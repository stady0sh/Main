Public Class PictureBoxID

	Public Property Checked As Boolean
		Get
			Return Me.chkSelect.Checked
		End Get
		Set(value As Boolean)
			Me.chkSelect.Checked = value
		End Set
	End Property

	Public Property Image As Image
		Get
			Return Me.pctPhoto.Image
		End Get
		Set(value As Image)
			Me.pctPhoto.Image = value
		End Set
	End Property

End Class
