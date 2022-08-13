<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="ImpDepenseVehicule.aspx.vb" Inherits="Vehicule01.WebForm37" 
    title="Page sans titre" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=10.5.3700.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="content" style="width: 1045px">

    <center>
<h2><i>Dépense par vehicule</i>&nbsp; </h2></center>

<br />
<br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:Button ID="BtnEnd" runat="server" Font-Bold="True" Font-Names="Garamond" Font-Overline="False" Font-Size="Medium" ForeColor="Red" Text="Retour" />


<br />
<br />
       
     <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
         AutoDataBind="True" DisplayGroupTree="False" Height="1106px" 
         ReportSourceID="CrystalReportSource1" Width="876px" />
 
     <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
         <Report FileName="CrystalReport1.rpt">
         </Report>
     </CR:CrystalReportSource>
 


   </div>
    
</asp:Content>
