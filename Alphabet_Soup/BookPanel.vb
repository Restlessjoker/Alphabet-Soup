Public Class BookPanel
    Public myBook As Book
    Public page As PagePanel
    Public finishedPagePanel As FinishedPagePanel
    Public finishedPage As FinishedPage
    Public difficultyPagePanel As DifficultyPagePanel

    Public myForm As Form1
    Public isTableOfContentsOpen As Boolean
    Private isFirstLoad As Boolean

    Sub New(book As Book, form As Form1)

        ' This call is required by the designer.
        InitializeComponent()

        isFirstLoad = True
        ' Add any initialization after the InitializeComponent() call.
        myBook = book
        myForm = form
        BookButtonBox1.BookButtonBoxLoad(myBook, Me)

        finishedPage = New FinishedPage()
        finishedPagePanel = New FinishedPagePanel()
        difficultyPagePanel = New DifficultyPagePanel
        difficultyPagePanel.loadBook(Me)

        finishedPagePanel.loadPage(finishedPage, Me)

        If myBook.GetType() = GetType(WhatAmIBook) Then
            page = New WhatAmIPagePanel()
        ElseIf myBook.GetType() = GetType(SoundOffBook) Then
            page = New SoundOffPagePanel()
        ElseIf myBook.GetType() = GetType(AlphabetSketchBook) Then
            page = New AlphabetSketchPagePanel()
        ElseIf myBook.GetType() = GetType(FindMeBook) Then
            page = New FindMePagePanel()
        ElseIf isGradeBook() Then
            page = New GradePagePanel()
        Else
            'Normally would not be this, should be different based on the if statement 
            page = New WhatAmIPagePanel()
        End If

        page.Hide()
        finishedPagePanel.Hide()

        If myBook.GetType() = GetType(GradeBook) Then
            LoadCurrentBookPage()
        ElseIf myForm.easyChecked And myForm.hardChecked
            isTableOfContentsOpen = True
            BookButtonBox1.CheckButtons()
        Else
            If myForm.easyChecked Then
                myBook.SetDifficulty(Book.EASY_CONSTANT)
            Else
                myBook.SetDifficulty(Book.DIFFICULT_CONSTANT)
            End If
            LoadCurrentBookPage()
        End If

        Me.Controls.Add(difficultyPagePanel)
    End Sub

    Public Sub LoadCurrentBookPage()
        difficultyPagePanel.Hide()
        isTableOfContentsOpen = False

        Dim pages = myBook.GetPages()

        If pages.Count <= myBook.GetCurrentPage() Then
            page.Hide()
            finishedPagePanel.Show()
        Else
            page.loadPage(pages(myBook.GetCurrentPage()), Me)
            finishedPagePanel.Hide()
            page.Show()
        End If

        BookButtonBox1.CheckButtons()
        Me.Controls.Add(finishedPagePanel)
        Me.Controls.Add(page)


        If isFirstLoad Then
            PlayInstruction()
            isFirstLoad = False
        End If

    End Sub

    Public Sub NextPage()
        myBook.incrementPage()

        Dim pages = myBook.GetPages()

        If pages.Count <= myBook.GetCurrentPage() Then
            page.Hide()
            finishedPagePanel.Show()
        Else
            page.Show()
            finishedPagePanel.Hide()
            page.loadPage(pages(myBook.GetCurrentPage()), Me)
        End If
    End Sub

    Public Sub PlayInstruction()
        SoundReferenceLibrary.PlayAudio(myBook.bookTitle, SoundReferenceLibrary.INSTRUCTION)
    End Sub

    Public Sub PreviousPage()

        Dim pages = myBook.GetPages()

        If pages.Count >= myBook.GetCurrentPage() Then
            finishedPagePanel.Hide()
            page.Show()
        End If

        myBook.decrementPage()

        page.loadPage(pages(myBook.GetCurrentPage()), Me)

    End Sub

    Public Function isGradeBook()
        Return myBook.GetType() = GetType(GradeBook)
    End Function

End Class
