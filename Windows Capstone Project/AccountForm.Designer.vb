<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAccount
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
        Me.dgvAccounts = New System.Windows.Forms.DataGridView()
        Me.AccountIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Donor_AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NoSuchDataSet = New NoSuchDatabase.NoSuchDataSet()
        Me.btnAddRecord = New System.Windows.Forms.Button()
        Me.btnEditRecord = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.stripMenuReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.Donor_AccountsTableAdapter = New NoSuchDatabase.NoSuchDataSetTableAdapters.Donor_AccountsTableAdapter()
        Me.TableAdapterManager = New NoSuchDatabase.NoSuchDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.accfitler = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.accCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.accNotCheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Donor_AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoSuchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.AllowUserToDeleteRows = False
        Me.dgvAccounts.AllowUserToResizeColumns = False
        Me.dgvAccounts.AllowUserToResizeRows = False
        Me.dgvAccounts.AutoGenerateColumns = False
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccountIDDataGridViewTextBoxColumn, Me.AccountNameDataGridViewTextBoxColumn, Me.AccActiveDataGridViewCheckBoxColumn})
        Me.dgvAccounts.DataSource = Me.Donor_AccountsBindingSource
        Me.dgvAccounts.Location = New System.Drawing.Point(51, 64)
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.ReadOnly = True
        Me.dgvAccounts.Size = New System.Drawing.Size(344, 193)
        Me.dgvAccounts.TabIndex = 0
        '
        'AccountIDDataGridViewTextBoxColumn
        '
        Me.AccountIDDataGridViewTextBoxColumn.DataPropertyName = "Account_ID"
        Me.AccountIDDataGridViewTextBoxColumn.HeaderText = "Account_ID"
        Me.AccountIDDataGridViewTextBoxColumn.Name = "AccountIDDataGridViewTextBoxColumn"
        Me.AccountIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccountNameDataGridViewTextBoxColumn
        '
        Me.AccountNameDataGridViewTextBoxColumn.DataPropertyName = "Account_Name"
        Me.AccountNameDataGridViewTextBoxColumn.HeaderText = "Account_Name"
        Me.AccountNameDataGridViewTextBoxColumn.Name = "AccountNameDataGridViewTextBoxColumn"
        Me.AccountNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccActiveDataGridViewCheckBoxColumn
        '
        Me.AccActiveDataGridViewCheckBoxColumn.DataPropertyName = "Acc_Active"
        Me.AccActiveDataGridViewCheckBoxColumn.HeaderText = "Acc_Active"
        Me.AccActiveDataGridViewCheckBoxColumn.Name = "AccActiveDataGridViewCheckBoxColumn"
        Me.AccActiveDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Donor_AccountsBindingSource
        '
        Me.Donor_AccountsBindingSource.DataMember = "Donor_Accounts"
        Me.Donor_AccountsBindingSource.DataSource = Me.NoSuchDataSet
        '
        'NoSuchDataSet
        '
        Me.NoSuchDataSet.DataSetName = "NoSuchDataSet"
        Me.NoSuchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAddRecord
        '
        Me.btnAddRecord.Location = New System.Drawing.Point(51, 353)
        Me.btnAddRecord.Name = "btnAddRecord"
        Me.btnAddRecord.Size = New System.Drawing.Size(75, 42)
        Me.btnAddRecord.TabIndex = 1
        Me.btnAddRecord.Text = "Add Record"
        Me.btnAddRecord.UseVisualStyleBackColor = True
        '
        'btnEditRecord
        '
        Me.btnEditRecord.Location = New System.Drawing.Point(185, 353)
        Me.btnEditRecord.Name = "btnEditRecord"
        Me.btnEditRecord.Size = New System.Drawing.Size(75, 42)
        Me.btnEditRecord.TabIndex = 2
        Me.btnEditRecord.Text = "Edit Record"
        Me.btnEditRecord.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(320, 353)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 42)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stripMenuReturn})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'stripMenuReturn
        '
        Me.stripMenuReturn.Name = "stripMenuReturn"
        Me.stripMenuReturn.Size = New System.Drawing.Size(122, 20)
        Me.stripMenuReturn.Text = "Back to Main Menu"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Account Name:"
        '
        'accfitler
        '
        Me.accfitler.Location = New System.Drawing.Point(94, 55)
        Me.accfitler.Name = "accfitler"
        Me.accfitler.Size = New System.Drawing.Size(100, 20)
        Me.accfitler.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.accNotCheckBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.accCheckBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.accfitler)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(529, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 193)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search for items"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Account is active: "
        '
        'accCheckBox
        '
        Me.accCheckBox.AutoSize = True
        Me.accCheckBox.Location = New System.Drawing.Point(119, 105)
        Me.accCheckBox.Name = "accCheckBox"
        Me.accCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.accCheckBox.TabIndex = 9
        Me.accCheckBox.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Account is not active: "
        '
        'accNotCheckBox
        '
        Me.accNotCheckBox.AutoSize = True
        Me.accNotCheckBox.Location = New System.Drawing.Point(119, 138)
        Me.accNotCheckBox.Name = "accNotCheckBox"
        Me.accNotCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.accNotCheckBox.TabIndex = 11
        Me.accNotCheckBox.UseVisualStyleBackColor = True
        '
        'frmAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEditRecord)
        Me.Controls.Add(Me.btnAddRecord)
        Me.Controls.Add(Me.dgvAccounts)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAccount"
        Me.Text = "Account Manager"
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Donor_AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoSuchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAccounts As DataGridView
    Friend WithEvents btnAddRecord As Button
    Friend WithEvents btnEditRecord As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents stripMenuReturn As ToolStripMenuItem
    Friend WithEvents NoSuchDataSet As NoSuchDataSet
    Friend WithEvents Donor_AccountsBindingSource As BindingSource
    Friend WithEvents Donor_AccountsTableAdapter As NoSuchDataSetTableAdapters.Donor_AccountsTableAdapter
    Friend WithEvents TableAdapterManager As NoSuchDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AccountIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccountNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccActiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents accfitler As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents accCheckBox As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents accNotCheckBox As CheckBox
    Friend WithEvents Label3 As Label
End Class
