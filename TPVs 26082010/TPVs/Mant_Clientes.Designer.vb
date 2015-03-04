<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mant_Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mant_Clientes))
        Me.ButtonCerrar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ActBBDD = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextPathExcel = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.FechaActualizaciónBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPVDataSet = New WindowsApplication1.TPVDataSet
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Fecha_ActualizaciónTableAdapter = New WindowsApplication1.TPVDataSetTableAdapters.Fecha_ActualizaciónTableAdapter
        Me.ClientesTableAdapter = New WindowsApplication1.TPVDataSetTableAdapters.ClientesTableAdapter
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.FechaActualizaciónBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.Image = CType(resources.GetObject("ButtonCerrar.Image"), System.Drawing.Image)
        Me.ButtonCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCerrar.Location = New System.Drawing.Point(625, 185)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(110, 37)
        Me.ButtonCerrar.TabIndex = 14
        Me.ButtonCerrar.Text = "Cerrar"
        Me.ButtonCerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(535, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Actualización de Base de datos de Clientes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha de última actualización"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(270, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label3"
        '
        'ActBBDD
        '
        Me.ActBBDD.Image = CType(resources.GetObject("ActBBDD.Image"), System.Drawing.Image)
        Me.ActBBDD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ActBBDD.Location = New System.Drawing.Point(420, 188)
        Me.ActBBDD.Name = "ActBBDD"
        Me.ActBBDD.Size = New System.Drawing.Size(110, 30)
        Me.ActBBDD.TabIndex = 11
        Me.ActBBDD.Text = "Actualizar"
        Me.ActBBDD.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Archivo"
        '
        'TextPathExcel
        '
        Me.TextPathExcel.Location = New System.Drawing.Point(87, 194)
        Me.TextPathExcel.Name = "TextPathExcel"
        Me.TextPathExcel.Size = New System.Drawing.Size(268, 20)
        Me.TextPathExcel.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(370, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.FechaActualizaciónBindingSource
        Me.ListBox1.DisplayMember = "Fecha"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(1019, 26)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(10, 17)
        Me.ListBox1.TabIndex = 6
        Me.ListBox1.ValueMember = "Fecha"
        Me.ListBox1.Visible = False
        '
        'FechaActualizaciónBindingSource
        '
        Me.FechaActualizaciónBindingSource.DataMember = "Fecha_Actualización"
        Me.FechaActualizaciónBindingSource.DataSource = Me.TPVDataSet
        '
        'TPVDataSet
        '
        Me.TPVDataSet.DataSetName = "TPVDataSet"
        Me.TPVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(1019, -2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(10, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.TPVDataSet
        '
        'Fecha_ActualizaciónTableAdapter
        '
        Me.Fecha_ActualizaciónTableAdapter.ClearBeforeFill = True
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(558, 184)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Mant_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 248)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextPathExcel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ActBBDD)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonCerrar)
        Me.Name = "Mant_Clientes"
        Me.Text = "Manteminiento Clientes"
        CType(Me.FechaActualizaciónBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonCerrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TPVDataSet As WindowsApplication1.TPVDataSet
    Friend WithEvents FechaActualizaciónBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Fecha_ActualizaciónTableAdapter As WindowsApplication1.TPVDataSetTableAdapters.Fecha_ActualizaciónTableAdapter
    Friend WithEvents ActBBDD As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextPathExcel As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As WindowsApplication1.TPVDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
