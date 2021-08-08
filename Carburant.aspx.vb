Imports System.Data
Imports System.Data.SqlClient

Partial Public Class WebForm10
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnModif_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModif.Click
        lblCarburant.Visible = True
        lbldate.Visible = True
        lblPrix.Visible = True

        cbxCarburant.Visible = True
        txtbxDate.Visible = True
        txtbxPrix.Visible = True
        txtbxDate1.Visible = True
        txtbxPrix1.Visible = True

        btnModif.Visible = False
        btnAnnuler.Visible = True
        btnValider.Visible = True


        cbxCarburant.Items.Clear()


        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct lib_carb From Carburant ", con)
        '  cmd = New SqlCommand("select c.lib_carb,pc.dat_prix_carb,pc.prix_carb from Carburant c,Prix_carburant pc where lib_carb='" & cbxCarburant.Text & "'", con)

        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        Do
            cbxCarburant.Items.Add(dr.Item("lib_carb"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()


    End Sub

    Private Sub btnAnnuler_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnnuler.Click
        btnModif.Visible = True
        btnAnnuler.Visible = True
        btnValider.Visible = False

        lblCarburant.Visible = False
        lbldate.Visible = False
        lblPrix.Visible = False

        cbxCarburant.Visible = False
        txtbxDate.Visible = False
        txtbxPrix.Visible = False

        txtbxDate1.Visible = False
        txtbxPrix1.Visible = False




    End Sub

    Private Sub btnValider_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnValider.Click
        If Not IsDate(Me.txtbxDate.Text) Then
            MsgBox(" Format date et jj/mm/aa ")

        Else
            Try
                con.Close()
                con.Open()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update Prix_carburant set dat_prix_carb='" & txtbxDate.Text & "',prix_carb='" & txtbxPrix.Text & "' where dat_prix_carb='" & txtbxDate1.Text & "' and prix_carb='" & txtbxPrix1.Text & "'"

                cmd.ExecuteNonQuery()
                con.Close()
                'MsgBox("Modification réalisée avec succès")

                txtbxDate.Text = ""
                txtbxPrix.Text = ""
                txtbxDate1.Text = ""
                txtbxPrix1.Text = ""

                Response.Redirect("Carburant.aspx")

            Catch ex As Exception
                ' MsgBox(" Stagiaire  ")
                'MsgBox("La Modification et Realiser Avec Succès")
                Label1.Text = ex.Message

                con.Close()
            End Try
            con.Close()
        End If

    End Sub

    Private Sub cbxCarburant_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxCarburant.SelectedIndexChanged
        Try

            con.Open()
            cmd = New SqlCommand(" SELECT dbo.Carburant.lib_carb, dbo.Prix_carburant.dat_prix_carb, dbo.Prix_carburant.prix_carb fROM dbo.Carburant INNER JOIN dbo.Prix_carburant ON dbo.Carburant.n_prix_carb = dbo.Prix_carburant.n_prix_carb where lib_carb='" & cbxCarburant.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()

            txtbxDate.Text = dr.Item("dat_prix_carb")
            txtbxPrix.Text = dr.Item("prix_carb")

            txtbxDate1.Text = dr.Item("dat_prix_carb")
            txtbxPrix1.Text = dr.Item("prix_carb")
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
End Class