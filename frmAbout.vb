Public Class frmAbout
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub



    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVer.Text = SBVersion

    End Sub

    Private Sub lblURL_Click(sender As Object, e As EventArgs) Handles lblURL.Click

    End Sub

    Private Sub lblURL_DoubleClick(sender As Object, e As EventArgs) Handles lblURL.DoubleClick
        System.Diagnostics.Process.Start(lblURL.Text)
    End Sub
End Class