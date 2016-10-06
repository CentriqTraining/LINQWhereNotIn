Module Module1
    Sub Main()
        Dim Ctx = New Ctx()
        Ctx.Database.Log = Sub(p) Console.WriteLine(p)

        Dim all = (From p In Ctx.Bookings
                   Where Not (From a In Ctx.Exclusions
                              Select a.PersonID).Contains(p.ID)
                   Select p).ToList()
    End Sub
End Module
