Imports ClosedXML.Excel
Imports DocumentFormat.OpenXml

Imports MySql.Data.MySqlClient
Imports System.IO

Module modulo

    Public conexion As New MySqlConnection
    Dim servidor As String
    Dim usuario As String
    Dim contra As String
    Dim basedatos As String
    Public formactivo As Form
    Public formlocal As Form
    Public comenzar As Integer = 0
    Public terminar As Integer = 0
    Public rutatexto As String
    Public totalderegistros As Integer



    Public Sub mostrarform(ByVal formlocal)

        If formactivo Is Nothing Then
        Else
            If Formlocal.Equals(formactivo) Then
            Else
                formactivo.Close()
                formactivo.Dispose()
            End If
        End If
        formactivo = Formlocal
        formactivo.TopLevel = False
        formactivo.Parent = Principal.contenedor()
        formactivo.Show()

    End Sub

    Public Sub datosdebase()

        Dim leer As StreamReader = File.OpenText("inicio.txt")

        Try
            servidor = leer.ReadLine()
            basedatos = leer.ReadLine()
            usuario = leer.ReadLine
            contra = leer.ReadLine
            leer.Close()
        Catch ex As Exception
            leer.Close()
            MsgBox("Error al conectar Origen de Datos", MsgBoxStyle.Critical, "Coneccion a Datos")
        End Try


    End Sub

    Public Sub varconexion()

        conexion.ConnectionString = "server=" & servidor & ";userid=" & usuario & ";password=" & contra & ";database=" & basedatos & ";port=3306"

    End Sub
    Public Sub exportaraexcel(ByVal grid As DataGridView, ByVal ruta As String)

        Dim workbook1 = New ClosedXML.Excel.XLWorkbook()
        Dim worksheet = workbook1.Worksheets.Add("Datos")

        For x1 As Integer = 0 To grid.ColumnCount - 1
            worksheet.Cell(1, x1 + 1).Value = grid.Columns(x1).HeaderText
        Next

        For X As Integer = 0 To grid.RowCount - 1

            For y As Integer = 0 To grid.ColumnCount - 1
                worksheet.Cell(X + 2, y + 1).Value = grid.Item(y, X).Value
            Next
        Next

        ruta = ruta
        workbook1.SaveAs(ruta)
        MsgBox("Exportacion exitosa: " & Chr(13) & ruta & "", MsgBoxStyle.Information, "Exportación Finalizada")

    End Sub


End Module
