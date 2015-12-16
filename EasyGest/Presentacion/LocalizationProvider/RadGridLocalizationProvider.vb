Imports Telerik.WinControls.UI.Localization

Namespace Presentacion.LocalizationProvider

    Public Class SpanishRadGridLocalizationProvider
        Inherits RadGridLocalizationProvider

        Public Overrides Function GetLocalizedString(ByVal id As String) As String
            Select Case (id)
                Case RadGridStringId.FilterFunctionBetween
                    Return "Dentro Rango"
                Case RadGridStringId.FilterFunctionContains
                    Return "Contiene"
                Case RadGridStringId.FilterFunctionDoesNotContain
                    Return "No Contiene"
                Case RadGridStringId.FilterFunctionEndsWith
                    Return "Termina en"
                Case RadGridStringId.FilterFunctionEqualTo
                    Return "Igual"
                Case RadGridStringId.FilterFunctionGreaterThan
                    Return "Mayor que"
                Case RadGridStringId.FilterFunctionGreaterThanOrEqualTo
                    Return "Mayor o Igual que"
                Case RadGridStringId.FilterFunctionIsEmpty
                    Return "Es Vacío"
                Case RadGridStringId.FilterFunctionIsNull
                    Return "Es Nulo"
                Case RadGridStringId.FilterFunctionLessThan
                    Return "Menor que"
                Case RadGridStringId.FilterFunctionLessThanOrEqualTo
                    Return "Menor o Igual que"
                Case RadGridStringId.FilterFunctionNoFilter
                    Return "Sin Filtro"
                Case RadGridStringId.FilterFunctionNotBetween
                    Return "Fuera Rango"
                Case RadGridStringId.FilterFunctionNotEqualTo
                    Return "Distinto"
                Case RadGridStringId.FilterFunctionNotIsEmpty
                    Return "No Es Vacio"
                Case RadGridStringId.FilterFunctionNotIsNull
                    Return "No Es Nulo"
                Case RadGridStringId.FilterFunctionStartsWith
                    Return "Emienza En"
                Case RadGridStringId.FilterFunctionCustom
                    Return "Personalizado"
                Case RadGridStringId.FilterOperatorBetween
                    Return "Dentro Rango"
                Case RadGridStringId.FilterOperatorContains
                    Return "Contiene"
                Case RadGridStringId.FilterOperatorDoesNotContain
                    Return "No Contiene"
                Case RadGridStringId.FilterOperatorEndsWith
                    Return "Termina En"
                Case RadGridStringId.FilterOperatorEqualTo
                    Return "Igual"
                Case RadGridStringId.FilterOperatorGreaterThan
                    Return "Mayor que"
                Case RadGridStringId.FilterOperatorGreaterThanOrEqualTo
                    Return "Mayor o Igual que"
                Case RadGridStringId.FilterOperatorIsEmpty
                    Return "Es Vacío"
                Case RadGridStringId.FilterOperatorIsNull
                    Return "Es Nulo"
                Case RadGridStringId.FilterOperatorLessThan
                    Return "Menor que"
                Case RadGridStringId.FilterOperatorLessThanOrEqualTo
                    Return "Menor o Igual que"
                Case RadGridStringId.FilterOperatorNoFilter
                    Return "Sin Filtro"
                Case RadGridStringId.FilterOperatorNotBetween
                    Return "Fuera Rango"
                Case RadGridStringId.FilterOperatorNotEqualTo
                    Return "Distinto"
                Case RadGridStringId.FilterOperatorNotIsEmpty
                    Return "No Vacío"
                Case RadGridStringId.FilterOperatorNotIsNull
                    Return "No Nulo"
                Case RadGridStringId.FilterOperatorStartsWith
                    Return "Empieza En"
                Case RadGridStringId.FilterOperatorIsLike
                    Return "Como"
                Case RadGridStringId.FilterOperatorNotIsLike
                    Return "No Como"
                Case RadGridStringId.FilterOperatorIsContainedIn
                    Return "Contenido En"
                Case RadGridStringId.FilterOperatorNotIsContainedIn
                    Return "No Contenido En"
                Case RadGridStringId.FilterOperatorCustom
                    Return "Personalizado"
                Case RadGridStringId.CustomFilterMenuItem
                    Return "Personalizado"
                Case RadGridStringId.CustomFilterDialogCaption
                    Return "Dialogo  Filtro de RadGridView [{0}]"
                Case RadGridStringId.CustomFilterDialogLabel
                    Return "Mostrar Filas Donde:"
                Case RadGridStringId.CustomFilterDialogRbAnd
                    Return "Y"
                Case RadGridStringId.CustomFilterDialogRbOr
                    Return "O"
                Case RadGridStringId.CustomFilterDialogBtnOk
                    Return "Aceptar"
                Case RadGridStringId.CustomFilterDialogBtnCancel
                    Return "Cancelar"
                Case RadGridStringId.CustomFilterDialogCheckBoxNot
                    Return "No"
                Case RadGridStringId.CustomFilterDialogTrue
                    Return "Verdadero"
                Case RadGridStringId.CustomFilterDialogFalse
                    Return "Falso"
                Case RadGridStringId.FilterMenuAvailableFilters
                    Return "Filtros Disponibles"
                Case RadGridStringId.FilterMenuSearchBoxText
                    Return "Buscar..."
                Case RadGridStringId.FilterMenuClearFilters
                    Return "Limpiar Filtro"
                Case RadGridStringId.FilterMenuButtonOK
                    Return "Aceptar"
                Case RadGridStringId.FilterMenuButtonCancel
                    Return "Cancelar"
                Case RadGridStringId.FilterMenuSelectionAll
                    Return "Todo"
                Case RadGridStringId.FilterMenuSelectionAllSearched
                    Return "Todos Resultado de Busqueda"
                Case RadGridStringId.FilterMenuSelectionNull
                    Return "Nulo"
                Case RadGridStringId.FilterMenuSelectionNotNull
                    Return "No Nulo"
                Case RadGridStringId.FilterFunctionSelectedDates
                    Return "Filtrar por dia especial:"
                Case RadGridStringId.FilterFunctionToday
                    Return "Hoy"
                Case RadGridStringId.FilterFunctionYesterday
                    Return "Ayer"
                Case RadGridStringId.FilterFunctionDuringLast7days
                    Return "Los últimos 7 días"

                Case RadGridStringId.FilterLogicalOperatorAnd
                    Return "Y"
                Case RadGridStringId.FilterLogicalOperatorOr
                    Return "O"
                Case RadGridStringId.FilterCompositeNotOperator
                    Return "No"
                Case RadGridStringId.DeleteRowMenuItem
                    Return "Borrar Fila"
                Case RadGridStringId.SortAscendingMenuItem
                    Return "Ordenar Ascendente"
                Case RadGridStringId.SortDescendingMenuItem
                    Return "Ordenar Descendente"
                Case RadGridStringId.ClearSortingMenuItem
                    Return "Limpiar Ordenación"
                Case RadGridStringId.ConditionalFormattingMenuItem
                    Return "Formatear condición"
                Case RadGridStringId.GroupByThisColumnMenuItem
                    Return "Agrupar por este columna"
                Case RadGridStringId.UngroupThisColumn
                    Return "Desagrupar por este columna"
                Case RadGridStringId.ColumnChooserMenuItem
                    Return "Selector de Columnas"
                Case RadGridStringId.HideMenuItem
                    Return "Ocultar Columna"
                Case RadGridStringId.UnpinMenuItem
                    Return "Desanclar Columna"
                Case RadGridStringId.UnpinRowMenuItem
                    Return "Desanclar Fila"
                Case RadGridStringId.PinMenuItem
                    Return "Estado Anclaje"
                Case RadGridStringId.PinAtLeftMenuItem
                    Return "Anclar por Izquierda"
                Case RadGridStringId.PinAtRightMenuItem
                    Return "Anclar por Derecha"
                Case RadGridStringId.PinAtBottomMenuItem
                    Return "Anclar por Abajo"
                Case RadGridStringId.PinAtTopMenuItem
                    Return "Anclar por Arriba"
                Case RadGridStringId.BestFitMenuItem
                    Return "Mejor Ajuste"
                Case RadGridStringId.PasteMenuItem
                    Return "Pegar"
                Case RadGridStringId.EditMenuItem
                    Return "Editar"
                Case RadGridStringId.ClearValueMenuItem
                    Return "Borrar Valor"
                Case RadGridStringId.CopyMenuItem
                    Return "Copiar"
                Case RadGridStringId.AddNewRowString
                    Return "Clikear aquí para añadir nueva fila"
                Case RadGridStringId.SearchRowResultsOfLabel
                    Return "de"
                Case RadGridStringId.SearchRowMatchCase
                    Return "Coincidir mayúscula y minúscula"
                Case RadGridStringId.ConditionalFormattingSortAlphabetically
                    Return "Ordenar columnas alfabéticamente"
                Case RadGridStringId.ConditionalFormattingCaption
                    Return "Gestor de Reglas de Formato Condicional"
                Case RadGridStringId.ConditionalFormattingLblColumn
                    Return "Sólo formatear las celdas"
                Case RadGridStringId.ConditionalFormattingLblName
                    Return "Nombre Regla:"
                Case RadGridStringId.ConditionalFormattingLblType
                    Return "Valor Celda:"
                Case RadGridStringId.ConditionalFormattingLblValue1
                    Return "Valor 1:"
                Case RadGridStringId.ConditionalFormattingLblValue2
                    Return "Valor 2:"
                Case RadGridStringId.ConditionalFormattingGrpConditions
                    Return "Reglas"
                Case RadGridStringId.ConditionalFormattingGrpProperties
                    Return "Propiedades Regla"
                Case RadGridStringId.ConditionalFormattingChkApplyToRow
                    Return "Aplicar esta regla a conjunto de las filas"
                Case RadGridStringId.ConditionalFormattingChkApplyOnSelectedRows
                    Return "Aplicar esta regla a las filas seleccionadas"
                Case RadGridStringId.ConditionalFormattingBtnAdd
                    Return "Añadir nueva regla"
                Case RadGridStringId.ConditionalFormattingBtnRemove
                    Return "Borrar regla seleccionada"
                Case RadGridStringId.ConditionalFormattingBtnOK
                    Return "Aceptar"
                Case RadGridStringId.ConditionalFormattingBtnCancel
                    Return "Cancelar"
                Case RadGridStringId.ConditionalFormattingBtnApply
                    Return "Aplicar"
                Case RadGridStringId.ConditionalFormattingRuleAppliesOn
                    Return "Regla aplicado en:"
                Case RadGridStringId.ConditionalFormattingChooseOne
                    Return "[Elegir uno]"
                Case RadGridStringId.ConditionalFormattingEqualsTo
                    Return "Igual a [Valor1]"
                Case RadGridStringId.ConditionalFormattingIsNotEqualTo
                    Return "Distinto a [Valor1]"
                Case RadGridStringId.ConditionalFormattingStartsWith
                    Return "Empieza en [Valor1]"
                Case RadGridStringId.ConditionalFormattingEndsWith
                    Return "Termina en [Valor1]"
                Case RadGridStringId.ConditionalFormattingContains
                    Return "Contiene [Valor1]"
                Case RadGridStringId.ConditionalFormattingDoesNotContain
                    Return "No contiene [Valor1]"
                Case RadGridStringId.ConditionalFormattingIsGreaterThan
                    Return "Mayor que [Valor1]"
                Case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual
                    Return "Mayor o igual que [Valor1]"
                Case RadGridStringId.ConditionalFormattingIsLessThan
                    Return "Menor que [Valor1]"
                Case RadGridStringId.ConditionalFormattingIsLessThanOrEqual
                    Return "Menor o igual que [Valor1]"
                Case RadGridStringId.ConditionalFormattingIsBetween
                    Return "Entre [Valor1] y [Valor2]"
                Case RadGridStringId.ConditionalFormattingIsNotBetween
                    Return "Fuera [Valor1] y [Valor2]"

                Case RadGridStringId.ConditionalFormattingLblFormat
                    Return "Formatear"
                Case RadGridStringId.ConditionalFormattingBtnExpression
                    Return "Editor expresión"
                Case RadGridStringId.ConditionalFormattingTextBoxExpression
                    Return "Expresión"
                Case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitiveDescription
                    Return "Determina si se distingue entre mayúsculas y minúsculas en la evaluación de los valores de cadena."
                Case RadGridStringId.ConditionalFormattingPropertyGridCellBackColorDescription
                    Return "Seleccionar el color fondo para ser usado en la celda."
                Case RadGridStringId.ConditionalFormattingPropertyGridCellForeColorDescription
                    Return "Seleccionar el color plano para ser usado en la celda."
                Case RadGridStringId.ConditionalFormattingPropertyGridEnabledDescription
                    Return "Determina si la condición está activa (puede ser evaluada y aplicada)."
                Case RadGridStringId.ConditionalFormattingPropertyGridRowBackColorDescription
                    Return "Introduzca el color de fondo que se utilizará para toda la fila."
                Case RadGridStringId.ConditionalFormattingPropertyGridRowForeColorDescription
                    Return "Introduzca el color de plano que se utilizará para toda la fila."
                Case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignmentDescription
                    Return "Introduzca la alineación que se utilizará para los valores de celda, cuando ApplyToRow es True."
                Case RadGridStringId.ConditionalFormattingPropertyGridTextAlignmentDescription
                    Return "Introduzca la alineación que se utilizará para los valores de celda."
                Case RadGridStringId.ConditionalFormattingPleaseSelectValidCellValue
                    Return "Por favor selecciona el valor válido para celda"
                Case RadGridStringId.ConditionalFormattingPleaseSetValidCellValue
                    Return "Por favor introduce el valor válido para celda"
                Case RadGridStringId.ConditionalFormattingPleaseSetValidCellValues
                    Return "Por favor introduce los valores válidos para celda"
                Case RadGridStringId.ConditionalFormattingPleaseSetValidExpression
                    Return "Por favor introduce la expresión válida"
                Case RadGridStringId.ConditionalFormattingItem
                    Return "Item"
                Case RadGridStringId.ConditionalFormattingInvalidParameters
                    Return "Parámetros inválido"
                Case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitive
                    Return "DistingueMayúsMinús"
                Case RadGridStringId.ConditionalFormattingPropertyGridCellBackColor
                    Return "ColorFondoCelda"
                Case RadGridStringId.ConditionalFormattingPropertyGridCellForeColor
                    Return "ColorPlanoCelda"
                Case RadGridStringId.ConditionalFormattingPropertyGridEnabled
                    Return "Activo"
                Case RadGridStringId.ConditionalFormattingPropertyGridRowBackColor
                    Return "ColorFondoFila"
                Case RadGridStringId.ConditionalFormattingPropertyGridRowForeColor
                    Return "ColorPlanoFila"
                Case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignment
                    Return "AlineaciónTextoFila"
                Case RadGridStringId.ConditionalFormattingPropertyGridTextAlignment
                    Return "AlineaciónTexto"



                Case RadGridStringId.ColumnChooserFormCaption
                    Return "Selector Columnas"
                Case RadGridStringId.ColumnChooserFormMessage
                    Return "Arrastra la cabecera de la columna de" & ControlChars.Lf & "la grilla hasta aquí, para ocultarla " & ControlChars.Lf & "de la vista actual."
                Case RadGridStringId.GroupingPanelDefaultMessage
                    Return "Arrastra la columna hasta aquí para agrupar por ella."
                Case RadGridStringId.GroupingPanelHeader
                    Return "Agrupar por:"
                Case RadGridStringId.NoDataText
                    Return "No hay datos para mostrar"
                Case RadGridStringId.PagingPanelPagesLabel
                    Return "Página"
                Case RadGridStringId.PagingPanelOfPagesLabel
                    Return "de"
                Case RadGridStringId.CompositeFilterFormInvalidFilter
                    Return "El descriptor de filtro compuesto no es válido."
                Case RadGridStringId.CompositeFilterFormErrorCaption
                    Return "Error Filtrar"
                Case RadGridStringId.ExpressionMenuItem
                    Return "Expresión"
                Case RadGridStringId.ExpressionFormTitle
                    Return "Constructor de Expresión"
                Case RadGridStringId.ExpressionFormFunctions
                    Return "Funciones"
                Case RadGridStringId.ExpressionFormFunctionsText
                    Return "Textos"
                Case RadGridStringId.ExpressionFormFunctionsAggregate
                    Return "Agregados"
                Case RadGridStringId.ExpressionFormFunctionsDateTime
                    Return "Fecha/Hora"
                Case RadGridStringId.ExpressionFormFunctionsLogical
                    Return "Lógicos"
                Case RadGridStringId.ExpressionFormFunctionsMath
                    Return "Matemáticos"
                Case RadGridStringId.ExpressionFormFunctionsOther
                    Return "Otros"
                Case RadGridStringId.ExpressionFormOperators
                    Return "Operadores"
                Case RadGridStringId.ExpressionFormConstants
                    Return "Constantes"
                Case RadGridStringId.ExpressionFormFields
                    Return "Campos"
                Case RadGridStringId.ExpressionFormDescription
                    Return "Descrición"
                Case RadGridStringId.ExpressionFormResultPreview
                    Return "Previsualización de resultados"
                Case RadGridStringId.ExpressionFormTooltipPlus
                    Return "Sumar"
                Case RadGridStringId.ExpressionFormTooltipMinus
                    Return "Restar"
                Case RadGridStringId.ExpressionFormTooltipMultiply
                    Return "Multiplicar"
                Case RadGridStringId.ExpressionFormTooltipDivide
                    Return "Dividir"
                Case RadGridStringId.ExpressionFormTooltipModulo
                    Return "Módulo"
                Case RadGridStringId.ExpressionFormTooltipEqual
                    Return "Igual"
                Case RadGridStringId.ExpressionFormTooltipNotEqual
                    Return "No Igual"
                Case RadGridStringId.ExpressionFormTooltipLess
                    Return "Menor"
                Case RadGridStringId.ExpressionFormTooltipLessOrEqual
                    Return "Menor Or Igual"
                Case RadGridStringId.ExpressionFormTooltipGreaterOrEqual
                    Return "Mayor Or Igual"
                Case RadGridStringId.ExpressionFormTooltipGreater
                    Return "Mayor"
                Case RadGridStringId.ExpressionFormTooltipAnd
                    Return "Lógico ""AND"""
                Case RadGridStringId.ExpressionFormTooltipOr
                    Return "Lógico ""OR"""
                Case RadGridStringId.ExpressionFormTooltipNot
                    Return "Lógico ""NOT"""
                    'Case RadGridStringId.ExpressionFormAndButton
                    '    Return "Y"
                    'Case RadGridStringId.ExpressionFormOrButton
                    '    Return "O"
                    'Case RadGridStringId.ExpressionFormNotButton
                    '    Return "No"
                Case RadGridStringId.ExpressionFormAndButton
                    Return String.Empty
                    'if empty, default button image is used
                Case RadGridStringId.ExpressionFormOrButton
                    Return String.Empty
                    'if empty, default button image is used
                Case RadGridStringId.ExpressionFormNotButton
                    Return String.Empty
                    'if empty, default button image is used
                Case RadGridStringId.ExpressionFormOKButton
                    Return "Aceptar"
                Case RadGridStringId.ExpressionFormCancelButton
                    Return "Cancelar"
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select
        End Function


    End Class

    Public Class ChineseRadGridLocationProvider
        Inherits RadGridLocalizationProvider

        Public Overrides Function GetLocalizedString(ByVal id As String) As String
            Select Case (id)
                Case RadGridStringId.FilterFunctionBetween
                    Return "范围内"
                Case RadGridStringId.FilterFunctionContains
                    Return "包含"
                Case RadGridStringId.FilterFunctionDoesNotContain
                    Return "不包含"
                Case RadGridStringId.FilterFunctionEndsWith
                    Return "结束于。。。"
                Case RadGridStringId.FilterFunctionEqualTo
                    Return "相同"
                Case RadGridStringId.FilterFunctionGreaterThan
                    Return "大于"
                Case RadGridStringId.FilterFunctionGreaterThanOrEqualTo
                    Return "大或等于"
                Case RadGridStringId.FilterFunctionIsEmpty
                    Return "是空值"
                Case RadGridStringId.FilterFunctionIsNull
                    Return "是无值"
                Case RadGridStringId.FilterFunctionLessThan
                    Return "小于"
                Case RadGridStringId.FilterFunctionLessThanOrEqualTo
                    Return "小或等于"
                Case RadGridStringId.FilterFunctionNoFilter
                    Return "无过滤"
                Case RadGridStringId.FilterFunctionNotBetween
                    Return "范围外"
                Case RadGridStringId.FilterFunctionNotEqualTo
                    Return "不相同"
                Case RadGridStringId.FilterFunctionNotIsEmpty
                    Return "非空值"
                Case RadGridStringId.FilterFunctionNotIsNull
                    Return "非无值"
                Case RadGridStringId.FilterFunctionStartsWith
                    Return "开始于。。。"
                Case RadGridStringId.FilterFunctionCustom
                    Return "个性"
                Case RadGridStringId.FilterOperatorBetween
                    Return "范围内"
                Case RadGridStringId.FilterOperatorContains
                    Return "包含"
                Case RadGridStringId.FilterOperatorDoesNotContain
                    Return "不包含"
                Case RadGridStringId.FilterOperatorEndsWith
                    Return "结束于。。。"
                Case RadGridStringId.FilterOperatorEqualTo
                    Return "相同"
                Case RadGridStringId.FilterOperatorGreaterThan
                    Return "大于"
                Case RadGridStringId.FilterOperatorGreaterThanOrEqualTo
                    Return "大或等于"
                Case RadGridStringId.FilterOperatorIsEmpty
                    Return "是空值"
                Case RadGridStringId.FilterOperatorIsNull
                    Return "是无值"
                Case RadGridStringId.FilterOperatorLessThan
                    Return "小于"
                Case RadGridStringId.FilterOperatorLessThanOrEqualTo
                    Return "小或等于"
                Case RadGridStringId.FilterOperatorNoFilter
                    Return "无过滤"
                Case RadGridStringId.FilterOperatorNotBetween
                    Return "范围外"
                Case RadGridStringId.FilterOperatorNotEqualTo
                    Return "不相同"
                Case RadGridStringId.FilterOperatorNotIsEmpty
                    Return "非空值"
                Case RadGridStringId.FilterOperatorNotIsNull
                    Return "非无值"
                Case RadGridStringId.FilterOperatorStartsWith
                    Return "开始于。。。"
                Case RadGridStringId.FilterOperatorIsLike
                    Return "相似"
                Case RadGridStringId.FilterOperatorNotIsLike
                    Return "不相似"
                Case RadGridStringId.FilterOperatorIsContainedIn
                    Return "包含之中"
                Case RadGridStringId.FilterOperatorNotIsContainedIn
                    Return "不包含之中"
                Case RadGridStringId.FilterOperatorCustom
                    Return "个性"
                Case RadGridStringId.CustomFilterMenuItem
                    Return "个性"
                Case RadGridStringId.CustomFilterDialogCaption
                    Return "RadGridView过滤对话框 [{0}]"
                Case RadGridStringId.CustomFilterDialogLabel
                    Return "显示行:"
                Case RadGridStringId.CustomFilterDialogRbAnd
                    Return "与"
                Case RadGridStringId.CustomFilterDialogRbOr
                    Return "或"
                Case RadGridStringId.CustomFilterDialogBtnOk
                    Return "确定"
                Case RadGridStringId.CustomFilterDialogBtnCancel
                    Return "取消"
                Case RadGridStringId.CustomFilterDialogCheckBoxNot
                    Return "不"
                Case RadGridStringId.CustomFilterDialogTrue
                    Return "真值"
                Case RadGridStringId.CustomFilterDialogFalse
                    Return "假值"
                Case RadGridStringId.FilterMenuAvailableFilters
                    Return "可用过滤"
                Case RadGridStringId.FilterMenuSearchBoxText
                    Return "查找。。。"
                Case RadGridStringId.FilterMenuClearFilters
                    Return "清除过滤"
                Case RadGridStringId.FilterMenuButtonOK
                    Return "确定"
                Case RadGridStringId.FilterMenuButtonCancel
                    Return "取消"
                Case RadGridStringId.FilterMenuSelectionAll
                    Return "所有"
                Case RadGridStringId.FilterMenuSelectionAllSearched
                    Return "所有查找结果"
                Case RadGridStringId.FilterMenuSelectionNull
                    Return "无值"
                Case RadGridStringId.FilterMenuSelectionNotNull
                    Return "有值"
                Case RadGridStringId.FilterFunctionSelectedDates
                    Return "由特殊日期过滤:"
                Case RadGridStringId.FilterFunctionToday
                    Return "今天"
                Case RadGridStringId.FilterFunctionYesterday
                    Return "昨天"
                Case RadGridStringId.FilterFunctionDuringLast7days
                    Return "最近7天"
                Case RadGridStringId.FilterLogicalOperatorAnd
                    Return "与"
                Case RadGridStringId.FilterLogicalOperatorOr
                    Return "或"
                Case RadGridStringId.FilterCompositeNotOperator
                    Return "不"
                Case RadGridStringId.DeleteRowMenuItem
                    Return "删除行"
                Case RadGridStringId.SortAscendingMenuItem
                    Return "升序排序"
                Case RadGridStringId.SortDescendingMenuItem
                    Return "降序排序"
                Case RadGridStringId.ClearSortingMenuItem
                    Return "清除排序"
                Case RadGridStringId.ConditionalFormattingMenuItem
                    Return "生成条件"
                Case RadGridStringId.GroupByThisColumnMenuItem
                    Return "由此列分组"
                Case RadGridStringId.UngroupThisColumn
                    Return "取消由此列分组"
                Case RadGridStringId.ColumnChooserMenuItem
                    Return "列选择"
                Case RadGridStringId.HideMenuItem
                    Return "隐藏列"
                Case RadGridStringId.UnpinMenuItem
                    Return "列解除固定"
                Case RadGridStringId.UnpinRowMenuItem
                    Return "行解除固定"
                Case RadGridStringId.PinMenuItem
                    Return "固定状态"
                Case RadGridStringId.PinAtLeftMenuItem
                    Return "在左边固定"
                Case RadGridStringId.PinAtRightMenuItem
                    Return "在右边固定"
                Case RadGridStringId.PinAtBottomMenuItem
                    Return "在下面固定"
                Case RadGridStringId.PinAtTopMenuItem
                    Return "在上面固定"
                Case RadGridStringId.BestFitMenuItem
                    Return "最佳适合"
                Case RadGridStringId.PasteMenuItem
                    Return "粘贴"
                Case RadGridStringId.EditMenuItem
                    Return "编辑"
                Case RadGridStringId.ClearValueMenuItem
                    Return "清除值"
                Case RadGridStringId.CopyMenuItem
                    Return "复制"
                Case RadGridStringId.AddNewRowString
                    Return "点击这里添加新行"
                Case RadGridStringId.SearchRowResultsOfLabel
                    Return "之"
                Case RadGridStringId.SearchRowMatchCase
                    Return "大小写匹配"
                Case RadGridStringId.ConditionalFormattingSortAlphabetically
                    Return "列按字母顺序排列"
                Case RadGridStringId.ConditionalFormattingCaption
                    Return "条件性格式化规则管理窗口"
                Case RadGridStringId.ConditionalFormattingLblColumn
                    Return "仅格式表格子"
                Case RadGridStringId.ConditionalFormattingLblName
                    Return "规则名称:"
                Case RadGridStringId.ConditionalFormattingLblType
                    Return "表格子值:"
                Case RadGridStringId.ConditionalFormattingLblValue1
                    Return "值1:"
                Case RadGridStringId.ConditionalFormattingLblValue2
                    Return "值2:"
                Case RadGridStringId.ConditionalFormattingGrpConditions
                    Return "规则"
                Case RadGridStringId.ConditionalFormattingGrpProperties
                    Return "规则属性"
                Case RadGridStringId.ConditionalFormattingChkApplyToRow
                    Return "对行应用此规则"
                Case RadGridStringId.ConditionalFormattingChkApplyOnSelectedRows
                    Return "对选定行应用此规则"
                Case RadGridStringId.ConditionalFormattingBtnAdd
                    Return "添加新规则"
                Case RadGridStringId.ConditionalFormattingBtnRemove
                    Return "删除选定规则"
                Case RadGridStringId.ConditionalFormattingBtnOK
                    Return "确定"
                Case RadGridStringId.ConditionalFormattingBtnCancel
                    Return "取消"
                Case RadGridStringId.ConditionalFormattingBtnApply
                    Return "应用"
                Case RadGridStringId.ConditionalFormattingRuleAppliesOn
                    Return "规则应用于:"
                Case RadGridStringId.ConditionalFormattingChooseOne
                    Return "[选择一项]"
                Case RadGridStringId.ConditionalFormattingEqualsTo
                    Return "相同于[值1]"
                Case RadGridStringId.ConditionalFormattingIsNotEqualTo
                    Return "不相同于[值1]"
                Case RadGridStringId.ConditionalFormattingStartsWith
                    Return "开始于[值1]"
                Case RadGridStringId.ConditionalFormattingEndsWith
                    Return "结束于[值1]"
                Case RadGridStringId.ConditionalFormattingContains
                    Return "包含[值1]"
                Case RadGridStringId.ConditionalFormattingDoesNotContain
                    Return "不包含[值1]"
                Case RadGridStringId.ConditionalFormattingIsGreaterThan
                    Return "大于[值1]"
                Case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual
                    Return "大或等于[值1]"
                Case RadGridStringId.ConditionalFormattingIsLessThan
                    Return "小于[值1]"
                Case RadGridStringId.ConditionalFormattingIsLessThanOrEqual
                    Return "小于或等于[值1]"
                Case RadGridStringId.ConditionalFormattingIsBetween
                    Return "[值1]和[值2]范围之内"
                Case RadGridStringId.ConditionalFormattingIsNotBetween
                    Return "[值1]和[值2]范围之外"

                Case RadGridStringId.ConditionalFormattingLblFormat
                    Return "格式"
                Case RadGridStringId.ConditionalFormattingBtnExpression
                    Return "表达式编辑器"
                Case RadGridStringId.ConditionalFormattingTextBoxExpression
                    Return "表达式"
                Case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitiveDescription
                    Return "决定在检查字符串时区别大小写。"
                Case RadGridStringId.ConditionalFormattingPropertyGridCellBackColorDescription
                    Return "选择用于表格的背景颜色。"
                Case RadGridStringId.ConditionalFormattingPropertyGridCellForeColorDescription
                    Return "选择用于表格的平面颜色。"
                Case RadGridStringId.ConditionalFormattingPropertyGridEnabledDescription
                    Return "决定该条件是否被启用（可评估以及可使用）。"
                Case RadGridStringId.ConditionalFormattingPropertyGridRowBackColorDescription
                    Return "选择用于整行的背景颜色"
                Case RadGridStringId.ConditionalFormattingPropertyGridRowForeColorDescription
                    Return "选择用于整行的平面颜色"
                Case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignmentDescription
                    Return "选择当ApplyToRow为True时表格值的对齐方式。"
                Case RadGridStringId.ConditionalFormattingPropertyGridTextAlignmentDescription
                    Return "选择表格值的对齐方式。"
                Case RadGridStringId.ConditionalFormattingPleaseSelectValidCellValue
                    Return "请选择一个正确的表格数值"
                Case RadGridStringId.ConditionalFormattingPleaseSetValidCellValue
                    Return "请输入一个正确的表格数值"
                Case RadGridStringId.ConditionalFormattingPleaseSetValidCellValues
                    Return "请输入多个正确的表格数值"
                Case RadGridStringId.ConditionalFormattingPleaseSetValidExpression
                    Return "请输入正确的表达式"
                Case RadGridStringId.ConditionalFormattingItem
                    Return "Item"
                Case RadGridStringId.ConditionalFormattingInvalidParameters
                    Return "参数不正确"
                Case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitive
                    Return "区分大小写"
                Case RadGridStringId.ConditionalFormattingPropertyGridCellBackColor
                    Return "格背色"
                Case RadGridStringId.ConditionalFormattingPropertyGridCellForeColor
                    Return "格前色"
                Case RadGridStringId.ConditionalFormattingPropertyGridEnabled
                    Return "活跃"
                Case RadGridStringId.ConditionalFormattingPropertyGridRowBackColor
                    Return "行背色"
                Case RadGridStringId.ConditionalFormattingPropertyGridRowForeColor
                    Return "行前色"
                Case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignment
                    Return "行文字对齐方式"
                Case RadGridStringId.ConditionalFormattingPropertyGridTextAlignment
                    Return "文字对齐方式"

                Case RadGridStringId.ColumnChooserFormCaption
                    Return "列选择"
                Case RadGridStringId.ColumnChooserFormMessage
                    Return "把表格的头列拖拽" & ControlChars.Lf & "到这里，这样可将该列从" & ControlChars.Lf & "表格之中去除."
                Case RadGridStringId.GroupingPanelDefaultMessage
                    Return "把列拖拽到这里用于分组."
                Case RadGridStringId.GroupingPanelHeader
                    Return "分组:"
                Case RadGridStringId.NoDataText
                    Return "没有数据显示"
                Case RadGridStringId.PagingPanelPagesLabel
                    Return "页"
                Case RadGridStringId.PagingPanelOfPagesLabel
                    Return "之"
                Case RadGridStringId.CompositeFilterFormInvalidFilter
                    Return "该过滤组成的描述符无效。"
                Case RadGridStringId.CompositeFilterFormErrorCaption
                    Return "过滤错误"
                Case RadGridStringId.ExpressionMenuItem
                    Return "表达式"
                Case RadGridStringId.ExpressionFormTitle
                    Return "表达式生成框"
                Case RadGridStringId.ExpressionFormFunctions
                    Return "涵数"
                Case RadGridStringId.ExpressionFormFunctionsText
                    Return "文本"
                Case RadGridStringId.ExpressionFormFunctionsAggregate
                    Return "合计"
                Case RadGridStringId.ExpressionFormFunctionsDateTime
                    Return "时间"
                Case RadGridStringId.ExpressionFormFunctionsLogical
                    Return "逻辑"
                Case RadGridStringId.ExpressionFormFunctionsMath
                    Return "数学"
                Case RadGridStringId.ExpressionFormFunctionsOther
                    Return "其它"
                Case RadGridStringId.ExpressionFormOperators
                    Return "运算符"
                Case RadGridStringId.ExpressionFormConstants
                    Return "常数"
                Case RadGridStringId.ExpressionFormFields
                    Return "数据列"
                Case RadGridStringId.ExpressionFormDescription
                    Return "表述"
                Case RadGridStringId.ExpressionFormResultPreview
                    Return "结果预览"
                Case RadGridStringId.ExpressionFormTooltipPlus
                    Return "加"
                Case RadGridStringId.ExpressionFormTooltipMinus
                    Return "减"
                Case RadGridStringId.ExpressionFormTooltipMultiply
                    Return "乘"
                Case RadGridStringId.ExpressionFormTooltipDivide
                    Return "除"
                Case RadGridStringId.ExpressionFormTooltipModulo
                    Return "整数除"
                Case RadGridStringId.ExpressionFormTooltipEqual
                    Return "等于"
                Case RadGridStringId.ExpressionFormTooltipNotEqual
                    Return "不等于"
                Case RadGridStringId.ExpressionFormTooltipLess
                    Return "小于"
                Case RadGridStringId.ExpressionFormTooltipLessOrEqual
                    Return "小或等于"
                Case RadGridStringId.ExpressionFormTooltipGreaterOrEqual
                    Return "大或等于"
                Case RadGridStringId.ExpressionFormTooltipGreater
                    Return "大于"
                Case RadGridStringId.ExpressionFormTooltipAnd
                    Return """AND""逻辑"
                Case RadGridStringId.ExpressionFormTooltipOr
                    Return """OR""逻辑"
                Case RadGridStringId.ExpressionFormTooltipNot
                    Return """NOT""逻辑"
                    'Case RadGridStringId.ExpressionFormAndButton
                    '    Return "与"
                    'Case RadGridStringId.ExpressionFormOrButton
                    '    Return "或"
                    'Case RadGridStringId.ExpressionFormNotButton
                    '    Return "不"
                Case RadGridStringId.ExpressionFormOKButton
                    Return "确定"
                Case RadGridStringId.ExpressionFormCancelButton
                    Return "取消"
                Case RadGridStringId.ExpressionFormAndButton
                    Return String.Empty
                    'if empty, default button image is used
                Case RadGridStringId.ExpressionFormOrButton
                    Return String.Empty
                    'if empty, default button image is used
                Case RadGridStringId.ExpressionFormNotButton
                    Return String.Empty
                    'if empty, default button image is used
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select
        End Function
    End Class

    'Public Class MyEnglishRadGridLocalizationProvider
    '    Inherits RadGridLocalizationProvider

    '    Public Overrides Function GetLocalizedString(id As String) As String
    '        Select Case id

    '            Case RadGridStringId.FilterFunctionBetween
    '                Return "Between"
    '            Case RadGridStringId.FilterFunctionContains
    '                Return "Contains"
    '            Case RadGridStringId.FilterFunctionDoesNotContain
    '                Return "Does not contain"
    '            Case RadGridStringId.FilterFunctionEndsWith
    '                Return "Ends with"
    '            Case RadGridStringId.FilterFunctionEqualTo
    '                Return "Equals"
    '            Case RadGridStringId.FilterFunctionGreaterThan
    '                Return "Greater than"
    '            Case RadGridStringId.FilterFunctionGreaterThanOrEqualTo
    '                Return "Greater than or equal to"
    '            Case RadGridStringId.FilterFunctionIsEmpty
    '                Return "Is empty"
    '            Case RadGridStringId.FilterFunctionIsNull
    '                Return "Is null"
    '            Case RadGridStringId.FilterFunctionLessThan
    '                Return "Less than"
    '            Case RadGridStringId.FilterFunctionLessThanOrEqualTo
    '                Return "Less than or equal to"
    '            Case RadGridStringId.FilterFunctionNoFilter
    '                Return "No filter"
    '            Case RadGridStringId.FilterFunctionNotBetween
    '                Return "Not between"
    '            Case RadGridStringId.FilterFunctionNotEqualTo
    '                Return "Not equal to"
    '            Case RadGridStringId.FilterFunctionNotIsEmpty
    '                Return "Is not empty"
    '            Case RadGridStringId.FilterFunctionNotIsNull
    '                Return "Is not null"
    '            Case RadGridStringId.FilterFunctionStartsWith
    '                Return "Starts with"
    '            Case RadGridStringId.FilterFunctionCustom
    '                Return "Custom"

    '            Case RadGridStringId.FilterOperatorBetween
    '                Return "Between"
    '            Case RadGridStringId.FilterOperatorContains
    '                Return "Contains"
    '            Case RadGridStringId.FilterOperatorDoesNotContain
    '                Return "NotContains"
    '            Case RadGridStringId.FilterOperatorEndsWith
    '                Return "EndsWith"
    '            Case RadGridStringId.FilterOperatorEqualTo
    '                Return "Equals"
    '            Case RadGridStringId.FilterOperatorGreaterThan
    '                Return "GreaterThan"
    '            Case RadGridStringId.FilterOperatorGreaterThanOrEqualTo
    '                Return "GreaterThanOrEquals"
    '            Case RadGridStringId.FilterOperatorIsEmpty
    '                Return "IsEmpty"
    '            Case RadGridStringId.FilterOperatorIsNull
    '                Return "IsNull"
    '            Case RadGridStringId.FilterOperatorLessThan
    '                Return "LessThan"
    '            Case RadGridStringId.FilterOperatorLessThanOrEqualTo
    '                Return "LessThanOrEquals"
    '            Case RadGridStringId.FilterOperatorNoFilter
    '                Return "No filter"
    '            Case RadGridStringId.FilterOperatorNotBetween
    '                Return "NotBetween"
    '            Case RadGridStringId.FilterOperatorNotEqualTo
    '                Return "NotEquals"
    '            Case RadGridStringId.FilterOperatorNotIsEmpty
    '                Return "NotEmpty"
    '            Case RadGridStringId.FilterOperatorNotIsNull
    '                Return "NotNull"
    '            Case RadGridStringId.FilterOperatorStartsWith
    '                Return "StartsWith"
    '            Case RadGridStringId.FilterOperatorIsLike
    '                Return "Like"
    '            Case RadGridStringId.FilterOperatorNotIsLike
    '                Return "NotLike"
    '            Case RadGridStringId.FilterOperatorIsContainedIn
    '                Return "ContainedIn"
    '            Case RadGridStringId.FilterOperatorNotIsContainedIn
    '                Return "NotContainedIn"
    '            Case RadGridStringId.FilterOperatorCustom
    '                Return "Custom"

    '            Case RadGridStringId.CustomFilterMenuItem
    '                Return "Custom"
    '            Case RadGridStringId.CustomFilterDialogCaption
    '                Return "RadGridView Filter Dialog [{0}]"
    '            Case RadGridStringId.CustomFilterDialogLabel
    '                Return "Show rows where:"
    '            Case RadGridStringId.CustomFilterDialogRbAnd
    '                Return "And"
    '            Case RadGridStringId.CustomFilterDialogRbOr
    '                Return "Or"
    '            Case RadGridStringId.CustomFilterDialogBtnOk
    '                Return "OK"
    '            Case RadGridStringId.CustomFilterDialogBtnCancel
    '                Return "Cancel"
    '            Case RadGridStringId.CustomFilterDialogCheckBoxNot
    '                Return "Not"
    '            Case RadGridStringId.CustomFilterDialogTrue
    '                Return "True"
    '            Case RadGridStringId.CustomFilterDialogFalse
    '                Return "False"

    '            Case RadGridStringId.FilterMenuAvailableFilters
    '                Return "Available Filters"
    '            Case RadGridStringId.FilterMenuSearchBoxText
    '                Return "Search..."
    '            Case RadGridStringId.FilterMenuClearFilters
    '                Return "Clear Filter"
    '            Case RadGridStringId.FilterMenuButtonOK
    '                Return "OK"
    '            Case RadGridStringId.FilterMenuButtonCancel
    '                Return "Cancel"
    '            Case RadGridStringId.FilterMenuSelectionAll
    '                Return "All"
    '            Case RadGridStringId.FilterMenuSelectionAllSearched
    '                Return "All Search Result"
    '            Case RadGridStringId.FilterMenuSelectionNull
    '                Return "Null"
    '            Case RadGridStringId.FilterMenuSelectionNotNull
    '                Return "Not Null"



    '            Case RadGridStringId.FilterLogicalOperatorAnd
    '                Return "AND"
    '            Case RadGridStringId.FilterLogicalOperatorOr
    '                Return "OR"
    '            Case RadGridStringId.FilterCompositeNotOperator
    '                Return "NOT"

    '            Case RadGridStringId.DeleteRowMenuItem
    '                Return "Delete Row"
    '            Case RadGridStringId.SortAscendingMenuItem
    '                Return "Sort Ascending"
    '            Case RadGridStringId.SortDescendingMenuItem
    '                Return "Sort Descending"
    '            Case RadGridStringId.ClearSortingMenuItem
    '                Return "Clear Sorting"
    '            Case RadGridStringId.ConditionalFormattingMenuItem
    '                Return "Conditional Formatting"
    '            Case RadGridStringId.GroupByThisColumnMenuItem
    '                Return "Group by this column"
    '            Case RadGridStringId.UngroupThisColumn
    '                Return "Ungroup this column"
    '            Case RadGridStringId.ColumnChooserMenuItem
    '                Return "Column Chooser"
    '            Case RadGridStringId.HideMenuItem
    '                Return "Hide Column"
    '            Case RadGridStringId.HideGroupMenuItem
    '                Return "Hide Group"
    '            Case RadGridStringId.UnpinMenuItem
    '                Return "Unpin Column"
    '            Case RadGridStringId.UnpinRowMenuItem
    '                Return "Unpin Row"
    '            Case RadGridStringId.PinMenuItem
    '                Return "Pinned state"
    '            Case RadGridStringId.PinAtLeftMenuItem
    '                Return "Pin at left"
    '            Case RadGridStringId.PinAtRightMenuItem
    '                Return "Pin at right"
    '            Case RadGridStringId.PinAtBottomMenuItem
    '                Return "Pin at bottom"
    '            Case RadGridStringId.PinAtTopMenuItem
    '                Return "Pin at top"
    '            Case RadGridStringId.BestFitMenuItem
    '                Return "Best Fit"
    '            Case RadGridStringId.PasteMenuItem
    '                Return "Paste"
    '            Case RadGridStringId.EditMenuItem
    '                Return "Edit"
    '            Case RadGridStringId.ClearValueMenuItem
    '                Return "Clear Value"
    '            Case RadGridStringId.CopyMenuItem
    '                Return "Copy"
    '            Case RadGridStringId.CutMenuItem
    '                Return "Cut"
    '            Case RadGridStringId.AddNewRowString
    '                Return "Click here to add a new row"
    '            Case RadGridStringId.SearchRowResultsOfLabel
    '                Return "of"
    '            Case RadGridStringId.SearchRowMatchCase
    '                Return "Match case"
    '            Case RadGridStringId.ConditionalFormattingSortAlphabetically
    '                Return "Sort columns alphabetically"
    '            Case RadGridStringId.ConditionalFormattingCaption
    '                Return "Conditional Formatting Rules Manager"
    '            Case RadGridStringId.ConditionalFormattingLblColumn
    '                Return "Format only cells with"
    '            Case RadGridStringId.ConditionalFormattingLblName
    '                Return "Rule name"
    '            Case RadGridStringId.ConditionalFormattingLblType
    '                Return "Cell value"
    '            Case RadGridStringId.ConditionalFormattingLblValue1
    '                Return "Value 1"
    '            Case RadGridStringId.ConditionalFormattingLblValue2
    '                Return "Value 2"
    '            Case RadGridStringId.ConditionalFormattingGrpConditions
    '                Return "Rules"
    '            Case RadGridStringId.ConditionalFormattingGrpProperties
    '                Return "Rule Properties"
    '            Case RadGridStringId.ConditionalFormattingChkApplyToRow
    '                Return "Apply this formatting to entire row"
    '            Case RadGridStringId.ConditionalFormattingChkApplyOnSelectedRows
    '                Return "Apply this formatting if the row is selected"
    '            Case RadGridStringId.ConditionalFormattingBtnAdd
    '                Return "Add new rule"
    '            Case RadGridStringId.ConditionalFormattingBtnRemove
    '                Return "Remove"
    '            Case RadGridStringId.ConditionalFormattingBtnOK
    '                Return "OK"
    '            Case RadGridStringId.ConditionalFormattingBtnCancel
    '                Return "Cancel"
    '            Case RadGridStringId.ConditionalFormattingBtnApply
    '                Return "Apply"
    '            Case RadGridStringId.ConditionalFormattingRuleAppliesOn
    '                Return "Rule applies to"
    '            Case RadGridStringId.ConditionalFormattingCondition
    '                Return "Condition"
    '            Case RadGridStringId.ConditionalFormattingExpression
    '                Return "Expression"
    '            Case RadGridStringId.ConditionalFormattingChooseOne
    '                Return "[Choose one]"
    '            Case RadGridStringId.ConditionalFormattingEqualsTo
    '                Return "equals to [Value1]"
    '            Case RadGridStringId.ConditionalFormattingIsNotEqualTo
    '                Return "is not equal to [Value1]"
    '            Case RadGridStringId.ConditionalFormattingStartsWith
    '                Return "starts with [Value1]"
    '            Case RadGridStringId.ConditionalFormattingEndsWith
    '                Return "ends with [Value1]"
    '            Case RadGridStringId.ConditionalFormattingContains
    '                Return "contains [Value1]"
    '            Case RadGridStringId.ConditionalFormattingDoesNotContain
    '                Return "does not contain [Value1]"
    '            Case RadGridStringId.ConditionalFormattingIsGreaterThan
    '                Return "is greater than [Value1]"
    '            Case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual
    '                Return "is greater than or equal [Value1]"
    '            Case RadGridStringId.ConditionalFormattingIsLessThan
    '                Return "is less than [Value1]"
    '            Case RadGridStringId.ConditionalFormattingIsLessThanOrEqual
    '                Return "is less than or equal to [Value1]"
    '            Case RadGridStringId.ConditionalFormattingIsBetween
    '                Return "is between [Value1] and [Value2]"
    '            Case RadGridStringId.ConditionalFormattingIsNotBetween
    '                Return "is not between [Value1] and [Value1]"





    '            Case RadGridStringId.ColumnChooserFormCaption
    '                Return "Column Chooser"
    '            Case RadGridStringId.ColumnChooserFormMessage
    '                Return "Drag a column header from the" & vbLf & "grid here to remove it from" & vbLf & "the current view."
    '            Case RadGridStringId.GroupingPanelDefaultMessage
    '                Return "Drag a column here to group by this column."
    '            Case RadGridStringId.GroupingPanelHeader
    '                Return "Group by:"

    '            Case RadGridStringId.CompositeFilterFormErrorCaption
    '                Return "Filter Error"

    '            Case RadGridStringId.ExpressionMenuItem
    '                Return "Expression"
    '            Case RadGridStringId.ExpressionFormTitle
    '                Return "Expression Builder"
    '            Case RadGridStringId.ExpressionFormFunctions
    '                Return "Functions"
    '            Case RadGridStringId.ExpressionFormFunctionsText
    '                Return "Text"
    '            Case RadGridStringId.ExpressionFormFunctionsAggregate
    '                Return "Aggregate"
    '            Case RadGridStringId.ExpressionFormFunctionsDateTime
    '                Return "Date-Time"
    '            Case RadGridStringId.ExpressionFormFunctionsLogical
    '                Return "Logical"
    '            Case RadGridStringId.ExpressionFormFunctionsMath
    '                Return "Math"
    '            Case RadGridStringId.ExpressionFormFunctionsOther
    '                Return "Other"
    '            Case RadGridStringId.ExpressionFormOperators
    '                Return "Operators"
    '            Case RadGridStringId.ExpressionFormConstants
    '                Return "Constants"
    '            Case RadGridStringId.ExpressionFormFields
    '                Return "Fields"
    '            Case RadGridStringId.ExpressionFormDescription
    '                Return "Description"
    '            Case RadGridStringId.ExpressionFormResultPreview
    '                Return "Result preview"
    '            Case RadGridStringId.ExpressionFormTooltipPlus
    '                Return "Plus"
    '            Case RadGridStringId.ExpressionFormTooltipMinus
    '                Return "Minus"
    '            Case RadGridStringId.ExpressionFormTooltipMultiply
    '                Return "Multiply"
    '            Case RadGridStringId.ExpressionFormTooltipDivide
    '                Return "Divide"
    '            Case RadGridStringId.ExpressionFormTooltipModulo
    '                Return "Modulo"
    '            Case RadGridStringId.ExpressionFormTooltipEqual
    '                Return "Equal"
    '            Case RadGridStringId.ExpressionFormTooltipNotEqual
    '                Return "Not Equal"
    '            Case RadGridStringId.ExpressionFormTooltipLess
    '                Return "Less"
    '            Case RadGridStringId.ExpressionFormTooltipLessOrEqual
    '                Return "Less Or Equal"
    '            Case RadGridStringId.ExpressionFormTooltipGreaterOrEqual
    '                Return "Greater Or Equal"
    '            Case RadGridStringId.ExpressionFormTooltipGreater
    '                Return "Greater"
    '            Case RadGridStringId.ExpressionFormTooltipAnd
    '                Return "Logical ""AND"""
    '            Case RadGridStringId.ExpressionFormTooltipOr
    '                Return "Logical ""OR"""
    '            Case RadGridStringId.ExpressionFormTooltipNot
    '                Return "Logical ""NOT"""

    '        End Select

    '        Return String.Empty
    '    End Function
    'End Class
End Namespace
