<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="ModifPneus.aspx.vb" Inherits="Vehicule01.WebForm18" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center>
<h2><i>Modification&nbsp;&nbsp;de&nbsp;Pneu</i></h2>

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
        
<asp:Panel ID="Panel1" runat="server" Width="97%" BorderColor="Black" 
        BorderWidth="1px" Height="462px" style="margin-left: 0px">

 <table style="width: 100%; margin-bottom: 0px; height: 445px;">
         <tr>
          <td valign="top" >
          
          
<table style="width: 342px; border-collapse: collapse;">

                            <tr>
                                <td> 
                                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="#CCCCCC" 
  BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" DataSourceID="SqlDataSource1" ForeColor="Black" style="margin-left: 0px" Width="515px">
                                        <RowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="mat_vehi" HeaderText="Matricule" SortExpression="mat_vehi" />
                                            <asp:BoundField DataField="lib_reparateur" HeaderText="Garagiste" SortExpression="lib_reparateur" />
                                            <asp:BoundField DataField="DateD" HeaderText="Date changement" SortExpression="DateD" />
                                            <asp:BoundField DataField="Km" HeaderText="Kilometrage" SortExpression="Km" />
                                            <asp:BoundField DataField="Marq_Pneus" HeaderText="Marque Pneus" SortExpression="Marq_Pneus" />
                                            <asp:BoundField DataField="Dimenssion" HeaderText="réference" SortExpression="Dimenssion" />
                                            <asp:BoundField DataField="Qte" HeaderText="Quantité" SortExpression="Qte" />
                                            <asp:BoundField DataField="Prix" HeaderText="Prix" SortExpression="Prix" />
                                            <asp:BoundField DataField="N_Fact" HeaderText="Numero Facture" SortExpression="N_Fact" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCCCC" />
                                        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                        ConnectionString="<%$ ConnectionStrings:Parc-AutoConnectionString10 %>" 
                                        SelectCommand="SELECT * FROM [PneusAffichage]"></asp:SqlDataSource>
                                </td>
                            </tr>
