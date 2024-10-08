Imports System.Data.SqlClient

Public Class formsinhvien
    ' Chuỗi kết nối tới cơ sở dữ liệu
    Private connectionString As String = "Data Source=HOANG20-8-24\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True"
    Private connection As SqlConnection
    Private command As SqlCommand
    Private adapter As SqlDataAdapter
    Private dt As DataTable

    Private Sub formsinhvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        ' Đặt chế độ lựa chọn thành chọn toàn bộ hàng
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub LoadData()
        Try
            connection = New SqlConnection(connectionString)
            connection.Open()
            command = New SqlCommand("SELECT * FROM SinhVien", connection)
            adapter = New SqlDataAdapter(command)
            dt = New DataTable()
            adapter.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải dữ liệu: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub bttthem_Click(sender As Object, e As EventArgs) Handles bttthem.Click
        Try
            connection = New SqlConnection(connectionString)
            connection.Open()

            ' Kiểm tra nếu ngày sinh không hợp lệ
            Dim ngaySinh As DateTime
            If Not DateTime.TryParseExact(txtngaysinh.Text, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, ngaySinh) Then
                MessageBox.Show("Ngày sinh không hợp lệ, vui lòng nhập theo định dạng dd/MM/yyyy.")
                Exit Sub
            End If

            command = New SqlCommand("INSERT INTO SinhVien (maSV, hoTenSV, gioiTinhSV, sdt, ngaySinhSV, lopSV) VALUES (@maSV, @hoTenSV, @gioiTinhSV, @sdt, @ngaySinhSV, @lopSV)", connection)

            command.Parameters.AddWithValue("@maSV", txtmasv.Text)
            command.Parameters.AddWithValue("@hoTenSV", txthotensv.Text)
            command.Parameters.AddWithValue("@gioiTinhSV", txtgioitinh.Text)
            command.Parameters.AddWithValue("@sdt", txtsdt.Text)
            command.Parameters.AddWithValue("@ngaySinhSV", ngaySinh)
            command.Parameters.AddWithValue("@lopSV", txtlopsinhvien.Text)

            command.ExecuteNonQuery()
            MessageBox.Show("Thêm sinh viên thành công!")
            LoadData()
            ClearFields() ' Gọi hàm để xóa các trường
        Catch ex As Exception
            MessageBox.Show("Lỗi khi thêm sinh viên: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub bttsua_Click(sender As Object, e As EventArgs) Handles bttsua.Click
        Try
            connection = New SqlConnection(connectionString)
            connection.Open()

            ' Kiểm tra nếu ngày sinh không hợp lệ
            Dim ngaySinh As DateTime
            If Not DateTime.TryParseExact(txtngaysinh.Text, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, ngaySinh) Then
                MessageBox.Show("Ngày sinh không hợp lệ, vui lòng nhập theo định dạng dd/MM/yyyy.")
                Exit Sub
            End If

            command = New SqlCommand("UPDATE SinhVien SET hoTenSV=@hoTenSV, gioiTinhSV=@gioiTinhSV, sdt=@sdt, ngaySinhSV=@ngaySinhSV, lopSV=@lopSV WHERE maSV=@maSV", connection)

            command.Parameters.AddWithValue("@maSV", txtmasv.Text)
            command.Parameters.AddWithValue("@hoTenSV", txthotensv.Text)
            command.Parameters.AddWithValue("@gioiTinhSV", txtgioitinh.Text)
            command.Parameters.AddWithValue("@sdt", txtsdt.Text)
            command.Parameters.AddWithValue("@ngaySinhSV", ngaySinh)
            command.Parameters.AddWithValue("@lopSV", txtlopsinhvien.Text)

            command.ExecuteNonQuery()
            MessageBox.Show("Sửa thông tin sinh viên thành công!")
            LoadData()
            ClearFields() ' Gọi hàm để xóa các trường
        Catch ex As Exception
            MessageBox.Show("Lỗi khi sửa sinh viên: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub bttxoa_Click(sender As Object, e As EventArgs) Handles bttxoa.Click
        Try
            connection = New SqlConnection(connectionString)
            connection.Open()
            command = New SqlCommand("DELETE FROM SinhVien WHERE maSV=@maSV", connection)

            command.Parameters.AddWithValue("@maSV", txtmasv.Text)

            command.ExecuteNonQuery()
            MessageBox.Show("Xóa sinh viên thành công!")
            LoadData()
            ClearFields() ' Gọi hàm để xóa các trường
        Catch ex As Exception
            MessageBox.Show("Lỗi khi xóa sinh viên: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            txtmasv.Text = selectedRow.Cells("maSV").Value.ToString()
            txthotensv.Text = selectedRow.Cells("hoTenSV").Value.ToString()
            txtgioitinh.Text = selectedRow.Cells("gioiTinhSV").Value.ToString()
            txtsdt.Text = selectedRow.Cells("sdt").Value.ToString()
            txtngaysinh.Text = Convert.ToDateTime(selectedRow.Cells("ngaySinhSV").Value).ToString("dd/MM/yyyy")
            txtlopsinhvien.Text = selectedRow.Cells("lopSV").Value.ToString()
        End If
    End Sub

    Private Sub ClearFields()
        txtmasv.Clear()
        txthotensv.Clear()
        txtgioitinh.Clear()
        txtsdt.Clear()
        txtngaysinh.Clear()
        txtlopsinhvien.Clear()
    End Sub

    Private Sub btttimkiemtheoten_Click(sender As Object, e As EventArgs) Handles btttimkiemtheoten.Click
        ' Gọi hàm tìm kiếm khi nút tìm kiếm được nhấn
        If String.IsNullOrWhiteSpace(txtnhaptentimkiem.Text) Then
            MessageBox.Show("Vui lòng nhập tên sinh viên để tìm kiếm.")
        Else
            SearchByName(txtnhaptentimkiem.Text)
        End If
    End Sub

    Private Sub SearchByName(name As String)
        Try
            connection = New SqlConnection(connectionString)
            connection.Open()
            command = New SqlCommand("SELECT * FROM SinhVien WHERE hoTenSV LIKE @hoTenSV", connection)
            command.Parameters.AddWithValue("@hoTenSV", "%" & name & "%")
            adapter = New SqlDataAdapter(command)
            dt = New DataTable()
            adapter.Fill(dt)
            DataGridView1.DataSource = dt

            ' Kiểm tra nếu không tìm thấy kết quả
            If dt.Rows.Count = 0 Then
                MessageBox.Show("Không tìm thấy sinh viên với tên: " & name)
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tìm kiếm: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
