<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lista_Reparaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lista_Reparaciones))
        Me.ButtonCerrar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TPVDataSet = New WindowsApplication1.TPVDataSet
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBoxSerie = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.ComboBoxEstado = New System.Windows.Forms.ComboBox
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonBuscar = New System.Windows.Forms.Button
        Me.ButtonGenerar = New System.Windows.Forms.Button
        Me.EstadoTableAdapter = New WindowsApplication1.TPVDataSetTableAdapters.EstadoTableAdapter
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.SerieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ComentarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ComentariosReparacionConsultaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Comentarios_Reparacion_ConsultaTableAdapter = New WindowsApplication1.TPVDataSetTableAdapters.Comentarios_Reparacion_ConsultaTableAdapter
        Me.BotonBorrar = New System.Windows.Forms.Button
        CType(Me.TPVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComentariosReparacionConsultaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.Image = CType(resources.GetObject("ButtonCerrar.Image"), System.Drawing.Image)
        Me.ButtonCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCerrar.Location = New System.Drawing.Point(864, 370)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(110, 37)
        Me.ButtonCerrar.TabIndex = 7
        Me.ButtonCerrar.Text = "Cerrar"
        Me.ButtonCerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(564, 31)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Listado de Reparaciones / Roturas Datáfonos"
        '
        'TPVDataSet
        '
        Me.TPVDataSet.DataSetName = "TPVDataSet"
        Me.TPVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Serie"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Fecha incial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(403, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 20)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Fecha Final"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Estado Final"
        '
        'TextBoxSerie
        '
        Me.TextBoxSerie.Location = New System.Drawing.Point(166, 129)
        Me.TextBoxSerie.Name = "TextBoxSerie"
        Me.TextBoxSerie.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxSerie.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(166, 172)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(505, 172)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 3
        '
        'ComboBoxEstado
        '
        Me.ComboBoxEstado.DataSource = Me.EstadoBindingSource
        Me.ComboBoxEstado.DisplayMember = "Estado"
        Me.ComboBoxEstado.FormattingEnabled = True
        Me.ComboBoxEstado.Location = New System.Drawing.Point(166, 216)
        Me.ComboBoxEstado.Name = "ComboBoxEstado"
        Me.ComboBoxEstado.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxEstado.TabIndex = 4
        '
        'EstadoBindingSource
        '
        Me.EstadoBindingSource.DataMember = "Estado"
        Me.EstadoBindingSource.DataSource = Me.TPVDataSet
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Image = CType(resources.GetObject("ButtonBuscar.Image"), System.Drawing.Image)
        Me.ButtonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBuscar.Location = New System.Drawing.Point(864, 119)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(110, 30)
        Me.ButtonBuscar.TabIndex = 5
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'ButtonGenerar
        '
        Me.ButtonGenerar.Enabled = False
        Me.ButtonGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGenerar.Image = CType(resources.GetObject("ButtonGenerar.Image"), System.Drawing.Image)
        Me.ButtonGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonGenerar.Location = New System.Drawing.Point(845, 227)
        Me.ButtonGenerar.Name = "ButtonGenerar"
        Me.ButtonGenerar.Size = New System.Drawing.Size(129, 30)
        Me.ButtonGenerar.TabIndex = 37
        Me.ButtonGenerar.Text = "Exportar a Excell"
        Me.ButtonGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonGenerar.UseVisualStyleBackColor = True
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SerieDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.ComentarioDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ComentariosReparacionConsultaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(166, 257)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(458, 150)
        Me.DataGridView1.TabIndex = 38
        '
        'SerieDataGridViewTextBoxColumn
        '
        Me.SerieDataGridViewTextBoxColumn.DataPropertyName = "Serie"
        Me.SerieDataGridViewTextBoxColumn.HeaderText = "Serie"
        Me.SerieDataGridViewTextBoxColumn.Name = "SerieDataGridViewTextBoxColumn"
        Me.SerieDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ComentarioDataGridViewTextBoxColumn
        '
        Me.ComentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario"
        Me.ComentarioDataGridViewTextBoxColumn.HeaderText = "Comentario"
        Me.ComentarioDataGridViewTextBoxColumn.Name = "ComentarioDataGridViewTextBoxColumn"
        Me.ComentarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ComentariosReparacionConsultaBindingSource
        '
        Me.ComentariosReparacionConsultaBindingSource.DataMember = "Comentarios_Reparacion Consulta"
        Me.ComentariosReparacionConsultaBindingSource.DataSource = Me.TPVDataSet
        '
        'Comentarios_Reparacion_ConsultaTableAdapter
        '
        Me.Comentarios_Reparacion_ConsultaTableAdapter.ClearBeforeFill = True
        '
        'BotonBorrar
        '
        Me.BotonBorrar.Image = CType(resources.GetObject("BotonBorrar.Image"), System.Drawing.Image)
        Me.BotonBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonBorrar.Location = New System.Drawing.Point(864, 173)
        Me.BotonBorrar.Name = "BotonBorrar"
        Me.BotonBorrar.Size = New System.Drawing.Size(110, 30)
        Me.BotonBorrar.TabIndex = 39
        Me.BotonBorrar.Text = "Borrar"
        Me.BotonBorrar.UseVisualStyleBackColor = True
        '
        'Lista_Reparaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 446)
        Me.ControlBox = False
        Me.Controls.Add(Me.BotonBorrar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonGenerar)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.ComboBoxEstado)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBoxSerie)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonCerrar)
        Me.Name = "Lista_Reparaciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TPVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComentariosReparacionConsultaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonCerrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSerie As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBoxEstado As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonBuscar As System.Windows.Forms.Button
    Friend WithEvents ButtonGenerar As System.Windows.Forms.Button
    Friend WithEvents TPVDataSet As WindowsApplication1.TPVDataSet
    Friend WithEvents EstadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadoTableAdapter As WindowsApplication1.TPVDataSetTableAdapters.EstadoTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ComentariosReparacionConsultaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SerieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComentarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comentarios_Reparacion_ConsultaTableAdapter As WindowsApplication1.TPVDataSetTableAdapters.Comentarios_Reparacion_ConsultaTableAdapter
    Friend WithEvents BotonBorrar As System.Windows.Forms.Button
End Class
