Public Class WhatAmIBook
    Inherits Book

    Sub New(photo As Bitmap, bookTitle As String)
        MyBase.New(photo, bookTitle)
        pages.Add(New WhatAmIPage(My.Resources.What_Am_I_Apple_Non_Coloured, My.Resources.What_Am_I_Apple_Coloured, "APPLE", 1, 4))
        pages.Add(New WhatAmIPage(My.Resources.What_Am_I_Book_Non_Coloured, My.Resources.What_Am_I_Book_Coloured, "BOOK", 1, 4))
        pages.Add(New WhatAmIPage(My.Resources.What_Am_I_Cat_Non_Coloured, My.Resources.What_Am_I_Cat_Coloured, "CAT", 1, 4))
        pages.Add(New WhatAmIPage(My.Resources.What_Am_I_Dog_Non_Coloured, My.Resources.What_Am_I_Dog_Coloured, "DOG", 1, 4))
        pages.Add(New WhatAmIPage(My.Resources.What_Am_I_Flower_Non_Coloured, My.Resources.What_Am_I_Flower_Coloured, "FLOWER", 1, 4))

        difficultPages.Add(New WhatAmIPage(My.Resources.What_Am_I_House_Non_Coloured, My.Resources.What_Am_I_House_Coloured, "HOUSE", 2, 5))
        difficultPages.Add(New WhatAmIPage(My.Resources.What_Am_I_Mouse_Non_Coloured, My.Resources.What_Am_I_Mouse_Coloured, "MOUSE", 2, 6))
        difficultPages.Add(New WhatAmIPage(My.Resources.What_Am_I_Telephone_Non_Coloured, My.Resources.What_Am_I_Telephone_Coloured, "TELEPHONE", 3, 7))
        difficultPages.Add(New WhatAmIPage(My.Resources.What_Am_I_Violin_Non_Coloured, My.Resources.What_Am_I_Violin_Coloured, "VIOLIN", 3, 8))
        difficultPages.Add(New WhatAmIPage(My.Resources.What_Am_I_Watermelon_Non_Coloured, My.Resources.What_Am_I_Watermelon_Coloured, "WATERMELON", 4, 10))

        ' Initialize the pages here

    End Sub

End Class
