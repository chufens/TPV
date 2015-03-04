<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Datafonos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Datafonos))
        Me.Cerrar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBoxCaja = New System.Windows.Forms.ComboBox
        Me.LocalizacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPVDataSet = New WindowsApplication1.TPVDataSet
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ComboBoxMarca = New System.Windows.Forms.ComboBox
        Me.MarcasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxModelo = New System.Windows.Forms.ComboBox
        Me.ModelosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label
        Me.ComboBoxEstado = New System.Windows.Forms.ComboBox
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.LocalizacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MarcaTPVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NobreModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubmodeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SerieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ComentarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LocalizacionConsultaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuscarDatafonos = New System.Windows.Forms.Button
        Me.BotonBorrar = New System.Windows.Forms.Button
        Me.ButtonExcell = New System.Windows.Forms.Button
        Me.TPVsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPVsTableAdapter = New WindowsApplication1.TPVDataSetTableAdapters.TPVsTableAdapter
        Me.LocalizacionTableAdapter = New WindowsApplication1.TPVDataSetTableAdapters.LocalizacionTableAdapter
        Me.MarcasTableAdapter = New WindowsApplication1.TPVDataSetTableAdapters.MarcasTableAdapter
        Me.ModelosTableAdapter = New WindowsApplication1.TPVDataSetTableAdapters.ModelosTableAdapter
        Me.EstadoTableAdapter = New WindowsApplication1.TPVDataSetTableAdapters.EstadoTableAdapter
        Me.Localizacion_ConsultaTableAdapter = New WindowsApplication1.TPVDataSetTableAdapters.Localizacion_ConsultaTableAdapter
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.FillBy1ToolStrip = New System.Windows.Forms.ToolStrip
        Me.FillBy1ToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TextBoxSerie = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        CType(Me.LocalizacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalizacionConsultaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPVsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.FillBy1ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cerrar
        '
        Me.Cerrar.Image = CType(resources.GetObject("Cerrar.Image"), System.Drawing.Image)
        Me.Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cerrar.Location = New System.Drawing.Point(865, 661)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(110, 37)
        Me.Cerrar.TabIndex = 21
        Me.Cerrar.Text = "Cerrar"
        Me.Cerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(315, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(428, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Listado de Datáfonos en la Oficina"
        '
        'ComboBoxCaja
        '
        Me.ComboBoxCaja.DataSource = Me.LocalizacionBindingSource
        Me.ComboBoxCaja.DisplayMember = "Localizacion"
        Me.ComboBoxCaja.FormattingEnabled = True
        Me.ComboBoxCaja.Location = New System.Drawing.Point(641, 131)
        Me.ComboBoxCaja.Name = "ComboBoxCaja"
        Me.ComboBoxCaja.Size = New System.Drawing.Size(286, 21)
        Me.ComboBoxCaja.TabIndex = 8
        '
        'LocalizacionBindingSource
        '
        Me.LocalizacionBindingSource.DataMember = "Localizacion"
        Me.LocalizacionBindingSource.DataSource = Me.TPVDataSet
        '
        'TPVDataSet
        '
        Me.TPVDataSet.DataSetName = "TPVDataSet"
        Me.TPVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(537, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Localización"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Marca"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(78, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Modelo"
        '
        'ComboBoxMarca
        '
        Me.ComboBoxMarca.DataSource = Me.MarcasBindingSource
        Me.ComboBoxMarca.DisplayMember = "Marca_TPV"
        Me.ComboBoxMarca.FormattingEnabled = True
        Me.ComboBoxMarca.Location = New System.Drawing.Point(145, 166)
        Me.ComboBoxMarca.Name = "ComboBoxMarca"
        Me.ComboBoxMarca.Size = New System.Drawing.Size(286, 21)
        Me.ComboBoxMarca.TabIndex = 6
        '
        'MarcasBindingSource
        '
        Me.MarcasBindingSource.DataMember = "Marcas"
        Me.MarcasBindingSource.DataSource = Me.TPVDataSet
        '
        'ComboBoxModelo
        '
        Me.ComboBoxModelo.DataSource = Me.ModelosBindingSource
        Me.ComboBoxModelo.DisplayMember = "Nobre_Modelo"
        Me.ComboBoxModelo.FormattingEnabled = True
        Me.ComboBoxModelo.Location = New System.Drawing.Point(145, 205)
        Me.ComboBoxModelo.Name = "ComboBoxModelo"
        Me.ComboBoxModelo.Size = New System.Drawing.Size(286, 21)
        Me.ComboBoxModelo.TabIndex = 7
        '
        'ModelosBindingSource
        '
        Me.ModelosBindingSource.DataMember = "Modelos"
        Me.ModelosBindingSource.DataSource = Me.TPVDataSet
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(573, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Estado"
        '
        'ComboBoxEstado
        '
        Me.ComboBoxEstado.DataSource = Me.EstadoBindingSource
        Me.ComboBoxEstado.DisplayMember = "Estado"
        Me.ComboBoxEstado.FormattingEnabled = True
        Me.ComboBoxEstado.Location = New System.Drawing.Point(641, 166)
        Me.ComboBoxEstado.Name = "ComboBoxEstado"
        Me.ComboBoxEstado.Size = New System.Drawing.Size(286, 21)
        Me.ComboBoxEstado.TabIndex = 13
        Me.ComboBoxEstado.ValueMember = "Estado"
        '
        'EstadoBindingSource
        '
        Me.EstadoBindingSource.DataMember = "Estado"
        Me.EstadoBindingSource.DataSource = Me.TPVDataSet
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LocalizacionDataGridViewTextBoxColumn, Me.MarcaTPVDataGridViewTextBoxColumn, Me.NobreModeloDataGridViewTextBoxColumn, Me.SubmodeloDataGridViewTextBoxColumn, Me.SerieDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.ComentarioDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LocalizacionConsultaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(45, 336)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(930, 243)
        Me.DataGridView1.TabIndex = 18
        '
        'LocalizacionDataGridViewTextBoxColumn
        '
        Me.LocalizacionDataGridViewTextBoxColumn.DataPropertyName = "Localizacion"
        Me.LocalizacionDataGridViewTextBoxColumn.HeaderText = "Localizacion"
        Me.LocalizacionDataGridViewTextBoxColumn.Name = "LocalizacionDataGridViewTextBoxColumn"
        Me.LocalizacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MarcaTPVDataGridViewTextBoxColumn
        '
        Me.MarcaTPVDataGridViewTextBoxColumn.DataPropertyName = "Marca_TPV"
        Me.MarcaTPVDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcaTPVDataGridViewTextBoxColumn.Name = "MarcaTPVDataGridViewTextBoxColumn"
        Me.MarcaTPVDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NobreModeloDataGridViewTextBoxColumn
        '
        Me.NobreModeloDataGridViewTextBoxColumn.DataPropertyName = "Nobre_Modelo"
        Me.NobreModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.NobreModeloDataGridViewTextBoxColumn.Name = "NobreModeloDataGridViewTextBoxColumn"
        Me.NobreModeloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubmodeloDataGridViewTextBoxColumn
        '
        Me.SubmodeloDataGridViewTextBoxColumn.DataPropertyName = "Submodelo"
        Me.SubmodeloDataGridViewTextBoxColumn.HeaderText = "Submodelo"
        Me.SubmodeloDataGridViewTextBoxColumn.Name = "SubmodeloDataGridViewTextBoxColumn"
        Me.SubmodeloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SerieDataGridViewTextBoxColumn
        '
        Me.SerieDataGridViewTextBoxColumn.DataPropertyName = "Serie"
        Me.SerieDataGridViewTextBoxColumn.HeaderText = "Serie"
        Me.SerieDataGridViewTextBoxColumn.Name = "SerieDataGridViewTextBoxColumn"
        Me.SerieDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ComentarioDataGridViewTextBoxColumn
        '
        Me.ComentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario"
        Me.ComentarioDataGridViewTextBoxColumn.HeaderText = "Comentario"
        Me.ComentarioDataGridViewTextBoxColumn.Name = "ComentarioDataGridViewTextBoxColumn"
        Me.ComentarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LocalizacionConsultaBindingSource
        '
        Me.LocalizacionConsultaBindingSource.DataMember = "Localizacion Consulta"
        Me.LocalizacionConsultaBindingSource.DataSource = Me.TPVDataSet
        '
        'BuscarDatafonos
        '
        Me.BuscarDatafonos.Image = CType(resources.GetObject("BuscarDatafonos.Image"), System.Drawing.Image)
        Me.BuscarDatafonos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarDatafonos.Location = New System.Drawing.Point(821, 206)
        Me.BuscarDatafonos.Name = "BuscarDatafonos"
        Me.BuscarDatafonos.Size = New System.Drawing.Size(110, 30)
        Me.BuscarDatafonos.TabIndex = 16
        Me.BuscarDatafonos.Text = "Buscar"
        Me.BuscarDatafonos.UseVisualStyleBackColor = True
        '
        'BotonBorrar
        '
        Me.BotonBorrar.Image = CType(resources.GetObject("BotonBorrar.Image"), System.Drawing.Image)
        Me.BotonBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonBorrar.Location = New System.Drawing.Point(145, 251)
        Me.BotonBorrar.Name = "BotonBorrar"
        Me.BotonBorrar.Size = New System.Drawing.Size(106, 30)
        Me.BotonBorrar.TabIndex = 15
        Me.BotonBorrar.Text = "Borrar"
        Me.BotonBorrar.UseVisualStyleBackColor = True
        '
        'ButtonExcell
        '
        Me.ButtonExcell.Enabled = False
        Me.ButtonExcell.Image = CType(resources.GetObject("ButtonExcell.Image"), System.Drawing.Image)
        Me.ButtonExcell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonExcell.Location = New System.Drawing.Point(802, 251)
        Me.ButtonExcell.Name = "ButtonExcell"
        Me.ButtonExcell.Size = New System.Drawing.Size(129, 30)
        Me.ButtonExcell.TabIndex = 17
        Me.ButtonExcell.Text = "Exportar a Excell"
        Me.ButtonExcell.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonExcell.UseVisualStyleBackColor = True
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
        'MarcasTableAdapter
        '
        Me.MarcasTableAdapter.ClearBeforeFill = True
        '
        'ModelosTableAdapter
        '
        Me.ModelosTableAdapter.ClearBeforeFill = True
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'Localizacion_ConsultaTableAdapter
        '
        Me.Localizacion_ConsultaTableAdapter.ClearBeforeFill = True
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1016, 25)
        Me.FillByToolStrip.TabIndex = 22
        Me.FillByToolStrip.Text = "FillByToolStrip"
        Me.FillByToolStrip.Visible = False
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Enabled = False
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(35, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'FillBy1ToolStrip
        '
        Me.FillBy1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillBy1ToolStripButton})
        Me.FillBy1ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBy1ToolStrip.Name = "FillBy1ToolStrip"
        Me.FillBy1ToolStrip.Size = New System.Drawing.Size(1016, 25)
        Me.FillBy1ToolStrip.TabIndex = 23
        Me.FillBy1ToolStrip.Text = "FillBy1ToolStrip"
        Me.FillBy1ToolStrip.Visible = False
        '
        'FillBy1ToolStripButton
        '
        Me.FillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy1ToolStripButton.Name = "FillBy1ToolStripButton"
        Me.FillBy1ToolStripButton.Size = New System.Drawing.Size(41, 22)
        Me.FillBy1ToolStripButton.Text = "FillBy1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(74, 619)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Label5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(347, 619)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Label6"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(347, 668)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 20)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Label8"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(578, 619)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 20)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Label9"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(576, 668)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 20)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Label10"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(128, 619)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(147, 20)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Datáfonos En Total"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(405, 619)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 20)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Ingenico 5100"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(405, 668)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 20)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Ingenico Banjos"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(637, 619)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 20)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Verifone 8210"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(637, 668)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(139, 20)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Verifone 8010 Wifi"
        '
        'TextBoxSerie
        '
        Me.TextBoxSerie.Location = New System.Drawing.Point(145, 129)
        Me.TextBoxSerie.Name = "TextBoxSerie"
        Me.TextBoxSerie.Size = New System.Drawing.Size(286, 20)
        Me.TextBoxSerie.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(93, 131)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 20)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Serie"
        '
        'Datafonos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 739)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBoxSerie)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonExcell)
        Me.Controls.Add(Me.BotonBorrar)
        Me.Controls.Add(Me.BuscarDatafonos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBoxEstado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBoxModelo)
        Me.Controls.Add(Me.ComboBoxMarca)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxCaja)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cerrar)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.FillBy1ToolStrip)
        Me.Name = "Datafonos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LocalizacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalizacionConsultaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPVsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.FillBy1ToolStrip.ResumeLayout(False)
        Me.FillBy1ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cerrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxCaja As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxMarca As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxModelo As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxEstado As System.Windows.Forms.ComboBox
    Friend WithEvents TPVDataSet As WindowsApplication1.TPVDataSet
    Friend WithEvents TPVsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TPVsTableAdapter As WindowsApplication1.TPVDataSetTableAdapters.TPVsTableAdapter
    Friend WithEvents LocalizacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocalizacionTableAdapter As WindowsApplication1.TPVDataSetTableAdapters.LocalizacionTableAdapter
    Friend WithEvents MarcasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MarcasTableAdapter As WindowsApplication1.TPVDataSetTableAdapters.MarcasTableAdapter
    Friend WithEvents ModelosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModelosTableAdapter As WindowsApplication1.TPVDataSetTableAdapters.ModelosTableAdapter
    Friend WithEvents EstadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadoTableAdapter As WindowsApplication1.TPVDataSetTableAdapters.EstadoTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BuscarDatafonos As System.Windows.Forms.Button
    Friend WithEvents BotonBorrar As System.Windows.Forms.Button
    Friend WithEvents ButtonExcell As System.Windows.Forms.Button
    Friend WithEvents LocalizacionConsultaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Localizacion_ConsultaTableAdapter As WindowsApplication1.TPVDataSetTableAdapters.Localizacion_ConsultaTableAdapter
    Friend WithEvents LocalizacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaTPVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NobreModeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubmodeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComentarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillBy1ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillBy1ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
