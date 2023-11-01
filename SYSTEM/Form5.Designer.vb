<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TEACHERSTUDENT
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
        Dim resources As SYSTEM.ComponentModel.ComponentResourceManager = New SYSTEM.ComponentModel.ComponentResourceManager(GetType(TEACHERSTUDENT))
        Me.btnstudent = New SYSTEM.Windows.Forms.Button
        Me.btnexit = New SYSTEM.Windows.Forms.Button
        Me.btnteacher = New SYSTEM.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnstudent
        '
        Me.btnstudent.BackColor = SYSTEM.Drawing.Color.Maroon
        Me.btnstudent.Font = New SYSTEM.Drawing.Font("Showcard Gothic", 14.25!, SYSTEM.Drawing.FontStyle.Bold, SYSTEM.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstudent.ForeColor = SYSTEM.Drawing.Color.White
        Me.btnstudent.Location = New SYSTEM.Drawing.Point(278, 177)
        Me.btnstudent.Name = "btnstudent"
        Me.btnstudent.Size = New SYSTEM.Drawing.Size(230, 70)
        Me.btnstudent.TabIndex = 1
        Me.btnstudent.Text = "STUDENT"
        Me.btnstudent.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = SYSTEM.Drawing.Color.Maroon
        Me.btnexit.Font = New SYSTEM.Drawing.Font("Showcard Gothic", 14.25!, SYSTEM.Drawing.FontStyle.Bold, SYSTEM.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = SYSTEM.Drawing.Color.White
        Me.btnexit.Location = New SYSTEM.Drawing.Point(278, 270)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New SYSTEM.Drawing.Size(230, 70)
        Me.btnexit.TabIndex = 2
        Me.btnexit.Text = "BACK"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnteacher
        '
        Me.btnteacher.BackColor = SYSTEM.Drawing.Color.Maroon
        Me.btnteacher.Font = New SYSTEM.Drawing.Font("Showcard Gothic", 12.75!, SYSTEM.Drawing.FontStyle.Bold, SYSTEM.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnteacher.ForeColor = SYSTEM.Drawing.Color.White
        Me.btnteacher.Location = New SYSTEM.Drawing.Point(278, 87)
        Me.btnteacher.Name = "btnteacher"
        Me.btnteacher.Size = New SYSTEM.Drawing.Size(230, 70)
        Me.btnteacher.TabIndex = 0
        Me.btnteacher.Text = "TEACHER/ADMIN"
        Me.btnteacher.UseVisualStyleBackColor = False
        '
        'TEACHERSTUDENT
        '
        Me.AutoScaleDimensions = New SYSTEM.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = SYSTEM.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), SYSTEM.Drawing.Image)
        Me.BackgroundImageLayout = SYSTEM.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New SYSTEM.Drawing.Size(625, 415)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnstudent)
        Me.Controls.Add(Me.btnteacher)
        Me.Icon = CType(resources.GetObject("$this.Icon"), SYSTEM.Drawing.Icon)
        Me.Name = "TEACHERSTUDENT"
        Me.StartPosition = SYSTEM.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TEACHER/STUDENT"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnstudent As SYSTEM.Windows.Forms.Button
    Friend WithEvents btnexit As SYSTEM.Windows.Forms.Button
    Friend WithEvents btnteacher As SYSTEM.Windows.Forms.Button
End Class
