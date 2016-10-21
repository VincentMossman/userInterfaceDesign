Public Class frmSquads

    Private Sub frmSquads_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtbxShooter1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbxShooter1.Click
        frmSelectSquadShooters.Visible = True
    End Sub

    Private Sub txtbxShooter2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbxShooter2.Click
        frmSelectSquadShooters.Visible() = True
    End Sub

    Private Sub txtbxShooter3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbxShooter3.Click
        frmSelectSquadShooters.Visible() = True
    End Sub

    Private Sub txtbxShooter4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbxShooter4.Click
        frmSelectSquadShooters.Visible() = True
    End Sub

    Private Sub txtbxShooter5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbxShooter5.Click
        frmSelectSquadShooters.Visible() = True
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Visible = False
        frmMainScreen.Visible = True
    End Sub

    Private Sub btnShooter1Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShooter1Cancel.Click
        txtbxShooter1.Text = ""
    End Sub

    Private Sub btnShooter2Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShooter2Cancel.Click
        txtbxShooter2.Text = ""
    End Sub

    Private Sub btnShooter3Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShooter3Cancel.Click
        txtbxShooter3.Text = ""
    End Sub

    Private Sub btnShooter4Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShooter4Cancel.Click
        txtbxShooter4.Text = ""
    End Sub

    Private Sub btnShooter5Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShooter5Cancel.Click
        txtbxShooter5.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocations.Click
        Me.Visible = False
        frmLocation.Visible = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShooters.Click
        Me.Visible = False
        frmSShooters.Visible = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Visible = False
        frmMainScreen.Visible = True
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlAddIcon.Paint
        ' frmPreMatch.listShooters.Items.Add()
    End Sub
End Class