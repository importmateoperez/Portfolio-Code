Public Class frmAddEditAlumni

    Public mem_id As String
    Private Sub BackToPreviousMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToPreviousMenuToolStripMenuItem.Click
        Dim yesno As DialogResult = MessageBox.Show("You are about to lose any changes. Continue with exit? ",
            "Exit", MessageBoxButtons.YesNo)

        If yesno = DialogResult.Yes Then
            Me.Alumni_InfoBindingSource.CancelEdit()
            Me.Close()
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim yesno As DialogResult = MessageBox.Show("You are about to lose any changes. Continue with cancel? ",
            "Cancel", MessageBoxButtons.YesNo)

        If yesno = DialogResult.Yes Then
            Me.Alumni_InfoBindingSource.CancelEdit()
            Me.Close()
        End If

    End Sub

    Private Sub Alumni_InfoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Alumni_InfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NoSuchDataSet)

    End Sub

    Private Sub frmAddEditAlumni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NoSuchDataSet.Alumni_Info' table. You can move, or remove it, as needed.
        Me.Alumni_InfoTableAdapter.Fill(Me.NoSuchDataSet.Alumni_Info)

        If mem_id = "-1" Then
            Me.Alumni_InfoBindingSource.AddNew()
        Else
            Me.Alumni_InfoBindingSource.Position = Alumni_InfoBindingSource.Find("Member_ID", mem_id)
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Me.Validate()

        Try
            Me.Alumni_InfoBindingSource.EndEdit()
            Me.Alumni_InfoTableAdapter.Update(Me.NoSuchDataSet.Alumni_Info)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(Me, "Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub


End Class