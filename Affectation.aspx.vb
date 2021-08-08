Imports System.Data
Imports System.Data.SqlClient

Partial Public Class WebForm8
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
        '  If btnAjoutAff.Enabled = False Then

        If Not Page.IsPostBack Then

            '*********Afficher Affectation

            Try


                con.Close()
                con.Open()
                cmd = New SqlCommand(" select distinct lib_aff From Affectation ", con)
                dr = cmd.ExecuteReader
                dr.Read()
                txtbxAff.Text = dr.Item("lib_aff")

                dr.Close()
                con.Close()
            Catch ex As Exception

            End Try
            'Else
            '    txtbxAff.Text = ""
        End If
        con.Close()

    End Sub

    Protected Sub btnAjout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAjoutAff.Click

        If txtbxAff.Text = "" Then

            Msg_Erreur(" Veuillez remplir le champ indiqué ")

        Else

            Dim req0 As String

            req0 = "select lib_aff from Affectation where lib_aff ='" & Me.txtbxAff.Text & "'"

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
                Msg_Erreur(" Ce bénéficiaire existe déjà ")
                con.Close()
            Else
                Try

                    cmd = New SqlCommand("insert into Affectation values ('" & txtbxAff.Text & "') ", con)
                    con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()
                    Msg_succes(" Ajout réalisé avec succès ")

                    txtbxAff.Text = ""
                    txtbxAff.Focus()

                    con.Close()
                Catch ex As Exception
                    ' Msg_Erreur("Erreur de ............!!!!!!")
                    Msg_Erreur(ex.Message)
                    con.Close()
                End Try
                con.Close()
            End If

            con.Close()
        End If

    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = True
        img_suppr.Visible = False

        txtbxAff.Visible = True
        cbxAffect.Visible = False

        btnAjoutAff.Visible = True
        btnAjoutAff.Enabled = True
        btnAnnulerAff.Visible = True
        btnsuppAff.Visible = False

        txtbxAff.Text = ""

    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = False
        img_suppr.Visible = True

        txtbxAff.Visible = False
        cbxAffect.Visible = True

        btnAjoutAff.Visible = False
        btnAnnulerAff.Visible = True
        btnsuppAff.Visible = True

        txtbxAff.Text = ""

        cbxAffect.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct lib_aff From Affectation ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        Do
            cbxAffect.Items.Add(dr.Item("lib_aff"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


    End Sub

    Protected Sub cbxAffect_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxAffect.SelectedIndexChanged

        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct * From Affectation where  lib_aff='" & cbxAffect.Text & "' ", con)
            dr = cmd.ExecuteReader
            dr.Read()


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

    Protected Sub btnsuppAff_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnsuppAff.Click
        Try

            cmd = New SqlCommand("delete  from Affectation where lib_aff= '" & cbxAffect.Text & "'", con)
            con.Close()
            con.Open()
            dr = cmd.ExecuteReader
            dr.Read()
            Msg_succes("suppression réalisée avec succès")
            dr.Close()
            con.Close()

            '********************************
            cbxAffect.Items.Clear()

            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct * From Affectation ", con)
            dr = cmd.ExecuteReader
            dr.Read()
            ' cbxMarq.Text = dr.Item("lib_marq")

            Do
                cbxAffect.Items.Add(dr.Item("lib_aff"))

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

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click

    End Sub
End Class