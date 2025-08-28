<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_record
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(user_record))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.count_label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.back_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.record_grid = New System.Windows.Forms.DataGridView()
        Me.Guna2Panel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.record_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2Panel1.Controls.Add(Me.count_label)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.back_btn)
        Me.Guna2Panel1.Location = New System.Drawing.Point(2, 49)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(657, 48)
        Me.Guna2Panel1.TabIndex = 3
        '
        'count_label
        '
        Me.count_label.AutoSize = True
        Me.count_label.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.count_label.ForeColor = System.Drawing.Color.Maroon
        Me.count_label.Location = New System.Drawing.Point(618, 18)
        Me.count_label.Name = "count_label"
        Me.count_label.Size = New System.Drawing.Size(18, 20)
        Me.count_label.TabIndex = 1
        Me.count_label.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(456, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NUMBERS OF RECORDS: "
        '
        'back_btn
        '
        Me.back_btn.BorderRadius = 3
        Me.back_btn.CheckedState.Parent = Me.back_btn
        Me.back_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back_btn.CustomImages.Parent = Me.back_btn
        Me.back_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.back_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn.ForeColor = System.Drawing.Color.White
        Me.back_btn.HoverState.Parent = Me.back_btn
        Me.back_btn.Location = New System.Drawing.Point(16, 9)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.ShadowDecoration.Parent = Me.back_btn
        Me.back_btn.Size = New System.Drawing.Size(80, 30)
        Me.back_btn.TabIndex = 0
        Me.back_btn.Text = "BACK"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.close_btn)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(661, 52)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'close_btn
        '
        Me.close_btn.BackColor = System.Drawing.Color.Maroon
        Me.close_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_btn.FlatAppearance.BorderSize = 0
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.close_btn.Location = New System.Drawing.Point(607, 0)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(58, 52)
        Me.close_btn.TabIndex = 1
        Me.close_btn.Text = "X"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'record_grid
        '
        Me.record_grid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.record_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.record_grid.Location = New System.Drawing.Point(12, 103)
        Me.record_grid.MultiSelect = False
        Me.record_grid.Name = "record_grid"
        Me.record_grid.ReadOnly = True
        Me.record_grid.Size = New System.Drawing.Size(635, 433)
        Me.record_grid.TabIndex = 4
        '
        'user_record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 548)
        Me.Controls.Add(Me.record_grid)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "user_record"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "user_record"
        Me.TopMost = True
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.record_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents count_label As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents back_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents record_grid As System.Windows.Forms.DataGridView
End Class
