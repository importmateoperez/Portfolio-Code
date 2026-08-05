<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDonation
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
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Account_NameLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvDonations = New System.Windows.Forms.DataGridView()
        Me.DonationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecordDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonationAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Donation_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NoSuchDataSet = New NoSuchDatabase.NoSuchDataSet()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BackToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAddDonation = New System.Windows.Forms.Button()
        Me.btnEditDonation = New System.Windows.Forms.Button()
        Me.btnDeleteDonation = New System.Windows.Forms.Button()
        Me.Donation_DetailsTableAdapter = New NoSuchDatabase.NoSuchDataSetTableAdapters.Donation_DetailsTableAdapter()
        Me.TableAdapterManager = New NoSuchDatabase.NoSuchDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.AlumniInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Account_NameTextBox = New System.Windows.Forms.TextBox()
        Me.DonorAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Donor_AccountsTableAdapter = New NoSuchDatabase.NoSuchDataSetTableAdapters.Donor_AccountsTableAdapter()
        Me.Alumni_InfoTableAdapter = New NoSuchDatabase.NoSuchDataSetTableAdapters.Alumni_InfoTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.minAmounttxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.maxAmounttxt = New System.Windows.Forms.TextBox()
        Me.accIDtxt = New System.Windows.Forms.TextBox()
        Me.memIDtxt = New System.Windows.Forms.TextBox()
        Me.endDatetxt = New System.Windows.Forms.TextBox()
        Me.startDatetxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Account_NameLabel = New System.Windows.Forms.Label()
        CType(Me.dgvDonations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Donation_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoSuchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AlumniInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DonorAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(45, 181)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 1
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(44, 207)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 3
        Last_NameLabel.Text = "Last Name:"
        '
        'Account_NameLabel
        '
        Account_NameLabel.AutoSize = True
        Account_NameLabel.Location = New System.Drawing.Point(90, 175)
        Account_NameLabel.Name = "Account_NameLabel"
        Account_NameLabel.Size = New System.Drawing.Size(81, 13)
        Account_NameLabel.TabIndex = 1
        Account_NameLabel.Text = "Account Name:"

        '
        'dgvDonations
        '
        Me.dgvDonations.AutoGenerateColumns = False
        Me.dgvDonations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDonations.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DonationIDDataGridViewTextBoxColumn, Me.RecordDateDataGridViewTextBoxColumn, Me.MemberIDDataGridViewTextBoxColumn, Me.AccountIDDataGridViewTextBoxColumn, Me.DonationAmountDataGridViewTextBoxColumn})
        Me.dgvDonations.DataSource = Me.Donation_DetailsBindingSource
        Me.dgvDonations.Location = New System.Drawing.Point(12, 50)
        Me.dgvDonations.Name = "dgvDonations"
        Me.dgvDonations.Size = New System.Drawing.Size(541, 281)
        Me.dgvDonations.TabIndex = 0
        '
        'DonationIDDataGridViewTextBoxColumn
        '
        Me.DonationIDDataGridViewTextBoxColumn.DataPropertyName = "Donation_ID"
        Me.DonationIDDataGridViewTextBoxColumn.HeaderText = "Donation_ID"
        Me.DonationIDDataGridViewTextBoxColumn.Name = "DonationIDDataGridViewTextBoxColumn"
        '
        'RecordDateDataGridViewTextBoxColumn
        '
        Me.RecordDateDataGridViewTextBoxColumn.DataPropertyName = "Record_Date"
        Me.RecordDateDataGridViewTextBoxColumn.HeaderText = "Record_Date"
        Me.RecordDateDataGridViewTextBoxColumn.Name = "RecordDateDataGridViewTextBoxColumn"
        '
        'MemberIDDataGridViewTextBoxColumn
        '
        Me.MemberIDDataGridViewTextBoxColumn.DataPropertyName = "Member_ID"
        Me.MemberIDDataGridViewTextBoxColumn.HeaderText = "Member_ID"
        Me.MemberIDDataGridViewTextBoxColumn.Name = "MemberIDDataGridViewTextBoxColumn"
        '
        'AccountIDDataGridViewTextBoxColumn
        '
        Me.AccountIDDataGridViewTextBoxColumn.DataPropertyName = "Account_ID"
        Me.AccountIDDataGridViewTextBoxColumn.HeaderText = "Account_ID"
        Me.AccountIDDataGridViewTextBoxColumn.Name = "AccountIDDataGridViewTextBoxColumn"
        '
        'DonationAmountDataGridViewTextBoxColumn
        '
        Me.DonationAmountDataGridViewTextBoxColumn.DataPropertyName = "Donation_Amount"
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.DonationAmountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.DonationAmountDataGridViewTextBoxColumn.HeaderText = "Donation_Amount"
        Me.DonationAmountDataGridViewTextBoxColumn.Name = "DonationAmountDataGridViewTextBoxColumn"
        '
        'Donation_DetailsBindingSource
        '
        Me.Donation_DetailsBindingSource.DataMember = "Donation_Details"
        Me.Donation_DetailsBindingSource.DataSource = Me.NoSuchDataSet
        '
        'NoSuchDataSet
        '
        Me.NoSuchDataSet.DataSetName = "NoSuchDataSet"
        Me.NoSuchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToMainMenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(992, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackToMainMenuToolStripMenuItem
        '
        Me.BackToMainMenuToolStripMenuItem.Name = "BackToMainMenuToolStripMenuItem"
        Me.BackToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.BackToMainMenuToolStripMenuItem.Text = "Back to Main Menu"
        '
        'btnAddDonation
        '
        Me.btnAddDonation.Location = New System.Drawing.Point(56, 484)
        Me.btnAddDonation.Name = "btnAddDonation"
        Me.btnAddDonation.Size = New System.Drawing.Size(109, 50)
        Me.btnAddDonation.TabIndex = 2
        Me.btnAddDonation.Text = "Add Donation"
        Me.btnAddDonation.UseVisualStyleBackColor = True
        '
        'btnEditDonation
        '
        Me.btnEditDonation.Location = New System.Drawing.Point(218, 484)
        Me.btnEditDonation.Name = "btnEditDonation"
        Me.btnEditDonation.Size = New System.Drawing.Size(109, 50)
        Me.btnEditDonation.TabIndex = 3
        Me.btnEditDonation.Text = "Edit Donation"
        Me.btnEditDonation.UseVisualStyleBackColor = True
        '
        'btnDeleteDonation
        '
        Me.btnDeleteDonation.Location = New System.Drawing.Point(384, 484)
        Me.btnDeleteDonation.Name = "btnDeleteDonation"
        Me.btnDeleteDonation.Size = New System.Drawing.Size(109, 50)
        Me.btnDeleteDonation.TabIndex = 4
        Me.btnDeleteDonation.Text = "Delete Donation"
        Me.btnDeleteDonation.UseVisualStyleBackColor = True
        '
        'Donation_DetailsTableAdapter
        '
        Me.Donation_DetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Alumni_InfoTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Donation_DetailsTableAdapter = Me.Donation_DetailsTableAdapter
        Me.TableAdapterManager.Donor_AccountsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NoSuchDatabase.NoSuchDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Last_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Last_NameTextBox)
        Me.GroupBox1.Controls.Add(First_NameLabel)
        Me.GroupBox1.Controls.Add(Me.First_NameTextBox)
        Me.GroupBox1.Controls.Add(Me.ListBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(626, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 239)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Member ID Lookup"
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumniInfoBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Enabled = False
        Me.Last_NameTextBox.Location = New System.Drawing.Point(111, 204)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Last_NameTextBox.TabIndex = 4
        '
        'AlumniInfoBindingSource
        '
        Me.AlumniInfoBindingSource.DataMember = "Alumni_Info"
        Me.AlumniInfoBindingSource.DataSource = Me.NoSuchDataSet
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumniInfoBindingSource, "First_Name", True))
        Me.First_NameTextBox.Enabled = False
        Me.First_NameTextBox.Location = New System.Drawing.Point(111, 178)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.First_NameTextBox.TabIndex = 2
        '
        'ListBox2
        '
        Me.ListBox2.DataSource = Me.AlumniInfoBindingSource
        Me.ListBox2.DisplayMember = "Member_ID"
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(6, 40)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(242, 121)
        Me.ListBox2.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Account_NameLabel)
        Me.GroupBox2.Controls.Add(Me.Account_NameTextBox)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(626, 323)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(271, 230)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Account ID Lookup"
        '
        'Account_NameTextBox
        '
        Me.Account_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DonorAccountsBindingSource, "Account_Name", True))
        Me.Account_NameTextBox.Enabled = False
        Me.Account_NameTextBox.Location = New System.Drawing.Point(6, 191)
        Me.Account_NameTextBox.Name = "Account_NameTextBox"
        Me.Account_NameTextBox.Size = New System.Drawing.Size(242, 20)
        Me.Account_NameTextBox.TabIndex = 2
        '
        'DonorAccountsBindingSource
        '
        Me.DonorAccountsBindingSource.DataMember = "Donor_Accounts"
        Me.DonorAccountsBindingSource.DataSource = Me.NoSuchDataSet
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.DonorAccountsBindingSource
        Me.ListBox1.DisplayMember = "Account_ID"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 40)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(242, 121)
        Me.ListBox1.TabIndex = 0
        '
        'Donor_AccountsTableAdapter
        '
        Me.Donor_AccountsTableAdapter.ClearBeforeFill = True
        '
        'Alumni_InfoTableAdapter
        '
        Me.Alumni_InfoTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.minAmounttxt)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.maxAmounttxt)
        Me.GroupBox3.Controls.Add(Me.accIDtxt)
        Me.GroupBox3.Controls.Add(Me.memIDtxt)
        Me.GroupBox3.Controls.Add(Me.endDatetxt)
        Me.GroupBox3.Controls.Add(Me.startDatetxt)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 346)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(553, 121)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search for items"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(372, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Min Amount:"
        '
        'minAmounttxt
        '
        Me.minAmounttxt.Location = New System.Drawing.Point(447, 32)
        Me.minAmounttxt.Name = "minAmounttxt"
        Me.minAmounttxt.Size = New System.Drawing.Size(100, 20)
        Me.minAmounttxt.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(372, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Max Amount:"
        '
        'maxAmounttxt
        '
        Me.maxAmounttxt.Location = New System.Drawing.Point(447, 67)
        Me.maxAmounttxt.Name = "maxAmounttxt"
        Me.maxAmounttxt.Size = New System.Drawing.Size(100, 20)
        Me.maxAmounttxt.TabIndex = 8
        '
        'accIDtxt
        '
        Me.accIDtxt.Location = New System.Drawing.Point(78, 71)
        Me.accIDtxt.Name = "accIDtxt"
        Me.accIDtxt.Size = New System.Drawing.Size(100, 20)
        Me.accIDtxt.TabIndex = 7
        '
        'memIDtxt
        '
        Me.memIDtxt.Location = New System.Drawing.Point(78, 28)
        Me.memIDtxt.Name = "memIDtxt"
        Me.memIDtxt.Size = New System.Drawing.Size(100, 20)
        Me.memIDtxt.TabIndex = 6
        '
        'endDatetxt
        '
        Me.endDatetxt.Location = New System.Drawing.Point(259, 71)
        Me.endDatetxt.Name = "endDatetxt"
        Me.endDatetxt.Size = New System.Drawing.Size(100, 20)
        Me.endDatetxt.TabIndex = 5
        '
        'startDatetxt
        '
        Me.startDatetxt.Location = New System.Drawing.Point(259, 31)
        Me.startDatetxt.Name = "startDatetxt"
        Me.startDatetxt.Size = New System.Drawing.Size(100, 20)
        Me.startDatetxt.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(203, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "End Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(203, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Start Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Account ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Member ID:"
        '
        'frmDonation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 558)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDeleteDonation)
        Me.Controls.Add(Me.btnEditDonation)
        Me.Controls.Add(Me.btnAddDonation)
        Me.Controls.Add(Me.dgvDonations)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDonation"
        Me.Text = "Donation Manager"
        CType(Me.dgvDonations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Donation_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoSuchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AlumniInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DonorAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDonations As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToMainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAddDonation As Button
    Friend WithEvents btnEditDonation As Button
    Friend WithEvents btnDeleteDonation As Button
    Friend WithEvents NoSuchDataSet As NoSuchDataSet
    Friend WithEvents Donation_DetailsBindingSource As BindingSource
    Friend WithEvents Donation_DetailsTableAdapter As NoSuchDataSetTableAdapters.Donation_DetailsTableAdapter
    Friend WithEvents TableAdapterManager As NoSuchDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DonorAccountsBindingSource As BindingSource
    Friend WithEvents Donor_AccountsTableAdapter As NoSuchDataSetTableAdapters.Donor_AccountsTableAdapter
    Friend WithEvents AlumniInfoBindingSource As BindingSource
    Friend WithEvents Alumni_InfoTableAdapter As NoSuchDataSetTableAdapters.Alumni_InfoTableAdapter
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Account_NameTextBox As TextBox
    Friend WithEvents DonationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecordDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccountIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DonationAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents minAmounttxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents maxAmounttxt As TextBox
    Friend WithEvents accIDtxt As TextBox
    Friend WithEvents memIDtxt As TextBox
    Friend WithEvents endDatetxt As TextBox
    Friend WithEvents startDatetxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
