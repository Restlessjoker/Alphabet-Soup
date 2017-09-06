Public Class WhatAmIControl
    Public myBook As Book

    Sub New(book As Book)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        myBook = book
        'BookButtonBox1.BookButtonBoxLoad(myBook, Me)
        'WhatAmIPageControl1.loadPage(myBook.pages(myBook.currentPage), Me)
    End Sub

    'Private Sub WhatAmIPageControl1_Load(sender As Object, e As EventArgs) Handles WhatAmIPageControl1.Load

    'End Sub

    Public Sub NextPage()
        myBook.incrementPage()
        'WhatAmIPageControl1.loadPage(myBook.pages(myBook.currentPage), Me)
    End Sub

    Public Sub PreviousPage()
        myBook.decrementPage()
        'WhatAmIPageControl1.loadPage(myBook.pages(myBook.currentPage), Me)
    End Sub
End Class