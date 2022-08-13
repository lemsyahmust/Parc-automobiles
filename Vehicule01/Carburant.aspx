<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="Carburant.aspx.vb" Inherits="Vehicule01.WebForm10" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
<h2><i>Carburant</i></h2>
<asp:Panel ID="Panel1" runat="server" Width="90%" BorderColor="Black" BorderWidth="1px" 
            Height="278px">

 <table style="width: 100%">
         <tr>
          <td valign="top" >
          
            <table style="width: 342px; border-collapse: collapse;">
                            <tr>
                                <td> 
                   <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  BackColor="#CCCCCC"  
                                        BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
                                  CellPadding="4" CellSpacing="2" DataSourceID="SqlDataSource1" 
                                  ForeColor="Black" AllowPaging="True" AllowSorting="false" Width="385px">
                                 <RowStyle BackColor="White" />
                       <Columns>
                            <asp:BoundField DataField="lib_carb" HeaderText="Carburant" 
                                SortExpression="lib_carb" />
                            <asp:BoundField DataField="dat_prix_carb" HeaderText="Date Du Carburant" 
                                SortExpression="dat_prix_carb" /> 
                                
                                 <asp:BoundField DataField="prix_carb" HeaderText="Prix Du Carburant (DH/L)" 
                                SortExpression="prix_carb" />
                       </Columns>
                       
                            <FooterStyle BackColor="#CCCCCC" />
                            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                   </asp:GridView>
                   
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                        ConnectionString="<%$ ConnectionStrings:Parc-AutoConnectionString2 %>" 
                                        SelectCommand="SELECT [lib_carb], [dat_prix_carb], [prix_carb] FROM [CarbPrix]">
                                    </asp:SqlDataSource>
                   
                   <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Parc-AutoConnectionString4 %>" 
                                     SelectCommand="SELECT [lib_carb], [dat_prix_carb], [prix_carb] FROM [CarbPrix]"> 
                                     
                                     
                   </asp:SqlDataSource>
                   
                                    </td>
                            </tr>
                            
           </table>
           
            <td align="center" valign="top">
                                             
                         <table style="width: 569px; height: 160px; border-collapse: collapse;">
                   
                    <tr>
                    <td>
                        <asp:Button ID="btnModif" runat="server" Font-Bold="True" Height="22px" Text="Modifier"
                            Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                               ForeColor="Blue"></asp:Button>
                        
                        <asp:Button ID="btnValider" runat="server" Font-Bold="True" Height="22px" Text="Valider" Width="99px" Font-Italic="True" Font-Names="Garamond" Font-Overline="False" 
                               Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
                               ForeColor="Blue" Visible="false"></asp:Button>       
                               
                               </td>
                               
                               <td>
                                <asp:Label ID="lblCarburant" runat="server" Font-Bold="True" Height="22px" Text="Carburant" Width="135px" Visible="false"></asp:Label>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="cbxCarburant" runat="server" AutoPostBack="true" Visible="false" Width="130px"></asp:DropDownList>
                               </td>
                          </tr>
                 
                     
                      <tr>
                      <td><asp:Button ID="btnAnnuler" runat="server" Font-Bold="True" Font-Italic="True" 
                                         Font-Names="Garamond" Font-Overline="False" Font-Size="Medium" 
                                         Font-Strikeout="False" Font-Underline="False" ForeColor="Blue" Height="22px" 
                                         Text="Annuler" Width="99px" /></td>
                      
                       <td>
                               <asp:Label ID="lbldate" runat="server" Font-Bold="True" Height="22px" Text="Date Du Carburant" Width="135px" Visible="false"></asp:Label>
                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtbxDate" runat="server" Width="130px" Visible="false" ></asp:TextBox>
                              
                               <asp:TextBox ID="txtbxDate1" runat="server" Width="0px" ForeColor="White" Visible="false"></asp:TextBox>
                               </td>
                      </tr>
                      
                  
                    <tr>
                    
                        <td>
                            <asp:Label ID="Label1" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblPrix" runat="server" Font-Bold="True" Height="22px" Visible="false" Text="Prix Du Carburant" Width="135px"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtbxPrix" runat="server" Width="130px" Visible="false"></asp:TextBox>
                       <asp:TextBox ID="txtbxPrix1" runat="server" Width="0px" ForeColor="White" Visible="false"></asp:TextBox>
                       
                                                  
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
