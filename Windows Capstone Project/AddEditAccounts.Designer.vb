<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Account_IDLabel As System.Windows.Forms.Label
        Dim Account_NameLabel As System.Windows.Forms.Label
        Dim Acc_ActiveLabel As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BackToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NoSuchDataSet = New NoSuchDatabase.NoSuchDataSet()
        Me.Donor_AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Donor_AccountsTableAdapter = New NoSuchDatabase.NoSuchDataSetTableAdapters.Donor_AccountsTableAdapter()
        Me.TableAdapterManager = New NoSuchDatabase.NoSuchDataSetTableAdapters.TableAdapterManager()
        Me.Account_ID = New System.Windows.Forms.TextBox()
        Me.Account_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Acc_ActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Account_IDLabel = New System.Windows.Forms.Label()
        Account_NameLabel = New System.Windows.Forms.Label()
        Acc_ActiveLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.NoSuchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Donor_AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Account_IDLabel
        '
        Account_IDLabel.AutoSize = True
        Account_IDLabel.Location = New System.Drawing.Point(229, 120)
        Account_IDLabel.Name = "Account_IDLabel"
        Account_IDLabel.Size = New System.Drawing.Size(64, 13)
        Account_IDLabel.TabIndex = 4
        Account_IDLabel.Text = "Account ID:"
        '
        'Account_NameLabel
        '
        Account_NameLabel.AutoSize = True
        Account_NameLabel.Location = New System.Drawing.Point(229, 146)
        Account_NameLabel.Name = "Account_NameLabel"
        Account_NameLabel.Size = New System.Drawing.Size(81, 13)
        Account_NameLabel.TabIndex = 6
        Account_NameLabel.Text = "Account Name:"
        '
        'Acc_ActiveLabel
        '
        Acc_ActiveLabel.AutoSize = True
        Acc_ActiveLabel.Location = New System.Drawing.Point(229, 174)
        Acc_ActiveLabel.Name = "Acc_ActiveLabel"
        Acc_ActiveLabel.Size = New System.Drawing.Size(62, 13)
        Acc_ActiveLabel.TabIndex = 8
        Acc_ActiveLabel.Text = "Acc Active:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToMainMenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(772, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackToMainMenuToolStripMenuItem
        '
        Me.BackToMainMenuToolStripMenuItem.Name = "BackToMainMenuToolStripMenuItem"
        Me.BackToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.BackToMainMenuToolStripMenuItem.Text = "Back to Main Menu"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(161, 250)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(128, 36)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save and Close"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(341, 250)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 36)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NoSuchDataSet
        '
        Me.NoSuchDataSet.DataSetName = "NoSuchDataSet"
        Me.NoSuchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Donor_AccountsBindingSource
        '
        Me.Donor_AccountsBindingSource.DataMember = "Donor_Accounts"
        Me.Donor_AccountsBindingSource.DataSource = Me.NoSuchDataSet
        '
        'Donor_AccountsTableAdapter
        '
        Me.Donor_AccountsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Alumni_InfoTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Donation_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Donor_AccountsTableAdapter = Me.Donor_AccountsTableAdapter
        Me.TableAdapterManager.UpdateOrder = NoSuchDatabase.NoSuchDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Account_ID
        '
        Me.Account_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Donor_AccountsBindingSource, "Account_ID", True))
        Me.Account_ID.Location = New System.Drawing.Point(316, 117)
        Me.Account_ID.Name = "Account_ID"
        Me.Account_ID.Size = New System.Drawing.Size(104, 20)
        Me.Account_ID.TabIndex = 5
        '
        'Account_NameTextBox
        '
        Me.Account_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Donor_AccountsBindingSource, "Account_Name", True))
        Me.Account_NameTextBox.Location = New System.Drawing.Point(316, 143)
        Me.Account_NameTextBox.Name = "Account_NameTextBox"
        Me.Account_NameTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Account_NameTextBox.TabIndex = 7
        '
        'Acc_ActiveCheckBox
        '
        Me.Acc_ActiveCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Donor_AccountsBindingSource, "Acc_Active", True))
        Me.Acc_ActiveCheckBox.Location = New System.Drawing.Point(316, 169)
        Me.Acc_ActiveCheckBox.Name = "Acc_ActiveCheckBox"
        Me.Acc_ActiveCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Acc_ActiveCheckBox.TabIndex = 9
        Me.Acc_ActiveCheckBox.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(233, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 13)
        Me.Label13.TabIndex = 105
        Me.Label13.Text = "Required fields"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(305, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 25)
        Me.Label12.TabIndex = 104
        Me.Label12.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(211, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 25)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(211, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 25)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "*"
        '
        'frmAddEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 334)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Account_IDLabel)
        Me.Controls.Add(Me.Account_ID)
        Me.Controls.Add(Account_NameLabel)
        Me.Controls.Add(Me.Account_NameTextBox)
        Me.Controls.Add(Acc_ActiveLabel)
        Me.Controls.Add(Me.Acc_ActiveCheckBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAddEdit"
        Me.Text = "Add/Edit Accounts"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.NoSuchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Donor_AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToMainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSave As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents NoSuchDataSet As NoSuchDataSet
    Friend WithEvents Donor_AccountsBindingSource As BindingSource
    Friend WithEvents Donor_AccountsTableAdapter As NoSuchDataSetTableAdapters.Donor_AccountsTableAdapter
    Friend WithEvents TableAdapterManager As NoSuchDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Account_ID As TextBox
    Friend WithEvents Account_NameTextBox As TextBox
    Friend WithEvents Acc_ActiveCheckBox As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
