Public Class Buscar_Clientes

    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label9.Text = Me.ClientesTableAdapter.Totales
        Me.Label10.Text = Me.ClientesTableAdapter.Ing5100
        Me.Label11.Text = Me.ClientesTableAdapter.Banjo
        Me.Label12.Text = Me.ClientesTableAdapter.V8210
        Me.Label13.Text = Me.ClientesTableAdapter.V8010Wifi
        Me.Label14.Text = Me.ClientesTableAdapter.V8010GPRS
        Me.Label15.Text = Me.ClientesTableAdapter.V8020GPRS
        Me.Label17.Text = Math.Round(Val(Label10.Text) * 100 / Val(Label9.Text)) & "%"
        Me.Label18.Text = Math.Round(Val(Label11.Text) * 100 / Val(Label9.Text)) & "%"
        Me.Label19.Text = Math.Round(Val(Label12.Text) * 100 / Val(Label9.Text)) & "%"
        Me.Label20.Text = Math.Round(Val(Label13.Text) * 100 / Val(Label9.Text)) & "%"
        Me.Label21.Text = Math.Round(Val(Label14.Text) * 100 / Val(Label9.Text)) & "%"
        Me.Label22.Text = Math.Round(Val(Label15.Text) * 100 / Val(Label9.Text)) & "%"

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Return)) Then
            e.Handled = True
            Dim dv As New DataView
            If Me.TextBox1.Text <> "" Then
                Try
                    Me.ClientesTableAdapter.FillBy(Me.TPVDataSet.Clientes, Val(Me.TextBox1.Text))
                    If Me.DataGridView1.RowCount = 1 Then
                        MessageBox.Show("No hay datos para ese número de cliente")
                    End If
                Catch ex As Exception
                    MessageBox.Show("No se puede acceder a la base de datos")
                End Try
            End If
        End If
    End Sub

    Private Sub BuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarCliente.Click
        Dim dv As New DataView
        Try
            Me.ClientesTableAdapter.FillBy(Me.TPVDataSet.Clientes, Val(Me.TextBox1.Text))
            If Me.DataGridView1.RowCount = 1 Then
                MessageBox.Show("No hay datos para ese número de cliente")
            End If
        Catch ex As Exception
            MessageBox.Show("No se puede acceder a la base de datos")
        End Try

    End Sub

    Private Sub BotonCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonCerrar.Click
        Me.Validate()
        Me.TPVDataSetBindingSource.EndEdit()
        Me.ClientesBindingSource.EndEdit()
        Me.Close()
    End Sub

End Class