</table>

 <td align="center" valign="top">
 <table style="width: 524px; height: 160px; border-collapse: collapse;">
                   
                    <tr>
                    <td>
                             
                               
                   </td>
                   
                   <td align="left" >
                   <asp:Label ID="lblMatricule" runat="server" Font-Bold="True" Height="22px" Text="Matricule" Width="135px" Visible="false"></asp:Label>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="cbxMatricule" runat="server" AutoPostBack="true" Visible="false" Width="130px"></asp:DropDownList>
                                <asp:TextBox ID="txtbxNVehi" runat="server" Height="17px" Width="1px" Visible="false"></asp:TextBox>
                             
                   </td>
                   
                  
                </tr>
                
                <tr>
                     <td>
                    
                      </td> 
                     
                     <td align="left"> 
                     <asp:Label ID="lblNFactP" runat="server" Font-Bold="True" Height="22px" Text="N° Facture" Width="135px" Visible="false"></asp:Label>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:DropDownList ID="cbxNFacture" runat="server" AutoPostBack="true" Visible="false" Width="130px"></asp:DropDownList>
                     </td>
                  </tr>
                  
                  
                <tr>
                <td>
                </td>
                 <td align="left">
                    <asp:Label ID="lblRepaP" runat="server" Font-Bold="True" Height="22px" Text="Garagiste" Width="99px" Visible="false"></asp:Label>
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="cbxRepaP" runat="server" AutoPostBack="true"  Width="195px" Visible="false">
                       </asp:DropDownList>
                       <asp:TextBox ID="txtbxNrep" runat="server" Height="17px" Width="10px" Visible="false"></asp:TextBox> 
                   </td>
                   
               </tr>
               
               
               <tr>
                     <td>
                     <asp:Button ID="btnModif" runat="server" Font-Bold="True" Height="22px" Text="Modifier"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                               ForeColor="Blue"></asp:Button>
                        
                        <asp:Button ID="btnValider" runat="server" Font-Bold="True" Height="22px" Text="Valider" Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                               ForeColor="Blue" Visible="false"></asp:Button> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      </td> 
                     
                     <td align="left">
                      <asp:Label ID="lblDateP" runat="server" Font-Bold="True" Height="22px" Text="Date de changement" Width="135px" Visible="false"></asp:Label>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtbxDateP" runat="server" Height="17px" Width="130px" Visible="false"></asp:TextBox>                     
                     </td>
                  </tr>
                  
               
                  
                   <tr>
                     <td>
                    
                      </td> 
                     
                     <td align="left">
                      <asp:Label ID="lblKm" runat="server" Font-Bold="True" Height="22px" Text="Kilometrage" Width="135px" Visible="false"></asp:Label>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:TextBox ID="txtbxKm" runat="server" Height="17px" Width="130px" Visible="false"></asp:TextBox>                     
                     </td>
                  </tr>
                  
                  
                    <tr>
                     <td>
                     <asp:Button ID="btnAnnuler" runat="server" Font-Bold="True" Font-Italic="True" 
                                         Font-Names="Garamond" Font-Overline="False" Font-Size="Medium" 
                                         Font-Strikeout="False" Font-Underline="False" ForeColor="Blue" Height="22px" 
                                         Text="Annuler" Width="99px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      </td> 
                     
                     <td align="left">
                        <asp:Label ID="lblMarqP" runat="server" Font-Bold="True" Height="22px" Text="Marque" Width="135px" Visible="false"></asp:Label>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="cbxMarq" runat="server" AutoPostBack="true"  Width="130px" Visible="false">
                        </asp:DropDownList>
                        <asp:TextBox ID="txtbxMarqP" runat="server" Height="17px" Width="16px" 
                             Visible="false"></asp:TextBox>                     
                     </td>
                  </tr>
                  
                   <tr>
                     <td>
                     
                      </td> 
                     
                     <td align="left">
                     <asp:Label ID="lblDimenssion" runat="server" Font-Bold="True" Height="22px" Text="Réference" Width="135px" Visible="false"></asp:Label>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:DropDownList ID="cbxRef" runat="server"  Width="130px" Visible="false" 
                             AutoPostBack="True"></asp:DropDownList>                     
                     </td>
                  </tr>
               
               
                  
                   <tr>
                     <td>
                     
                      </td> 
                     
                     <td align="left">
                     <asp:Label ID="lblQteP" runat="server" Font-Bold="True" Height="22px" Text="Quantité" Width="135px" Visible="false"></asp:Label>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:DropDownList ID="cbxQteP" runat="server"  Width="130px" Visible="false">
                                    <asp:ListItem>0</asp:ListItem>
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                       </asp:DropDownList>                     
                     </td>
                  </tr>
               
               
               <tr>
                     <td>
                    
                      </td> 
                     
                     <td align="left"> 
                     <asp:Label ID="lblPrixP" runat="server" Font-Bold="True" Height="22px" Text="Prix" Width="135px" Visible="false"></asp:Label>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:TextBox ID="txtbxPrixP" runat="server" Height="17px" Width="130px" Visible="false"></asp:TextBox>                     
                     </td>
                  </tr>
                  
                        
                  <tr>
                  <td> <asp:Label ID="Label1" runat="server" Height="22px" Text="" Width="1px" Visible="true"></asp:Label></td>
                  <td>
                  <br />
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="BtnEnd" runat="server" Font-Bold="True" Font-Names="Garamond" Font-Overline="False" Font-Size="Medium" ForeColor="Red" PostBackUrl="~/PneusVehi.aspx" Text="Retour" />
                 
                  </td>
                  </tr>
            </table>
                               
 </td>
         
    </td>
  </tr>
</table>
                                

</asp:Panel>
</center>

</asp:Content>
