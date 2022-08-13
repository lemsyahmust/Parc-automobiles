Imports System.Data.SqlClient

Partial Public Class WebForm15
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
        '  SELECT dbo.consommation.N_cons, dbo.Pneus.n_pneus, dbo.Pneus.mat_vehi, dbo.Pneus.DateD, dbo.Pneus.N_Fact fROM dbo.consommation INNER JOIN dbo.Pneus ON dbo.consommation.n_pneus = dbo.Pneus.N_Pneus 


       


        ''********* N Pneus

        'cbxNPneus.Items.Clear()
        'cbxMatricule.Items.Clear()

        'con.Close()
        'con.Open()
        'cmd = New SqlCommand(" select distinct lib_marq From marque ", con)
        'dr = cmd.ExecuteReader
        'dr.Read()
        '' cbxMarq.Text = dr.Item("lib_marq")


        'Do
        '    cbxNPneus.Items.Add(dr.Item("lib_marq"))

        'Loop While (dr.Read)
        'dr.Close()
        'con.Close()


    End Sub

    Protected Sub btnsuppPneus_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnsuppPneus.Click
        'If cbxNPneus.Text <> Nothing Or lblNCons.Text = Nothing Then

        If txtbxNFact.Enabled = False Then

            Msg_Erreur("Sélectionner le numéro du pneu")

        Else

            If lblNPneuss.Visible = True Then

                Dim req As String
                req = "select n_cons,n_pneus from consommation where n_cons ='" & Me.lblNCons.Text & "' and  n_pneus = '" & lblNPneuss.Text & "'"

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

                        cmd = New SqlCommand("delete  from Pneus where n_pneus= '" & lblNPneuss.Text & "' and n_cons='" & lblNCons.Text & "' ", con)
                        con.Close()
                        con.Open()
                        dr = cmd.ExecuteReader
                        dr.Read()
                        dr.Close()
                        con.Close()

                        cmd = New SqlCommand("delete  from consommation where n_cons= '" & lblNCons.Text & "' and n_pneus='" & lblNPneuss.Text & "' ", con)
                        con.Close()
                        con.Open()
                        dr = cmd.ExecuteReader
                        dr.Read()
                        dr.Close()
                        con.Close()


                    Catch ex As Exception
                        Msg_Erreur(ex.Message)
                        con.Close()
                    End Try

                    dr.Close()
                    con.Close()
                End If


            ElseIf lblNPneuss.Visible = False Then

                Dim req1 As String
                req1 = "select n_cons,n_pneus from consommation where n_cons ='" & Me.lblNCons.Text & "' and  n_pneus = '" & cbxNPneus.Text & "'"

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

                        cmd = New SqlCommand("delete  from consommation where n_cons= '" & lblNCons.Text & "' and n_pneus='" & cbxNPneus.Text & "' ", con)
                        con.Close()
                        con.Open()
                        dr = cmd.ExecuteReader
                        dr.Read()
                        dr.Close()
                        con.Close()

                        cmd = New SqlCommand("delete  from Pneus where n_pneus= '" & cbxNPneus.Text & "' and n_cons ='" & lblNCons.Text & "' ", con)
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

    Protected Sub RadPneus_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadPneus.CheckedChanged

        lblNPneuss.Visible = False
        lblNCons.Visible = True

        cbxNPneus.Visible = True
        lblNPneus.Visible = True

        txtbxdateD.Visible = True
        cbxdateD.Visible = False

        txtbxdateD.Text = ""
        txtbxNFact.Text = ""
        lblNCons.Text = ""

        cbxNPneus.Enabled = True
        txtbxdateD.Enabled = True
        txtbxNFact.Enabled = True
        cbxMatricule.Enabled = True

        '********* N Pneus

        cbxNPneus.Items.Clear()
        cbxMatricule.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct n_pneus From Pneus ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")


        Do
            cbxNPneus.Items.Add(dr.Item("n_pneus"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()



    End Sub

    Protected Sub RadMatricule_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadMatricule.CheckedChanged

        lblNPneus.Visible = False
        'lblNPneus.Visible = True

        cbxNPneus.Visible = False
        'cbxNPneus.Visible = True

        lblNCons.Visible = True
        'lblNCons.Visible = True

        lblNPneuss.Visible = True
        'lblNPneuss.Visible = False


        txtbxdateD.Visible = False
        cbxdateD.Visible = True

        txtbxNFact.Text = ""
        lblNCons.Text = ""
        lblNPneuss.Text = ""

        txtbxNFact.Enabled = True
        cbxMatricule.Enabled = True

        '********* Matricule

        cbxNPneus.Items.Clear()
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
    End Sub

    Private Sub cbxNPneus_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxNPneus.SelectedIndexChanged
        cbxMatricule.Items.Clear()

        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand("SELECT n_pneus,mat_vehi,DateD,N_Fact,N_cons from Pneus where n_pneus ='" & cbxNPneus.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()


            'cbxMatricule.Text = dr.Item("mat_vehi")
            txtbxdateD.Text = dr.Item("DateD")
            txtbxNFact.Text = dr.Item("N_Fact")
            lblNCons.Text = dr.Item("N_cons")


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

    Private Sub cbxdateD_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxdateD.SelectedIndexChanged
        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand("SELECT n_pneus,DateD,N_Fact,N_cons from Pneus where DateD ='" & cbxdateD.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()


            'cbxMatricule.Text = dr.Item("mat_vehi")
            ' txtbxdateD.Text = dr.Item("DateD")
            txtbxNFact.Text = dr.Item("N_Fact")
            lblNPneuss.Text = dr.Item("n_pneus")
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

    Private Sub cbxMatricule_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxMatricule.SelectedIndexChanged
        cbxdateD.Items.Clear()

        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand("SELECT n_pneus,mat_vehi,DateD,N_Fact,N_cons from Pneus where mat_vehi ='" & cbxMatricule.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()


            'cbxMatricule.Text = dr.Item("mat_vehi")
            ' txtbxdateD.Text = dr.Item("DateD")
            txtbxNFact.Text = dr.Item("N_Fact")
            lblNPneuss.Text = dr.Item("n_pneus")
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

End Class