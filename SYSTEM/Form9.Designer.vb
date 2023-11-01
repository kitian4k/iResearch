<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Googledrive
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
        Dim resources As SYSTEM.ComponentModel.ComponentResourceManager = New SYSTEM.ComponentModel.ComponentResourceManager(GetType(Googledrive))
        Me.WebBrowser1 = New SYSTEM.Windows.Forms.WebBrowser
        Me.Button1 = New SYSTEM.Windows.Forms.Button
        Me.Button2 = New SYSTEM.Windows.Forms.Button
        Me.Button3 = New SYSTEM.Windows.Forms.Button
        Me.Button4 = New SYSTEM.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = SYSTEM.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New SYSTEM.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New SYSTEM.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New SYSTEM.Drawing.Size(901, 581)
        Me.WebBrowser1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New SYSTEM.Drawing.Font("Showcard Gothic", 12.0!, SYSTEM.Drawing.FontStyle.Regular, SYSTEM.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New SYSTEM.Drawing.Point(762, 536)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New SYSTEM.Drawing.Size(107, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "REFRESH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New SYSTEM.Drawing.Font("Showcard Gothic", 14.25!, SYSTEM.Drawing.FontStyle.Bold, SYSTEM.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New SYSTEM.Drawing.Point(672, 536)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New SYSTEM.Drawing.Size(39, 33)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New SYSTEM.Drawing.Font("Showcard Gothic", 14.25!, SYSTEM.Drawing.FontStyle.Bold, SYSTEM.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New SYSTEM.Drawing.Point(717, 536)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New SYSTEM.Drawing.Size(39, 33)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = ">"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New SYSTEM.Drawing.Font("Showcard Gothic", 12.0!, SYSTEM.Drawing.FontStyle.Regular, SYSTEM.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New SYSTEM.Drawing.Point(562, 536)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New SYSTEM.Drawing.Size(104, 33)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "HOME"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Googledrive
        '
        Me.AutoScaleDimensions = New SYSTEM.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = SYSTEM.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New SYSTEM.Drawing.Size(901, 581)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), SYSTEM.Drawing.Icon)
        Me.Name = "Googledrive"
        Me.StartPosition = SYSTEM.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Google Drive"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebBrowser1 As SYSTEM.Windows.Forms.WebBrowser
    Friend WithEvents Button1 As SYSTEM.Windows.Forms.Button
    Friend WithEvents Button2 As SYSTEM.Windows.Forms.Button
    Friend WithEvents Button3 As SYSTEM.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
