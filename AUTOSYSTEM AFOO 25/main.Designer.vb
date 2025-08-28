<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.count_label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.view_record_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.back_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.profile_id_combo = New System.Windows.Forms.ComboBox()
        Me.delete_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.fetch_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.reg = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.phone_number_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.email_address_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.full_name_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.passport = New System.Windows.Forms.PictureBox()
        Me.upload_passport_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.clear_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.submit_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.reg.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        CType(Me.passport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.close_btn)
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 68)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'close_btn
        '
        Me.close_btn.BackColor = System.Drawing.Color.Maroon
        Me.close_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.close_btn.Location = New System.Drawing.Point(910, -9)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(87, 77)
        Me.close_btn.TabIndex = 1
        Me.close_btn.Text = "X"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2Panel1.Controls.Add(Me.count_label)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.view_record_btn)
        Me.Guna2Panel1.Controls.Add(Me.back_btn)
        Me.Guna2Panel1.Location = New System.Drawing.Point(2, 68)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(987, 80)
        Me.Guna2Panel1.TabIndex = 1
        '
        'count_label
        '
        Me.count_label.AutoSize = True
        Me.count_label.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.count_label.ForeColor = System.Drawing.Color.Maroon
        Me.count_label.Location = New System.Drawing.Point(927, 28)
        Me.count_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.count_label.Name = "count_label"
        Me.count_label.Size = New System.Drawing.Size(27, 31)
        Me.count_label.TabIndex = 1
        Me.count_label.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(684, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NUMBERS OF RECORDS: "
        '
        'view_record_btn
        '
        Me.view_record_btn.BorderRadius = 5
        Me.view_record_btn.CheckedState.Parent = Me.view_record_btn
        Me.view_record_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.view_record_btn.CustomImages.Parent = Me.view_record_btn
        Me.view_record_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.view_record_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view_record_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.view_record_btn.HoverState.Parent = Me.view_record_btn
        Me.view_record_btn.Location = New System.Drawing.Point(159, 12)
        Me.view_record_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.view_record_btn.Name = "view_record_btn"
        Me.view_record_btn.ShadowDecoration.Parent = Me.view_record_btn
        Me.view_record_btn.Size = New System.Drawing.Size(180, 48)
        Me.view_record_btn.TabIndex = 0
        Me.view_record_btn.Text = "VIEW RECORDS"
        '
        'back_btn
        '
        Me.back_btn.BorderRadius = 5
        Me.back_btn.CheckedState.Parent = Me.back_btn
        Me.back_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back_btn.CustomImages.Parent = Me.back_btn
        Me.back_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.back_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.back_btn.HoverState.Parent = Me.back_btn
        Me.back_btn.Location = New System.Drawing.Point(24, 14)
        Me.back_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.ShadowDecoration.Parent = Me.back_btn
        Me.back_btn.Size = New System.Drawing.Size(120, 46)
        Me.back_btn.TabIndex = 0
        Me.back_btn.Text = "HOME"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderRadius = 5
        Me.Guna2GroupBox1.Controls.Add(Me.profile_id_combo)
        Me.Guna2GroupBox1.Controls.Add(Me.delete_btn)
        Me.Guna2GroupBox1.Controls.Add(Me.fetch_btn)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(22, 158)
        Me.Guna2GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(945, 183)
        Me.Guna2GroupBox1.TabIndex = 2
        Me.Guna2GroupBox1.Text = "SELECT A USER"
        '
        'profile_id_combo
        '
        Me.profile_id_combo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.profile_id_combo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profile_id_combo.FormattingEnabled = True
        Me.profile_id_combo.ItemHeight = 32
        Me.profile_id_combo.Location = New System.Drawing.Point(28, 72)
        Me.profile_id_combo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.profile_id_combo.Name = "profile_id_combo"
        Me.profile_id_combo.Size = New System.Drawing.Size(886, 40)
        Me.profile_id_combo.TabIndex = 0
        Me.profile_id_combo.Text = " "
        '
        'delete_btn
        '
        Me.delete_btn.BorderRadius = 5
        Me.delete_btn.CheckedState.Parent = Me.delete_btn
        Me.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delete_btn.CustomImages.Parent = Me.delete_btn
        Me.delete_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.delete_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_btn.ForeColor = System.Drawing.Color.White
        Me.delete_btn.HoverState.Parent = Me.delete_btn
        Me.delete_btn.Location = New System.Drawing.Point(777, 129)
        Me.delete_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.ShadowDecoration.Parent = Me.delete_btn
        Me.delete_btn.Size = New System.Drawing.Size(140, 46)
        Me.delete_btn.TabIndex = 0
        Me.delete_btn.Text = "DELETE"
        '
        'fetch_btn
        '
        Me.fetch_btn.BorderRadius = 5
        Me.fetch_btn.CheckedState.Parent = Me.fetch_btn
        Me.fetch_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fetch_btn.CustomImages.Parent = Me.fetch_btn
        Me.fetch_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.fetch_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fetch_btn.ForeColor = System.Drawing.Color.White
        Me.fetch_btn.HoverState.Parent = Me.fetch_btn
        Me.fetch_btn.Location = New System.Drawing.Point(28, 129)
        Me.fetch_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fetch_btn.Name = "fetch_btn"
        Me.fetch_btn.ShadowDecoration.Parent = Me.fetch_btn
        Me.fetch_btn.Size = New System.Drawing.Size(146, 46)
        Me.fetch_btn.TabIndex = 0
        Me.fetch_btn.Text = "FETCH"
        '
        'reg
        '
        Me.reg.BorderRadius = 5
        Me.reg.Controls.Add(Me.phone_number_txt)
        Me.reg.Controls.Add(Me.email_address_txt)
        Me.reg.Controls.Add(Me.full_name_txt)
        Me.reg.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.reg.Location = New System.Drawing.Point(26, 352)
        Me.reg.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.reg.Name = "reg"
        Me.reg.ShadowDecoration.Parent = Me.reg
        Me.reg.Size = New System.Drawing.Size(618, 458)
        Me.reg.TabIndex = 3
        Me.reg.Text = "REGISTRATION"
        '
        'phone_number_txt
        '
        Me.phone_number_txt.BorderRadius = 5
        Me.phone_number_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.phone_number_txt.DefaultText = ""
        Me.phone_number_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.phone_number_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.phone_number_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.phone_number_txt.DisabledState.Parent = Me.phone_number_txt
        Me.phone_number_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.phone_number_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.phone_number_txt.FocusedState.Parent = Me.phone_number_txt
        Me.phone_number_txt.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phone_number_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.phone_number_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.phone_number_txt.HoverState.Parent = Me.phone_number_txt
        Me.phone_number_txt.Location = New System.Drawing.Point(24, 338)
        Me.phone_number_txt.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.phone_number_txt.Name = "phone_number_txt"
        Me.phone_number_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.phone_number_txt.PlaceholderText = "ENTER PHONE NUMBER HERE"
        Me.phone_number_txt.SelectedText = ""
        Me.phone_number_txt.ShadowDecoration.Parent = Me.phone_number_txt
        Me.phone_number_txt.Size = New System.Drawing.Size(572, 74)
        Me.phone_number_txt.TabIndex = 0
        '
        'email_address_txt
        '
        Me.email_address_txt.BorderRadius = 5
        Me.email_address_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email_address_txt.DefaultText = ""
        Me.email_address_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.email_address_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.email_address_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email_address_txt.DisabledState.Parent = Me.email_address_txt
        Me.email_address_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email_address_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email_address_txt.FocusedState.Parent = Me.email_address_txt
        Me.email_address_txt.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_address_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.email_address_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email_address_txt.HoverState.Parent = Me.email_address_txt
        Me.email_address_txt.Location = New System.Drawing.Point(26, 222)
        Me.email_address_txt.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.email_address_txt.Name = "email_address_txt"
        Me.email_address_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.email_address_txt.PlaceholderText = "ENTER EMAIL ADDRESS HERE"
        Me.email_address_txt.SelectedText = ""
        Me.email_address_txt.ShadowDecoration.Parent = Me.email_address_txt
        Me.email_address_txt.Size = New System.Drawing.Size(572, 75)
        Me.email_address_txt.TabIndex = 0
        '
        'full_name_txt
        '
        Me.full_name_txt.BorderRadius = 5
        Me.full_name_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.full_name_txt.DefaultText = ""
        Me.full_name_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.full_name_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.full_name_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.full_name_txt.DisabledState.Parent = Me.full_name_txt
        Me.full_name_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.full_name_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.full_name_txt.FocusedState.Parent = Me.full_name_txt
        Me.full_name_txt.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.full_name_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.full_name_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.full_name_txt.HoverState.Parent = Me.full_name_txt
        Me.full_name_txt.Location = New System.Drawing.Point(26, 105)
        Me.full_name_txt.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.full_name_txt.Name = "full_name_txt"
        Me.full_name_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.full_name_txt.PlaceholderText = "ENTER FULL NAME HERE"
        Me.full_name_txt.SelectedText = ""
        Me.full_name_txt.ShadowDecoration.Parent = Me.full_name_txt
        Me.full_name_txt.Size = New System.Drawing.Size(572, 77)
        Me.full_name_txt.TabIndex = 0
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BorderRadius = 5
        Me.Guna2GroupBox2.Controls.Add(Me.passport)
        Me.Guna2GroupBox2.Controls.Add(Me.upload_passport_btn)
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(652, 354)
        Me.Guna2GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(315, 385)
        Me.Guna2GroupBox2.TabIndex = 4
        Me.Guna2GroupBox2.Text = "PASSPORT"
        '
        'passport
        '
        Me.passport.BackgroundImage = CType(resources.GetObject("passport.BackgroundImage"), System.Drawing.Image)
        Me.passport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.passport.Location = New System.Drawing.Point(4, 63)
        Me.passport.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.passport.Name = "passport"
        Me.passport.Size = New System.Drawing.Size(306, 235)
        Me.passport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.passport.TabIndex = 0
        Me.passport.TabStop = False
        '
        'upload_passport_btn
        '
        Me.upload_passport_btn.BorderRadius = 3
        Me.upload_passport_btn.CheckedState.Parent = Me.upload_passport_btn
        Me.upload_passport_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.upload_passport_btn.CustomImages.Parent = Me.upload_passport_btn
        Me.upload_passport_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.upload_passport_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upload_passport_btn.ForeColor = System.Drawing.Color.White
        Me.upload_passport_btn.HoverState.Parent = Me.upload_passport_btn
        Me.upload_passport_btn.Location = New System.Drawing.Point(6, 309)
        Me.upload_passport_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.upload_passport_btn.Name = "upload_passport_btn"
        Me.upload_passport_btn.ShadowDecoration.Parent = Me.upload_passport_btn
        Me.upload_passport_btn.Size = New System.Drawing.Size(310, 71)
        Me.upload_passport_btn.TabIndex = 0
        Me.upload_passport_btn.Text = "UPLOAD PICTURE"
        '
        'clear_btn
        '
        Me.clear_btn.BorderRadius = 5
        Me.clear_btn.CheckedState.Parent = Me.clear_btn
        Me.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear_btn.CustomImages.Parent = Me.clear_btn
        Me.clear_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.clear_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.ForeColor = System.Drawing.Color.White
        Me.clear_btn.HoverState.Parent = Me.clear_btn
        Me.clear_btn.Location = New System.Drawing.Point(820, 748)
        Me.clear_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.ShadowDecoration.Parent = Me.clear_btn
        Me.clear_btn.Size = New System.Drawing.Size(147, 57)
        Me.clear_btn.TabIndex = 2
        Me.clear_btn.Text = "CLEAR"
        '
        'submit_btn
        '
        Me.submit_btn.BorderRadius = 5
        Me.submit_btn.CheckedState.Parent = Me.submit_btn
        Me.submit_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.submit_btn.CustomImages.Parent = Me.submit_btn
        Me.submit_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.submit_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit_btn.ForeColor = System.Drawing.Color.White
        Me.submit_btn.HoverState.Parent = Me.submit_btn
        Me.submit_btn.Location = New System.Drawing.Point(656, 748)
        Me.submit_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.submit_btn.Name = "submit_btn"
        Me.submit_btn.ShadowDecoration.Parent = Me.submit_btn
        Me.submit_btn.Size = New System.Drawing.Size(150, 57)
        Me.submit_btn.TabIndex = 1
        Me.submit_btn.Text = "SUBMIT"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 953)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.submit_btn)
        Me.Controls.Add(Me.reg)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.reg.ResumeLayout(False)
        Me.Guna2GroupBox2.ResumeLayout(False)
        CType(Me.passport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents count_label As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents view_record_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents back_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents profile_id_combo As System.Windows.Forms.ComboBox
    Friend WithEvents delete_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents fetch_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents reg As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents phone_number_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents email_address_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents full_name_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents passport As System.Windows.Forms.PictureBox
    Friend WithEvents upload_passport_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents clear_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents submit_btn As Guna.UI2.WinForms.Guna2Button
End Class
