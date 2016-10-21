<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainScreen))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlStartMatchIcon = New System.Windows.Forms.Panel()
        Me.pnlViewStatsContainer = New System.Windows.Forms.Panel()
        Me.lblViewStats = New System.Windows.Forms.Label()
        Me.pnlViewStatsIcon = New System.Windows.Forms.Panel()
        Me.pnlSetupContainer = New System.Windows.Forms.Panel()
        Me.lblSetup = New System.Windows.Forms.Label()
        Me.pnlSetupIcon = New System.Windows.Forms.Panel()
        Me.pnlStartMatchContainer = New System.Windows.Forms.Panel()
        Me.lblStartMatch = New System.Windows.Forms.Label()
        Me.TrapShootingDataSet1 = New Trapshooting5000ALPHA.TrapShootingDataSet()
        Me.pnlViewStatsContainer.SuspendLayout()
        Me.pnlSetupContainer.SuspendLayout()
        Me.pnlStartMatchContainer.SuspendLayout()
        CType(Me.TrapShootingDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(12, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(51, 53)
        Me.btnExit.TabIndex = 3
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'pnlStartMatchIcon
        '
        Me.pnlStartMatchIcon.BackgroundImage = CType(resources.GetObject("pnlStartMatchIcon.BackgroundImage"), System.Drawing.Image)
        Me.pnlStartMatchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlStartMatchIcon.Location = New System.Drawing.Point(1, -1)
        Me.pnlStartMatchIcon.Name = "pnlStartMatchIcon"
        Me.pnlStartMatchIcon.Size = New System.Drawing.Size(108, 100)
        Me.pnlStartMatchIcon.TabIndex = 4
        '
        'pnlViewStatsContainer
        '
        Me.pnlViewStatsContainer.AutoSize = True
        Me.pnlViewStatsContainer.Controls.Add(Me.lblViewStats)
        Me.pnlViewStatsContainer.Controls.Add(Me.pnlViewStatsIcon)
        Me.pnlViewStatsContainer.Location = New System.Drawing.Point(384, 177)
        Me.pnlViewStatsContainer.Name = "pnlViewStatsContainer"
        Me.pnlViewStatsContainer.Size = New System.Drawing.Size(285, 103)
        Me.pnlViewStatsContainer.TabIndex = 5
        '
        'lblViewStats
        '
        Me.lblViewStats.AutoSize = True
        Me.lblViewStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewStats.Location = New System.Drawing.Point(128, 30)
        Me.lblViewStats.Name = "lblViewStats"
        Me.lblViewStats.Size = New System.Drawing.Size(143, 31)
        Me.lblViewStats.TabIndex = 6
        Me.lblViewStats.Text = "View Stats"
        '
        'pnlViewStatsIcon
        '
        Me.pnlViewStatsIcon.BackgroundImage = CType(resources.GetObject("pnlViewStatsIcon.BackgroundImage"), System.Drawing.Image)
        Me.pnlViewStatsIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlViewStatsIcon.Location = New System.Drawing.Point(1, 0)
        Me.pnlViewStatsIcon.Name = "pnlViewStatsIcon"
        Me.pnlViewStatsIcon.Size = New System.Drawing.Size(108, 100)
        Me.pnlViewStatsIcon.TabIndex = 5
        '
        'pnlSetupContainer
        '
        Me.pnlSetupContainer.AutoSize = True
        Me.pnlSetupContainer.Controls.Add(Me.lblSetup)
        Me.pnlSetupContainer.Controls.Add(Me.pnlSetupIcon)
        Me.pnlSetupContainer.Location = New System.Drawing.Point(384, 298)
        Me.pnlSetupContainer.Name = "pnlSetupContainer"
        Me.pnlSetupContainer.Size = New System.Drawing.Size(285, 100)
        Me.pnlSetupContainer.TabIndex = 5
        '
        'lblSetup
        '
        Me.lblSetup.AutoSize = True
        Me.lblSetup.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetup.Location = New System.Drawing.Point(130, 34)
        Me.lblSetup.Name = "lblSetup"
        Me.lblSetup.Size = New System.Drawing.Size(85, 31)
        Me.lblSetup.TabIndex = 7
        Me.lblSetup.Text = "Setup"
        '
        'pnlSetupIcon
        '
        Me.pnlSetupIcon.BackgroundImage = CType(resources.GetObject("pnlSetupIcon.BackgroundImage"), System.Drawing.Image)
        Me.pnlSetupIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlSetupIcon.Location = New System.Drawing.Point(9, 9)
        Me.pnlSetupIcon.Name = "pnlSetupIcon"
        Me.pnlSetupIcon.Size = New System.Drawing.Size(87, 80)
        Me.pnlSetupIcon.TabIndex = 6
        '
        'pnlStartMatchContainer
        '
        Me.pnlStartMatchContainer.AutoSize = True
        Me.pnlStartMatchContainer.Controls.Add(Me.lblStartMatch)
        Me.pnlStartMatchContainer.Controls.Add(Me.pnlStartMatchIcon)
        Me.pnlStartMatchContainer.Location = New System.Drawing.Point(384, 58)
        Me.pnlStartMatchContainer.Name = "pnlStartMatchContainer"
        Me.pnlStartMatchContainer.Size = New System.Drawing.Size(285, 102)
        Me.pnlStartMatchContainer.TabIndex = 6
        '
        'lblStartMatch
        '
        Me.lblStartMatch.AutoSize = True
        Me.lblStartMatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartMatch.Location = New System.Drawing.Point(128, 32)
        Me.lblStartMatch.Name = "lblStartMatch"
        Me.lblStartMatch.Size = New System.Drawing.Size(153, 31)
        Me.lblStartMatch.TabIndex = 5
        Me.lblStartMatch.Text = "Start Match"
        '
        'TrapShootingDataSet1
        '
        Me.TrapShootingDataSet1.DataSetName = "TrapShootingDataSet"
        Me.TrapShootingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmMainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 492)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlStartMatchContainer)
        Me.Controls.Add(Me.pnlSetupContainer)
        Me.Controls.Add(Me.pnlViewStatsContainer)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmMainScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlViewStatsContainer.ResumeLayout(False)
        Me.pnlViewStatsContainer.PerformLayout()
        Me.pnlSetupContainer.ResumeLayout(False)
        Me.pnlSetupContainer.PerformLayout()
        Me.pnlStartMatchContainer.ResumeLayout(False)
        Me.pnlStartMatchContainer.PerformLayout()
        CType(Me.TrapShootingDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents pnlStartMatchIcon As System.Windows.Forms.Panel
    Friend WithEvents pnlViewStatsContainer As System.Windows.Forms.Panel
    Friend WithEvents pnlSetupContainer As System.Windows.Forms.Panel
    Friend WithEvents pnlStartMatchContainer As System.Windows.Forms.Panel
    Friend WithEvents lblStartMatch As System.Windows.Forms.Label
    Friend WithEvents lblViewStats As System.Windows.Forms.Label
    Friend WithEvents pnlViewStatsIcon As System.Windows.Forms.Panel
    Friend WithEvents lblSetup As System.Windows.Forms.Label
    Friend WithEvents pnlSetupIcon As System.Windows.Forms.Panel
    Friend WithEvents TrapShootingDataSet1 As Trapshooting5000ALPHA.TrapShootingDataSet

End Class
