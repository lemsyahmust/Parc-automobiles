Imports System.Data
Imports System.Data.SqlClient

Partial Public Class NewUser1
    Inherits System.Web.UI.Page

    Sub Msg_succes(ByVal x As String)
        lblMessage.ForeColor = Drawing.Color.SeaGreen
        lblMessage.Text = ""
        lblMessage.Visible = True
        img_error.Visible = False
        img_succes.Visible = True
        lblMessage.Text = x
    End Sub

    Sub Msg_Erreur(ByVal x As String)
        lblMessage.ForeColor = Drawing.Color.Red
        lblMessage.Text = ""
        lblMessage.Visible = True
        img_succes.Visible = False
        img_error.Visible = True
        lblMessage.Text = x
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnOk_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOk.Click
        If txtbxLoginUT.Text = Nothing And txtbxCIN.Text = Nothing And txtbxPasswordUT.Text = Nothing Then
            Msg_Erreur("vide")
        Else

            Dim req0 As String
            req0 = "select Login,CIN from tc_user where Login ='" & Me.txtbxLoginUT.Text & "' or CIN = '" & txtbxCIN.Text & "'"
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
                Msg_Erreur(" éxsiste déjà ")
                txtbxLoginUT.Text = ""
                txtbxCIN.Text = ""
                con.Close()
            Else
                If txtbxPasswordUT.Text = txtbxConfirm.Text Then

                    cmd = New SqlCommand("insert into tc_user values ('" & txtbxLoginUT.Text & "','" & txtbxCIN.Text & "','" & txtbxNomUT.Text & "','" & txtbxPrenomUT.Text & "','" & txtbxPasswordUT.Text & "','" & txtbxAdress.Text & "','" & txtbxVille.Text & "','Administrateur') ", con)
                    con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                    Msg_succes("Ajout réalisé avec succès")

                Else
                    Msg_Erreur("vérifier le mot de passe")
                    txtbxPasswordUT.Text = ""
                    txtbxConfirm.Text = ""
                End If
            End If

        End If
    End Sub

    Protected Sub btnAnnuler_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAnnuler.Click
        Response.Redirect("Login1.aspx")
    End Sub
End Class