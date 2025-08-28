Imports MySql.Data.MySqlClient
Public Class overlay

    Private Sub overlay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim connection = functions.connection
        Try
            connection.Open()
            If connection.State = ConnectionState.Open Then
                MsgBox("Connection successful.")
            End If
        Catch ex As MySqlException
            MsgBox("Connection failed: " & ex.Message)
            Me.Close()
        Finally
            connection.Close()
        End Try
        main.Show()
    End Sub
End Class
