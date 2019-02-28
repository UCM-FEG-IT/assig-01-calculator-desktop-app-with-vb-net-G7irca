Public Class Form1
    Private Sub ButtonClickMethod(sender As Object, e As EventArgs) Handles num0.Click, num1.Click, num2.Click, num3.Click, num4.Click, num5.Click, num6.Click, num7.Click, num8.Click, num9.Click, Nclear.Click, add.Click, multi.Click, subtract.Click, divide.Click, dot.Click, equal.Click

        Dim button As Button = CType(sender, Button)
        If button.Name = "num1" Then
            TextBox.Text = TextBox.Text + "1"
        End If
        If button.Name = "num2" Then
            TextBox.Text = TextBox.Text + "2"
        End If
        If button.Name = "num3" Then
            TextBox.Text = TextBox.Text + "3"
        End If
        If button.Name = "num4" Then
            TextBox.Text = TextBox.Text + "5"
        End If
        If button.Name = "num5" Then
            TextBox.Text = TextBox.Text + "4"
        End If
        If button.Name = "num6" Then
            TextBox.Text = TextBox.Text + "6"
        End If
        If button.Name = "num7" Then
            TextBox.Text = TextBox.Text + "7"
        End If
        If button.Name = "num8" Then
            TextBox.Text = TextBox.Text + "8"
        End If
        If button.Name = "num9" Then
            TextBox.Text = TextBox.Text + "9"
        End If
        If button.Name = "num0" Then
            TextBox.Text = TextBox.Text + "0"
        End If

        If button.Name = "dot" Then
            TextBox.Text = TextBox.Text + "."

        End If
        If button.Name = "add" Then
            TextBox.Text = TextBox.Text + "+"
        End If
        If button.Name = "subtract" Then
            TextBox.Text = TextBox.Text + "-"
        End If
        If button.Name = "divide" Then
            TextBox.Text = TextBox.Text + "/"
        End If
        If button.Name = "multi" Then
            TextBox.Text = TextBox.Text + "*"
        End If
        If button.Name = "Nclear" Then
            TextBox.Text = TextBox.Text + ""
        End If
        If button.Name = "equal" Then
            Dim equation As String = TextBox.Text
            Dim result = New DataTable().Compute(equation, Nothing)
            TextBox.Text = result
        End If

    End Sub
End Class
