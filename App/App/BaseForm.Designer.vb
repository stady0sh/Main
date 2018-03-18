<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaseForm
	Inherits System.Windows.Forms.Form

	'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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
		Me.pnlBaseHeader = New System.Windows.Forms.Panel()
		Me.pnlHeader = New System.Windows.Forms.Panel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.pnlBody = New App.ExPanel()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Button8 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button7 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button6 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.pnlBaseHeader.SuspendLayout()
		Me.pnlHeader.SuspendLayout()
		Me.pnlBody.SuspendLayout()
		Me.SuspendLayout()
		'
		'pnlBaseHeader
		'
		Me.pnlBaseHeader.BackColor = System.Drawing.Color.Transparent
		Me.pnlBaseHeader.Controls.Add(Me.pnlHeader)
		Me.pnlBaseHeader.Controls.Add(Me.Panel3)
		Me.pnlBaseHeader.Controls.Add(Me.Panel2)
		Me.pnlBaseHeader.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnlBaseHeader.Location = New System.Drawing.Point(0, 0)
		Me.pnlBaseHeader.Name = "pnlBaseHeader"
		Me.pnlBaseHeader.Size = New System.Drawing.Size(800, 36)
		Me.pnlBaseHeader.TabIndex = 0
		'
		'pnlHeader
		'
		Me.pnlHeader.BackColor = System.Drawing.Color.LavenderBlush
		Me.pnlHeader.Controls.Add(Me.Label1)
		Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnlHeader.Location = New System.Drawing.Point(13, 0)
		Me.pnlHeader.Name = "pnlHeader"
		Me.pnlHeader.Size = New System.Drawing.Size(787, 34)
		Me.pnlHeader.TabIndex = 3
		'
		'Label1
		'
		Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.Label1.Location = New System.Drawing.Point(0, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(211, 34)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Sample"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.Pink
		Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.Panel3.Location = New System.Drawing.Point(13, 34)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(787, 2)
		Me.Panel3.TabIndex = 1
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.Pink
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
		Me.Panel2.Location = New System.Drawing.Point(0, 0)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(13, 36)
		Me.Panel2.TabIndex = 0
		'
		'pnlBody
		'
		Me.pnlBody.AutoScroll = True
		Me.pnlBody.Controls.Add(Me.Button5)
		Me.pnlBody.Controls.Add(Me.Button4)
		Me.pnlBody.Controls.Add(Me.Button8)
		Me.pnlBody.Controls.Add(Me.Button3)
		Me.pnlBody.Controls.Add(Me.Button7)
		Me.pnlBody.Controls.Add(Me.Button2)
		Me.pnlBody.Controls.Add(Me.Button6)
		Me.pnlBody.Controls.Add(Me.Button1)
		Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnlBody.Location = New System.Drawing.Point(0, 36)
		Me.pnlBody.Name = "pnlBody"
		Me.pnlBody.Size = New System.Drawing.Size(800, 414)
		Me.pnlBody.TabIndex = 1
		'
		'Button5
		'
		Me.Button5.Location = New System.Drawing.Point(555, 202)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(295, 116)
		Me.Button5.TabIndex = 4
		Me.Button5.Text = "Button5"
		Me.Button5.UseVisualStyleBackColor = True
		'
		'Button4
		'
		Me.Button4.Location = New System.Drawing.Point(202, 202)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(295, 116)
		Me.Button4.TabIndex = 3
		Me.Button4.Text = "Button4"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'Button8
		'
		Me.Button8.Location = New System.Drawing.Point(739, 31)
		Me.Button8.Name = "Button8"
		Me.Button8.Size = New System.Drawing.Size(295, 116)
		Me.Button8.TabIndex = 2
		Me.Button8.Text = "Button3"
		Me.Button8.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(730, 354)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(295, 116)
		Me.Button3.TabIndex = 2
		Me.Button3.Text = "Button3"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button7
		'
		Me.Button7.Location = New System.Drawing.Point(390, 31)
		Me.Button7.Name = "Button7"
		Me.Button7.Size = New System.Drawing.Size(295, 116)
		Me.Button7.TabIndex = 1
		Me.Button7.Text = "Button2"
		Me.Button7.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(381, 354)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(295, 116)
		Me.Button2.TabIndex = 1
		Me.Button2.Text = "Button2"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button6
		'
		Me.Button6.Location = New System.Drawing.Point(27, 31)
		Me.Button6.Name = "Button6"
		Me.Button6.Size = New System.Drawing.Size(295, 116)
		Me.Button6.TabIndex = 0
		Me.Button6.Text = "Button1"
		Me.Button6.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(18, 354)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(295, 116)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Button1"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'BaseForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.pnlBody)
		Me.Controls.Add(Me.pnlBaseHeader)
		Me.Name = "BaseForm"
		Me.pnlBaseHeader.ResumeLayout(False)
		Me.pnlHeader.ResumeLayout(False)
		Me.pnlBody.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents pnlBaseHeader As Panel
	Friend WithEvents Label1 As Label
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Panel2 As Panel
	Friend WithEvents pnlHeader As Panel
	Friend WithEvents pnlBody As ExPanel
	Friend WithEvents Button5 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents Button8 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents Button7 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button6 As Button
	Friend WithEvents Button1 As Button
End Class
