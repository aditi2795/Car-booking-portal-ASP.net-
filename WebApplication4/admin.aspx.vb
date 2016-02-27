Imports System.Data.SqlClient


Public Class WebForm8
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
       
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader




        con.ConnectionString = "Data Source=HP\SQLEXPRESS;Initial Catalog=data; Integrated security = true"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "SELECT * from taxi where regno ='" & TextBox1.Text & "'"

        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            TextBox2.Text = rd.Item("name")
            TextBox3.Text = rd.Item("adrs")
            TextBox4.Text = rd.Item("mn")
            TextBox5.Text = rd.Item("vm")
            TextBox6.Text = rd.Item("vc")
            TextBox7.Text = rd.Item("aip")
        Else
            MsgBox("not valid")

        End If



    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=HP\SQLEXPRESS;Initial Catalog=data; Integrated security = true"
        cmd.Connection = con
        con.Open()


        cmd.CommandText = "INSERT INTO adminlogin(nm,fa,no,vm,vc,rgno,ap,ack)VALUES  ('" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "', '" & TextBox6.Text & "','" & TextBox1.Text & "','" & TextBox7.Text & "','Y')"

        cmd.ExecuteNonQuery()
        MsgBox(" ACKNOWLEDGEMENT GRANTED")
        Response.Redirect("adminlogin.aspx")



    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(" ACKNOWLEDGEMENT DENIED")


    End Sub
End Class