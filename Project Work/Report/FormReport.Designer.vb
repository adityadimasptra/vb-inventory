<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReport))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.grp_interval2 = New System.Windows.Forms.GroupBox
        Me.cmb_sampai2 = New System.Windows.Forms.ComboBox
        Me.cmb_dari2 = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.btn_intervalpack = New System.Windows.Forms.Button
        Me.grp_interval = New System.Windows.Forms.GroupBox
        Me.btn_interval = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmb_sampai = New System.Windows.Forms.ComboBox
        Me.cmb_dari = New System.Windows.Forms.ComboBox
        Me.grp_bulanan2 = New System.Windows.Forms.GroupBox
        Me.cmb_tahun2 = New System.Windows.Forms.ComboBox
        Me.cmb_bulan2 = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btn_bulananpack = New System.Windows.Forms.Button
        Me.grp_bulanan = New System.Windows.Forms.GroupBox
        Me.btn_bulanan = New System.Windows.Forms.Button
        Me.cmb_tahun = New System.Windows.Forms.ComboBox
        Me.cmb_bulan = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.grp_tahunan2 = New System.Windows.Forms.GroupBox
        Me.cmb_tahunan2 = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btn_tahunanpack = New System.Windows.Forms.Button
        Me.grp_tahunan = New System.Windows.Forms.GroupBox
        Me.btn_tahunanbarang = New System.Windows.Forms.Button
        Me.lb_tahun = New System.Windows.Forms.Label
        Me.cmb_tahunan = New System.Windows.Forms.ComboBox
        Me.cb_intpack = New System.Windows.Forms.CheckBox
        Me.cb_intbarang = New System.Windows.Forms.CheckBox
        Me.cb_blnpack = New System.Windows.Forms.CheckBox
        Me.cb_blnbarang = New System.Windows.Forms.CheckBox
        Me.cb_thnpack = New System.Windows.Forms.CheckBox
        Me.cb_thnbarang = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ReportBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportPackbarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.GroupBox1.SuspendLayout()
        Me.grp_interval2.SuspendLayout()
        Me.grp_interval.SuspendLayout()
        Me.grp_bulanan2.SuspendLayout()
        Me.grp_bulanan.SuspendLayout()
        Me.grp_tahunan2.SuspendLayout()
        Me.grp_tahunan.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grp_interval2)
        Me.GroupBox1.Controls.Add(Me.grp_interval)
        Me.GroupBox1.Controls.Add(Me.grp_bulanan2)
        Me.GroupBox1.Controls.Add(Me.grp_bulanan)
        Me.GroupBox1.Controls.Add(Me.grp_tahunan2)
        Me.GroupBox1.Controls.Add(Me.grp_tahunan)
        Me.GroupBox1.Controls.Add(Me.cb_intpack)
        Me.GroupBox1.Controls.Add(Me.cb_intbarang)
        Me.GroupBox1.Controls.Add(Me.cb_blnpack)
        Me.GroupBox1.Controls.Add(Me.cb_blnbarang)
        Me.GroupBox1.Controls.Add(Me.cb_thnpack)
        Me.GroupBox1.Controls.Add(Me.cb_thnbarang)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 481)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report"
        '
        'grp_interval2
        '
        Me.grp_interval2.Controls.Add(Me.cmb_sampai2)
        Me.grp_interval2.Controls.Add(Me.cmb_dari2)
        Me.grp_interval2.Controls.Add(Me.Label10)
        Me.grp_interval2.Controls.Add(Me.Label9)
        Me.grp_interval2.Controls.Add(Me.btn_intervalpack)
        Me.grp_interval2.Location = New System.Drawing.Point(12, 350)
        Me.grp_interval2.Name = "grp_interval2"
        Me.grp_interval2.Size = New System.Drawing.Size(200, 100)
        Me.grp_interval2.TabIndex = 7
        Me.grp_interval2.TabStop = False
        Me.grp_interval2.Text = "Cari Dengan Interval"
        '
        'cmb_sampai2
        '
        Me.cmb_sampai2.FormattingEnabled = True
        Me.cmb_sampai2.Location = New System.Drawing.Point(73, 49)
        Me.cmb_sampai2.Name = "cmb_sampai2"
        Me.cmb_sampai2.Size = New System.Drawing.Size(121, 21)
        Me.cmb_sampai2.TabIndex = 4
        '
        'cmb_dari2
        '
        Me.cmb_dari2.FormattingEnabled = True
        Me.cmb_dari2.Location = New System.Drawing.Point(73, 24)
        Me.cmb_dari2.Name = "cmb_dari2"
        Me.cmb_dari2.Size = New System.Drawing.Size(121, 21)
        Me.cmb_dari2.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Sampai :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Dari :"
        '
        'btn_intervalpack
        '
        Me.btn_intervalpack.Location = New System.Drawing.Point(120, 73)
        Me.btn_intervalpack.Name = "btn_intervalpack"
        Me.btn_intervalpack.Size = New System.Drawing.Size(75, 23)
        Me.btn_intervalpack.TabIndex = 0
        Me.btn_intervalpack.Text = "Find"
        Me.btn_intervalpack.UseVisualStyleBackColor = True
        '
        'grp_interval
        '
        Me.grp_interval.Controls.Add(Me.btn_interval)
        Me.grp_interval.Controls.Add(Me.Label5)
        Me.grp_interval.Controls.Add(Me.Label4)
        Me.grp_interval.Controls.Add(Me.cmb_sampai)
        Me.grp_interval.Controls.Add(Me.cmb_dari)
        Me.grp_interval.Location = New System.Drawing.Point(12, 350)
        Me.grp_interval.Name = "grp_interval"
        Me.grp_interval.Size = New System.Drawing.Size(212, 113)
        Me.grp_interval.TabIndex = 9
        Me.grp_interval.TabStop = False
        Me.grp_interval.Text = "Cari Dengan Interval"
        '
        'btn_interval
        '
        Me.btn_interval.Location = New System.Drawing.Point(120, 88)
        Me.btn_interval.Name = "btn_interval"
        Me.btn_interval.Size = New System.Drawing.Size(75, 23)
        Me.btn_interval.TabIndex = 4
        Me.btn_interval.Text = "Find"
        Me.btn_interval.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Sampai"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Dari"
        '
        'cmb_sampai
        '
        Me.cmb_sampai.FormattingEnabled = True
        Me.cmb_sampai.Location = New System.Drawing.Point(70, 61)
        Me.cmb_sampai.Name = "cmb_sampai"
        Me.cmb_sampai.Size = New System.Drawing.Size(121, 21)
        Me.cmb_sampai.TabIndex = 1
        '
        'cmb_dari
        '
        Me.cmb_dari.FormattingEnabled = True
        Me.cmb_dari.Location = New System.Drawing.Point(70, 34)
        Me.cmb_dari.Name = "cmb_dari"
        Me.cmb_dari.Size = New System.Drawing.Size(121, 21)
        Me.cmb_dari.TabIndex = 0
        '
        'grp_bulanan2
        '
        Me.grp_bulanan2.Controls.Add(Me.cmb_tahun2)
        Me.grp_bulanan2.Controls.Add(Me.cmb_bulan2)
        Me.grp_bulanan2.Controls.Add(Me.Label8)
        Me.grp_bulanan2.Controls.Add(Me.Label7)
        Me.grp_bulanan2.Controls.Add(Me.btn_bulananpack)
        Me.grp_bulanan2.Location = New System.Drawing.Point(12, 213)
        Me.grp_bulanan2.Name = "grp_bulanan2"
        Me.grp_bulanan2.Size = New System.Drawing.Size(200, 100)
        Me.grp_bulanan2.TabIndex = 6
        Me.grp_bulanan2.TabStop = False
        Me.grp_bulanan2.Text = "Cari Berdasarkan Bulanan"
        '
        'cmb_tahun2
        '
        Me.cmb_tahun2.FormattingEnabled = True
        Me.cmb_tahun2.Location = New System.Drawing.Point(69, 47)
        Me.cmb_tahun2.Name = "cmb_tahun2"
        Me.cmb_tahun2.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tahun2.TabIndex = 4
        '
        'cmb_bulan2
        '
        Me.cmb_bulan2.FormattingEnabled = True
        Me.cmb_bulan2.Location = New System.Drawing.Point(69, 21)
        Me.cmb_bulan2.Name = "cmb_bulan2"
        Me.cmb_bulan2.Size = New System.Drawing.Size(121, 21)
        Me.cmb_bulan2.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Tahun :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Bulan :"
        '
        'btn_bulananpack
        '
        Me.btn_bulananpack.Location = New System.Drawing.Point(119, 71)
        Me.btn_bulananpack.Name = "btn_bulananpack"
        Me.btn_bulananpack.Size = New System.Drawing.Size(75, 23)
        Me.btn_bulananpack.TabIndex = 0
        Me.btn_bulananpack.Text = "Find"
        Me.btn_bulananpack.UseVisualStyleBackColor = True
        '
        'grp_bulanan
        '
        Me.grp_bulanan.Controls.Add(Me.btn_bulanan)
        Me.grp_bulanan.Controls.Add(Me.cmb_tahun)
        Me.grp_bulanan.Controls.Add(Me.cmb_bulan)
        Me.grp_bulanan.Controls.Add(Me.Label3)
        Me.grp_bulanan.Controls.Add(Me.Label2)
        Me.grp_bulanan.Location = New System.Drawing.Point(12, 213)
        Me.grp_bulanan.Name = "grp_bulanan"
        Me.grp_bulanan.Size = New System.Drawing.Size(213, 131)
        Me.grp_bulanan.TabIndex = 8
        Me.grp_bulanan.TabStop = False
        Me.grp_bulanan.Text = "Cari Berdasarkan Bulanan "
        '
        'btn_bulanan
        '
        Me.btn_bulanan.Location = New System.Drawing.Point(120, 97)
        Me.btn_bulanan.Name = "btn_bulanan"
        Me.btn_bulanan.Size = New System.Drawing.Size(75, 23)
        Me.btn_bulanan.TabIndex = 4
        Me.btn_bulanan.Text = "Find"
        Me.btn_bulanan.UseVisualStyleBackColor = True
        '
        'cmb_tahun
        '
        Me.cmb_tahun.FormattingEnabled = True
        Me.cmb_tahun.Location = New System.Drawing.Point(71, 70)
        Me.cmb_tahun.Name = "cmb_tahun"
        Me.cmb_tahun.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tahun.TabIndex = 3
        '
        'cmb_bulan
        '
        Me.cmb_bulan.FormattingEnabled = True
        Me.cmb_bulan.Location = New System.Drawing.Point(71, 39)
        Me.cmb_bulan.Name = "cmb_bulan"
        Me.cmb_bulan.Size = New System.Drawing.Size(121, 21)
        Me.cmb_bulan.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tahun"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Bulan"
        '
        'grp_tahunan2
        '
        Me.grp_tahunan2.Controls.Add(Me.cmb_tahunan2)
        Me.grp_tahunan2.Controls.Add(Me.Label6)
        Me.grp_tahunan2.Controls.Add(Me.btn_tahunanpack)
        Me.grp_tahunan2.Location = New System.Drawing.Point(6, 128)
        Me.grp_tahunan2.Name = "grp_tahunan2"
        Me.grp_tahunan2.Size = New System.Drawing.Size(200, 100)
        Me.grp_tahunan2.TabIndex = 5
        Me.grp_tahunan2.TabStop = False
        Me.grp_tahunan2.Text = "Cari Berdasarkan Tahunan"
        '
        'cmb_tahunan2
        '
        Me.cmb_tahunan2.FormattingEnabled = True
        Me.cmb_tahunan2.Location = New System.Drawing.Point(74, 33)
        Me.cmb_tahunan2.Name = "cmb_tahunan2"
        Me.cmb_tahunan2.Size = New System.Drawing.Size(116, 21)
        Me.cmb_tahunan2.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Tahun :"
        '
        'btn_tahunanpack
        '
        Me.btn_tahunanpack.Location = New System.Drawing.Point(119, 71)
        Me.btn_tahunanpack.Name = "btn_tahunanpack"
        Me.btn_tahunanpack.Size = New System.Drawing.Size(75, 23)
        Me.btn_tahunanpack.TabIndex = 0
        Me.btn_tahunanpack.Text = "Find"
        Me.btn_tahunanpack.UseVisualStyleBackColor = True
        '
        'grp_tahunan
        '
        Me.grp_tahunan.Controls.Add(Me.btn_tahunanbarang)
        Me.grp_tahunan.Controls.Add(Me.lb_tahun)
        Me.grp_tahunan.Controls.Add(Me.cmb_tahunan)
        Me.grp_tahunan.Location = New System.Drawing.Point(6, 128)
        Me.grp_tahunan.Name = "grp_tahunan"
        Me.grp_tahunan.Size = New System.Drawing.Size(216, 79)
        Me.grp_tahunan.TabIndex = 7
        Me.grp_tahunan.TabStop = False
        Me.grp_tahunan.Text = "Cari Berdasarkan Tahunan"
        '
        'btn_tahunanbarang
        '
        Me.btn_tahunanbarang.Location = New System.Drawing.Point(120, 52)
        Me.btn_tahunanbarang.Name = "btn_tahunanbarang"
        Me.btn_tahunanbarang.Size = New System.Drawing.Size(75, 23)
        Me.btn_tahunanbarang.TabIndex = 7
        Me.btn_tahunanbarang.Text = "Find"
        Me.btn_tahunanbarang.UseVisualStyleBackColor = True
        '
        'lb_tahun
        '
        Me.lb_tahun.AutoSize = True
        Me.lb_tahun.Location = New System.Drawing.Point(18, 29)
        Me.lb_tahun.Name = "lb_tahun"
        Me.lb_tahun.Size = New System.Drawing.Size(44, 13)
        Me.lb_tahun.TabIndex = 6
        Me.lb_tahun.Text = "Tahun :"
        '
        'cmb_tahunan
        '
        Me.cmb_tahunan.FormattingEnabled = True
        Me.cmb_tahunan.Location = New System.Drawing.Point(74, 26)
        Me.cmb_tahunan.Name = "cmb_tahunan"
        Me.cmb_tahunan.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tahunan.TabIndex = 5
        '
        'cb_intpack
        '
        Me.cb_intpack.AutoSize = True
        Me.cb_intpack.Location = New System.Drawing.Point(172, 102)
        Me.cb_intpack.Name = "cb_intpack"
        Me.cb_intpack.Size = New System.Drawing.Size(61, 17)
        Me.cb_intpack.TabIndex = 4
        Me.cb_intpack.Text = "Interval"
        Me.cb_intpack.UseVisualStyleBackColor = True
        '
        'cb_intbarang
        '
        Me.cb_intbarang.AutoSize = True
        Me.cb_intbarang.Location = New System.Drawing.Point(106, 100)
        Me.cb_intbarang.Name = "cb_intbarang"
        Me.cb_intbarang.Size = New System.Drawing.Size(61, 17)
        Me.cb_intbarang.TabIndex = 4
        Me.cb_intbarang.Text = "Interval"
        Me.cb_intbarang.UseVisualStyleBackColor = True
        '
        'cb_blnpack
        '
        Me.cb_blnpack.AutoSize = True
        Me.cb_blnpack.Location = New System.Drawing.Point(172, 79)
        Me.cb_blnpack.Name = "cb_blnpack"
        Me.cb_blnpack.Size = New System.Drawing.Size(65, 17)
        Me.cb_blnpack.TabIndex = 3
        Me.cb_blnpack.Text = "Bulanan"
        Me.cb_blnpack.UseVisualStyleBackColor = True
        '
        'cb_blnbarang
        '
        Me.cb_blnbarang.AutoSize = True
        Me.cb_blnbarang.Location = New System.Drawing.Point(106, 77)
        Me.cb_blnbarang.Name = "cb_blnbarang"
        Me.cb_blnbarang.Size = New System.Drawing.Size(65, 17)
        Me.cb_blnbarang.TabIndex = 3
        Me.cb_blnbarang.Text = "Bulanan"
        Me.cb_blnbarang.UseVisualStyleBackColor = True
        '
        'cb_thnpack
        '
        Me.cb_thnpack.AutoSize = True
        Me.cb_thnpack.Location = New System.Drawing.Point(172, 54)
        Me.cb_thnpack.Name = "cb_thnpack"
        Me.cb_thnpack.Size = New System.Drawing.Size(69, 17)
        Me.cb_thnpack.TabIndex = 2
        Me.cb_thnpack.Text = "Tahunan"
        Me.cb_thnpack.UseVisualStyleBackColor = True
        '
        'cb_thnbarang
        '
        Me.cb_thnbarang.AutoSize = True
        Me.cb_thnbarang.Location = New System.Drawing.Point(106, 54)
        Me.cb_thnbarang.Name = "cb_thnbarang"
        Me.cb_thnbarang.Size = New System.Drawing.Size(69, 17)
        Me.cb_thnbarang.TabIndex = 2
        Me.cb_thnbarang.Text = "Tahunan"
        Me.cb_thnbarang.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cari Berdasarkan :"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GrayText
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportBarangToolStripMenuItem, Me.ReportPackbarangToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(222, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReportBarangToolStripMenuItem
        '
        Me.ReportBarangToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ReportBarangToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.ReportBarangToolStripMenuItem.Name = "ReportBarangToolStripMenuItem"
        Me.ReportBarangToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.ReportBarangToolStripMenuItem.Text = "Report Barang"
        Me.ReportBarangToolStripMenuItem.ToolTipText = "Click Here"
        '
        'ReportPackbarangToolStripMenuItem
        '
        Me.ReportPackbarangToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ReportPackbarangToolStripMenuItem.Name = "ReportPackbarangToolStripMenuItem"
        Me.ReportPackbarangToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.ReportPackbarangToolStripMenuItem.Text = "Report Packbarang"
        '
        'CRV
        '
        Me.CRV.ActiveViewIndex = -1
        Me.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV.DisplayGroupTree = False
        Me.CRV.Location = New System.Drawing.Point(246, 28)
        Me.CRV.Name = "CRV"
        Me.CRV.SelectionFormula = ""
        Me.CRV.Size = New System.Drawing.Size(803, 535)
        Me.CRV.TabIndex = 1
        Me.CRV.ViewTimeSelectionFormula = ""
        '
        'FormReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(1061, 575)
        Me.Controls.Add(Me.CRV)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grp_interval2.ResumeLayout(False)
        Me.grp_interval2.PerformLayout()
        Me.grp_interval.ResumeLayout(False)
        Me.grp_interval.PerformLayout()
        Me.grp_bulanan2.ResumeLayout(False)
        Me.grp_bulanan2.PerformLayout()
        Me.grp_bulanan.ResumeLayout(False)
        Me.grp_bulanan.PerformLayout()
        Me.grp_tahunan2.ResumeLayout(False)
        Me.grp_tahunan2.PerformLayout()
        Me.grp_tahunan.ResumeLayout(False)
        Me.grp_tahunan.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ReportBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportPackbarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cb_intbarang As System.Windows.Forms.CheckBox
    Friend WithEvents cb_blnbarang As System.Windows.Forms.CheckBox
    Friend WithEvents cb_thnbarang As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lb_tahun As System.Windows.Forms.Label
    Friend WithEvents cmb_tahunan As System.Windows.Forms.ComboBox
    Friend WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents grp_tahunan As System.Windows.Forms.GroupBox
    Friend WithEvents grp_bulanan As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_tahun As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_bulan As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grp_interval As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_sampai As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_dari As System.Windows.Forms.ComboBox
    Friend WithEvents btn_interval As System.Windows.Forms.Button
    Friend WithEvents btn_bulanan As System.Windows.Forms.Button
    Friend WithEvents btn_tahunanbarang As System.Windows.Forms.Button
    Friend WithEvents cb_thnpack As System.Windows.Forms.CheckBox
    Friend WithEvents cb_blnpack As System.Windows.Forms.CheckBox
    Friend WithEvents cb_intpack As System.Windows.Forms.CheckBox
    Friend WithEvents grp_tahunan2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_tahunan2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_tahunanpack As System.Windows.Forms.Button
    Friend WithEvents grp_bulanan2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_tahun2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_bulan2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_bulananpack As System.Windows.Forms.Button
    Friend WithEvents grp_interval2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_dari2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_intervalpack As System.Windows.Forms.Button
    Friend WithEvents cmb_sampai2 As System.Windows.Forms.ComboBox
End Class
