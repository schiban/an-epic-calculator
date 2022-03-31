Option Explicit On

'Em Criação!!



Public Class Form3
    Dim FirstNumber As Single
    Dim SecondNumber As Single
    Dim ThirdNumber As Single
    Dim AnswerNumber As Single
    Dim ArithmeticProcess As String
    Private Sub cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click
        txtDisplay.Text = txtDisplay.Text & "1"
    End Sub

    Private Sub cmd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd2.Click
        txtDisplay.Text = txtDisplay.Text & "2"
    End Sub

    Private Sub cmd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd3.Click
        txtDisplay.Text = txtDisplay.Text & "3"
    End Sub

    Private Sub cmd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd4.Click
        txtDisplay.Text = txtDisplay.Text & "4"
    End Sub

    Private Sub cmd5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd5.Click
        txtDisplay.Text = txtDisplay.Text & "5"
    End Sub

    Private Sub cmd6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd6.Click
        txtDisplay.Text = txtDisplay.Text & "6"
    End Sub

    Private Sub cmd7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd7.Click
        txtDisplay.Text = txtDisplay.Text & "7"
    End Sub

    Private Sub cmd8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd8.Click
        txtDisplay.Text = txtDisplay.Text & "8"
    End Sub

    Private Sub cmd9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd9.Click
        txtDisplay.Text = txtDisplay.Text & "9"
    End Sub

    Private Sub cmd0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd0.Click
        txtDisplay.Text = txtDisplay.Text & "0"
    End Sub

    Private Sub cmddecimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddecimal.Click
        txtDisplay.Text = txtDisplay.Text & "."
    End Sub

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        txtDisplay.Text = " "
        txtDisplay1.Text = " "
        txtDisplay2.Text = " "
        txtDisplay3.Text = " "
    End Sub

    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = "+"
    End Sub

    Private Sub cmdsubtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsubtract.Click
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = "-"
    End Sub

    Private Sub cmdmultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmultiply.Click
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = "X"
    End Sub

    Private Sub cmddivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddivide.Click
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = "/"
    End Sub

    Private Sub cmdequals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdequals.Click
        SecondNumber = Val(txtDisplay.Text)
        If ArithmeticProcess = "+" Then
            AnswerNumber = FirstNumber + SecondNumber
        End If
        If ArithmeticProcess = "-" Then
            AnswerNumber = FirstNumber - SecondNumber
        End If
        If ArithmeticProcess = "X" Then
            AnswerNumber = FirstNumber * SecondNumber
        End If
        If ArithmeticProcess = "/" Then
            AnswerNumber = FirstNumber / SecondNumber
        End If

        '---------------------------------------------------------------------------
        If ArithmeticProcess = "Triângulo" Then
            Dim b, h As Integer
            txtDisplay1.Text = b
            txtDisplay2.Text = h
            AnswerNumber = (b * h) / 2
        End If


        txtDisplay.Text = AnswerNumber
    End Sub

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        End
    End Sub

    Private Sub CientíficoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CientíficoToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub ÁreasEVolumesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÁreasEVolumesToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Área do Triângulo
        FirstNumber = Val(txtDisplay1.Text)
        txtDisplay1.Text = "Base é igual a"
        txtDisplay2.Text = "Altura é igual a"
        ArithmeticProcess = "Triângulo"






        'Em Criação!!
    End Sub
End Class