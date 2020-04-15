<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCariBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCariBarang))
        Me.DGVbarang = New System.Windows.Forms.DataGridView
        Me.btn_cari = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_sortby = New System.Windows.Forms.ComboBox
        Me.txt_cari = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmb_tglpack = New System.Windows.Forms.ComboBox
        CType(Me.DGVbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVbarang
        '
        Me.DGVbarang.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.DGVbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVbarang.Location = New System.Drawing.Point(12, 51)
        Me.DGVbarang.Name = "DGVbarang"
        Me.DGVbarang.Size = New System.Drawing.Size(544, 401)
        Me.DGVbarang.TabIndex = 0
        '
        'btn_cari
        '
        Me.btn_cari.Image = Global.Project_Work.My.Resources.Resources.zoom
        Me.btn_cari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cari.Location = New System.Drawing.Point(481, 22)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(50, 23)
        Me.btn_cari.TabIndex = 1
        Me.btn_cari.Text = "Cari"
        Me.btn_cari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cari.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Berdasarkan Urutan :"
        '
        'cmb_sortby
        '
        Me.cmb_sortby.FormattingEnabled = True
        Me.cmb_sortby.Location = New System.Drawing.Point(144, 24)
        Me.cmb_sortby.Name = "cmb_sortby"
        Me.cmb_sortby.Size = New System.Drawing.Size(121, 21)
        Me.cmb_sortby.TabIndex = 3
        '
        'txt_cari
        '
        Me.txt_cari.Location = New System.Drawing.Point(317, 24)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(155, 20)
        Me.txt_cari.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(271, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Dicari :"
        '
        'cmb_tglpack
        '
        Me.cmb_tglpack.FormattingEnabled = True
        Me.cmb_tglpack.Location = New System.Drawing.Point(317, 3)
        Me.cmb_tglpack.Name = "cmb_tglpack"
        Me.cmb_tglpack.Size = New System.Drawing.Size(155, 21)
        Me.cmb_tglpack.TabIndex = 6
        '
        'FormCariBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 464)
        Me.Controls.Add(Me.cmb_tglpack)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cari)
        Me.Controls.Add(Me.cmb_sortby)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_cari)
        Me.Controls.Add(Me.DGVbarang)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCariBarang"
        CType(Me.DGVbarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVbarang As System.Windows.Forms.DataGridView
    Friend WithEvents btn_cari As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_sortby As System.Windows.Forms.ComboBox
    Friend WithEvents txt_cari As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_tglpack As System.Windows.Forms.ComboBox
End Class
