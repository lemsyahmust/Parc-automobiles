<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="ModifAffect.aspx.vb" Inherits="Vehicule01.WebForm9" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h2><i>
     Modification&nbsp; De&nbsp; Bénéficiaire</i></h2></center>
     <br />
    <center>
<asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" 
        BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" 
        CellSpacing="2" ForeColor="Black" AutoGenerateColumns="False" 
            DataSourceID="SqlDataSource1" AllowPaging="True">
    <RowStyle BackColor="White" />
    <Columns>
        <asp:BoundField DataField="lib_aff" HeaderText="Bénéficiaire" SortExpression="lib_aff" />
        
        <asp:CommandField ButtonType="Button" ShowEditButton="True" />
    </Columns>
    <FooterStyle BackColor="#CCCCCC" />
    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
    
</asp:GridView>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:Parc-AutoConnectionString5 %>" 
            SelectCommand="SELECT [lib_aff] FROM [Affectation]" ConflictDetection="CompareAllValues"
            
             DeleteCommand="DELETE FROM [Affectation] WHERE [lib_aff] = @original_lib_aff " 
            
             InsertCommand="INSERT INTO [Affectation] ([lib_aff]) VALUES (@lib_aff)" OldValuesParameterFormatString="original_{0}" 
            
             UpdateCommand="UPDATE [Affectation] SET [lib_aff] = @Lib_aff WHERE [lib_aff] = @original_lib_aff " 
          
                       
                         
            ProviderName="<%$ ConnectionStrings:Parc-AutoConnectionString5.ProviderName %>">
            
   <UpdateParameters>
         <asp:Parameter Name="lib_aff" Type="String" />
        
        
         <asp:Parameter Name="original_lib_aff" Type="String" />
        
         
   </UpdateParameters>
   <InsertParameters>
        
         <asp:Parameter Name="lib_aff" Type="String" />
      
        
   </InsertParameters>
   
        </asp:SqlDataSource>
        
        <br />
 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button 
            ID="BtnEnd" runat="server" 
         Font-Bold="True" Font-Names="Garamond" 
         Font-Overline="False" Font-Size="Medium" ForeColor="Red" 
        Text="Retour" PostBackUrl="~/Affectation.aspx" />
         
</center>

</asp:Content>
