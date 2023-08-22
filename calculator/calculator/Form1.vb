Public Class Form1
    Dim num1, num2, ans As Double
    Dim op As String
    Private Sub NumberClick(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btnDot.Click, btn0.Click
        Dim b As Button = sender
        If (txtDisplay.Text = "0") Then
            txtDisplay.Clear()
            txtDisplay.Text = b.Text
        ElseIf (b.Text = ".") Then
            If (Not txtDisplay.Text.Contains(".")) Then
                txtDisplay.Text = txtDisplay.Text + b.Text
            End If
        Else
            txtDisplay.Text = txtDisplay.Text + b.Text
        End If
    End Sub

    Private Sub Clear(sender As Object, e As EventArgs) Handles btnAC.Click
        txtDisplay.Clear()
    End Sub

    Private Sub DelClick(sender As Object, e As EventArgs) Handles btnDel.Click
        txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1)
    End Sub

    Private Sub ResultClick(sender As Object, e As EventArgs) Handles btnResult.Click
        num2 = Convert.ToDouble(txtDisplay.Text)
        If op = "+" Then
            ans = num1 + num2
        ElseIf op = "-" Then
            ans = num1 - num2
        ElseIf op = "*" Then
            ans = num1 * num2
        ElseIf op = "/" Then
            ans = num1 / num2
        End If
        txtDisplay.Text = Convert.ToString(ans)
    End Sub

    Private Sub OpClick(sender As Object, e As EventArgs) Handles btnDiv.Click, btnMult.Click, btnSub.Click, btnAdd.Click, btnPercent.Click, btnSqrt.Click
        Dim b As Button = sender
        num1 = Convert.ToDouble(txtDisplay.Text)
        op = b.Text
        txtDisplay.Text = ""
        If op = "%" Then
            num1 /= 100
            txtDisplay.Text = num1
        ElseIf op = "√" Then
            num1 = Math.Sqrt(num1)
            txtDisplay.Text = num1
        End If
    End Sub
End Class
