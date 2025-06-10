<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtstdno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbmale = New System.Windows.Forms.RadioButton()
        Me.rbfemale = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbdate = New System.Windows.Forms.TextBox()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbomunicipality = New System.Windows.Forms.ComboBox()
        Me.cboprovince = New System.Windows.Forms.ComboBox()
        Me.cbocourse = New System.Windows.Forms.ComboBox()
        Me.txtsy = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtparent = New System.Windows.Forms.TextBox()
        Me.txtpcontact = New System.Windows.Forms.TextBox()
        Me.txtsh = New System.Windows.Forms.TextBox()
        Me.txtyr = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbofilter = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.lstdetails = New System.Windows.Forms.ListView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Registration Form"
        '
        'txtstdno
        '
        Me.txtstdno.Location = New System.Drawing.Point(109, 59)
        Me.txtstdno.Name = "txtstdno"
        Me.txtstdno.Size = New System.Drawing.Size(150, 23)
        Me.txtstdno.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Student ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(284, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Last Name"
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(109, 92)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(150, 23)
        Me.txtfname.TabIndex = 5
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(370, 92)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(175, 23)
        Me.txtlname.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(568, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "M.I"
        '
        'txtmi
        '
        Me.txtmi.Location = New System.Drawing.Point(611, 93)
        Me.txtmi.Name = "txtmi"
        Me.txtmi.Size = New System.Drawing.Size(34, 23)
        Me.txtmi.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(381, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Sex"
        '
        'rbmale
        '
        Me.rbmale.AutoSize = True
        Me.rbmale.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbmale.Location = New System.Drawing.Point(424, 160)
        Me.rbmale.Name = "rbmale"
        Me.rbmale.Size = New System.Drawing.Size(51, 19)
        Me.rbmale.TabIndex = 10
        Me.rbmale.TabStop = True
        Me.rbmale.Text = "Male"
        Me.rbmale.UseVisualStyleBackColor = True
        '
        'rbfemale
        '
        Me.rbfemale.AutoSize = True
        Me.rbfemale.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbfemale.Location = New System.Drawing.Point(491, 160)
        Me.rbfemale.Name = "rbfemale"
        Me.rbfemale.Size = New System.Drawing.Size(63, 19)
        Me.rbfemale.TabIndex = 11
        Me.rbfemale.TabStop = True
        Me.rbfemale.Text = "Female"
        Me.rbfemale.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Birth Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Contact Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Student Address"
        '
        'txtbdate
        '
        Me.txtbdate.Location = New System.Drawing.Point(109, 129)
        Me.txtbdate.Name = "txtbdate"
        Me.txtbdate.Size = New System.Drawing.Size(150, 23)
        Me.txtbdate.TabIndex = 15
        '
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(142, 161)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(181, 23)
        Me.txtcontact.TabIndex = 16
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(141, 202)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(496, 23)
        Me.txtaddress.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(40, 242)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Municipality"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(78, 276)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 15)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Course"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(353, 242)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 15)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Province"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(353, 282)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 15)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "School Year"
        '
        'cbomunicipality
        '
        Me.cbomunicipality.FormattingEnabled = True
        Me.cbomunicipality.Location = New System.Drawing.Point(140, 240)
        Me.cbomunicipality.Name = "cbomunicipality"
        Me.cbomunicipality.Size = New System.Drawing.Size(182, 23)
        Me.cbomunicipality.TabIndex = 22
        '
        'cboprovince
        '
        Me.cboprovince.FormattingEnabled = True
        Me.cboprovince.Location = New System.Drawing.Point(455, 242)
        Me.cboprovince.Name = "cboprovince"
        Me.cboprovince.Size = New System.Drawing.Size(182, 23)
        Me.cboprovince.TabIndex = 23
        '
        'cbocourse
        '
        Me.cbocourse.FormattingEnabled = True
        Me.cbocourse.Location = New System.Drawing.Point(141, 276)
        Me.cbocourse.Name = "cbocourse"
        Me.cbocourse.Size = New System.Drawing.Size(182, 23)
        Me.cbocourse.TabIndex = 24
        '
        'txtsy
        '
        Me.txtsy.Location = New System.Drawing.Point(456, 279)
        Me.txtsy.Name = "txtsy"
        Me.txtsy.Size = New System.Drawing.Size(181, 23)
        Me.txtsy.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(761, 59)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(143, 19)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Guardian Information"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(688, 99)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 15)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Guardian Name"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(688, 140)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 15)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Contact Number"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(761, 231)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(147, 19)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Preliminary Education"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(681, 274)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(110, 15)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "Senior High School"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(761, 311)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 15)
        Me.Label21.TabIndex = 33
        Me.Label21.Text = "Year"
        '
        'txtparent
        '
        Me.txtparent.Location = New System.Drawing.Point(816, 96)
        Me.txtparent.Name = "txtparent"
        Me.txtparent.Size = New System.Drawing.Size(198, 23)
        Me.txtparent.TabIndex = 34
        '
        'txtpcontact
        '
        Me.txtpcontact.Location = New System.Drawing.Point(816, 137)
        Me.txtpcontact.Name = "txtpcontact"
        Me.txtpcontact.Size = New System.Drawing.Size(201, 23)
        Me.txtpcontact.TabIndex = 35
        '
        'txtsh
        '
        Me.txtsh.Location = New System.Drawing.Point(827, 271)
        Me.txtsh.Name = "txtsh"
        Me.txtsh.Size = New System.Drawing.Size(181, 23)
        Me.txtsh.TabIndex = 36
        '
        'txtyr
        '
        Me.txtyr.Location = New System.Drawing.Point(827, 308)
        Me.txtyr.Name = "txtyr"
        Me.txtyr.Size = New System.Drawing.Size(181, 23)
        Me.txtyr.TabIndex = 37
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(34, 341)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(52, 15)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Filter By:"
        '
        'cbofilter
        '
        Me.cbofilter.FormattingEnabled = True
        Me.cbofilter.Location = New System.Drawing.Point(109, 337)
        Me.cbofilter.Name = "cbofilter"
        Me.cbofilter.Size = New System.Drawing.Size(176, 23)
        Me.cbofilter.TabIndex = 40
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(306, 341)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 15)
        Me.Label23.TabIndex = 41
        Me.Label23.Text = "Type here:"
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(396, 338)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(249, 23)
        Me.txtsearch.TabIndex = 42
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnadd.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(1043, 152)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(166, 34)
        Me.btnadd.TabIndex = 43
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnupdate.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(1043, 192)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(166, 34)
        Me.btnupdate.TabIndex = 44
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btndelete.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(1043, 272)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(170, 34)
        Me.btndelete.TabIndex = 45
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnclear.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(1043, 232)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(166, 34)
        Me.btnclear.TabIndex = 46
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnexit.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(1043, 312)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(170, 34)
        Me.btnexit.TabIndex = 47
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'lstdetails
        '
        Me.lstdetails.BackColor = System.Drawing.SystemColors.Control
        Me.lstdetails.HideSelection = False
        Me.lstdetails.Location = New System.Drawing.Point(12, 393)
        Me.lstdetails.Name = "lstdetails"
        Me.lstdetails.Size = New System.Drawing.Size(1202, 246)
        Me.lstdetails.TabIndex = 48
        Me.lstdetails.UseCompatibleStateImageBehavior = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.DarkRed
        Me.Label14.Location = New System.Drawing.Point(265, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(12, 15)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.DarkRed
        Me.Label18.Location = New System.Drawing.Point(265, 96)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(12, 15)
        Me.Label18.TabIndex = 49
        Me.Label18.Text = "*"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.DarkRed
        Me.Label24.Location = New System.Drawing.Point(550, 89)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(12, 15)
        Me.Label24.TabIndex = 50
        Me.Label24.Text = "*"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.DarkRed
        Me.Label25.Location = New System.Drawing.Point(651, 92)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(12, 15)
        Me.Label25.TabIndex = 51
        Me.Label25.Text = "*"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.DarkRed
        Me.Label26.Location = New System.Drawing.Point(265, 129)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(12, 15)
        Me.Label26.TabIndex = 52
        Me.Label26.Text = "*"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.DarkRed
        Me.Label27.Location = New System.Drawing.Point(329, 160)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(12, 15)
        Me.Label27.TabIndex = 53
        Me.Label27.Text = "*"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.DarkRed
        Me.Label28.Location = New System.Drawing.Point(569, 161)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(12, 15)
        Me.Label28.TabIndex = 54
        Me.Label28.Text = "*"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.DarkRed
        Me.Label29.Location = New System.Drawing.Point(328, 239)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(12, 15)
        Me.Label29.TabIndex = 55
        Me.Label29.Text = "*"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.DarkRed
        Me.Label30.Location = New System.Drawing.Point(643, 242)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(12, 15)
        Me.Label30.TabIndex = 56
        Me.Label30.Text = "*"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.DarkRed
        Me.Label31.Location = New System.Drawing.Point(328, 276)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(12, 15)
        Me.Label31.TabIndex = 57
        Me.Label31.Text = "*"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.Color.DarkRed
        Me.Label32.Location = New System.Drawing.Point(643, 279)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(12, 15)
        Me.Label32.TabIndex = 58
        Me.Label32.Text = "*"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.DarkRed
        Me.Label33.Location = New System.Drawing.Point(643, 202)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(12, 15)
        Me.Label33.TabIndex = 59
        Me.Label33.Text = "*"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.Color.DarkRed
        Me.Label35.Location = New System.Drawing.Point(645, 333)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(0, 15)
        Me.Label35.TabIndex = 61
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1047, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 34)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "TEACHER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1043, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(166, 34)
        Me.Button2.TabIndex = 63
        Me.Button2.Text = "GRADES"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'formStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1244, 703)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lstdetails)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.cbofilter)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtyr)
        Me.Controls.Add(Me.txtsh)
        Me.Controls.Add(Me.txtpcontact)
        Me.Controls.Add(Me.txtparent)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtsy)
        Me.Controls.Add(Me.cbocourse)
        Me.Controls.Add(Me.cboprovince)
        Me.Controls.Add(Me.cbomunicipality)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.txtbdate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.rbfemale)
        Me.Controls.Add(Me.rbmale)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtmi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtstdno)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "formStudent"
        Me.Text = "v"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtstdno As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtfname As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtmi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents rbmale As RadioButton
    Friend WithEvents rbfemale As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtbdate As TextBox
    Friend WithEvents txtcontact As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cbomunicipality As ComboBox
    Friend WithEvents cboprovince As ComboBox
    Friend WithEvents cbocourse As ComboBox
    Friend WithEvents txtsy As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtparent As TextBox
    Friend WithEvents txtpcontact As TextBox
    Friend WithEvents txtsh As TextBox
    Friend WithEvents txtyr As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cbofilter As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents listdetails As ListView
    Friend WithEvents lstdetails As ListView
    Friend WithEvents Label14 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
