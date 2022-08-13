Imports System.Data
Imports System.Data.SqlClient

Partial Public Class WebForm30
    Inherits System.Web.UI.Page


    Function N_L() As Int32
        'retourne l dernier numero du série du pneus plus 1
        Dim m As Int32
        ' Dim con As New SqlConnection(Application("str"))
        Dim cmd As SqlCommand = New SqlCommand("select N_A_F from Autre_F", con)
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
                cmd = New SqlCommand(" SELECT dbo.Autre_F.mat_vehi, dbo.Autre_F.n_rep, dbo.Reparateur.lib_reparateur, dbo.Autre_F.n_reparation, dbo.tc_reparation.lib_reparation,dbo.Autre_F.Ref, dbo.Autre_F.Descp, dbo.Autre_F.Date, dbo.Autre_F.Prix, dbo.Autre_F.n_cons, dbo.Autre_F.N_A_F, dbo.Autre_F.n_cons FROM dbo.Autre_F INNER JOIN dbo.Reparateur ON dbo.Autre_F.n_rep = dbo.Reparateur.n_reparateur INNER JOIN  dbo.tc_reparation ON dbo.Autre_F.n_reparation = dbo.tc_reparation.n_reparation ", con)
                dr = cmd.ExecuteReader
                dr.Read()

                cbxMatricule.Items.Add(dr.Item("mat_vehi"))
                cbxReparateur.Items.Add(dr.Item("lib_reparateur"))
                cbxTypeRep.Items.Add(dr.Item("lib_reparation"))

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

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
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

        txtbxDate.Text = ""
        txtbxDescp.Text = ""
        txtbxPrix.Text = ""
        txtbxRef.Text = ""

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

        cbxTypeRep.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_reparation,lib_reparation From tc_reparation ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        txtbxTypeRep.Text = dr.Item("n_reparation")
        Do
            cbxTypeRep.Items.Add(dr.Item("lib_reparation"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


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
        cmd = New SqlCommand(" select distinct mat_vehi From Autre_F ", con)
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

        cbxTypeRep.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_reparation,lib_reparation From tc_reparation ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        'txtbxTypeRep.Text = dr.Item("n_reparation")
        Do
            cbxTypeRep.Items.Add(dr.Item("lib_reparation"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()

    End Sub

    Private Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
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
        cmd = New SqlCommand(" select distinct mat_vehi From Autre_F ", con)
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

        cbxTypeRep.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_reparation,lib_reparation From tc_reparation ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        txtbxTypeRep.Text = dr.Item("n_reparation")
        Do
            cbxTypeRep.Items.Add(dr.Item("lib_reparation"))

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

    Private Sub cbxTypeRep_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxTypeRep.SelectedIndexChanged
        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand("SELECT n_reparation,lib_reparation from tc_reparation where  lib_reparation ='" & cbxTypeRep.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxTypeRep.Text = dr.Item("n_reparation")

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

    Private Sub cbxMatricule_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxMatricule.SelectedIndexChanged
        If btnModifierReparation.Visible = True Or btnsuppReparation.Visible = True Then

            Try
                con.Close()
                con.Open()
                cmd = New SqlCommand(" SELECT dbo.Autre_F.mat_vehi, dbo.Autre_F.n_rep, dbo.Reparateur.lib_reparateur, dbo.Autre_F.n_reparation, dbo.tc_reparation.lib_reparation,dbo.Autre_F.Ref, dbo.Autre_F.Descp, dbo.Autre_F.Date, dbo.Autre_F.Prix, dbo.Autre_F.n_cons, dbo.Autre_F.N_A_F, dbo.Autre_F.n_cons FROM dbo.Autre_F INNER JOIN dbo.Reparateur ON dbo.Autre_F.n_rep = dbo.Reparateur.n_reparateur INNER JOIN  dbo.tc_reparation ON dbo.Autre_F.n_reparation = dbo.tc_reparation.n_reparation where mat_vehi='" & cbxMatricule.Text & "' ", con)
                'cmd = New SqlCommand("SELECT dbo.ReparationT.N_RepT, dbo.ReparationT.mat_vehi, dbo.Reparateur.lib_reparateur, dbo.tc_reparation.lib_reparation, dbo.ReparationT.Ref, dbo.ReparationT.Descp,dbo.ReparationT.Date, dbo.ReparationT.Prix, dbo.ReparationT.NFact, dbo.ReparationT.n_cons, dbo.tc_reparation.n_reparation, dbo.Reparateur.n_reparateur FROM dbo.ReparationT INNER JOIN dbo.Reparateur ON dbo.ReparationT.n_rep = dbo.Reparateur.n_reparateur INNER JOIN dbo.tc_reparation ON dbo.ReparationT.n_reparation = dbo.tc_reparation.n_reparation where mat_vehi='" & cbxMatricule.Text & "'", con)

                dr = cmd.ExecuteReader
                dr.Read()

                lblNRepT.Text = dr.Item("N_A_F")
                lblncons.Text = dr.Item("n_cons")
                ' txtbxNVehi.Text = dr.Item("n_vehi")
                cbxReparateur.Text = dr.Item("lib_reparateur")
                txtbxReparateur.Text = dr.Item("n_rep")
                cbxTypeRep.Text = dr.Item("lib_reparation")
                txtbxTypeRep.Text = dr.Item("n_reparation")
                txtbxRef.Text = dr.Item("Ref")
                txtbxDescp.Text = dr.Item("Descp")
                txtbxDate.Text = dr.Item("Date")
                'cbxDate.Text = dr.Item("Date")
                txtbxPrix.Text = dr.Item("Prix")

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

    Private Sub btnAjoutReparation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAjoutReparation.Click
        If cbxMatricule.Text = Nothing Then

            Msg_Erreur(" Veuillez remplir les champs ")

        Else

            If txtbxDate.Text = Nothing Then

                cmd = New SqlCommand("insert into ReparationT values(" & lblNRepT.Text & ",'" & cbxMatricule.Text & "'," & txtbxReparateur.Text & "," & txtbxTypeRep.Text & ",'" & txtbxRef.Text & "','" & txtbxDescp.Text & "','" & txtbxDate.Text & "','" & txtbxPrix.Text & "'," & lblncons.Text & ")", con)

                con.Close()
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                cmd = New SqlCommand("insert into consommation (N_cons,n_vehi,mat_vehi,montant,Autre_F) values(" & lblncons.Text & "," & txtbxNVehi.Text & ",'" & cbxMatricule.Text & "','" & txtbxPrix.Text & "'," & lblNRepT.Text & ")", con)

                con.Close()
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                Msg_succes(" Ajout réalisé avec succès ")

                txtbxDate.Text = ""
                txtbxDescp.Text = ""
                txtbxPrix.Text = ""
                txtbxRef.Text = ""

            Else

                Try
                    If Not IsDate(Me.txtbxDate.Text) Then
                        Msg_Erreur(" Format date et jj/mm/aa ")
                    Else

                        cmd = New SqlCommand("insert into Autre_F values(" & lblNRepT.Text & ",'" & cbxMatricule.Text & "'," & txtbxReparateur.Text & "," & txtbxTypeRep.Text & ",'" & txtbxRef.Text & "','" & txtbxDescp.Text & "','" & txtbxDate.Text & "','" & txtbxPrix.Text & "'," & lblncons.Text & ")", con)

                        con.Close()
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()

                        cmd = New SqlCommand("insert into consommation (N_cons,n_vehi,mat_vehi,montant,Autre_F) values(" & lblncons.Text & "," & txtbxNVehi.Text & ",'" & cbxMatricule.Text & "','" & txtbxPrix.Text & "'," & lblNRepT.Text & ")", con)

                        con.Close()
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()

                        Msg_succes(" Ajout réalisé avec succès ")

                        txtbxDate.Text = ""
                        txtbxDescp.Text = ""
                        txtbxPrix.Text = ""
                        txtbxRef.Text = ""

                    End If

                Catch ex As Exception
                    Msg_Erreur(ex.Message)
                    con.Close()
                End Try
                con.Close()
            End If

        End If
    End Sub

    Private Sub btnModifierReparation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModifierReparation.Click

        If txtbxDate.Text = Nothing Then

            Try

                con.Close()
                con.Open()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update Autre_F set n_rep='" & txtbxReparateur.Text & "',n_reparation='" & txtbxTypeRep.Text & "',Ref='" & txtbxRef.Text & "',Descp='" & txtbxDescp.Text & "',Date='" & txtbxDate.Text & "',Prix='" & txtbxPrix.Text & "' where mat_vehi='" & cbxMatricule.Text & "' and n_cons='" & lblncons.Text & "' "

                cmd.ExecuteNonQuery()
                con.Close()

                Msg_succes("Modification réalisé avec succès")


            Catch ex As Exception
                Msg_Erreur(ex.Message)
                con.Close()
            End Try
            con.Close()

        Else


            Try
                If Not IsDate(Me.txtbxDate.Text) Then
                    Msg_Erreur(" Format date et jj/mm/aa ")

                Else
                    con.Close()
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "update Autre_F set n_rep='" & txtbxReparateur.Text & "',n_reparation='" & txtbxTypeRep.Text & "',Ref='" & txtbxRef.Text & "',Descp='" & txtbxDescp.Text & "',Date='" & txtbxDate.Text & "',Prix='" & txtbxPrix.Text & "' where mat_vehi='" & cbxMatricule.Text & "' and n_cons='" & lblncons.Text & "'  "

                    cmd.ExecuteNonQuery()
                    con.Close()

                    Msg_succes("Modification réalisé avec succès")

                End If
            Catch ex As Exception
                Msg_Erreur(ex.Message)
                con.Close()
            End Try
            con.Close()

        End If
    End Sub

    Private Sub btnsuppReparation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsuppReparation.Click
        Try

            cmd = New SqlCommand("delete  from consommation where n_cons= '" & lblncons.Text & "' and mat_vehi='" & cbxMatricule.Text & "' and Autre_F='" & lblNRepT.Text & "' ", con)
            con.Close()
            con.Open()
            dr = cmd.ExecuteReader
            dr.Read()
            dr.Close()
            con.Close()

            cmd = New SqlCommand("delete  from Autre_F where N_A_F= '" & lblNRepT.Text & "' and mat_vehi='" & cbxMatricule.Text & "' and n_cons ='" & lblncons.Text & "' ", con)
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
End Class