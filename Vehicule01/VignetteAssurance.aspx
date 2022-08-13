<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="VignetteAssurance.aspx.vb" Inherits="Vehicule01.WebForm32" 
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
        <asp:ImageButton ID="btnImpMarqPneus" runat="server" Height="44px" 
        ImageUrl="~/images/imprimante-icone-6110-96.png" 
        PostBackUrl="~/ImpVignetteAssurance.aspx" Width="107px" />
        
         <br />
<asp:Panel ID="Panel1" runat="server" Width="75%" BorderColor="Black" 
    BorderWidth="1px" Height="265px">
   
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
                         <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="True" 
                             BorderColor="Silver" BorderStyle="Outset" Font-Bold="True" 
                             ForeColor="#FF6600" Height="28px" RepeatDirection="Horizontal" 
                             Width="397px" Font-Names="Garamond" Font-Overline="False" Font-Size="Large" 
                             Font-Strikeout="False" Font-Underline="True">
                             <asp:ListItem>Vignette</asp:ListItem>
                             <asp:ListItem>Assurance</asp:ListItem>
                         </asp:RadioButtonList>
                                              
   <table style="width: 614px; height: 204px; border-collapse: collapse; margin-left: 0px;">
                         
                         <tr>
                            <td style="height: 5px">
                       <asp:Label ID="lblSNTL" runat="server" Font-Bold="True" Height="16px"  Width="5px"></asp:Label>
                          
                          </td>
                          
                             <td>
                       <asp:Label ID="lblSNTLRes" runat="server" Font-Bold="True" Height="22px"  Width="5px"></asp:Label>
                          
                          </td>
                          
                          
                         </tr>
                           <tr>
                     <td style="height: 20px">
                     <asp:Label ID="lblMatricule" runat="server" Font-Bold="True" Height="20px" Text="Matricule" Width="176px"></asp:Label>
                      </td> 
                     
                     <td style="width: 298px; height: 20px;">
                           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                           <asp:DropDownList ID="cbxMatricule" runat="server" AutoPostBack="true"  Width="226px">
                           </asp:DropDownList>                   
                           <asp:Label ID="lblNVehi" runat="server" Font-Bold="True" Height="20px" 
                               Width="16px"></asp:Label>
                     </td>
                  </tr>
                  
                             <tr>
                               <td style="height: 2px">
                           <asp:Label ID="lblTypeVehi" runat="server" Font-Bold="True" Height="20px" 
                                       Text="Type Vehicule" Width="176px" Visible="False"></asp:Label>
                               </td> 
                     
                               <td style="width: 298px; height: 2px;">
                           <asp:Label ID="lblTypeVehi1" runat="server" Font-Bold="True" Height="20px" 
                                       Width="176px" Font-Names="Garamond" Font-Size="Medium" ForeColor="Blue" 
                                       Visible="False"></asp:Label> 
                            </td>
                  </tr>
                  
                     <tr>
                     <td style="height: 1px">
                     <asp:Label ID="lblMontant" runat="server" Font-Bold="True" Height="20px" Text="Montant" Width="176px"></asp:Label>
                      </td> 
                     
                     <td style="width: 298px; height: 1px;">
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:TextBox ID="txtbxMontant" runat="server" Height="17px" Width="221px"></asp:TextBox>    
                     <asp:Label ID="Label1" runat="server" Font-Bold="True" Height="20px" Text="(Dhs)" 
                             Width="24px"></asp:Label>                 
                     </td>
                  </tr>
                  
                   <tr>
                     <td style="height: 2px">
                     <asp:Label ID="lbldate" runat="server" Font-Bold="True" Height="20px" Text="Date" Width="176px"></asp:Label>
                      </td> 
                     
                     <td style="width: 298px; height: 2px;">
                     <asp:TextBox ID="txtbxDate" runat="server" Height="17px" Width="221px"></asp:TextBox>                     
                     </td>
                  </tr>
                  
                  
               <tr>
                 <td style="height: 25px">
                 
                 </td>
                       <td style="width: 298px; height: 20px;">
                       <asp:Button ID="btnAjoutD" runat="server" Font-Bold="True" Height="22px" Text="Ajouter"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" Enabled="false"
                               ForeColor="Blue"></asp:Button>
                               
                           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            
                       <asp:Button ID="btnAnnulerD" runat="server" Font-Bold="True" Height="22px" Text="Quitter"
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
