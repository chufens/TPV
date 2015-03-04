Public Class Lista_Reparaciones

    Private Sub Lista_Reparaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TPVDataSet.Comentarios_Reparacion_Consulta' table. You can move, or remove it, as needed.
        'Me.Comentarios_Reparacion_ConsultaTableAdapter.Fill(Me.TPVDataSet.Comentarios_Reparacion_Consulta)
        'TODO: This line of code loads data into the 'TPVDataSet.Estado' table. You can move, or remove it, as needed.
        Me.EstadoTableAdapter.Fill(Me.TPVDataSet.Estado)

    End Sub

    Private Sub ButtonBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuscar.Click
        Dim fechamin As String = Me.DateTimePicker1.Value.ToString("dd/MM/yyyy")
        Dim fechamax As String = Me.DateTimePicker2.Value.ToString("dd/MM/yyyy")
        Dim serie As String = Me.TextBoxSerie.Text
        Dim estado As String = Me.ComboBoxEstado.Text

        Try
            If serie <> "" Then 'Hay un número de serie seleccionado
                'Las fechas no se han modificado
                If fechamin = Date.Now.ToString("dd/MM/yyyy") And fechamax = Date.Now.ToString("dd/MM/yyyy") Then
                    'Estado está vacío  
                    If Me.ComboBoxEstado.Text = "" Then
                        Me.Comentarios_Reparacion_ConsultaTableAdapter.FillBySerie(Me.TPVDataSet.Comentarios_Reparacion_Consulta, serie)
                        'Estado ha sido seleccionado
                    Else : Me.Comentarios_Reparacion_ConsultaTableAdapter.FillByEstadoSerie(Me.TPVDataSet.Comentarios_Reparacion_Consulta, estado, serie)
                        'Estado ha sido seleccionado
                    End If
                Else 'Las fechas han cambiado
                    'Estado está vacío
                    If Me.ComboBoxEstado.Text = "" Then
                        Me.Comentarios_Reparacion_ConsultaTableAdapter.FillBySerieFecha(Me.TPVDataSet.Comentarios_Reparacion_Consulta, serie, fechamin, fechamax)
                        'Estado ha sido seleccionado
                    Else : Me.Comentarios_Reparacion_ConsultaTableAdapter.FillBySerieEstadoFecha(Me.TPVDataSet.Comentarios_Reparacion_Consulta, serie, estado, fechamin, fechamax)
                    End If
                End If
            Else 'No hay un número de serie seleccionado
                'Las fechas no han cambiado
                If fechamin = Date.Now.ToString("dd/MM/yyyy") And fechamax = Date.Now.ToString("dd/MM/yyyy") Then
                    'Estado está vacío
                    If Me.ComboBoxEstado.Text = "" Then
                        Me.Comentarios_Reparacion_ConsultaTableAdapter.Fill(Me.TPVDataSet.Comentarios_Reparacion_Consulta)
                        'Estado ha sido seleccionado
                    Else : Me.Comentarios_Reparacion_ConsultaTableAdapter.FillByEstado(Me.TPVDataSet.Comentarios_Reparacion_Consulta, estado)
                    End If
                Else 'Las fechas han cambiado
                    'Estado está vacío
                    If Me.ComboBoxEstado.Text = "" Then
                        Me.Comentarios_Reparacion_ConsultaTableAdapter.FillByFecha(Me.TPVDataSet.Comentarios_Reparacion_Consulta, fechamin, fechamax)
                        'Estado ha sido seleccionado
                    Else : Me.Comentarios_Reparacion_ConsultaTableAdapter.FillByEstadoFecha(Me.TPVDataSet.Comentarios_Reparacion_Consulta, estado, fechamin, fechamax)
                    End If
                End If
            End If
            Me.ButtonGenerar.Enabled = True
        Catch ex As Exception
            MessageBox.Show("No hay datos para los parámetros introducidos")
        End Try

    End Sub

    Private Sub ButtonGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGenerar.Click
        Dim RowsCount As Int32 = Me.DataGridView1.RowCount - 1

        If RowsCount > -1 Then
            'The array for field names.
            Dim FldNames() As String = {"Serie", "Fecha", "Comentario", "Estado"}
            'The array for the selected records.
            Dim DataArr(RowsCount, 3) As Object
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
                .Range(.Cells(1, 1), .Cells(1, 4)).Value = FldNames
                .Range(.Cells(2, 1), .Cells(RowsCount + 2, 4)).Value = DataArr
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
        Me.TextBoxSerie.Clear()
        Me.DateTimePicker1.Value = Date.Now
        Me.DateTimePicker2.Value = Date.Now
        Me.ComboBoxEstado.SelectedIndex = -1
        Me.ButtonGenerar.Enabled = False
        For i As Integer = 0 To Me.DataGridView1.RowCount - 2
            Me.DataGridView1.Rows.Remove(Me.DataGridView1.CurrentRow)
        Next
    End Sub

    Private Sub BotonBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonBorrar.Click
        Me.TextBoxSerie.Clear()
        Me.DateTimePicker1.Value = Date.Now
        Me.DateTimePicker2.Value = Date.Now
        Me.ComboBoxEstado.SelectedIndex = -1
        Me.ButtonGenerar.Enabled = False
        For i As Integer = 0 To Me.DataGridView1.RowCount - 2
            Me.DataGridView1.Rows.Remove(Me.DataGridView1.CurrentRow)
        Next
    End Sub

    Private Sub ButtonCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub

End Class