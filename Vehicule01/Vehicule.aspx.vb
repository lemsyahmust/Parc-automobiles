Imports System.Data
Imports System.Data.SqlClient

Partial Public Class WebForm12
    Inherits System.Web.UI.Page


    Function N_L() As Int32
        'retourne l dernier numero de bon de livaison plus un
        Dim m As Int32
        Dim cmd As SqlCommand = New SqlCommand("select n_vehi from Vehicule", con)
        Dim dr As SqlDataReader
        con.Close()
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

        'If btnAjoutVeh.Enabled = False And btnModifVeh.Enabled = False Then
        If Not Page.IsPostBack Then

            '********* Afficher Pneus
            Try

                con.Close()
                con.Open()
                '  cmd = New SqlCommand(" SELECT dbo.Vehicule.n_aff, dbo.Affectation.lib_aff, dbo.Vehicule.lib_marqq, dbo.Vehicule.nbr_Plc, dbo.Vehicule.n_chauff, dbo.chauffeurV.Nom, dbo.Vehicule.mat_vehi, dbo.Vehicule.num_chass, dbo.Vehicule.num_moteur, dbo.Vehicule.date_circul, dbo.Vehicule.Kilom, dbo.Vehicule.dat_aff, dbo.Vehicule.n_carb, dbo.Carburant.lib_carb, dbo.Vehicule.n_cat,dbo.Vehicule.t_aff, dbo.Categorie.lib_cat, dbo.Vehicule.n_etat_vehi, dbo.etat_vehicule.lib_etat_vehi FROM dbo.Vehicule INNER JOIN dbo.Affectation ON dbo.Vehicule.n_aff = dbo.Affectation.n_aff INNER JOIN dbo.chauffeurV ON dbo.Vehicule.n_chauff = dbo.chauffeurV.n_chauff INNER JOIN dbo.Carburant ON dbo.Vehicule.n_carb = dbo.Carburant.n_carb INNER JOIN dbo.Categorie ON dbo.Vehicule.n_cat = dbo.Categorie.n_cat INNER JOIN dbo.etat_vehicule ON dbo.Vehicule.n_etat_vehi = dbo.etat_vehicule.n_etat_vehi  ", con)
                cmd = New SqlCommand("SELECT dbo.Vehicule.n_vehi, dbo.Vehicule.lib_marqq, dbo.Vehicule.nbr_Plc, dbo.Vehicule.mat_vehi , dbo.Vehicule.num_chass, dbo.Vehicule.num_moteur, dbo.Vehicule.date_circul, dbo.Vehicule.Kilom, dbo.Vehicule.n_carb, dbo.Carburant.lib_carb, dbo.Vehicule.n_cat, dbo.Categorie.lib_cat FROM dbo.Vehicule INNER JOIN dbo.Carburant ON dbo.Vehicule.n_carb = dbo.Carburant.n_carb INNER JOIN dbo.Categorie ON dbo.Vehicule.n_cat = dbo.Categorie.n_cat ", con)
                dr = cmd.ExecuteReader
                dr.Read()

                'txtbxMatricule.Items.Add(dr.Item("mat_vehi"))
                'cbxRepaP.Items.Add(dr.Item("lib_reparateur"))

                txtbxMatricule.Text = dr.Item("mat_vehi")
                txtbxMarqueV.Text = dr.Item("lib_marqq")

                txtbxNbrP.Text = dr.Item("nbr_Plc")
                txtbxNChassis.Text = dr.Item("num_chass")

                txtbxNmoteur.Text = dr.Item("num_moteur")

                cbxCategorie.Items.Add(dr.Item("lib_cat"))
                txtbxNcategorie.Text = dr.Item("n_cat")

                cbxCarburant.Items.Add(dr.Item("lib_carb"))
                txtbxNcarburant.Text = dr.Item("n_carb")

                txtbxKilom.Text = dr.Item("Kilom")
                txtbxDatCirc.Text = dr.Item("date_circul")

                'cbxChauff.Items.Add(dr.Item("Nom"))
                'txtbxNChauffeur.Text = dr.Item("n_chauff")

                'cbxAff.Items.Add(dr.Item("lib_aff"))
                'txtbxNAffectation.Text = dr.Item("n_aff")

                'txtbxDatAff.Text = dr.Item("dat_aff")
                'cbxTypeB.Items.Add(dr.Item("t_aff"))

                'cbxetatVehi.Items.Add(dr.Item("lib_etat_vehi"))
                'txtbxNEtat.Text = dr.Item("n_etat_vehi")


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
            '    txtbxKm.Text = ""
            '    txtbxDateP.Text = ""
            '    'cbxQteP.Text = "0"
            '    txtbxPrixP.Text = ""
            '    txtbxNFactP.Text = ""
            '    txtbxDate2.Text = ""
        End If


    End Sub

    Protected Sub cbxMarque_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxMarque.SelectedIndexChanged
        Try
            con.Close()
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select distinct n_marq,lib_marq from marque where lib_marq ='" & cbxMarque.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxNMarque.Text = dr.Item("n_marq")
            cbxMarque.Text = dr.Item("lib_marq")

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

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click

        'txtbxTypeB.Visible = False
        'cbxTypeB.Visible = True

        img_new.Visible = True
        img_suppr.Visible = False

        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        btnAjoutVeh.Visible = True
        btnModifVeh.Visible = False
        btnAnnulerVeh.Visible = True

        ' txtbxDatAff.Text = ""
        txtbxDatCirc.Text = ""
        txtbxKilom.Text = ""
        txtbxMatricule.Text = ""
        'txtbxNAffectation.Text = " "
        txtbxNcarburant.Text = " "
        txtbxNcategorie.Text = " "
        txtbxNChassis.Text = ""
        'txtbxNChauffeur.Text = " "
        'txtbxNEtat.Text = " "
        txtbxNMarque.Text = " "
        txtbxNmoteur.Text = ""
        txtbxMarqueV.Text = ""
        txtbxNbrP.Text = ""

        txtbxMatricule.Visible = True
        cbxMatricule.Visible = False

        btnAjoutVeh.Enabled = True

        'cbxTypeB.Items.Clear()
        'cbxTypeB.Items.Add("Temporaire")
        'cbxTypeB.Items.Add("Permanent")

        Dim n As Integer = N_L()
        Label1.Text = n + 1

        '*********Marque

        cbxMarque.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct lib_marq From marque ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        ' cbxMarque.Text = Nothing

        Do
            cbxMarque.Items.Add(dr.Item("lib_marq"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()

        '*********Categorie

        cbxCategorie.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_cat,lib_cat From Categorie ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        txtbxNcategorie.Text = dr.Item("n_cat")
        Do
            cbxCategorie.Items.Add(dr.Item("lib_cat"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


        '*********Carburant

        cbxCarburant.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_carb,lib_carb From Carburant ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        txtbxNcarburant.Text = dr.Item("n_carb")
        Do
            cbxCarburant.Items.Add(dr.Item("lib_carb"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


        ''*********Chauffeur

        'cbxChauff.Items.Clear()

        'con.Close()
        'con.Open()
        'cmd = New SqlCommand(" select distinct n_chauff,Nom From chauffeurV ", con)
        'dr = cmd.ExecuteReader
        'dr.Read()
        '' cbxMarq.Text = dr.Item("lib_marq")
        'txtbxNChauffeur.Text = dr.Item("n_chauff")
        'Do
        '    cbxChauff.Items.Add(dr.Item("Nom"))

        'Loop While (dr.Read)
        'dr.Close()
        'con.Close()


        ''*********Affectation

        'cbxAff.Items.Clear()

        'con.Close()
        'con.Open()
        'cmd = New SqlCommand(" select distinct n_aff,lib_aff From Affectation ", con)
        'dr = cmd.ExecuteReader
        'dr.Read()
        '' cbxMarq.Text = dr.Item("lib_marq")
        'txtbxNAffectation.Text = dr.Item("n_aff")
        'Do
        '    cbxAff.Items.Add(dr.Item("lib_aff"))

        'Loop While (dr.Read)
        'dr.Close()
        'con.Close()


       
    End Sub

    Private Sub cbxCarburant_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxCarburant.SelectedIndexChanged
        Try
            con.Close()
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select distinct n_carb,lib_carb from Carburant where lib_carb ='" & cbxCarburant.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxNcarburant.Text = dr.Item("n_carb")
            cbxCarburant.Text = dr.Item("lib_carb")

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

    'Private Sub cbxChauff_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxChauff.SelectedIndexChanged
    '    Try
    '        con.Close()
    '        con.Open()
    '        cmd.Connection = con
    '        cmd.CommandType = CommandType.Text
    '        cmd.CommandText = "select distinct n_chauff,Nom from chauffeurV where Nom ='" & cbxChauff.Text & "'"
    '        dr = cmd.ExecuteReader
    '        dr.Read()

    '        txtbxNChauffeur.Text = dr.Item("n_chauff")
    '        '  cbxChauff.Text = dr.Item("Nom")

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

    'Private Sub cbxAff_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxAff.SelectedIndexChanged
    '    Try
    '        con.Close()
    '        con.Open()
    '        cmd.Connection = con
    '        cmd.CommandType = CommandType.Text
    '        cmd.CommandText = "select distinct n_aff,lib_aff from Affectation where lib_aff ='" & cbxAff.Text & "'"
    '        dr = cmd.ExecuteReader
    '        dr.Read()

    '        txtbxNAffectation.Text = dr.Item("n_aff")
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

    'Private Sub cbxetatVehi_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxetatVehi.SelectedIndexChanged
    '    Try
    '        con.Close()
    '        con.Open()
    '        cmd.Connection = con
    '        cmd.CommandType = CommandType.Text
    '        cmd.CommandText = "select distinct n_etat_vehi,lib_etat_vehi from etat_vehicule where lib_etat_vehi ='" & cbxetatVehi.Text & "'"
    '        dr = cmd.ExecuteReader
    '        dr.Read()

    '        txtbxNEtat.Text = dr.Item("n_etat_vehi")
    '        cbxetatVehi.Text = dr.Item("lib_etat_vehi")

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

    Private Sub cbxCategorie_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxCategorie.SelectedIndexChanged
        Try
            con.Close()
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select distinct n_cat,lib_cat from Categorie where lib_cat ='" & cbxCategorie.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxNcategorie.Text = dr.Item("n_cat")
            cbxCategorie.Text = dr.Item("lib_cat")

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

    Private Sub btnAjoutVeh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAjoutVeh.Click

        If txtbxMatricule.Text = Nothing Or txtbxNChassis.Text = Nothing Then
            'Or txtbxNAffectation.Text = Nothing then

            Msg_Erreur(" Veuillez remplir les champs ")

        Else

            Dim req0 As String

            req0 = "select mat_vehi,num_chass from Vehicule where mat_vehi ='" & Me.txtbxMatricule.Text & "' or num_chass='" & txtbxNChassis.Text & "'"

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
                Msg_Erreur(" Cette vehicule existe deja ")
                con.Close()
            Else
                Try

                    '  cmd = New SqlCommand("insert into Vehicule values (0001," & txtbxNAffectation.Text & "," & txtbxNMarque.Text & "," & txtbxNChauffeur.Text & ",'" & txtbxMatricule.Text & "','" & txtbxNChassis.Text & "','" & txtbxNmoteur.Text & "','" & txtbxDatCirc.Text & "','" & txtbxKilom.Text & "','" & txtbxDatAff.Text & "','" & txtbxdatCond.Text & "'," & txtbxNcarburant.Text & "," & txtbxNcategorie.Text & "," & txtbxNEtat.Text & ") ", con)
                    'cmd = New SqlCommand("insert into Vehicule values(012," & txtbxNAffectation.Text & "," & txtbxNMarque.Text & "," & txtbxNChauffeur.Text & ",'" & txtbxMatricule.Text & "','" & txtbxNChassis.Text & "','" & txtbxNmoteur.Text & "','" & txtbxDatCirc.Text & "','" & txtbxKilom.Text & "','" & txtbxDatAff.Text & "','" & txtbxdatCond.Text & "'," & txtbxNcarburant.Text & "," & txtbxNcategorie.Text & "," & txtbxNEtat.Text & ")", con)
                    cmd = New SqlCommand("insert into Vehicule(n_vehi,lib_marqq,nbr_plc,mat_vehi,num_chass,num_moteur,date_circul,kilom,n_carb,n_cat,n_aff) values(" & Label1.Text & ",'" & txtbxMarqueV.Text & "','" & txtbxNbrP.Text & "','" & txtbxMatricule.Text & "','" & txtbxNChassis.Text & "','" & txtbxNmoteur.Text & "','" & txtbxDatCirc.Text & "','" & txtbxKilom.Text & "'," & txtbxNcarburant.Text & "," & txtbxNcategorie.Text & "," & 0 & ")", con)

                    con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()
                    Msg_succes(" Ajout réalisé avec succès ")

                    ' txtbxNAffectation.Text = ""
                    txtbxMarqueV.Text = ""
                    txtbxNbrP.Text = ""
                    ' txtbxNChauffeur.Text = ""
                    txtbxMatricule.Text = ""

                    txtbxNChassis.Text = ""
                    txtbxNmoteur.Text = ""
                    txtbxDatCirc.Text = ""
                    '    txtbxNChauffeur.Text = ""
                    txtbxKilom.Text = ""


                    '   txtbxDatAff.Text = ""
                    txtbxNcarburant.Text = ""
                    txtbxNcategorie.Text = ""
                    ' txtbxNEtat.Text = ""


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

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click

        'txtbxTypeB.Visible = True
        'cbxTypeB.Visible = False

        btnModifVeh.Enabled = True

        img_new.Visible = False
        img_suppr.Visible = True

        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = False
        img_suppr.Visible = True

        btnAjoutVeh.Visible = False
        btnModifVeh.Visible = True
        btnAnnulerVeh.Visible = True

        'txtbxDatAff.Text = ""
        txtbxDatCirc.Text = ""
        txtbxKilom.Text = ""
        txtbxMatricule.Text = ""
        'txtbxNAffectation.Text = " "
        txtbxNcarburant.Text = " "
        txtbxNcategorie.Text = " "
        txtbxNChassis.Text = ""
        'txtbxNChauffeur.Text = " "
        'txtbxNEtat.Text = " "
        txtbxNMarque.Text = " "
        txtbxNmoteur.Text = ""
        txtbxMarqueV.Text = ""
        txtbxNbrP.Text = ""

        'cbxTypeB.Items.Clear()
        'cbxTypeB.Items.Add("Temporaire")
        'cbxTypeB.Items.Add("Permanent")

        txtbxMatricule.Visible = False
        cbxMatricule.Visible = True

        '*********Matricule 

        cbxMatricule.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct mat_vehi From Vehicule ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        ' cbxMarque.Text = Nothing

        Do
            cbxMatricule.Items.Add(dr.Item("mat_vehi"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


        '*********Marque

        cbxMarque.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct lib_marq From marque ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        ' cbxMarque.Text = Nothing

        Do
            cbxMarque.Items.Add(dr.Item("lib_marq"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()

        '*********Categorie

        cbxCategorie.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_cat,lib_cat From Categorie ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        txtbxNcategorie.Text = dr.Item("n_cat")
        Do
            cbxCategorie.Items.Add(dr.Item("lib_cat"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


        '*********Carburant

        cbxCarburant.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_carb,lib_carb From Carburant ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        txtbxNcarburant.Text = dr.Item("n_carb")
        Do
            cbxCarburant.Items.Add(dr.Item("lib_carb"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


        ''*********Chauffeur

        'cbxChauff.Items.Clear()

        'con.Close()
        'con.Open()
        'cmd = New SqlCommand(" select distinct n_chauff,Nom From chauffeurV ", con)
        'dr = cmd.ExecuteReader
        'dr.Read()
        '' cbxMarq.Text = dr.Item("lib_marq")
        'txtbxNChauffeur.Text = dr.Item("n_chauff")
        'Do
        '    cbxChauff.Items.Add(dr.Item("Nom"))

        'Loop While (dr.Read)
        'dr.Close()
        'con.Close()


        ''*********Affectation

        'cbxAff.Items.Clear()

        'con.Close()
        'con.Open()
        'cmd = New SqlCommand(" select distinct n_aff,lib_aff From Affectation ", con)
        'dr = cmd.ExecuteReader
        'dr.Read()
        '' cbxMarq.Text = dr.Item("lib_marq")
        'txtbxNAffectation.Text = dr.Item("n_aff")
        'Do
        '    cbxAff.Items.Add(dr.Item("lib_aff"))

        'Loop While (dr.Read)
        'dr.Close()
        'con.Close()


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

    End Sub

    Protected Sub cbxMatricule_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxMatricule.SelectedIndexChanged

        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        If btnModifVeh.Visible = True Then

            Try

                con.Close()
                con.Open()
                'cmd = New SqlCommand(" SELECT dbo.Vehicule.n_aff, dbo.Affectation.lib_aff, dbo.Vehicule.lib_marqq, dbo.Vehicule.nbr_Plc, dbo.Vehicule.n_chauff, dbo.chauffeurV.Nom, dbo.Vehicule.mat_vehi, dbo.Vehicule.num_chass, dbo.Vehicule.num_moteur, dbo.Vehicule.date_circul, dbo.Vehicule.Kilom, dbo.Vehicule.dat_aff, dbo.Vehicule.n_carb, dbo.Carburant.lib_carb, dbo.Vehicule.n_cat,dbo.Vehicule.t_aff, dbo.Categorie.lib_cat, dbo.Vehicule.n_etat_vehi, dbo.etat_vehicule.lib_etat_vehi FROM dbo.Vehicule INNER JOIN dbo.Affectation ON dbo.Vehicule.n_aff = dbo.Affectation.n_aff INNER JOIN dbo.chauffeurV ON dbo.Vehicule.n_chauff = dbo.chauffeurV.n_chauff INNER JOIN dbo.Carburant ON dbo.Vehicule.n_carb = dbo.Carburant.n_carb INNER JOIN dbo.Categorie ON dbo.Vehicule.n_cat = dbo.Categorie.n_cat INNER JOIN dbo.etat_vehicule ON dbo.Vehicule.n_etat_vehi = dbo.etat_vehicule.n_etat_vehi where mat_vehi='" & cbxMatricule.Text & "' ", con)
                cmd = New SqlCommand("SELECT  dbo.Vehicule.lib_marqq, dbo.Vehicule.nbr_Plc,dbo.Vehicule.mat_vehi, dbo.Vehicule.num_chass, dbo.Vehicule.num_moteur, dbo.Vehicule.date_circul, dbo.Vehicule.Kilom, dbo.Vehicule.n_carb, dbo.Carburant.lib_carb, dbo.Vehicule.n_cat, dbo.Categorie.lib_cat FROM dbo.Vehicule INNER JOIN dbo.Carburant ON dbo.Vehicule.n_carb = dbo.Carburant.n_carb INNER JOIN dbo.Categorie ON dbo.Vehicule.n_cat = dbo.Categorie.n_cat where mat_vehi='" & cbxMatricule.Text & "' ", con)

                dr = cmd.ExecuteReader
                dr.Read()

                'txtbxMatricule.Items.Add(dr.Item("mat_vehi"))
                'cbxRepaP.Items.Add(dr.Item("lib_reparateur"))

                '  txtbxMatricule.Text = dr.Item("mat_vehi")
                txtbxMarqueV.Text = dr.Item("lib_marqq")

                txtbxNbrP.Text = dr.Item("nbr_Plc")
                txtbxNChassis.Text = dr.Item("num_chass")

                txtbxNmoteur.Text = dr.Item("num_moteur")

                ' cbxCategorie.Items.Add(dr.Item("lib_cat"))
                cbxCategorie.Text = dr.Item("lib_cat")
                txtbxNcategorie.Text = dr.Item("n_cat")

                'cbxCarburant.Items.Add(dr.Item("lib_carb"))
                cbxCarburant.Text = dr.Item("lib_carb")
                txtbxNcarburant.Text = dr.Item("n_carb")

                txtbxKilom.Text = dr.Item("Kilom")
                txtbxDatCirc.Text = dr.Item("date_circul")

                ''cbxChauff.Items.Add(dr.Item("Nom"))
                'cbxChauff.Text = dr.Item("Nom")
                'txtbxNChauffeur.Text = dr.Item("n_chauff")

                '' cbxAff.Items.Add(dr.Item("lib_aff"))
                'cbxAff.Text = dr.Item("lib_aff")
                'txtbxNAffectation.Text = dr.Item("n_aff")

                'txtbxDatAff.Text = dr.Item("dat_aff")
                ''cbxTypeB.Items.Add(dr.Item("t_aff"))
                'txtbxTypeB.Text = dr.Item("t_aff")

                '' cbxetatVehi.Items.Add(dr.Item("lib_etat_vehi"))
                'cbxetatVehi.Text = dr.Item("lib_etat_vehi")
                'txtbxNEtat.Text = dr.Item("n_etat_vehi")


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

    Protected Sub btnModifVeh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnModifVeh.Click

        Try
            con.Close()
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update Vehicule set lib_marqq='" & txtbxMarqueV.Text & "',nbr_Plc=" & txtbxNbrP.Text & ",num_chass='" & txtbxNChassis.Text & "',num_moteur='" & txtbxNmoteur.Text & "',date_circul='" & txtbxDatCirc.Text & "', Kilom='" & txtbxKilom.Text & "',n_carb= " & txtbxNcarburant.Text & ",  n_cat=" & txtbxNcategorie.Text & " where mat_vehi='" & cbxMatricule.Text & "' "


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

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click

    End Sub
End Class