Public Class AlphabetSketchBook
    Inherits Book

    Sub New(photo As Bitmap, bookTitle As String)
        MyBase.New(photo, bookTitle)
        pages.Add(New AlphabetSketchPage("Aa"))
        pages.Add(New AlphabetSketchPage("Bb"))
        pages.Add(New AlphabetSketchPage("Cc"))
        pages.Add(New AlphabetSketchPage("Dd"))
        pages.Add(New AlphabetSketchPage("Ee"))
        pages.Add(New AlphabetSketchPage("Fe"))
        pages.Add(New AlphabetSketchPage("Gg"))
        pages.Add(New AlphabetSketchPage("Hh"))
        pages.Add(New AlphabetSketchPage("Ii"))

        difficultPages.Add(New AlphabetSketchPage("Ant"))
        difficultPages.Add(New AlphabetSketchPage("Bat"))
        difficultPages.Add(New AlphabetSketchPage("Car"))
        difficultPages.Add(New AlphabetSketchPage("Dog"))
        difficultPages.Add(New AlphabetSketchPage("Eat"))
        difficultPages.Add(New AlphabetSketchPage("Fat"))
        difficultPages.Add(New AlphabetSketchPage("Game"))
        difficultPages.Add(New AlphabetSketchPage("Hat"))
        difficultPages.Add(New AlphabetSketchPage("Ice"))
        ' Initialize the pages here

    End Sub

End Class
