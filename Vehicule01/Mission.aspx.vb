Imports System.Data
Imports System.Data.SqlClient

Partial Public Class WebForm27
    Inherits System.Web.UI.Page

    Function N_L() As Int32
        'retourne l dernier numero du série du pneus plus 1
        Dim m As Int32
        ' Dim con As New SqlConnection(Application("str"))
        Dim cmd As SqlCommand = New SqlCommand("select N_cons from consommation", con)
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

    Function N_L2() As Int32
        'retourne l dernier numero du série du pneus plus 1
        Dim m As Int32
        ' Dim con As New SqlConnection(Application("str"))
        Dim cmd As SqlCommand = New SqlCommand("select N_Miss from Mission", con)
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
        'txtbxDateD.Enabled = False
        'txtbxDateD.Text = Day(Now()) & "/" & Month(Now()) & "/" & Year(Now())

    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        If txtbxVille.Visible = True Then
        Else
            Lblerror.Visible = False
            img_error.Visible = False
            img_succes.Visible = False

            img_new.Visible = True
            img_mod.Visible = False
            img_suppr.Visible = False

            btnAjoutMI.Visible = True
            btnAjoutMI.Enabled = True

            btnAnnulerMI.Visible = True
            btnsuppMI.Visible = False
            'btnModifierMI.Visible = False

            lblVille.Visible = False
            txtbxVille.Visible = False

            lblMontant.Visible = True
            txtbxMontant.Visible = True

            Dim n As Integer = N_L()
            lblNConsMI.Text = n + 1

            Dim nM As Integer = N_L2()
            lblNMiss.Text = nM + 1



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

            '*********Type Vehicule

            cbxTypeVehi.Items.Clear()

            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct lib_marqq From Vehicule ", con)
            dr = cmd.ExecuteReader
            dr.Read()
            ' cbxMarq.Text = dr.Item("lib_marq")
            ' txtbxNVehiMI.Text = dr.Item("n_vehi")
            Do
                cbxTypeVehi.Items.Add(dr.Item("lib_marqq"))

            Loop While (dr.Read)
            dr.Close()
            con.Close()


            '*********Chauffeur

            cbxChaufMI.Items.Clear()

            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct n_chauff,Nom From chauffeurV ", con)
            dr = cmd.ExecuteReader
            dr.Read()
            ' cbxMarq.Text = dr.Item("lib_marq")
            txtbxNChauffMI.Text = dr.Item("n_chauff")
            Do
                cbxChaufMI.Items.Add(dr.Item("Nom"))

            Loop While (dr.Read)
            dr.Close()
            con.Close()

            '*********Destination
            cbxDesti.Items.Clear()

            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct n_des,lib_des From tc_destination ", con)
            dr = cmd.ExecuteReader
            dr.Read()
            txtbxNDesct.Text = dr.Item("n_des")
            Do
                cbxDesti.Items.Add(dr.Item("lib_des"))

            Loop While (dr.Read)
            dr.Close()
            con.Close()


            '*********Personnel
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()

            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct Nom,Prenom From Personnel ", con)
            dr = cmd.ExecuteReader
            dr.Read()
            ' cbxMarq.Text = dr.Item("lib_marq")
            Do
                ListBox1.Items.Add(dr.Item("Nom"))

            Loop While (dr.Read)
            dr.Close()
            con.Close()
        End If

        txtbxDateD.Text = Now.Date


    End Sub

    'Private Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click

    '    lblVille.Visible = False
    '    txtbxVille.Visible = False

    '    lblMontant.Visible = True
    '    txtbxMontant.Visible = True

    'End Sub

    'Private Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click

    '    lblVille.Visible = False
    '    txtbxVille.Visible = False

    '    lblMontant.Visible = True
    '    txtbxMontant.Visible = True

    'End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

        lblVille.Visible = True
        txtbxVille.Visible = True

        lblDestination.Visible = False
        cbxDesti.Visible = False

        lblTypeVehi.Visible = False
        cbxTypeVehi.Visible = False

        cbxMatVehiMI.Enabled = False
        cbxChaufMI.Enabled = False
        txtbxDateD.Enabled = False
        txtbxNDateF.Enabled = False
        cbxDesti.Enabled = False
        'cbxPerso.Enabled = False

        ListBox1.Enabled = False
        ListBox2.Enabled = False

        Button3.Enabled = False
        Button5.Enabled = False

        Button2.Enabled = False

        ImageButton1.Enabled = False
        'ImageButton2.Enabled = False
        'ImageButton3.Enabled = False
        btnImpPneus.Enabled = False

        txtbxObse.Enabled = False

        txtbxVille.Focus()

        btnAjoutMI.Enabled = True
        btnAjoutMI.Visible = True
        'btnModifierMI.Visible = False
        btnsuppMI.Visible = False
        btnAnnulerMI.Visible = True

    End Sub

    Private Sub btnAnnulerMI_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnnulerMI.Click

        lblVille.Visible = False
        txtbxVille.Visible = False

        lblDestination.Visible = True
        cbxDesti.Visible = True

        lblTypeVehi.Visible = False
        cbxTypeVehi.Visible = False

        cbxMatVehiMI.Enabled = True
        cbxChaufMI.Enabled = True
        txtbxDateD.Enabled = True
        txtbxNDateF.Enabled = True
        cbxDesti.Enabled = True
        'cbxPerso.Enabled = True
        txtbxObse.Enabled = True

        ListBox1.Enabled = True
        ListBox2.Enabled = True

        Button3.Enabled = True
        Button5.Enabled = True

        Button2.Enabled = True

        ImageButton1.Enabled = True
        'ImageButton2.Enabled = True
        'ImageButton3.Enabled = True
        btnImpPneus.Enabled = True

        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = True
        img_mod.Visible = False
        img_suppr.Visible = False

        '*********Type Vehicule

        cbxTypeVehi.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct lib_marqq From Vehicule ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        ' txtbxNVehiMI.Text = dr.Item("n_vehi")
        Do
            cbxTypeVehi.Items.Add(dr.Item("lib_marqq"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()



        '*********Chauffeur

        cbxChaufMI.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_chauff,Nom From chauffeurV ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        txtbxNChauffMI.Text = dr.Item("n_chauff")
        Do
            cbxChaufMI.Items.Add(dr.Item("Nom"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()

        '*********Destination
        cbxDesti.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct lib_des From tc_destination ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        Do
            cbxDesti.Items.Add(dr.Item("lib_des"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


        ''*********Personnel
        'cbxPerso.Items.Clear()

        'con.Close()
        'con.Open()
        'cmd = New SqlCommand(" select distinct Nom,Prenom From Personnel ", con)
        'dr = cmd.ExecuteReader
        'dr.Read()
        '' cbxMarq.Text = dr.Item("lib_marq")
        'Do
        '    cbxPerso.Items.Add(dr.Item("Nom"))

        'Loop While (dr.Read)
        'dr.Close()
        'con.Close()

    End Sub

    Private Sub btnAjoutMI_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAjoutMI.Click
        If txtbxVille.Visible = True Then

            Dim req0 As String

            req0 = "select lib_des from tc_destination where lib_des ='" & Me.txtbxVille.Text & "' "

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
                Msg_Erreur(" Erreur....!!! Cette Ville éxiste déjà ")
                con.Close()
            Else
                Try

                    cmd = New SqlCommand("insert into tc_destination values('" & txtbxVille.Text & "')", con)

                    con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()
                    Msg_succes(" Ajout réalisé avec succès ")

                    txtbxVille.Text = ""

                    con.Close()
                Catch ex As Exception
                    ' Msg_Erreur("Erreur de ............!!!!!!")
                    Msg_Erreur(ex.Message)
                    con.Close()
                End Try
                con.Close()
            End If
        Else

            If txtbxDateD.Text <> Nothing And txtbxNDateF.Text <> Nothing And txtbxMontant.Text <> Nothing Then



                If Not IsDate(Me.txtbxDateD.Text) Or Not IsDate(Me.txtbxNDateF.Text) Then
                    Msg_Erreur(" Format date en jj/mm/aa ")

                Else

                    If Val(txtbxNDateF.Text) >= Val(txtbxDateD.Text) Then

                        'If (lblSNTLRes.Text) >= 0 Then

                        '    cmd = New SqlCommand("insert into SNTL(Date,Montant1,Montant2) values('" & txtbxDateD.Text & "','" & lblSNTLRes.Text & "','" & lblSNTL.Text & "')", con)
                        '    con.Close()
                        '    con.Open()
                        '    cmd.ExecuteNonQuery()
                        '    con.Close()

                        Dim req0 As String

                        req0 = " select M.mat_vehi,M.Date_D  from Mission M where M.mat_vehi='" & cbxMatVehiMI.Text & "' and  M.Date_F between '" & txtbxDateD.Text & "' and '" & txtbxNDateF.Text & "' "

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
                            Msg_Erreur(" Erreur....!!! Ce véhicule est actuellement en mission ")
                            con.Close()
                        Else

                            Dim req1 As String

                            req1 = " select N_Chauff,Date_F  from Mission where N_chauff ='" & txtbxNChauffMI.Text & "' and Date_F between '" & txtbxDateD.Text & "' and '" & txtbxNDateF.Text & "'  "

                            Dim cmd1 As New SqlCommand(req1, con)
                            con.Close()
                            con.Open()
                            Dim dr1 As SqlDataReader
                            dr1 = cmd1.ExecuteReader
                            Dim trouve1 As Boolean
                            trouve1 = False

                            Do While dr1.Read
                                trouve1 = True
                            Loop
                            dr0.Close()
                            If trouve1 = True Then
                                Msg_Erreur(" Erreur....!!! Ce chauffeur est actuellement en mission ")
                                con.Close()
                            Else
                                Dim req2 As String

                                req2 = " select Ordre_M from Mission where Ordre_M='" & txtbxSouche.Text & "' "

                                Dim cmd2 As New SqlCommand(req2, con)
                                con.Close()
                                con.Open()
                                Dim dr2 As SqlDataReader
                                dr2 = cmd2.ExecuteReader
                                Dim trouve2 As Boolean
                                trouve2 = False

                                Do While dr2.Read
                                    trouve2 = True
                                Loop
                                dr0.Close()
                                If trouve2 = True Then
                                    Msg_Erreur(" Erreur....!!! Cet ordre de mission éxiste déjà ")
                                    con.Close()
                                Else


                                    Try

                                        cmd = New SqlCommand("insert into Mission values(" & lblNMiss.Text & "," & txtbxNVehiMI.Text & ",'" & cbxMatVehiMI.Text & "','" & cbxTypeVehi.Text & "'," & txtbxNChauffMI.Text & ",'" & txtbxSouche.Text & "'," & txtbxNDesct.Text & ",'" & txtbxDateD.Text & "','" & txtbxNDateF.Text & "','" & txtbxMontant.Text & "','" & txtbxObse.Text & "','" & lblFraisMI.Text & "'," & lblNConsMI.Text & ")", con)
                                        con.Close()
                                        con.Open()
                                        cmd.ExecuteNonQuery()
                                        con.Close()

                                        cmd = New SqlCommand("insert into consommation(N_cons,n_vehi,mat_vehi,montant,N_Miss) values(" & lblNConsMI.Text & "," & txtbxNVehiMI.Text & ",'" & cbxMatVehiMI.Text & "','" & txtbxMontant.Text & "'," & lblNMiss.Text & ")", con)
                                        con.Close()
                                        con.Open()
                                        cmd.ExecuteNonQuery()
                                        con.Close()

                                        Msg_succes(" Ajout réalisé avec succès ")
                                    Catch ex As Exception
                                        ' Msg_Erreur("Erreur de ............!!!!!!")
                                        Msg_Erreur(ex.Message)
                                        con.Close()
                                    End Try
                                    con.Close()

                                    'Else
                                    '    Msg_Erreur("Le Montant et Insuffisant")
                                    'End If

                                End If
                            End If
                        End If

                    Else
                        Msg_Erreur(" la date de retour est antérieure à la date de début de mission ")
                    End If

                    End If

            Else
                Msg_Erreur("Veuillez remplir les champs suivants :Date de debut , date de retour , Montant et les noms des Missionnaires(personnel accompagnant)")
            End If
        End If

    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        If txtbxDateD.Text = Nothing Or txtbxNDateF.Text = Nothing Then

            Msg_Erreur(" Veuillez saissir la date debut ou date fin ")

        Else

            If txtbxDateD.Text < txtbxNDateF.Text Then


                Dim req0 As String

                'req0 = " select P.Nom_Perso,M.dat_miss,M.dat_ret from mission_Perso P,Mission M where P.N_Mission=M.N_Miss and M.dat_miss >= '" & txtbxDateD.Text & "' and M.dat_ret >= '" & txtbxNDateF.Text & "' and P.Nom_Perso='" & ListBox1.SelectedItem.Text & "'"
                'req0 = "select P.M,M.Date_D ,M.Date_F from mission_Perso P,Mission M where P.N=M.N_Miss and M.Date_D >= '" & txtbxDateD.Text & "' and M.Date_F >= '" & txtbxNDateF.Text & "' and P.M='" & ListBox1.SelectedItem.Text & "'"

                req0 = " select P.M,M.Date_D ,M.Date_F from mission_Perso P,Mission M where P.N=M.N_Miss and P.M='" & ListBox1.SelectedItem.Text & "' and M.Date_F between '" & txtbxDateD.Text & "' and '" & txtbxNDateF.Text & "' "

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
                    Msg_Erreur(" Ce personnel il est actuellement en mission ")
                    con.Close()
                Else

                    Try
                        con.Close()
                        con.Open()
                        cmd = New SqlCommand("insert into mission_Perso values ( " & lblNMiss.Text & ",'" & ListBox1.SelectedItem.Text & "')", con)
                        cmd.ExecuteNonQuery()
                        con.Close()

                        ListBox2.Items.Add(ListBox1.SelectedItem.Text)
                        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)

                    Catch ex As Exception
                        Msg_Erreur("Erreur....!!? Veuillez choisir un element de la liste")
                    End Try
                End If
            Else
                Msg_Erreur(" la date debut de mission et superieur au date de retour de mission ")
            End If
        End If

    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand("delete from mission_Perso where M='" & ListBox2.SelectedItem.Text & "' and N=" & lblNMiss.Text & "", con)
            cmd.ExecuteNonQuery()
            con.Close()

            ListBox1.Items.Add(ListBox2.SelectedItem.Text)
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)

        Catch ex As Exception

            Msg_Erreur("Erreur....!!? Veuillez choisir un element de la liste")

        End Try

    End Sub

    Private Sub cbxMatVehiMI_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxMatVehiMI.SelectedIndexChanged
        Try
            con.Close()
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select distinct n_vehi,mat_vehi from Vehicule where mat_vehi ='" & cbxMatVehiMI.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxNVehiMI.Text = dr.Item("n_vehi")
            cbxMatVehiMI.Text = dr.Item("mat_vehi")

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

    Private Sub cbxChaufMI_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxChaufMI.SelectedIndexChanged
        Try
            con.Close()
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select distinct n_chauff,Nom from chauffeurV where Nom ='" & cbxChaufMI.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxNChauffMI.Text = dr.Item("n_chauff")
            cbxChaufMI.Text = dr.Item("Nom")

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

    Private Sub cbxDesti_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxDesti.SelectedIndexChanged
        Try
            con.Close()
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select distinct n_des,lib_des from tc_destination where lib_des ='" & cbxDesti.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxNDesct.Text = dr.Item("n_des")
            cbxDesti.Text = dr.Item("lib_des")

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

    Protected Sub cbxTypeVehi_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxTypeVehi.SelectedIndexChanged

        '*********Type Vehicule

        cbxMatVehiMI.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct lib_marqq,mat_vehi,N_Vehi From Vehicule where lib_marqq='" & cbxTypeVehi.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        txtbxNVehiMI.Text = dr.Item("n_vehi")
        Do
            cbxMatVehiMI.Items.Add(dr.Item("mat_vehi"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


    End Sub

    'Protected Sub btnSouche_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSouche.Click

    '    Lblerror.Visible = False
    '    img_error.Visible = False
    '    img_succes.Visible = False

    '    If lblNConsMI.Text = "" Or txtbxSouche.Text = "" Then

    '        Msg_Erreur("Veuillez remplir le champs")

    '    Else

    '        Dim req0 As String

    '        req0 = " select N_Cons,Souche from Souche where N_Cons='" & lblNConsMI.Text & "' and Souche='" & txtbxSouche.Text & "'"

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
    '                cmd = New SqlCommand("insert into Souche values ( " & lblNConsMI.Text & ",'" & txtbxSouche.Text & "')", con)
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

End Class