
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient


Module Validation

    Private ReadOnly host As String = "localhost"
    Private ReadOnly user As String = "root"
    Private ReadOnly password As String = ""
    Private ReadOnly database As String = "details_db"
    Public Connect = New MySqlConnection
    Public command = New MySqlCommand
    Public connect1 = New MySqlConnection
    Public connect2 = New MySqlConnection
    Public connect3 = New MySqlConnection
    Public command1 = New MySqlCommand



    Public Sub connectdb()

        'database connect
        Connect = New MySqlConnection()

        Dim str As String = String.Format("host={0};user={1};password={2};database={3};Charset=utf8;", host, user, password, database)

        Connect.connectionstring = str


        Try
            If connect1.state = ConnectionState.Closed Then
                connect1.connectionstring = str


                connect1.open()


            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


        Try
            If Connect.state = ConnectionState.Closed Then
                Connect.connectionstring = str


                Connect.open()

            End If


        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Try
            If Connect2.state = ConnectionState.Closed Then
                Connect2.connectionstring = str


                Connect2.open()

            End If


        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


        Try
            If connect3.state = ConnectionState.Closed Then
                connect3.connectionstring = str


                connect3.open()

            End If


        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub




    Public Function con_tb_NewItem() As List(Of GridView_clss)

        Dim getcolumn As New List(Of GridView_clss)
        connectdb()
        Dim q = "select * from item_tb;"
        Dim command As New MySqlCommand(q, Connect)
        Dim Result = command.ExecuteReader
        If Result.HasRows Then
            While Result.Read
                getcolumn.Add(New GridView_clss With {.I_code = Result("I_Code"), .C_Name = Result("I_Name"), .I_Name_Sin = Result("I_Name_Sin")})

            End While
        End If
        Result.Close()
        Return getcolumn
        Connect.close()

    End Function





    Public Function con_table() As List(Of GridView_clss)

        Dim getcolumn As New List(Of GridView_clss)
        connectdb()
        Dim q = "SELECT Date,Id, I_Code, Name,S_Name, Quantity, M_Price, O_Price FROM inventory WHERE active = 1;"

        Dim command As New MySqlCommand(q, Connect)
        Dim Result = command.ExecuteReader
        If Result.HasRows Then
            While Result.Read
                getcolumn.Add(New GridView_clss With {.D = Result("Date"), .Code = Result("I_Code"), .C_Name = Result("Name"), .I_Name_Sin = Result("S_Name"), .Quentity = Result("Quantity"), .Market_Price = Result("M_Price"), .Our_Price = Result("O_Price")})

            End While
        End If
        Result.Close()
        Return getcolumn
        Connect.close()

    End Function


    Public Function IsSinhala(text As String) As Boolean

        Dim pattern As String = "([\u0D80-\u0DFF])+"
        Dim match As Match = Regex.Match(text, pattern)
        If match.Success Then
            Return True
        Else
            Return False
        End If
    End Function



    Public Function inv_all() As List(Of GridView_clss)

        Dim getcolumn As New List(Of GridView_clss)
        connectdb()
        Dim q = "SELECT * FROM `inventory` "
        '"WHERE `select_item_tb`.`SI_Name` = @ItemName"
        ' "select * from inventory where 	I_Name.select_item_tb = Name.inventory;"
        Dim command As New MySqlCommand(q, Connect)
        Dim Result = command.ExecuteReader
        If Result.HasRows Then
            While Result.Read
                getcolumn.Add(New GridView_clss With {.D = Result("Date"), .Code = Result("I_Code"), .C_Name = Result("Name"), .Quentity = Result("Quantity"), .Market_Price = Result("M_Price"), .Our_Price = Result("O_Price")})

            End While
        End If
        Result.Close()
        Return getcolumn
        Connect.close()

    End Function




    Public Function unique_Item(ByVal table_name As String, ByVal column_name As String, ByVal textbox_name As String) As Boolean
        'check Item alredy registored or not
        ' if Item registored return false other vise true
        Dim r As Boolean = False

        Dim str = "SELECT COUNT(" + column_name + ") FROM " + table_name + " WHERE " + column_name + "= @I_name"



        Try
            command = New MySqlCommand(str, Connect)

            command.Parameters.AddWithValue("@I_name", textbox_name)

            Dim result As Integer = command.ExecuteScalar()

            If result = 0 Then

                r = True

            End If

            command.Parameters.Clear()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        Return r

    End Function






    Public Function ValidPrice(ByVal price As String) As Boolean
        '  price validation.

        If price = 0 Then
            Return False
        Else
            Dim pattern As String = "^\d+(\.\d{1,2})?$"
            Dim regex As New Regex(pattern)
            If regex.IsMatch(price) Then
                Return True
            Else
                Return False
            End If

        End If
    End Function






    'checking empty text box
    Function checkEmpty(ByVal str As String) As Boolean
        str = str.Trim
        If String.IsNullOrEmpty(str) Then
            Return True

        End If
        Return False
    End Function



    'combine KG and G 
    Function combine_kg(ByVal kg As Integer, ByVal g As Integer)

        Dim que As Integer

        If checkEmpty(kg) = True Then
            kg = 0
        End If
        If checkEmpty(g) = True Then
            g = 0
        End If
        que = ((kg * 1000) + (g))

        Return que
    End Function

    'check kg and g are 0
    Function emp_kg(ByVal kg As Integer, ByVal g As Integer)
        Dim que As Boolean
        If kg = 0 And g = 0 Then
            que = True
        Else
            que = False
        End If

        Return que
    End Function


    'only number input and maximum length is 4
    Public Function numlen(ByVal numbers As String) As Boolean
        Dim pattern As String = "^[0-9]{1,4}$"
        Dim regex As New Regex(pattern)

        If regex.IsMatch(numbers) Then
            Return True
        End If
        Return False
    End Function




    Function combo_empty(ByVal com As ComboBox) As Boolean
        'check combo box value is empty or not
        Dim results As Boolean = True
        If com.SelectedIndex > -1 Then
            results = False
        End If

        Return results


    End Function


    'date check
    Function date_Change(ByVal combo_date As String) As Boolean

        If combo_date = Now() Then
            Return True

        End If
        Return False


    End Function



    'only enter number and maximum 3 digit
    Public Function Valid_g(ByVal numbers As String) As Boolean
        Dim pattern As String = "^[0-9]{1,3}$"
        Dim regex As New Regex(pattern)

        If regex.IsMatch(numbers) Then
            Return True
        End If
        Return False
    End Function


    'validation for maximum length is 4
    Public Function Code_len(ByVal numbers As String) As Boolean
        Dim pattern As String = "^[a-zA-Z0-9]{1,4}$"
        Dim regex As New Regex(pattern)

        If regex.IsMatch(numbers) Then
            Return True
        End If
        Return False
    End Function



    'Name Validation
    Public Function VALID_Name(ByVal name As String) As Boolean
        Dim pattern As String = "^[a-zA-Z]+(?:[\s.'\-,][a-zA-Z]+)*$"
        Dim regex As New Regex(pattern)

        If regex.IsMatch(name) Then
            Return True
        End If
        Return False
    End Function



    'get Item code according to name
    Public Function get_code(ByVal name As String)


        connectdb()
        Dim q = "SELECT I_Code  FROM inventory where Name = '" & name & "';"
        Dim command As New MySqlCommand(q, Connect)
        Dim Result = command.ExecuteReader()
        Dim out As String

        While Result.Read
            out = Result("I_Code")

        End While
        Return out
        Result.Close()

        Connect.close()

    End Function


    'get row index using combo selection
    Public Function GetRowIndexByCondition(dataGridView As DataGridView, columnName As String, searchValue As String) As Integer
        For Each row As DataGridViewRow In dataGridView.Rows
            If row.Cells(columnName).Value IsNot Nothing AndAlso row.Cells(columnName).Value.ToString().Contains(searchValue) Then
                Return row.Index
            End If
        Next
        Return -1 ' If not found
    End Function





    'genarate unique Item Code
    Dim codeCounter As Integer = 1
    Public Function GenerateUniqueCode(inputText As String) As String

        ' Extract the first character from the input text
        Dim firstChar As Char = inputText(0)
        connectdb()
        command = New MySqlCommand
        Dim r As String = "Select count(*) as charcount from inventory where Item_Code like'%" & firstChar & "%'"
        command = New MySqlCommand(r, Connect)




        ' Check if the input text is not empty
        If Not String.IsNullOrEmpty(inputText) Then


            ' Generate a unique code using the first character and the counter
            Dim uniqueCode As String = $"{firstChar}{codeCounter}"
            codeCounter += 1

            ' Return the generated unique code
            Return uniqueCode.ToUpper()

        End If
    End Function







End Module
