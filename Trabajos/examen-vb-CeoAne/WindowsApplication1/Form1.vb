Imports System.IO

Public Class Form1

    Private alumnos(4, 4) As String
    'Private cantPlatos As String
    'Private incremento As Integer = 0

    Dim promedio, mayor, notaAlumno, N, i As Integer
    'Dim notaAlumno As Integer


    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If MsgBox("Desea salir de la aplicación?", MessageBoxButtons.YesNo, "Cerrar") = MsgBoxResult.Yes Then
            Me.Close()
        Else
        End If

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim nombre, apellido As String
        Dim sexo As String

        If txtnombre.Text = "" Or txtapellido.Text = "" Or txtnota.Text = "" Then
            MessageBox.Show("LLenar  nombre y apellidos")

        Else
            If rdbfemenino.Checked Then
                sexo = "F"
            ElseIf rdbmasculino.Checked Then
                sexo = "M"
            End If
            nombre = txtnombre.Text
            apellido = txtapellido.Text
            notaAlumno = Val(txtnota.Text)



            alumnos(i, 0) = nombre
            alumnos(i, 1) = apellido
            alumnos(i, 2) = sexo
            alumnos(i, 3) = notaAlumno

            limpiarForm()


            i = i + 1
        End If





    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnlistar_Click(sender As Object, e As EventArgs) Handles btnlistar.Click
        If i > 0 Then

            ListView1.Items.Clear()
            Dim notasAlumnos As Integer = 0
            Dim mayorNota As Integer = 0

            For X = 0 To i - 1
                Dim fila As New ListViewItem(alumnos(X, 0))
                fila.SubItems.Add(alumnos(X, 1))
                fila.SubItems.Add(alumnos(X, 2))
                fila.SubItems.Add(alumnos(X, 3))
                ListView1.Items.Add(fila)
                notasAlumnos = notasAlumnos + alumnos(X, 3)

                If Val(alumnos(X, 3)) > mayorNota Then
                    mayorNota = alumnos(X, 3)
                End If
            Next


            txtpromedio.Text = Val(notasAlumnos) / i
            txtmayornota.Text = mayorNota
        End If






    End Sub


    Private Sub limpiarForm()
        txtnombre.Clear()
        txtapellido.Clear()
        txtnota.Clear()


    End Sub

End Class
