Imports System.Data
Imports System.Data.SqlClient

Partial Public Class WebForm22
    Inherits System.Web.UI.Page

    Function N_L() As Int32
        'retourne l dernier numero du série du pneus plus 1
        Dim m As Int32
        ' Dim con As New SqlConnection(Application("str"))
        Dim cmd As SqlCommand = New SqlCommand("select N_Huile from Vidange", con)
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

    Function N_L2() As Int32
        'retourne l dernier numero du série du pneus plus 1
        Dim m As Int32
        Dim cmd As SqlCommand = New SqlCommand("select n_cons from consommation", con)
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

        If Not Page.IsPostBack Then

            'lblDateCons.Text = Now.Date

        End If


        'If btnAjoutHuile.Enabled = False And btnModifHuile.Enabled = False Then

        '    '********* Afficher Vidange
        '    Try

        '        con.Close()
        '        con.Open()
        '        cmd = New SqlCommand(" SELECT dbo.Vidange.mat_vehi, dbo.Vidange.n_reparateur, dbo.Reparateur.lib_reparateur, dbo.Vidange.DateD,dbo.Vidange.Km, dbo.Vidange.N_Serie, dbo.Marq_huile.MarqH, dbo.Vidange.Prix,dbo.Vidange.N_Fact FROM dbo.Vidange INNER JOIN dbo.Reparateur ON dbo.Vidange.n_reparateur = dbo.Reparateur.n_reparateur INNER JOIN dbo.Marq_huile ON dbo.Vidange.N_Serie = dbo.Marq_huile.N_serieH", con)
        '        dr = cmd.ExecuteReader
        '        dr.Read()

        '        cbxMatVehiH.Items.Add(dr.Item("mat_vehi"))
        '        cbxRepaH.Items.Add(dr.Item("lib_reparateur"))
        '        txtbxDateH.Text = dr.Item("DateD")
        '        txtbxKm.Text = dr.Item("Km")
        '        'cbxMarH.Items.Add(dr.Item("MarqH"))
        '        txtbxPrixH.Text = dr.Item("Prix")
        '        txtbxNFactH.Text = dr.Item("N_Fact")


        '        dr.Close()
        '        con.Close()
        '    Catch ex As Exception
        '        Msg_Erreur(ex.Message)
        '        dr.Close()
        '        con.Close()
        '    End Try
        '    dr.Close()
        '    con.Close()

        'Else

        '    con.Close()

        'End If

    End Sub

    Private Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = True
        img_suppr.Visible = False
        img_modif.Visible = False

        btnAjoutHuile.Enabled = True
        btnModifHuile.Visible = False
        btnAjoutHuile.Visible = True
        btnAnnulerHuile.Visible = True
        btnsuppHuile.Visible = False

        ' cbxMarH.Items.Clear()
        'cbxMatVehiH.Items.Clear()
        'cbxRepaH.Items.Clear()
        txtbxDateH.Text = ""
        txtbxKm.Text = ""
        txtbxPrixH.Text = ""
        txtbxNFactH.Text = ""

        txtbxNFactH.Visible = True
        cbxFact.Visible = False


        lblmarq.Visible = False
        lblMMarq.Visible = False


        ''*********Montant SNTL

        'lblSNTL.Text = ""

        'con.Close()
        'con.Open()
        ''  cmd = New SqlCommand(" select distinct Montant1 From SNTL ", con)
        'cmd = New SqlCommand("select distinct NSNTL,Montant1 From SNTL order by NSNTL desc", con)
        'dr = cmd.ExecuteReader
        'dr.Read()
        '' cbxMarq.Text = dr.Item("lib_marq")

        'lblSNTL.Text = dr.Item("Montant1")

        'dr.Close()
        'con.Close()


        '*********Reparateur

        cbxRepaH.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_reparateur,lib_reparateur From Reparateur ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        txtbxNreH.Text = dr.Item("n_reparateur")
        Do
            cbxRepaH.Items.Add(dr.Item("lib_reparateur"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()



        '*********Matricule Vehicule

        cbxMatVehiH.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_vehi,mat_vehi From Vehicule ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        txtbxNVehiH.Text = dr.Item("n_vehi")
        Do
            cbxMatVehiH.Items.Add(dr.Item("mat_vehi"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


        ''********* Marque Huile

        'cbxMarH.Items.Clear()

        'con.Close()
        'con.Open()
        'cmd = New SqlCommand(" select distinct N_serieH,MarqH From Marq_huile ", con)
        'dr = cmd.ExecuteReader
        'dr.Read()
        '' cbxMarq.Text = dr.Item("lib_marq")
        'txtbxMarqH.Text = dr.Item("N_serieH")
        'Do
        '    cbxMarH.Items.Add(dr.Item("MarqH"))

        'Loop While (dr.Read)
        'dr.Close()
        'con.Close()

        Dim n As Integer = N_L()
        lblNsérie.Text = n + 1

        Dim nn As Integer = N_L2()
        lblNCons.Text = nn + 1

    End Sub

    Private Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = False
        img_suppr.Visible = True
        img_modif.Visible = False

        btnAjoutHuile.Visible = False
        btnModifHuile.Visible = False
        btnAnnulerHuile.Visible = True
        btnsuppHuile.Visible = True


        '*********Matricule Vehicule

        cbxMatVehiH.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_vehi,mat_vehi From Vehicule ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        txtbxNVehiH.Text = dr.Item("n_vehi")
        Do
            cbxMatVehiH.Items.Add(dr.Item("mat_vehi"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()

        '*********Montant SNTL

        lblSNTL.Text = ""

        con.Close()
        con.Open()
        '  cmd = New SqlCommand(" select distinct Montant1 From SNTL ", con)
        cmd = New SqlCommand("select distinct NSNTL,Montant1 From SNTL order by NSNTL desc", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")

        lblSNTL.Text = dr.Item("Montant1")

        dr.Close()
        con.Close()


        '*********Reparateur

        cbxRepaH.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_reparateur,lib_reparateur From Reparateur ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        txtbxNreH.Text = dr.Item("n_reparateur")
        Do
            cbxRepaH.Items.Add(dr.Item("lib_reparateur"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()

    End Sub

    Private Sub btnAjoutHuile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAjoutHuile.Click
        If cbxMatVehiH.Text = Nothing And txtbxPrixH.Text Then

            Msg_Erreur(" Veuillez remplir les champs ")

        Else

            If txtbxDateH.Text = Nothing Then

                'If (lblSNTLRes.Text) >= 0 Then
                Try
                    'cmd = New SqlCommand("insert into SNTL(Date,Montant1,Montant2) values('" & txtbxDateH.Text & "','" & lblSNTLRes.Text & "','" & lblSNTL.Text & "')", con)
                    'con.Close()
                    'con.Open()
                    'cmd.ExecuteNonQuery()
                    'con.Close()
                    'cmd = New SqlCommand("insert into Vidange values(" & lblNsérie.Text & ",'" & cbxMatVehiH.Text & "','" & lblMMarq.Text & "'," & txtbxNreH.Text & ",'" & txtbxDateH.Text & "','" & txtbxKm.Text & "','" & txtbxPrixH.Text & "','" & txtbxNFactH.Text & "'," & lblNCons.Text & ")", con)


                    cmd = New SqlCommand("insert into Vidange(n_huile,mat_vehi,n_reparateur,DateD,km,Prix,N_Fact,N_cons,nature,Nbrkm,souche,calnbrkm) values(" & lblNsérie.Text & ",'" & cbxMatVehiH.Text & "'," & txtbxNreH.Text & ",'" & txtbxDateH.Text & "','" & txtbxKm.Text & "','" & txtbxPrixH.Text & "','" & txtbxNFactH.Text & "'," & lblNCons.Text & ",'" & cbxNature.Text & "','" & txtbxNbrKm.Text & "','" & txtbxSouche.Text & "','" & lblCalNbrKm.Text & "')", con)
                    con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()


                    cmd = New SqlCommand("insert into consommation (N_cons,n_vehi,mat_vehi,montant,N_Huile,km,dat_cons,n_reparateur,n_fact,souche) values(" & lblNCons.Text & "," & txtbxNVehiH.Text & ",'" & cbxMatVehiH.Text & "','" & txtbxPrixH.Text & "'," & lblNsérie.Text & ",'" & txtbxKm.Text & "','" & txtbxDateH.Text & "'," & txtbxNreH.Text & ",'" & txtbxNFactH.Text & "','" & txtbxSouche.Text & "')", con)

                    con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                    Msg_succes(" Ajout réalisé avec succès ")

                    ' btnAjoutHuile.Enabled = False


                    'txtbxNom.Text = ""
                    'txtbxPrenom.Text = ""
                    'txtbxNumPermis.Text = ""
                    'txtbxNDoti.Text = ""
                    'txtbxcatg.Text = ""

                Catch ex As Exception
                    Msg_Erreur(ex.Message)
                    con.Close()
                End Try
                con.Close()

                'Else
                '    Msg_Erreur("Le Montant et Insuffisant")
                'End If
                con.Close()

            Else

                If Not IsDate(Me.txtbxDateH.Text) Then
                    Msg_Erreur(" Format date et jj/mm/aa ")

                Else

                    'If (lblSNTLRes.Text) >= 0 Then

                    'cmd = New SqlCommand("insert into SNTL(Date,Montant1,Montant2) values('" & txtbxDateH.Text & "','" & lblSNTLRes.Text & "','" & lblSNTL.Text & "')", con)
                    'con.Close()
                    'con.Open()
                    'cmd.ExecuteNonQuery()
                    'con.Close()

                    Try
                        cmd = New SqlCommand("insert into Vidange(n_huile,mat_vehi,n_reparateur,DateD,km,Prix,N_Fact,N_cons,nature,Nbrkm,souche,calnbrkm) values(" & lblNsérie.Text & ",'" & cbxMatVehiH.Text & "'," & txtbxNreH.Text & ",'" & txtbxDateH.Text & "','" & txtbxKm.Text & "','" & txtbxPrixH.Text & "','" & txtbxNFactH.Text & "'," & lblNCons.Text & ",'" & cbxNature.Text & "','" & txtbxNbrKm.Text & "','" & txtbxSouche.Text & "','" & lblCalNbrKm.Text & "')", con)
                        con.Close()
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()


                        cmd = New SqlCommand("insert into consommation (N_cons,n_vehi,mat_vehi,montant,N_Huile,km,dat_cons,n_reparateur,n_fact,souche) values(" & lblNCons.Text & "," & txtbxNVehiH.Text & ",'" & cbxMatVehiH.Text & "','" & txtbxPrixH.Text & "'," & lblNsérie.Text & ",'" & txtbxKm.Text & "','" & txtbxDateH.Text & "'," & txtbxNreH.Text & ",'" & txtbxNFactH.Text & "','" & txtbxSouche.Text & "')", con)

                        con.Close()
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()


                        Msg_succes(" Ajout réalisé avec succès ")

                        ' btnAjoutHuile.Enabled = False


                        'txtbxNom.Text = ""
                        'txtbxPrenom.Text = ""
                        'txtbxNumPermis.Text = ""
                        'txtbxNDoti.Text = ""
                        'txtbxcatg.Text = ""

                    Catch ex As Exception
                        Msg_Erreur(ex.Message)
                        con.Close()
                    End Try
                    con.Close()

                    '    Else

                    '    Msg_Erreur("Le Montant et Insuffisant")
                    'End If

                End If
            End If
        End If
        con.Close()
    End Sub

    Private Sub cbxRepaH_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxRepaH.SelectedIndexChanged
        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct n_reparateur,lib_reparateur From Reparateur where  lib_reparateur='" & cbxRepaH.Text & "' ", con)
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxNreH.Text = dr.Item("n_reparateur")

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

    'Private Sub cbxMarH_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxMarH.SelectedIndexChanged
    '    Try
    '        con.Close()
    '        con.Open()
    '        cmd = New SqlCommand(" select distinct N_SerieH,MarqH From Marq_huile where  MarqH='" & cbxMarH.Text & "' ", con)
    '        dr = cmd.ExecuteReader
    '        dr.Read()

    '        txtbxMarqH.Text = dr.Item("N_SerieH")

    '        Lblerror.Visible = False
    '        img_error.Visible = False
    '        img_succes.Visible = False

    '        dr.Close()
    '        con.Close()
    '    Catch ex As Exception
    '        Msg_Erreur(ex.Message)
    '        con.Close()
    '    End Try
    '    con.Close()
    'End Sub

    Private Sub cbxMatVehiH_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxMatVehiH.SelectedIndexChanged

        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        lblmarq.Visible = True
        lblMMarq.Visible = True

        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand("select distinct n_vehi,lib_marqq,Kilom,mat_vehi from Vehicule where mat_vehi  ='" & cbxMatVehiH.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxNVehiH.Text = dr.Item("n_vehi")
            cbxMatVehiH.Text = dr.Item("mat_vehi")
            lblMMarq.Text = dr.Item("lib_marqq")

            dr.Close()
            con.Close()
        Catch ex As Exception
            Lblerror.Text = ex.Message
            dr.Close()
            con.Close()
        End Try
        dr.Close()
        con.Close()


        If txtbxNFactH.Visible = True Then

            Try
                con.Close()
                con.Open()
                cmd = New SqlCommand("SELECT n_vehi,mat_vehi from Vehicule where  mat_vehi ='" & cbxMatVehiH.Text & "'", con)
                dr = cmd.ExecuteReader
                dr.Read()

                txtbxNVehiH.Text = dr.Item("n_vehi")


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

        If txtbxNFactH.Visible = False Then

            cbxFact.Items.Clear()

            Try
                con.Close()
                con.Open()
                '  cmd = New SqlCommand(" SELECT dbo.Pneus.mat_vehi, dbo.Reparateur.n_reparateur,dbo.Reparateur.lib_reparateur, dbo.Pneus.DateD, dbo.Pneus.DateF, dbo.Pneus.Km, dbo.Marque_Pneus.N_Serie,dbo.Marque_Pneus.Marq_Pneus, dbo.Pneus.Qte,dbo.Pneus.N_Fact, dbo.Pneus.Prix FROM dbo.Pneus INNER JOIN dbo.Marque_Pneus ON dbo.Pneus.N_Serie = dbo.Marque_Pneus.N_Serie INNER JOIN dbo.Reparateur ON dbo.Pneus.n_reparateur = dbo.Reparateur.n_reparateur where mat_vehi='" & cbxMatVehiH.Text & "' ", con)
                ' cmd = New SqlCommand("SELECT dbo.Vidange.mat_vehi, dbo.Vidange.n_reparateur, dbo.Reparateur.lib_reparateur, dbo.Vidange.DateD,dbo.Vidange.Km, dbo.Vidange.N_Serie, dbo.Marq_huile.MarqH, dbo.Vidange.Prix,dbo.Vidange.N_Fact FROM dbo.Vidange INNER JOIN dbo.Reparateur ON dbo.Vidange.n_reparateur = dbo.Reparateur.n_reparateur INNER JOIN dbo.Marq_huile ON dbo.Vidange.N_Serie = dbo.Marq_huile.N_serieH where mat_vehi='" & cbxMatVehiH.Text & "'", con)
                cmd = New SqlCommand("SELECT dbo.vidange.N_Huile ,dbo.Vidange.mat_vehi, dbo.Vidange.n_reparateur, dbo.Reparateur.lib_reparateur, dbo.Vidange.DateD,dbo.Vidange.Km , dbo.Vidange.Prix,dbo.Vidange.N_Fact ,dbo.Vidange.N_Cons,dbo.Vidange.Nature,dbo.Vidange.NbrKm,dbo.Vidange.Souche FROM dbo.Vidange INNER JOIN dbo.Reparateur ON dbo.Vidange.n_reparateur = dbo.Reparateur.n_reparateur INNER JOIN dbo.consommation  ON dbo.Vidange.N_Cons  = dbo.consommation .N_cons where mat_vehi='" & cbxMatVehiH.Text & "' ", con)
                dr = cmd.ExecuteReader
                dr.Read()

                cbxRepaH.Text = dr.Item("lib_reparateur")
                txtbxNreH.Text = dr.Item("n_reparateur")
                txtbxDateH.Text = dr.Item("DateD")
                txtbxKm.Text = dr.Item("Km")
                txtbxPrixH.Text = dr.Item("Prix")
                txtbxNbrKm.Text = dr.Item("NbrKm")
                cbxNature.Text = dr.Item("Nature")
                txtbxSouche.Text = dr.Item("Souche")
                lblNsérie.Text = dr.Item("N_Huile")
                lblNCons.Text = dr.Item("N_Cons")

                'cbxMarH.Text = dr.Item("MarqH")
                'txtbxMarqH.Text = dr.Item("N_Serie")


                Do
                    cbxFact.Items.Add(dr.Item("N_Fact"))
                Loop While dr.Read

                dr.Close()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
            con.Close()
        End If
    End Sub

    Private Sub btnsuppHuile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsuppHuile.Click



    End Sub

    'Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
    '    Lblerror.Visible = False
    '    img_error.Visible = False
    '    img_succes.Visible = False

    '    img_new.Visible = False
    '    img_suppr.Visible = False
    '    img_modif.Visible = True

    '    btnAjoutHuile.Visible = False
    '    btnAnnulerHuile.Visible = True
    '    btnsuppHuile.Visible = False
    '    btnModifHuile.Visible = True
    '    btnModifHuile.Enabled = True

    '    txtbxDateH.Text = ""
    '    txtbxKm.Text = ""
    '    txtbxPrixH.Text = ""
    '    txtbxNFactH.Text = ""

    '    txtbxNFactH.Visible = False
    '    cbxFact.Visible = True

    '    cbxFact.Items.Clear()

    '    '*****************Matricule Vehicule de Table Vidange
    '    cbxMatVehiH.Items.Clear()

    '    con.Close()
    '    con.Open()
    '    cmd = New SqlCommand(" select distinct mat_vehi From Vidange ", con)
    '    dr = cmd.ExecuteReader
    '    dr.Read()
    '    ' cbxMarq.Text = dr.Item("lib_marq")
    '    Do
    '        cbxMatVehiH.Items.Add(dr.Item("mat_vehi"))

    '    Loop While (dr.Read)
    '    dr.Close()
    '    con.Close()


    '    '*********Reparateur
    '    cbxRepaH.Items.Clear()

    '    con.Close()
    '    con.Open()
    '    cmd = New SqlCommand(" select distinct n_reparateur,lib_reparateur From Reparateur ", con)
    '    dr = cmd.ExecuteReader
    '    dr.Read()
    '    ' cbxMarq.Text = dr.Item("lib_marq")
    '    txtbxNreH.Text = dr.Item("n_reparateur")

    '    Do
    '        cbxRepaH.Items.Add(dr.Item("lib_reparateur"))

    '    Loop While (dr.Read)
    '    dr.Close()
    '    con.Close()



    '    ''********* Marque Huile
    '    'cbxMarH.Items.Clear()

    '    'con.Close()
    '    'con.Open()
    '    'cmd = New SqlCommand(" select distinct N_serieH,MarqH From Marq_huile ", con)
    '    'dr = cmd.ExecuteReader
    '    'dr.Read()
    '    '' cbxMarq.Text = dr.Item("lib_marq")
    '    'txtbxMarqH.Text = dr.Item("N_serieH")
    '    'Do
    '    '    cbxMarH.Items.Add(dr.Item("MarqH"))

    '    'Loop While (dr.Read)
    '    'dr.Close()
    '    'con.Close()
    'End Sub

    Private Sub cbxFact_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxFact.SelectedIndexChanged
        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand("SELECT dbo.Vidange.mat_vehi, dbo.Vidange.n_reparateur, dbo.Reparateur.lib_reparateur, dbo.Vidange.DateD,dbo.Vidange.Km, dbo.Vidange.N_Serie, dbo.Marq_huile.MarqH, dbo.Vidange.Prix,dbo.Vidange.N_Fact FROM dbo.Vidange INNER JOIN dbo.Reparateur ON dbo.Vidange.n_reparateur = dbo.Reparateur.n_reparateur INNER JOIN dbo.Marq_huile ON dbo.Vidange.N_Serie = dbo.Marq_huile.N_serieH where n_fact='" & cbxFact.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()

            cbxRepaH.Text = dr.Item("lib_reparateur")
            txtbxNreH.Text = dr.Item("n_reparateur")
            txtbxDateH.Text = dr.Item("DateD")
            txtbxKm.Text = dr.Item("Km")
            'cbxMarH.Text = dr.Item("MarqH")
            'txtbxMarqH.Text = dr.Item("N_Serie")
            txtbxPrixH.Text = dr.Item("Prix")

            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
        con.Close()
    End Sub

    Private Sub btnModifHuile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModifHuile.Click
        If txtbxDateH.Text = Nothing Then

            If (lblSNTLRes.Text) >= 0 Then

                cmd = New SqlCommand("insert into SNTL(Date,Montant1,Montant2) values('" & txtbxDateH.Text & "','" & lblSNTLRes.Text & "','" & lblSNTL.Text & "')", con)
                con.Close()
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                Try
                    con.Close()
                    con.Open()
                    cmd = New SqlCommand("update Vidange set n_reparateur='" & txtbxNreH.Text & "',DateD='" & txtbxDateH.Text & "',Km='" & txtbxKm.Text & "',Prix='" & txtbxPrixH.Text & "' where mat_vehi='" & cbxMatVehiH.Text & "' and N_Fact='" & cbxFact.Text & "'", con)

                    cmd.ExecuteNonQuery()
                    con.Close()
                    Msg_succes("Modification réalisé avec succès")

                Catch ex As Exception
                    Msg_Erreur(ex.Message)
                    con.Close()
                End Try
                con.Close()
            Else
                Msg_Erreur("Le Montant et Insuffisant")
            End If

        Else
            If Not IsDate(Me.txtbxDateH.Text) Then
                Msg_Erreur(" Format date et jj/mm/aa ")

            Else

                If (lblSNTLRes.Text) >= 0 Then

                    cmd = New SqlCommand("insert into SNTL(Date,Montant1,Montant2) values('" & txtbxDateH.Text & "','" & lblSNTLRes.Text & "','" & lblSNTL.Text & "')", con)
                    con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                    Try
                        con.Close()
                        con.Open()
                        cmd = New SqlCommand("update Vidange set n_reparateur='" & txtbxNreH.Text & "',DateD='" & txtbxDateH.Text & "',Km='" & txtbxKm.Text & "',Prix='" & txtbxPrixH.Text & "' where mat_vehi='" & cbxMatVehiH.Text & "' and N_Fact='" & cbxFact.Text & "'", con)

                        cmd.ExecuteNonQuery()
                        con.Close()
                        Msg_succes("Modification réalisé avec succès")

                    Catch ex As Exception
                        Msg_Erreur(ex.Message)
                        con.Close()
                    End Try
                    con.Close()
                Else
                    Msg_Erreur("Le Montant et Insuffisant")
                End If

                End If
        End If
    End Sub

    'Protected Sub btnSouche_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSouche.Click

    '    Lblerror.Visible = False
    '    img_error.Visible = False
    '    img_succes.Visible = False

    '    If lblNCons.Text = "" Or txtbxSouche.Text = "" Then

    '        Msg_Erreur("Veuillez remplir le champs")

    '    Else

    '        Dim req0 As String

    '        req0 = " select N_Cons,Souche from Souche where N_Cons='" & lblNCons.Text & "' and Souche='" & txtbxSouche.Text & "'"

    '        Dim cmd0 As New SqlCommand(req0, con)
    '        con.Close()
    '        con.Open()
    '        Dim dr0 As SqlDataReader
    '        dr0 = cmd0.ExecuteReader
    '        Dim trouve As Boolean
    '        trouve = False

    '        Do While dr0.Read
    '            trouve = True
    '        Loop
    '        dr0.Close()
    '        If trouve = True Then
    '            Msg_Erreur("Cette existe déjà")
    '            con.Close()
    '        Else

    '            Try
    '                con.Close()
    '                con.Open()
    '                cmd = New SqlCommand("insert into Souche values ( " & lblNCons.Text & ",'" & txtbxSouche.Text & "')", con)
    '                cmd.ExecuteNonQuery()
    '                con.Close()

    '                txtbxSouche.Text = ""

    '            Catch ex As Exception
    '                Msg_Erreur("Erreur....!!?")
    '            End Try
    '        End If

    '    End If

    'End Sub

    Protected Sub txtbxPrixH_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtbxPrixH.TextChanged

        ' lblSNTLRes.Text = (lblSNTL.Text.ToString - (Replace(txtbxPrixH.Text, ".", ",")))

    End Sub

    Protected Sub txtbxNbrKm_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtbxNbrKm.TextChanged

        lblCalNbrKm.Text = (Val(txtbxNbrKm.Text) + (Val(txtbxKm.Text)))

    End Sub

End Class