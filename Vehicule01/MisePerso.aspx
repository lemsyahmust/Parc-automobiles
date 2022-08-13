<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="MisePerso.aspx.vb" Inherits="Vehicule01.WebForm29" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center><h2><i>
        Suppression&nbsp;&nbsp;de missionnaire</i></h2></center>
        <br />
    <asp:Panel ID="Panel1" runat="server" Width="90%" BorderColor="Black" 
        BorderWidth="1px" Height="484px">
        <br /> 
    <center style="height: 452px">
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" BackColor="#CCCCCC" 
            BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" 
            CellSpacing="2" DataSourceID="SqlDataSource1" ForeColor="Black" 
            EnableTheming="True" HorizontalAlign="Center" Width="603px">
            <PagerSettings PageButtonCount="2" />
            <RowStyle BackColor="White" Wrap="True" />
            <EmptyDataRowStyle Wrap="True" />
            <Columns>
                <asp:BoundField DataField="Nom" HeaderText="Nom" SortExpression="Nom" />
                <asp:BoundField DataField="Prenom" HeaderText="Prenom" 
                    SortExpression="Prenom" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Tel" HeaderText="Tel" SortExpression="Tel" />
                <asp:BoundField DataField="Poste" HeaderText="Poste" SortExpression="Poste" />
                <asp:BoundField DataField="groupe" HeaderText="groupe" 
                    SortExpression="groupe" />
                
                <asp:CommandField ButtonType="Button" ShowDeleteButton="true" />
                
            </Columns>
            <FooterStyle BackColor="#CCCCCC" Wrap="True" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" 
                Wrap="True" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" 
                Wrap="False" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" Wrap="True" />
            <EditRowStyle Wrap="True" />
        </asp:GridView>
    
 
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:Parc-AutoConnectionString12 %>" 
            
            SelectCommand="SELECT [Nom], [Prenom], [Email], [Tel], [Poste], [groupe] FROM [Personnel]" ConflictDetection="CompareAllValues"
            
            
            DeleteCommand="DELETE FROM [Personnel] WHERE [Nom] = @original_Nom AND [Prenom] = @original_Prenom AND [Email] = @original_Email AND [Tel] = @original_Tel AND [Poste] = @original_Poste and [groupe]=@original_groupe " 
            
            
            InsertCommand="INSERT INTO [Personnel] ( [Nom], [Prenom], [Email], [Tel], [Poste],[groupe]) VALUES (@Nom, @Prenom, @Email, @Tel, @Poste,@groupe)" OldValuesParameterFormatString="original_{0}" 
            
              UpdateCommand="UPDATE [Personnel] SET [Nom] = @Nom, [Prenom] = @Prenom, [Email] = @Email, [Tel] = @Tel, [Poste] = @Poste , [groupe]=@groupe WHERE [Nom] = @original_Nom AND [Prenom] = @original_Prenom AND [Email] = @original_Email AND [Tel] = @original_Tel AND [Poste] = @original_Poste And [groupe]=@original_groupe " 
              
              
            ProviderName="<%$ ConnectionStrings:Parc-AutoConnectionString12.ProviderName %>">
            
            <DeleteParameters>
                <asp:Parameter Name="original_Nom" />
                <asp:Parameter Name="original_Prenom" />
                <asp:Parameter Name="original_Email" />
                <asp:Parameter Name="original_Tel" />
                <asp:Parameter Name="original_Poste" />
                <asp:Parameter Name="original_groupe" />
            </DeleteParameters>
            
            <UpdateParameters>
         <asp:Parameter Name="Nom" Type="String" />
         <asp:Parameter Name="Prenom" Type="String" />
         <asp:Parameter Name="Email" Type="String" />
         <asp:Parameter Name="Tel" Type="String" />
         <asp:Parameter Name="Poste" Type="String" />
        <asp:Parameter Name="groupe" Type="String" />
                
     
         <asp:Parameter Name="original_Nom" Type="String" />
          <asp:Parameter Name="original_Prenom" Type="String" />
         <asp:Parameter Name="original_Email" Type="String" />
          <asp:Parameter Name="original_Tel" Type="String" />
         <asp:Parameter Name="original_Poste" Type="String" />
         <asp:Parameter Name="original_groupe" Type="String" />
                
   </UpdateParameters>
   <InsertParameters>
        
         <asp:Parameter Name="Nom" Type="String" />
         <asp:Parameter Name="Prenom" Type="String" />
         <asp:Parameter Name="Email" Type="String" />
         <asp:Parameter Name="Tel" Type="String" />
         <asp:Parameter Name="Poste" Type="String" />
        <asp:Parameter Name="groupe" Type="String" />
               
   </InsertParameters>
   
   
        </asp:SqlDataSource>
    
    <br />
    
     <asp:Button ID="BtnEnd" runat="server" Font-Bold="True" Font-Names="Garamond" Font-Overline="False" Font-Size="Medium" ForeColor="Red" PostBackUrl="~/Personnel.aspx" Text="Retour" />

    </center>
    </asp:Panel>
    
</asp:Content>
