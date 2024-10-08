Public Class formchinh
    Private Sub formchinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Data Source=HOANG20-8-24\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True;Trust Server Certificate=True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formsinhvien.Show()


    End Sub

    Private Sub bttttsasch_Click(sender As Object, e As EventArgs) Handles bttttsasch.Click
        formttsach.Show()

    End Sub

    Private Sub bttsach_Click(sender As Object, e As EventArgs) Handles bttsach.Click
        muamuonsach.Show()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        formttsinhvienmuonsach.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End

    End Sub
End Class