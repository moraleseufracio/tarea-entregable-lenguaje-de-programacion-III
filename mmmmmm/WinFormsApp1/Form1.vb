Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim N As String
    Dim A As String
    Dim I As Integer
    Dim T As Integer
    Dim D As String
    Dim G As String
    Dim someDateAndTime As Date = #8/13/2002 12:14 PM#


    Dim O As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        N = TextBox2.Text
        A = TextBox3.Text
        I = TextBox1.Text
        T = TextBox4.Text
        D = TextBox5.Text
        G = TextBox6.Text
        someDateAndTime = TextBox8.Text
        O = TextBox7.Text




        Button2.Text = (" HOLA su nombre es : ") & N & "su apellido es:" & A & "su id :" &
            I & "su numero de celular es :" & T & "su direccion es :" & D & "su gmail es :" &
            G & "su fecha de nacimiento es :" & someDateAndTime & " no tiene ningun observacion  " & O &
        ("SUS DATOS QUE INGRESO ESTAN REGISTRADO CORRECTAMENTE DEL ALUMNO ")


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox8.Text = ""
        TextBox7.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub
End Class
