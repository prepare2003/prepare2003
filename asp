-Imports System.Data.OleDb
Imports System.Data
Partial Class _Default
    Inherits System.Web.UI.Page
    Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=???????????????????????????????")
    Dim gender As String
    Dim subject As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fetch()
    End Sub
    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            If male.Checked Then
                gender = "Male"
            ElseIf female.Checked Then
                gender = "Female"
            Else
                gender = "Other"
            End If
            subject = DropDownList1.SelectedValue
            Dim cmd As OleDbCommand = New OleDbCommand("insert into student values(" & txtID.Text & " , '" & txtName.Text & "','" & txtRoll.Text & "','" & txtMobile.Text & "','" & gender.ToString() & "','" & subject.ToString() & "')", conn)
            cmd.ExecuteNonQuery()

            lblMsg.Text = "Data Inserted"
            fetch()
            clear()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            If male.Checked Then
                gender = "Male"
            ElseIf female.Checked Then
                gender = "Female"
            Else
                gender = "Other"
            End If
            subject = DropDownList1.SelectedValue
            Dim cmd As OleDbCommand = New OleDbCommand("update student set sname = '" & txtName.Text & "',srollno = '" & txtRoll.Text & "',smobileno = '" & txtMobile.Text & "',sgender = '" & gender.ToString() & "',subject = '" & subject.ToString() & "' where ID = " & txtID.Text & "", conn)
            cmd.ExecuteNonQuery()

            lblMsg.Text = "Data Updated"
            fetch()
            clear()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Protected Sub Button3_Click(sender As Object, e As System.EventArgs) Handles Button3.Click
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd As OleDbCommand = New OleDbCommand("delete from student where ID = " & txtID.Text & "", conn)
            cmd.ExecuteNonQuery()

            lblMsg.Text = "Data Deleted"
            fetch()
            clear()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Protected Sub Button4_Click(sender As Object, e As System.EventArgs) Handles Button4.Click
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            'search for grid view
            Dim cmd As OleDbCommand = New OleDbCommand("select * from student where ID = " & txtSearch.Text & "", conn)
            cmd.ExecuteScalar()

            Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim ds As DataSet = New DataSet

            da.Fill(ds)

            GridView1.DataBind()

            'search for textbox
            Dim dr As OleDbDataReader
            Dim cmd1 As OleDbCommand = New OleDbCommand("select * from student where ID = " & txtSearch.Text & "", conn)
            dr = cmd1.ExecuteReader()

            dr.Read()

            txtID.Text = dr.Item(0)
            txtName.Text = dr.Item(1)
            txtRoll.Text = dr.Item(2)
            txtMobile.Text = dr.Item(3)
            If dr.Item(4).Equals("Male") Then
                male.Checked = True
            ElseIf dr.Item(4).Equals("female") Then
                female.Checked = True
            Else
                other.Checked = True
            End If
            DropDownList1.SelectedValue = dr.Item(5)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Private Sub fetch()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd As OleDbCommand = New OleDbCommand("select * from student", conn)
            cmd.ExecuteScalar()

            Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim ds As DataSet = New DataSet

            da.Fill(ds)

            GridView1.DataBind()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Private Sub clear()
        txtID.Text = ""
        txtMobile.Text = ""
        txtName.Text = ""
        txtRoll.Text = ""
        txtSearch.Text = ""
        male.Checked = False
        female.Checked = False
        other.Checked = False
        DropDownList1.SelectedValue = "ASP"
        lblMsg.Text = ""
    End Sub

End Class
