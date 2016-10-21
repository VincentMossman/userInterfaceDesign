<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSquads
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSquads))
        Me.pnlDetailContainer = New System.Windows.Forms.Panel()
        Me.pnlSaveContainer = New System.Windows.Forms.Panel()
        Me.lblSave = New System.Windows.Forms.Label()
        Me.pnlSaveIcon = New System.Windows.Forms.Panel()
        Me.btnShooter5Cancel = New System.Windows.Forms.Button()
        Me.btnShooter4Cancel = New System.Windows.Forms.Button()
        Me.btnShooter3Cancel = New System.Windows.Forms.Button()
        Me.btnShooter2Cancel = New System.Windows.Forms.Button()
        Me.btnShooter1Cancel = New System.Windows.Forms.Button()
        Me.lblShooters = New System.Windows.Forms.Label()
        Me.txtbxNotes = New System.Windows.Forms.TextBox()
        Me.txtbxShooter2 = New System.Windows.Forms.TextBox()
        Me.txtbxShooter3 = New System.Windows.Forms.TextBox()
        Me.txtbxShooter4 = New System.Windows.Forms.TextBox()
        Me.txtbxShooter5 = New System.Windows.Forms.TextBox()
        Me.txtbxShooter1 = New System.Windows.Forms.TextBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.lblShooter5 = New System.Windows.Forms.Label()
        Me.lblShooter4 = New System.Windows.Forms.Label()
        Me.lblShooter3 = New System.Windows.Forms.Label()
        Me.lblShooter2 = New System.Windows.Forms.Label()
        Me.lblShooter1 = New System.Windows.Forms.Label()
        Me.pnlShooters = New System.Windows.Forms.Panel()
        Me.listSquads = New System.Windows.Forms.ListBox()
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
        Me.pnlLineCover = New System.Windows.Forms.Panel()
        Me.txtbxSearch = New System.Windows.Forms.TextBox()
        Me.pnlDetailContainer.SuspendLayout()
        Me.pnlSaveContainer.SuspendLayout()
        Me.pnlShooters.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDetailContainer
        '
        Me.pnlDetailContainer.BackColor = System.Drawing.Color.Silver
        Me.pnlDetailContainer.Controls.Add(Me.pnlSaveContainer)
        Me.pnlDetailContainer.Controls.Add(Me.btnShooter5Cancel)
        Me.pnlDetailContainer.Controls.Add(Me.btnShooter4Cancel)
        Me.pnlDetailContainer.Controls.Add(Me.btnShooter3Cancel)
        Me.pnlDetailContainer.Controls.Add(Me.btnShooter2Cancel)
        Me.pnlDetailContainer.Controls.Add(Me.btnShooter1Cancel)
        Me.pnlDetailContainer.Controls.Add(Me.lblShooters)
        Me.pnlDetailContainer.Controls.Add(Me.txtbxNotes)
        Me.pnlDetailContainer.Controls.Add(Me.txtbxShooter2)
        Me.pnlDetailContainer.Controls.Add(Me.txtbxShooter3)
        Me.pnlDetailContainer.Controls.Add(Me.txtbxShooter4)
        Me.pnlDetailContainer.Controls.Add(Me.txtbxShooter5)
        Me.pnlDetailContainer.Controls.Add(Me.txtbxShooter1)
        Me.pnlDetailContainer.Controls.Add(Me.lblNotes)
        Me.pnlDetailContainer.Controls.Add(Me.lblShooter5)
        Me.pnlDetailContainer.Controls.Add(Me.lblShooter4)
        Me.pnlDetailContainer.Controls.Add(Me.lblShooter3)
        Me.pnlDetailContainer.Controls.Add(Me.lblShooter2)
        Me.pnlDetailContainer.Controls.Add(Me.lblShooter1)
        Me.pnlDetailContainer.Location = New System.Drawing.Point(371, 0)
        Me.pnlDetailContainer.Name = "pnlDetailContainer"
        Me.pnlDetailContainer.Size = New System.Drawing.Size(641, 364)
        Me.pnlDetailContainer.TabIndex = 25
        '
        'pnlSaveContainer
        '
        Me.pnlSaveContainer.Controls.Add(Me.lblSave)
        Me.pnlSaveContainer.Controls.Add(Me.pnlSaveIcon)
        Me.pnlSaveContainer.Location = New System.Drawing.Point(482, 286)
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
        'btnShooter5Cancel
        '
        Me.btnShooter5Cancel.BackColor = System.Drawing.Color.Red
        Me.btnShooter5Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShooter5Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShooter5Cancel.Location = New System.Drawing.Point(471, 169)
        Me.btnShooter5Cancel.Name = "btnShooter5Cancel"
        Me.btnShooter5Cancel.Size = New System.Drawing.Size(25, 25)
        Me.btnShooter5Cancel.TabIndex = 21
        Me.btnShooter5Cancel.Text = "X"
        Me.btnShooter5Cancel.UseVisualStyleBackColor = False
        '
        'btnShooter4Cancel
        '
        Me.btnShooter4Cancel.BackColor = System.Drawing.Color.Red
        Me.btnShooter4Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShooter4Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShooter4Cancel.Location = New System.Drawing.Point(471, 140)
        Me.btnShooter4Cancel.Name = "btnShooter4Cancel"
        Me.btnShooter4Cancel.Size = New System.Drawing.Size(25, 25)
        Me.btnShooter4Cancel.TabIndex = 20
        Me.btnShooter4Cancel.Text = "X"
        Me.btnShooter4Cancel.UseVisualStyleBackColor = False
        '
        'btnShooter3Cancel
        '
        Me.btnShooter3Cancel.BackColor = System.Drawing.Color.Red
        Me.btnShooter3Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShooter3Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShooter3Cancel.Location = New System.Drawing.Point(471, 108)
        Me.btnShooter3Cancel.Name = "btnShooter3Cancel"
        Me.btnShooter3Cancel.Size = New System.Drawing.Size(25, 25)
        Me.btnShooter3Cancel.TabIndex = 19
        Me.btnShooter3Cancel.Text = "X"
        Me.btnShooter3Cancel.UseVisualStyleBackColor = False
        '
        'btnShooter2Cancel
        '
        Me.btnShooter2Cancel.BackColor = System.Drawing.Color.Red
        Me.btnShooter2Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShooter2Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShooter2Cancel.Location = New System.Drawing.Point(471, 77)
        Me.btnShooter2Cancel.Name = "btnShooter2Cancel"
        Me.btnShooter2Cancel.Size = New System.Drawing.Size(25, 25)
        Me.btnShooter2Cancel.TabIndex = 18
        Me.btnShooter2Cancel.Text = "X"
        Me.btnShooter2Cancel.UseVisualStyleBackColor = False
        '
        'btnShooter1Cancel
        '
        Me.btnShooter1Cancel.BackColor = System.Drawing.Color.Red
        Me.btnShooter1Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShooter1Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShooter1Cancel.Location = New System.Drawing.Point(471, 44)
        Me.btnShooter1Cancel.Name = "btnShooter1Cancel"
        Me.btnShooter1Cancel.Size = New System.Drawing.Size(25, 25)
        Me.btnShooter1Cancel.TabIndex = 17
        Me.btnShooter1Cancel.Text = "X"
        Me.btnShooter1Cancel.UseVisualStyleBackColor = False
        '
        'lblShooters
        '
        Me.lblShooters.AutoSize = True
        Me.lblShooters.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShooters.Location = New System.Drawing.Point(58, 19)
        Me.lblShooters.Name = "lblShooters"
        Me.lblShooters.Size = New System.Drawing.Size(82, 20)
        Me.lblShooters.TabIndex = 14
        Me.lblShooters.Text = "Shooters"
        '
        'txtbxNotes
        '
        Me.txtbxNotes.Location = New System.Drawing.Point(225, 202)
        Me.txtbxNotes.Multiline = True
        Me.txtbxNotes.Name = "txtbxNotes"
        Me.txtbxNotes.Size = New System.Drawing.Size(325, 69)
        Me.txtbxNotes.TabIndex = 13
        '
        'txtbxShooter2
        '
        Me.txtbxShooter2.Location = New System.Drawing.Point(225, 81)
        Me.txtbxShooter2.Name = "txtbxShooter2"
        Me.txtbxShooter2.Size = New System.Drawing.Size(228, 20)
        Me.txtbxShooter2.TabIndex = 11
        '
        'txtbxShooter3
        '
        Me.txtbxShooter3.Location = New System.Drawing.Point(225, 112)
        Me.txtbxShooter3.Name = "txtbxShooter3"
        Me.txtbxShooter3.Size = New System.Drawing.Size(228, 20)
        Me.txtbxShooter3.TabIndex = 10
        '
        'txtbxShooter4
        '
        Me.txtbxShooter4.Location = New System.Drawing.Point(225, 143)
        Me.txtbxShooter4.Name = "txtbxShooter4"
        Me.txtbxShooter4.Size = New System.Drawing.Size(228, 20)
        Me.txtbxShooter4.TabIndex = 9
        '
        'txtbxShooter5
        '
        Me.txtbxShooter5.Location = New System.Drawing.Point(225, 172)
        Me.txtbxShooter5.Name = "txtbxShooter5"
        Me.txtbxShooter5.Size = New System.Drawing.Size(228, 20)
        Me.txtbxShooter5.TabIndex = 8
        '
        'txtbxShooter1
        '
        Me.txtbxShooter1.Location = New System.Drawing.Point(225, 48)
        Me.txtbxShooter1.Name = "txtbxShooter1"
        Me.txtbxShooter1.Size = New System.Drawing.Size(228, 20)
        Me.txtbxShooter1.TabIndex = 7
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.Location = New System.Drawing.Point(111, 202)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(48, 18)
        Me.lblNotes.TabIndex = 6
        Me.lblNotes.Text = "Notes"
        '
        'lblShooter5
        '
        Me.lblShooter5.AutoSize = True
        Me.lblShooter5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShooter5.Location = New System.Drawing.Point(111, 172)
        Me.lblShooter5.Name = "lblShooter5"
        Me.lblShooter5.Size = New System.Drawing.Size(73, 18)
        Me.lblShooter5.TabIndex = 5
        Me.lblShooter5.Text = "Shooter 5"
        '
        'lblShooter4
        '
        Me.lblShooter4.AutoSize = True
        Me.lblShooter4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShooter4.Location = New System.Drawing.Point(111, 143)
        Me.lblShooter4.Name = "lblShooter4"
        Me.lblShooter4.Size = New System.Drawing.Size(73, 18)
        Me.lblShooter4.TabIndex = 3
        Me.lblShooter4.Text = "Shooter 4"
        '
        'lblShooter3
        '
        Me.lblShooter3.AutoSize = True
        Me.lblShooter3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShooter3.Location = New System.Drawing.Point(111, 112)
        Me.lblShooter3.Name = "lblShooter3"
        Me.lblShooter3.Size = New System.Drawing.Size(73, 18)
        Me.lblShooter3.TabIndex = 2
        Me.lblShooter3.Text = "Shooter 3"
        '
        'lblShooter2
        '
        Me.lblShooter2.AutoSize = True
        Me.lblShooter2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShooter2.Location = New System.Drawing.Point(111, 81)
        Me.lblShooter2.Name = "lblShooter2"
        Me.lblShooter2.Size = New System.Drawing.Size(73, 18)
        Me.lblShooter2.TabIndex = 1
        Me.lblShooter2.Text = "Shooter 2"
        '
        'lblShooter1
        '
        Me.lblShooter1.AutoSize = True
        Me.lblShooter1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShooter1.Location = New System.Drawing.Point(111, 51)
        Me.lblShooter1.Name = "lblShooter1"
        Me.lblShooter1.Size = New System.Drawing.Size(73, 18)
        Me.lblShooter1.TabIndex = 0
        Me.lblShooter1.Text = "Shooter 1"
        '
        'pnlShooters
        '
        Me.pnlShooters.Controls.Add(Me.listSquads)
        Me.pnlShooters.Controls.Add(Me.pnlDetailContainer)
        Me.pnlShooters.Location = New System.Drawing.Point(-2, 139)
        Me.pnlShooters.Name = "pnlShooters"
        Me.pnlShooters.Size = New System.Drawing.Size(1012, 355)
        Me.pnlShooters.TabIndex = 33
        '
        'listSquads
        '
        Me.listSquads.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listSquads.FormattingEnabled = True
        Me.listSquads.ItemHeight = 24
        Me.listSquads.Items.AddRange(New Object() {"Main", "Second", "Beginners"})
        Me.listSquads.Location = New System.Drawing.Point(0, 0)
        Me.listSquads.Name = "listSquads"
        Me.listSquads.Size = New System.Drawing.Size(372, 364)
        Me.listSquads.TabIndex = 29
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlTitle.Controls.Add(Me.lblSetup)
        Me.pnlTitle.Controls.Add(Me.btnBack)
        Me.pnlTitle.Location = New System.Drawing.Point(-1, -1)
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
        Me.btnSquads.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSquads.Enabled = False
        Me.btnSquads.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSquads.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSquads.Location = New System.Drawing.Point(672, 40)
        Me.btnSquads.Name = "btnSquads"
        Me.btnSquads.Size = New System.Drawing.Size(340, 59)
        Me.btnSquads.TabIndex = 47
        Me.btnSquads.Text = "Squads"
        Me.btnSquads.UseVisualStyleBackColor = False
        '
        'btnLocations
        '
        Me.btnLocations.BackColor = System.Drawing.Color.LightGreen
        Me.btnLocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLocations.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocations.Location = New System.Drawing.Point(336, 40)
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
        Me.btnShooters.Location = New System.Drawing.Point(0, 40)
        Me.btnShooters.Margin = New System.Windows.Forms.Padding(0)
        Me.btnShooters.Name = "btnShooters"
        Me.btnShooters.Size = New System.Drawing.Size(340, 59)
        Me.btnShooters.TabIndex = 45
        Me.btnShooters.Text = "Shooters"
        Me.btnShooters.UseVisualStyleBackColor = False
        '
        'shapeLine
        '
        Me.shapeLine.Name = "shapeLine"
        Me.shapeLine.X1 = 737
        Me.shapeLine.X2 = 737
        Me.shapeLine.Y1 = 103
        Me.shapeLine.Y2 = 132
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.shapeLine})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1008, 492)
        Me.ShapeContainer2.TabIndex = 52
        Me.ShapeContainer2.TabStop = False
        '
        'pnlSearchIcon
        '
        Me.pnlSearchIcon.BackgroundImage = CType(resources.GetObject("pnlSearchIcon.BackgroundImage"), System.Drawing.Image)
        Me.pnlSearchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlSearchIcon.Location = New System.Drawing.Point(757, 99)
        Me.pnlSearchIcon.Name = "pnlSearchIcon"
        Me.pnlSearchIcon.Size = New System.Drawing.Size(43, 40)
        Me.pnlSearchIcon.TabIndex = 55
        '
        'pnlAddIcon
        '
        Me.pnlAddIcon.BackgroundImage = CType(resources.GetObject("pnlAddIcon.BackgroundImage"), System.Drawing.Image)
        Me.pnlAddIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlAddIcon.Location = New System.Drawing.Point(680, 102)
        Me.pnlAddIcon.Name = "pnlAddIcon"
        Me.pnlAddIcon.Size = New System.Drawing.Size(37, 34)
        Me.pnlAddIcon.TabIndex = 54
        '
        'pnlLineCover
        '
        Me.pnlLineCover.Location = New System.Drawing.Point(0, 95)
        Me.pnlLineCover.Name = "pnlLineCover"
        Me.pnlLineCover.Size = New System.Drawing.Size(1011, 5)
        Me.pnlLineCover.TabIndex = 56
        '
        'txtbxSearch
        '
        Me.txtbxSearch.Location = New System.Drawing.Point(806, 109)
        Me.txtbxSearch.Name = "txtbxSearch"
        Me.txtbxSearch.Size = New System.Drawing.Size(181, 20)
        Me.txtbxSearch.TabIndex = 44
        Me.txtbxSearch.Text = "Search"
        '
        'frmSquads
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 492)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlLineCover)
        Me.Controls.Add(Me.pnlSearchIcon)
        Me.Controls.Add(Me.pnlAddIcon)
        Me.Controls.Add(Me.pnlShooters)
        Me.Controls.Add(Me.pnlTitle)
        Me.Controls.Add(Me.btnShooters)
        Me.Controls.Add(Me.btnSquads)
        Me.Controls.Add(Me.txtbxSearch)
        Me.Controls.Add(Me.btnLocations)
        Me.Controls.Add(Me.ShapeContainer2)
        Me.Name = "frmSquads"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlDetailContainer.ResumeLayout(False)
        Me.pnlDetailContainer.PerformLayout()
        Me.pnlSaveContainer.ResumeLayout(False)
        Me.pnlSaveContainer.PerformLayout()
        Me.pnlShooters.ResumeLayout(False)
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlDetailContainer As System.Windows.Forms.Panel
    Friend WithEvents txtbxNotes As System.Windows.Forms.TextBox
    Friend WithEvents txtbxShooter2 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxShooter3 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxShooter4 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxShooter5 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxShooter1 As System.Windows.Forms.TextBox
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents lblShooter5 As System.Windows.Forms.Label
    Friend WithEvents lblShooter4 As System.Windows.Forms.Label
    Friend WithEvents lblShooter3 As System.Windows.Forms.Label
    Friend WithEvents lblShooter2 As System.Windows.Forms.Label
    Friend WithEvents lblShooter1 As System.Windows.Forms.Label
    Friend WithEvents pnlShooters As System.Windows.Forms.Panel
    Friend WithEvents listSquads As System.Windows.Forms.ListBox
    Friend WithEvents lblShooters As System.Windows.Forms.Label
    Friend WithEvents btnShooter5Cancel As System.Windows.Forms.Button
    Friend WithEvents btnShooter4Cancel As System.Windows.Forms.Button
    Friend WithEvents btnShooter3Cancel As System.Windows.Forms.Button
    Friend WithEvents btnShooter2Cancel As System.Windows.Forms.Button
    Friend WithEvents btnShooter1Cancel As System.Windows.Forms.Button
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblSetup As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnSquads As System.Windows.Forms.Button
    Friend WithEvents btnLocations As System.Windows.Forms.Button
    Friend WithEvents btnShooters As System.Windows.Forms.Button
    Friend WithEvents shapeLine As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents pnlSaveContainer As System.Windows.Forms.Panel
    Friend WithEvents lblSave As System.Windows.Forms.Label
    Friend WithEvents pnlSaveIcon As System.Windows.Forms.Panel
    Friend WithEvents pnlSearchIcon As System.Windows.Forms.Panel
    Friend WithEvents pnlAddIcon As System.Windows.Forms.Panel
    Friend WithEvents pnlLineCover As System.Windows.Forms.Panel
    Friend WithEvents txtbxSearch As System.Windows.Forms.TextBox
End Class
