Imports System.Data.SqlClient

Partial Public Class WebForm40
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

        If Not Page.IsPostBack Then


            '*********Type Vehicule

            cbxTypeVehi.Items.Clear()

            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct Type_Vehi From Mission ", con)
            dr = cmd.ExecuteReader
            dr.Read()
            ' cbxMarq.Text = dr.Item("lib_marq")
            ' txtbxNVehiMI.Text = dr.Item("n_vehi")
            Do
                cbxTypeVehi.Items.Add(dr.Item("Type_Vehi"))

            Loop While (dr.Read)
            dr.Close()
            con.Close()

        End If

    End Sub

    Protected Sub btnsuppMI_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnsuppMI.Click

        Try
            con.Close()
            con.Open()
            cmd = New SqlCommand("delete  from Consommation where mat_vehi= '" & cbxMatVehiMI.Text & "' and N_Miss=" & Label1.Text & " ", con)
            dr = cmd.ExecuteReader
            dr.Read()
            con.Close()

            con.Close()
            con.Open()
            cmd = New SqlCommand("delete  from Mission where mat_vehi= '" & cbxMatVehiMI.Text & "'  and N_Miss=" & Label1.Text & "", con)
            dr = cmd.ExecuteReader
            dr.Read()

            dr.Close()
            con.Close()

            con.Close()
            con.Open()
            cmd = New SqlCommand("delete  from mission_Perso where N=" & Label1.Text & "", con)
            dr = cmd.ExecuteReader
            dr.Read()

            dr.Close()
            con.Close()

            '*********Type Vehicule

            cbxTypeVehi.Items.Clear()
            cbxTypeVehi0.Items.Clear()
            txtbxSouche.Text = ""

            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct Type_Vehi From Mission ", con)
            dr = cmd.ExecuteReader
            dr.Read()
            ' cbxMarq.Text = dr.Item("lib_marq")
            ' txtbxNVehiMI.Text = dr.Item("n_vehi")
            Do
                cbxTypeVehi.Items.Add(dr.Item("Type_Vehi"))

            Loop While (dr.Read)
            dr.Close()
            con.Close()


            Msg_succes("suppression réalisée avec succès")

        Catch ex As Exception
            Msg_Erreur(ex.Message)
            con.Close()
        End Try
        dr.Close()
        con.Close()

    End Sub

    Protected Sub cbxTypeVehi_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxTypeVehi.SelectedIndexChanged
        Try

            '*********Type Vehicule

            cbxMatVehiMI.Items.Clear()
            cbxTypeVehi0.Items.Clear()

            con.Close()
            con.Open()
            'cmd = New SqlCommand(" select distinct lib_marqq,mat_vehi,N_Vehi From Vehicule where lib_marqq='" & cbxTypeVehi.Text & "'", con)
            cmd = New SqlCommand("select distinct mat_vehi,type_Vehi,Date_D,Ordre_M,N_Miss  from Mission where Type_Vehi='" & cbxTypeVehi.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()


            txtbxSouche.Text = dr.Item("Ordre_M")
            Label1.Text = dr.Item("N_Miss")

            Do
                cbxMatVehiMI.Items.Add(dr.Item("mat_vehi"))
                cbxTypeVehi0.Items.Add(dr.Item("Date_D"))

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

    Protected Sub cbxMatVehiMI_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxMatVehiMI.SelectedIndexChanged

        Try

            '*********Type Vehicule

            cbxTypeVehi0.Items.Clear()

            con.Close()
            con.Open()
            'cmd = New SqlCommand(" select distinct lib_marqq,mat_vehi,N_Vehi From Vehicule where lib_marqq='" & cbxTypeVehi.Text & "'", con)
            cmd = New SqlCommand("select mat_vehi,type_Vehi,Date_D,Ordre_M,N_Miss  from Mission where mat_vehi='" & cbxMatVehiMI.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxSouche.Text = dr.Item("Ordre_M")
            Label1.Text = dr.Item("N_Miss")

            Do

                cbxTypeVehi0.Items.Add(dr.Item("Date_D"))

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

    Protected Sub cbxTypeVehi0_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxTypeVehi0.SelectedIndexChanged

        Try

            '*********Type Vehicule

            '  cbxTypeVehi0.Items.Clear()

            con.Close()
            con.Open()
            'cmd = New SqlCommand(" select distinct lib_marqq,mat_vehi,N_Vehi From Vehicule where lib_marqq='" & cbxTypeVehi.Text & "'", con)
            cmd = New SqlCommand("select mat_vehi,type_Vehi,Date_D,Ordre_M,N_Miss  from Mission where Date_D='" & cbxTypeVehi0.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxSouche.Text = dr.Item("Ordre_M")
            Label1.Text = dr.Item("N_Miss")

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