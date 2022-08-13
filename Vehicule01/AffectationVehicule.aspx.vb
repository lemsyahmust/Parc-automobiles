Imports System.Data
Imports System.Data.SqlClient

Partial Public Class WebForm38
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

        lblNAFFVehi.Text = Now.Date

    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        img_new.Visible = True
        img_suppr.Visible = False
        img_modif.Visible = False

        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        btnAjoutHuile.Visible = True
        btnAjoutHuile.Enabled = True
        btnModifHuile.Visible = False
        btnAnnulerHuile.Visible = True
        btnsuppHuile.Visible = False

        'txtbxAFFDateCrl.Enabled = False


        '*********Matricule

        cbxMatAFFVehiH.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select n_vehi,mat_vehi,lib_marqq,num_chass,date_circul,n_aff from Vehicule where n_aff=" & 0 & " ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        ' cbxMarque.Text = Nothing
        'lblNAFFVehi.Text = dr.Item("n_vehi")

        Do
            cbxMatAFFVehiH.Items.Add(dr.Item("mat_vehi"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()

        '*********Affectation

        cbxBenificiaire.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_aff,lib_aff From Affectation ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")

        txtbxNBénéficiare.Text = dr.Item("n_aff")
        Do
            cbxBenificiaire.Items.Add(dr.Item("lib_aff"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


    End Sub

    Protected Sub cbxBenificiaire_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxBenificiaire.SelectedIndexChanged
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand("select n_aff,lib_aff from Affectation where lib_aff ='" & cbxBenificiaire.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()

            cbxBenificiaire.Text = dr.Item("lib_aff")
            txtbxNBénéficiare.Text = dr.Item("n_aff")

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

    Protected Sub cbxMatAFFVehiH_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxMatAFFVehiH.SelectedIndexChanged
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        If btnAjoutHuile.Visible = True Then

            Try
                con.Close()
                con.Open()
                cmd = New SqlCommand("select n_vehi,mat_vehi,lib_marqq,num_chass,date_circul from Vehicule where mat_vehi ='" & cbxMatAFFVehiH.Text & "'", con)
                dr = cmd.ExecuteReader
                dr.Read()

                cbxMatAFFVehiH.Text = dr.Item("mat_vehi")
                txtbxNVehiH.Text = dr.Item("n_vehi")
                txtbxAFFMarqueV.Text = dr.Item("lib_marqq")
                txtbxAFFDateCrl.Text = dr.Item("date_circul")
                txtbxAFFNChassis.Text = dr.Item("num_chass")

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
        If btnModifHuile.Visible = True Or btnsuppHuile.Visible = True Then

            Lblerror.Visible = False
            img_error.Visible = False
            img_succes.Visible = False

            Try

                con.Close()
                con.Open()

                cmd = New SqlCommand("SELECT dbo.vehicule.n_vehi, dbo.Vehicule.lib_marqq,dbo.Vehicule.mat_vehi, dbo.Vehicule.num_chass, dbo.Vehicule.date_circul,dbo.vehicule.n_aff,dbo.Affectation.lib_aff FROM dbo.Vehicule  INNER JOIN dbo.Affectation ON dbo.Vehicule.n_Aff = dbo.Affectation.n_aff where mat_vehi='" & cbxMatAFFVehiH.Text & "' ", con)

                dr = cmd.ExecuteReader
                dr.Read()


                cbxMatAFFVehiH.Text = dr.Item("mat_vehi")
                txtbxNVehiH.Text = dr.Item("n_vehi")
                txtbxAFFMarqueV.Text = dr.Item("lib_marqq")
                txtbxAFFDateCrl.Text = dr.Item("date_circul")
                txtbxAFFNChassis.Text = dr.Item("num_chass")
                cbxBenificiaire.Text = dr.Item("lib_aff")
                txtbxNBénéficiare.Text = dr.Item("n_aff")

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

    Protected Sub btnAjoutHuile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAjoutHuile.Click
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        Try

            'cmd = New SqlCommand("insert into Vehicule(n_vehi,n_aff,date_circul) values(" & txtbxNVehiH.Text & "," & txtbxNBénéficiare.Text & ",'" & txtbxAFFDateCrl.Text & "' )", con)
            cmd = New SqlCommand("update Vehicule set n_aff=" & txtbxNBénéficiare.Text & ",date_circul='" & txtbxAFFDateCrl.Text & "',dat_aff='" & lblNAFFVehi.Text & "'  where n_vehi=" & txtbxNVehiH.Text & " ", con)


            con.Close()
            con.Open()
            cmd.ExecuteNonQuery()
            Msg_succes(" Ajout réalisé avec succès ")

            txtbxAFFDateCrl.Text = ""
            txtbxAFFMarqueV.Text = ""
            txtbxAFFNChassis.Text = ""

            '*********Matricule

            cbxMatAFFVehiH.Items.Clear()

            con.Close()
            con.Open()
            cmd = New SqlCommand(" select n_vehi,mat_vehi,lib_marqq,num_chass,date_circul,n_aff from Vehicule where n_aff=" & 0 & " ", con)
            dr = cmd.ExecuteReader
            dr.Read()
            ' cbxMarq.Text = dr.Item("lib_marq")
            ' cbxMarque.Text = Nothing
            'lblNAFFVehi.Text = dr.Item("n_vehi")

            Do
                cbxMatAFFVehiH.Items.Add(dr.Item("mat_vehi"))

            Loop While (dr.Read)
            dr.Close()
            con.Close()

            con.Close()
        Catch ex As Exception
            ' Msg_Erreur("Erreur de ............!!!!!!")
            Msg_Erreur(ex.Message)
            con.Close()
        End Try
        con.Close()
    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        img_new.Visible = False
        img_suppr.Visible = False
        img_modif.Visible = True

        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        btnAjoutHuile.Visible = False
        btnModifHuile.Enabled = True
        btnModifHuile.Visible = True
        btnAnnulerHuile.Visible = True
        btnsuppHuile.Visible = False

        '*********Matricule

        cbxMatAFFVehiH.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select n_vehi,mat_vehi,lib_marqq,num_chass,date_circul,n_aff from Vehicule where n_aff <> " & 0 & " ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        ' cbxMarque.Text = Nothing
        'lblNAFFVehi.Text = dr.Item("n_vehi")

        Do
            cbxMatAFFVehiH.Items.Add(dr.Item("mat_vehi"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()

        '*********Affectation

        cbxBenificiaire.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_aff,lib_aff From Affectation ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")

        txtbxNBénéficiare.Text = dr.Item("n_aff")
        Do
            cbxBenificiaire.Items.Add(dr.Item("lib_aff"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()



    End Sub

    Protected Sub btnModifHuile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnModifHuile.Click
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        Try

            'cmd = New SqlCommand("insert into Vehicule(n_vehi,n_aff,date_circul) values(" & txtbxNVehiH.Text & "," & txtbxNBénéficiare.Text & ",'" & txtbxAFFDateCrl.Text & "' )", con)
            cmd = New SqlCommand("update Vehicule set n_aff=" & txtbxNBénéficiare.Text & ",date_circul='" & txtbxAFFDateCrl.Text & "'  where n_vehi=" & txtbxNVehiH.Text & " ", con)


            con.Close()
            con.Open()
            cmd.ExecuteNonQuery()
            Msg_succes(" Modification réalisée avec succès ")

            con.Close()
        Catch ex As Exception
            ' Msg_Erreur("Erreur de ............!!!!!!")
            Msg_Erreur(ex.Message)
            con.Close()
        End Try
        con.Close()
    End Sub

    Protected Sub btnsuppHuile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnsuppHuile.Click
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        Try

            cmd = New SqlCommand("update Vehicule set n_aff=" & 0 & "  where n_vehi=" & txtbxNVehiH.Text & " ", con)

            con.Close()
            con.Open()
            cmd.ExecuteNonQuery()
            Msg_succes(" Suppression réalisée avec succès ")

            '*********Matricule

            cbxMatAFFVehiH.Items.Clear()

            con.Close()
            con.Open()
            cmd = New SqlCommand(" select n_vehi,mat_vehi,lib_marqq,num_chass,date_circul,n_aff from Vehicule where n_aff <> " & 0 & " ", con)
            dr = cmd.ExecuteReader
            dr.Read()
            ' cbxMarq.Text = dr.Item("lib_marq")
            ' cbxMarque.Text = Nothing
            'lblNAFFVehi.Text = dr.Item("n_vehi")

            Do
                cbxMatAFFVehiH.Items.Add(dr.Item("mat_vehi"))

            Loop While (dr.Read)
            dr.Close()
            con.Close()


            con.Close()
        Catch ex As Exception
            ' Msg_Erreur("Erreur de ............!!!!!!")
            Msg_Erreur(ex.Message)
            con.Close()
        End Try
        con.Close()

    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        img_new.Visible = False
        img_suppr.Visible = True
        img_modif.Visible = False

        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        btnAjoutHuile.Visible = False
        btnsuppHuile.Enabled = True
        btnModifHuile.Visible = False
        btnAnnulerHuile.Visible = True
        btnsuppHuile.Visible = True

        '*********Matricule

        cbxMatAFFVehiH.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select n_vehi,mat_vehi,lib_marqq,num_chass,date_circul,n_aff from Vehicule where n_aff <> " & 0 & " ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        ' cbxMarque.Text = Nothing
        'lblNAFFVehi.Text = dr.Item("n_vehi")

        Do
            cbxMatAFFVehiH.Items.Add(dr.Item("mat_vehi"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()

        '*********Affectation

        cbxBenificiaire.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_aff,lib_aff From Affectation ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")

        txtbxNBénéficiare.Text = dr.Item("n_aff")
        Do
            cbxBenificiaire.Items.Add(dr.Item("lib_aff"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


    End Sub

End Class