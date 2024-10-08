<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formchinh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formchinh))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bttttsasch = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.bttsach = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(392, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thư Viện HUBT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(680, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 48)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "QL Sinh viên"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'bttttsasch
        '
        Me.bttttsasch.BackColor = System.Drawing.Color.DarkKhaki
        Me.bttttsasch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttttsasch.Location = New System.Drawing.Point(296, 413)
        Me.bttttsasch.Name = "bttttsasch"
        Me.bttttsasch.Size = New System.Drawing.Size(134, 49)
        Me.bttttsasch.TabIndex = 2
        Me.bttttsasch.Text = "SL Sách"
        Me.bttttsasch.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(680, 414)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 48)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "TT mượn Sách"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'bttsach
        '
        Me.bttsach.BackColor = System.Drawing.Color.DarkKhaki
        Me.bttsach.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttsach.Location = New System.Drawing.Point(296, 336)
        Me.bttsach.Name = "bttsach"
        Me.bttsach.Size = New System.Drawing.Size(134, 45)
        Me.bttsach.TabIndex = 4
        Me.bttsach.Text = "SÁCH"
        Me.bttsach.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.GreenYellow
        Me.Button4.Location = New System.Drawing.Point(12, 584)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(110, 41)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "THOÁT"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'formchinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1115, 647)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.bttsach)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.bttttsasch)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formchinh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formchinh"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents bttttsasch As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents bttsach As Button
    Friend WithEvents Button4 As Button
End Class
