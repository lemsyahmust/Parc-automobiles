Imports System.Data.SqlClient

Partial Public Class WebForm23
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

    Private Sub RadHuile_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadHuile.CheckedChanged
        lblNHuilee.Visible = True
        lblNCons.Visible = True

        cbxNHuile.Visible = True
        lblNHuile.Visible = True

        txtbxdateD.Visible = True
        cbxdateD.Visible = False


        cbxNHuile.Enabled = True
        txtbxdateD.Enabled = True
        txtbxNFact.Enabled = True
        cbxMatricule.Enabled = True

        txtbxdateD.Text = ""
        txtbxNFact.Text = ""
        lblNCons.Text = ""
        lblNHuilee.Text = ""


        '********* N Huile

        cbxNHuile.Items.Clear()
        cbxMatricule.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct N_Huile From Vidange ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")


        Do
            cbxNHuile.Items.Add(dr.Item("N_Huile"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()

    End Sub

    Private Sub RadMatricule_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadMatricule.CheckedChanged
        lblNHuile.Visible = False
        cbxNHuile.Visible = False

        lblNCons.Visible = True
        lblNHuilee.Visible = True

        txtbxdateD.Visible = False
        cbxdateD.Visible = True


        txtbxNFact.Enabled = True
        cbxMatricule.Enabled = True


        txtbxNFact.Text = ""
        lblNCons.Text = ""
        lblNHuilee.Text = ""

        '********* Matricule

        cbxNHuile.Items.Clear()
        cbxMatricule.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct mat_vehi From Vidange ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")


        Do
            cbxMatricule.Items.Add(dr.Item("mat_vehi"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()
    End Sub

    Private Sub cbxNHuile_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxNHuile.SelectedIndexChanged
        cbxMatricule.Items.Clear()

        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand("SELECT N_Huile,mat_vehi,DateD,N_Fact,N_cons from Vidange where N_Huile ='" & cbxNHuile.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()


            'cbxMatricule.Text = dr.Item("mat_vehi")
            txtbxdateD.Text = dr.Item("DateD")
            txtbxNFact.Text = dr.Item("N_Fact")
            lblNCons.Text = dr.Item("N_cons")
            lblNHuilee.Text = dr.Item("N_Huile")

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
        cbxdateD.Items.Clear()

        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand("SELECT N_Huile,mat_vehi,DateD,N_Fact,N_cons from Vidange where mat_vehi ='" & cbxMatricule.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()


            'cbxMatricule.Text = dr.Item("mat_vehi")
            ' txtbxdateD.Text = dr.Item("DateD")
            txtbxNFact.Text = dr.Item("N_Fact")
            lblNHuilee.Text = dr.Item("N_Huile")
            lblNCons.Text = dr.Item("N_cons")

            Do
                cbxdateD.Items.Add(dr.Item("DateD"))
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

    Private Sub cbxdateD_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxdateD.SelectedIndexChanged
        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand("SELECT N_Huile,DateD,N_Fact,N_cons from Vidange where DateD ='" & cbxdateD.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()


            'cbxMatricule.Text = dr.Item("mat_vehi")
            ' txtbxdateD.Text = dr.Item("DateD")
            txtbxNFact.Text = dr.Item("N_Fact")
            lblNHuilee.Text = dr.Item("N_Huile")
            lblNCons.Text = dr.Item("N_cons")


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

    Private Sub btnsuppPneus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsuppPneus.Click
        If txtbxNFact.Enabled = False Then

            Msg_Erreur("Sélectionner N° d'huile ou matricule ")

        Else

            If lblNHuilee.Visible = True Then

                Dim req As String
                req = "select n_cons,N_Huile from consommation where n_cons ='" & Me.lblNCons.Text & "' and  N_Huile = '" & lblNHuilee.Text & "'"

                Dim cmd As New SqlCommand(req, con)
                con.Close()
                con.Open()
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader
                Dim trouv As Boolean
                trouv = False
                Do While dr.Read

                    trouv = True

                Loop
                dr.Close()
                If trouv = False Then
                    Msg_Erreur(" Introuvable ")
                    con.Close()
                Else

                    Try

                        cmd = New SqlCommand("delete  from Vidange where N_Huile= '" & lblNHuilee.Text & "' and n_cons='" & lblNCons.Text & "' ", con)
                        con.Close()
                        con.Open()
                        dr = cmd.ExecuteReader
                        dr.Read()
                        dr.Close()
                        con.Close()

                        cmd = New SqlCommand("delete  from consommation where n_cons= '" & lblNCons.Text & "' and N_Huile='" & lblNHuilee.Text & "' ", con)
                        con.Close()
                        con.Open()
                        dr = cmd.ExecuteReader
                        dr.Read()
                        dr.Close()
                        con.Close()

                        Msg_succes("suppression réalisée avec succès 1111111")

                        '********* Matricule

                        cbxNHuile.Items.Clear()
                        cbxMatricule.Items.Clear()
                        cbxdateD.Items.Clear()

                        con.Close()
                        con.Open()
                        cmd = New SqlCommand(" select distinct mat_vehi,DateD,N_Fact From Vidange ", con)
                        dr = cmd.ExecuteReader
                        dr.Read()
                        ' cbxMarq.Text = dr.Item("lib_marq")

                        cbxdateD.Text = dr.Item("DateD")
                        txtbxNFact.Text = dr.Item("N_Fact")


                        Do
                            cbxMatricule.Items.Add(dr.Item("mat_vehi"))

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


            ElseIf lblNHuilee.Visible = False Then

                Dim req1 As String
                req1 = "select n_cons,N_Huile from consommation where n_cons ='" & Me.lblNCons.Text & "' and  N_Huile = '" & cbxNHuile.Text & "'"

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
                dr1.Close()
                If trouve1 = False Then
                    Msg_Erreur(" Introuvable ")
                    con.Close()
                Else

                    Try

                        cmd = New SqlCommand("delete  from consommation where n_cons= '" & lblNCons.Text & "' and N_Huile='" & cbxNHuile.Text & "' ", con)
                        con.Close()
                        con.Open()
                        dr = cmd.ExecuteReader
                        dr.Read()
                        dr.Close()
                        con.Close()

                        cmd = New SqlCommand("delete  from Vidange where N_Huile= '" & cbxNHuile.Text & "' and n_cons ='" & lblNCons.Text & "' ", con)
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
                End If

            End If

        End If


    End Sub

End Class