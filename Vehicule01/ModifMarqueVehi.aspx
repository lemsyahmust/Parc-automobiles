<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="ModifMarqueVehi.aspx.vb" Inherits="Vehicule01.WebForm3" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <center><h2><i>
         Modification&nbsp;&nbsp;de&nbsp;&nbsp;la marque&nbsp; du&nbsp; Véhicule</i></h2></center>
     <br />
    <center>
        <br />
        <br />
      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            BackColor="#CCCCCC" BorderColor="#999999" 
              BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" 
              DataSourceID="SqlDataSource1" ForeColor="Black" AllowPaging="True" >
              <RowStyle BackColor="White" />
             
              <Columns>
                  <asp:BoundField DataField="lib_marq" HeaderText="  Marque  " 
                      SortExpression="lib_marq" />
                  <asp:BoundField DataField="nbr_place" HeaderText="Nombre de Place" 
                      SortExpression="nbr_place" />
                  <asp:CommandField ButtonType="Button" ShowEditButton="True" />
             </Columns>
             
              <FooterStyle BackColor="#CCCCCC" />
              <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
              <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
              <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
          </asp:GridView> </center>
          
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
              ConnectionString="<%$ ConnectionStrings:Parc-AutoConnectionString %>" 
              SelectCommand="SELECT [lib_marq], [nbr_place] FROM [marque]" ConflictDetection="CompareAllValues"
            
            DeleteCommand="DELETE FROM [marque] WHERE [lib_marq] = @original_lib_marq AND [nbr_place] = @original_nbr_place" 
            
            InsertCommand="INSERT INTO [marque] ([lib_marq], [nbr_place]) VALUES (@lib_marq, @nbr_place)" OldValuesParameterFormatString="original_{0}" 
            
              UpdateCommand="UPDATE [marque] SET [lib_marq] = @lib_marq, [nbr_place] = @nbr_place WHERE [lib_marq] = @original_lib_marq AND [nbr_place] = @original_nbr_place" 
              
           ProviderName="<%$ ConnectionStrings:Parc-AutoConnectionString.ProviderName %>">
            
            <UpdateParameters>
         <asp:Parameter Name="lib_marq" Type="String" />
         <asp:Parameter Name="nbr_place" Type="String" />
         
        
         <asp:Parameter Name="original_lib_marq" Type="String" />
         <asp:Parameter Name="original_nbr_place" Type="String" />
         
   </UpdateParameters>
   <InsertParameters>
        
         <asp:Parameter Name="lib_marq" Type="String" />
         <asp:Parameter Name="nbr_place" Type="String" />
        
   </InsertParameters>
          </asp:SqlDataSource>
 <br />
 
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:Button ID="BtnEnd" runat="server" 
         Font-Bold="True" Font-Names="Garamond" 
         Font-Overline="False" Font-Size="Medium" ForeColor="Red" 
         PostBackUrl="~/MarqueVehi.aspx" Text="Retour" />
 
</asp:Content>


