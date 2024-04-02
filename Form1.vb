Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        MsgBox("hello world")
        MsgBox("how are you ")
        MsgBox("I hope you are well")

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnMsBox.Click

        ' Different ways to display something on to the screen

        'the way of doing it
        MsgBox("Welcome to the VB.net framework personal studies")

        'the Oop way of doing it 
        MessageBox.Show("This is the power of Oops")

    End Sub

    Private Sub btnVariable_Click(sender As Object, e As EventArgs) Handles btnVariable.Click

        'Variables declarations
        'st = string

        Dim stFirstName As String
        Dim lsLastName As String

        stFirstName = "Joshua"
        lsLastName = "Tulasi"

        MessageBox.Show("Hello and welcome to " & lsLastName & "'s" & " workSpace")
        MessageBox.Show("Remember that my first name is " & stFirstName & " my lastname is " & lsLastName)

        'DataTypes in Vb.net programming



    End Sub

    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click
        ' variables declarations
        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColour As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtDateRegistered As Date

        'variables assignments
        stMake = "Ford"
        stModel = "Escort"
        iDoors = "5"
        stColour = "Grey"
        bTaxed = True
        iEngineSize = 1200
        decPrice = 999.99
        dtDateRegistered = #4/2/2024#

        MessageBox.Show("Tulasi's car is " & stMake & " with the below properties : " & vbNewLine &
            stModel & vbNewLine & iDoors & vbNewLine & stColour & vbNewLine & bTaxed & vbNewLine &
            iEngineSize & vbNewLine & decPrice & vbNewLine & dtDateRegistered)


    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        'The inputBox method is use to capture string variables

        Dim stFirstName As String
        stFirstName = InputBox("Please enter your first name: ")

        MessageBox.Show("Your first name is " & stFirstName)

    End Sub
End Class