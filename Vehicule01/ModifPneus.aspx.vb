Imports System.Data
Imports System.Data.SqlClient

Partial Public Class WebForm18
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

    End Sub

    Private Sub btnModif_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModif.Click
        btnValider.Visible = True
        btnModif.Visible = False

        '***********************************

        lblMatricule.Visible = True
        cbxMatricule.Visible = True
        txtbxNVehi.Visible = True
        lblNFactP.Visible = True
        cbxNFacture.Visible = True
        lblRepaP.Visible = True
        cbxRepaP.Visible = True
        txtbxNrep.Visible = True
        lblDateP.Visible = True
        txtbxDateP.Visible = True
        'lblDate2.Visible = True
        'txtbxDate2.Visible = True
        lblKm.Visible = True
        txtbxKm.Visible = True
        lblMarqP.Visible = True
        cbxMarq.Visible = True
        txtbxMarqP.Visible = True
        lblQteP.Visible = True
        cbxQteP.Visible = True
        lblPrixP.Visible = True
        txtbxPrixP.Visible = True

        lblDimenssion.Visible = True
        cbxRef.Visible = True


        '***********************************


        '*********Reparateur

        cbxRepaP.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct lib_reparateur From Reparateur ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        Do
            cbxRepaP.Items.Add(dr.Item("lib_reparateur"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


        '*********Matricule Vehicule

        cbxMatricule.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct mat_vehi From Pneus ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        Do
            cbxMatricule.Items.Add(dr.Item("mat_vehi"))

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
        Do
            cbxMarq.Items.Add(dr.Item("Marq_Pneus"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()
    End Sub

    Private Sub cbxMatricule_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxMatricule.SelectedIndexChanged
        cbxNFacture.Items.Clear()

        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand(" SELECT dbo.Pneus.mat_vehi, dbo.Reparateur.n_reparateur,dbo.Reparateur.lib_reparateur, dbo.Pneus.DateD, dbo.Pneus.Km, dbo.Marque_Pneus.N_Serie,dbo.Marque_Pneus.Marq_Pneus, dbo.Pneus.Qte,dbo.Pneus.N_Fact, dbo.Pneus.Prix FROM dbo.Pneus INNER JOIN dbo.Marque_Pneus ON dbo.Pneus.N_Serie = dbo.Marque_Pneus.N_Serie INNER JOIN dbo.Reparateur ON dbo.Pneus.n_reparateur = dbo.Reparateur.n_reparateur where mat_vehi='" & cbxMatricule.Text & "' ", con)
            dr = cmd.ExecuteReader
            dr.Read()

            cbxRepaP.Text = dr.Item("lib_reparateur")
            txtbxNrep.Text = dr.Item("n_reparateur")
            txtbxDateP.Text = dr.Item("DateD")
            'txtbxDate2.Text = dr.Item("DateF")
            txtbxKm.Text = dr.Item("Km")
            cbxMarq.Text = dr.Item("Marq_Pneus")
            txtbxMarqP.Text = dr.Item("N_Serie")
            cbxQteP.Text = dr.Item("Qte")
            txtbxPrixP.Text = dr.Item("Prix")
            ' txtbxNFactP.Text = dr.Item("N_Fact")

            Do
                cbxNFacture.Items.Add(dr.Item("N_Fact"))

            Loop While dr.Read

            'ComboBox2.DisplayMember = "lib_reparateur"
            'ComboBox2.ValueMember = "n_reparateur"

            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
        con.Close()
    End Sub

    Private Sub cbxNFacture_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxNFacture.SelectedIndexChanged
        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand(" SELECT  dbo.Reparateur.n_reparateur,dbo.Reparateur.lib_reparateur, dbo.Pneus.DateD, dbo.Pneus.Km, dbo.Marque_Pneus.N_Serie,dbo.Marque_Pneus.Marq_Pneus, dbo.Pneus.Qte,dbo.Pneus.N_Fact, dbo.Pneus.Prix FROM dbo.Pneus INNER JOIN dbo.Marque_Pneus ON dbo.Pneus.N_Serie = dbo.Marque_Pneus.N_Serie INNER JOIN dbo.Reparateur ON dbo.Pneus.n_reparateur = dbo.Reparateur.n_reparateur where N_Fact='" & cbxNFacture.Text & "' ", con)
            dr = cmd.ExecuteReader
            dr.Read()

            cbxRepaP.Text = dr.Item("lib_reparateur")
            txtbxNrep.Text = dr.Item("n_reparateur")
            txtbxDateP.Text = dr.Item("DateD")
            'txtbxDate2.Text = dr.Item("DateF")
            txtbxKm.Text = dr.Item("Km")
            cbxMarq.Text = dr.Item("Marq_Pneus")
            txtbxMarqP.Text = dr.Item("N_Serie")
            cbxQteP.Text = dr.Item("Qte")
            txtbxPrixP.Text = dr.Item("Prix")

            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
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

        '    dr.Close()
        '    con.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
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

    Private Sub cbxRepaP_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxRepaP.SelectedIndexChanged
        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct n_reparateur,lib_reparateur From Reparateur where  lib_reparateur='" & cbxRepaP.Text & "' ", con)
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxNrep.Text = dr.Item("n_reparateur")

            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
        con.Close()
    End Sub

    Private Sub btnValider_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnValider.Click
        If txtbxDateP.Text = Nothing Then


            Try

                cmd = New SqlCommand("update Pneus set n_reparateur='" & txtbxNrep.Text & "',DateD='" & txtbxDateP.Text & "',Km='" & txtbxKm.Text & "',N_Serie='" & txtbxMarqP.Text & "',qte='" & cbxQteP.Text & "',Prix='" & txtbxPrixP.Text & "' where mat_vehi='" & cbxMatricule.Text & "' and N_Fact='" & cbxNFacture.Text & "'", con)
                con.Close()
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                cmd = New SqlCommand("update Consommation set n_reparateur='" & txtbxNrep.Text & "',dat_cons='" & txtbxDateP.Text & "',Km='" & txtbxKm.Text & "',montant='" & txtbxPrixP.Text & "' where mat_vehi='" & cbxMatricule.Text & "' and N_Fact='" & cbxNFacture.Text & "'", con)
                con.Close()
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                Response.Redirect("ModifPneus.aspx")

            Catch ex As Exception
                Label1.Text = ex.Message
                con.Close()
            End Try
            con.Close()
            btnModif.Visible = True
            btnValider.Visible = False

        Else
            If Not IsDate(Me.txtbxDateP.Text) Then
                MsgBox(" Format date et jj/mm/aa ")

            Else
                Try

                    cmd = New SqlCommand("update Pneus set n_reparateur='" & txtbxNrep.Text & "',DateD='" & txtbxDateP.Text & "',Km='" & txtbxKm.Text & "',N_Serie='" & txtbxMarqP.Text & "',qte='" & cbxQteP.Text & "',Prix='" & txtbxPrixP.Text & "' where mat_vehi='" & cbxMatricule.Text & "' and N_Fact='" & cbxNFacture.Text & "'", con)
                    con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                    cmd = New SqlCommand("update Consommation set n_reparateur='" & txtbxNrep.Text & "',dat_cons='" & txtbxDateP.Text & "',Km='" & txtbxKm.Text & "',montant='" & txtbxPrixP.Text & "' where mat_vehi='" & cbxMatricule.Text & "' and N_Fact='" & cbxNFacture.Text & "'", con)
                    con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()


                    Response.Redirect("ModifPneus.aspx")

                Catch ex As Exception
                    Label1.Text = ex.Message
                    con.Close()
                End Try
                con.Close()
                btnModif.Visible = True
                btnValider.Visible = False

            End If

        End If

    End Sub

    Private Sub btnAnnuler_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnnuler.Click

        lblMatricule.Visible = False
        cbxMatricule.Visible = False
        txtbxNVehi.Visible = False
        lblNFactP.Visible = False
        cbxNFacture.Visible = False
        lblRepaP.Visible = False
        cbxRepaP.Visible = False
        txtbxNrep.Visible = False
        lblDateP.Visible = False
        txtbxDateP.Visible = False
        'lblDate2.Visible = False
        'txtbxDate2.Visible = False
        lblKm.Visible = False
        txtbxKm.Visible = False
        lblMarqP.Visible = False
        cbxMarq.Visible = False
        txtbxMarqP.Visible = False
        lblQteP.Visible = False
        cbxQteP.Visible = False
        lblPrixP.Visible = False
        txtbxPrixP.Visible = False

        lblDimenssion.Visible = False
        cbxRef.Visible = False

        btnModif.Visible = True
        btnValider.Visible = False



        cbxMatricule.Items.Clear()
        txtbxNVehi.Text = ""
        cbxNFacture.Items.Clear()
        cbxRepaP.Items.Clear()
        txtbxNrep.Text = ""
        txtbxDateP.Text = ""
        'txtbxDate2.Text = ""
        txtbxKm.Text = ""
        cbxMarq.Items.Clear()
        cbxQteP.Text = 0
        txtbxMarqP.Text = ""
        txtbxPrixP.Text = ""

      

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