Public Class Añadir_Datafono
    Dim serie As String
    Dim marca As String
    Dim modelo As String
    Dim dimsubmodelo As String
    Dim dimestado As String
    Dim dimlocalizacion As String
    Dim comentario As String
    Dim instalado As Boolean = False
    Dim v8210 As String = "8210ES"
    Dim v8010 As String = "8010ES"
    Dim v8020 As String = "8020ES"
    Dim datosok As Boolean = False

    Dim locrow() As TPVDataSet.LocalizacionRow
    Dim estrow() As TPVDataSet.EstadoRow
    Dim marcarow() As TPVDataSet.MarcasRow
    Dim modelorow() As TPVDataSet.ModelosRow
    Dim submodelorow() As TPVDataSet.SubmodeloRow

    Private Sub Añadir_Datafono_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TPVDataSet.Estado' table. You can move, or remove it, as needed.
        Me.EstadoTableAdapter.Fill(Me.TPVDataSet.Estado)
        'TODO: This line of code loads data into the 'TPVDataSet.Localizacion' table. You can move, or remove it, as needed.
        Me.LocalizacionTableAdapter.Fill(Me.TPVDataSet.Localizacion)
        If Main.numserie <> "" Then
            Me.TextBoxSerie.Text = Main.numserie
            Main.numserie = ""
        End If
        Me.TextBoxSerie.Select()
    End Sub

    Private Sub TextBoxSerie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxSerie.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Return)) Then
            e.Handled = True
            'Comprobamos si el datafono ya existe en la base de datos
            If Me.TextBoxSerie.Text <> "" Then

                Dim a As Integer = Me.TPVsTableAdapter.Existe(Me.TextBoxSerie.Text)

                If a = 1 Then 'El datafono existe en la base de datos
                    MessageBox.Show("El datáfono ya existe en la base de datos. Por favor introduzca otro número de serie")

                    Me.TextBoxSerie.Clear()
                    Me.TextBoxSerie.Select()

                Else 'No existe el datafono y vamos a añadirlo

                    'Asignar valores a las variables
                    Me.serie = Me.TextBoxSerie.Text

                    If serie.Contains(v8210) Then
                        Me.TextBoxMarca.Text = "Verifone"
                        Me.ComboBoxModelo.Text = "Nurit 8210"
                        Me.ComboBoxSubmodelo.Text = "8210S"
                    ElseIf serie.Contains(v8010) Then
                        Me.TextBoxMarca.Text = "Verifone"
                        With Me.ComboBoxModelo
                            .DataSource = Me.ModelosTableAdapter.GetDataBy8010
                            .DisplayMember = "Nobre_Modelo"
                        End With
                        Me.ComboBoxSubmodelo.Text = "8010S"
                    ElseIf serie.Contains(v8020) Then
                        Me.TextBoxMarca.Text = "Verifone"
                        Me.ComboBoxModelo.Text = "Nurit 8020 - GPRS"
                        Me.ComboBoxSubmodelo.Text = "8020S"
                    ElseIf Me.TextBoxSerie.Text.Length = 11 Then
                        Me.TextBoxMarca.Text = "Ingenico"
                        Me.ComboBoxModelo.Text = "Banjo"
                        Me.ComboBoxSubmodelo.Text = "BANJB17E-ROJ"
                    ElseIf Me.TextBoxSerie.Text.Length = 10 Then
                        Me.TextBoxMarca.Text = "Ingenico"
                        With Me.ComboBoxModelo
                            .DataSource = Me.ModelosTableAdapter.GetDataByMarca(1)
                            .DisplayMember = "Nobre_Modelo"
                        End With
                        ' With Me.ComboBoxSubmodelo
                        '.DataSource = Me.SubmodeloTableAdapter.GetDataByModelo(1, 2)
                        '.DisplayMember = "Submodelo"
                        'End With
                    Else : MessageBox.Show("El Número de serie no se corresponde con ningún modelo de la base de datos, Por favor, vuelva a introducirlo")
                    End If
                End If

            End If
        End If
    End Sub

    Private Sub ComboBoxModelo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxModelo.SelectedIndexChanged
        If Me.ComboBoxModelo.Text = "5100 RTC" Then
            With Me.ComboBoxSubmodelo
                .DataSource = Me.SubmodeloTableAdapter.GetDataByModelo(1)
                .DisplayMember = "Submodelo"
            End With
        ElseIf Me.ComboBoxModelo.Text = "5100 ADSL" Then
            With Me.ComboBoxSubmodelo
                .DataSource = Me.SubmodeloTableAdapter.GetDataByModelo(2)
                .DisplayMember = "Submodelo"
            End With
        End If
    End Sub

    Private Sub TextBoxSerie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSerie.TextChanged
        If Me.TextBoxSerie.Text <> "" Then
            Me.TextBoxMarca.Clear()
            Me.ComboBoxModelo.Text = ""
            Me.ComboBoxModelo.DataSource = Nothing
            Me.ComboBoxSubmodelo.DataSource = Nothing
            Me.ComboBoxSubmodelo.Text = ""
            Me.ComboBoxEstado.SelectedIndex = 0
            Me.ComboBoxLocalizacion.SelectedIndex = 0
            Me.TextBoxComentario.Clear()
            Me.Button1.Enabled = False
            Me.Label9.Visible = False
            Me.Label10.Visible = False
            Me.Label11.Visible = False
            Me.Label12.Visible = False
            Me.Label13.Visible = False
            Me.Label14.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim arg1 As Integer
        Dim arg2 As String
        Dim arg3 As String
        Dim arg4 As String
        Dim arg5 As String
        Dim arg6 As Boolean = False
        ' Todo OK?
        If Not datosok Then
            MessageBox.Show("Por favor, valide los datos antes")
        Else
            Select Case Me.TextBoxMarca.Text
                Case "Ingenico"
                    Select Case Me.ComboBoxModelo.Text
                        Case "5100 RTC"
                            Select Case Me.ComboBoxSubmodelo.Text
                                Case "DESCONOCIDO"
                                    arg1 = 1
                                Case "I5100PMU001A"
                                    arg1 = 5
                                Case "I5100MMT010A"
                                    arg1 = 6
                                Case "I5100MMD005A"
                                    arg1 = 7
                                Case "I5100MMD005C"
                                    arg1 = 9
                            End Select
                        Case "5100 ADSL"
                            Select Case Me.ComboBoxSubmodelo.Text
                                Case "DESCONOCIDO"
                                    arg1 = 2
                                Case "I5100MMD005A"
                                    arg1 = 8
                                Case "I5100PMU001A"
                                    arg1 = 11
                            End Select
                        Case "Banjo"
                            arg1 = 13
                    End Select
                Case "Verifone"
                    Select Case Me.ComboBoxModelo.Text
                        Case "Nurit 8210"
                            arg1 = 12
                        Case "Nurit 8010 - Wifi"
                            arg1 = 15
                    End Select
            End Select

            'MessageBox.Show(arg1)

            locrow = TPVDataSet.Tables("Localizacion").Select("Localizacion = '" & Me.ComboBoxLocalizacion.Text & "'")
            arg2 = locrow(0)("Id_Localizacion").ToString

            'MessageBox.Show(arg2)

            arg3 = Me.TextBoxSerie.Text

            'MessageBox.Show(arg3)

            estrow = TPVDataSet.Tables("Estado").Select("Estado = '" & Me.ComboBoxEstado.Text & "'")
            arg4 = estrow(0)("Id_Estado").ToString

            'MessageBox.Show(arg4)

            arg5 = Me.TextBoxComentario.Text

            'MessageBox.Show(arg5)

            Try
                Me.Validate()
                Me.TPVsBindingSource.EndEdit()
                Me.TPVsTableAdapter.Insert(arg1, Val(arg2), arg3, Val(arg4), arg5, arg6)
                Dim result As DialogResult
                result = MessageBox.Show("Los datos se han introducido correctamente. ¿Desea introducir más datafonos?", "Datos", MessageBoxButtons.YesNo)
                If result = Windows.Forms.DialogResult.Yes Then
                    Me.TextBoxSerie.Clear()
                    Me.TextBoxMarca.Clear()
                    Me.ComboBoxModelo.Text = ""
                    Me.ComboBoxModelo.DataSource = Nothing
                    Me.ComboBoxSubmodelo.DataSource = Nothing
                    Me.ComboBoxSubmodelo.Text = ""
                    Me.ComboBoxEstado.SelectedIndex = 0
                    Me.ComboBoxLocalizacion.SelectedIndex = 0
                    Me.TextBoxComentario.Clear()
                Else : Me.Close()
                End If

                Me.Button1.Enabled = False
            Catch ex As Exception
                MessageBox.Show("Error al introducir datos")
            End Try
        End If
        Me.TextBoxSerie.Select()
        Me.Label9.Visible = False
        Me.Label10.Visible = False
        Me.Label11.Visible = False
        Me.Label12.Visible = False
        Me.Label13.Visible = False
        Me.Label14.Visible = False
    End Sub

    Private Sub ButtonComprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonComprobar.Click

        Me.serie = Me.TextBoxSerie.Text
        Me.marca = Me.TextBoxMarca.Text
        Me.modelo = Me.ComboBoxModelo.Text
        Me.dimsubmodelo = Me.ComboBoxSubmodelo.Text
        Me.dimestado = Me.ComboBoxEstado.Text
        Me.dimlocalizacion = Me.ComboBoxLocalizacion.Text
        Me.comentario = Me.TextBoxComentario.Text

        Me.Label9.Visible = False
        Me.Label10.Visible = False
        Me.Label11.Visible = False
        Me.Label12.Visible = False
        Me.Label13.Visible = False
        Me.Label14.Visible = False

        If serie = "" Or marca = "" Or modelo = "" Or dimsubmodelo = "" Or dimestado = "" Or dimlocalizacion = "" Then
            If serie = "" Then
                Label9.Visible = True
            End If
            If marca = "" Then
                Label10.Visible = True
            End If
            If modelo = "" Then
                Label11.Visible = True
            End If
            If dimsubmodelo = "" Then
                Label12.Visible = True
            End If
            If dimestado = "" Then
                Label13.Visible = True
            End If
            If dimlocalizacion = "" Then
                Label14.Visible = True
            End If
            MessageBox.Show("Por favor compruebe los campos marcados con asteriscos")
            Me.datosok = False
        Else
            'MessageBox.Show("Todo OK")
            Me.datosok = True
            Me.Button1.Enabled = True
        End If

    End Sub

    Private Sub BotonBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonBorrar.Click
        Me.TextBoxSerie.Clear()
        Me.TextBoxMarca.Clear()
        Me.ComboBoxModelo.Text = ""
        Me.ComboBoxModelo.DataSource = Nothing
        Me.ComboBoxSubmodelo.DataSource = Nothing
        Me.ComboBoxSubmodelo.Text = ""
        Me.ComboBoxEstado.SelectedIndex = 0
        Me.ComboBoxLocalizacion.SelectedIndex = 0
        Me.TextBoxComentario.Clear()
        Me.Button1.Enabled = False
        Me.Label9.Visible = False
        Me.Label10.Visible = False
        Me.Label11.Visible = False
        Me.Label12.Visible = False
        Me.Label13.Visible = False
        Me.Label14.Visible = False
        Me.TextBoxSerie.Select()
    End Sub

    Private Sub ButtonCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub

  
End Class