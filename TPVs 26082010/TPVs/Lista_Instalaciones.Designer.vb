<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lista_Instalaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lista_Instalaciones))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ButtonGenerar = New System.Windows.Forms.Button
        Me.ComboBoxAño = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.ComboBoxMes = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.ButtonCerrar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.serie_mod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TecnicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NobreModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SerieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NuevaInstalacionDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.SegundaInstalacionDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.InstaladoConsultaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPVDataSet = New WindowsApplication1.TPVDataSet
        Me.Instalado_ConsultaTableAdapter = New WindowsApplication1.TPVDataSetTableAdapters.Instalado_ConsultaTableAdapter
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstaladoConsultaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonGenerar)
        Me.GroupBox3.Controls.Add(Me.ComboBoxAño)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.ComboBoxMes)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(71, 99)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(741, 90)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Informe Mesual de Instalaciones"
        '
        'ButtonGenerar
        '
        Me.ButtonGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGenerar.Image = CType(resources.GetObject("ButtonGenerar.Image"), System.Drawing.Image)
        Me.ButtonGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonGenerar.Location = New System.Drawing.Point(564, 37)
        Me.ButtonGenerar.Name = "ButtonGenerar"
        Me.ButtonGenerar.Size = New System.Drawing.Size(129, 30)
        Me.ButtonGenerar.TabIndex = 28
        Me.ButtonGenerar.Text = "Exportar a Excell"
        Me.ButtonGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonGenerar.UseVisualStyleBackColor = True
        '
        'ComboBoxAño
        '
        Me.ComboBoxAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxAño.FormattingEnabled = True
        Me.ComboBoxAño.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.ComboBoxAño.Location = New System.Drawing.Point(383, 39)
        Me.ComboBoxAño.Name = "ComboBoxAño"
        Me.ComboBoxAño.Size = New System.Drawing.Size(121, 28)
        Me.ComboBoxAño.TabIndex = 27
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(339, 41)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(38, 20)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Año"
        '
        'ComboBoxMes
        '
        Me.ComboBoxMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxMes.FormattingEnabled = True
        Me.ComboBoxMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.ComboBoxMes.Location = New System.Drawing.Point(104, 39)
        Me.ComboBoxMes.Name = "ComboBoxMes"
        Me.ComboBoxMes.Size = New System.Drawing.Size(189, 28)
        Me.ComboBoxMes.TabIndex = 25
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(57, 42)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 20)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Mes"
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.Image = CType(resources.GetObject("ButtonCerrar.Image"), System.Drawing.Image)
        Me.ButtonCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCerrar.Location = New System.Drawing.Point(876, 152)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(110, 37)
        Me.ButtonCerrar.TabIndex = 29
        Me.ButtonCerrar.Text = "Cerrar"
        Me.ButtonCerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(475, 31)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Listado de Instalaciones de Datáfonos"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.serie_mod, Me.ClienteDataGridViewTextBoxColumn, Me.CiudadDataGridViewTextBoxColumn, Me.TecnicoDataGridViewTextBoxColumn, Me.NobreModeloDataGridViewTextBoxColumn, Me.SerieDataGridViewTextBoxColumn, Me.NuevaInstalacionDataGridViewCheckBoxColumn, Me.SegundaInstalacionDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.InstaladoConsultaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(25, 195)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(643, 15)
        Me.DataGridView1.TabIndex = 31
        Me.DataGridView1.Visible = False
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'serie_mod
        '
        Me.serie_mod.DataPropertyName = "serie_mod"
        Me.serie_mod.HeaderText = "serie_mod"
        Me.serie_mod.Name = "serie_mod"
        Me.serie_mod.ReadOnly = True
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CiudadDataGridViewTextBoxColumn
        '
        Me.CiudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad"
        Me.CiudadDataGridViewTextBoxColumn.HeaderText = "Ciudad"
        Me.CiudadDataGridViewTextBoxColumn.Name = "CiudadDataGridViewTextBoxColumn"
        Me.CiudadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TecnicoDataGridViewTextBoxColumn
        '
        Me.TecnicoDataGridViewTextBoxColumn.DataPropertyName = "Tecnico"
        Me.TecnicoDataGridViewTextBoxColumn.HeaderText = "Tecnico"
        Me.TecnicoDataGridViewTextBoxColumn.Name = "TecnicoDataGridViewTextBoxColumn"
        Me.TecnicoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NobreModeloDataGridViewTextBoxColumn
        '
        Me.NobreModeloDataGridViewTextBoxColumn.DataPropertyName = "Nobre_Modelo"
        Me.NobreModeloDataGridViewTextBoxColumn.HeaderText = "Nobre_Modelo"
        Me.NobreModeloDataGridViewTextBoxColumn.Name = "NobreModeloDataGridViewTextBoxColumn"
        Me.NobreModeloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SerieDataGridViewTextBoxColumn
        '
        Me.SerieDataGridViewTextBoxColumn.DataPropertyName = "Serie"
        Me.SerieDataGridViewTextBoxColumn.HeaderText = "Serie"
        Me.SerieDataGridViewTextBoxColumn.Name = "SerieDataGridViewTextBoxColumn"
        Me.SerieDataGridViewTextBoxColumn.ReadOnly = True
        Me.SerieDataGridViewTextBoxColumn.Visible = False
        '
        'NuevaInstalacionDataGridViewCheckBoxColumn
        '
        Me.NuevaInstalacionDataGridViewCheckBoxColumn.DataPropertyName = "Nueva_Instalacion"
        Me.NuevaInstalacionDataGridViewCheckBoxColumn.HeaderText = "Nueva_Instalacion"
        Me.NuevaInstalacionDataGridViewCheckBoxColumn.Name = "NuevaInstalacionDataGridViewCheckBoxColumn"
        Me.NuevaInstalacionDataGridViewCheckBoxColumn.ReadOnly = True
        Me.NuevaInstalacionDataGridViewCheckBoxColumn.Visible = False
        '
        'SegundaInstalacionDataGridViewCheckBoxColumn
        '
        Me.SegundaInstalacionDataGridViewCheckBoxColumn.DataPropertyName = "Segunda_Instalacion"
        Me.SegundaInstalacionDataGridViewCheckBoxColumn.HeaderText = "Segunda_Instalacion"
        Me.SegundaInstalacionDataGridViewCheckBoxColumn.Name = "SegundaInstalacionDataGridViewCheckBoxColumn"
        Me.SegundaInstalacionDataGridViewCheckBoxColumn.ReadOnly = True
        Me.SegundaInstalacionDataGridViewCheckBoxColumn.Visible = False
        '
        'InstaladoConsultaBindingSource
        '
        Me.InstaladoConsultaBindingSource.DataMember = "Instalado Consulta"
        Me.InstaladoConsultaBindingSource.DataSource = Me.TPVDataSet
        '
        'TPVDataSet
        '
        Me.TPVDataSet.DataSetName = "TPVDataSet"
        Me.TPVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Instalado_ConsultaTableAdapter
        '
        Me.Instalado_ConsultaTableAdapter.ClearBeforeFill = True
        '
        'Lista_Instalaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 218)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonCerrar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Lista_Instalaciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstaladoConsultaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonGenerar As System.Windows.Forms.Button
    Friend WithEvents ComboBoxAño As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TPVDataSet As WindowsApplication1.TPVDataSet
    Friend WithEvents ButtonCerrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents InstaladoConsultaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Instalado_ConsultaTableAdapter As WindowsApplication1.TPVDataSetTableAdapters.Instalado_ConsultaTableAdapter
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serie_mod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CiudadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TecnicoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NobreModeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NuevaInstalacionDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SegundaInstalacionDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
