<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="AdepenseV.aspx.vb" Inherits="Vehicule01.WebForm26" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center>
<h2><i>Dotation&nbsp; en&nbsp; Carburant</i></h2></center>
    
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
        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/images/supprimer.jpg"/>
        <asp:ImageButton ID="btnImpPneus" runat="server" Height="44px" 
    ImageUrl="~/images/imprimante-icone-6110-96.png" Width="107px" 
    PostBackUrl="~/ImpDepenseV.aspx" />
<br />

 <asp:Panel ID="Panel1" runat="server" Width="90%" BorderColor="Black" 
        BorderWidth="1px" Height="438px">
 
                          
         <table style="width: 100%; height: 413px;">
         
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
                        
          <table style="width: 689px; height: 368px; border-collapse: collapse; margin-left: 0px;">
                    <tr>
                    <td style="height: 3px">
                    <asp:Label ID="lblNConsD" runat="server" Font-Bold="True" Height="18px" Width="5px" BackColor="white"  BorderColor="White" ForeColor="Black" ></asp:Label>        
 
                    </td>
                       <td style="height: 3px">
                       <asp:Label ID="lblSNTL" runat="server" Font-Bold="True" Height="22px"  Width="5px"></asp:Label>
                          
                          </td>
                          
                             <td>
                       <asp:Label ID="lblSNTLRes" runat="server" Font-Bold="True" Height="22px"  Width="5px"></asp:Label>
                          
                          </td>
                          
                          
                    </tr>
                     
                     <tr>
                     
                    <td style="height: 20px">
                        <asp:Label ID="lblMatricule" runat="server" Font-Bold="True" Height="17px" Text="Matricule"
                            Width="75px"></asp:Label></td>
                    <td style="height: 20px" >
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="cbxMatVehiP" runat="server" AutoPostBack="true" 
                            Width="226px">
                        </asp:DropDownList>
                        <asp:TextBox ID="txtbxNVehi" runat="server" Height="17px" Width="10px"></asp:TextBox>
                        &nbsp;&nbsp;
                        <asp:Label ID="lblNCarb" runat="server" BackColor="White" BorderColor="White" 
                            Font-Bold="True" ForeColor="Black" Height="18px" Width="5px"></asp:Label>
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
                     
                    <td style="height: 20px">
                        <asp:Label ID="lblchauffeur" runat="server" Font-Bold="True" Height="16px" 
                            Text="Chauffeur" Width="135px"></asp:Label></td>
                    <td style="height: 20px" >
                         &nbsp;&nbsp;&nbsp;
                         <asp:DropDownList ID="cbxChauf" runat="server" AutoPostBack="true" 
                             Width="226px">
                         </asp:DropDownList>
                         <asp:TextBox ID="txtbxNChauf" runat="server" Height="17px" Width="10px"></asp:TextBox>
                   </td>
                   </tr>
                   
                    <tr>
                     
                    <td style="height: 26px">
                        <asp:Label ID="lblMontant" runat="server" Font-Bold="True" Height="17px" Text="Montant de la dotation"
                            Width="135px"></asp:Label></td>
                    <td style="height: 26px" >
                        <asp:TextBox ID="txtbxMontant" runat="server" Height="17px" Width="226px"></asp:TextBox>
                   </td>
                   </tr>
                     
                      <tr>
                     <td style="height: 23px">
                        <asp:Label ID="lbldateD" runat="server" Font-Bold="True" Height="16px" Text="Date"
                            Width="135px"></asp:Label></td>
                    <td style="height: 23px" >
                        <asp:TextBox ID="txtbxDate" runat="server" Height="17px" Width="226px"></asp:TextBox>
                        <asp:DropDownList ID="cbxdate" runat="server" AutoPostBack="true" 
                            Visible="false" Width="226px">
                        </asp:DropDownList>
                   </td>
                   </tr>
                       
                        
                     <tr>
                     
                    <td style="height: 26px">
                        <asp:Label ID="lblSouche" runat="server" Font-Bold="True" Height="16px" Text="Souche"
                            Width="135px"></asp:Label></td>
                    <td style="height: 26px" >
                       <asp:TextBox ID="txtbxSouche" runat="server" Height="17px" Width="226px"></asp:TextBox>
                        <td style="height: 26px">
                            <asp:Label ID="lblCalNbrKm" runat="server" Font-Bold="True" Height="22px" 
                                Width="67px" ForeColor="Black"></asp:Label>
                        </td>
                   </td>
                   </tr>
                    
                                 
                    <tr>
                     
                    <td style="height: 20px">
                        <asp:Label ID="lblKm" runat="server" Font-Bold="True" Height="16px" Text="Kilometrage"
                            Width="135px"></asp:Label></td>
                    <td style="height: 20px" >
                        <asp:TextBox ID="txtbxKm" runat="server" Height="17px" Width="226px" 
                            AutoPostBack="True"></asp:TextBox>
                   </td>
                   </tr>
                                      
                     <tr>
                     
                    <td style="height: 20px">
                        <asp:Label ID="lblobs" runat="server" Font-Bold="True" Height="18px" Text="Observations"
                            Width="135px"></asp:Label></td>
                    <td style="height: 20px" >
                       <asp:TextBox ID="txtbxObsv" runat="server" Height="17px" Width="226px"></asp:TextBox>
                     
                   </td>
                   </tr>
                   
                   
                    <tr>
                     
                    <td style="height: 20px">
                        </td>
                    <td style="height: 20px" >
                        <br />
                        <asp:Button ID="btnAjoutD" runat="server" Enabled="false" Font-Bold="True" 
                            Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                            Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                            ForeColor="Blue" Height="22px" Text="Ajouter" Width="99px" />
                        <asp:Button ID="btnModifierD" runat="server" Font-Bold="True" 
                            Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                            Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                            ForeColor="Blue" Height="22px" Text="Modifier" Visible="False" Width="99px" />
                        <asp:Button ID="btnsuppD" runat="server" Font-Bold="True" Font-Italic="True" 
                            Font-Names="Garamond" Font-Overline="False" Font-Size="Medium" 
                            Font-Strikeout="False" Font-Underline="False" ForeColor="Blue" Height="22px" 
                            Text="Supprimer" Visible="False" Width="99px" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                        <asp:Button ID="btnAnnulerD" runat="server" Font-Bold="True" Font-Italic="True" 
                            Font-Names="Garamond" Font-Overline="False" Font-Size="Medium" ForeColor="Blue" 
                            Height="22px" Text="Annuler" Width="99px" />
                   </td>
                   </tr>    
                       
                        
         </table>
</td>
</td>
</tr>
</table>


</asp:Panel>
                     
</asp:Content>
