Imports System.Data.SqlClient

Partial Public Class WebForm11
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then

            Label1.Text = Now.Date

            Dim req0 As String

            req0 = " select mat_vehi,Date_F,Ordre_M from Mission where Date_F='" & Label1.Text & "' "

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

                con.Close()
                con.Open()
                cmd = New SqlCommand(" select mat_vehi,Date_F,Ordre_M from Mission where Date_F='" & Label1.Text & "' ", con)
                dr = cmd.ExecuteReader
                dr.Read()

                Do

                    Label2.Text = dr.Item("mat_vehi")
                    Label3.Text = dr.Item("Ordre_M")

                    MsgBox("le vehicule avec le matricule :   " & Label2.Text & "est avec l'ordre mission    :" & Label3.Text & " doit rentrer du mission aujourd'hui ")

                Loop While dr.Read


                dr.Close()
                con.Close()

                con.Close()
            Else

            End If


        End If

    End Sub

End Class