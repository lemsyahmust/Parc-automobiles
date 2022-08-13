<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login1.aspx.vb" Inherits="Vehicule01.Login1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >

<head runat="server">
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
<body vlink="#000fff">
    <form id="form1" runat="server">
<div id="header">

</div>


<div class="Style1" id="menu">
<br />
<marquee  scrollAmount="3"><center> <asp:Label ID="Noor"  runat="server"  class="Style2" Text="Gestion  Du  Parc  Auto"></asp:Label></center></marquee>
    </div>
    
    
     <div id="content"> 
     
     <table border="0" align="center" background ="../images/4.bmp" 
             style="height: 259px; border-collapse: collapse; width: 828px;">
    <tr>
        <td style="height: 213px; width: 141px;" valign="bottom">
                    <table align="left" 
                        style="width: 240px; border-collapse: collapse; height: 167px">
                       
                        <tr>
                            <td style="width: 152px; height: 24px;">
                                <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Type"></asp:Label></td>
                            <td style="width: 127px; height: 24px;">
                            
                                <asp:DropDownList ID="DropDownList1" runat="server" Width="120px">
                                
                                    <asp:ListItem>Administrateur</asp:ListItem>
                                    <asp:ListItem>Utilisateur</asp:ListItem>
                                    
                                </asp:DropDownList></td>
                        </tr>
                        <tr>
                            <td style="width: 152px">
                                <asp:Label ID="Label1" runat="server" Text="Login&nbsp;:" Width="60px" Font-Bold="True"></asp:Label></td>
                            <td style="width: 127px">
                            
                                <asp:TextBox  ID="txtbxLoginSC" runat="server" Width="116px"></asp:TextBox>
                               
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 152px; height: 28px">
                                <asp:Label ID="Label3" runat="server" Text="Password : " Width="91px" 
                                    Font-Bold="True"></asp:Label></td>
                            <td style="width: 127px; height: 28px">
                                <asp:TextBox ID="txtbxPasswordSC" runat="server" Width="114px" 
                                    TextMode="Password"></asp:TextBox></td>
                        </tr>
                        
                        
                        <tr>
                            <td colspan="2" style="height: 22px">
                                <asp:CheckBox ID="CheckBox1" runat="server" Text="Mémoriser le mot de passe." /></td>
                        </tr>
                        
                         <tr>
                       <td colspan="2"> 
                              <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="* Informations d'authentification non valides : veuillez réessayer"
                                    Visible="False" Width="232px" Height="20px"></asp:Label></td>
                        </tr>
                        
                        <tr>
                            <td align="center" colspan="2">
                                <asp:Button ID="Button1" runat="server" Text="Se connecter" />
                                <br />
                                <asp:Label ID="Label5" runat="server" BackColor="White" BorderColor="White"></asp:Label>
                                <br />
                                </td>
                        </tr>
                    </table>
        </td>
        <td width="491" style="height: 213px">
            &nbsp;</td>
    </tr>
    </table>
     
     </div>
     
<br /><br />
<div id="footer">
	<p id="legal">Copyright &copy; 2011</p>
</div>
    </form>
</body>
</html>
