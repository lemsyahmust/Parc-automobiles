<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="ModifTypeRepTion.aspx.vb" Inherits="Vehicule01.WebForm20" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h2><i>
     Modification&nbsp;&nbsp;d'Intervention</i></h2></center>
     <br />
    <center>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" BackColor="#CCCCCC" 
            BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" 
            CellSpacing="2" DataSourceID="SqlDataSource1" ForeColor="Black" 
            Width="451px">
            <RowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="lib_reparation" HeaderText="Intervention" SortExpression="lib_reparation" />
                <asp:CommandField ButtonType="Button" ShowEditButton="True" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
        
        
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:Parc-AutoConnectionString8 %>" 
            SelectCommand="SELECT [lib_reparation] FROM [tc_reparation]" ConflictDetection="CompareAllValues"
            
            DeleteCommand="DELETE FROM [tc_reparation] WHERE [lib_reparation] = @original_lib_reparation " 
            
            InsertCommand="INSERT INTO [tc_reparation] ([lib_reparation]) VALUES (@lib_reparation)" OldValuesParameterFormatString="original_{0}" 
            
              UpdateCommand="UPDATE [tc_reparation] SET [lib_reparation] = @lib_reparation WHERE [lib_reparation] = @original_lib_reparation " 
              
           ProviderName="<%$ ConnectionStrings:Parc-AutoConnectionString8.ProviderName %>">
            
            <UpdateParameters>
         <asp:Parameter Name="lib_reparation" Type="String" />
      
        
         <asp:Parameter Name="original_lib_reparation" Type="String" />
       
         
   </UpdateParameters>
   <InsertParameters>
        
         <asp:Parameter Name="lib_reparation" Type="String" />
           
   </InsertParameters>
        </asp:SqlDataSource>
        
          <br />
 
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="BtnEnd" runat="server" Font-Bold="True" Font-Names="Garamond" Font-Overline="False" Font-Size="Medium" ForeColor="Red" PostBackUrl="~/TypeReparation.aspx" Text="Retour" />

 </center>
</asp:Content>
