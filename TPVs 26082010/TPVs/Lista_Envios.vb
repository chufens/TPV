Public Class Lista_Envios

    Private Sub ButtonGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGenerar.Click
        If Me.ComboBoxAño.Text = "" Or Me.ComboBoxMes.Text = "" Then
            MessageBox.Show("Seleccione un mes y un año en los que realizar la búsqueda")
        Else
            Dim fechamin As String = Date.Now.ToString
            Dim fechamax As String = Date.Now.ToString

            Select Case Me.ComboBoxMes.Text
                Case "Enero"
                    fechamin = "01/01/" & Me.ComboBoxAño.Text
                    fechamax = "01/02/" & Me.ComboBoxAño.Text
                Case "Febrero"
                    fechamin = "01/02/" & Me.ComboBoxAño.Text
                    fechamax = "01/03/" & Me.ComboBoxAño.Text
                Case "Marzo"
                    fechamin = "01/03/" & Me.ComboBoxAño.Text
                    fechamax = "01/04/" & Me.ComboBoxAño.Text
                Case "Abril"
                    fechamin = "01/04/" & Me.ComboBoxAño.Text
                    fechamax = "01/05/" & Me.ComboBoxAño.Text
                Case "Mayo"
                    fechamin = "01/05/" & Me.ComboBoxAño.Text
                    fechamax = "01/06/" & Me.ComboBoxAño.Text
                Case "Junio"
                    fechamin = "01/06/" & Me.ComboBoxAño.Text
                    fechamax = "01/07/" & Me.ComboBoxAño.Text
                Case "Julio"
                    fechamin = "01/07/" & Me.ComboBoxAño.Text
                    fechamax = "01/08/" & Me.ComboBoxAño.Text
                Case "Agosto"
                    fechamin = "01/08/" & Me.ComboBoxAño.Text
                    fechamax = "01/09/" & Me.ComboBoxAño.Text
                Case "Septiembre"
                    fechamin = "01/09/" & Me.ComboBoxAño.Text
                    fechamax = "01/10/" & Me.ComboBoxAño.Text
                Case "Octubre"
                    fechamin = "01/10/" & Me.ComboBoxAño.Text
                    fechamax = "01/11/" & Me.ComboBoxAño.Text
                Case "Noviembre"
                    fechamin = "01/11/" & Me.ComboBoxAño.Text
                    fechamax = "01/12/" & Me.ComboBoxAño.Text
                Case "Diciembre"
                    fechamin = "01/12/" & Me.ComboBoxAño.Text
                    fechamax = "31/12/" & Me.ComboBoxAño.Text
            End Select

            ' MessageBox.Show(fechamin, fechamax)
            Dim min As Date = Date.Parse(fechamin)
            Dim max As Date = Date.Parse(fechamax)

            'Primeras instalaciones

            Try
                Me.Enviado_ConsultaTableAdapter.FillByEnviado(Me.TPVDataSet.Enviado_Consulta, min, max)
            Catch ex As System.Exception
            End Try

            Dim RowsCount As Int32 = Me.DataGridView1.RowCount - 1

            If RowsCount > -1 Then
                'The array for field names.
                Dim FldNames() As String = {"Fecha", "Serie", "Cliente", "Ciudad", "Técnico", "Modelo", "", ""}
                'The array for the selected records.
                Dim DataArr(RowsCount, 9) As Object
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

                'Write the field names and the data to the targeting worksheet

                With xlWSheet
                    .Range(.Cells(1, 3), .Cells(1, 3)).Value = "Datafonos Enviados o Usados en Clientes"
                    .Range(.Cells(3, 1), .Cells(3, 5)).Value = FldNames
                    .Range(.Cells(5, 1), .Cells(RowsCount + 5, 5)).Value = DataArr
                    .UsedRange.Columns.AutoFit()
                End With

                Dim contadoraseguir As Integer = RowsCount + 5

                'Segundas instalaciones
                'MessageBox.Show("Segunda parte")
                Try
                    Me.Enviado_ConsultaTableAdapter.FillByRecibido(Me.TPVDataSet.Enviado_Consulta, min, max)
                Catch ex As System.Exception
                End Try

                RowsCount = Me.DataGridView1.RowCount - 1

                If RowsCount > -1 Then
                    'The array for field names.
                    Dim FldNames1() As String = {"Fecha", "Serie", "Cliente", "Ciudad", "Técnico", "Modelo", "", ""}
                    'The array for the selected records.
                    Dim DataArr1(RowsCount, 9) As Object
                    ColsCounter = 0

                    'Populate the data array - The list is sorted in ascending order.
                    For RowsCounter As Int32 = 0 To RowsCount
                        For Each cell As DataGridViewCell In Me.DataGridView1 _
                                                             .Rows(RowsCount - RowsCounter) _
                                                             .Cells
                            DataArr1(RowsCounter, ColsCounter) = cell.Value
                            ColsCounter = ColsCounter + 1
                        Next
                        ColsCounter = 0
                    Next

                    With xlWSheet
                        .Range(.Cells(contadoraseguir + 2, 3), .Cells(contadoraseguir + 2, 3)).Value = "Datafonos Recibidos o Retirados de Clientes"
                        .Range(.Cells(contadoraseguir + 4, 1), .Cells(contadoraseguir + 4, 5)).Value = FldNames
                        .Range(.Cells(contadoraseguir + 6, 1), .Cells(RowsCount + contadoraseguir + 6, 5)).Value = DataArr1
                        .Name = Me.ComboBoxMes.Text
                        .UsedRange.Columns.AutoFit()
                    End With
                End If
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

            Else
                MessageBox.Show("No hay datos para instalaciones en la fecha introducida")
            End If

        End If
    End Sub

    Private Sub ButtonCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub

End Class