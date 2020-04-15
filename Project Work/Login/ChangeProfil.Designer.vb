<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeProfil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangeProfil))
        Me.btn_update = New System.Windows.Forms.Button
        Me.btn_close = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_nama = New System.Windows.Forms.TextBox
        Me.txt_username = New System.Windows.Forms.TextBox
        Me.txt_password = New System.Windows.Forms.TextBox
        Me.txt_newpassword = New System.Windows.Forms.TextBox
        Me.txt_confirmpassword = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_stat = New System.Windows.Forms.Label
        Me.txt_stat2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txt_stat3 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.Image = Global.Project_Work.My.Resources.Resources.editblack
        Me.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_update.Location = New System.Drawing.Point(120, 200)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 26)
        Me.btn_update.TabIndex = 0
        Me.btn_update.Text = "&Update"
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Image = Global.Project_Work.My.Resources.Resources.repeatblack
        Me.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_close.Location = New System.Drawing.Point(201, 200)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 26)
        Me.btn_close.TabIndex = 1
        Me.btn_close.Text = "&Close"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nama :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Tag = ""
        Me.Label2.Text = "Username :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Current Password :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "New Password :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Confirm Password :"
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(120, 70)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(138, 20)
        Me.txt_nama.TabIndex = 7
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(120, 96)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(116, 20)
        Me.txt_username.TabIndex = 8
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(120, 123)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(156, 20)
        Me.txt_password.TabIndex = 9
        '
        'txt_newpassword
        '
        Me.txt_newpassword.Location = New System.Drawing.Point(120, 149)
        Me.txt_newpassword.Name = "txt_newpassword"
        Me.txt_newpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_newpassword.Size = New System.Drawing.Size(156, 20)
        Me.txt_newpassword.TabIndex = 10
        '
        'txt_confirmpassword
        '
        Me.txt_confirmpassword.Location = New System.Drawing.Point(120, 174)
        Me.txt_confirmpassword.Name = "txt_confirmpassword"
        Me.txt_confirmpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_confirmpassword.Size = New System.Drawing.Size(156, 20)
        Me.txt_confirmpassword.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Harvest", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 27)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "PROFIL"
        '
        'txt_stat
        '
        Me.txt_stat.AutoSize = True
        Me.txt_stat.Location = New System.Drawing.Point(282, 153)
        Me.txt_stat.Name = "txt_stat"
        Me.txt_stat.Size = New System.Drawing.Size(0, 13)
        Me.txt_stat.TabIndex = 13
        '
        'txt_stat2
        '
        Me.txt_stat2.AutoSize = True
        Me.txt_stat2.Location = New System.Drawing.Point(282, 177)
        Me.txt_stat2.Name = "txt_stat2"
        Me.txt_stat2.Size = New System.Drawing.Size(0, 13)
        Me.txt_stat2.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project_Work.My.Resources.Resources.userblack
        Me.PictureBox1.Location = New System.Drawing.Point(12, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'txt_stat3
        '
        Me.txt_stat3.AutoSize = True
        Me.txt_stat3.Location = New System.Drawing.Point(264, 75)
        Me.txt_stat3.Name = "txt_stat3"
        Me.txt_stat3.Size = New System.Drawing.Size(0, 13)
        Me.txt_stat3.TabIndex = 16
        '
        'ChangeProfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 232)
        Me.Controls.Add(Me.txt_stat3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_stat2)
        Me.Controls.Add(Me.txt_stat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_confirmpassword)
        Me.Controls.Add(Me.txt_newpassword)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.txt_nama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_update)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ChangeProfil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChangeProfil"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_nama As System.Windows.Forms.TextBox
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents txt_newpassword As System.Windows.Forms.TextBox
    Friend WithEvents txt_confirmpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_stat As System.Windows.Forms.Label
    Friend WithEvents txt_stat2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_stat3 As System.Windows.Forms.Label
End Class
