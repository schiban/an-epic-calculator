Option Explicit On
Public Class Form2
    Dim FirstNumber As Single
    Dim SecondNumber As Single
    Dim AnswerNumber As Single
    Dim ArithmeticProcess As String
    Dim i, c, j As Double
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
        'Limpar
        txtDisplay.Text = " "
    End Sub

    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        'Soma
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = "+"
    End Sub

    Private Sub cmdsubtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsubtract.Click
        'Subtração
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = "-"
    End Sub

    Private Sub cmdmultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmultiply.Click
        'Multiplicação
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = "X"
    End Sub

    Private Sub cmddivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddivide.Click
        'Divisão de Números Reais
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
        If ArithmeticProcess = ">" Then
            If (FirstNumber > SecondNumber) Then
                AnswerNumber = FirstNumber
            Else
                AnswerNumber = SecondNumber
            End If
        End If
        If ArithmeticProcess = "<" Then
            If (FirstNumber < SecondNumber) Then
                AnswerNumber = SecondNumber
            Else
                AnswerNumber = FirstNumber
            End If
        End If
        If ArithmeticProcess = "^" Then
            AnswerNumber = FirstNumber ^ SecondNumber
        End If
        If ArithmeticProcess = "COS(" Then
            AnswerNumber = Math.Cos(FirstNumber)
        End If
        If ArithmeticProcess = "SIN(" Then
            AnswerNumber = Math.Sin(FirstNumber)
        End If
        If ArithmeticProcess = "TAN(" Then
            AnswerNumber = Math.Tan(FirstNumber)
        End If
        If ArithmeticProcess = "LOG(" Then
            AnswerNumber = Math.Log(FirstNumber)
        End If
        If ArithmeticProcess = "√" Then
            AnswerNumber = Math.Sqrt(FirstNumber)
        End If
        If ArithmeticProcess = "∜" Then
            AnswerNumber = FirstNumber ^ (1 / 4)
        End If
        If ArithmeticProcess = "∛" Then
            AnswerNumber = FirstNumber ^ (1 / 3)
        End If
        If ArithmeticProcess = "x²" Then
            AnswerNumber = FirstNumber ^ 2
        End If
        If ArithmeticProcess = "x³" Then
            AnswerNumber = FirstNumber ^ 3
        End If
        If ArithmeticProcess = "\" Then
            AnswerNumber = FirstNumber \ SecondNumber
        End If
        If ArithmeticProcess = "MOD" Then
            AnswerNumber = FirstNumber Mod SecondNumber
        End If
        If ArithmeticProcess = "%" Then
            AnswerNumber = FirstNumber / 100
        End If
        If ArithmeticProcess = "P%" Then
            AnswerNumber = (FirstNumber - SecondNumber) / FirstNumber
        End If
        If ArithmeticProcess = "‰" Then
            AnswerNumber = FirstNumber / 1000
        End If
        If ArithmeticProcess = "FAC" Then
            Dim fact As Integer = 0
            Dim i As Integer = 1
            If FirstNumber = 0 Then
                AnswerNumber = 1
            End If
            fact = FirstNumber * i
            For i = 2 To FirstNumber - 1
                fact *= i
            Next
            AnswerNumber = fact
        End If
        If ArithmeticProcess = "Mn" Then
            FirstNumber = 2 ^ FirstNumber - 1
            AnswerNumber = FirstNumber
        End If
        If ArithmeticProcess = "±" Then
            Math.Abs(FirstNumber)
        End If
        If ArithmeticProcess = "(-)" Then
            FirstNumber = (-1 * FirstNumber)
        End If
        If ArithmeticProcess = "Fn" Then
            FirstNumber = 2 ^ (2 ^ FirstNumber) + 1
            AnswerNumber = FirstNumber
        End If
        If ArithmeticProcess = "COSˉ¹(" Then
            AnswerNumber = Math.Cos(FirstNumber) ^ (-1)
        End If
        If ArithmeticProcess = "SINˉ¹(" Then
            AnswerNumber = Math.Sin(FirstNumber) ^ (-1)
        End If
        If ArithmeticProcess = "TANˉ¹(" Then
            AnswerNumber = Math.Tan(FirstNumber) ^ (-1)
        End If
        If ArithmeticProcess = "∑" Then
            Dim soma, num As Integer
            num = FirstNumber
            For soma = 0 To num
                soma += 1
                AnswerNumber = soma
            Next
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

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        'MOD - Resto do quociente dum problema
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = "MOD"
    End Sub

    Private Sub cmdexpoente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexpoente.Click
        'Expoente de um número, ou elevado a ...
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = "^"
    End Sub

    Private Sub cmdmenor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmenor.Click
        'Menor que
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = "<"
    End Sub

    Private Sub cmdmaior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmaior.Click
        'Maior que
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = ">"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Cosseno
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = "COS("
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Seno
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = "SIN("
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Tangente
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = "TAN("
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'Logaritmo
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = "LOG("
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'Pi
        txtDisplay.Text = txtDisplay.Text & "3.141592653589793238462643383279502884197169399375105820974944592307816406286208998628034825342117067982148"
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'Número de Euler
        txtDisplay.Text = txtDisplay.Text & "2.718281828"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'Raíz Quadrada ou Quadrática
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = "√" & FirstNumber
        ArithmeticProcess = "√"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'x = número ao quadrado (ou elevado a 2)
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = FirstNumber & "²"
        ArithmeticProcess = "x²"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'x = número ao cubo (ou elevado a 3)
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = FirstNumber & "³"
        ArithmeticProcess = "x³"
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        'Divisor de Números Inteiros
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = "\"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Percentagem
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = "%"
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        'Ponto Percentual
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = "P%"
    End Sub

    Private Sub cmdfac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdfac.Click
        'Factorial
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = FirstNumber & "!"
        ArithmeticProcess = "FAC"
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        'Permilagem
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = "‰"
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        'Raíz Cúbica
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = "∛" & FirstNumber
        ArithmeticProcess = "∛"
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        'Raíz à Quarta
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = "∜" & FirstNumber
        ArithmeticProcess = "∜"
    End Sub

    Private Sub cmdpri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpri.Click
        'Números Primos de Mersenne
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = "Mn"
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        'Mais ou Menos
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = "±"
        ArithmeticProcess = "±"
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        'Número Negativo
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = "-" & FirstNumber
        ArithmeticProcess = "(-)"
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        'Número de Fermat
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = "Fn"
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        'Gama
        txtDisplay.Text = txtDisplay.Text & "0,5772156649015328606065120900824024310421593359399235988057672348848677267776646709369470632917467495"
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        'Cosseno Elevado a -1
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = "COSˉ¹("
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        'Seno Elevado a -1
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = "SINˉ¹("
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        'Tangente Elevado a -1
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = "TANˉ¹("
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        'Somatórios de Números Naturais
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        ArithmeticProcess = "∑"
    End Sub

    Private Sub ÁreasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÁreasToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class
