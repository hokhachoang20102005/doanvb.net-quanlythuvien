<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class muamuonsach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(muamuonsach))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cbbchonsinhvien = New System.Windows.Forms.ComboBox()
        Me.CheckedListBoxchonsach = New System.Windows.Forms.CheckedListBox()
        Me.bttmuasach = New System.Windows.Forms.Button()
        Me.bttmuonsach = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(159, 346)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(777, 289)
        Me.DataGridView1.TabIndex = 0
        '
        'cbbchonsinhvien
        '
        Me.cbbchonsinhvien.FormattingEnabled = True
        Me.cbbchonsinhvien.Location = New System.Drawing.Point(167, 97)
        Me.cbbchonsinhvien.Name = "cbbchonsinhvien"
        Me.cbbchonsinhvien.Size = New System.Drawing.Size(203, 24)
        Me.cbbchonsinhvien.TabIndex = 1
        '
        'CheckedListBoxchonsach
        '
        Me.CheckedListBoxchonsach.BackColor = System.Drawing.Color.LightCoral
        Me.CheckedListBoxchonsach.FormattingEnabled = True
        Me.CheckedListBoxchonsach.Location = New System.Drawing.Point(167, 183)
        Me.CheckedListBoxchonsach.Name = "CheckedListBoxchonsach"
        Me.CheckedListBoxchonsach.Size = New System.Drawing.Size(214, 157)
        Me.CheckedListBoxchonsach.TabIndex = 2
        '
        'bttmuasach
        '
        Me.bttmuasach.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.bttmuasach.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttmuasach.Location = New System.Drawing.Point(714, 97)
        Me.bttmuasach.Name = "bttmuasach"
        Me.bttmuasach.Size = New System.Drawing.Size(180, 50)
        Me.bttmuasach.TabIndex = 3
        Me.bttmuasach.Text = "Xác nhận mua"
        Me.bttmuasach.UseVisualStyleBackColor = False
        '
        'bttmuonsach
        '
        Me.bttmuonsach.BackColor = System.Drawing.Color.Yellow
        Me.bttmuonsach.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttmuonsach.ForeColor = System.Drawing.Color.DarkGreen
        Me.bttmuonsach.Location = New System.Drawing.Point(76, 112)
        Me.bttmuonsach.Name = "bttmuonsach"
        Me.bttmuonsach.Size = New System.Drawing.Size(155, 33)
        Me.bttmuonsach.TabIndex = 4
        Me.bttmuonsach.Text = "Xác nhận mượn"
        Me.bttmuonsach.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(22, 69)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(242, 27)
        Me.DateTimePicker1.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleVioletRed
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.bttmuonsach)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Location = New System.Drawing.Point(663, 189)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 151)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mượn sách"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(72, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "chọn hạn muốn trả"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(197, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 22)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Vui lòng chọn sv"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(185, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Vui lòng chọn sách"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(16, 605)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 30)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Thoát"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'muamuonsach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1115, 647)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bttmuasach)
        Me.Controls.Add(Me.CheckedListBoxchonsach)
        Me.Controls.Add(Me.cbbchonsinhvien)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "muamuonsach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "muamuonsach"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cbbchonsinhvien As ComboBox
    Friend WithEvents CheckedListBoxchonsach As CheckedListBox
    Friend WithEvents bttmuasach As Button
    Friend WithEvents bttmuonsach As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
