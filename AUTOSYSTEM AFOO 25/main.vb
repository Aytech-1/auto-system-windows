Imports System.Text.RegularExpressions
Public Class main

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        functions.clearFunction()
    End Sub

    Private Sub submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit_btn.Click
        Dim answer As DialogResult

        If (full_name_txt.Text = "") Then
            MessageBox.Show("Full name field is required. Kindly fill to proceed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (email_address_txt.Text = "") Then
            MessageBox.Show("Email Address field is required. Kindly fill to proceed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (phone_number_txt.Text = "") Then
            MessageBox.Show("Phone Number field is required. Kindly fill to proceed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not IsValidEmail(email_address_txt.Text.Trim()) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf passport.Image Is Nothing Then
            MessageBox.Show("Please upload a passport photo.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If profile_id_combo.Text = "SELECT USER" Then
                answer = MessageBox.Show("Are you sure you want to save?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If (answer = DialogResult.Yes) Then
                    If functions.RegistrationemailCheck(email_address_txt.Text) Then
                        MessageBox.Show("Email Address already Exist, Kindly Enter a new Email Address to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    ElseIf phone_number_txt.Text.Length <> 11 Then
                        MessageBox.Show("Mobile number must be exactly 11 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        phone_number_txt.Focus() ' Set focus back to the text box
                        Return
                    Else
                        functions.Registration()
                    End If
                End If
            Else
                answer = MessageBox.Show("Are you sure you want to update?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If answer = DialogResult.Yes Then
                    If functions.UpdateemailCheck(email_address_txt.Text) Then
                        MessageBox.Show("Email Address is already Exist, Kindly Enter a new Email Address to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        functions.Updated()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub view_record_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles view_record_btn.Click
        Me.Hide()
        user_record.Show()

    End Sub

    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click

    End Sub

    Private Sub upload_passport_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upload_passport_btn.Click
        'select passport
        Dim fd As New OpenFileDialog
        fd.Filter = "Choose image(*.gif;*.bmp;*.wmf;*.JPEG;*.PNG;*.GIF;*.JPG;)|.jpeg;*.png;*.gif;*.jpg;*.gif;*.bmp;*.wmf;"
        If fd.ShowDialog = DialogResult.OK Then
            passport.Image = Image.FromFile(fd.FileName)
        End If
        fd = Nothing
    End Sub

    Private Sub fetch_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fetch_btn.Click
        If (profile_id_combo.Text = "SELECT USER") Then
            MessageBox.Show("Select a user to fetch!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            functions.fetchUser()
        End If
    End Sub

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        functions.getUserIds()
        functions.GetRecordCount()
    End Sub


    Private Sub full_name_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) AndAlso Not e.KeyChar = " "c Then
            e.Handled = True
            MessageBox.Show("Accepts Only Alphabet")
        End If



    End Sub

    Private Sub phone_number_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        ElseIf phone_number_txt.Text.Length >= 11 AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Cannot Accept More than 11 digits")
        End If


    End Sub


    Private Sub profile_id_combo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles profile_id_combo.KeyPress

        e.Handled = True


    End Sub

    Private Sub delete_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_btn.Click
        Dim answer As DialogResult
        If profile_id_combo.Text = "SELECT USER" Then
            MessageBox.Show("Select a user to delete!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            answer = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If answer = DialogResult.Yes Then
                functions.deleteUser()
            End If


        End If

    End Sub




    Private Sub phone_number_txt_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phone_number_txt.KeyPress
        Dim gunaTextBox = CType(sender, Guna.UI2.WinForms.Guna2TextBox)

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Please enter positive whole numbers only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        
        If gunaTextBox.Text.Length >= 11 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Mobile number cannot exceed 11 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
    End Sub

    Private Sub full_name_txt_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles full_name_txt.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) AndAlso Not e.KeyChar = ChrW(Keys.Space) Then
            e.Handled = True
        End If

    End Sub


    Private Sub profile_id_combo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles profile_id_combo.SelectedValueChanged
        functions.clearFunction2()

    End Sub

    Private Sub profile_id_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles profile_id_combo.SelectedIndexChanged
    End Sub

    Private Sub email_address_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles email_address_txt.TextChanged
        Dim email As String = email_address_txt.Text.Trim()
        Dim match As Match = Regex.Match(email, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|ng|edu)")

        ' Split email before and after @
        Dim parts() As String = email.Split("@"c)

        If parts.Length > 1 Then
            Dim localPart As String = parts(0)

            ' Check if local part is only digits or only letters
            If Regex.IsMatch(localPart, "^\d+$") OrElse Regex.IsMatch(localPart, "^[a-zA-Z]+$") Then
                MessageBox.Show("Error: Part before '@' must contain both letters and digits or special characters.", "Email input verification", MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' Remove everything from "@" onward
                email_address_txt.Text = localPart
                email_address_txt.SelectionStart = email_address_txt.Text.Length ' Keep cursor at end

                Exit Sub
            End If
        End If

        If match.Success AndAlso email.Length > match.Value.Length Then
            email_address_txt.Text = match.Value ' Trim invalid end
            MessageBox.Show("Can't accept any further value", "Email input verification", MessageBoxButtons.OK, MessageBoxIcon.Error)
            email_address_txt.SelectionStart = email_address_txt.Text.Length ' Keep cursor at end
        End If


    End Sub

    Private Sub full_name_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles full_name_txt.TextChanged

    End Sub
End Class