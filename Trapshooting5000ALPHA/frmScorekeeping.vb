Public Class frmScorekeeping
    Dim shotnumber = 0
    Dim cyclenumber = 1
    Dim roundnumber = 1

    Private Sub btnHit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHit.Click
        lblHitOrMiss.Text = "Hit!"
        lblHitOrMiss.Visible = True
    End Sub

    Private Sub btnMiss_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMiss.Click
        lblHitOrMiss.Text = "Miss!"
        lblHitOrMiss.Visible = True
    End Sub

    Private Sub frmScorekeeping_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnShooterPos1.Text = frmPreMatch.txtbxShooter1.Text
        btnShooterPos2.Text = frmPreMatch.txtbxShooter2.Text
        btnShooterPos3.Text = frmPreMatch.txtbxShooter3.Text
        btnShooterPos4.Text = frmPreMatch.txtbxShooter4.Text
        btnShooterPos5.Text = frmPreMatch.txtbxShooter5.Text
        lblRoundStatic.Text = "of " & frmPreMatch2.numNumRounds.Text
        lblHitOrMiss.Visible = False
        lblHard.Visible = False

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlNext.Click

        If lblHitOrMiss.Text = "Hit!" And lblHitOrMiss.Visible = True Then
            If shotnumber = 0 Then
                cb0.Checked = True
            ElseIf shotnumber = 1 Then
                cb1.Checked = True
            ElseIf shotnumber = 2 Then
                cb2.Checked = True
            ElseIf shotnumber = 3 Then
                cb3.Checked = True
            ElseIf shotnumber = 4 Then
                cb4.Checked = True
            ElseIf shotnumber = 5 Then
                cb5.Checked = True
            ElseIf shotnumber = 6 Then
                cb6.Checked = True
            ElseIf shotnumber = 7 Then
                cb7.Checked = True
            ElseIf shotnumber = 8 Then
                cb8.Checked = True
            ElseIf shotnumber = 9 Then
                cb9.Checked = True
            ElseIf shotnumber = 10 Then
                cb10.Checked = True
            ElseIf shotnumber = 11 Then
                cb11.Checked = True
            ElseIf shotnumber = 12 Then
                cb12.Checked = True
            ElseIf shotnumber = 13 Then
                cb13.Checked = True
            ElseIf shotnumber = 14 Then
                cb14.Checked = True
            ElseIf shotnumber = 15 Then
                cb15.Checked = True
            ElseIf shotnumber = 16 Then
                cb16.Checked = True
            ElseIf shotnumber = 17 Then
                cb17.Checked = True
            ElseIf shotnumber = 18 Then
                cb18.Checked = True
            ElseIf shotnumber = 19 Then
                cb19.Checked = True
            ElseIf shotnumber = 20 Then
                cb20.Checked = True
            ElseIf shotnumber = 21 Then
                cb21.Checked = True
            ElseIf shotnumber = 22 Then
                cb22.Checked = True
            ElseIf shotnumber = 23 Then
                cb23.Checked = True
            ElseIf shotnumber = 24 Then
                cb24.Checked = True
            End If
        ElseIf lblHitOrMiss.Text = "Miss!" And lblHitOrMiss.Visible = True Then
            If shotnumber = 0 Then
                cb0.CheckState = CheckState.Indeterminate
            ElseIf shotnumber = 1 Then
                cb1.CheckState = CheckState.Indeterminate
            ElseIf shotnumber = 2 Then
                cb2.CheckState = CheckState.Indeterminate
            ElseIf shotnumber = 3 Then
                cb3.CheckState = CheckState.Indeterminate
            ElseIf shotnumber = 4 Then
                cb4.CheckState = CheckState.Indeterminate
            ElseIf shotnumber = 5 Then
                cb5.CheckState = CheckState.Indeterminate
            ElseIf shotnumber = 6 Then
                cb6.CheckState = CheckState.Indeterminate
            ElseIf shotnumber = 7 Then
                cb7.CheckState = CheckState.Indeterminate
            ElseIf shotnumber = 8 Then
                cb8.CheckState = CheckState.Indeterminate
            ElseIf shotnumber = 9 Then
                cb9.CheckState = CheckState.Indeterminate
            ElseIf shotnumber = 10 Then
                cb10.CheckState = CheckState.Indeterminate
            ElseIf shotnumber = 11 Then
                cb11.CheckState = CheckState.Indeterminate
            ElseIf shotnumber = 12 Then
                cb12.CheckState = CheckState.Indeterminate
            ElseIf shotnumber = 13 Then
                cb13.CheckState = CheckState.Indeterminate
            ElseIf shotnumber = 14 Then
                cb14.CheckState = CheckState.Indeterminate
            ElseIf shotnumber = 15 Then
                cb15.CheckState = CheckState.Indeterminate
            ElseIf shotnumber = 16 Then
                cb16.CheckState = CheckState.Indeterminate
            ElseIf shotnumber = 17 Then
                cb17.CheckState = CheckState.Indeterminate
            ElseIf shotnumber = 18 Then
                cb18.CheckState = CheckState.Indeterminate
            ElseIf shotnumber = 19 Then
                cb19.CheckState = CheckState.Indeterminate
            ElseIf shotnumber = 20 Then
                cb20.CheckState = CheckState.Indeterminate
            ElseIf shotnumber = 21 Then
                cb21.CheckState = CheckState.Indeterminate
            ElseIf shotnumber = 22 Then
                cb22.CheckState = CheckState.Indeterminate
            ElseIf shotnumber = 23 Then
                cb23.CheckState = CheckState.Indeterminate
            ElseIf shotnumber = 24 Then
                cb24.CheckState = CheckState.Indeterminate
            End If
        End If

        Dim temp = btnShooterPos5.Text

        btnHit.Enabled = True
        btnMiss.Enabled = True
        lblHitOrMiss.Visible = False
        lblHard.Visible = False

        If btnShooterPos1.BackColor = Color.FromArgb(0, 192, 0) Then
            btnShooterPos1.BackColor = Color.Green
            cb0.BackColor = Color.Green
            cb5.BackColor = Color.Green
            cb10.BackColor = Color.Green
            cb15.BackColor = Color.Green
            cb20.BackColor = Color.Green
            btnShooterPos2.BackColor = Color.FromArgb(0, 192, 0)
            cb1.BackColor = Color.FromArgb(0, 192, 0)
            cb6.BackColor = Color.FromArgb(0, 192, 0)
            cb11.BackColor = Color.FromArgb(0, 192, 0)
            cb16.BackColor = Color.FromArgb(0, 192, 0)
            cb21.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf btnShooterPos2.BackColor = Color.FromArgb(0, 192, 0) Then
            btnShooterPos2.BackColor = Color.Green
            cb1.BackColor = Color.Green
            cb6.BackColor = Color.Green
            cb11.BackColor = Color.Green
            cb16.BackColor = Color.Green
            cb21.BackColor = Color.Green
            btnShooterPos3.BackColor = Color.FromArgb(0, 192, 0)
            cb2.BackColor = Color.FromArgb(0, 192, 0)
            cb7.BackColor = Color.FromArgb(0, 192, 0)
            cb12.BackColor = Color.FromArgb(0, 192, 0)
            cb17.BackColor = Color.FromArgb(0, 192, 0)
            cb22.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf btnShooterPos3.BackColor = Color.FromArgb(0, 192, 0) Then
            btnShooterPos3.BackColor = Color.Green
            cb2.BackColor = Color.Green
            cb7.BackColor = Color.Green
            cb12.BackColor = Color.Green
            cb17.BackColor = Color.Green
            cb22.BackColor = Color.Green
            btnShooterPos4.BackColor = Color.FromArgb(0, 192, 0)
            cb3.BackColor = Color.FromArgb(0, 192, 0)
            cb8.BackColor = Color.FromArgb(0, 192, 0)
            cb13.BackColor = Color.FromArgb(0, 192, 0)
            cb18.BackColor = Color.FromArgb(0, 192, 0)
            cb23.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf btnShooterPos4.BackColor = Color.FromArgb(0, 192, 0) Then
            btnShooterPos4.BackColor = Color.Green
            cb3.BackColor = Color.Green
            cb8.BackColor = Color.Green
            cb13.BackColor = Color.Green
            cb18.BackColor = Color.Green
            cb23.BackColor = Color.Green
            btnShooterPos5.BackColor = Color.FromArgb(0, 192, 0)
            cb4.BackColor = Color.FromArgb(0, 192, 0)
            cb9.BackColor = Color.FromArgb(0, 192, 0)
            cb14.BackColor = Color.FromArgb(0, 192, 0)
            cb19.BackColor = Color.FromArgb(0, 192, 0)
            cb24.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf btnShooterPos5.BackColor = Color.FromArgb(0, 192, 0) Then
            btnShooterPos5.BackColor = Color.Green
            cb4.BackColor = Color.Green
            cb9.BackColor = Color.Green
            cb14.BackColor = Color.Green
            cb19.BackColor = Color.Green
            cb24.BackColor = Color.Green
            btnShooterPos1.BackColor = Color.FromArgb(0, 192, 0)
            cb0.BackColor = Color.FromArgb(0, 192, 0)
            cb5.BackColor = Color.FromArgb(0, 192, 0)
            cb10.BackColor = Color.FromArgb(0, 192, 0)
            cb15.BackColor = Color.FromArgb(0, 192, 0)
            cb20.BackColor = Color.FromArgb(0, 192, 0)
        End If

        shotnumber = shotnumber + 1

        If shotnumber > 24 Then
            shotnumber = 0

            cyclenumber = cyclenumber + 1
            lblCycleDynamic.Text = cyclenumber
            cb0.Checked = False
            cb1.Checked = False
            cb2.Checked = False
            cb3.Checked = False
            cb4.Checked = False
            cb5.Checked = False
            cb6.Checked = False
            cb7.Checked = False
            cb8.Checked = False
            cb9.Checked = False
            cb10.Checked = False
            cb11.Checked = False
            cb12.Checked = False
            cb13.Checked = False
            cb14.Checked = False
            cb15.Checked = False
            cb16.Checked = False
            cb17.Checked = False
            cb18.Checked = False
            cb19.Checked = False
            cb20.Checked = False
            cb21.Checked = False
            cb22.Checked = False
            cb23.Checked = False
            cb24.Checked = False

            btnShooterPos5.Text = btnShooterPos4.Text
            btnShooterPos4.Text = btnShooterPos3.Text
            btnShooterPos3.Text = btnShooterPos2.Text
            btnShooterPos2.Text = btnShooterPos1.Text
            btnShooterPos1.Text = temp

            If cyclenumber > 5 Then
                roundnumber = roundnumber + 1
                lblRoundDynamic.Text = roundnumber
                cyclenumber = 1
                lblCycleDynamic.Text = 1
                If roundnumber > (frmPreMatch2.numNumRounds.Text) Then
                    Me.Visible = False
                    frmAfterMatchNotes.Visible = True
                End If
            End If
        End If

        pnlBang.Visible = True
        Me.Refresh()
        System.Threading.Thread.Sleep(250)
        pnlBang.Visible = False
    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlHardLeft.Click
        lblHard.Text = "Hard Left!"
        lblHard.Visible = True
    End Sub

    Private Sub Panel5_Paint(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlHardRight.Click
        lblHard.Text = "Hard Right!"
        lblHard.Visible = True
    End Sub

    Private Sub Panel6_Paint(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlCenter.Click
        lblHard.Text = "Center!"
        lblHard.Visible = True
    End Sub

    Private Sub Panel7_Paint(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Visible = False
        frmAfterMatchNotes.Visible = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxAutoNext.CheckedChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Visible = False
        frmPreMatch2.Visible = True
    End Sub

    Private Sub Panel8_Paint(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel8.Click
        If (MessageBox.Show("End match?", "Confirmation", MessageBoxButtons.YesNo)) Then
            Me.Visible = False
            frmAfterMatchNotes.Visible = True
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        If (MessageBox.Show("End match?", "Confirmation", MessageBoxButtons.YesNo)) Then
            Me.Visible = False
            frmAfterMatchNotes.Visible = True
        End If
    End Sub

    Private Sub Panel9_Paint(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel9.Click
        If (MessageBox.Show("End match?", "Confirmation", MessageBoxButtons.YesNo)) Then
            Me.Visible = False
            frmAfterMatchNotes.Visible = True
        End If
    End Sub

End Class