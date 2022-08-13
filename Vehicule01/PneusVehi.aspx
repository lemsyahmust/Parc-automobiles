<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="MasterPage.Master" CodeBehind="PneusVehi.aspx.vb" Inherits="Vehicule01.WebForm2" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center>
<h2><i>Changement&nbsp; des&nbsp; Pneus&nbsp;</i></h2></center>
    
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
        ImageUrl="~/images/modifier.jpg" PostBackUrl="~/ModifPneus.aspx"  /> 
        <asp:ImageButton ID="ImageButton3" runat="server" 
        ImageUrl="~/images/supprimer.jpg" PostBackUrl="~/SupprimerPneus.aspx" />
<asp:ImageButton ID="ImageButton4" runat="server" Height="44px" 
    ImageUrl="~/images/pneus.jpg" PostBackUrl="~/MarquePneus.aspx" 
    Width="107px" />
    <asp:ImageButton ID="btnImpPneus" runat="server" Height="44px" 
        ImageUrl="~/images/imprimante-icone-6110-96.png" PostBackUrl="~/ImpPneus.aspx" 
        Width="107px" />
<br />
        
        <asp:Panel ID="Panel1" runat="server" Width="90%" BorderColor="Black" 
        BorderWidth="1px" Height="388px">
        
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
                                    <asp:Image ID="img_suppr" runat="server" ImageUrl="~/images/supprimer2.jpg" Visible="False" /></td>
                            </tr>
                     </table>
                     
                      <td align="center" valign="top">
                        <br />
                        
              <table style="width: 572px; height: 126px; border-collapse: collapse; margin-left: 0px;">
                     <tr>
                     <td>
                      <asp:Label ID="lblNPneus" runat="server" Font-Bold="True" Height="22px" 
                         Width="20px" BackColor="White" BorderColor="White" ForeColor="White" ></asp:Label></td>
                     <td>  
                     <asp:Label ID="lblNCons" runat="server" BackColor="White" BorderColor="White" 
                              Font-Bold="True" Height="22px" Width="5px" ForeColor="White"></asp:Label>
                     </td>
                     
                     
                       <td>
                       <asp:Label ID="lblSNTL" runat="server" Font-Bold="True" Height="22px"  Width="5px"></asp:Label>
                          
                          </td>
                                 
                     </tr>
                    
                      <caption>
                          &nbsp;
                         
                          <tr>
                              <td>
                                  <asp:Label ID="lblMatVehiP" runat="server" Font-Bold="True" Height="22px" 
                                      Text="Matricule du vehicule" Width="135px"></asp:Label>
                              </td>
                              <td style="width: 328px">
                                  &nbsp;&nbsp;&nbsp;&nbsp;
                                  <asp:DropDownList ID="cbxMatVehiP" runat="server" AutoPostBack="true" 
                                      Width="226px">
                                  </asp:DropDownList>
                                  <asp:TextBox ID="txtbxNVehi" runat="server" Height="17px" Width="1px" 
                                      ForeColor="White"></asp:TextBox>
                              </td>
                                 <td>
                       <asp:Label ID="lblSNTLRes" runat="server" Font-Bold="True" Height="22px"  Width="5px"></asp:Label>
                          
                          </td>
                          
                          </tr>
                          <tr>
                              <td>
                                  <asp:Label ID="lblRepaP" runat="server" Font-Bold="True" Height="22px" 
                                      Text="Garagiste" Width="99px"></asp:Label>
                              </td>
                              <td style="width: 328px">
                                  &nbsp;&nbsp;&nbsp;
                                  <asp:DropDownList ID="cbxRepaP" runat="server" AutoPostBack="true" 
                                      Width="226px">
                                  </asp:DropDownList>
                                  <asp:TextBox ID="txtbxNrep" runat="server" Height="17px" Width="1px" 
                                      ForeColor="White"></asp:TextBox>
                              </td>
                          </tr>
                          <tr>
                              <td>
                                  <asp:Label ID="lblKm" runat="server" Font-Bold="True" Height="22px" 
                                      Text="Kilometrage" Width="135px"></asp:Label>
                              </td>
                              <td style="width: 328px">
                                  <asp:TextBox ID="txtbxKm" runat="server" Height="17px" Width="221px"></asp:TextBox>
                              </td>
                          </tr>
                          <tr>
                              <td>
                                  <asp:Label ID="lblDateP" runat="server" Font-Bold="True" Height="22px" 
                                      Text="Date de changement" Width="135px"></asp:Label>
                              </td>
                              <td style="width: 328px">
                                  <asp:TextBox ID="txtbxDateP" runat="server" Height="17px" Width="221px"></asp:TextBox>
                              </td>
                          </tr>
                          <tr>
                              <td>
                                  <asp:Label ID="lblMarqP" runat="server" Font-Bold="True" Height="22px" 
                                      Text="Marque" Width="135px"></asp:Label>
                              </td>
                              <td style="width: 328px">
                                  &nbsp;&nbsp;&nbsp;
                                  <asp:DropDownList ID="cbxMarq" runat="server" AutoPostBack="true" Width="226px">
                                  </asp:DropDownList>
                                  <asp:TextBox ID="txtbxMarqP" runat="server" Height="17px" Width="1px" 
                                      ForeColor="White"></asp:TextBox>
                              </td>
                          </tr>
                          
                           <tr>
                              <td>
                                  <asp:Label ID="lblDimenssion" runat="server" Font-Bold="True" Height="22px" 
                                      Text="Réference" Width="135px"></asp:Label>
                              </td>
                              <td style="width: 328px">
                                  &nbsp;&nbsp;&nbsp;
                                  <asp:DropDownList ID="cbxRef" runat="server" AutoPostBack="true" Width="226px">
                                  </asp:DropDownList>
                                 
                              </td>
                          </tr>
                          
                          <tr>
                              <td>
                                  <asp:Label ID="lblQteP" runat="server" Font-Bold="True" Height="22px" 
                                      Text="Quantité" Width="135px"></asp:Label>
                              </td>
                              <td style="width: 328px" valign="top">
                                  <asp:DropDownList ID="cbxQteP" runat="server" Width="100px">
                                      <asp:ListItem>0</asp:ListItem>
                                      <asp:ListItem>1</asp:ListItem>
                                      <asp:ListItem>2</asp:ListItem>
                                      <asp:ListItem>3</asp:ListItem>
                                      <asp:ListItem>4</asp:ListItem>
                                  </asp:DropDownList>
                              </td>
                          </tr>
                          <tr>
                              <td>
                                  <asp:Label ID="lblSouche" runat="server" Font-Bold="True" Height="22px" 
                                      Text="Souche" Width="135px"></asp:Label>
                              </td>
                              <td style="width: 328px">
                                  <asp:TextBox ID="txtbxSouche" runat="server" Height="17px" Width="221px"></asp:TextBox>
                              </td>
                          </tr>
                          
                            <tr>
                              <td>
                                  <asp:Label ID="lblPrixP" runat="server" Font-Bold="True" Height="22px" 
                                      Text="Montant" Width="135px"></asp:Label>
                              </td>
                              <td style="width: 328px">
                                  <asp:TextBox ID="txtbxPrixP" runat="server" Height="17px" Width="221px"></asp:TextBox>
                              </td>
                          </tr>
                          
                          <tr>
                              <td>
                                  <asp:Label ID="lblNFactP" runat="server" Font-Bold="True" Height="22px" 
                                      Text="N° Facture" Width="135px"></asp:Label>
                              </td>
                              <td style="width: 328px">
                                  <asp:TextBox ID="txtbxNFactP" runat="server" Height="17px" Width="221px"></asp:TextBox>
                              </td>
                          </tr>
                        
                          <tr>
                              <td>
                                  &nbsp;</td>
                              <td style="width: 328px">
                                  <br />
                                  <br />
                                  <asp:Button ID="btnAjoutPneus" runat="server" Enabled="false" Font-Bold="True" 
                                      Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                                      Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                                      ForeColor="Blue" Height="22px" Text="Ajouter" Width="99px" />
                                  <asp:Button ID="btnsuppPneus" runat="server" Font-Bold="True" 
                                      Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                                      Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                                      ForeColor="Blue" Height="22px" Text="Supprimer" Visible="False" Width="99px" />
                                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                  <asp:Button ID="btnAnnulerPneus" runat="server" Font-Bold="True" 
                                      Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                                      Font-Size="Medium" ForeColor="Blue" Height="22px" Text="Annuler" Width="99px" />
                              </td>
                          </tr>
                     </caption>
                   
                    </table>
                        
        </td>
      
     </td>
     
        </tr>
        
        </table>
        <br />

        
        </asp:Panel>
     

</asp:Content>
