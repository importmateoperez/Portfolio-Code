Public Class frmAccount

    Public acc_id As String


    Private Sub filterBuilder()
        Dim filter As String = ""

        Try

            If Not String.IsNullOrEmpty(accfitler.Text) Then
                filter += "[Account_Name] LIKE '%" & accfitler.Text & "%'"
            End If

            If accCheckBox.Checked Then
                filter += ("[Acc_Active] = True")
            End If

            If accNotCheckBox.Checked Then
                filter += ("[Acc_Active] = False")
            End If

            Donor_AccountsBindingSource.Filter = filter

        Catch ex As Exception
            MessageBox.Show(Me, "Error: Do not click the two checkboxes at the same time. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub

    Private Sub stripMenuReturn_Click(sender As Object, e As EventArgs) Handles stripMenuReturn.Click
        Me.Close()
    End Sub

    Private Sub btnEditRecord_Click(sender As Object, e As EventArgs) Handles btnEditRecord.Click
        Dim frmAddEdit As New frmAddEdit
        Dim rowCount As Integer = dgvAccounts.SelectedRows.Count

        If rowCount > 1 Then
            MessageBox.Show("Too many rows selected. You may only edit one record at a time.")
        Else
            If rowCount < 1 Then
                MessageBox.Show("You must select a row to edit.")
            Else
                Dim aid As Integer = CInt(dgvAccounts.CurrentRow.Cells(0).Value)
                frmAddEdit.acc_id = aid
                frmAddEdit.ShowDialog()

            End If
        End If

        Me.Donor_AccountsTableAdapter.Fill(Me.NoSuchDataSet.Donor_Accounts)

    End Sub

    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click
        Dim frmAddEdit As New frmAddEdit
        frmAddEdit.acc_id = "-1"
        frmAddEdit.ShowDialog()

        Me.Donor_AccountsTableAdapter.Fill(Me.NoSuchDataSet.Donor_Accounts)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim rowCount As Integer = dgvAccounts.SelectedRows.Count

        If rowCount > 1 Then
            MessageBox.Show("Too many rows selected. You may only delete one record at a time.")
        Else
            If rowCount < 1 Then
                MessageBox.Show("You must select a row to delete.")
            Else
                Dim aid As String = CInt(dgvAccounts.CurrentRow.Cells(0).Value)
                Me.Donor_AccountsBindingSource.Position = Donor_AccountsBindingSource.Find("Account_ID", aid)

                Dim recdata As String = dgvAccounts.CurrentRow.Cells(0).Value.ToString

                Dim yesno As DialogResult = MessageBox.Show("Do you wish to delete account ID " & recdata & "?",
                    "Delete", MessageBoxButtons.YesNo)
                If yesno = DialogResult.Yes Then
                    Me.Donor_AccountsBindingSource.RemoveCurrent()
                    Me.Donor_AccountsTableAdapter.Update(Me.NoSuchDataSet.Donor_Accounts)
                End If
            End If
        End If

        Me.Donor_AccountsTableAdapter.Fill(Me.NoSuchDataSet.Donor_Accounts)

    End Sub

    Private Sub frmAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Donor_AccountsTableAdapter.Fill(Me.NoSuchDataSet.Donor_Accounts)


        If acc_id = "-1" Then
            Me.Donor_AccountsBindingSource.AddNew()
        Else
            Me.Donor_AccountsBindingSource.Position = Donor_AccountsBindingSource.Find("Account_ID", acc_id)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles accfitler.TextChanged
        filterBuilder()
    End Sub

    Private Sub accCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles accCheckBox.CheckedChanged
        filterBuilder()
    End Sub

    Private Sub accNotCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles accNotCheckBox.CheckedChanged
        filterBuilder()
    End Sub
End Class