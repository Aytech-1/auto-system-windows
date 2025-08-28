Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Module functions
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim mstream As New MemoryStream
    Dim arrimage() As Byte

    'for connection to the db
    Function connection()
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=auto-system-windows")
        Return conn
    End Function

    'to check email_address in good mail format
    Public Function IsValidEmail(ByVal email As String) As Boolean
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|ng|edu)$"
        Return Regex.IsMatch(email, emailPattern)
    End Function


    'check for email duplication or reuse in database
    Function RegistrationemailCheck(ByVal email As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM user_tab WHERE email_address=@email_address", connection)
        command.Parameters.AddWithValue("@email_address", email)
        reader = command.ExecuteReader
        Dim validateEmail = reader.Read()
        connection.Close()
        Return validateEmail
    End Function

    'check for email duplication or resuse during update
    Function UpdateemailCheck(ByVal email As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM user_tab WHERE email_address=@email_address AND user_id!=@user_id", connection)
        command.Parameters.AddWithValue("@email_address", email)
        command.Parameters.AddWithValue("@user_id", main.profile_id_combo.SelectedValue)
        reader = command.ExecuteReader
        Dim validateEmail = reader.Read()
        connection.Close()
        Return validateEmail
    End Function

    'passport
    Function passport()
        Dim msstream As New System.IO.MemoryStream()
        main.passport.Image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrimage = msstream.GetBuffer()
        Dim filesize As UInt32
        filesize = msstream.Length
        msstream.Close()
        Return arrimage
    End Function

    'to count users in and from the database
    Function countId(ByVal counter_id As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("UPDATE counter_tab SET counter_value=counter_value+1 WHERE counter_id=@counter_id", connection)
        command.Parameters.AddWithValue("@counter_id", counter_id)
        reader = command.ExecuteReader
        connection.Close()

        connection.Open()
        command = New MySqlCommand("SELECT counter_value FROM counter_tab WHERE counter_id=@counter_id", connection)
        command.Parameters.AddWithValue("@counter_id", counter_id)
        reader = command.ExecuteReader
        reader.Read()
        Dim counter_value = reader("counter_value")
        connection.Close()
        Return counter_value
    End Function


    'for clear buttons
    Public Sub clearFunction()
        main.full_name_txt.Text = ""
        main.email_address_txt.Text = ""
        main.phone_number_txt.Text = ""
        main.profile_id_combo.Text = "SELECT USER"
        main.passport.Image = Nothing
    End Sub

    Public Sub clearFunction2()
        main.full_name_txt.Text = ""
        main.email_address_txt.Text = ""
        main.phone_number_txt.Text = ""
        main.passport.Image = Nothing
    End Sub


    'to call user id to the profile combo 
    Public Sub getUserIds()
        Dim DT As New DataTable
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM user_tab  ", connection)
        DT.Load(command.ExecuteReader)
        connection.Close()

        Dim defaultRow As DataRow = DT.NewRow()
        defaultRow("user_id") = ""
        defaultRow("full_name") = "SELECT USER"
        defaultRow("email_address") = ""
        defaultRow("phone_number") = ""
        defaultRow("created_time") = Date.Now
        defaultRow("updated_time") = Date.Now
        DT.Rows.InsertAt(defaultRow, 0)

        main.profile_id_combo.DataSource = DT
        main.profile_id_combo.DisplayMember = "full_name"
        main.profile_id_combo.ValueMember = "user_id"
    End Sub
    'to insert into the database
    Public Sub Registration()
        'allow passport to save
        functions.passport()

        Dim userId = "USER" + Now.ToString("yyyyMMddss") & functions.countId("USER")

        Try
            Dim connection = functions.connection
            Dim query As String

            connection.Open()
            query = "INSERT INTO user_tab (user_id, full_name, email_address, phone_number, passport, created_time) VALUES (@user_id, @full_name,@email_address,@phone_number,@passport,NOW())"
            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@user_id", userId)
            Command.Parameters.AddWithValue("@full_name", main.full_name_txt.Text.ToUpper())
            Command.Parameters.AddWithValue("@email_address", main.email_address_txt.Text)
            Command.Parameters.AddWithValue("@phone_number", main.phone_number_txt.Text)
            Command.Parameters.AddWithValue("@passport", arrimage)
            reader = Command.ExecuteReader
            connection.Close()

            MsgBox("User Registration successful!")

            GetRecordCount()
            clearFunction()
            getUserIds()

        Catch ex As Exception
            MsgBox("User Registration failed: " & ex.Message)
        End Try
    End Sub


    Public Sub SetupDataGridView()
        ' Add columns
        user_record.record_grid.Columns.Add("sn", "S/N")
        user_record.record_grid.Columns.Add("user_id", "USER_ID")
        user_record.record_grid.Columns.Add("full_name", "FULL_NAME")
        user_record.record_grid.Columns.Add("email_address", "EMAIL_ADDRESS")
        user_record.record_grid.Columns.Add("phone_number", "PHONE_NO")

        ' Add an image column
        Dim imgColumn As New DataGridViewImageColumn()
        imgColumn.Name = "passport"
        imgColumn.HeaderText = "PASSPORT"
        imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
        user_record.record_grid.Columns.Add(imgColumn)

    End Sub

    'To fetch all users into datagrid
    Public Sub FetchUserData()
        SetupDataGridView()
        Try
            Dim connection = functions.connection

            connection.Open()
            Dim query As String = "SELECT * FROM user_tab"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    Dim sn As String = reader("sn").ToString()
                    Dim userId As String = reader("user_id").ToString()
                    Dim fullName As String = reader("full_name").ToString()
                    Dim email As String = reader("email_address").ToString()
                    Dim mobileNo As String = reader("phone_number").ToString()

                    Dim img As Image = Nothing
                    If reader("passport") IsNot DBNull.Value Then
                        Dim profileImage As Byte() = CType(reader("passport"), Byte())
                        If profileImage.Length > 0 Then
                            img = Image.FromStream(New MemoryStream(profileImage))
                        End If
                    End If

                    ' Add the row to DataGridView
                    user_record.record_grid.Rows.Add(sn, userId, fullName, email, mobileNo, img)
                End While
                connection.Close()
            Else
                MessageBox.Show("No records found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    'to fetch users from the db to the interface
    Public Sub fetchUser()
        Try
            Dim connection = functions.connection
            connection.Open()
            command = New MySqlCommand("SELECT * FROM user_tab WHERE user_id=@user_id", connection)
            command.Parameters.AddWithValue("@user_id", main.profile_id_combo.SelectedValue)
            reader = command.ExecuteReader
            reader.Read()

            main.full_name_txt.Text = reader("full_name")
            main.email_address_txt.Text = reader("email_address")
            main.phone_number_txt.Text = reader("phone_number")
            arrimage = reader("passport")
            mstream = New MemoryStream(arrimage)
            main.passport.Image = Image.FromStream(mstream)
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    'To update individual user's record
    Public Sub Updated()
        functions.passport()
        Try
            Dim connection = functions.connection
            Dim query As String

            connection.Open()
            query = "UPDATE user_tab SET full_name=@full_name,email_address=@email_address,phone_number=@phone_number,passport=@passport WHERE user_id=@user_id"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@user_id", main.profile_id_combo.SelectedValue)
            command.Parameters.AddWithValue("@full_name", main.full_name_txt.Text.ToUpper)
            command.Parameters.AddWithValue("@email_address", main.email_address_txt.Text)
            command.Parameters.AddWithValue("@phone_number", main.phone_number_txt.Text)
            command.Parameters.AddWithValue("@passport", arrimage)
            reader = command.ExecuteReader
            connection.Close()

            MsgBox("User Update Successful !")
            clearFunction()
            getUserIds()
        Catch ex As Exception
            MessageBox.Show("User Upadate Failed:: " & ex.Message)
        End Try
    End Sub

    'To count all record of user from the database
    Public Sub GetRecordCount()
        Dim connection = functions.connection
        Dim query As String

        connection.Open()
        query = "SELECT COUNT(*) FROM user_tab"
        command = New MySqlCommand(query, connection)
        main.count_label.Text = command.ExecuteScalar()
        user_record.count_label.Text = command.ExecuteScalar()
        connection.Close()
    End Sub

    'to delete an individual user 
    Public Sub deleteUser()
        Try
            Dim connection = functions.connection
            Dim query As String

            connection.Open()
            query = "DELETE FROM user_tab WHERE user_id=@user_id"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@user_id", main.profile_id_combo.SelectedValue)
            reader = command.ExecuteReader
            connection.Close()

            MsgBox("User Delete Successful !")
            clearFunction()
            GetRecordCount()
            getUserIds()
        Catch ex As Exception
            MessageBox.Show("User Delete Failed:: " & ex.Message)
        End Try
    End Sub
End Module
