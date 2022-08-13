<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="ModifMarqPneus.aspx.vb" Inherits="Vehicule01.WebForm17" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center>
<h2><i>Modification&nbsp; De&nbsp; Marque&nbsp; De&nbsp; Pneus&nbsp;&nbsp;</i></h2>
<br />
<asp:Panel ID="Panel1" runat="server" Width="90%" BorderColor="Black" 
        BorderWidth="1px" Height="316px">
        <br />
        <br />
<asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" 
        BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" 
        DataSourceID="SqlDataSource1" ForeColor="Black" Height="111px" Width="730px">
    <RowStyle BackColor="White" />
    <Columns>
        <asp:BoundField DataField="N_Serie" HeaderText="N°Série" 
            SortExpression="N_Serie" />
        <asp:BoundField DataField="Marq_Pneus" HeaderText="Marque" 
            SortExpression="Marq_Pneus" />
        <asp:BoundField DataField="Dimenssion" HeaderText="Référence" 
            SortExpression="Dimenssion" />
        <asp:BoundField DataField="Description" HeaderText="Description" 
            SortExpression="Description" />    
        <asp:BoundField DataField="Qte" HeaderText="Quantité" SortExpression="Qte" />
        <asp:BoundField DataField="Prix" HeaderText="Prix" SortExpression="Prix (DH)" />
        <asp:CommandField ButtonType="Button" ShowEditButton="True" />
         
    </Columns>
    <FooterStyle BackColor="#CCCCCC" />
    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />

</asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:Parc-AutoConnectionString11 %>" 
        SelectCommand="SELECT * FROM [Marque_Pneus]" ConflictDetection="CompareAllValues"
            
            DeleteCommand="DELETE FROM [Marque_Pneus] WHERE [N_Serie] = @original_N_Serie " 
            
            
            InsertCommand="INSERT INTO [Marque_Pneus] ([N_Serie], [Marq_Pneus], [Dimenssion],[Description], [Qte], [Prix]) VALUES (@N_Serie, @Marq_Pneus, @Dimenssion,@Description, @Qte, @Prix)" OldValuesParameterFormatString="original_{0}" 
            
            UpdateCommand="UPDATE [Marque_Pneus] SET [N_Serie] = @N_Serie, [Marq_Pneus] = @Marq_Pneus , [Dimenssion] = @Dimenssion,[Description]=@Description, [Qte] = @Qte, [Prix] = @Prix WHERE [N_Serie] = @original_N_Serie AND [Marq_Pneus] = @original_Marq_Pneus AND [Dimenssion] = @original_Dimenssion AND [Description]=@original_Description and [Qte] = @original_Qte AND [Prix] = @original_Prix" 
              
           
            ProviderName="<%$ ConnectionStrings:Parc-AutoConnectionString11.ProviderName %>">
            
            <DeleteParameters>
                <asp:Parameter Name="original_N_Serie" />
            </DeleteParameters>
            
            <UpdateParameters>
         <asp:Parameter Name="N_Serie" Type="String" />
         <asp:Parameter Name="Marq_Pneus" Type="String" />
         <asp:Parameter Name="Dimenssion" Type="String" />
          <asp:Parameter Name="Description" Type="String" />
         <asp:Parameter Name="Qte" Type="String" />  
         <asp:Parameter Name="Prix" Type="String" />
         
         <asp:Parameter Name="original_N_Serie" Type="String" />
         <asp:Parameter Name="original_Marq_Pneus" Type="String" />
         <asp:Parameter Name="original_Dimenssion" Type="String" />
         <asp:Parameter Name="original_Description" Type="String" />
         <asp:Parameter Name="original_Qte" Type="String" /> 
         <asp:Parameter Name="original_Prix" Type="String" />
         
   </UpdateParameters>
   <InsertParameters>
        
         <asp:Parameter Name="N_Serie" Type="String" />
         <asp:Parameter Name="Marq_Pneus" Type="String" />
         <asp:Parameter Name="Dimenssion" Type="String" />
         <asp:Parameter Name="Description" Type="String" />
         <asp:Parameter Name="Qte" Type="String" />
         <asp:Parameter Name="Prix" Type="String" />
         
   </InsertParameters>
        </asp:SqlDataSource>
        
        <br />
 
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button 
            ID="BtnEnd" runat="server" 
         Font-Bold="True" Font-Names="Garamond" 
         Font-Overline="False" Font-Size="Medium" ForeColor="Red" 
        Text="Retour" PostBackUrl="~/MarquePneus.aspx" />
        
        
</asp:Panel>
        
</center>
</asp:Content>
