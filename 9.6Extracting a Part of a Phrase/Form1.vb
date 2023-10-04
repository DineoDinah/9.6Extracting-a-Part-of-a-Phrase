Public Class form1
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnExtract.Click

		Dim myPhrase As String
		Dim pos As Integer
		Dim n As Integer
		Dim TxtExtract


		myPhrase = TextBox1.Text

		pos = TextBox2.Text

		n = TextBox3.Text

		TxtExtract = TextBox4.Text

		TxtExtract = MsgBox(Mid(TextBox1.Text, 5, 6))

	End Sub
End Class
