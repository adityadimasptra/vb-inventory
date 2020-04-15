Imports System.Data.OleDb
Module Module1
    Public con As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public cmd As OleDbCommand
    Public rd As OleDbDataReader
    Public rd2 As OleDbDataReader
    Public str As String
    Public sConnstring As String
    Function Get_Constring()
        If Microsoft.VisualBasic.Right(Application.StartupPath, 1) = "\" Then
            sConnstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "perusahaanKG.accdb;Persist Security Info=False;"
        Else
            sConnstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\perusahaanKG.accdb;Persist Security Info=False;"
        End If
        Return sConnstring
    End Function
    Public Sub Koneksi()
        'str = "provider=microsoft.jet.oledb.4.0;data source=db_poliklinik.mdb"
        str = "Provider=microsoft.ace.oledb.12.0;data source=perusahaanKG.accdb"
        'str = "driver={MYSQL ODBC 3.51 Driver}; database=db_poliklinik;server=localhost;uid=root"
        con = New OleDbConnection(str)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
End Module
