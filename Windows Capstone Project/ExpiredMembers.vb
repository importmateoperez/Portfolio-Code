Imports System.IO

Public Class ExpiredMembers
    Private Sub Alumni_InfoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Alumni_InfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NoSuchDataSet)

    End Sub

    Private Sub ExpiredMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NoSuchDataSet.Donation_Details' table. You can move, or remove it, as needed.
        Me.Donation_DetailsTableAdapter.Fill(Me.NoSuchDataSet.Donation_Details)
        'TODO: This line of code loads data into the 'NoSuchDataSet.Alumni_Info' table. You can move, or remove it, as needed.
        Me.Alumni_InfoTableAdapter.Fill(Me.NoSuchDataSet.Alumni_Info)

    End Sub

    Private Sub expiredCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles expiredCheckbox.CheckedChanged
        Dim filter As String = ""

        Try
            If expiredCheckbox.Checked Then
                filter += ("[Account_Active] = False")
            End If
        Catch ex As Exception
            MessageBox.Show(Me, "Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        AlumniInfoBindingSource.Filter = filter

    End Sub

    Private Sub BackToPreviousMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToPreviousMenuToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim yesno As DialogResult = MessageBox.Show("You are about to lose any changes. Continue with cancel? ",
           "Cancel", MessageBoxButtons.YesNo)
        If yesno = DialogResult.Yes Then
            Me.AlumniInfoBindingSource.CancelEdit()
            Me.Close()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim fileName As String
        Dim expiredMemberFile As StreamWriter

        fileName = InputBox("Enter a name for the file. Please only use files ending in .txt or .csv")

        Try

            expiredMemberFile = File.CreateText(fileName)

            For Each item In expiredLstBox.Items
                Dim row As DataRowView = DirectCast(item, DataRowView)

                expiredMemberFile.WriteLine(row("First_Name").ToString() & " " & row("Last_Name").ToString() & " " & row("Mobile_Phone").ToString())

            Next

            expiredMemberFile.Close()

            MessageBox.Show("File saved successfully.")

        Catch ex As Exception
            MessageBox.Show(Me, "Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub
End Class