Imports System.Data
Imports System.Data.SqlClient

Partial Public Class WebForm25
    Inherits System.Web.UI.Page

    Function N_L() As Int32
        'retourne l dernier numero du série du pneus plus 1
        Dim m As Int32
        ' Dim con As New SqlConnection(Application("str"))
        Dim cmd As SqlCommand = New SqlCommand("select N_RepT from ReparationT", con)
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
        ' Dim con As New SqlConnection(Application("str"))
        Dim cmd As SqlCommand = New SqlCommand("select N_cons from consommation", con)
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

        If btnAjoutReparation.Enabled = False And btnsuppReparation.Enabled = False And btnModifierReparation.Enabled = False Then
            '********* Afficher Réparation
            Try

                con.Close()
                con.Open()
                cmd = New SqlCommand(" SELECT dbo.ReparationT.mat_vehi, dbo.ReparationT.n_rep, dbo.Reparateur.lib_reparateur, dbo.ReparationT.Ref, dbo.ReparationT.Descp, dbo.ReparationT.Date, dbo.ReparationT.Prix, dbo.ReparationT.n_cons, dbo.ReparationT.N_RepT, dbo.ReparationT.n_cons FROM dbo.ReparationT INNER JOIN dbo.Reparateur ON dbo.ReparationT.n_rep = dbo.Reparateur.n_reparateur ", con)
                dr = cmd.ExecuteReader
                dr.Read()

                cbxMatricule.Items.Add(dr.Item("mat_vehi"))
                cbxReparateur.Items.Add(dr.Item("lib_reparateur"))
                'cbxTypeRep.Items.Add(dr.Item("lib_reparation"))

                txtbxRef.Text = dr.Item("Ref")
                txtbxDescp.Text = dr.Item("Descp")
                txtbxDate.Text = dr.Item("Date")
                txtbxPrix.Text = dr.Item("Prix")


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
            'txtbxDate.Text = ""
            'txtbxDescp.Text = ""
            'txtbxPrix.Text = ""
            'txtbxRef.Text = ""
        End If

    End Sub

    Private Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click

        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = True
        img_mod.Visible = False
        img_suppr.Visible = False

        btnAjoutReparation.Visible = True
        btnAjoutReparation.Enabled = True
        btnAnnulerReparation.Visible = True
        btnsuppReparation.Visible = False
        btnModifierReparation.Visible = False

        lblNReparation.Visible = False
        cbxNReparation.Visible = False

        txtbxDate.Text = ""
        txtbxDescp.Text = ""
        txtbxPrix.Text = ""
        txtbxRef.Text = ""

        ''*********Montant SNTL

        'lblSNTL.Text = ""

        'con.Close()
        'con.Open()
        '' cmd = New SqlCommand(" select distinct Montant1 From SNTL groupby", con)
        'cmd = New SqlCommand("select distinct NSNTL,Montant1 From SNTL order by NSNTL desc", con)
        'dr = cmd.ExecuteReader
        'dr.Read()
        '' cbxMarq.Text = dr.Item("lib_marq")

        'lblSNTL.Text = dr.Item("Montant1")

        'dr.Close()
        'con.Close()


        '*********Matricule Vehicule

        cbxMatricule.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_vehi,mat_vehi From Vehicule ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        txtbxNVehi.Text = dr.Item("n_vehi")
        Do
            cbxMatricule.Items.Add(dr.Item("mat_vehi"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


        '*********Reparateur

        cbxReparateur.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_reparateur,lib_reparateur From Reparateur ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")

        txtbxReparateur.Text = dr.Item("n_reparateur")

        Do
            cbxReparateur.Items.Add(dr.Item("lib_reparateur"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


        '*********Type Réparation (Intervention)

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_reparation,lib_reparation From tc_reparation ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        ' txtbxTypeRep.Text = dr.Item("n_reparation")
        Do
            ListBox1.Items.Add(dr.Item("lib_reparation"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


        ''*********Etat Vehicule

        'cbxetatVehi.Items.Clear()

        'con.Close()
        'con.Open()
        'cmd = New SqlCommand(" select distinct n_etat_vehi,lib_etat_vehi From etat_vehicule ", con)
        'dr = cmd.ExecuteReader
        'dr.Read()
        '' cbxMarq.Text = dr.Item("lib_marq")
        'txtbxNEtat.Text = dr.Item("n_etat_vehi")
        'Do
        '    cbxetatVehi.Items.Add(dr.Item("lib_etat_vehi"))

        'Loop While (dr.Read)
        'dr.Close()
        'con.Close()


        Dim n As Integer = N_L()
        lblNRepT.Text = n + 1

        Dim nn As Integer = N_L2()
        lblncons.Text = nn + 1

    End Sub

    Private Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click

        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = False
        img_mod.Visible = False
        img_suppr.Visible = True

        btnAjoutReparation.Visible = False
        btnAnnulerReparation.Visible = True
        btnsuppReparation.Visible = True
        btnsuppReparation.Enabled = True
        btnModifierReparation.Visible = False

        txtbxDate.Text = ""
        txtbxDescp.Text = ""
        txtbxPrix.Text = ""
        txtbxRef.Text = ""


        '*********la liste des matricules qui se trouve dans la table Réparation

        cbxMatricule.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct mat_vehi From ReparationT ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        Do
            cbxMatricule.Items.Add(dr.Item("mat_vehi"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()

        '*********Reparateur

        cbxReparateur.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_reparateur,lib_reparateur From Reparateur ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")

        '        txtbxReparateur.Text = dr.Item("n_reparateur")

        Do
            cbxReparateur.Items.Add(dr.Item("lib_reparateur"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


        '*********Type Réparation (Intervention)

        ListBox1.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_reparation,lib_reparation From tc_reparation ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        'txtbxTypeRep.Text = dr.Item("n_reparation")
        Do
            ListBox1.Items.Add(dr.Item("lib_reparation"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


    End Sub

    Private Sub cbxReparateur_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxReparateur.SelectedIndexChanged
        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct n_reparateur,lib_reparateur From Reparateur where  lib_reparateur='" & cbxReparateur.Text & "' ", con)
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxReparateur.Text = dr.Item("n_reparateur")

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

    'Private Sub cbxTypeRep_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxTypeRep.SelectedIndexChanged
    '    Try
    '        con.Close()
    '        con.Open()
    '        cmd = New SqlCommand("SELECT n_reparation,lib_reparation from tc_reparation where  lib_reparation ='" & cbxTypeRep.Text & "'", con)
    '        dr = cmd.ExecuteReader
    '        dr.Read()

    '        txtbxTypeRep.Text = dr.Item("n_reparation")

    '        dr.Close()
    '        con.Close()
    '    Catch ex As Exception
    '        Msg_Erreur(ex.Message)
    '        dr.Close()
    '        con.Close()
    '    End Try
    '    dr.Close()
    '    con.Close()
    'End Sub

    Private Sub btnAjoutReparation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAjoutReparation.Click
        If cbxMatricule.Text = Nothing Then

            Msg_Erreur(" Veuillez remplir le champ ")

        Else

            If txtbxDate.Text <> Nothing Then

                If Not IsDate(Me.txtbxDate.Text) Then
                    Msg_Erreur(" Format date en jj/mm/aa ")
                Else
                    '  If (lblSNTLRes.Text) >= 0 Then

                    'cmd = New SqlCommand("insert into SNTL(Date,Montant1,Montant2) values('" & txtbxDate.Text & "','" & lblSNTLRes.Text & "','" & lblSNTL.Text & "')", con)
                    'con.Close()
                    'con.Open()
                    'cmd.ExecuteNonQuery()
                    'con.Close()

                    cmd = New SqlCommand("insert into ReparationT(N_RepT,mat_vehi,n_rep,Ref,Descp,Date,Prix,n_cons) values(" & lblNRepT.Text & ",'" & cbxMatricule.Text & "'," & txtbxReparateur.Text & ",'" & txtbxRef.Text & "','" & txtbxDescp.Text & "','" & txtbxDate.Text & "','" & txtbxPrix.Text & "'," & lblncons.Text & ")", con)

                    con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                    cmd = New SqlCommand("insert into consommation (N_cons,n_vehi,mat_vehi,montant,N_RepT,Souche,N_fact) values(" & lblncons.Text & "," & txtbxNVehi.Text & ",'" & cbxMatricule.Text & "','" & txtbxPrix.Text & "'," & lblNRepT.Text & ",'" & txtbxSouche.Text & "','" & txtbxNFact.Text & "')", con)

                    con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                    Msg_succes(" Ajout réalisé avec succès ")

                    txtbxDate.Text = ""
                    txtbxDescp.Text = ""
                    txtbxPrix.Text = ""
                    txtbxRef.Text = ""
                    txtbxSouche.Text = ""
                    txtbxNFact.Text = ""

                End If


                'Else
                '    Msg_Erreur("le Montant est Insuffisant")

            End If

                'Else

                'If (lblSNTLRes.Text) >= 0 Then

                '    Try
                '        If Not IsDate(Me.txtbxDate.Text) Then
                '            Msg_Erreur(" Format date et jj/mm/aa ")
                '        Else

                '            cmd = New SqlCommand("insert into SNTL(Date,Montant1,Montant2) values('" & txtbxDate.Text & "','" & lblSNTLRes.Text & "','" & lblSNTL.Text & "')", con)
                '            con.Close()
                '            con.Open()
                '            cmd.ExecuteNonQuery()
                '            con.Close()

                '            cmd = New SqlCommand("insert into ReparationT(N_RepT,mat_vehi,n_rep,Ref,Descp,Date,Prix,n_cons) values(" & lblNRepT.Text & ",'" & cbxMatricule.Text & "'," & txtbxReparateur.Text & ",'" & txtbxRef.Text & "','" & txtbxDescp.Text & "','" & txtbxDate.Text & "','" & txtbxPrix.Text & "'," & lblncons.Text & ")", con)

                '            con.Close()
                '            con.Open()
                '            cmd.ExecuteNonQuery()
                '            con.Close()

                '            cmd = New SqlCommand("insert into consommation (N_cons,n_vehi,mat_vehi,montant,N_RepT,Type) values(" & lblncons.Text & "," & txtbxNVehi.Text & ",'" & cbxMatricule.Text & "','" & txtbxPrix.Text & "'," & lblNRepT.Text & ",'Repar')", con)

                '            con.Close()
                '            con.Open()
                '            cmd.ExecuteNonQuery()
                '            con.Close()

                '            Msg_succes(" Ajout réalisé avec succès ")

                '            txtbxDate.Text = ""
                '            txtbxDescp.Text = ""
                '            txtbxPrix.Text = ""
                '            txtbxRef.Text = ""

                '        End If

                '    Catch ex As Exception
                '        Msg_Erreur(ex.Message)
                '        con.Close()
                '    End Try
                '    con.Close()

                'Else
                '    Msg_Erreur("le Montant et Insuffisant")

                'End If


                ' End If
            End If

    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = False
        img_mod.Visible = True
        img_suppr.Visible = False

        btnAjoutReparation.Visible = False
        btnAnnulerReparation.Visible = True
        btnsuppReparation.Visible = False
        btnModifierReparation.Visible = True
        btnModifierReparation.Enabled = True

        txtbxDate.Text = ""
        txtbxDescp.Text = ""
        txtbxPrix.Text = ""
        txtbxRef.Text = ""

        '*********la liste des matricules qui se trouve dans la table Réparation

        cbxMatricule.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct mat_vehi From ReparationT ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        Do
            cbxMatricule.Items.Add(dr.Item("mat_vehi"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()

        '*********Reparateur

        cbxReparateur.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_reparateur,lib_reparateur From Reparateur ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        txtbxReparateur.Text = dr.Item("n_reparateur")
        Do
            cbxReparateur.Items.Add(dr.Item("lib_reparateur"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


        '*********Type Réparation (Intervention)

        ListBox1.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_reparation,lib_reparation From tc_reparation ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        ListBox1.Text = dr.Item("n_reparation")
        Do
            ListBox1.Items.Add(dr.Item("lib_reparation"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


    End Sub

    Private Sub cbxMatricule_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxMatricule.SelectedIndexChanged

        If btnModifierReparation.Visible = True Or btnsuppReparation.Visible = True Then

            lblNReparation.Visible = True
            cbxNReparation.Visible = True
            ListBox2.Items.Clear()
            cbxNReparation.Items.Clear()

            Try
                con.Close()
                con.Open()
                ' cmd = New SqlCommand(" SELECT dbo.ReparationT.n_vehi,dbo.ReparationT.mat_vehi, dbo.ReparationT.n_rep, dbo.Reparateur.lib_reparateur, dbo.ReparationT.n_reparation, dbo.tc_reparation.lib_reparation,dbo.ReparationT.Ref, dbo.ReparationT.Descp, dbo.ReparationT.Date, dbo.ReparationT.Prix, dbo.ReparationT.n_cons, dbo.ReparationT.N_RepT, dbo.ReparationT.n_cons FROM dbo.ReparationT INNER JOIN dbo.Reparateur ON dbo.ReparationT.n_rep = dbo.Reparateur.n_reparateur INNER JOIN  dbo.tc_reparation ON dbo.ReparationT.n_reparation = dbo.tc_reparation.n_reparation where mat_vehi='" & cbxMatricule.Text & "' ", con)
                'cmd = New SqlCommand("SELECT dbo.ReparationT.N_RepT, dbo.ReparationT.mat_vehi, dbo.Reparateur.lib_reparateur, dbo.tc_reparation.lib_reparation, dbo.ReparationT.Ref, dbo.ReparationT.Descp,dbo.ReparationT.Date, dbo.ReparationT.Prix, dbo.ReparationT.NFact, dbo.ReparationT.n_cons, dbo.tc_reparation.n_reparation, dbo.Reparateur.n_reparateur FROM dbo.ReparationT INNER JOIN dbo.Reparateur ON dbo.ReparationT.n_rep = dbo.Reparateur.n_reparateur INNER JOIN dbo.tc_reparation ON dbo.ReparationT.n_reparation = dbo.tc_reparation.n_reparation where mat_vehi='" & cbxMatricule.Text & "'", con)
                ' cmd = New SqlCommand("SELECT dbo.ReparationT.mat_vehi,dbo.ReparationT.N_RepT,dbo.Intervention.Lib_Reparation, dbo.ReparationT.n_rep, dbo.Reparateur.lib_reparateur,dbo.ReparationT.Ref, dbo.ReparationT.Descp, dbo.ReparationT.Date, dbo.ReparationT.Prix, dbo.ReparationT.n_cons, dbo.ReparationT.N_RepT, dbo.ReparationT.n_cons  FROM dbo.ReparationT INNER JOIN dbo.Reparateur ON dbo.ReparationT.n_rep = dbo.Reparateur.n_reparateur INNER JOIN dbo.Intervention ON dbo.ReparationT.N_RepT  = dbo.Intervention.N_RepT  where mat_vehi='" & cbxMatricule.Text & "'", con)
                cmd = New SqlCommand("select distinct I.N_RepT,R.mat_Vehi from Intervention I,ReparationT R where I.N_RepT=R.N_RepT  and R.mat_vehi='" & cbxMatricule.Text & "'", con)
                dr = cmd.ExecuteReader
                dr.Read()

                lblNRepT.Text = dr.Item("N_RepT")
               

                Do

                    cbxNReparation.Items.Add(dr.Item("N_RepT"))

                Loop While (dr.Read)

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
        Else
            Try
                con.Close()
                con.Open()
                cmd = New SqlCommand("SELECT n_vehi,mat_vehi from Vehicule where  mat_vehi ='" & cbxMatricule.Text & "'", con)
                dr = cmd.ExecuteReader
                dr.Read()

                txtbxNVehi.Text = dr.Item("n_vehi")


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

    Protected Sub btnModifierReparation_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnModifierReparation.Click
        'If txtbxDate.Text = Nothing Then

        '    If (lblSNTLRes.Text) >= 0 Then

        '        cmd = New SqlCommand("insert into SNTL(Date,Montant1,Montant2) values('" & txtbxDate.Text & "','" & lblSNTLRes.Text & "','" & lblSNTL.Text & "')", con)
        '        con.Close()
        '        con.Open()
        '        cmd.ExecuteNonQuery()
        '        con.Close()

        '        Try

        '            con.Close()
        '            con.Open()
        '            cmd = New SqlCommand("update ReparationT set n_rep='" & txtbxReparateur.Text & "',Ref='" & txtbxRef.Text & "',Descp='" & txtbxDescp.Text & "',Date='" & txtbxDate.Text & "',Prix='" & txtbxPrix.Text & "' where mat_vehi='" & cbxMatricule.Text & "' and n_cons='" & lblncons.Text & "'  ", con)

        '            cmd.ExecuteNonQuery()
        '            con.Close()

        '            Msg_succes("Modification réalisé avec succès")


        '        Catch ex As Exception
        '            Msg_Erreur(ex.Message)
        '            con.Close()
        '        End Try
        '        con.Close()
        '    Else
        '        Msg_Erreur("Le Montant et Insuffisant")

        '    End If


        '  Else


        Try
            If Not IsDate(Me.txtbxDate.Text) Then
                Msg_Erreur(" Format date et jj/mm/aa ")

            Else

                ' If (lblSNTLRes.Text) >= 0 Then

                'cmd = New SqlCommand("insert into SNTL(Date,Montant1,Montant2) values('" & txtbxDate.Text & "','" & lblSNTLRes.Text & "','" & lblSNTL.Text & "')", con)
                'con.Close()
                'con.Open()
                'cmd.ExecuteNonQuery()
                'con.Close()

                con.Close()
                con.Open()
                cmd = New SqlCommand("update ReparationT set n_rep='" & txtbxReparateur.Text & "',Ref='" & txtbxRef.Text & "',Descp='" & txtbxDescp.Text & "',Date='" & txtbxDate.Text & "',Prix='" & txtbxPrix.Text & "' where mat_vehi='" & cbxMatricule.Text & "' and N_RepT='" & cbxNReparation.Text & "'  ", con)
                cmd.ExecuteNonQuery()
                con.Close()


                con.Close()
                con.Open()
                cmd = New SqlCommand("update Consommation set Montant='" & txtbxPrix.Text & "',Souche='" & txtbxSouche.Text & "',N_Fact='" & txtbxNFact.Text & "'  where mat_vehi='" & cbxMatricule.Text & "' and N_RepT='" & cbxNReparation.Text & "'  ", con)
                cmd.ExecuteNonQuery()
                con.Close()


                Msg_succes("Modification réalisé avec succès")

                '    Else
                '    Msg_Erreur("Le Montant et Insuffisant")
                'End If

            End If

        Catch ex As Exception
            Msg_Erreur(ex.Message)
            con.Close()
        End Try
        con.Close()

        'End If

    End Sub

    Private Sub btnsuppReparation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsuppReparation.Click

        Try
            cmd = New SqlCommand("delete  from consommation where n_cons= '" & lblncons.Text & "' and mat_vehi='" & cbxMatricule.Text & "' and N_RepT='" & cbxNReparation.Text & "' ", con)
            con.Close()
            con.Open()
            dr = cmd.ExecuteReader
            dr.Read()
            dr.Close()
            con.Close()

            cmd = New SqlCommand("delete  from ReparationT where N_RepT= '" & cbxNReparation.Text & "' and mat_vehi='" & cbxMatricule.Text & "' and n_cons ='" & lblncons.Text & "' ", con)
            con.Close()
            con.Open()
            dr = cmd.ExecuteReader
            dr.Read()
            dr.Close()
            con.Close()

            cmd = New SqlCommand("delete  from Intervention where N_RepT='" & lblNRepT.Text & "' ", con)
            con.Close()
            con.Open()
            dr = cmd.ExecuteReader
            dr.Read()
            dr.Close()
            con.Close()

            Msg_succes("suppression réalisée avec succès")

        Catch ex As Exception
            Msg_Erreur(ex.Message)
            con.Close()
        End Try
        dr.Close()
        con.Close()

    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click

        If cbxNReparation.Visible = False Then

            Dim req0 As String

            req0 = " select N_RepT,Lib_Reparation from Intervention where N_RepT='" & lblNRepT.Text & "' and Lib_Reparation='" & ListBox1.SelectedItem.Text & "'"

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
                Msg_Erreur("Cette intervention et déjà réparé")
                con.Close()
            Else

                Try
                    con.Close()
                    con.Open()
                    cmd = New SqlCommand("insert into Intervention values ( " & lblNRepT.Text & ",'" & ListBox1.SelectedItem.Text & "')", con)
                    cmd.ExecuteNonQuery()
                    con.Close()

                    ListBox2.Items.Add(ListBox1.SelectedItem.Text)
                    ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)

                Catch ex As Exception
                    Msg_Erreur("Erreur....!!? Veuillez choisir un element de la liste")
                End Try
            End If
        Else
            Try
                con.Close()
                con.Open()
                cmd = New SqlCommand("insert into Intervention values ( " & cbxNReparation.Text & ",'" & ListBox1.SelectedItem.Text & "')", con)
                cmd.ExecuteNonQuery()
                con.Close()

                ListBox2.Items.Add(ListBox1.SelectedItem.Text)
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)

            Catch ex As Exception
                Msg_Erreur("Erreur....!!? Veuillez choisir un element de la liste")
            End Try
        End If
    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click

        If cbxNReparation.Visible = False Then


            Lblerror.Visible = False
            img_error.Visible = False
            img_succes.Visible = False

            Try
                con.Close()
                con.Open()
                cmd = New SqlCommand("delete from intervention where Lib_Reparation='" & ListBox2.SelectedItem.Text & "' and N_RepT=" & lblNRepT.Text & "", con)
                cmd.ExecuteNonQuery()
                con.Close()

                ListBox1.Items.Add(ListBox2.SelectedItem.Text)
                ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)

            Catch ex As Exception

                Msg_Erreur("Erreur....!!? Veuillez choisir un element de la liste")

            End Try
        Else
            Try
                con.Close()
                con.Open()
                cmd = New SqlCommand("delete from intervention where Lib_Reparation='" & ListBox2.SelectedItem.Text & "' and N_RepT=" & cbxNReparation.Text & "", con)
                cmd.ExecuteNonQuery()
                con.Close()

                ListBox1.Items.Add(ListBox2.SelectedItem.Text)
                ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)

            Catch ex As Exception

                Msg_Erreur("Erreur....!!? Veuillez choisir un element de la liste")

            End Try
        End If


    End Sub

    'Protected Sub btnAjoutSouche_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAjoutSouche.Click

    '    Lblerror.Visible = False
    '    img_error.Visible = False
    '    img_succes.Visible = False

    '    If lblncons.Text = "" Or txtbxSouche.Text = "" Then

    '        Msg_Erreur("Veuillez remplir le champs")

    '    Else

    '        Dim req0 As String

    '        req0 = " select N_Cons,Souche from Souche where N_Cons='" & lblncons.Text & "' and Souche='" & txtbxSouche.Text & "'"

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
    '                cmd = New SqlCommand("insert into Souche values ( " & lblncons.Text & ",'" & txtbxSouche.Text & "')", con)
    '                cmd.ExecuteNonQuery()
    '                con.Close()

    '                txtbxSouche.Text = ""

    '            Catch ex As Exception
    '                Msg_Erreur("Erreur....!!?")
    '            End Try
    '        End If

    '    End If
    'End Sub

    'Protected Sub txtbxPrix_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtbxPrix.TextChanged

    '    lblSNTLRes.Text = (lblSNTL.Text.ToString - (Replace(txtbxPrix.Text, ".", ",")))

    'End Sub

    Protected Sub cbxNReparation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxNReparation.SelectedIndexChanged

        ListBox2.Items.Clear()
        '    cbxNReparation.Items.Clear()

        Try
            con.Close()
            con.Open()
            ' cmd = New SqlCommand(" SELECT dbo.ReparationT.n_vehi,dbo.ReparationT.mat_vehi, dbo.ReparationT.n_rep, dbo.Reparateur.lib_reparateur, dbo.ReparationT.n_reparation, dbo.tc_reparation.lib_reparation,dbo.ReparationT.Ref, dbo.ReparationT.Descp, dbo.ReparationT.Date, dbo.ReparationT.Prix, dbo.ReparationT.n_cons, dbo.ReparationT.N_RepT, dbo.ReparationT.n_cons FROM dbo.ReparationT INNER JOIN dbo.Reparateur ON dbo.ReparationT.n_rep = dbo.Reparateur.n_reparateur INNER JOIN  dbo.tc_reparation ON dbo.ReparationT.n_reparation = dbo.tc_reparation.n_reparation where mat_vehi='" & cbxMatricule.Text & "' ", con)
            'cmd = New SqlCommand("SELECT dbo.ReparationT.N_RepT, dbo.ReparationT.mat_vehi, dbo.Reparateur.lib_reparateur, dbo.tc_reparation.lib_reparation, dbo.ReparationT.Ref, dbo.ReparationT.Descp,dbo.ReparationT.Date, dbo.ReparationT.Prix, dbo.ReparationT.NFact, dbo.ReparationT.n_cons, dbo.tc_reparation.n_reparation, dbo.Reparateur.n_reparateur FROM dbo.ReparationT INNER JOIN dbo.Reparateur ON dbo.ReparationT.n_rep = dbo.Reparateur.n_reparateur INNER JOIN dbo.tc_reparation ON dbo.ReparationT.n_reparation = dbo.tc_reparation.n_reparation where mat_vehi='" & cbxMatricule.Text & "'", con)
            cmd = New SqlCommand("SELECT dbo.consommation.N_Fact,dbo.consommation.souche,dbo.ReparationT.mat_vehi,dbo.ReparationT.N_RepT,dbo.Intervention.Lib_Reparation, dbo.ReparationT.n_rep, dbo.Reparateur.lib_reparateur,dbo.ReparationT.Ref, dbo.ReparationT.Descp, dbo.ReparationT.Date, dbo.ReparationT.Prix, dbo.ReparationT.n_cons, dbo.ReparationT.N_RepT, dbo.ReparationT.n_cons  FROM dbo.ReparationT INNER JOIN dbo.Reparateur ON dbo.ReparationT.n_rep = dbo.Reparateur.n_reparateur INNER JOIN dbo.Intervention ON dbo.ReparationT.N_RepT  = dbo.Intervention.N_RepT INNER JOIN dbo.consommation  ON dbo.ReparationT.N_RepT  = dbo.consommation .N_RepT  where dbo.ReparationT.N_RepT='" & cbxNReparation.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()

            lblNRepT.Text = dr.Item("N_RepT")
            lblncons.Text = dr.Item("n_cons")
            cbxReparateur.Text = dr.Item("lib_reparateur")
            txtbxReparateur.Text = dr.Item("n_rep")
            txtbxRef.Text = dr.Item("Ref")
            txtbxDescp.Text = dr.Item("Descp")
            txtbxDate.Text = dr.Item("Date")
            txtbxPrix.Text = dr.Item("Prix")
            txtbxNFact.Text = dr.Item("N_Fact")
            txtbxSouche.Text = dr.Item("Souche")

            '  cbxNReparation.Items.Add(dr.Item("N_RepT"))


            Do

                ListBox2.Items.Add(dr.Item("Lib_Reparation"))
                '  cbxNReparation.Items.Add(dr.Item("N_RepT"))

            Loop While (dr.Read)

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

End Class