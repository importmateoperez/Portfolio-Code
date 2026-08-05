<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnAlumni = New System.Windows.Forms.Button()
        Me.btnManageAcc = New System.Windows.Forms.Button()
        Me.btnManageDon = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.stripMenuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ExitApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAlumni
        '
        Me.btnAlumni.Location = New System.Drawing.Point(81, 352)
        Me.btnAlumni.Name = "btnAlumni"
        Me.btnAlumni.Size = New System.Drawing.Size(156, 23)
        Me.btnAlumni.TabIndex = 0
        Me.btnAlumni.Text = "Manage Alumni Members"
        Me.btnAlumni.UseVisualStyleBackColor = True
        '
        'btnManageAcc
        '
        Me.btnManageAcc.Location = New System.Drawing.Point(542, 352)
        Me.btnManageAcc.Name = "btnManageAcc"
        Me.btnManageAcc.Size = New System.Drawing.Size(156, 23)
        Me.btnManageAcc.TabIndex = 1
        Me.btnManageAcc.Text = "Manage Accounts"
        Me.btnManageAcc.UseVisualStyleBackColor = True
        '
        'btnManageDon
        '
        Me.btnManageDon.Location = New System.Drawing.Point(317, 352)
        Me.btnManageDon.Name = "btnManageDon"
        Me.btnManageDon.Size = New System.Drawing.Size(156, 23)
        Me.btnManageDon.TabIndex = 2
        Me.btnManageDon.Text = "Manage Donations"
        Me.btnManageDon.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(297, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Main Menu"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitApplicationToolStripMenuItem, Me.stripMenuAbout})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'stripMenuAbout
        '
        Me.stripMenuAbout.Name = "stripMenuAbout"
        Me.stripMenuAbout.Size = New System.Drawing.Size(52, 20)
        Me.stripMenuAbout.Text = "About"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(311, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(173, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'ExitApplicationToolStripMenuItem
        '
        Me.ExitApplicationToolStripMenuItem.Name = "ExitApplicationToolStripMenuItem"
        Me.ExitApplicationToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.ExitApplicationToolStripMenuItem.Text = "Exit Application"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnManageDon)
        Me.Controls.Add(Me.btnManageAcc)
        Me.Controls.Add(Me.btnAlumni)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "NoSuch Alumni Manager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAlumni As Button
    Friend WithEvents btnManageAcc As Button
    Friend WithEvents btnManageDon As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents stripMenuAbout As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ExitApplicationToolStripMenuItem As ToolStripMenuItem
End Class
