Imports System.Data
Imports System.Data.SqlClient

Partial Public Class WebForm2
    Inherits System.Web.UI.Page

    Function N_L() As Int32
        'retourne l dernier numero du série du pneus plus 1
        Dim m As Int32
        ' Dim con As New SqlConnection(Application("str"))
        Dim cmd As SqlCommand = New SqlCommand("select N_Pneus from Pneus", con)
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

        ' If btnAjoutPneus.Enabled = False Then

        If Not Page.IsPostBack Then

            'Label1.Text = Now.Date

            '********* Afficher Pneus
            Try

                con.Close()
                con.Open()
                cmd = New SqlCommand(" SELECT dbo.Pneus.mat_vehi, dbo.Reparateur.n_reparateur,dbo.Reparateur.lib_reparateur, dbo.Pneus.DateD, dbo.Pneus.Km, dbo.Marque_Pneus.N_Serie,dbo.Marque_Pneus.Marq_Pneus, dbo.Pneus.Qte,dbo.Pneus.N_Fact, dbo.Pneus.Prix FROM dbo.Pneus INNER JOIN dbo.Marque_Pneus ON dbo.Pneus.N_Serie = dbo.Marque_Pneus.N_Serie INNER JOIN dbo.Reparateur ON dbo.Pneus.n_reparateur = dbo.Reparateur.n_reparateur", con)
                dr = cmd.ExecuteReader
                dr.Read()

                cbxMatVehiP.Items.Add(dr.Item("mat_vehi"))
                cbxRepaP.Items.Add(dr.Item("lib_reparateur"))
                txtbxKm.Text = dr.Item("Km")
                txtbxDateP.Text = dr.Item("DateD")
                cbxMarq.Items.Add(dr.Item("Marq_Pneus"))
                cbxQteP.Text = "1"
                txtbxPrixP.Text = dr.Item("Prix")
                txtbxNFactP.Text = dr.Item("N_Fact")
                'txtbxDate2.Text = dr.Item("DateF")

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

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = True
        img_suppr.Visible = False

        btnAjoutPneus.Visible = True
        btnAjoutPneus.Enabled = True
        btnAnnulerPneus.Visible = True
        btnsuppPneus.Visible = False

        'cbxMarq.Items.Add(dr.Item("Marq_Pneus"))
        'cbxMatVehiP.Items.Add(dr.Item("mat_vehi"))
        'cbxRepaP.Items.Add(dr.Item("lib_reparateur"))
        txtbxKm.Text = ""
        txtbxDateP.Text = ""
        cbxQteP.Text = "0"
        txtbxPrixP.Text = ""
        txtbxNFactP.Text = ""
        'txtbxDate2.Text = ""


        ''*********Montant SNTL

        'lblSNTL.Text = ""

        'con.Close()
        'con.Open()
        ''   cmd = New SqlCommand(" select distinct Montant1 From SNTL ", con)
        'cmd = New SqlCommand("select distinct NSNTL,Montant1 From SNTL order by NSNTL desc", con)
        'dr = cmd.ExecuteReader
        'dr.Read()
        '' cbxMarq.Text = dr.Item("lib_marq")

        'lblSNTL.Text = dr.Item("Montant1")

        'dr.Close()
        'con.Close()



        '*********Reparateur

        cbxRepaP.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_reparateur,lib_reparateur From Reparateur ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        txtbxNrep.Text = dr.Item("n_reparateur")

        Do
            cbxRepaP.Items.Add(dr.Item("lib_reparateur"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


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


        '*********Matricule Pneus

        cbxMarq.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct Marq_Pneus From Marque_Pneus ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        '  txtbxMarqP.Text = dr.Item("N_Serie")
        Do
            cbxMarq.Items.Add(dr.Item("Marq_Pneus"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()

        Dim n As Integer = N_L()
        lblNPneus.Text = n + 1

        Dim nn As Integer = N_L2()
        lblNCons.Text = nn + 1

    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = False
        img_suppr.Visible = True

        btnAjoutPneus.Visible = False
        btnAnnulerPneus.Visible = True
        btnsuppPneus.Visible = True
    End Sub

    Protected Sub btnAjoutPneus_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAjoutPneus.Click
        If cbxMatVehiP.Text = Nothing Then

            Msg_Erreur(" Veuillez remplir le champ ")

        Else

            Dim req0 As String

            req0 = "select n_Fact from Pneus where n_Fact ='" & Me.txtbxNFactP.Text & "' "

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
                Msg_Erreur(" Cette facture éxiste déjà ")
                con.Close()
            Else

                If txtbxDateP.Text = Nothing Then


                    Try

                        cmd = New SqlCommand("insert into Pneus values(" & lblNPneus.Text & ",'" & cbxMatVehiP.Text & "'," & txtbxNrep.Text & ",'" & txtbxDateP.Text & "','" & txtbxKm.Text & "','" & txtbxMarqP.Text & "'," & cbxQteP.SelectedIndex & ",'" & txtbxPrixP.Text & "','" & txtbxNFactP.Text & "'," & lblNCons.Text & ")", con)

                        con.Close()
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()


                        cmd = New SqlCommand("insert into consommation (N_cons,n_vehi,mat_vehi,montant,n_pneus,n_reparateur,dat_cons,souche,n_fact,km) values(" & lblNCons.Text & "," & txtbxNVehi.Text & ",'" & cbxMatVehiP.Text & "','" & txtbxPrixP.Text & "'," & lblNPneus.Text & "," & txtbxNrep.Text & ",'" & txtbxDateP.Text & "','" & txtbxSouche.Text & "','" & txtbxNFactP.Text & "','" & txtbxKm.Text & "')", con)

                        con.Close()
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()

                        Msg_succes(" Ajout réalisé avec succès ")

                        txtbxKm.Text = ""
                        txtbxDateP.Text = ""
                        txtbxSouche.Text = ""
                        txtbxPrixP.Text = ""
                        txtbxNFactP.Text = ""

                    Catch ex As Exception
                        Msg_Erreur(ex.Message)
                        con.Close()
                    End Try
                    con.Close()

                Else
                    If Not IsDate(Me.txtbxDateP.Text) Then
                        Msg_Erreur(" Format date en jj/mm/aa ")

                    Else
                        Try

                            cmd = New SqlCommand("insert into Pneus values(" & lblNPneus.Text & ",'" & cbxMatVehiP.Text & "'," & txtbxNrep.Text & ",'" & txtbxDateP.Text & "','" & txtbxKm.Text & "','" & txtbxMarqP.Text & "'," & cbxQteP.SelectedIndex & ",'" & txtbxPrixP.Text & "','" & txtbxNFactP.Text & "'," & lblNCons.Text & ")", con)

                            con.Close()
                            con.Open()
                            cmd.ExecuteNonQuery()
                            con.Close()


                            cmd = New SqlCommand("insert into consommation (N_cons,n_vehi,mat_vehi,montant,n_pneus,n_reparateur,dat_cons,souche,n_fact,km) values(" & lblNCons.Text & "," & txtbxNVehi.Text & ",'" & cbxMatVehiP.Text & "','" & txtbxPrixP.Text & "'," & lblNPneus.Text & "," & txtbxNrep.Text & ",'" & txtbxDateP.Text & "','" & txtbxSouche.Text & "','" & txtbxNFactP.Text & "','" & txtbxKm.Text & "')", con)

                            con.Close()
                            con.Open()
                            cmd.ExecuteNonQuery()
                            con.Close()

                            Msg_succes(" Ajout réalisé avec succès ")

                            txtbxKm.Text = ""
                            txtbxDateP.Text = ""
                            txtbxSouche.Text = ""
                            txtbxPrixP.Text = ""
                            txtbxNFactP.Text = ""

                        Catch ex As Exception
                            Msg_Erreur(ex.Message)
                            con.Close()
                        End Try
                        con.Close()

                    End If

                End If

            End If

        End If

    End Sub

    Protected Sub cbxRepaP_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxRepaP.SelectedIndexChanged

        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct n_reparateur,lib_reparateur From Reparateur where  lib_reparateur='" & cbxRepaP.Text & "' ", con)
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxNrep.Text = dr.Item("n_reparateur")

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

    Private Sub cbxMarq_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxMarq.SelectedIndexChanged
        'Try
        '    con.Close()
        '    con.Open()
        '    cmd = New SqlCommand(" select distinct N_Serie,Marq_Pneus From Marque_Pneus where  Marq_Pneus='" & cbxMarq.Text & "' ", con)
        '    dr = cmd.ExecuteReader
        '    dr.Read()

        '    txtbxMarqP.Text = dr.Item("N_Serie")

        '    Lblerror.Visible = False
        '    img_error.Visible = False
        '    img_succes.Visible = False

        '    dr.Close()
        '    con.Close()
        'Catch ex As Exception
        '    Msg_Erreur(ex.Message)
        '    con.Close()
        'End Try
        'con.Close()


        cbxRef.Items.Clear()

        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct N_Serie,Marq_Pneus,Dimenssion,Description,Qte,Prix From Marque_Pneus where  Marq_Pneus='" & cbxMarq.Text & "' ", con)
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxMarqP.Text = dr(0)

            'txtbxdesc.Text = dr(3)
            ''lblNQte.Text = dr(4)
            'Txtbxprix.Text = dr(5)

            Do
                cbxRef.Items.Add(dr.Item("Dimenssion"))

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

    Protected Sub btnsuppPneus_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnsuppPneus.Click
        'Try

        '    '   cmd = New SqlCommand("delete  from Pneus where N_Pneus= '" & txtbxNSerie.Text & "'", con)
        '    con.Close()
        '    con.Open()
        '    dr = cmd.ExecuteReader
        '    dr.Read()
        '    Msg_succes("suppression réalisée avec succès")
        '    dr.Close()
        '    con.Close()

        '    '********************Marque

        '    ' cbxMarque.Items.Clear()

        '    con.Close()
        '    con.Open()
        '    cmd = New SqlCommand("select distinct N_Serie,Marq_Pneus,Dimenssion,Qte,Prix From Marque_Pneus ", con)
        '    dr = cmd.ExecuteReader
        '    dr.Read()
        '    ' cbxMarq.Text = dr.Item("lib_marq")

        '    'txtbxNSerie.Text = dr(0)
        '    'txtbxDimenssion.Text = dr(2)
        '    'lblNQte.Text = dr(3)
        '    'txtbxPrix.Text = dr(4)


        '    Do
        '        'cbxMarque.Items.Add(dr.Item("Marq_Pneus"))

        '    Loop While (dr.Read)
        '    dr.Close()
        '    con.Close()


        'Catch ex As Exception
        '    Msg_Erreur(ex.Message)
        '    con.Close()
        'End Try
        'dr.Close()
        'con.Close()
    End Sub

    Protected Sub cbxMatVehiP_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxMatVehiP.SelectedIndexChanged


        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand("SELECT n_vehi,mat_vehi from Vehicule where  mat_vehi ='" & cbxMatVehiP.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxNVehi.Text = dr.Item("n_vehi")


            'Do
            '    cbxMatricule.Items.Add(dr.Item("mat_vehi"))
            'Loop While (dr.Read)
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

    Protected Sub txtbxPrixP_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtbxPrixP.TextChanged

        'lblSNTLRes.Text = (lblSNTL.Text.ToString - (Replace(txtbxPrixP.Text, ".", ",")))

    End Sub

    Protected Sub cbxRef_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxRef.SelectedIndexChanged

        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct N_Serie,Dimenssion From Marque_Pneus where  dimenssion='" & cbxRef.Text & "' ", con)
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxMarqP.Text = dr(0)

            dr.Close()
            con.Close()
        Catch ex As Exception
            Msg_Erreur(ex.Message)
            con.Close()
        End Try
        con.Close()

    End Sub

End Class