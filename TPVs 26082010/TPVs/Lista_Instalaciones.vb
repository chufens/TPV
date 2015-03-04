Public Class Lista_Instalaciones

    Private Sub ButtonGenerar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGenerar.Click
        Dim nuevas As Boolean = False
        Dim segundas As Boolean = False

        If Me.ComboBoxA�o.Text = "" Or Me.ComboBoxMes.Text = "" Then
            MessageBox.Show("Seleccione un mes y un a�o en los que realizar la busqueda")
        Else
            Dim fechamin As String = Date.Now.ToString
            Dim fechamax As String = Date.Now.ToString

            Select Case Me.ComboBoxMes.Text
                Case "Enero"
                    fechamin = "01/01/" & Me.ComboBoxA�o.Text
                    fechamax = "01/02/" & Me.ComboBoxA�o.Text
                Case "Febrero"
                    fechamin = "01/02/" & Me.ComboBoxA�o.Text
                    fechamax = "01/03/" & Me.ComboBoxA�o.Text
                Case "Marzo"
                    fechamin = "01/03/" & Me.ComboBoxA�o.Text
                    fechamax = "01/04/" & Me.ComboBoxA�o.Text
                Case "Abril"
                    fechamin = "01/04/" & Me.ComboBoxA�o.Text
                    fechamax = "01/05/" & Me.ComboBoxA�o.Text
                Case "Mayo"
                    fechamin = "01/05/" & Me.ComboBoxA�o.Text
                    fechamax = "01/06/" & Me.ComboBoxA�o.Text
                Case "Junio"
                    fechamin = "01/06/" & Me.ComboBoxA�o.Text
                    fechamax = "01/07/" & Me.ComboBoxA�o.Text
                Case "Julio"
                    fechamin = "01/07/" & Me.ComboBoxA�o.Text
                    fechamax = "01/08/" & Me.ComboBoxA�o.Text
                Case "Agosto"
                    fechamin = "01/08/" & Me.ComboBoxA�o.Text
                    fechamax = "01/09/" & Me.ComboBoxA�o.Text
                Case "Septiembre"
                    fechamin = "01/09/" & Me.ComboBoxA�o.Text
                    fechamax = "01/10/" & Me.ComboBoxA�o.Text
                Case "Octubre"
                    fechamin = "01/10/" & Me.ComboBoxA�o.Text
                    fechamax = "01/11/" & Me.ComboBoxA�o.Text
                Case "Noviembre"
                    fechamin = "01/11/" & Me.ComboBoxA�o.Text
                    fechamax = "01/12/" & Me.ComboBoxA�o.Text
                Case "Diciembre"
                    fechamin = "01/12/" & Me.ComboBoxA�o.Text
                    fechamax = "31/12/" & Me.ComboBoxA�o.Text
            End Select

            ' MessageBox.Show(fechamin, fechamax)
            Dim min As Date = Date.Parse(fechamin)
            Dim max As Date = Date.Parse(fechamax)

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

            Dim contadoraseguir As Integer = 0

            'Primeras instalaciones

            Try
                Me.Instalado_ConsultaTableAdapter.FillByNuevas(Me.TPVDataSet.Instalado_Consulta, True, min, max)
            Catch ex As System.Exception
            End Try

            Dim RowsCount As Int32 = Me.DataGridView1.RowCount - 1

            If RowsCount > -1 Then
                'The array for field names.
                Dim FldNames() As String = {"Fecha", "Serie", "Cliente", "Ciudad", "T�cnico", "Modelo", "", ""}
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
                'Dim xlApp As New Excel.Application
                'Dim xlWBook As Excel.Workbook = xlApp.Workbooks.Add( _
                '                                Excel.XlWBATemplate.xlWBATWorksheet)
                'Dim xlWSheet As Excel.Worksheet = CType(xlWBook.Worksheets(1), Excel.Worksheet)
                'Dim xlCalc As Excel.XlCalculation

                'Save the present setting for Excel's calculation mode and turn it off. 
                With xlApp
                    xlCalc = .Calculation
                    .Calculation = Excel.XlCalculation.xlCalculationManual
                End With

                'Write the field names and the data to the targeting worksheet

                With xlWSheet
                    .Range(.Cells(1, 3), .Cells(1, 3)).Value = "Nuevas Instalaciones"
                    .Range(.Cells(3, 1), .Cells(3, 5)).Value = FldNames
                    .Range(.Cells(5, 1), .Cells(RowsCount + 5, 5)).Value = DataArr
                    .UsedRange.Columns.AutoFit()
                End With

                contadoraseguir = RowsCount + 5
                nuevas = True
            End If

            'Segundas instalaciones
            'MessageBox.Show("Segunda parte")
            Try
                Me.Instalado_ConsultaTableAdapter.FillBySegundas(Me.TPVDataSet.Instalado_Consulta, True, min, max)
            Catch ex As System.Exception
            End Try

            RowsCount = Me.DataGridView1.RowCount - 1

            If RowsCount > -1 Then
                'The array for field names.
                Dim FldNames1() As String = {"Fecha", "Serie", "Cliente", "Ciudad", "T�cnico", "Modelo", "", ""}
                'The array for the selected records.
                Dim DataArr1(RowsCount, 9) As Object
                Dim ColsCounter1 As Int32 = 0

                'Populate the data array - The list is sorted in ascending order.
                For RowsCounter As Int32 = 0 To RowsCount
                    For Each cell As DataGridViewCell In Me.DataGridView1 _
                                                         .Rows(RowsCount - RowsCounter) _
                                                         .Cells
                        DataArr1(RowsCounter, ColsCounter1) = cell.Value
                        ColsCounter1 = ColsCounter1 + 1
                    Next
                    ColsCounter1 = 0
                Next

                With xlWSheet
                    .Range(.Cells(contadoraseguir + 2, 3), .Cells(contadoraseguir + 2, 3)).Value = "Segundo Cambio"
                    .Range(.Cells(contadoraseguir + 4, 1), .Cells(contadoraseguir + 4, 5)).Value = FldNames1
                    .Range(.Cells(contadoraseguir + 6, 1), .Cells(RowsCount + contadoraseguir + 6, 5)).Value = DataArr1
                    .Name = Me.ComboBoxMes.Text
                    .UsedRange.Columns.AutoFit()
                End With
                segundas = True
            End If
            If nuevas Or segundas Then

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub
End Class