<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="Vidange.aspx.vb" Inherits="Vehicule01.WebForm22" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center>
<h2><i>Vidanges</i></h2></center>

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
        
 <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/nouveau.jpg" 
        style="width: 107px" />
        <asp:ImageButton ID="ImageButton3" runat="server" 
        ImageUrl="~/images/supprimer.jpg" 
    PostBackUrl="~/Supprimervidange.aspx" Width="107px" />
    <asp:ImageButton ID="btnImpPneus" runat="server" Height="44px" 
        ImageUrl="~/images/imprimante-icone-6110-96.png" 
        PostBackUrl="~/ImpVidange.aspx" Width="107px" />
<br />

 <asp:Panel ID="Panel1" runat="server" Width="91%" BorderColor="Black" 
        BorderWidth="1px" Height="394px">
 
 <table style="width: 100%; height: 375px;">
                <tr>
                    <td valign="top" >
                    <table style="width: 58px; border-collapse: collapse;">
                            <tr>
                                <td>
                                    <asp:Image ID="img_new" runat="server" ImageUrl="~/images/nouveau2.jpg" /></td>
                            </tr>
                            
                            <tr>
                            <td>
                            <asp:Image ID="img_modif" runat="server" ImageUrl="~/images/modifier2.jpg" Visible="false" />
                            </td>
                            </tr>
                            
                            <tr>
                                <td>
                                    <asp:Image ID="img_suppr" runat="server" ImageUrl="~/images/supprimer2.jpg" Visible="False" /></td>
                            </tr>
                     </table>
                     
                     <td align="center" valign="top">
                        <br />
                        
                        <table style="width: 634px; height: 126px; border-collapse: collapse; margin-left: 0px;">
                        
                        <tr>
                        <td style="height: 1px">  <asp:Label ID="lblNsérie" runat="server" Font-Bold="True" 
                                Height="27px" Width="5px" 
                                BackColor="White" BorderColor="White" ForeColor="White"></asp:Label>                   </td>
                        <td style="height: 1px"> <asp:Label ID="lblNCons" runat="server" Font-Bold="True" 
                                Height="22px" Width="5px" BackColor="White" BorderColor="White" 
                                ForeColor="White" ></asp:Label>        
                    </td>
                       <td>
                       <asp:Label ID="lblSNTL" runat="server" Font-Bold="True" Height="22px"  Width="36px"></asp:Label>
                          
                          </td>
                        </tr>
                    
                              
                     
                     <tr>
                     
                    <td>
                        <asp:Label ID="lblMatVehiH" runat="server" Font-Bold="True" Height="22px" Text="Matricule du vehicule"
                            Width="135px"></asp:Label></td>
                    <td style="width: 393px" >
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="cbxMatVehiH" runat="server" AutoPostBack="true"  Width="226px">
                        </asp:DropDownList>
                        <asp:TextBox ID="txtbxNVehiH" runat="server" Height="17px" Width="1px" 
                            ForeColor="White"></asp:TextBox>
                   </td>
                   
                      <td>
                       <asp:Label ID="lblSNTLRes" runat="server" Font-Bold="True" Height="22px"  
                              Width="40px"></asp:Label>
                          
                          </td>
                          
                   </tr>
                   
                     <tr>
                     
                    <td style="height: 1px">
                        <asp:Label ID="lblmarq" runat="server" Font-Bold="True" Height="16px" 
                            Text="Type Vehicule" Visible="False"
                            Width="150px"></asp:Label></td>
                    <td style="height: 1px" >
                         <asp:Label ID="lblMMarq" runat="server" Font-Bold="True" Height="16px" 
                             Width="135px" Visible="False" Font-Italic="False" Font-Names="Garamond" 
                             Font-Size="Medium" ForeColor="Blue"></asp:Label>
                   </td>
                   </tr>
                   
                   <tr>
                    <td>
                        <asp:Label ID="lblRepaH" runat="server" Font-Bold="True" Height="22px" Text="Garagiste" Width="99px"></asp:Label></td>  
                            
                             <td style="width: 393px" >
                                 &nbsp;&nbsp;&nbsp;
                       <asp:DropDownList ID="cbxRepaH" runat="server" AutoPostBack="true"  Width="226px">
                       </asp:DropDownList>
                       <asp:TextBox ID="txtbxNreH" runat="server" Height="17px" Width="1px" ForeColor="White"></asp:TextBox> 
                       
                             </td>
                      
                    </tr>
                    
                         <tr>
                     <td>
                     <asp:Label ID="lblKm" runat="server" Font-Bold="True" Height="22px" Text="Kilometrage" Width="135px"></asp:Label>
                      </td> 
                     
                     <td style="width: 393px">
                     <asp:TextBox ID="txtbxKm" runat="server" Height="17px" Width="221px"></asp:TextBox>                     
                     </td>
                  </tr>
                                                  
                    
                    <tr>
                     <td>
                     <asp:Label ID="lblDateH" runat="server" Font-Bold="True" Height="22px" 
                             Text="Date Vidange" Width="135px"></asp:Label>
                      </td> 
                     
                     <td style="width: 393px">
                     <asp:TextBox ID="txtbxDateH" runat="server" Height="17px" Width="221px"></asp:TextBox>                     
                     </td>
                  </tr>
                  
                  
                 
                  <tr>
                     <td>
                     <asp:Label ID="lblNature" runat="server" Font-Bold="True" Height="22px" Text="Nature vidange" Width="135px"></asp:Label>
                      </td> 
                     
                     <td style="width: 393px">
                         &nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="cbxNature" runat="server" AutoPostBack="true"  Width="226px">
                            <asp:ListItem>Vidange Simple</asp:ListItem>
                            <asp:ListItem>Vidange Complet</asp:ListItem>
                        </asp:DropDownList>
                        <asp:TextBox ID="txtbxNature" runat="server" Height="17px" Width="5px"></asp:TextBox>                     
                     </td>
                  </tr>
                  
                  <tr>
                     <td>
                     <asp:Label ID="lblNbrKM" runat="server" Font-Bold="True" Height="22px" Text="Nombre de Km" Width="135px"></asp:Label>
                      </td> 
                     
                     <td style="width: 393px">
                     <asp:TextBox ID="txtbxNbrKm" runat="server" Height="17px" Width="221px" 
                             AutoPostBack="True"></asp:TextBox>                     
                     </td>
                     <td>
                    <asp:Label ID="lblCalNbrKm" runat="server" Font-Bold="True" Height="22px" 
                             Width="67px" ForeColor="White"></asp:Label>
