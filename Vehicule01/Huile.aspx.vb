Imports System.Data.SqlClient

Partial Public Class WebForm21
    Inherits System.Web.UI.Page

    Function N_L() As Int32
        'retourne l dernier numero de bon de livaison plus un
        Dim m As Int32
        Dim cmd As SqlCommand = New SqlCommand("select N_serieH from Marq_Huile", con)
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
        Dim n As Integer = N_L()
        lblNSerie.Text = n + 1

        '  If btnAjoutHuile.Enabled = False Then
        ' ********* Afficher Réparation
        Try

            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct MarqH,Réf,Description,Qte,Qualite,TypeMtr,Prix From Marq_Huile ", con)
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxMarque.Text = dr.Item("MarqH")
            txtbxRéf.Text = dr.Item("Réf")
            txtbxDescH.Text = dr.Item("Description")
            cbxQteH.Items.Add(dr.Item("Qte"))
            txtbxQualitéH.Text = dr.Item("Qualite")
            cbxTypeMtr.Items.Add(dr.Item("TypeMtr"))
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
        '        Else

        'End If


    End Sub

    Protected Sub btnAjoutHuile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAjoutHuile.Click
        If txtbxMarque.Text = Nothing Then

            Msg_Erreur(" Veuillez remplir les champs ")

        Else

            Dim req0 As String

            req0 = "select MarqH from Marq_Huile where MarqH ='" & Me.txtbxMarque.Text & "'"

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
                Msg_Erreur(" erreur......!!!?    Cette marque du Huile existe deja ")
                con.Close()
            Else
                Try

                    cmd = New SqlCommand("insert into Marq_huile values (" & lblNSerie.Text & ",'" & txtbxMarque.Text & "','" & txtbxRéf.Text & "','" & txtbxDescH.Text & "','" & cbxQteH.Text & "','" & txtbxQualitéH.Text & "','" & cbxTypeMtr.Text & "','" & txtbxPrix.Text & "') ", con)
                    con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()
                    Msg_succes(" Ajout réalisé avec succès ")

                    Dim n As Integer = N_L()
                    lblNSerie.Text = n + 1

                    txtbxNSerie.Text = ""
                    txtbxRéf.Text = ""
                    txtbxDescH.Text = ""
                    txtbxQte.Text = ""
                    txtbxQualitéH.Text = ""
                    txtbxTypeMtr.Text = ""
                    txtbxPrix.Text = ""

                    con.Close()
                Catch ex As Exception
                    ' Msg_Erreur("Erreur de ............!!!!!!")
                    Msg_Erreur(ex.Message)
                    con.Close()
                End Try
                con.Close()
            End If
        End If
    End Sub

    Private Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = True
        img_suppr.Visible = False
        img_mod.Visible = False

        cbxTypeMtr.Items.Clear()
        cbxTypeMtr.Items.Add("Essence")
        cbxTypeMtr.Items.Add("Gazoil")

        cbxQteH.Items.Clear()
        cbxQteH.Items.Add("0L")
        cbxQteH.Items.Add("4L")
        cbxQteH.Items.Add("7L")
        cbxQteH.Items.Add("10L")

        btnAjoutHuile.Visible = True
        btnAjoutHuile.Enabled = True
        btnAnnulerHuile.Visible = True
        btnsuppHuile.Visible = False
        txtbxNSerie.Visible = False
        btnModifierHuile.Visible = False

        cbxMarque.Visible = False
        txtbxMarque.Visible = True

        lblNHuile.Visible = True
        lblNSerie.Visible = True

        cbxQteH.Visible = True
        txtbxQte.Visible = False

        cbxTypeMtr.Visible = True
        txtbxTypeMtr.Visible = False

        txtbxNSerie.Text = ""
        txtbxMarque.Text = ""
        txtbxRéf.Text = ""
        txtbxDescH.Text = ""
        txtbxQte.Text = ""
        txtbxQualitéH.Text = ""
        txtbxTypeMtr.Text = ""
        txtbxPrix.Text = ""

    End Sub

    Private Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = False
        img_suppr.Visible = True
        img_mod.Visible = False

        cbxTypeMtr.Items.Clear()
        cbxTypeMtr.Items.Add("Essence")
        cbxTypeMtr.Items.Add("Gazoil")

        cbxQteH.Items.Clear()
        cbxQteH.Items.Add("0L")
        cbxQteH.Items.Add("4L")
        cbxQteH.Items.Add("7L")
        cbxQteH.Items.Add("10L")


        btnsuppHuile.Visible = True
        btnAnnulerHuile.Visible = True
        btnAjoutHuile.Visible = False
        btnModifierHuile.Visible = False

        txtbxNSerie.Visible = True

        cbxMarque.Visible = True
        txtbxMarque.Visible = False

        cbxQteH.Visible = False
        txtbxQte.Visible = True

        cbxTypeMtr.Visible = False
        txtbxTypeMtr.Visible = True

        lblNSerie.Visible = False
        lblNHuile.Visible = False


        '************************Marque Huile
        cbxMarque.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct MarqH From Marq_Huile ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        Do
            cbxMarque.Items.Add(dr.Item("MarqH"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


    End Sub

    Private Sub cbxMarque_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxMarque.SelectedIndexChanged
        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct N_serieH,Réf,Description,Qte,Qualite,TypeMtr,Prix From Marq_Huile where  MarqH='" & cbxMarque.Text & "' ", con)
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxNSerie.Text = dr.Item("N_serieH")
            txtbxRéf.Text = dr.Item("Réf")
            txtbxDescH.Text = dr.Item("Description")
            txtbxQte.Text = dr.Item("Qte")
            txtbxQualitéH.Text = dr.Item("Qualite")
            txtbxTypeMtr.Text = dr.Item("TypeMtr")
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
    End Sub

    Private Sub btnsuppHuile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsuppHuile.Click
        Try

            cmd = New SqlCommand("delete  from Marq_Huile where N_serieH= '" & txtbxNSerie.Text & "'", con)
            con.Close()
            con.Open()
            dr = cmd.ExecuteReader
            dr.Read()
            Msg_succes("suppression réalisée avec succès")
            dr.Close()
            con.Close()

            '********************Marque

            cbxMarque.Items.Clear()

            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct N_serieH,MarqH,Réf,Description,Qte,Qualite,TypeMtr,Prix From Marq_Huile ", con)
            dr = cmd.ExecuteReader
            dr.Read()
            ' cbxMarq.Text = dr.Item("lib_marq")

            txtbxNSerie.Text = dr.Item("N_serieH")
            txtbxRéf.Text = dr.Item("Réf")
            txtbxDescH.Text = dr.Item("Description")
            txtbxQte.Text = dr.Item("Qte")
            txtbxQualitéH.Text = dr.Item("Qualite")
            txtbxTypeMtr.Text = dr.Item("TypeMtr")
            txtbxPrix.Text = dr.Item("Prix")


            Do
                cbxMarque.Items.Add(dr.Item("MarqH"))

            Loop While (dr.Read)
            dr.Close()
            con.Close()


        Catch ex As Exception
            Msg_Erreur(ex.Message)
            con.Close()
        End Try
        dr.Close()
        con.Close()
    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = False
        img_suppr.Visible = False
        img_mod.Visible = True

        btnAjoutHuile.Visible = False
        btnAnnulerHuile.Visible = True
        btnsuppHuile.Visible = False
        txtbxNSerie.Visible = False
        btnModifierHuile.Visible = True

        txtbxNSerie.Visible = True

        cbxMarque.Visible = True
        txtbxMarque.Visible = False

        cbxQteH.Visible = False
        txtbxQte.Visible = True

        cbxTypeMtr.Visible = False
        txtbxTypeMtr.Visible = True

        lblNSerie.Visible = False
        lblNHuile.Visible = False


        '************************Marque Huile
        cbxMarque.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct MarqH From Marq_Huile ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        Do
            cbxMarque.Items.Add(dr.Item("MarqH"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()

    End Sub

    Private Sub btnModifierHuile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModifierHuile.Click
        Try
            con.Close()
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update Marq_Huile set Réf='" & txtbxRéf.Text & "',Description='" & txtbxDescH.Text & "',Qte='" & txtbxQte.Text & "',Qualite='" & txtbxQualitéH.Text & "',TypeMtr='" & txtbxTypeMtr.Text & "',Prix='" & txtbxPrix.Text & "' where N_serieH='" & txtbxNSerie.Text & "' and MarqH='" & cbxMarque.Text & "'"

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
    End Sub

    Protected Sub btnImpMarqPneus_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImpMarqPneus.Click

    End Sub
End Class