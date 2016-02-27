Imports System.Data.SqlClient


Public Class WebForm6
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Response.Redirect("taxiii.aspx")



    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=HP\SQLEXPRESS;Initial Catalog=data; Integrated security = true"
        cmd.Connection = con
        con.Open()


        cmd.CommandText = "INSERT INTO taxi(name,adrs,mn,vm,vc,regno,aip)VALUES  ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & DropDownList1.SelectedItem.Text & "', '" & DropDownList2.SelectedItem.Text & "','" & TextBox4.Text & "','" & DropDownList3.SelectedItem.Text & "')"
        cmd.ExecuteNonQuery()
        MsgBox("REQUEST SENT.. WAIT FOR ADMIN ACKNOWLEDGEMENT")
        Response.Redirect("taxilogin.aspx")
    End Sub
End Class