<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="CParDepenseReparation.aspx.vb" Inherits="Vehicule01.WebForm39" 
    title="Page sans titre" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=10.5.3700.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="content" style="width: 1045px; height: 297px;">
<center><h2>Dépense&nbsp;&nbsp; De &nbsp; Réparation</h2></center>

    <asp:Panel ID="Panel1" runat="server" BorderColor="Black" BorderWidth="1px"
        Width="100%" Height="256px">
        <table style="width: 99%; border-collapse: collapse;">
            <tr>
                <td style="height: 15px" align="center">
                    <br />
                    <table style="width: 866px; height: 28px;">
                        <tr>
                            <td>
                    <asp:Label ID="LblMatricule" runat="server" Text="Matricule" Width="126px"></asp:Label>
                            </td>
                            <td>
                    <asp:DropDownList ID="cbxMatricule" runat="server" AutoPostBack="True" Width="357px">
                    </asp:DropDownList></td>
                    
                    <td>
                      <asp:Button ID="BtnEnd" runat="server" Font-Bold="True" Font-Names="Garamond" 
                            Font-Overline="False" Font-Size="Medium" ForeColor="Red"  Text="Imprimer" 
                            Width="110px" />

                    </td>
                        </tr>
                    </table>
                </td>
            </tr>
             <tr>
                <td style="height: 141px">
                    <asp:DataGrid ID="Datagrid2" runat="server" AutoGenerateColumns="False" 
                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                        CellPadding="3" Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                        Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                        Width="99%" Visible="False">
                        <FooterStyle BackColor="White" ForeColor="#000066" />
                        <SelectedItemStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" Mode="NumericPages" />
                        <ItemStyle ForeColor="#000066" />
                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                        <Columns>
                            <asp:BoundColumn DataField="mat_vehi" HeaderText="Matricule">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <HeaderStyle Font-Bold="True" Font-Names="Comic Sans MS" HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="Lib_Reparateur" HeaderText="Garagiste">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <HeaderStyle Font-Bold="True" Font-Names="Comic Sans MS" HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="Ref" HeaderText="Réference">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <HeaderStyle Font-Bold="True" Font-Names="Comic Sans MS" HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundColumn>
                            
                            <asp:BoundColumn DataField="Date" HeaderText="Date">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <HeaderStyle Font-Bold="True" Font-Names="Comic Sans MS" HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundColumn>
                            
                             <asp:BoundColumn DataField="Souche" HeaderText="Souche">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <HeaderStyle Font-Bold="True" Font-Names="Comic Sans MS" HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundColumn>
                                                        
                           <asp:BoundColumn DataField="Montant" HeaderText="Montant">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <HeaderStyle Font-Bold="True" Font-Names="Comic Sans MS" HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundColumn>
                            
                            <asp:BoundColumn DataField="N_Fact" HeaderText="Facture">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <HeaderStyle Font-Bold="True" Font-Names="Comic Sans MS" HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundColumn>
                            
                        </Columns>
                    </asp:DataGrid></td>
            </tr>
            </table>
            
                        
</asp:Panel>
</div>

</asp:Content>
