Imports System.Data.Entity
Imports LINQWhereNotInTestVB

Friend Class Init
    Inherits DropCreateDatabaseIfModelChanges(Of Ctx)

    Protected Overrides Sub Seed(context As Ctx)
        ''  Adds some sample data
        Dim ids = Enumerable.Range(1, 1000)

        For Each item In ids
            context.Bookings.Add(New Booking() With {.MiscFieldForSample = item.ToString()})
        Next


        Dim avoids = Enumerable.Range(400, 600)

        For Each item In avoids
            context.Exclusions.Add(New ExclusionList() With {.PersonID = item})
        Next

        context.SaveChanges()

        MyBase.Seed(context)
    End Sub
End Class
