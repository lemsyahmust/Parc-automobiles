<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="ModifRepaVehi.aspx.vb" Inherits="Vehicule01.WebForm1" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center><h2><i>
        Modification&nbsp; de&nbsp; garagiste</i></h2></center>
     <br />
    <center>
        <br />
        <br />
        
        <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="False" 
            BackColor="#CCCCCC" BorderColor="#999999" 
            BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" 
            DataSourceID="SqlDataSource1" ForeColor="Black" AllowPaging="True">
            <RowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="lib_reparateur" HeaderText="Garagiste" 
                    SortExpression="lib_reparateur" />
                <asp:BoundField DataField="Adresse" HeaderText="Adresse" 
                    SortExpression="Adresse" />
                <asp:BoundField DataField="Tel" HeaderText="Tel" SortExpression="Tel" />
                <asp:BoundField DataField="Fax" HeaderText="Fax" SortExpression="Fax" />
                
                <asp:CommandField ButtonType="Button" ShowEditButton="True" />
                
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
        
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:Parc-AutoConnectionString9 %>" 
            
            SelectCommand="SELECT [lib_reparateur], [Adresse], [Tel], [Fax] FROM [Reparateur]" ConflictDetection="CompareAllValues"
            
            DeleteCommand="DELETE FROM [Reparateur] WHERE [lib_reparateur] = @original_lib_reparateur AND [Adresse] = @original_Adresse  AND [Tel] = @original_Tel  AND [Fax] = @original_Fax" 
            
            InsertCommand="INSERT INTO [Reparateur] ([lib_reparateur], [Adresse], [Tel], [Fax]) VALUES (@lib_reparateur, @Adresse, @Tel, @Fax)" OldValuesParameterFormatString="original_{0}" 
            
              UpdateCommand="UPDATE [Reparateur] SET [lib_reparateur] = @lib_reparateur, [Adresse] = @Adresse, [Tel] = @Tel, [Fax] = @Fax WHERE [lib_reparateur] = @original_lib_reparateur AND [Adresse] = @original_Adresse AND [Tel] = @original_Tel AND [Fax] = @original_Fax" 
              
           ProviderName="<%$ ConnectionStrings:Parc-AutoConnectionString9.ProviderName %>">
            
            <UpdateParameters>
         <asp:Parameter Name="lib_reparateur" Type="String" />
         <asp:Parameter Name="Adresse" Type="String" />
        <asp:Parameter Name="Tel" Type="String" />
         <asp:Parameter Name="Fax" Type="String" />
        
         <asp:Parameter Name="original_lib_reparateur" Type="String" />
         <asp:Parameter Name="original_Adresse" Type="String" />
         <asp:Parameter Name="original_Tel" Type="String" />
         <asp:Parameter Name="original_Fax" Type="String" />
   </UpdateParameters>
   <InsertParameters>
        
         <asp:Parameter Name="lib_reparateur" Type="String" />
         <asp:Parameter Name="Adresse" Type="String" />
         <asp:Parameter Name="Tel" Type="String" />
         <asp:Parameter Name="Fax" Type="String" />
   </InsertParameters>
   
   
        </asp:SqlDataSource>
          <br />
 
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
            ID="BtnEnd" runat="server" 
         Font-Bold="True" Font-Names="Garamond" 
         Font-Overline="False" Font-Size="Medium" ForeColor="Red" 
         PostBackUrl="~/Reparateur.aspx" Text="Retour" />

        
        </center>

</asp:Content>
