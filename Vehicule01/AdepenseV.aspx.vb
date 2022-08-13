Imports System.Data
Imports System.Data.SqlClient

Partial Public Class WebForm26
    Inherits System.Web.UI.Page

    Function N_L() As Int32
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

    Function N_LL() As Int32
        'retourne l dernier numero du série du pneus plus 1
        Dim f As Int32
        Dim cmd As SqlCommand = New SqlCommand("select n_carb from DepCarburant", con)
        Dim dr As SqlDataReader
        con.Open()
        dr = cmd.ExecuteReader
        While dr.Read()
            f = dr.GetValue(0)
        End While
        dr.Close()
        con.Close()
        Return f
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

            If btnAjoutD.Enabled = False And btnModifierD.Visible = False And btnsuppD.Visible = False Then

                Try

                    con.Close()
                    con.Open()
                    'cmd = New SqlCommand(" SELECT dbo.consommation.n_vehi, dbo.consommation.mat_vehi, dbo.consommation.n_chauf, dbo.chauffeurV.Nom, dbo.consommation.n_aff, dbo.Affectation.lib_aff, dbo.consommation.n_t_cons, dbo.type_cons.lib_t_cons, dbo.consommation.dat_cons, dbo.consommation.montant, dbo.consommation.km, dbo.consommation.observation, dbo.consommation.t_dot FROM dbo.consommation INNER JOIN dbo.chauffeurV ON dbo.consommation.n_chauf = dbo.chauffeurV.n_chauff INNER JOIN dbo.Affectation ON dbo.consommation.n_aff = dbo.Affectation.n_aff INNER JOIN dbo.type_cons ON dbo.consommation.n_t_cons = dbo.type_cons.n_t_cons where dbo.consommation.n_t_cons=1 ", con)
                    cmd = New SqlCommand("SELECT dbo.consommation.N_cons,dbo.consommation.n_carb,dbo.consommation.n_vehi,dbo.consommation.souche, dbo.consommation.mat_vehi, dbo.chauffeurV.Nom, dbo.consommation.dat_cons, dbo.consommation.montant, dbo.consommation.km,  dbo.consommation.observation,dbo.consommation.n_chauf FROM  dbo.consommation INNER JOIN dbo.chauffeurV ON dbo.consommation.n_chauf = dbo.chauffeurV.n_chauff ", con)
                    dr = cmd.ExecuteReader
                    dr.Read()


                    cbxMatVehiP.Items.Add(dr.Item("mat_vehi"))
                    txtbxNVehi.Text = dr.Item("n_vehi")

                    cbxChauf.Items.Add(dr.Item("Nom"))
                    txtbxNChauf.Text = dr.Item("n_chauf")

                    txtbxDate.Text = dr.Item("dat_cons")

                    txtbxMontant.Text = dr.Item("montant")
                    txtbxKm.Text = dr.Item("km")

                    txtbxObsv.Text = dr.Item("observation")

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

        End If

    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = True
        img_mod.Visible = False
        img_suppr.Visible = False

        btnAjoutD.Visible = True
        btnAjoutD.Enabled = True

        btnAnnulerD.Visible = True
        btnsuppD.Visible = False
        btnModifierD.Visible = False
        'btnSuppTT.Visible = False

        txtbxDate.Visible = True
        cbxdate.Visible = False

        lblmarq.Visible = False
        lblMMarq.Visible = False

        'cbxTypeDoti.Items.Clear()
        'cbxTypeDoti.Items.Add("Dotation fixe par semaine")
        'cbxTypeDoti.Items.Add("Dotation fixe par mois")

        txtbxDate.Text = ""
        txtbxMontant.Text = ""
        txtbxKm.Text = ""
        txtbxSouche.Text = ""
        txtbxObsv.Text = ""



        ''*********Montant SNTL

        'lblSNTL.Text = ""

        'con.Close()
        'con.Open()
        ''      cmd = New SqlCommand(" select distinct Montant1 From SNTL ", con)
        'cmd = New SqlCommand("select distinct NSNTL,Montant1 From SNTL order by NSNTL desc", con)
        'dr = cmd.ExecuteReader
        'dr.Read()
        '' cbxMarq.Text = dr.Item("lib_marq")

        'lblSNTL.Text = dr.Item("Montant1")

        'dr.Close()
        'con.Close()


        '*********Matricule Vehicule

        cbxMatVehiP.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_vehi,mat_vehi From Vehicule ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        txtbxNVehi.Text = dr.Item("n_vehi")
        Do
            cbxMatVehiP.Items.Add(dr.Item("mat_vehi"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


        '*********Chauffeur

        cbxChauf.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_chauff,Nom From chauffeurV ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        txtbxNChauf.Text = dr.Item("n_chauff")
        Do
            cbxChauf.Items.Add(dr.Item("Nom"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()

        Dim n As Integer = N_L()
        lblNConsD.Text = n + 1

        Dim ff As Integer = N_LL()
        lblNCarb.Text = ff + 1

    End Sub

    Private Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        img_new.Visible = False
        img_suppr.Visible = True

        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = False
        img_mod.Visible = True
        img_suppr.Visible = False

        btnAjoutD.Visible = False
        btnAnnulerD.Visible = True
        btnsuppD.Visible = False
        'btnSuppTT.Visible = False

        btnModifierD.Visible = True
        btnModifierD.Enabled = True


        txtbxDate.Visible = False
        cbxdate.Visible = True

        txtbxDate.Text = ""
        txtbxMontant.Text = ""
        txtbxKm.Text = ""
        txtbxSouche.Text = ""
        txtbxObsv.Text = ""

        'cbxTypeDoti.Items.Clear()
        'cbxTypeDoti.Items.Add("Dotation fixe par semaine")
        'cbxTypeDoti.Items.Add("Dotation fixe par mois")

        '*********Matricule Vehicule

        cbxMatVehiP.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_vehi,mat_vehi From Depcarburant", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        txtbxNVehi.Text = dr.Item("n_vehi")
        Do
            cbxMatVehiP.Items.Add(dr.Item("mat_vehi"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


        '*********Chauffeur

        cbxChauf.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_chauff,Nom From chauffeurV ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        txtbxNChauf.Text = dr.Item("n_chauff")
        Do
            cbxChauf.Items.Add(dr.Item("Nom"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()

    End Sub

    Private Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        img_new.Visible = False
        img_suppr.Visible = True

        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = False
        img_mod.Visible = False
        img_suppr.Visible = True

        btnAjoutD.Visible = False
        btnAnnulerD.Visible = True
        btnModifierD.Visible = False

        btnsuppD.Visible = True
        btnsuppD.Enabled = True
        'btnSuppTT.Visible = True

        txtbxDate.Visible = False
        cbxdate.Visible = True

        txtbxDate.Text = ""
        txtbxMontant.Text = ""
        txtbxKm.Text = ""
        txtbxSouche.Text = ""
        txtbxObsv.Text = ""

        'cbxTypeDoti.Items.Clear()
        'cbxTypeDoti.Items.Add("Dotation fixe par semaine")
        'cbxTypeDoti.Items.Add("Dotation fixe par mois")

        '*********Matricule Vehicule

        cbxMatVehiP.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_vehi,mat_vehi From Depcarburant ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        txtbxNVehi.Text = dr.Item("n_vehi")
        Do
            cbxMatVehiP.Items.Add(dr.Item("mat_vehi"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


        '*********Chauffeur

        cbxChauf.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_chauff,Nom From chauffeurV ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        txtbxNChauf.Text = dr.Item("n_chauff")
        Do
            cbxChauf.Items.Add(dr.Item("Nom"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()

    End Sub

    Private Sub btnAjoutD_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAjoutD.Click
        If txtbxDate.Text = Nothing Then

            '  If (lblSNTLRes.Text) >= 0 Then

            'cmd = New SqlCommand("insert into SNTL(Date,Montant1,Montant2) values('" & txtbxDate.Text & "','" & lblSNTLRes.Text & "','" & lblSNTL.Text & "')", con)
            'con.Close()
            'con.Open()
            'cmd.ExecuteNonQuery()
            'con.Close()

            Try

                cmd = New SqlCommand("insert into DepCarburant values(" & lblNCarb.Text & ",'" & cbxMatVehiP.Text & "'," & txtbxNChauf.Text & ",'" & txtbxMontant.Text & "','" & txtbxKm.Text & "','" & txtbxDate.Text & "','" & txtbxObsv.Text & "','" & txtbxSouche.Text & "'," & lblNConsD.Text & "," & txtbxNVehi.Text & ")", con)
                con.Close()
                con.Open()
                cmd.ExecuteNonQuery()


                cmd = New SqlCommand("insert into consommation (N_cons,n_vehi,mat_vehi,n_chauf,montant,km,dat_cons,observation,N_Carb,souche) values(" & lblNConsD.Text & "," & txtbxNVehi.Text & ",'" & cbxMatVehiP.Text & "'," & txtbxNChauf.Text & ",'" & txtbxMontant.Text & "','" & txtbxKm.Text & "','" & txtbxDate.Text & "','" & txtbxObsv.Text & "'," & lblNCarb.Text & ",'" & txtbxSouche.Text & "')", con)
                con.Close()
                con.Open()
                cmd.ExecuteNonQuery()

                Msg_succes(" Ajout réalisé avec succès ")

                con.Close()

            Catch ex As Exception
                ' Msg_Erreur("Erreur de ............!!!!!!")
                Msg_Erreur(ex.Message)
                con.Close()
            End Try
            con.Close()

            'Else
            '    Msg_Erreur("Le Montant et Insuffisant")
            'End If

        Else
            If Not IsDate(Me.txtbxDate.Text) Then
                Msg_Erreur(" Format date en jj/mm/aa ")

            Else

                '    If (lblSNTLRes.Text) >= 0 Then

                'cmd = New SqlCommand("insert into SNTL(Date,Montant1,Montant2) values('" & txtbxDate.Text & "','" & lblSNTLRes.Text & "','" & lblSNTL.Text & "')", con)
                'con.Close()
                'con.Open()
                'cmd.ExecuteNonQuery()
                'con.Close()

                Try

                    cmd = New SqlCommand("insert into DepCarburant values(" & lblNCarb.Text & ",'" & cbxMatVehiP.Text & "'," & txtbxNChauf.Text & ",'" & txtbxMontant.Text & "','" & txtbxKm.Text & "','" & txtbxDate.Text & "','" & txtbxObsv.Text & "','" & txtbxSouche.Text & "'," & lblNConsD.Text & "," & txtbxNVehi.Text & ")", con)

                    con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()



                    cmd = New SqlCommand("insert into consommation (N_cons,n_vehi,mat_vehi,n_chauf,montant,km,dat_cons,observation,N_Carb,souche) values(" & lblNConsD.Text & "," & txtbxNVehi.Text & ",'" & cbxMatVehiP.Text & "'," & txtbxNChauf.Text & ",'" & txtbxMontant.Text & "','" & txtbxKm.Text & "','" & txtbxDate.Text & "','" & txtbxObsv.Text & "'," & lblNCarb.Text & ",'" & txtbxSouche.Text & "')", con)

                    con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()
                    Msg_succes(" Ajout réalisé avec succès ")

                    con.Close()
                Catch ex As Exception
                    ' Msg_Erreur("Erreur de ............!!!!!!")
                    Msg_Erreur(ex.Message)
                    con.Close()
                End Try
                con.Close()
                '    Else

                '    Msg_Erreur(" Le Montant et Insuffisant")
                'End If

            End If
        End If

    End Sub

    Private Sub cbxMatVehiP_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxMatVehiP.SelectedIndexChanged

        If btnModifierD.Visible = True Or btnsuppD.Visible = True Then

            '    If cbxSouche.Visible = False Then

            lblmarq.Visible = False
            lblMMarq.Visible = False

            cbxdate.Items.Clear()

            Try
                con.Close()
                con.Open()
                ' cmd = New SqlCommand("select n_vehi,lib_marqq,Kilom,mat_vehi from Vehicule where mat_vehi  ='" & cbxMatVehiP.Text & "'", con)
                cmd = New SqlCommand("select n_carb,n_cons,n_vehi,mat_vehi from depcarburant where mat_vehi='" & cbxMatVehiP.Text & "'", con)
                dr = cmd.ExecuteReader
                dr.Read()
                txtbxNVehi.Text = dr.Item("n_vehi")
                cbxMatVehiP.Text = dr.Item("mat_vehi")
                lblNConsD.Text = dr.Item("n_cons")
                lblNCarb.Text = dr.Item("n_carb")


                con.Close()
                con.Open()
                cmd = New SqlCommand("select mat_vehi,max(calnbrkm) from Vidange where mat_vehi='" & cbxMatVehiP.Text & "' group by mat_vehi ", con)
                dr = cmd.ExecuteReader
                dr.Read()
                lblCalNbrKm.Text = dr(1)

                con.Close()
                con.Open()
                cmd = New SqlCommand("SELECT dbo.consommation.N_cons,dbo.consommation.n_vehi,dbo.consommation.souche, dbo.consommation.mat_vehi, dbo.chauffeurV.Nom, dbo.consommation.dat_cons, dbo.consommation.montant, dbo.consommation.km,  dbo.consommation.observation,dbo.consommation.n_chauf FROM  dbo.consommation INNER JOIN dbo.chauffeurV ON dbo.consommation.n_chauf = dbo.chauffeurV.n_chauff where mat_vehi='" & cbxMatVehiP.Text & "' ", con)
                dr = cmd.ExecuteReader
                dr.Read()

                txtbxNVehi.Text = dr.Item("n_vehi")
                cbxChauf.Text = dr.Item("Nom")
                txtbxNChauf.Text = dr.Item("n_chauf")

                txtbxMontant.Text = dr.Item("montant")
                txtbxKm.Text = dr.Item("Km")
                txtbxObsv.Text = dr.Item("observation")
                txtbxSouche.Text = dr.Item("souche")

                Do

                    cbxdate.Items.Add(dr.Item("dat_cons"))

                Loop While (dr.Read)

                dr.Close()
                con.Close()
            Catch ex As Exception
                Lblerror.Text = ex.Message
                dr.Close()
                con.Close()
            End Try
            dr.Close()
            con.Close()

            'If Not Page.IsPostBack Then

            'Try

            'Catch ex As Exception
            '    Lblerror.Text = ex.Message
            '    dr.Close()
            '    con.Close()
            'End Try

            'dr.Close()
            'con.Close()

        End If

        If btnAjoutD.Visible = True Then

            lblmarq.Visible = True
            lblMMarq.Visible = True

            Try
                con.Close()
                con.Open()
                cmd = New SqlCommand("select  n_vehi,mat_vehi,lib_marqq from Vehicule where mat_vehi ='" & cbxMatVehiP.Text & "'", con)
                dr = cmd.ExecuteReader
                dr.Read()

                txtbxNVehi.Text = dr.Item("n_vehi")
                cbxMatVehiP.Text = dr.Item("mat_vehi")
                lblMMarq.Text = dr.Item("lib_marqq")

                con.Close()
                con.Open()
                cmd = New SqlCommand("select mat_vehi,max(calnbrkm) from Vidange where mat_vehi='" & cbxMatVehiP.Text & "' group by mat_vehi ", con)
                dr = cmd.ExecuteReader
                dr.Read()

                lblCalNbrKm.Text = dr(1)

                dr.Close()
                con.Close()
            Catch ex As Exception
                Lblerror.Text = ex.Message
                dr.Close()
                con.Close()
            End Try
            dr.Close()
            con.Close()

        End If
    End Sub

    'Private Sub cbxAff_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxAff.SelectedIndexChanged
    '    Try
    '        con.Close()
    '        con.Open()
    '        cmd.Connection = con
    '        cmd.CommandType = CommandType.Text
    '        cmd.CommandText = "select distinct n_aff,lib_aff from Affectation where lib_aff ='" & cbxAff.Text & "'"
    '        dr = cmd.ExecuteReader
    '        dr.Read()

    '        txtbxNAff.Text = dr.Item("n_aff")
    '        cbxAff.Text = dr.Item("lib_aff")

    '        dr.Close()
    '        con.Close()
    '    Catch ex As Exception
    '        Lblerror.Text = ex.Message
    '        dr.Close()
    '        con.Close()
    '    End Try
    '    dr.Close()
    '    con.Close()
    'End Sub

    Private Sub cbxChauf_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxChauf.SelectedIndexChanged
        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand("select distinct n_chauff,Nom from chauffeurV where Nom ='" & cbxChauf.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxNChauf.Text = dr.Item("n_chauff")
            cbxChauf.Text = dr.Item("Nom")

            dr.Close()
            con.Close()
        Catch ex As Exception
            Lblerror.Text = ex.Message
            dr.Close()
            con.Close()
        End Try
        dr.Close()
        con.Close()
    End Sub

    'Private Sub cbxTypeCons_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxTypeCons.SelectedIndexChanged
    '    Try
    '        con.Close()
    '        con.Open()
    '        cmd.Connection = con
    '        cmd.CommandType = CommandType.Text
    '        cmd.CommandText = "select distinct n_t_cons,lib_t_cons from type_cons where lib_t_cons ='" & cbxTypeCons.Text & "'"
    '        dr = cmd.ExecuteReader
    '        dr.Read()

    '        txtbxNTypeC.Text = dr.Item("n_t_cons")
    '        cbxTypeCons.Text = dr.Item("lib_t_cons")

    '        dr.Close()
    '        con.Close()
    '    Catch ex As Exception
    '        Lblerror.Text = ex.Message
    '        dr.Close()
    '        con.Close()
    '    End Try
    '    dr.Close()
    '    con.Close()
    'End Sub

    'Private Sub cbxSouche_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxSouche.SelectedIndexChanged
    '    'SELECT dbo.consommation.n_vehi, dbo.consommation.mat_vehi, dbo.consommation.n_chauf, dbo.chauffeurV.Nom, dbo.consommation.n_aff, dbo.Affectation.lib_aff, dbo.consommation.n_t_cons, dbo.type_cons.lib_t_cons, dbo.consommation.dat_cons, dbo.consommation.montant, dbo.consommation.km, dbo.consommation.souche,dbo.consommation.observation, dbo.consommation.t_dot FROM dbo.consommation INNER JOIN dbo.chauffeurV ON dbo.consommation.n_chauf = dbo.chauffeurV.n_chauff INNER JOIN dbo.Affectation ON dbo.consommation.n_aff = dbo.Affectation.n_aff INNER JOIN dbo.type_cons ON dbo.consommation.n_t_cons = dbo.type_cons.n_t_cons where Souche  ='44' and dbo.consommation.n_t_cons=1 

    '    Try
    '        con.Close()
    '        con.Open()
    '        cmd = New SqlCommand("SELECT dbo.consommation.n_vehi, dbo.consommation.mat_vehi, dbo.consommation.n_chauf, dbo.chauffeurV.Nom, dbo.consommation.n_aff, dbo.Affectation.lib_aff, dbo.consommation.n_t_cons, dbo.type_cons.lib_t_cons, dbo.consommation.dat_cons, dbo.consommation.montant, dbo.consommation.km, dbo.consommation.souche,dbo.consommation.observation, dbo.consommation.t_dot FROM dbo.consommation INNER JOIN dbo.chauffeurV ON dbo.consommation.n_chauf = dbo.chauffeurV.n_chauff INNER JOIN dbo.Affectation ON dbo.consommation.n_aff = dbo.Affectation.n_aff INNER JOIN dbo.type_cons ON dbo.consommation.n_t_cons = dbo.type_cons.n_t_cons where souche  ='" & cbxSouche.Text & "' and dbo.consommation.n_t_cons=1 ", con)
    '        dr = cmd.ExecuteReader
    '        dr.Read()

    '        ' txtbxNVehi.Text = dr.Item("n_vehi")
    '        '   cbxMatVehiP.Text = dr.Item("mat_vehi")
    '        cbxChauf.Text = dr.Item("Nom")
    '        txtbxNChauf.Text = dr.Item("n_chauf")
    '        'txtbxNAff.Text = dr.Item("n_aff")
    '        '            cbxAff.Text = dr.Item("lib_aff")

    '        'txtbxNTypeC.Text = dr.Item("n_t_cons")
    '        '           cbxTypeCons.Text = dr.Item("lib_t_cons")

    '        '          cbxTypeDoti.Text = dr.Item("t_dot")
    '        txtbxDate.Text = dr.Item("dat_cons")
    '        txtbxMontant.Text = dr.Item("montant")
    '        txtbxKm.Text = dr.Item("Km")
    '        txtbxObsv.Text = dr.Item("observation")

    '        '  Do
    '        'cbxSouche.Items.Add(dr.Item("souche"))

    '        'Loop While (dr.Read)

    '        dr.Close()
    '        con.Close()
    '    Catch ex As Exception
    '        Lblerror.Text = ex.Message
    '        dr.Close()
    '        con.Close()
    '    End Try
    '    dr.Close()
    '    con.Close()

    'End Sub

    Private Sub btnModifierD_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModifierD.Click
        'If Not IsDate(Me.txtbxDate.Text) Then
        '    Msg_Erreur(" Format date et jj/mm/aa ")

        'Else

        'If (lblSNTLRes.Text) > 0 Then

        '    cmd = New SqlCommand("insert into SNTL(Date,Montant1,Montant2) values('" & txtbxDate.Text & "','" & lblSNTLRes.Text & "','" & lblSNTL.Text & "')", con)
        '    con.Close()
        '    con.Open()
        '    cmd.ExecuteNonQuery()
        '    con.Close()


        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand("update depcarburant set n_chauff='" & txtbxNChauf.Text & "',Prix='" & txtbxMontant.Text & "',km='" & txtbxKm.Text & "',description='" & txtbxObsv.Text & "', souche='" & txtbxSouche.Text & "'  where mat_vehi='" & cbxMatVehiP.Text & "' and  N_cons=" & lblNConsD.Text & " and N_carb=" & lblNCarb.Text & "", con)
            cmd.ExecuteNonQuery()
            con.Close()

            con.Close()
            con.Open()
            cmd = New SqlCommand("update consommation set n_chauf='" & txtbxNChauf.Text & "',montant='" & txtbxMontant.Text & "',km='" & txtbxKm.Text & "',observation='" & txtbxObsv.Text & "', souche='" & txtbxSouche.Text & "'  where mat_vehi='" & cbxMatVehiP.Text & "' and  N_cons=" & lblNConsD.Text & " and N_carb=" & lblNCarb.Text & "", con)
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

        '    Else
        '    Msg_Erreur("Le Montant et Insuffisant")
        'End If
        '  End If


    End Sub

    Protected Sub btnsuppD_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnsuppD.Click
        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand("delete  from DepCarburant where mat_vehi= '" & cbxMatVehiP.Text & "' and n_cons=" & lblNConsD.Text & " and n_carb=" & lblNCarb.Text & " ", con)
            dr = cmd.ExecuteReader
            dr.Read()
            con.Close()

            con.Close()
            con.Open()
            cmd = New SqlCommand("delete  from consommation where mat_vehi= '" & cbxMatVehiP.Text & "'  and  n_cons=" & lblNConsD.Text & " and n_carb=" & lblNCarb.Text & "", con)
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

    'Private Sub btnSuppTT_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSuppTT.Click
    '    Try
    '        cmd = New SqlCommand("delete  from consommation where mat_vehi= '" & cbxMatVehiP.Text & "' ", con)
    '        con.Close()
    '        con.Open()
    '        dr = cmd.ExecuteReader
    '        dr.Read()
    '        dr.Close()
    '        con.Close()

    '        Msg_succes("suppression réalisée avec succès")

    '    Catch ex As Exception
    '        Msg_Erreur(ex.Message)
    '        con.Close()
    '    End Try
    '    dr.Close()
    '    con.Close()
    'End Sub

    'Protected Sub btnSouche_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSouche.Click


    '    Lblerror.Visible = False
    '    img_error.Visible = False
    '    img_succes.Visible = False

    '    If lblNConsD.Text = "" Or txtbxSouche.Text = "" Then

    '        Msg_Erreur("Veuillez remplir le champs")

    '    Else

    '        Dim req0 As String

    '        req0 = " select N_Cons,Souche from Souche where N_Cons='" & lblNConsD.Text & "' and Souche='" & txtbxSouche.Text & "'"

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
    '                cmd = New SqlCommand("insert into Souche values ( " & lblNConsD.Text & ",'" & txtbxSouche.Text & "')", con)
    '                cmd.ExecuteNonQuery()
    '                con.Close()

    '                txtbxSouche.Text = ""

    '            Catch ex As Exception
    '                Msg_Erreur("Erreur....!!?")
    '            End Try
    '        End If

    '    End If


    'End Sub

    Protected Sub txtbxMontant_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtbxMontant.TextChanged

        'lblSNTLRes.Text = (lblSNTL.Text.ToString - (Replace(txtbxMontant.Text, ".", ",")))

    End Sub

    Protected Sub txtbxKm_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtbxKm.TextChanged

        If Val(txtbxKm.Text) >= Val(lblCalNbrKm.Text) Then

            MsgBox("     Faire la vidange pour le vehicule au matricule  :    " & cbxMatVehiP.Text)

        Else

        End If

    End Sub

    Protected Sub cbxdate_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxdate.SelectedIndexChanged
        Try

            con.Close()
            con.Open()
            cmd = New SqlCommand("SELECT dbo.consommation.N_cons,dbo.consommation.n_carb,dbo.consommation.n_vehi,dbo.consommation.souche, dbo.consommation.mat_vehi, dbo.chauffeurV.Nom, dbo.consommation.dat_cons, dbo.consommation.montant, dbo.consommation.km,  dbo.consommation.observation,dbo.consommation.n_chauf FROM  dbo.consommation INNER JOIN dbo.chauffeurV ON dbo.consommation.n_chauf = dbo.chauffeurV.n_chauff where mat_vehi='" & cbxMatVehiP.Text & "' and dat_cons='" & cbxdate.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()

            cbxChauf.Text = dr.Item("Nom")
            txtbxNChauf.Text = dr.Item("n_chauf")

            txtbxMontant.Text = dr.Item("montant")
            txtbxKm.Text = dr.Item("Km")
            txtbxObsv.Text = dr.Item("observation")
            txtbxSouche.Text = dr.Item("souche")

            lblNCarb.Text = dr.Item("n_carb")
            lblNConsD.Text = dr.Item("n_cons")

            dr.Close()
            con.Close()
        Catch ex As Exception
            Lblerror.Text = ex.Message
            dr.Close()
            con.Close()
        End Try
        dr.Close()
        con.Close()

    End Sub

End Class