Public Class Main
    Public numserie As String
    Public instalado As Boolean
    Public Marcas As String
    Public Modelo As String
    Public Submodelo As String

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim NewMDIChild As New Buscar_Clientes()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub DatafonosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatafonosToolStripMenuItem1.Click
        Dim NewMDIChild As New Añadir_Datafono()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub


    Private Sub DatafonosToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatafonosToolStripMenuItem3.Click
        Dim NewMDIChild As New Datafonos()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub InstalacionesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstalacionesToolStripMenuItem1.Click
        Dim NewMDIChild As New Lista_Instalaciones()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub EnvíosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnvíosToolStripMenuItem1.Click
        Dim NewMDIChild As New Lista_Envios()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub ReparacionesDeDatafonosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReparacionesDeDatafonosToolStripMenuItem.Click
        Dim NewMDIChild As New Lista_Reparaciones()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub


    Private Sub ClientesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem2.Click
        Dim NewMDIChild As New Mant_Clientes()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
        'PictureBox1.Visible = False
    End Sub

    Private Sub BaseDeDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaseDeDatosToolStripMenuItem.Click
        Dim NewMDIChild As New Mantenimientos()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub DatafonosToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatafonosToolStripMenuItem4.Click
        Dim NewMDIChild As New Modificar_Datafonos()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub ConversorNúmerosDeSerieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConversorNúmerosDeSerieToolStripMenuItem.Click
        Dim NewMDIChild As New Conversor
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub
End Class
