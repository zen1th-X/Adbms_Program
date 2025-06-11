Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call con()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub chkshow_CheckedChanged(sender As Object, e As EventArgs) Handles chkshow.CheckedChanged
        If chkshow.Checked = True Then
            txtpassword.PasswordChar = ""
        Else
            txtpassword.PasswordChar = "$"
        End If
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        ' Input validation
        If txtusername.Text = "" Then
            MsgBox("Enter username", vbInformation, "Missing")
            txtusername.Focus()
            Exit Sub
        ElseIf txtpassword.Text = "" Then
            MsgBox("Enter password", vbInformation, "Missing")
            txtpassword.Focus()
            Exit Sub
        End If

        ' Admin login (hardcoded)
        If txtusername.Text = "admin" And txtpassword.Text = "admin" Then
            formAdmin.Show()
            Me.Hide()
            Exit Sub
        End If

        ' Database login
        rs = New ADODB.Recordset
        If cn.State = 1 Then cn.Close()
        cn.Open() ' ensure the connection is open

        rs.Open("SELECT * FROM tbl_accounts WHERE ACC_UNAME='" & txtusername.Text & "' AND ACC_PWORD='" & txtpassword.Text & "'", cn, 1, 2)

        If rs.EOF Then
            MsgBox("Log in Failed", vbInformation, "Failed")
            rs.Close()
            cn.Close()
            Exit Sub
        Else
            MsgBox("Log in Successful", vbInformation, "Success")
            rs.Close()
            cn.Close()
            frmgrades.Show()
            Me.Hide()
        End If
    End Sub

End Class