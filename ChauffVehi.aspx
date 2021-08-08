<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="ChauffVehi.aspx.vb" Inherits="Vehicule01.WebForm5" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   
    <center>
<h2><i>Chauffeur</i></h2></center>
    
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
        ImageUrl="~/images/modifier.jpg" PostBackUrl="~/ModifChaufVehi.aspx" /> 
        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/images/supprimer.jpg" />
    <asp:ImageButton ID="btnImpChauffV" runat="server" Height="45px" 
        ImageUrl="~/images/imprimante-icone-6110-96.png" 
        PostBackUrl="~/ImpChauffeurV.aspx" Width="107px" />
    <br />
        
        <asp:Panel ID="Panel1" runat="server" Width="90%" BorderColor="Black" 
        BorderWidth="1px" Height="218px">
        
        
        <table style="width: 100%; height: 189px;">
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
                        
                      <table style="width: 482px; height: 162px; border-collapse: collapse;">
                         
                         <tr>
                    <td>
                        <asp:Label ID="lblCIN" runat="server" Font-Bold="True" Height="22px" Text="CIN"
                            Width="135px"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtbxCIN" runat="server" Height="17px" Width="221px"></asp:TextBox>
                        <asp:DropDownList ID="cbxCIN" runat="server" AutoPostBack="true" Visible="False" Width="226px">
                        </asp:DropDownList>
                                               
                    </td>
                    
                   </tr>
                   
                    <tr>
                    <td>
                        <asp:Label ID="lblNom" runat="server" Font-Bold="True" Height="22px" Text="Nom"
                            Width="135px"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtbxNom" runat="server" Height="17px" Width="221px"></asp:TextBox>
                                                                     
                    </td>
                    </tr>
                   
                    <tr>
                    <td>
                        <asp:Label ID="lblPrenom" runat="server" Font-Bold="True" Height="22px" Text="Prenom"
                            Width="135px"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtbxPrenom" runat="server" Height="17px" Width="221px"></asp:TextBox>
                                                                     
                    </td>
                    
                   </tr>
                   
                    <tr>
                    <td>
                        <asp:Label ID="lblNumP" runat="server" Font-Bold="True" Height="22px" Text="N° Permis"
                            Width="135px"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtbxNumPermis" runat="server" Height="17px" Width="221px"></asp:TextBox>
                                                                     
                    </td>
                    
                   </tr>
                   
                   
                    <tr>
                    <td>
                        <asp:Label ID="lblnDoti" runat="server" Font-Bold="True" Height="22px" Text="PPR"
                            Width="135px"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtbxNDoti" runat="server" Height="17px" Width="221px"></asp:TextBox>
                                                                     
                    </td>
                    
                   </tr>
                   
                    <tr>
                    <td>
                        <asp:Label ID="lblCat" runat="server" Font-Bold="True" Height="22px" Text="Categorie de permis"
                            Width="135px"></asp:Label></td>
                    <td >
                      <asp:TextBox ID="txtbxcatg" runat="server" Visible="false" Height="17px" Width="221px"></asp:TextBox>
                      <asp:DropDownList ID="cbxCatg" runat="server" AutoPostBack="false" Width="226px">
                                                  
                        </asp:DropDownList>
                                                                     
                    </td>
                    
                   </tr>
                  
                  
                  <tr>
                    <td>
                   </td>
                    <td >
                          <br />
                    <asp:Button ID="btnAjoutChauf" runat="server" Font-Bold="True" Height="22px" Text="Ajouter"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                               ForeColor="Blue"></asp:Button>
                                       
                    <asp:Button ID="btnsuppChauf" runat="server" Font-Bold="True" Height="22px" Text="Supprimer"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                               ForeColor="Blue" Visible="false"></asp:Button> 
                               
                               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            
                    <asp:Button ID="btnAnnulerChauf" runat="server" Font-Bold="True" Height="22px" Text="Annuler"
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
