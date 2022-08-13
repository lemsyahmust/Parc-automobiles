Imports System.Data
Imports System.Data.SqlClient

Partial Public Class WebForm4

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

    Protected Sub btnAjout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAjout.Click

        If txtbxmarq.Text = Nothing Or txtbxNbrPlace.Text = Nothing Then

            Msg_Erreur(" Veuillez remplir les champs ")

        Else

            Dim req0 As String

            req0 = "select lib_marq from marque where lib_marq ='" & Me.txtbxmarq.Text & "'"

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
                Msg_Erreur(" La marque de ce véhicule éxiste déjà ")
                con.Close()
            Else
                Try

                    cmd = New SqlCommand("insert into marque values (0001,'" & txtbxmarq.Text & "','" & txtbxNbrPlace.Text & "') ", con)
                    con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()
                    Msg_succes(" Ajout réalisé avec succès ")
                    txtbxmarq.Text = ""
                    txtbxNbrPlace.Text = ""
                Catch ex As Exception
                    ' Msg_Erreur("Erreur de ............!!!!!!")
                    Msg_Erreur(ex.Message)
                End Try
            End If
        End If

    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        cbxMarq.Visible = False
        txtbxmarq.Visible = True

        img_new.Visible = True
        img_suppr.Visible = False

        btnAjout.Visible = True
        btnsupp.Visible = False
        btnAnnuler.Visible = True

    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        cbxMarq.Visible = True
        txtbxmarq.Visible = False

        img_new.Visible = False
        img_suppr.Visible = True

        btnAjout.Visible = False
        btnsupp.Visible = True
        btnAnnuler.Visible = True

        cbxMarq.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct lib_marq From marque ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        Do
            cbxMarq.Items.Add(dr.Item("lib_marq"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load


    End Sub

    Protected Sub cbxMarq_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxMarq.SelectedIndexChanged

        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct lib_marq,nbr_place From marque where  lib_marq='" & cbxMarq.Text & "' ", con)
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxNbrPlace.Text = dr.Item("nbr_place")

            dr.Close()
            con.Close()
        Catch ex As Exception
            Msg_Erreur(ex.Message)
            con.Close()
        End Try
        con.Close()
    End Sub

    Protected Sub btnsupp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnsupp.Click

        Try

            cmd = New SqlCommand("delete  from marque where lib_marq= '" & cbxMarq.Text & "'", con)
            con.Close()
            con.Open()
            dr = cmd.ExecuteReader
            dr.Read()
            Msg_succes("suppression réalisée avec succès")
            txtbxmarq.Text = ""
            txtbxNbrPlace.Text = ""

            dr.Close()
            con.Close()

            '********************************
            cbxMarq.Items.Clear()


            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct lib_marq,nbr_place From marque ", con)
            dr = cmd.ExecuteReader
            dr.Read()
            ' cbxMarq.Text = dr.Item("lib_marq")
            txtbxNbrPlace.Text = dr.Item("nbr_place")
            Do
                cbxMarq.Items.Add(dr.Item("lib_marq"))

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
End Class