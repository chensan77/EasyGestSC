Imports EasyGestControllers

Namespace Presentacion.Impresion
    Public Class TareaImpresion

        Public Delegate Sub ImpresionError(ByVal ex As Exception)

        Private _delegado As ImpresionError
        Private _tareas As New Dictionary(Of String, Object)

        Public Shared Sub EstablecerImpresora(impresora As String)
            RawTicketPrinterHelper.Impresora = impresora
        End Sub

        Public Shared Sub AbrirCajon()
            Dim secuencia As String()
            Dim sb As New System.Text.StringBuilder()

            If String.IsNullOrWhiteSpace(RawTicketPrinterHelper.Impresora) Then Return
            If String.IsNullOrWhiteSpace(gConfLocal.SecuenciaAperturaCajon) Then Return

            secuencia = gConfLocal.SecuenciaAperturaCajon.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
            For Each item As String In secuencia
                Dim code As Integer
                If Integer.TryParse(item, code) Then
                    sb.Append(Convert.ToChar(code))
                Else
                    sb.Append(item)
                End If
            Next
            Try
                RawTicketPrinterHelper.SendStringToPrinter(sb.ToString())
            Catch ex As Exception

            End Try
        End Sub

        Public Sub AddTarea(ByVal tarea As String, ByVal param As Object)
            If String.IsNullOrEmpty(tarea) Then Return
            _tareas.Add(tarea, param)
        End Sub

        Public Sub SetErrorDelegate(ByVal delegado As ImpresionError)
            _delegado = delegado
        End Sub

        Public Sub Imprimir()
            For Each item In _tareas
                Select Case item.Key.ToUpper()
                    Case Is = "VALE"
                        ImprimirVale(item.Value)
                    Case Is = "VALEDIRECTO"
                        ImprimirValeDirecto(item.Value)
                    Case Is = "TICKET"
                        ImprimirTicket(item.Value)
                End Select
                Threading.Thread.Sleep(500)
            Next
            _tareas.Clear()
        End Sub

        Public Sub ImprimirVale(ByVal param As Object)
            'Dim archivo As String = System.IO.Path.GetFullPath(Application.StartupPath) & "\Informe\rptVales.mr6"
            'Dim report As New Report()
            'Dim vale As Data.Entity.VWVales = DirectCast(param, Data.Entity.VWVales)
            'Dim label As NeoDataType.MyNeoReport.Label
            'If Not gParametros.ContainsKey(CONFG_IMPRESORATICKET & gCaja.idCaja) Then Return
            'Try
            '    If System.IO.File.Exists(archivo) Then
            '        report.LoadFrom(archivo)
            '        label = report.Page.PageHeader.Items("lblFechaEmision")
            '        label.Text = vale.FechaEmision.ToString("g")
            '        label = report.Page.PageHeader.Items("lblFechaValido")
            '        If vale.FechaValidez.HasValue Then
            '            label.Text = vale.FechaValidez.Value.ToString("d")
            '        Else
            '            label.Text = "Sin Fecha"
            '        End If
            '        label = report.Page.PageHeader.Items("lblImporte")
            '        label.Text = FormatCurrency(vale.Importe, 2)
            '        label = report.Page.PageHeader.Items("lblCliente")
            '        If vale.idCliente.HasValue Then
            '            label.Text = vale.idCliente.Value.ToString().PadLeft(4, "0") & " - " & vale.Nombre
            '        Else
            '            label.Text = "-----------------"
            '        End If
            '        label = report.Page.PageHeader.Items("lblEAN")
            '        label.Text = "*" & vale.Numero & "*"
            '        label = report.Page.PageHeader.Items("lblNumeroVale")
            '        label.Text = vale.Numero

            '        report.PrinterSettings.PrinterName = gParametros(CONFG_IMPRESORATICKET & gCaja.idCaja)
            '        report.Print()
            '        report = Nothing
            '    Else
            '        If _delegado IsNot Nothing Then _delegado.Invoke(New Exception("No se encuentra el archivo de definición de report"))
            '    End If
            'Catch ex As Exception
            '    If _delegado IsNot Nothing Then _delegado.Invoke(ex)
            'End Try
        End Sub

        Public Sub ImprimirValeDirecto(ByVal param As Object)
            Dim vale As Data.Entity.VWVales = DirectCast(param, Data.Entity.VWVales)
            Dim fechavalidez As String = "Sin Fecha"

            If String.IsNullOrWhiteSpace(RawTicketPrinterHelper.Impresora) Then Return
            Try
                If vale IsNot Nothing Then
                    'RawTicketPrinterHelper.EstablecerTablaCaracter(16)
                    RawTicketPrinterHelper.AlineacionTexto(RawTicketPrinterHelper.EnumAlineacion.CENTRADA)
                    RawTicketPrinterHelper.EstablecerFuente(RawTicketPrinterHelper.EnumTicketFormato.NEGRITA Or RawTicketPrinterHelper.EnumTicketFormato.DOBLEALTURA)
                    RawTicketPrinterHelper.ImprimirLinea("VALE DE COMPRA")
                    RawTicketPrinterHelper.AvanzarLinea(1)
                    RawTicketPrinterHelper.AlineacionTexto(RawTicketPrinterHelper.EnumAlineacion.IZQUIERDA)
                    RawTicketPrinterHelper.EstablecerFuente(RawTicketPrinterHelper.EnumTicketFormato.CPP10)
                    RawTicketPrinterHelper.ImprimirLinea("Numero: " & vale.Numero)
                    RawTicketPrinterHelper.ImprimirLinea("Fecha emision: " & vale.FEmision.ToString("g"))
                    If vale.FValidez.HasValue() Then fechavalidez = vale.FValidez.Value.ToString("d")
                    RawTicketPrinterHelper.ImprimirLinea("Fecha validez: " & fechavalidez)
                    If vale.idCliente.HasValue Then
                        RawTicketPrinterHelper.ImprimirLinea("Propietario:   " & vale.idCliente.Value.ToString().PadLeft(4, "0"c) & " - " & vale.Cliente)
                    End If
                    RawTicketPrinterHelper.AvanzarLinea(1)
                    RawTicketPrinterHelper.EstablecerFuente(RawTicketPrinterHelper.EnumTicketFormato.NEGRITA Or RawTicketPrinterHelper.EnumTicketFormato.DOBLEALTURA)
                    RawTicketPrinterHelper.ImprimirLinea("Importe: " & FormatNumber(vale.Importe, 2) & " Euros")
                    RawTicketPrinterHelper.AvanzarLinea(1)
                    RawTicketPrinterHelper.EstablecerFuente(RawTicketPrinterHelper.EnumTicketFormato.CPP10)
                    RawTicketPrinterHelper.ImprimirLinea("Firma y/o sello del comercio:")
                    RawTicketPrinterHelper.AlineacionTexto(RawTicketPrinterHelper.EnumAlineacion.CENTRADA)
                    RawTicketPrinterHelper.ImprimirLinea("**********************************")
                    RawTicketPrinterHelper.AvanzarLinea(8)
                    RawTicketPrinterHelper.ImprimirLinea("**********************************")
                    RawTicketPrinterHelper.EstablecerFuente(RawTicketPrinterHelper.EnumTicketFormato.CPP12)
                    RawTicketPrinterHelper.ImprimirLinea("Sin la firma y/o sello este vale carece la validez.")
                    RawTicketPrinterHelper.ImprimirLinea("Ni tampoco una vez pasado la fecha de validez si proceda.")
                    RawTicketPrinterHelper.ImprimirBarra(vale.Numero.ToString())
                    RawTicketPrinterHelper.AvanzarLinea(5)
                    RawTicketPrinterHelper.CortarTicket()
                    RawTicketPrinterHelper.AvanzarLinea(2)
                End If
            Catch ex As Exception
                If _delegado IsNot Nothing Then _delegado.Invoke(ex)
            End Try
        End Sub

        'Public Sub ImprimirTicket(ByVal param As Object)
        '    Dim cliente As Data.Entity.Clientes = Nothing
        '    Dim listaLineas As IEnumerable(Of Data.Entity.VWLineasAlbaran)
        '    'Dim anchoCantidad As Integer = 3
        '    Dim anchoDescripcion As Integer = 34
        '    Dim anchoImporte As Integer = 6
        '    Dim anchoLineaNormal As Integer = 40
        '    'Dim anchoLineaComprimido As Integer = 33
        '    Dim linea As String
        '    Dim totalCantidad As Integer
        '    Dim objs As Object() = DirectCast(param, Object())
        '    Dim albaran As Data.Entity.Albaranes = DirectCast(objs(0), Data.Entity.Albaranes)
        '    Dim total As Double = DirectCast(objs(1), Double)
        '    Dim entregado As Double = DirectCast(objs(2), Double)
        '    'Dim abrirCajon As Boolean = DirectCast(objs(3), Boolean)
        '    If Not gParametros.ContainsKey(CONFG_IMPRESORATICKET & gCaja.idCaja) Then Return
        '    Try
        '        If albaran.idCliente IsNot Nothing Then
        '            Using control As New Controlador.ClientesController()
        '                cliente = control.GetItem(albaran.idCliente)
        '            End Using
        '        End If
        '        Using control As New Controlador.LineasAlbaranController()
        '            listaLineas = control.GetItems(Of Data.Entity.VWLineasAlbaran)("idAlbaran = " & albaran.idAlbaran)
        '        End Using
        '        totalCantidad = listaLineas.Sum(Function(l As Data.Entity.VWLineasAlbaran) l.Cantidad)
        '    Catch ex As Exception
        '        If _delegado IsNot Nothing Then _delegado.Invoke(ex)
        '        Return
        '    End Try

        '    Try
        '        RawTicketPrinterHelper.Impresora = gParametros(CONFG_IMPRESORATICKET & gCaja.idCaja)
        '        RawTicketPrinterHelper.EstablecerTablaCaracter(16)
        '        RawTicketPrinterHelper.AlineacionTexto(RawTicketPrinterHelper.EnumAlineacion.CENTRADA)
        '        RawTicketPrinterHelper.EstablecerFuente(RawTicketPrinterHelper.EnumTicketFormato.NEGRITA Or RawTicketPrinterHelper.EnumTicketFormato.DOBLEALTURA)
        '        RawTicketPrinterHelper.ImprimirLinea(gEmpresa.Empresa)
        '        RawTicketPrinterHelper.AvanzarLinea(1)
        '        RawTicketPrinterHelper.EstablecerFuente(RawTicketPrinterHelper.EnumTicketFormato.CPP10)
        '        linea = "NIF: " & gEmpresa.NIF & "    Tlf.: " & gEmpresa.Telefono
        '        RawTicketPrinterHelper.ImprimirLinea(linea)
        '        linea = albaran.FechaAlbaran.ToString() & "  Caja: " & gCaja.Caja
        '        RawTicketPrinterHelper.ImprimirLinea(linea)
        '        linea = albaran.NumAlbaran & "  * IVA INCLUIDO"
        '        RawTicketPrinterHelper.ImprimirLinea(linea)
        '        'RawTicketPrinterHelper.AvanzarLinea(2)
        '        If cliente IsNot Nothing Then
        '            RawTicketPrinterHelper.AvanzarLinea(1)
        '            RawTicketPrinterHelper.AlineacionTexto(RawTicketPrinterHelper.EnumAlineacion.IZQUIERDA)
        '            linea = "CLIENTE: " & cliente.NombreYNombreCN
        '            RawTicketPrinterHelper.ImprimirLinea(linea)
        '            linea = "Núm: " & cliente.idCliente.ToString.PadLeft(5, "0")
        '            RawTicketPrinterHelper.ImprimirLinea(linea)
        '            If Not String.IsNullOrEmpty(cliente.Identificacion) Then
        '                RawTicketPrinterHelper.ImprimirLinea(cliente.Identificacion)
        '            End If
        '            If Not String.IsNullOrEmpty(cliente.Direccion) Then
        '                RawTicketPrinterHelper.ImprimirLinea(cliente.Direccion)
        '            End If
        '            linea = ""
        '            If Not String.IsNullOrEmpty(cliente.CodigoPostal) Then linea = cliente.CodigoPostal & " "
        '            If Not String.IsNullOrEmpty(cliente.Localidad) Then linea = cliente.Localidad & " "
        '            If Not String.IsNullOrEmpty(linea) Then
        '                RawTicketPrinterHelper.ImprimirLinea(linea)
        '            End If
        '            If Not String.IsNullOrEmpty(cliente.Provincia) Then
        '                RawTicketPrinterHelper.ImprimirLinea(cliente.Provincia)
        '            End If
        '        End If
        '        RawTicketPrinterHelper.AlineacionTexto(RawTicketPrinterHelper.EnumAlineacion.CENTRADA)
        '        linea = "=".PadLeft(32, "=")
        '        RawTicketPrinterHelper.ImprimirLinea(linea)
        '        'RawTicketPrinterHelper.EstablecerFuente(RawTicketPrinterHelper.EnumTicketFormato.CPP12)
        '        For Each item In listaLineas
        '            'linea = item.Cantidad.ToString().PadRight(anchoCantidad, " "c)
        '            linea = ""
        '            If item.DescripcionProducto.Length > anchoDescripcion Then
        '                linea &= item.DescripcionProducto.Substring(0, anchoDescripcion - 3) & "..."
        '            Else
        '                linea &= item.DescripcionProducto.PadRight(anchoDescripcion, " "c)
        '            End If
        '            linea &= FormatNumber(item.Importe, 2).PadLeft(anchoImporte, " "c)
        '            RawTicketPrinterHelper.ImprimirLinea(linea)
        '            If Math.Abs(item.Cantidad) <> 1 Then
        '                linea = (item.Cantidad.ToString() & " X " & FormatNumber(item.Precio, 2)).PadRight(anchoDescripcion + anchoImporte)
        '                RawTicketPrinterHelper.ImprimirLinea(linea)
        '            End If
        '        Next
        '        RawTicketPrinterHelper.AlineacionTexto(RawTicketPrinterHelper.EnumAlineacion.CENTRADA)
        '        'RawTicketPrinterHelper.EstablecerFuente(RawTicketPrinterHelper.EnumTicketFormato.CPP10)
        '        linea = "=".PadLeft(32, "=")
        '        RawTicketPrinterHelper.ImprimirLinea(linea)
        '        RawTicketPrinterHelper.AlineacionTexto(RawTicketPrinterHelper.EnumAlineacion.DERECHA)
        '        linea = "Num. art.:" & totalCantidad.ToString().PadLeft(anchoImporte + 3, " "c)
        '        RawTicketPrinterHelper.ImprimirLinea(linea)
        '        linea = "Total:" & FormatNumber(total, 2).PadLeft(anchoImporte + 3, " "c)
        '        RawTicketPrinterHelper.ImprimirLinea(linea)
        '        linea = "Entrega:" & FormatNumber(entregado, 2).PadLeft(anchoImporte + 3, " "c)
        '        RawTicketPrinterHelper.ImprimirLinea(linea)
        '        linea = "Cambio:" & FormatNumber(entregado - total, 2).PadLeft(anchoImporte + 3, " "c)
        '        RawTicketPrinterHelper.ImprimirLinea(linea)
        '        RawTicketPrinterHelper.AlineacionTexto(RawTicketPrinterHelper.EnumAlineacion.CENTRADA)
        '        linea = "-".PadLeft(32, "-")
        '        RawTicketPrinterHelper.ImprimirLinea(linea)
        '        RawTicketPrinterHelper.AvanzarLinea(1)
        '        RawTicketPrinterHelper.ImprimirLinea("Gracias por su visita!")
        '        RawTicketPrinterHelper.AvanzarLinea(1)
        '        RawTicketPrinterHelper.ImprimirLinea("Para cualq. devol. es necesaria")
        '        RawTicketPrinterHelper.ImprimirLinea("la presentacion de este ticket")
        '        RawTicketPrinterHelper.ImprimirLinea("Devolucion valida durante 15 dias")
        '        RawTicketPrinterHelper.ImprimirLinea("desde la fecha de compra")
        '        RawTicketPrinterHelper.AvanzarLinea(5)
        '        RawTicketPrinterHelper.CortarTicket()
        '        RawTicketPrinterHelper.AvanzarLinea(2)
        '    Catch ex As Exception
        '        If _delegado IsNot Nothing Then _delegado.Invoke(ex)
        '    End Try

        'End Sub

        Public Sub ImprimirTicket(ByVal param As Object)
            If String.IsNullOrWhiteSpace(RawTicketPrinterHelper.Impresora) Then Return

            Dim cliente As Data.Entity.Clientes = Nothing
            Dim listaLineas As IEnumerable(Of Data.Entity.VWLineasAlbaran)
            'Dim anchoCantidad As Integer = 3
            Dim anchoImporte As Integer = 6
            Dim anchoLineaNormal As Integer = gConfLocal.ImpresoraTicketNumCaracteres
            Dim anchoDescripcion As Integer = anchoLineaNormal - anchoImporte
            'Dim anchoLineaComprimido As Integer = 33
            Dim linea As String
            Dim totalCantidad As Single
            Dim objs As Object() = DirectCast(param, Object())
            Dim albaran As Data.Entity.VWAlbaranes = DirectCast(objs(0), Data.Entity.VWAlbaranes)
            Dim total As Double = DirectCast(objs(1), Double)
            Dim entregado As Double = DirectCast(objs(2), Double)
            'Dim abrirCajon As Boolean = DirectCast(objs(3), Boolean)

            Try
                If albaran.idCliente IsNot Nothing Then
                    Using control As New ClientesController()
                        cliente = control.GetItem(albaran.idCliente)
                    End Using
                End If
                Using control As New LineasAlbaranController()
                    listaLineas = control.GetItems(Of Data.Entity.VWLineasAlbaran)("idAlbaran = " & albaran.idAlbaran)
                End Using
                totalCantidad = listaLineas.Sum(Function(l As Data.Entity.VWLineasAlbaran) l.Cantidad)
            Catch ex As Exception
                If _delegado IsNot Nothing Then _delegado.Invoke(ex)
                Return
            End Try

            Try
                RawTicketPrinterHelper.EstablecerTablaCaracter(16)
                RawTicketPrinterHelper.AlineacionTexto(RawTicketPrinterHelper.EnumAlineacion.CENTRADA)
                RawTicketPrinterHelper.EstablecerFuente(RawTicketPrinterHelper.EnumTicketFormato.NEGRITA Or RawTicketPrinterHelper.EnumTicketFormato.DOBLEALTURA)
                RawTicketPrinterHelper.ImprimirLinea(gEmpresa.NombreComercial)
                RawTicketPrinterHelper.AvanzarLinea(1)
                RawTicketPrinterHelper.EstablecerFuente(RawTicketPrinterHelper.EnumTicketFormato.CPP10)
                linea = "R.Social: " & gEmpresa.Empresa
                RawTicketPrinterHelper.ImprimirLinea(linea)
                linea = "NIF: " & gEmpresa.NIF & "    Tlf.: " & gEmpresa.Telefono
                RawTicketPrinterHelper.ImprimirLinea(linea)
                linea = albaran.FAlbaran.ToString() & "  Puesto: " & gPuesto.Puesto
                RawTicketPrinterHelper.ImprimirLinea(linea)
                linea = albaran.NumAlbaran & "  * IVA INCLUIDO"
                RawTicketPrinterHelper.ImprimirLinea(linea)
                'RawTicketPrinterHelper.AvanzarLinea(2)
                If cliente IsNot Nothing Then
                    RawTicketPrinterHelper.AvanzarLinea(1)
                    RawTicketPrinterHelper.AlineacionTexto(RawTicketPrinterHelper.EnumAlineacion.IZQUIERDA)
                    linea = "CLIENTE: " & cliente.NombreYNombreCN
                    RawTicketPrinterHelper.ImprimirLinea(linea)
                    linea = "Núm: " & cliente.idCliente.ToString.PadLeft(5, "0"c)
                    RawTicketPrinterHelper.ImprimirLinea(linea)
                    If Not String.IsNullOrEmpty(cliente.Identificacion) Then
                        RawTicketPrinterHelper.ImprimirLinea(cliente.Identificacion)
                    End If
                    If Not String.IsNullOrEmpty(cliente.Direccion) Then
                        RawTicketPrinterHelper.ImprimirLinea(cliente.Direccion)
                    End If
                    linea = ""
                    If Not String.IsNullOrEmpty(cliente.CodigoPostal) Then linea = cliente.CodigoPostal & " "
                    If Not String.IsNullOrEmpty(cliente.Localidad) Then linea = cliente.Localidad & " "
                    If Not String.IsNullOrEmpty(linea) Then
                        RawTicketPrinterHelper.ImprimirLinea(linea)
                    End If
                    If Not String.IsNullOrEmpty(cliente.Provincia) Then
                        RawTicketPrinterHelper.ImprimirLinea(cliente.Provincia)
                    End If
                End If
                RawTicketPrinterHelper.AlineacionTexto(RawTicketPrinterHelper.EnumAlineacion.CENTRADA)
                linea = "=".PadLeft(32, "="c)
                RawTicketPrinterHelper.ImprimirLinea(linea)
                'RawTicketPrinterHelper.EstablecerFuente(RawTicketPrinterHelper.EnumTicketFormato.CPP12)
                For Each item In listaLineas
                    'linea = item.Cantidad.ToString().PadRight(anchoCantidad, " "c)
                    linea = ""
                    If item.DescripcionProducto.Length > anchoDescripcion Then
                        linea &= item.DescripcionProducto.Substring(0, anchoDescripcion - 3) & "..."
                    Else
                        linea &= item.DescripcionProducto.PadRight(anchoDescripcion, " "c)
                    End If
                    linea &= FormatNumber(item.Importe, 2).PadLeft(anchoImporte, " "c)
                    RawTicketPrinterHelper.ImprimirLinea(linea)
                    If Math.Abs(item.Cantidad) <> 1 Then
                        linea = (FormatNumber(item.Cantidad, 2) & " X " & FormatNumber(item.Precio, 2)).PadRight(anchoDescripcion + anchoImporte)
                        RawTicketPrinterHelper.ImprimirLinea(linea)
                    End If
                Next
                RawTicketPrinterHelper.AlineacionTexto(RawTicketPrinterHelper.EnumAlineacion.CENTRADA)
                'RawTicketPrinterHelper.EstablecerFuente(RawTicketPrinterHelper.EnumTicketFormato.CPP10)
                linea = "=".PadLeft(32, "="c)
                RawTicketPrinterHelper.ImprimirLinea(linea)
                RawTicketPrinterHelper.AlineacionTexto(RawTicketPrinterHelper.EnumAlineacion.DERECHA)
                linea = "Num. art.:" & totalCantidad.ToString().PadLeft(anchoImporte + 3, " "c)
                RawTicketPrinterHelper.ImprimirLinea(linea)
                linea = "Total:" & FormatNumber(total, 2).PadLeft(anchoImporte + 3, " "c)
                RawTicketPrinterHelper.ImprimirLinea(linea)
                linea = "Entrega:" & FormatNumber(entregado, 2).PadLeft(anchoImporte + 3, " "c)
                RawTicketPrinterHelper.ImprimirLinea(linea)
                linea = "Cambio:" & FormatNumber(entregado - total, 2).PadLeft(anchoImporte + 3, " "c)
                RawTicketPrinterHelper.ImprimirLinea(linea)
                linea = "Forma de pago: " & albaran.ModoPagoEsp
                RawTicketPrinterHelper.ImprimirLinea(linea)
                RawTicketPrinterHelper.AlineacionTexto(RawTicketPrinterHelper.EnumAlineacion.CENTRADA)
                linea = "-".PadLeft(32, "-"c)
                RawTicketPrinterHelper.ImprimirLinea(linea)
                RawTicketPrinterHelper.AvanzarLinea(1)
                RawTicketPrinterHelper.ImprimirLinea("Gracias por su visita!")
                RawTicketPrinterHelper.AvanzarLinea(1)
                RawTicketPrinterHelper.ImprimirLinea("Para cualq. devol. es necesaria")
                RawTicketPrinterHelper.ImprimirLinea("la presentacion de este ticket")
                RawTicketPrinterHelper.ImprimirLinea("Devolucion valida durante 15 dias")
                RawTicketPrinterHelper.ImprimirLinea("desde la fecha de compra")
                RawTicketPrinterHelper.AvanzarLinea(5)
                RawTicketPrinterHelper.CortarTicket()
                RawTicketPrinterHelper.AvanzarLinea(2)
            Catch ex As Exception
                If _delegado IsNot Nothing Then _delegado.Invoke(ex)
            End Try

        End Sub

    End Class

End Namespace
