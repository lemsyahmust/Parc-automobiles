Imports System.Data.SqlClient

Partial Public Class WebForm35
    Inherits System.Web.UI.Page

    Dim tm, tct, tc As New DataTable
    Dim dat, dact, dam, dac As New SqlDataAdapter
    Dim dss As New DataSet

    Sub P_c()

        cmd = New SqlCommand("select distinct lib_aff from Affectation ", con)
        dac = New SqlDataAdapter(cmd)
        dac.Fill(dss, "Affectation")
        tc = dss.Tables("Affectation")

    End Sub

    Sub remplc(ByVal livr As String)
        Dim t As DataTable = Nothing
        Me.Datagrid2.DataSource = t
        Me.Datagrid2.DataBind()
        Dim dv As New DataView
        dv = New DataView(tct)
        dv.RowFilter = "lib_aff='" & livr & "'"
        Me.Datagrid2.DataSource = dv
        Me.Datagrid2.DataBind()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        'If Not Page.IsPostBack Then

        If Not Page.IsPostBack Then


            cbxMatricule.Items.Clear()
            con.Close()
            con.Open()
            cmd = New SqlCommand(" select distinct lib_aff From Affectation ", con)
            dr = cmd.ExecuteReader
            dr.Read()
            ' cbxMarq.Text = dr.Item("lib_marq")
            Do
                cbxMatricule.Items.Add(dr.Item("lib_aff"))

            Loop While (dr.Read)
            dr.Close()
            con.Close()


            tm.Rows.Clear()
            Me.Datagrid2.DataSource = tm
            Me.Datagrid2.DataBind()
        End If
        'P_Cmd_t()
        'P_m()
        '  P_c()

        'Me.cbxMatricule.DataSource = tc
        'Me.cbxMatricule.DataTextField = "lib_aff"
        'Me.cbxMatricule.DataBind()
        'Me.cbxMatricule.SelectedIndex = 0

        'cmd = New SqlCommand("SELECT dbo.Vehicule.mat_vehi, dbo.Vehicule.lib_marqq, dbo.Vehicule.date_circul, dbo.Affectation.lib_aff, dbo.etat_vehicule.lib_etat_vehi FROM dbo.Vehicule INNER JOIN dbo.etat_vehicule ON dbo.Vehicule.n_etat_vehi = dbo.etat_vehicule.n_etat_vehi INNER JOIN  dbo.Affectation ON dbo.Vehicule.n_aff = dbo.Affectation.n_aff CROSS JOIN dbo.consommation where dbo.Affectation.lib_aff= '" & cbxMatricule.Text & "'", con)
        'dact = New SqlDataAdapter(cmd)

        'dact.Fill(dss, "Vehicule")
        'tct = dss.Tables("Vehicule")

        'Datagrid2.DataSource = dss.Tables("Vehicule")
        'Datagrid2.DataBind()
        'con.Close()

        'If Me.cbxMatricule.Items.Count = 1 Then
        '    remplc(Me.cbxMatricule.Text)
        'End If
        'End If



    End Sub

    Protected Sub cbxMatricule_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxMatricule.SelectedIndexChanged



        Datagrid2.Visible = True

        Try

            ' cmd = New SqlCommand("SELECT Distinct dbo.Vehicule.mat_vehi, dbo.Vehicule.lib_marqq, dbo.Vehicule.date_circul, dbo.Affectation.lib_aff, dbo.etat_vehicule.lib_etat_vehi FROM dbo.Vehicule INNER JOIN dbo.etat_vehicule ON dbo.Vehicule.n_etat_vehi = dbo.etat_vehicule.n_etat_vehi INNER JOIN  dbo.Affectation ON dbo.Vehicule.n_aff = dbo.Affectation.n_aff CROSS JOIN dbo.consommation where dbo.Affectation.lib_aff= '" & cbxMatricule.Text & "'", con)

            cmd = New SqlCommand("select A.lib_aff,V.mat_vehi,V.lib_marqq,V.nbr_Plc,V.date_circul from Vehicule V, Affectation A where V.n_aff=A.n_aff and A.lib_aff='" & cbxMatricule.Text & "'", con)

            dact = New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            dact.Fill(ds, "Vehicule")
            tct = ds.Tables("Vehicule")

            Datagrid2.DataSource = ds.Tables("Vehicule")
            Datagrid2.DataBind()
            con.Close()

        Catch ex As Exception
            con.Close()

        End Try
        con.Close()


    End Sub

    'Protected Sub BtnEnd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnEnd.Click

    '    CrystalReportViewer1.Visible = True
    '    Datagrid2.Visible = False


    '    '  Dim da As New SqlDataAdapter("SELECT dbo.Vehicule.mat_vehi, dbo.Vehicule.lib_marqq, dbo.Vehicule.date_circul, dbo.Affectation.lib_aff, dbo.etat_vehicule.lib_etat_vehi FROM dbo.Vehicule INNER JOIN dbo.etat_vehicule ON dbo.Vehicule.n_etat_vehi = dbo.etat_vehicule.n_etat_vehi INNER JOIN  dbo.Affectation ON dbo.Vehicule.n_aff = dbo.Affectation.n_aff CROSS JOIN dbo.consommation where dbo.Affectation.lib_aff= '" & cbxMatricule.Text & "'", con)
    '    Dim da As New SqlDataAdapter(" select * from Affectation where Lib_Aff='" & cbxMatricule.Text & "' ", con)
    '    Dim dt As New DataTable
    '    da.Fill(dt)

    '    Dim crp As New CrysBéné
    '    crp.SetDataSource(dt)
    '    CrystalReportViewer1.ReportSource = crp

    'End Sub

End Class