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
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.pnlBody = New System.Windows.Forms.Panel()
		Me.pnlBaseHeader.SuspendLayout()
		Me.pnlHeader.SuspendLayout()
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
		'Label1
		'
		Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
		Me.Label1.Font = New System.Drawing.Font("正調祥南行書体P", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.Label1.Location = New System.Drawing.Point(0, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(211, 34)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Sample"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'pnlBody
		'
		Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnlBody.Location = New System.Drawing.Point(0, 36)
		Me.pnlBody.Name = "pnlBody"
		Me.pnlBody.Size = New System.Drawing.Size(800, 414)
		Me.pnlBody.TabIndex = 1
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
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents pnlBaseHeader As Panel
	Friend WithEvents Label1 As Label
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Panel2 As Panel
	Friend WithEvents pnlHeader As Panel
	Friend WithEvents pnlBody As Panel
End Class
