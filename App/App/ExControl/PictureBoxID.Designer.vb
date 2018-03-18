<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PictureBoxID
	Inherits System.Windows.Forms.UserControl

	'UserControl はコンポーネント一覧をクリーンアップするために dispose をオーバーライドします。
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Windows フォーム デザイナーで必要です。
	Private components As System.ComponentModel.IContainer

	'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
	'Windows フォーム デザイナーを使用して変更できます。  
	'コード エディターを使って変更しないでください。
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.txtID = New System.Windows.Forms.TextBox()
		Me.pctPhoto = New System.Windows.Forms.PictureBox()
		Me.chkSelect = New System.Windows.Forms.CheckBox()
		CType(Me.pctPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'txtID
		'
		Me.txtID.Location = New System.Drawing.Point(3, 3)
		Me.txtID.Name = "txtID"
		Me.txtID.Size = New System.Drawing.Size(100, 19)
		Me.txtID.TabIndex = 0
		'
		'pctPhoto
		'
		Me.pctPhoto.Location = New System.Drawing.Point(3, 28)
		Me.pctPhoto.Name = "pctPhoto"
		Me.pctPhoto.Size = New System.Drawing.Size(294, 219)
		Me.pctPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pctPhoto.TabIndex = 1
		Me.pctPhoto.TabStop = False
		'
		'chkSelect
		'
		Me.chkSelect.AutoSize = True
		Me.chkSelect.Location = New System.Drawing.Point(282, 6)
		Me.chkSelect.Name = "chkSelect"
		Me.chkSelect.Size = New System.Drawing.Size(15, 14)
		Me.chkSelect.TabIndex = 2
		Me.chkSelect.UseVisualStyleBackColor = True
		'
		'PictureBoxID
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.chkSelect)
		Me.Controls.Add(Me.pctPhoto)
		Me.Controls.Add(Me.txtID)
		Me.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
		Me.Name = "PictureBoxID"
		Me.Size = New System.Drawing.Size(300, 250)
		CType(Me.pctPhoto, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtID As TextBox
	Friend WithEvents pctPhoto As PictureBox
	Friend WithEvents chkSelect As CheckBox
End Class
