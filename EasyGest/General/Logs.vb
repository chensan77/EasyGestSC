Imports System.IO

Namespace General

    Public Class Logs


        ' el archivo se llamar?  año-mes-dia.log
        Private _Archivo As String
        Private _Prefijo As String = ""
        Private _DirectorioLogs As String

        Public Property DirectorioLogs() As String
            Get
                Return Me._DirectorioLogs
            End Get
            Set(value As String)
                Me._DirectorioLogs = value
            End Set
        End Property

        Public Sub Iniciar(ByVal directorio As String)
            _DirectorioLogs = directorio
            ChequeaLogDir()
        End Sub

        Public Sub New(ByVal directorio As String, ByVal Prefijo As String)
            _Prefijo = Prefijo
            Iniciar(directorio)
        End Sub

        Public Sub New(ByVal directorio As String)
            Iniciar(directorio)
        End Sub

        Public Sub Cerrar()
            EscribirLog(Now, "-------------[ Fin de la Sesión ]-------------")
        End Sub

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub

        Public Function EscribirLog(ByVal fecha As DateTime, ByVal Cadena As String) As String
            _Archivo = DirectorioLogs & "\" & _Prefijo & Format(fecha, "yyyy-MM-dd") & ".log"
            Try
                Dim fs As New FileStream(_Archivo, FileMode.Append, FileAccess.Write)
                Dim s As New StreamWriter(fs)
                s.WriteLine(Format(fecha, "dd/MM/yyyy HH:mm:ss") & " - " & Cadena)
                s.Close()
                fs.Close()
                s = Nothing
                fs = Nothing
                Return Format(fecha, "dd/MM/yyyy HH:mm:ss") & " - " & Cadena

            Catch ex As Exception
                Return Format(fecha, "dd/MM/yyyy HH:mm:ss") & " - Error al escribir Logs en " & _Archivo & ": " & Cadena
            End Try

        End Function

        Public Function Escribirlog(ByVal cadena As String) As String
            Return Escribirlog(Now(), cadena)
        End Function

        Private Sub ChequeaLogDir()
            'Dim dire As Directory
            Dim archivos() As String
            Dim archivoInfo As FileInfo
            Dim fechaCota As Date = Now().AddMonths(-1)
            Dim fechaCreacionArchivo As Date
            Try
                If Not Directory.Exists(DirectorioLogs) Then
                    Directory.CreateDirectory(DirectorioLogs)
                    Return
                End If
            Catch ex As Exception
                Throw ex
            End Try
            archivos = Directory.GetFiles(DirectorioLogs, "*.log")
            For Each archivo As String In archivos
                archivoInfo = New FileInfo(archivo)
                fechaCreacionArchivo = archivoInfo.CreationTime()
                If fechaCreacionArchivo.CompareTo(fechaCota) < 0 Then ' si el archivo se ha creado hace mas de un mes, se borrar?
                    Try
                        archivoInfo.Delete()
                    Catch ex As Exception
                    Finally
                        archivoInfo = Nothing
                    End Try
                End If
            Next
        End Sub
    End Class

End Namespace
