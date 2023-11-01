<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class STUDENT
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
        Dim resources As SYSTEM.ComponentModel.ComponentResourceManager = New SYSTEM.ComponentModel.ComponentResourceManager(GetType(STUDENT))
        Me.Button3 = New SYSTEM.Windows.Forms.Button
        Me.Button1 = New SYSTEM.Windows.Forms.Button
        Me.Button2 = New SYSTEM.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = SYSTEM.Drawing.Color.Maroon
        Me.Button3.Font = New SYSTEM.Drawing.Font("Showcard Gothic", 11.25!, SYSTEM.Drawing.FontStyle.Bold, SYSTEM.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = SYSTEM.Drawing.Color.White
        Me.Button3.Location = New SYSTEM.Drawing.Point(85, 197)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New SYSTEM.Drawing.Size(140, 61)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "BACK"
        Me.Button3.UseCompatibleTextRendering = True
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = SYSTEM.Drawing.Color.Maroon
        Me.Button1.Font = New SYSTEM.Drawing.Font("Showcard Gothic", 11.25!, SYSTEM.Drawing.FontStyle.Bold, SYSTEM.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = SYSTEM.Drawing.Color.White
        Me.Button1.Location = New SYSTEM.Drawing.Point(63, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New SYSTEM.Drawing.Size(186, 44)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "SEARCH"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = SYSTEM.Drawing.Color.Maroon
        Me.Button2.Font = New SYSTEM.Drawing.Font("Showcard Gothic", 11.25!, SYSTEM.Drawing.FontStyle.Bold, SYSTEM.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = SYSTEM.Drawing.Color.White
        Me.Button2.Location = New SYSTEM.Drawing.Point(63, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New SYSTEM.Drawing.Size(186, 44)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "ADD RESEARCH"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'STUDENT
        '
        Me.AutoScaleDimensions = New SYSTEM.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = SYSTEM.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), SYSTEM.Drawing.Image)
        Me.BackgroundImageLayout = SYSTEM.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New SYSTEM.Drawing.Size(312, 319)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), SYSTEM.Drawing.Icon)
        Me.Name = "STUDENT"
        Me.StartPosition = SYSTEM.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STUDENT"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As SYSTEM.Windows.Forms.Button
    Friend WithEvents Button2 As SYSTEM.Windows.Forms.Button
End Class
