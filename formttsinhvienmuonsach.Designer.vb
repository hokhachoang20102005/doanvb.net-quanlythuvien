<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formttsinhvienmuonsach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formttsinhvienmuonsach))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttimbangtensvhoactimbangtensach = New System.Windows.Forms.TextBox()
        Me.bttxoatt = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(246, 293)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(680, 311)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FloralWhite
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(414, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Thông tin mượn sách"
        '
        'txttimbangtensvhoactimbangtensach
        '
        Me.txttimbangtensvhoactimbangtensach.Location = New System.Drawing.Point(408, 265)
        Me.txttimbangtensvhoactimbangtensach.Name = "txttimbangtensvhoactimbangtensach"
        Me.txttimbangtensvhoactimbangtensach.Size = New System.Drawing.Size(348, 22)
        Me.txttimbangtensvhoactimbangtensach.TabIndex = 2
        '
        'bttxoatt
        '
        Me.bttxoatt.BackColor = System.Drawing.Color.Chocolate
        Me.bttxoatt.Location = New System.Drawing.Point(971, 595)
        Me.bttxoatt.Name = "bttxoatt"
        Me.bttxoatt.Size = New System.Drawing.Size(98, 40)
        Me.bttxoatt.TabIndex = 3
        Me.bttxoatt.Text = "xóa thông tin"
        Me.bttxoatt.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Chocolate
        Me.Button1.Location = New System.Drawing.Point(74, 595)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 40)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Thoát"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'formttsinhvienmuonsach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1115, 647)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bttxoatt)
        Me.Controls.Add(Me.txttimbangtensvhoactimbangtensach)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "formttsinhvienmuonsach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formttsinhvienmuonsach"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txttimbangtensvhoactimbangtensach As TextBox
    Friend WithEvents bttxoatt As Button
    Friend WithEvents Button1 As Button
End Class
