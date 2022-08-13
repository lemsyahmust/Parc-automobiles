<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="Reforme.aspx.vb" Inherits="Vehicule01.WebForm42" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
<h2> <i>Réforme&nbsp; du&nbsp; Véhicule</i></h2></center>

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
           
           
            <asp:Panel ID="Panel1" runat="server" Width="90%" BorderColor="Black" 
        BorderWidth="1px" Height="157px">
        <center>
        <br />
        <br />
               
             <table style="width: 676px; height: 122px; border-collapse: collapse;">
                 
                   <tr>
                    <td style="width: 181px">
                        <asp:Label ID="lblMarque" runat="server" Font-Bold="True" Height="22px" Text=" Matricule "
                            Width="135px"></asp:Label></td>
                    <td >
                        <asp:DropDownList ID="cbxMarque" runat="server" AutoPostBack="True" 
                           Width="226px" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False">
                        </asp:DropDownList>
                    </td>
                   </tr>
                   
                    <tr>
                    <td style="width: 181px">
                        <asp:Label ID="lblmatricule1" runat="server" Font-Bold="True" Height="22px" Text=" Matricule "
                            Width="135px"></asp:Label></td>
                    <td >
                        <asp:DropDownList ID="cbxmaticule" runat="server" AutoPostBack="True" 
                            Width="226px" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False">
                        </asp:DropDownList>
                    </td>
                   </tr>
                   
                    <tr>
                    <td style="width: 181px">
                        <asp:Label ID="lblNChassis" runat="server" Font-Bold="True" Height="22px" Text="N°Chassis"
                            Width="135px"></asp:Label></td>
                    <td >
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:TextBox ID="txtbxNChassis" runat="server" Width="220px"></asp:TextBox>
                     
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                   </tr>
                   
                   <tr>
                     <td style="width: 181px">
                      </td> 
                     
                       <td>
                       
                       <br />
                   
                       <asp:Button ID="btnsuppVeh" runat="server" Font-Bold="True" Height="22px" Text="Supprimer tous"
                            Width="127px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                               ForeColor="Blue" ></asp:Button> 
                               
                               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            
                       <asp:Button ID="btnAnnulerVeh" runat="server" Font-Bold="True" Height="22px" Text="Annuler"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" ForeColor="Blue" ></asp:Button>
                       </td>                     
                    </tr>
                    
                   
                   </table>
                   </center>
       </asp:Panel>
                                
               
</asp:Content>
