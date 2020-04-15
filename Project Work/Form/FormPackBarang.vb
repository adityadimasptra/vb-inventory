Imports System.Data.OleDb
Public Class FormPackBarang
    Sub Kosongkan()
        txt_kategori.Text = ""
        txt_kdbarang.Text = ""
        txt_namabarang.Text = ""
        txt_noean.Text = ""
        txt_qty.Text = ""
        txt_dus.Text = ""
    End Sub
    '' Private Sub AutoNomorDus()
    '' cmd = New OleDbCommand("SELECT count(nomor_pack) FROM tb_pack", con)
    '' rd = cmd.ExecuteReader
    '' rd.Read()
    ''If rd.HasRows Then
    ''    txt_dus.Text = ("PCK-" + Format(Date.Now, "ddyyyymmhhssmm")) & txt_dus.Text()
    ''End If
    ''End Sub
    Sub TampilKategori()
        cmd = New OleDbCommand("SELECT kategori FROM tb_kategori ORDER BY kategori ASC", con)
        rd = cmd.ExecuteReader
        cmb_kategori.Items.Clear()
        Do While rd.Read
            cmb_kategori.Items.Add(rd.Item(0))
        Loop
    End Sub
    Sub TampilBerdasarkanKategori()
        cmd = New OleDbCommand("SELECT * FROM tb_barang where kategori ='" & cmb_kategori.Text & "'", con)
        rd = cmd.ExecuteReader
        lb_barang.Items.Clear()
        Do While rd.Read
            Dim item As ListViewItem
            item = lb_barang.Items.Add(rd(0))
            item.SubItems.Add(rd.Item(2)).ToString()
            item.SubItems.Add(rd.Item(3)).ToString()
        Loop
    End Sub
    Sub AturKolomDGV()
        DGVpack.Columns.Add("Kode", "Kode")
        DGVpack.Columns.Add("NomorEan", "Nomor Ean")
        DGVpack.Columns.Add("Nama", "Nama Barang")
        DGVpack.Columns.Add("Kategori", "Kategori")
        DGVpack.Columns.Add("Harga", "Harga")
        DGVpack.Columns.Add("Jumlah", "Jumlah")
        DGVpack.Columns.Add("Total", "Total")
    End Sub
    Private Sub FormPackBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Kosongkan()
        ''Call AutoNomorDus()
        Call TampilKategori()
        Call AturKolomDGV()
        cmb_kategori.DropDownHeight = cmb_kategori.ItemHeight * 8
        DGVpack.ReadOnly = True
        txt_tgl.Text = Today
        txt_kdbarang.Enabled = False
        txt_namabarang.Enabled = False
        txt_kategori.Enabled = False
        txt_noean.Enabled = False
        ''txt_dus.Enabled = False
    End Sub
    Sub TampilKlikBarang()
        cmd = New OleDbCommand("Select * from tb_barang where kode_barang='" & lb_barang.SelectedItems(0).Text & "'", con)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txt_kdbarang.Text = rd.Item(0)
            txt_noean.Text = rd.Item(1)
            txt_namabarang.Text = rd.Item(2)
            txt_kategori.Text = rd.Item(3)
        End If
    End Sub
    Sub TotalHarga()
        Dim Harga As Integer = 0
        For I As Integer = 0 To DGVpack.Rows.Count - 1
            Harga = Harga + Val(DGVpack.Rows(I).Cells(6).Value)
            txt_total.Text = Harga
        Next
    End Sub
    Sub TambahBarang()
        If txt_qty.Text = "0" Or txt_qty.Text = "" Then
            MsgBox("Jumlah Barang Masih Kosong")
        ElseIf txt_dus.Text = "" Then
            MsgBox("Nomor Dus Masih Kosong")
            Exit Sub
        End If
        cmd = New OleDbCommand("SELECT * FROM tb_barang WHERE kode_barang='" & txt_kdbarang.Text & "'", con)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            If txt_qty.Text > rd.Item(4) Then
                MessageBox.Show("Barang tersisa : " & rd.Item(4) & "")
            Else
                Dim I As Integer = DGVpack.Rows.Count - 1
                DGVpack.Rows.Add("", "", "", "", "", "", "", "", "", "")
                DGVpack.Rows(I).Cells(0).Value = txt_kdbarang.Text  'kode barang
                DGVpack.Rows(I).Cells(1).Value = txt_noean.Text  'nomor ean
                DGVpack.Rows(I).Cells(2).Value = txt_namabarang.Text 'nama barang
                DGVpack.Rows(I).Cells(3).Value = txt_kategori.Text 'kategori
                DGVpack.Rows(I).Cells(4).Value = rd.Item(5) 'harga barang
                DGVpack.Rows(I).Cells(5).Value = txt_qty.Text 'jumlah barang
                DGVpack.Rows(I).Cells(6).Value = DGVpack.Rows(I).Cells(4).Value * Val(txt_qty.Text) 'total barang
                Call TotalHarga()
                txt_dus.Enabled = False
                txt_kategori.Text = ""
                txt_kdbarang.Text = ""
                txt_namabarang.Text = ""
                txt_noean.Text = ""
                txt_qty.Text = ""
                txt_qty.Focus()
            End If
        End If
        Dim C As Integer = DGVpack.Rows.Count - 1
        DGVpack.Rows(C).Cells(6).Value = DGVpack.Rows(C).Cells(4).Value * Val(txt_qty.Text)
        If Not rd.HasRows Then
            MsgBox("Barang Tidak Ada")
            Dim A As Integer = DGVpack.Rows.Count - 1
            DGVpack.Rows(A).Cells(0).Value = ""
        End If
        
    End Sub
    Sub TambahPack()
        Dim KodeBarang, NamaBarang, KategoriBarang, HargaBarang, TotalHarga As String
        Dim JumlahBarang, NoEAN As Integer
        For I As Integer = 0 To DGVpack.Rows.Count - 2
            KodeBarang = DGVpack.Rows(I).Cells(0).Value
            NoEAN = DGVpack.Rows(I).Cells(1).Value
            NamaBarang = DGVpack.Rows(I).Cells(2).Value
            KategoriBarang = DGVpack.Rows(I).Cells(3).Value
            HargaBarang = DGVpack.Rows(I).Cells(4).Value
            JumlahBarang = DGVpack.Rows(I).Cells(5).Value
            TotalHarga = DGVpack.Rows(I).Cells(5).Value * DGVpack.Rows(I).Cells(5).Value

            Dim inputpack As String = "INSERT INTO tb_pack VALUES('" & txt_dus.Text & "', '" & KodeBarang & "','" & NoEAN & "', '" & NamaBarang & "', '" & KategoriBarang & "','" & JumlahBarang & "','" & HargaBarang & "', '" & Val(JumlahBarang) * Val(HargaBarang) & "','" & txt_tgl.Text & "', '" & txt_tgl.Text & "')"
            cmd = New OleDbCommand(inputpack, con)
            cmd.ExecuteNonQuery()
            cmd = New OleDbCommand("SELECT * FROM tb_barang WHERE kode_barang='" & KodeBarang & "'", con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Dim SisaBarang As Integer = rd.Item(4)
                For a As Integer = 0 To DGVpack.Rows.Count - 2
                    KodeBarang = DGVpack.Rows(I).Cells(0).Value
                    Dim KurangJumlahBarang As String = "UPDATE tb_barang set qty='" & Val(SisaBarang) - Val(JumlahBarang) & "' WHERE kode_barang='" & KodeBarang & "'"
                    cmd = New OleDbCommand(KurangJumlahBarang, con)
                    cmd.ExecuteNonQuery()
                Next
            End If
        Next
        Dim inputpack1 As String = "INSERT INTO tb_detailpack VALUES('" & txt_dus.Text & "', '" & txt_total.Text & "','Belum')"
        cmd = New OleDbCommand(inputpack1, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Ditambah")
        Call Kosongkan()
        ''Call AutoNomorDus()
        txt_dus.Text = ""
    End Sub
    Sub ValidasiData()
        If txt_kdbarang.Text = "" Then
            MsgBox("Anda Belum Memilih Barang")
            Exit Sub
        End If
    End Sub
    Private Sub btn_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tambah.Click
        Call ValidasiData()
        Try
            cmd = New OleDbCommand("SELECT * FROM tb_detailpack WHERE nomor_pack ='" & txt_dus.Text & "'", con)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Call TambahBarang()
            Else
                MessageBox.Show("Nomor DUS tsb Sudah Terdaftar")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        If txt_total.Text = "" Then
            MsgBox("Semua Data Masih Kosong")
        Else
            Call TambahPack()
            Call Kosongkan()
            DGVpack.Columns.Clear()
            Call AturKolomDGV()
            txt_dus.Enabled = True
            txt_total.Text = ""
        End If
    End Sub
    Private Sub DGVpack_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGVpack.KeyDown
        If e.KeyCode = Keys.Delete Then
            If MessageBox.Show("Apakah anda ingin menghapus Semua Data yang sudah di pilih..?", "Perhatian", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                DGVpack.Rows.Clear()
                txt_total.Text = ""
                txt_dus.Enabled = True
            End If
        End If
    End Sub
    Private Sub cmb_kategori_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_kategori.KeyPress
        e.Handled = True
    End Sub
    Private Sub cmb_kategori_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_kategori.SelectedIndexChanged
        Call TampilBerdasarkanKategori()
    End Sub
    Private Sub lb_barang_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lb_barang.Click
        Call TampilKlikBarang()
    End Sub
    Private Sub txt_qty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_qty.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub
    Private Sub DGVpack_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DGVpack.RowsAdded
        Dim rowNumber As Integer = 1
        For Each row As DataGridViewRow In DGVpack.Rows
            If row.IsNewRow Then Continue For
            row.HeaderCell.Value = rowNumber.ToString
            rowNumber = rowNumber + 1
        Next
    End Sub

    Private Sub txt_total_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_total.KeyPress
        e.Handled = True
    End Sub
End Class