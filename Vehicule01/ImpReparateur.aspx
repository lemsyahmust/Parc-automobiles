<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ImpReparateur.aspx.vb" Inherits="Vehicule01.ImpReparateur" %>

<%@ Register assembly="CrystalDecisions.Web, Version=10.5.3700.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Fiche de renseignement</title>
</head>
<body>
<form runat="server" >
       <center>    
      <asp:Button ID="BtnEnd" runat="server" Font-Bold="True" Font-Names="Garamond" Font-Overline="False" Font-Size="Medium" ForeColor="Red" Text="Retour" PostBackUrl="~/Reparateur.aspx" />
      <br /><br />
        <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
            AutoDataBind="True" Height="700px" ReportSourceID="CrystalReportSource1" 
               Width="1100px" DisplayGroupTree="False" />
        <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
            <Report FileName="CrysReparateur.rpt">
            </Report>
        </CR:CrystalReportSource>

    </center>
     </form>   
</body>
</html>
