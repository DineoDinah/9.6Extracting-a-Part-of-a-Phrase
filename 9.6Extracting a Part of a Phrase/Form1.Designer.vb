<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		BtnExtract = New Button()
		Label1 = New Label()
		Label2 = New Label()
		Label3 = New Label()
		Label4 = New Label()
		TextBox1 = New TextBox()
		TextBox2 = New TextBox()
		TextBox3 = New TextBox()
		TextBox4 = New TextBox()
		SuspendLayout()
		' 
		' BtnExtract
		' 
		BtnExtract.Location = New Point(352, 275)
		BtnExtract.Name = "BtnExtract"
		BtnExtract.Size = New Size(112, 34)
		BtnExtract.TabIndex = 0
		BtnExtract.Text = "Extract"
		BtnExtract.UseVisualStyleBackColor = True
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(153, 38)
		Label1.Name = "Label1"
		Label1.Size = New Size(124, 25)
		Label1.TabIndex = 1
		Label1.Text = "Enter a phrase"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(61, 92)
		Label2.Name = "Label2"
		Label2.Size = New Size(216, 25)
		Label2.TabIndex = 1
		Label2.Text = "Enter the Starting Position"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(12, 140)
		Label3.Name = "Label3"
		Label3.Size = New Size(265, 25)
		Label3.TabIndex = 1
		Label3.Text = "Number of Characters to Extract"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Location = New Point(183, 209)
		Label4.Name = "Label4"
		Label4.Size = New Size(119, 25)
		Label4.TabIndex = 1
		Label4.Text = "Text Extracted"
		' 
		' TextBox1
		' 
		TextBox1.Location = New Point(342, 32)
		TextBox1.Name = "TextBox1"
		TextBox1.Size = New Size(150, 31)
		TextBox1.TabIndex = 2
		' 
		' TextBox2
		' 
		TextBox2.Location = New Point(342, 92)
		TextBox2.Name = "TextBox2"
		TextBox2.Size = New Size(150, 31)
		TextBox2.TabIndex = 2
		' 
		' TextBox3
		' 
		TextBox3.Location = New Point(342, 140)
		TextBox3.Name = "TextBox3"
		TextBox3.Size = New Size(150, 31)
		TextBox3.TabIndex = 2
		' 
		' TextBox4
		' 
		TextBox4.Location = New Point(342, 203)
		TextBox4.Name = "TextBox4"
		TextBox4.Size = New Size(150, 31)
		TextBox4.TabIndex = 2
		' 
		' form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(TextBox4)
		Controls.Add(TextBox3)
		Controls.Add(TextBox2)
		Controls.Add(TextBox1)
		Controls.Add(Label4)
		Controls.Add(Label3)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Controls.Add(BtnExtract)
		Name = "form1"
		Text = "Form1"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents BtnExtract As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents TextBox4 As TextBox
End Class
