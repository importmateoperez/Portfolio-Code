<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddEditDonation
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
        Dim Donation_IDLabel As System.Windows.Forms.Label
        Dim Member_IDLabel As System.Windows.Forms.Label
        Dim Donation_AmountLabel As System.Windows.Forms.Label
        Dim Record_DateLabel1 As System.Windows.Forms.Label
        Dim Account_IDLabel As System.Windows.Forms.Label
        Dim Account_IDLabel1 As System.Windows.Forms.Label
        Dim Member_IDLabel1 As System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BackToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoSuchDataSet = New NoSuchDatabase.NoSuchDataSet()
        Me.Donation_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Donation_DetailsTableAdapter = New NoSuchDatabase.NoSuchDataSetTableAdapters.Donation_DetailsTableAdapter()
        Me.TableAdapterManager = New NoSuchDatabase.NoSuchDataSetTableAdapters.TableAdapterManager()
        Me.Donation_ID = New System.Windows.Forms.TextBox()
        Me.Donation_Amount = New System.Windows.Forms.TextBox()
        Me.Member_IDTextBox = New System.Windows.Forms.TextBox()
        Me.DonorAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Donor_AccountsTableAdapter = New NoSuchDatabase.NoSuchDataSetTableAdapters.Donor_AccountsTableAdapter()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Account_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Account_IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Member_IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.Alumni_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Alumni_InfoTableAdapter = New NoSuchDatabase.NoSuchDataSetTableAdapters.Alumni_InfoTableAdapter()
        Me.AlumniInfoDonationDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Record_DateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Donation_IDLabel = New System.Windows.Forms.Label()
        Member_IDLabel = New System.Windows.Forms.Label()
        Donation_AmountLabel = New System.Windows.Forms.Label()
        Record_DateLabel1 = New System.Windows.Forms.Label()
        Account_IDLabel = New System.Windows.Forms.Label()
        Account_IDLabel1 = New System.Windows.Forms.Label()
        Member_IDLabel1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.NoSuchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Donation_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonorAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Alumni_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumniInfoDonationDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Donation_IDLabel
        '
        Donation_IDLabel.AutoSize = True
        Donation_IDLabel.Location = New System.Drawing.Point(41, 87)
        Donation_IDLabel.Name = "Donation_IDLabel"
        Donation_IDLabel.Size = New System.Drawing.Size(67, 13)
        Donation_IDLabel.TabIndex = 8
        Donation_IDLabel.Text = "Donation ID:"
        '
        'Member_IDLabel
        '
        Member_IDLabel.AutoSize = True
        Member_IDLabel.Location = New System.Drawing.Point(41, 139)
        Member_IDLabel.Name = "Member_IDLabel"
        Member_IDLabel.Size = New System.Drawing.Size(62, 13)
        Member_IDLabel.TabIndex = 12
        Member_IDLabel.Text = "Member ID:"
        '
        'Donation_AmountLabel
        '
        Donation_AmountLabel.AutoSize = True
        Donation_AmountLabel.Location = New System.Drawing.Point(41, 191)
        Donation_AmountLabel.Name = "Donation_AmountLabel"
        Donation_AmountLabel.Size = New System.Drawing.Size(92, 13)
        Donation_AmountLabel.TabIndex = 16
        Donation_AmountLabel.Text = "Donation Amount:"
        '
        'Record_DateLabel1
        '
        Record_DateLabel1.AutoSize = True
        Record_DateLabel1.Location = New System.Drawing.Point(41, 113)
        Record_DateLabel1.Name = "Record_DateLabel1"
        Record_DateLabel1.Size = New System.Drawing.Size(71, 13)
        Record_DateLabel1.TabIndex = 19
        Record_DateLabel1.Text = "Record Date:"
        '
        'Account_IDLabel
        '
        Account_IDLabel.AutoSize = True
        Account_IDLabel.Location = New System.Drawing.Point(41, 166)
        Account_IDLabel.Name = "Account_IDLabel"
        Account_IDLabel.Size = New System.Drawing.Size(64, 13)
        Account_IDLabel.TabIndex = 22
        Account_IDLabel.Text = "Account ID:"
        '
        'Account_IDLabel1
        '
        Account_IDLabel1.AutoSize = True
        Account_IDLabel1.Location = New System.Drawing.Point(24, 325)
        Account_IDLabel1.Name = "Account_IDLabel1"
        Account_IDLabel1.Size = New System.Drawing.Size(64, 13)
        Account_IDLabel1.TabIndex = 23
        Account_IDLabel1.Text = "Account ID:"
        '
        'Member_IDLabel1
        '
        Member_IDLabel1.AutoSize = True
        Member_IDLabel1.Location = New System.Drawing.Point(20, 322)
        Member_IDLabel1.Name = "Member_IDLabel1"
        Member_IDLabel1.Size = New System.Drawing.Size(62, 13)
        Member_IDLabel1.TabIndex = 1
        Member_IDLabel1.Text = "Member ID:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(27, 387)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(131, 40)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save and Close"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(223, 387)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(131, 40)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToMainMenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(852, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackToMainMenuToolStripMenuItem
        '
        Me.BackToMainMenuToolStripMenuItem.Name = "BackToMainMenuToolStripMenuItem"
        Me.BackToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(140, 20)
        Me.BackToMainMenuToolStripMenuItem.Text = "Back to Previous Menu"
        '
        'NoSuchDataSet
        '
        Me.NoSuchDataSet.DataSetName = "NoSuchDataSet"
        Me.NoSuchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Donation_DetailsBindingSource
        '
        Me.Donation_DetailsBindingSource.DataMember = "Donation_Details"
        Me.Donation_DetailsBindingSource.DataSource = Me.NoSuchDataSet
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
        'Donation_ID
        '
        Me.Donation_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Donation_DetailsBindingSource, "Donation_ID", True))
        Me.Donation_ID.Location = New System.Drawing.Point(139, 84)
        Me.Donation_ID.Name = "Donation_ID"
        Me.Donation_ID.ReadOnly = True
        Me.Donation_ID.Size = New System.Drawing.Size(200, 20)
        Me.Donation_ID.TabIndex = 9
        '
        'Donation_Amount
        '
        Me.Donation_Amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Donation_DetailsBindingSource, "Donation_Amount", True))
        Me.Donation_Amount.Location = New System.Drawing.Point(139, 188)
        Me.Donation_Amount.Name = "Donation_Amount"
        Me.Donation_Amount.Size = New System.Drawing.Size(200, 20)
        Me.Donation_Amount.TabIndex = 17
        '
        'Member_IDTextBox
        '
        Me.Member_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Donation_DetailsBindingSource, "Member_ID", True))
        Me.Member_IDTextBox.Location = New System.Drawing.Point(139, 136)
        Me.Member_IDTextBox.Name = "Member_IDTextBox"
        Me.Member_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Member_IDTextBox.TabIndex = 13
        '
        'DonorAccountsBindingSource
        '
        Me.DonorAccountsBindingSource.DataMember = "Donor_Accounts"
        Me.DonorAccountsBindingSource.DataSource = Me.NoSuchDataSet
        '
        'Donor_AccountsTableAdapter
        '
        Me.Donor_AccountsTableAdapter.ClearBeforeFill = True
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.DonorAccountsBindingSource
        Me.ListBox1.DisplayMember = "Account_Name"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(22, 48)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(182, 251)
        Me.ListBox1.TabIndex = 22
        '
        'Account_IDTextBox
        '
        Me.Account_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Donation_DetailsBindingSource, "Account_ID", True))
        Me.Account_IDTextBox.Location = New System.Drawing.Point(139, 163)
        Me.Account_IDTextBox.Name = "Account_IDTextBox"
        Me.Account_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Account_IDTextBox.TabIndex = 23
        '
        'Account_IDTextBox1
        '
        Me.Account_IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DonorAccountsBindingSource, "Account_ID", True))
        Me.Account_IDTextBox1.Enabled = False
        Me.Account_IDTextBox1.Location = New System.Drawing.Point(94, 322)
        Me.Account_IDTextBox1.Name = "Account_IDTextBox1"
        Me.Account_IDTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.Account_IDTextBox1.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Account_IDLabel1)
        Me.GroupBox1.Controls.Add(Me.Account_IDTextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(594, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 375)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account ID Lookup"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Member_IDLabel1)
        Me.GroupBox2.Controls.Add(Me.Member_IDTextBox1)
        Me.GroupBox2.Controls.Add(Me.ListBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(360, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(213, 375)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Member ID Lookup"
        '
        'Member_IDTextBox1
        '
        Me.Member_IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alumni_InfoBindingSource, "Member_ID", True))
        Me.Member_IDTextBox1.Enabled = False
        Me.Member_IDTextBox1.Location = New System.Drawing.Point(88, 319)
        Me.Member_IDTextBox1.Name = "Member_IDTextBox1"
        Me.Member_IDTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.Member_IDTextBox1.TabIndex = 2
        '
        'Alumni_InfoBindingSource
        '
        Me.Alumni_InfoBindingSource.DataMember = "Alumni_Info"
        Me.Alumni_InfoBindingSource.DataSource = Me.NoSuchDataSet
        '
        'ListBox2
        '
        Me.ListBox2.DataSource = Me.Alumni_InfoBindingSource
        Me.ListBox2.DisplayMember = "Last_Name"
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(16, 48)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(181, 251)
        Me.ListBox2.TabIndex = 0
        '
        'Alumni_InfoTableAdapter
        '
        Me.Alumni_InfoTableAdapter.ClearBeforeFill = True
        '
        'AlumniInfoDonationDetailsBindingSource
        '
        Me.AlumniInfoDonationDetailsBindingSource.DataMember = "Alumni_InfoDonation_Details"
        Me.AlumniInfoDonationDetailsBindingSource.DataSource = Me.Alumni_InfoBindingSource
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(22, 163)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 25)
        Me.Label12.TabIndex = 105
        Me.Label12.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(22, 136)
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
        Me.Label2.Location = New System.Drawing.Point(22, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 25)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(41, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 13)
        Me.Label13.TabIndex = 109
        Me.Label13.Text = "Required fields"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(113, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 25)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(22, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 25)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "*"
        '
        'Record_DateMaskedTextBox
        '
        Me.Record_DateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Donation_DetailsBindingSource, "Record_Date", True))
        Me.Record_DateMaskedTextBox.Location = New System.Drawing.Point(139, 110)
        Me.Record_DateMaskedTextBox.Mask = "00/00/0000"
        Me.Record_DateMaskedTextBox.Name = "Record_DateMaskedTextBox"
        Me.Record_DateMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Record_DateMaskedTextBox.TabIndex = 111
        Me.Record_DateMaskedTextBox.ValidatingType = GetType(Date)
        '
        'frmAddEditDonation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 450)
        Me.Controls.Add(Me.Record_DateMaskedTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Account_IDLabel)
        Me.Controls.Add(Me.Account_IDTextBox)
        Me.Controls.Add(Record_DateLabel1)
        Me.Controls.Add(Donation_IDLabel)
        Me.Controls.Add(Me.Donation_ID)
        Me.Controls.Add(Member_IDLabel)
        Me.Controls.Add(Me.Member_IDTextBox)
        Me.Controls.Add(Donation_AmountLabel)
        Me.Controls.Add(Me.Donation_Amount)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAddEditDonation"
        Me.Text = "Add/Edit Donation"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.NoSuchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Donation_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonorAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Alumni_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumniInfoDonationDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToMainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NoSuchDataSet As NoSuchDataSet
    Friend WithEvents Donation_DetailsBindingSource As BindingSource
    Friend WithEvents Donation_DetailsTableAdapter As NoSuchDataSetTableAdapters.Donation_DetailsTableAdapter
    Friend WithEvents TableAdapterManager As NoSuchDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Donation_ID As TextBox
    Friend WithEvents Donation_Amount As TextBox
    Friend WithEvents Member_IDTextBox As TextBox
    Friend WithEvents DonorAccountsBindingSource As BindingSource
    Friend WithEvents Donor_AccountsTableAdapter As NoSuchDataSetTableAdapters.Donor_AccountsTableAdapter
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Account_IDTextBox As TextBox
    Friend WithEvents Account_IDTextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Alumni_InfoBindingSource As BindingSource
    Friend WithEvents Alumni_InfoTableAdapter As NoSuchDataSetTableAdapters.Alumni_InfoTableAdapter
    Friend WithEvents Member_IDTextBox1 As TextBox
    Friend WithEvents AlumniInfoDonationDetailsBindingSource As BindingSource
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Record_DateMaskedTextBox As MaskedTextBox
End Class
