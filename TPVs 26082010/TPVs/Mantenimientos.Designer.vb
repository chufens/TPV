<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mantenimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mantenimientos))
        Me.ButtonIntroEstado = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBoxEstado = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.TPVDataSet = New WindowsApplication1.TPVDataSet
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadoTableAdapter = New WindowsApplication1.TPVDataSetTableAdapters.EstadoTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ButtonIntroLocalizacion = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBoxLocalizacion = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ButtonIntroMarcas = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBoxMarca = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BotonBorrarModelo = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBoxModelo = New System.Windows.Forms.TextBox
        Me.ButtonIntroModelo = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.ComboBoxMarca = New System.Windows.Forms.ComboBox
        Me.GrouoBox5 = New System.Windows.Forms.GroupBox
        Me.BotonBorrarSubmodelo = New System.Windows.Forms.Button
        Me.ButtonIntroSubmodelo = New System.Windows.Forms.Button
        Me.ComboBoxModelo = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBoxSubModelo = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.ComboBoxMarca1 = New System.Windows.Forms.ComboBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBoxNombre = New System.Windows.Forms.TextBox
        Me.ButtonIntroTecnico = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBoxNumero = New System.Windows.Forms.TextBox
        Me.LocalizacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalizacionTableAdapter = New WindowsApplication1.TPVDataSetTableAdapters.LocalizacionTableAdapter
        Me.MarcasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarcasTableAdapter = New WindowsApplication1.TPVDataSetTableAdapters.MarcasTableAdapter
        Me.ModelosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModelosTableAdapter = New WindowsApplication1.TPVDataSetTableAdapters.ModelosTableAdapter
        Me.SubmodeloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubmodeloTableAdapter = New WindowsApplication1.TPVDataSetTableAdapters.SubmodeloTableAdapter
        Me.TécnicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TécnicosTableAdapter = New WindowsApplication1.TPVDataSetTableAdapters.TécnicosTableAdapter
        CType(Me.TPVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GrouoBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.LocalizacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubmodeloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TécnicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonIntroEstado
        '
        Me.ButtonIntroEstado.Image = CType(resources.GetObject("ButtonIntroEstado.Image"), System.Drawing.Image)
        Me.ButtonIntroEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonIntroEstado.Location = New System.Drawing.Point(584, 28)
        Me.ButtonIntroEstado.Name = "ButtonIntroEstado"
        Me.ButtonIntroEstado.Size = New System.Drawing.Size(120, 30)
        Me.ButtonIntroEstado.TabIndex = 37
        Me.ButtonIntroEstado.Text = "Introducir Datos"
        Me.ButtonIntroEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonIntroEstado.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(123, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Nuevo Estado"
        '
        'TextBoxEstado
        '
        Me.TextBoxEstado.Location = New System.Drawing.Point(242, 34)
        Me.TextBoxEstado.Name = "TextBoxEstado"
        Me.TextBoxEstado.Size = New System.Drawing.Size(212, 20)
        Me.TextBoxEstado.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(427, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mantenimiento de Bases de Datos"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(882, 119)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TPVDataSet
        '
        Me.TPVDataSet.DataSetName = "TPVDataSet"
        Me.TPVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstadoBindingSource
        '
        Me.EstadoBindingSource.DataMember = "Estado"
        Me.EstadoBindingSource.DataSource = Me.TPVDataSet
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxEstado)
        Me.GroupBox1.Controls.Add(Me.ButtonIntroEstado)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(820, 80)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BBDD Estado"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonIntroLocalizacion)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBoxLocalizacion)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 203)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(820, 80)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Localización"
        '
        'ButtonIntroLocalizacion
        '
        Me.ButtonIntroLocalizacion.Image = CType(resources.GetObject("ButtonIntroLocalizacion.Image"), System.Drawing.Image)
        Me.ButtonIntroLocalizacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonIntroLocalizacion.Location = New System.Drawing.Point(584, 29)
        Me.ButtonIntroLocalizacion.Name = "ButtonIntroLocalizacion"
        Me.ButtonIntroLocalizacion.Size = New System.Drawing.Size(120, 30)
        Me.ButtonIntroLocalizacion.TabIndex = 40
        Me.ButtonIntroLocalizacion.Text = "Introducir Datos"
        Me.ButtonIntroLocalizacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonIntroLocalizacion.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 20)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Nueva Localización"
        '
        'TextBoxLocalizacion
        '
        Me.TextBoxLocalizacion.Location = New System.Drawing.Point(242, 35)
        Me.TextBoxLocalizacion.Name = "TextBoxLocalizacion"
        Me.TextBoxLocalizacion.Size = New System.Drawing.Size(212, 20)
        Me.TextBoxLocalizacion.TabIndex = 38
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonIntroMarcas)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TextBoxMarca)
        Me.GroupBox3.Location = New System.Drawing.Point(28, 291)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(820, 80)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Marcas"
        '
        'ButtonIntroMarcas
        '
        Me.ButtonIntroMarcas.Image = CType(resources.GetObject("ButtonIntroMarcas.Image"), System.Drawing.Image)
        Me.ButtonIntroMarcas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonIntroMarcas.Location = New System.Drawing.Point(584, 25)
        Me.ButtonIntroMarcas.Name = "ButtonIntroMarcas"
        Me.ButtonIntroMarcas.Size = New System.Drawing.Size(120, 30)
        Me.ButtonIntroMarcas.TabIndex = 43
        Me.ButtonIntroMarcas.Text = "Introducir Datos"
        Me.ButtonIntroMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonIntroMarcas.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 20)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Nueva Marca"
        '
        'TextBoxMarca
        '
        Me.TextBoxMarca.Location = New System.Drawing.Point(242, 31)
        Me.TextBoxMarca.Name = "TextBoxMarca"
        Me.TextBoxMarca.Size = New System.Drawing.Size(212, 20)
        Me.TextBoxMarca.TabIndex = 41
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BotonBorrarModelo)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.TextBoxModelo)
        Me.GroupBox4.Controls.Add(Me.ButtonIntroModelo)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.ComboBoxMarca)
        Me.GroupBox4.Location = New System.Drawing.Point(28, 377)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(820, 100)
        Me.GroupBox4.TabIndex = 39
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Modelos"
        '
        'BotonBorrarModelo
        '
        Me.BotonBorrarModelo.Image = CType(resources.GetObject("BotonBorrarModelo.Image"), System.Drawing.Image)
        Me.BotonBorrarModelo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonBorrarModelo.Location = New System.Drawing.Point(594, 55)
        Me.BotonBorrarModelo.Name = "BotonBorrarModelo"
        Me.BotonBorrarModelo.Size = New System.Drawing.Size(110, 30)
        Me.BotonBorrarModelo.TabIndex = 46
        Me.BotonBorrarModelo.Text = "Borrar"
        Me.BotonBorrarModelo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(173, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Modelo"
        '
        'TextBoxModelo
        '
        Me.TextBoxModelo.Location = New System.Drawing.Point(242, 58)
        Me.TextBoxModelo.Name = "TextBoxModelo"
        Me.TextBoxModelo.Size = New System.Drawing.Size(212, 20)
        Me.TextBoxModelo.TabIndex = 44
        '
        'ButtonIntroModelo
        '
        Me.ButtonIntroModelo.Image = CType(resources.GetObject("ButtonIntroModelo.Image"), System.Drawing.Image)
        Me.ButtonIntroModelo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonIntroModelo.Location = New System.Drawing.Point(584, 19)
        Me.ButtonIntroModelo.Name = "ButtonIntroModelo"
        Me.ButtonIntroModelo.Size = New System.Drawing.Size(120, 30)
        Me.ButtonIntroModelo.TabIndex = 45
        Me.ButtonIntroModelo.Text = "Introducir Datos"
        Me.ButtonIntroModelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonIntroModelo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(180, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 20)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Marca"
        '
        'ComboBoxMarca
        '
        Me.ComboBoxMarca.FormattingEnabled = True
        Me.ComboBoxMarca.Location = New System.Drawing.Point(242, 18)
        Me.ComboBoxMarca.Name = "ComboBoxMarca"
        Me.ComboBoxMarca.Size = New System.Drawing.Size(212, 21)
        Me.ComboBoxMarca.TabIndex = 43
        '
        'GrouoBox5
        '
        Me.GrouoBox5.Controls.Add(Me.BotonBorrarSubmodelo)
        Me.GrouoBox5.Controls.Add(Me.ButtonIntroSubmodelo)
        Me.GrouoBox5.Controls.Add(Me.ComboBoxModelo)
        Me.GrouoBox5.Controls.Add(Me.Label7)
        Me.GrouoBox5.Controls.Add(Me.Label8)
        Me.GrouoBox5.Controls.Add(Me.TextBoxSubModelo)
        Me.GrouoBox5.Controls.Add(Me.Label9)
        Me.GrouoBox5.Controls.Add(Me.ComboBoxMarca1)
        Me.GrouoBox5.Location = New System.Drawing.Point(28, 483)
        Me.GrouoBox5.Name = "GrouoBox5"
        Me.GrouoBox5.Size = New System.Drawing.Size(820, 125)
        Me.GrouoBox5.TabIndex = 39
        Me.GrouoBox5.TabStop = False
        Me.GrouoBox5.Text = "Submodelos"
        '
        'BotonBorrarSubmodelo
        '
        Me.BotonBorrarSubmodelo.Image = CType(resources.GetObject("BotonBorrarSubmodelo.Image"), System.Drawing.Image)
        Me.BotonBorrarSubmodelo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonBorrarSubmodelo.Location = New System.Drawing.Point(594, 67)
        Me.BotonBorrarSubmodelo.Name = "BotonBorrarSubmodelo"
        Me.BotonBorrarSubmodelo.Size = New System.Drawing.Size(110, 30)
        Me.BotonBorrarSubmodelo.TabIndex = 59
        Me.BotonBorrarSubmodelo.Text = "Borrar"
        Me.BotonBorrarSubmodelo.UseVisualStyleBackColor = True
        '
        'ButtonIntroSubmodelo
        '
        Me.ButtonIntroSubmodelo.Image = CType(resources.GetObject("ButtonIntroSubmodelo.Image"), System.Drawing.Image)
        Me.ButtonIntroSubmodelo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonIntroSubmodelo.Location = New System.Drawing.Point(584, 31)
        Me.ButtonIntroSubmodelo.Name = "ButtonIntroSubmodelo"
        Me.ButtonIntroSubmodelo.Size = New System.Drawing.Size(120, 30)
        Me.ButtonIntroSubmodelo.TabIndex = 58
        Me.ButtonIntroSubmodelo.Text = "Introducir Datos"
        Me.ButtonIntroSubmodelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonIntroSubmodelo.UseVisualStyleBackColor = True
        '
        'ComboBoxModelo
        '
        Me.ComboBoxModelo.FormattingEnabled = True
        Me.ComboBoxModelo.Location = New System.Drawing.Point(242, 56)
        Me.ComboBoxModelo.Name = "ComboBoxModelo"
        Me.ComboBoxModelo.Size = New System.Drawing.Size(212, 21)
        Me.ComboBoxModelo.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(144, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 20)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "SubModelo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(173, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 20)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Modelo"
        '
        'TextBoxSubModelo
        '
        Me.TextBoxSubModelo.Location = New System.Drawing.Point(242, 94)
        Me.TextBoxSubModelo.Name = "TextBoxSubModelo"
        Me.TextBoxSubModelo.Size = New System.Drawing.Size(212, 20)
        Me.TextBoxSubModelo.TabIndex = 55
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(180, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 20)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Marca"
        '
        'ComboBoxMarca1
        '
        Me.ComboBoxMarca1.FormattingEnabled = True
        Me.ComboBoxMarca1.Location = New System.Drawing.Point(242, 19)
        Me.ComboBoxMarca1.Name = "ComboBoxMarca1"
        Me.ComboBoxMarca1.Size = New System.Drawing.Size(212, 21)
        Me.ComboBoxMarca1.TabIndex = 52
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.TextBoxNombre)
        Me.GroupBox6.Controls.Add(Me.ButtonIntroTecnico)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.TextBoxNumero)
        Me.GroupBox6.Location = New System.Drawing.Point(28, 614)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(820, 80)
        Me.GroupBox6.TabIndex = 39
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Técnicos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(104, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 20)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Nombre Técnico"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(242, 18)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(212, 20)
        Me.TextBoxNombre.TabIndex = 47
        '
        'ButtonIntroTecnico
        '
        Me.ButtonIntroTecnico.Image = CType(resources.GetObject("ButtonIntroTecnico.Image"), System.Drawing.Image)
        Me.ButtonIntroTecnico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonIntroTecnico.Location = New System.Drawing.Point(584, 19)
        Me.ButtonIntroTecnico.Name = "ButtonIntroTecnico"
        Me.ButtonIntroTecnico.Size = New System.Drawing.Size(120, 30)
        Me.ButtonIntroTecnico.TabIndex = 49
        Me.ButtonIntroTecnico.Text = "Introducir Datos"
        Me.ButtonIntroTecnico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonIntroTecnico.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(104, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 20)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Número Técnico"
        '
        'TextBoxNumero
        '
        Me.TextBoxNumero.Location = New System.Drawing.Point(242, 52)
        Me.TextBoxNumero.Name = "TextBoxNumero"
        Me.TextBoxNumero.Size = New System.Drawing.Size(212, 20)
        Me.TextBoxNumero.TabIndex = 48
        '
        'LocalizacionBindingSource
        '
        Me.LocalizacionBindingSource.DataMember = "Localizacion"
        Me.LocalizacionBindingSource.DataSource = Me.TPVDataSet
        '
        'LocalizacionTableAdapter
        '
        Me.LocalizacionTableAdapter.ClearBeforeFill = True
        '
        'MarcasBindingSource
        '
        Me.MarcasBindingSource.DataMember = "Marcas"
        Me.MarcasBindingSource.DataSource = Me.TPVDataSet
        '
        'MarcasTableAdapter
        '
        Me.MarcasTableAdapter.ClearBeforeFill = True
        '
        'ModelosBindingSource
        '
        Me.ModelosBindingSource.DataMember = "Modelos"
        Me.ModelosBindingSource.DataSource = Me.TPVDataSet
        '
        'ModelosTableAdapter
        '
        Me.ModelosTableAdapter.ClearBeforeFill = True
        '
        'SubmodeloBindingSource
        '
        Me.SubmodeloBindingSource.DataMember = "Submodelo"
        Me.SubmodeloBindingSource.DataSource = Me.TPVDataSet
        '
        'SubmodeloTableAdapter
        '
        Me.SubmodeloTableAdapter.ClearBeforeFill = True
        '
        'TécnicosBindingSource
        '
        Me.TécnicosBindingSource.DataMember = "Técnicos"
        Me.TécnicosBindingSource.DataSource = Me.TPVDataSet
        '
        'TécnicosTableAdapter
        '
        Me.TécnicosTableAdapter.ClearBeforeFill = True
        '
        'Mantenimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1193, 767)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GrouoBox5)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Mantenimientos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TPVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GrouoBox5.ResumeLayout(False)
        Me.GrouoBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.LocalizacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubmodeloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TécnicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ButtonIntroEstado As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxEstado As System.Windows.Forms.TextBox
    Friend WithEvents TPVDataSet As WindowsApplication1.TPVDataSet
    Friend WithEvents EstadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadoTableAdapter As WindowsApplication1.TPVDataSetTableAdapters.EstadoTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GrouoBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonIntroLocalizacion As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxLocalizacion As System.Windows.Forms.TextBox
    Friend WithEvents LocalizacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocalizacionTableAdapter As WindowsApplication1.TPVDataSetTableAdapters.LocalizacionTableAdapter
    Friend WithEvents ButtonIntroMarcas As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxMarca As System.Windows.Forms.TextBox
    Friend WithEvents MarcasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MarcasTableAdapter As WindowsApplication1.TPVDataSetTableAdapters.MarcasTableAdapter
    Friend WithEvents BotonBorrarModelo As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxModelo As System.Windows.Forms.TextBox
    Friend WithEvents ButtonIntroModelo As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxMarca As System.Windows.Forms.ComboBox
    Friend WithEvents ModelosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModelosTableAdapter As WindowsApplication1.TPVDataSetTableAdapters.ModelosTableAdapter
    Friend WithEvents SubmodeloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubmodeloTableAdapter As WindowsApplication1.TPVDataSetTableAdapters.SubmodeloTableAdapter
    Friend WithEvents TécnicosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TécnicosTableAdapter As WindowsApplication1.TPVDataSetTableAdapters.TécnicosTableAdapter
    Friend WithEvents BotonBorrarSubmodelo As System.Windows.Forms.Button
    Friend WithEvents ButtonIntroSubmodelo As System.Windows.Forms.Button
    Friend WithEvents ComboBoxModelo As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSubModelo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxMarca1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents ButtonIntroTecnico As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNumero As System.Windows.Forms.TextBox
End Class
