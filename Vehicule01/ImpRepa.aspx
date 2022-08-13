<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="ImpRepa.aspx.vb" Inherits="Vehicule01.WebForm36" 
    title="Page sans titre" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=10.5.3700.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content" style="width: 1045px">

    <center>
<h2><i>Détail de réparation(S)</i></h2></center>

    <table  style="width: 389px; border-collapse: collapse; height: 19px;">
            <tr>
                <td style="width: 76px; height: 31px">
                    <asp:Image ID="img_error" runat="server" Height="16px" ImageUrl="~/images/error.gif"
                        Visible="False" Width="16px" /></td>
                <td style="width: 95px; height: 31px">
                    <asp:Image ID="img_succes" runat="server" ImageUrl="~/images/ok.gif" Visible="False" /></td>
                <td style="width: 3px; height: 31px">
                    <asp:Label ID="Lblerror" runat="server" ForeColor="Red" Visible="False" 
                        Width="649px"></asp:Label></td>
            </tr>
        </table>
        
<center>
<asp:Panel ID="Panel1" runat="server" Width="90%" BorderColor="Black" 
        BorderWidth="1px" Height="201px">
        
        
   <table style="width: 748px; height: 61px; border-collapse: collapse; margin-right: 0px;">
   
       <tr>
                    <td>
                        <asp:Label ID="lblDateDebut" runat="server" Font-Bold="True" Height="22px" 
                            Text="De" Width="134px" ForeColor="Gray"></asp:Label>
                        
                       <asp:TextBox ID="txtbxDateDebut" runat="server" Height="17px" Width="183px"></asp:TextBox>                   
                    </td>
                    
                <td>
                        <asp:Label ID="lblDateFin" runat="server" Font-Bold="True" Height="22px" 
                            Text="à" Width="135px" ForeColor="Gray"></asp:Label>
                        
                      <asp:TextBox ID="txtbxDateFin" runat="server" Height="17px" Width="183px"></asp:TextBox>                   
                    </td>
                    
                   </tr>
                   
                     <tr>
                    <td>
                        <asp:Label ID="lblMatricule" runat="server" Font-Bold="True" Height="22px" 
                            Text="Matricule" Width="135px" ForeColor="Gray"></asp:Label>
                        
                        <asp:DropDownList ID="cbxMatricule" runat="server" Visible="true" Width="226px">
                        </asp:DropDownList>
                                         
                    </td>
                    <td>
                     <asp:Button ID="BtnEnd" runat="server" Font-Bold="True" Font-Names="Garamond" Font-Overline="False" Font-Size="Medium" ForeColor="Red"  Text="Imprimer" />

                    </td>
                    
                                                   
                  </tr>
                   
   
   </table>
   
   <table style="width: 748px; height: 74px; border-collapse: collapse; margin-right: 0px;">
   
   <tr>
   <td>
       <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
           AutoDataBind="true" DisplayGroupTree="False" />
   </td>
   </tr>
   
   </table>
   
   </asp:Panel>
   </center>
   </div>
   
</asp:Content>
