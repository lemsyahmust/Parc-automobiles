Imports System.Data.SqlClient

Partial Public Class Test
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListBox1.Visible = True
        ' If ListBox1.Text = "10" Then

        '*********Nom

        

        '        Else
        '  MsgBox("Ok")
        '       End If

        TextBox1.Text = Day(Now()) & "/" & Month(Now()) & "/" & Year(Now())

    End Sub

    Function transfer(ByVal source As ListBox, ByVal destination As ListBox, ByVal btn1 As Button, ByVal btn2 As Button)
        Try
            ListBox2.Items.Add(ListBox1.SelectedItem.ToString)
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            Button2.Enabled = True
            If ListBox1.Items.Count = 0 Then
                Button1.Enabled = False
            End If
        Catch ex As Exception
            ' MsgBox("Veuilliez selectionner un element.", MsgBoxStyle.RetryCancel, "ERREUR (-_-')")
            MsgBox(ex.Message)
        End Try
        Return 0
    End Function

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        
        Try

            con.Close()
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into mission_Perso values ( 1,'" & ListBox1.Text & "')"
            cmd.ExecuteNonQuery()
            con.Close()

            ListBox2.Items.Add(ListBox1.SelectedItem.Text)
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Veuiilez choisir un element de la liste !!")
        End Try
            End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()


        con.Close()
        con.Open()
        cmd = New SqlCommand(" select distinct Nom,Prenom From Personnel ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        ' cbxMarq.Text = dr.Item("lib_marq")
        'txtbxNEtat.Text = dr.Item("n_etat_vehi")
        Do

            ListBox1.Items.Add(dr.Item("Nom"))

        Loop While (dr.Read)
        dr.Close()
        con.Close()
    End Sub

    Protected Sub Button2_Click1(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Try

            con.Close()
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from mission_Perso where Nom_Perso='" & ListBox2.SelectedItem.Text & "'"
            cmd.ExecuteNonQuery()
            con.Close()


            ListBox1.Items.Add(ListBox2.SelectedItem.Text)
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Veuiilez choisir un element de la liste !!")

        End Try


    End Sub

    Protected Sub ListBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ListBox2.SelectedIndexChanged

       

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        'Try
        'Do

        '   cmd = New SqlCommand("insert into mission_Perso values(1,'" & ListBox2.Text & "')", con)

        'Dim i As Int16 = 1

        'i = ListBox2.Text.Length - 1
        'Dim i As Integer = 0
        'While (i < ListBox2.Items.Count - 1)
        '    con.Close()
        '    con.Open()
        '    cmd.Connection = con
        '    cmd.CommandType = CommandType.Text
        '    cmd.CommandText = "insert into mission_Perso values ( 1," & i & ")"
        '    cmd.ExecuteNonQuery()
        '    con.Close()
        'End While

        'Dim i As ListItem
        'For Each i In ListBox2.s
        '    con.Close()
        '    con.Open()
        '    cmd.Connection = con
        '    cmd.CommandType = CommandType.Text
        '    cmd.CommandText = "insert into mission_Perso values ( 1," & i.Text & ")"
        '    cmd.ExecuteNonQuery()
        '    con.Close()
        'Next
        '    Dim i As Integer = 0
        '    While i < ListBox2.Items.Count - 1
        '        con.Close()
        '        con.Open()
        '        cmd.Connection = con
        '        cmd.CommandType = CommandType.Text
        '        cmd.CommandText = "insert into mission_Perso values ( 1,'" & ListBox2.Items(i).Selected.ToString & "')"
        '        cmd.ExecuteNonQuery()
        '        con.Close()
        '    End While


        'con.Close()
        'con.Open()
        'cmd.Connection = con
        'cmd.CommandType = CommandType.Text
        'cmd.CommandText = "insert into mission_Perso values ( 1,'" & ListBox2.Text & "')"
        'cmd.ExecuteNonQuery()
        'con.Close()


        'Catch ex As Exception
        '    ' Msg_Erreur("Erreur de ............!!!!!!")
        '    MsgBox(ex.Message)
        '    con.Close()
        'End Try
        'con.Close()
    End Sub
End Class