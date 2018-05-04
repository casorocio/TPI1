Public Class Form1

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "/" And Not e.KeyChar = "." And Not e.KeyChar = "," And Not e.KeyChar = "-" Then
            e.Handled = True
            Exit Sub

        End If
        Dim pos As Integer = TextBox1.SelectionStart
        'si() la tecla pulsada es / y la posicion del cursor es distinto de 2 y la posicion del cursor es distinto de 5, entonces
        If e.KeyChar = "/" And pos <> 2 And pos <> 5 Then
            e.Handled = True
            Exit Sub

        End If
        'habilitar(hadled) y salir 
        'si la tecla pulsada es un numero y (pos es 2 o 5), entonces habilitar hadler
        If Char.IsNumber(e.KeyChar) And (pos = 2 Or pos = 5) Then
            e.Handled = True
            Exit Sub
        End If

        If e.KeyChar = "." Or e.KeyChar = "," Or e.KeyChar = "-" Then
            SendKeys.Send("/")
            e.Handled = True
        End If

    End Sub

End Class
