Public Class user_record

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click
        main.Show()
        Me.Hide()
        main.ShowInTaskbar = True
    End Sub

    Private Sub user_record_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getUserIds()
        GetRecordCount()
        FetchUserData()
    End Sub

    Private Sub record_grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles record_grid.CellContentClick

    End Sub

    Private Sub count_label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles count_label.Click

    End Sub
End Class