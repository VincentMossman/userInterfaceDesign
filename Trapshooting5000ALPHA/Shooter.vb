Public Class GlobalVariables
    'Some Dummy Data
    Public Shared SOne = New Shooter(1, "George", "Bush", "Senior", "Varsity", "(800) 867-5309", "george.bush@aol.com", "This guy came up with a new fitness program to get people walking again. It's called 'gas at $3/gallon.'")
    Public Shared STwo = New Shooter(2, "Miley", "Cyrus", "Freshman", "Varsity", "(888) 256-7382", "likarekingbal@gmail.com", "She's releasing a new fragrance called 'Twerk', its just Billy Ray's tears in a bottle.")
    Public Shared SThree = New Shooter(3, "Vladamir", "Putin", "Sophomore", "Varsity", "(319) 165-2724", "motherrussia@russia.russia", "I see the Russian army is now conducting drills on Finland's border. Or as this guy calls it, 'window shopping.'")
    Public Shared SFour = New Shooter(4, "Chuck", "Norris", "Junior", "Varsity", "(555) 876-9982", "chuck.the.norris@gmail.com", "When Alexander Bell invented the telephone he had 3 missed calls from this man.")
    Public Shared SFive = New Shooter(5, "Eva", "Mendez", "Junior", "Varsity", "(508) 563-1254", "eva.mendez@gmail.com", "Ryan Gosling has nothing on me.")

    Public Shared ListOfShooters = New ArrayList({SOne, STwo, SThree, SFour, SFive})

    Public Shared Function listNames(ByVal value) As Array
        Dim lst = New ArrayList
        For Each Shooter In value
            lst.Add(Shooter.name())
        Next
        Return lst.ToArray
    End Function

    Public Shared Function getShooters(ByVal value) As Array
        Dim lst = New ArrayList
        For Each Shooter In value
            lst.Add(Shooter)
        Next
        Return lst.ToArray
    End Function

End Class

Public Class ShooterList
    Public sList As ArrayList = New ArrayList

    Public Sub New(ByVal value As Shooter)
        sList.Add(value)
    End Sub

    Public Sub add(ByVal value As Shooter)
        sList.Add(GlobalVariables.SOne)
    End Sub

    Public Sub New(ByVal value As Array)
        sList.AddRange(value)
    End Sub

    Public Sub add(ByVal value As Array)
        sList.AddRange(value)
    End Sub

    Public Property listNames() As ArrayList

        Get
            Dim lst = New ArrayList
            For Each Shooter As Shooter In sList
                lst.Add(Shooter.getFirstName() + " " + Shooter.getLastName())
            Next
            Return lst
        End Get

        Set(ByVal value As ArrayList)
            sList.Add(value)
        End Set
    End Property



End Class

Public Class Shooter
    Private ID As Integer
    Private FirstName As String
    Private LastName As String
    Private Squad As String
    Private GradeLevel As String
    Private Phone As String
    Private Email As String
    Private Notes As String

    Public Sub New(ByVal id As Integer, ByVal fname As String, ByVal lname As String, ByVal grade As String, ByVal squad As String, ByVal phone As String, ByVal email As String, ByVal notes As String)
        Me.ID = id
        Me.FirstName = fname
        Me.LastName = lname
        Me.Squad = grade
        Me.GradeLevel = squad
        Me.Phone = phone
        Me.Email = email
        Me.Notes = notes
    End Sub

    Public Function getFirstName() As String
        Return Me.FirstName
    End Function

    Public Function getLastName() As String
        Return Me.LastName
    End Function

    Public Function getGrade() As String
        Return Me.GradeLevel
    End Function

    Public Function getSquad() As String
        Return Me.Squad
    End Function

    Public Function getPhone() As String
        Return Me.Phone
    End Function

    Public Function getEmail() As String
        Return Me.Email
    End Function

    Public Function getNotes() As String
        Return Me.Notes
    End Function
End Class
