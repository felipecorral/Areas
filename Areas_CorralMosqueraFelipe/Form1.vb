Public Class Form1


    Dim bas As Integer
    Dim altur As Integer
    Dim rad As Integer



    Private Sub RadioButton_Cuadrado_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Cuadrado.CheckedChanged
        Label_Base.Visible = True
        TextBox_Base.Visible = True
        Label_Altura.Visible = False
        TextBox_Altura.Visible = False
        Label_Radio.Visible = False
        TextBox_Radio.Visible = False
    End Sub

    Private Sub RadioButton_Rectangulo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Rectangulo.CheckedChanged
        Label_Base.Visible = True
        TextBox_Base.Visible = True
        Label_Altura.Visible = True
        TextBox_Altura.Visible = True
        Label_Radio.Visible = False
        TextBox_Radio.Visible = False
    End Sub

    Private Sub RadioButton_Circulo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Circulo.CheckedChanged
        Label_Base.Visible = False
        TextBox_Base.Visible = False
        Label_Altura.Visible = False
        TextBox_Altura.Visible = False
        Label_Radio.Visible = True
        TextBox_Radio.Visible = True
    End Sub

    Private Sub RadioButton_Triangulo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Triangulo.CheckedChanged
        Label_Base.Visible = True
        TextBox_Base.Visible = True
        Label_Altura.Visible = True
        TextBox_Altura.Visible = True
        Label_Radio.Visible = False
        TextBox_Radio.Visible = False
    End Sub

    Private Sub Button_Calcular_Click(sender As Object, e As EventArgs) Handles Button_Calcular.Click
        If (RadioButton_Cuadrado.Checked = True) Then
            If IsNumeric(TextBox_Base.Text) Then
                bas = CDbl(TextBox_Base.Text)
                Label_ResultadoFinal.Text = " " + (bas * bas).ToString
                TextBox_Base.Text = ""
            End If
        End If
        If (RadioButton_Rectangulo.Checked = True) Then
            If IsNumeric(TextBox_Base.Text And TextBox_Altura.Text) Then
                bas = CDbl(TextBox_Base.Text)
                altur = CDbl(TextBox_Altura.Text)
                Label_ResultadoFinal.Text = " " + (altur * bas).ToString
                TextBox_Base.Text = ""
                TextBox_Altura.Text = ""
            End If
        End If
        If (RadioButton_Circulo.Checked = True) Then
            If IsNumeric(TextBox_Radio.Text) Then
                rad = CDbl(TextBox_Radio.Text)
                Label_ResultadoFinal.Text = " " + (rad * rad * Math.PI).ToString
                TextBox_Radio.Text = ""
            End If
        End If
        If (RadioButton_Triangulo.Checked = True) Then
            If IsNumeric(TextBox_Base.Text And TextBox_Altura.Text) Then
                bas = CDbl(TextBox_Base.Text)
                altur = CDbl(TextBox_Altura.Text)
                Label_ResultadoFinal.Text = " " + ((bas * altur) / 2).ToString
                TextBox_Base.Text = ""
                TextBox_Altura.Text = ""
            End If
        End If
    End Sub
End Class
