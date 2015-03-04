<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Añadir_Datafono
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Añadir_Datafono))
        Me.TextBoxSerie = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBoxMarca = New System.Windows.Forms.TextBox
        Me.ComboBoxEstado = New System.Windows.Forms.ComboBox
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPVDataSet = New WindowsApplication1.TPVDataSet
        Me.ComboBoxLocalizacion = New System.Windows.Forms.ComboBox
        Me.LocalizacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBoxComentario = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.ComboBoxSubmodelo = New System.Windows.Forms.ComboBox
        Me.ComboBoxModelo = New System.Windows.Forms.ComboBox
        Me.ModelosSubmodeloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModelosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonComprobar = New System.Windows.Forms.Button
        Me.ButtonCerrar = New System.Windows.Forms.Button
        Me.ModelosTableAdapter = New WindowsApplication1.TPVDataSetTableAdapters.ModelosTableAdapter
        Me.SubmodeloTableAdapter = New WindowsApplication1.TPVDataSetTableAdapters.SubmodeloTableAdapter
        Me.SubmodeloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPVsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPVsTableAdapter = New WindowsApplication1.TPVDataSetTableAdapters.TPVsTableAdapter
        Me.LocalizacionTableAdapter = New WindowsApplication1.TPVDataSetTableAdapters.LocalizacionTableAdapter
        Me.EstadoTableAdapter = New WindowsApplication1.TPVDataSetTableAdapters.EstadoTableAdapter
        Me.BotonBorrar = New System.Windows.Forms.Button
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalizacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelosSubmodeloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubmodeloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPVsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxSerie
        '
        Me.TextBoxSerie.Location = New System.Drawing.Point(138, 109)
        Me.TextBoxSerie.Name = "TextBoxSerie"
        Me.TextBoxSerie.Size = New System.Drawing.Size(247, 20)
        Me.TextBoxSerie.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Serie"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Marca"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Modelo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Submodelo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(72, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Estado"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Localización"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 336)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Comentario"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxMarca
        '
        Me.TextBoxMarca.Location = New System.Drawing.Point(138, 148)
        Me.TextBoxMarca.Name = "TextBoxMarca"
        Me.TextBoxMarca.Size = New System.Drawing.Size(247, 20)
        Me.TextBoxMarca.TabIndex = 8
        '
        'ComboBoxEstado
        '
        Me.ComboBoxEstado.DataSource = Me.EstadoBindingSource
        Me.ComboBoxEstado.DisplayMember = "Estado"
        Me.ComboBoxEstado.FormattingEnabled = True
        Me.ComboBoxEstado.Location = New System.Drawing.Point(138, 261)
        Me.ComboBoxEstado.Name = "ComboBoxEstado"
        Me.ComboBoxEstado.Size = New System.Drawing.Size(247, 21)
        Me.ComboBoxEstado.TabIndex = 11
        Me.ComboBoxEstado.ValueMember = "Estado"
        '
        'EstadoBindingSource
        '
        Me.EstadoBindingSource.DataMember = "Estado"
        Me.EstadoBindingSource.DataSource = Me.TPVDataSet
        '
        'TPVDataSet
        '
        Me.TPVDataSet.DataSetName = "TPVDataSet"
        Me.TPVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBoxLocalizacion
        '
        Me.ComboBoxLocalizacion.DataSource = Me.LocalizacionBindingSource
        Me.ComboBoxLocalizacion.DisplayMember = "Localizacion"
        Me.ComboBoxLocalizacion.FormattingEnabled = True
        Me.ComboBoxLocalizacion.Location = New System.Drawing.Point(138, 298)
        Me.ComboBoxLocalizacion.Name = "ComboBoxLocalizacion"
        Me.ComboBoxLocalizacion.Size = New System.Drawing.Size(247, 21)
        Me.ComboBoxLocalizacion.TabIndex = 12
        Me.ComboBoxLocalizacion.ValueMember = "Localizacion"
        '
        'LocalizacionBindingSource
        '
        Me.LocalizacionBindingSource.DataMember = "Localizacion"
        Me.LocalizacionBindingSource.DataSource = Me.TPVDataSet
        '
        'TextBoxComentario
        '
        Me.TextBoxComentario.Location = New System.Drawing.Point(138, 338)
        Me.TextBoxComentario.Name = "TextBoxComentario"
        Me.TextBoxComentario.Size = New System.Drawing.Size(411, 20)
        Me.TextBoxComentario.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(290, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(450, 31)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Introducción de datos de Datáfonos "
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(826, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 30)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Introducir Datos"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(391, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "*"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(391, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 20)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "*"
        Me.Label10.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(391, 185)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 20)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "*"
        Me.Label11.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(391, 219)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 20)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "*"
        Me.Label12.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(391, 259)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 20)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "*"
        Me.Label13.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(391, 296)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 20)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "*"
        Me.Label14.Visible = False
        '
        'ComboBoxSubmodelo
        '
        Me.ComboBoxSubmodelo.FormattingEnabled = True
        Me.ComboBoxSubmodelo.Location = New System.Drawing.Point(139, 221)
        Me.ComboBoxSubmodelo.Name = "ComboBoxSubmodelo"
        Me.ComboBoxSubmodelo.Size = New System.Drawing.Size(246, 21)
        Me.ComboBoxSubmodelo.TabIndex = 10
        '
        'ComboBoxModelo
        '
        Me.ComboBoxModelo.FormattingEnabled = True
        Me.ComboBoxModelo.Location = New System.Drawing.Point(138, 184)
        Me.ComboBoxModelo.Name = "ComboBoxModelo"
        Me.ComboBoxModelo.Size = New System.Drawing.Size(246, 21)
        Me.ComboBoxModelo.TabIndex = 9
        '
        'ModelosSubmodeloBindingSource
        '
        Me.ModelosSubmodeloBindingSource.DataMember = "ModelosSubmodelo"
        Me.ModelosSubmodeloBindingSource.DataSource = Me.ModelosBindingSource
        '
        'ModelosBindingSource
        '
        Me.ModelosBindingSource.DataMember = "Modelos"
        Me.ModelosBindingSource.DataSource = Me.TPVDataSet
        '
        'ButtonComprobar
        '
        Me.ButtonComprobar.Location = New System.Drawing.Point(688, 132)
        Me.ButtonComprobar.Name = "ButtonComprobar"
        Me.ButtonComprobar.Size = New System.Drawing.Size(110, 30)
        Me.ButtonComprobar.TabIndex = 26
        Me.ButtonComprobar.Text = "Validar"
        Me.ButtonComprobar.UseVisualStyleBackColor = True
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.Image = CType(resources.GetObject("ButtonCerrar.Image"), System.Drawing.Image)
        Me.ButtonCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCerrar.Location = New System.Drawing.Point(838, 329)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(110, 37)
        Me.ButtonCerrar.TabIndex = 27
        Me.ButtonCerrar.Text = "Cerrar"
        Me.ButtonCerrar.UseVisualStyleBackColor = True
        '
        'ModelosTableAdapter
        '
        Me.ModelosTableAdapter.ClearBeforeFill = True
        '
        'SubmodeloTableAdapter
        '
        Me.SubmodeloTableAdapter.ClearBeforeFill = True
        '
        'SubmodeloBindingSource
        '
        Me.SubmodeloBindingSource.DataMember = "Submodelo"
        Me.SubmodeloBindingSource.DataSource = Me.TPVDataSet
        '
        'TPVsBindingSource
        '
        Me.TPVsBindingSource.DataMember = "TPVs"
        Me.TPVsBindingSource.DataSource = Me.TPVDataSet
        '
        'TPVsTableAdapter
        '
        Me.TPVsTableAdapter.ClearBeforeFill = True
        '
        'LocalizacionTableAdapter
        '
        Me.LocalizacionTableAdapter.ClearBeforeFill = True
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'BotonBorrar
        '
        Me.BotonBorrar.Image = CType(resources.GetObject("BotonBorrar.Image"), System.Drawing.Image)
        Me.BotonBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonBorrar.Location = New System.Drawing.Point(688, 185)
        Me.BotonBorrar.Name = "BotonBorrar"
        Me.BotonBorrar.Size = New System.Drawing.Size(110, 30)
        Me.BotonBorrar.TabIndex = 40
        Me.BotonBorrar.Text = "Borrar"
        Me.BotonBorrar.UseVisualStyleBackColor = True
        '
        'Añadir_Datafono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 393)
        Me.ControlBox = False
        Me.Controls.Add(Me.BotonBorrar)
        Me.Controls.Add(Me.ButtonCerrar)
        Me.Controls.Add(Me.ButtonComprobar)
        Me.Controls.Add(Me.ComboBoxModelo)
        Me.Controls.Add(Me.ComboBoxSubmodelo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxComentario)
        Me.Controls.Add(Me.ComboBoxLocalizacion)
        Me.Controls.Add(Me.ComboBoxEstado)
        Me.Controls.Add(Me.TextBoxMarca)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxSerie)
        Me.Name = "Añadir_Datafono"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalizacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelosSubmodeloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubmodeloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPVsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxMarca As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxEstado As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxLocalizacion As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxComentario As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TPVDataSet As WindowsApplication1.TPVDataSet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxSubmodelo As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxModelo As System.Windows.Forms.ComboBox
    Friend WithEvents ModelosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModelosTableAdapter As WindowsApplication1.TPVDataSetTableAdapters.ModelosTableAdapter
    Friend WithEvents ModelosSubmodeloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubmodeloTableAdapter As WindowsApplication1.TPVDataSetTableAdapters.SubmodeloTableAdapter
    Friend WithEvents ButtonComprobar As System.Windows.Forms.Button
    Friend WithEvents SubmodeloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TPVsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TPVsTableAdapter As WindowsApplication1.TPVDataSetTableAdapters.TPVsTableAdapter
    Friend WithEvents ButtonCerrar As System.Windows.Forms.Button
    Friend WithEvents LocalizacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocalizacionTableAdapter As WindowsApplication1.TPVDataSetTableAdapters.LocalizacionTableAdapter
    Friend WithEvents EstadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadoTableAdapter As WindowsApplication1.TPVDataSetTableAdapters.EstadoTableAdapter
    Friend WithEvents BotonBorrar As System.Windows.Forms.Button
End Class
