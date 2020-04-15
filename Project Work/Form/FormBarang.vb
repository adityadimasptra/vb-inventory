Imports System.Data.OleDb
Public Class FormBarang
    Sub TampilData()
        da = New OleDbDataAdapter("SELECT * FROM tb_barang", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, " tb_barang")
        DGVbarang.DataSource = (ds.Tables(" tb_barang"))
        DGVbarang.ReadOnly = True
    End Sub

    Private Sub AutoKodeBarang()
        cmd = New OleDbCommand("SELECT count(kode_barang) FROM tb_barang", con)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txt_kdbarang.Text = ("BRG-" + Format(Date.Now, "ddyyyymmhhssmm")) & txt_kdbarang.Text
        End If
    End Sub

    Sub TampilKategori()
        cmd = New OleDbCommand("SELECT kategori FROM tb_kategori ORDER BY kategori ASC", con)
        rd = cmd.ExecuteReader
        cmb_kategori.Items.Clear()
        Do While rd.Read
            cmb_kategori.Items.Add(rd.Item(0))
        Loop
    End Sub
    Sub AturKolom()
        DGVbarang.Columns("kode_barang").HeaderText = "ID Barang"
        DGVbarang.Columns("kode_barang").Width = 130
        DGVbarang.Columns("no_ean").HeaderText = "No Ean"
        DGVbarang.Columns("no_ean").Width = 75
        DGVbarang.Columns("nama_barang").HeaderText = "Nama Barang"
        DGVbarang.Columns("nama_barang").Width = 120
        DGVbarang.Columns("kategori").HeaderText = "Kategori"
        DGVbarang.Columns("kategori").Width = 80
        DGVbarang.Columns("qty").HeaderText = "Jumlah"
        DGVbarang.Columns("qty").Width = 40
        DGVbarang.Columns("harga").HeaderText = "Harga"
        DGVbarang.Columns("harga").Width = 80
        DGVbarang.Columns("tgl_dibuat").HeaderText = "Tgl Dibuat"
        DGVbarang.Columns("tgl_dibuat").Width = 70
        DGVbarang.Columns("tgl_input").HeaderText = "Tgl Input"
        DGVbarang.Columns("tgl_input").Width = 70
        DGVbarang.Columns("tgl_update").HeaderText = "Tgl Update"
        DGVbarang.Columns("tgl_update").Width = 70

    End Sub
    Sub Kosongkan()
        txt_kdbarang.Text = ""
        txt_nmbarang.Text = ""
        cmb_kategori.Text = ""
        txt_noean.Text = ""
        txt_jumlah.Text = ""
        txt_harga.Text = ""
        txt_cari.Text = ""
        cmb_sortby.Text = ""
        cmb_tglbuat.Text = ""
    End Sub
    Sub ValidasiData()
        If txt_kdbarang.Text = "" Then
            MsgBox("Kode Barang Masih Kosong")
        ElseIf txt_nmbarang.Text = "" Then
            MsgBox("Nama Barang Masih Kosong")
        ElseIf cmb_kategori.Text = "" Then
            MsgBox("Kategori Masih Kosong")
        ElseIf cmb_tglbuat.Text = "" Then
            MsgBox("Tanggal Buat Masih Kosong")
        ElseIf txt_jumlah.Text = "" Then
            MsgBox("Jumlah Barang Masih Kosong")
        ElseIf txt_harga.Text = "" Then
            MsgBox("Harga Barang Masih Kosong")
            Exit Sub
        End If
    End Sub

    Sub TambahData()
        Call ValidasiData()
        Try
            cmd = New OleDbCommand("SELECT * FROM tb_barang WHERE kode_barang ='" & txt_kdbarang.Text & "'", con)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim sqltambah As String = " INSERT INTO tb_barang(kode_barang, no_ean, nama_barang, kategori, qty, harga, tgl_dibuat, tgl_input) VALUES ('" & txt_kdbarang.Text & "','" & txt_noean.Text & "','" & txt_nmbarang.Text & "','" & cmb_kategori.Text & "','" & txt_jumlah.Text & "','" & txt_harga.Text & "','" & cmb_tglbuat.Text & "','" & lbl_tgl.Text & "')"
                cmd = New OleDbCommand(sqltambah, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil di tambah", "ADEES Confirmation")
                Call Kosongkan()
                Call TampilData()
                Call AutoKodeBarang()
            Else
                Call Kosongkan()
                Call TampilData()
                Call AutoKodeBarang()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub UpdateData()
        Call ValidasiData()
        Try
            If MessageBox.Show("Apakah anda ingin merubah data Barang '" & txt_nmbarang.Text & "' ?", "Perhatian", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim ubah As String = " UPDATE tb_barang SET no_ean ='" & txt_noean.Text & "', nama_barang ='" & txt_nmbarang.Text & "', kategori = '" & cmb_kategori.Text & "', qty = '" & txt_jumlah.Text & "', harga = '" & txt_harga.Text & "', tgl_dibuat = '" & cmb_tglbuat.Text & "', tgl_update = '" & lbl_tgl.Text & "' WHERE kode_barang = '" & txt_kdbarang.Text & "'"
                cmd = New OleDbCommand(ubah, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Di Ubah", "INFO")
                Call Kosongkan()
                Call AutoKodeBarang()
                Call TampilData()
            Else
                Call Kosongkan()
                Call AutoKodeBarang()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Sub HapusData()
        Try
            cmd = New OleDbCommand("SELECT * FROM tb_barang WHERE kode_barang='" & txt_kdbarang.Text & "'", con)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                MsgBox("Pilih Barang Dahulu Sebelum Menghapus")
            Else
                If MessageBox.Show("Apakah anda ingin menghapus '" & txt_nmbarang.Text & "' ?", "Perhatian", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    cmd = New OleDbCommand("DELETE FROM tb_barang WHERE kode_barang='" & txt_kdbarang.Text & "'", con)
                    rd = cmd.ExecuteReader
                    rd.Read()
                    MsgBox("Data Berhasil Dihapus")
                    Call Kosongkan()
                    Call AutoKodeBarang()
                    Call TampilData()
                Else
                    Call Kosongkan()
                    Call AutoKodeBarang()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub SortBy()
        cmb_sortby.Items.Add("Nama Barang")
        cmb_sortby.Items.Add("Kategori")
        cmb_sortby.Items.Add("Kode Barang")
    End Sub
    Sub CariBarang()
        Dim dt As New DataTable
        Dim sSQL As String = String.Empty
        If cmb_sortby.Text = "" Then
            MsgBox("Anda belum memilih urutan")
        End If
        'try catch block is used to catch the error
        Try
            'get connection string declared in the Module1.vb and assing it to conn variable
            con = New OleDbConnection(Get_Constring)
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            sSQL = "SELECT kode_barang, no_ean, nama_barang, kategori, qty, harga, tgl_dibuat, tgl_input, tgl_update FROM tb_barang"
            If Me.cmb_sortby.Text = "Nama Barang" Then
                sSQL = sSQL & " WHERE nama_barang LIKE '%" & Me.txt_cari.Text & "%'"
            ElseIf Me.cmb_sortby.Text = "Kategori" Then
                sSQL = sSQL & " WHERE kategori LIKE '%" & Me.txt_cari.Text & "%'"
            ElseIf Me.cmb_sortby.Text = "Kode Barang" Then
                sSQL = sSQL & " WHERE kode_barang LIKE '%" & Me.txt_cari.Text & "%'"
            End If
            cmd.CommandText = sSQL
            da.SelectCommand = cmd
            da.Fill(dt)

            Me.DGVbarang.DataSource = dt
            If dt.Rows.Count = 0 Then
                MsgBox("Barang Tidak Ditemukan")
                Call TampilData()
            End If
        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try
    End Sub
    Private Sub FormBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Kosongkan()
        Call TampilData()
        Call AutoKodeBarang()
        Call TampilKategori()
        Call SortBy()
        Call AturKolom()
        cmb_kategori.DropDownHeight = cmb_kategori.ItemHeight * 8
        lbl_tgl.Text = Today
        txt_nmbarang.Focus()
        txt_kdbarang.Enabled = False
        btn_delete.Enabled = False
        btn_refresh.Enabled = False
        btn_update.Enabled = False
    End Sub

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        Call TambahData()
        btn_simpan.Enabled = True
        btn_delete.Enabled = False
        btn_update.Enabled = False
        btn_refresh.Enabled = False
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Call UpdateData()
        btn_simpan.Enabled = True
        btn_delete.Enabled = False
        btn_update.Enabled = False
        btn_refresh.Enabled = False
    End Sub

    Private Sub btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh.Click
        Call Kosongkan()
        Call AutoKodeBarang()
        btn_simpan.Enabled = True
        btn_delete.Enabled = False
        btn_update.Enabled = False
        btn_refresh.Enabled = False
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Call HapusData()
        btn_simpan.Enabled = True
        btn_delete.Enabled = False
        btn_update.Enabled = False
        btn_refresh.Enabled = False
    End Sub

    Private Sub DGVbarang_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVbarang.CellContentClick
        Try
            txt_kdbarang.Text = DGVbarang.Rows(e.RowIndex).Cells(0).Value
            txt_noean.Text = DGVbarang.Rows(e.RowIndex).Cells(1).Value
            txt_nmbarang.Text = DGVbarang.Rows(e.RowIndex).Cells(2).Value
            cmb_kategori.Text = DGVbarang.Rows(e.RowIndex).Cells(3).Value
            txt_jumlah.Text = DGVbarang.Rows(e.RowIndex).Cells(4).Value
            txt_harga.Text = DGVbarang.Rows(e.RowIndex).Cells(5).Value
            cmb_tglbuat.Text = DGVbarang.Rows(e.RowIndex).Cells(6).Value
            btn_simpan.Enabled = False
            btn_refresh.Enabled = True
            btn_delete.Enabled = True
            btn_update.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub cmb_kategori_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_kategori.KeyPress
        e.Handled = True
    End Sub

    Private Sub DGVbarang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGVbarang.KeyDown
        If e.KeyCode = Keys.Delete Then
            Call HapusData()
            btn_simpan.Enabled = True
            btn_delete.Enabled = False
            btn_update.Enabled = False
            btn_refresh.Enabled = False
        End If
    End Sub

    Private Sub txt_noean_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_noean.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub txt_jumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_jumlah.KeyPress
        txt_jumlah.MaxLength = 6
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub txt_harga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_harga.KeyPress
        txt_harga.MaxLength = 12
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub cmb_tglbuat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_tglbuat.KeyPress
        e.Handled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call CariBarang()
        txt_cari.Text = ""
    End Sub

    Private Sub DGVbarang_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DGVbarang.RowsAdded
        Dim rowNumber As Integer = 1
        For Each row As DataGridViewRow In DGVbarang.Rows
            If row.IsNewRow Then Continue For
            row.HeaderCell.Value = rowNumber.ToString
            rowNumber = rowNumber + 1
        Next
    End Sub
End Class