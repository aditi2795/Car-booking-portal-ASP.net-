Imports System.Data.SqlClient


Public Class WebForm5

    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Calendar1_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar1.SelectionChanged
        TextBox1.Text = Calendar1.SelectedDate.ToShortDateString()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=HP\SQLEXPRESS;Initial Catalog=data; Integrated security = true"
        cmd.Connection = con
        con.Open()
        TextBox1.Text = Calendar1.SelectedDate
        If Calendar1.SelectedDate < DateTime.Today Then
            MsgBox("SELECT A VALID DATE")
            TextBox1.Text = ""
        End If



        cmd.CommandText = " SELECT date from users where date ='" & TextBox1.Text & "'"
        rd = cmd.ExecuteReader

        If rd.HasRows Then
            MsgBox("SELECT ANOTHER DATE AS THIS DATE IS UNAVAILABLE")
            TextBox1.Text = ""

        End If



    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
       
        con.ConnectionString = "Data Source=HP\SQLEXPRESS;Initial Catalog=data; Integrated security = true"
        cmd.Connection = con
        con.Open()


        cmd.CommandText = "INSERT INTO users(travel,vehicle,purpose,location,date)VALUES  ('" & DropDownList1.SelectedItem.Text & "', '" & DropDownList2.SelectedItem.Text & "','" & DropDownList3.SelectedItem.Text & "','" & DropDownList4.SelectedItem.Text & "','" & TextBox1.Text & "' )"
        cmd.ExecuteNonQuery()
        MsgBox("Booking successful!!!")


        Response.Redirect("MAINPAGE.aspx")

    End Sub



    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class