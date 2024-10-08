Imports System.Data.SqlClient

Public Class formttsach
    Private connectionString As String = "Data Source=HOANG20-8-24\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True"
    Private selectedMaSach As Integer = -1

    Private Sub formttsach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBooks()
    End Sub

    Private Sub LoadBooks()
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim cmd As New SqlCommand("SELECT * FROM Sach", con)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt

            ' Đặt tên cột cho DataGridView
            DataGridView1.Columns("maSach").HeaderText = "Mã Sách"
            DataGridView1.Columns("tenSach").HeaderText = "Tên Sách"
            DataGridView1.Columns("tentacgia").HeaderText = "Tên Tác Giả"
            DataGridView1.Columns("gia").HeaderText = "Giá"
            DataGridView1.Columns("soLuong").HeaderText = "Số Lượng"
            DataGridView1.Columns("ngayNhap").HeaderText = "Ngày Nhập"
            DataGridView1.Columns("maNXB").HeaderText = "Mã NXB"
        End Using
    End Sub

    Private Sub btthem_Click(sender As Object, e As EventArgs) Handles btthem.Click
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim cmd As New SqlCommand("INSERT INTO Sach (tenSach, tentacgia, gia, soLuong, ngayNhap, maNXB) VALUES (@tenSach, @tentacgia, @gia, @soLuong, @ngayNhap, @maNXB)", con)
            cmd.Parameters.AddWithValue("@tenSach", txttensach.Text)
            cmd.Parameters.AddWithValue("@tentacgia", txttacgia.Text)
            cmd.Parameters.AddWithValue("@gia", Convert.ToInt32(txtgiatien.Text))
            cmd.Parameters.AddWithValue("@soLuong", Convert.ToInt32(txtsoluong.Text))
            cmd.Parameters.AddWithValue("@ngayNhap", DateTime.Now) ' Hoặc thay bằng giá trị ngày nhập từ một TextBox
            cmd.Parameters.AddWithValue("@maNXB", Convert.ToInt32(txtmanxb.Text))
            cmd.ExecuteNonQuery()
            MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadBooks()
            ClearFields()
        End Using
    End Sub

    Private Sub bttsua_Click(sender As Object, e As EventArgs) Handles bttsua.Click
        If selectedMaSach <> -1 Then
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim cmd As New SqlCommand("UPDATE Sach SET tenSach = @tenSach, tentacgia = @tentacgia, gia = @gia, soLuong = @soLuong, maNXB = @maNXB WHERE maSach = @maSach", con)
                cmd.Parameters.AddWithValue("@tenSach", txttensach.Text)
                cmd.Parameters.AddWithValue("@tentacgia", txttacgia.Text)
                cmd.Parameters.AddWithValue("@gia", Convert.ToInt32(txtgiatien.Text))
                cmd.Parameters.AddWithValue("@soLuong", Convert.ToInt32(txtsoluong.Text))
                cmd.Parameters.AddWithValue("@maNXB", Convert.ToInt32(txtmanxb.Text))
                cmd.Parameters.AddWithValue("@maSach", selectedMaSach)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Cập nhật sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadBooks()
                ClearFields()
            End Using
        Else
            MessageBox.Show("Vui lòng chọn một cuốn sách để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub bttxoa_Click(sender As Object, e As EventArgs) Handles bttxoa.Click
        If selectedMaSach <> -1 Then
            Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa cuốn sách này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Using con As New SqlConnection(connectionString)
                    con.Open()
                    Dim cmd As New SqlCommand("DELETE FROM Sach WHERE maSach = @maSach", con)
                    cmd.Parameters.AddWithValue("@maSach", selectedMaSach)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadBooks()
                    ClearFields()
                End Using
            End If
        Else
            MessageBox.Show("Vui lòng chọn một cuốn sách để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txttimkiemtheoten_TextChanged(sender As Object, e As EventArgs) Handles txttimkiemtheoten.TextChanged
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim cmd As New SqlCommand("SELECT * FROM Sach WHERE tenSach LIKE @search", con)
            cmd.Parameters.AddWithValue("@search", "%" & txttimkiemtheoten.Text & "%")
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
        End Using
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            selectedMaSach = Convert.ToInt32(row.Cells("maSach").Value)
            txttensach.Text = row.Cells("tenSach").Value.ToString()
            txttacgia.Text = row.Cells("tentacgia").Value.ToString()
            txtgiatien.Text = row.Cells("gia").Value.ToString()
            txtsoluong.Text = row.Cells("soLuong").Value.ToString()
            txtmanxb.Text = row.Cells("maNXB").Value.ToString()
        End If
    End Sub

    Private Sub ClearFields()
        selectedMaSach = -1
        txttensach.Clear()
        txttacgia.Clear()
        txtgiatien.Clear()
        txtsoluong.Clear()
        txtmanxb.Clear()
    End Sub

    Private Sub txttensach_TextChanged(sender As Object, e As EventArgs) Handles txttensach.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
