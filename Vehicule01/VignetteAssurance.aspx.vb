Imports System.Data.SqlClient

Partial Public Class WebForm32
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
        'btnsuppD.Visible = False
        'btnModifierD.Visible = False
        'btnsuppD.Visible = False


        lblTypeVehi.Visible = False
        lblTypeVehi1.Visible = False



        '*********Montant SNTL

        lblSNTL.Text = ""

        con.Close()
        con.Open()
        ' cmd = New SqlCommand(" select distinct Montant1 From SNTL ", con)
        cmd = New SqlCommand("select distinct NSNTL,Montant1 From SNTL order by NSNTL desc", con)

        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")

        lblSNTL.Text = dr.Item("Montant1")

        dr.Close()
        con.Close()


        '*********Matricule Vehicule

        cbxMatricule.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_vehi,mat_vehi From Vehicule ", con)
        dr = cmd.ExecuteReader
        dr.Read()

        lblNVehi.Text = dr.Item("n_vehi")
        Do
            cbxMatricule.Items.Add(dr.Item("mat_vehi"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()

    End Sub

    Protected Sub cbxMatricule_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxMatricule.SelectedIndexChanged

        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        lblTypeVehi.Visible = True
        lblTypeVehi1.Visible = True

        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand("select distinct n_vehi,lib_marqq,Kilom,mat_vehi from Vehicule where mat_vehi  ='" & cbxMatricule.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()

            lblNVehi.Text = dr.Item("n_vehi")
            cbxMatricule.Text = dr.Item("mat_vehi")
            lblTypeVehi1.Text = dr.Item("lib_marqq")

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

    Protected Sub btnAjoutD_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAjoutD.Click

        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

    
        If lblTypeVehi1.Text <> "" Then

            If Not IsDate(Me.txtbxDate.Text) Then
                Msg_Erreur(" Format date et jj/mm/aa ")
            Else

        
                If Not RadioButtonList2.SelectedIndex Then

                    If RadioButtonList2.SelectedIndex = 0 Then

                        If (lblSNTLRes.Text) >= 0 Then

                            cmd = New SqlCommand("insert into SNTL(Date,Montant1,Montant2) values('" & txtbxDate.Text & "','" & lblSNTLRes.Text & "','" & lblSNTL.Text & "')", con)
                            con.Close()
                            con.Open()
                            cmd.ExecuteNonQuery()
                            con.Close()


                            Try

                                cmd = New SqlCommand("insert into VignetteAssurance  values(" & lblNVehi.Text & ",'" & cbxMatricule.Text & "','" & lblTypeVehi1.Text & "','" & txtbxDate.Text & "','" & txtbxMontant.Text & "','Vignette ')", con)

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
                        Else
                            Msg_Erreur("Le Montant et Insuffisant")
                        End If

                    End If

                    If RadioButtonList2.SelectedIndex = 1 Then

                        If (lblSNTLRes.Text) >= 0 Then

                            cmd = New SqlCommand("insert into SNTL(Date,Montant1,Montant2) values('" & txtbxDate.Text & "','" & lblSNTLRes.Text & "','" & lblSNTL.Text & "')", con)
                            con.Close()
                            con.Open()
                            cmd.ExecuteNonQuery()
                            con.Close()

                            Try

                                cmd = New SqlCommand("insert into VignetteAssurance  values(" & lblNVehi.Text & ",'" & cbxMatricule.Text & "','" & lblTypeVehi1.Text & "','" & txtbxDate.Text & "','" & txtbxMontant.Text & "','Assurance')", con)

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
                        Else
                            Msg_Erreur("Le Montant et Insuffisant")
                        End If

                    End If

                    Else
                        Msg_Erreur("Veuillez sélectionner un type : Vignette/Assurance")

                    End If


                End If

        Else
                Msg_Erreur("veuillez sélectionner un matricule")
        End If


    End Sub

    Protected Sub txtbxMontant_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtbxMontant.TextChanged

        lblSNTLRes.Text = (lblSNTL.Text.ToString - (Replace(txtbxMontant.Text, ".", ",")))

    End Sub
End Class