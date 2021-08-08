Imports System.Data
Imports System.Data.SqlClient

Partial Public Class WebForm5
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

        If Not Page.IsPostBack Then

            '*********Afficher Chauffeur
            Try
                con.Close()
                con.Open()
                cmd = New SqlCommand(" select CIN,Nom,Prenom,num_permis,n_doti,categorie_P from chauffeurV ", con)
                dr = cmd.ExecuteReader
                dr.Read()

                txtbxCIN.Text = dr.Item("CIN")
                txtbxNom.Text = dr.Item("Nom")
                txtbxPrenom.Text = dr.Item("Prenom")
                txtbxNumPermis.Text = dr.Item("num_permis")
                txtbxNDoti.Text = dr.Item("n_doti")
                cbxCatg.Items.Add(dr.Item("categorie_P"))

                dr.Close()
                con.Close()
            Catch ex As Exception
                Msg_Erreur(ex.Message)

                dr.Close()
                con.Close()
            End Try
            dr.Close()
            con.Close()
        End If

    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = True
        img_suppr.Visible = False

        cbxCIN.Visible = False
        txtbxCIN.Visible = True

        cbxCatg.Visible = True
        txtbxcatg.Visible = False



        btnAjoutChauf.Visible = True
        btnsuppChauf.Visible = False
        btnAnnulerChauf.Visible = True

        cbxCatg.Items.Clear()
        cbxCatg.Items.Add("Permis A")
        cbxCatg.Items.Add("Permis B")
        cbxCatg.Items.Add("Permis C")
        cbxCatg.Items.Add("Permis D")

        txtbxNom.Text = ""
        txtbxPrenom.Text = ""
        txtbxNumPermis.Text = ""
        txtbxNDoti.Text = ""
        txtbxcatg.Text = ""
        txtbxCIN.Text = ""

    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = False
        img_suppr.Visible = True

        cbxCIN.Visible = True
        txtbxCIN.Visible = False

        cbxCatg.Visible = False
        txtbxcatg.Visible = True

        cbxCatg.Items.Clear()
        cbxCatg.Items.Add("Permis A")
        cbxCatg.Items.Add("Permis B")
        cbxCatg.Items.Add("Permis C")
        cbxCatg.Items.Add("Permis D")

        btnAjoutChauf.Visible = False
        btnsuppChauf.Visible = True
        btnAnnulerChauf.Visible = True

        txtbxCIN.Text = ""
        txtbxNom.Text = ""
        txtbxPrenom.Text = ""
        txtbxNumPermis.Text = ""
        txtbxNDoti.Text = ""
        txtbxcatg.Text = ""


        cbxCIN.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct CIN From chauffeurV ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        Do
            cbxCIN.Items.Add(dr.Item("CIN"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


    End Sub

    Protected Sub cbxCIN_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxCIN.SelectedIndexChanged

        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct * From chauffeurV where  CIN='" & cbxCIN.Text & "' ", con)
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxNom.Text = dr(2)
            txtbxPrenom.Text = dr(3)
            txtbxNumPermis.Text = dr(4)
            txtbxNDoti.Text = dr(5)
            txtbxcatg.Text = dr(6)

            Lblerror.Visible = False
            img_error.Visible = False
            img_succes.Visible = False

            dr.Close()
            con.Close()
        Catch ex As Exception
            Msg_Erreur(ex.Message)
            con.Close()
        End Try
        con.Close()
    End Sub

    Protected Sub btnAjoutChauf_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAjoutChauf.Click
        If txtbxCIN.Text = Nothing Or txtbxNumPermis.Text = Nothing Or txtbxNDoti.Text = Nothing Then

            Msg_Erreur(" Veuillez remplir les champs ")

        Else

            Dim req0 As String

            req0 = "select CIN from chauffeurV where CIN ='" & Me.txtbxCIN.Text & "' or num_permis='" & txtbxNumPermis.Text & "'"

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
                Msg_Erreur(" Le nom de ce chauffeur existe déjà ")
                con.Close()
            Else
                Try

                    cmd = New SqlCommand("insert into chauffeurV values (0001,'" & txtbxCIN.Text & "','" & txtbxNom.Text & "','" & txtbxPrenom.Text & "','" & txtbxNumPermis.Text & "','" & txtbxNDoti.Text & "','" & cbxCatg.Text & "') ", con)
                    con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()
                    Msg_succes(" Ajout réalisé avec succès ")

                    txtbxNom.Text = ""
                    txtbxPrenom.Text = ""
                    txtbxNumPermis.Text = ""
                    txtbxNDoti.Text = ""
                    txtbxcatg.Text = ""
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

    Protected Sub btnsuppChauf_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnsuppChauf.Click
        Try

            cmd = New SqlCommand("delete  from chauffeurV where CIN= '" & cbxCIN.Text & "'", con)
            con.Close()
            con.Open()
            dr = cmd.ExecuteReader
            dr.Read()
            Msg_succes("suppression réalisée avec succès")
            dr.Close()
            con.Close()

            '********************************
            cbxCIN.Items.Clear()


            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct CIN From chauffeurV ", con)
            dr = cmd.ExecuteReader
            dr.Read()
            ' cbxMarq.Text = dr.Item("lib_marq")

            txtbxNom.Text = ""
            txtbxPrenom.Text = ""
            txtbxNumPermis.Text = ""
            txtbxNDoti.Text = ""
            txtbxcatg.Text = ""
            txtbxCIN.Text = ""

            Do
                cbxCIN.Items.Add(dr.Item("CIN"))

            Loop While (dr.Read)
            dr.Close()
            con.Close()

            '**************************************

        Catch ex As Exception
            Msg_Erreur(ex.Message)
            con.Close()
        End Try
        dr.Close()
        con.Close()

    End Sub

    Protected Sub btnImpChauffV_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnImpChauffV.Click

    End Sub
End Class