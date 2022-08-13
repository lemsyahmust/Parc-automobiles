Imports System.Data
Imports System.Data.SqlClient

Partial Public Class Login1
    Inherits System.Web.UI.Page

    Public Sub valider()

        If (Trim(txtbxLoginSC.Text) = Nothing) Then
            txtbxLoginSC.BackColor = Drawing.Color.Red
            Label2.Visible = True

            Label2.Text = "Login Incorrect"
            Exit Sub
        Else
            txtbxLoginSC.BackColor = Drawing.Color.White
        End If

        If (Trim(txtbxPasswordSC.Text) = Nothing) Then
            txtbxPasswordSC.BackColor = Drawing.Color.Red
            Label2.Visible = True
            Label2.Text = "Password Incorrect"
            Exit Sub
        Else
            txtbxPasswordSC.BackColor = Drawing.Color.White
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtbxLoginSC.Focus()

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        valider()

        con.Open()

        cmd = New SqlCommand("select Login,Passe,Role from tc_user ", con)
        dr = cmd.ExecuteReader

        Try

            If (txtbxLoginSC.Text <> Nothing And txtbxPasswordSC.Text <> Nothing And DropDownList1.Text = "Administrateur") Then

                Dim req0 As String
                req0 = "select Login,Passe,Role from tc_user where Login ='" & Me.txtbxLoginSC.Text & "' and Passe = '" & txtbxPasswordSC.Text & "' and Role='Administrateur'"
                Dim cmd0 As New SqlCommand(req0, con)
                con.Close()
                con.Open()
                Dim dr0 As SqlDataReader
                dr0 = cmd0.ExecuteReader
                Dim trouve As Boolean
                trouve = False

                Do While dr0.Read

                    trouve = True

                Loop

                dr0.Close()
                If trouve = True Then

                    Response.Redirect("Image.aspx")

                End If

            End If

            If (txtbxLoginSC.Text <> Nothing And txtbxPasswordSC.Text <> Nothing And DropDownList1.Text = "Utilisateur") Then

                Dim req0 As String
                req0 = "select Login,Passe,Role from tc_user where Login ='" & Me.txtbxLoginSC.Text & "' and Passe = '" & txtbxPasswordSC.Text & "' and Role='Utilisateur'"
                Dim cmd0 As New SqlCommand(req0, con)
                con.Close()
                con.Open()
                Dim dr0 As SqlDataReader
                dr0 = cmd0.ExecuteReader
                Dim trouve As Boolean
                trouve = False

                Do While dr0.Read

                    trouve = True

                Loop

                dr0.Close()
                If trouve = True Then
                    Response.Redirect("Login1.aspx")
                    ' Response.Redirect("ChauffVehi.aspx")

                End If

            End If

            dr.Close()
            con.Close()

        Catch ex As Exception

            Label5.Text = ex.Message

            dr.Close()

            con.Close()
        End Try
        dr.Close()
        con.Close()
    End Sub
End Class