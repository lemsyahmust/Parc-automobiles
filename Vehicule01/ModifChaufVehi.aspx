<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="ModifChaufVehi.aspx.vb" Inherits="Vehicule01.WebForm6" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h2><i>
     Modification&nbsp;&nbsp;De&nbsp;&nbsp;Chauffeur</i></h2></center>
     <br />
    <center>
        <br />
        <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
            CellPadding="4" CellSpacing="2" DataSourceID="SqlDataSource1" 
            ForeColor="Black" AllowPaging="True">
        <RowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="CIN" HeaderText="CIN" SortExpression="CIN" />
            <asp:BoundField DataField="Nom" HeaderText="Nom" SortExpression="Nom" />
            <asp:BoundField DataField="Prenom" HeaderText="Prenom" 
                SortExpression="Prenom" />
            <asp:BoundField DataField="num_permis" HeaderText="Numéro de permis" 
                SortExpression="num_permis" />
            <asp:BoundField DataField="n_doti" HeaderText="PPR" 
                SortExpression="n_doti" />
            <asp:BoundField DataField="categorie_P" HeaderText="Catégorie de permis" 
                SortExpression="categorie_P" />
                
            <asp:CommandField ButtonType="Button" ShowEditButton="True" />
                
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
</asp:GridView>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:Parc-AutoConnectionString7 %>" 
            SelectCommand="SELECT [CIN], [Nom], [Prenom], [num_permis], [n_doti], [categorie_P] FROM [chauffeurV]" ConflictDetection="CompareAllValues"
            
            DeleteCommand="DELETE FROM [chauffeurV] WHERE [CIN] = @original_CIN AND [Nom] = @original_Nom AND [Prenom] = @original_Prenom AND [num_permis] = @original_num_permis AND [n_doti] = @original_n_doti AND [categorie_P] = @original_categorie_P" 
            
            InsertCommand="INSERT INTO [chauffeurV] ([CIN], [Nom], [Prenom], [num_permis], [n_doti], [categorie_P]) VALUES (@CIN, @Nom, @Prenom, @num_permis, @n_doti, @categorie_P)" OldValuesParameterFormatString="original_{0}" 
            
              UpdateCommand="UPDATE [chauffeurV] SET [CIN] = @CIN, [Nom] = @Nom, [Prenom] = @Prenom, [num_permis] = @num_permis, [n_doti] = @n_doti, [categorie_P] = @categorie_P WHERE [CIN] = @original_CIN AND [Nom] = @original_Nom AND [Prenom] = @original_Prenom AND [num_permis] = @original_num_permis AND [n_doti] = @original_n_doti AND [categorie_P] = @original_categorie_P" 
              
           ProviderName="<%$ ConnectionStrings:Parc-AutoConnectionString7.ProviderName %>">
            
            <UpdateParameters>
         <asp:Parameter Name="CIN" Type="String" />
         <asp:Parameter Name="Nom" Type="String" />
         <asp:Parameter Name="Prenom" Type="String" />
         <asp:Parameter Name="num_permis" Type="String" />
         <asp:Parameter Name="n_doti" Type="String" />
         <asp:Parameter Name="categorie_P" Type="String" />
        
         <asp:Parameter Name="original_CIN" Type="String" />
         <asp:Parameter Name="original_Nom" Type="String" />
          <asp:Parameter Name="original_Prenom" Type="String" />
         <asp:Parameter Name="original_num_permis" Type="String" />
          <asp:Parameter Name="original_n_doti" Type="String" />
         <asp:Parameter Name="original_categorie_P" Type="String" />
         
   </UpdateParameters>
   <InsertParameters>
        
         <asp:Parameter Name="CIN" Type="String" />
         <asp:Parameter Name="Nom" Type="String" />
         <asp:Parameter Name="Prenom" Type="String" />
         <asp:Parameter Name="num_permis" Type="String" />
         <asp:Parameter Name="n_doti" Type="String" />
         <asp:Parameter Name="categorie_P" Type="String" />
        
   </InsertParameters>
   
   
   
        </asp:SqlDataSource>
        <br />
 
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="BtnEnd" runat="server" Font-Bold="True" Font-Names="Garamond" Font-Overline="False" Font-Size="Medium" ForeColor="Red" PostBackUrl="~/ChauffVehi.aspx" Text="Retour" />

    </center>
    
</asp:Content>
