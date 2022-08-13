<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="SupprimerVehi.aspx.vb" Inherits="Vehicule01.WebForm13" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<center style="width: 1120px">
<h2> <i>Suppression&nbsp;&nbsp;des&nbsp; Véhicules </i></h2>

      <table  style="width: 388px; border-collapse: collapse;">
            <tr>
                <td style="width: 76px; height: 31px">
                    <asp:Image ID="img_error" runat="server" Height="16px" ImageUrl="~/images/error.gif"
                        Visible="False" Width="16px" /></td>
                <td style="width: 95px; height: 31px">
                    <asp:Image ID="img_succes" runat="server" ImageUrl="~/images/ok.gif" Visible="False" /></td>
                <td style="width: 3px; height: 31px">
                    <asp:Label ID="Lblerror" runat="server" ForeColor="Red" Visible="False" 
                        Width="323px"></asp:Label></td>
            </tr>
        </table>
        
 
           
<asp:Panel ID="Panel1" runat="server" Width="90%" BorderColor="Black" BorderWidth="1px" Height="278px">
      <table style="width: 103%">
        
      <tr>
          <td valign="top" >
       
           <table style="width: 863px; height: 271px; border-collapse: collapse;">
                 
                 <tr>
                 
                    <td>
                        <asp:Label ID="lbloption" runat="server" Font-Bold="True" Height="22px" Text=" Option " Width="135px"></asp:Label>
                    </td>
                     
                    <td >
                        <asp:RadioButton ID="RadMatricule" runat="server" ForeColor="Blue" Font-Size="Medium" Font-Names="Garamond"  GroupName="MyGroup" Text="Matricule" AutoPostBack="true" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    <asp:RadioButton ID="RadMarque" runat="server" Font-Size="Medium" Font-Names="Garamond" ForeColor="Blue" GroupName="MyGroup" Text="Marque" AutoPostBack="true" />
                    </td>
                   </tr>
                 
                 
                   <tr>
                    <td style="width: 163px">
                        <asp:Label ID="lblMarque" runat="server" Font-Bold="True" Height="22px" Text=" Marque " Width="135px"></asp:Label></td>
                    <td >
                        <asp:DropDownList ID="cbxMarque" runat="server" AutoPostBack="True" 
                            Visible="true" Width="158px" Enabled="False">
                        </asp:DropDownList>
                    </td>
                   </tr>
                   
                   
                   <tr>
                    <td style="width: 163px">
                        <asp:Label ID="lblMatricule" runat="server" Font-Bold="True" Height="22px" Text=" Matricule "
                            Width="135px"></asp:Label></td>
                    <td >
                        <asp:DropDownList ID="cbxMatricule" runat="server" AutoPostBack="true" 
                            Visible="true" Width="158px" EnableTheming="True" Enabled="False">
                        </asp:DropDownList>
                                     
                    </td>
                   </tr>
                 
                 
                   <tr>
                    <td style="width: 163px">
                         <asp:Label ID="lblNChassis" runat="server" Font-Bold="True" Height="22px" Text=" Numéro de châssis " Width="135px"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtbxNChassis" runat="server" Width="156px" Enabled="False"></asp:TextBox>
                    </td>
                   </tr>
                   
                   <tr>
                     <td style="width: 163px">
                      </td> 
                     
                       <td>
                       
                       <br /><br />
                        <asp:Button ID="btnsuppVeh" runat="server" Font-Bold="True" Height="26px" Text="Supprimer"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                               ForeColor="Blue" Visible="True"></asp:Button>
                               
                               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                            
                       <asp:Button ID="BtnEnd" runat="server" Font-Bold="True" Font-Names="Garamond" Height="26px" Width="99px" 
                               Font-Overline="False" Font-Size="Medium" ForeColor="blue" 
                               PostBackUrl="~/Vehicule.aspx" Text="Retour" />
                       </td>                     
                    </tr>
                    
                 </table>
          
          </td>
      </tr>
    </table>
          
</asp:Panel></center>


</asp:Content>
