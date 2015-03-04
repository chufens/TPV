Partial Class TPVDataSet
    Partial Class InstaladoDataTable

        Private Sub InstaladoDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Segunda_InstalacionColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
