<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conversor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Conversor))
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBoxReal = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.BotonBorrar = New System.Windows.Forms.Button
        Me.ButtonConvertir = New System.Windows.Forms.Button
        Me.LabelSerie = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(290, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(364, 31)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Conversor Números de Serie"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(123, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Número CAJARIOJA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(171, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Número REAL"
        '
        'TextBoxReal
        '
        Me.TextBoxReal.Location = New System.Drawing.Point(320, 121)
        Me.TextBoxReal.Name = "TextBoxReal"
        Me.TextBoxReal.Size = New System.Drawing.Size(245, 20)
        Me.TextBoxReal.TabIndex = 30
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(836, 144)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 37)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BotonBorrar
        '
        Me.BotonBorrar.Image = CType(resources.GetObject("BotonBorrar.Image"), System.Drawing.Image)
        Me.BotonBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonBorrar.Location = New System.Drawing.Point(653, 151)
        Me.BotonBorrar.Name = "BotonBorrar"
        Me.BotonBorrar.Size = New System.Drawing.Size(110, 30)
        Me.BotonBorrar.TabIndex = 43
        Me.BotonBorrar.Text = "Borrar"
        Me.BotonBorrar.UseVisualStyleBackColor = True
        '
        'ButtonConvertir
        '
        Me.ButtonConvertir.Image = CType(resources.GetObject("ButtonConvertir.Image"), System.Drawing.Image)
        Me.ButtonConvertir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonConvertir.Location = New System.Drawing.Point(653, 111)
        Me.ButtonConvertir.Name = "ButtonConvertir"
        Me.ButtonConvertir.Size = New System.Drawing.Size(110, 30)
        Me.ButtonConvertir.TabIndex = 44
        Me.ButtonConvertir.Text = "Convertir"
        Me.ButtonConvertir.UseVisualStyleBackColor = True
        '
        'LabelSerie
        '
        Me.LabelSerie.AutoSize = True
        Me.LabelSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSerie.Location = New System.Drawing.Point(320, 155)
        Me.LabelSerie.Name = "LabelSerie"
        Me.LabelSerie.Size = New System.Drawing.Size(0, 20)
        Me.LabelSerie.TabIndex = 45
        '
        'Conversor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 210)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelSerie)
        Me.Controls.Add(Me.ButtonConvertir)
        Me.Controls.Add(Me.BotonBorrar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBoxReal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Name = "Conversor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxReal As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BotonBorrar As System.Windows.Forms.Button
    Friend WithEvents ButtonConvertir As System.Windows.Forms.Button
    Friend WithEvents LabelSerie As System.Windows.Forms.Label
End Class
