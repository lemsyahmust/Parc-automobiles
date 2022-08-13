Imports System.Data.SqlClient

Partial Public Class WebForm42
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
            Try
                '*********Marque

                cbxMarque.Items.Clear()

                con.Close()
                con.Open()
                cmd = New SqlCommand(" select distinct lib_marqq From Vehicule ", con)
                dr = cmd.ExecuteReader
                dr.Read()
                ' cbxMarq.Text = dr.Item("lib_marq")
                ' cbxMarque.Text = Nothing

                Do
                    cbxMarque.Items.Add(dr.Item("lib_marqq"))

                Loop While (dr.Read)
                dr.Close()
                con.Close()
            Catch ex As Exception

            End Try

        End If

    End Sub

    Protected Sub cbxMarque_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxMarque.SelectedIndexChanged
        '*********Marque

        cbxmaticule.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select lib_marqq,mat_vehi,num_chass From Vehicule where lib_marqq='" & cbxMarque.Text & "' ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        ' cbxMarque.Text = Nothing
        txtbxNChassis.Text = dr.Item("num_chass")

        Do
            cbxmaticule.Items.Add(dr.Item("mat_vehi"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()
    End Sub

    Protected Sub cbxmaticule_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxmaticule.SelectedIndexChanged
        '*********Marque

        cbxmaticule.Items.Clear()

        con.Close()
        con.Open()
        cmd = New SqlCommand(" select lib_marqq,mat_vehi,num_chass From Vehicule where mat_vehi='" & cbxmaticule.Text & "' ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        ' cbxMarque.Text = Nothing
        txtbxNChassis.Text = dr.Item("num_chass")

        dr.Close()
        con.Close()

    End Sub

    Protected Sub btnsuppVeh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnsuppVeh.Click

        Try

            cmd = New SqlCommand("delete  from Consommation where mat_vehi= '" & cbxmaticule.Text & "'", con)
            con.Close()
            con.Open()
            dr = cmd.ExecuteReader
            dr.Read()

            dr.Close()
            con.Close()


            cmd = New SqlCommand("delete  from DepCarburant where mat_vehi= '" & cbxmaticule.Text & "'", con)
            con.Close()
            con.Open()
            dr = cmd.ExecuteReader
            dr.Read()

            dr.Close()
            con.Close()


            cmd = New SqlCommand("delete  from Mission where mat_vehi= '" & cbxmaticule.Text & "'", con)
            con.Close()
            con.Open()
            dr = cmd.ExecuteReader
            dr.Read()

            dr.Close()
            con.Close()


            cmd = New SqlCommand("delete  from Pneus where mat_vehi= '" & cbxmaticule.Text & "'", con)
            con.Close()
            con.Open()
            dr = cmd.ExecuteReader
            dr.Read()

            dr.Close()
            con.Close()


            cmd = New SqlCommand("delete  from ReparationT where mat_vehi= '" & cbxmaticule.Text & "'", con)
            con.Close()
            con.Open()
            dr = cmd.ExecuteReader
            dr.Read()

            dr.Close()
            con.Close()


            cmd = New SqlCommand("delete  from vehicule where mat_vehi= '" & cbxmaticule.Text & "' and num_chass='" & txtbxNChassis.Text & "'", con)
            con.Close()
            con.Open()
            dr = cmd.ExecuteReader
            dr.Read()

            dr.Close()
            con.Close()


            cmd = New SqlCommand("delete  from Vidange where mat_vehi= '" & cbxmaticule.Text & "'", con)
            con.Close()
            con.Open()
            dr = cmd.ExecuteReader
            dr.Read()

            dr.Close()
            con.Close()


            Msg_succes("La suppression du véhicule avec son matricule :  " & cbxmaticule.Text & "  est réalisée avec succès")

        Catch ex As Exception

        End Try

    End Sub
End Class