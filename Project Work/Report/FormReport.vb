Imports System.Data.OleDb
Imports Project_Work.FormReport

Public Class FormReport
    Private Sub ReportBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportBarangToolStripMenuItem.Click
        ReportBarangToolStripMenuItem.ForeColor = Color.Red
        ReportPackbarangToolStripMenuItem.ForeColor = Color.White
        cb_thnbarang.Visible = True
        cb_blnbarang.Visible = True
        cb_intbarang.Visible = True
        Call ReportPackingHide()
    End Sub

    Sub ReportBarangHide()
        grp_tahunan.Visible = False
        grp_bulanan.Visible = False
        grp_interval.Visible = False
        cb_blnbarang.Visible = False
        cb_blnbarang.Checked = False
        cb_intbarang.Visible = False
        cb_intbarang.Checked = False
        cb_thnbarang.Visible = False
        cb_thnbarang.Checked = False
    End Sub
    Sub ReportBarangShow()
        grp_tahunan.Visible = True
        grp_bulanan.Visible = True
        grp_interval.Visible = True
        cb_blnbarang.Visible = True
        cb_intbarang.Visible = True
        cb_thnbarang.Visible = True
    End Sub

    Private Sub cb_thnbarang_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_thnbarang.CheckedChanged
        If cb_thnbarang.Checked Then
            grp_tahunan.Visible = True
            grp_tahunan.Location = New Point(6, 128)
            grp_interval.Visible = False
            grp_bulanan.Visible = False
            cb_intbarang.Checked = False
            cb_blnbarang.Checked = False
        ElseIf cb_thnbarang.Checked = False Then
            grp_tahunan.Visible = False
            Call Kosongkan()
            Call TampilTahunBarang()
        End If
    End Sub
    Private Sub cb_blnbarang_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_blnbarang.CheckedChanged
        If cb_blnbarang.Checked Then
            grp_bulanan.Visible = True
            grp_bulanan.Location = New Point(6, 128)
            grp_interval.Visible = False
            grp_tahunan.Visible = False
            cb_thnbarang.Checked = False
            cb_intbarang.Checked = False
        ElseIf cb_blnbarang.Checked = False Then
            grp_bulanan.Visible = False
            Call Kosongkan()
            Call TampilBulanBarang()
            Call TampilTahunBarang()
        End If
    End Sub
    Private Sub cb_intbarang_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_intbarang.CheckedChanged
        If cb_intbarang.Checked Then
            grp_interval.Visible = True
            grp_interval.Location = New Point(6, 128)
            grp_tahunan.Visible = False
            grp_bulanan.Visible = False
            cb_thnbarang.Checked = False
            cb_blnbarang.Checked = False
        ElseIf cb_intbarang.Checked = False Then
            grp_interval.Visible = False
            Call Kosongkan()
            Call TampilTanggalBarang()
        End If
    End Sub


    Sub TampilBulanBarang()
        cmd = New OleDbCommand("SELECT DISTINCT month(tgl_input) FROM tb_barang", con)
        rd = cmd.ExecuteReader
        cmb_bulan.Items.Clear()
        Do While rd.Read
            cmb_bulan.Items.Add(rd.Item(0))
        Loop
    End Sub
    Sub TampilTahunBarang()
        cmd = New OleDbCommand("SELECT DISTINCT year(tgl_input) FROM tb_barang", con)
        rd = cmd.ExecuteReader
        cmb_tahun.Items.Clear()
        cmb_tahunan.Items.Clear()
        Do While rd.Read
            cmb_tahun.Items.Add(rd.Item(0))
            cmb_tahunan.Items.Add(rd.Item(0))
        Loop
    End Sub
    Sub TampilTanggalBarang()
        cmd = New OleDbCommand("SELECT DISTINCT tgl_input FROM tb_barang", con)
        rd = cmd.ExecuteReader
        cmb_dari.Items.Clear()
        cmb_sampai.Items.Clear()
        Do While rd.Read
            cmb_dari.Items.Add(Format(rd.Item(0), "dd, MM, yyyy"))
            cmb_sampai.Items.Add(Format(rd.Item(0), "dd, MM, yyyy"))
        Loop
    End Sub

    Private Sub btn_tahunanbarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tahunanbarang.Click
        Try
            If cmb_tahunan.Text = "" Then
                MessageBox.Show("Maaf, pilihan anda masih kosong !", "INFORMATION")
                Exit Sub
            Else
                CRV.ReportSource = Nothing
                CRV.RefreshReport()
                'FormReportPengembalian.CRV.SelectionFormula = "totext({tb_pembayaran.tgl_pemb}) ='" & bulan.Text & "'"
                CRV.SelectionFormula = "Year({tb_barang.tgl_input})=  " & cmb_tahunan.Text
                'CRV.ReportSource = "CrystalReportBarang.rpt"
                CRV.ReportSource = "../../Report/CrystalReportBarang.rpt"
                'CRV.RefreshReport()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_bulanan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bulanan.Click
        Try
            If cmb_bulan.Text = "" Or cmb_tahun.Text = "" Then
                MessageBox.Show("Maaf, pilihan anda masih kosong !", "INFORMATION")
                Exit Sub
            Else

                CRV.ReportSource = Nothing
                CRV.RefreshReport()
                'FormReportPengembalian.CRV.SelectionFormula = "totext({tb_pembayaran.tgl_pemb}) ='" & bulan.Text & "'"
                CRV.SelectionFormula = "Month({tb_barang.tgl_input}) =" & cmb_bulan.Text & " AND Year({tb_barang.tgl_input}) =" & cmb_tahun.Text
                'CRV.ReportSource = "CrystalReportBarang.rpt"
                CRV.ReportSource = "../../Report/CrystalReportBarang.rpt"
                'CRV.RefreshReport()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_interval_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_interval.Click
        Try
            If cmb_dari.Text = "" Or cmb_sampai.Text = "" Then
                MessageBox.Show("Maaf, pilihan anda masih kosong !", "INFORMATION")
                Exit Sub
            Else

                CRV.ReportSource = Nothing
                CRV.RefreshReport()
                'CRV.SelectionFormula = "totext({tb_pengembalian.tgl_kembali}) ='" & bulan.Text & "'"
                CRV.SelectionFormula = "{tb_barang.tgl_input} in date ('" & cmb_dari.Text & "') to date ('" & cmb_sampai.Text & "')"
                'CRV.ReportSource = "CrystalReportBarang.rpt"
                CRV.ReportSource = "../../Report/CrystalReportBarang.rpt"
                'CRV.RefreshReport()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ReportPackbarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportPackbarangToolStripMenuItem.Click
        ReportPackbarangToolStripMenuItem.ForeColor = Color.Red
        ReportBarangToolStripMenuItem.ForeColor = Color.White
        cb_thnpack.Visible = True
        cb_blnpack.Visible = True
        cb_intpack.Visible = True
        Call ReportBarangHide()
    End Sub

    Sub ReportPackingHide()
        grp_tahunan2.Visible = False
        grp_bulanan2.Visible = False
        grp_interval2.Visible = False
        cb_blnpack.Visible = False
        cb_blnpack.Checked = False
        cb_intpack.Visible = False
        cb_intpack.Checked = False
        cb_thnpack.Visible = False
        cb_thnpack.Checked = False
    End Sub
    Sub ReportPackingShow()
        grp_tahunan2.Visible = True
        grp_bulanan2.Visible = True
        grp_interval2.Visible = True
        cb_blnpack.Visible = True
        cb_intpack.Visible = True
        cb_thnpack.Visible = True
    End Sub

    Private Sub cb_thnpack_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_thnpack.CheckedChanged
        If cb_thnpack.Checked Then
            grp_tahunan2.Visible = True
            grp_tahunan2.Location = New Point(6, 128)
            grp_interval2.Visible = False
            grp_bulanan2.Visible = False
            cb_intpack.Checked = False
            cb_blnpack.Checked = False
        ElseIf cb_thnpack.Checked = False Then
            grp_tahunan2.Visible = False
        End If
    End Sub
    Private Sub cb_blnpack_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_blnpack.CheckedChanged
        If cb_blnpack.Checked Then
            grp_bulanan2.Visible = True
            grp_bulanan2.Location = New Point(6, 128)
            grp_interval2.Visible = False
            grp_tahunan.Visible = False
            cb_thnpack.Checked = False
            cb_intpack.Checked = False
        ElseIf cb_blnpack.Checked = False Then
            grp_bulanan2.Visible = False
        End If
    End Sub
    Private Sub cb_intpack_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_intpack.CheckedChanged
        If cb_intpack.Checked Then
            grp_interval2.Visible = True
            grp_interval2.Location = New Point(6, 128)
            grp_tahunan2.Visible = False
            grp_bulanan2.Visible = False
            cb_thnpack.Checked = False
            cb_blnpack.Checked = False
        ElseIf cb_intpack.Checked = False Then
            grp_interval2.Visible = False
        End If
    End Sub


    Sub CheckBoxLocation()
        cb_blnbarang.Location = New Point(106, 77)
        cb_intbarang.Location = New Point(106, 100)
        cb_thnbarang.Location = New Point(106, 54)
        cb_blnpack.Location = New Point(106, 77)
        cb_intpack.Location = New Point(106, 100)
        cb_thnpack.Location = New Point(106, 54)
    End Sub
    Private Sub FormReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Kosongkan()
        ReportPackbarangToolStripMenuItem.Visible = False
        ReportBarangToolStripMenuItem.ForeColor = Color.White
        ReportPackbarangToolStripMenuItem.ForeColor = Color.White
        Call CheckBoxLocation()
        Call ReportBarangHide()
        Call ReportPackingHide()
        Call TampilBulanBarang()
        Call TampilTahunBarang()
        Call TampilTanggalBarang()
    End Sub
    Sub LimitCombobox()
        cmb_bulan.DropDownHeight = cmb_bulan.ItemHeight * 10
        cmb_bulan2.DropDownHeight = cmb_bulan2.ItemHeight * 10
        cmb_dari.DropDownHeight = cmb_dari.ItemHeight * 10
        cmb_dari2.DropDownHeight = cmb_dari2.ItemHeight * 10
        cmb_tahun.DropDownHeight = cmb_tahun.ItemHeight * 10
        cmb_tahun2.DropDownHeight = cmb_tahun2.ItemHeight * 10
        cmb_tahunan.DropDownHeight = cmb_tahunan.ItemHeight * 10
        cmb_tahunan2.DropDownHeight = cmb_tahunan2.ItemHeight * 10
        cmb_sampai.DropDownHeight = cmb_sampai.ItemHeight * 10
        cmb_sampai2.DropDownHeight = cmb_sampai2.ItemHeight * 10
    End Sub
    Sub Kosongkan()
        cmb_bulan.Text = ""
        cmb_bulan2.Text = ""
        cmb_dari.Text = ""
        cmb_dari2.Text = ""
        cmb_sampai.Text = ""
        cmb_sampai2.Text = ""
        cmb_tahun.Text = ""
        cmb_tahun2.Text = ""
        cmb_tahunan.Text = ""
        cmb_tahunan2.Text = ""
    End Sub
End Class