<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarang
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBarang))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbl_tgl = New System.Windows.Forms.Label
        Me.txt_kdbarang = New System.Windows.Forms.TextBox
        Me.txt_noean = New System.Windows.Forms.TextBox
        Me.txt_nmbarang = New System.Windows.Forms.TextBox
        Me.txt_jumlah = New System.Windows.Forms.TextBox
        Me.txt_harga = New System.Windows.Forms.TextBox
        Me.cmb_tglbuat = New System.Windows.Forms.DateTimePicker
        Me.cmb_kategori = New System.Windows.Forms.ComboBox
        Me.DGVbarang = New System.Windows.Forms.DataGridView
        Me.btn_simpan = New System.Windows.Forms.Button
        Me.btn_update = New System.Windows.Forms.Button
        Me.btn_refresh = New System.Windows.Forms.Button
        Me.btn_delete = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.txt_cari = New System.Windows.Forms.TextBox
        Me.cmb_sortby = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.grp_inputbarang = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        CType(Me.DGVbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_inputbarang.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_tgl
        '
        Me.lbl_tgl.AutoSize = True
        Me.lbl_tgl.Location = New System.Drawing.Point(68, 40)
        Me.lbl_tgl.Name = "lbl_tgl"
        Me.lbl_tgl.Size = New System.Drawing.Size(113, 13)
        Me.lbl_tgl.TabIndex = 7
        Me.lbl_tgl.Text = "Tanggal Input/Update"
        Me.ToolTip1.SetToolTip(Me.lbl_tgl, "Tanggal")
        '
        'txt_kdbarang
        '
        Me.txt_kdbarang.Location = New System.Drawing.Point(98, 24)
        Me.txt_kdbarang.Name = "txt_kdbarang"
        Me.txt_kdbarang.Size = New System.Drawing.Size(157, 20)
        Me.txt_kdbarang.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txt_kdbarang, "Kode Barang")
        '
        'txt_noean
        '
        Me.txt_noean.Location = New System.Drawing.Point(98, 48)
        Me.txt_noean.Name = "txt_noean"
        Me.txt_noean.Size = New System.Drawing.Size(109, 20)
        Me.txt_noean.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.txt_noean, "Nomor EAN")
        '
        'txt_nmbarang
        '
        Me.txt_nmbarang.Location = New System.Drawing.Point(98, 73)
        Me.txt_nmbarang.Name = "txt_nmbarang"
        Me.txt_nmbarang.Size = New System.Drawing.Size(220, 20)
        Me.txt_nmbarang.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.txt_nmbarang, "Nama Barang")
        '
        'txt_jumlah
        '
        Me.txt_jumlah.Location = New System.Drawing.Point(445, 54)
        Me.txt_jumlah.Name = "txt_jumlah"
        Me.txt_jumlah.Size = New System.Drawing.Size(60, 20)
        Me.txt_jumlah.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.txt_jumlah, "Jumlah Barang")
        '
        'txt_harga
        '
        Me.txt_harga.Location = New System.Drawing.Point(445, 80)
        Me.txt_harga.Name = "txt_harga"
        Me.txt_harga.Size = New System.Drawing.Size(131, 20)
        Me.txt_harga.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.txt_harga, "Harga Satuan Barang")
        '
        'cmb_tglbuat
        '
        Me.cmb_tglbuat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_tglbuat.Location = New System.Drawing.Point(445, 28)
        Me.cmb_tglbuat.Name = "cmb_tglbuat"
        Me.cmb_tglbuat.Size = New System.Drawing.Size(99, 20)
        Me.cmb_tglbuat.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.cmb_tglbuat, "Tanggal Dibuatnya Barang")
        '
        'cmb_kategori
        '
        Me.cmb_kategori.FormattingEnabled = True
        Me.cmb_kategori.Location = New System.Drawing.Point(98, 99)
        Me.cmb_kategori.Name = "cmb_kategori"
        Me.cmb_kategori.Size = New System.Drawing.Size(121, 21)
        Me.cmb_kategori.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.cmb_kategori, "Kategori Barang")
        '
        'DGVbarang
        '
        Me.DGVbarang.AllowUserToAddRows = False
        Me.DGVbarang.AllowUserToDeleteRows = False
        Me.DGVbarang.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.DGVbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVbarang.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGVbarang.Location = New System.Drawing.Point(13, 258)
        Me.DGVbarang.Name = "DGVbarang"
        Me.DGVbarang.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVbarang.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVbarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVbarang.Size = New System.Drawing.Size(641, 244)
        Me.DGVbarang.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.DGVbarang, "Tampilan Data Barang")
        '
        'btn_simpan
        '
        Me.btn_simpan.Image = Global.Project_Work.My.Resources.Resources.add
        Me.btn_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_simpan.Location = New System.Drawing.Point(327, 113)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(65, 26)
        Me.btn_simpan.TabIndex = 18
        Me.btn_simpan.Text = "&Simpan"
        Me.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btn_simpan, "Tambah Barang")
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Image = Global.Project_Work.My.Resources.Resources.database_edit
        Me.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_update.Location = New System.Drawing.Point(398, 113)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(65, 26)
        Me.btn_update.TabIndex = 19
        Me.btn_update.Text = "&Update"
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btn_update, "Update Barang")
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.Image = Global.Project_Work.My.Resources.Resources.arrow_refresh
        Me.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_refresh.Location = New System.Drawing.Point(468, 113)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(70, 26)
        Me.btn_refresh.TabIndex = 20
        Me.btn_refresh.Text = "&Refresh"
        Me.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btn_refresh, "Refresh Form")
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Image = Global.Project_Work.My.Resources.Resources.database_delete
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete.Location = New System.Drawing.Point(543, 113)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(70, 26)
        Me.btn_delete.TabIndex = 21
        Me.btn_delete.Text = "&Delete"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btn_delete, "Hapus Barang")
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Project_Work.My.Resources.Resources.zoom
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(595, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 26)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "&Cari"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Button1, "Cari Barang")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_cari
        '
        Me.txt_cari.Location = New System.Drawing.Point(467, 229)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(122, 20)
        Me.txt_cari.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.txt_cari, "Barang Yang Dicari")
        '
        'cmb_sortby
        '
        Me.cmb_sortby.FormattingEnabled = True
        Me.cmb_sortby.Location = New System.Drawing.Point(300, 229)
        Me.cmb_sortby.Name = "cmb_sortby"
        Me.cmb_sortby.Size = New System.Drawing.Size(104, 21)
        Me.cmb_sortby.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.cmb_sortby, "Berdasarkan Pencarian")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Barang :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No.EAN :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Barang :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kategori :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(358, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(358, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Harga :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(358, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tanggal Dibuat :"
        '
        'grp_inputbarang
        '
        Me.grp_inputbarang.Controls.Add(Me.btn_simpan)
        Me.grp_inputbarang.Controls.Add(Me.btn_update)
        Me.grp_inputbarang.Controls.Add(Me.btn_refresh)
        Me.grp_inputbarang.Controls.Add(Me.btn_delete)
        Me.grp_inputbarang.Controls.Add(Me.cmb_kategori)
        Me.grp_inputbarang.Controls.Add(Me.cmb_tglbuat)
        Me.grp_inputbarang.Controls.Add(Me.txt_harga)
        Me.grp_inputbarang.Controls.Add(Me.txt_jumlah)
        Me.grp_inputbarang.Controls.Add(Me.txt_nmbarang)
        Me.grp_inputbarang.Controls.Add(Me.txt_noean)
        Me.grp_inputbarang.Controls.Add(Me.txt_kdbarang)
        Me.grp_inputbarang.Controls.Add(Me.Label7)
        Me.grp_inputbarang.Controls.Add(Me.Label6)
        Me.grp_inputbarang.Controls.Add(Me.Label5)
        Me.grp_inputbarang.Controls.Add(Me.Label4)
        Me.grp_inputbarang.Controls.Add(Me.Label3)
        Me.grp_inputbarang.Controls.Add(Me.Label2)
        Me.grp_inputbarang.Controls.Add(Me.Label1)
        Me.grp_inputbarang.Location = New System.Drawing.Point(13, 69)
        Me.grp_inputbarang.Name = "grp_inputbarang"
        Me.grp_inputbarang.Size = New System.Drawing.Size(641, 151)
        Me.grp_inputbarang.TabIndex = 16
        Me.grp_inputbarang.TabStop = False
        Me.grp_inputbarang.Text = "Input Barang"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Tanggal :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(221, 233)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Berdasarkan :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(410, 233)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Mencari :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Harvest", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(517, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 35)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Product"
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(666, 514)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmb_sortby)
        Me.Controls.Add(Me.txt_cari)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.grp_inputbarang)
        Me.Controls.Add(Me.DGVbarang)
        Me.Controls.Add(Me.lbl_tgl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Pengimputan Barang"
        CType(Me.DGVbarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_inputbarang.ResumeLayout(False)
        Me.grp_inputbarang.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_tgl As System.Windows.Forms.Label
    Friend WithEvents txt_kdbarang As System.Windows.Forms.TextBox
    Friend WithEvents txt_noean As System.Windows.Forms.TextBox
    Friend WithEvents txt_nmbarang As System.Windows.Forms.TextBox
    Friend WithEvents txt_jumlah As System.Windows.Forms.TextBox
    Friend WithEvents txt_harga As System.Windows.Forms.TextBox
    Friend WithEvents cmb_tglbuat As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_kategori As System.Windows.Forms.ComboBox
    Friend WithEvents DGVbarang As System.Windows.Forms.DataGridView
    Friend WithEvents grp_inputbarang As System.Windows.Forms.GroupBox
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_refresh As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_cari As System.Windows.Forms.TextBox
    Friend WithEvents cmb_sortby As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
