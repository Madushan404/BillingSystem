Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Data.SqlTypes
Imports Mysqlx
 Imports Mysqlx.XDevAPI.Common

    Module DBconnection
        Public conn As New MySqlConnection
        Public result As Boolean
        Public Function OpenDb()
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.ConnectionString = ("datasource=localhost;username=root;password=;database=details_db;SslMode=none")
                    conn.Open()
                    result = conn.State
                End If
            Catch ex As Exception
                result = conn.State
            End Try

            Return result
        End Function
        Public Function CloseDb()
            conn.Close()
            Return conn.State


        End Function

        Public Function Getusers() As List(Of DatabaseData)

            Dim s_details As New List(Of DatabaseData)


            Dim command As New MySqlCommand
        Dim A = "SELECT * FROM customer_tb"
        command = New MySqlCommand(A, conn)
        Dim result = command.ExecuteReader



        For Each i In result
            s_details.Add(New DatabaseData With {.C_Id = result("Customer_ID"), .C_name = result("Customer_Name"), .C_Mobile = result("Mobile_Number"), .O_Details = result("Other_Details")})
        Next
        Return s_details

        result.Close()
    End Function
        Function empty(ByVal str As String) As Boolean
            str = str.Trim
            If String.IsNullOrEmpty(str) Then
                Return True
            End If
            Return False
        End Function
        Public Function Encrypt(Encryption As String) As String
            Dim msg As String = String.Empty
            Dim encode As Byte() = New Byte(Encryption.Length - 1) {}
            encode = Encoding.UTF8.GetBytes(Encryption)
            msg = Convert.ToBase64String(encode)
            Return msg
        End Function

    Public Function Decrypt(Decryption As String) As String
        Dim decrypttext As String = String.Empty
        Dim encodedtxt As New UTF32Encoding()
        Dim decode As Decoder = encodedtxt.GetDecoder()
        Dim code_byte As Byte() = Convert.FromBase64String(Decryption)
        Dim charcount As Integer = decode.GetCharCount(code_byte, 0, code_byte.Length)
        Dim decode_char As Char() = New Char(charcount - 1) {}
        decode.GetChars(code_byte, 0, code_byte.Length, decode_char, 0)
        decrypttext = New String(decode_char)
        Return decrypttext
    End Function

End Module


