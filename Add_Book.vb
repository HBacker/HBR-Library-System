
    
Imports HtmlAgilityPack
Imports MySql.Data.MySqlClient
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports System.Security.Cryptography
Imports System.Text
Public Class Add_Book
    
    Dim HTMLxpath As String = My.Settings.xpath
    Dim LibBo_Data As String
    Dim raw_data As String
    Dim publisher_converted As String
    Dim pbType as Boolean
    Dim db_credentials as String
    Dim data_isbn As String
    Dim SectionName as String = "AddBook"
    Dim ColorMode as String
    Dim colorMode_Speed as Integer
    Dim session as String = my.Settings.session.ToString()
    Dim selenium_bookname as String
    Dim selenium_author as String
    dim getFromSelenium as Boolean
    Dim bookPoster_ex As String
    Dim path as String = Application.StartupPath.ToString() + "\"
    Private Sub Add_Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combo_Subject.SelectedItem = "Seçiniz..."
        Default_EntityColor()
        Default_EntityValues()
         welcomeSESSION.Text = "welcome, " & My.Settings.session.ToString & "!"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
    End Sub
    Sub loading_show
        loading.Visible = True
    End Sub
    Sub loading_hide
        loading.Visible = False
    End Sub
    Private Sub button_bot_Click(sender As Object, e As EventArgs) Handles button_bot.Click
        If libbo_isbn.Text.Length <= 5 Then

            Else
            loading_show
              If libbo_isbn.Text.Contains(" ") Then
            libbo_isbn.Text = libbo_isbn.Text.Replace(" ", "")
        End If
        data_isbn = ""
        raw_data = ""
        data_isbn = libbo_isbn.Text
        btn_Clear.PerformClick()
        libbo(data_isbn)
        text_ISBN.Text = data_isbn
        If libbo_basic.Checked = true
        else
            LibBo_WebDriver(data_isbn)
        End If
        End If
      


    End Sub
    Function Libbo_Subject(x As String)

        If text_ISBN.Text.Contains(" ") Then
            text_ISBN.Text = text_ISBN.Text.Replace(" ", "")
        End If
        dim backup as string
        
      if  x  Is Nothing Then
             libbo_emptydata()
            Else
           x = x.ToString().ToLower()
            'subjectLog.Text = subjectLog.Text + vbNewLine + "Main;" + vbNewLine + x.ToString
     If x.Contains("ingilizce hikaye") Then
            combo_Subject.SelectedItem = "Polisiye"
        ElseIf x.Contains("çocuk edebiyatı") Then
            combo_Subject.SelectedItem = "Edebiyat"
        ElseIf x.Contains("genç edebiyatı") Then
            combo_Subject.SelectedItem = "Edebiyat"
        ElseIf x.Contains("rus romanı") or x.Contains("rus edebiyatı") Then
            combo_Subject.SelectedItem = "Rus Romanı"
        ElseIf x.Contains("ingiliz romanı") or x.Contains("ingiliz edebiyatı") Then
            combo_Subject.SelectedItem = "İngiliz Romanı"
        ElseIf x.Contains("roman") Then
            combo_Subject.SelectedItem = "Roman"
        ElseIf x.Contains("edebiyat") Then
            combo_Subject.SelectedItem = "Edebiyat"
             ElseIf x.Contains("edebiyat") Then
            combo_Subject.SelectedItem = "Edebiyat"

        Else
            'subjectLog.text   = subjectLog.text + vbNewLine + "BULUNAMADI"
            Try
                Dim document = New HtmlWeb().Load("http://www.toplukatalog.gov.tr/?_f=1&the_page=1&cwid=2&keyword=" & text_ISBN.Text & "&tokat_search_field=1&order=0&command=Tara#alt")        
                Dim veri = document.DocumentNode.SelectSingleNode("//*[@id='search_results']/table[2]")
               If veri Is Nothing Then
                        libbo_emptydata
                        Else
                        backup = veri.InnerText

                          sleep(1)
                x = backup.ToString().ToLower()
                'subjectLog.Text = subjectLog.Text + vbNewLine + "BACKUP;" + vbNewLine + x.ToString
                If x.Contains("ingilizce hikaye") Then
                    combo_Subject.SelectedText = ""
                ElseIf x.Contains("çocuk edebiyatı") Then
                    combo_Subject.SelectedText = "Edebiyat"
                ElseIf x.Contains("genç edebiyatı") Then
                    combo_Subject.SelectedText = "Edebiyat"
                ElseIf x.Contains("rus romanı") or x.Contains("rus edebiyatı") Then
                    combo_Subject.SelectedText = "Rus Romanı"
                ElseIf x.Contains("ingiliz romanı") or x.Contains("ingiliz edebiyatı") Then
                    combo_Subject.SelectedText = ""
                ElseIf x.Contains("roman") Then
                    combo_Subject.SelectedText = "Roman"
                ElseIf x.Contains("edebiyat") Then
                    combo_Subject.SelectedText = "Edebiyat"
                    ElseIf x.Contains("mutluluk") Then
                    combo_Subject.SelectedText = "Diğer"
                Else
                    
                End If
               End If
                
              
            Catch ex As Exception

            End Try

        End If
        End If
         
        
        libbo_reset.Start
    End Function
    Function libbo(isbn As String)
       
        getFromSelenium = False
        Dim yıl As String
        Try
            Dim document = New HtmlWeb().Load("http://www.toplukatalog.gov.tr/?_f=1&the_page=1&cwid=2&keyword=" & isbn & "&tokat_search_field=1&order=0&command=Tara#alt")
            Dim veri = document.DocumentNode.SelectSingleNode(HTMLxpath)
            If veri Is Nothing Then
               libbo_emptydata()
              
                Else
                LibBo_Data  = veri.InnerText
                
            End If
           
            
           


        Catch ex As Exception
            libbo_emptydata()
        End Try
        Try

            Dim text As String = LibBo_Data
            Dim çıktı As String
            Dim i As Integer = 3
            raw_data = text
            çıktı = Split((Split(text, ":")(i).ToString), ":")(0).ToString.TrimEnd()


            If çıktı.Contains("/") Then

                çıktı = ":" + çıktı

                çıktı = Split((Split(text, ":")(3).ToString), "/")(0).ToString.TrimEnd()
                text_bookName.Text = çıktı.ToString.TrimEnd
                System.Threading.Thread.Sleep((50))
                If çıktı.Contains(";") Then
                    çıktı = Split((Split(text, ":")(3).ToString), "/")(0).ToString.TrimEnd()
                    Console.WriteLine("/  ve ; Bulundu: " + vbNewLine + çıktı.TrimEnd())
                    text_bookName.Text = çıktı.ToString.TrimEnd
                Else
                    Console.WriteLine("Sadece  /  Bulundu:  " + vbNewLine + çıktı.TrimEnd())
                    text_bookName.Text = çıktı.ToString.TrimEnd
                End If
            Else

                text_bookName.Text = çıktı.ToString.TrimEnd
            End If
            sendLog("Function.Libbo", "Libbo HtmlAgilityPack_Module: SUCCESS", "RAW DATA:: " & çıktı.TrimEnd().ToString())
        Catch ex As Exception
            libbo_emptydata()
            sendLog("Function.Libbo", "Libbo HtmlAgilityPack_Module: ERROR", ex.Message)
            getFromSelenium = True
            selenium_bookname = ""
            selenium_author = ""
        End Try

        If text_bookName.Text.Contains("Yazar") Then
            text_bookName.Text = text_bookName.Text + "?"
            text_bookName.Text = text_bookName.Text.Replace("Yazar?", "")
        Else

        End If
        LibBo_ReleaseDate(raw_data)
        LibBo_Author(raw_data)
        Libbo_Subject(raw_data)
    End Function
    Function LibBo_Author(x As String)

        Dim y As String = x
        Try
            Dim i As Integer = 1

            y = Split((Split(x, "Yazar:")(i).ToString), "ISBN")(0).ToString.TrimEnd()
            If y.Contains("(") Then
                y = y.Split("(")(0)
            Else
            End If
            If y.Contains("|") Then
                y = y.Split("|")(0)
            Else
            End If
            y = y + "*"
            If y.Contains("Alt*") Then
                y = y.Replace("Alt*", "")
            Else
            End If
            If y.Contains(" *") Then
                y = y.Replace(" *", "")
            ElseIf y.Contains("*") Then
                y = y.Replace("*", "")
            Else
            End If
            text_Author.Text = y.TrimEnd().ToString

            Console.WriteLine("yazar Bilgisi BAŞARILI: {0}", y)
            sendLog("Function.LibBo_Author", "Author Data: SUCCESS", "Author:: " & y.TrimEnd().ToString())
        Catch ex As Exception
            Console.WriteLine("yazar Bilgisi BAŞARISIZ!" + vbNewLine + ex.Message)
            If getFromSelenium = True Then

            else

                text_Author.Text = ""
            End If
            sendLog("Function.LibBo_Author", "Author Data: ERROR", ex.Message)
        Catch exx As Exception
        End Try
        If text_Author.Text.Contains(",") Or text_Author.Text.Contains(", 1") Then
            Dim v1x As String = text_Author.Text.Split(",")(0)
            Dim v2x As String = text_Author.Text.Split(",")(1)
            If v1x.Contains(" ") Then
                v1x = v1x.Replace(" ", "")
            Else
            End If
            If v2x.Contains(" ") Then
                v2x = v2x.Replace(" ", "")
            Else
            End If
            Dim finalx As String = v2x.ToString() & " " & v1x.ToString()
            text_Author.Text = finalx.ToString()

        else
        End If
        If text_Author.Text.Contains("FyodorMihayloviç") Then
            text_Author.Text = text_Author.Text.Replace("FyodorMihayloviç", "Fyodor Mihayloviç")
        End If
         If text_Author.Text.Contains("LevNikolayeviç Tolstoy") Then
            text_Author.Text = text_Author.Text.Replace("LevNikolayeviç Tolstoy", "Lev Nikolayeviç Tolstoy")
        End If

    End Function
    Function LibBo_ReleaseDate(x As String)

        text_Release.MaxLength = 99999
        Try

            Dim i As Integer = 1
            Dim y As String
            y = Split((Split(x, "Yayın Yılı:")(i).ToString), "Bası")(0).ToString.TrimEnd()
            If y.Contains("Dil:") Then
                y = y.Split("Dil:")(0)
            End If

            text_Release.Text = y
            If text_Release.Text.Contains("") Then
                text_Release.Text = text_Release.Text.Replace(" ", "")
            Else

            End If
            Console.WriteLine("YIL Bilgisi BAŞARILI: {0}", y)
            sendLog("Function.LibBo_ReleaseDate", "getData.Ex_EX: [Main] ReleaseDate Data: SUCCESS", "Release Date:: " & y.TrimEnd().ToString())
        Catch exx As Exception
        Catch ex As Exception
            Try
                Dim xyz As String
                Dim documentx = New HtmlWeb().Load("http://www.toplukatalog.gov.tr/?_f=1&the_page=1&cwid=2&keyword=" & libbo_isbn.Text & "&tokat_search_field=1&order=0&command=Tara#alt")
                Dim verixx = documentx.DocumentNode.SelectSingleNode("//*[@id='search_results']/table[2]")
                xyz = verixx.InnerText
                Dim i As Integer = 1
                Dim y As String
                y = Split((Split(xyz, "Yayın Yılı:")(i).ToString), "Bası")(0).ToString.TrimEnd()
                If y.Contains("Dil:") Then
                    y = y.Split("Dil:")(0)
                End If

                text_Release.Text = y
                If text_Release.Text.Contains(" ") Then
                    text_Release.Text = text_Release.Text.Replace(" ", "")
                Else

                End If
                Console.WriteLine("BAŞARILI!" + vbNewLine + y)
                sendLog("Function.LibBo_ReleaseDate", "getData.Ex_EX:[Backup] ReleaseDate Data: SUCCESS", "Release Date[Backup]:: " & y.TrimEnd().ToString())
            Catch exx As Exception
                text_Release.Text = ""
                sendLog("Function.LibBo_ReleaseDate", "Backup ReleaseDate Data: ERROR", exx.Message)
                Console.WriteLine("HATA: RELEASE DATE - getDATA_EX'S EX. " + vbNewLine + exx.Message)
            End Try
            Console.WriteLine("HATA: RELEASE DATE - getDATA_EX. " + vbNewLine + ex.Message)
        End Try
        text_Release.MaxLength = 4
        text_Publisher.Select()

    End Function

    Private Sub text_bookName_TextChanged(sender As Object, e As EventArgs) Handles text_bookName.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_FulLScreen_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        text_bookName.Text = ""
        text_Author.Text = ""
        text_Publisher.Text = ""
        text_ISBN.Text = ""
        text_Release.Text = ""
        libbo_isbn.Text = ""
        rate.Text = ""

        book_poster.Image = My.Resources.Resources.HBR
        combo_Subject.SelectedItem = "Seçiniz..."
    End Sub

    Private Sub LibBoEmpty_timer_Tick(sender As Object, e As EventArgs) Handles LibBoEmpty_timer.Tick
        LibBoEmpty_timer.Stop()
        LibBo_empty.Visible = False
    End Sub
    Sub libbo_emptydata()
        LibBo_empty.Visible = True
        LibBoEmpty_timer.Start()
    End Sub

    Private Sub libbo_isbn_TextChanged(sender As Object, e As EventArgs) Handles libbo_isbn.TextChanged
    End Sub

    Private Sub libbo_isbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles libbo_isbn.KeyPress

    End Sub

    Private Sub libbo_isbn_KeyUp(sender As Object, e As KeyEventArgs) Handles libbo_isbn.KeyUp
        Try
            If e.KeyCode = Keys.Enter Then
                button_bot.PerformClick()
            Else
            End If
        Catch ex As Exception

        End Try


    End Sub
    Function LibBo_WebDriver(x As String)
       Dim xyz As String
        bookPoster_ex = ""
        Dim a As String
        Dim b As String
        Dim c As String
        Dim driver As IWebDriver
        session = my.Settings.session.ToString()

        Try
            dim DriverPATH As String = path
            Dim optionsx = New ChromeOptions
            Dim svc As ChromeDriverService = ChromeDriverService.CreateDefaultService()
            svc.CreateDefaultService()
            svc.HideCommandPromptWindow = True
            
            optionsx.AddArguments("window-position=-10000,0", "--no-sandbox", "--disable-web-security", "--disable-gpu", "--incognito", "--proxy-bypass-list=*", "--proxy-server='direct://'", "--log-level=3", "--hide-scrollbars")
            If session = "user" Then
               driver = New ChromeDriver(svc, optionsx)
          Else
              driver = New ChromeDriver(svc)
           End If


            driver.Navigate().GoToUrl("https://www.bookfinder.com/?")
            Sleep(100)
            Dim isbn As IWebElement = driver.FindElement(By.Name("isbn"))
            Dim button As IWebElement = driver.FindElement(By.Name("submitBtn"))
            isbn.SendKeys(x)
            a = isbn.Text.TrimEnd.ToString
            button.Click()
            Sleep(1000)
            Dim image As IWebElement = driver.FindElement(By.Id("coverImage"))
        bookPoster_ex = image.GetAttribute("src").ToString
            Dim strPublisher As String
            try

                Dim bookname as IWebElement = driver.FindElement(By.Id("describe-isbn-title"))
                console.writeline("Libbo_WebDriver<BookName>:: " & bookname.Text.TrimEnd.ToString)
                Dim author as IWebElement = driver.FindElement(By.XPath("//*[@id='bd-isbn']/div/div[2]/div[2]/p/strong/a/span"))
                console.writeline("Libbo_WebDriver<Author>:: " & author.Text.TrimEnd.ToString)

                Dim publisher As IWebElement = driver.FindElement(By.xpath("//*[@id='bd-isbn']/div/div[2]/p[1]/span[2]"))
                console.writeline("Libbo_WebDriver<Publisher>:: " & publisher.Text.TrimEnd.ToString)
                console.writeline("[" + DateAndTime.Now.ToString("HH:mm") + "] Libbo_WebDriver<IMAGE>:: " & image.GetAttribute("src").TrimEnd.ToString)
                selenium_bookname = bookname.Text.ToString()
                selenium_author = author.Text.ToString()
                strPublisher = publisher.Text.ToString
        
            Catch ex As Exception
                sendLog("Ex.Function.Libbo_WebDriver.EX", "Ex.Function.Libbo_WebDriver.EX: ERROR", ex.message)
            End Try

            dim rating as IWebElement = driver.FindElement(By.XPath("//*[@id='bd-isbn']/div/div[2]/div[4]/span[1]"))
            Dim rate_x as String = rating.Text.ToString()
            rate_x = rate_x.Split(" ")(0)


            If rate_x.Contains(" ") Then
                rate_x = rate_x.Replace(" ", "")
            End If
            rate.Text = rate_x.ToString()
            TRY
                ConvertUTF8Display(strPublisher.TrimEnd.ToString)
                Sendlog("Libbo_WebDriver", "ConvertUTF8Display: SUCCESS", "RAW==> '" & strPublisher.tostring & "'")
            Catch ex As Exception
                Sendlog("Libbo_WebDriver", "ConvertUTF8Display: ERROR", ex.message)
            End Try

           
            xyz = image.GetAttribute("src").ToString
            Console.WriteLine("Image=> " + xyz.TrimEnd)
            bookPoster_ex = xyz.ToString
           
            If getFromSelenium = true Then
                TRY
                    sendLog("Function. LibBo_WebDriver.TransferToSeleniumData", "Libbo Preferred to Libbo_Selenium", "Book Name:: " & selenium_bookname.ToString() & "Author:: " & selenium_author.ToString())
                    text_bookName.Text = selenium_bookname.ToString()
                    text_Author.Text = selenium_author.ToString()
                Catch ERR As Exception
                    sendLog("Function. LibBo_WebDriver.ex.TransferToSeleniumData", "TransferToSeleniumData: ERROR", ERR.Message)
                End Try
            else
            End If
            SendDLReqToHBR(xyz, x)
           
            book_poster.Load(xyz)
            b = image.GetAttribute("src").ToString

            ' y = y + "*prefix*"
            Console.WriteLine("ISBN:==> " + "'" + x + "'")
            Console.WriteLine("IMG:==> " + "'" + xyz + "'")
           Console.WriteLine("Publisher:==> " + "'" + strPublisher + "'")
            Dim abcx As String = x
            book_poster.Load(xyz.ToString)
            sendLog("Function.LibBo_WebDriver / REQUESTED BY:: " & session, "Web Driver: SUCCESS", "Book Name:: " & selenium_bookname.ToString() & "Author:: " & selenium_author.ToString() & "IMAGE:: " & xyz.ToString() & " / Publisher(Encoded):: " & strPublisher.TrimEnd().ToString() & " / ISBN:: " & abcx.TrimEnd().ToString())

            ' y = y.Split("*prefix*")(0)
            driver.Quit()
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName = "chromedriver" Then
                    prog.Kill()
                End If
            Next

        Catch ex As Exception
            Console.WriteLine("WebDriver: ERROR. EX_BASE> " + vbNewLine + ex.Message)
            sendLog("Function.LibBo_WebDriver / REQUESTED BY:: " & session, "Web Driver: ERROR", EX.Message)
        End Try
        Try
             book_poster.Load("https://pictures.abebooks.com/isbn/" & text_ISBN.text  & "-us-300.jpg")
     
        Catch ex As Exception
            book_poster.Image = My.Resources.Resources.HBR
            Console.WriteLine("BookPoster_EX: " + vbNewLine + ex.Message)
        End Try
       

    End Function
    Function SendDLReqToHBR(ReqUrl As String, ISBN As String)
        Dim base As String = My.Settings.api_url
        Dim baseModule As String = "getImage.php/"
        Dim code As String = My.Settings.code
        Try
            Dim GETx As String


            Dim url As String = base & baseModule

            GETx = url + "?image-url=" + ReqUrl _
                   + "&isbn=" + ISBN _
                   + "&code=" + code
            Console.WriteLine("WEB Request: " + GETx.ToString())
            Dim webClient As New Net.WebClient
            Dim writeÇıktı As String = webClient.DownloadString(GETx)
            Console.WriteLine("Web Request: OUTPUT. " + writeÇıktı.TrimEnd().ToString())
            sendLog("Function.SendDLReqToHBR", "API/WEB Request: SUCCESS", writeÇıktı.TrimEnd().ToString())
        Catch ex As Exception
            Console.WriteLine("WEB Request: ERROR.  " + ex.Message)
            sendLog("Function.SendDLReqToHBR", "API/WEB Request: ERROR", EX.Message)
        End Try
        data_isbn = ""

    End Function
    Function ConvertUTF8Display(x As String)
        If x.Contains(",") Then
            x = x.Split(",")(0)
        Else
        End If
        If x.Contains("Ä±") Then
            x = x.Replace("Ä±", "ı")
        Else
        End If
        If x.Contains("Ã§") Then
            x = x.Replace("Ã§", "ç")
        Else
        End If
        If x.Contains("ÅŸ") Then
            x = x.Replace("ÅŸ", "ş")
        Else
        End If
        If x.Contains("Ã¶") Then
            x = x.Replace("Ã¶", "ö")
        Else
        End If
        If x.Contains("Ã¼") Then
            x = x.Replace("Ã¼", "ü")
        Else
        End If
        If x.Contains("ÄŸ") Then
            x = x.Replace("ÄŸ", "ğ")
        Else
        End If
        If x.Contains("Ä°") Then
            x = x.Replace("Ä°", "İ")
        Else
        End If
        If x.Contains("Ã‡") Then
            x = x.Replace("Ã‡", "Ç")
        Else
        End If
        If x.Contains("ÅŸ") Then
            x = x.Replace("ÅŸ", "Ş")
        Else
        End If
        If x.Contains("Ã–") Then
            x = x.Replace("Ã–", "Ö")
        Else
        End If
        If x.Contains("Ãœ") Then
            x = x.Replace("Ãœ", "Ü")
        Else

        End If
        If x.Contains("ÄŸ") Then
            x = x.Replace("ÄŸ", "Ğ")
        Else
        End If
        Console.WriteLine("Publisher:==> " + "'" + x + "'")
        publisher_converted = x.ToString()
        Try
            publisher_converted = publisher_converted.Replace("Yayincilik", "Yayıncılık")
            publisher_converted = publisher_converted.Replace("yayincilik", "yayıncılık")
            publisher_converted = publisher_converted.Replace("Yayinci", "Yayıncı")
            publisher_converted = publisher_converted.Replace("yayinci", "yayıncılık")

            publisher_converted = publisher_converted.Replace("Yayinlari", "Yayınları")
            publisher_converted = publisher_converted.Replace("yayinlari", "yayınları")
            sendLog("Function.ConvertUTF8Display: SUCCESS", "Publisher(Decoded):: " & x, "")
        Catch ex As Exception
            sendLog("Function.ConvertUTF8Display: ERROR", ":: " & x, "")
            Finally
            loading_hide
        End Try

        text_Publisher.Text = publisher_converted

    End Function

    Function Sleep(i As Integer)
        System.Threading.Thread.Sleep(i)
    End Function

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles btn_pbType.Click
       
        If pbType = False Then
            pbType = True
            btn_pbType.Text = "Standart"
            book_poster.SizeMode = PictureBoxSizeMode.StretchImage
        else
            btn_pbType.Text = "Sığdır"
            PBType = false
            book_poster.SizeMode = PictureBoxSizeMode.Zoom

        End If

    End Sub

    Private Sub dataUpdater_Tick(sender As Object, e As EventArgs) Handles dataUpdater.Tick
        db_credentials = "server=" & My.Settings.sqlhost & ";" & "userid=" & My.Settings.sqluser & ";" & "pwd=" & My.Settings.sqlpwd & ";" & "database=" & My.Settings.sqldb & ";" & "port=" & My.Settings.sqlport & ";" & "charset=" & My.Settings.sqlcharset & ";" & "SslMode=" & My.Settings.sqlssl & ";"
    End Sub
    Function Dialog(data As String, help_message As String)
        My.Settings.dialog = data
        My.Settings.dialog_help = help_message
        dialog_box.Close()
        dialog_box.show()
    End Function
     Function hasher(ByVal x As String)
        Dim md5 As MD5 = New MD5CryptoServiceProvider()
        Dim result As Byte()
        result = md5.ComputeHash(Encoding.ASCII.GetBytes(x))
        Dim output_hbr As New StringBuilder()
        For i As Integer = 0 To result.Length - 1
            output_hbr.Append(result(i).ToString("x2"))
        Next
        Return output_hbr.ToString.TrimEnd()
    End Function

    Function AddBook()

        Dim Book as String = text_bookName.Text
        Dim Author As String = text_Author.Text
        Dim Publisher As String = text_Publisher.Text
        Dim Subject as String = combo_Subject.SelectedItem.ToString()
        Dim Release As String = text_Release.Text
        Dim ISBN as String = text_ISBN.Text
        Dim ImageName as string
        Dim xtime As String = dashboard.pdate.Value.ToString("dd.MM.yyyy") & " / " & dashboard.lTime.Text.ToString
       Dim hash As String = hasher(Book & " | " & xtime)
        If ISBN = "" Then
            ImageName = "HBR"
        elseif ISBN.Length < 8 Then
            ImageName = "HBR"
        Else
            ImageName = text_ISBN.Text
        End If
        Dim Image As String = My.Settings.api_url.ToString() + "library-posters/" & ImageName & ".jpg"
        If Book.Length < 2 Or Author.Length < 3 Or Publisher.Length < 3 Then

            Dialog("AddBook-empty_area", "Eklenecek her kitap Kitap Adı, Yazar ve Yayınevi bilgilerini içermek zorundadır!")
        Else
            Try
                Dim db As New MySqlConnection(db_credentials)
                Dim cmd As New MySqlCommand
                db.Open()
                cmd.Connection = db

                cmd.CommandText = "INSERT INTO books (Kapak,Kitap,Yazar,Yayıncı,Konu,ÇıkışYılı,ISBN,KayıtTarihi,Sonİşlem,SonTeslimAlan,Durum,hash) VALUES ('" & Image & "','" & Book & "','" & Author & "','" & Publisher & "','" & Subject & "','" & Release & "', '" & ISBN & "', '" & dashboard.pdate.Value.ToString("dd.MM.yyyy").ToString & "', '" & dashboard.pdate.Value.ToString("dd.MM.yyyy") & " / " & dashboard.lTime.Text.ToString & "', '" & "Yok" & "', '" & "Kütüphanede" & "', '" & hash & "')"
                cmd.ExecuteNonQuery()
                btn_clear.PerformClick()
                Console.WriteLine("Function.AddBook: SUCCESS")
                sendLog("Function.AddBook: SUCCESS", "MySQL Data INSERT: SUCCESS", cmd.CommandText.Tostring)
                 Book_Logger(hash) 'CREATE BOOK TRANSACTION HISTORY type=HASH
                addButtonChange("success")
                Dialog("AddBook-success", "Kitap bilgileri Veritabanına başarıyla eklendi!")
            Catch ERR As Exception
                Console.WriteLine("Function.AddBook: ERROR " + ERR.Message)
                sendLog("Function.AddBook: ERROR", "Ex Exception", ERR.Message)
                addButtonChange("error")
            End Try
        End If

    End Function
    Function Book_Logger(hash As String)
                 Dim db_logger As New MySqlConnection(db_credentials)
                Dim cmd As New MySqlCommand
        Try        
                db_logger.Open()
                cmd.Connection = db_logger

                cmd.CommandText = "CREATE TABLE `book_history`.`" & hash & "` ( `id` INT(255) NOT NULL AUTO_INCREMENT ,  `Yetkili` VARCHAR(535) NOT NULL ,  `TeslimAlan` VARCHAR(535) NOT NULL ,  `TeslimEdecegiTarih` VARCHAR(535) NOT NULL ,  `TeslimEttigiTarih` VARCHAR(535) NOT NULL ,  `TeslimEttigiZaman` VARCHAR(535) NOT NULL ,  `Durum` VARCHAR(535) NOT NULL ,  `hash` VARCHAR(535) NOT NULL ,    PRIMARY KEY  (`id`)) ENGINE = InnoDB CHARSET=utf8 COLLATE utf8_turkish_ci COMMENT = 'this table created automatically by HBR Library System';"
                cmd.ExecuteNonQuery()
         sendLog("Function.BookLogger: SUCCESS", "TABLE CREATE by HASH(" & hash & "): SUCCESS", cmd.CommandText.Tostring)
        Catch ex As Exception
            sendLog("Function.BookLogger: ERROR", "Ex Exception", ex.Message)
       Finally
           db_logger.Dispose
        End Try
       
    End Function
    Function sendLog(title As String, message As String, ex As String)
        DevTool.log.Text = DevTool.log.Text + vbNewLine + "[" + dashboard.lTime.Text + "]" + "{" + SectionName + "}---" + title + " ==> " + message + " #BASE=>" + vbNewLine + "[" + ex + "]"
    End Function

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        raw_data = ""
        data_isbn = ""
    End Sub

    Private Sub GunaAdvenceButton2_Click_1(sender As Object, e As EventArgs) Handles btnINSERT.Click

        AddBook()
    End Sub

    Private Sub addedTimer_Tick(sender As Object, e As EventArgs) Handles addedTimer.Tick
        addedTimer.Stop()
        addButtonChange("default")

    End Sub
    Sub addButtonChange(x As String)
        if x = "success" Then
            ColorMode = "btn_addBook_success"
            colorMASTER.Start()
            btnINSERT.Image = my.Resources.Resources.approval_96px
            btnINSERT.Text = "Eklendi!"
            colorMASTER_Stopper.Start()
            addedTimer.Start()
        Elseif x = "error"
            ColorMode = "btn_addBook_error"
            colorMASTER.Start()
            btnINSERT.Image = my.Resources.Resources.cancel_64px
            btnINSERT.Text = "HATA!"
            colorMASTER_Stopper.Start()
            addedTimer.Start()
        Else
            btnINSERT.Image = my.Resources.Resources.forward_96px
            btnINSERT.Text = "Ekle"
        End If

    End Sub

    Private Sub colorMASTER_Tick(sender As Object, e As EventArgs) Handles colorMASTER.Tick
        colorMASTER.Interval = colorMode_Speed
        if ColorMode = "btn_addBook_error" Then
            If btnINSERT.LineColor = Color.FromArgb(4, 175, 175) Then
                btnINSERT.LineColor = color.Crimson
            Else
                btnINSERT.LineColor = Color.FromArgb(4, 175, 175)
            end if
        ElseIf ColorMode = "btn_addBook_success" Then
            If btnINSERT.LineColor = Color.FromArgb(4, 175, 175) Then
                btnINSERT.LineColor = color.MidnightBlue
            Else
                btnINSERT.LineColor = color.FromArgb(4, 175, 175)
            End If
        Else
            btnINSERT.LineColor = color.FromArgb(4, 175, 175)
        End If

    End Sub


    Private Sub colorMASTER_Stopper_Tick(sender As Object, e As EventArgs) Handles colorMASTER_Stopper.Tick
        Default_EntityColor()
        Default_EntityValues()
        colorMASTER.Stop()
    End Sub
    Sub Default_EntityColor

        btnINSERT.LineColor = Color.FromArgb(4, 175, 175)
    End Sub
    Sub Default_EntityValues
        colorMode_Speed = 500
        selenium_bookname = " "
        selenium_author = " "

    End Sub

    Private Sub rate_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub libbo_reset_Tick(sender As Object, e As EventArgs) Handles libbo_reset.Tick
        data_isbn = ""
        raw_data = ""
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        My.Settings.session = "user"
        My.Settings.Save
        welcomeSESSION.Text = "welcome, " & My.Settings.session.ToString & "!"
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
         My.Settings.session = "developer"
        My.Settings.Save
         welcomeSESSION.Text = "welcome, " & My.Settings.session.ToString & "!"
    End Sub

    Private Sub GunaLabel11_Click(sender As Object, e As EventArgs) 
     

    End Sub
End Class
