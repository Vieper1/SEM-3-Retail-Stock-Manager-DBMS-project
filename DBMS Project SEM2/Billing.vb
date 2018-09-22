Public Class Billing_page
    Dim conn As New SqlClient.SqlConnection
    Dim blank_table As New DataTable


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim message = "Do you want to leave this page?"

        Dim response = MsgBox(message, MsgBoxStyle.YesNo, "Exiter")
        If response = MsgBoxResult.Yes Then
            conn.Close()
            Me.Close()
            main_page.Show()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\GT2\Project Files\Studio 2015\SQL Datasheet\Original\DBMS Project SEM2\DBMS Project SEM2\Sniper_DBMS_project_DB.mdf;Integrated Security=True;Connect Timeout=30"
        main_list.SelectedIndex = 0
        mobo_qty.SelectedIndex = 0
        pro_qty.SelectedIndex = 0
        ram_qty.SelectedIndex = 0
        gpu_qty.SelectedIndex = 0
        psu_qty.SelectedIndex = 0
        hdd_qty.SelectedIndex = 0
        cab_qty.SelectedIndex = 0
        final_cost.Text = "0"


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles main_list.SelectedIndexChanged


    End Sub

    Private Sub display_obj_Click(sender As Object, e As EventArgs) Handles display_obj.Click
        Dim display_table As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        Dim adapter1 As New SqlClient.SqlDataAdapter
        cmd.Connection = conn
        conn.Open()

        If main_list.SelectedIndex = 0 Then
            cmd.CommandText = "select * from MOTHERBOARD"

            adapter1.SelectCommand = cmd
            conn.Close()
            adapter1.Fill(display_table)

            grid1.DataSource = display_table
        ElseIf main_list.SelectedIndex = 1
            cmd.CommandText = "select * from PROCESSOR"

            adapter1.SelectCommand = cmd
            conn.Close()
            adapter1.Fill(display_table)

            grid1.DataSource = display_table
        ElseIf main_list.SelectedIndex = 2
            cmd.CommandText = "select * from RAM"

            adapter1.SelectCommand = cmd
            conn.Close()
            adapter1.Fill(display_table)

            grid1.DataSource = display_table
        ElseIf main_list.SelectedIndex = 3
            cmd.CommandText = "select * from GRAPHIC_CARD"

            adapter1.SelectCommand = cmd
            conn.Close()
            adapter1.Fill(display_table)

            grid1.DataSource = display_table
        ElseIf main_list.SelectedIndex = 4
            cmd.CommandText = "select * from PSU"

            adapter1.SelectCommand = cmd
            conn.Close()
            adapter1.Fill(display_table)

            grid1.DataSource = display_table
        ElseIf main_list.SelectedIndex = 5
            cmd.CommandText = "select * from HDDS"

            adapter1.SelectCommand = cmd
            conn.Close()
            adapter1.Fill(display_table)

            grid1.DataSource = display_table
        ElseIf main_list.SelectedIndex = 6
            cmd.CommandText = "select * from CABINET"

            adapter1.SelectCommand = cmd
            conn.Close()
            adapter1.Fill(display_table)

            grid1.DataSource = display_table
        End If


        adapter1.Dispose()

    End Sub

    Private Sub clear_grid_Click(sender As Object, e As EventArgs) Handles clear_grid.Click
        grid1.DataSource = blank_table

    End Sub

    Private Sub mobo_id_TextChanged(sender As Object, e As EventArgs) Handles mobo_id.TextChanged
        If mobo_qty.SelectedIndex < 1 Then
            mobo_qty.SelectedIndex = 1
        End If

    End Sub

    Private Sub pro_id_TextChanged(sender As Object, e As EventArgs) Handles pro_id.TextChanged
        If pro_qty.SelectedIndex < 1 Then
            pro_qty.SelectedIndex = 1
        End If

    End Sub

    Private Sub ram_id_TextChanged(sender As Object, e As EventArgs) Handles ram_id.TextChanged
        If ram_qty.SelectedIndex < 1 Then
            ram_qty.SelectedIndex = 1
        End If

    End Sub

    Private Sub gpu_id_TextChanged(sender As Object, e As EventArgs) Handles gpu_id.TextChanged
        If gpu_qty.SelectedIndex < 1 Then
            gpu_qty.SelectedIndex = 1
        End If

    End Sub

    Private Sub psu_id_TextChanged(sender As Object, e As EventArgs) Handles psu_id.TextChanged
        If psu_qty.SelectedIndex < 1 Then
            psu_qty.SelectedIndex = 1
        End If

    End Sub

    Private Sub hdd_id_TextChanged(sender As Object, e As EventArgs) Handles hdd_id.TextChanged
        If hdd_qty.SelectedIndex < 1 Then
            hdd_qty.SelectedIndex = 1
        End If

    End Sub

    Private Sub cab_id_TextChanged(sender As Object, e As EventArgs) Handles cab_id.TextChanged
        If cab_qty.SelectedIndex < 1 Then
            cab_qty.SelectedIndex = 1
        End If

    End Sub













    Private Sub bill_it_Click(sender As Object, e As EventArgs) Handles bill_it.Click
        Dim cmd As New SqlClient.SqlCommand
        Dim exist As New SqlClient.SqlCommand
        Dim new_bill_id As Integer
        cmd.Connection = conn
        exist.Connection = conn

        If fname.Text = "" Then
            MsgBox("'First Name' MISSING...", MsgBoxStyle.Information, "fnamemissing")
            fname.Focus()
        ElseIf lname.Text = ""
            MsgBox("'Last Name' MISSING...", MsgBoxStyle.Information, "fnamemissing")
            lname.Focus()
        ElseIf ct_no.Text = ""
            MsgBox("'Contact Number' MISSING...", MsgBoxStyle.Information, "fnamemissing")
            ct_no.Focus()
        Else
            Dim fin_response = MsgBox("FINALIZE THE BILL?", MsgBoxStyle.YesNo, "finalize_yesno")
            exist.CommandText = "select count(bill_id) from BILL"
            cmd.CommandText = "select max(bill_id) from BILL"
            conn.Open()

            If exist.ExecuteScalar = 0 Then
                new_bill_id = 1
                conn.Close()
            Else
                new_bill_id = cmd.ExecuteScalar() + 1
                conn.Close()
            End If



            If fin_response = MsgBoxResult.Yes Then
                Me.Button2.PerformClick()

                conn.Open()
                cmd.CommandText = "insert into BILL(bill_id, bill_client_fname, bill_client_lname, bill_client_ctno, bill_amount_payable) values(" & new_bill_id & ",'" & fname.Text & "','" & lname.Text & "','" & ct_no.Text & "'," & final_cost.Text & ");"
                cmd.ExecuteNonQuery()

                exist.CommandText = "select count(mobo_id) from MOTHERBOARD where mobo_id=" & mobo_id.Text & ";"
                If Not mobo_qty.SelectedIndex = 0 Then
                    If Not exist.ExecuteScalar = 0 Then
                        cmd.CommandText = "update BILL set bill_mobo_id=" & mobo_id.Text & "where bill_id=" & new_bill_id & ";"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "update BILL set bill_mobo_count=" & mobo_qty.SelectedIndex & "where bill_id=" & new_bill_id & ";"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "update MOTHERBOARD set mobo_stock=mobo_stock-" & mobo_qty.SelectedIndex & " where mobo_id=" & mobo_id.Text & ";"
                        cmd.ExecuteNonQuery()
                    End If

                End If



                exist.CommandText = "select count(pro_id) from PROCESSOR where pro_id=" & pro_id.Text & ";"
                If Not pro_qty.SelectedIndex = 0 Then
                    If Not exist.ExecuteScalar = 0 Then
                        cmd.CommandText = "update BILL set bill_pro_id=" & pro_id.Text & "where bill_id=" & new_bill_id & ";"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "update BILL set bill_pro_count=" & pro_qty.SelectedIndex & "where bill_id=" & new_bill_id & ";"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "update PROCESSOR set pro_stock=pro_stock-" & pro_qty.SelectedIndex & " where pro_id=" & pro_id.Text & ";"
                        cmd.ExecuteNonQuery()
                    End If

                End If



                exist.CommandText = "select count(ram_id) from RAM where ram_id=" & ram_id.Text & ";"
                If Not ram_qty.SelectedIndex = 0 Then
                    If Not exist.ExecuteScalar = 0 Then
                        cmd.CommandText = "update BILL set bill_ram_id=" & ram_id.Text & "where bill_id=" & new_bill_id & ";"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "update BILL set bill_ram_count=" & ram_qty.SelectedIndex & "where bill_id=" & new_bill_id & ";"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "update RAM set ram_stock=ram_stock-" & ram_qty.SelectedIndex & " where ram_id=" & ram_id.Text & ";"
                        cmd.ExecuteNonQuery()
                    End If

                End If



                exist.CommandText = "select count(gpu_id) from GRAPHIC_CARD where gpu_id=" & gpu_id.Text & ";"
                If Not gpu_qty.SelectedIndex = 0 Then
                    If Not exist.ExecuteScalar = 0 Then
                        cmd.CommandText = "update BILL set bill_gpu_id=" & gpu_id.Text & "where bill_id=" & new_bill_id & ";"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "update BILL set bill_gpu_count=" & gpu_qty.SelectedIndex & "where bill_id=" & new_bill_id & ";"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "update GRAPHIC_CARD set gpu_stock=gpu_stock-" & gpu_qty.SelectedIndex & " where gpu_id=" & gpu_id.Text & ";"
                        cmd.ExecuteNonQuery()
                    End If

                End If



                exist.CommandText = "select count(hdd_id) from HDDS where hdd_id=" & hdd_id.Text & ";"
                If Not hdd_qty.SelectedIndex = 0 Then
                    If Not exist.ExecuteScalar = 0 Then
                        cmd.CommandText = "update BILL set bill_hdd_id=" & hdd_id.Text & "where bill_id=" & new_bill_id & ";"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "update BILL set bill_hdd_count=" & hdd_qty.SelectedIndex & "where bill_id=" & new_bill_id & ";"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "update HDDS set hdd_stock=hdd_stock-" & hdd_qty.SelectedIndex & " where hdd_id=" & hdd_id.Text & ";"
                        cmd.ExecuteNonQuery()
                    End If

                End If



                exist.CommandText = "select count(psu_id) from PSU where psu_id=" & psu_id.Text & ";"
                If Not psu_qty.SelectedIndex = 0 Then
                    If Not exist.ExecuteScalar = 0 Then
                        cmd.CommandText = "update BILL set bill_psu_id=" & psu_id.Text & "where bill_id=" & new_bill_id & ";"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "update BILL set bill_psu_count=" & psu_qty.SelectedIndex & "where bill_id=" & new_bill_id & ";"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "update PSU set psu_stock=psu_stock-" & psu_qty.SelectedIndex & " where psu_id=" & psu_id.Text & ";"
                        cmd.ExecuteNonQuery()
                    End If

                End If



                exist.CommandText = "select count(cab_id) from CABINET where cab_id=" & cab_id.Text & ";"
                If Not cab_qty.SelectedIndex = 0 Then
                    If Not exist.ExecuteScalar = 0 Then
                        cmd.CommandText = "update BILL set bill_cab_id=" & cab_id.Text & "where bill_id=" & new_bill_id & ";"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "update BILL set bill_cab_count=" & cab_qty.SelectedIndex & "where bill_id=" & new_bill_id & ";"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "update CABINET set cab_stock=cab_stock-" & cab_qty.SelectedIndex & " where cab_id=" & cab_id.Text & ";"
                        cmd.ExecuteNonQuery()
                    End If

                End If



                conn.Close()
                grid1.DataSource = blank_table
                fname.Text = ""
                lname.Text = ""
                ct_no.Text = ""
                mobo_id.Text = ""
                mobo_qty.SelectedIndex = 0
                pro_id.Text = ""
                pro_qty.SelectedIndex = 0
                ram_id.Text = ""
                ram_qty.SelectedIndex = 0
                gpu_id.Text = ""
                gpu_qty.SelectedIndex = 0
                psu_id.Text = ""
                psu_qty.SelectedIndex = 0
                hdd_id.Text = ""
                hdd_qty.SelectedIndex = 0
                cab_id.Text = ""
                cab_qty.SelectedIndex = 0
                main_list.SelectedIndex = 0
                final_cost.Text = ""

                MsgBox("BILLING COMPLETED", MsgBoxStyle.Information, "updatesuccess")
            End If
        End If





















    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tot As Integer
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = conn
        tot = 0


        If mobo_qty.SelectedIndex > 0 And mobo_id.Text = Nothing Then
            mobo_qty.SelectedIndex = 0
        End If

        If pro_qty.SelectedIndex > 0 And pro_id.Text = "" Then
            pro_qty.SelectedIndex = 0
        End If

        If ram_qty.SelectedIndex > 0 And ram_id.Text = "" Then
            ram_qty.SelectedIndex = 0
        End If

        If gpu_qty.SelectedIndex > 0 And gpu_id.Text = "" Then
            gpu_qty.SelectedIndex = 0
        End If

        If psu_qty.SelectedIndex > 0 And psu_id.Text = "" Then
            psu_qty.SelectedIndex = 0
        End If

        If hdd_qty.SelectedIndex > 0 And hdd_id.Text = "" Then
            hdd_qty.SelectedIndex = 0
        End If

        If cab_qty.SelectedIndex > 0 And cab_id.Text = "" Then
            cab_qty.SelectedIndex = 0
        End If


        If mobo_qty.SelectedIndex > 0 Then
            conn.Open()
            cmd.CommandText = "select mobo_price from MOTHERBOARD where mobo_id=" & mobo_id.Text & ";"
            tot = tot + cmd.ExecuteScalar() * mobo_qty.SelectedIndex
            conn.Close()
        End If

        If pro_qty.SelectedIndex > 0 Then
            conn.Open()
            cmd.CommandText = "select pro_price from PROCESSOR where pro_id=" & pro_id.Text & ";"
            tot = tot + cmd.ExecuteScalar() * pro_qty.SelectedIndex
            conn.Close()
        End If

        If ram_qty.SelectedIndex > 0 Then
            conn.Open()
            cmd.CommandText = "select ram_price from RAM where ram_id=" & ram_id.Text & ";"
            tot = tot + cmd.ExecuteScalar() * ram_qty.SelectedIndex
            conn.Close()
        End If

        If gpu_qty.SelectedIndex > 0 Then
            conn.Open()
            cmd.CommandText = "select gpu_price from GRAPHIC_CARD where gpu_id=" & gpu_id.Text & ";"
            tot = tot + cmd.ExecuteScalar() * gpu_qty.SelectedIndex
            conn.Close()
        End If

        If psu_qty.SelectedIndex > 0 Then
            conn.Open()
            cmd.CommandText = "select psu_price from PSU where psu_id=" & psu_id.Text & ";"
            tot = tot + cmd.ExecuteScalar() * psu_qty.SelectedIndex
            conn.Close()
        End If

        If hdd_qty.SelectedIndex > 0 Then
            conn.Open()
            cmd.CommandText = "select hdd_price from HDDS where hdd_id=" & hdd_id.Text & ";"
            tot = tot + cmd.ExecuteScalar() * hdd_qty.SelectedIndex
            conn.Close()
        End If

        If cab_qty.SelectedIndex > 0 Then
            conn.Open()
            cmd.CommandText = "select cab_price from CABINET where cab_id=" & cab_id.Text & ";"
            tot = tot + cmd.ExecuteScalar() * cab_qty.SelectedIndex
            conn.Close()
        End If


        final_cost.Text = tot
    End Sub

End Class