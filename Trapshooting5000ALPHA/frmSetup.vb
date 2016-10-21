Public Class frmSShooters

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Visible = False
        frmMainScreen.Visible = True
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("Under Construction", "Add a Player")
    End Sub

    Private Sub btnLocations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Visible = False
        frmLocation.Visible = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocations.Click
        Me.Visible = False
        frmLocation.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSquads.Click
        Me.Visible = False
        frmSquads.Visible = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Visible = False
        frmMainScreen.Visible = True

        txtbxFirstName.Clear()
        txtbxPhone.Clear()
        txtbxGradeLevel.Clear()
        txtbxLastName.Clear()
        txtbxEmail.Clear()
        txtbxNotes.Clear()
        cmbbxSquad.Text = ""
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlAddIcon.Click
        txtbxFirstName.Clear()
        txtbxPhone.Clear()
        txtbxGradeLevel.Clear()
        txtbxLastName.Clear()
        txtbxEmail.Clear()
        txtbxNotes.Clear()
        cmbbxSquad.Text = ""
    End Sub

    Private Sub Panel6_Paint(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlSaveContainer.Click, pnlSaveIcon.Click, lblSave.Click
        Dim newShooter = New Shooter(1, txtbxFirstName.Text, txtbxLastName.Text, txtbxGradeLevel.Text, cmbbxSquad.Text, txtbxPhone.Text, txtbxEmail.Text, txtbxNotes.Text)
        GlobalVariables.ListOfShooters.Add(newShooter)
        listShooters.Items.Clear()
        listShooters.Items.AddRange(GlobalVariables.listNames(GlobalVariables.ListOfShooters))
        frmPreMatch.listShooters.Items.Clear()
        frmPreMatch.listShooters.Items.AddRange(GlobalVariables.listNames(GlobalVariables.ListOfShooters))
    End Sub

    Private Sub frmSShooters_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listShooters.Items.Clear()
        listShooters.Items.AddRange(GlobalVariables.listNames(GlobalVariables.ListOfShooters))
        listShooters.SetSelected(0, True)
        Dim index = listShooters.SelectedIndex()
        Dim shooterarray = GlobalVariables.getShooters(GlobalVariables.ListOfShooters)
        txtbxFirstName.Text = shooterarray(index).getFirstName()
        txtbxLastName.Text = shooterarray(index).getLastName()
        txtbxGradeLevel.Text = shooterarray(index).getGrade()
        txtbxEmail.Text = shooterarray(index).getEmail()
        txtbxNotes.Text = shooterarray(index).getNotes()
        txtbxPhone.Text = shooterarray(index).getPhone()
        cmbbxSquad.Text = shooterarray(index).getSquad()
    End Sub

    Private Sub listShooters_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listShooters.SelectedIndexChanged
        Dim index = listShooters.SelectedIndex()
        Dim shooterarray = GlobalVariables.getShooters(GlobalVariables.ListOfShooters)
        txtbxFirstName.Text = shooterarray(index).getFirstName()
        txtbxLastName.Text = shooterarray(index).getLastName()
        txtbxGradeLevel.Text = shooterarray(index).getGrade()
        txtbxEmail.Text = shooterarray(index).getEmail()
        txtbxNotes.Text = shooterarray(index).getNotes()
        txtbxPhone.Text = shooterarray(index).getPhone()
        cmbbxSquad.Text = shooterarray(index).getSquad()
    End Sub
End Class