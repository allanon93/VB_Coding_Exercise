Public Class form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' center the App

        CenterToScreen()

    End Sub

    Private Sub btnExercise1_Click(sender As Object, e As EventArgs) Handles btnExercise1.Click

        ' output each item one after another

        ' create variables
        Dim aiData(4) As Integer
        Dim i As Integer

        ' assign values to variables
        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        ' for each integer in range 0 - 4 display a msgbox
        For i = 0 To 4
            MsgBox(aiData(i) & " is a value found in the array.",
                   MsgBoxStyle.OkOnly, "Coding Exercise: 1")
        Next

    End Sub

    Private Sub btnExercise2_Click(sender As Object, e As EventArgs) Handles btnExercise2.Click

        ' output all items in same box

        ' create variables
        Dim aiData(4) As Integer
        Dim stResult As String

        ' assign values to variables
        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        ' join values in aiData with new line and store in stResult
        stResult = String.Join(vbCrLf, aiData)

        ' display stResult
        MsgBox("The values in the array are:" & vbCrLf & stResult,
               MsgBoxStyle.OkOnly, "Coding Exercise: 2")

    End Sub

    Private Sub btnExercise3_Click(sender As Object, e As EventArgs) Handles btnExercise3.Click

        ' total all items and display result

        ' create variables
        Dim aiData(4) As Integer
        Dim i As Integer
        Dim iSum As Integer = 0

        ' assign values to variables
        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        ' for integers in range 0 - 4 add each integer to previous and store as iSum
        For i = 0 To 4
            iSum = iSum + aiData(i)
        Next

        ' display iSum
        MsgBox("The sum of the values is: " & iSum,
               MsgBoxStyle.OkOnly, "Coding Exercise: 3")

    End Sub

    Private Sub btnExercise4_Click(sender As Object, e As EventArgs) Handles btnExercise4.Click

        ' average the items and display value

        ' create variables
        Dim aiData(4) As Integer
        Dim i As Integer
        Dim iSum As Integer
        Dim iAverage As Integer

        ' assign values to variables
        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        ' for integers in range 0 - 4 add each integer to previous and store as iSum
        For i = 0 To 4
            iSum = iSum + aiData(i)
        Next

        ' divide iSum by length of array aiData
        iAverage = iSum / aiData.Length

        ' display iAverage
        MsgBox("The average of the values is: " & iAverage,
               MsgBoxStyle.OkOnly, "Coding Exercise: 4")

    End Sub

    Private Sub btnExercise5_Click(sender As Object, e As EventArgs) Handles btnExercise5.Click

        ' add items greater than twenty and display result

        ' create variables
        Dim aiData(4) As Integer
        Dim i As Integer
        Dim iSum As Integer

        ' assign values to variables
        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        ' for integers in range 0 - 4 collect variables greater than twenty;
        '   add each integer to previous and store as iSum
        For i = 0 To 4
            If aiData(i) > 20 Then
                iSum = iSum + aiData(i)
            End If
        Next

        ' display iSum
        MsgBox("The sum of the values larger than twenty is: " & iSum,
               MsgBoxStyle.OkOnly, "Coding Exercise: 5")

    End Sub

    Private Sub btnExercise6_Click(sender As Object, e As EventArgs) Handles btnExercise6.Click

        ' display largest item

        ' create variables
        Dim aiData(4) As Integer
        Dim iMax As Integer

        ' assign values to variables
        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        ' find and store maximum value in array aiData with Max function as iMax
        iMax = aiData.Max

        ' display iMax
        MsgBox("The largest value is: " & iMax,
               MsgBoxStyle.OkOnly, "Coding Exercise: 6")

    End Sub

    Private Sub btnExercise7_Click(sender As Object, e As EventArgs) Handles btnExercise7.Click

        ' display smallest item

        ' create variables
        Dim aiData(4) As Integer
        Dim iMin As Integer

        ' assign values to variables
        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        ' find and store minimum value in array aiData with Min function as iMin
        iMin = aiData.Min

        ' display iMin
        MsgBox("The smallest value is: " & iMin,
               MsgBoxStyle.OkOnly, "Coding Exercise: 7")

    End Sub

    Private Sub btnExercise8_Click(sender As Object, e As EventArgs) Handles btnExercise8.Click

        ' double each item and display results

        ' create variables
        Dim aiData(4) As Integer
        Dim aiDoubleData(4) As Integer
        Dim i As Integer
        Dim stResult As String

        ' assign values to variables
        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        ' for integers in range 0 - 4 for both aiDoubleData and aiData;
        '   multiply aiData value by two and store new value in aiDoubleData
        For i = 0 To 4
            aiDoubleData(i) = aiData(i) * 2
        Next

        ' join values in aiDoubleData with new lines and store in stResult
        stResult = String.Join(vbCrLf, aiDoubleData)

        ' display stResult
        MsgBox("Here are all the values in the array, but doubled:" & vbCrLf & stResult,
               MsgBoxStyle.OkOnly, "Coding Exercise: 8")
    End Sub

End Class
