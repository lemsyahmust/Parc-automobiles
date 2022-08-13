<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ImpMarqPneus.aspx.vb" Inherits="Vehicule01.ImpMarqPneus" %>

<%@ Register assembly="CrystalDecisions.Web, Version=10.5.3700.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Fiche de renseignement</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center>
    
<asp:Button ID="BtnEnd" runat="server" Font-Bold="True" Font-Names="Garamond" Font-Overline="False" Font-Size="Medium" ForeColor="Red" PostBackUrl="~/MarquePneus.aspx" Text="Retour" />
     
     <br />     
     <br />

        <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
            AutoDataBind="True" Height="1106px" ReportSourceID="CrystalReportSource1" 
            Width="876px" DisplayGroupTree="False" />
        <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
            <Report FileName="CrysMarqPneus.rpt">
            </Report>
        </CR:CrystalReportSource>

 </center>
 
    </div>
    </form>
</body>
</html>
