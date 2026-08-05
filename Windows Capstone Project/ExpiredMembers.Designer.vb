<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpiredMembers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.NoSuchDataSet = New NoSuchDatabase.NoSuchDataSet()
        Me.Alumni_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Alumni_InfoTableAdapter = New NoSuchDatabase.NoSuchDataSetTableAdapters.Alumni_InfoTableAdapter()
        Me.TableAdapterManager = New NoSuchDatabase.NoSuchDataSetTableAdapters.TableAdapterManager()
        Me.Donation_DetailsTableAdapter = New NoSuchDatabase.NoSuchDataSetTableAdapters.Donation_DetailsTableAdapter()
        Me.expiredLstBox = New System.Windows.Forms.ListBox()
        Me.AlumniInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.AlumniInfoDonationDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.expiredCheckbox = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BackToPreviousMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.NoSuchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alumni_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumniInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumniInfoDonationDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NoSuchDataSet
        '
        Me.NoSuchDataSet.DataSetName = "NoSuchDataSet"
        Me.NoSuchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Alumni_InfoBindingSource
        '
        Me.Alumni_InfoBindingSource.DataMember = "Alumni_Info"
        Me.Alumni_InfoBindingSource.DataSource = Me.NoSuchDataSet
        '
        'Alumni_InfoTableAdapter
        '
        Me.Alumni_InfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Alumni_InfoTableAdapter = Me.Alumni_InfoTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Donation_DetailsTableAdapter = Me.Donation_DetailsTableAdapter
        Me.TableAdapterManager.Donor_AccountsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NoSuchDatabase.NoSuchDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Donation_DetailsTableAdapter
        '
        Me.Donation_DetailsTableAdapter.ClearBeforeFill = True
        '
        'expiredLstBox
        '
        Me.expiredLstBox.DataSource = Me.AlumniInfoBindingSource
        Me.expiredLstBox.DisplayMember = "First_Name"
        Me.expiredLstBox.FormattingEnabled = True
        Me.expiredLstBox.Location = New System.Drawing.Point(77, 47)
        Me.expiredLstBox.Name = "expiredLstBox"
        Me.expiredLstBox.Size = New System.Drawing.Size(248, 173)
        Me.expiredLstBox.TabIndex = 0
        '
        'AlumniInfoBindingSource
        '
        Me.AlumniInfoBindingSource.DataMember = "Alumni_Info"
        Me.AlumniInfoBindingSource.DataSource = Me.NoSuchDataSet
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(250, 246)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 45)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Generate Report"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(77, 246)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 45)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'AlumniInfoDonationDetailsBindingSource
        '
        Me.AlumniInfoDonationDetailsBindingSource.DataMember = "Alumni_InfoDonation_Details"
        Me.AlumniInfoDonationDetailsBindingSource.DataSource = Me.Alumni_InfoBindingSource
        '
        'expiredCheckbox
        '
        Me.expiredCheckbox.AutoSize = True
        Me.expiredCheckbox.Location = New System.Drawing.Point(479, 132)
        Me.expiredCheckbox.Name = "expiredCheckbox"
        Me.expiredCheckbox.Size = New System.Drawing.Size(15, 14)
        Me.expiredCheckbox.TabIndex = 3
        Me.expiredCheckbox.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToPreviousMenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(609, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackToPreviousMenuToolStripMenuItem
        '
        Me.BackToPreviousMenuToolStripMenuItem.Name = "BackToPreviousMenuToolStripMenuItem"
        Me.BackToPreviousMenuToolStripMenuItem.Size = New System.Drawing.Size(140, 20)
        Me.BackToPreviousMenuToolStripMenuItem.Text = "Back to Previous Menu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(384, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Click to see who has an expired account:"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ExpiredMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 312)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.expiredCheckbox)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.expiredLstBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ExpiredMembers"
        Me.Text = "ExpiredMembers"
        CType(Me.NoSuchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alumni_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumniInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumniInfoDonationDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NoSuchDataSet As NoSuchDataSet
    Friend WithEvents Alumni_InfoBindingSource As BindingSource
    Friend WithEvents Alumni_InfoTableAdapter As NoSuchDataSetTableAdapters.Alumni_InfoTableAdapter
    Friend WithEvents TableAdapterManager As NoSuchDataSetTableAdapters.TableAdapterManager
    Friend WithEvents expiredLstBox As ListBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Donation_DetailsTableAdapter As NoSuchDataSetTableAdapters.Donation_DetailsTableAdapter
    Friend WithEvents AlumniInfoDonationDetailsBindingSource As BindingSource
    Friend WithEvents AlumniInfoBindingSource As BindingSource
    Friend WithEvents expiredCheckbox As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToPreviousMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
