Imports System.IO

Public Class generartexto

    Private Sub generartexto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "Numero de Registros: " & totalderegistros
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            comenzar = Trim(TextBox1.Text)
            terminar = Trim(TextBox2.Text)
        Catch ex As Exception
            MsgBox("Los valores no son tipo entero")
            Exit Sub
        End Try

        If comenzar <= 0 Or terminar <= 0 Then
            MsgBox("El rango no es valido, no existe un indice CERO", MsgBoxStyle.Exclamation, "Error en Rango")
            Exit Sub
        End If

        If terminar > totalderegistros Then
            terminar = totalderegistros
        End If
        If comenzar > totalderegistros Then
            comenzar = totalderegistros
        End If

        If comenzar > terminar Then
            MsgBox("El rango no es valido", MsgBoxStyle.Exclamation, "Error en Rango")
            Exit Sub
        End If

        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Filter = "archivo de texto|*.txt"
        SaveFileDialog1.Title = "Exportar a TXT"
        SaveFileDialog1.ShowDialog()
        rutatexto = SaveFileDialog1.FileName

        If SaveFileDialog1.FileName.Length > 0 Then

            generararchivotexto()

            Me.Dispose()

            Me.Close()
        Else
            MsgBox("la Ruta no es valida", MsgBoxStyle.Information, "Ruta a Exportar")
        End If



    End Sub
    Public Sub generararchivotexto()
      
        Try
            File.WriteAllText(rutatexto, "")

            Dim crear As StreamWriter = File.AppendText(rutatexto)

            For x1 As Integer = 0 To Principal.datamostras.ColumnCount - 1
                crear.Write(Principal.datamostras.Columns(x1).HeaderText & "|")
            Next

            crear.WriteLine("")

            For X As Integer = comenzar - 1 To terminar - 1
                For y As Integer = 0 To Principal.datamostras.ColumnCount - 1
                    crear.Write(Principal.datamostras.Item(y, X).Value & "|")
                Next
                crear.WriteLine("")
            Next
        
            crear.Close()
            crear = Nothing


            MsgBox("Exportación Exitosa", MsgBoxStyle.Information, "Exportado a TXT")


        Catch ex As Exception
            MsgBox("no se completo la exportacion demasiados datos :( ", MsgBoxStyle.Exclamation, "Error en Exportacion")
        End Try
    End Sub
End Class