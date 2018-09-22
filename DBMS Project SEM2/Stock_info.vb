Public Class Stock_info
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()
        main_page.Show()

    End Sub

    Private Sub Stock_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim adapter1 As New SqlClient.SqlDataAdapter
        Dim cmd1 As New SqlClient.SqlCommand
        Dim connb4 As New SqlClient.SqlConnection
        Dim display_table As New DataTable

        connb4.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\GT2\Project Files\Studio 2015\SQL Datasheet\Original\DBMS Project SEM2\DBMS Project SEM2\Sniper_DBMS_project_DB.mdf;Integrated Security=True;Connect Timeout=30"
        connb4.Open()

        cmd1.Connection = connb4
        cmd1.CommandText = "select * from MOTHERBOARD"

        adapter1.SelectCommand = cmd1

        connb4.Close()
        adapter1.Fill(display_table)

        DataGridView1.DataSource = display_table
        adapter1.Dispose()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim adapter2 As New SqlClient.SqlDataAdapter
        Dim cmd2 As New SqlClient.SqlCommand
        Dim connb5 As New SqlClient.SqlConnection
        Dim display_table As New DataTable

        connb5.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\GT2\Project Files\Studio 2015\SQL Datasheet\Original\DBMS Project SEM2\DBMS Project SEM2\Sniper_DBMS_project_DB.mdf;Integrated Security=True;Connect Timeout=30"
        connb5.Open()

        cmd2.Connection = connb5
        cmd2.CommandText = "select * from PROCESSOR"

        adapter2.SelectCommand = cmd2
        connb5.Close()
        adapter2.Fill(display_table)

        DataGridView1.DataSource = display_table
        adapter2.Dispose()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim adapter3 As New SqlClient.SqlDataAdapter
        Dim cmd3 As New SqlClient.SqlCommand
        Dim connb6 As New SqlClient.SqlConnection
        Dim display_table As New DataTable

        connb6.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\GT2\Project Files\Studio 2015\SQL Datasheet\Original\DBMS Project SEM2\DBMS Project SEM2\Sniper_DBMS_project_DB.mdf;Integrated Security=True;Connect Timeout=30"
        connb6.Open()

        cmd3.Connection = connb6
        cmd3.CommandText = "select * from RAM"

        adapter3.SelectCommand = cmd3
        connb6.Close()
        adapter3.Fill(display_table)

        DataGridView1.DataSource = display_table
        adapter3.Dispose()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim adapter4 As New SqlClient.SqlDataAdapter
        Dim cmd4 As New SqlClient.SqlCommand
        Dim connb7 As New SqlClient.SqlConnection
        Dim display_table As New DataTable

        connb7.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\GT2\Project Files\Studio 2015\SQL Datasheet\Original\DBMS Project SEM2\DBMS Project SEM2\Sniper_DBMS_project_DB.mdf;Integrated Security=True;Connect Timeout=30"
        connb7.Open()

        cmd4.Connection = connb7
        cmd4.CommandText = "select * from GRAPHIC_CARD"

        adapter4.SelectCommand = cmd4
        connb7.Close()
        adapter4.Fill(display_table)

        DataGridView1.DataSource = display_table
        adapter4.Dispose()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim adapter5 As New SqlClient.SqlDataAdapter
        Dim cmd5 As New SqlClient.SqlCommand
        Dim connb8 As New SqlClient.SqlConnection
        Dim display_table As New DataTable

        connb8.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\GT2\Project Files\Studio 2015\SQL Datasheet\Original\DBMS Project SEM2\DBMS Project SEM2\Sniper_DBMS_project_DB.mdf;Integrated Security=True;Connect Timeout=30"
        connb8.Open()

        cmd5.Connection = connb8
        cmd5.CommandText = "select * from PSU"

        adapter5.SelectCommand = cmd5
        connb8.Close()
        adapter5.Fill(display_table)

        DataGridView1.DataSource = display_table
        adapter5.Dispose()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim adapter6 As New SqlClient.SqlDataAdapter
        Dim cmd6 As New SqlClient.SqlCommand
        Dim connb9 As New SqlClient.SqlConnection
        Dim display_table As New DataTable

        connb9.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\GT2\Project Files\Studio 2015\SQL Datasheet\Original\DBMS Project SEM2\DBMS Project SEM2\Sniper_DBMS_project_DB.mdf;Integrated Security=True;Connect Timeout=30"
        connb9.Open()

        cmd6.Connection = connb9
        cmd6.CommandText = "select * from CABINET"

        adapter6.SelectCommand = cmd6
        connb9.Close()
        adapter6.Fill(display_table)

        DataGridView1.DataSource = display_table
        adapter6.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim adapter7 As New SqlClient.SqlDataAdapter
        Dim cmd7 As New SqlClient.SqlCommand
        Dim connb10 As New SqlClient.SqlConnection
        Dim display_table As New DataTable

        connb10.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\GT2\Project Files\Studio 2015\SQL Datasheet\Original\DBMS Project SEM2\DBMS Project SEM2\Sniper_DBMS_project_DB.mdf;Integrated Security=True;Connect Timeout=30"
        connb10.Open()

        cmd7.Connection = connb10
        cmd7.CommandText = "select * from HDDS"

        adapter7.SelectCommand = cmd7
        connb10.Close()
        adapter7.Fill(display_table)

        DataGridView1.DataSource = display_table
        adapter7.Dispose()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim response = MsgBox("RESET STOCKS?", MsgBoxStyle.YesNo, "resetquestion")
        Dim conn_reset As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        conn_reset.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\GT2\Project Files\Studio 2015\SQL Datasheet\Original\DBMS Project SEM2\DBMS Project SEM2\Sniper_DBMS_project_DB.mdf;Integrated Security=True;Connect Timeout=30"
        cmd.Connection = conn_reset

        If response = MsgBoxResult.Yes Then
            conn_reset.Open()
            cmd.CommandText = "update MOTHERBOARD set mobo_stock=30"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update GRAPHIC_CARD set gpu_stock=30"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update PROCESSOR set pro_stock=30"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update RAM set ram_stock=30"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update PSU set psu_stock=30"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update HDDS set hdd_stock=30"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update CABINET set cab_stock=30"
            cmd.ExecuteNonQuery()
            conn_reset.Close()
            DataGridView1.DataSource = Nothing

        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) 

    End Sub
End Class