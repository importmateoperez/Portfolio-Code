<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlumni
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
        Me.stripMenuReturn = New System.Windows.Forms.MenuStrip()
        Me.BackToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvAlumni = New System.Windows.Forms.DataGridView()
        Me.Alumni_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NoSuchDataSet = New NoSuchDatabase.NoSuchDataSet()
        Me.btnAddRecord = New System.Windows.Forms.Button()
        Me.btnEditRecord = New System.Windows.Forms.Button()
        Me.Alumni_InfoTableAdapter = New NoSuchDatabase.NoSuchDataSetTableAdapters.Alumni_InfoTableAdapter()
        Me.TableAdapterManager = New NoSuchDatabase.NoSuchDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.activeNotChecked = New System.Windows.Forms.CheckBox()
        Me.activeChecked = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.statetxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.citytxt = New System.Windows.Forms.TextBox()
        Me.majortxt = New System.Windows.Forms.TextBox()
        Me.firstNametxt = New System.Windows.Forms.TextBox()
        Me.lastNametxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.MemberIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalutationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZIPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobilePhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HomePhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MembershipRenewalDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FamilyInfoNotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiscNotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Degree1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Degree1GradDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Degree2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Degree2GradDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Degree3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Degree3GradDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Degree4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Degree4GradDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EducationalInfoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stripMenuReturn.SuspendLayout()
        CType(Me.dgvAlumni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alumni_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoSuchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'stripMenuReturn
        '
        Me.stripMenuReturn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToMainMenuToolStripMenuItem})
        Me.stripMenuReturn.Location = New System.Drawing.Point(0, 0)
        Me.stripMenuReturn.Name = "stripMenuReturn"
        Me.stripMenuReturn.Size = New System.Drawing.Size(1236, 24)
        Me.stripMenuReturn.TabIndex = 0
        Me.stripMenuReturn.Text = "MenuStrip1"
        '
        'BackToMainMenuToolStripMenuItem
        '
        Me.BackToMainMenuToolStripMenuItem.Name = "BackToMainMenuToolStripMenuItem"
        Me.BackToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.BackToMainMenuToolStripMenuItem.Text = "Back to Main Menu"
        '
        'dgvAlumni
        '
        Me.dgvAlumni.AutoGenerateColumns = False
        Me.dgvAlumni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlumni.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MemberIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MiddleNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.SalutationDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.ZIPDataGridViewTextBoxColumn, Me.MobilePhoneDataGridViewTextBoxColumn, Me.HomePhoneDataGridViewTextBoxColumn, Me.MembershipRenewalDateDataGridViewTextBoxColumn, Me.AccountActiveDataGridViewCheckBoxColumn, Me.FamilyInfoNotesDataGridViewTextBoxColumn, Me.MiscNotesDataGridViewTextBoxColumn, Me.Degree1DataGridViewTextBoxColumn, Me.Degree1GradDateDataGridViewTextBoxColumn, Me.Degree2DataGridViewTextBoxColumn, Me.Degree2GradDateDataGridViewTextBoxColumn, Me.Degree3DataGridViewTextBoxColumn, Me.Degree3GradDateDataGridViewTextBoxColumn, Me.Degree4DataGridViewTextBoxColumn, Me.Degree4GradDateDataGridViewTextBoxColumn, Me.EducationalInfoDataGridViewTextBoxColumn})
        Me.dgvAlumni.DataSource = Me.Alumni_InfoBindingSource
        Me.dgvAlumni.Location = New System.Drawing.Point(48, 85)
        Me.dgvAlumni.Name = "dgvAlumni"
        Me.dgvAlumni.Size = New System.Drawing.Size(1044, 211)
        Me.dgvAlumni.TabIndex = 1
        '
        'Alumni_InfoBindingSource
        '
        Me.Alumni_InfoBindingSource.DataMember = "Alumni_Info"
        Me.Alumni_InfoBindingSource.DataSource = Me.NoSuchDataSet
        '
        'NoSuchDataSet
        '
        Me.NoSuchDataSet.DataSetName = "NoSuchDataSet"
        Me.NoSuchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAddRecord
        '
        Me.btnAddRecord.Location = New System.Drawing.Point(48, 432)
        Me.btnAddRecord.Name = "btnAddRecord"
        Me.btnAddRecord.Size = New System.Drawing.Size(75, 55)
        Me.btnAddRecord.TabIndex = 2
        Me.btnAddRecord.Text = "Add Record"
        Me.btnAddRecord.UseVisualStyleBackColor = True
        '
        'btnEditRecord
        '
        Me.btnEditRecord.Location = New System.Drawing.Point(200, 432)
        Me.btnEditRecord.Name = "btnEditRecord"
        Me.btnEditRecord.Size = New System.Drawing.Size(75, 55)
        Me.btnEditRecord.TabIndex = 3
        Me.btnEditRecord.Text = "Edit Record"
        Me.btnEditRecord.UseVisualStyleBackColor = True
        '
        'Alumni_InfoTableAdapter
        '
        Me.Alumni_InfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Alumni_InfoTableAdapter = Me.Alumni_InfoTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Donation_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Donor_AccountsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NoSuchDatabase.NoSuchDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.activeNotChecked)
        Me.GroupBox1.Controls.Add(Me.activeChecked)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.statetxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.citytxt)
        Me.GroupBox1.Controls.Add(Me.majortxt)
        Me.GroupBox1.Controls.Add(Me.firstNametxt)
        Me.GroupBox1.Controls.Add(Me.lastNametxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(612, 364)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 165)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search for items"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(233, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Account is not active"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(233, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Account is active:"
        '
        'activeNotChecked
        '
        Me.activeNotChecked.AutoSize = True
        Me.activeNotChecked.Location = New System.Drawing.Point(346, 130)
        Me.activeNotChecked.Name = "activeNotChecked"
        Me.activeNotChecked.Size = New System.Drawing.Size(15, 14)
        Me.activeNotChecked.TabIndex = 14
        Me.activeNotChecked.UseVisualStyleBackColor = True
        '
        'activeChecked
        '
        Me.activeChecked.AutoSize = True
        Me.activeChecked.Location = New System.Drawing.Point(346, 102)
        Me.activeChecked.Name = "activeChecked"
        Me.activeChecked.Size = New System.Drawing.Size(15, 14)
        Me.activeChecked.TabIndex = 13
        Me.activeChecked.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(233, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Major:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(233, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "State:"
        '
        'statetxt
        '
        Me.statetxt.Location = New System.Drawing.Point(295, 41)
        Me.statetxt.Name = "statetxt"
        Me.statetxt.Size = New System.Drawing.Size(100, 20)
        Me.statetxt.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "City:"
        '
        'citytxt
        '
        Me.citytxt.Location = New System.Drawing.Point(86, 107)
        Me.citytxt.Name = "citytxt"
        Me.citytxt.Size = New System.Drawing.Size(100, 20)
        Me.citytxt.TabIndex = 8
        '
        'majortxt
        '
        Me.majortxt.Location = New System.Drawing.Point(295, 73)
        Me.majortxt.Name = "majortxt"
        Me.majortxt.Size = New System.Drawing.Size(100, 20)
        Me.majortxt.TabIndex = 7
        '
        'firstNametxt
        '
        Me.firstNametxt.Location = New System.Drawing.Point(86, 37)
        Me.firstNametxt.Name = "firstNametxt"
        Me.firstNametxt.Size = New System.Drawing.Size(100, 20)
        Me.firstNametxt.TabIndex = 5
        '
        'lastNametxt
        '
        Me.lastNametxt.Location = New System.Drawing.Point(86, 70)
        Me.lastNametxt.Name = "lastNametxt"
        Me.lastNametxt.Size = New System.Drawing.Size(100, 20)
        Me.lastNametxt.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "First Name:"
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(363, 432)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(75, 55)
        Me.btnReport.TabIndex = 5
        Me.btnReport.Text = "Membership Expired Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'MemberIDDataGridViewTextBoxColumn
        '
        Me.MemberIDDataGridViewTextBoxColumn.DataPropertyName = "Member_ID"
        Me.MemberIDDataGridViewTextBoxColumn.HeaderText = "Member_ID"
        Me.MemberIDDataGridViewTextBoxColumn.Name = "MemberIDDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'MiddleNameDataGridViewTextBoxColumn
        '
        Me.MiddleNameDataGridViewTextBoxColumn.DataPropertyName = "Middle_Name"
        Me.MiddleNameDataGridViewTextBoxColumn.HeaderText = "Middle_Name"
        Me.MiddleNameDataGridViewTextBoxColumn.Name = "MiddleNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'SalutationDataGridViewTextBoxColumn
        '
        Me.SalutationDataGridViewTextBoxColumn.DataPropertyName = "Salutation"
        Me.SalutationDataGridViewTextBoxColumn.HeaderText = "Salutation"
        Me.SalutationDataGridViewTextBoxColumn.Name = "SalutationDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        '
        'ZIPDataGridViewTextBoxColumn
        '
        Me.ZIPDataGridViewTextBoxColumn.DataPropertyName = "ZIP"
        Me.ZIPDataGridViewTextBoxColumn.HeaderText = "ZIP"
        Me.ZIPDataGridViewTextBoxColumn.Name = "ZIPDataGridViewTextBoxColumn"
        '
        'MobilePhoneDataGridViewTextBoxColumn
        '
        Me.MobilePhoneDataGridViewTextBoxColumn.DataPropertyName = "Mobile_Phone"
        Me.MobilePhoneDataGridViewTextBoxColumn.HeaderText = "Mobile_Phone"
        Me.MobilePhoneDataGridViewTextBoxColumn.Name = "MobilePhoneDataGridViewTextBoxColumn"
        '
        'HomePhoneDataGridViewTextBoxColumn
        '
        Me.HomePhoneDataGridViewTextBoxColumn.DataPropertyName = "Home_Phone"
        Me.HomePhoneDataGridViewTextBoxColumn.HeaderText = "Home_Phone"
        Me.HomePhoneDataGridViewTextBoxColumn.Name = "HomePhoneDataGridViewTextBoxColumn"
        '
        'MembershipRenewalDateDataGridViewTextBoxColumn
        '
        Me.MembershipRenewalDateDataGridViewTextBoxColumn.DataPropertyName = "Membership_Renewal_Date"
        Me.MembershipRenewalDateDataGridViewTextBoxColumn.HeaderText = "Membership_Renewal_Date"
        Me.MembershipRenewalDateDataGridViewTextBoxColumn.Name = "MembershipRenewalDateDataGridViewTextBoxColumn"
        '
        'AccountActiveDataGridViewCheckBoxColumn
        '
        Me.AccountActiveDataGridViewCheckBoxColumn.DataPropertyName = "Account_Active"
        Me.AccountActiveDataGridViewCheckBoxColumn.HeaderText = "Account_Active"
        Me.AccountActiveDataGridViewCheckBoxColumn.Name = "AccountActiveDataGridViewCheckBoxColumn"
        Me.AccountActiveDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'FamilyInfoNotesDataGridViewTextBoxColumn
        '
        Me.FamilyInfoNotesDataGridViewTextBoxColumn.DataPropertyName = "Family_Info_Notes"
        Me.FamilyInfoNotesDataGridViewTextBoxColumn.HeaderText = "Family_Info_Notes"
        Me.FamilyInfoNotesDataGridViewTextBoxColumn.Name = "FamilyInfoNotesDataGridViewTextBoxColumn"
        '
        'MiscNotesDataGridViewTextBoxColumn
        '
        Me.MiscNotesDataGridViewTextBoxColumn.DataPropertyName = "Misc_Notes"
        Me.MiscNotesDataGridViewTextBoxColumn.HeaderText = "Misc_Notes"
        Me.MiscNotesDataGridViewTextBoxColumn.Name = "MiscNotesDataGridViewTextBoxColumn"
        '
        'Degree1DataGridViewTextBoxColumn
        '
        Me.Degree1DataGridViewTextBoxColumn.DataPropertyName = "Degree_1"
        Me.Degree1DataGridViewTextBoxColumn.HeaderText = "Degree_1"
        Me.Degree1DataGridViewTextBoxColumn.Name = "Degree1DataGridViewTextBoxColumn"
        '
        'Degree1GradDateDataGridViewTextBoxColumn
        '
        Me.Degree1GradDateDataGridViewTextBoxColumn.DataPropertyName = "Degree_1_Grad_Date"
        Me.Degree1GradDateDataGridViewTextBoxColumn.HeaderText = "Degree_1_Grad_Date"
        Me.Degree1GradDateDataGridViewTextBoxColumn.Name = "Degree1GradDateDataGridViewTextBoxColumn"
        '
        'Degree2DataGridViewTextBoxColumn
        '
        Me.Degree2DataGridViewTextBoxColumn.DataPropertyName = "Degree_2"
        Me.Degree2DataGridViewTextBoxColumn.HeaderText = "Degree_2"
        Me.Degree2DataGridViewTextBoxColumn.Name = "Degree2DataGridViewTextBoxColumn"
        '
        'Degree2GradDateDataGridViewTextBoxColumn
        '
        Me.Degree2GradDateDataGridViewTextBoxColumn.DataPropertyName = "Degree_2_Grad_Date"
        Me.Degree2GradDateDataGridViewTextBoxColumn.HeaderText = "Degree_2_Grad_Date"
        Me.Degree2GradDateDataGridViewTextBoxColumn.Name = "Degree2GradDateDataGridViewTextBoxColumn"
        '
        'Degree3DataGridViewTextBoxColumn
        '
        Me.Degree3DataGridViewTextBoxColumn.DataPropertyName = "Degree_3"
        Me.Degree3DataGridViewTextBoxColumn.HeaderText = "Degree_3"
        Me.Degree3DataGridViewTextBoxColumn.Name = "Degree3DataGridViewTextBoxColumn"
        '
        'Degree3GradDateDataGridViewTextBoxColumn
        '
        Me.Degree3GradDateDataGridViewTextBoxColumn.DataPropertyName = "Degree_3_Grad_Date"
        Me.Degree3GradDateDataGridViewTextBoxColumn.HeaderText = "Degree_3_Grad_Date"
        Me.Degree3GradDateDataGridViewTextBoxColumn.Name = "Degree3GradDateDataGridViewTextBoxColumn"
        '
        'Degree4DataGridViewTextBoxColumn
        '
        Me.Degree4DataGridViewTextBoxColumn.DataPropertyName = "Degree_4"
        Me.Degree4DataGridViewTextBoxColumn.HeaderText = "Degree_4"
        Me.Degree4DataGridViewTextBoxColumn.Name = "Degree4DataGridViewTextBoxColumn"
        '
        'Degree4GradDateDataGridViewTextBoxColumn
        '
        Me.Degree4GradDateDataGridViewTextBoxColumn.DataPropertyName = "Degree_4_Grad_Date"
        Me.Degree4GradDateDataGridViewTextBoxColumn.HeaderText = "Degree_4_Grad_Date"
        Me.Degree4GradDateDataGridViewTextBoxColumn.Name = "Degree4GradDateDataGridViewTextBoxColumn"
        '
        'EducationalInfoDataGridViewTextBoxColumn
        '
        Me.EducationalInfoDataGridViewTextBoxColumn.DataPropertyName = "Educational_Info"
        Me.EducationalInfoDataGridViewTextBoxColumn.HeaderText = "Educational_Info"
        Me.EducationalInfoDataGridViewTextBoxColumn.Name = "EducationalInfoDataGridViewTextBoxColumn"
        '
        'frmAlumni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1236, 567)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEditRecord)
        Me.Controls.Add(Me.btnAddRecord)
        Me.Controls.Add(Me.dgvAlumni)
        Me.Controls.Add(Me.stripMenuReturn)
        Me.MainMenuStrip = Me.stripMenuReturn
        Me.Name = "frmAlumni"
        Me.Text = "Alumni Manager"
        Me.stripMenuReturn.ResumeLayout(False)
        Me.stripMenuReturn.PerformLayout()
        CType(Me.dgvAlumni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alumni_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoSuchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents stripMenuReturn As MenuStrip
    Friend WithEvents BackToMainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvAlumni As DataGridView
    Friend WithEvents btnAddRecord As Button
    Friend WithEvents btnEditRecord As Button
    Friend WithEvents NoSuchDataSet As NoSuchDataSet
    Friend WithEvents Alumni_InfoBindingSource As BindingSource
    Friend WithEvents Alumni_InfoTableAdapter As NoSuchDataSetTableAdapters.Alumni_InfoTableAdapter
    Friend WithEvents TableAdapterManager As NoSuchDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents statetxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents citytxt As TextBox
    Friend WithEvents majortxt As TextBox
    Friend WithEvents firstNametxt As TextBox
    Friend WithEvents lastNametxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents activeNotChecked As CheckBox
    Friend WithEvents activeChecked As CheckBox
    Friend WithEvents btnReport As Button
    Friend WithEvents MemberIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalutationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZIPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MobilePhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HomePhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MembershipRenewalDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccountActiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FamilyInfoNotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiscNotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Degree1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Degree1GradDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Degree2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Degree2GradDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Degree3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Degree3GradDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Degree4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Degree4GradDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EducationalInfoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
