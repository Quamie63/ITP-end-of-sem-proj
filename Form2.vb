Public Class Form2


    Public Sub DisplaySteps(steps As List(Of String))
        ' Display each step in the TextBox
        For Each stepText As String In steps
            StepsTextBox.AppendText(stepText & Environment.NewLine)
        Next
    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        ' Close the current form and return to the main form
        Me.Close()
    End Sub
End Class