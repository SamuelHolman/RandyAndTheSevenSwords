<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblMenu1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblMenu2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(67, 273)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(259, 72)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblMenu1
        '
        Me.lblMenu1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu1.Location = New System.Drawing.Point(12, 9)
        Me.lblMenu1.Name = "lblMenu1"
        Me.lblMenu1.Size = New System.Drawing.Size(368, 128)
        Me.lblMenu1.TabIndex = 1
        Me.lblMenu1.Text = "Randy and the Seven Swords"
        Me.lblMenu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(121, 203)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(133, 20)
        Me.txtName.TabIndex = 2
        '
        'lblMenu2
        '
        Me.lblMenu2.AutoSize = True
        Me.lblMenu2.Location = New System.Drawing.Point(137, 163)
        Me.lblMenu2.Name = "lblMenu2"
        Me.lblMenu2.Size = New System.Drawing.Size(101, 13)
        Me.lblMenu2.TabIndex = 3
        Me.lblMenu2.Text = "What is your name?"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 450)
        Me.Controls.Add(Me.lblMenu2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblMenu1)
        Me.Controls.Add(Me.btnStart)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents lblMenu1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblMenu2 As Label
End Class
