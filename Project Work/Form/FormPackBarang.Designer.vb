<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPackBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPackBarang))
        Me.DGVpack = New System.Windows.Forms.DataGridView
        Me.txt_dus = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_tambah = New System.Windows.Forms.Button
        Me.txt_kdbarang = New System.Windows.Forms.TextBox
        Me.txt_namabarang = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lb_barang = New System.Windows.Forms.ListView
        Me.kdbarang = New System.Windows.Forms.ColumnHeader
        Me.namabarang = New System.Windows.Forms.ColumnHeader
        Me.kategori = New System.Windows.Forms.ColumnHeader
        Me.cmb_kategori = New System.Windows.Forms.ComboBox
        Me.txt_qty = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_noean = New System.Windows.Forms.TextBox
        Me.txt_kategori = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btn_simpan = New System.Windows.Forms.Button
        Me.txt_tgl = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_total = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.pctdus = New System.Windows.Forms.PictureBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DGVpack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctdus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVpack
        '
        Me.DGVpack.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.DGVpack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVpack.Location = New System.Drawing.Point(12, 270)
        Me.DGVpack.Name = "DGVpack"
        Me.DGVpack.Size = New System.Drawing.Size(580, 222)
        Me.DGVpack.TabIndex = 0
        '
        'txt_dus
        '
        Me.txt_dus.Location = New System.Drawing.Point(75, 48)
        Me.txt_dus.Name = "txt_dus"
        Me.txt_dus.Size = New System.Drawing.Size(128, 20)
        Me.txt_dus.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txt_dus, "Nomor Dus ")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-1, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nomor DUS :"
        '
        'btn_tambah
        '
        Me.btn_tambah.Image = Global.Project_Work.My.Resources.Resources.cart_add
        Me.btn_tambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_tambah.Location = New System.Drawing.Point(160, 180)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(69, 26)
        Me.btn_tambah.TabIndex = 5
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btn_tambah, "Tambah Barang")
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'txt_kdbarang
        '
        Me.txt_kdbarang.Location = New System.Drawing.Point(92, 80)
        Me.txt_kdbarang.Name = "txt_kdbarang"
        Me.txt_kdbarang.Size = New System.Drawing.Size(137, 20)
        Me.txt_kdbarang.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txt_kdbarang, "Kode Barang")
        '
        'txt_namabarang
        '
        Me.txt_namabarang.Location = New System.Drawing.Point(92, 132)
        Me.txt_namabarang.Name = "txt_namabarang"
        Me.txt_namabarang.Size = New System.Drawing.Size(151, 20)
        Me.txt_namabarang.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.txt_namabarang, "Nama Barang")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Kode Barang :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nama Barang :"
        '
        'lb_barang
        '
        Me.lb_barang.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.kdbarang, Me.namabarang, Me.kategori})
        Me.lb_barang.FullRowSelect = True
        Me.lb_barang.Location = New System.Drawing.Point(272, 57)
        Me.lb_barang.Name = "lb_barang"
        Me.lb_barang.Size = New System.Drawing.Size(320, 171)
        Me.lb_barang.TabIndex = 12
        Me.lb_barang.UseCompatibleStateImageBehavior = False
        Me.lb_barang.View = System.Windows.Forms.View.Details
        '
        'kdbarang
        '
        Me.kdbarang.Text = "Kode Barang"
        Me.kdbarang.Width = 105
        '
        'namabarang
        '
        Me.namabarang.Text = "Nama Barang"
        Me.namabarang.Width = 107
        '
        'kategori
        '
        Me.kategori.Text = "Kategori"
        Me.kategori.Width = 100
        '
        'cmb_kategori
        '
        Me.cmb_kategori.FormattingEnabled = True
        Me.cmb_kategori.Location = New System.Drawing.Point(433, 30)
        Me.cmb_kategori.Name = "cmb_kategori"
        Me.cmb_kategori.Size = New System.Drawing.Size(121, 21)
        Me.cmb_kategori.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.cmb_kategori, "Kategori Barang")
        '
        'txt_qty
        '
        Me.txt_qty.Location = New System.Drawing.Point(92, 184)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(62, 20)
        Me.txt_qty.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.txt_qty, "Jumlah Barang")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "No. EAN :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Jumlah :"
        '
        'txt_noean
        '
        Me.txt_noean.Location = New System.Drawing.Point(92, 107)
        Me.txt_noean.Name = "txt_noean"
        Me.txt_noean.Size = New System.Drawing.Size(100, 20)
        Me.txt_noean.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.txt_noean, "Nomor EAN")
        '
        'txt_kategori
        '
        Me.txt_kategori.Location = New System.Drawing.Point(92, 158)
        Me.txt_kategori.Name = "txt_kategori"
        Me.txt_kategori.Size = New System.Drawing.Size(100, 20)
        Me.txt_kategori.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.txt_kategori, "Kategori Barang")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Kategori :"
        '
        'btn_simpan
        '
        Me.btn_simpan.Image = Global.Project_Work.My.Resources.Resources.cart_go
        Me.btn_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_simpan.Location = New System.Drawing.Point(272, 234)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(66, 26)
        Me.btn_simpan.TabIndex = 20
        Me.btn_simpan.Text = "&Simpan"
        Me.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btn_simpan, "Simpan Pack Barang")
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'txt_tgl
        '
        Me.txt_tgl.AutoSize = True
        Me.txt_tgl.Location = New System.Drawing.Point(71, 19)
        Me.txt_tgl.Name = "txt_tgl"
        Me.txt_tgl.Size = New System.Drawing.Size(46, 13)
        Me.txt_tgl.TabIndex = 21
        Me.txt_tgl.Text = "Tanggal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Tanggal :"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(101, 238)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(100, 20)
        Me.txt_total.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.txt_total, "Total Harga")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Total Harga :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(352, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Pilih Kategori :"
        '
        'pctdus
        '
        Me.pctdus.Image = Global.Project_Work.My.Resources.Resources._error
        Me.pctdus.Location = New System.Drawing.Point(208, 48)
        Me.pctdus.Name = "pctdus"
        Me.pctdus.Size = New System.Drawing.Size(21, 20)
        Me.pctdus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctdus.TabIndex = 26
        Me.pctdus.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pctdus, "Nomor DUS Harus Di Isi")
        '
        'FormPackBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 511)
        Me.Controls.Add(Me.pctdus)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_tgl)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_kategori)
        Me.Controls.Add(Me.txt_noean)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.cmb_kategori)
        Me.Controls.Add(Me.lb_barang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_namabarang)
        Me.Controls.Add(Me.txt_kdbarang)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_dus)
        Me.Controls.Add(Me.DGVpack)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPackBarang"
        Me.Text = "FormPackBarang"
        CType(Me.DGVpack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctdus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVpack As System.Windows.Forms.DataGridView
    Friend WithEvents txt_dus As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_tambah As System.Windows.Forms.Button
    Friend WithEvents txt_kdbarang As System.Windows.Forms.TextBox
    Friend WithEvents txt_namabarang As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lb_barang As System.Windows.Forms.ListView
    Friend WithEvents kdbarang As System.Windows.Forms.ColumnHeader
    Friend WithEvents namabarang As System.Windows.Forms.ColumnHeader
    Friend WithEvents kategori As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmb_kategori As System.Windows.Forms.ComboBox
    Friend WithEvents txt_qty As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_noean As System.Windows.Forms.TextBox
    Friend WithEvents txt_kategori As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents txt_tgl As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents pctdus As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
