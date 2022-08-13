<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="SuppMission.aspx.vb" Inherits="Vehicule01.WebForm40" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
<h2><i>Suppression&nbsp; des&nbsp; Missions</i></h2></center>


        <table  style="width: 389px; border-collapse: collapse;">
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
       
        
<asp:Panel ID="Panel1" runat="server" Width="86%" BorderColor="Black" 
        BorderWidth="1px" Height="248px">
        <br />
        <br />
 <table style="width: 66%; height: 187px; margin-right: 0px;"  align="center" 
            valign="top">
 
    
                                       <tr>
                                       <td>
                                           <asp:Label ID="lblTypeVehi" runat="server" Font-Bold="True" Height="22px" 
                                               Text="Type vehicule" Width="118px"></asp:Label>
                                       </td>
                                       <td style="width: 392px">
                                           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                           <asp:DropDownList ID="cbxTypeVehi" runat="server" AutoPostBack="true" 
                                               Width="226px">
                                           </asp:DropDownList>
                                       </td>
                                   </tr>
                                   <tr>
                                       <td>
                                           <asp:Label ID="lblMatriculeMI" runat="server" Font-Bold="True" Height="22px" 
                                               Text="Matricule" Width="135px"></asp:Label>
                                       </td>
                                       <td style="width: 392px">
                                           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                           <asp:DropDownList ID="cbxMatVehiMI" runat="server" AutoPostBack="true" 
                                               Width="226px">
                                           </asp:DropDownList>
                                       </td>
                                   </tr>
                                   
                                   <tr>
                                       <td>
                                           <asp:Label ID="lblDateD" runat="server" Font-Bold="True" Height="22px" 
                                               Text="Date début mission" Width="135px"></asp:Label>
                                       </td>
                                       <td style="width: 392px">
                                           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                           <asp:DropDownList ID="cbxTypeVehi0" runat="server" AutoPostBack="true" 
                                               Width="226px">
                                           </asp:DropDownList>
                                           <asp:Label ID="Label1" runat="server"></asp:Label>
                                       </td>
                                   </tr>
                                   
                                    <tr>
                                       <td>
                                           <asp:Label ID="lblsouche" runat="server" Font-Bold="True" Height="22px" 
                                               Text="Ordre de mission" Width="135px"></asp:Label>
                                       </td>
                                       <td style="width: 392px">
                                           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                           <asp:TextBox ID="txtbxSouche" runat="server" Height="17px" Width="226px"></asp:TextBox>
                                       </td>
                                   </tr>
                                   
                                    <tr>
                                       <td>
                                       </td>
                                       <td style="width: 392px">
                                           <br />
                                           <asp:Button ID="btnsuppMI" runat="server" Font-Bold="True" Font-Italic="True" 
                                               Font-Names="Garamond" Font-Overline="False" Font-Size="Medium" 
                                               Font-Strikeout="False" Font-Underline="False" ForeColor="Blue" Height="22px" 
                                               Text="Supprimer" Width="99px" />
                                           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                           <asp:Button ID="btnAnnulerMI" runat="server" Font-Bold="True" 
                                               Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                                               Font-Size="Medium" ForeColor="Blue" Height="22px" Text="Retour" 
                                               Width="99px" PostBackUrl="~/Mission.aspx" />
                                           <br />
                                       </td>
                                   </tr>
                                   
                                   
 
 </table>
 
 </asp:Panel>
 
</asp:Content>
