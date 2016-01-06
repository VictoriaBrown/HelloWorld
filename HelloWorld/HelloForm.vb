' Project:      Hello World
' Programmer:   Victoria Brown
' Date:         01/05/2015
' Description:  This project will display a "Hello World" message in English and 
'               Spanish.

Public Class HelloForm
    Private Sub PushButton_Click(sender As Object, e As EventArgs) Handles PushButton.Click
        ' Display the Hello World message.

        MessageLabel.Text = "Hello World"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Exit the project.

        Me.Close()
    End Sub

    Private Sub HelloForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SpanishButton_Click(sender As Object, e As EventArgs) Handles SpanishButton.Click
        ' Display the Hello World message in Spanish.

        MessageLabel.Text = "Hola Mundo"
    End Sub
End Class
