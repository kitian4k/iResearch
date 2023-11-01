<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Dim resources As SYSTEM.ComponentModel.ComponentResourceManager = New SYSTEM.ComponentModel.ComponentResourceManager(GetType(LOGIN))
        Me.btnexit = New SYSTEM.Windows.Forms.Button
        Me.TextBox1 = New SYSTEM.Windows.Forms.TextBox
        Me.Button1 = New SYSTEM.Windows.Forms.Button
        Me.TextBox2 = New SYSTEM.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnexit
        '
        Me.btnexit.BackColor = SYSTEM.Drawing.Color.Maroon
        Me.btnexit.Font = New SYSTEM.Drawing.Font("Showcard Gothic", 18.0!, SYSTEM.Drawing.FontStyle.Bold, SYSTEM.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = SYSTEM.Drawing.SystemColors.Control
        Me.btnexit.Location = New SYSTEM.Drawing.Point(356, 338)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New SYSTEM.Drawing.Size(163, 58)
        Me.btnexit.TabIndex = 24
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New SYSTEM.Drawing.Point(368, 173)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New SYSTEM.Drawing.Size(177, 20)
        Me.TextBox1.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.BackColor = SYSTEM.Drawing.Color.Maroon
        Me.Button1.Font = New SYSTEM.Drawing.Font("Showcard Gothic", 18.0!, SYSTEM.Drawing.FontStyle.Bold, SYSTEM.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = SYSTEM.Drawing.SystemColors.Control
        Me.Button1.Location = New SYSTEM.Drawing.Point(177, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New SYSTEM.Drawing.Size(163, 58)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Log In"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New SYSTEM.Drawing.Point(368, 255)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New SYSTEM.Drawing.Size(177, 20)
        Me.TextBox2.TabIndex = 23
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New SYSTEM.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = SYSTEM.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), SYSTEM.Drawing.Image)
        Me.BackgroundImageLayout = SYSTEM.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New SYSTEM.Drawing.Size(690, 478)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), SYSTEM.Drawing.Icon)
        Me.Name = "LOGIN"
        Me.StartPosition = SYSTEM.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnexit As SYSTEM.Windows.Forms.Button
    Friend WithEvents TextBox1 As SYSTEM.Windows.Forms.TextBox
    Friend WithEvents Button1 As SYSTEM.Windows.Forms.Button
    Friend WithEvents TextBox2 As SYSTEM.Windows.Forms.TextBox
End Class
