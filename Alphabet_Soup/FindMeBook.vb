Public Class FindMeBook
    Inherits Book

    Sub New(photo As Bitmap, bookTitle As String)
        MyBase.New(photo, bookTitle)

        pages.Add(New FindMePage("A"c, 3, False))
        pages.Add(New FindMePage("B"c, 3, False))
        pages.Add(New FindMePage("C"c, 3, False))
        pages.Add(New FindMePage("D"c, 3, False))
        pages.Add(New FindMePage("E"c, 3, False))
        pages.Add(New FindMePage("F"c, 3, False))
        pages.Add(New FindMePage("G"c, 3, False))
        pages.Add(New FindMePage("H"c, 3, False))
        pages.Add(New FindMePage("I"c, 3, False))

        difficultPages.Add(New FindMePage("a"c, 5, True))
        difficultPages.Add(New FindMePage("b"c, 5, True))
        difficultPages.Add(New FindMePage("c"c, 5, True))
        difficultPages.Add(New FindMePage("d"c, 5, True))
        difficultPages.Add(New FindMePage("e"c, 5, True))
        difficultPages.Add(New FindMePage("f"c, 5, True))
        difficultPages.Add(New FindMePage("g"c, 5, True))
        difficultPages.Add(New FindMePage("h"c, 5, True))
        difficultPages.Add(New FindMePage("i"c, 5, True))
    End Sub
End Class
