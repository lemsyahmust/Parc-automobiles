Imports System.Data.SqlClient

Partial Public Class WebForm16
    Inherits System.Web.UI.Page

    Function N_L() As Int32
        'retourne l dernier numero de bon de livaison plus un
        Dim m As Int32
        ' Dim con As New OleDbConnection(Application("str"))
        Dim cmd As SqlCommand = New SqlCommand("select N_Serie from Marque_Pneus", con)
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
        If Not Page.IsPostBack Then


            Dim n As Integer = N_L()
            lblNSerie.Text = n + 1

            '********* Afficher Marque Pneus
            Try

                con.Close()
                con.Open()
                cmd = New SqlCommand(" select N_serie,Marq_Pneus,Dimenssion,Description,Prix from Marque_Pneus ", con)
                dr = cmd.ExecuteReader
                dr.Read()

                lblNSerie.Text = dr.Item("n_serie")
                txtbxMarque.Text = dr.Item("Marq_Pneus")
                txtbxDimenssion.Text = dr.Item("Dimenssion")
                txtbxdesc.Text = dr.Item("Description")
                Txtbxprix.Text = dr.Item("Prix")


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

    Protected Sub btnAjoutMPneus_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAjoutMPneus.Click
        If txtbxMarque.Text = Nothing Then

            Msg_Erreur(" Veuillez remplir le champ ")

        Else

            Dim req0 As String

            req0 = "select Marq_Pneus,Dimenssion from Marque_Pneus where Marq_Pneus ='" & Me.txtbxMarque.Text & "' and dimenssion='" & txtbxDimenssion.Text & "'"

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
                Msg_Erreur(" erreur......!!!?    La réference de cette marque de ce pneu éxiste déjà ")
                con.Close()
            Else
                Try

                    cmd = New SqlCommand("insert into Marque_Pneus values (" & lblNSerie.Text & ",'" & txtbxMarque.Text & "','" & txtbxDimenssion.Text & "','" & txtbxdesc.Text & "',1,'" & Txtbxprix.Text & "') ", con)
                    con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()
                    Msg_succes(" Ajout réalisé avec succès ")

                    Dim n As Integer = N_L()
                    lblNSerie.Text = n + 1

                    txtbxMarque.Text = ""
                    txtbxDimenssion.Text = ""
                    txtbxdesc.Text = ""
                    Txtbxprix.Text = ""

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

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        btnAjoutMPneus.Visible = True
        btnAnnulerMPneus.Visible = True
        btnsuppMPneus.Visible = False
        txtbxNSerie.Visible = False

        lblNPneus.Visible = True
        lblNSerie.Visible = True

        cbxMarque.Visible = False
        txtbxMarque.Visible = True

        cbxRef.Visible = False
        txtbxDimenssion.Visible = True

        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = True
        img_suppr.Visible = False


        txtbxMarque.Text = ""
        txtbxDimenssion.Text = ""
        txtbxdesc.Text = ""
        Txtbxprix.Text = ""

    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click


        Lblerror.Visible = False
        img_error.Visible = False
        img_succes.Visible = False

        img_new.Visible = False
        img_suppr.Visible = True

        txtbxDimenssion.Text = ""
        txtbxdesc.Text = ""
        Txtbxprix.Text = ""

        btnAjoutMPneus.Visible = False
        btnAnnulerMPneus.Visible = True
        btnsuppMPneus.Visible = True
        txtbxNSerie.Visible = True

        cbxMarque.Visible = True
        txtbxMarque.Visible = False

        cbxRef.Visible = True
        cbxRef.Items.Clear()
        txtbxDimenssion.Visible = False

        lblNSerie.Visible = False
        lblNPneus.Visible = False

        '************************Marque
        cbxMarque.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct Marq_Pneus From Marque_Pneus ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        Do
            cbxMarque.Items.Add(dr.Item("Marq_Pneus"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


    End Sub

    Private Sub cbxMarque_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxMarque.SelectedIndexChanged

        cbxRef.Items.Clear()

        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct N_Serie,Marq_Pneus,Dimenssion,Description,Qte,Prix From Marque_Pneus where  Marq_Pneus='" & cbxMarque.Text & "' ", con)
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxNSerie.Text = dr(0)

            txtbxdesc.Text = dr(3)
            'lblNQte.Text = dr(4)
            Txtbxprix.Text = dr(5)

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

    Private Sub btnsuppMPneus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsuppMPneus.Click
        Try

            cmd = New SqlCommand("delete  from Marque_Pneus where N_Serie= '" & txtbxNSerie.Text & "'", con)
            con.Close()
            con.Open()
            dr = cmd.ExecuteReader
            dr.Read()
            Msg_succes("suppression réalisée avec succès")
            dr.Close()
            con.Close()

            '********************Marque

            'cbxMarque.Items.Clear()

            'con.Close()
            'con.Open()
            'cmd = New SqlCommand("select distinct N_Serie,Marq_Pneus,Dimenssion,Description,Qte,Prix From Marque_Pneus ", con)
            'dr = cmd.ExecuteReader
            'dr.Read()
            '' cbxMarq.Text = dr.Item("lib_marq")

            'txtbxNSerie.Text = dr(0)
            'txtbxDimenssion.Text = dr(2)
            'txtbxdesc.Text = dr(3)
            ''lblNQte.Text = dr(4)
            'Txtbxprix.Text = dr(5)


            'Do
            '    cbxMarque.Items.Add(dr.Item("Marq_Pneus"))

            'Loop While (dr.Read)
            'dr.Close()
            'con.Close()




            cbxRef.Items.Clear()

            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct N_Serie,Marq_Pneus,Dimenssion,Description,Qte,Prix From Marque_Pneus where Marq_Pneus='" & cbxMarque.Text & "' ", con)
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxNSerie.Text = dr(0)

            txtbxdesc.Text = dr(3)
            'lblNQte.Text = dr(4)
            Txtbxprix.Text = dr(5)

            Do
                cbxRef.Items.Add(dr.Item("Dimenssion"))

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

    Protected Sub cbxRef_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxRef.SelectedIndexChanged
        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct N_Serie,Dimenssion From Marque_Pneus where  dimenssion='" & cbxRef.Text & "' ", con)
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxNSerie.Text = dr(0)

            dr.Close()
            con.Close()
        Catch ex As Exception
            Msg_Erreur(ex.Message)
            con.Close()
        End Try
        con.Close()
    End Sub

End Class