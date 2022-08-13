<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="Mission.aspx.vb" Inherits="Vehicule01.WebForm27" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center>
<h2><i>Missions</i></h2></center>
    
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
        <asp:ImageButton ID="ImageButton3" runat="server" 
        ImageUrl="~/images/supprimer.jpg" PostBackUrl="~/SuppMission.aspx"/>
        <asp:ImageButton ID="btnImpPneus" runat="server" Height="44px" 
    ImageUrl="~/images/imprimante-icone-6110-96.png" Width="107px" 
    PostBackUrl="~/ImpMission.aspx" />
<br />

 <asp:Panel ID="Panel1" runat="server" Width="86%" BorderColor="Black" 
    BorderWidth="1px" Height="529px">
 
 <table style="width: 89%; height: 520px; margin-right: 0px;">
         
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
                        
                   <table style="width: 664px; height: 470px; border-collapse: collapse; margin-left: 0px;">
                    <tr>
                    <td>                     
                    <asp:Label ID="lblNConsMI" runat="server" Font-Bold="True" Height="18px" 
                            Width="5px" BackColor="White"  BorderColor="White" ForeColor="White" ></asp:Label>        
                    </td>
                       <td style="width: 392px">
                       <asp:Label ID="lblSNTL" runat="server" Font-Bold="True" Height="22px"  Width="5px" 
                               ForeColor="White"></asp:Label>
                          
                          </td>
                          
                             <td>
                       <asp:Label ID="lblSNTLRes" runat="server" Font-Bold="True" Height="22px"  Width="5px"></asp:Label>
                          
                          </td>
                          
                    </tr>
                    
                                   <caption>
                                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblNMiss" runat="server" BackColor="white" 
                                           BorderColor="White" Font-Bold="True" ForeColor="Black" Height="18px" 
                                           Width="5px"></asp:Label><tr>
                                           <td>
                                               <asp:Label ID="lblTypeVehi" runat="server" Font-Bold="True" Height="22px" 
                                                   Text="Type vehicule" Width="118px"></asp:Label>
                                           </td>
                                           <td style="width: 392px">
                                               <asp:DropDownList ID="cbxTypeVehi" runat="server" AutoPostBack="true" 
                                                   Width="226px">
                                               </asp:DropDownList>
                                               <asp:Label ID="lblTypeVehi1" runat="server" Font-Bold="True" ForeColor="White" 
                                                   Height="22px" Width="1px"></asp:Label>
                                           </td>
                                       </tr>
                                       <tr>
                                           <td>
                                               <asp:Label ID="lblMatriculeMI" runat="server" Font-Bold="True" Height="22px" 
                                                   Text="Matricule" Width="135px"></asp:Label>
                                           </td>
                                           <td style="width: 392px">
                                               &nbsp;&nbsp;&nbsp;
                                               <asp:DropDownList ID="cbxMatVehiMI" runat="server" AutoPostBack="true" 
                                                   Width="226px">
                                               </asp:DropDownList>
                                               <asp:TextBox ID="txtbxNVehiMI" runat="server" ForeColor="White" Height="17px" 
                                                   Width="1px"></asp:TextBox>
                                           </td>
                                       </tr>
                                       <tr>
                                           <td>
                                               <asp:Label ID="lblchaufMI" runat="server" Font-Bold="True" Height="22px" 
                                                   Text="Chauffeur" Width="135px"></asp:Label>
                                           </td>
                                           <td style="width: 392px">
                                               &nbsp;&nbsp;&nbsp;
                                               <asp:DropDownList ID="cbxChaufMI" runat="server" AutoPostBack="true" 
                                                   Width="226px">
                                               </asp:DropDownList>
                                               <asp:TextBox ID="txtbxNChauffMI" runat="server" ForeColor="White" Height="17px" 
                                                   Width="1px"></asp:TextBox>
                                           </td>
                                       </tr>
                                       <tr>
                                           <td>
                                               <asp:Label ID="lblTypeD" runat="server" Font-Bold="True" Height="22px" 
                                                   Text="Type de dotation" Width="135px"></asp:Label>
                                           </td>
                                           <td style="width: 392px">
                                               <asp:Label ID="lblFraisMI" runat="server" Font-Bold="True" Height="22px" 
                                                   Text="Mission" Width="226px"></asp:Label>
                                           </td>
                                       </tr>
                                       <tr>
                                           <td>
                                               <asp:Label ID="lblsouche" runat="server" Font-Bold="True" Height="22px" 
                                                   Text="Ordre de mission" Width="135px"></asp:Label>
                                           </td>
                                           <td style="width: 392px">
                                               <asp:TextBox ID="txtbxSouche" runat="server" Height="17px" Width="226px"></asp:TextBox>
                                           </td>
                                       </tr>
                                       <tr>
                                           <td>
                                               <asp:Label ID="lblDateD" runat="server" Font-Bold="True" Height="22px" 
                                                   Text="Date début mission" Width="135px"></asp:Label>
                                           </td>
                                           <td style="width: 392px">
                                               <asp:TextBox ID="txtbxDateD" runat="server" Height="17px" Width="226px"></asp:TextBox>
                                           </td>
                                       </tr>
                                       <tr>
                                           <td>
                                               <asp:Label ID="lblDateF" runat="server" Font-Bold="True" Height="22px" 
                                                   Text="Date retour mission" Width="135px"></asp:Label>
                                           </td>
                                           <td style="width: 392px">
                                               <asp:TextBox ID="txtbxNDateF" runat="server" Height="17px" Width="226px"></asp:TextBox>
                                           </td>
                                       </tr>
                                       <tr>
                                           <td>
                                               <asp:Label ID="lblMontant" runat="server" Font-Bold="True" Height="22px" 
                                                   Text="Montant" Width="68px"></asp:Label>
                                           </td>
                                           <td style="width: 392px">
                                               <asp:TextBox ID="txtbxMontant" runat="server" Height="17px" Width="226px"></asp:TextBox>
                                           </td>
                                       </tr>
                                       <tr>
                                           <td>
                                               <asp:Label ID="lblDestination" runat="server" Font-Bold="True" Height="22px" 
                                                   Text="Destination" Width="95px"></asp:Label>
                                               <asp:Label ID="lblVille" runat="server" Font-Bold="True" Font-Names="Garamond" 
                                                   Font-Size="Medium" Font-Strikeout="False" Font-Underline="True" 
                                                   ForeColor="#FF3300" Height="22px" Text="Ville" Visible="False" Width="39px"></asp:Label>
                                           </td>
                                           <td style="width: 392px">
                                               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                               <asp:TextBox ID="txtbxVille" runat="server" BorderColor="#FF3300" Height="16px" 
                                                   Visible="false" Width="226px"></asp:TextBox>
                                               <asp:DropDownList ID="cbxDesti" runat="server" AutoPostBack="true" 
                                                   Width="226px">
                                               </asp:DropDownList>
                                               <asp:TextBox ID="txtbxNDesct" runat="server" Height="17px" Width="3px"></asp:TextBox>
                                               <asp:Button ID="Button1" runat="server" Height="22px" Text="+" 
                                                   ToolTip="Saissir  une  nouvelle vile" Width="26px" />
                                           </td>
                                       </tr>
                                       <tr>
                                           <td>
                                               <asp:Label ID="lblPerso" runat="server" Font-Bold="True" Height="34px" 
                                                   Text="Personnel accompagnant" Width="135px"></asp:Label>
                                           </td>
                                           <td style="width: 392px">
                                               &nbsp;
                                               <asp:ListBox ID="ListBox1" runat="server" Font-Size="X-Small" Height="100px" 
                                                   Width="105px"></asp:ListBox>
                                               <asp:Button ID="Button3" runat="server" Text="&gt;&gt;" Width="33px" />
                                               <asp:Button ID="Button5" runat="server" Text="&lt;&lt;" Width="33px" />
                                               <asp:ListBox ID="ListBox2" runat="server" Font-Size="X-Small" Height="100px" 
                                                   SelectionMode="Multiple" Width="105px"></asp:ListBox>
                                               <asp:Button ID="Button2" runat="server" Height="22px" 
                                                   PostBackUrl="~/Personnel.aspx" Text="+" 
                                                   ToolTip="Saissir  un  nouveau personnel accompagné" Width="26px" />
                                           </td>
                                       </tr>
                                       <tr>
                                           <td>
                                               <asp:Label ID="lblObs" runat="server" Font-Bold="True" Height="22px" 
                                                   Text="Observations" Width="135px"></asp:Label>
                                           </td>
                                           <td style="width: 392px">
                                               <asp:TextBox ID="txtbxObse" runat="server" Height="17px" Width="226px"></asp:TextBox>
                                           </td>
                                       </tr>
                                       <tr>
                                           <td>
                                           </td>
                                           <td style="width: 392px">
                                               <br />
                                               <asp:Button ID="btnAjoutMI" runat="server" Enabled="false" Font-Bold="True" 
                                                   Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                                                   Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                                                   ForeColor="Blue" Height="22px" Text="Ajouter" Width="99px" />
                                               <asp:Button ID="btnsuppMI" runat="server" Font-Bold="True" Font-Italic="True" 
                                                   Font-Names="Garamond" Font-Overline="False" Font-Size="Medium" 
                                                   Font-Strikeout="False" Font-Underline="False" ForeColor="Blue" Height="22px" 
                                                   Text="Supprimer" Visible="False" Width="99px" />
                                               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                               <asp:Button ID="btnAnnulerMI" runat="server" Font-Bold="True" 
                                                   Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                                                   Font-Size="Medium" ForeColor="Blue" Height="22px" Text="Quitter" Width="99px" />
                                               <br />
                                           </td>
                                       </tr>
                       </caption>
                                                                                                          
       </table>
 
</td>
                               
 </td>

 </tr>

 </table>
  
 </asp:Panel>

</asp:Content>
