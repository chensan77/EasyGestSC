Imports System
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.IO

Namespace Presentacion.Impresion


    Friend Class RawTicketPrinterHelper


        Public Shared _impresora As String


        Public Enum EnumTicketFormato
            CPP10 = 0
            CPP12 = 1
            PROPORCIONAL = 2
            COMPRIMIDO = 4
            NEGRITA = 8
            DOBLEALTURA = 16
            DOBLEANCHURA = 32
            CURSIVA = 64
            SUBRAYADO = 128
        End Enum

        Public Enum EnumAlineacion
            IZQUIERDA = 0
            CENTRADA = 1
            DERECHA = 2
        End Enum


        Public Declare Function OpenPrinter Lib "winspool.Drv" Alias "OpenPrinterA" (ByVal szPrinter As String, ByRef hPrinter As IntPtr, ByVal pd As IntPtr) As Boolean

        Public Declare Function ClosePrinter Lib "winspool.Drv" Alias "ClosePrinter" (ByVal hPrinter As IntPtr) As Boolean

        Public Declare Function StartDocPrinter Lib "winspool.Drv" Alias "StartDocPrinterA" (ByVal hPrinter As IntPtr, ByVal level As Int32, ByVal di As DOCINFOA) As Boolean

        Public Declare Function EndDocPrinter Lib "winspool.Drv" Alias "EndDocPrinter" (ByVal hPrinter As IntPtr) As Boolean

        Public Declare Function StartPagePrinter Lib "winspool.Drv" Alias "StartPagePrinter" (ByVal hPrinter As IntPtr) As Boolean

        Public Declare Function EndPagePrinter Lib "winspool.Drv" Alias "EndPagePrinter" (ByVal hPrinter As IntPtr) As Boolean

        Public Declare Function WritePrinter Lib "winspool.Drv" Alias "WritePrinter" (ByVal hPrinter As IntPtr, ByVal pBytes As IntPtr, ByVal dwCount As Int32, ByRef dwWritten As Int32) As Boolean


        Public Shared Property Impresora() As String
            Get
                Return _impresora
            End Get
            Set(ByVal value As String)
                _impresora = value
            End Set
        End Property

        ' SendBytesToPrinter()
        ' When the function is given a printer name and an unmanaged array
        ' of bytes, the function sends those bytes to the print queue.
        ' Returns true on success, false on failure.
        Public Shared Function SendBytesToPrinter(ByVal szPrinterName As String, ByVal pBytes As IntPtr, ByVal dwCount As Int32) As Boolean
            Dim dwWritten As Int32 = 0
            Dim dwError As Int32 = 0
            Dim hPrinter As IntPtr = New IntPtr(0)
            Dim di As DOCINFOA = New DOCINFOA
            Dim bSuccess As Boolean = False
            ' Assume failure unless you specifically succeed.
            di.pDocName = "RAW Doc"
            di.pDataType = "RAW"
            ' Open the printer.
            If OpenPrinter(szPrinterName.Normalize, hPrinter, IntPtr.Zero) Then
                ' Start a document.
                If StartDocPrinter(hPrinter, 1, di) Then
                    ' Start a page.
                    If StartPagePrinter(hPrinter) Then
                        ' Write your bytes.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, dwWritten)
                        EndPagePrinter(hPrinter)
                    End If
                    EndDocPrinter(hPrinter)
                End If
                ClosePrinter(hPrinter)
            End If
            ' If you did not succeed, GetLastError may give more information
            ' about why not.
            If (bSuccess = False) Then
                dwError = Marshal.GetLastWin32Error
            End If
            Return bSuccess
        End Function

        Public Shared Function SendFileToPrinter(ByVal szPrinterName As String, ByVal szFileName As String) As Boolean
            ' Open the file.
            Dim fs As FileStream = New FileStream(szFileName, FileMode.Open)
            ' Create a BinaryReader on the file.
            Dim br As BinaryReader = New BinaryReader(fs)
            ' Dim an array of bytes big enough to hold the file's contents.
            Dim bytes(CInt(fs.Length)) As Byte
            Dim bSuccess As Boolean = False
            ' Your unmanaged pointer.
            Dim pUnmanagedBytes As IntPtr = New IntPtr(0)
            Dim nLength As Integer
            nLength = Convert.ToInt32(fs.Length)
            ' Read the contents of the file into the array.
            bytes = br.ReadBytes(nLength)
            ' Allocate some unmanaged memory for those bytes.
            pUnmanagedBytes = Marshal.AllocCoTaskMem(nLength)
            ' Copy the managed byte array into the unmanaged array.
            Marshal.Copy(bytes, 0, pUnmanagedBytes, nLength)
            ' Send the unmanaged bytes to the printer.
            bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, nLength)
            ' Free the unmanaged memory that you allocated earlier.
            Marshal.FreeCoTaskMem(pUnmanagedBytes)
            Return bSuccess
        End Function

        Public Shared Function SendStringToPrinter(ByVal szString As String) As Boolean
            Dim pBytes As IntPtr
            Dim dwCount As Int32
            szString = ConvertirA850(szString)
            ' How many characters are in the string?
            dwCount = szString.Length
            ' Assume that the printer is expecting ANSI text, and then convert
            ' the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString)
            ' Send the converted ANSI string to the printer.
            SendBytesToPrinter(Impresora, pBytes, dwCount)
            Marshal.FreeCoTaskMem(pBytes)
            Return True
        End Function

        Private Shared Function ConvertirA850(ByVal cadena As String) As String
            Dim resultado As String
            Dim targetEncoding As Encoding
            Dim encodedChars() As Byte

            ' Gets the encoding for the specified code page.
            targetEncoding = Encoding.GetEncoding(850)

            ' Gets the byte representation of the specified string.
            encodedChars = targetEncoding.GetBytes(cadena)

            ' Prints the bytes.
            'Debug.Print("Byte representation of '{0}' in CP '{1}':", _
            '   Str, codePage)
            Dim i As Integer
            resultado = ""
            For i = 0 To encodedChars.Length - 1
                'Debug.Print("Byte {0}: {1}", i, encodedChars(i))
                resultado = resultado & Chr(encodedChars(i))
            Next i
            Return resultado
        End Function

        Public Shared Sub EstablecerTablaCaracter(ByVal code As Integer)
            SendStringToPrinter(Convert.ToChar(27) & "t" & Convert.ToChar(code))
        End Sub

        Public Shared Sub ImprimirBarra(ByVal cadena As String)
            SendStringToPrinter(Convert.ToChar(29) & "w" & Convert.ToChar(2))
            SendStringToPrinter(Convert.ToChar(29) & "h" & Convert.ToChar(75))
            SendStringToPrinter(Convert.ToChar(29) & "k" & Convert.ToChar(4) & cadena & Convert.ToChar(0))
        End Sub


        Public Shared Sub AbrirCajon()
            SendStringToPrinter(Convert.ToChar(27) & "p" & Convert.ToChar(0) & Convert.ToChar(25) & Convert.ToChar(250))
        End Sub

        Public Shared Sub EstablecerFuente(ByVal formato As Integer)
            SendStringToPrinter(Convert.ToChar(27) & "!" & Convert.ToChar(formato))
        End Sub

        Public Shared Sub ImprimirLinea(ByVal linea As String)
            If linea IsNot Nothing Then _
                SendStringToPrinter(linea & ControlChars.Cr & ControlChars.Lf)
        End Sub

        Public Shared Sub AlineacionTexto(ByVal alineacion As Integer)
            SendStringToPrinter(Convert.ToChar(27) & "a" & Convert.ToChar(alineacion))
        End Sub

        Public Shared Sub CortarTicket()
            SendStringToPrinter(Convert.ToChar(27) & "m")
        End Sub

        Public Shared Sub AvanzarLinea(ByVal num As Integer)
            SendStringToPrinter(Convert.ToChar(27) & "d" & Convert.ToChar(num))
        End Sub

        ' Structure and API declarions:
        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)> _
        Public Class DOCINFOA

            <MarshalAs(UnmanagedType.LPStr)> _
            Public pDocName As String

            <MarshalAs(UnmanagedType.LPStr)> _
            Public pOutputFile As String

            <MarshalAs(UnmanagedType.LPStr)> _
            Public pDataType As String
        End Class
    End Class
End Namespace