Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        MsgBox("Hello World!!")

        Dim name As String
        name = "sabri"
        MsgBox("welcome to Dear " & name & " I hope you are well.")

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim carName As String
        Dim carModel As String
        Dim iDoor As Integer
        Dim carColor As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim iDate As Date

        carName = "Ford"
        carModel = "escort"
        iDoor = 5
        carColor = "red"
        bTaxed = True
        iEngineSize = 1.6
        decPrice = 999.99
        iDate = #12/12/2023#

        MsgBox("The car" & " " & carName & " " & " " & carModel & " " & " " & iDoor & " " & " " & carColor & " " & " " & bTaxed & " " & " " & iEngineSize & " " & " " & decPrice & " " & " " & iDate & " ")



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim stFirstName As String
        Dim stLastName As String
        Dim stGander As String
        Dim stSelection As String

        stFirstName = txtFirstName.Text
        stLastName = txtLastName.Text
        stGander = txtGender.Text
        stSelection = lstOccupation.SelectedItem

        MsgBox("Welcome " & stFirstName & " " & stLastName & " " & "you are a " & stGander & " " & stSelection)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOccupation.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intFirstNum As Integer
        Dim intSecondNum As Integer

        Dim dblResult As Double

        intFirstNum = intNumber1.Text
        intSecondNum = intNumber2.Text

        dblResult = intFirstNum + intSecondNum
        MsgBox(dblResult)

        dblResult = intFirstNum - intSecondNum
        MsgBox(dblResult)

        dblResult = intFirstNum * intSecondNum
        MsgBox(dblResult)

        dblResult = intFirstNum / intSecondNum
        MsgBox(dblResult)

        dblResult = intFirstNum ^ intSecondNum
        MsgBox(dblResult)

        dblResult = intFirstNum \ intSecondNum
        MsgBox(dblResult)

        dblResult = intFirstNum Mod intSecondNum
        MsgBox(dblResult)
    End Sub
End Class
