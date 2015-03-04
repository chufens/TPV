Public Class Conversor

    Private Sub BotonBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonBorrar.Click
        Me.LabelSerie.Text = ""
        Me.TextBoxReal.Clear()
        Me.TextBoxReal.Select()
    End Sub

    Private Sub ButtonConvertir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonConvertir.Click
        Dim serieinicial As String = Me.TextBoxReal.Text
        Dim longitud As Integer = Me.TextBoxReal.Text.Length
        Dim seriefinal As String
        Dim i As Integer

        If serieinicial.Length > 9 Then
            If serieinicial.Length < 12 Then
                seriefinal = "BT"
            Else : seriefinal = "LN"
            End If
            For i = longitud - 9 To longitud - 1
                seriefinal = String.Concat(seriefinal, serieinicial(i))
                'MessageBox.Show(seriefinal)
            Next

            Me.LabelSerie.Text = seriefinal
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class