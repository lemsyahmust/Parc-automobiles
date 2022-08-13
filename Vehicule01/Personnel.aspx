<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="Personnel.aspx.vb" Inherits="Vehicule01.WebForm28" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center>
<h2>Missionnaire</h2></center>
    
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
        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/modifier.jpg"/> 
        <asp:ImageButton ID="ImageButton3" runat="server" 
        ImageUrl="~/images/supprimer.jpg" PostBackUrl="~/MisePerso.aspx"/>
        <asp:ImageButton ID="btnImpPneus" runat="server" Height="44px" 
    ImageUrl="~/images/imprimante-icone-6110-96.png" Width="107px" 
    PostBackUrl="~/ImpPers.aspx" />
<br />
<asp:Panel ID="Panel1" runat="server" Width="90%" BorderColor="Black" 
        BorderWidth="1px" Height="341px">
 
 <table style="width: 100%; height: 347px;">
         
                <tr>
                    <td valign="top" >
                    
                      <table style="width: 58px; border-collapse: collapse;">
                     
                            <tr>
                                <td>
                                    <asp:Image ID="img_new" runat="server" ImageUrl="~/images/nouveau2.jpg" /></td>
                            </tr>
                            
                            <tr>
                                <td>
                                    <asp:Image ID="img_mod" runat="server" ImageUrl="~/images/modifier2.jpg" Visible="False" /></td>
                            </tr>
                            
                            <tr>
                                <td>
                                    <asp:Image ID="img_suppr" runat="server" ImageUrl="~/images/supprimer2.jpg" Visible="False" /></td>
                            </tr>
                            
                            
                     </table>
                     
                     <td align="center" valign="top">
                        <br />
                        
                         <table style="width: 689px; height: 311px; border-collapse: collapse; margin-left: 0px;">
                       
                                                               
                      <tr>
                     
                    <td>
                        <asp:Label ID="lblNom" runat="server" Font-Bold="True" Height="22px" Text="Nom"
                            Width="135px"></asp:Label></td>
                    <td >
                        <asp:DropDownList ID="cbxNom" runat="server" AutoPostBack="true"  Width="231px" 
                            Visible="false">
                        </asp:DropDownList>
                        <br />
                        <asp:TextBox ID="txtbxNom" runat="server" Height="17px" Width="226px"></asp:TextBox>
                   </td>
                   </tr>
                   
                   <tr>
                     
                    <td>
                        <asp:Label ID="lblPrenom" runat="server" Font-Bold="True" Height="22px" Text="Prenom"
                            Width="135px"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtbxPrenom" runat="server" Height="17px" Width="226px"></asp:TextBox>
                   </td>
                   </tr>
                      
                      <tr>
                     
                    <td>
                        <asp:Label ID="lblEmail" runat="server" Font-Bold="True" Height="22px" Text="Email"
                            Width="135px"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtbxEmail" runat="server" Height="17px" Width="220px"></asp:TextBox>
                   </td>
                   </tr>
                   
                   <tr>
                     
                    <td>
                        <asp:Label ID="lblTel" runat="server" Font-Bold="True" Height="22px" Text="Tel"
                            Width="135px"></asp:Label></td>
                    <td >
                       <asp:TextBox ID="txtbxTel" runat="server" Height="17px" Width="220px"></asp:TextBox>
                   </td>
                   </tr>
                   
                   
                   <tr>
                     
                    <td>
                        <asp:Label ID="lblPoste" runat="server" Font-Bold="True" Height="22px" Text="Poste"
                            Width="135px"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtbxPoste" runat="server" Height="17px" Width="220px"></asp:TextBox>
                   </td>
                   </tr>
                   
                   
                   <tr>
                     
                    <td>
                        <asp:Label ID="lblGroup" runat="server" Font-Bold="True" Height="22px" Text="Groupe"
                            Width="135px"></asp:Label></td>
                    <td >
                       <asp:TextBox ID="txtbxgroupe" runat="server" Height="17px" Width="220px"></asp:TextBox>
                   </td>
                   </tr>
                   
                   <tr>
                 <td>
                 
                 </td>
                       <td>
                       <br />
                       <asp:Button ID="btnAjoutPE" runat="server" Font-Bold="True" Height="22px" Text="Ajouter"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" Enabled="false"
                               ForeColor="Blue"></asp:Button>
                               
                          <asp:Button ID="btnModifierPE" runat="server" Font-Bold="True" Height="22px" Text="Modifier"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                               ForeColor="Blue" Visible="False"></asp:Button>       
                               
                       <asp:Button ID="btnsuppPE" runat="server" Font-Bold="True" Height="22px" Text="Supprimer"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                               ForeColor="Blue" Visible="False"></asp:Button>
                               
                               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            
                       <asp:Button ID="btnAnnulerPE" runat="server" Font-Bold="True" Height="22px" Text="Retour"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" ForeColor="Blue" PostBackUrl="~/Mission.aspx" ></asp:Button>
                       </td>                     
                    </tr>
                    
                         </table>  
                     </td>   
                    
                    </td>
                </tr>
 </table>
                    
</asp:Panel>

</asp:Content>
