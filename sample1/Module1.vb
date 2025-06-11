' Module1.vb
Module Module1
    Public cn As New ADODB.Connection
    Public rs As New ADODB.Recordset

    Sub con()
        If cn.State = 1 Then cn.Close()
        cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Downloadss\PROGRAM_UPLOADING_GRADES\sample1\bin\Debug\dbsample.mdb;"
        cn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        cn.Open()
    End Sub

    Sub Main()

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' Replace formLogin with your real form name
        Application.Run(frmLogin)
    End Sub
End Module
