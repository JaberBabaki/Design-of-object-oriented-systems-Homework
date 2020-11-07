Imports System.Data.OleDb
Public Class Form2
    Dim strCon = "Provider=Microsoft.jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db.mdb"
    Private Sub btnDarj_Click(sender As Object, e As EventArgs) Handles btnDarj.Click
        'Dim cmd As New OleDbCommand
        '' Dim con As New OleDbConnection
        ''con.ConnectionString = connectionString
        'cmd.Connection = con
        ' con.Open()
        ' cmd.CommandText = ole
        'cmd.ExecuteNonQuery()
        'con.Close()

        ' Try
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        con.ConnectionString = strCon
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "insert into tbt  values('" + txtName.Text + "','" + txtFamily.Text + "','" + txtTelephon.Text + "')"
        cmd.ExecuteNonQuery()
        con.Close()
        ' Catch ex As Exception
        '  MessageBox.Show(ex.Message)
        'End Try*/

    End Sub

    Private Sub btnHazf_Click(sender As Object, e As EventArgs) Handles btnHazf.Click

    End Sub
End Class