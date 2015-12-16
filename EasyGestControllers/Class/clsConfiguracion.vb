Imports System.Reflection

Namespace Data.Configuracion

    Public Enum TipoDocumentoVentaEnum
        Ticket = 0
        Albaran = 1
    End Enum

    Public Enum MomentoAperturaCajonEnum
        AnteMostrarCobro = 0
        DespuesAceptarCobro = 1
        NoAbrir = 2
    End Enum

    Public Enum TipoFidelizacionEnum
        Saldo = 0
        Punto = 1
    End Enum

    Public Class ConfiguracionLocal

        Public Property UsarCajon As Boolean = True
        Public Property SecuenciaAperturaCajon As String = "27 p m 25 200"
        Public Property ImpresoraXDefecto As String = Nothing
        Public Property ImpresoraTicket As String = Nothing
        Public Property AtajoAperturaCajon As String = "CTRL+F12"
        Public Property DepositoCaja As Single = 100.0
        Public Property DbUsuario As String = Nothing
        Public Property DbContrasña As String = Nothing
        Public Property DbServidor As String = Nothing
        Public Property DbCatalogo As String = Nothing
        Public Property DbAuxiliar As String = Nothing
        Public Property PuestoID As Long? = Nothing
        Public Property DiarioID As Long? = Nothing
        Public Property NumRegXPagina As Integer = 50
        Public Property PeriodoActualizacionInicio As Single = 60 ' en segundos
        Public Property MomentoAperturaCajon As MomentoAperturaCajonEnum = MomentoAperturaCajonEnum.DespuesAceptarCobro
        Public Property UltimoSerieUsado As String = ""
        Public Property ImpresoraTicketNumCaracteres As Integer = 40
        Public Property PeriodoActualizacionDivisa As Single = 6.0
        Public Property PeriodoActualizacionMeteologia As Single = 6.0
        Public Property MostrarInicioArranque As Boolean = True
        Public Property UsarCuchilloCorteImpresora As Boolean = True

        Public Sub New()
            Dim impresora As New System.Drawing.Printing.PrinterSettings()

            Try
                ImpresoraXDefecto = impresora.PrinterName
            Catch ex As System.Exception
                ImpresoraXDefecto = ""
            Finally
                impresora = Nothing
            End Try
        End Sub

        Public Shared Function LeerConfiguracion() As ConfiguracionLocal
            Dim conf As New ConfiguracionLocal()
            Dim tipoConf As Type = GetType(ConfiguracionLocal)
            Dim propiedades As PropertyInfo() = tipoConf.GetProperties(BindingFlags.Public Or BindingFlags.Instance)
            Dim valor As String
            For Each propiedad As PropertyInfo In propiedades
                Try
                    valor = Util.Comunes.GetRegistryValue(propiedad.Name)
                    If Not IsNothing(valor) Then
                        propiedad.SetValue(conf, Conversion.CTypeDynamic(valor, propiedad.PropertyType), Nothing)
                    End If
                Catch ex As Exception
                    'Throw ex
                End Try
            Next
            Return conf
        End Function

        Public Shared Sub EscribirConfiguracion(ByVal conf As ConfiguracionLocal)
            Dim tipoConf As Type = GetType(ConfiguracionLocal)
            Dim propiedades As PropertyInfo() = tipoConf.GetProperties(BindingFlags.Public Or BindingFlags.Instance)
            Dim valor As String
            For Each propiedad As PropertyInfo In propiedades
                Try                    
                    If propiedad.PropertyType.IsEnum Then
                        valor = CStr(CInt(propiedad.GetValue(conf, Nothing)))
                    Else
                        valor = CStr(propiedad.GetValue(conf, Nothing))
                    End If
                    If IsNothing(valor) Then valor = ""
                    Util.Comunes.SetRegistryValue(propiedad.Name, valor)
                Catch ex As Exception

                End Try
            Next

        End Sub



    End Class

    Public Class ConfiguracionGlobal

        Public Property ImpuestoIncluidoPrecio As Boolean = False
        Public Property ImprimirSiempreVenta As Boolean = False
        Public Property PorcentajeGanancia As Single = 0.0
        Public Property DocumentoVenta As TipoDocumentoVentaEnum = TipoDocumentoVentaEnum.Albaran
        Public Property FacturarSiempreVenta As Boolean = False
        Public Property NombreImpuesto As String = "IVA"
        Public Property AvisarPrecioCero As Boolean = False
        Public Property PermitirCrearProducto As Boolean = True
        Public Property ClaveAdministrador As String = "1234"
        Public Property UsarDecimalCantidad As Boolean = False
        Public Property ValidezVale As Short = 0
        Public Property ValidezAlbaran As Short = 0
        Public Property IndiceCorrectorVenta As Single = 0.0
        Public Property UsarTarjetaFidelizacion As Boolean = False
        Public Property ModoFidelizacion As TipoFidelizacionEnum = TipoFidelizacionEnum.Saldo
        Public Property Autentificar As Boolean = False
        Public Property FormulaFidelizacion As String = ""
        Public Property FidelizacionModoGlobal As Boolean = True
        Public Property ValidezBeneficioFidelizacion As Integer = 8
        Public Property PermitirGastoFidelizacionParcial As Boolean = True
        Public Property PeriodoEmisionValeFidelizacion As Short = 4
        Public Property CuantiaMinimoEmisionValeFidelizacion As Single = 0.0
        Public Property UsarImpuestoCompra As Boolean = True
        Public Property ControlCaja As Boolean = True
        Public Property RecargoIncluidoPrecio As Boolean = False
        Public Property ControlStock As Boolean = True
        Public Property PeriodoObtencionTarea As Integer = 7

        Public ReadOnly Property PorcentajeBeneficioFidelizacion As Single
            Get
                If String.IsNullOrWhiteSpace(FormulaFidelizacion) Then
                    Return 0.0F
                Else
                    Dim relac As Single = 0.0F
                    Dim base, beneficio, basepunto, equivalente As Single
                    InterpretarFormulaFidelizacion(base, beneficio, basepunto, equivalente)
                    If base > 0.0F Then
                        relac = equivalente / basepunto
                    End If
                    Return relac
                End If
            End Get
        End Property

        Public ReadOnly Property RelacionPuntoEuroFidelizacion As Single
            Get
                If String.IsNullOrWhiteSpace(FormulaFidelizacion) Or ModoFidelizacion = TipoFidelizacionEnum.Saldo Then
                    Return 0.0F
                Else
                    Dim porc As Single = 0.0F
                    Dim base, beneficio, basepunto, equivalente As Single
                    InterpretarFormulaFidelizacion(base, beneficio, basepunto, equivalente)
                    If base > 0.0F Then
                        porc = beneficio / base
                    End If
                    Return porc
                End If
            End Get
        End Property


        Public Sub BuidFormulaFidelizacion(base As Single, beneficio As Single, Optional basePunto As Single = 0.0F, Optional equivalente As Single = 0.0F)
            FormulaFidelizacion = String.Format("{0:N2}/{1:N2};{2:N2}/{3:N2}", base, beneficio, basePunto, equivalente)
        End Sub

        Public Sub InterpretarFormulaFidelizacion(ByRef base As Single, ByRef beneficio As Single, ByRef basePunto As Single, ByRef equivalente As Single)
            Try
                Util.Comunes.InterpretarFormulaFidelizacion(FormulaFidelizacion, base, beneficio, basePunto, equivalente)
            Catch ex As Exception
            End Try
        End Sub

        Public Shared Function CargarConfiguracion(ByVal infoConf As List(Of Data.Entity.Configuraciones)) As ConfiguracionGlobal
            Dim conf As New ConfiguracionGlobal()
            Dim tipoConf As Type = GetType(ConfiguracionGlobal)
            Dim propiedad As PropertyInfo

            For Each info As Data.Entity.Configuraciones In infoConf
                Try
                    propiedad = tipoConf.GetProperty(info.Parametro, BindingFlags.Instance Or BindingFlags.Public)
                    If Not IsNothing(propiedad) AndAlso propiedad.CanWrite Then
                        propiedad.SetValue(conf, Conversion.CTypeDynamic(info.Valor, propiedad.PropertyType), Nothing)
                    End If
                Catch ex As Exception
                End Try
            Next
            Return conf
        End Function

        Public Shared Function DescargarConfiguracion(ByVal conf As ConfiguracionGlobal) As List(Of Data.Entity.Configuraciones)
            Dim infoConf As New List(Of Data.Entity.Configuraciones)
            Dim tipoConf As Type = GetType(ConfiguracionGlobal)
            Dim propiedades As PropertyInfo() = tipoConf.GetProperties(BindingFlags.Public Or BindingFlags.Instance)
            Dim valor As String
            For Each propiedad As PropertyInfo In propiedades
                Try
                    If Not propiedad.CanRead Then
                        Continue For
                    End If
                    Dim confTemp As New Data.Entity.Configuraciones()
                    If propiedad.PropertyType.IsEnum Then
                        valor = CStr(CInt(propiedad.GetValue(conf, Nothing)))
                    Else
                        valor = CStr(propiedad.GetValue(conf, Nothing))
                    End If
                    If IsNothing(valor) Then valor = ""
                    confTemp.idPuesto = Nothing
                    confTemp.Parametro = propiedad.Name
                    confTemp.Valor = valor
                    infoConf.Add(confTemp)
                Catch ex As Exception
                End Try
            Next
            Return infoConf
        End Function
    End Class

End Namespace

