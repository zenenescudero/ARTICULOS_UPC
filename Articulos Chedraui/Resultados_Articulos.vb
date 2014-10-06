
Imports MySql.Data.MySqlClient
'Imports Microsoft.Office.Interop.Excel
Imports ClosedXML.Excel


Public Class ResultadosArticulos
    Dim dset1 As DataSet


    Public Sub consultar(ByVal consulta As String)

        Try
            varconexion()
            conexion.Open()

            Dim dset As New DataSet
            Dim dadaptador As New MySqlDataAdapter

            dadaptador.SelectCommand = New MySqlCommand(consulta, conexion)
            dadaptador.Fill(dset)
            conexion.Close()
            Dim dtable As DataTable = dset.Tables(0)
            gridtabla.DataSource = dtable
            dset1 = dset

        Catch ex As Exception

            conexion.Close()
        End Try

    End Sub

    Private Sub Resultados_ar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        consultar("Select a.articulo,a.proveedor,a.descripcion,a.empaque,a.iva,a.ieps,sap.* from tabla_articulos a left join saparticulos sap on(a.articulo=sap.articulo and a.proveedor=sap.Clave)")


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Filter = "Excel 2007 y Superior|*.xlsx|Excel 2003|*.xls"
        SaveFileDialog1.Title = "Exportar a Excel"

        SaveFileDialog1.ShowDialog()

        If SaveFileDialog1.FileName.Length > 0 Then
            Cursor.Current = Cursors.WaitCursor

            Dim workbook1 = New ClosedXML.Excel.XLWorkbook()
            Dim worksheet = workbook1.Worksheets.Add("Datos")

            For x1 As Integer = 0 To gridtabla.ColumnCount - 1
                worksheet.Cell(1, x1 + 1).Value = gridtabla.Columns(x1).HeaderText
            Next

            For X As Integer = 0 To gridtabla.RowCount - 1
                For y As Integer = 0 To gridtabla.ColumnCount - 1
                    worksheet.Cell(X + 2, y + 1).Value = gridtabla.Item(y, X).Value
                Next

            Next

            workbook1.SaveAs(SaveFileDialog1.FileName)
            MsgBox("Exportacion exitosa: " & Chr(13) & SaveFileDialog1.FileName & "", MsgBoxStyle.Information, "Exportación Finalizada")
        End If

        Cursor.Current = Cursors.Default

    End Sub

    

    Private Sub gridtabla_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles gridtabla.RowsAdded
        Label2.Text = "Registros: " & Format(gridtabla.RowCount, "###,###,###")
    End Sub

    Private Sub gridtabla_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles gridtabla.RowsRemoved
        Label2.Text = "Registros: " & Format(gridtabla.RowCount, "###,###,###")
    End Sub
End Class