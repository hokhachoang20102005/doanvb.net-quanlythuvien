Imports System.Data.SqlClient

Public Class formttsinhvienmuonsach
    Private Sub formttsinhvienmuonsach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadThongTinMuonSach()
    End Sub

    ' Load data from database to DataGridView
    Private Sub LoadThongTinMuonSach()
        Dim dt As New DataTable()
        Using con As New SqlConnection("Data Source=HOANG20-8-24\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True")
            Dim cmd As New SqlCommand("SELECT SV.maSV, SV.hoTenSV, S.tenSach, S.tentacgia, CT.ngayMuon, CT.hanTra, " &
                                      "DATEDIFF(day, GETDATE(), CT.hanTra) AS SoNgayConLai, CT.maSach " &
                                      "FROM CTMuon CT " &
                                      "INNER JOIN SinhVien SV ON CT.maSV = SV.maSV " &
                                      "INNER JOIN Sach S ON CT.maSach = S.maSach", con)
            Dim adapter As New SqlDataAdapter(cmd)

            con.Open()
            adapter.Fill(dt)
            con.Close()
        End Using

        DataGridView1.DataSource = dt
        FormatDataGridView()
    End Sub

    ' Format DataGridView appearance
    Private Sub FormatDataGridView()
        With DataGridView1
            .Columns("maSV").HeaderText = "Mã SV"
            .Columns("hoTenSV").HeaderText = "Tên SV"
            .Columns("tenSach").HeaderText = "Tên Sách"
            .Columns("tentacgia").HeaderText = "Tác Giả"
            .Columns("ngayMuon").HeaderText = "Ngày Mượn"
            .Columns("hanTra").HeaderText = "Hạn Trả"
            .Columns("SoNgayConLai").HeaderText = "Số Ngày Còn Lại"

            ' Hide maSach column since it is not needed for display
            .Columns("maSach").Visible = False

            ' Format date columns
            .Columns("ngayMuon").DefaultCellStyle.Format = "dd/MM/yyyy"
            .Columns("hanTra").DefaultCellStyle.Format = "dd/MM/yyyy"

            ' Auto-size columns
            For Each col As DataGridViewColumn In .Columns
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
        End With
    End Sub

    ' Filter DataGridView based on text input
    Private Sub txttimbangtensvhoactimbangtensach_TextChanged(sender As Object, e As EventArgs) Handles txttimbangtensvhoactimbangtensach.TextChanged
        Dim searchText As String = txttimbangtensvhoactimbangtensach.Text.Trim()

        If String.IsNullOrEmpty(searchText) Then
            CType(DataGridView1.DataSource, DataTable).DefaultView.RowFilter = String.Empty
        Else
            CType(DataGridView1.DataSource, DataTable).DefaultView.RowFilter =
                String.Format("hoTenSV LIKE '%{0}%' OR tenSach LIKE '%{0}%'", searchText.Replace("'", "''"))
        End If
    End Sub

    ' Delete selected record from the database
    Private Sub bttxoatt_Click(sender As Object, e As EventArgs) Handles bttxoatt.Click
        ' Ensure a row is selected
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim maSV As String = selectedRow.Cells("maSV").Value.ToString()
            Dim maSach As Integer = CInt(selectedRow.Cells("maSach").Value)

            ' Confirm deletion with user
            Dim confirmDelete As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin mượn sách?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirmDelete = DialogResult.Yes Then
                ' Proceed with deletion
                Using con As New SqlConnection("Data Source=HOANG20-8-24\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True")
                    Dim cmd As New SqlCommand("DELETE FROM CTMuon WHERE maSV = @maSV AND maSach = @maSach", con)
                    cmd.Parameters.AddWithValue("@maSV", maSV)
                    cmd.Parameters.AddWithValue("@maSach", maSach)

                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                End Using

                ' Refresh the DataGridView to reflect the changes
                LoadThongTinMuonSach()
            End If
        Else
            MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
