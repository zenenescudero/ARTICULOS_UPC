Imports MySql.Data.MySqlClient

Public Class articulos


    Dim articulo As Double
    Dim proveedor As Double
    Dim descripcion As String
    Dim empaque As Double
    Dim iva As Double
    Dim ieps As Double

    Private Sub articulosupc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        varconexion()
        conexion.Open()

        Try
            Dim comando1 As New MySqlCommand("delete from tabla_articulos", conexion)
            comando1.CommandType = CommandType.Text
            comando1.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
        End Try

        Dim x As Integer = 0
        Dim error1 As String = " "

        For x = 0 To gridtabla.RowCount - 2

            Try

                error1 = "Error en Campo Articulo"
                articulo = Trim(gridtabla.Item(0, x).Value)
                error1 = "Error en Campo Proveedor"
                proveedor = Trim(gridtabla.Item(1, x).Value)
                error1 = "Error en Campo Empaque"
                empaque = Trim(gridtabla.Item(3, x).Value)
                error1 = "Error en Campo Iva"
                iva = Trim(gridtabla.Item(4, x).Value)
                error1 = "Error en Campo IEPS"
                ieps = Trim(gridtabla.Item(5, x).Value)
                error1 = "no"

            Catch ex As Exception

                MsgBox(error1 & "Fila: " & x + 1, MsgBoxStyle.Critical, "Error al leer la grilla")
                error1 = "si"
                Exit Sub
            End Try
        Next


        If MsgBox("Se generara el reporte... Espera Un momento", MsgBoxStyle.OkCancel, "Generar Reporte") = MsgBoxResult.Ok Then
        Else
            Exit Sub
        End If
        If error1 = "no" Then


            For x = 0 To gridtabla.RowCount - 2
                Try
                    articulo = Trim(gridtabla.Item(0, x).Value)
                    proveedor = Trim(gridtabla.Item(1, x).Value)
                    descripcion = Trim(gridtabla.Item(2, x).Value)
                    empaque = Trim(gridtabla.Item(3, x).Value)
                    iva = Trim(gridtabla.Item(4, x).Value)
                    ieps = Trim(gridtabla.Item(5, x).Value)

                    conexion.Open()
                    If articulo > 0 Then
                        Dim agrega As String = "insert into tabla_articulos values(@articulo,@proveedor ,@descripcion,@empaque ,@iva,@ieps)"
                        Dim comando As New MySqlCommand(agrega, conexion)
                        comando.CommandType = CommandType.Text
                        comando.Parameters.AddWithValue("@articulo", articulo)
                        comando.Parameters.AddWithValue("@proveedor", proveedor)
                        comando.Parameters.AddWithValue("@descripcion", descripcion)
                        comando.Parameters.AddWithValue("@empaque", empaque)
                        comando.Parameters.AddWithValue("@iva", iva)
                        comando.Parameters.AddWithValue("@ieps", ieps)
                        comando.ExecuteNonQuery()

                    End If
                    conexion.Close()

                Catch ex As Exception
                    MsgBox("Error al Enviar los datos", MsgBoxStyle.Critical, "Error en los datos")
                    Exit Sub
                End Try

            Next

            If gridtabla.RowCount - 1 < 1 Then
                MsgBox("La grilla esta Vacia")
                Exit Sub
            End If

            Me.Close()
            ResultadosArticulos.Show()


        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.FileName.Length > 0 Then

            Try

                Dim workbook1 = New ClosedXML.Excel.XLWorkbook(OpenFileDialog1.FileName)
                Dim worksheet = workbook1.Worksheet(1)
                Dim x As Integer = 1
                Dim texto As String = worksheet.Cell(x, 1).Value

                While (texto.Length > 0)
                    gridtabla.Rows.Add(worksheet.Cell(x, 1).Value, worksheet.Cell(x, 2).Value, worksheet.Cell(x, 3).Value, worksheet.Cell(x, 4).Value, worksheet.Cell(x, 5).Value, worksheet.Cell(x, 6).Value)
                    x = x + 1
                    texto = worksheet.Cell(x, 1).Value
                End While

                Label3.Text = "No Registros: " & gridtabla.RowCount - 1
            Catch ex As Exception
                MsgBox("Error al abrir el archivo", MsgBoxStyle.Critical, "Error al Importar")
            End Try

        Else
            MsgBox("Eligue el Origen de datos", MsgBoxStyle.Critical, "Error al Importar")
        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        gridtabla.Rows.Clear()
        Label3.Text = "No. Registros: " & gridtabla.RowCount - 1


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            gridtabla.Rows.Remove(gridtabla.CurrentRow)
            Label3.Text = "No.Registros: " & gridtabla.RowCount - 1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub gridtabla_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles gridtabla.RowsAdded
        Label3.Text = "No. Registros:  " & gridtabla.RowCount - 1
    End Sub
End Class