Imports Project_Work.LoginForm
Public Class Home
    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If HakAkses = "STAFF" Then
            lbl_akses.Text = HakAkses
            lbl_nama.Text = NamaPetugas
            Accountstrip.Text = Usernameid
        Else
            lbl_akses.Text = HakAkses
            lbl_nama.Text = NamaPetugas
            Accountstrip.Text = Usernameid
        End If
        TransaksiToolStripMenuItem.Visible = False
        ''ReportToolStripMenuItem.Visible = False
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        If MessageBox.Show("Apakah anda ingin Logout?", "Perhatian", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            lbl_akses.Text = ""
            lbl_nama.Text = ""
            Me.Close()
            FormBarang.Close()
            FormKategori.Close()
            FormPackBarang.Close()
            LoginForm.Show()
            LoginForm.txt_username.Focus()
        End If
    End Sub
    Private Sub BarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangToolStripMenuItem.Click
        FormBarang.ShowDialog()
    End Sub

    Private Sub InputKategoriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputKategoriToolStripMenuItem.Click
        FormKategori.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        FormBarang.Close()
        FormKategori.Close()
        FormPackBarang.Close()
    End Sub

    Private Sub PackingBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PackingBarangToolStripMenuItem.Click
        FormPackBarang.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        ChangeProfil.ShowDialog()
    End Sub

    Private Sub CariBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CariBarangToolStripMenuItem.Click
        FormCariBarang.ShowDialog()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportToolStripMenuItem.Click
        FormReport.ShowDialog()
    End Sub

    Private Sub InputToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputToolStripMenuItem.Click

    End Sub
End Class