</td>
                  </tr>
                  
                  <tr>
                     <td>
                     <asp:Label ID="lblSouche" runat="server" Font-Bold="True" Height="22px" Text="Souche" Width="135px"></asp:Label>
                      </td> 
                     
                     <td style="width: 393px">
                     <asp:TextBox ID="txtbxSouche" runat="server" Height="17px" Width="221px" 
                             AutoPostBack="True"></asp:TextBox>                     
                     </td>
                     
                  </tr>
                  
                  
                   <tr>
                     <td>
                     <asp:Label ID="lblPrixH" runat="server" Font-Bold="True" Height="22px" Text="Montant" Width="135px"></asp:Label>
                      </td> 
                     
                     <td style="width: 393px">
                     <asp:TextBox ID="txtbxPrixH" runat="server" Height="17px" Width="221px"></asp:TextBox>                     
                     </td>
                  </tr>
                  
                  
                    <tr>
                     <td>
                     <asp:Label ID="lblNFactH" runat="server" Font-Bold="True" Height="22px" Text="N° Facture" Width="135px"></asp:Label>
                      </td> 
                     
                     <td style="width: 393px">
                     <asp:TextBox ID="txtbxNFactH" runat="server" Height="17px" Width="221px"></asp:TextBox> 
                      <asp:DropDownList ID="cbxFact" runat="server" AutoPostBack="true"  Width="226px" Visible="false" >
                        </asp:DropDownList>                    
                     </td>
                  </tr>
             
              <tr>
                 <td>
                 
                     &nbsp;</td>
                       <td style="width: 393px">
                       <br />
                       <asp:Button ID="btnAjoutHuile" runat="server" Font-Bold="True" Height="22px" Text="Ajouter" Enabled="false"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                               ForeColor="Blue"></asp:Button>
                       <asp:Button ID="btnsuppHuile" runat="server" Font-Bold="True" Height="22px" Text="Supprimer"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                               ForeColor="Blue" Visible="False"></asp:Button>
                               
                      <asp:Button ID="btnModifHuile" runat="server" Font-Bold="True" Height="22px" Text="Modifier"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" Enabled="false"
                               ForeColor="Blue" Visible="False"></asp:Button>
                                        
                               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            
                       <asp:Button ID="btnAnnulerHuile" runat="server" Font-Bold="True" Height="22px" Text="Quitter"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" ForeColor="Blue" ></asp:Button>
                       </td>                     
                    </tr>
                    
                   </table>
                   
                     </td>
                    </td>
               </tr>
               
</table>                    
 
 </asp:Panel>
</asp:Content>
