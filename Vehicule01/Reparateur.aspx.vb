Imports System.Data
Imports System.Data.SqlClient

Partial Public Class WebForm7
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

            '*********Afficher les données Réparateur 
            Try

                con.Close()
                con.Open()
                cmd = New SqlCommand(" select lib_reparateur,Adresse,Tel,Fax from Reparateur  ", con)
                dr = cmd.ExecuteReader
                dr.Read()

                txtbxRep.Text = dr.Item("lib_reparateur")
                txtbxAdress.Text = dr.Item("Adresse")

                txtbxTel.Text = dr.Item("Tel")
                txtbxFax.Text = dr.Item("Fax")


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

        cbxRep.Visible = False
        txtbxRep.Visible = True

        btnAjoutRepa.Visible = True
        btnsuppRepa.Visible = False
        btnAnnulerRepa.Visible = True


        txtbxRep.Text = ""
        txtbxAdress.Text = ""
        txtbxTel.Text = ""
        txtbxFax.Text = ""


    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = False
        img_suppr.Visible = True

        cbxRep.Visible = True
        txtbxRep.Visible = False

        btnAjoutRepa.Visible = False
        btnsuppRepa.Visible = True
        btnAnnulerRepa.Visible = True


        cbxRep.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct lib_reparateur From Reparateur ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        Do
            cbxRep.Items.Add(dr.Item("lib_reparateur"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()

    End Sub

    Protected Sub btnAjoutRepa_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAjoutRepa.Click
        If txtbxRep.Text = Nothing Or txtbxTel.Text = Nothing Then

            Msg_Erreur(" Veuillez remplir les champs ")

        Else

            Dim req0 As String

            req0 = "select lib_reparateur from Reparateur where lib_reparateur ='" & Me.txtbxRep.Text & "'"

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
                Msg_Erreur(" Ce garagiste éxiste déjà ")
                con.Close()
            Else
                Try

                    cmd = New SqlCommand("insert into Reparateur values (0001,'" & txtbxRep.Text & "','" & txtbxAdress.Text & "','" & txtbxTel.Text & "','" & txtbxFax.Text & "') ", con)
                    con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()
                    Msg_succes(" Ajout réalisé avec succès ")

                    txtbxRep.Text = ""
                    txtbxAdress.Text = ""
                    txtbxTel.Text = ""
                    txtbxFax.Text = ""
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

    Protected Sub cbxRep_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxRep.SelectedIndexChanged
        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct * From Reparateur where  lib_reparateur='" & cbxRep.Text & "' ", con)
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxRep.Text = dr(1)
            txtbxAdress.Text = dr(2)
            txtbxTel.Text = dr(3)
            txtbxFax.Text = dr(4)

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

    Protected Sub btnsuppRepa_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnsuppRepa.Click
        Try

            cmd = New SqlCommand("delete  from Reparateur where lib_reparateur= '" & cbxRep.Text & "'", con)
            con.Close()
            con.Open()
            dr = cmd.ExecuteReader
            dr.Read()
            Msg_succes("suppression réalisée avec succès")
            dr.Close()
            con.Close()

            '********************************
            cbxRep.Items.Clear()


            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct lib_reparateur From Reparateur ", con)
            dr = cmd.ExecuteReader
            dr.Read()
            ' cbxMarq.Text = dr.Item("lib_marq")


            txtbxRep.Text = ""
            txtbxAdress.Text = ""
            txtbxTel.Text = ""
            txtbxFax.Text = ""


            Do
                cbxRep.Items.Add(dr.Item("lib_reparateur"))

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