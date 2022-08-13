<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="NewUser1.aspx.vb" Inherits="Vehicule01.NewUser1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
 <title>Gestion Du Parc Auto</title>
    <style type="text/css">
<!--

body {
	margin: 0;
	padding: 0;
	background: #FFFFFF url(../images/img01.jpg) repeat-x;
	font: normal 11px Tahoma, Arial, Helvetica, sans-serif;
	color: #666666;
}
#header {
	width: 760px;
	height: 140px;
	margin: 0 auto;
	background: #FFFFFF url(../images/04.bmp);
	 	 
}
#menu {
	width: 760px;
	height: 70px;
	margin: 0 auto;
}
#content {
	width: 1327px;
	margin: 0 auto 20px auto;
	padding: 20px;
	background: #FFFFFF url(../images/img04.jpg) repeat-x left bottom;
}

#footer {
	height: 10px;
	padding: 20px;
	background: #2D2D2D url(../images/img07.gif) repeat-x;
}
#footer p {
	text-align: center;
	color: #999999;
}
.Style1 {
	color: #FFFFFF;
	font-weight: bold;
}
.Style2 {font-size: 16px}

        -->

</style>
</head>
<body>
    <form id="form1" runat="server">
<div id="header">

</div>


<div class="Style1" id="menu">
<br />
<marquee  scrollAmount="3"><center> <asp:Label ID="Noor"  runat="server"  class="Style2" Text="Gestion  Du  Parc  Auto"></asp:Label></center></marquee>
    </div>
    
    
     <div id="content"> 
     
      <br />
         <center>
             <h2><i>
     Nouveaux Comptes</i></h2></center>
     <center>
       <asp:Panel ID="Panel1" runat="server" BorderColor="Black" BorderWidth="1px"
           Width="706px" style="margin-right: 67px">
           <table align="center" style="width: 694px; border-collapse: collapse;">
           <tr>
           <td style="width: 149px; height: 50px;">
               Saisissez les informations du nouveau compte :</td>
           <td style="height: 34px; width: 13px;">
               <asp:Image ID="img_error" runat="server" Height="16px" ImageUrl="~/images/error.gif"
                   Visible="false" Width="16px" /></td>
           <td style="height: 34px; width: 10px;">
               <asp:Image ID="img_succes" runat="server" Height="16px" ImageUrl="~/images/ok.gif"
                  Visible="false" Width="16px" /></td>
           <td style="width:322px; height: 34px">
               <asp:Label ID="lblMessage" runat="server" Width="272px" Visible="false"></asp:Label></td>
          </tr>
         </table>
         
         <table align="center" border="1"  bordercolor ="silver" cellpadding="3"
             width="700" style="border-collapse: collapse; height: 150px">
             <tr>
                <td align="center" colspan="2" background="bg_gradient.gif" >
                <b>Nouveaux comptes</b></td>
             </tr>
             
             <tr>
                 <td>
             Login :</td>
             <td>
                <asp:TextBox ID="txtbxLoginUT" runat="server" Width="160px"></asp:TextBox></td>
         </tr>
         
         <tr>
            <td>
            CIN : :</td>
            <td>
                <asp:TextBox ID="txtbxCIN" runat="server"  Width="160px"></asp:TextBox></td>
         </tr>
         
         <tr>
            <td>
            Nom :</td>
            <td>
                <asp:TextBox ID="txtbxNomUT" runat="server" Width="160px"></asp:TextBox></td>
         </tr>
           <tr>
            <td>
           Prenom :</td>
            <td>
                <asp:TextBox ID="txtbxPrenomUT" runat="server" Width="160px"></asp:TextBox></td>
         </tr>
                    
         <tr>
            <td>
            Adresse : :</td>
            <td>
                <asp:TextBox ID="txtbxAdress" runat="server"  Width="160px"></asp:TextBox></td>
         </tr>
         
         <tr>
            <td>
            Ville : :</td>
            <td>
                <asp:TextBox ID="txtbxVille" runat="server"  Width="160px"></asp:TextBox></td>
         </tr>
         
         <tr>
            <td>
            Password :</td>
            <td>
                <asp:TextBox ID="txtbxPasswordUT" runat="server" TextMode="Password"  Width="160px"></asp:TextBox></td>
         </tr>
           <tr>
            <td>
            Confirm Password : :</td>
            <td>
                <asp:TextBox ID="txtbxConfirm" runat="server"  TextMode="Password"  Width="160px"></asp:TextBox></td>
         </tr>
         
         <tr>
         <td align="center" colspan="2" style="height: 46px">
             <table style="width: 111px; border-collapse: collapse;" border="0">
                <tr>
                   <td>
                      <asp:Button ID="btnOk" runat="server" Text="Ok" Width="62px" /></td>
                      
                  <td>
                      <asp:Button ID="btnAnnuler" runat="server" Text="Retour" 
                          PostBackUrl="~/Image.aspx" /></td>
              </tr>
             </table>
         </td>
         </tr>  
       
         </table>
           </asp:Panel></center>
     
     </div>
     
<br /><br />
<div id="footer">
	<p id="legal">Copyright &copy; 2011</p>
</div>
    </form>
</body>
</html>
