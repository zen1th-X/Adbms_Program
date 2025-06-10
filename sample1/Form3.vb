﻿Imports Microsoft.Office.Interop
Imports System.Data.OleDb

Public Class frmgrades
    Dim xlapp As New Excel.Application
    Dim wkb As Excel.Workbook
    Dim wks As Excel.Worksheet
    Dim cnAccess As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dbsample.mdb;")

    Private Sub frmgrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call con()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        ' Validation block - check for empty fields
        If String.IsNullOrWhiteSpace(txtgradeid.Text) OrElse
       String.IsNullOrWhiteSpace(txtname.Text) OrElse
       String.IsNullOrWhiteSpace(txtgpa.Text) OrElse
       String.IsNullOrWhiteSpace(txtstudid.Text) OrElse
       String.IsNullOrWhiteSpace(txtsy.Text) OrElse
       String.IsNullOrWhiteSpace(cbocourse.Text) OrElse
       String.IsNullOrWhiteSpace(txtcode.Text) OrElse
       String.IsNullOrWhiteSpace(txttitle.Text) OrElse
       String.IsNullOrWhiteSpace(cbosem.Text) OrElse
       String.IsNullOrWhiteSpace(txtsection.Text) OrElse
       String.IsNullOrWhiteSpace(txtinstructor.Text) Then

            MsgBox("Please complete all the fields before saving.", vbExclamation, "Incomplete Data")
            Exit Sub
        End If

        ' Check if record already exists
        rs = New ADODB.Recordset
        With rs
            If .State = 1 Then .Close()
            .Open("Select * from tbl_grades where STUD_ID='" + txtstudid.Text + "' and CODE='" + txtcode.Text + "' and SY='" + txtsy.Text + "' and SEM='" + cbosem.Text + "'", cn, 1, 2)

            If .EOF = False Then
                MsgBox("Student grade was already recorded", vbInformation, "Exist")
                Exit Sub
            End If

            ' Proceed with saving since all fields are filled and not duplicate
            .AddNew()
            .Fields("GRADE_ID").Value = txtgradeid.Text
            .Fields("NAME").Value = txtname.Text
            .Fields("GPA").Value = txtgpa.Text
            .Fields("STUD_ID").Value = txtstudid.Text
            .Fields("SY").Value = txtsy.Text
            .Fields("COURSE").Value = cbocourse.Text
            .Fields("CODE").Value = txtcode.Text
            .Fields("TITLE").Value = txttitle.Text
            .Fields("SEM").Value = cbosem.Text
            .Fields("SECTION").Value = txtsection.Text
            .Fields("INSTRUCTOR").Value = txtinstructor.Text
            .Update()
            MsgBox("Student grade was recorded", vbInformation, "Recorded")
            .Close()
        End With
    End Sub

    Private Sub btnupload_Click(sender As Object, e As EventArgs) Handles btnupload.Click
        Dim strfilename As String
        Dim shtname As String = "GRADES"

        With openfile
            .FileName = ""
            .Title = "Select an excel file"
            .Filter = "Excel Office| *.xls;*.xlsx"
            .ShowDialog()
            strfilename = .FileName
        End With

        If String.IsNullOrEmpty(strfilename) Then Exit Sub

        xlapp = New Excel.Application
        wkb = xlapp.Workbooks.Open(strfilename)
        wks = wkb.Worksheets(shtname)

        txtsy.Text = wks.Cells(1, 2).Value
        cbocourse.Text = wks.Cells(2, 2).Value
        txtsection.Text = wks.Cells(3, 2).Value
        txtcode.Text = wks.Cells(4, 2).Value
        txttitle.Text = wks.Cells(5, 2).Value
        cbosem.Text = wks.Cells(6, 2).Value
        txtinstructor.Text = wks.Cells(1, 4).Value

        With rs
            If .State <> 0 Then .Close()
            .Open("Select * from tbl_grades where COURSE='" + cbocourse.Text + "' and CODE='" + txtcode.Text + "' and SY='" + txtsy.Text + "' and SEM='" + cbosem.Text + "'", cn, 1, 2)
            If .EOF = False Then
                MsgBox("Grades was already uploaded", vbInformation, "Exist")
                Exit Sub
            End If

            Dim row As Integer = 9
            While wks.Cells(row, 1).Value <> ""
                .AddNew()
                .Fields("STUD_ID").Value = wks.Cells(row, 1).Value
                .Fields("NAME").Value = wks.Cells(row, 2).Value
                .Fields("GPA").Value = wks.Cells(row, 3).Value
                .Fields("GRADE_ID").Value = txtgradeid.Text
                .Fields("SY").Value = txtsy.Text
                .Fields("SEM").Value = cbosem.Text
                .Fields("SECTION").Value = txtsection.Text
                .Fields("COURSE").Value = cbocourse.Text
                .Fields("INSTRUCTOR").Value = txtinstructor.Text
                .Fields("CODE").Value = txtcode.Text
                .Fields("TITLE").Value = txttitle.Text
                row += 1
            End While
            .Update()
            MsgBox("Grades was successfully uploaded", vbInformation, "Upload")
            .Close()
        End With

        wkb.Close(SaveChanges:=False)
        xlapp.Quit()
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Try
            If cnAccess.State = ConnectionState.Open Then cnAccess.Close()
            cnAccess.Open()

            Dim query As String = "SELECT * FROM tbl_grades WHERE 1=1"
            Dim cmd As New OleDbCommand()
            cmd.Connection = cnAccess

            If Not String.IsNullOrWhiteSpace(txtsy.Text) Then
                query &= " AND SY = ?"
                cmd.Parameters.AddWithValue("@SY", txtsy.Text.Trim())
            End If
            If Not String.IsNullOrWhiteSpace(cbocourse.Text) Then
                query &= " AND COURSE = ?"
                cmd.Parameters.AddWithValue("@COURSE", cbocourse.Text.Trim())
            End If
            ' FIXED: Escaped SECTION keyword
            If txtsection.Text.Trim() <> "" Then
                query &= " AND [SECTION] = ?"
                cmd.Parameters.AddWithValue("@SECTION", txtsection.Text.Trim())
            End If
            If Not String.IsNullOrWhiteSpace(txtcode.Text) Then
                query &= " AND CODE = ?"
                cmd.Parameters.AddWithValue("@CODE", txtcode.Text.Trim())
            End If
            If Not String.IsNullOrWhiteSpace(txttitle.Text) Then
                query &= " AND TITLE = ?"
                cmd.Parameters.AddWithValue("@TITLE", txttitle.Text.Trim())
            End If
            If Not String.IsNullOrWhiteSpace(cbosem.Text) Then
                query &= " AND SEM = ?"
                cmd.Parameters.AddWithValue("@SEM", cbosem.Text.Trim())
            End If
            If Not String.IsNullOrWhiteSpace(txtinstructor.Text) Then
                query &= " AND INSTRUCTOR = ?"
                cmd.Parameters.AddWithValue("@INSTRUCTOR", txtinstructor.Text.Trim())
            End If

            cmd.CommandText = query

            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            cnAccess.Close()

            If dt.Rows.Count = 0 Then
                MsgBox("No matching records found.", MsgBoxStyle.Information, "Print")
                Return
            End If

            Dim templatePath As String = Application.StartupPath & "\report_grades.xlsx"

            If IO.File.Exists(templatePath) Then
                wkb = xlapp.Workbooks.Open(templatePath)
                wks = CType(wkb.Sheets(1), Excel.Worksheet)
            Else
                wkb = xlapp.Workbooks.Add()
                wks = CType(wkb.Sheets(1), Excel.Worksheet)
                wks.Name = "Grades"
                wks.Cells(8, 1) = "Student ID"
                wks.Cells(8, 2) = "Name"
                wks.Cells(8, 3) = "GPA"
                wks.Cells(8, 4) = "Remarks"
            End If

            ' SY
            wks.Cells(1, 1).Value = "SY: " & txtsy.Text

            ' COURSE
            wks.Cells(2, 1).Value = "COURSE: " & cbocourse.Text

            ' SECTION
            wks.Cells(3, 1).Value = "SECTION: " & txtsection.Text

            ' CODE
            wks.Cells(4, 1).Value = "CODE: " & txtcode.Text

            ' TITLE
            wks.Cells(5, 1).Value = "TITLE: " & txttitle.Text

            ' SEMESTER
            wks.Cells(6, 1).Value = "SEMESTER: " & cbosem.Text

            ' INSTRUCTOR
            wks.Cells(7, 1).Value = "INSTRUCTOR: " & txtinstructor.Text

            Dim rowIndex As Integer = 9
            For Each row As DataRow In dt.Rows
                Dim gpa As Double = Val(row("GPA").ToString())
                Dim remarks As String = If(gpa > 3.0, "FAILED", "PASSED")

                wks.Cells(rowIndex, 1) = row("STUD_ID").ToString()
                wks.Cells(rowIndex, 2) = row("NAME").ToString()
                wks.Cells(rowIndex, 3) = gpa.ToString("0.00")
                wks.Cells(rowIndex, 4) = remarks
                rowIndex += 1
            Next

            ' Place additional info on worksheet
            wks.Cells(64, 1) = txtinstructor.Text
            wks.Cells(65, 1) = cbocourse.Text & " - " & txtsection.Text

            xlapp.Visible = True
            wks.PrintPreview()

            wkb.Close(SaveChanges:=False)
            xlapp.Quit()

        Catch ex As OleDbException
            MsgBox("Database Error: " & ex.Message, MsgBoxStyle.Critical, "Print Error")
        Catch ex As Exception
            MsgBox("Unexpected Error: " & ex.Message, MsgBoxStyle.Critical, "Print Error")
        Finally
            Try
                xlapp.Quit()
            Catch
            End Try
        End Try
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class
