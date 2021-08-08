<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="CPMarque.aspx.vb" Inherits="Vehicule01.WebForm34" 
    title="Page sans titre" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=10.5.3700.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div id="content" style="width: 1045px">
<center><h2>Consultation&nbsp; par&nbsp; Marque &nbsp; Vehicule</h2></center>

    <asp:Panel ID="Panel1" runat="server" BorderColor="Black" BorderWidth="1px"
        Width="100%">
        <table style="width: 99%; border-collapse: collapse;">
            <tr>
                <td style="height: 15px" align="center">
                    <br />
                    <table style="width: 910px">
                        <tr>
                            <td>
                    <asp:Label ID="LblMatricule" runat="server" Text="Marque Vehicule" Width="126px"></asp:Label>
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
                            
                            <asp:BoundColumn DataField="lib_marqq" HeaderText="Marque">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <HeaderStyle Font-Bold="True" Font-Names="Comic Sans MS" HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundColumn>
                            
                            <asp:BoundColumn DataField="mat_vehi" HeaderText="Matricule">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <HeaderStyle Font-Bold="True" Font-Names="Comic Sans MS" HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundColumn>
                            
                            <asp:BoundColumn DataField="date_circul" HeaderText="Date Circulation">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <HeaderStyle Font-Bold="True" Font-Names="Comic Sans MS" HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundColumn>
                            
                            <asp:BoundColumn DataField="Km" HeaderText="Km">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <HeaderStyle Font-Bold="True" Font-Names="Comic Sans MS" HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundColumn>
                            
                             <asp:BoundColumn DataField="lib_aff" HeaderText="Béneficiaire">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <HeaderStyle Font-Bold="True" Font-Names="Comic Sans MS" HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundColumn>
                                                        
                           <asp:BoundColumn DataField="lib_etat_vehi" HeaderText="Etat Vehicule">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <HeaderStyle Font-Bold="True" Font-Names="Comic Sans MS" HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundColumn>
                            
                            
                        </Columns>
                    </asp:DataGrid></td>
            </tr>
            
        </table>
        
  <center>
        <table style="width: 1036px; height: 74px; border-collapse: collapse; margin-right: 0px;">
   
   <tr>
   <td>
       <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
           AutoDataBind="true" DisplayGroupTree="False" Visible="False" />
   </td>
   </tr>
   
   </table>
   </center>
        
        
    </asp:Panel>
    <br />
    <br />
</div>


</asp:Content>
