Imports System.Data.SqlClient

Public Class muamuonsach
    Private Sub muamuonsach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGridView()
        LoadComboBoxSinhVien()
        LoadCheckedListBoxSach()
        SetupDateTimePicker()
    End Sub

    Private Sub SetupDateTimePicker()
        DateTimePicker1.MinDate = DateTime.Now.AddDays(1)
        DateTimePicker1.MaxDate = DateTime.Now.AddMonths(1)
        DateTimePicker1.Value = DateTime.Now.AddDays(14) ' Default is 2 weeks
    End Sub

    Private Sub LoadDataGridView()
        Dim dt As New DataTable()
        Using con As New SqlConnection("Data Source=HOANG20-8-24\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True")
            Dim cmd As New SqlCommand("SELECT maSach, tenSach, tentacgia, gia, soLuong FROM Sach", con)
            Dim adapter As New SqlDataAdapter(cmd)

            con.Open()
            adapter.Fill(dt)
            con.Close()
        End Using

        DataGridView1.DataSource = dt
    End Sub

    Private Sub LoadComboBoxSinhVien()
        Using con As New SqlConnection("Data Source=HOANG20-8-24\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True")
            Dim cmd As New SqlCommand("SELECT maSV, hoTenSV FROM SinhVien", con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            con.Open()
            adapter.Fill(dt)
            con.Close()

            cbbchonsinhvien.DataSource = dt
            cbbchonsinhvien.DisplayMember = "hoTenSV"
            cbbchonsinhvien.ValueMember = "maSV"
        End Using
    End Sub

    Private Sub LoadCheckedListBoxSach()
        Using con As New SqlConnection("Data Source=HOANG20-8-24\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True")
            Dim cmd As New SqlCommand("SELECT maSach, tenSach, tentacgia, soLuong FROM Sach", con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            con.Open()
            adapter.Fill(dt)
            con.Close()

            CheckedListBoxchonsach.DataSource = dt
            CheckedListBoxchonsach.DisplayMember = "tenSach"
            CheckedListBoxchonsach.ValueMember = "maSach"
        End Using
    End Sub

    Private Sub bttmuonsach_Click(sender As Object, e As EventArgs) Handles bttmuonsach.Click
        If cbbchonsinhvien.SelectedItem IsNot Nothing AndAlso CheckedListBoxchonsach.CheckedItems.Count > 0 Then
            Dim maSV As String = cbbchonsinhvien.SelectedValue.ToString()
            Dim hanTra As DateTime = DateTimePicker1.Value

            Using con As New SqlConnection("Data Source=HOANG20-8-24\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True")
                con.Open()

                For Each item In CheckedListBoxchonsach.CheckedItems
                    Dim maSach As Integer = CType(item, DataRowView)("maSach")
                    Dim soLuong As Integer = CType(item, DataRowView)("soLuong")

                    If soLuong > 0 Then
                        Dim ngayMuon As DateTime = DateTime.Now

                        Dim cmd As New SqlCommand("INSERT INTO CTMuon (maSV, maSach, ngayMuon, hanTra) VALUES (@maSV, @maSach, @ngayMuon, @hanTra)", con)
                        cmd.Parameters.AddWithValue("@maSV", maSV)
                        cmd.Parameters.AddWithValue("@maSach", maSach)
                        cmd.Parameters.AddWithValue("@ngayMuon", ngayMuon)
                        cmd.Parameters.AddWithValue("@hanTra", hanTra)

                        cmd.ExecuteNonQuery()

                        ' Decrease book quantity
                        Dim cmdUpdate As New SqlCommand("UPDATE Sach SET soLuong = soLuong - 1 WHERE maSach = @maSach", con)
                        cmdUpdate.Parameters.AddWithValue("@maSach", maSach)
                        cmdUpdate.ExecuteNonQuery()
                    Else
                        MessageBox.Show("Số lượng sách không đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Next

                con.Close()
            End Using

            MessageBox.Show("Mượn sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reload data
            LoadDataGridView()
            LoadCheckedListBoxSach()
        Else
            MessageBox.Show("Vui lòng chọn sinh viên và sách để mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub CheckedListBoxchonsach_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBoxchonsach.SelectedIndexChanged

    End Sub

    Private Sub cbbchonsinhvien_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbchonsinhvien.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub bttmuasach_Click(sender As Object, e As EventArgs) Handles bttmuasach.Click
        ' Kiểm tra xem đã chọn sinh viên và sách chưa
        If cbbchonsinhvien.SelectedItem IsNot Nothing AndAlso CheckedListBoxchonsach.CheckedItems.Count > 0 Then
            ' Lấy mã sinh viên từ ComboBox
            Dim maSV As String = cbbchonsinhvien.SelectedValue.ToString()

            ' Mở kết nối SQL
            Using con As New SqlConnection("Data Source=HOANG20-8-24\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True")
                con.Open()

                ' Lặp qua từng sách được chọn trong CheckedListBox
                For Each item In CheckedListBoxchonsach.CheckedItems
                    Dim maSach As Integer = CType(item, DataRowView)("maSach") ' Lấy mã sách
                    Dim soLuong As Integer = CType(item, DataRowView)("soLuong") ' Lấy số lượng sách hiện có

                    ' Kiểm tra nếu còn sách để mua
                    If soLuong > 0 Then
                        ' Thực hiện mua sách
                        Dim cmdUpdate As New SqlCommand("UPDATE Sach SET soLuong = soLuong - 1 WHERE maSach = @maSach", con)
                        cmdUpdate.Parameters.AddWithValue("@maSach", maSach)
                        cmdUpdate.ExecuteNonQuery() ' Trừ số lượng sách

                        ' Thêm thông tin vào bảng lịch sử mua sách (nếu có bảng này)
                        ' Bạn có thể thêm một lệnh SQL khác để lưu lịch sử mua sách vào cơ sở dữ liệu, nếu cần
                        ' Ví dụ: INSERT INTO LichSuMua (maSV, maSach, ngayMua) VALUES (@maSV, @maSach, GETDATE())
                    Else
                        ' Hiển thị thông báo nếu sách không đủ số lượng
                        MessageBox.Show("Số lượng sách không đủ để mua.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Next

                ' Đóng kết nối
                con.Close()
            End Using

            ' Hiển thị thông báo mua sách thành công
            MessageBox.Show("Mua sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Tải lại dữ liệu DataGridView và CheckedListBox để cập nhật số lượng sách sau khi mua
            LoadDataGridView()
            LoadCheckedListBoxSach()
        Else
            ' Hiển thị thông báo nếu chưa chọn sinh viên hoặc sách
            MessageBox.Show("Vui lòng chọn sinh viên và sách để mua.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class