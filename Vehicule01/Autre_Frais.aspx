<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="Autre_Frais.aspx.vb" Inherits="Vehicule01.WebForm30" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center>
<h2><i>Autre&nbsp;&nbsp;Frais</i></h2></center>


        <table  style="width: 389px; border-collapse: collapse;">
            <tr>
                <td style="width: 76px; height: 31px">
                    <asp:Image ID="img_error" runat="server" Height="16px" ImageUrl="~/images/error.gif" Visible="False" Width="16px" /></td>
                <td style="width: 95px; height: 31px">
                    <asp:Image ID="img_succes" runat="server" ImageUrl="~/images/ok.gif" Visible="False" /></td>
                <td style="width: 3px; height: 31px">
                    <asp:Label ID="Lblerror" runat="server" ForeColor="Red" Visible="False" Width="649px"></asp:Label></td>
            </tr>
        </table>
        
         <asp:ImageButton ID="ImageButton1" runat="server" 
    ImageUrl="~/images/nouveau.jpg" Width="107px" />
         <asp:ImageButton ID="ImageButton2" runat="server"  ImageUrl="~/images/modifier.jpg"  /> 
         <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/images/supprimer.jpg" />
         <asp:ImageButton ID="btnImpRep" runat="server" Height="44px" 
    ImageUrl="~/images/imprimante-icone-6110-96.png"  Width="107px" 
    PostBackUrl="~/ImpAutreF.aspx" />
        
         <br />
        
        
         <asp:Panel ID="Panel1" runat="server" Width="90%" BorderColor="Black" 
        BorderWidth="1px" Height="311px">
        
         <table style="width: 100%; height: 325px;">
                <tr>
                    <td valign="top" >
                     <table style="width: 58px; border-collapse: collapse;">
                            <tr>
                                <td>
                                    <asp:Image ID="img_new" runat="server" ImageUrl="~/images/nouveau2.jpg" /></td>
                            </tr>
                                     
                                 <tr>
                                <td>
                                    <asp:Image ID="img_mod" runat="server" ImageUrl="~/images/modifier2.jpg" Visible="false" /></td>
                            </tr>     
                                                      
                            <tr>
                                <td>
                                    <asp:Image ID="img_suppr" runat="server" ImageUrl="~/images/supprimer2.jpg" Visible="False" /></td>
                            </tr>
                     </table>
                    </td>
                    
                  <td align="center" valign="top">
                        <br />
                        
                         <table style="width: 510px; height: 253px; border-collapse: collapse;">
                         
                         
                          <tr>
                    <td><asp:Label ID="lblNRepT" runat="server" Font-Bold="True" Height="22px" Text=" " Width="5px"></asp:Label>
                        </td>
                    <td >
                                               
                        <asp:Label ID="lblncons" runat="server" Font-Bold="True" Height="22px" Text=" " Width="5px"></asp:Label>
                        
                          </td>
                  </tr>
                  
                         
                                    
                 <tr>
                    <td>
                        <asp:Label ID="lblMatricule" runat="server" Font-Bold="True" Height="22px" Text="Matricule" Width="135px"></asp:Label></td>
                    <td >
                        
                        <asp:DropDownList ID="cbxMatricule" runat="server" AutoPostBack="true" Visible="true" Width="226px">
                        </asp:DropDownList>
                        <asp:TextBox ID="txtbxNVehi" runat="server" Height="17px" Width="14px"></asp:TextBox>                   
                    </td>
                  </tr>
                         
                                  
                 <tr>
                    <td>
                        <asp:Label ID="lblReparateur" runat="server" Font-Bold="True" Height="22px" Text="Mécanicien" Width="135px"></asp:Label></td>
                    <td >
                        
                        <asp:DropDownList ID="cbxReparateur" runat="server" AutoPostBack="true" Visible="true" Width="226px">
                        </asp:DropDownList>
                        <asp:TextBox ID="txtbxReparateur" runat="server" Height="17px" Width="14px"></asp:TextBox>                   
                    </td>
                    
                   </tr>
                   
                         
                 <tr>
                    <td>
                        <asp:Label ID="lblTypeRep" runat="server" Font-Bold="True" Height="22px" Text="Intervention" Width="135px"></asp:Label></td>
                    <td >
                        
                        <asp:DropDownList ID="cbxTypeRep" runat="server" AutoPostBack="true" Visible="true" Width="226px">
                        </asp:DropDownList>
                        <asp:TextBox ID="txtbxTypeRep" runat="server" Height="17px" Width="14px"></asp:TextBox>                   
                    </td>
                    
                   </tr>
              
              
               <tr>
                    <td>
                        <asp:Label ID="lblRef" runat="server" Font-Bold="True" Height="22px" Text="Réference" Width="135px"></asp:Label></td>
                    <td >
                      
                        <asp:TextBox ID="txtbxRef" runat="server" Height="17px" Width="221px"></asp:TextBox>                   
                    </td>
                    
                   </tr>
                   
                   <tr>
                    <td>
                        <asp:Label ID="lblDescp" runat="server" Font-Bold="True" Height="22px" Text="Description" Width="135px"></asp:Label></td>
                    <td >
                      
                        <asp:TextBox ID="txtbxDescp" runat="server" Height="17px" Width="221px"></asp:TextBox>                   
                    </td>
                    
                   </tr>
                   
                   
                   <tr>
                    <td>
                        <asp:Label ID="lblDate" runat="server" Font-Bold="True" Height="22px" Text="Date" Width="135px"></asp:Label></td>
                    <td >
                        
                        <asp:TextBox ID="txtbxDate" runat="server" Height="17px" Width="221px"></asp:TextBox>
                    </td>
                    
                   </tr>
                      
                               
                 <tr>
                    <td>
                        <asp:Label ID="lblPrix" runat="server" Font-Bold="True" Height="22px" Text="Montant" Width="135px"></asp:Label></td>
                    <td >
                      
                        <asp:TextBox ID="txtbxPrix" runat="server" Height="17px" Width="221px"></asp:TextBox>                   
                    </td>
                    
                   </tr>
                   
                                                 
                 <tr>
                    <td>
                   </td>
                    <td >
                 
                        <asp:Button ID="btnAjoutReparation" runat="server" Font-Bold="True" Height="22px" Text="Ajouter"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" Enabled="false"
                               ForeColor="Blue"></asp:Button>
                               
                               <asp:Button ID="btnModifierReparation" runat="server" Font-Bold="True" Height="22px" Text="Modifier"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" Enabled="false"
                               ForeColor="Blue" Visible="false"></asp:Button> 
                                       
                         <asp:Button ID="btnsuppReparation" runat="server" Font-Bold="True" Height="22px" Text="Supprimer"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" Enabled="false"
                               ForeColor="Blue" Visible="false"></asp:Button> 
                               
                               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            
                       <asp:Button ID="btnAnnulerReparation" runat="server" Font-Bold="True" Height="22px" Text="Annuler"
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
