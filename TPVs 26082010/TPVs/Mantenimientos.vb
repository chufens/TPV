Public Class Mantenimientos
    Dim estadorow() As TPVDataSet.EstadoRow
    Dim localizacionrow() As TPVDataSet.LocalizacionRow
    Dim marcarow() As TPVDataSet.MarcasRow
    Dim modelorow() As TPVDataSet.ModelosRow
    Dim submodelorow() As TPVDataSet.SubmodeloRow
    Dim tecnicorow() As TPVDataSet.TécnicosRow

    Private Sub Mantenimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TPVDataSet.Técnicos' table. You can move, or remove it, as needed.
        Me.TécnicosTableAdapter.Fill(Me.TPVDataSet.Técnicos)
        'TODO: This line of code loads data into the 'TPVDataSet.Submodelo' table. You can move, or remove it, as needed.
        Me.SubmodeloTableAdapter.Fill(Me.TPVDataSet.Submodelo)
        'TODO: This line of code loads data into the 'TPVDataSet.Modelos' table. You can move, or remove it, as needed.
        Me.ModelosTableAdapter.Fill(Me.TPVDataSet.Modelos)
        'TODO: This line of code loads data into the 'TPVDataSet.Marcas' table. You can move, or remove it, as needed.
        Me.MarcasTableAdapter.Fill(Me.TPVDataSet.Marcas)
        'TODO: This line of code loads data into the 'TPVDataSet.Localizacion' table. You can move, or remove it, as needed.
        Me.LocalizacionTableAdapter.Fill(Me.TPVDataSet.Localizacion)
        'TODO: This line of code loads data into the 'TPVDataSet.Estado' table. You can move, or remove it, as needed.
        Me.EstadoTableAdapter.Fill(Me.TPVDataSet.Estado)
        If Main.Marcas <> "" Then
            Me.ComboBoxMarca.Text = Main.Marcas
            Me.ComboBoxMarca.Enabled = False
            Me.TextBoxModelo.Select()
            Main.Marcas = ""
        Else
            With Me.ComboBoxMarca
                .DataSource = Me.MarcasTableAdapter.GetData
                .DisplayMember = "Marca_TPV"
            End With

        End If
        If Main.Marcas <> "" And Main.Modelo <> "" Then
            Me.ComboBoxMarca1.Text = Main.Marcas
            Me.ComboBoxMarca.Enabled = False
            Me.ComboBoxModelo.Text = Main.Modelo
            Me.ComboBoxModelo.Enabled = False
            Main.Marcas = ""
            Main.Modelo = ""
        Else
            With Me.ComboBoxMarca1
                .DataSource = Me.MarcasTableAdapter.GetData
                .DisplayMember = "Marca_TPV"
            End With

        End If
    End Sub

    Private Sub ButtonIntroEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIntroEstado.Click
        Dim resultado As DialogResult
        If Me.TextBoxEstado.Text <> "" Then
            Try
                estadorow = TPVDataSet.Tables("Estado").Select("Estado = '" & Me.TextBoxEstado.Text & "'")
                Dim a As String = estadorow(0)("Estado").ToString
                MessageBox.Show("El estado '" & a & "' ya se encuentra en la base de datos")
                Me.TextBoxEstado.Clear()
                Me.TextBoxEstado.Select()
            Catch ex As Exception
                Me.EstadoTableAdapter.Insert(Me.TextBoxEstado.Text)

                Me.Validate()
                Me.EstadoBindingSource.EndEdit()
                Me.EstadoTableAdapter.Fill(Me.TPVDataSet.Estado)

                Me.TextBoxEstado.Clear()
                resultado = MessageBox.Show("Estado añadido correctamente. ¿Desea añadir otro?", "", MessageBoxButtons.YesNo)
                If resultado Then
                    Me.TextBoxEstado.Select()
                Else : Me.Close()
                End If
            End Try
        Else : MessageBox.Show("Por favor introduzca un estado válido")
            Me.TextBoxEstado.Select()
        End If

    End Sub

    Private Sub ButtonIntroLocalizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIntroLocalizacion.Click
        Dim resultado As DialogResult
        If Me.TextBoxLocalizacion.Text <> "" Then
            Try
                localizacionrow = TPVDataSet.Tables("Localizacion").Select("Localizacion = '" & Me.TextBoxLocalizacion.Text & "'")
                Dim a As String = localizacionrow(0)("Localizacion").ToString
                MessageBox.Show("La localización '" & a & "' ya se encuentra en la base de datos")
                Me.TextBoxLocalizacion.Clear()
                Me.TextBoxLocalizacion.Select()
            Catch ex As Exception
                Me.LocalizacionTableAdapter.Insert(Me.TextBoxLocalizacion.Text)

                Me.Validate()
                Me.LocalizacionBindingSource.EndEdit()
                Me.LocalizacionTableAdapter.Fill(Me.TPVDataSet.Localizacion)

                Me.TextBoxLocalizacion.Clear()
                resultado = MessageBox.Show("Localización añadida correctamente. ¿Desea añadir otra?", "", MessageBoxButtons.YesNo)
                If resultado Then
                    Me.TextBoxLocalizacion.Select()
                Else : Me.Close()
                End If
            End Try
        Else : MessageBox.Show("Por favor introduzca una localización válida")
            Me.TextBoxLocalizacion.Select()
        End If
    End Sub

    Private Sub ButtonIntroMarcas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIntroMarcas.Click
        If Me.TextBoxMarca.Text <> "" Then
            Try
                marcarow = TPVDataSet.Tables("Marcas").Select("Marca_TPV = '" & Me.TextBoxMarca.Text & "'")
                Dim a As String = marcarow(0)("Marca_TPV").ToString
                MessageBox.Show("La marca '" & a & "' ya se encuentra en la base de datos")
                Me.TextBoxMarca.Clear()
                Me.TextBoxMarca.Select()
            Catch ex As Exception
                Me.MarcasTableAdapter.Insert(Me.TextBoxMarca.Text)

                Me.Validate()
                Me.MarcasBindingSource.EndEdit()
                Me.MarcasTableAdapter.Fill(Me.TPVDataSet.Marcas)

                MessageBox.Show("Marca añadida correctamente.")
                Me.TextBoxMarca.Select()
                Me.TextBoxMarca.Clear()
            End Try
        Else : MessageBox.Show("Por favor introduzca una marca válida")
            Me.TextBoxMarca.Clear()
            Me.TextBoxMarca.Select()
        End If
        With Me.ComboBoxMarca
            .DataSource = Me.MarcasTableAdapter.GetData
            .DisplayMember = "Marca_TPV"
        End With
        With Me.ComboBoxMarca1
            .DataSource = Me.MarcasTableAdapter.GetData
            .DisplayMember = "Marca_TPV"
        End With
    End Sub

    Private Sub ButtonIntroModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIntroModelo.Click
        Dim resultado As DialogResult
        If Me.ComboBoxMarca.Text <> "" And Me.TextBoxModelo.Text <> "" Then
            Try
                modelorow = TPVDataSet.Tables("Modelos").Select("Nobre_Modelo = '" & Me.TextBoxModelo.Text & "'")
                Dim a As String = modelorow(0)("Nobre_Modelo").ToString
                MessageBox.Show("El modelo '" & a & "' ya se encuentra en la base de datos")
                Me.TextBoxModelo.Clear()
                Me.TextBoxModelo.Select()
            Catch ex As Exception
                Try
                    marcarow = TPVDataSet.Tables("Marcas").Select("Marca_TPV = '" & Me.ComboBoxMarca.Text & "'")
                    'MessageBox.Show(marcarow(0)("Id_Marca").ToString)
                    'MessageBox.Show(Me.TextBoxModelo.Text)
                    Me.ModelosTableAdapter.Insert(marcarow(0)("Id_Marca").ToString, Me.TextBoxModelo.Text)

                    Me.Validate()
                    Me.ModelosBindingSource.EndEdit()
                    Me.ModelosTableAdapter.Fill(Me.TPVDataSet.Modelos)

                    resultado = MessageBox.Show("Modelo añadido correctamente. ¿Desea añadir otro modelo a la marca '" & Me.ComboBoxMarca.Text & "'?", "", MessageBoxButtons.YesNo)
                    If resultado = Windows.Forms.DialogResult.Yes Then
                        Me.TextBoxModelo.Clear()
                        Me.TextBoxModelo.Select()
                    Else : resultado = MessageBox.Show("¿Desea añadir modelos a otra marca?", "", MessageBoxButtons.YesNo)
                        If resultado = Windows.Forms.DialogResult.Yes Then
                            Me.ComboBoxMarca.Enabled = True
                            With Me.ComboBoxMarca
                                .DataSource = Me.MarcasTableAdapter.GetData
                                .DisplayMember = "Marca_TPV"
                            End With
                            Me.ComboBoxMarca.Select()
                            Me.TextBoxModelo.Clear()
                        Else
                            Me.ComboBoxMarca.Select()
                            Me.TextBoxModelo.Clear()
                        End If
                    End If
                Catch ex1 As Exception
                    MessageBox.Show("Por favor introduzca una marca válida")
                    Me.ComboBoxMarca.Select()
                End Try
            End Try
        Else : MessageBox.Show("Por favor introduzca una marca y un modelo válidos")
            Me.ComboBoxMarca.Select()
        End If

    End Sub

    Private Sub BotonBorrarModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonBorrarModelo.Click
        With Me.ComboBoxMarca
            .DataSource = Me.MarcasTableAdapter.GetData
            .DisplayMember = "Marca_TPV"
        End With
        Me.ComboBoxMarca.Select()
        Me.TextBoxModelo.Clear()
    End Sub

    Private Sub ComboBoxMarca1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxMarca1.SelectedIndexChanged
        Try
            marcarow = TPVDataSet.Tables("Marcas").Select("Marca_TPV = '" & Me.ComboBoxMarca1.Text & "'")
            With Me.ComboBoxModelo
                .DataSource = Me.ModelosTableAdapter.GetDataBy(marcarow(0)("Id_Marca"))
                .DisplayMember = "Nobre_Modelo"
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonIntroSubmodelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIntroSubmodelo.Click

        marcarow = TPVDataSet.Tables("Marcas").Select("Marca_TPV = '" & Me.ComboBoxMarca1.Text & "'")

        Dim resultado As DialogResult
        If Me.ComboBoxMarca1.Text <> "" And Me.TextBoxSubModelo.Text <> "" Then
            Try
                submodelorow = TPVDataSet.Tables("Submodelo").Select("Submodelo = '" & Me.TextBoxSubModelo.Text & "'")
                Dim a As String = submodelorow(0)("Submodelo").ToString
                MessageBox.Show("El submodelo '" & a & "' ya se encuentra en la base de datos")
                Me.TextBoxSubModelo.Clear()
                Me.TextBoxSubModelo.Select()
            Catch ex As Exception
                Try
                    modelorow = TPVDataSet.Tables("Modelos").Select("Nobre_Modelo = '" & Me.ComboBoxModelo.Text & "'")
                    'MessageBox.Show(marcarow(0)("Id_Marca").ToString)
                    'MessageBox.Show(Me.TextBoxSubModelo.Text)
                    Me.SubmodeloTableAdapter.Insert(modelorow(0)("Id_Modelo").ToString, Me.TextBoxSubModelo.Text)

                    Me.Validate()
                    Me.SubmodeloBindingSource.EndEdit()
                    Me.SubmodeloTableAdapter.Fill(Me.TPVDataSet.Submodelo)

                    resultado = MessageBox.Show("Submodelo añadido correctamente. ¿Desea añadir más submodelos al '" & Me.ComboBoxModelo.Text & "'?", "", MessageBoxButtons.YesNo)
                    If resultado = Windows.Forms.DialogResult.Yes Then
                        Me.TextBoxSubModelo.Clear()
                        Me.TextBoxSubModelo.Select()
                    Else : resultado = MessageBox.Show("¿Desea añadir submodelos a otro modelo de la marca '" & Me.ComboBoxMarca1.Text & "'?", "", MessageBoxButtons.YesNo)
                        If resultado = Windows.Forms.DialogResult.Yes Then
                            Me.ComboBoxModelo.Enabled = True
                            Me.TextBoxSubModelo.Clear()
                            With Me.ComboBoxModelo
                                .DataSource = Me.ModelosTableAdapter.GetDataBy(marcarow(0)("Id_Marca"))
                                .DisplayMember = "Nobre_Modelo"
                            End With
                            Me.ComboBoxModelo.Select()
                        Else : resultado = MessageBox.Show("¿Desea añadir submodelos a otra marca?", "", MessageBoxButtons.YesNo)
                            If resultado = Windows.Forms.DialogResult.Yes Then
                                Me.ComboBoxMarca1.Enabled = True
                                With Me.ComboBoxMarca1
                                    .DataSource = Me.MarcasTableAdapter.GetData
                                    .DisplayMember = "Marca_TPV"
                                End With
                                Me.ComboBoxModelo.DataSource = Nothing
                                Me.ComboBoxMarca1.Select()
                                Me.TextBoxSubModelo.Clear()
                            Else
                                Me.ComboBoxModelo.DataSource = Nothing
                                Me.ComboBoxMarca1.Select()
                                Me.TextBoxSubModelo.Clear()
                            End If
                        End If
                    End If
                Catch ex1 As Exception
                    MessageBox.Show("Por favor introduzca un modelo válido")
                    Me.ComboBoxMarca1.Select()
                End Try

            End Try
        Else : MessageBox.Show("Por favor introduzca una marca, un modelo y un submodelo válidos")
            Me.ComboBoxMarca1.Select()
        End If
    End Sub

    Private Sub BotonBorrarSubmodelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonBorrarSubmodelo.Click
        With Me.ComboBoxMarca1
            .DataSource = Me.MarcasTableAdapter.GetData
            .DisplayMember = "Marca_TPV"
        End With
        Me.ComboBoxMarca1.Select()
        Me.ComboBoxModelo.DataSource = Nothing
        Me.TextBoxSubModelo.Clear()
    End Sub

    Private Sub ButtonIntroTecnico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIntroTecnico.Click
        If Me.TextBoxNombre.Text <> "" And Me.TextBoxNumero.Text <> "" Then
            Try
                tecnicorow = TPVDataSet.Tables("Técnicos").Select("Técnico = '" & Me.TextBoxNombre.Text & "'")
                Dim a As String = tecnicorow(0)("Técnico").ToString
                MessageBox.Show("El nombre '" & a & "' ya se encuentra en la base de datos")
                Me.TextBoxNombre.Clear()
                Me.TextBoxNombre.Select()

            Catch ex As Exception
                Try
                    tecnicorow = TPVDataSet.Tables("Técnicos").Select("Id_Tecnico = '" & Me.TextBoxNumero.Text & "'")
                    Dim b As Integer = tecnicorow(0)("Id_Tecnico")
                    MessageBox.Show("El número de técnico '" & b.ToString & "' ya se encuentra en la base de datos")
                    Me.TextBoxNumero.Clear()
                    Me.TextBoxNumero.Select()


                Catch ex1 As Exception
                    Me.TécnicosTableAdapter.Insert(Val(Me.TextBoxNumero.Text), Me.TextBoxNombre.Text)

                    Me.Validate()
                    Me.TécnicosBindingSource.EndEdit()
                    Me.TécnicosTableAdapter.Fill(Me.TPVDataSet.Técnicos)

                    MessageBox.Show("Técnico '" & Me.TextBoxNombre.Text & "' con número '" & Me.TextBoxNumero.Text & "' añadido correctamente")
                    Me.TextBoxNombre.Clear()
                    Me.TextBoxNumero.Clear()
                    Me.TextBoxNombre.Select()
                End Try
            End Try
        Else : MessageBox.Show("Por favor introduzca un nombre y un número válidos")
            Me.TextBoxNombre.Select()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class