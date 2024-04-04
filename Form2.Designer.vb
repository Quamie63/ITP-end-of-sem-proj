<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        StepsTextBox = New TextBox()
        ReturnButton = New Button()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        SuspendLayout()
        ' 
        ' StepsTextBox
        ' 
        StepsTextBox.Location = New Point(90, 46)
        StepsTextBox.Multiline = True
        StepsTextBox.Name = "StepsTextBox"
        StepsTextBox.Size = New Size(355, 329)
        StepsTextBox.TabIndex = 0
        ' 
        ' ReturnButton
        ' 
        ReturnButton.Location = New Point(90, 398)
        ReturnButton.Name = "ReturnButton"
        ReturnButton.Size = New Size(355, 59)
        ReturnButton.TabIndex = 1
        ReturnButton.Text = "Return"
        ReturnButton.UseVisualStyleBackColor = True
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(535, 490)
        Controls.Add(ReturnButton)
        Controls.Add(StepsTextBox)
        Name = "Form2"
        Text = "Display Steps Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StepsTextBox As TextBox
    Friend WithEvents ReturnButton As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
