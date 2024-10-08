Public Class Form1
    ' Tài khoản và mật khẩu cố định
    Private Const Username As String = "hoang25"
    Private Const Password As String = "20102005"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Kiểm tra thông tin đăng nhập
        If TextBox1.Text = Username AndAlso TextBox2.Text = Password Then
            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Mở form chính
            formchinh.Show()
            Me.Hide() ' Ẩn form đăng nhập sau khi thành công
        Else
            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
