<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewStats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewStats))
        Me.pnlFiltersContainer = New System.Windows.Forms.Panel()
        Me.pnlHitIcon = New System.Windows.Forms.Panel()
        Me.pnlDirectionIcon = New System.Windows.Forms.Panel()
        Me.pnlTimeDateIcon = New System.Windows.Forms.Panel()
        Me.pnlEventIcon = New System.Windows.Forms.Panel()
        Me.pnlPositionIcon = New System.Windows.Forms.Panel()
        Me.pnlShooterIcon = New System.Windows.Forms.Panel()
        Me.pnlSquadIcon = New System.Windows.Forms.Panel()
        Me.lblFilters = New System.Windows.Forms.Label()
        Me.btnHitFilter = New System.Windows.Forms.Button()
        Me.btnDirectionFilter = New System.Windows.Forms.Button()
        Me.btnTimeDateFilter = New System.Windows.Forms.Button()
        Me.btnEventFilter = New System.Windows.Forms.Button()
        Me.btnPositionFilter = New System.Windows.Forms.Button()
        Me.btnShooterFilter = New System.Windows.Forms.Button()
        Me.btnSquadFilter = New System.Windows.Forms.Button()
        Me.pnlStats = New System.Windows.Forms.Panel()
        Me.dataStats = New System.Windows.Forms.DataGridView()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblViewStats = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlExportIcon = New System.Windows.Forms.Panel()
        Me.pnlExportContainer = New System.Windows.Forms.Panel()
        Me.lblExport = New System.Windows.Forms.Label()
        Me.Squad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Shooter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Position = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlFiltersContainer.SuspendLayout()
        Me.pnlStats.SuspendLayout()
        CType(Me.dataStats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitle.SuspendLayout()
        Me.pnlExportContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlFiltersContainer
        '
        Me.pnlFiltersContainer.BackColor = System.Drawing.Color.White
        Me.pnlFiltersContainer.Controls.Add(Me.pnlHitIcon)
        Me.pnlFiltersContainer.Controls.Add(Me.pnlDirectionIcon)
        Me.pnlFiltersContainer.Controls.Add(Me.pnlTimeDateIcon)
        Me.pnlFiltersContainer.Controls.Add(Me.pnlEventIcon)
        Me.pnlFiltersContainer.Controls.Add(Me.pnlPositionIcon)
        Me.pnlFiltersContainer.Controls.Add(Me.pnlShooterIcon)
        Me.pnlFiltersContainer.Controls.Add(Me.pnlSquadIcon)
        Me.pnlFiltersContainer.Controls.Add(Me.lblFilters)
        Me.pnlFiltersContainer.Controls.Add(Me.btnHitFilter)
        Me.pnlFiltersContainer.Controls.Add(Me.btnDirectionFilter)
        Me.pnlFiltersContainer.Controls.Add(Me.btnTimeDateFilter)
        Me.pnlFiltersContainer.Controls.Add(Me.btnEventFilter)
        Me.pnlFiltersContainer.Controls.Add(Me.btnPositionFilter)
        Me.pnlFiltersContainer.Controls.Add(Me.btnShooterFilter)
        Me.pnlFiltersContainer.Controls.Add(Me.btnSquadFilter)
        Me.pnlFiltersContainer.Location = New System.Drawing.Point(0, 36)
        Me.pnlFiltersContainer.Name = "pnlFiltersContainer"
        Me.pnlFiltersContainer.Size = New System.Drawing.Size(311, 456)
        Me.pnlFiltersContainer.TabIndex = 5
        '
        'pnlHitIcon
        '
        Me.pnlHitIcon.BackColor = System.Drawing.Color.LightGreen
        Me.pnlHitIcon.BackgroundImage = CType(resources.GetObject("pnlHitIcon.BackgroundImage"), System.Drawing.Image)
        Me.pnlHitIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlHitIcon.Location = New System.Drawing.Point(47, 358)
        Me.pnlHitIcon.Name = "pnlHitIcon"
        Me.pnlHitIcon.Size = New System.Drawing.Size(35, 35)
        Me.pnlHitIcon.TabIndex = 24
        '
        'pnlDirectionIcon
        '
        Me.pnlDirectionIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlDirectionIcon.BackgroundImage = CType(resources.GetObject("pnlDirectionIcon.BackgroundImage"), System.Drawing.Image)
        Me.pnlDirectionIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlDirectionIcon.Location = New System.Drawing.Point(47, 313)
        Me.pnlDirectionIcon.Name = "pnlDirectionIcon"
        Me.pnlDirectionIcon.Size = New System.Drawing.Size(35, 35)
        Me.pnlDirectionIcon.TabIndex = 23
        '
        'pnlTimeDateIcon
        '
        Me.pnlTimeDateIcon.BackColor = System.Drawing.Color.LightGreen
        Me.pnlTimeDateIcon.BackgroundImage = CType(resources.GetObject("pnlTimeDateIcon.BackgroundImage"), System.Drawing.Image)
        Me.pnlTimeDateIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlTimeDateIcon.Location = New System.Drawing.Point(49, 261)
        Me.pnlTimeDateIcon.Name = "pnlTimeDateIcon"
        Me.pnlTimeDateIcon.Size = New System.Drawing.Size(32, 32)
        Me.pnlTimeDateIcon.TabIndex = 22
        '
        'pnlEventIcon
        '
        Me.pnlEventIcon.BackColor = System.Drawing.Color.LightGreen
        Me.pnlEventIcon.BackgroundImage = CType(resources.GetObject("pnlEventIcon.BackgroundImage"), System.Drawing.Image)
        Me.pnlEventIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlEventIcon.Location = New System.Drawing.Point(47, 211)
        Me.pnlEventIcon.Name = "pnlEventIcon"
        Me.pnlEventIcon.Size = New System.Drawing.Size(35, 35)
        Me.pnlEventIcon.TabIndex = 21
        '
        'pnlPositionIcon
        '
        Me.pnlPositionIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlPositionIcon.BackgroundImage = CType(resources.GetObject("pnlPositionIcon.BackgroundImage"), System.Drawing.Image)
        Me.pnlPositionIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlPositionIcon.Location = New System.Drawing.Point(50, 163)
        Me.pnlPositionIcon.Name = "pnlPositionIcon"
        Me.pnlPositionIcon.Size = New System.Drawing.Size(30, 35)
        Me.pnlPositionIcon.TabIndex = 20
        '
        'pnlShooterIcon
        '
        Me.pnlShooterIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlShooterIcon.BackgroundImage = CType(resources.GetObject("pnlShooterIcon.BackgroundImage"), System.Drawing.Image)
        Me.pnlShooterIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlShooterIcon.Location = New System.Drawing.Point(50, 116)
        Me.pnlShooterIcon.Name = "pnlShooterIcon"
        Me.pnlShooterIcon.Size = New System.Drawing.Size(30, 33)
        Me.pnlShooterIcon.TabIndex = 2
        '
        'pnlSquadIcon
        '
        Me.pnlSquadIcon.BackColor = System.Drawing.Color.LightGreen
        Me.pnlSquadIcon.BackgroundImage = CType(resources.GetObject("pnlSquadIcon.BackgroundImage"), System.Drawing.Image)
        Me.pnlSquadIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlSquadIcon.Location = New System.Drawing.Point(47, 67)
        Me.pnlSquadIcon.Name = "pnlSquadIcon"
        Me.pnlSquadIcon.Size = New System.Drawing.Size(35, 35)
        Me.pnlSquadIcon.TabIndex = 1
        '
        'lblFilters
        '
        Me.lblFilters.AutoSize = True
        Me.lblFilters.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilters.Location = New System.Drawing.Point(12, 22)
        Me.lblFilters.Name = "lblFilters"
        Me.lblFilters.Size = New System.Drawing.Size(60, 24)
        Me.lblFilters.TabIndex = 19
        Me.lblFilters.Text = "Filters"
        '
        'btnHitFilter
        '
        Me.btnHitFilter.BackColor = System.Drawing.Color.LightGreen
        Me.btnHitFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHitFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitFilter.Location = New System.Drawing.Point(-1, 350)
        Me.btnHitFilter.Name = "btnHitFilter"
        Me.btnHitFilter.Size = New System.Drawing.Size(311, 52)
        Me.btnHitFilter.TabIndex = 18
        Me.btnHitFilter.Text = "Hit"
        Me.btnHitFilter.UseVisualStyleBackColor = False
        '
        'btnDirectionFilter
        '
        Me.btnDirectionFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDirectionFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDirectionFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDirectionFilter.Location = New System.Drawing.Point(-1, 300)
        Me.btnDirectionFilter.Name = "btnDirectionFilter"
        Me.btnDirectionFilter.Size = New System.Drawing.Size(311, 52)
        Me.btnDirectionFilter.TabIndex = 17
        Me.btnDirectionFilter.Text = "Direction"
        Me.btnDirectionFilter.UseVisualStyleBackColor = False
        '
        'btnTimeDateFilter
        '
        Me.btnTimeDateFilter.BackColor = System.Drawing.Color.LightGreen
        Me.btnTimeDateFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeDateFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeDateFilter.Location = New System.Drawing.Point(-1, 252)
        Me.btnTimeDateFilter.Name = "btnTimeDateFilter"
        Me.btnTimeDateFilter.Size = New System.Drawing.Size(311, 52)
        Me.btnTimeDateFilter.TabIndex = 16
        Me.btnTimeDateFilter.Text = "Time / Date"
        Me.btnTimeDateFilter.UseVisualStyleBackColor = False
        '
        'btnEventFilter
        '
        Me.btnEventFilter.BackColor = System.Drawing.Color.LightGreen
        Me.btnEventFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEventFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEventFilter.Location = New System.Drawing.Point(-1, 204)
        Me.btnEventFilter.Name = "btnEventFilter"
        Me.btnEventFilter.Size = New System.Drawing.Size(311, 52)
        Me.btnEventFilter.TabIndex = 15
        Me.btnEventFilter.Text = "Event"
        Me.btnEventFilter.UseVisualStyleBackColor = False
        '
        'btnPositionFilter
        '
        Me.btnPositionFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPositionFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPositionFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPositionFilter.Location = New System.Drawing.Point(-1, 156)
        Me.btnPositionFilter.Name = "btnPositionFilter"
        Me.btnPositionFilter.Size = New System.Drawing.Size(311, 52)
        Me.btnPositionFilter.TabIndex = 14
        Me.btnPositionFilter.Text = "Position"
        Me.btnPositionFilter.UseVisualStyleBackColor = False
        '
        'btnShooterFilter
        '
        Me.btnShooterFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnShooterFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShooterFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShooterFilter.Location = New System.Drawing.Point(-1, 108)
        Me.btnShooterFilter.Name = "btnShooterFilter"
        Me.btnShooterFilter.Size = New System.Drawing.Size(311, 52)
        Me.btnShooterFilter.TabIndex = 11
        Me.btnShooterFilter.Text = "Shooter"
        Me.btnShooterFilter.UseVisualStyleBackColor = False
        '
        'btnSquadFilter
        '
        Me.btnSquadFilter.BackColor = System.Drawing.Color.LightGreen
        Me.btnSquadFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSquadFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSquadFilter.Location = New System.Drawing.Point(-1, 60)
        Me.btnSquadFilter.Name = "btnSquadFilter"
        Me.btnSquadFilter.Size = New System.Drawing.Size(311, 52)
        Me.btnSquadFilter.TabIndex = 6
        Me.btnSquadFilter.Text = "Squad"
        Me.btnSquadFilter.UseVisualStyleBackColor = False
        '
        'pnlStats
        '
        Me.pnlStats.BackColor = System.Drawing.Color.Transparent
        Me.pnlStats.Controls.Add(Me.dataStats)
        Me.pnlStats.Location = New System.Drawing.Point(321, 56)
        Me.pnlStats.Name = "pnlStats"
        Me.pnlStats.Size = New System.Drawing.Size(674, 348)
        Me.pnlStats.TabIndex = 7
        '
        'dataStats
        '
        Me.dataStats.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.dataStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataStats.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Squad, Me.Shooter, Me.Position, Me.EventType, Me.Time, Me.Direction, Me.Hit})
        Me.dataStats.Location = New System.Drawing.Point(2, -1)
        Me.dataStats.Name = "dataStats"
        Me.dataStats.Size = New System.Drawing.Size(671, 346)
        Me.dataStats.TabIndex = 0
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlTitle.Controls.Add(Me.lblViewStats)
        Me.pnlTitle.Controls.Add(Me.btnBack)
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(1012, 42)
        Me.pnlTitle.TabIndex = 49
        '
        'lblViewStats
        '
        Me.lblViewStats.AutoSize = True
        Me.lblViewStats.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblViewStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewStats.Location = New System.Drawing.Point(82, 9)
        Me.lblViewStats.Name = "lblViewStats"
        Me.lblViewStats.Size = New System.Drawing.Size(96, 24)
        Me.lblViewStats.TabIndex = 30
        Me.lblViewStats.Text = "View Stats"
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
        'pnlExportIcon
        '
        Me.pnlExportIcon.BackgroundImage = CType(resources.GetObject("pnlExportIcon.BackgroundImage"), System.Drawing.Image)
        Me.pnlExportIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlExportIcon.Location = New System.Drawing.Point(3, 2)
        Me.pnlExportIcon.Name = "pnlExportIcon"
        Me.pnlExportIcon.Size = New System.Drawing.Size(67, 64)
        Me.pnlExportIcon.TabIndex = 50
        '
        'pnlExportContainer
        '
        Me.pnlExportContainer.Controls.Add(Me.lblExport)
        Me.pnlExportContainer.Controls.Add(Me.pnlExportIcon)
        Me.pnlExportContainer.Location = New System.Drawing.Point(850, 419)
        Me.pnlExportContainer.Name = "pnlExportContainer"
        Me.pnlExportContainer.Size = New System.Drawing.Size(142, 64)
        Me.pnlExportContainer.TabIndex = 51
        '
        'lblExport
        '
        Me.lblExport.AutoSize = True
        Me.lblExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExport.Location = New System.Drawing.Point(73, 21)
        Me.lblExport.Name = "lblExport"
        Me.lblExport.Size = New System.Drawing.Size(65, 24)
        Me.lblExport.TabIndex = 51
        Me.lblExport.Text = "Export"
        '
        'Squad
        '
        Me.Squad.HeaderText = "Squad"
        Me.Squad.Name = "Squad"
        Me.Squad.Width = 75
        '
        'Shooter
        '
        Me.Shooter.HeaderText = "Shooter"
        Me.Shooter.Name = "Shooter"
        Me.Shooter.Width = 150
        '
        'Position
        '
        Me.Position.HeaderText = "Position"
        Me.Position.Name = "Position"
        Me.Position.Width = 50
        '
        'EventType
        '
        Me.EventType.HeaderText = "Event"
        Me.EventType.Name = "EventType"
        '
        'Time
        '
        Me.Time.HeaderText = "Time"
        Me.Time.Name = "Time"
        '
        'Direction
        '
        Me.Direction.HeaderText = "Direction"
        Me.Direction.Name = "Direction"
        Me.Direction.Width = 75
        '
        'Hit
        '
        Me.Hit.HeaderText = "Hit"
        Me.Hit.Name = "Hit"
        Me.Hit.Width = 75
        '
        'frmViewStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 492)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlExportContainer)
        Me.Controls.Add(Me.pnlTitle)
        Me.Controls.Add(Me.pnlStats)
        Me.Controls.Add(Me.pnlFiltersContainer)
        Me.Name = "frmViewStats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlFiltersContainer.ResumeLayout(False)
        Me.pnlFiltersContainer.PerformLayout()
        Me.pnlStats.ResumeLayout(False)
        CType(Me.dataStats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.pnlExportContainer.ResumeLayout(False)
        Me.pnlExportContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlFiltersContainer As System.Windows.Forms.Panel
    Friend WithEvents btnSquadFilter As System.Windows.Forms.Button
    Friend WithEvents pnlStats As System.Windows.Forms.Panel
    Friend WithEvents dataStats As System.Windows.Forms.DataGridView
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblViewStats As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents pnlExportIcon As System.Windows.Forms.Panel
    Friend WithEvents pnlExportContainer As System.Windows.Forms.Panel
    Friend WithEvents lblExport As System.Windows.Forms.Label
    Friend WithEvents lblFilters As System.Windows.Forms.Label
    Friend WithEvents btnHitFilter As System.Windows.Forms.Button
    Friend WithEvents btnDirectionFilter As System.Windows.Forms.Button
    Friend WithEvents btnTimeDateFilter As System.Windows.Forms.Button
    Friend WithEvents btnEventFilter As System.Windows.Forms.Button
    Friend WithEvents btnPositionFilter As System.Windows.Forms.Button
    Friend WithEvents btnShooterFilter As System.Windows.Forms.Button
    Friend WithEvents pnlHitIcon As System.Windows.Forms.Panel
    Friend WithEvents pnlDirectionIcon As System.Windows.Forms.Panel
    Friend WithEvents pnlTimeDateIcon As System.Windows.Forms.Panel
    Friend WithEvents pnlEventIcon As System.Windows.Forms.Panel
    Friend WithEvents pnlPositionIcon As System.Windows.Forms.Panel
    Friend WithEvents pnlShooterIcon As System.Windows.Forms.Panel
    Friend WithEvents pnlSquadIcon As System.Windows.Forms.Panel
    Friend WithEvents Squad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Shooter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Position As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EventType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Time As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direction As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hit As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
