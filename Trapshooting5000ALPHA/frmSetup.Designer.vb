<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSShooters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSShooters))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pnlDetailContainer = New System.Windows.Forms.Panel()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.pnlSaveContainer = New System.Windows.Forms.Panel()
        Me.lblSave = New System.Windows.Forms.Label()
        Me.pnlSaveIcon = New System.Windows.Forms.Panel()
        Me.cmbbxSquad = New System.Windows.Forms.ComboBox()
        Me.txtbxNotes = New System.Windows.Forms.TextBox()
        Me.txtbxEmail = New System.Windows.Forms.TextBox()
        Me.txtbxLastName = New System.Windows.Forms.TextBox()
        Me.txtbxGradeLevel = New System.Windows.Forms.TextBox()
        Me.txtbxPhone = New System.Windows.Forms.TextBox()
        Me.txtbxFirstName = New System.Windows.Forms.TextBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblSquad = New System.Windows.Forms.Label()
        Me.lblGradeLevel = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.playersPanel = New System.Windows.Forms.Panel()
        Me.pnlRegisteredShootersContainer = New System.Windows.Forms.Panel()
        Me.lblRegisteredShooters = New System.Windows.Forms.Label()
        Me.listShooters = New System.Windows.Forms.ListBox()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblSetup = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSquads = New System.Windows.Forms.Button()
        Me.btnLocations = New System.Windows.Forms.Button()
        Me.btnShooters = New System.Windows.Forms.Button()
        Me.shapeLine = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.pnlSearchIcon = New System.Windows.Forms.Panel()
        Me.pnlAddIcon = New System.Windows.Forms.Panel()
        Me.txtbxSearch = New System.Windows.Forms.TextBox()
        Me.pnlLineCover = New System.Windows.Forms.Panel()
        Me.pnlDetailContainer.SuspendLayout()
        Me.pnlSaveContainer.SuspendLayout()
        Me.playersPanel.SuspendLayout()
        Me.pnlRegisteredShootersContainer.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(807, 110)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(181, 20)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "Search"
        '
        'pnlDetailContainer
        '
        Me.pnlDetailContainer.BackColor = System.Drawing.Color.Silver
        Me.pnlDetailContainer.Controls.Add(Me.lblDetails)
        Me.pnlDetailContainer.Controls.Add(Me.pnlSaveContainer)
        Me.pnlDetailContainer.Controls.Add(Me.cmbbxSquad)
        Me.pnlDetailContainer.Controls.Add(Me.txtbxNotes)
        Me.pnlDetailContainer.Controls.Add(Me.txtbxEmail)
        Me.pnlDetailContainer.Controls.Add(Me.txtbxLastName)
        Me.pnlDetailContainer.Controls.Add(Me.txtbxGradeLevel)
        Me.pnlDetailContainer.Controls.Add(Me.txtbxPhone)
        Me.pnlDetailContainer.Controls.Add(Me.txtbxFirstName)
        Me.pnlDetailContainer.Controls.Add(Me.lblNotes)
        Me.pnlDetailContainer.Controls.Add(Me.lblPhone)
        Me.pnlDetailContainer.Controls.Add(Me.lblEmail)
        Me.pnlDetailContainer.Controls.Add(Me.lblSquad)
        Me.pnlDetailContainer.Controls.Add(Me.lblGradeLevel)
        Me.pnlDetailContainer.Controls.Add(Me.lblLastName)
        Me.pnlDetailContainer.Controls.Add(Me.lblFirstName)
        Me.pnlDetailContainer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlDetailContainer.Location = New System.Drawing.Point(371, 0)
        Me.pnlDetailContainer.Name = "pnlDetailContainer"
        Me.pnlDetailContainer.Size = New System.Drawing.Size(641, 355)
        Me.pnlDetailContainer.TabIndex = 25
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetails.Location = New System.Drawing.Point(283, 7)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(98, 31)
        Me.lblDetails.TabIndex = 31
        Me.lblDetails.Text = "Details"
        '
        'pnlSaveContainer
        '
        Me.pnlSaveContainer.Controls.Add(Me.lblSave)
        Me.pnlSaveContainer.Controls.Add(Me.pnlSaveIcon)
        Me.pnlSaveContainer.Location = New System.Drawing.Point(481, 283)
        Me.pnlSaveContainer.Name = "pnlSaveContainer"
        Me.pnlSaveContainer.Size = New System.Drawing.Size(154, 64)
        Me.pnlSaveContainer.TabIndex = 54
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
        'cmbbxSquad
        '
        Me.cmbbxSquad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxSquad.FormattingEnabled = True
        Me.cmbbxSquad.Items.AddRange(New Object() {"Main", "Second", "Beginners"})
        Me.cmbbxSquad.Location = New System.Drawing.Point(156, 94)
        Me.cmbbxSquad.Name = "cmbbxSquad"
        Me.cmbbxSquad.Size = New System.Drawing.Size(146, 32)
        Me.cmbbxSquad.TabIndex = 3
        '
        'txtbxNotes
        '
        Me.txtbxNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxNotes.Location = New System.Drawing.Point(156, 216)
        Me.txtbxNotes.Multiline = True
        Me.txtbxNotes.Name = "txtbxNotes"
        Me.txtbxNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtbxNotes.Size = New System.Drawing.Size(309, 99)
        Me.txtbxNotes.TabIndex = 7
        '
        'txtbxEmail
        '
        Me.txtbxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEmail.Location = New System.Drawing.Point(404, 167)
        Me.txtbxEmail.Name = "txtbxEmail"
        Me.txtbxEmail.Size = New System.Drawing.Size(202, 29)
        Me.txtbxEmail.TabIndex = 6
        '
        'txtbxLastName
        '
        Me.txtbxLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxLastName.Location = New System.Drawing.Point(423, 59)
        Me.txtbxLastName.Name = "txtbxLastName"
        Me.txtbxLastName.Size = New System.Drawing.Size(146, 29)
        Me.txtbxLastName.TabIndex = 2
        '
        'txtbxGradeLevel
        '
        Me.txtbxGradeLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxGradeLevel.Location = New System.Drawing.Point(156, 132)
        Me.txtbxGradeLevel.Name = "txtbxGradeLevel"
        Me.txtbxGradeLevel.Size = New System.Drawing.Size(146, 29)
        Me.txtbxGradeLevel.TabIndex = 4
        '
        'txtbxPhone
        '
        Me.txtbxPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxPhone.Location = New System.Drawing.Point(156, 167)
        Me.txtbxPhone.Name = "txtbxPhone"
        Me.txtbxPhone.Size = New System.Drawing.Size(146, 29)
        Me.txtbxPhone.TabIndex = 5
        '
        'txtbxFirstName
        '
        Me.txtbxFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxFirstName.Location = New System.Drawing.Point(156, 59)
        Me.txtbxFirstName.Name = "txtbxFirstName"
        Me.txtbxFirstName.Size = New System.Drawing.Size(146, 29)
        Me.txtbxFirstName.TabIndex = 1
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.Location = New System.Drawing.Point(44, 222)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(51, 20)
        Me.lblNotes.TabIndex = 6
        Me.lblNotes.Text = "Notes"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(44, 173)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(55, 20)
        Me.lblPhone.TabIndex = 5
        Me.lblPhone.Text = "Phone"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(339, 173)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(48, 20)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email"
        '
        'lblSquad
        '
        Me.lblSquad.AutoSize = True
        Me.lblSquad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSquad.Location = New System.Drawing.Point(44, 100)
        Me.lblSquad.Name = "lblSquad"
        Me.lblSquad.Size = New System.Drawing.Size(56, 20)
        Me.lblSquad.TabIndex = 3
        Me.lblSquad.Text = "Squad"
        '
        'lblGradeLevel
        '
        Me.lblGradeLevel.AutoSize = True
        Me.lblGradeLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeLevel.Location = New System.Drawing.Point(42, 138)
        Me.lblGradeLevel.Name = "lblGradeLevel"
        Me.lblGradeLevel.Size = New System.Drawing.Size(103, 20)
        Me.lblGradeLevel.TabIndex = 2
        Me.lblGradeLevel.Text = "Grade Level  "
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(331, 65)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(86, 20)
        Me.lblLastName.TabIndex = 1
        Me.lblLastName.Text = "Last Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(44, 65)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(86, 20)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name"
        '
        'playersPanel
        '
        Me.playersPanel.Controls.Add(Me.pnlRegisteredShootersContainer)
        Me.playersPanel.Controls.Add(Me.pnlDetailContainer)
        Me.playersPanel.Location = New System.Drawing.Point(-1, 140)
        Me.playersPanel.Name = "playersPanel"
        Me.playersPanel.Size = New System.Drawing.Size(1012, 355)
        Me.playersPanel.TabIndex = 25
        '
        'pnlRegisteredShootersContainer
        '
        Me.pnlRegisteredShootersContainer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlRegisteredShootersContainer.Controls.Add(Me.lblRegisteredShooters)
        Me.pnlRegisteredShootersContainer.Controls.Add(Me.listShooters)
        Me.pnlRegisteredShootersContainer.Location = New System.Drawing.Point(1, 0)
        Me.pnlRegisteredShootersContainer.Name = "pnlRegisteredShootersContainer"
        Me.pnlRegisteredShootersContainer.Size = New System.Drawing.Size(371, 352)
        Me.pnlRegisteredShootersContainer.TabIndex = 30
        '
        'lblRegisteredShooters
        '
        Me.lblRegisteredShooters.AutoSize = True
        Me.lblRegisteredShooters.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisteredShooters.Location = New System.Drawing.Point(81, 7)
        Me.lblRegisteredShooters.Name = "lblRegisteredShooters"
        Me.lblRegisteredShooters.Size = New System.Drawing.Size(235, 29)
        Me.lblRegisteredShooters.TabIndex = 30
        Me.lblRegisteredShooters.Text = "Registered Shooters"
        '
        'listShooters
        '
        Me.listShooters.BackColor = System.Drawing.Color.WhiteSmoke
        Me.listShooters.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listShooters.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listShooters.FormattingEnabled = True
        Me.listShooters.ItemHeight = 25
        Me.listShooters.Location = New System.Drawing.Point(0, 53)
        Me.listShooters.Name = "listShooters"
        Me.listShooters.Size = New System.Drawing.Size(372, 275)
        Me.listShooters.TabIndex = 29
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlTitle.Controls.Add(Me.lblSetup)
        Me.pnlTitle.Controls.Add(Me.btnBack)
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(1012, 42)
        Me.pnlTitle.TabIndex = 42
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
        Me.btnSquads.Location = New System.Drawing.Point(673, 41)
        Me.btnSquads.Name = "btnSquads"
        Me.btnSquads.Size = New System.Drawing.Size(340, 59)
        Me.btnSquads.TabIndex = 41
        Me.btnSquads.Text = "Squads"
        Me.btnSquads.UseVisualStyleBackColor = False
        '
        'btnLocations
        '
        Me.btnLocations.BackColor = System.Drawing.Color.LightGreen
        Me.btnLocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLocations.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocations.Location = New System.Drawing.Point(337, 41)
        Me.btnLocations.Name = "btnLocations"
        Me.btnLocations.Size = New System.Drawing.Size(345, 59)
        Me.btnLocations.TabIndex = 40
        Me.btnLocations.Text = "Locations"
        Me.btnLocations.UseVisualStyleBackColor = False
        '
        'btnShooters
        '
        Me.btnShooters.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnShooters.Enabled = False
        Me.btnShooters.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShooters.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShooters.Location = New System.Drawing.Point(-1, 41)
        Me.btnShooters.Margin = New System.Windows.Forms.Padding(0)
        Me.btnShooters.Name = "btnShooters"
        Me.btnShooters.Size = New System.Drawing.Size(340, 59)
        Me.btnShooters.TabIndex = 39
        Me.btnShooters.Text = "Shooters"
        Me.btnShooters.UseVisualStyleBackColor = False
        '
        'shapeLine
        '
        Me.shapeLine.Name = "shapeLine"
        Me.shapeLine.X1 = 737
        Me.shapeLine.X2 = 737
        Me.shapeLine.Y1 = 105
        Me.shapeLine.Y2 = 134
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.shapeLine})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1008, 492)
        Me.ShapeContainer2.TabIndex = 53
        Me.ShapeContainer2.TabStop = False
        '
        'pnlSearchIcon
        '
        Me.pnlSearchIcon.BackgroundImage = CType(resources.GetObject("pnlSearchIcon.BackgroundImage"), System.Drawing.Image)
        Me.pnlSearchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlSearchIcon.Location = New System.Drawing.Point(758, 100)
        Me.pnlSearchIcon.Name = "pnlSearchIcon"
        Me.pnlSearchIcon.Size = New System.Drawing.Size(43, 40)
        Me.pnlSearchIcon.TabIndex = 55
        '
        'pnlAddIcon
        '
        Me.pnlAddIcon.BackgroundImage = CType(resources.GetObject("pnlAddIcon.BackgroundImage"), System.Drawing.Image)
        Me.pnlAddIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlAddIcon.Location = New System.Drawing.Point(681, 103)
        Me.pnlAddIcon.Name = "pnlAddIcon"
        Me.pnlAddIcon.Size = New System.Drawing.Size(37, 34)
        Me.pnlAddIcon.TabIndex = 54
        '
        'txtbxSearch
        '
        Me.txtbxSearch.Location = New System.Drawing.Point(807, 110)
        Me.txtbxSearch.Name = "txtbxSearch"
        Me.txtbxSearch.Size = New System.Drawing.Size(181, 20)
        Me.txtbxSearch.TabIndex = 53
        Me.txtbxSearch.Text = "Search"
        '
        'pnlLineCover
        '
        Me.pnlLineCover.Location = New System.Drawing.Point(0, 96)
        Me.pnlLineCover.Name = "pnlLineCover"
        Me.pnlLineCover.Size = New System.Drawing.Size(1011, 5)
        Me.pnlLineCover.TabIndex = 56
        '
        'frmSShooters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 492)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlLineCover)
        Me.Controls.Add(Me.pnlSearchIcon)
        Me.Controls.Add(Me.pnlAddIcon)
        Me.Controls.Add(Me.txtbxSearch)
        Me.Controls.Add(Me.pnlTitle)
        Me.Controls.Add(Me.playersPanel)
        Me.Controls.Add(Me.btnSquads)
        Me.Controls.Add(Me.btnLocations)
        Me.Controls.Add(Me.btnShooters)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ShapeContainer2)
        Me.Name = "frmSShooters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlDetailContainer.ResumeLayout(False)
        Me.pnlDetailContainer.PerformLayout()
        Me.pnlSaveContainer.ResumeLayout(False)
        Me.pnlSaveContainer.PerformLayout()
        Me.playersPanel.ResumeLayout(False)
        Me.pnlRegisteredShootersContainer.ResumeLayout(False)
        Me.pnlRegisteredShootersContainer.PerformLayout()
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents pnlDetailContainer As System.Windows.Forms.Panel
    Friend WithEvents txtbxNotes As System.Windows.Forms.TextBox
    Friend WithEvents txtbxEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtbxLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtbxGradeLevel As System.Windows.Forms.TextBox
    Friend WithEvents txtbxPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtbxFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblSquad As System.Windows.Forms.Label
    Friend WithEvents lblGradeLevel As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents playersPanel As System.Windows.Forms.Panel
    Friend WithEvents listShooters As System.Windows.Forms.ListBox
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblSetup As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnSquads As System.Windows.Forms.Button
    Friend WithEvents btnLocations As System.Windows.Forms.Button
    Friend WithEvents btnShooters As System.Windows.Forms.Button
    Friend WithEvents cmbbxSquad As System.Windows.Forms.ComboBox
    Friend WithEvents shapeLine As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents pnlSaveContainer As System.Windows.Forms.Panel
    Friend WithEvents lblSave As System.Windows.Forms.Label
    Friend WithEvents pnlSaveIcon As System.Windows.Forms.Panel
    Friend WithEvents pnlSearchIcon As System.Windows.Forms.Panel
    Friend WithEvents pnlAddIcon As System.Windows.Forms.Panel
    Friend WithEvents txtbxSearch As System.Windows.Forms.TextBox
    Friend WithEvents pnlLineCover As System.Windows.Forms.Panel
    Friend WithEvents lblDetails As System.Windows.Forms.Label
    Friend WithEvents pnlRegisteredShootersContainer As System.Windows.Forms.Panel
    Friend WithEvents lblRegisteredShooters As System.Windows.Forms.Label
End Class
