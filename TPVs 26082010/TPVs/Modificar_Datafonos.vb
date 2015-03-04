Public Class Modificar_Datafonos
    Dim serie As String
    Dim instalado As Boolean
    Dim recibido As Boolean
    Dim primera As Boolean
    Dim segunda As Boolean
    Dim fecha As Date
    Dim cliente As String
    Dim ciudad As String
    Dim tecnico As String

    Dim Instrow() As TPVDataSet.TPVsRow
    Dim Tecrow() As TPVDataSet.TécnicosRow
    Dim Localizacionrow() As TPVDataSet.LocalizacionRow
    Dim estadorow() As TPVDataSet.EstadoRow
    Dim reparacionrow() As TPVDataSet.Comentarios_ReparacionRow


    Dim correcto As Boolean
    Dim resultado As DialogResult

    Private Sub Modificar_Datafonos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TPVDataSet.Estado' table. You can move, or remove it, as needed.
        Me.EstadoTableAdapter.Fill(Me.TPVDataSet.Estado)
        'TODO: This line of code loads data into the 'TPVDataSet.Comentarios_Reparacion' table. You can move, or remove it, as needed.
        Me.Comentarios_ReparacionTableAdapter.Fill(Me.TPVDataSet.Comentarios_Reparacion)
        'TODO: This line of code loads data into the 'TPVDataSet.Localizacion' table. You can move, or remove it, as needed.
        Me.LocalizacionTableAdapter.Fill(Me.TPVDataSet.Localizacion)
        'TODO: This line of code loads data into the 'TPVDataSet.Técnicos' table. You can move, or remove it, as needed.
        Me.TécnicosTableAdapter.Fill(Me.TPVDataSet.Técnicos)
        'TODO: This line of code loads data into the 'TPVDataSet.Instalado' table. You can move, or remove it, as needed.
        Me.InstaladoTableAdapter.Fill(Me.TPVDataSet.Instalado)
        'TODO: This line of code loads data into the 'TPVDataSet.TPVs' table. You can move, or remove it, as needed.
        Me.TPVsTableAdapter.Fill(Me.TPVDataSet.TPVs)
        Me.TextBoxSerie.Select()
        Me.ComboBoxTecnico1.SelectedIndex = -1
        Me.ComboBoxTecnico2.SelectedIndex = -1

    End Sub

    Private Function cambio_serie(ByVal serieinicial As String, ByVal longitud As Integer) As String

        Dim seriefinal As String = ""
        Dim i As Integer
        If serieinicial.Length < 12 Then
            seriefinal = "BT"
        Else : seriefinal = "LN"
        End If
        For i = longitud - 9 To longitud - 1
            seriefinal = String.Concat(seriefinal, serieinicial(i))
            'MessageBox.Show(seriefinal)
        Next

        cambio_serie = seriefinal

    End Function

    Private Sub ButtonAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAceptar.Click
        Dim arg1 As String
        Dim resultado As DialogResult
        Dim a As Integer = Me.TPVsTableAdapter.Existe(Me.TextBoxSerie.Text)
        Dim serie As String = Me.TextBoxSerie.Text
        'Dim estadodat As String

        If serie <> "" Then

            If a = 1 Then 'El datafono existe en la base de datos

                Instrow = TPVDataSet.Tables("TPVs").Select("Serie = '" & serie & "'")
                'MessageBox.Show(instrow(0)("Serie"))

                If Instrow(0)("Estado") = 2 Or Instrow(0)("Estado") = 3 Then
                    '"No OK"
                    Me.GroupBoxEnvío.Enabled = False

                    Me.GroupBoxInstalacion.Enabled = False

                    Me.GroupBoxRepacion.Enabled = True
                    Me.TextBoxSerie3.Text = Me.TextBoxSerie.Text
                    Try
                        Instrow = TPVDataSet.Tables("TPVs").Select("Serie = '" & serie & "'")
                        arg1 = Instrow(0)("Estado").ToString
                        estadorow = TPVDataSet.Tables("Estado").Select("Id_Estado = '" & arg1 & "'")
                        Me.TextBoxEstado.Text = estadorow(0)("Estado").ToString
                    Catch ex As Exception
                    End Try
                    Me.ComboBoxEstado.Focus()

                    Me.GroupBoxLocalizacion.Enabled = False

                ElseIf Instrow(0)("Estado") = 1 Then
                    '"OK" y sin instalar
                    If Instrow(0)("Instalado") = False Then
                        Me.GroupBoxEnvío.Enabled = True
                        Me.TextBoxSerie1.Text = Me.TextBoxSerie.Text
                        Me.CheckBox1.Checked = True
                        Me.ComboBoxTecnico1.SelectedIndex = -1
                        Me.TextBoxCliente1.Focus()

                        Me.GroupBoxInstalacion.Enabled = True
                        Me.TextBoxSerie2.Text = Me.TextBoxSerie.Text
                        Me.CheckBoxInstalacion1.Checked = True
                        Me.ComboBoxTecnico2.SelectedIndex = -1
                        Me.TextBoxCliente2.Focus()

                        Me.GroupBoxRepacion.Enabled = False

                        Me.GroupBoxLocalizacion.Enabled = True
                        Me.TextBoxSerie4.Text = Me.TextBoxSerie.Text
                        Try
                            Instrow = TPVDataSet.Tables("TPVs").Select("Serie = '" & serie & "'")
                            arg1 = Instrow(0)("Id_Localizacion").ToString
                            Localizacionrow = TPVDataSet.Tables("Localizacion").Select("Id_Localizacion = '" & arg1 & "'")
                            Me.TextBoxLocalizacion.Text = Localizacionrow(0)("Localizacion").ToString
                        Catch ex As Exception
                        End Try
                        Me.ComboBoxLocalizacion.Focus()

                    Else
                        '"OK" e instalado
                        Me.GroupBoxEnvío.Enabled = True
                        Me.TextBoxSerie1.Text = Me.TextBoxSerie.Text
                        Me.ComboBoxTecnico1.SelectedIndex = -1
                        Me.CheckBoxInstalacion2.Checked = True
                        Me.TextBoxCliente2.Focus()

                        Me.GroupBoxInstalacion.Enabled = False
                        Me.ComboBoxTecnico2.SelectedIndex = -1

                        Me.GroupBoxLocalizacion.Enabled = False

                        Me.GroupBoxRepacion.Enabled = False

                    End If
                End If
            Else
                resultado = MessageBox.Show("El datáfono no existe en la base de datos, ¿Desea añadirlo?", "", MessageBoxButtons.YesNoCancel)
                If resultado = Windows.Forms.DialogResult.Yes Then
                    Main.numserie = Me.TextBoxSerie.Text
                    Me.TextBoxSerie.Clear()
                    Me.TextBoxSerie.Select()
                    Dim NewMDIChild As New Añadir_Datafono()
                    'Set the Parent Form of the Child window.
                    NewMDIChild.MdiParent = Main
                    'Display the new form.
                    NewMDIChild.Show()
                    Me.Close()
                Else : Me.TextBoxSerie.Clear()
                    Me.TextBoxSerie.Select()
                End If
            End If
        End If

    End Sub

    Private Sub TextBoxSerie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxSerie.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Return)) Then
            e.Handled = True
            Dim arg1 As String
            Dim resultado As DialogResult
            Dim a As Integer = Me.TPVsTableAdapter.Existe(Me.TextBoxSerie.Text)
            Dim serie As String = Me.TextBoxSerie.Text
            'Dim estadodat As String

            If serie <> "" Then

                If a = 1 Then 'El datafono existe en la base de datos

                    Instrow = TPVDataSet.Tables("TPVs").Select("Serie = '" & serie & "'")
                    'MessageBox.Show(instrow(0)("Serie"))

                    If Instrow(0)("Estado") = 2 Or Instrow(0)("Estado") = 3 Then
                        '"No OK"
                        Me.GroupBoxEnvío.Enabled = False

                        Me.GroupBoxInstalacion.Enabled = False

                        Me.GroupBoxRepacion.Enabled = True
                        Me.TextBoxSerie3.Text = Me.TextBoxSerie.Text
                        Try
                            Instrow = TPVDataSet.Tables("TPVs").Select("Serie = '" & serie & "'")
                            arg1 = Instrow(0)("Estado").ToString
                            estadorow = TPVDataSet.Tables("Estado").Select("Id_Estado = '" & arg1 & "'")
                            Me.TextBoxEstado.Text = estadorow(0)("Estado").ToString
                        Catch ex As Exception
                        End Try
                        Me.ComboBoxEstado.Focus()

                        Me.GroupBoxLocalizacion.Enabled = False

                    ElseIf Instrow(0)("Estado") = 1 Then
                        '"OK" y sin instalar
                        If Instrow(0)("Instalado") = False Then
                            Me.GroupBoxEnvío.Enabled = True
                            Me.TextBoxSerie1.Text = Me.TextBoxSerie.Text
                            Me.CheckBox1.Checked = True
                            Me.ComboBoxTecnico1.SelectedIndex = -1
                            Me.TextBoxCliente1.Focus()

                            Me.GroupBoxInstalacion.Enabled = True
                            Me.TextBoxSerie2.Text = Me.TextBoxSerie.Text
                            Me.CheckBoxInstalacion1.Checked = True
                            Me.ComboBoxTecnico2.SelectedIndex = -1
                            Me.TextBoxCliente2.Focus()

                            Me.GroupBoxRepacion.Enabled = False

                            Me.GroupBoxLocalizacion.Enabled = True
                            Me.TextBoxSerie4.Text = Me.TextBoxSerie.Text
                            Try
                                Instrow = TPVDataSet.Tables("TPVs").Select("Serie = '" & serie & "'")
                                arg1 = Instrow(0)("Id_Localizacion").ToString
                                Localizacionrow = TPVDataSet.Tables("Localizacion").Select("Id_Localizacion = '" & arg1 & "'")
                                Me.TextBoxLocalizacion.Text = Localizacionrow(0)("Localizacion").ToString
                            Catch ex As Exception
                            End Try
                            Me.ComboBoxLocalizacion.Focus()

                        Else
                            '"OK" e instalado
                            Me.GroupBoxEnvío.Enabled = True
                            Me.TextBoxSerie1.Text = Me.TextBoxSerie.Text
                            Me.ComboBoxTecnico1.SelectedIndex = -1
                            Me.CheckBoxInstalacion2.Checked = True
                            Me.TextBoxCliente2.Focus()

                            Me.GroupBoxInstalacion.Enabled = False
                            Me.ComboBoxTecnico2.SelectedIndex = -1

                            Me.GroupBoxLocalizacion.Enabled = False

                            Me.GroupBoxRepacion.Enabled = False

                        End If
                    End If
                Else
                    resultado = MessageBox.Show("El datáfono no existe en la base de datos, ¿Desea añadirlo?", "", MessageBoxButtons.YesNoCancel)
                    If resultado = Windows.Forms.DialogResult.Yes Then
                        Main.numserie = Me.TextBoxSerie.Text
                        Me.TextBoxSerie.Clear()
                        Me.TextBoxSerie.Select()
                        Dim NewMDIChild As New Añadir_Datafono()
                        'Set the Parent Form of the Child window.
                        NewMDIChild.MdiParent = Main
                        'Display the new form.
                        NewMDIChild.Show()
                        Me.Close()
                    Else : Me.TextBoxSerie.Clear()
                        Me.TextBoxSerie.Select()
                    End If
                End If
            End If

        End If

    End Sub

    Private Sub TextBoxSerie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSerie.TextChanged
        If Me.TextBoxSerie.Text <> "" Then
            Me.GroupBoxEnvío.Enabled = True
            Me.GroupBoxLocalizacion.Enabled = True
            Me.GroupBoxInstalacion.Enabled = True
            Me.GroupBoxRepacion.Enabled = True

            Me.TextBoxSerie4.Clear()
            Me.TextBoxLocalizacion.Clear()
            Me.ComboBoxLocalizacion.SelectedIndex = -1

            Me.TextBoxSerie3.Clear()
            Me.TextBoxEstado.Clear()
            Me.TextBoxComentario.Clear()
            Me.ComboBoxEstado.SelectedIndex = -1

            Me.TextBoxSerie2.Clear()
            Me.CheckBoxInstalacion1.Checked = False
            Me.CheckBoxInstalacion2.Checked = False
            Me.TextBoxCliente2.Clear()
            Me.TextBoxCiudad2.Clear()
            Me.ComboBoxTecnico2.SelectedIndex = -1

            Me.TextBoxSerie1.Clear()
            Me.CheckBox1.Checked = False
            Me.CheckBox2.Checked = False
            Me.TextBoxCliente1.Clear()
            Me.TextBoxCiudad1.Clear()
            Me.ComboBoxTecnico1.SelectedIndex = -1
        End If
    End Sub

    Private Sub BotonBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonBorrar1.Click
        Me.TextBoxSerie1.Clear()
        Me.CheckBox1.Checked = False
        Me.CheckBox2.Checked = False
        Me.TextBoxCliente1.Clear()
        Me.TextBoxCiudad1.Clear()
        Me.ComboBoxTecnico1.Text = ""
        Me.ComboBoxTecnico1.SelectedIndex = -1
        Me.TextBoxSerie1.Select()
        Me.Label10.Visible = False
        Me.Label11.Visible = False
        Me.Label12.Visible = False
        Me.Label13.Visible = False
        Me.Label14.Visible = False
        Me.Label15.Visible = False
        Me.Label16.Visible = False
    End Sub

    Private Sub ButtonActMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonActMod.Click
        Dim largo As Integer = Me.TextBoxSerie1.Text.Length
        Dim arg1 As Boolean

        serie = Me.TextBoxSerie1.Text
        instalado = Me.CheckBox1.CheckState
        recibido = Me.CheckBox2.CheckState
        fecha = Me.DateTimePicker1.Value
        cliente = Me.TextBoxCliente1.Text
        ciudad = Me.TextBoxCiudad1.Text

        correcto = True

        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        Label16.Visible = False

        If serie <> "" Then
            Dim serie_mod As String = Me.cambio_serie(Me.TextBoxSerie1.Text, largo)

            'Intentar leer de la base de datos si esta instalado y lo intentamos enviar

            Instrow = TPVDataSet.Tables("TPVs").Select("Serie = '" & serie & "'")
            arg1 = Instrow(0)("Instalado")

            Try
                Tecrow = TPVDataSet.Tables("Técnicos").Select("Técnico= '" & Me.ComboBoxTecnico1.Text & "'")
                tecnico = Tecrow(0)("Id_Tecnico").ToString
            Catch ex As Exception
                tecnico = Me.ComboBoxTecnico1.Text
            End Try

            If serie = "" Then
                Label10.Visible = True
                correcto = False
            End If
            If instalado = False And recibido = False Then
                Label11.Visible = True
                Label12.Visible = True
                correcto = False
            End If
            If arg1 And instalado Then
                MessageBox.Show("El datáfono figura como instalado en un cliente, Tiene que recepcionarlo antes")
                Label11.Visible = True
                correcto = False
            End If
            If arg1 = False And recibido Then
                MessageBox.Show("El datáfono no figura como instalado en ningún cliente")
                Label12.Visible = True
                correcto = False
            End If
            If cliente = "" Then
                Label14.Visible = True
                correcto = False
            End If
            If ciudad = "" Then
                Label15.Visible = True
                correcto = False
            End If
            If tecnico = "" Then
                Label16.Visible = True
                correcto = False
                'Else : correcto = True
            End If

            If correcto Then

                Me.InstaladoTableAdapter.Insert(instalado, recibido, False, fecha, cliente, tecnico, False, serie, ciudad, serie_mod)

                Instrow = TPVDataSet.Tables("TPVs").Select("Serie = '" & serie & "'")
                Instrow(0)("Instalado") = instalado
                Instrow(0)("Comentario") = cliente

                Me.TPVsTableAdapter.Update(Me.TPVDataSet.TPVs)
                Me.TextBoxSerie1.Clear()
                Me.CheckBox1.Checked = False
                Me.CheckBox2.Checked = False
                Me.TextBoxCliente1.Clear()
                Me.TextBoxCiudad1.Clear()
                Me.ComboBoxTecnico1.Text = ""
                Me.ComboBoxTecnico1.SelectedIndex = -1
                Me.TextBoxSerie1.Select()

                MessageBox.Show("Datos introducidos correctamente")

                Label10.Visible = False
                Label11.Visible = False
                Label12.Visible = False
                Label13.Visible = False
                Label14.Visible = False
                Label15.Visible = False
                Label16.Visible = False

            Else : MessageBox.Show("Por favor compruebe los campos marcados con asteriscos")
            End If
        End If

    End Sub

    Private Sub TextBoxSerie1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxSerie1.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Return)) Then
            e.Handled = True
            Dim serie As String = Me.TextBoxSerie1.Text
            Dim arg1 As Boolean

            If serie <> "" Then
                Try
                    Instrow = TPVDataSet.Tables("TPVs").Select("Serie = '" & serie & "'")
                    arg1 = Instrow(0)("Instalado")
                Catch ex As Exception
                    resultado = MessageBox.Show("El datáfono no existe en la base de datos, ¿Desea introducirlo?", "", MessageBoxButtons.YesNo)
                    If resultado = Windows.Forms.DialogResult.Yes Then
                        Main.numserie = Me.TextBoxSerie1.Text
                        Me.TextBoxSerie1.Clear()
                        Me.TextBoxSerie1.Select()
                        Dim NewMDIChild As New Añadir_Datafono()
                        'Set the Parent Form of the Child window.
                        NewMDIChild.MdiParent = Main
                        'Display the new form.
                        NewMDIChild.Show()
                        Me.Close()

                    Else : Me.TextBoxSerie1.Clear()
                        Me.TextBoxSerie1.Select()
                    End If
                End Try
            End If
            Me.CheckBox1.Focus()
        End If
    End Sub

    Private Sub ButtonBorrar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBorrar2.Click
        Me.TextBoxSerie2.Clear()
        Me.CheckBoxInstalacion1.Checked = False
        Me.CheckBoxInstalacion2.Checked = False
        Me.TextBoxCliente2.Clear()
        Me.TextBoxCiudad2.Clear()
        Me.ComboBoxTecnico2.Text = ""
        Me.ComboBoxTecnico2.SelectedIndex = -1
        Me.TextBoxSerie2.Select()
        Me.Label100.Visible = False
        Me.Label101.Visible = False
        Me.Label102.Visible = False
        Me.Label103.Visible = False
        Me.Label104.Visible = False
        Me.Label105.Visible = False
        Me.Label106.Visible = False
    End Sub

    Private Sub ButtonActInst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonActInst.Click
        Dim largo As Integer = Me.TextBoxSerie2.Text.Length
        Dim serie_mod As String = Me.cambio_serie(Me.TextBoxSerie2.Text, largo)
        Dim arg1 As Boolean

        serie = Me.TextBoxSerie2.Text
        fecha = Me.DateTimePicker2.Value
        primera = Me.CheckBoxInstalacion1.CheckState
        segunda = Me.CheckBoxInstalacion2.CheckState
        cliente = Me.TextBoxCliente2.Text
        ciudad = Me.TextBoxCiudad2.Text
        correcto = True

        Instrow = TPVDataSet.Tables("TPVs").Select("Serie = '" & serie & "'")
        arg1 = Instrow(0)("Instalado")

        Try
            Tecrow = TPVDataSet.Tables("Técnicos").Select("Técnico= '" & Me.ComboBoxTecnico2.Text & "'")
            tecnico = Tecrow(0)("Id_Tecnico").ToString
        Catch ex As Exception
            tecnico = Me.ComboBoxTecnico2.Text
        End Try

        Label100.Visible = False
        Label101.Visible = False
        Label102.Visible = False
        Label103.Visible = False
        Label104.Visible = False
        Label105.Visible = False
        Label106.Visible = False

        If serie = "" Then
            Label100.Visible = True
            correcto = False
        End If
        If primera = False And segunda = False Then
            Label101.Visible = True
            Label102.Visible = True
            correcto = False
        End If
        If arg1 And primera Then
            MessageBox.Show("El datáfono figura como instalado en un cliente, Tiene que recepcionarlo antes")
            Label101.Visible = True
            correcto = False
        End If
        If arg1 And segunda Then
            MessageBox.Show("El datáfono figura como instalado en un cliente, Tiene que recepcionarlo antes")
            Label102.Visible = True
            correcto = False
        End If
        If cliente = "" Then
            Label104.Visible = True
            correcto = False
        End If
        If ciudad = "" Then
            Label105.Visible = True
            correcto = False
        End If
        If tecnico = "" Then
            Label106.Visible = True
            correcto = False
        End If

        If correcto Then
            Me.InstaladoTableAdapter.Insert(True, False, primera, fecha, cliente, tecnico, segunda, serie, ciudad, serie_mod)

            Instrow = TPVDataSet.Tables("TPVs").Select("Serie = '" & serie & "'")
            Instrow(0)("Instalado") = "True"
            Me.TPVsTableAdapter.Update(Me.TPVDataSet.TPVs)

            Me.TextBoxSerie2.Clear()
            Me.CheckBoxInstalacion1.Checked = False
            Me.CheckBoxInstalacion2.Checked = False
            Me.TextBoxCliente2.Clear()
            Me.TextBoxCiudad2.Clear()
            Me.ComboBoxTecnico2.Text = ""
            Me.ComboBoxTecnico2.SelectedIndex = -1
            Me.TextBoxSerie2.Select()

            MessageBox.Show("Datos introducidos correctamente")

            Label100.Visible = False
            Label101.Visible = False
            Label102.Visible = False
            Label103.Visible = False
            Label104.Visible = False
            Label105.Visible = False
            Label106.Visible = False

        Else : MessageBox.Show("Por favor compruebe los campos marcados con asteriscos")
        End If
    End Sub

    Private Sub TextBoxSerie2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxSerie2.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Return)) Then
            e.Handled = True
            Dim serie As String = Me.TextBoxSerie2.Text
            Dim arg1 As Boolean

            If serie <> "" Then
                Try
                    Instrow = TPVDataSet.Tables("TPVs").Select("Serie = '" & serie & "'")
                    arg1 = Instrow(0)("Instalado")
                Catch ex As Exception
                    resultado = MessageBox.Show("El datáfono no existe en la base de datos, ¿Desea introducirlo?", "", MessageBoxButtons.YesNo)
                    If resultado = Windows.Forms.DialogResult.Yes Then
                        Main.numserie = Me.TextBoxSerie2.Text
                        Me.TextBoxSerie2.Clear()
                        Me.TextBoxSerie2.Select()
                        Dim NewMDIChild As New Añadir_Datafono()
                        'Set the Parent Form of the Child window.
                        NewMDIChild.MdiParent = Main
                        'Display the new form.
                        NewMDIChild.Show()
                        Me.Close()

                    Else : Me.TextBoxSerie2.Clear()
                        Me.TextBoxSerie2.Select()
                    End If
                End Try
            End If
            Me.CheckBoxInstalacion1.Focus()
        End If
    End Sub

    Private Sub ButtonBorrar3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBorrar3.Click
        Me.TextBoxSerie3.Clear()
        Me.TextBoxEstado.Clear()
        Me.TextBoxComentario.Clear()
        Me.ComboBoxEstado.SelectedIndex = -1
        Me.TextBoxSerie3.Select()
    End Sub

    Private Sub ButtonActRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonActRep.Click
        Dim estado_Final As Integer
        If Me.ComboBoxEstado.Text <> "" Then
            Try
                estadorow = TPVDataSet.Tables("Estado").Select("Estado = '" & Me.ComboBoxEstado.Text & "'")
                'MessageBox.Show(estadorow(0)("Estado").ToString)
                Instrow(0)("Estado") = estadorow(0)("Id_Estado")
                'MessageBox.Show(TPVrow(0)("Estado").ToString)
                estado_Final = estadorow(0)("Id_Estado")
                Me.TPVsTableAdapter.Update(Me.TPVDataSet.TPVs)
                Me.Comentarios_ReparacionTableAdapter.Insert(Me.TextBoxSerie3.Text, Me.TextBoxComentario.Text, Date.Now, estado_Final)
                MessageBox.Show("Actualización correcta")
                Me.TextBoxSerie3.Text = ""
                Me.TextBoxEstado.Text = ""
                Me.TextBoxComentario.Text = ""
                Me.ComboBoxEstado.SelectedIndex = -1
                Me.TextBoxSerie3.Select()
            Catch ex As Exception
                MessageBox.Show("Imposible realizar actualizacion")
            End Try
        Else : MessageBox.Show("Por favor, seleccione un nuevo estado")
        End If
    End Sub

    Private Sub TextBoxSerie3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxSerie3.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Return)) Then
            e.Handled = True
            Dim serie As String = Me.TextBoxSerie3.Text
            Dim arg1 As Integer

            If serie <> "" Then
                Try
                    Instrow = TPVDataSet.Tables("TPVs").Select("Serie = '" & serie & "'")
                    arg1 = Instrow(0)("Estado").ToString
                    estadorow = TPVDataSet.Tables("Estado").Select("Id_Estado = '" & arg1 & "'")
                    Me.TextBoxEstado.Text = estadorow(0)("Estado").ToString
                Catch ex As Exception
                    resultado = MessageBox.Show("El datáfono no existe en la base de datos, ¿Desea introducirlo?", "", MessageBoxButtons.YesNo)
                    If resultado = Windows.Forms.DialogResult.Yes Then
                        Main.numserie = Me.TextBoxSerie.Text
                        Me.TextBoxSerie3.Clear()
                        Me.TextBoxSerie3.Select()
                        Dim NewMDIChild As New Añadir_Datafono()
                        'Set the Parent Form of the Child window.
                        NewMDIChild.MdiParent = Main
                        'Display the new form.
                        NewMDIChild.Show()
                        Me.Close()

                    Else : Me.TextBoxSerie3.Clear()
                        Me.TextBoxSerie3.Select()
                    End If
                End Try
            End If
            Me.ComboBoxEstado.Focus()
        End If
    End Sub

    Private Sub ButtonBorrar4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBorrar4.Click
        Me.TextBoxSerie4.Clear()
        Me.TextBoxLocalizacion.Clear()
        Me.ComboBoxLocalizacion.SelectedIndex = -1
        Me.TextBoxSerie4.Select()
    End Sub

    Private Sub ButtonActLoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonActLoc.Click
        If Me.ComboBoxLocalizacion.Text <> "" Then
            Try
                Localizacionrow = TPVDataSet.Tables("Localizacion").Select("Localizacion = '" & Me.ComboBoxLocalizacion.Text & "'")
                'MessageBox.Show(Localizacionrow(0)("Localizacion").ToString)
                Instrow(0)("Id_Localizacion") = Localizacionrow(0)("Id_localizacion")
                Me.TPVsTableAdapter.Update(Me.TPVDataSet.TPVs)
                MessageBox.Show("Actualización correcta")
                Me.TextBoxSerie4.Text = ""
                Me.TextBoxLocalizacion.Text = ""
                Me.ComboBoxLocalizacion.SelectedIndex = -1
                Me.TextBoxSerie4.Select()
            Catch ex As Exception
                MessageBox.Show("Imposible realizar actualizacion")
            End Try
        Else : MessageBox.Show("Por favor, seleccione una nueva localizacion")
        End If
    End Sub

    Private Sub TextBoxSerie4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxSerie4.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Return)) Then
            e.Handled = True
            Dim serie As String = Me.TextBoxSerie4.Text
            Dim arg1 As String

            If serie <> "" Then
                Try
                    Instrow = TPVDataSet.Tables("TPVs").Select("Serie = '" & serie & "'")
                    arg1 = Instrow(0)("Id_Localizacion").ToString
                    Localizacionrow = TPVDataSet.Tables("Localizacion").Select("Id_Localizacion = '" & arg1 & "'")
                    Me.TextBoxLocalizacion.Text = Localizacionrow(0)("Localizacion").ToString
                Catch ex As Exception
                    resultado = MessageBox.Show("El datáfono no existe en la base de datos, ¿Desea introducirlo?", "", MessageBoxButtons.YesNo)
                    If resultado = Windows.Forms.DialogResult.Yes Then
                        Main.numserie = Me.TextBoxSerie4.Text
                        Me.TextBoxSerie4.Clear()
                        Me.TextBoxSerie4.Select()
                        Dim NewMDIChild As New Añadir_Datafono()
                        'Set the Parent Form of the Child window.
                        NewMDIChild.MdiParent = Main
                        'Display the new form.
                        NewMDIChild.Show()
                        Me.Close()

                    Else : Me.TextBoxSerie4.Clear()
                        Me.TextBoxSerie4.Select()
                    End If
                End Try
            End If
            Me.ComboBoxLocalizacion.Focus()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.GroupBoxEnvío.Enabled = True
        Me.GroupBoxLocalizacion.Enabled = True
        Me.GroupBoxInstalacion.Enabled = True
        Me.GroupBoxRepacion.Enabled = True

        Me.TextBoxSerie4.Clear()
        Me.TextBoxLocalizacion.Clear()
        Me.ComboBoxLocalizacion.SelectedIndex = -1

        Me.TextBoxSerie3.Clear()
        Me.TextBoxEstado.Clear()
        Me.TextBoxComentario.Clear()
        Me.ComboBoxEstado.SelectedIndex = -1

        Me.TextBoxSerie2.Clear()
        Me.CheckBoxInstalacion1.Checked = False
        Me.CheckBoxInstalacion2.Checked = False
        Me.TextBoxCliente2.Clear()
        Me.TextBoxCiudad2.Clear()
        Me.ComboBoxTecnico2.Text = ""
        Me.ComboBoxTecnico2.SelectedIndex = -1

        Me.TextBoxSerie1.Clear()
        Me.CheckBox1.Checked = False
        Me.CheckBox2.Checked = False
        Me.TextBoxCliente1.Clear()
        Me.TextBoxCiudad1.Clear()
        Me.ComboBoxTecnico1.Text = ""
        Me.ComboBoxTecnico1.SelectedIndex = -1

        Me.TextBoxSerie.Clear()
        Me.TextBoxSerie.Select()

    End Sub

    Private Sub ButtonCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub


End Class