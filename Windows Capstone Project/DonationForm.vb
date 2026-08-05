Public Class frmDonation

    Public don_id As String

    Private Sub filterBuilder()
        Dim filter As String = ""

        Try

            Dim Member As Integer
            If Not String.IsNullOrEmpty(memIDtxt.Text) AndAlso Integer.TryParse(memIDtxt.Text, Member) Then
                If Not String.IsNullOrEmpty(filter) Then filter += " AND "
                filter += "[Member_ID] = " & Member.ToString()
            End If

            Dim Account As Integer
            If Not String.IsNullOrEmpty(accIDtxt.Text) AndAlso Integer.TryParse(accIDtxt.Text, Account) Then
                If Not String.IsNullOrEmpty(filter) Then filter += " AND "
                filter += "[Account_ID] = " & Account.ToString()
            End If

            Dim startDate As DateTime
            If Not String.IsNullOrEmpty(startDatetxt.Text) AndAlso DateTime.TryParse(startDatetxt.Text, startDate) Then
                If Not String.IsNullOrEmpty(filter) Then filter += " AND "
                filter += "[Record_Date] >= '" & startDate.ToString("yyyy-MM-dd") & "'"
            End If

            Dim endDate As DateTime
            If Not String.IsNullOrEmpty(endDatetxt.Text) AndAlso DateTime.TryParse(endDatetxt.Text, endDate) Then
                If Not String.IsNullOrEmpty(filter) Then filter += " AND "
                filter += "[Record_Date] <= '" & endDate.ToString("yyyy-MM-dd") & "'"
            End If

            Dim amountMin As Decimal
            If Not String.IsNullOrEmpty(minAmounttxt.Text) AndAlso Decimal.TryParse(minAmounttxt.Text, amountMin) Then
                If Not String.IsNullOrEmpty(filter) Then filter += " AND "
                filter += "[Donation_Amount] >= " & amountMin.ToString()
            End If

            Dim amountMax As Decimal
            If Not String.IsNullOrEmpty(maxAmounttxt.Text) AndAlso Decimal.TryParse(maxAmounttxt.Text, amountMax) Then
                If Not String.IsNullOrEmpty(filter) Then filter += " AND "
                filter += "[Donation_Amount] <= " & amountMax.ToString()
            End If

            Donation_DetailsBindingSource.Filter = filter

        Catch ex As Exception
            MessageBox.Show(Me, "Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub
    Private Sub BackToMainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToMainMenuToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnAddDonation_Click(sender As Object, e As EventArgs) Handles btnAddDonation.Click
        Dim frmAddEditDonation As New frmAddEditDonation
        frmAddEditDonation.don_id = "-1"
        frmAddEditDonation.ShowDialog()

        Me.Donation_DetailsTableAdapter.Fill(Me.NoSuchDataSet.Donation_Details)
    End Sub

    Private Sub btnEditDonation_Click(sender As Object, e As EventArgs) Handles btnEditDonation.Click
        Dim frmAddEditDonation As New frmAddEditDonation

        Dim rowCount As Integer = dgvDonations.SelectedRows.Count

        If rowCount > 1 Then
            MessageBox.Show("Too many rows selected. You may only edit one record at a time.")
        Else
            If rowCount < 1 Then
                MessageBox.Show("You must select a row to edit.")
            Else
                Dim did As Integer = CInt(dgvDonations.CurrentRow.Cells(0).Value)
                frmAddEditDonation.don_id = did

                frmAddEditDonation.ShowDialog()
            End If
        End If

        Me.Donation_DetailsTableAdapter.Fill(Me.NoSuchDataSet.Donation_Details)
    End Sub

    Private Sub frmDonation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NoSuchDataSet.Alumni_Info' table. You can move, or remove it, as needed.
        Me.Alumni_InfoTableAdapter.Fill(Me.NoSuchDataSet.Alumni_Info)
        'TODO: This line of code loads data into the 'NoSuchDataSet.Donor_Accounts' table. You can move, or remove it, as needed.
        Me.Donor_AccountsTableAdapter.Fill(Me.NoSuchDataSet.Donor_Accounts)
        Me.Donation_DetailsTableAdapter.Fill(Me.NoSuchDataSet.Donation_Details)


        If don_id = "-1" Then
            Me.Donation_DetailsBindingSource.AddNew()
        Else
            Me.Donation_DetailsBindingSource.Position = Donation_DetailsBindingSource.Find("Donation_ID", don_id)
        End If

    End Sub

    Private Sub btnDeleteDonation_Click(sender As Object, e As EventArgs) Handles btnDeleteDonation.Click
        Dim rowCount As Integer = dgvDonations.SelectedRows.Count

        If rowCount > 1 Then
            MessageBox.Show("Too many rows selected. You may only delete one record at a time.")
        Else
            If rowCount < 1 Then
                MessageBox.Show("You must select a row to delete.")
            Else
                Dim aid As String = CInt(dgvDonations.CurrentRow.Cells(0).Value)
                Me.Donation_DetailsBindingSource.Position = Donation_DetailsBindingSource.Find("Donation_ID", aid)

                Dim recdata As String = dgvDonations.CurrentRow.Cells(0).Value.ToString

                Dim yesno As DialogResult = MessageBox.Show("Do you wish to delete Donation ID " & recdata & "?",
                    "Delete", MessageBoxButtons.YesNo)
                If yesno = DialogResult.Yes Then
                    Me.Donation_DetailsBindingSource.RemoveCurrent()
                    Me.Donation_DetailsTableAdapter.Update(Me.NoSuchDataSet.Donation_Details)
                End If
            End If
        End If

        Me.Donation_DetailsTableAdapter.Fill(Me.NoSuchDataSet.Donation_Details)
    End Sub

    Private Sub memIDtxt_TextChanged(sender As Object, e As EventArgs) Handles memIDtxt.TextChanged
        filterBuilder()
    End Sub

    Private Sub accIDtxt_TextChanged(sender As Object, e As EventArgs) Handles accIDtxt.TextChanged
        filterBuilder()
    End Sub

    Private Sub startDatetxt_TextChanged(sender As Object, e As EventArgs) Handles startDatetxt.TextChanged
        filterBuilder()
    End Sub

    Private Sub endDatetxt_TextChanged(sender As Object, e As EventArgs) Handles endDatetxt.TextChanged
        filterBuilder()
    End Sub

    Private Sub minAmounttxt_TextChanged(sender As Object, e As EventArgs) Handles minAmounttxt.TextChanged
        filterBuilder()
    End Sub

    Private Sub maxAmounttxt_TextChanged(sender As Object, e As EventArgs) Handles maxAmounttxt.TextChanged
        filterBuilder()
    End Sub
End Class