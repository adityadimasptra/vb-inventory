Imports System.Runtime.InteropServices
Imports System.Data.OleDb
Public Class LoginForm
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Public Shared HakAkses As String
    Public Shared NamaPetugas As String
    Public Shared Usernameid As String
    Public Shared Passwordid As String
    Sub Loginapp()
        If txt_username.Text = "" Then
            MessageBox.Show("Username masih kosong !", "INFORMATION")
        ElseIf txt_password.Text = "" Then
            MessageBox.Show("Password masih kosong !", "INFORMATION")
            Exit Sub
        Else
            cmd = New OleDbCommand("SELECT * FROM tb_admin WHERE usernameid='" & txt_username.Text & "' and passwordid='" & txt_password.Text & "'", con)
            rd = cmd.ExecuteReader
            If rd.Read Then
                MessageBox.Show("Selamat Datang", "INFORMATION")
                HakAkses = rd.Item(5)
                NamaPetugas = rd.Item(1)
                Usernameid = rd.Item(2)
                Passwordid = rd.Item(3)
                txt_username.Clear()
                txt_password.Clear()
                Me.Hide()
                Home.Show()
            Else
                MsgBox("Username atau Password Salah !", MsgBoxStyle.Critical, "Attention")
                txt_username.Clear()
                txt_password.Clear()
                txt_username.Focus()
            End If
        End If
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Call Loginapp()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        txt_username.Clear()
        txt_password.Clear()
        txt_username.Focus()
        SendMessage(Me.txt_username.Handle, &H1501, 0, "Username")
        SendMessage(Me.txt_password.Handle, &H1501, 0, "Password")
    End Sub
    Private Sub txt_username_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_username.KeyPress
        If Not ((e.KeyChar >= "A" And e.KeyChar <= "z") Or (e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
    End Sub
End Class
