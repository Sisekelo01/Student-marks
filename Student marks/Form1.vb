Public Class Form1
    Private Sub resultBtn_Click(sender As Object, e As EventArgs) Handles resultBtn.Click
        Dim marks As Integer
        marks = txtmark.Text


        If IsNumeric(txtmark.Text) Then
            marks = Integer.Parse(txtmark.Text)
        Else msgbox("enter a number")
        End If

        If marks >= 80 Then
            MsgBox("Passed with distinction")
        ElseIf marks >= 50 And marks <= 80 Then
            MsgBox("Passed")
        ElseIf marks < 50 Then
            MsgBox("failed")







        End If





    End Sub
End Class
