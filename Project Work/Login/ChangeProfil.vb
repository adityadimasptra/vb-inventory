Imports System.Data.OleDb
Imports Project_Work.LoginForm
Public Class ChangeProfil
    Sub ValidasiUbah()
        If txt_nama.Text = "" Then
            MsgBox("Nama Masih Kosong")
        ElseIf txt_username.Text = "" Then
            MsgBox("Username Masih Kosong")
        ElseIf txt_password.Text = "" Then
            MsgBox("Current Password Masih Kosong")
        ElseIf txt_newpassword.Text = "" Then
            MsgBox("Password Baru Masih Kosong")
        ElseIf txt_confirmpassword.Text = "" Then
            MsgBox("Confirm Password Masih Kosong")
            Exit Sub
        End If
    End Sub
    Sub UbahProfil()
        Call ValidasiUbah()
        Try
            If MessageBox.Show("Apakah anda ingin merubah profil Anda?", "Perhatian", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim gantidata As String = " UPDATE tb_admin SET nama ='" & txt_nama.Text & "', passwordid ='" & txt_newpassword.Text & "' WHERE usernameid = '" & txt_username.Text & "'"
                cmd = New OleDbCommand(gantidata, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Di Ubah", "INFO")
            Else
                btn_update.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Private Sub ChangeProfil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        txt_nama.Text = NamaPetugas
        txt_username.Text = Usernameid
        txt_username.Enabled = False
    End Sub
    Sub Kosongkan()
        txt_confirmpassword.Text = ""
        txt_newpassword.Text = ""
        txt_password.Text = ""
        txt_stat.Text = ""
        txt_stat2.Text = ""
    End Sub
    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        cmd = New OleDbCommand("SELECT * FROM tb_admin WHERE usernameid='" & txt_username.Text & "' and passwordid='" & txt_password.Text & "'", con)
        rd = cmd.ExecuteReader
        If Not rd.Read Then
            MsgBox("Current Password Salah")
            Call Kosongkan()
        ElseIf txt_newpassword.Text <> txt_confirmpassword.Text Then
            MsgBox("Confirmasi Password Tidak Sama")
            Call Kosongkan()
        Else
            Call UbahProfil()
            Call Kosongkan()
        End If
    End Sub

    Private Sub txt_confirmpassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_confirmpassword.KeyPress
        If e.KeyChar = Chr(13) Then
            cmd = New OleDbCommand("SELECT * FROM tb_admin WHERE usernameid='" & txt_username.Text & "' and passwordid='" & txt_password.Text & "'", con)
            rd = cmd.ExecuteReader
            If Not rd.Read Then
                MsgBox("Current Password Salah")
                Call Kosongkan()
            ElseIf txt_newpassword.Text <> txt_confirmpassword.Text Then
                MsgBox("Confirmasi Password Tidak Sama")
                Call Kosongkan()
            Else
                Call UbahProfil()
                Call Kosongkan()
            End If
        End If
    End Sub

    Private Sub txt_newpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_newpassword.TextChanged
        txt_newpassword.MaxLength = 18
        If txt_newpassword.TextLength <= 4 Then
            txt_stat.Text = "Weak"
            txt_stat.ForeColor = Color.Orange
        ElseIf txt_newpassword.TextLength <= 10 Then
            txt_stat.Text = "Medium"
            txt_stat.ForeColor = Color.Green
        ElseIf txt_newpassword.TextLength <= 16 Then
            txt_stat.Text = "Strong"
            txt_stat.ForeColor = Color.Blue
        ElseIf txt_newpassword.TextLength <= 18 Then
            txt_stat.Text = "Limited!"
            txt_stat.ForeColor = Color.Red
        End If
    End Sub

    Private Sub txt_confirmpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_confirmpassword.TextChanged
        txt_confirmpassword.MaxLength = 18
        If txt_confirmpassword.TextLength <= 4 Then
            txt_stat2.Text = "Weak"
            txt_stat2.ForeColor = Color.Orange
        ElseIf txt_confirmpassword.TextLength <= 10 Then
            txt_stat2.Text = "Medium"
            txt_stat2.ForeColor = Color.Green
        ElseIf txt_confirmpassword.TextLength <= 16 Then
            txt_stat2.Text = "Strong"
            txt_stat2.ForeColor = Color.Blue
        ElseIf txt_confirmpassword.TextLength <= 18 Then
            txt_stat2.Text = "Limited!"
            txt_stat2.ForeColor = Color.Red
        End If
    End Sub

    Private Sub txt_password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_password.TextChanged
        txt_password.MaxLength = 18
    End Sub

    Private Sub txt_nama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nama.TextChanged
        txt_nama.MaxLength = 30
        If txt_nama.TextLength = 30 Then
            txt_stat3.Text = "STRONGGG!"
            txt_stat3.ForeColor = Color.Red
        ElseIf txt_nama.TextLength <= 30 Then
            txt_stat3.Text = " "
            txt_stat3.ForeColor = Color.Red
        End If
    End Sub
End Class