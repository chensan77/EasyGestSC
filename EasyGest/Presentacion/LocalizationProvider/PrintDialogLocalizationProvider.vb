Namespace Presentacion.LocalizationProvider
    Class SpanishPrintDialogLocalizationProvider
        Inherits Telerik.WinControls.UI.PrintDialogsLocalizationProvider

        Public Overrides Function GetLocalizedString(id As String) As String
            Select Case id
                Case PrintDialogsStringId.PreviewDialogTitle
                    Return "Vista preliminar"
                Case PrintDialogsStringId.PreviewDialogPrint
                    Return "Imprimir..."
                Case PrintDialogsStringId.PreviewDialogPrintSettings
                    Return "Configuración impresión..."
                Case PrintDialogsStringId.PreviewDialogWatermark
                    Return "Marca de agua..."
                Case PrintDialogsStringId.PreviewDialogPreviousPage
                    Return "Página previo"
                Case PrintDialogsStringId.PreviewDialogNextPage
                    Return "Página siguiente"
                Case PrintDialogsStringId.PreviewDialogZoomIn
                    Return "Ampliar"
                Case PrintDialogsStringId.PreviewDialogZoomOut
                    Return "Reducir"
                Case PrintDialogsStringId.PreviewDialogZoom
                    Return "Zoom"
                Case PrintDialogsStringId.PreviewDialogAuto
                    Return "Auto"
                Case PrintDialogsStringId.PreviewDialogLayout
                    Return "Capa"
                Case PrintDialogsStringId.PreviewDialogFile
                    Return "Archivo"
                Case PrintDialogsStringId.PreviewDialogView
                    Return "Vista"
                Case PrintDialogsStringId.PreviewDialogTools
                    Return "Herramientas"
                Case PrintDialogsStringId.PreviewDialogExit
                    Return "Salir"
                Case PrintDialogsStringId.PreviewDialogStripTools
                    Return "Herramientas"
                Case PrintDialogsStringId.PreviewDialogStripNavigation
                    Return "Navegación"


                Case PrintDialogsStringId.WatermarkDialogTitle
                    Return "Configuración marca de agua"
                Case PrintDialogsStringId.WatermarkDialogButtonOK
                    Return "Aceptar"
                Case PrintDialogsStringId.WatermarkDialogButtonCancel
                    Return "Cancelar"
                Case PrintDialogsStringId.WatermarkDialogLabelPreview
                    Return "Preliminar"
                Case PrintDialogsStringId.WatermarkDialogButtonRemove
                    Return "Quitar marca de agua"
                Case PrintDialogsStringId.WatermarkDialogLabelPosition
                    Return "Posición"
                Case PrintDialogsStringId.WatermarkDialogRadioInFront
                    Return "Al frente"
                Case PrintDialogsStringId.WatermarkDialogRadioBehind
                    Return "Detrás"
                Case PrintDialogsStringId.WatermarkDialogLabelPageRange
                    Return "Rango página"
                Case PrintDialogsStringId.WatermarkDialogRadioAll
                    Return "Todo"
                Case PrintDialogsStringId.WatermarkDialogRadioPages
                    Return "Páginas"
                Case PrintDialogsStringId.WatermarkDialogLabelPagesDescription
                    Return "(e.j. 1,3,5-12)"
                Case PrintDialogsStringId.WatermarkDialogTabText
                    Return "Texto"
                Case PrintDialogsStringId.WatermarkDialogTabPicture
                    Return "Imagen"
                Case PrintDialogsStringId.WatermarkDialogLabelText
                    Return "Texto"
                Case PrintDialogsStringId.WatermarkDialogWatermarkText
                    Return "Texto marca de agua"
                Case PrintDialogsStringId.WatermarkDialogLabelHOffset
                    Return "Desp. horizontal"
                Case PrintDialogsStringId.WatermarkDialogLabelVOffset
                    Return "Desp. vertical"
                Case PrintDialogsStringId.WatermarkDialogLabelRotation
                    Return "Rotación"
                Case PrintDialogsStringId.WatermarkDialogLabelFont
                    Return "Fuente:"
                Case PrintDialogsStringId.WatermarkDialogLabelSize
                    Return "Tamaño:"
                Case PrintDialogsStringId.WatermarkDialogLabelColor
                    Return "Color:"
                Case PrintDialogsStringId.WatermarkDialogLabelOpacity
                    Return "Opacidad:"
                Case PrintDialogsStringId.WatermarkDialogLabelLoadImage
                    Return "Cargar imagen:"
                Case PrintDialogsStringId.WatermarkDialogCheckboxTiling
                    Return "Estirado"


                Case PrintDialogsStringId.SettingDialogTitle
                    Return "Configuración impresión"
                Case PrintDialogsStringId.SettingDialogButtonPrint
                    Return "Imprimir"
                Case PrintDialogsStringId.SettingDialogButtonPreview
                    Return "Preliminar"
                Case PrintDialogsStringId.SettingDialogButtonCancel
                    Return "Cancelar"
                Case PrintDialogsStringId.SettingDialogButtonOK
                    Return "Aceptar"
                Case PrintDialogsStringId.SettingDialogPageFormat
                    Return "Formato"
                Case PrintDialogsStringId.SettingDialogPagePaper
                    Return "Papel"
                Case PrintDialogsStringId.SettingDialogPageHeaderFooter
                    Return "Cabecera/Pie"
                Case PrintDialogsStringId.SettingDialogButtonPageNumber
                    Return "Numero página"
                Case PrintDialogsStringId.SettingDialogButtonTotalPages
                    Return "Total página"
                Case PrintDialogsStringId.SettingDialogButtonCurrentDate
                    Return "Fecha actual"
                Case PrintDialogsStringId.SettingDialogButtonCurrentTime
                    Return "Tiempo actual"
                Case PrintDialogsStringId.SettingDialogButtonUserName
                    Return "Nombre usuario"
                    'Case PrintDialogsStringId.SettingDialogButtonFont
                    '    Return "Fuente..."
                Case PrintDialogsStringId.SettingDialogLabelHeader
                    Return "Cabecera"
                Case PrintDialogsStringId.SettingDialogLabelFooter
                    Return "Pie"
                Case PrintDialogsStringId.SettingDialogCheckboxReverse
                    Return "Invertir en las páginas pares"
                Case PrintDialogsStringId.SettingDialogLabelPage
                    Return "Página"
                Case PrintDialogsStringId.SettingDialogLabelType
                    Return "Tipo"
                Case PrintDialogsStringId.SettingDialogLabelPageSource
                    Return "Origen papel"
                Case PrintDialogsStringId.SettingDialogLabelMargins
                    Return "Margen (inch)"
                Case PrintDialogsStringId.SettingDialogLabelOrientation
                    Return "Orientación"
                Case PrintDialogsStringId.SettingDialogLabelTop
                    Return "Superior:"
                Case PrintDialogsStringId.SettingDialogLabelBottom
                    Return "Inferior:"
                Case PrintDialogsStringId.SettingDialogLabelLeft
                    Return "Izquierda:"
                Case PrintDialogsStringId.SettingDialogLabelRight
                    Return "Derecha:"
                Case PrintDialogsStringId.SettingDialogRadioPortrait
                    Return "Vertical"
                Case PrintDialogsStringId.SettingDialogRadioLandscape
                    Return "Horizontal"


                Case PrintDialogsStringId.SchedulerSettingsLabelPrintStyle
                    Return "Estilo impresión"
                Case PrintDialogsStringId.SchedulerSettingsDailyStyle
                    Return "Estilo diaria"
                Case PrintDialogsStringId.SchedulerSettingsWeeklyStyle
                    Return "Estilo semanal"
                Case PrintDialogsStringId.SchedulerSettingsMonthlyStyle
                    Return "Estilo mensual"
                Case PrintDialogsStringId.SchedulerSettingsDetailStyle
                    Return "Estilo detalle"
                Case PrintDialogsStringId.SchedulerSettingsButtonWatermark
                    Return "Marca de agua..."
                    'Case PrintDialogsStringId.SchedulerSettingsButtonFont
                    '    Return "Fuente..."
                Case PrintDialogsStringId.SchedulerSettingsLabelPrintRange
                    Return "Rango impresión"
                Case PrintDialogsStringId.SchedulerSettingsLabelStyleSettings
                    Return "Configuración estilo"
                Case PrintDialogsStringId.SchedulerSettingsLabelPrintSettings
                    Return "Configuración impresión"
                Case PrintDialogsStringId.SchedulerSettingsLabelStartDate
                    Return "Fecha inicial"
                Case PrintDialogsStringId.SchedulerSettingsLabelEndDate
                    Return "Fecha final"
                Case PrintDialogsStringId.SchedulerSettingsLabelStartTime
                    Return "Hora inicial"
                Case PrintDialogsStringId.SchedulerSettingsLabelEndTime
                    Return "Hora final"
                Case PrintDialogsStringId.SchedulerSettingsLabelDateFont
                    Return "Fuente fecha titular"
                Case PrintDialogsStringId.SchedulerSettingsLabelAppointmentFont
                    Return "Fuente cita"
                Case PrintDialogsStringId.SchedulerSettingsLabelLayout
                    Return "Capa"
                Case PrintDialogsStringId.SchedulerSettingsPrintPageTitle
                    Return "Título página impresa"
                Case PrintDialogsStringId.SchedulerSettingsPrintCalendar
                    Return "Incluir el canlendar en el título"
                Case PrintDialogsStringId.SchedulerSettingsPrintTimezone
                    Return "Imprimir el huso horario seleccionado"
                Case PrintDialogsStringId.SchedulerSettingsPrintNotesBlank
                    Return "Area notas (negro)"
                Case PrintDialogsStringId.SchedulerSettingsPrintNotesLined
                    Return "Area notas (rayado)"
                Case PrintDialogsStringId.SchedulerSettingsNonworkingDays
                    Return "Excluir días no laborales"
                Case PrintDialogsStringId.SchedulerSettingsExactlyOneMonth
                    Return "Imprimir el mes exacto"
                Case PrintDialogsStringId.SchedulerSettingsLabelWeeksPerPage
                    Return "Semanas por página"
                Case PrintDialogsStringId.SchedulerSettingsNewPageEach
                    Return "Comienza una nueva página cada"
                Case PrintDialogsStringId.SchedulerSettingsStringDay
                    Return "Día"
                Case PrintDialogsStringId.SchedulerSettingsStringMonth
                    Return "Mes"
                Case PrintDialogsStringId.SchedulerSettingsStringWeek
                    Return "Semana"
                Case PrintDialogsStringId.SchedulerSettingsStringPage
                    Return "Página"
                Case PrintDialogsStringId.SchedulerSettingsStringPages
                    Return "Páginas"
                Case PrintDialogsStringId.SchedulerSettingsLabelGroupBy
                    Return "Agrupar por:"
                Case PrintDialogsStringId.SchedulerSettingsGroupByNone
                    Return "Nada"
                Case PrintDialogsStringId.SchedulerSettingsGroupByResource
                    Return "Recurso"
                Case PrintDialogsStringId.SchedulerSettingsGroupByDate
                    Return "Fecha"


                Case PrintDialogsStringId.GridSettingsLabelPreview
                    Return "Preliminar"
                Case PrintDialogsStringId.GridSettingsLabelStyleSettings
                    Return "Configuración estilo"
                Case PrintDialogsStringId.GridSettingsLabelFitMode
                    Return "Modo de ajuste página:"
                Case PrintDialogsStringId.GridSettingsLabelHeaderCells
                    Return "Celdas cebeceras"
                Case PrintDialogsStringId.GridSettingsLabelGroupCells
                    Return "Celdas grupales"
                Case PrintDialogsStringId.GridSettingsLabelDataCells
                    Return "Celdas datos"
                Case PrintDialogsStringId.GridSettingsLabelSummaryCells
                    Return "Celdas sumarias"
                Case PrintDialogsStringId.GridSettingsLabelBackground
                    Return "Fondo"
                Case PrintDialogsStringId.GridSettingsLabelBorderColor
                    Return "Color border"
                Case PrintDialogsStringId.GridSettingsLabelAlternatingRowColor
                    Return "Color fila alternante"
                Case PrintDialogsStringId.GridSettingsLabelPadding
                    Return "Relleno"
                Case PrintDialogsStringId.GridSettingsPrintGrouping
                    Return "Imprimir agrupación"
                Case PrintDialogsStringId.GridSettingsPrintSummaries
                    Return "Imprimir resumen"
                Case PrintDialogsStringId.GridSettingsPrintHiddenRows
                    Return "Imprimir filas ocultas"
                Case PrintDialogsStringId.GridSettingsPrintHiddenColumns
                    Return "Imprimir columnas ocultas"
                Case PrintDialogsStringId.GridSettingsPrintHeader
                    Return "Imprimir cabecera en cada página"
                Case PrintDialogsStringId.GridSettingsButtonWatermark
                    Return "Marca de agua..."
                    'Case PrintDialogsStringId.GridSettingsButtonFont
                    '    Return "Fuente..."
                Case PrintDialogsStringId.GridSettingsFitPageWidth
                    Return "Ajuste ancho página"
                Case PrintDialogsStringId.GridSettingsNoFit
                    Return "Sin ajuste"
                Case PrintDialogsStringId.GridSettingsNoFitCentered
                    Return "Sin ajuste centrado"
                Case PrintDialogsStringId.GridSettingsLabelPrint
                    Return "Imprimir"
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select

        End Function
    End Class

    Class ChinesePrintDialogsLocalizationProvider
        Inherits Telerik.WinControls.UI.PrintDialogsLocalizationProvider
        Public Overrides Function GetLocalizedString(id As String) As String
            Select Case id
                Case PrintDialogsStringId.PreviewDialogTitle
                    Return "预览"
                Case PrintDialogsStringId.PreviewDialogPrint
                    Return "打印..."
                Case PrintDialogsStringId.PreviewDialogPrintSettings
                    Return "打印设置..."
                Case PrintDialogsStringId.PreviewDialogWatermark
                    Return "水印..."
                Case PrintDialogsStringId.PreviewDialogPreviousPage
                    Return "上一页"
                Case PrintDialogsStringId.PreviewDialogNextPage
                    Return "下一页"
                Case PrintDialogsStringId.PreviewDialogZoomIn
                    Return "放大"
                Case PrintDialogsStringId.PreviewDialogZoomOut
                    Return "缩小"
                Case PrintDialogsStringId.PreviewDialogZoom
                    Return "Zoom"
                Case PrintDialogsStringId.PreviewDialogAuto
                    Return "自动"
                Case PrintDialogsStringId.PreviewDialogLayout
                    Return "布局"
                Case PrintDialogsStringId.PreviewDialogFile
                    Return "文件"
                Case PrintDialogsStringId.PreviewDialogView
                    Return "视图"
                Case PrintDialogsStringId.PreviewDialogTools
                    Return "工具"
                Case PrintDialogsStringId.PreviewDialogExit
                    Return "退出"
                Case PrintDialogsStringId.PreviewDialogStripTools
                    Return "工具"
                Case PrintDialogsStringId.PreviewDialogStripNavigation
                    Return "浏览"


                Case PrintDialogsStringId.WatermarkDialogTitle
                    Return "水印设置"
                Case PrintDialogsStringId.WatermarkDialogButtonOK
                    Return "确定"
                Case PrintDialogsStringId.WatermarkDialogButtonCancel
                    Return "取消"
                Case PrintDialogsStringId.WatermarkDialogLabelPreview
                    Return "预览"
                Case PrintDialogsStringId.WatermarkDialogButtonRemove
                    Return "消除水印"
                Case PrintDialogsStringId.WatermarkDialogLabelPosition
                    Return "位置"
                Case PrintDialogsStringId.WatermarkDialogRadioInFront
                    Return "在前"
                Case PrintDialogsStringId.WatermarkDialogRadioBehind
                    Return "在后"
                Case PrintDialogsStringId.WatermarkDialogLabelPageRange
                    Return "页范围"
                Case PrintDialogsStringId.WatermarkDialogRadioAll
                    Return "所有"
                Case PrintDialogsStringId.WatermarkDialogRadioPages
                    Return "页"
                Case PrintDialogsStringId.WatermarkDialogLabelPagesDescription
                    Return "(例 1,3,5-12)"
                Case PrintDialogsStringId.WatermarkDialogTabText
                    Return "文字"
                Case PrintDialogsStringId.WatermarkDialogTabPicture
                    Return "图片"
                Case PrintDialogsStringId.WatermarkDialogLabelText
                    Return "文字"
                Case PrintDialogsStringId.WatermarkDialogWatermarkText
                    Return "水印文字"
                Case PrintDialogsStringId.WatermarkDialogLabelHOffset
                    Return "横向偏移"
                Case PrintDialogsStringId.WatermarkDialogLabelVOffset
                    Return "纵向偏移"
                Case PrintDialogsStringId.WatermarkDialogLabelRotation
                    Return "自转"
                Case PrintDialogsStringId.WatermarkDialogLabelFont
                    Return "字体:"
                Case PrintDialogsStringId.WatermarkDialogLabelSize
                    Return "大小:"
                Case PrintDialogsStringId.WatermarkDialogLabelColor
                    Return "色泽:"
                Case PrintDialogsStringId.WatermarkDialogLabelOpacity
                    Return "透明度:"
                Case PrintDialogsStringId.WatermarkDialogLabelLoadImage
                    Return "加载图片:"
                Case PrintDialogsStringId.WatermarkDialogCheckboxTiling
                    Return "平铺"


                Case PrintDialogsStringId.SettingDialogTitle
                    Return "打印设置"
                Case PrintDialogsStringId.SettingDialogButtonPrint
                    Return "打印"
                Case PrintDialogsStringId.SettingDialogButtonPreview
                    Return "预览"
                Case PrintDialogsStringId.SettingDialogButtonCancel
                    Return "取消"
                Case PrintDialogsStringId.SettingDialogButtonOK
                    Return "确定"
                Case PrintDialogsStringId.SettingDialogPageFormat
                    Return "格式化"
                Case PrintDialogsStringId.SettingDialogPagePaper
                    Return "纸张"
                Case PrintDialogsStringId.SettingDialogPageHeaderFooter
                    Return "页头/页尾"
                Case PrintDialogsStringId.SettingDialogButtonPageNumber
                    Return "页数"
                Case PrintDialogsStringId.SettingDialogButtonTotalPages
                    Return "总页数"
                Case PrintDialogsStringId.SettingDialogButtonCurrentDate
                    Return "当前日期"
                Case PrintDialogsStringId.SettingDialogButtonCurrentTime
                    Return "当前时间"
                Case PrintDialogsStringId.SettingDialogButtonUserName
                    Return "用户名"
                    'Case PrintDialogsStringId.SettingDialogButtonFont
                    '    Return "字体..."
                Case PrintDialogsStringId.SettingDialogLabelHeader
                    Return "头"
                Case PrintDialogsStringId.SettingDialogLabelFooter
                    Return "尾"
                Case PrintDialogsStringId.SettingDialogCheckboxReverse
                    Return "逆转偶数页"
                Case PrintDialogsStringId.SettingDialogLabelPage
                    Return "页面"
                Case PrintDialogsStringId.SettingDialogLabelType
                    Return "种类"
                Case PrintDialogsStringId.SettingDialogLabelPageSource
                    Return "页源"
                Case PrintDialogsStringId.SettingDialogLabelMargins
                    Return "边距（英寸）"
                Case PrintDialogsStringId.SettingDialogLabelOrientation
                    Return "转向"
                Case PrintDialogsStringId.SettingDialogLabelTop
                    Return "上:"
                Case PrintDialogsStringId.SettingDialogLabelBottom
                    Return "下:"
                Case PrintDialogsStringId.SettingDialogLabelLeft
                    Return "左:"
                Case PrintDialogsStringId.SettingDialogLabelRight
                    Return "右:"
                Case PrintDialogsStringId.SettingDialogRadioPortrait
                    Return "竖排"
                Case PrintDialogsStringId.SettingDialogRadioLandscape
                    Return "横排"


                Case PrintDialogsStringId.SchedulerSettingsLabelPrintStyle
                    Return "打印格式"
                Case PrintDialogsStringId.SchedulerSettingsDailyStyle
                    Return "日格式"
                Case PrintDialogsStringId.SchedulerSettingsWeeklyStyle
                    Return "周格式"
                Case PrintDialogsStringId.SchedulerSettingsMonthlyStyle
                    Return "月格式"
                Case PrintDialogsStringId.SchedulerSettingsDetailStyle
                    Return "详细格式"
                Case PrintDialogsStringId.SchedulerSettingsButtonWatermark
                    Return "水印..."
                    'Case PrintDialogsStringId.SchedulerSettingsButtonFont
                    '    Return "字体..."
                Case PrintDialogsStringId.SchedulerSettingsLabelPrintRange
                    Return "打印范围"
                Case PrintDialogsStringId.SchedulerSettingsLabelStyleSettings
                    Return "格式设置"
                Case PrintDialogsStringId.SchedulerSettingsLabelPrintSettings
                    Return "打印设置"
                Case PrintDialogsStringId.SchedulerSettingsLabelStartDate
                    Return "开始日期"
                Case PrintDialogsStringId.SchedulerSettingsLabelEndDate
                    Return "结束日期"
                Case PrintDialogsStringId.SchedulerSettingsLabelStartTime
                    Return "开始时间"
                Case PrintDialogsStringId.SchedulerSettingsLabelEndTime
                    Return "结束时间"
                Case PrintDialogsStringId.SchedulerSettingsLabelDateFont
                    Return "日期标题字体"
                Case PrintDialogsStringId.SchedulerSettingsLabelAppointmentFont
                    Return "预约字体"
                Case PrintDialogsStringId.SchedulerSettingsLabelLayout
                    Return "布局"
                Case PrintDialogsStringId.SchedulerSettingsPrintPageTitle
                    Return "打印页面标题"
                Case PrintDialogsStringId.SchedulerSettingsPrintCalendar
                    Return "包含日历标题"
                Case PrintDialogsStringId.SchedulerSettingsPrintTimezone
                    Return "打印所选的时区"
                Case PrintDialogsStringId.SchedulerSettingsPrintNotesBlank
                    Return "备注区域 (黑体)"
                Case PrintDialogsStringId.SchedulerSettingsPrintNotesLined
                    Return "备注区域 (夹线)"
                Case PrintDialogsStringId.SchedulerSettingsNonworkingDays
                    Return "不包含休息日"
                Case PrintDialogsStringId.SchedulerSettingsExactlyOneMonth
                    Return "打印整整一个月"
                Case PrintDialogsStringId.SchedulerSettingsLabelWeeksPerPage
                    Return "每页一周"
                Case PrintDialogsStringId.SchedulerSettingsNewPageEach
                    Return "打印新页每"
                Case PrintDialogsStringId.SchedulerSettingsStringDay
                    Return "日"
                Case PrintDialogsStringId.SchedulerSettingsStringMonth
                    Return "月"
                Case PrintDialogsStringId.SchedulerSettingsStringWeek
                    Return "周"
                Case PrintDialogsStringId.SchedulerSettingsStringPage
                    Return "页面"
                Case PrintDialogsStringId.SchedulerSettingsStringPages
                    Return "页面"
                Case PrintDialogsStringId.SchedulerSettingsLabelGroupBy
                    Return "分组:"
                Case PrintDialogsStringId.SchedulerSettingsGroupByNone
                    Return "无"
                Case PrintDialogsStringId.SchedulerSettingsGroupByResource
                    Return "资源"
                Case PrintDialogsStringId.SchedulerSettingsGroupByDate
                    Return "日期"


                Case PrintDialogsStringId.GridSettingsLabelPreview
                    Return "预览"
                Case PrintDialogsStringId.GridSettingsLabelStyleSettings
                    Return "样式设计"
                Case PrintDialogsStringId.GridSettingsLabelFitMode
                    Return "页面契合模式:"
                Case PrintDialogsStringId.GridSettingsLabelHeaderCells
                    Return "表头格"
                Case PrintDialogsStringId.GridSettingsLabelGroupCells
                    Return "数据分组格"
                Case PrintDialogsStringId.GridSettingsLabelDataCells
                    Return "数据格"
                Case PrintDialogsStringId.GridSettingsLabelSummaryCells
                    Return "数据统计格"
                Case PrintDialogsStringId.GridSettingsLabelBackground
                    Return "背景"
                Case PrintDialogsStringId.GridSettingsLabelBorderColor
                    Return "边框颜色"
                Case PrintDialogsStringId.GridSettingsLabelAlternatingRowColor
                    Return "间隔行颜色"
                Case PrintDialogsStringId.GridSettingsLabelPadding
                    Return "填充"
                Case PrintDialogsStringId.GridSettingsPrintGrouping
                    Return "打印数据分组列"
                Case PrintDialogsStringId.GridSettingsPrintSummaries
                    Return "打印数据统计列"
                Case PrintDialogsStringId.GridSettingsPrintHiddenRows
                    Return "打印隐藏行"
                Case PrintDialogsStringId.GridSettingsPrintHiddenColumns
                    Return "打印隐藏列"
                Case PrintDialogsStringId.GridSettingsPrintHeader
                    Return "每页都打印表头"
                Case PrintDialogsStringId.GridSettingsButtonWatermark
                    Return "水印..."
                    'Case PrintDialogsStringId.GridSettingsButtonFont
                    '    Return "字体..."
                Case PrintDialogsStringId.GridSettingsFitPageWidth
                    Return "页面契合宽度"
                Case PrintDialogsStringId.GridSettingsNoFit
                    Return "不契合"
                Case PrintDialogsStringId.GridSettingsNoFitCentered
                    Return "不折中契合"
                Case PrintDialogsStringId.GridSettingsLabelPrint
                    Return "打印"
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select
        End Function
    End Class
End Namespace