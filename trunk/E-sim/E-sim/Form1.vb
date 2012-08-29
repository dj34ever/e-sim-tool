Option Explicit On

Public Class Form1
    Dim TmpString, S1, Link, SID, CID, IID, QID, Currency As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CBServer.Items.Add("Primera")
        'CBServer.Items.Add("Secura")

        'CBItem.Items.Add("Iron")
        'CBItem.Items.Add("Grain")
        'CBItem.Items.Add("Oil")
        'CBItem.Items.Add("Stone")
        'CBItem.Items.Add("Wood")
        'CBItem.Items.Add("Diamond")
        'CBItem.Items.Add("Weapon")
        'CBItem.Items.Add("House")
        'CBItem.Items.Add("Gift")
        'CBItem.Items.Add("Food")
        'CBItem.Items.Add("Ticket")
        'CBItem.Items.Add("DS")
        'CBItem.Items.Add("Hospital")
        'CBItem.Items.Add("Estate")

        'CBQuality.Items.Add("Q1")
        'CBQuality.Items.Add("Q2")
        'CBQuality.Items.Add("Q3")
        'CBQuality.Items.Add("Q4")
        'CBQuality.Items.Add("Q5")

        'CBCountry.Items.Add("Argentina")
        'CBCountry.Items.Add("Australia")
        'CBCountry.Items.Add("Belgium")
        'CBCountry.Items.Add("Bosnia and Herzegovina")
        'CBCountry.Items.Add("Brazil")
        'CBCountry.Items.Add("Bulgaria")
        'CBCountry.Items.Add("Canada")
        'CBCountry.Items.Add("Chile")
        'CBCountry.Items.Add("China")
        'CBCountry.Items.Add("Colombia")
        'CBCountry.Items.Add("Croatia")
        'CBCountry.Items.Add("Finland")
        'CBCountry.Items.Add("France")
        'CBCountry.Items.Add("Germany")
        'CBCountry.Items.Add("Greece")
        'CBCountry.Items.Add("Hungary")
        'CBCountry.Items.Add("India")
        'CBCountry.Items.Add("Indonesia")
        'CBCountry.Items.Add("Iran")
        'CBCountry.Items.Add("Ireland")
        'CBCountry.Items.Add("Israel")
        'CBCountry.Items.Add("Italy")
        'CBCountry.Items.Add("Latvia")
        'CBCountry.Items.Add("Lithuania")
        'CBCountry.Items.Add("Malasya")
        'CBCountry.Items.Add("Mexico")
        'CBCountry.Items.Add("Netherlands")
        'CBCountry.Items.Add("Norway")
        'CBCountry.Items.Add("Pakistan")
        'CBCountry.Items.Add("Peru")
        'CBCountry.Items.Add("Poland")
        'CBCountry.Items.Add("Portugal")
        'CBCountry.Items.Add("Republic of Macedonia")
        'CBCountry.Items.Add("Romania")
        'CBCountry.Items.Add("Russia")
        'CBCountry.Items.Add("Serbia")
        'CBCountry.Items.Add("Slovenia")
        'CBCountry.Items.Add("South Korea")
        'CBCountry.Items.Add("Spain")
        'CBCountry.Items.Add("Sweden")
        'CBCountry.Items.Add("Switzerland")
        'CBCountry.Items.Add("Taiwan")
        'CBCountry.Items.Add("Turkey")
        'CBCountry.Items.Add("USA")
        'CBCountry.Items.Add("Ukraine")
        'CBCountry.Items.Add("United Kingdom")
        CBServer.SelectedItem = "Primera"
        CBCountry.SelectedItem = "Portugal"
        CBItem.SelectedItem = "Weapon"
        CBQuality.SelectedItem = "Q4"
    End Sub



    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click
        'Verifica qual o servidor selecionado
        If CBServer.SelectedItem.ToString = "Primera" Then
            SID = "primera"
        ElseIf CBServer.SelectedItem.ToString = "Secura" Then
            SID = "secura"
        End If

        'Verifica qual o pais selecionado
        
            If CBCountry.SelectedItem.ToString = "Argentina" Then
            CID = "24"
            Currency = "ARS"
            ElseIf CBCountry.SelectedItem.ToString = "Australia" Then
            CID = "35"
            Currency = "AUD"
            ElseIf CBCountry.SelectedItem.ToString = "Belgium" Then
            CID = "40"
            Currency = "BEF"
            ElseIf CBCountry.SelectedItem.ToString = "Bosnia e Herzegovina" Then
            CID = "13"
            Currency = "BAM"
            ElseIf CBCountry.SelectedItem.ToString = "Brazil" Then
            CID = "23"
            Currency = "BRL"
            ElseIf CBCountry.SelectedItem.ToString = "Bulgaria" Then
            CID = "10"
            Currency = "BGN"
            ElseIf CBCountry.SelectedItem.ToString = "Canada" Then
            CID = "27"
            Currency = "CAD"
            ElseIf CBCountry.SelectedItem.ToString = "Chile" Then
            CID = "45"
            Currency = "CLP"
            ElseIf CBCountry.SelectedItem.ToString = "China" Then
            CID = "28"
            Currency = "CNY"
            ElseIf CBCountry.SelectedItem.ToString = "Colombia" Then
            CID = "46"
            Currency = "COP"
            ElseIf CBCountry.SelectedItem.ToString = "Croatia" Then
            CID = "12"
            Currency = "HRK"
            ElseIf CBCountry.SelectedItem.ToString = "Finland" Then
            CID = "37"
            Currency = "FIM"
            ElseIf CBCountry.SelectedItem.ToString = "France" Then
            CID = "4"
            Currency = "FRF"
            ElseIf CBCountry.SelectedItem.ToString = "Germany" Then
            CID = "3"
            Currency = "DEM"
            ElseIf CBCountry.SelectedItem.ToString = "Greece" Then
            CID = "14"
            Currency = "GRD"
            ElseIf CBCountry.SelectedItem.ToString = "Hungary" Then
            CID = "8"
            Currency = "HUF"
            ElseIf CBCountry.SelectedItem.ToString = "India" Then
            CID = "34"
            Currency = "INR"
            ElseIf CBCountry.SelectedItem.ToString = "Indonesia" Then
            CID = "29"
            Currency = "IDR"
            ElseIf CBCountry.SelectedItem.ToString = "Iran" Then
            CID = "30"
            Currency = "IRR"
            ElseIf CBCountry.SelectedItem.ToString = "Ireland" Then
            CID = "38"
            Currency = "IEP"
            ElseIf CBCountry.SelectedItem.ToString = "Israel" Then
            CID = "33"
            Currency = "NIS"
            ElseIf CBCountry.SelectedItem.ToString = "Italy" Then
            CID = "7"
            Currency = "ITL"
            ElseIf CBCountry.SelectedItem.ToString = "Latvia" Then
            CID = "20"
            Currency = "LVL"
            ElseIf CBCountry.SelectedItem.ToString = "Lithuania" Then
            CID = "19"
            Currency = "LTL"
            ElseIf CBCountry.SelectedItem.ToString = "Malasya" Then
            CID = "42"
            Currency = "MYR"
            ElseIf CBCountry.SelectedItem.ToString = "Mexico" Then
            CID = "25"
            Currency = "MXN"
            ElseIf CBCountry.SelectedItem.ToString = "Netherlands" Then
            CID = "36"
            Currency = "NLG"
            ElseIf CBCountry.SelectedItem.ToString = "Norway" Then
            CID = "43"
            Currency = "NOK"
            ElseIf CBCountry.SelectedItem.ToString = "Pakistan" Then
            CID = "41"
            Currency = "PKR"
            ElseIf CBCountry.SelectedItem.ToString = "Peru" Then
            CID = "44"
            Currency = "PEN"
            ElseIf CBCountry.SelectedItem.ToString = "Poland" Then
            CID = "1"
            Currency = "PLN"
            ElseIf CBCountry.SelectedItem.ToString = "Portugal" Then
            CID = "18"
            Currency = "PTE"
            ElseIf CBCountry.SelectedItem.ToString = "Republic of Macedonia" Then
            CID = "15"
            Currency = "MKD"
            ElseIf CBCountry.SelectedItem.ToString = "Romania" Then
            CID = "9"
            Currency = "RON"
            ElseIf CBCountry.SelectedItem.ToString = "Russia" Then
            CID = "2"
            Currency = "RUB"
            ElseIf CBCountry.SelectedItem.ToString = "Serbia" Then
            CID = "11"
            Currency = "RSD"
            ElseIf CBCountry.SelectedItem.ToString = "Slovenia" Then
            CID = "21"
            Currency = "SIT"
            ElseIf CBCountry.SelectedItem.ToString = "South Korea" Then
            CID = "31"
            Currency = "KRW"
            ElseIf CBCountry.SelectedItem.ToString = "Spain" Then
            CID = "5"
            Currency = "ESP"
            ElseIf CBCountry.SelectedItem.ToString = "Sweden" Then
            CID = "17"
            Currency = "SEK"
            ElseIf CBCountry.SelectedItem.ToString = "Switzerland" Then
            CID = "39"
            Currency = "CHF"
            ElseIf CBCountry.SelectedItem.ToString = "Taiwan" Then
            CID = "32"
            Currency = "TWD"
            ElseIf CBCountry.SelectedItem.ToString = "Turkey" Then
            CID = "22"
            Currency = "TRY"
            ElseIf CBCountry.SelectedItem.ToString = "USA" Then
            CID = "26"
            Currency = "USD"
            ElseIf CBCountry.SelectedItem.ToString = "Ukraine" Then
            CID = "16"
            Currency = "UAH"
            ElseIf CBCountry.SelectedItem.ToString = "United Kingdom" Then
            CID = "6"
            Currency = "GBP"
            End If

            'Verifica qual o recurso
            If CBItem.SelectedItem.ToString = "Weapon" Then
                IID = "WEAPON"
            ElseIf CBItem.SelectedItem.ToString = "Diamond" Then
                IID = "DIAMONDS"
            ElseIf CBItem.SelectedItem.ToString = "Iron" Then
                IID = "IRON"
            ElseIf CBItem.SelectedItem.ToString = "Grain" Then
                IID = "GRAIN"
            ElseIf CBItem.SelectedItem.ToString = "Oil" Then
                IID = "OIL"
            ElseIf CBItem.SelectedItem.ToString = "Stone" Then
                IID = "STONE"
            ElseIf CBItem.SelectedItem.ToString = "Wood" Then
                IID = "WOOD"
            ElseIf CBItem.SelectedItem.ToString = "House" Then
                IID = "HOUSE"
            ElseIf CBItem.SelectedItem.ToString = "Gift" Then
                IID = "GIFT"
            ElseIf CBItem.SelectedItem.ToString = "Food" Then
                IID = "FOOD"
            ElseIf CBItem.SelectedItem.ToString = "Ticket" Then
                IID = "TICKET"
            ElseIf CBItem.SelectedItem.ToString = "DS" Then
                IID = "DS"
            ElseIf CBItem.SelectedItem.ToString = "Hospital" Then
                IID = "HOSPITAL"
            ElseIf CBItem.SelectedItem.ToString = "Estate" Then
                IID = "ESTATE"
            End If

            'Verifica a qualidade 
            If CBQuality.SelectedItem.ToString = "Q5" Then
                QID = "5"
            ElseIf CBQuality.SelectedItem.ToString = "Q4" Then
                QID = "4"
            ElseIf CBQuality.SelectedItem.ToString = "Q3" Then
                QID = "3"
            ElseIf CBQuality.SelectedItem.ToString = "Q2" Then
                QID = "2"
            ElseIf CBQuality.SelectedItem.ToString = "Q1" Then
                QID = "1"
            End If

            Link = "http://" & SID & ".e-sim.org/productMarket.html?resource=" & IID & "&countryId=" & CID & "&quality=" & QID & ""
            'MsgBox(Link)
            Load_site()


    End Sub

    Private Sub Load_site()
        WebBrowser1.Navigate("" & Link & "")
        TmpString = WebBrowser1.Document.Body.InnerHtml
        If TmpString <> "" Then
            Find_Quantity()
            Find_Money()
        End If
    End Sub

    Private Sub Find_Quantity()

        Dim tmp, striped As String
        tmp = ""
        striped = ""
        tmp = "type=""hidden"" name=""quantity"""
        If InStr(TmpString, "No offers") = 0 Then
            striped = TmpString.Substring(InStr(TmpString, tmp), 47)
            striped = onlyDigits(striped)
            TBQuantity.Text = striped
        Else : TBQuantity.Text = "No offers"
        End If
    End Sub
    Private Sub Find_Money()
        Dim tmp, striped As String
        tmp = ""
        striped = ""
        tmp = Currency
        If InStr(TmpString, "No offers") = 0 Then
            If InStr(TmpString, tmp) - 12 > 0 Then
                striped = TmpString.Substring(InStr(TmpString, tmp) - 12, 12)
                striped = onlyDigits(striped)
                TBMoney.Text = striped / 100
                Label7.Text = Currency
            End If
        Else : TBMoney.Text = "No offers"
        End If
    End Sub
    Function onlyDigits(s As String) As String
        ' Variables needed (remember to use "option explicit").   '
        Dim retval As String    ' This is the return string.      '
        Dim i As Integer        ' Counter for character position. '

        ' Initialise return string to empty                       '
        retval = ""

        ' For every character in input string, copy digits to     '
        '   return string.                                        '
        For i = 1 To Len(s)
            If Mid(s, i, 1) >= "0" And Mid(s, i, 1) <= "9" Then
                retval = retval + Mid(s, i, 1)
            End If
        Next

        ' Then return the return string.                          '
        onlyDigits = retval
    End Function



End Class
