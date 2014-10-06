Imports MySql.Data.MySqlClient


Public Class Resultados_UPC

    Dim dset1 As New DataSet

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

    Private Sub Resultados_UPC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        consultar("Select a.articulo as UPC,a.proveedor,a.descripcion,a.empaque,a.iva,a.ieps,sap.* from tabla_articulos a left join saparticulos sap on(a.articulo=sap.ean_upc and a.proveedor=sap.Clave)")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Filter = "Excel 2007 y Superior|*.xlsx|Excel 2003|.xls"
        SaveFileDialog1.Title = "Exportar a Excel"

        SaveFileDialog1.ShowDialog()
        Dim divide As Integer = 0

        If SaveFileDialog1.FileName.Length > 0 Then
            Cursor.Current = Cursors.WaitCursor

            Dim workbook1 = New ClosedXML.Excel.XLWorkbook()
            Dim worksheet = workbook1.Worksheets.Add("Datos")
            workbook1.SaveAs(SaveFileDialog1.FileName)

            workbook1.Dispose()
            workbook1 = New ClosedXML.Excel.XLWorkbook(SaveFileDialog1.FileName)
            worksheet = workbook1.Worksheet(1)

            For x1 As Integer = 0 To gridtabla.ColumnCount - 1
                worksheet.Cell(1, x1 + 1).Value = gridtabla.Columns(x1).HeaderText
            Next
            For X As Integer = 0 To gridtabla.RowCount - 1
                divide = divide + 1
                If divide = 30000 Then
                    divide = 0
                    workbook1.Save()
                    workbook1.Dispose()
                    workbook1 = New ClosedXML.Excel.XLWorkbook(SaveFileDialog1.FileName)
                    worksheet = workbook1.Worksheet(1)
                End If

                For y As Integer = 0 To gridtabla.ColumnCount - 1

                    worksheet.Cell(X + 2, y + 1).Value = gridtabla.Item(y, X).Value
                Next

            Next

            If divide > 0 Then
                workbook1.Save()
                workbook1.Dispose()
            End If

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

    Private Sub gridtabla_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridtabla.CellContentClick

    End Sub
End Class