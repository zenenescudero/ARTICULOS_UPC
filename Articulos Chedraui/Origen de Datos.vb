Imports System.IO

Public Class Origen_de_Datos

    Private Sub Origen_de_Datos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Trim(TextBox1.Text).Length < 1 Or Trim(TextBox2.Text).Length < 1 Or Trim(TextBox3.Text).Length < 1 Or Trim(TextBox4.Text).Length < 1 Then
            MsgBox("Rellena todos los campos", MsgBoxStyle.Exclamation, "Campos en Vacios")
            Exit Sub
        End If

        If MsgBox(" Estas seguro de cambiar" & Chr(13) & "La Información de Base de Datos" & Chr(13) & "Esto Podria Generar Errores.", vbOKCancel, "Confirmación") = vbOK Then
            Try

                File.WriteAllText("inicio.txt", "")
                Dim crear As StreamWriter = File.AppendText("inicio.txt")
                crear.WriteLine(TextBox1.Text)
                crear.WriteLine(TextBox2.Text)
                crear.WriteLine(TextBox4.Text)
                crear.WriteLine(TextBox3.Text)
                crear.Close()
                Me.Close()

                MsgBox("Origen De datos Regitrado", vbOKOnly, "Articulos -- Configuración")
                datosdebase()

            Catch ex As Exception
                MsgBox("Error al registrar Orgien de datos", vbOKOnly, "Articulos -- Configuración")
            End Try

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class