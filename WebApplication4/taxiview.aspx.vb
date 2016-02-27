Imports System.Data.SqlClient

Public Class WebForm9
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=HP\SQLEXPRESS;Initial Catalog=data; Integrated security = true"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "SELECT * from adminlogin where rgno ='" & TextBox1.Text & "'"

        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows Then

            TextBox2.Text = rd.Item("nm")
            TextBox3.Text = rd.Item("fa")
            TextBox4.Text = rd.Item("no")
            TextBox5.Text = rd.Item("vm")
            TextBox6.Text = rd.Item("vc")
            TextBox7.Text = rd.Item("ap")
        Else
            MsgBox("NOT ACKNOWLEDGED BY ADMIN")

        End If
        ' Response.Redirect("taxiii.aspx")


    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("MAINPAGE.aspx")

    End Sub
End Class