<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="Vehicule.aspx.vb" Inherits="Vehicule01.WebForm12" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center>
<h2> <i>Identification&nbsp; du&nbsp; Véhicule </i></h2></center>
    
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
        
        
        <asp:ImageButton ID="ImageButton1" runat="server"  ImageUrl="~/images/nouveau.jpg" />
        <asp:ImageButton ID="ImageButton2" runat="server"  ImageUrl="~/images/modifier.jpg" /> 
        <asp:ImageButton ID="ImageButton3" runat="server"  ImageUrl="~/images/supprimer.jpg" PostBackUrl="~/SupprimerVehi.aspx" />
        
        <asp:Panel ID="Panel1" runat="server" Width="90%" BorderColor="Black" 
        BorderWidth="1px" Height="371px">
        
         <table style="width: 100%; height: 386px;">
         <tr>
           <td valign="top" >
          
           <table style="width: 58px; border-collapse: collapse;">
                            <tr>
                                <td>
                                    <asp:Image ID="img_new" runat="server" ImageUrl="~/images/nouveau2.jpg" /></td>
                            </tr>
                            
                            <tr>
                                <td>
                                    <asp:Image ID="img_suppr" runat="server" ImageUrl="~/images/modifier2.jpg" Visible="False" /></td>
                            </tr>
           </table>
          
          
          <td align="center" valign="top">  <br />
          
           <asp:Label ID="Label1" runat="server" Font-Bold="True" Height="22px" Width="4px" 
                  ForeColor="White"></asp:Label>
                            
                 <table style="width: 676px; height: 300px; border-collapse: collapse;">
                 
                   <tr>
                    <td style="width: 181px">
                        <asp:Label ID="lblMatricule" runat="server" Font-Bold="True" Height="22px" Text=" Matricule "
                            Width="135px"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtbxMatricule" runat="server" Width="226px"></asp:TextBox>
                        <asp:DropDownList ID="cbxMatricule" runat="server" AutoPostBack="True" 
                            Visible="false" Width="226px" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False">
                        </asp:DropDownList>
                    </td>
                   </tr>
                 
                   <tr>
                    <td style="width: 181px">
                        <asp:Label ID="lblMarque" runat="server" Font-Bold="True" Height="22px" Text=" Marque "
                            Width="135px"></asp:Label></td>
                    <td >
                        &nbsp;&nbsp;&nbsp;
                     <asp:TextBox ID="txtbxMarqueV" runat="server" Width="226px"></asp:TextBox>
                     
                        <asp:DropDownList ID="cbxMarque" runat="server" AutoPostBack="True" 
                            Visible="false" Width="226px" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False">
                        </asp:DropDownList>
                        <asp:TextBox ID="txtbxNMarque" runat="server" Width="5px"></asp:TextBox>
                    </td>
                   </tr>
                   
                   
                   <tr>
                    <td style="width: 181px">
                        <asp:Label ID="lblNbrPlace" runat="server" Font-Bold="True" Height="22px" Text=" Nombre Places "
                            Width="135px"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtbxNbrP" runat="server" Width="226px"></asp:TextBox>
                    </td>
                   </tr>
                   
                   
                   
                     <tr>
                    <td style="width: 181px">
                        <asp:Label ID="lblNChassis" runat="server" Font-Bold="True" Height="22px" Text=" N° châssis "
                            Width="135px"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtbxNChassis" runat="server" Width="226px"></asp:TextBox>
                    </td>
                   </tr>
                   
                     <tr>
                    <td style="width: 181px">
                        <asp:Label ID="lblNMoteur" runat="server" Font-Bold="True" Height="22px" Text=" N° moteur "
                            Width="135px"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtbxNmoteur" runat="server" Width="224px"></asp:TextBox>
                    </td>
                   </tr>
                   
                     <tr>
                    <td style="width: 181px">
                        <asp:Label ID="lblCategorie" runat="server" Font-Bold="True" Height="22px" Text=" Catégorie "
                            Width="135px"></asp:Label></td>
                    <td >
                        &nbsp;
                        <asp:DropDownList ID="cbxCategorie" runat="server" AutoPostBack="true" 
                            Visible="True" Width="226px">
                        </asp:DropDownList>
                        <asp:TextBox ID="txtbxNcategorie" runat="server" Width="5px" ForeColor="White"></asp:TextBox>
                        
                    </td>
                   </tr>
                   
                   
                     <tr>
                    <td style="width: 181px">
                        <asp:Label ID="lblcarburant" runat="server" Font-Bold="True" Height="22px" Text=" Carburant "
                            Width="135px"></asp:Label></td>
                    <td >
                        &nbsp;
                        <asp:DropDownList ID="cbxCarburant" runat="server" AutoPostBack="true" 
                            Visible="true" Width="226px">
                        </asp:DropDownList>
                        <asp:TextBox ID="txtbxNcarburant" runat="server" Width="5px" ForeColor="White"></asp:TextBox>
                    </td>
                   </tr>
                   
                     <tr>
                    <td style="width: 181px">
                        <asp:Label ID="lblKilom" runat="server" Font-Bold="True" Height="22px" Text=" Kilométrage "
                            Width="135px"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtbxKilom" runat="server" Width="226px"></asp:TextBox>
                    </td>
                   </tr>
                   
                   
                     <tr>
                    <td style="width: 181px">
                        <asp:Label ID="lblDatCirc" runat="server" Font-Bold="True" Height="22px" Text=" Date de mise en circulation "
                            Width="164px"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtbxDatCirc" runat="server" Width="226px"></asp:TextBox>
                    </td>
                   </tr>
                   
                   
                  <tr>
                     <td style="width: 181px">
                      </td> 
                     
                       <td>
                       
                       <br />
                       <asp:Button ID="btnAjoutVeh" runat="server" Font-Bold="True" Height="22px" Text="Ajouter"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" Enabled="false"
                               ForeColor="Blue"></asp:Button>
                       <asp:Button ID="btnModifVeh" runat="server" Font-Bold="True" Height="22px" Text="Modifier"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" Enabled="false"
                               ForeColor="Blue" Visible="false"></asp:Button> 
                               
                               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            
                       <asp:Button ID="btnAnnulerVeh" runat="server" Font-Bold="True" Height="22px" Text="Annuler"
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
