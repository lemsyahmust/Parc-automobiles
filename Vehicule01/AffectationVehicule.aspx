<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="AffectationVehicule.aspx.vb" Inherits="Vehicule01.WebForm38" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
    <h2>
        <i>Affectation&nbsp; du&nbsp; Véhicule</i></h2>
</center>
<table  style="width: 389px; border-collapse: collapse;">
    <tr>
        <td style="width: 76px; height: 31px">
            <asp:Image ID="img_error" runat="server" Height="16px" ImageUrl="~/images/error.gif"
                        Visible="False" Width="16px" />
        </td>
        <td style="width: 95px; height: 31px">
            <asp:Image ID="img_succes" runat="server" ImageUrl="~/images/ok.gif" Visible="False" />
        </td>
        <td style="width: 3px; height: 31px">
            <asp:Label ID="Lblerror" runat="server" ForeColor="Red" Visible="False" 
                        Width="649px"></asp:Label>
        </td>
    </tr>
</table>
<asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/nouveau.jpg" 
        style="width: 107px" />
<asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/modifier.jpg" />
<asp:ImageButton ID="ImageButton3" runat="server" 
        ImageUrl="~/images/supprimer.jpg" Width="107px" />
<br />
<asp:Panel ID="Panel1" runat="server" Width="91%" BorderColor="Black" 
        BorderWidth="1px" Height="329px">
    <table style="width: 100%; height: 2387px;">
        <tr>
            <td valign="top" style="width: 93px" >
                <table style="width: 58px; border-collapse: collapse;">
                    <tr>
                        <td>
                            <asp:Image ID="img_new" runat="server" ImageUrl="~/images/nouveau2.jpg" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Image ID="img_modif" runat="server" ImageUrl="~/images/modifier2.jpg" Visible="false" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Image ID="img_suppr" runat="server" ImageUrl="~/images/supprimer2.jpg" Visible="False" />
                        </td>
                    </tr>
                </table>
                <td align="center" valign="top">
                    <br />
                    <table style="width: 622px; height: 300px; border-collapse: collapse; margin-left: 0px;">
                        <tr>
                            <td style="height: 1px; width: 117px;">
                                &nbsp;</td>
                            <td style="height: 1px">
                                <asp:Label ID="lblNAFFVehi" runat="server" Font-Bold="True" Height="22px" 
                                    Width="5px" BackColor="White" BorderColor="White" ForeColor="White" ></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style1" style="width: 117px; height: 33px;">
                                <asp:Label ID="lblMatAFFVehiH" runat="server" Font-Bold="True" Height="22px" Text="Matricule du vehicule"
                            Width="123px"></asp:Label>
                            </td>
                            <td style="width: 393px; height: 33px;" >
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="cbxMatAFFVehiH" runat="server" AutoPostBack="true"  
                                    Width="226px">
                                </asp:DropDownList>
                                <asp:TextBox ID="txtbxNVehiH" runat="server" Height="17px" Width="10px" 
                                    ForeColor="White"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style1" style="width: 117px; height: 29px;">
                                <asp:Label ID="lblAFFMarqVehi" runat="server" Font-Bold="True" Height="22px" 
                                    Text="Marque du vehicule" Width="110px"></asp:Label>
                            </td>
                            <td style="width: 393px; height: 29px;" >
                                &nbsp;&nbsp;
                                <asp:TextBox ID="txtbxAFFMarqueV" runat="server" Width="226px" Height="19px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style1" style="width: 117px; height: 37px;">
                                <asp:Label ID="lblNAFFChassis" runat="server" Font-Bold="True" Height="22px" 
                                    Text="N° Chassis" 
                                    Width="93px"></asp:Label>
                            </td>
                            <td style="width: 393px; height: 37px;">
                                &nbsp;
                                <asp:TextBox ID="txtbxAFFNChassis" runat="server" Height="18px" Width="221px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style1" style="width: 117px; height: 15px;">
                                <asp:Label ID="lblAFFDateCrl" runat="server" Font-Bold="True" Height="22px" 
                             Text="Date Circulation" Width="135px"></asp:Label>
                            </td>
                            <td style="width: 393px; height: 15px;">
                                &nbsp;
                                <asp:TextBox ID="txtbxAFFDateCrl" runat="server" Height="18px" Width="221px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style1" style="width: 117px; height: 18px;">
                                <asp:Label ID="lblAFFDateCrl0" runat="server" Font-Bold="True" Height="22px" 
                                    Text="Bénéficiaire" Width="135px"></asp:Label>
                            </td>
                            <td style="width: 393px; height: 18px;">
                         &nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="cbxBenificiaire" runat="server" AutoPostBack="true"  
                                    Width="226px">
                                </asp:DropDownList>
                                <asp:TextBox ID="txtbxNBénéficiare" runat="server" Height="17px" Width="5px" 
                                    ForeColor="White"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style1" style="width: 117px; height: 60px;">
                            </td>
                            <td style="width: 393px; height: 60px;">
                                <asp:Button ID="btnAjoutHuile" runat="server" Font-Bold="True" Height="22px" Text="Ajouter" Enabled="false"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                               ForeColor="Blue"></asp:Button>
                                <asp:Button ID="btnsuppHuile" runat="server" Font-Bold="True" Height="22px" Text="Supprimer"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                               ForeColor="Blue" Visible="False"></asp:Button>
                                <asp:Button ID="btnModifHuile" runat="server" Font-Bold="True" Height="22px" Text="Modifier"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" Enabled="false"
                               ForeColor="Blue" Visible="False"></asp:Button>
                                        
                               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            
                                <asp:Button ID="btnAnnulerHuile" runat="server" Font-Bold="True" Height="22px" Text="Quitter"
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
