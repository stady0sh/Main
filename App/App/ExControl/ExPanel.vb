Imports System.ComponentModel

Public Class ExPanel
	Inherits Panel

	<DefaultValue(True), Category("ExProperty")>
	Public Property IsAutoScroll As Boolean

	Protected Overrides Function ScrollToControl(c As Control) As Point
		If Me.IsAutoScroll Then
			Return MyBase.ScrollToControl(c)
		Else
			'Return New Point(Me.HorizontalScroll.Value, Me.VerticalScroll.Value)
			Return Point.Empty
		End If


		'Dim p As Point
		'p = MyBase.ScrollToControl(c) '対象のコントロールの左上を表示するための移動量

		'If (TypeOf c Is DataGridView) Then
		'	Dim dgv As DataGridView
		'	dgv = CType(c, DataGridView)

		'	'カレントセルのDataGridViewの左上に対しての相対座標でのセルの位置を取得
		'	Dim rect As Rectangle = dgv.GetCellDisplayRectangle(dgv.CurrentCell.ColumnIndex, dgv.CurrentCell.RowIndex, True)

		'	Dim rectDGV As Rectangle = New Rectangle(0, 0, dgv.Width, dgv.Height)
		'	If (rect.Width > 0 And (rectDGV.Contains(rect) Or rectDGV.IntersectsWith(rect))) Then '必要ないだろうがカレントセルが表示範囲にあるかどうか調べる
		'		p.Offset(-rect.Left, -rect.Top) 'カレントセルの左上が表示されるように移動量を補正。センターに配置したければWindowの大きさの半分をさらに補正してください
		'	End If

		'	'p=Point.Empty 'スクロールさせたくなければ移動量をゼロにしてしまえばいい
		'End If

		'Return p
	End Function



End Class
