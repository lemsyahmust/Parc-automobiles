Imports System.Data.SqlClient

Partial Public Class WebForm31
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

    Protected Sub btnAjout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAjout.Click

        If txtbxDate.Text <> Nothing And txtbxMontant.Text <> Nothing Then



            If Not IsDate(Me.txtbxDate.Text) Then
                Msg_Erreur(" Format date et jj/mm/aa ")

            Else
                If Not IsNumeric(Me.txtbxMontant.Text) Then
                    Msg_Erreur("Le montant doit êtres obligatoirement un chiffre")
                Else

                    Dim req0 As String

                    req0 = "select Date from SNTL where Date ='" & Me.txtbxDate.Text & "' "

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
                        Msg_Erreur(" Erreur....!!! Cette Date existe déjà ")
                        con.Close()
                    Else

                        Try

                            cmd = New SqlCommand("insert into SNTL(Date,Montant1,Montant2) values('" & txtbxDate.Text & "','" & txtbxMontant.Text & "','" & txtbxMontant.Text & "')", con)
                            con.Close()
                            con.Open()
                            cmd.ExecuteNonQuery()
                            con.Close()

                            'cmd = New SqlCommand("insert into consommation(N_cons,n_vehi,mat_vehi,montant,N_Miss,lib_marqq) values(" & lblNConsMI.Text & "," & txtbxNVehiMI.Text & ",'" & cbxMatVehiMI.Text & "','" & txtbxMontant.Text & "'," & lblNMiss.Text & ",'" & cbxTypeVehi.Text & "')", con)
                            'con.Close()
                            'con.Open()
                            'cmd.ExecuteNonQuery()
                            'con.Close()

                            Msg_succes(" Ajout réalisé avec succès ")
                        Catch ex As Exception
                            ' Msg_Erreur("Erreur de ............!!!!!!")
                            Msg_Erreur(ex.Message)
                            con.Close()
                        End Try
                        con.Close()
                    End If

                End If

            End If
        Else
            Msg_Erreur("Veuillez remplir les champs")
        End If

    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click

        txtbxDate.Text = ""
        txtbxMontant.Text = ""

    End Sub
End Class