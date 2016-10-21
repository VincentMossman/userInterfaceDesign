<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectSquadShooters
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
        Me.listShooters = New System.Windows.Forms.ListBox()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblSelectShooter = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'listShooters
        '
        Me.listShooters.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listShooters.FormattingEnabled = True
        Me.listShooters.ItemHeight = 24
        Me.listShooters.Location = New System.Drawing.Point(3, 46)
        Me.listShooters.Name = "listShooters"
        Me.listShooters.Size = New System.Drawing.Size(235, 340)
        Me.listShooters.TabIndex = 30
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlTitle.Controls.Add(Me.lblSelectShooter)
        Me.pnlTitle.Controls.Add(Me.btnBack)
        Me.pnlTitle.Location = New System.Drawing.Point(3, 1)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(235, 42)
        Me.pnlTitle.TabIndex = 59
        '
        'lblSelectShooter
        '
        Me.lblSelectShooter.AutoSize = True
        Me.lblSelectShooter.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSelectShooter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectShooter.Location = New System.Drawing.Point(68, 9)
        Me.lblSelectShooter.Name = "lblSelectShooter"
        Me.lblSelectShooter.Size = New System.Drawing.Size(133, 24)
        Me.lblSelectShooter.TabIndex = 30
        Me.lblSelectShooter.Text = "Select Shooter"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(9, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(35, 36)
        Me.btnBack.TabIndex = 30
        Me.btnBack.Text = "<"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmSelectSquadShooters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 389)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlTitle)
        Me.Controls.Add(Me.listShooters)
        Me.Name = "frmSelectSquadShooters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listShooters As System.Windows.Forms.ListBox
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblSelectShooter As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
