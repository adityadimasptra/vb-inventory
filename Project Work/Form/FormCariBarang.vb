Imports System.Data.OleDb
Public Class FormCariBarang
    Sub SortBy()
        cmb_sortby.Items.Add("No Pack")
        cmb_sortby.Items.Add("Tanggal Pack")
    End Sub
    Sub CariBarang()
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable
        Dim sSQL As String = String.Empty
        If cmb_sortby.Text = "" Then
            MsgBox("Anda belum memilih urutan")
            Exit Sub
        End If
        'try catch block is used to catch the error
        Try
            'get connection string declared in the Module1.vb and assing it to conn variable
            con = New OleDbConnection(Get_Constring)
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            sSQL = "SELECT nomor_pack, kode_barang, no_ean, nama_barang, kategori, qty, harga, harga_total, tgl_pack, tgl_updatepack FROM tb_pack"
            If Me.cmb_sortby.Text = "No Packed" Then
                sSQL = sSQL & " WHERE nomor_pack LIKE '%" & Me.txt_cari.Text & "%'"
            ElseIf Me.cmb_sortby.Text = "Tanggal Pack" Then
                sSQL = sSQL & " WHERE tgl_pack LIKE '%" & Me.cmb_tglpack.Text & "%'"
            End If
            cmd.CommandText = sSQL
            da.SelectCommand = cmd
            da.Fill(dt)

            Me.DGVbarang.DataSource = dt
            If dt.Rows.Count = 0 Then
                MsgBox("Data Tidak Ditemukan")
            End If
        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try
    End Sub
    Sub TampilTanggalPack()
        cmd = New OleDbCommand("SELECT DISTINCT tgl_pack FROM tb_pack", con)
        rd = cmd.ExecuteReader
        cmb_tglpack.Items.Clear()
        Do While rd.Read
            cmb_tglpack.Items.Add(rd.Item(0))
        Loop
    End Sub
    Private Sub FormCariBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        cmb_tglpack.DropDownHeight = cmb_tglpack.ItemHeight * 15
        cmb_tglpack.Visible = False
        txt_cari.Text = ""
        cmb_sortby.Text = ""
        Call SortBy()
    End Sub

    Private Sub btn_cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari.Click
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
    Private Sub DGVbarang_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVbarang.CellContentClick
        DGVbarang.ReadOnly = True
    End Sub

    Private Sub cmb_sortby_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_sortby.KeyPress
        e.Handled = True
    End Sub
    Private Sub cmb_sortby_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_sortby.SelectedIndexChanged
        If cmb_sortby.Text = "Tanggal Pack" Then
            Call TampilTanggalPack()
            txt_cari.Visible = False
            cmb_tglpack.Visible = True
            cmb_tglpack.Location = New Point(317, 24)
        ElseIf cmb_sortby.Text = "No Pack" Then
            txt_cari.Visible = True
            cmb_tglpack.Visible = False
        End If
    End Sub

    Private Sub cmb_tglpack_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_tglpack.KeyPress
        e.Handled = True
    End Sub
End Class