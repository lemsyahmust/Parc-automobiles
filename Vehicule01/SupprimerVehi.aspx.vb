Imports System.Data.SqlClient

Partial Public Class WebForm13
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

    Private Sub RadMarque_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadMarque.CheckedChanged

        cbxMarque.Enabled = True
        cbxMatricule.Enabled = True
        txtbxNChassis.Enabled = True

        cbxMarque.Visible = True
        lblMarque.Visible = True

        '*********Marque table vehicule

        cbxMarque.Items.Clear()
        cbxMatricule.Items.Clear()
        txtbxNChassis.Text = ""

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct lib_marqq From Vehicule ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")


        Do
            cbxMarque.Items.Add(dr.Item("lib_marqq"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()



    End Sub

    Private Sub RadMatricule_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadMatricule.CheckedChanged
        cbxMarque.Enabled = False
        cbxMatricule.Enabled = True
        txtbxNChassis.Enabled = True

        cbxMarque.Visible = False
        lblMarque.Visible = False


        '*********Matricule
        Try
            cbxMatricule.Items.Clear()
            txtbxNChassis.Text = ""

            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct mat_vehi,num_chass From Vehicule ", con)
            dr = cmd.ExecuteReader
            dr.Read()
            ' cbxMarq.Text = dr.Item("lib_marq")

            txtbxNChassis.Text = dr.Item("num_chass")

            Do
                cbxMatricule.Items.Add(dr.Item("mat_vehi"))

            Loop While (dr.Read)
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

    Private Sub cbxMarque_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxMarque.SelectedIndexChanged

        cbxMatricule.Items.Clear()

        Try
            con.Close()
            con.Open()
            'cmd = New SqlCommand("SELECT dbo.marque.lib_marq, dbo.Vehicule.mat_vehi,dbo.Vehicule.num_chass FROM dbo.marque INNER JOIN dbo.Vehicule ON dbo.marque.n_marq = dbo.Vehicule.n_marq where lib_marq ='" & cbxMarque.Text & "'", con)
            cmd = New SqlCommand(" select lib_marqq,mat_vehi,num_chass from vehicule where  lib_marqq='" & cbxMarque.Text & "'", con)

            dr = cmd.ExecuteReader
            dr.Read()

            cbxMarque.Text = dr.Item("lib_marqq")
            cbxMatricule.Text = dr.Item("mat_vehi")
            txtbxNChassis.Text = dr.Item("num_chass")
            Do
                cbxMatricule.Items.Add(dr.Item("mat_vehi"))
            Loop While (dr.Read)
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

        txtbxNChassis.Text = " "

        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand("SELECT mat_vehi,num_chass from Vehicule where  mat_vehi ='" & cbxMatricule.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()


            cbxMatricule.Text = dr.Item("mat_vehi")
            txtbxNChassis.Text = dr.Item("num_chass")
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

    Protected Sub btnsuppVeh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnsuppVeh.Click

        If txtbxNChassis.Enabled = False Then

            Msg_Erreur("Sélectionner un véhicule")
        Else

            Try
                cmd = New SqlCommand("delete  from Vehicule where mat_vehi= '" & cbxMatricule.Text & "' and num_chass='" & txtbxNChassis.Text & "' ", con)
                con.Close()
                con.Open()
                dr = cmd.ExecuteReader
                dr.Read()
                Msg_succes("suppression réalisée avec succès")
                dr.Close()
                con.Close()



                'cbxMatricule.Text = ""
                ''********************************
                'cbxAffect.Items.Clear()


                'con.Close()
                'con.Open()
                'cmd = New SqlCommand(" select distinct * From Affectation ", con)
                'dr = cmd.ExecuteReader
                'dr.Read()
                '' cbxMarq.Text = dr.Item("lib_marq")

                'txtbxAutre.Text = dr(2)
                'Do
                '    cbxAffect.Items.Add(dr.Item("lib_aff"))

                'Loop While (dr.Read)
                'dr.Close()
                'con.Close()

                '**************************************

                '*********Matricule

                cbxMatricule.Items.Clear()
                txtbxNChassis.Text = ""

                con.Close()
                con.Open()
                cmd = New SqlCommand(" select distinct mat_vehi,num_chass From Vehicule ", con)
                dr = cmd.ExecuteReader
                dr.Read()
                ' cbxMarq.Text = dr.Item("lib_marq")

                txtbxNChassis.Text = dr.Item("num_chass")

                Do
                    cbxMatricule.Items.Add(dr.Item("mat_vehi"))

                Loop While (dr.Read)
                dr.Close()
                con.Close()


                '*********Marque table vehicule

                cbxMarque.Items.Clear()
                '  cbxMatricule.Items.Clear()
                txtbxNChassis.Text = ""

                con.Close()
                con.Open()
                cmd = New SqlCommand(" select distinct lib_marqq From Vehicule ", con)
                dr = cmd.ExecuteReader
                dr.Read()
                ' cbxMarq.Text = dr.Item("lib_marq")


                Do
                    cbxMarque.Items.Add(dr.Item("lib_marqq"))

                Loop While (dr.Read)
                dr.Close()
                con.Close()



            Catch ex As Exception
                Msg_Erreur(ex.Message)
                con.Close()
            End Try
            dr.Close()
            con.Close()
        End If
        ' Response.Redirect("SupprimerVehi.aspx")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub
End Class