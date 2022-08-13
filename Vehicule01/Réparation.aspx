<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="MasterPage.Master" CodeBehind="Réparation.aspx.vb" Inherits="Vehicule01.WebForm25" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center>
<h2><i>Réparations</i></h2></center>


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
        ImageUrl="~/images/modifier.jpg"  /> 
        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/images/supprimer.jpg" />
    <asp:ImageButton ID="ImageButton4" runat="server" Height="44px" 
    ImageUrl="~/images/Ouverture-du-service-de-reparation-des-consoles-de-Jeux.gif" 
    PostBackUrl="~/TypeReparation.aspx" Width="107px" />
    <asp:ImageButton ID="ImageButton5" runat="server" Height="44px" 
    ImageUrl="~/images/Mecanicien.gif" PostBackUrl="~/Reparateur.aspx" 
    Width="107px" />
    <asp:ImageButton ID="btnImpRep" runat="server" Height="44px" 
        ImageUrl="~/images/imprimante-icone-6110-96.png"  Width="107px" 
    PostBackUrl="~/ImpReparation.aspx" Visible="False" />
        
         <br />
        
        
        <asp:Panel ID="Panel1" runat="server" Width="90%" BorderColor="Black" 
        BorderWidth="1px" Height="440px">
        
         <table style="width: 89%; height: 325px;">
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
                        
                         <table style="width: 557px; height: 329px; border-collapse: collapse; margin-right: 0px;">
                         
                          <tr>
                    <td><asp:Label ID="lblNRepT" runat="server" Font-Bold="True" Height="22px"  
                            Width="5px" ForeColor="White"></asp:Label>
                        </td>
                    <td style="width: 328px" >
                                               
                        <asp:Label ID="lblncons" runat="server" Font-Bold="True" Height="22px"  
                            Width="5px" ForeColor="White"></asp:Label>
                        
                          </td>
                          <td>
                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:Label ID="lblSNTL" runat="server" Font-Bold="True" Height="22px"  Width="5px"></asp:Label>
                          
                          </td>
                  </tr>
                  
                         
                 <tr>
                    <td>
                        <asp:Label ID="lblMatricule" runat="server" Font-Bold="True" Height="22px" Text="Matricule" Width="135px"></asp:Label></td>
                    <td style="width: 328px" >
                        
                        <asp:DropDownList ID="cbxMatricule" runat="server" AutoPostBack="true" Visible="true" Width="226px">
                        </asp:DropDownList>
                        <asp:TextBox ID="txtbxNVehi" runat="server" Height="17px" Width="1px"></asp:TextBox>                   
                    </td>
                    
                         <td>
                             <asp:Label ID="lblSNTLRes" runat="server" Font-Bold="True" Height="22px" 
                                 Width="16px"></asp:Label>
                     </td>
                          
                  </tr>
                  
                   <tr>
                    <td>
                        <asp:Label ID="lblNReparation" runat="server" Font-Bold="True" Height="22px" Text="N° Reparation" Width="135px" Visible="false"></asp:Label></td>
                    <td style="width: 328px" >
                        
                        <asp:DropDownList ID="cbxNReparation" runat="server" AutoPostBack="true" Visible="false" Width="226px">
                        </asp:DropDownList>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    
                         <td>
                             &nbsp;</td>
                          
                  </tr>
                         
                                  
                 <tr>
                    <td>
                        <asp:Label ID="lblReparateur" runat="server" Font-Bold="True" Height="22px" Text="Garagiste" Width="135px"></asp:Label></td>
                    <td style="width: 328px" >
                        
                        <asp:DropDownList ID="cbxReparateur" runat="server" AutoPostBack="true" Visible="true" Width="226px">
                        </asp:DropDownList>
                        <asp:TextBox ID="txtbxReparateur" runat="server" Height="17px" Width="1px" 
                            ForeColor="White"></asp:TextBox>                   
                    </td>
                    
                   </tr>
                   
                         
                 <tr>
                    <td>
                        <asp:Label ID="lblTypeRep" runat="server" Font-Bold="True" Height="22px" 
                            Text="Interventions" Width="135px"></asp:Label></td>
                    <td style="width: 328px" >
                        &nbsp;
                                   <asp:ListBox ID="ListBox1" runat="server" Font-Size="X-Small" 
                            Height="100px" Width="115px"></asp:ListBox>
                                   <asp:Button ID="Button3" runat="server" Text="&gt;&gt;" Width="30px" 
                            Font-Size="X-Small" />
                                   <asp:Button ID="Button5" runat="server" Text="&lt;&lt;" Width="30px" 
                            Font-Size="X-Small" />
                                   <asp:ListBox ID="ListBox2" runat="server" Font-Size="X-Small" 
                            Height="100px" SelectionMode="Multiple" Width="115px" AutoPostBack="True"></asp:ListBox>
                            
                    </td>
                    
                   </tr>
              
              
               <tr>
                    <td>
                        <asp:Label ID="lblRef" runat="server" Font-Bold="True" Height="22px" Text="Réference" Width="135px"></asp:Label></td>
                    <td style="width: 328px" >
                      
                        <asp:TextBox ID="txtbxRef" runat="server" Height="17px" Width="221px"></asp:TextBox>                   
                    </td>
                    
                   </tr>
                   
                   <tr>
                    <td>
                        <asp:Label ID="lblDescp" runat="server" Font-Bold="True" Height="22px" Text="Description" Width="135px"></asp:Label></td>
                    <td style="width: 328px" >
                      
                        <asp:TextBox ID="txtbxDescp" runat="server" Height="17px" Width="221px"></asp:TextBox>                   
                    </td>
                    
                   </tr>
                   
                   
                   <tr>
                    <td>
                        <asp:Label ID="lblDate" runat="server" Font-Bold="True" Height="22px" Text="Date" Width="135px"></asp:Label></td>
                    <td style="width: 328px" >
                        
                        <asp:TextBox ID="txtbxDate" runat="server" Height="17px" Width="221px"></asp:TextBox>
                    </td>
                    
                   </tr>
                   
                   
                    <tr>
                    <td>
                        <asp:Label ID="lblSouche" runat="server" Font-Bold="True" Height="22px" Text="Souche" Width="135px"></asp:Label></td>
                    <td style="width: 328px" >
                      
                        <asp:TextBox ID="txtbxSouche" runat="server" Height="17px" Width="221px"></asp:TextBox>                   
                                       
                    </td>
                    
                    <td>
                        &nbsp;</td>
                   </tr>
                   
                     
                     <tr>
                    <td>
                        <asp:Label ID="lblPrix" runat="server" Font-Bold="True" Height="22px" 
                            Text="Montant" Width="135px"></asp:Label></td>
                    <td style="width: 328px" >
                      
                        <asp:TextBox ID="txtbxPrix" runat="server" Height="17px" Width="221px"></asp:TextBox>                   
                    </td>
                    
                   </tr>
                      
                         
                <tr>
                    <td>
                        <asp:Label ID="lblNFact" runat="server" Font-Bold="True" Height="22px" Text="N° Facture" Width="135px"></asp:Label></td>
                    <td style="width: 328px" >
                      
                        <asp:TextBox ID="txtbxNFact" runat="server" Height="17px" Width="221px"></asp:TextBox>                   
                    </td>
                    
                   </tr>
                   
                         
                 
                   
                 <tr>
                    <td>
                   </td>
                    <td style="width: 328px" >
                 
                        <br />
                 
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
