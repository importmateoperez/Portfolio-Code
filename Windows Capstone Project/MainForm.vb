Public Class frmMain

    'display form on button click
    Private Sub btnAlumni_Click(sender As Object, e As EventArgs) Handles btnAlumni.Click
        Dim frmAlumni As New frmAlumni

        frmAlumni.Show()
    End Sub

    'display form on button click
    Private Sub btnManageDon_Click(sender As Object, e As EventArgs) Handles btnManageDon.Click
        Dim frmDonation As New frmDonation

        frmDonation.Show()
    End Sub

    'display form on button click
    Private Sub btnManageAcc_Click(sender As Object, e As EventArgs) Handles btnManageAcc.Click
        Dim frmAccount As New frmAccount

        frmAccount.Show()
    End Sub

    Private Sub ExitApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitApplicationToolStripMenuItem.Click
        Dim yesno As DialogResult = MessageBox.Show("Are you sure you want to exit the application? ",
           "Exit App", MessageBoxButtons.YesNo)

        If yesno = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub stripMenuAbout_Click(sender As Object, e As EventArgs) Handles stripMenuAbout.Click
        MessageBox.Show("A college database manager" & vbNewLine & vbNewLine & "Version 1.0.0")
    End Sub
End Class
