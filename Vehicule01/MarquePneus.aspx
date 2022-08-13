<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="MarquePneus.aspx.vb" Inherits="Vehicule01.WebForm16" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center>
<h2><i>Marque &nbsp;&nbsp;de&nbsp;&nbsp; Pneu</i></h2></center>
    
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
        ImageUrl="~/images/modifier.jpg" PostBackUrl="~/ModifMarqPneus.aspx"  /> 
        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/images/supprimer.jpg" />
    <asp:ImageButton ID="btnImpMarqPneus" runat="server" Height="44px" 
        ImageUrl="~/images/imprimante-icone-6110-96.png" 
        PostBackUrl="~/ImpMarqPneus.aspx" Width="107px" />
<br />
<asp:Panel ID="Panel1" runat="server" Width="90%" BorderColor="Black" 
        BorderWidth="1px" Height="230px">

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
                                    <asp:Image ID="img_suppr" runat="server" ImageUrl="~/images/supprimer2.jpg" Visible="False" /></td>
                            </tr>
                     </table>
                     
                       <td align="center" valign="top">
                        <br />
   <table style="width: 663px; height: 126px; border-collapse: collapse; margin-left: 0px;">
   
                <tr>
                    <td>
                        <asp:Label ID="lblNPneus" runat="server" Font-Bold="True" Height="22px" Text="N° Série" Width="135px"></asp:Label></td>
                    <td >
                         <asp:Label ID="lblNSerie" runat="server" Font-Bold="True" Height="22px" Text="" Width="135px">  </asp:Label>                   
                        
                    </td>
               </tr>
               
               
               <tr>
                     <td>
                     <asp:Label ID="lblMarque" runat="server" Font-Bold="True" Height="20px" Text="Marque" Width="176px"></asp:Label>
                      </td> 
                     
                     <td>
                     <asp:TextBox ID="txtbxMarque" runat="server" Height="17px" Width="221px"></asp:TextBox>
                     <asp:DropDownList ID="cbxMarque" runat="server" AutoPostBack="true" Visible="false"  Width="226px">
                     </asp:DropDownList>
                     <asp:TextBox ID="txtbxNSerie" runat="server" Height="17px" Width="18px" 
                             Visible="false"></asp:TextBox>                                          
                     </td>
                  </tr>
                  
                   <tr>
                     <td>
                     <asp:Label ID="lblDimenssion" runat="server" Font-Bold="True" Height="20px" Text="Référence" Width="176px"></asp:Label>
                      </td> 
                     
                     <td>
                     <asp:TextBox ID="txtbxDimenssion" runat="server" Height="17px" Width="221px"></asp:TextBox>                     
                         <asp:DropDownList ID="cbxRef" runat="server" AutoPostBack="true" 
                             Visible="false" Width="226px">
                         </asp:DropDownList>
                     </td>
                  </tr>
                  
                   
                   <tr>
                     <td>
                     <asp:Label ID="lblPrix" runat="server" Font-Bold="True" Height="20px" Text="Prix / (pneus)" Width="176px"></asp:Label>
                      </td> 
                     
                     <td>
                     <asp:TextBox ID="Txtbxprix" runat="server" Height="17px" Width="221px"></asp:TextBox>                     
                     </td>
                  </tr>
                   
                   <tr>
                     <td>
                     <asp:Label ID="lbldesc" runat="server" Font-Bold="True" Height="20px" 
                             Text="Déscription" Width="160px"></asp:Label>
                      </td> 
                     
                     <td>
                     <asp:TextBox ID="txtbxdesc" runat="server" Height="17px" Width="221px"></asp:TextBox>                     
                     </td>
                  </tr>
                  
                  
               <tr>
               
                 <td>
                 
                 </td>
                       <td>
                       <br /><br />
                       <asp:Button ID="btnAjoutMPneus" runat="server" Font-Bold="True" Height="22px" Text="Ajouter"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                               ForeColor="Blue"></asp:Button>
                       <asp:Button ID="btnsuppMPneus" runat="server" Font-Bold="True" Height="22px" Text="Supprimer"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                               ForeColor="Blue" Visible="False"></asp:Button>
                               
                               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            
                       <asp:Button ID="btnAnnulerMPneus" runat="server" Font-Bold="True" Height="22px" Text="Retour"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" ForeColor="Blue" PostBackUrl="~/PneusVehi.aspx" ></asp:Button>
                       </td>                     
                    </tr>  
                                    
   
   </table>
       </td>             
                    </td>
                </tr>
</table>

</asp:Panel>
        
</asp:Content>
