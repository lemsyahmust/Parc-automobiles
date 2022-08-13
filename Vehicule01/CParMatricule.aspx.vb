Imports System.Data.SqlClient

Partial Public Class WebForm33
    Inherits System.Web.UI.Page

    Dim tm, tct, tc As New DataTable
    Dim dat, dact, dam, dac As New SqlDataAdapter
    Dim ds As New DataSet

    Sub P_c()

        cmd = New SqlCommand("select distinct mat_vehi from Vehicule ", con)
        dac = New SqlDataAdapter(cmd)
        dac.Fill(ds, "Vehicule")
        tc = ds.Tables("Vehicule")
        con.Close()

    End Sub

    Sub remplc(ByVal livr As String)
        Dim t As DataTable = Nothing
        Me.Datagrid2.DataSource = t
        Me.Datagrid2.DataBind()
        Dim dv As New DataView
        dv = New DataView(tct)
        dv.RowFilter = "mat_vehi='" & livr & "'"
        Me.Datagrid2.DataSource = dv
        Me.Datagrid2.DataBind()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            tm.Rows.Clear()
            Me.Datagrid2.DataSource = tm
            Me.Datagrid2.DataBind()

            'P_Cmd_t()
            'P_m()
            P_c()

            Me.cbxMatricule.DataSource = tc
            Me.cbxMatricule.DataTextField = "mat_vehi"
            Me.cbxMatricule.DataBind()
            Me.cbxMatricule.SelectedIndex = 0

            cmd = New SqlCommand("SELECT distinct dbo.Vehicule.mat_vehi, dbo.Vehicule.lib_marqq, dbo.Vehicule.date_circul,dbo.vehicule.nbr_plc, dbo.consommation.km, dbo.Affectation.lib_aff, dbo.etat_vehicule.lib_etat_vehi FROM dbo.Vehicule INNER JOIN dbo.consommation ON dbo.Vehicule.n_vehi = dbo.consommation.n_vehi INNER JOIN dbo.etat_vehicule ON dbo.Vehicule.n_etat_vehi = dbo.etat_vehicule.n_etat_vehi INNER JOIN dbo.Affectation ON dbo.Vehicule.n_aff = dbo.Affectation.n_aff and dbo.Vehicule.mat_vehi= '" & cbxMatricule.Text & "'", con)
            dact = New SqlDataAdapter(cmd)

            dact.Fill(ds, "Vehicule")
            tct = ds.Tables("Vehicule")
            con.Close()

            Datagrid2.DataSource = ds.Tables("Vehicule")
            Datagrid2.DataBind()
            con.Close()

            If Me.cbxMatricule.Items.Count = 1 Then
                remplc(Me.cbxMatricule.Text)
            End If
        End If


    End Sub

    Protected Sub cbxMatricule_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxMatricule.SelectedIndexChanged

        'CrystalReportViewer1.Visible = False
        Datagrid2.Visible = True

        Try
            ' cmd = New SqlCommand("SELECT distinct dbo.Vehicule.mat_vehi, dbo.Vehicule.lib_marqq, dbo.Vehicule.date_circul, dbo.consommation.km, dbo.Affectation.lib_aff, dbo.etat_vehicule.lib_etat_vehi FROM dbo.Vehicule INNER JOIN dbo.consommation ON dbo.Vehicule.n_vehi = dbo.consommation.n_vehi INNER JOIN dbo.etat_vehicule ON dbo.Vehicule.n_etat_vehi = dbo.etat_vehicule.n_etat_vehi INNER JOIN dbo.Affectation ON dbo.Vehicule.n_aff = dbo.Affectation.n_aff and dbo.Vehicule.mat_vehi= '" & cbxMatricule.Text & "'", con)
            cmd = New SqlCommand("select C.dat_cons,C.mat_vehi,V.lib_marqq,V.date_circul,C.km,A.lib_aff,V.nbr_Plc  from Vehicule V, consommation C,Affectation A where V.mat_vehi=C.mat_vehi and V.n_aff=A.n_aff and C.mat_vehi='" & cbxMatricule.Text & "' and C.km=(select MAX(km) from consommation where mat_vehi='" & cbxMatricule.Text & "')", con)
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

    Protected Sub BtnEnd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnEnd.Click
        'CrystalReportViewer1.Visible = True
        'Datagrid2.Visible = False


        'CrystalReportViewer1.Visible = True

        ''Dim da As New SqlDataAdapter("SELECT distinct dbo.Vehicule.mat_vehi, dbo.Vehicule.lib_marqq, dbo.Vehicule.date_circul, dbo.consommation.km, dbo.Affectation.lib_aff, dbo.etat_vehicule.lib_etat_vehi FROM dbo.Vehicule INNER JOIN dbo.consommation ON dbo.Vehicule.n_vehi = dbo.consommation.n_vehi INNER JOIN dbo.etat_vehicule ON dbo.Vehicule.n_etat_vehi = dbo.etat_vehicule.n_etat_vehi INNER JOIN dbo.Affectation ON dbo.Vehicule.n_aff = dbo.Affectation.n_aff and dbo.Vehicule.mat_vehi= '" & cbxMatricule.Text & "'", con)
        'Dim da As New SqlDataAdapter("select C.dat_cons,C.mat_vehi,V.lib_marqq,V.date_circul,C.km,A.lib_aff,V.nbr_Plc  from Vehicule V, consommation C,Affectation A where V.mat_vehi=C.mat_vehi and V.n_aff=A.n_aff and C.mat_vehi='" & cbxMatricule.Text & "' and C.km=(select MAX(km) from consommation where mat_vehi='" & cbxMatricule.Text & "')", con)

        'Dim dt As New DataTable
        'da.Fill(dt)

        'Dim crp As New CrysMatricule
        'crp.SetDataSource(dt)
        'CrystalReportViewer1.ReportSource = crp



    End Sub
End Class