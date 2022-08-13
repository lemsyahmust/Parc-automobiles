<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="WebForm14.aspx.vb" Inherits="Vehicule01.WebForm14" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataPager ID="DataPager1" runat="server">
        <Fields>
            <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" 
                ShowNextPageButton="False" ShowPreviousPageButton="False" />
            <asp:NumericPagerField />
            <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" 
                ShowNextPageButton="False" ShowPreviousPageButton="False" />
        </Fields>
    </asp:DataPager>
    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
        BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" 
        Font-Size="10pt" ForeColor="Black" Height="220px" NextPrevFormat="FullMonth" 
        TitleFormat="Month" Width="400px">
        <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
        <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" 
            Font-Size="8pt" ForeColor="#333333" Width="1%" />
        <TodayDayStyle BackColor="#CCCC99" />
        <OtherMonthDayStyle ForeColor="#999999" />
        <DayStyle Width="14%" />
        <NextPrevStyle Font-Size="8pt" ForeColor="White" />
        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" 
            ForeColor="#333333" Height="10pt" />
        <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" 
            ForeColor="White" Height="14pt" />
    </asp:Calendar>
</asp:Content>
