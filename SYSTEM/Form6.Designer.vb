<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TEACHER
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
        Dim resources As SYSTEM.ComponentModel.ComponentResourceManager = New SYSTEM.ComponentModel.ComponentResourceManager(GetType(TEACHER))
        Me.Button1 = New SYSTEM.Windows.Forms.Button
        Me.Button3 = New SYSTEM.Windows.Forms.Button
        Me.btngoogled = New SYSTEM.Windows.Forms.Button
        Me.Button2 = New SYSTEM.Windows.Forms.Button
        Me.Button4 = New SYSTEM.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = SYSTEM.Drawing.Color.Maroon
        Me.Button1.Font = New SYSTEM.Drawing.Font("Showcard Gothic", 9.75!, SYSTEM.Drawing.FontStyle.Bold, SYSTEM.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = SYSTEM.Drawing.Color.White
        Me.Button1.Location = New SYSTEM.Drawing.Point(196, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New SYSTEM.Drawing.Size(165, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ADD NEW RESEARCH"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = SYSTEM.Drawing.Color.Maroon
        Me.Button3.Font = New SYSTEM.Drawing.Font("Showcard Gothic", 9.75!, SYSTEM.Drawing.FontStyle.Bold, SYSTEM.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = SYSTEM.Drawing.Color.White
        Me.Button3.Location = New SYSTEM.Drawing.Point(196, 322)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New SYSTEM.Drawing.Size(165, 46)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "BACK"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btngoogled
        '
        Me.btngoogled.BackColor = SYSTEM.Drawing.Color.Maroon
        Me.btngoogled.Font = New SYSTEM.Drawing.Font("Showcard Gothic", 9.75!, SYSTEM.Drawing.FontStyle.Bold, SYSTEM.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngoogled.ForeColor = SYSTEM.Drawing.Color.White
        Me.btngoogled.Location = New SYSTEM.Drawing.Point(196, 250)
        Me.btngoogled.Name = "btngoogled"
        Me.btngoogled.Size = New SYSTEM.Drawing.Size(165, 46)
        Me.btngoogled.TabIndex = 3
        Me.btngoogled.Text = "GOOGLE DRIVE"
        Me.btngoogled.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = SYSTEM.Drawing.Color.Maroon
        Me.Button2.Font = New SYSTEM.Drawing.Font("Showcard Gothic", 9.75!, SYSTEM.Drawing.FontStyle.Bold, SYSTEM.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = SYSTEM.Drawing.Color.White
        Me.Button2.Location = New SYSTEM.Drawing.Point(196, 179)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New SYSTEM.Drawing.Size(165, 46)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "RESEARCHS"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = SYSTEM.Drawing.Color.Maroon
        Me.Button4.Font = New SYSTEM.Drawing.Font("Showcard Gothic", 9.75!, SYSTEM.Drawing.FontStyle.Bold, SYSTEM.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = SYSTEM.Drawing.Color.White
        Me.Button4.Location = New SYSTEM.Drawing.Point(196, 115)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New SYSTEM.Drawing.Size(165, 46)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "FOR APPROVAL"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TEACHER
        '
        Me.AutoScaleDimensions = New SYSTEM.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = SYSTEM.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), SYSTEM.Drawing.Image)
        Me.BackgroundImageLayout = SYSTEM.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New SYSTEM.Drawing.Size(438, 409)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btngoogled)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), SYSTEM.Drawing.Icon)
        Me.Name = "TEACHER"
        Me.StartPosition = SYSTEM.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TEACHER"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As SYSTEM.Windows.Forms.Button
    Friend WithEvents Button3 As SYSTEM.Windows.Forms.Button
    Friend WithEvents btngoogled As SYSTEM.Windows.Forms.Button
    Friend WithEvents Button2 As SYSTEM.Windows.Forms.Button
    Friend WithEvents Button4 As SYSTEM.Windows.Forms.Button
End Class
