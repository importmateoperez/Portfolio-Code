Public Class frmAddEditDonation

    Public don_id As String
    Private Sub BackToMainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToMainMenuToolStripMenuItem.Click
        Dim yesno As DialogResult = MessageBox.Show("You are about to lose any changes. Continue with exit? ",
            "Exit", MessageBoxButtons.YesNo)

        If yesno = DialogResult.Yes Then
            Me.Donation_DetailsBindingSource.CancelEdit()
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim yesno As DialogResult = MessageBox.Show("You are about to lose any changes. Continue with cancel? ",
            "Cancel", MessageBoxButtons.YesNo)
        If yesno = DialogResult.Yes Then
            Me.Donation_DetailsBindingSource.CancelEdit()
            Me.Close()
        End If
    End Sub

    Private Sub frmAddEditDonation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NoSuchDataSet.Alumni_Info' table. You can move, or remove it, as needed.
        Me.Alumni_InfoTableAdapter.Fill(Me.NoSuchDataSet.Alumni_Info)
        'TODO: This line of code loads data into the 'NoSuchDataSet.Donor_Accounts' table. You can move, or remove it, as needed.
        Me.Donor_AccountsTableAdapter.Fill(Me.NoSuchDataSet.Donor_Accounts)
        'TODO: This line of code loads data into the 'NoSuchDataSet.Donation_Details' table. You can move, or remove it, as needed.
        Me.Donation_DetailsTableAdapter.Fill(Me.NoSuchDataSet.Donation_Details)

        If don_id = "-1" Then
            Me.Donation_DetailsBindingSource.AddNew()
        Else
            Me.Donation_DetailsBindingSource.Position = Donation_DetailsBindingSource.Find("Donation_ID", don_id)
        End If

    End Sub

    Private Sub Donation_DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Donation_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NoSuchDataSet)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Me.Validate()

        If Not IsNumeric(Donation_ID.Text) And Not IsNumeric(Account_IDTextBox.Text) And Not IsNumeric(Member_IDTextBox.Text) And Not IsNumeric(Donation_Amount.Text) Then

            MessageBox.Show("Donation ID, Member ID, Account ID, and Donation amount must be numeric")

        Else
            Try
                Me.Donation_DetailsBindingSource.EndEdit()
                Me.Donation_DetailsTableAdapter.Update(Me.NoSuchDataSet.Donation_Details)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(Me, "Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try

        End If

    End Sub


End Class