<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="MarqueVehi.aspx.vb" Inherits="Vehicule01.WebForm4" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
<h2><i>Marque&nbsp; de&nbsp; Véhicule</i></h2></center>
    
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
        ImageUrl="~/images/modifier.jpg" PostBackUrl="~/ModifMarqueVehi.aspx" /> 
        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/images/supprimer.jpg" />
    <asp:ImageButton ID="btnImpMarqVehi" runat="server" Height="44px" 
        ImageUrl="~/images/imprimante-icone-6110-96.png" 
        PostBackUrl="~/ImpMarqVehi.aspx" Width="107px" />
<br />
        <asp:Panel ID="Panel1" runat="server" Width="90%" BorderColor="Black" 
        BorderWidth="1px" Height="206px">
      
        <table style="width: 100%">
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
                     </td>
                      <td align="center" valign="top">
                        <br />
                        
                      <table style="width: 482px; height: 126px; border-collapse: collapse;">
                         
                          <tr>
                    <td>
                        <asp:Label ID="lblmarq" runat="server" Font-Bold="True" Height="22px" Text="Nom de la marque"
                            Width="135px"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtbxmarq" runat="server" Height="17px" Width="221px"></asp:TextBox>
                        <asp:DropDownList ID="cbxMarq" runat="server" AutoPostBack="true" Visible="False" Width="226px">
                        </asp:DropDownList>
                        
                        
                    </td>
                   </tr>
                                        
                     <tr>
                    <td>
                        <asp:Label ID="lblNBRPlace" runat="server" Font-Bold="True" Height="22px" Text="Nombre de place"
                            Width="99px"></asp:Label></td>  
                            
                             <td >
                        <asp:TextBox ID="txtbxNbrPlace" runat="server" Height="17px" Width="221px"></asp:TextBox>
                 
                   </td>
                      
                    </tr>
                    
                    <tr>
                     <td>
                      </td> 
                     
                       <td>
                       <asp:Button ID="btnAjout" runat="server" Font-Bold="True" Height="22px" Text="Ajouter"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                               ForeColor="Blue"></asp:Button>
                       <asp:Button ID="btnsupp" runat="server" Font-Bold="True" Height="22px" Text="Supprimer"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                               ForeColor="Blue" Visible="False"></asp:Button>
                               
                               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            
                       <asp:Button ID="btnAnnuler" runat="server" Font-Bold="True" Height="22px" Text="Annuler"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" ForeColor="Blue" ></asp:Button>
                       </td>                     
                    </tr>
                    </table>
        
        </td>
        </tr>
        </table>
        
        
        </asp:Panel>
        
</asp:Content>
