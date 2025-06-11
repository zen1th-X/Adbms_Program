Public Class formAdmin
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateCounts()
    End Sub

    Private Sub Labeldashb_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Labeldashb_Click_1(sender As Object, e As EventArgs) Handles Labeldashb.Click

    End Sub

    Private Sub LblTeacherCount_Click(sender As Object, e As EventArgs) Handles LblTeacherCount.Click

    End Sub

    Private Sub LblStudentCount_Click(sender As Object, e As EventArgs) Handles LblStudentCount.Click

    End Sub
    Private Sub UpdateCounts()
        Try
            con() ' Connect to the database

            ' Count students
            rs = New ADODB.Recordset
            rs.Open("SELECT COUNT(*) FROM std_registrations", cn)
            If Not rs.EOF Then
                LblStudentCount.Text = rs.Fields(0).Value.ToString()
            End If
            rs.Close()

            ' Count teachers
            rs = New ADODB.Recordset
            rs.Open("SELECT COUNT(*) FROM tbl_accounts", cn)
            If Not rs.EOF Then
                LblTeacherCount.Text = rs.Fields(0).Value.ToString()
            End If
            rs.Close()

        Catch ex As Exception
            MsgBox("Error while counting records: " & ex.Message)
        End Try
    End Sub

    Private Sub btnaddteachers_Click(sender As Object, e As EventArgs) Handles btnaddteachers.Click
        frmAccount.Show()
        Me.Hide()
    End Sub

    Private Sub btnaddstudents_Click(sender As Object, e As EventArgs) Handles btnaddstudents.Click
        formStudent.Show()
        Me.Hide()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        frmLogin.Show()
        Me.Hide()
    End Sub
End Class