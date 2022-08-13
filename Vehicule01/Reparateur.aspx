<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="Reparateur.aspx.vb" Inherits="Vehicule01.WebForm7" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center>
<h2><i>Garagiste</i></h2></center>
    
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
        ImageUrl="~/images/modifier.jpg" PostBackUrl="~/ModifRepaVehi.aspx" /> 
        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/images/supprimer.jpg" />
    <asp:ImageButton ID="btnImpRep" runat="server" Height="44px" 
        ImageUrl="~/images/imprimante-icone-6110-96.png" 
        PostBackUrl="~/ImpReparateur.aspx" Width="107px" />
    <br />
        
        
        <asp:Panel ID="Panel1" runat="server" Width="90%" BorderColor="Black" BorderWidth="1px" Height="206px">
       
      <table style="width: 100%; height: 189px;">
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
                  </td>
                      <td align="center" valign="top">
                        <br />
                        
                      <table style="width: 482px; height: 162px; border-collapse: collapse;">
                         
                         <tr>
                    <td>
                        <asp:Label ID="lblreparateur" runat="server" Font-Bold="True" Height="22px" Text="Garagiste" Width="135px"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtbxRep" runat="server" Height="17px" Width="221px"></asp:TextBox>
                        <asp:DropDownList ID="cbxRep" runat="server" AutoPostBack="true" Visible="False" Width="226px">
                        </asp:DropDownList>
                                               
                    </td>
                    
                   </tr>
                   
                    <tr>
                    <td>
                        <asp:Label ID="lblAdress" runat="server" Font-Bold="True" Height="22px" Text="Adresse" Width="135px"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtbxAdress" runat="server" Height="17px" Width="221px"></asp:TextBox>
                                                                     
                    </td>
                    </tr>
                   
                    <tr>
                    <td>
                        <asp:Label ID="lblTel" runat="server" Font-Bold="True" Height="22px" Text="Tel" Width="135px"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtbxTel" runat="server" Height="17px" Width="221px"></asp:TextBox>
                                                                     
                    </td>
                    
                   </tr>
                   
                    <tr>
                    <td>
                        <asp:Label ID="lblFax" runat="server" Font-Bold="True" Height="22px" Text="Fax" Width="135px"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtbxFax" runat="server" Height="17px" Width="221px"></asp:TextBox>
                                                                     
                    </td>
                    
                   </tr>
          
                 <tr>
                    <td>
                   </td>
                    <td >
                 
                        <asp:Button ID="btnAjoutRepa" runat="server" Font-Bold="True" Height="22px" Text="Ajouter"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                               ForeColor="Blue"></asp:Button>
                                       
                         <asp:Button ID="btnsuppRepa" runat="server" Font-Bold="True" Height="22px" Text="Supprimer"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                               ForeColor="Blue" Visible="false"></asp:Button> 
                               
                               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            
                       <asp:Button ID="btnAnnulerRepa" runat="server" Font-Bold="True" Height="22px" Text="Retour"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" ForeColor="Blue" PostBackUrl="~/Réparation.aspx" ></asp:Button>
                                                            
                    </td>
                    
                   </tr>
                   
                   
                   </table>
                   </td>
                   </tr>
                  
                   </table>
                  
        </asp:Panel>
        
        
</asp:Content>
