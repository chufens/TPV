Public Class Datafonos
    Dim marcarow() As TPVDataSet.MarcasRow

    Private Sub Datafonos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TPVDataSet.Estado' table. You can move, or remove it, as needed.
        Me.EstadoTableAdapter.Fill(Me.TPVDataSet.Estado)
        'TODO: This line of code loads data into the 'TPVDataSet.Modelos' table. You can move, or remove it, as needed.
        Me.ModelosTableAdapter.Fill(Me.TPVDataSet.Modelos)
        'TODO: This line of code loads data into the 'TPVDataSet.Marcas' table. You can move, or remove it, as needed.
        Me.MarcasTableAdapter.Fill(Me.TPVDataSet.Marcas)
        'TODO: This line of code loads data into the 'TPVDataSet.Localizacion' table. You can move, or remove it, as needed.
        Me.LocalizacionTableAdapter.Fill(Me.TPVDataSet.Localizacion)
        'TODO: This line of code loads data into the 'TPVDataSet.TPVs' table. You can move, or remove it, as needed.
        Me.TPVsTableAdapter.Fill(Me.TPVDataSet.TPVs)
        Me.ComboBoxCaja.SelectedIndex = -1
        Me.ComboBoxMarca.SelectedIndex = -1
        Me.ComboBoxModelo.SelectedIndex = -1
        Me.ComboBoxEstado.SelectedIndex = -1
        Me.Label5.Text = Me.TPVsTableAdapter.Totales
        Me.Label6.Text = Me.TPVsTableAdapter.Ing5100
        Me.Label8.Text = Me.TPVsTableAdapter.Banjo
        Me.Label9.Text = Me.TPVsTableAdapter.V8210
        Me.Label10.Text = Me.TPVsTableAdapter.V8010
        Me.TextBoxSerie.Select()
        Me.TextBoxSerie.Enabled = True
    End Sub

    Private Sub BotonBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonBorrar.Click
        Me.ButtonExcell.Enabled = False
        Me.ComboBoxCaja.SelectedIndex = -1
        Me.ComboBoxMarca.SelectedIndex = -1
        With Me.ComboBoxModelo
            .DataSource = Me.ModelosTableAdapter.GetData
            .DisplayMember = "Nobre_Modelo"
        End With
        Me.ComboBoxModelo.SelectedIndex = -1
        Me.ComboBoxEstado.SelectedIndex = -1
        For i As Integer = 0 To Me.DataGridView1.RowCount - 1
            Me.DataGridView1.Rows.Remove(Me.DataGridView1.CurrentRow)
        Next
        Me.TextBoxSerie.Select()
        Me.TextBoxSerie.Clear()
        Me.TextBoxSerie.Enabled = True
    End Sub

    Private Sub BuscarDatafonos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarDatafonos.Click
        Dim arg1 As String = Me.ComboBoxCaja.Text
        Dim arg2 As String = Me.ComboBoxMarca.Text
        Dim arg3 As String = Me.ComboBoxModelo.Text
        Dim arg4 As String = Me.ComboBoxEstado.Text
        Dim arg5 As Boolean = False

        If arg1 = "" Then arg1 = "%"
        If arg2 = "" Then arg2 = "%"
        If arg3 = "" Then arg3 = "%"
        If arg4 = "" Then arg4 = "%"

        If Me.TextBoxSerie.Text = "" Then

            Try
                Me.Localizacion_ConsultaTableAdapter.Fillbycombos(Me.TPVDataSet.Localizacion_Consulta, arg1, arg2, arg3, arg4, arg5)
                Me.ButtonExcell.Enabled = True
            Catch ex As Exception
                MessageBox.Show("No se pueden mostrar resultados")
            End Try
        Else
            Try
                Me.Localizacion_ConsultaTableAdapter.FillBySerie(Me.TPVDataSet.Localizacion_Consulta, Me.TextBoxSerie.Text)
                Me.ButtonExcell.Enabled = True
            Catch ex As Exception
                MessageBox.Show("No hay datos para el número de serie solicitado")
            End Try
        End If

    End Sub

    Private Sub ButtonExcell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExcell.Click

        Dim RowsCount As Int32 = Me.DataGridView1.RowCount - 1

        If RowsCount > -1 Then
            'The array for field names.
            Dim FldNames() As String = {"Localizacion", "Marca", "Modelo", "Submodelo", "Serie", "Estado", "Comentario"}
            'The array for the selected records.
            Dim DataArr(RowsCount, 6) As Object
            Dim ColsCounter As Int32 = 0

            'Populate the data array - The list is sorted in ascending order.
            For RowsCounter As Int32 = 0 To RowsCount
                For Each cell As DataGridViewCell In Me.DataGridView1 _
                                                     .Rows(RowsCount - RowsCounter) _
                                                     .Cells
                    DataArr(RowsCounter, ColsCounter) = cell.Value
                    ColsCounter = ColsCounter + 1
                Next
                ColsCounter = 0
            Next

            'Variables for Excel.
            Dim xlApp As New Excel.Application
            Dim xlWBook As Excel.Workbook = xlApp.Workbooks.Add( _
                                            Excel.XlWBATemplate.xlWBATWorksheet)
            Dim xlWSheet As Excel.Worksheet = CType(xlWBook.Worksheets(1), Excel.Worksheet)
            Dim xlCalc As Excel.XlCalculation

            'Save the present setting for Excel's calculation mode and turn it off. 
            With xlApp
                xlCalc = .Calculation
                .Calculation = Excel.XlCalculation.xlCalculationManual
            End With

            'Write the field names and the data to the targeting worksheet.
            With xlWSheet
                .Range(.Cells(1, 1), .Cells(1, 7)).Value = FldNames
                .Range(.Cells(2, 1), .Cells(RowsCount + 2, 7)).Value = DataArr
                .UsedRange.Columns.AutoFit()
            End With

            With xlApp
                .Visible = True
                .UserControl = True
                'Restore the calculation mode. 
                .Calculation = xlCalc
            End With

            'Relase objects from memory.                         
            xlWSheet = Nothing
            xlWBook = Nothing
            xlApp = Nothing
            GC.Collect()
        End If
        Me.ButtonExcell.Enabled = False
        Me.ComboBoxCaja.SelectedIndex = -1
        Me.ComboBoxMarca.SelectedIndex = -1
        Me.ComboBoxModelo.SelectedIndex = -1
        Me.ComboBoxEstado.SelectedIndex = -1
        For i As Integer = 0 To Me.DataGridView1.RowCount - 2
            Me.DataGridView1.Rows.Remove(Me.DataGridView1.CurrentRow)
        Next
        Me.ComboBoxCaja.Select()
    End Sub

    Private Sub ComboBoxMarca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxMarca.SelectedIndexChanged
        Me.TextBoxSerie.Enabled = False
        Try
            marcarow = TPVDataSet.Tables("Marcas").Select("Marca_TPV = '" & Me.ComboBoxMarca.Text & "'")

            With Me.ComboBoxModelo
                .DataSource = Me.ModelosTableAdapter.GetDataBy(marcarow(0)("Id_Marca"))
                .DisplayMember = "Nobre_Modelo"
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBoxModelo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxModelo.SelectedIndexChanged
        Me.TextBoxSerie.Enabled = False
    End Sub

    Private Sub ComboBoxCaja_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxCaja.SelectedIndexChanged
        Me.TextBoxSerie.Enabled = False
    End Sub

    Private Sub ComboBoxEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEstado.SelectedIndexChanged
        Me.TextBoxSerie.Enabled = False
    End Sub

    Private Sub Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cerrar.Click
        Me.Close()
    End Sub
End Class