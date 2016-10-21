Public Class frmPreMatch

    Private Sub frmPreMatch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listShooters.Items.Clear()
        listShooters.Items.AddRange(GlobalVariables.listNames(GlobalVariables.ListOfShooters))
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Visible = False
        frmPreMatch2.Visible = True
    End Sub

    Private Sub btnShooter2Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtbxShooter2.Clear()
    End Sub

    Private Sub btnShooter3Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtbxShooter3.Clear()
    End Sub

    Private Sub btnShooter4Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtbxShooter4.Clear()
    End Sub

    Private Sub btnShooter5Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtbxShooter5.Clear()
    End Sub

    Private Sub listShooters_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listShooters.SelectedIndexChanged
        Add(listShooters.SelectedItem)
    End Sub

    Private Sub Add(ByVal name)
        If txtbxShooter1.Text = "" Then
            If txtbxShooter2.Text = name Or txtbxShooter3.Text = name Or
                txtbxShooter4.Text = name Or txtbxShooter5.Text = name Then

            Else
                txtbxShooter1.Text = name
            End If
        ElseIf txtbxShooter2.Text = "" Then
            If txtbxShooter1.Text = name Or txtbxShooter3.Text = name Or
                txtbxShooter4.Text = name Or txtbxShooter5.Text = name Then

            Else
                txtbxShooter2.Text = name
            End If
        ElseIf txtbxShooter3.Text = "" Then
            If txtbxShooter2.Text = name Or txtbxShooter1.Text = name Or
                txtbxShooter4.Text = name Or txtbxShooter5.Text = name Then

            Else
                txtbxShooter3.Text = name
            End If
        ElseIf txtbxShooter4.Text = "" Then
            If txtbxShooter2.Text = name Or txtbxShooter3.Text = name Or
                txtbxShooter1.Text = name Or txtbxShooter5.Text = name Then

            Else
                txtbxShooter4.Text = name
            End If
        ElseIf txtbxShooter5.Text = "" Then
            If txtbxShooter2.Text = name Or txtbxShooter3.Text = name Or
                txtbxShooter4.Text = name Or txtbxShooter1.Text = name Then

            Else
                txtbxShooter5.Text = name
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Visible = False
        frmMainScreen.Visible = True
        txtbxShooter1.Text = ""
        txtbxShooter2.Text = ""
        txtbxShooter3.Text = ""
        txtbxShooter4.Text = ""
        txtbxShooter5.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocations.Click
        If txtbxShooter2.Text = "" Or txtbxShooter3.Text = "" Or
                txtbxShooter4.Text = "" Or txtbxShooter1.Text = "" Or txtbxShooter5.Text = "" Then
            MessageBox.Show("Please select all five shooters.", "Attention!")
        Else
            Me.Visible = False
            frmPreMatch2.Visible = True
        End If

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlNext.Click
        If txtbxShooter2.Text = "" Or txtbxShooter3.Text = "" Or
                txtbxShooter4.Text = "" Or txtbxShooter1.Text = "" Or txtbxShooter5.Text = "" Then
            MessageBox.Show("Please select all five shooters.", "Attention!")
        Else
            Me.Visible = False
            frmPreMatch2.Visible = True
        End If
    End Sub

    Private Sub pnlShooter1Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlShooter1Cancel.Click
        txtbxShooter1.Clear()
    End Sub

    Private Sub pnlShooter2Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlShooter2Cancel.Click
        txtbxShooter2.Clear()
    End Sub

    Private Sub pnlShooter3Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlShooter3Cancel.Click
        txtbxShooter3.Clear()
    End Sub

    Private Sub pnlShooter4Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlShooter4Cancel.Click
        txtbxShooter4.Clear()
    End Sub

    Private Sub pnlShooter5Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlShooter5Cancel.Click
        txtbxShooter5.Clear()
    End Sub

    Private Sub pnlPosition1Up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlPosition1Up.Click
        Dim temp = txtbxShooter5.Text
        txtbxShooter5.Text = txtbxShooter1.Text
        txtbxShooter1.Text = temp
    End Sub

    Private Sub pnlPosition2Up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlPosition2Up.Click
        Dim temp = txtbxShooter1.Text
        txtbxShooter1.Text = txtbxShooter2.Text
        txtbxShooter2.Text = temp
    End Sub

    Private Sub pnlPosition3Up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlPosition3Up.Click
        Dim temp = txtbxShooter2.Text
        txtbxShooter2.Text = txtbxShooter3.Text
        txtbxShooter3.Text = temp
    End Sub

    Private Sub pnlPosition4Up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlPosition4Up.Click
        Dim temp = txtbxShooter3.Text
        txtbxShooter3.Text = txtbxShooter4.Text
        txtbxShooter4.Text = temp
    End Sub

    Private Sub pnlPosition5Up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlPosition5Up.Click
        Dim temp = txtbxShooter4.Text
        txtbxShooter4.Text = txtbxShooter5.Text
        txtbxShooter5.Text = temp
    End Sub

    Private Sub pnlPosition1Down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlPosition1Down.Click
        Dim temp = txtbxShooter2.Text
        txtbxShooter2.Text = txtbxShooter1.Text
        txtbxShooter1.Text = temp
    End Sub

    Private Sub pnlPosition2Down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlPosition2Down.Click
        Dim temp = txtbxShooter3.Text
        txtbxShooter3.Text = txtbxShooter2.Text
        txtbxShooter2.Text = temp
    End Sub

    Private Sub pnlPosition3Down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlPosition3Down.Click
        Dim temp = txtbxShooter4.Text
        txtbxShooter4.Text = txtbxShooter3.Text
        txtbxShooter3.Text = temp
    End Sub

    Private Sub pnlPosition4Down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlPosition4Down.Click
        Dim temp = txtbxShooter5.Text
        txtbxShooter5.Text = txtbxShooter4.Text
        txtbxShooter4.Text = temp
    End Sub

    Private Sub pnlPosition5Down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlPosition5Down.Click
        Dim temp = txtbxShooter1.Text
        txtbxShooter1.Text = txtbxShooter5.Text
        txtbxShooter5.Text = temp
    End Sub
End Class