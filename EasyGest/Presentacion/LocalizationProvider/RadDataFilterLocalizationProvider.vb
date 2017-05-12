Namespace Presentacion.LocalizationProvider

    Public Class SpanishDataFilterLocalizationProvider
        Inherits Telerik.WinControls.UI.DataFilterLocalizationProvider
        Public Overrides Function GetLocalizedString(id As String) As String
            Select Case id
                Case DataFilterStringId.LogicalOperatorAnd
                    Return "Todo"
                Case DataFilterStringId.LogicalOperatorOr
                    Return "Alguno"
                Case DataFilterStringId.LogicalOperatorDescription
                    Return " de los siguientes cond. son verdadera"
                Case DataFilterStringId.FieldNullText
                    Return "Escoger campo"
                Case DataFilterStringId.ValueNullText
                    Return "Introduce un valor"
                Case DataFilterStringId.AddNewButtonText
                    Return "Añadir"
                Case DataFilterStringId.AddNewButtonExpression
                    Return "Expresión"
                Case DataFilterStringId.AddNewButtonGroup
                    Return "Grupo"
                Case DataFilterStringId.DialogTitle
                    Return "Filtro de datos"
                Case DataFilterStringId.DialogOKButton
                    Return "Aceptar"
                Case DataFilterStringId.DialogCancelButton
                    Return "Cancelar"
                Case DataFilterStringId.DialogApplyButton
                    Return "Aplicar"
                Case DataFilterStringId.ErrorAddNodeDialogTitle
                    Return "Error RadDataFilter"
                Case DataFilterStringId.ErrorAddNodeDialogText
                    Return "No se puede agregar entradas al control - falta descriptores de propiedades. " & vbLf & "DataSource no está establecido y / o DataFilterDescriptorItems no se ha agregado a la colección de descriptores del control."
                Case DataFilterStringId.FilterFunctionBetween
                    Return "Entre rango"
                Case DataFilterStringId.FilterFunctionContains
                    Return "Contiene"
                Case DataFilterStringId.FilterFunctionDoesNotContain
                    Return "No contiene"
                Case DataFilterStringId.FilterFunctionEndsWith
                    Return "Termina en"
                Case DataFilterStringId.FilterFunctionEqualTo
                    Return "Igual a"
                Case DataFilterStringId.FilterFunctionGreaterThan
                    Return "Mayor que"
                Case DataFilterStringId.FilterFunctionGreaterThanOrEqualTo
                    Return "Mayor o igual que"
                Case DataFilterStringId.FilterFunctionIsEmpty
                    Return "Es vacío"
                Case DataFilterStringId.FilterFunctionIsNull
                    Return "Es nulo"
                Case DataFilterStringId.FilterFunctionLessThan
                    Return "Menor que"
                Case DataFilterStringId.FilterFunctionLessThanOrEqualTo
                    Return "Menor o igual que"
                Case DataFilterStringId.FilterFunctionNoFilter
                    Return "Sin filtro"
                Case DataFilterStringId.FilterFunctionNotBetween
                    Return "Fuera de rango"
                Case DataFilterStringId.FilterFunctionNotEqualTo
                    Return "Distinto a"
                Case DataFilterStringId.FilterFunctionNotIsEmpty
                    Return "No vacío"
                Case DataFilterStringId.FilterFunctionNotIsNull
                    Return "No nulo"
                Case DataFilterStringId.FilterFunctionStartsWith
                    Return "Empieza por"
                Case DataFilterStringId.FilterFunctionCustom
                    Return "Personalizado"
            End Select
            Return MyBase.GetLocalizedString(id)
        End Function
    End Class

    Public Class ChinesesDataFilterLocalizationProvider
        Inherits Telerik.WinControls.UI.DataFilterLocalizationProvider
        Public Overrides Function GetLocalizedString(id As String) As String
            Select Case id
                Case DataFilterStringId.LogicalOperatorAnd
                    Return "所有"
                Case DataFilterStringId.LogicalOperatorOr
                    Return "任何"
                Case DataFilterStringId.LogicalOperatorDescription
                    Return "的当下条件为属实"
                Case DataFilterStringId.FieldNullText
                    Return "选取域"
                Case DataFilterStringId.ValueNullText
                    Return "输入值"
                Case DataFilterStringId.AddNewButtonText
                    Return "添加"
                Case DataFilterStringId.AddNewButtonExpression
                    Return "表达式"
                Case DataFilterStringId.AddNewButtonGroup
                    Return "组群"
                Case DataFilterStringId.DialogTitle
                    Return "数据过滤"
                Case DataFilterStringId.DialogOKButton
                    Return "确定"
                Case DataFilterStringId.DialogCancelButton
                    Return "取消"
                Case DataFilterStringId.DialogApplyButton
                    Return "应用"
                Case DataFilterStringId.ErrorAddNodeDialogTitle
                    Return "RadDataFilter错误"
                Case DataFilterStringId.ErrorAddNodeDialogText
                    Return "无法向控件添加条目 - 缺少的属性描述符。" & vbLf & "DataSource未设置和/或DataFilterDescriptorItems未添加到控件的属性描述符集合。"
                Case DataFilterStringId.FilterFunctionBetween
                    Return "值间"
                Case DataFilterStringId.FilterFunctionContains
                    Return "包含"
                Case DataFilterStringId.FilterFunctionDoesNotContain
                    Return "不包含"
                Case DataFilterStringId.FilterFunctionEndsWith
                    Return "结尾为"
                Case DataFilterStringId.FilterFunctionEqualTo
                    Return "相同"
                Case DataFilterStringId.FilterFunctionGreaterThan
                    Return "大于"
                Case DataFilterStringId.FilterFunctionGreaterThanOrEqualTo
                    Return "大或等于"
                Case DataFilterStringId.FilterFunctionIsEmpty
                    Return "空值"
                Case DataFilterStringId.FilterFunctionIsNull
                    Return "无效值"
                Case DataFilterStringId.FilterFunctionLessThan
                    Return "小于"
                Case DataFilterStringId.FilterFunctionLessThanOrEqualTo
                    Return "小或等于"
                Case DataFilterStringId.FilterFunctionNoFilter
                    Return "无过滤"
                Case DataFilterStringId.FilterFunctionNotBetween
                    Return "值外"
                Case DataFilterStringId.FilterFunctionNotEqualTo
                    Return "不相同"
                Case DataFilterStringId.FilterFunctionNotIsEmpty
                    Return "非空值"
                Case DataFilterStringId.FilterFunctionNotIsNull
                    Return "非无效值"
                Case DataFilterStringId.FilterFunctionStartsWith
                    Return "开始于"
                Case DataFilterStringId.FilterFunctionCustom
                    Return "个性化"
            End Select
            Return MyBase.GetLocalizedString(id)
        End Function
    End Class

End Namespace
