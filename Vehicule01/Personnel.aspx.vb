Imports System.Data
Imports System.Data.SqlClient

Partial Public Class WebForm28
    Inherits System.Web.UI.Page

    Sub Msg_Erreur(ByVal x As String)
        Lblerror.ForeColor = Drawing.Color.Red
        Lblerror.Text = ""
        Lblerror.Visible = True
        img_succes.Visible = False
        img_error.Visible = True
        Lblerror.Text = x
    End Sub

    Sub Msg_succes(ByVal x As String)
        Lblerror.ForeColor = Drawing.Color.SeaGreen
        Lblerror.Text = ""
        Lblerror.Visible = True
        img_error.Visible = False
        img_succes.Visible = True
        Lblerror.Text = x
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If btnAjoutPE.Enabled = False And btnModifierPE.Visible = False Then

            Try

                con.Close()
                con.Open()
                cmd = New SqlCommand(" select Nom,Prenom,Email,Tel,Poste,groupe from Personnel ", con)
                dr = cmd.ExecuteReader
                dr.Read()

                txtbxNom.Text = dr.Item("Nom")
                txtbxPrenom.Text = dr.Item("Prenom")
                txtbxEmail.Text = dr.Item("Email")
                txtbxTel.Text = dr.Item("Tel")
                txtbxPoste.Text = dr.Item("Poste")
                txtbxgroupe.Text = dr.Item("groupe")

                dr.Close()
                con.Close()
            Catch ex As Exception
                Msg_Erreur(ex.Message)
                dr.Close()
                con.Close()
            End Try
            dr.Close()
            con.Close()

        Else

        End If
    End Sub

    Protected Sub btnAjoutPE_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAjoutPE.Click
        If txtbxNom.Text = Nothing Or txtbxEmail.Text = Nothing Then
            Msg_Erreur(" Champs Vides ")
        Else

            Dim req0 As String

            req0 = "select Nom,Email from Personnel where Nom ='" & Me.txtbxNom.Text & "' or Email='" & txtbxEmail.Text & "'"

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
                Msg_Erreur(" Cette personne éxiste déjà ")
                con.Close()
            Else
                Try

                    cmd = New SqlCommand("insert into Personnel(Nom,Prenom,Email,Tel,Poste,groupe) values('" & txtbxNom.Text & "','" & txtbxPrenom.Text & "','" & txtbxEmail.Text & "','" & txtbxTel.Text & "','" & txtbxPoste.Text & "','" & txtbxgroupe.Text & "')", con)

                    con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()
                    Msg_succes(" Ajout réalisé avec succès ")


                    txtbxNom.Text = ""
                    txtbxPrenom.Text = ""
                    txtbxEmail.Text = ""
                    txtbxTel.Text = ""
                    txtbxPoste.Text = ""
                    txtbxgroupe.Text = ""

                    con.Close()
                Catch ex As Exception
                    ' Msg_Erreur("Erreur de ............!!!!!!")
                    Msg_Erreur(ex.Message)
                    con.Close()
                End Try
                con.Close()
            End If
        End If
    End Sub

    Private Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        img_new.Visible = True
        img_mod.Visible = False
        img_suppr.Visible = False

        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False


        btnAjoutPE.Enabled = True
        btnAjoutPE.Visible = True
        btnAnnulerPE.Visible = True
        btnModifierPE.Visible = False
        btnsuppPE.Visible = False

        cbxNom.Visible = False

        txtbxNom.Text = ""
        txtbxPrenom.Text = ""
        txtbxEmail.Text = ""
        txtbxTel.Text = ""
        txtbxPoste.Text = ""
        txtbxgroupe.Text = ""

    End Sub

    Private Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        img_new.Visible = False
        img_mod.Visible = True
        img_suppr.Visible = False

        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False


        btnAjoutPE.Enabled = True
        btnAjoutPE.Visible = False
        btnAnnulerPE.Visible = True
        btnModifierPE.Visible = True
        btnsuppPE.Visible = False

        txtbxNom.Text = ""
        txtbxPrenom.Text = ""
        txtbxEmail.Text = ""
        txtbxTel.Text = ""
        txtbxPoste.Text = ""
        txtbxgroupe.Text = ""

        cbxNom.Visible = True
        txtbxNom.Visible = False


        '*********Nom

        cbxNom.Items.Clear()


        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct Nom From Personnel ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        'txtbxNEtat.Text = dr.Item("n_etat_vehi")
        Do
            cbxNom.Items.Add(dr.Item("Nom"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()

    End Sub

    Protected Sub btnModifierPE_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnModifierPE.Click

        Try
            con.Close()
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update Personnel set Nom='" & txtbxNom.Text & "',Prenom='" & txtbxPrenom.Text & "',Email='" & txtbxEmail.Text & "',Tel='" & txtbxTel.Text & "',Poste='" & txtbxPoste.Text & "',groupe='" & txtbxgroupe.Text & "' where Nom='" & cbxNom.Text & "' "


            cmd.ExecuteNonQuery()
            con.Close()

            Msg_succes("Modification réalisée avec succès")

            '  Response.Redirect("Carburant.aspx")
        Catch ex As Exception
            ' MsgBox(" Stagiaire  ")
            'MsgBox("La Modification et Realiser Avec Succès")
            Msg_Erreur(ex.Message)

            con.Close()
        End Try
        con.Close()

    End Sub

    Private Sub cbxNom_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxNom.SelectedIndexChanged
        Try

            con.Close()
            con.Open()
            cmd = New SqlCommand(" select Nom,Prenom,Email,Tel,Poste,groupe from Personnel where Nom='" & cbxNom.Text & "' ", con)
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxNom.Text = dr.Item("Nom")
            txtbxPrenom.Text = dr.Item("Prenom")
            txtbxEmail.Text = dr.Item("Email")
            txtbxTel.Text = dr.Item("Tel")
            txtbxPoste.Text = dr.Item("Poste")
            txtbxgroupe.Text = dr.Item("groupe")

            dr.Close()
            con.Close()
        Catch ex As Exception
            Msg_Erreur(ex.Message)
            dr.Close()
            con.Close()
        End Try
        dr.Close()
        con.Close()
    End Sub
End Class