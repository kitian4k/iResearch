<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WELCOME
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
        Dim resources As SYSTEM.ComponentModel.ComponentResourceManager = New SYSTEM.ComponentModel.ComponentResourceManager(GetType(WELCOME))
        Me.btnwel = New SYSTEM.Windows.Forms.Button
        Me.btnexit = New SYSTEM.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnwel
        '
        Me.btnwel.BackColor = SYSTEM.Drawing.Color.Maroon
        Me.btnwel.Font = New SYSTEM.Drawing.Font("Showcard Gothic", 18.0!, SYSTEM.Drawing.FontStyle.Bold, SYSTEM.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnwel.ForeColor = SYSTEM.Drawing.Color.White
        Me.btnwel.Location = New SYSTEM.Drawing.Point(254, 281)
        Me.btnwel.Name = "btnwel"
        Me.btnwel.Size = New SYSTEM.Drawing.Size(234, 60)
        Me.btnwel.TabIndex = 0
        Me.btnwel.Text = "Welcome"
        Me.btnwel.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = SYSTEM.Drawing.Color.Maroon
        Me.btnexit.Font = New SYSTEM.Drawing.Font("Showcard Gothic", 18.0!, SYSTEM.Drawing.FontStyle.Bold, SYSTEM.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = SYSTEM.Drawing.Color.White
        Me.btnexit.Location = New SYSTEM.Drawing.Point(254, 347)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New SYSTEM.Drawing.Size(234, 60)
        Me.btnexit.TabIndex = 1
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'WELCOME
        '
        Me.AutoScaleDimensions = New SYSTEM.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = SYSTEM.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = SYSTEM.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), SYSTEM.Drawing.Image)
        Me.BackgroundImageLayout = SYSTEM.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New SYSTEM.Drawing.Size(726, 457)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnwel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), SYSTEM.Drawing.Icon)
        Me.Name = "WELCOME"
        Me.StartPosition = SYSTEM.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WELCOME"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnexit As SYSTEM.Windows.Forms.Button
    Friend WithEvents btnwel As SYSTEM.Windows.Forms.Button
End Class
