
Imports MySql.Data.MySqlClient
Imports ClosedXML.Excel
'Imports DocumentFormat.OpenXml
Imports System.IO

Public Class Principal

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        datosdebase()
    End Sub

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
            datamostras.DataSource = dset.Tables(0)
            datamostras.Visible = True
            dset.Dispose()

            Label2.Visible = True

        Catch ex As Exception
            conexion.Close()
        End Try
    End Sub

    Private Sub ConsultaPorUPCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarUPCToolStripMenuItem.Click
        datamostras.Visible = False
        formlocal = articulosupc
        mostrarform(formlocal)
        Button1.Visible = False
        Button2.Visible = False
        Label2.Visible = False
    End Sub

    Private Sub ConsultaPorArticuloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarArticuloToolStripMenuItem.Click

        datamostras.Visible = False
        formlocal = articulos
        mostrarform(formlocal)
        Button1.Visible = False
        Button2.Visible = False
        Label2.Visible = False


    End Sub

    Private Sub DescargarCatalogoCompletoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescargarCatalogoCompletoToolStripMenuItem.Click

        If formlocal Is Nothing Then
        Else
            formlocal.Close()
        End If

        If MsgBox("Esto tardara unos momentos... Espere", MsgBoxStyle.OkCancel, "Catalogo Completo") = MsgBoxResult.Ok Then
            consultar("Select * from saparticulos order by articulo")
            Button1.Visible = True
            Button2.Visible = True
            Label2.Visible = True

        End If

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub





    Private Sub Principal_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Button1.Visible = False
        Button2.Visible = False
        Label2.Visible = False

    End Sub

    Private Sub CatalogoProveedorArticuloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatalogoProveedorArticuloToolStripMenuItem.Click
        pruebas.Show()
    End Sub

    Private Sub OrigenDeDatosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrigenDeDatosToolStripMenuItem1.Click
        Origen_de_Datos.Show()
    End Sub

    Private Sub SalirDelSistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirDelSistemaToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub datamostras_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles datamostras.RowsAdded
        Label2.Text = "Registros: " & Format(datamostras.RowCount, "###,###,###")
    End Sub

    Private Sub datamostras_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles datamostras.RowsRemoved
        Label2.Text = "Registros: " & Format(datamostras.RowCount, "###,###,###")
    End Sub

   
    Private Sub hilosegundoplano_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles hilosegundoplano.DoWork

        Try

            If SaveFileDialog1.FileName.Length > 0 Then
                Cursor.Current = Cursors.WaitCursor
                Dim workbook1 = New ClosedXML.Excel.XLWorkbook()
                Dim worksheet = workbook1.Worksheets.Add("Datos")

                For x1 As Integer = 0 To datamostras.ColumnCount - 1
                    worksheet.Cell(1, x1 + 1).Value = datamostras.Columns(x1).HeaderText
                Next

                For X As Integer = 0 To datamostras.RowCount - 1
                    For y As Integer = 0 To datamostras.ColumnCount - 1
                        worksheet.Cell(X + 2, y + 1).Value = datamostras.Item(y, X).Value
                    Next
                Next

                workbook1.SaveAs(SaveFileDialog1.FileName)
                MsgBox("Exportacion exitosa: " & Chr(13) & SaveFileDialog1.FileName & "", MsgBoxStyle.Information, "Exportación Finalizada")
            End If
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Cursor.Current = Cursors.Default

            MsgBox("Memoria insuficiente intenta  exportar a TXT por partes", MsgBoxStyle.Information, "Generar TXT")
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        totalderegistros = datamostras.RowCount
        generartexto.Show()

    End Sub

    

  

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Filter = "Excel 2007 y Superior|*.xlsx|Excel 2003|*.xls"
        SaveFileDialog1.Title = "Exportar a Excel"
        SaveFileDialog1.ShowDialog()

        If SaveFileDialog1.FileName.Length > 0 Then
            hilosegundoplano.RunWorkerAsync()
        Else
            MsgBox("Ruta no valida", MsgBoxStyle.Information, "Exportar a Excel")
        End If


    End Sub
End Class
