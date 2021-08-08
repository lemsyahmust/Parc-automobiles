Imports System.Data
Imports System.Data.SqlClient

Partial Public Class WebForm24
    Inherits System.Web.UI.Page

    Function N_L() As Int32
        'retourne l dernier numero de bon de livaison plus un
        Dim m As Int32
        Dim cmd As SqlCommand = New SqlCommand("select n_carnet from carnet_vignette", con)
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

        If btnAjoutCarnet.Enabled = False And btnModifierCarnet.Enabled = False And btnsuppCarnet.Enabled = False Then

            '*****Afficher Carnet Vignette
            cbxNCarnet.Visible = True
            lblNcarnetTTT.Visible = False

            Try
                con.Close()
                con.Open()
                cmd = New SqlCommand(" SELECT dbo.carnet_vignette.n_carnet, dbo.carnet_vignette.num_conv, dbo.carnet_vignette.n_vign, dbo.Vignette.lib_vign, dbo.carnet_vignette.dat_carnt,dbo.carnet_vignette.montant FROM dbo.Vignette INNER JOIN dbo.carnet_vignette ON dbo.Vignette.n_vign = dbo.carnet_vignette.n_vign  ", con)
                dr = cmd.ExecuteReader
                dr.Read()

                cbxNCarnet.Items.Add(dr.Item("n_carnet"))
                txtbxDate.Text = dr.Item("dat_carnt")
                txtbxNConv.Text = dr.Item("num_conv")
                cbxVignette.Items.Add(dr.Item("lib_vign"))
                txtbxMontant.Text = dr.Item("montant")

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

    End Sub

    Private Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim n As Integer = N_L()
        lblNcarnetTTT.Text = n + 1

        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = True
        img_suppr.Visible = False
        img_mod.Visible = False

        btnAjoutCarnet.Visible = True
        btnAjoutCarnet.Enabled = True
        btnAnnulerCarnet.Visible = True
        btnModifierCarnet.Visible = False
        btnsuppCarnet.Visible = False


        txtbxDate.Text = ""
        txtbxNConv.Text = ""
        'cbxVignette.Text = ""
        txtbxNVign.Text = ""
        txtbxMontant.Text = ""


        lblNcarnetTTT.Visible = True
        cbxNCarnet.Visible = False

        '************************Vignette
        cbxVignette.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_vign,lib_vign From Vignette ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        txtbxNVign.Text = dr.Item("n_vign")
        Do
            cbxVignette.Items.Add(dr.Item("lib_vign"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()



    End Sub

    Private Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = False
        img_suppr.Visible = False
        img_mod.Visible = True

        btnAjoutCarnet.Visible = False
        btnAnnulerCarnet.Visible = True
        btnModifierCarnet.Visible = True
        btnModifierCarnet.Enabled = True
        btnsuppCarnet.Visible = False

        txtbxDate.Text = ""
        txtbxNConv.Text = ""
        'cbxVignette.Text = ""
        txtbxNVign.Text = ""
        txtbxMontant.Text = ""

        lblNcarnetTTT.Visible = False
        cbxNCarnet.Visible = True

        '************************N° Carnet Vignette
        cbxNCarnet.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_carnet From carnet_vignette ", con)
        dr = cmd.ExecuteReader
        dr.Read()
       
        Do
            cbxNCarnet.Items.Add(dr.Item("n_carnet"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


        '************************Vignette
        cbxVignette.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_vign,lib_vign From Vignette ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        txtbxNVign.Text = dr.Item("n_vign")
        Do
            cbxVignette.Items.Add(dr.Item("lib_vign"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


    End Sub

    Private Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = False
        img_suppr.Visible = True
        img_mod.Visible = False

        btnsuppCarnet.Visible = True
        btnsuppCarnet.Enabled = True
        btnAnnulerCarnet.Visible = True
        btnAjoutCarnet.Visible = False
        btnModifierCarnet.Visible = False

        txtbxDate.Text = ""
        txtbxNConv.Text = ""
        'cbxVignette.Text = ""
        txtbxNVign.Text = ""
        txtbxMontant.Text = ""

        lblNcarnetTTT.Visible = False
        cbxNCarnet.Visible = True

        '************************N° Carnet Vignette
        cbxNCarnet.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_carnet From carnet_vignette ", con)
        dr = cmd.ExecuteReader
        dr.Read()

        Do
            cbxNCarnet.Items.Add(dr.Item("n_carnet"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


        '************************Vignette
        cbxVignette.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_vign,lib_vign From Vignette ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        txtbxNVign.Text = dr.Item("n_vign")
        Do
            cbxVignette.Items.Add(dr.Item("lib_vign"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


    End Sub

    Private Sub btnAjoutCarnet_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAjoutCarnet.Click
        If txtbxNConv.Text = Nothing Then

            Msg_Erreur(" Veuillez remplir les champs ")

        Else

            If txtbxDate.Text = Nothing Then

                Try

                    cmd = New SqlCommand("insert into carnet_vignette values (" & lblNcarnetTTT.Text & ",'" & txtbxNConv.Text & "','" & txtbxNVign.Text & "','" & txtbxDate.Text & "','" & txtbxMontant.Text & "') ", con)
                    con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()
                    Msg_succes(" Ajout réalisé avec succès ")

                    Dim n As Integer = N_L()
                    lblNcarnetTTT.Text = n + 1

                    txtbxDate.Text = ""
                    txtbxNConv.Text = ""
                    txtbxMontant.Text = ""
                    txtbxNVign.Text = ""

                    con.Close()
                Catch ex As Exception
                    ' Msg_Erreur("Erreur de ............!!!!!!")
                    Msg_Erreur(ex.Message)
                    con.Close()
                End Try
                con.Close()

            Else
                If Not IsDate(Me.txtbxDate.Text) Then
                    Msg_Erreur(" Format date et jj/mm/aa ")

                Else
                    Try

                        cmd = New SqlCommand("insert into carnet_vignette values (" & lblNcarnetTTT.Text & ",'" & txtbxNConv.Text & "','" & txtbxNVign.Text & "','" & txtbxDate.Text & "','" & txtbxMontant.Text & "') ", con)
                        con.Close()
                        con.Open()
                        cmd.ExecuteNonQuery()
                        Msg_succes(" Ajout réalisé avec succès ")

                        Dim n As Integer = N_L()
                        lblNcarnetTTT.Text = n + 1

                        txtbxDate.Text = ""
                        txtbxNConv.Text = ""
                        txtbxMontant.Text = ""
                        txtbxNVign.Text = ""

                        con.Close()
                    Catch ex As Exception
                        ' Msg_Erreur("Erreur de ............!!!!!!")
                        Msg_Erreur(ex.Message)
                        con.Close()
                    End Try
                    con.Close()

                End If
            End If
        End If
    End Sub

    Private Sub cbxVignette_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxVignette.SelectedIndexChanged
        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct n_vign,lib_vign From vignette where  lib_vign='" & cbxVignette.Text & "' ", con)
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxNVign.Text = dr.Item("n_vign")

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

    Private Sub cbxNCarnet_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxNCarnet.SelectedIndexChanged
        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand(" SELECT dbo.carnet_vignette.n_carnet, dbo.carnet_vignette.num_conv, dbo.carnet_vignette.n_vign, dbo.Vignette.lib_vign, dbo.carnet_vignette.dat_carnt,dbo.carnet_vignette.montant FROM dbo.Vignette INNER JOIN dbo.carnet_vignette ON dbo.Vignette.n_vign = dbo.carnet_vignette.n_vign where  n_carnet='" & cbxNCarnet.Text & "' ", con)
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxDate.Text = dr.Item("dat_carnt")
            txtbxNConv.Text = dr.Item("num_conv")
            cbxVignette.Text = dr.Item("lib_vign")
            txtbxNVign.Text = dr.Item("n_vign")
            txtbxMontant.Text = dr.Item("montant")


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

    Private Sub btnModifierCarnet_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModifierCarnet.Click
        If txtbxDate.Text = Nothing Then

            Try
                con.Close()
                con.Open()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update carnet_vignette set num_conv='" & txtbxNConv.Text & "',n_vign='" & txtbxNVign.Text & "',dat_carnt='" & txtbxDate.Text & "',montant='" & txtbxMontant.Text & "' where n_carnet='" & cbxNCarnet.Text & "' "

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

        Else
            If Not IsDate(Me.txtbxDate.Text) Then
                Msg_Erreur(" Format date et jj/mm/aa ")

            Else

                Try
                    con.Close()
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "update carnet_vignette set num_conv='" & txtbxNConv.Text & "',n_vign='" & txtbxNVign.Text & "',dat_carnt='" & txtbxDate.Text & "',montant='" & txtbxMontant.Text & "' where n_carnet='" & cbxNCarnet.Text & "' "

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

            End If
        End If

    End Sub

    Private Sub btnsuppCarnet_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsuppCarnet.Click
        Try

            cmd = New SqlCommand("delete  from carnet_vignette where n_carnet= '" & cbxNCarnet.Text & "' ", con)
            con.Close()
            con.Open()
            dr = cmd.ExecuteReader
            dr.Read()
            dr.Close()
            con.Close()




            Try
                con.Close()
                con.Open()
                cmd = New SqlCommand(" SELECT dbo.carnet_vignette.n_carnet, dbo.carnet_vignette.num_conv, dbo.carnet_vignette.n_vign, dbo.Vignette.lib_vign, dbo.carnet_vignette.dat_carnt,dbo.carnet_vignette.montant FROM dbo.Vignette INNER JOIN dbo.carnet_vignette ON dbo.Vignette.n_vign = dbo.carnet_vignette.n_vign  ", con)
                dr = cmd.ExecuteReader
                dr.Read()

                cbxNCarnet.Text = dr.Item("n_carnet")
                txtbxDate.Text = dr.Item("dat_carnt")
                txtbxNConv.Text = dr.Item("num_conv")
                cbxVignette.Text = dr.Item("lib_vign")
                txtbxNVign.Text = dr.Item("n_vign")
                txtbxMontant.Text = dr.Item("montant")


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

            Msg_succes("suppression réalisée avec succès")

        Catch ex As Exception
            Msg_Erreur(ex.Message)
            con.Close()
        End Try
        dr.Close()
        con.Close()
    End Sub
End Class