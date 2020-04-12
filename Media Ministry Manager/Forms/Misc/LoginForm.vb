﻿Option Strict On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frm_Login
    Dim _dbConnection As SqlConnectionStringBuilder

    Private Sub frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _dbConnection = New SqlConnectionStringBuilder(My.Settings.masterConnectionString)
        reset()
    End Sub

    Private Sub frm_Login_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If My.Settings.KeepLoggedIn Then
            _dbConnection.UserID = My.Settings.Username
            _dbConnection.Password = My.Settings.Password

            btn_LogIn.PerformClick()
        Else
            reset()
        End If
    End Sub

    Private Sub btn_LogIn_Click(sender As Object, e As EventArgs) Handles btn_LogIn.Click
        If My.Settings.KeepLoggedIn Then
            _dbConnection.UserID = My.Settings.Username
            _dbConnection.Password = My.Settings.Password
        Else
            _dbConnection.Password = txt_Password.Text
            _dbConnection.UserID = txt_Username.Text
        End If

        If checkCreds(txt_Username.Text, txt_Password.Text) Then
            Try
                Dim db = New Database(_dbConnection)

                Dim mainForm = New frm_Main(db)
                mainForm.Show()
                bw_SaveSettings.RunWorkerAsync()
            Catch exception As SqlException
                tss_UserFeedback.Text = "Unknown Error. Please try again."
                tss_UserFeedback.ForeColor = Color.Red
                Console.WriteLine("Failed to connect to database: " & exception.Message)
            End Try
        End If

    End Sub

    Private Sub reset()
        chk_KeepLoggedIn.Checked = False
        txt_Username.Clear()
        txt_Password.Clear()
        tss_UserFeedback.Text = "Please enter your log-in information"
        tss_UserFeedback.ForeColor = Color.Black
        txt_Username.Focus()
    End Sub

    Private Sub bw_SaveSettings_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_SaveSettings.DoWork
        My.Settings.KeepLoggedIn = chk_KeepLoggedIn.Checked
        My.Settings.Username = txt_Username.Text
        My.Settings.Password = txt_Password.Text

        My.Settings.Save()
    End Sub

    Private Sub bw_SaveSettings_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw_SaveSettings.RunWorkerCompleted
        Me.Hide()
        reset()
    End Sub

    Private Sub txt_Password_GotFocus(sender As Object, e As EventArgs) Handles txt_Password.GotFocus
        txt_Password.Select(0, txt_Password.TextLength)
    End Sub

    Private Sub btn_CreateUser_Click(sender As Object, e As EventArgs) Handles btn_CreateUser.Click
        Dim createForm = New frm_CreateUser()
        createForm.Show()
        Me.Hide()
        reset()
    End Sub

    Private Sub btn_ChangePassword_Click(sender As Object, e As EventArgs) Handles btn_ChangePassword.Click
        Dim password = New frm_ChangePassword()
        password.Show()
        Me.Hide()
        reset()
    End Sub

    Private Function checkCreds(username As String, password As String) As Boolean
        Try
            Dim db As Database = New Database(username, password)
            db.Close()
            Return True
        Catch e As SqlException
            tss_UserFeedback.Text = "Username/Password was inccorect. Please try again."
            tss_UserFeedback.ForeColor = Color.Red
            Console.WriteLine(e.Message)
            txt_Password.Text = ""
            txt_Password.Focus()
            Return False
        End Try
    End Function

    'creating a login for a user in the database
    'CREATE USER [NAME] WITH PASSWORD = [PASSWORD]

    'granting permissions in database
    'GRANT [PERMISSION-NAME] ON [OBJECT-NAME] TO [USER/ROLE-TYPE]

    'chaging the passwords
    'ALTER USER [USER] WITH PASSWORD = [NEW-PASSWORD]
End Class