<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreMatch2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreMatch2))
        Me.pnlDetailContainer = New System.Windows.Forms.Panel()
        Me.pnlNext = New System.Windows.Forms.Panel()
        Me.listLocations = New System.Windows.Forms.ListBox()
        Me.rdoNo = New System.Windows.Forms.RadioButton()
        Me.rdoYes = New System.Windows.Forms.RadioButton()
        Me.numNumRounds = New System.Windows.Forms.NumericUpDown()
        Me.lblNumberOfRounds = New System.Windows.Forms.Label()
        Me.txtbxNotes = New System.Windows.Forms.TextBox()
        Me.txtbxEventDescription = New System.Windows.Forms.TextBox()
        Me.txtbxCurrentLocation = New System.Windows.Forms.TextBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.lblPractice = New System.Windows.Forms.Label()
        Me.lblEventDescription = New System.Windows.Forms.Label()
        Me.lblCurrentLocation = New System.Windows.Forms.Label()
        Me.btnLocations = New System.Windows.Forms.Button()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblSelectLocation = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnShooters = New System.Windows.Forms.Button()
        Me.pnlLineCover = New System.Windows.Forms.Panel()
        Me.pnlDetailContainer.SuspendLayout()
        CType(Me.numNumRounds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDetailContainer
        '
        Me.pnlDetailContainer.BackColor = System.Drawing.Color.Silver
        Me.pnlDetailContainer.Controls.Add(Me.pnlNext)
        Me.pnlDetailContainer.Controls.Add(Me.listLocations)
        Me.pnlDetailContainer.Controls.Add(Me.rdoNo)
        Me.pnlDetailContainer.Controls.Add(Me.rdoYes)
        Me.pnlDetailContainer.Controls.Add(Me.numNumRounds)
        Me.pnlDetailContainer.Controls.Add(Me.lblNumberOfRounds)
        Me.pnlDetailContainer.Controls.Add(Me.txtbxNotes)
        Me.pnlDetailContainer.Controls.Add(Me.txtbxEventDescription)
        Me.pnlDetailContainer.Controls.Add(Me.txtbxCurrentLocation)
        Me.pnlDetailContainer.Controls.Add(Me.lblNotes)
        Me.pnlDetailContainer.Controls.Add(Me.lblPractice)
        Me.pnlDetailContainer.Controls.Add(Me.lblEventDescription)
        Me.pnlDetailContainer.Controls.Add(Me.lblCurrentLocation)
        Me.pnlDetailContainer.Location = New System.Drawing.Point(0, 143)
        Me.pnlDetailContainer.Name = "pnlDetailContainer"
        Me.pnlDetailContainer.Size = New System.Drawing.Size(1008, 349)
        Me.pnlDetailContainer.TabIndex = 3
        '
        'pnlNext
        '
        Me.pnlNext.BackgroundImage = CType(resources.GetObject("pnlNext.BackgroundImage"), System.Drawing.Image)
        Me.pnlNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlNext.Location = New System.Drawing.Point(895, 145)
        Me.pnlNext.Name = "pnlNext"
        Me.pnlNext.Size = New System.Drawing.Size(101, 81)
        Me.pnlNext.TabIndex = 32
        '
        'listLocations
        '
        Me.listLocations.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listLocations.FormattingEnabled = True
        Me.listLocations.ItemHeight = 24
        Me.listLocations.Items.AddRange(New Object() {"Ackley", "Cedar Falls", "Davenport", "Independence", "Steamboat Rock", "Waukee", "West Delaware"})
        Me.listLocations.Location = New System.Drawing.Point(1, 1)
        Me.listLocations.Name = "listLocations"
        Me.listLocations.Size = New System.Drawing.Size(408, 412)
        Me.listLocations.TabIndex = 18
        '
        'rdoNo
        '
        Me.rdoNo.AutoSize = True
        Me.rdoNo.Location = New System.Drawing.Point(694, 124)
        Me.rdoNo.Name = "rdoNo"
        Me.rdoNo.Size = New System.Drawing.Size(39, 17)
        Me.rdoNo.TabIndex = 17
        Me.rdoNo.Text = "No"
        Me.rdoNo.UseVisualStyleBackColor = True
        '
        'rdoYes
        '
        Me.rdoYes.AutoSize = True
        Me.rdoYes.Checked = True
        Me.rdoYes.Location = New System.Drawing.Point(645, 123)
        Me.rdoYes.Name = "rdoYes"
        Me.rdoYes.Size = New System.Drawing.Size(43, 17)
        Me.rdoYes.TabIndex = 16
        Me.rdoYes.TabStop = True
        Me.rdoYes.Text = "Yes"
        Me.rdoYes.UseVisualStyleBackColor = True
        '
        'numNumRounds
        '
        Me.numNumRounds.Location = New System.Drawing.Point(645, 276)
        Me.numNumRounds.Name = "numNumRounds"
        Me.numNumRounds.Size = New System.Drawing.Size(44, 20)
        Me.numNumRounds.TabIndex = 15
        Me.numNumRounds.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'lblNumberOfRounds
        '
        Me.lblNumberOfRounds.AutoSize = True
        Me.lblNumberOfRounds.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfRounds.Location = New System.Drawing.Point(452, 273)
        Me.lblNumberOfRounds.Name = "lblNumberOfRounds"
        Me.lblNumberOfRounds.Size = New System.Drawing.Size(163, 24)
        Me.lblNumberOfRounds.TabIndex = 14
        Me.lblNumberOfRounds.Text = "Number of rounds"
        '
        'txtbxNotes
        '
        Me.txtbxNotes.Location = New System.Drawing.Point(645, 165)
        Me.txtbxNotes.Multiline = True
        Me.txtbxNotes.Name = "txtbxNotes"
        Me.txtbxNotes.Size = New System.Drawing.Size(220, 94)
        Me.txtbxNotes.TabIndex = 13
        '
        'txtbxEventDescription
        '
        Me.txtbxEventDescription.Location = New System.Drawing.Point(645, 76)
        Me.txtbxEventDescription.Name = "txtbxEventDescription"
        Me.txtbxEventDescription.Size = New System.Drawing.Size(220, 20)
        Me.txtbxEventDescription.TabIndex = 12
        '
        'txtbxCurrentLocation
        '
        Me.txtbxCurrentLocation.Location = New System.Drawing.Point(645, 33)
        Me.txtbxCurrentLocation.Name = "txtbxCurrentLocation"
        Me.txtbxCurrentLocation.Size = New System.Drawing.Size(220, 20)
        Me.txtbxCurrentLocation.TabIndex = 11
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.Location = New System.Drawing.Point(452, 161)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(59, 24)
        Me.lblNotes.TabIndex = 10
        Me.lblNotes.Text = "Notes"
        '
        'lblPractice
        '
        Me.lblPractice.AutoSize = True
        Me.lblPractice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPractice.Location = New System.Drawing.Point(452, 117)
        Me.lblPractice.Name = "lblPractice"
        Me.lblPractice.Size = New System.Drawing.Size(87, 24)
        Me.lblPractice.TabIndex = 9
        Me.lblPractice.Text = "Practice?"
        '
        'lblEventDescription
        '
        Me.lblEventDescription.AutoSize = True
        Me.lblEventDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventDescription.Location = New System.Drawing.Point(452, 72)
        Me.lblEventDescription.Name = "lblEventDescription"
        Me.lblEventDescription.Size = New System.Drawing.Size(157, 24)
        Me.lblEventDescription.TabIndex = 8
        Me.lblEventDescription.Text = "Event Description"
        '
        'lblCurrentLocation
        '
        Me.lblCurrentLocation.AutoSize = True
        Me.lblCurrentLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentLocation.Location = New System.Drawing.Point(452, 29)
        Me.lblCurrentLocation.Name = "lblCurrentLocation"
        Me.lblCurrentLocation.Size = New System.Drawing.Size(148, 24)
        Me.lblCurrentLocation.TabIndex = 7
        Me.lblCurrentLocation.Text = "Current Location"
        '
        'btnLocations
        '
        Me.btnLocations.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLocations.Enabled = False
        Me.btnLocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLocations.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocations.Location = New System.Drawing.Point(519, 42)
        Me.btnLocations.Name = "btnLocations"
        Me.btnLocations.Size = New System.Drawing.Size(490, 59)
        Me.btnLocations.TabIndex = 58
        Me.btnLocations.Text = "Locations"
        Me.btnLocations.UseVisualStyleBackColor = False
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlTitle.Controls.Add(Me.lblSelectLocation)
        Me.pnlTitle.Controls.Add(Me.btnBack)
        Me.pnlTitle.Location = New System.Drawing.Point(1, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(1012, 42)
        Me.pnlTitle.TabIndex = 56
        '
        'lblSelectLocation
        '
        Me.lblSelectLocation.AutoSize = True
        Me.lblSelectLocation.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSelectLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectLocation.Location = New System.Drawing.Point(82, 9)
        Me.lblSelectLocation.Name = "lblSelectLocation"
        Me.lblSelectLocation.Size = New System.Drawing.Size(138, 24)
        Me.lblSelectLocation.TabIndex = 30
        Me.lblSelectLocation.Text = "Select Location"
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
        'btnShooters
        '
        Me.btnShooters.BackColor = System.Drawing.Color.LightGreen
        Me.btnShooters.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShooters.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShooters.Location = New System.Drawing.Point(-1, 42)
        Me.btnShooters.Margin = New System.Windows.Forms.Padding(0)
        Me.btnShooters.Name = "btnShooters"
        Me.btnShooters.Size = New System.Drawing.Size(522, 59)
        Me.btnShooters.TabIndex = 57
        Me.btnShooters.Text = "Shooters"
        Me.btnShooters.UseVisualStyleBackColor = False
        '
        'pnlLineCover
        '
        Me.pnlLineCover.Location = New System.Drawing.Point(1, 97)
        Me.pnlLineCover.Name = "pnlLineCover"
        Me.pnlLineCover.Size = New System.Drawing.Size(1011, 5)
        Me.pnlLineCover.TabIndex = 59
        '
        'frmPreMatch2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 492)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlLineCover)
        Me.Controls.Add(Me.btnLocations)
        Me.Controls.Add(Me.pnlDetailContainer)
        Me.Controls.Add(Me.pnlTitle)
        Me.Controls.Add(Me.btnShooters)
        Me.Name = "frmPreMatch2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlDetailContainer.ResumeLayout(False)
        Me.pnlDetailContainer.PerformLayout()
        CType(Me.numNumRounds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlDetailContainer As System.Windows.Forms.Panel
    Friend WithEvents numNumRounds As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblNumberOfRounds As System.Windows.Forms.Label
    Friend WithEvents txtbxNotes As System.Windows.Forms.TextBox
    Friend WithEvents txtbxEventDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtbxCurrentLocation As System.Windows.Forms.TextBox
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents lblPractice As System.Windows.Forms.Label
    Friend WithEvents lblEventDescription As System.Windows.Forms.Label
    Friend WithEvents lblCurrentLocation As System.Windows.Forms.Label
    Friend WithEvents rdoNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdoYes As System.Windows.Forms.RadioButton
    Friend WithEvents listLocations As System.Windows.Forms.ListBox
    Friend WithEvents btnLocations As System.Windows.Forms.Button
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblSelectLocation As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnShooters As System.Windows.Forms.Button
    Friend WithEvents pnlNext As System.Windows.Forms.Panel
    Friend WithEvents pnlLineCover As System.Windows.Forms.Panel
End Class
