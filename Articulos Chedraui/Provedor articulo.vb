Public Class pruebas

    Private Sub pruebas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim cadena As String = ""

        If RadioButton1.Checked = True Then
            If Trim(TextBox1.Text).Length > 0 Then
                cadena = "select * from saparticulos where clave='" & Trim(TextBox1.Text) & "'"
            Else
                MsgBox("El campo Proveedor esta vacio", MsgBoxStyle.Information, "Consulta Articulos del proveedor")
                Exit Sub
            End If
        End If


        If RadioButton3.Checked = True Then

            If Trim(TextBox2.Text).Length > 0 Then
                cadena = "select * from saparticulos where articulo='" & Trim(TextBox2.Text) & "'"
            Else
                MsgBox("El campo Articulo esta vacio", MsgBoxStyle.Information, "Consulta Proveedores de Articulo")
                Exit Sub
            End If
        End If

        If RadioButton2.Checked = True Then

            If Trim(TextBox1.Text).Length > 0 And Trim(TextBox2.Text).Length > 0 Then
                cadena = "select * from saparticulos where clave='" & Trim(TextBox1.Text) & "' and articulo='" & Trim(TextBox2.Text) & "'"
            Else
                MsgBox("No tienes datos Suficientes", MsgBoxStyle.Information, "Consulta Proveedor-Articulo")
                Exit Sub
            End If
        End If

        If formlocal Is Nothing Then

        Else
            formlocal.Close()
        End If


        If MsgBox("Esto tardara unos momentos... Espere", MsgBoxStyle.OkCancel, "CatalogoProveedor") = MsgBoxResult.Ok Then
            Principal.consultar(cadena)
            Principal.Button1.Visible = True
            Principal.Button2.Visible = True
        End If
        Me.Close()

    End Sub
End Class