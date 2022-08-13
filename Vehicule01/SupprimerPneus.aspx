<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="SupprimerPneus.aspx.vb" Inherits="Vehicule01.WebForm15" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<center style="width: 1120px">
<h2> <i>Suppression des Pneus</i></h2>

      <table  style="width: 388px; border-collapse: collapse;">
            <tr>
                <td style="width: 76px; height: 31px">
                    <asp:Image ID="img_error" runat="server" Height="16px" ImageUrl="~/images/error.gif"
                        Visible="False" Width="16px" /></td>
                <td style="width: 95px; height: 31px">
                    <asp:Image ID="img_succes" runat="server" ImageUrl="~/images/ok.gif" Visible="False" /></td>
                <td style="width: 3px; height: 31px">
                    <asp:Label ID="Lblerror" runat="server" ForeColor="Red" Visible="False" 
                        Width="323px"></asp:Label></td>
            </tr>
        </table>
        
        <asp:Panel ID="Panel1" runat="server" Width="90%" BorderColor="Black" BorderWidth="1px" Height="278px">
        
        <table style="width: 103%">
        
        <tr>
          <td valign="top" >
              <table style="width: 863px; height: 271px; border-collapse: collapse;">
              
               <tr>
                 
                    <td>
                        <asp:Label ID="lbloption" runat="server" Font-Bold="True" Height="22px" Text=" Option " Width="135px"></asp:Label>
                    </td>
                     
                    <td >
                        <asp:RadioButton ID="RadPneus" runat="server" ForeColor="Blue" Font-Size="Medium" Font-Names="Garamond"  GroupName="MyGroup" Text="Numéro Pneus" AutoPostBack="true" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    <asp:RadioButton ID="RadMatricule" runat="server" Font-Size="Medium" Font-Names="Garamond" ForeColor="Blue" GroupName="MyGroup" Text="Matricule" AutoPostBack="true" />
                    </td>
                   </tr>
                   
              
                   <tr>
                    <td style="width: 163px">
                        <asp:Label ID="lblNPneus" runat="server" Font-Bold="True" Height="22px" Text=" Numéro du Pneus " Width="135px"></asp:Label></td>
                    <td >
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="cbxNPneus" runat="server" AutoPostBack="True" Enabled="false" Width="158px">
                        </asp:DropDownList>
                        <asp:Label ID="lblNCons" runat="server" Font-Bold="True" Height="22px" Text="" Width="5px"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblNPneuss" runat="server" Font-Bold="True" Height="22px" Text="" Width="5px"></asp:Label>
                    </td>
                   </tr>
                    
                  <tr>
                    <td style="width: 163px">
                        <asp:Label ID="lblMatricule" runat="server" Font-Bold="True" Height="22px" Text=" Matricule " Width="135px"></asp:Label></td>
                    <td >
                        <asp:DropDownList ID="cbxMatricule" runat="server" AutoPostBack="True" Visible="true" Width="158px" Enabled="false" >
                        </asp:DropDownList>
                    </td>
                   </tr>
                   
                   
                         <tr>
                    <td style="width: 163px">
                        <asp:Label ID="lbldateD" runat="server" Font-Bold="True" Height="22px" Text=" Date de changement " Width="135px"></asp:Label></td>
                    <td >
                         <asp:TextBox ID="txtbxdateD" runat="server" Width="156px" Enabled="false" ></asp:TextBox>
                         <asp:DropDownList ID="cbxdateD" runat="server" AutoPostBack="True" Width="158px" Visible="false">
                         </asp:DropDownList>
                    </td>
                   </tr>
                   
                   
                             <tr>
                    <td style="width: 163px">
                        <asp:Label ID="lblNFact" runat="server" Font-Bold="True" Height="22px" Text=" Numéro Facture " Width="135px"></asp:Label></td>
                    <td >
                         <asp:TextBox ID="txtbxNFact" runat="server" Width="156px" Enabled="false" ></asp:TextBox>
                    </td>
                   </tr>
                   
                    <tr>
                     <td style="width: 163px">
                      </td> 
                     
                       <td>
                       
                       <br />
                        <asp:Button ID="btnsuppPneus" runat="server" Font-Bold="True" Height="26px" Text="Supprimer"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                               ForeColor="Blue" Visible="True"></asp:Button>
                               
                               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                            
                       <asp:Button ID="BtnEnd" runat="server" Font-Bold="True" Font-Names="Garamond" Height="26px" Width="99px" font-Overline="False" Font-Size="Medium" ForeColor="blue" 
                               PostBackUrl="~/PneusVehi.aspx" Text="Retour" />
                       </td>                     
                    </tr>
              
              </table>
          </td>
        </tr>  
        
        </table>
        
        </asp:Panel>
</center>
</asp:Content>
