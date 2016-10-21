<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLocation))
        Me.pnlPlayers = New System.Windows.Forms.Panel()
        Me.listShooters = New System.Windows.Forms.ListBox()
        Me.pnlDetailsContainer = New System.Windows.Forms.Panel()
        Me.pnlSaveContainer = New System.Windows.Forms.Panel()
        Me.lblSave = New System.Windows.Forms.Label()
        Me.pnlSaveIcon = New System.Windows.Forms.Panel()
        Me.txtbxAddress = New System.Windows.Forms.TextBox()
        Me.txtbxNotes = New System.Windows.Forms.TextBox()
        Me.txtbxTitle = New System.Windows.Forms.TextBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblSetup = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSquads = New System.Windows.Forms.Button()
        Me.btnLocations = New System.Windows.Forms.Button()
        Me.btnShooters = New System.Windows.Forms.Button()
        Me.txtbxSearch = New System.Windows.Forms.TextBox()
        Me.pnlAddIcon = New System.Windows.Forms.Panel()
        Me.pnlSearchIcon = New System.Windows.Forms.Panel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.shapeLine = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.pnlLineCover = New System.Windows.Forms.Panel()
        Me.pnlPlayers.SuspendLayout()
        Me.pnlDetailsContainer.SuspendLayout()
        Me.pnlSaveContainer.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPlayers
        '
        Me.pnlPlayers.Controls.Add(Me.listShooters)
        Me.pnlPlayers.Controls.Add(Me.pnlDetailsContainer)
        Me.pnlPlayers.Location = New System.Drawing.Point(0, 139)
        Me.pnlPlayers.Name = "pnlPlayers"
        Me.pnlPlayers.Size = New System.Drawing.Size(1012, 359)
        Me.pnlPlayers.TabIndex = 26
        '
        'listShooters
        '
        Me.listShooters.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listShooters.FormattingEnabled = True
        Me.listShooters.ItemHeight = 24
        Me.listShooters.Items.AddRange(New Object() {"Ackley", "Cedar Falls", "Davenport", "Independence", "Steamboat Rock", "Waukee", "West Delaware"})
        Me.listShooters.Location = New System.Drawing.Point(0, 0)
        Me.listShooters.Name = "listShooters"
        Me.listShooters.Size = New System.Drawing.Size(374, 364)
        Me.listShooters.TabIndex = 29
        '
        'pnlDetailsContainer
        '
        Me.pnlDetailsContainer.BackColor = System.Drawing.Color.Silver
        Me.pnlDetailsContainer.Controls.Add(Me.pnlSaveContainer)
        Me.pnlDetailsContainer.Controls.Add(Me.txtbxAddress)
        Me.pnlDetailsContainer.Controls.Add(Me.txtbxNotes)
        Me.pnlDetailsContainer.Controls.Add(Me.txtbxTitle)
        Me.pnlDetailsContainer.Controls.Add(Me.lblNotes)
        Me.pnlDetailsContainer.Controls.Add(Me.lblAddress)
        Me.pnlDetailsContainer.Controls.Add(Me.lblTitle)
        Me.pnlDetailsContainer.Location = New System.Drawing.Point(371, 0)
        Me.pnlDetailsContainer.Name = "pnlDetailsContainer"
        Me.pnlDetailsContainer.Size = New System.Drawing.Size(641, 356)
        Me.pnlDetailsContainer.TabIndex = 25
        '
        'pnlSaveContainer
        '
        Me.pnlSaveContainer.Controls.Add(Me.lblSave)
        Me.pnlSaveContainer.Controls.Add(Me.pnlSaveIcon)
        Me.pnlSaveContainer.Location = New System.Drawing.Point(480, 284)
        Me.pnlSaveContainer.Name = "pnlSaveContainer"
        Me.pnlSaveContainer.Size = New System.Drawing.Size(154, 64)
        Me.pnlSaveContainer.TabIndex = 55
        '
        'lblSave
        '
        Me.lblSave.AutoSize = True
        Me.lblSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSave.Location = New System.Drawing.Point(73, 21)
        Me.lblSave.Name = "lblSave"
        Me.lblSave.Size = New System.Drawing.Size(52, 24)
        Me.lblSave.TabIndex = 51
        Me.lblSave.Text = "Save"
        '
        'pnlSaveIcon
        '
        Me.pnlSaveIcon.BackgroundImage = CType(resources.GetObject("pnlSaveIcon.BackgroundImage"), System.Drawing.Image)
        Me.pnlSaveIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlSaveIcon.Location = New System.Drawing.Point(13, 11)
        Me.pnlSaveIcon.Name = "pnlSaveIcon"
        Me.pnlSaveIcon.Size = New System.Drawing.Size(45, 43)
        Me.pnlSaveIcon.TabIndex = 52
        '
        'txtbxAddress
        '
        Me.txtbxAddress.Location = New System.Drawing.Point(215, 60)
        Me.txtbxAddress.Multiline = True
        Me.txtbxAddress.Name = "txtbxAddress"
        Me.txtbxAddress.Size = New System.Drawing.Size(228, 93)
        Me.txtbxAddress.TabIndex = 14
        '
        'txtbxNotes
        '
        Me.txtbxNotes.Location = New System.Drawing.Point(215, 168)
        Me.txtbxNotes.Multiline = True
        Me.txtbxNotes.Name = "txtbxNotes"
        Me.txtbxNotes.Size = New System.Drawing.Size(307, 101)
        Me.txtbxNotes.TabIndex = 13
        '
        'txtbxTitle
        '
        Me.txtbxTitle.Location = New System.Drawing.Point(215, 29)
        Me.txtbxTitle.Name = "txtbxTitle"
        Me.txtbxTitle.Size = New System.Drawing.Size(228, 20)
        Me.txtbxTitle.TabIndex = 7
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.Location = New System.Drawing.Point(127, 168)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(47, 19)
        Me.lblNotes.TabIndex = 6
        Me.lblNotes.Text = "Notes"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(127, 60)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(61, 19)
        Me.lblAddress.TabIndex = 1
        Me.lblAddress.Text = "Address"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(127, 32)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(38, 19)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title"
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlTitle.Controls.Add(Me.lblSetup)
        Me.pnlTitle.Controls.Add(Me.btnBack)
        Me.pnlTitle.Location = New System.Drawing.Point(-2, -1)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(1012, 42)
        Me.pnlTitle.TabIndex = 48
        '
        'lblSetup
        '
        Me.lblSetup.AutoSize = True
        Me.lblSetup.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSetup.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetup.Location = New System.Drawing.Point(82, 9)
        Me.lblSetup.Name = "lblSetup"
        Me.lblSetup.Size = New System.Drawing.Size(59, 24)
        Me.lblSetup.TabIndex = 30
        Me.lblSetup.Text = "Setup"
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
        'btnSquads
        '
        Me.btnSquads.BackColor = System.Drawing.Color.LightGreen
        Me.btnSquads.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSquads.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSquads.Location = New System.Drawing.Point(671, 40)
        Me.btnSquads.Name = "btnSquads"
        Me.btnSquads.Size = New System.Drawing.Size(340, 59)
        Me.btnSquads.TabIndex = 47
        Me.btnSquads.Text = "Squads"
        Me.btnSquads.UseVisualStyleBackColor = False
        '
        'btnLocations
        '
        Me.btnLocations.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLocations.Enabled = False
        Me.btnLocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLocations.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocations.Location = New System.Drawing.Point(335, 40)
        Me.btnLocations.Name = "btnLocations"
        Me.btnLocations.Size = New System.Drawing.Size(345, 59)
        Me.btnLocations.TabIndex = 46
        Me.btnLocations.Text = "Locations"
        Me.btnLocations.UseVisualStyleBackColor = False
        '
        'btnShooters
        '
        Me.btnShooters.BackColor = System.Drawing.Color.LightGreen
        Me.btnShooters.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShooters.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShooters.Location = New System.Drawing.Point(-1, 40)
        Me.btnShooters.Margin = New System.Windows.Forms.Padding(0)
        Me.btnShooters.Name = "btnShooters"
        Me.btnShooters.Size = New System.Drawing.Size(340, 59)
        Me.btnShooters.TabIndex = 45
        Me.btnShooters.Text = "Shooters"
        Me.btnShooters.UseVisualStyleBackColor = False
        '
        'txtbxSearch
        '
        Me.txtbxSearch.Location = New System.Drawing.Point(805, 109)
        Me.txtbxSearch.Name = "txtbxSearch"
        Me.txtbxSearch.Size = New System.Drawing.Size(181, 20)
        Me.txtbxSearch.TabIndex = 44
        Me.txtbxSearch.Text = "Search"
        '
        'pnlAddIcon
        '
        Me.pnlAddIcon.BackgroundImage = CType(resources.GetObject("pnlAddIcon.BackgroundImage"), System.Drawing.Image)
        Me.pnlAddIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlAddIcon.Location = New System.Drawing.Point(679, 102)
        Me.pnlAddIcon.Name = "pnlAddIcon"
        Me.pnlAddIcon.Size = New System.Drawing.Size(37, 34)
        Me.pnlAddIcon.TabIndex = 49
        '
        'pnlSearchIcon
        '
        Me.pnlSearchIcon.BackgroundImage = CType(resources.GetObject("pnlSearchIcon.BackgroundImage"), System.Drawing.Image)
        Me.pnlSearchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlSearchIcon.Location = New System.Drawing.Point(756, 99)
        Me.pnlSearchIcon.Name = "pnlSearchIcon"
        Me.pnlSearchIcon.Size = New System.Drawing.Size(43, 40)
        Me.pnlSearchIcon.TabIndex = 52
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.shapeLine})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1008, 492)
        Me.ShapeContainer1.TabIndex = 53
        Me.ShapeContainer1.TabStop = False
        '
        'shapeLine
        '
        Me.shapeLine.Name = "shapeLine"
        Me.shapeLine.X1 = 736
        Me.shapeLine.X2 = 736
        Me.shapeLine.Y1 = 103
        Me.shapeLine.Y2 = 132
        '
        'pnlLineCover
        '
        Me.pnlLineCover.Location = New System.Drawing.Point(-2, 95)
        Me.pnlLineCover.Name = "pnlLineCover"
        Me.pnlLineCover.Size = New System.Drawing.Size(1011, 5)
        Me.pnlLineCover.TabIndex = 54
        '
        'frmLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 492)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlLineCover)
        Me.Controls.Add(Me.pnlSearchIcon)
        Me.Controls.Add(Me.pnlAddIcon)
        Me.Controls.Add(Me.pnlTitle)
        Me.Controls.Add(Me.btnSquads)
        Me.Controls.Add(Me.btnLocations)
        Me.Controls.Add(Me.btnShooters)
        Me.Controls.Add(Me.txtbxSearch)
        Me.Controls.Add(Me.pnlPlayers)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmLocation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlPlayers.ResumeLayout(False)
        Me.pnlDetailsContainer.ResumeLayout(False)
        Me.pnlDetailsContainer.PerformLayout()
        Me.pnlSaveContainer.ResumeLayout(False)
        Me.pnlSaveContainer.PerformLayout()
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlPlayers As System.Windows.Forms.Panel
    Friend WithEvents listShooters As System.Windows.Forms.ListBox
    Friend WithEvents pnlDetailsContainer As System.Windows.Forms.Panel
    Friend WithEvents txtbxNotes As System.Windows.Forms.TextBox
    Friend WithEvents txtbxTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtbxAddress As System.Windows.Forms.TextBox
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblSetup As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnSquads As System.Windows.Forms.Button
    Friend WithEvents btnLocations As System.Windows.Forms.Button
    Friend WithEvents btnShooters As System.Windows.Forms.Button
    Friend WithEvents txtbxSearch As System.Windows.Forms.TextBox
    Friend WithEvents pnlAddIcon As System.Windows.Forms.Panel
    Friend WithEvents pnlSearchIcon As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents shapeLine As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents pnlSaveContainer As System.Windows.Forms.Panel
    Friend WithEvents lblSave As System.Windows.Forms.Label
    Friend WithEvents pnlSaveIcon As System.Windows.Forms.Panel
    Friend WithEvents pnlLineCover As System.Windows.Forms.Panel
End Class
