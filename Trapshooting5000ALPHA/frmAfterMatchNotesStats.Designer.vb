<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAfterMatchNotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAfterMatchNotes))
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtbxNotes = New System.Windows.Forms.TextBox()
        Me.lblGameStats = New System.Windows.Forms.Label()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblAfterMatch = New System.Windows.Forms.Label()
        Me.dataGameStats = New System.Windows.Forms.DataGridView()
        Me.playerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POS2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POS3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POS4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POS5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlFinishIcon = New System.Windows.Forms.Panel()
        Me.pnlFinishContainer = New System.Windows.Forms.Panel()
        Me.lblFinish = New System.Windows.Forms.Label()
        Me.pnlTitle.SuspendLayout()
        CType(Me.dataGameStats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFinishContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.Location = New System.Drawing.Point(28, 65)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(51, 20)
        Me.lblNotes.TabIndex = 0
        Me.lblNotes.Text = "Notes"
        '
        'txtbxNotes
        '
        Me.txtbxNotes.Location = New System.Drawing.Point(32, 101)
        Me.txtbxNotes.Multiline = True
        Me.txtbxNotes.Name = "txtbxNotes"
        Me.txtbxNotes.Size = New System.Drawing.Size(434, 323)
        Me.txtbxNotes.TabIndex = 1
        '
        'lblGameStats
        '
        Me.lblGameStats.AutoSize = True
        Me.lblGameStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameStats.Location = New System.Drawing.Point(501, 65)
        Me.lblGameStats.Name = "lblGameStats"
        Me.lblGameStats.Size = New System.Drawing.Size(95, 20)
        Me.lblGameStats.TabIndex = 2
        Me.lblGameStats.Text = "Game Stats"
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlTitle.Controls.Add(Me.lblAfterMatch)
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(1010, 42)
        Me.pnlTitle.TabIndex = 5
        '
        'lblAfterMatch
        '
        Me.lblAfterMatch.AutoSize = True
        Me.lblAfterMatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAfterMatch.Location = New System.Drawing.Point(81, 9)
        Me.lblAfterMatch.Name = "lblAfterMatch"
        Me.lblAfterMatch.Size = New System.Drawing.Size(104, 24)
        Me.lblAfterMatch.TabIndex = 30
        Me.lblAfterMatch.Text = "After Match"
        '
        'dataGameStats
        '
        Me.dataGameStats.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dataGameStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGameStats.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.playerName, Me.POS1, Me.POS2, Me.POS3, Me.POS4, Me.POS5, Me.TOTAL})
        Me.dataGameStats.Location = New System.Drawing.Point(493, 101)
        Me.dataGameStats.Name = "dataGameStats"
        Me.dataGameStats.Size = New System.Drawing.Size(491, 323)
        Me.dataGameStats.TabIndex = 6
        '
        'playerName
        '
        Me.playerName.HeaderText = "Name"
        Me.playerName.Name = "playerName"
        Me.playerName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.playerName.Width = 150
        '
        'POS1
        '
        Me.POS1.HeaderText = "POS 1"
        Me.POS1.Name = "POS1"
        Me.POS1.Width = 50
        '
        'POS2
        '
        Me.POS2.HeaderText = "POS 2"
        Me.POS2.Name = "POS2"
        Me.POS2.Width = 50
        '
        'POS3
        '
        Me.POS3.HeaderText = "POS 3"
        Me.POS3.Name = "POS3"
        Me.POS3.Width = 50
        '
        'POS4
        '
        Me.POS4.HeaderText = "POS 4"
        Me.POS4.Name = "POS4"
        Me.POS4.Width = 50
        '
        'POS5
        '
        Me.POS5.HeaderText = "POS 5"
        Me.POS5.Name = "POS5"
        Me.POS5.Width = 50
        '
        'TOTAL
        '
        Me.TOTAL.HeaderText = "TOTAL"
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.Width = 50
        '
        'pnlFinishIcon
        '
        Me.pnlFinishIcon.BackgroundImage = CType(resources.GetObject("pnlFinishIcon.BackgroundImage"), System.Drawing.Image)
        Me.pnlFinishIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlFinishIcon.Location = New System.Drawing.Point(1, 0)
        Me.pnlFinishIcon.Name = "pnlFinishIcon"
        Me.pnlFinishIcon.Size = New System.Drawing.Size(65, 57)
        Me.pnlFinishIcon.TabIndex = 7
        '
        'pnlFinishContainer
        '
        Me.pnlFinishContainer.Controls.Add(Me.lblFinish)
        Me.pnlFinishContainer.Controls.Add(Me.pnlFinishIcon)
        Me.pnlFinishContainer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlFinishContainer.Location = New System.Drawing.Point(830, 430)
        Me.pnlFinishContainer.Name = "pnlFinishContainer"
        Me.pnlFinishContainer.Size = New System.Drawing.Size(138, 57)
        Me.pnlFinishContainer.TabIndex = 8
        '
        'lblFinish
        '
        Me.lblFinish.AutoSize = True
        Me.lblFinish.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinish.Location = New System.Drawing.Point(67, 15)
        Me.lblFinish.Name = "lblFinish"
        Me.lblFinish.Size = New System.Drawing.Size(61, 24)
        Me.lblFinish.TabIndex = 8
        Me.lblFinish.Text = "Finish"
        '
        'frmAfterMatchNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 492)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlFinishContainer)
        Me.Controls.Add(Me.dataGameStats)
        Me.Controls.Add(Me.pnlTitle)
        Me.Controls.Add(Me.lblGameStats)
        Me.Controls.Add(Me.txtbxNotes)
        Me.Controls.Add(Me.lblNotes)
        Me.Name = "frmAfterMatchNotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        CType(Me.dataGameStats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFinishContainer.ResumeLayout(False)
        Me.pnlFinishContainer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents txtbxNotes As System.Windows.Forms.TextBox
    Friend WithEvents lblGameStats As System.Windows.Forms.Label
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblAfterMatch As System.Windows.Forms.Label
    Friend WithEvents dataGameStats As System.Windows.Forms.DataGridView
    Friend WithEvents names As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents names1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlFinishIcon As System.Windows.Forms.Panel
    Friend WithEvents pnlFinishContainer As System.Windows.Forms.Panel
    Friend WithEvents lblFinish As System.Windows.Forms.Label
    Friend WithEvents playerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POS2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POS3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POS4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POS5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
