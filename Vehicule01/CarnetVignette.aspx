<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="CarnetVignette.aspx.vb" Inherits="Vehicule01.WebForm24" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center>
     <h2><i>Vignette/Assurance</i></h2>
    </center>

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

        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/nouveau.jpg"   />
        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/modifier.jpg"  /> 
        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/images/supprimer.jpg" />
        <asp:ImageButton ID="btnImpMarqPneus" runat="server" Height="44px" 
        ImageUrl="~/images/imprimante-icone-6110-96.png" 
        PostBackUrl="~/ImpCarnetVign.aspx" Width="107px" />
        
         <br />
<asp:Panel ID="Panel1" runat="server" Width="81%" BorderColor="Black" BorderWidth="1px" Height="287px">
   
    <table style="width: 100%; height: 211px;">
                <tr>
                    <td valign="top" >
                    
                      <table style="width: 58px; border-collapse: collapse;">
                            <tr>
                                <td>
                                    <asp:Image ID="img_new" runat="server" ImageUrl="~/images/nouveau2.jpg" /></td>
                            </tr>
                            
                            <tr>
                            <td>
                                    <asp:Image ID="img_mod" runat="server" ImageUrl="~/images/modifier2.jpg" Visible="false" />
                            </td>
                            </tr>
                            
                            <tr>
                                <td>
                                    <asp:Image ID="img_suppr" runat="server" ImageUrl="~/images/supprimer2.jpg" Visible="False" /></td>
                            </tr>
                     </table>
                                     
                    </td>
                    
                     <td align="center" valign="top">
                        <br />
                        
                         <table style="width: 614px; height: 253px; border-collapse: collapse; margin-left: 0px;">
                         
                           <tr>
                     <td>
                     <asp:Label ID="lblNconv" runat="server" Font-Bold="True" Height="20px" Text="N° Convention" Width="176px"></asp:Label>
                      </td> 
                     
                     <td style="width: 298px">
                     <asp:TextBox ID="txtbxNConv" runat="server" Height="17px" Width="221px"></asp:TextBox>                     
                     </td>
                  </tr>
                  
                             <tr>
                               <td>
                           <asp:Label ID="lblNCarnet" runat="server" Font-Bold="True" Height="20px" Text="N° Carnet" Width="176px"></asp:Label>
                               </td> 
                     
                               <td style="width: 298px">
                           <asp:Label ID="lblNcarnetTTT" runat="server" Font-Bold="True" Height="20px" Text="" Width="176px"></asp:Label> 
                           <asp:DropDownList ID="cbxNCarnet" runat="server" AutoPostBack="true" Visible="false"  Width="226px">
                           </asp:DropDownList>                      
                             </td>
                  </tr>
                      
                                       
                      <tr>
                     <td>
                     <asp:Label ID="lblvign" runat="server" Font-Bold="True" Height="20px" Text="Vignette" Width="176px"></asp:Label>
                      </td> 
                     
                     <td style="width: 298px">
                      <asp:DropDownList ID="cbxVignette" runat="server" AutoPostBack="true" Visible="True"  Width="226px">
                      </asp:DropDownList>
                     <asp:TextBox ID="txtbxNVign" runat="server" Height="17px" Width="5px"></asp:TextBox>                     
                     </td>
                  </tr>
                     
                      <tr>
                    <td>
                        <asp:Label ID="lblSouche" runat="server" Font-Bold="True" Height="22px" Text="Souche" Width="135px"></asp:Label></td>
                    <td style="width: 298px" >
                      
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      
                        <asp:TextBox ID="txtbxSouche" runat="server" Height="17px" Width="221px"></asp:TextBox>                   
                                       
                    </td>
                    
                    <td>
                        <asp:Button ID="btnAjoutSouche" runat="server" Text="Ajouter" Width="61px" />
                    </td>
                   </tr>
                   
                                    
                     <tr>
                     <td>
                     <asp:Label ID="lblMontant" runat="server" Font-Bold="True" Height="20px" Text="Montant" Width="176px"></asp:Label>
                      </td> 
                     
                     <td style="width: 298px">
                     <asp:TextBox ID="txtbxMontant" runat="server" Height="17px" Width="221px"></asp:TextBox>    
                     <asp:Label ID="Label1" runat="server" Font-Bold="True" Height="20px" Text="(Dh)" 
                             Width="24px"></asp:Label>                 
                     </td>
                  </tr>
                  
                  <tr>
                     <td>
                     <asp:Label ID="lbldate" runat="server" Font-Bold="True" Height="20px" Text="Date" Width="176px"></asp:Label>
                      </td> 
                     
                     <td style="width: 298px">
                     <asp:TextBox ID="txtbxDate" runat="server" Height="17px" Width="221px"></asp:TextBox>                     
                     </td>
                  </tr>
                  
                                  
                  <tr>
                 <td>
                 
                 </td>
                       <td style="width: 298px">
                       <br /><br />
                       <asp:Button ID="btnAjoutCarnet" runat="server" Font-Bold="True" Height="22px" Text="Ajouter"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" Enabled="false"
                               ForeColor="Blue"></asp:Button>
                               
                       <asp:Button ID="btnsuppCarnet" runat="server" Font-Bold="True" Height="22px" Text="Supprimer"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" Enabled="false"
                               ForeColor="Blue" Visible="False"></asp:Button>
                               
                         <asp:Button ID="btnModifierCarnet" runat="server" Font-Bold="True" Height="22px" Text="Modifier"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" Enabled="false"
                               ForeColor="Blue" Visible="False"></asp:Button>        
                               
                               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            
                       <asp:Button ID="btnAnnulerCarnet" runat="server" Font-Bold="True" Height="22px" Text="Quitter"
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
