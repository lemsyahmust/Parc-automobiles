<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="SNTL.aspx.vb" Inherits="Vehicule01.WebForm31" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center>
<h2> <i> La Société Nationale des Transports et de Logistique </i></h2></center>
    
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
    <asp:ImageButton ID="btnImpAff" runat="server" Height="44px" 
        ImageUrl="~/images/imprimante-icone-6110-96.png" Width="107px" 
        PostBackUrl="~/ImpSNTL.aspx" />
    <br />


 <asp:Panel ID="Panel1" runat="server" Width="90%" BorderColor="Black" 
        BorderWidth="1px" Height="145px">
        
         <table style="width: 91%">
         <tr>
          <td valign="top" >
          
                <table style="width: 58px; border-collapse: collapse;">
                            <tr>
                                <td>
                                    <asp:Image ID="img_new" runat="server" ImageUrl="~/images/nouveau2.jpg" /></td>
                            </tr>
                            
               </table>
               
               <td align="center" valign="top">
                        <br />
                   <table style="width: 788px; height: 111px; border-collapse: collapse;">
                   
                    <tr>
                    <td>
                        <asp:Label ID="lblDate" runat="server" Font-Bold="True" Height="22px" Text="Date"
                            Width="135px"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtbxDate" runat="server" Width="226px"></asp:TextBox>
                    </td>
                   </tr>               
                   
                     <tr>
                    <td>
                        <asp:Label ID="lblMontant" runat="server" Font-Bold="True" Height="22px" Text="Montant"
                            Width="135px"></asp:Label></td>
                    <td >
                        <asp:TextBox ID="txtbxMontant" runat="server" Width="226px"></asp:TextBox>
                   </td>
                   </tr>           
                   
                    <tr>
                     <td>
                      </td> 
                     
                       <td>
                       
                       <asp:Button ID="btnAjout" runat="server" Font-Bold="True" Height="22px" Text="Ajouter"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" ForeColor="Blue"></asp:Button>
                           
                               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            
                       <asp:Button ID="btnQuitter" runat="server" Font-Bold="True" Height="22px" Text="Quitter"
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
