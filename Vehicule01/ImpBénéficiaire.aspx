<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ImpBénéficiaire.aspx.vb" Inherits="Vehicule01.ImpBénéficiaire" %>

<%@ Register assembly="CrystalDecisions.Web, Version=10.5.3700.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Page sans titre</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <center>
    
 <asp:Button ID="BtnEnd" runat="server" Font-Bold="True" Font-Names="Garamond" Font-Overline="False" Font-Size="Medium" ForeColor="Red" PostBackUrl="~/Affectation.aspx" Text="Retour" />

         <br />

<br />
    
        <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
            AutoDataBind="True" DisplayGroupTree="False" Height="1116px" 
            ReportSourceID="CrystalReportSource1" Width="767px" />
    
        <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
            <report filename="CrysBénéficiaire.rpt">
            </report>
        </CR:CrystalReportSource>
    
     </center>
    
    </div>
    </form>
</body>
</html>
