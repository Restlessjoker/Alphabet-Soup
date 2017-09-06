Public Class SoundOffBook
    Inherits Book

    Sub New(photo As Bitmap, bookTitle As String)
        MyBase.New(photo, bookTitle)
        pages.Add(New SoundOffPage("ABCD", EASY_CONSTANT))
        pages.Add(New SoundOffPage("EFGH", EASY_CONSTANT))
        pages.Add(New SoundOffPage("IJKL", EASY_CONSTANT))
        pages.Add(New SoundOffPage("MNOP", EASY_CONSTANT))
        pages.Add(New SoundOffPage("QRST", EASY_CONSTANT))
        pages.Add(New SoundOffPage("UVWX", EASY_CONSTANT))
        pages.Add(New SoundOffPage("YZab", EASY_CONSTANT))
        pages.Add(New SoundOffPage("cdef", EASY_CONSTANT))
        pages.Add(New SoundOffPage("ghij", EASY_CONSTANT))
        pages.Add(New SoundOffPage("klmn", EASY_CONSTANT))
        pages.Add(New SoundOffPage("opqr", EASY_CONSTANT))
        pages.Add(New SoundOffPage("stuv", EASY_CONSTANT))

        difficultPages.Add(New SoundOffPage("JDWR", DIFFICULT_CONSTANT))
        difficultPages.Add(New SoundOffPage("LIEZ", DIFFICULT_CONSTANT))
        difficultPages.Add(New SoundOffPage("BXSW", DIFFICULT_CONSTANT))
        difficultPages.Add(New SoundOffPage("APOQ", DIFFICULT_CONSTANT))
        difficultPages.Add(New SoundOffPage("HTYM", DIFFICULT_CONSTANT))
        difficultPages.Add(New SoundOffPage("POSY", DIFFICULT_CONSTANT))
        difficultPages.Add(New SoundOffPage("JAIJ", DIFFICULT_CONSTANT))
        difficultPages.Add(New SoundOffPage("RZIJ", DIFFICULT_CONSTANT))
        difficultPages.Add(New SoundOffPage("LUVS", DIFFICULT_CONSTANT))
    End Sub

End Class
