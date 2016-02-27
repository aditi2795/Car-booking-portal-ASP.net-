Imports System.Data.SqlClient
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=HP\SQLEXPRESS;Initial Catalog=data; Integrated security = true"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = " SELECT username , password from taxilogin where username ='" & TextBox2.Text & "' and password= '" & TextBox3.Text & "'"

        rd = cmd.ExecuteReader

        If rd.HasRows Then
            Response.Redirect("taxiii.aspx")
        Else
            MsgBox("login failed")

        End If





    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=HP\SQLEXPRESS;Initial Catalog=data; Integrated security = true"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "INSERT INTO taxilogin(username,password) VALUES( '" & TextBox2.Text & "' , '" & TextBox3.Text & "') "
        cmd.ExecuteNonQuery()
        TextBox2.Text = ""
        TextBox3.Text = ""

        MsgBox("created successfully!!")
        
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Response.Redirect("MAINPAGE.aspx")
    End Sub
End Class