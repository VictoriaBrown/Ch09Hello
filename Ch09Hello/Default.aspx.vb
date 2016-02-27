'Web Site:           Ch09Hello
'Web page:           Default.aspx
'Programmer:         Victoria Brown
'Date:               February 2016
'Description:        Concatenate the name and display in a label.

Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub SubmitButton_Click(ByVal sender As Object,
      ByVal e As System.EventArgs) Handles SubmitButton.Click
        'Display the name and a message.

        MessageLabel.Text = "Hello " & NameTextBox.Text & "!"
    End Sub
End Class