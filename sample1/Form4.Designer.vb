<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAdmin))
        Me.Labeldashb = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblTeacherCount = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblStudentCount = New System.Windows.Forms.Label()
        Me.btnaddstudents = New System.Windows.Forms.Button()
        Me.btnaddteachers = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Labeldashb
        '
        Me.Labeldashb.AutoSize = True
        Me.Labeldashb.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeldashb.Location = New System.Drawing.Point(53, 36)
        Me.Labeldashb.Name = "Labeldashb"
        Me.Labeldashb.Size = New System.Drawing.Size(138, 19)
        Me.Labeldashb.TabIndex = 1
        Me.Labeldashb.Text = "Dashboard Overview"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblTeacherCount)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 192)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Teachers"
        '
        'LblTeacherCount
        '
        Me.LblTeacherCount.AutoSize = True
        Me.LblTeacherCount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTeacherCount.Location = New System.Drawing.Point(214, 75)
        Me.LblTeacherCount.Name = "LblTeacherCount"
        Me.LblTeacherCount.Size = New System.Drawing.Size(53, 55)
        Me.LblTeacherCount.TabIndex = 67
        Me.LblTeacherCount.Text = "0"
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(39, 45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(119, 109)
        Me.PictureBox2.TabIndex = 66
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(38, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblStudentCount)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(415, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(332, 192)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Students"
        '
        'LblStudentCount
        '
        Me.LblStudentCount.AutoSize = True
        Me.LblStudentCount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStudentCount.Location = New System.Drawing.Point(213, 75)
        Me.LblStudentCount.Name = "LblStudentCount"
        Me.LblStudentCount.Size = New System.Drawing.Size(53, 55)
        Me.LblStudentCount.TabIndex = 68
        Me.LblStudentCount.Text = "0"
        '
        'btnaddstudents
        '
        Me.btnaddstudents.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnaddstudents.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddstudents.Location = New System.Drawing.Point(466, 332)
        Me.btnaddstudents.Name = "btnaddstudents"
        Me.btnaddstudents.Size = New System.Drawing.Size(254, 34)
        Me.btnaddstudents.TabIndex = 64
        Me.btnaddstudents.Text = "Register Students"
        Me.btnaddstudents.UseVisualStyleBackColor = False
        '
        'btnaddteachers
        '
        Me.btnaddteachers.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnaddteachers.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddteachers.Location = New System.Drawing.Point(96, 332)
        Me.btnaddteachers.Name = "btnaddteachers"
        Me.btnaddteachers.Size = New System.Drawing.Size(254, 34)
        Me.btnaddteachers.TabIndex = 65
        Me.btnaddteachers.Text = "Register Teachers"
        Me.btnaddteachers.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.IndianRed
        Me.btnexit.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(638, 36)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(109, 34)
        Me.btnexit.TabIndex = 66
        Me.btnexit.Text = "Log - out"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'formAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnaddteachers)
        Me.Controls.Add(Me.btnaddstudents)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Labeldashb)
        Me.Name = "formAdmin"
        Me.Text = "Admin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Labeldashb As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnaddstudents As Button
    Friend WithEvents btnaddteachers As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblTeacherCount As Label
    Friend WithEvents LblStudentCount As Label
    Friend WithEvents btnexit As Button
End Class
