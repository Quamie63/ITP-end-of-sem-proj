Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate algorithm selection dropdown
        AlgorithmComboBox.Items.AddRange({"Bubble Sort", "Insertion Sort", "Linear Search", "Binary Search"})

        ' Select default data input Random
        RandomRadioButton.Checked = True
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        ' Determine selected algorithm and data input
        Dim algorithm As String = AlgorithmComboBox.SelectedItem.ToString()
        Dim dataInput As String = If(RandomRadioButton.Checked, "Random", "File")

        ' Perform the selected algorithm and get algorithm steps
        Dim inputData As List(Of Integer)
        If dataInput = "Random" Then
            inputData = GenerateRandomData()
        Else
            If String.IsNullOrEmpty(FilePathTextBox.Text) Then
                MessageBox.Show("Please select a file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            inputData = ReadDataFromFile(FilePathTextBox.Text)
        End If

        Dim itemToSearch As Integer = 0
        If algorithm = "Linear Search" OrElse algorithm = "Binary Search" Then
            If Not Integer.TryParse(ItemToSearchTextBox.Text, itemToSearch) Then
                MessageBox.Show("Please enter a valid integer to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If

        Dim algorithmSteps As List(Of String) = PerformAlgorithm(algorithm, inputData, itemToSearch)

        ' Display algorithm steps
        Dim stepsForm As New Form2
        stepsForm.DisplaySteps(algorithmSteps)
        stepsForm.ShowDialog()

        ' Get the final result
        Dim finalResult As String = GetFinalResult(algorithmSteps)

        ' Display final result
        MessageBox.Show(finalResult, "Final Result")
    End Sub

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        ' Open file dialog to select a file
        Dim openFileDialog As New OpenFileDialog()
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            FilePathTextBox.Text = openFileDialog.FileName
        End If
    End Sub

    ' Function to generate random data
    Private Function GenerateRandomData() As List(Of Integer)
        Dim random As New Random()
        Dim data As New List(Of Integer)()
        For i As Integer = 0 To 9
            data.Add(random.Next(0, 20))
        Next
        Return data
    End Function

    ' Function to read data from a file
    Private Function ReadDataFromFile(filePath As String) As List(Of Integer)
        Dim data As New List(Of Integer)()
        Try
            Dim lines As String() = File.ReadAllLines(filePath)
            For Each line As String In lines
                Dim value As Integer
                If Integer.TryParse(line, value) Then
                    data.Add(value)
                End If
            Next
        Catch ex As DirectoryNotFoundException
            MessageBox.Show("Directory not found: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Log the error
            My.Computer.FileSystem.WriteAllText("error.log", "Directory not found: " & ex.Message & vbCrLf, True)
        Catch ex As IOException
            MessageBox.Show("An IO error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Log the error
            My.Computer.FileSystem.WriteAllText("error.log", "IO error: " & ex.Message & vbCrLf, True)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Log the error
            My.Computer.FileSystem.WriteAllText("error.log", "Unexpected error: " & ex.Message & vbCrLf, True)
        End Try
        Return data
    End Function


    Private Function PerformAlgorithm(algorithm As String, inputData As List(Of Integer), Optional itemToSearch As Integer = 0) As List(Of String)
        Dim algorithmSteps As New List(Of String)

        ' Determine which algorithm to perform
        Select Case algorithm
            Case "Bubble Sort"
                algorithmSteps.AddRange(BubbleSort(inputData))
            Case "Insertion Sort"
                algorithmSteps.AddRange(InsertionSort(inputData))
            Case "Linear Search"
                ' Perform linear search algorithm
                algorithmSteps.AddRange(LinearSearch(inputData, itemToSearch))
            Case "Binary Search"
                ' Perform binary search algorithm
                algorithmSteps.AddRange(BinarySearch(inputData, itemToSearch))
            Case Else
                algorithmSteps.Add("Selected algorithm not implemented yet")
        End Select

        Return algorithmSteps
    End Function

    ' Define BubbleSort function to implement the Bubble Sort algorithm
    Private Function BubbleSort(data As List(Of Integer)) As List(Of String)
        Dim steps As New List(Of String)()

        ' Check if the data is empty
        If data.Count = 0 Then
            MessageBox.Show("Nothing to sort, please provide valid data or file")
            Return steps
        End If

        steps.Add("Before: " & String.Join(" ", data))

        ' Implement Bubble Sort algorithm and generate steps
        Dim n As Integer = data.Count
        For i As Integer = 0 To n - 2
            For j As Integer = 0 To n - i - 2
                If data(j) > data(j + 1) Then
                    Dim temp As Integer = data(j)
                    data(j) = data(j + 1)
                    data(j + 1) = temp
                End If
            Next
            steps.Add("Step " & (i + 1) & ": " & String.Join(" ", data))
        Next

        Return steps
    End Function


    ' Define InsertionSort function to implement the Insertion Sort algorithm
    Private Function InsertionSort(data As List(Of Integer)) As List(Of String)
        Dim steps As New List(Of String)()

        ' Check if the data is empty
        If data.Count = 0 Then
            MessageBox.Show("Nothing to sort, please provide valid data or file")
            Return steps
        End If

        ' Add initial data
        steps.Add("Before: " & String.Join(" ", data))

        ' Implement Insertion Sort algorithm and generate steps
        Dim n As Integer = data.Count
        For i As Integer = 1 To n - 1
            Dim key As Integer = data(i)
            Dim j As Integer = i - 1

            While j >= 0 AndAlso data(j) > key
                data(j + 1) = data(j)
                j -= 1
            End While

            data(j + 1) = key
            steps.Add("Step " & i & ": " & String.Join(" ", data))
        Next

        Return steps
    End Function


    ' Define LinearSearch function to implement the Linear Search algorithm
    Private Function LinearSearch(data As List(Of Integer), itemToSearch As Integer) As List(Of String)
        Dim steps As New List(Of String)

        steps.Add("Linear Search algorithm steps:")
        steps.Add("Data: " & String.Join(" ", data))

        Dim found As Boolean = False

        For i As Integer = 0 To data.Count - 1
            If data(i) = itemToSearch Then
                steps.Add("Item " & itemToSearch & " found at index " & i)
                found = True
                Exit For
            End If
        Next

        If Not found Then
            steps.Add("Item " & itemToSearch & " not found")
        End If

        Return steps
    End Function


    ' Define BinarySearch function to implement the Binary Search algorithm
    Private Function BinarySearch(data As List(Of Integer), itemToSearch As Integer) As List(Of String)
        Dim steps As New List(Of String)

        steps.Add("Binary Search algorithm steps:")
        steps.Add("Data: " & String.Join(" ", data))

        ' Perform binary search
        Dim low As Integer = 0
        Dim high As Integer = data.Count - 1
        Dim found As Boolean = False

        While low <= high
            Dim mid As Integer = (low + high) \ 2
            Dim guess As Integer = data(mid)

            If guess = itemToSearch Then
                steps.Add("Item " & itemToSearch & " found at index " & mid)
                found = True
                Exit While
            End If

            If guess > itemToSearch Then
                high = mid - 1
            Else
                low = mid + 1
            End If
        End While

        If Not found Then
            steps.Add("Item " & itemToSearch & " not found")
        End If

        Return steps
    End Function

    Private Function GetFinalResult(algorithmSteps As List(Of String)) As String
        'return a success message
        Return "Algorithm completed successfully"
    End Function


End Class
