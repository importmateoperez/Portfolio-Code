<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddEditAlumni
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
        Dim Member_IDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Middle_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim SalutationLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim Family_Info_NotesLabel As System.Windows.Forms.Label
        Dim Misc_NotesLabel As System.Windows.Forms.Label
        Dim Degree_1Label As System.Windows.Forms.Label
        Dim Degree_2Label As System.Windows.Forms.Label
        Dim Degree_3Label As System.Windows.Forms.Label
        Dim Degree_4Label As System.Windows.Forms.Label
        Dim Educational_InfoLabel As System.Windows.Forms.Label
        Dim Mobile_PhoneLabel1 As System.Windows.Forms.Label
        Dim Home_PhoneLabel1 As System.Windows.Forms.Label
        Dim ZIPLabel1 As System.Windows.Forms.Label
        Dim Degree_1_Grad_DateLabel As System.Windows.Forms.Label
        Dim Degree_2_Grad_DateLabel1 As System.Windows.Forms.Label
        Dim Degree_3_Grad_DateLabel1 As System.Windows.Forms.Label
        Dim Degree_4_Grad_DateLabel1 As System.Windows.Forms.Label
        Dim Membership_Renewal_DateLabel As System.Windows.Forms.Label
        Dim Account_ActiveLabel As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BackToPreviousMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpDegrees = New System.Windows.Forms.GroupBox()
        Me.Degree_4_Grad_DateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Alumni_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NoSuchDataSet = New NoSuchDatabase.NoSuchDataSet()
        Me.Degree_3_Grad_DateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Degree_2_Grad_DateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Degree_1_Grad_DateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Degree_1TextBox = New System.Windows.Forms.TextBox()
        Me.Educational_InfoTextBox = New System.Windows.Forms.TextBox()
        Me.Degree_4TextBox = New System.Windows.Forms.TextBox()
        Me.Degree_3TextBox = New System.Windows.Forms.TextBox()
        Me.Degree_2TextBox = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Alumni_InfoTableAdapter = New NoSuchDatabase.NoSuchDataSetTableAdapters.Alumni_InfoTableAdapter()
        Me.TableAdapterManager = New NoSuchDatabase.NoSuchDataSetTableAdapters.TableAdapterManager()
        Me.Member_ID = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Middle_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.SalutationTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.Family_Info_NotesTextBox = New System.Windows.Forms.TextBox()
        Me.Misc_NotesTextBox = New System.Windows.Forms.TextBox()
        Me.Mobile_PhoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Home_PhoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ZIPMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Membership_Renewal_DateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Account_ActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Member_IDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Middle_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        SalutationLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        Family_Info_NotesLabel = New System.Windows.Forms.Label()
        Misc_NotesLabel = New System.Windows.Forms.Label()
        Degree_1Label = New System.Windows.Forms.Label()
        Degree_2Label = New System.Windows.Forms.Label()
        Degree_3Label = New System.Windows.Forms.Label()
        Degree_4Label = New System.Windows.Forms.Label()
        Educational_InfoLabel = New System.Windows.Forms.Label()
        Mobile_PhoneLabel1 = New System.Windows.Forms.Label()
        Home_PhoneLabel1 = New System.Windows.Forms.Label()
        ZIPLabel1 = New System.Windows.Forms.Label()
        Degree_1_Grad_DateLabel = New System.Windows.Forms.Label()
        Degree_2_Grad_DateLabel1 = New System.Windows.Forms.Label()
        Degree_3_Grad_DateLabel1 = New System.Windows.Forms.Label()
        Degree_4_Grad_DateLabel1 = New System.Windows.Forms.Label()
        Membership_Renewal_DateLabel = New System.Windows.Forms.Label()
        Account_ActiveLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.grpDegrees.SuspendLayout()
        CType(Me.Alumni_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoSuchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Member_IDLabel
        '
        Member_IDLabel.AutoSize = True
        Member_IDLabel.Location = New System.Drawing.Point(68, 83)
        Member_IDLabel.Name = "Member_IDLabel"
        Member_IDLabel.Size = New System.Drawing.Size(62, 13)
        Member_IDLabel.TabIndex = 34
        Member_IDLabel.Text = "Member ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(68, 109)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 36
        First_NameLabel.Text = "First Name:"
        '
        'Middle_NameLabel
        '
        Middle_NameLabel.AutoSize = True
        Middle_NameLabel.Location = New System.Drawing.Point(68, 135)
        Middle_NameLabel.Name = "Middle_NameLabel"
        Middle_NameLabel.Size = New System.Drawing.Size(72, 13)
        Middle_NameLabel.TabIndex = 38
        Middle_NameLabel.Text = "Middle Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(68, 161)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 40
        Last_NameLabel.Text = "Last Name:"
        '
        'SalutationLabel
        '
        SalutationLabel.AutoSize = True
        SalutationLabel.Location = New System.Drawing.Point(68, 187)
        SalutationLabel.Name = "SalutationLabel"
        SalutationLabel.Size = New System.Drawing.Size(57, 13)
        SalutationLabel.TabIndex = 42
        SalutationLabel.Text = "Salutation:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(68, 213)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 44
        AddressLabel.Text = "Address:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(68, 239)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 46
        CityLabel.Text = "City:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(68, 265)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(35, 13)
        StateLabel.TabIndex = 48
        StateLabel.Text = "State:"
        '
        'Family_Info_NotesLabel
        '
        Family_Info_NotesLabel.AutoSize = True
        Family_Info_NotesLabel.Location = New System.Drawing.Point(68, 370)
        Family_Info_NotesLabel.Name = "Family_Info_NotesLabel"
        Family_Info_NotesLabel.Size = New System.Drawing.Size(91, 13)
        Family_Info_NotesLabel.TabIndex = 60
        Family_Info_NotesLabel.Text = "Family Info Notes:"
        '
        'Misc_NotesLabel
        '
        Misc_NotesLabel.AutoSize = True
        Misc_NotesLabel.Location = New System.Drawing.Point(68, 396)
        Misc_NotesLabel.Name = "Misc_NotesLabel"
        Misc_NotesLabel.Size = New System.Drawing.Size(63, 13)
        Misc_NotesLabel.TabIndex = 62
        Misc_NotesLabel.Text = "Misc Notes:"
        '
        'Degree_1Label
        '
        Degree_1Label.AutoSize = True
        Degree_1Label.Location = New System.Drawing.Point(84, 100)
        Degree_1Label.Name = "Degree_1Label"
        Degree_1Label.Size = New System.Drawing.Size(54, 13)
        Degree_1Label.TabIndex = 64
        Degree_1Label.Text = "Degree 1:"
        '
        'Degree_2Label
        '
        Degree_2Label.AutoSize = True
        Degree_2Label.Location = New System.Drawing.Point(84, 152)
        Degree_2Label.Name = "Degree_2Label"
        Degree_2Label.Size = New System.Drawing.Size(54, 13)
        Degree_2Label.TabIndex = 68
        Degree_2Label.Text = "Degree 2:"
        '
        'Degree_3Label
        '
        Degree_3Label.AutoSize = True
        Degree_3Label.Location = New System.Drawing.Point(84, 204)
        Degree_3Label.Name = "Degree_3Label"
        Degree_3Label.Size = New System.Drawing.Size(54, 13)
        Degree_3Label.TabIndex = 72
        Degree_3Label.Text = "Degree 3:"
        '
        'Degree_4Label
        '
        Degree_4Label.AutoSize = True
        Degree_4Label.Location = New System.Drawing.Point(84, 256)
        Degree_4Label.Name = "Degree_4Label"
        Degree_4Label.Size = New System.Drawing.Size(54, 13)
        Degree_4Label.TabIndex = 76
        Degree_4Label.Text = "Degree 4:"
        '
        'Educational_InfoLabel
        '
        Educational_InfoLabel.AutoSize = True
        Educational_InfoLabel.Location = New System.Drawing.Point(84, 308)
        Educational_InfoLabel.Name = "Educational_InfoLabel"
        Educational_InfoLabel.Size = New System.Drawing.Size(87, 13)
        Educational_InfoLabel.TabIndex = 80
        Educational_InfoLabel.Text = "Educational Info:"
        '
        'Mobile_PhoneLabel1
        '
        Mobile_PhoneLabel1.AutoSize = True
        Mobile_PhoneLabel1.Location = New System.Drawing.Point(68, 317)
        Mobile_PhoneLabel1.Name = "Mobile_PhoneLabel1"
        Mobile_PhoneLabel1.Size = New System.Drawing.Size(75, 13)
        Mobile_PhoneLabel1.TabIndex = 87
        Mobile_PhoneLabel1.Text = "Mobile Phone:"
        '
        'Home_PhoneLabel1
        '
        Home_PhoneLabel1.AutoSize = True
        Home_PhoneLabel1.Location = New System.Drawing.Point(68, 343)
        Home_PhoneLabel1.Name = "Home_PhoneLabel1"
        Home_PhoneLabel1.Size = New System.Drawing.Size(72, 13)
        Home_PhoneLabel1.TabIndex = 88
        Home_PhoneLabel1.Text = "Home Phone:"
        '
        'ZIPLabel1
        '
        ZIPLabel1.AutoSize = True
        ZIPLabel1.Location = New System.Drawing.Point(68, 291)
        ZIPLabel1.Name = "ZIPLabel1"
        ZIPLabel1.Size = New System.Drawing.Size(27, 13)
        ZIPLabel1.TabIndex = 89
        ZIPLabel1.Text = "ZIP:"
        '
        'Degree_1_Grad_DateLabel
        '
        Degree_1_Grad_DateLabel.AutoSize = True
        Degree_1_Grad_DateLabel.Location = New System.Drawing.Point(84, 127)
        Degree_1_Grad_DateLabel.Name = "Degree_1_Grad_DateLabel"
        Degree_1_Grad_DateLabel.Size = New System.Drawing.Size(106, 13)
        Degree_1_Grad_DateLabel.TabIndex = 81
        Degree_1_Grad_DateLabel.Text = "Degree 1 Grad Date:"
        '
        'Degree_2_Grad_DateLabel1
        '
        Degree_2_Grad_DateLabel1.AutoSize = True
        Degree_2_Grad_DateLabel1.Location = New System.Drawing.Point(85, 178)
        Degree_2_Grad_DateLabel1.Name = "Degree_2_Grad_DateLabel1"
        Degree_2_Grad_DateLabel1.Size = New System.Drawing.Size(106, 13)
        Degree_2_Grad_DateLabel1.TabIndex = 82
        Degree_2_Grad_DateLabel1.Text = "Degree 2 Grad Date:"
        '
        'Degree_3_Grad_DateLabel1
        '
        Degree_3_Grad_DateLabel1.AutoSize = True
        Degree_3_Grad_DateLabel1.Location = New System.Drawing.Point(84, 230)
        Degree_3_Grad_DateLabel1.Name = "Degree_3_Grad_DateLabel1"
        Degree_3_Grad_DateLabel1.Size = New System.Drawing.Size(106, 13)
        Degree_3_Grad_DateLabel1.TabIndex = 83
        Degree_3_Grad_DateLabel1.Text = "Degree 3 Grad Date:"
        '
        'Degree_4_Grad_DateLabel1
        '
        Degree_4_Grad_DateLabel1.AutoSize = True
        Degree_4_Grad_DateLabel1.Location = New System.Drawing.Point(86, 282)
        Degree_4_Grad_DateLabel1.Name = "Degree_4_Grad_DateLabel1"
        Degree_4_Grad_DateLabel1.Size = New System.Drawing.Size(106, 13)
        Degree_4_Grad_DateLabel1.TabIndex = 84
        Degree_4_Grad_DateLabel1.Text = "Degree 4 Grad Date:"
        '
        'Membership_Renewal_DateLabel
        '
        Membership_Renewal_DateLabel.AutoSize = True
        Membership_Renewal_DateLabel.Location = New System.Drawing.Point(68, 423)
        Membership_Renewal_DateLabel.Name = "Membership_Renewal_DateLabel"
        Membership_Renewal_DateLabel.Size = New System.Drawing.Size(138, 13)
        Membership_Renewal_DateLabel.TabIndex = 90
        Membership_Renewal_DateLabel.Text = "Membership Renewal Date:"
        '
        'Account_ActiveLabel
        '
        Account_ActiveLabel.AutoSize = True
        Account_ActiveLabel.Location = New System.Drawing.Point(71, 451)
        Account_ActiveLabel.Name = "Account_ActiveLabel"
        Account_ActiveLabel.Size = New System.Drawing.Size(83, 13)
        Account_ActiveLabel.TabIndex = 91
        Account_ActiveLabel.Text = "Account Active:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToPreviousMenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1073, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackToPreviousMenuToolStripMenuItem
        '
        Me.BackToPreviousMenuToolStripMenuItem.Name = "BackToPreviousMenuToolStripMenuItem"
        Me.BackToPreviousMenuToolStripMenuItem.Size = New System.Drawing.Size(140, 20)
        Me.BackToPreviousMenuToolStripMenuItem.Text = "Back to Previous Menu"
        '
        'grpDegrees
        '
        Me.grpDegrees.Controls.Add(Me.Label11)
        Me.grpDegrees.Controls.Add(Me.Label10)
        Me.grpDegrees.Controls.Add(Degree_4_Grad_DateLabel1)
        Me.grpDegrees.Controls.Add(Me.Degree_4_Grad_DateMaskedTextBox)
        Me.grpDegrees.Controls.Add(Degree_3_Grad_DateLabel1)
        Me.grpDegrees.Controls.Add(Me.Degree_3_Grad_DateMaskedTextBox)
        Me.grpDegrees.Controls.Add(Degree_2_Grad_DateLabel1)
        Me.grpDegrees.Controls.Add(Me.Degree_2_Grad_DateMaskedTextBox)
        Me.grpDegrees.Controls.Add(Degree_1_Grad_DateLabel)
        Me.grpDegrees.Controls.Add(Me.Degree_1_Grad_DateMaskedTextBox)
        Me.grpDegrees.Controls.Add(Me.Degree_1TextBox)
        Me.grpDegrees.Controls.Add(Me.Educational_InfoTextBox)
        Me.grpDegrees.Controls.Add(Educational_InfoLabel)
        Me.grpDegrees.Controls.Add(Me.Degree_4TextBox)
        Me.grpDegrees.Controls.Add(Degree_4Label)
        Me.grpDegrees.Controls.Add(Me.Degree_3TextBox)
        Me.grpDegrees.Controls.Add(Degree_3Label)
        Me.grpDegrees.Controls.Add(Me.Degree_2TextBox)
        Me.grpDegrees.Controls.Add(Degree_2Label)
        Me.grpDegrees.Controls.Add(Degree_1Label)
        Me.grpDegrees.Location = New System.Drawing.Point(477, 64)
        Me.grpDegrees.Name = "grpDegrees"
        Me.grpDegrees.Size = New System.Drawing.Size(549, 442)
        Me.grpDegrees.TabIndex = 31
        Me.grpDegrees.TabStop = False
        Me.grpDegrees.Text = "Educational Data"
        '
        'Degree_4_Grad_DateMaskedTextBox
        '
        Me.Degree_4_Grad_DateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alumni_InfoBindingSource, "Degree_4_Grad_Date", True))
        Me.Degree_4_Grad_DateMaskedTextBox.Location = New System.Drawing.Point(228, 279)
        Me.Degree_4_Grad_DateMaskedTextBox.Mask = "00/00/0000"
        Me.Degree_4_Grad_DateMaskedTextBox.Name = "Degree_4_Grad_DateMaskedTextBox"
        Me.Degree_4_Grad_DateMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Degree_4_Grad_DateMaskedTextBox.TabIndex = 85
        Me.Degree_4_Grad_DateMaskedTextBox.ValidatingType = GetType(Date)
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
        'Degree_3_Grad_DateMaskedTextBox
        '
        Me.Degree_3_Grad_DateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alumni_InfoBindingSource, "Degree_3_Grad_Date", True))
        Me.Degree_3_Grad_DateMaskedTextBox.Location = New System.Drawing.Point(228, 227)
        Me.Degree_3_Grad_DateMaskedTextBox.Mask = "00/00/0000"
        Me.Degree_3_Grad_DateMaskedTextBox.Name = "Degree_3_Grad_DateMaskedTextBox"
        Me.Degree_3_Grad_DateMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Degree_3_Grad_DateMaskedTextBox.TabIndex = 84
        Me.Degree_3_Grad_DateMaskedTextBox.ValidatingType = GetType(Date)
        '
        'Degree_2_Grad_DateMaskedTextBox
        '
        Me.Degree_2_Grad_DateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alumni_InfoBindingSource, "Degree_2_Grad_Date", True))
        Me.Degree_2_Grad_DateMaskedTextBox.Location = New System.Drawing.Point(228, 175)
        Me.Degree_2_Grad_DateMaskedTextBox.Mask = "00/00/0000"
        Me.Degree_2_Grad_DateMaskedTextBox.Name = "Degree_2_Grad_DateMaskedTextBox"
        Me.Degree_2_Grad_DateMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Degree_2_Grad_DateMaskedTextBox.TabIndex = 83
        Me.Degree_2_Grad_DateMaskedTextBox.ValidatingType = GetType(Date)
        '
        'Degree_1_Grad_DateMaskedTextBox
        '
        Me.Degree_1_Grad_DateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alumni_InfoBindingSource, "Degree_1_Grad_Date", True))
        Me.Degree_1_Grad_DateMaskedTextBox.Location = New System.Drawing.Point(228, 123)
        Me.Degree_1_Grad_DateMaskedTextBox.Mask = "00/00/0000"
        Me.Degree_1_Grad_DateMaskedTextBox.Name = "Degree_1_Grad_DateMaskedTextBox"
        Me.Degree_1_Grad_DateMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Degree_1_Grad_DateMaskedTextBox.TabIndex = 82
        Me.Degree_1_Grad_DateMaskedTextBox.ValidatingType = GetType(Date)
        '
        'Degree_1TextBox
        '
        Me.Degree_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alumni_InfoBindingSource, "Degree_1", True))
        Me.Degree_1TextBox.Location = New System.Drawing.Point(228, 97)
        Me.Degree_1TextBox.Name = "Degree_1TextBox"
        Me.Degree_1TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Degree_1TextBox.TabIndex = 65
        '
        'Educational_InfoTextBox
        '
        Me.Educational_InfoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alumni_InfoBindingSource, "Educational_Info", True))
        Me.Educational_InfoTextBox.Location = New System.Drawing.Point(228, 305)
        Me.Educational_InfoTextBox.Name = "Educational_InfoTextBox"
        Me.Educational_InfoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Educational_InfoTextBox.TabIndex = 81
        '
        'Degree_4TextBox
        '
        Me.Degree_4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alumni_InfoBindingSource, "Degree_4", True))
        Me.Degree_4TextBox.Location = New System.Drawing.Point(228, 253)
        Me.Degree_4TextBox.Name = "Degree_4TextBox"
        Me.Degree_4TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Degree_4TextBox.TabIndex = 77
        '
        'Degree_3TextBox
        '
        Me.Degree_3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alumni_InfoBindingSource, "Degree_3", True))
        Me.Degree_3TextBox.Location = New System.Drawing.Point(228, 201)
        Me.Degree_3TextBox.Name = "Degree_3TextBox"
        Me.Degree_3TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Degree_3TextBox.TabIndex = 73
        '
        'Degree_2TextBox
        '
        Me.Degree_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alumni_InfoBindingSource, "Degree_2", True))
        Me.Degree_2TextBox.Location = New System.Drawing.Point(228, 149)
        Me.Degree_2TextBox.Name = "Degree_2TextBox"
        Me.Degree_2TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Degree_2TextBox.TabIndex = 69
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(563, 515)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(119, 36)
        Me.btnSave.TabIndex = 32
        Me.btnSave.Text = "Save and Close"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(826, 515)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(119, 36)
        Me.btnCancel.TabIndex = 33
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
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
        'Member_ID
        '
        Me.Member_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alumni_InfoBindingSource, "Member_ID", True))
        Me.Member_ID.Location = New System.Drawing.Point(212, 80)
        Me.Member_ID.Name = "Member_ID"
        Me.Member_ID.ReadOnly = True
        Me.Member_ID.Size = New System.Drawing.Size(200, 20)
        Me.Member_ID.TabIndex = 35
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alumni_InfoBindingSource, "First_Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(212, 106)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.First_NameTextBox.TabIndex = 37
        '
        'Middle_NameTextBox
        '
        Me.Middle_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alumni_InfoBindingSource, "Middle_Name", True))
        Me.Middle_NameTextBox.Location = New System.Drawing.Point(212, 132)
        Me.Middle_NameTextBox.Name = "Middle_NameTextBox"
        Me.Middle_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Middle_NameTextBox.TabIndex = 39
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alumni_InfoBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(212, 158)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Last_NameTextBox.TabIndex = 41
        '
        'SalutationTextBox
        '
        Me.SalutationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alumni_InfoBindingSource, "Salutation", True))
        Me.SalutationTextBox.Location = New System.Drawing.Point(212, 184)
        Me.SalutationTextBox.Name = "SalutationTextBox"
        Me.SalutationTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SalutationTextBox.TabIndex = 43
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alumni_InfoBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(212, 210)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AddressTextBox.TabIndex = 45
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alumni_InfoBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(212, 236)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CityTextBox.TabIndex = 47
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alumni_InfoBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(212, 262)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StateTextBox.TabIndex = 49
        '
        'Family_Info_NotesTextBox
        '
        Me.Family_Info_NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alumni_InfoBindingSource, "Family_Info_Notes", True))
        Me.Family_Info_NotesTextBox.Location = New System.Drawing.Point(212, 367)
        Me.Family_Info_NotesTextBox.Name = "Family_Info_NotesTextBox"
        Me.Family_Info_NotesTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Family_Info_NotesTextBox.TabIndex = 61
        '
        'Misc_NotesTextBox
        '
        Me.Misc_NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alumni_InfoBindingSource, "Misc_Notes", True))
        Me.Misc_NotesTextBox.Location = New System.Drawing.Point(212, 393)
        Me.Misc_NotesTextBox.Name = "Misc_NotesTextBox"
        Me.Misc_NotesTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Misc_NotesTextBox.TabIndex = 63
        '
        'Mobile_PhoneMaskedTextBox
        '
        Me.Mobile_PhoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alumni_InfoBindingSource, "Mobile_Phone", True))
        Me.Mobile_PhoneMaskedTextBox.Location = New System.Drawing.Point(212, 314)
        Me.Mobile_PhoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.Mobile_PhoneMaskedTextBox.Name = "Mobile_PhoneMaskedTextBox"
        Me.Mobile_PhoneMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Mobile_PhoneMaskedTextBox.TabIndex = 88
        '
        'Home_PhoneMaskedTextBox
        '
        Me.Home_PhoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alumni_InfoBindingSource, "Home_Phone", True))
        Me.Home_PhoneMaskedTextBox.Location = New System.Drawing.Point(212, 341)
        Me.Home_PhoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.Home_PhoneMaskedTextBox.Name = "Home_PhoneMaskedTextBox"
        Me.Home_PhoneMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Home_PhoneMaskedTextBox.TabIndex = 89
        '
        'ZIPMaskedTextBox
        '
        Me.ZIPMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alumni_InfoBindingSource, "ZIP", True))
        Me.ZIPMaskedTextBox.Location = New System.Drawing.Point(212, 288)
        Me.ZIPMaskedTextBox.Mask = "00000"
        Me.ZIPMaskedTextBox.Name = "ZIPMaskedTextBox"
        Me.ZIPMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ZIPMaskedTextBox.TabIndex = 90
        Me.ZIPMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'Membership_Renewal_DateMaskedTextBox
        '
        Me.Membership_Renewal_DateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Alumni_InfoBindingSource, "Membership_Renewal_Date", True))
        Me.Membership_Renewal_DateMaskedTextBox.Location = New System.Drawing.Point(212, 420)
        Me.Membership_Renewal_DateMaskedTextBox.Mask = "00/00/0000"
        Me.Membership_Renewal_DateMaskedTextBox.Name = "Membership_Renewal_DateMaskedTextBox"
        Me.Membership_Renewal_DateMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Membership_Renewal_DateMaskedTextBox.TabIndex = 91
        Me.Membership_Renewal_DateMaskedTextBox.ValidatingType = GetType(Date)
        '
        'Account_ActiveCheckBox
        '
        Me.Account_ActiveCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Alumni_InfoBindingSource, "Account_Active", True))
        Me.Account_ActiveCheckBox.Location = New System.Drawing.Point(212, 446)
        Me.Account_ActiveCheckBox.Name = "Account_ActiveCheckBox"
        Me.Account_ActiveCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Account_ActiveCheckBox.TabIndex = 92
        Me.Account_ActiveCheckBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(49, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 25)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(51, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 25)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(51, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 25)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(49, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 25)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(49, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 25)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(49, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 25)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(49, 314)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 25)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(49, 420)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 25)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(49, 449)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 25)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(63, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 25)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(63, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 25)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(138, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 25)
        Me.Label12.TabIndex = 102
        Me.Label12.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(66, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 13)
        Me.Label13.TabIndex = 103
        Me.Label13.Text = "Required fields"
        '
        'frmAddEditAlumni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 602)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Account_ActiveLabel)
        Me.Controls.Add(Me.Account_ActiveCheckBox)
        Me.Controls.Add(Membership_Renewal_DateLabel)
        Me.Controls.Add(Me.Membership_Renewal_DateMaskedTextBox)
        Me.Controls.Add(ZIPLabel1)
        Me.Controls.Add(Me.ZIPMaskedTextBox)
        Me.Controls.Add(Home_PhoneLabel1)
        Me.Controls.Add(Me.Home_PhoneMaskedTextBox)
        Me.Controls.Add(Mobile_PhoneLabel1)
        Me.Controls.Add(Me.Mobile_PhoneMaskedTextBox)
        Me.Controls.Add(Member_IDLabel)
        Me.Controls.Add(Me.Member_ID)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Middle_NameLabel)
        Me.Controls.Add(Me.Middle_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(SalutationLabel)
        Me.Controls.Add(Me.SalutationTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Family_Info_NotesLabel)
        Me.Controls.Add(Me.Family_Info_NotesTextBox)
        Me.Controls.Add(Misc_NotesLabel)
        Me.Controls.Add(Me.Misc_NotesTextBox)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpDegrees)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAddEditAlumni"
        Me.Text = "Add/Edit Alumni"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpDegrees.ResumeLayout(False)
        Me.grpDegrees.PerformLayout()
        CType(Me.Alumni_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoSuchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToPreviousMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpDegrees As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents NoSuchDataSet As NoSuchDataSet
    Friend WithEvents Alumni_InfoBindingSource As BindingSource
    Friend WithEvents Alumni_InfoTableAdapter As NoSuchDataSetTableAdapters.Alumni_InfoTableAdapter
    Friend WithEvents TableAdapterManager As NoSuchDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Degree_1TextBox As TextBox
    Friend WithEvents Educational_InfoTextBox As TextBox
    Friend WithEvents Degree_4TextBox As TextBox
    Friend WithEvents Degree_3TextBox As TextBox
    Friend WithEvents Degree_2TextBox As TextBox
    Friend WithEvents Member_ID As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Middle_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents SalutationTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents Family_Info_NotesTextBox As TextBox
    Friend WithEvents Misc_NotesTextBox As TextBox
    Friend WithEvents Mobile_PhoneMaskedTextBox As MaskedTextBox
    Friend WithEvents Degree_3_Grad_DateMaskedTextBox As MaskedTextBox
    Friend WithEvents Degree_2_Grad_DateMaskedTextBox As MaskedTextBox
    Friend WithEvents Degree_1_Grad_DateMaskedTextBox As MaskedTextBox
    Friend WithEvents Home_PhoneMaskedTextBox As MaskedTextBox
    Friend WithEvents ZIPMaskedTextBox As MaskedTextBox
    Friend WithEvents Degree_4_Grad_DateMaskedTextBox As MaskedTextBox
    Friend WithEvents Membership_Renewal_DateMaskedTextBox As MaskedTextBox
    Friend WithEvents Account_ActiveCheckBox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
