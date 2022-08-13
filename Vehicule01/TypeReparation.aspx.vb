Imports System.Data
Imports System.Data.SqlClient

Partial Public Class WebForm19
    Inherits System.Web.UI.Page

    Function N_L() As Int32
        'retourne l dernier numero du série du pneus plus 1
        Dim m As Int32
        ' Dim con As New SqlConnection(Application("str"))
        Dim cmd As SqlCommand = New SqlCommand("select n_reparation from tc_reparation", con)
        Dim dr As SqlDataReader
        con.Open()
        dr = cmd.ExecuteReader
        While dr.Read()
            m = dr.GetValue(0)
        End While
        dr.Close()
        con.Close()
        Return m
    End Function

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

        'If btnAjoutReparation.Enabled = False Then

        If Not Page.IsPostBack Then

            '*********Type Réparation
            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct lib_reparation From tc_reparation ", con)
            dr = cmd.ExecuteReader
            dr.Read()
            txtbxReparation.Text = dr.Item("lib_reparation")

            dr.Close()
            con.Close()
            'Else
            '    txtbxReparation.Text = ""
        End If


    End Sub

    Protected Sub btnAjoutReparation_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAjoutReparation.Click
        If txtbxReparation.Text = Nothing Then

            Msg_Erreur(" Veuillez remplir les champs ")

        Else
            Dim req0 As String

            req0 = "select lib_reparation from tc_reparation where lib_reparation ='" & Me.txtbxReparation.Text & "' "

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
                Msg_Erreur(" Erreur......!!!?  Ce Type existe deja ")
                con.Close()
            Else


                Try

                    cmd = New SqlCommand("insert into tc_reparation values(" & lblNReparation.Text & ",'" & txtbxReparation.Text & "')", con)

                    con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                    Msg_succes(" Ajout réalisé avec succès ")

                    txtbxReparation.Text = ""

                Catch ex As Exception
                    Msg_Erreur(ex.Message)
                    con.Close()
                End Try
                con.Close()
            End If
        End If

    End Sub

    Private Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = True
        img_suppr.Visible = False

        btnAjoutReparation.Visible = True
        btnAnnulerReparation.Visible = True
        btnsuppReparation.Visible = False

        Dim nn As Integer = N_L()
        lblNReparation.Text = nn + 1

        txtbxReparation.Text = ""
        txtbxReparation.Visible = True
        cbxReparation.Visible = False

        btnAjoutReparation.Enabled = True

    End Sub

    Private Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click

        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = False
        img_suppr.Visible = True

        btnAjoutReparation.Visible = False
        btnAnnulerReparation.Visible = True
        btnsuppReparation.Visible = True

        cbxReparation.Visible = True
        txtbxReparation.Visible = False


        '*********Type Réparation

        cbxReparation.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct lib_reparation,n_reparation From tc_reparation ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        lblNReparation.Text = dr.Item("n_reparation")
        Do
            cbxReparation.Items.Add(dr.Item("lib_reparation"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()
    End Sub

    Private Sub cbxReparation_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxReparation.SelectedIndexChanged
        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct n_reparation,lib_reparation From tc_reparation where  lib_reparation='" & cbxReparation.Text & "' ", con)
            dr = cmd.ExecuteReader
            dr.Read()

            lblNReparation.Text = dr.Item("n_reparation")

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

    Private Sub btnsuppReparation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsuppReparation.Click

        If lblNReparation.Text = Nothing Then

            Msg_Erreur("Sélectionner un type de réparation")
        Else

            Try
                cmd = New SqlCommand("delete  from tc_reparation where n_reparation= '" & lblNReparation.Text & "' and lib_reparation='" & cbxReparation.Text & "' ", con)
                con.Close()
                con.Open()
                dr = cmd.ExecuteReader
                dr.Read()
                Msg_succes("suppression réalisée avec succès")
                dr.Close()
                con.Close()

                '********************************
                txtbxReparation.Text = ""
                cbxReparation.Items.Clear()

                con.Close()
                con.Open()
                cmd = New SqlCommand(" select distinct n_reparation,lib_reparation From tc_reparation ", con)
                dr = cmd.ExecuteReader
                dr.Read()
                ' cbxMarq.Text = dr.Item("lib_marq")

                lblNReparation.Text = dr.Item("n_reparation")
                txtbxReparation.Text = dr.Item("lib_reparation")
                Do
                    cbxReparation.Items.Add(dr.Item("lib_reparation"))

                Loop While (dr.Read)
                dr.Close()
                con.Close()

                '   **************************************

            Catch ex As Exception
                Msg_Erreur(ex.Message)
                con.Close()
            End Try
            dr.Close()
            con.Close()
        End If
    End Sub

End Class