Public Class frmAddEdit

    Public acc_id As String

    Private Sub BackToMainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToMainMenuToolStripMenuItem.Click
        Dim yesno As DialogResult = MessageBox.Show("You are about to lose any changes. Continue with exit? ",
            "Exit", MessageBoxButtons.YesNo)

        If yesno = DialogResult.Yes Then
            Me.Donor_AccountsBindingSource.CancelEdit()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim yesno As DialogResult = MessageBox.Show("You are about to lose any changes. Continue with cancel? ",
            "Cancel", MessageBoxButtons.YesNo)
        If yesno = DialogResult.Yes Then
            Me.Donor_AccountsBindingSource.CancelEdit()
            Me.Close()
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Me.Validate()

        If Not IsNumeric(Account_ID.Text) Or Account_ID.Text.Length <> 7 Then

            MessageBox.Show("Account ID must be numeric and 7 digits")

        Else
            Try
                Me.Donor_AccountsBindingSource.EndEdit()
                Me.Donor_AccountsTableAdapter.Update(Me.NoSuchDataSet.Donor_Accounts)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(Me, "Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try

        End If

    End Sub

    Private Sub frmAddEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NoSuchDataSet.Donor_Accounts' table. You can move, or remove it, as needed.
        Me.Donor_AccountsTableAdapter.Fill(Me.NoSuchDataSet.Donor_Accounts)

        If acc_id = "-1" Then
            Me.Donor_AccountsBindingSource.AddNew()
        Else
            Me.Donor_AccountsBindingSource.Position = Donor_AccountsBindingSource.Find("Account_ID", acc_id)
        End If

    End Sub

    Private Sub Donor_AccountsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Donor_AccountsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NoSuchDataSet)

    End Sub
End Class