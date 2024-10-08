<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formsinhvien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formsinhvien))
        Me.bttthem = New System.Windows.Forms.Button()
        Me.bttsua = New System.Windows.Forms.Button()
        Me.bttxoa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtmasv = New System.Windows.Forms.TextBox()
        Me.txthotensv = New System.Windows.Forms.TextBox()
        Me.txtlopsinhvien = New System.Windows.Forms.TextBox()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.txtgioitinh = New System.Windows.Forms.TextBox()
        Me.txtngaysinh = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btttimkiemtheoten = New System.Windows.Forms.Button()
        Me.txtnhaptentimkiem = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttthem
        '
        Me.bttthem.BackColor = System.Drawing.Color.Yellow
        Me.bttthem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttthem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttthem.Location = New System.Drawing.Point(728, 217)
        Me.bttthem.Name = "bttthem"
        Me.bttthem.Size = New System.Drawing.Size(109, 42)
        Me.bttthem.TabIndex = 12
        Me.bttthem.Text = "Thêm"
        Me.bttthem.UseVisualStyleBackColor = False
        '
        'bttsua
        '
        Me.bttsua.BackColor = System.Drawing.Color.Yellow
        Me.bttsua.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttsua.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttsua.Location = New System.Drawing.Point(671, 100)
        Me.bttsua.Name = "bttsua"
        Me.bttsua.Size = New System.Drawing.Size(109, 42)
        Me.bttsua.TabIndex = 13
        Me.bttsua.Text = "sửa"
        Me.bttsua.UseVisualStyleBackColor = False
        '
        'bttxoa
        '
        Me.bttxoa.BackColor = System.Drawing.Color.Yellow
        Me.bttxoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttxoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttxoa.Location = New System.Drawing.Point(671, 152)
        Me.bttxoa.Name = "bttxoa"
        Me.bttxoa.Size = New System.Drawing.Size(109, 40)
        Me.bttxoa.TabIndex = 14
        Me.bttxoa.Text = "xóa"
        Me.bttxoa.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Cyan
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(241, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 22)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "mã sv"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Cyan
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(241, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 22)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Họ tên"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Cyan
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(244, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 22)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "lớp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Cyan
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(244, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 22)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Sđt"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Cyan
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(244, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 22)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "giới tính"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Cyan
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(244, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 22)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "ngày sinh"
        '
        'txtmasv
        '
        Me.txtmasv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmasv.Location = New System.Drawing.Point(381, 80)
        Me.txtmasv.Name = "txtmasv"
        Me.txtmasv.Size = New System.Drawing.Size(185, 22)
        Me.txtmasv.TabIndex = 22
        '
        'txthotensv
        '
        Me.txthotensv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txthotensv.Location = New System.Drawing.Point(381, 112)
        Me.txthotensv.Name = "txthotensv"
        Me.txthotensv.Size = New System.Drawing.Size(185, 22)
        Me.txthotensv.TabIndex = 23
        '
        'txtlopsinhvien
        '
        Me.txtlopsinhvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtlopsinhvien.Location = New System.Drawing.Point(381, 143)
        Me.txtlopsinhvien.Name = "txtlopsinhvien"
        Me.txtlopsinhvien.Size = New System.Drawing.Size(185, 22)
        Me.txtlopsinhvien.TabIndex = 24
        '
        'txtsdt
        '
        Me.txtsdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsdt.Location = New System.Drawing.Point(381, 176)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(185, 22)
        Me.txtsdt.TabIndex = 25
        '
        'txtgioitinh
        '
        Me.txtgioitinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtgioitinh.Location = New System.Drawing.Point(381, 213)
        Me.txtgioitinh.Name = "txtgioitinh"
        Me.txtgioitinh.Size = New System.Drawing.Size(185, 22)
        Me.txtgioitinh.TabIndex = 26
        '
        'txtngaysinh
        '
        Me.txtngaysinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtngaysinh.Location = New System.Drawing.Point(381, 251)
        Me.txtngaysinh.Name = "txtngaysinh"
        Me.txtngaysinh.Size = New System.Drawing.Size(185, 22)
        Me.txtngaysinh.TabIndex = 27
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(210, 344)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(795, 245)
        Me.DataGridView1.TabIndex = 28
        '
        'btttimkiemtheoten
        '
        Me.btttimkiemtheoten.BackColor = System.Drawing.Color.Yellow
        Me.btttimkiemtheoten.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btttimkiemtheoten.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btttimkiemtheoten.Location = New System.Drawing.Point(812, 101)
        Me.btttimkiemtheoten.Name = "btttimkiemtheoten"
        Me.btttimkiemtheoten.Size = New System.Drawing.Size(109, 40)
        Me.btttimkiemtheoten.TabIndex = 29
        Me.btttimkiemtheoten.Text = "tìm kiếm"
        Me.btttimkiemtheoten.UseVisualStyleBackColor = False
        '
        'txtnhaptentimkiem
        '
        Me.txtnhaptentimkiem.Location = New System.Drawing.Point(812, 162)
        Me.txtnhaptentimkiem.Name = "txtnhaptentimkiem"
        Me.txtnhaptentimkiem.Size = New System.Drawing.Size(109, 22)
        Me.txtnhaptentimkiem.TabIndex = 30
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 566)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "thoát"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'formsinhvien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1115, 647)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtnhaptentimkiem)
        Me.Controls.Add(Me.btttimkiemtheoten)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtngaysinh)
        Me.Controls.Add(Me.txtgioitinh)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.txtlopsinhvien)
        Me.Controls.Add(Me.txthotensv)
        Me.Controls.Add(Me.txtmasv)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttxoa)
        Me.Controls.Add(Me.bttsua)
        Me.Controls.Add(Me.bttthem)
        Me.Name = "formsinhvien"
        Me.Text = "formsinhvien"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttthem As Button
    Friend WithEvents bttsua As Button
    Friend WithEvents bttxoa As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtmasv As TextBox
    Friend WithEvents txthotensv As TextBox
    Friend WithEvents txtlopsinhvien As TextBox
    Friend WithEvents txtsdt As TextBox
    Friend WithEvents txtgioitinh As TextBox
    Friend WithEvents txtngaysinh As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btttimkiemtheoten As Button
    Friend WithEvents txtnhaptentimkiem As TextBox
    Friend WithEvents Button1 As Button
End Class
