<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="TypeReparation.aspx.vb" Inherits="Vehicule01.WebForm19" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center>
<h2><i>Intervention</i></h2></center>
    
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
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/nouveau.jpg" />
        <asp:ImageButton ID="ImageButton2" runat="server" 
    ImageUrl="~/images/modifier.jpg" PostBackUrl="~/ModifTypeRepTion.aspx"  /> 
        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/images/supprimer.jpg"  />
        <asp:ImageButton ID="btnImpTypRep" runat="server" Height="44px" 
        ImageUrl="~/images/imprimante-icone-6110-96.png" 
        PostBackUrl="~/ImpTypeRepTion.aspx" Width="107px" />
    <br />
        
        <asp:Panel ID="Panel1" runat="server" Width="90%" BorderColor="Black" 
        BorderWidth="1px" Height="177px">
        
         <table style="width: 100%; height: 159px;">
                <tr>
                    <td valign="top" >
                    
                     <table style="width: 58px; border-collapse: collapse;">
                            <tr>
                                <td>
                                    <asp:Image ID="img_new" runat="server" ImageUrl="~/images/nouveau2.jpg" /></td>
                            </tr>
                            
                            <tr>
                                <td>
                                    <asp:Image ID="img_suppr" runat="server" ImageUrl="~/images/supprimer2.jpg" Visible="False" /></td>
                            </tr>
                     </table>
                     
                      <td align="center" valign="top">
                        <br />
                        
              <table style="width: 663px; height: 74px; border-collapse: collapse; margin-left: 0px;">
              
               <asp:Label ID="lblNReparation" runat="server" Font-Bold="True" Height="22px" Width="5px" BackColor="White" BorderColor="White" ForeColor="black" ></asp:Label>
                              
                <tr>
                     
                    <td>
                        <asp:Label ID="lblReparation" runat="server" Font-Bold="True" Height="22px" Text="Intervention"
                            Width="135px"></asp:Label></td>
                    <td >
                        <asp:DropDownList ID="cbxReparation" runat="server" AutoPostBack="true"  Width="210px" Visible="false">
                        </asp:DropDownList>
                        <asp:TextBox ID="txtbxReparation" runat="server" Height="17px" Width="210px"></asp:TextBox>
                   </td>
                   </tr>
                                 
                       <tr>
                 <td>
                 
                 </td>
                       <td>
                       <br /><br />
                       <asp:Button ID="btnAjoutReparation" runat="server" Font-Bold="True" Height="22px" Text="Ajouter" Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" Enabled="false"
                               ForeColor="Blue"></asp:Button>
                       <asp:Button ID="btnsuppReparation" runat="server" Font-Bold="True" Height="22px" Text="Supprimer"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                               ForeColor="Blue" Visible="False"></asp:Button>
                               
                               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            
                       <asp:Button ID="btnAnnulerReparation" runat="server" Font-Bold="True" Height="22px" Text="Retour"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" ForeColor="Blue" PostBackUrl="~/Réparation.aspx" ></asp:Button>
                       </td>                     
                    </tr>
                              
                   
              </table>
           </td>
        </td>
      </tr>
    </table>
 </asp:Panel>
              


</asp:Content>
