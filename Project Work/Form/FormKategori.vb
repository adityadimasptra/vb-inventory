Imports System.Runtime.InteropServices
Imports System.Data.OleDb
Public Class FormKategori
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Sub TampilDataKategori()
        da = New OleDbDataAdapter("SELECT * FROM tb_kategori", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, " tb_kategori")
        DGVkategori.DataSource = (ds.Tables(" tb_kategori"))
        DGVkategori.ReadOnly = True
    End Sub
    Private Sub FormKategori_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Kosongkan()
        Call TampilDataKategori()
        SendMessage(Me.txt_kategori.Handle, &H1501, 0, "Kategori")
    End Sub
    Sub Kosongkan()
        txt_kategori.Text = ""
    End Sub
    Sub TambahKategori()
        If txt_kategori.Text = "" Then
            MsgBox(" Data Belum Lengkap")
            Exit Sub
        Else
            cmd = New OleDbCommand("SELECT * FROM tb_kategori WHERE kategori ='" & txt_kategori.Text & "'", con)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                If MessageBox.Show("Apakah anda ingin Menambah Kategori '" & txt_kategori.Text & "' ?", "Perhatian", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim sqltambah As String = " INSERT INTO tb_kategori VALUES('" & txt_kategori.Text & "')"
                    cmd = New OleDbCommand(sqltambah, con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data berhasil di tambah", "ADEES Confirmation")
                    Call Kosongkan()
                    Call TampilDataKategori()
                Else
                    Call Kosongkan()
                    Call TampilDataKategori()
                End If
            End If
        End If
    End Sub

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        Call TambahKategori()
    End Sub
    Private Sub DGVkategori_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DGVkategori.RowsAdded
        Dim rowNumber As Integer = 1
        For Each row As DataGridViewRow In DGVkategori.Rows
            If row.IsNewRow Then Continue For
            row.HeaderCell.Value = rowNumber.ToString
            rowNumber = rowNumber + 1
        Next
    End Sub
End Class