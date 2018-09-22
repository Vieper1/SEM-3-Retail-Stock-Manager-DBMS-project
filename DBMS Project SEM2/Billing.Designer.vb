<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Billing_page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ct_no = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.main_list = New System.Windows.Forms.ListBox()
        Me.display_obj = New System.Windows.Forms.Button()
        Me.grid1 = New System.Windows.Forms.DataGridView()
        Me.clear_grid = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mobo_id = New System.Windows.Forms.TextBox()
        Me.pro_id = New System.Windows.Forms.TextBox()
        Me.ram_id = New System.Windows.Forms.TextBox()
        Me.gpu_id = New System.Windows.Forms.TextBox()
        Me.psu_id = New System.Windows.Forms.TextBox()
        Me.hdd_id = New System.Windows.Forms.TextBox()
        Me.cab_id = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.mobo_qty = New System.Windows.Forms.ListBox()
        Me.pro_qty = New System.Windows.Forms.ListBox()
        Me.ram_qty = New System.Windows.Forms.ListBox()
        Me.gpu_qty = New System.Windows.Forms.ListBox()
        Me.psu_qty = New System.Windows.Forms.ListBox()
        Me.hdd_qty = New System.Windows.Forms.ListBox()
        Me.cab_qty = New System.Windows.Forms.ListBox()
        Me.bill_it = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.final_cost = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(300, 50)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "GO BACK TO MAIN MENU"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(13, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(13, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Last Name"
        '
        'fname
        '
        Me.fname.Location = New System.Drawing.Point(143, 86)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(200, 30)
        Me.fname.TabIndex = 4
        '
        'lname
        '
        Me.lname.Location = New System.Drawing.Point(143, 131)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(200, 30)
        Me.lname.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(12, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Contact Number"
        '
        'ct_no
        '
        Me.ct_no.Location = New System.Drawing.Point(143, 173)
        Me.ct_no.Name = "ct_no"
        Me.ct_no.Size = New System.Drawing.Size(200, 30)
        Me.ct_no.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(12, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 28)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ADD OBJECT"
        '
        'main_list
        '
        Me.main_list.FormattingEnabled = True
        Me.main_list.ItemHeight = 24
        Me.main_list.Items.AddRange(New Object() {"MOTHERBOARD", "PROCESSOR", "RAM", "GRAPHIC CARD", "PSU", "HDD", "CABINET"})
        Me.main_list.Location = New System.Drawing.Point(17, 251)
        Me.main_list.Name = "main_list"
        Me.main_list.Size = New System.Drawing.Size(120, 172)
        Me.main_list.TabIndex = 10
        '
        'display_obj
        '
        Me.display_obj.ForeColor = System.Drawing.SystemColors.ControlText
        Me.display_obj.Location = New System.Drawing.Point(143, 251)
        Me.display_obj.Name = "display_obj"
        Me.display_obj.Size = New System.Drawing.Size(239, 40)
        Me.display_obj.TabIndex = 12
        Me.display_obj.Text = "DISPLAY GRID"
        Me.display_obj.UseVisualStyleBackColor = True
        '
        'grid1
        '
        Me.grid1.AllowUserToAddRows = False
        Me.grid1.AllowUserToDeleteRows = False
        Me.grid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.grid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.Location = New System.Drawing.Point(388, 12)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(950, 350)
        Me.grid1.TabIndex = 13
        '
        'clear_grid
        '
        Me.clear_grid.ForeColor = System.Drawing.SystemColors.ControlText
        Me.clear_grid.Location = New System.Drawing.Point(143, 322)
        Me.clear_grid.Name = "clear_grid"
        Me.clear_grid.Size = New System.Drawing.Size(239, 40)
        Me.clear_grid.TabIndex = 14
        Me.clear_grid.Text = "CLEAR GRID"
        Me.clear_grid.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(20, 488)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 25)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Object ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(20, 528)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 25)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Object Quantity"
        '
        'mobo_id
        '
        Me.mobo_id.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mobo_id.Location = New System.Drawing.Point(212, 486)
        Me.mobo_id.Name = "mobo_id"
        Me.mobo_id.Size = New System.Drawing.Size(100, 30)
        Me.mobo_id.TabIndex = 15
        Me.mobo_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pro_id
        '
        Me.pro_id.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pro_id.Location = New System.Drawing.Point(318, 486)
        Me.pro_id.Name = "pro_id"
        Me.pro_id.Size = New System.Drawing.Size(100, 30)
        Me.pro_id.TabIndex = 17
        Me.pro_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ram_id
        '
        Me.ram_id.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ram_id.Location = New System.Drawing.Point(424, 486)
        Me.ram_id.Name = "ram_id"
        Me.ram_id.Size = New System.Drawing.Size(100, 30)
        Me.ram_id.TabIndex = 19
        Me.ram_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gpu_id
        '
        Me.gpu_id.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpu_id.Location = New System.Drawing.Point(530, 486)
        Me.gpu_id.Name = "gpu_id"
        Me.gpu_id.Size = New System.Drawing.Size(100, 30)
        Me.gpu_id.TabIndex = 21
        Me.gpu_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'psu_id
        '
        Me.psu_id.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.psu_id.Location = New System.Drawing.Point(636, 486)
        Me.psu_id.Name = "psu_id"
        Me.psu_id.Size = New System.Drawing.Size(100, 30)
        Me.psu_id.TabIndex = 23
        Me.psu_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'hdd_id
        '
        Me.hdd_id.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdd_id.Location = New System.Drawing.Point(742, 486)
        Me.hdd_id.Name = "hdd_id"
        Me.hdd_id.Size = New System.Drawing.Size(100, 30)
        Me.hdd_id.TabIndex = 25
        Me.hdd_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cab_id
        '
        Me.cab_id.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cab_id.Location = New System.Drawing.Point(848, 486)
        Me.cab_id.Name = "cab_id"
        Me.cab_id.Size = New System.Drawing.Size(100, 30)
        Me.cab_id.TabIndex = 27
        Me.cab_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(208, 445)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 24)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "MOTHERBOARD"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(314, 445)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 24)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "PROCESSOR"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Location = New System.Drawing.Point(420, 445)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 24)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "RAM"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label10.Location = New System.Drawing.Point(526, 445)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 24)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "GPU"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label11.Location = New System.Drawing.Point(632, 445)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 24)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "PSU"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label12.Location = New System.Drawing.Point(738, 445)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 24)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "HDD"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label13.Location = New System.Drawing.Point(844, 445)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 24)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "CABINET"
        '
        'mobo_qty
        '
        Me.mobo_qty.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mobo_qty.FormattingEnabled = True
        Me.mobo_qty.ItemHeight = 24
        Me.mobo_qty.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.mobo_qty.Location = New System.Drawing.Point(212, 528)
        Me.mobo_qty.Name = "mobo_qty"
        Me.mobo_qty.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mobo_qty.Size = New System.Drawing.Size(100, 124)
        Me.mobo_qty.TabIndex = 40
        '
        'pro_qty
        '
        Me.pro_qty.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pro_qty.FormattingEnabled = True
        Me.pro_qty.ItemHeight = 24
        Me.pro_qty.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.pro_qty.Location = New System.Drawing.Point(318, 528)
        Me.pro_qty.Name = "pro_qty"
        Me.pro_qty.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pro_qty.Size = New System.Drawing.Size(100, 124)
        Me.pro_qty.TabIndex = 41
        '
        'ram_qty
        '
        Me.ram_qty.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ram_qty.FormattingEnabled = True
        Me.ram_qty.ItemHeight = 24
        Me.ram_qty.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.ram_qty.Location = New System.Drawing.Point(424, 528)
        Me.ram_qty.Name = "ram_qty"
        Me.ram_qty.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ram_qty.Size = New System.Drawing.Size(100, 124)
        Me.ram_qty.TabIndex = 42
        '
        'gpu_qty
        '
        Me.gpu_qty.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpu_qty.FormattingEnabled = True
        Me.gpu_qty.ItemHeight = 24
        Me.gpu_qty.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.gpu_qty.Location = New System.Drawing.Point(530, 528)
        Me.gpu_qty.Name = "gpu_qty"
        Me.gpu_qty.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gpu_qty.Size = New System.Drawing.Size(100, 124)
        Me.gpu_qty.TabIndex = 43
        '
        'psu_qty
        '
        Me.psu_qty.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.psu_qty.FormattingEnabled = True
        Me.psu_qty.ItemHeight = 24
        Me.psu_qty.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.psu_qty.Location = New System.Drawing.Point(636, 528)
        Me.psu_qty.Name = "psu_qty"
        Me.psu_qty.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.psu_qty.Size = New System.Drawing.Size(100, 124)
        Me.psu_qty.TabIndex = 44
        '
        'hdd_qty
        '
        Me.hdd_qty.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdd_qty.FormattingEnabled = True
        Me.hdd_qty.ItemHeight = 24
        Me.hdd_qty.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.hdd_qty.Location = New System.Drawing.Point(742, 528)
        Me.hdd_qty.Name = "hdd_qty"
        Me.hdd_qty.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.hdd_qty.Size = New System.Drawing.Size(100, 124)
        Me.hdd_qty.TabIndex = 45
        '
        'cab_qty
        '
        Me.cab_qty.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cab_qty.FormattingEnabled = True
        Me.cab_qty.ItemHeight = 24
        Me.cab_qty.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cab_qty.Location = New System.Drawing.Point(848, 528)
        Me.cab_qty.Name = "cab_qty"
        Me.cab_qty.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cab_qty.Size = New System.Drawing.Size(100, 124)
        Me.cab_qty.TabIndex = 46
        '
        'bill_it
        '
        Me.bill_it.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bill_it.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bill_it.Location = New System.Drawing.Point(17, 680)
        Me.bill_it.Name = "bill_it"
        Me.bill_it.Size = New System.Drawing.Size(180, 37)
        Me.bill_it.TabIndex = 39
        Me.bill_it.Text = "FINALIZE"
        Me.bill_it.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(17, 615)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 37)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "TOTAL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'final_cost
        '
        Me.final_cost.BackColor = System.Drawing.SystemColors.Window
        Me.final_cost.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.final_cost.ForeColor = System.Drawing.SystemColors.ControlText
        Me.final_cost.Location = New System.Drawing.Point(212, 680)
        Me.final_cost.Name = "final_cost"
        Me.final_cost.Size = New System.Drawing.Size(736, 37)
        Me.final_cost.TabIndex = 47
        Me.final_cost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label14.Location = New System.Drawing.Point(119, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 24)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label15.Location = New System.Drawing.Point(119, 134)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(18, 24)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label16.Location = New System.Drawing.Point(119, 176)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 24)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "*"
        '
        'Billing_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DBMS_Project_SEM2.My.Resources.Resources.Wireframe
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.final_cost)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.bill_it)
        Me.Controls.Add(Me.cab_qty)
        Me.Controls.Add(Me.hdd_qty)
        Me.Controls.Add(Me.psu_qty)
        Me.Controls.Add(Me.gpu_qty)
        Me.Controls.Add(Me.ram_qty)
        Me.Controls.Add(Me.pro_qty)
        Me.Controls.Add(Me.mobo_qty)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cab_id)
        Me.Controls.Add(Me.hdd_id)
        Me.Controls.Add(Me.psu_id)
        Me.Controls.Add(Me.gpu_id)
        Me.Controls.Add(Me.ram_id)
        Me.Controls.Add(Me.pro_id)
        Me.Controls.Add(Me.mobo_id)
        Me.Controls.Add(Me.clear_grid)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.display_obj)
        Me.Controls.Add(Me.main_list)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ct_no)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "Billing_page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BILL GENERATOR"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents fname As TextBox
    Friend WithEvents lname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ct_no As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents main_list As ListBox
    Friend WithEvents display_obj As Button
    Friend WithEvents grid1 As DataGridView
    Friend WithEvents clear_grid As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents mobo_id As TextBox
    Friend WithEvents pro_id As TextBox
    Friend WithEvents ram_id As TextBox
    Friend WithEvents gpu_id As TextBox
    Friend WithEvents psu_id As TextBox
    Friend WithEvents hdd_id As TextBox
    Friend WithEvents cab_id As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents mobo_qty As ListBox
    Friend WithEvents pro_qty As ListBox
    Friend WithEvents ram_qty As ListBox
    Friend WithEvents gpu_qty As ListBox
    Friend WithEvents psu_qty As ListBox
    Friend WithEvents hdd_qty As ListBox
    Friend WithEvents cab_qty As ListBox
    Friend WithEvents bill_it As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents final_cost As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
End Class
