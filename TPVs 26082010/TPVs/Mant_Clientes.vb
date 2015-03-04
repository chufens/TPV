Imports System.Data.OleDb
Public Class Mant_Clientes
    Dim dt As New TPVDataSet

    Private Sub ActClientes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Fecha_ActualizaciónTableAdapter.Fill(Me.TPVDataSet.Fecha_Actualización)
        Dim contfechas As Integer = Me.TPVDataSet.Fecha_Actualización.Count
        Dim a As Integer = contfechas - 1
        Me.ListBox1.SelectedIndex = a
        Dim dtFecha As Date = Me.ListBox1.SelectedValue
        Me.Label3.Text = dtFecha.ToString("dd/MM/yyyy")
        Me.TextPathExcel.Select()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*.xlsx|Todos los archivos (*.*)|*.*"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                TextPathExcel.Text = .FileName
            End If
        End With

    End Sub

    Private Sub ActBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActBBDD.Click
        Dim Hoja As String = "Teradata SQL Assistant"
        Me.PictureBox1.Visible = True
        Try
            Dim strconn As String
            strconn = "Provider=Microsoft.Jet.Oledb.4.0; data source= " + TextPathExcel.Text + ";Extended properties=""Excel 8.0;hdr=yes;imex=1"""
            Dim mconn As New OleDbConnection(strconn)
            Dim ad As New OleDbDataAdapter("Select * from [" & Hoja & "$]", mconn)
            mconn.Open()
            ad.Fill(dt.Clientes)
            mconn.Close()
            Try
                Dim contador As Integer = Me.ClientesTableAdapter.Totales
                If contador <> 0 Then
                    With Me.ComboBox1
                        .DataSource = Me.ClientesTableAdapter.GetData
                        .DisplayMember = "serie"
                    End With
                    For RowsCounter As Integer = 0 To contador - 1
                        With ComboBox1
                            .SelectedIndex = RowsCounter
                        End With
                        Me.ClientesTableAdapter.Delete(Me.ComboBox1.Text)

                    Next

                End If
                Dim fila As TPVDataSet.ClientesRow
                contador = Me.dt.Clientes.Count
                For RowsCounter As Integer = 0 To contador - 1
                    fila = dt.Clientes.Rows(RowsCounter)
                    Dim arg(12) As String
                    For i As Integer = 0 To 11
                        arg(i) = fila(i).ToString
                    Next
                    Me.ClientesTableAdapter.Insert(arg(0), arg(1), arg(2), arg(3), arg(4), arg(5), arg(6), arg(7), Val(arg(8)), arg(9), Val(arg(11)), arg(10))
                Next

                Me.PictureBox1.Visible = False

                MsgBox("Actualización Completada")
                Dim dtFecha As Date = Date.Now
                Me.Label3.Text = dtFecha.ToString("dd/MM/yyyy")
                Me.Fecha_ActualizaciónTableAdapter.Insert(dtFecha)
                Me.Label3.Text = dtFecha.ToString("dd/MM/yyyy")
                Me.TextPathExcel.Clear()
                Me.TextPathExcel.Select()
            Catch ex As Exception
                Me.PictureBox1.Visible = False
                MsgBox("Actualización fallida")
            End Try
        Catch ex As OleDbException
            Me.PictureBox1.Visible = False
            MessageBox.Show("Introduzca un nombre de archivo válido")
            Me.TextPathExcel.Select()
        End Try
    End Sub

    Private Sub ButtonCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub

End Class