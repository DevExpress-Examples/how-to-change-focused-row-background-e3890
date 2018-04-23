Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Data
Imports DevExpress.Xpf.Grid
Imports System.Windows.Media

Namespace SLGridExample
	Public Class SelectionStateToBrushConverter
		Implements IValueConverter

		Public Property NormalBrush() As SolidColorBrush
		Public Property FocusedBrush() As SolidColorBrush
		Public Property SelectedBrush() As SolidColorBrush
		Public Property FocusedAndSelectedBrush() As SolidColorBrush

		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			Dim state As SelectionState = CType(value, SelectionState)

			If state = SelectionState.Focused Then
				Return FocusedBrush
			End If

			If state = SelectionState.Selected Then
				Return SelectedBrush
			End If

			If state = SelectionState.FocusedAndSelected Then
				Return If(FocusedAndSelectedBrush IsNot Nothing, FocusedAndSelectedBrush, FocusedBrush)
			End If

			Return NormalBrush
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function
	End Class
End Namespace
