Public Class BaseForm

#Region " メンバ変数 "
	Private _PreviousX As Integer = 0
	Private _PreviousY As Integer = 0
#End Region

#Region " イベント "
	Public Sub New()
		MyBase.New

		' この呼び出しはデザイナーで必要です。
		InitializeComponent()

		' InitializeComponent() 呼び出しの後で初期化を追加します。

		For Each ctrl As Control In Me.pnlBody.Controls
			AddHandler ctrl.MouseDown, AddressOf Control_MouseDown
			AddHandler ctrl.MouseMove, AddressOf Control_MouseMove
		Next

	End Sub
#Region " pnlBody... "
	Private Sub pnlBody_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlBody.MouseDown
		pnlBody.Capture = True
		Me._PreviousX = pnlBody.PointToScreen(e.Location).X
		Me._PreviousY = pnlBody.PointToScreen(e.Location).Y
	End Sub

	Private Sub pnlBody_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlBody.MouseMove

		If pnlBody.Capture Then

			'' X座標の位置修正
			Dim x = pnlBody.PointToScreen(e.Location).X
			pnlBody.HorizontalScroll.Value = Math.Min(
														   Math.Max(
															   pnlBody.HorizontalScroll.Minimum,
															   pnlBody.HorizontalScroll.Value + _PreviousX - x),
															   pnlBody.HorizontalScroll.Maximum)
			Me._PreviousX = x

			'' Y座標の位置修正
			Dim y = pnlBody.PointToScreen(e.Location).Y
			pnlBody.VerticalScroll.Value = Math.Min(
														   Math.Max(
															   pnlBody.VerticalScroll.Minimum,
															   pnlBody.VerticalScroll.Value + _PreviousY - y),
															   pnlBody.VerticalScroll.Maximum)
			Me._PreviousY = y

		End If

	End Sub

	Private Sub pnlBody_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlBody.MouseUp
		pnlBody.Capture = False
	End Sub
#End Region

#Region " Control... "
	Private Sub Control_MouseDown(sender As Object, e As MouseEventArgs)
		Dim ctrl As Control = DirectCast(sender, Control)
		ctrl.Capture = True
		_PreviousX = ctrl.PointToScreen(e.Location).X
		_PreviousY = ctrl.PointToScreen(e.Location).Y
	End Sub

	Private Sub Control_MouseMove(sender As Object, e As MouseEventArgs)

		Dim ctrl As Control = DirectCast(sender, Control)
		If (ctrl.Capture) Then
			'' ボタンが押された状態である程度動いたらpnlBodyにイベントを付け替える
			Dim x As Integer = pnlBody.PointToScreen(e.Location).X
			Dim y As Integer = pnlBody.PointToScreen(e.Location).Y
			If (Math.Abs(x - _PreviousX) > 3) OrElse (Math.Abs(y - _PreviousY) > 3) Then
				ctrl.Capture = False
				pnlBody.Capture = True
			End If
		End If
	End Sub
#End Region
#End Region




End Class