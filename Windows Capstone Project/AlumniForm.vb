Public Class frmAlumni

    Public mem_id As String

    Private Sub filterBuilder()
        Dim filter As String = ""

        Try
            If Not String.IsNullOrEmpty(firstNametxt.Text) Then
                filter += "[First_Name] LIKE '%" & firstNametxt.Text & "%'"
            End If

            If Not String.IsNullOrEmpty(lastNametxt.Text) Then
                filter += "[Last_Name] LIKE '%" & lastNametxt.Text & "%'"
            End If

            If Not String.IsNullOrEmpty(citytxt.Text) Then
                filter += "[City] LIKE '%" & citytxt.Text & "%'"
            End If

            If Not String.IsNullOrEmpty(statetxt.Text) Then
                filter += "[State] LIKE '%" & statetxt.Text & "%'"
            End If

            If Not String.IsNullOrEmpty(majortxt.Text) Then
                filter += "[Degree_1] LIKE '%" & majortxt.Text & "%'"
            End If

            If activeChecked.Checked Then
                filter += ("[Account_Active] = True")
            End If

            If activeNotChecked.Checked Then
                filter += ("[Account_Active] = False")
            End If

            Alumni_InfoBindingSource.Filter = filter

        Catch ex As Exception
            MessageBox.Show(Me, "Error: Please only use one search function at a time.  " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub
    Private Sub BackToMainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToMainMenuToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click
        Dim frmAddEditAlumni As New frmAddEditAlumni

        frmAddEditAlumni.mem_id = "-1"
        frmAddEditAlumni.ShowDialog()

        Me.Alumni_InfoTableAdapter.Fill(Me.NoSuchDataSet.Alumni_Info)
    End Sub

    Private Sub btnEditRecord_Click(sender As Object, e As EventArgs) Handles btnEditRecord.Click
        Dim frmAddEditAlumni As New frmAddEditAlumni
        Dim rowCount As Integer = dgvAlumni.SelectedRows.Count

        If rowCount > 1 Then
            MessageBox.Show("Too many rows selected. You may only edit one record at a time.")
        Else
            If rowCount < 1 Then
                MessageBox.Show("You must select a row to edit.")
            Else
                Dim memid As Integer = CInt(dgvAlumni.CurrentRow.Cells(0).Value)
                frmAddEditAlumni.mem_id = memid
                frmAddEditAlumni.ShowDialog()

            End If
        End If

        Me.Alumni_InfoTableAdapter.Fill(Me.NoSuchDataSet.Alumni_Info)
    End Sub

    Private Sub frmAlumni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NoSuchDataSet.Alumni_Info' table. You can move, or remove it, as needed.
        Me.Alumni_InfoTableAdapter.Fill(Me.NoSuchDataSet.Alumni_Info)

        If mem_id = "-1" Then
            Me.Alumni_InfoBindingSource.AddNew()
        Else
            Me.Alumni_InfoBindingSource.Position = Alumni_InfoBindingSource.Find("Member_ID", mem_id)
        End If

    End Sub

    Private Sub firstNametxt_TextChanged(sender As Object, e As EventArgs) Handles firstNametxt.TextChanged
        filterBuilder()
    End Sub

    Private Sub lastNametxt_TextChanged(sender As Object, e As EventArgs) Handles lastNametxt.TextChanged
        filterBuilder()
    End Sub

    Private Sub citytxt_TextChanged(sender As Object, e As EventArgs) Handles citytxt.TextChanged
        filterBuilder()
    End Sub

    Private Sub statetxt_TextChanged(sender As Object, e As EventArgs) Handles statetxt.TextChanged
        filterBuilder()
    End Sub

    Private Sub majortxt_TextChanged(sender As Object, e As EventArgs) Handles majortxt.TextChanged
        filterBuilder()
    End Sub

    Private Sub activeChecked_CheckedChanged(sender As Object, e As EventArgs) Handles activeChecked.CheckedChanged
        filterBuilder()
    End Sub

    Private Sub activeNotChecked_CheckedChanged(sender As Object, e As EventArgs) Handles activeNotChecked.CheckedChanged
        filterBuilder()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim frmExpiredMembers As New ExpiredMembers

        frmExpiredMembers.ShowDialog()
    End Sub
End Class