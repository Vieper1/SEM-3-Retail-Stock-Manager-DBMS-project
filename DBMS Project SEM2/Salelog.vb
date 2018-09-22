Public Class Salelog
    Dim conn As New SqlClient.SqlConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        main_page.Show()

    End Sub

    Private Sub Salelog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\GT2\Project Files\Studio 2015\SQL Datasheet\Original\DBMS Project SEM2\DBMS Project SEM2\Sniper_DBMS_project_DB.mdf;Integrated Security=True;Connect Timeout=30"
        Dim display_table As New DataTable
        Dim adapter As New SqlClient.SqlDataAdapter
        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = conn
        cmd.CommandText = "select bill_id as [TRANS ID], bill_client_fname as [FIRST NAME], bill_client_lname as [LAST NAME], bill_client_ctno as [CONTACT NO], bill_amount_payable as [AMOUNT PAID], bill_mobo_id as [MOBO ID], bill_mobo_count as [QTY], bill_pro_id as [PROCSR ID], bill_pro_count as [QTY], bill_ram_id as [RAM ID], bill_ram_count as [QTY], bill_gpu_id as [GPU ID], bill_gpu_count as [QTY], bill_hdd_id as [HDD ID], bill_hdd_count as [QTY], bill_psu_id as [PSU ID], bill_psu_count as [QTY], bill_cab_id as [CABINET ID], bill_cab_count as [QTY] from BILL;"

        conn.Open()
        adapter.SelectCommand = cmd
        conn.Close()

        adapter.Fill(display_table)

        DataGridView1.DataSource = display_table

        adapter.Dispose()
    End Sub

    Private Sub refresh_list_Click(sender As Object, e As EventArgs) Handles refresh_list.Click
        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\GT2\Project Files\Studio 2015\SQL Datasheet\Original\DBMS Project SEM2\DBMS Project SEM2\Sniper_DBMS_project_DB.mdf;Integrated Security=True;Connect Timeout=30"
        Dim display_table As New DataTable
        Dim adapter As New SqlClient.SqlDataAdapter
        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = conn
        cmd.CommandText = "select bill_id as [TRANS ID], bill_client_fname as [FIRST NAME], bill_client_lname as [LAST NAME], bill_client_ctno as [CONTACT NO], bill_amount_payable as [AMOUNT PAID], bill_mobo_id as [MOBO ID], bill_mobo_count as [QTY], bill_pro_id as [PROCSR ID], bill_pro_count as [QTY], bill_ram_id as [RAM ID], bill_ram_count as [QTY], bill_gpu_id as [GPU ID], bill_gpu_count as [QTY], bill_hdd_id as [HDD ID], bill_hdd_count as [QTY], bill_psu_id as [PSU ID], bill_psu_count as [QTY], bill_cab_id as [CABINET ID], bill_cab_count as [QTY] from BILL;"

        conn.Open()
        adapter.SelectCommand = cmd
        conn.Close()

        adapter.Fill(display_table)

        DataGridView1.DataSource = display_table

        adapter.Dispose()
    End Sub
End Class