Imports System.Data.Entity

Public Class Booking
    Public Property ID As Integer
    Public Property MiscFieldForSample As String
End Class

Public Class ExclusionList
    Public Property ID As Integer
    Public Property PersonID As Integer
End Class

Public Class Ctx
    Inherits DbContext

    Public Sub New()
        Database.SetInitializer(Of Ctx)(New Init())
    End Sub
    Public Property Bookings As DbSet(Of Booking)
    Public Property Exclusions As DbSet(Of ExclusionList)
End Class


