<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        AlgorithmComboBox = New ComboBox()
        RandomRadioButton = New RadioButton()
        FileRadioButton = New RadioButton()
        StartButton = New Button()
        ItemToSearchTextBox = New TextBox()
        BrowseButton = New Button()
        FilePathTextBox = New TextBox()
        SuspendLayout()
        ' 
        ' AlgorithmComboBox
        ' 
        AlgorithmComboBox.FormattingEnabled = True
        AlgorithmComboBox.Location = New Point(200, 52)
        AlgorithmComboBox.Name = "AlgorithmComboBox"
        AlgorithmComboBox.Size = New Size(260, 33)
        AlgorithmComboBox.TabIndex = 0
        AlgorithmComboBox.Text = "Select Algorithm"
        ' 
        ' RandomRadioButton
        ' 
        RandomRadioButton.AutoSize = True
        RandomRadioButton.Location = New Point(200, 264)
        RandomRadioButton.Name = "RandomRadioButton"
        RandomRadioButton.Size = New Size(105, 29)
        RandomRadioButton.TabIndex = 1
        RandomRadioButton.TabStop = True
        RandomRadioButton.Text = "Random"
        RandomRadioButton.UseVisualStyleBackColor = True
        ' 
        ' FileRadioButton
        ' 
        FileRadioButton.AutoSize = True
        FileRadioButton.Location = New Point(397, 264)
        FileRadioButton.Name = "FileRadioButton"
        FileRadioButton.Size = New Size(63, 29)
        FileRadioButton.TabIndex = 2
        FileRadioButton.TabStop = True
        FileRadioButton.Text = "File"
        FileRadioButton.UseVisualStyleBackColor = True
        ' 
        ' StartButton
        ' 
        StartButton.Location = New Point(200, 322)
        StartButton.Name = "StartButton"
        StartButton.Size = New Size(260, 57)
        StartButton.TabIndex = 3
        StartButton.Text = "Start"
        StartButton.UseVisualStyleBackColor = True
        ' 
        ' ItemToSearchTextBox
        ' 
        ItemToSearchTextBox.Location = New Point(200, 183)
        ItemToSearchTextBox.Multiline = True
        ItemToSearchTextBox.Name = "ItemToSearchTextBox"
        ItemToSearchTextBox.PlaceholderText = "Enter Value To Search"
        ItemToSearchTextBox.Size = New Size(260, 41)
        ItemToSearchTextBox.TabIndex = 4
        ' 
        ' BrowseButton
        ' 
        BrowseButton.Location = New Point(366, 124)
        BrowseButton.Name = "BrowseButton"
        BrowseButton.Size = New Size(94, 41)
        BrowseButton.TabIndex = 5
        BrowseButton.Text = "Browse"
        BrowseButton.UseVisualStyleBackColor = True
        ' 
        ' FilePathTextBox
        ' 
        FilePathTextBox.Location = New Point(200, 124)
        FilePathTextBox.Multiline = True
        FilePathTextBox.Name = "FilePathTextBox"
        FilePathTextBox.Size = New Size(160, 41)
        FilePathTextBox.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(684, 536)
        Controls.Add(FilePathTextBox)
        Controls.Add(BrowseButton)
        Controls.Add(ItemToSearchTextBox)
        Controls.Add(StartButton)
        Controls.Add(FileRadioButton)
        Controls.Add(RandomRadioButton)
        Controls.Add(AlgorithmComboBox)
        Name = "Form1"
        Text = "MainForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AlgorithmComboBox As ComboBox
    Friend WithEvents RandomRadioButton As RadioButton
    Friend WithEvents FileRadioButton As RadioButton
    Friend WithEvents StartButton As Button
    Friend WithEvents ItemToSearchTextBox As TextBox
    Friend WithEvents BrowseButton As Button
    Friend WithEvents FilePathTextBox As TextBox

End Class
