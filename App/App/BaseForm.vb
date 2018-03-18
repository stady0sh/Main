Public Class BaseForm

	Public Sub New()
		MyBase.New

		For Each ctrl As Control In Me.pnlBody.Controls
			ctrl.Click += ()
		Next

	End Sub

	'Public Sub New()
	'   {
	'       // デザイナー上ではpanel1の中にButtonが水平に並べてあります。
	'       InitializeComponent();

	'       // パネル内のコントロールにイベントハンドラーを設定
	'       foreach (Control c in panel1.Controls)
	'       {
	'           c.Click += (s, args) => MessageBox.Show(s.ToString());
	'           c.MouseDown += Button_MouseDown;
	'           c.MouseMove += Button_MouseMove;
	'       }
	'   }

	Private void panel1_MouseDown(Object sender, MouseEventArgs e)
    {
        // パネルが普通にクリックされた場合
        panel1.Capture = true;
        _PreviousX = panel1.PointToScreen(e.Location).X;
    }

    Private void panel1_MouseMove(Object sender, MouseEventArgs e)
    {
        If (panel1.Capture)
        {
            // パネルのドラッグ処理
            var x = panel1.PointToScreen(e.Location).X;
            panel1.HorizontalScroll.Value = Math.Min(
                                                Math.Max(
                                                    panel1.HorizontalScroll.Minimum,
                                                    panel1.HorizontalScroll.Value + _PreviousX - x),
                                                    panel1.HorizontalScroll.Maximum);
            _PreviousX = x;
        }
    }

    Private void panel1_MouseUp(Object sender, MouseEventArgs e)
    {
        panel1.Capture = false;
    }

    Private void Button_MouseDown(Object sender, MouseEventArgs e)
    {
        // ボタンがクリックされた場合
        var c = (Control)sender;

        c.Capture = true;

        _PreviousX = c.PointToScreen(e.Location).X;
    }

    Private void Button_MouseMove(Object sender, MouseEventArgs e)
    {
        var c = (Control)sender;
        If (c.Capture)
        {
            // ボタンが押された状態である程度動いたらpanel1にイベントを付け替える
            var x = panel1.PointToScreen(e.Location).X;
            If (Math.Abs(x - _PreviousX) > 3)
            {
                c.Capture = false;
                panel1.Capture = true;
            }
        }
    }


End Class