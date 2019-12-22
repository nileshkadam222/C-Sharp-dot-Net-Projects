<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="upgrade.aspx.cs" Inherits="shubhafinal.upgrade" %> 

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8" />
<title>Welcome to Pavitrabandhan</title>
<script  language ="javascript" >

     function isValidAlpha(c) {

         var c = event.keyCode;

         event.keyCode = (!((c >= 65 && c <= 90)
                      || (c >= 97 && c <= 122)
                      || (c == 32))) ? 0 : event.keyCode;

     }

     function keypress(e) {

         if ([e.keyCode || e.which] == 8) //this is to allow backspace
             return true;
         if ([e.keyCode || e.which] < 48 || [e.keyCode || e.which] > 57)
             e.preventDefault ? e.preventDefault() : e.returnValue = false;
     }
     </script>
<meta name="keywords" content="" />
<meta name="Premium Series" content="" />
<link href="default.css" rel="stylesheet" type="text/css" media="screen" />
</head>
<body>
<!-- start header -->
<div id="header">
	<div id="logo">
		<h1><a><span>Pavitrabandhan</span></a></h1>
	</div>
	<div id="tabsE">

  <ul>
    <li >  <asp:HyperLink ID="HyperLink1" runat="server" CssClass ="prof" ><span>Home</span></asp:HyperLink></li>
    <li >  <asp:HyperLink ID="HyperLink2" runat="server" CssClass ="prof" ><span>Profile</span></asp:HyperLink></li>
    <li >  <asp:HyperLink ID="HyperLink3" runat="server" CssClass ="prof" ><span>Search</span></asp:HyperLink></li>
    <li >  <asp:HyperLink ID="HyperLink4" runat="server" CssClass ="prof" ><span>Upgrade</span></asp:HyperLink></li>
    <li >  <asp:HyperLink ID="HyperLink5" runat="server" CssClass ="prof" ><span>Message</span></asp:HyperLink></li>
    <li >  <asp:HyperLink ID="HyperLink6" runat="server" CssClass ="prof" ><span>Help</span></asp:HyperLink></li>
    
</ul>
</div>

	 
</div>
<!-- end header -->
<div id="wrapper">
	<!-- start page -->
	<div id="page">
	<div id="page-bg">
		<div id="sidebar1" class="sidebar">
			<ul>
			  <li>
			    <ul>
					  <li></li>
			    </ul>
			  </li>
		  </ul>
		</div>
		<!-- start content -->
	  <div id="content">
			<div class="flower"></div>
		  <div class="post">
				<h1 class="title"><a>Premium Membership </a></h1>
				<form runat="server">
				<asp:ScriptManager ID ="sm" runat = "server"> </asp:ScriptManager>
			    <table width="503" border="1">
                  <tr>
                    <td colspan="4"><strong>Membership options : </strong></td>
                  </tr>
				  <tr>
                    <td>&nbsp;</td>
                    <td align="center" valign="middle"> <strong> 3 Months </strong></td>
                    <td align="center" valign="middle"> <strong>6 Months</strong> </td>
                    <td align="center" valign="middle"> <strong>9 Months</strong> </td>
			      </tr>
                  <tr>
                    <td width="214"><strong>Diamond : </strong><br/>
                    Send and receive personalised messages through E-mail and Chat. Get Highlighting for your profile. Access highest number of Verified Phone Numbers.</td>
                    <td width="82" align="center" valign="middle"> Rs. 2999 <br/>
                      
                        <asp:Button ID="cmddia3" Text="Buy" runat="server" onclick="cmddia3_Click" />                      
                    </td>
                    <td width="85" align="center" valign="middle"> Rs. 4999 <br/>
                      
                    <asp:Button ID="cmddia6" Text="Buy" runat="server" onclick="cmddia6_Click" />  </td>
                    <td width="94" align="center" valign="middle"> Rs. 6999 <br/>
                      
                    <asp:Button ID="cmddia9" Text="Buy" runat="server" onclick="cmddia9_Click" />  </td>
                  </tr>
                  <tr>
                    <td><strong>Gold : </strong><br/> 
                    Send and receive personalised messages through E-mail and Chat. Get Highlighting for your profile. Access medium number of Verified Phone Numbers </td>
                    <td align="center" valign="middle"> Rs. 2499<br/>
                      
                    <asp:Button ID="cmdgold3" Text="Buy" runat="server" onclick="cmdgold3_Click" 
                            style="height: 26px" />   </td>
                    <td align="center" valign="middle"> Rs. 4499<br/>
                      
                    <asp:Button ID="cmdgold6" Text="Buy" runat="server" onclick="cmdgold6_Click" />   </td>
                    <td align="center" valign="middle"> Rs. 5999<br/>
                      
                    <asp:Button ID="cmdgold9" Text="Buy" runat="server" onclick="cmdgold9_Click" />   </td>
                  </tr>
				  <tr>
                    <td><strong>Silver : </strong><br/> 
                      Send and receive personalised messages through E-mail and Chat. Access medium number of Verified Phone Numbers                    </td>
                    <td align="center"> Rs. 1999<br/>
                      
                    <asp:Button ID="cmdsilver3" Text="Buy" runat="server" onclick="cmdsilver3_Click" />   </td>
                    <td align="center"> Rs. 3499<br/>
                      
                    <asp:Button ID="cmdsilver6" Text="Buy" runat="server" onclick="cmdsilver6_Click" />   </td>
                    <td align="center">  Rs. 4499 <br/>
                      
                    <asp:Button ID="cmdsilver9" Text="Buy" runat="server" onclick="cmdsilver9_Click" />  </td>
				  </tr>
				   
                </table>
				<br/>
				
			    <asp:Table width="505" border="1" ID="tbldetails" runat="server" 
                    Visible="False">
                  <asp:TableRow>
                    <asp:TableCell  ColumnSpan="4"><strong>Credit Card Details:</strong></asp:TableCell>
                  </asp:TableRow>
                  <asp:TableRow>
                    <asp:TableCell width="93">Membership Type: </asp:TableCell>
                    <asp:TableCell width="123" align="center"><asp:Label ID="lblmembertype" runat="server" />
</asp:TableCell><asp:TableCell width="109">Credit card type: </asp:TableCell><asp:TableCell width="152" align="left"><asp:DropDownList ID="cmbcard" runat="server"></asp:DropDownList>
</asp:TableCell></asp:TableRow><asp:TableRow  runat="server">
                    <asp:TableCell>First Name : </asp:TableCell><asp:TableCell align="left"><asp:TextBox ID="txtfname" runat="server" onkeypress= "isValidAlpha(event)" MaxLength="20"/>
</asp:TableCell><asp:TableCell>Last Name : </asp:TableCell><asp:TableCell align="center"><asp:TextBox ID="txtlname" runat="server" onkeypress= "isValidAlpha(event)" MaxLength="20"/>
</asp:TableCell></asp:TableRow  ><asp:TableRow>
                    <asp:TableCell>Card No. : </asp:TableCell><asp:TableCell><asp:TextBox ID="txtcardno" runat="server" MaxLength="13" onkeypress= "keypress(event)"  />
</asp:TableCell><asp:TableCell>Expiration : </asp:TableCell><asp:TableCell><asp:DropDownList ID="cmbexpmonth" runat="server"></asp:DropDownList><asp:DropDownList ID="cmbexpyear" runat="server"></asp:DropDownList>
</asp:TableCell></asp:TableRow ><asp:TableRow runat="server">
                    <asp:TableCell>Security code: </asp:TableCell><asp:TableCell><asp:TextBox ID="txtsec" runat="server"  MaxLength="3" onkeypress= "keypress(event)" />
</asp:TableCell><asp:TableCell>Phone Number: </asp:TableCell><asp:TableCell><asp:TextBox ID="txtnumber" runat="server" MaxLength="8" onkeypress= "keypress(event)" />
</asp:TableCell></asp:TableRow><asp:TableRow runat="server">
                    <asp:TableCell>Address : </asp:TableCell><asp:TableCell><asp:TextBox ID="txtaddr1" runat="server" TextMode="MultiLine" />
<br/>
                      </asp:TableCell><asp:TableCell>Pincode:</asp:TableCell><asp:TableCell><asp:TextBox ID="txtpin" runat="server"  MaxLength="6" onkeypress= "keypress(event)" />
</asp:TableCell></asp:TableRow><asp:TableRow runat="server">
                    <asp:TableCell>Country : </asp:TableCell><asp:TableCell>
                    <asp:UpdatePanel ID="upcounrty" runat="server">
                    <ContentTemplate>
                    <asp:DropDownList ID="cmbcountry" runat="server" 
              AutoPostBack="True" onselectedindexchanged="cmbcountry_SelectedIndexChanged">
			<asp:ListItem value="cmbcountryselect">Select</asp:ListItem>
        </asp:DropDownList>
        </ContentTemplate>
        </asp:UpdatePanel>
</asp:TableCell><asp:TableCell>State : </asp:TableCell><asp:TableCell>
<asp:UpdatePanel ID="upstate" runat="server">
                    <ContentTemplate>
<asp:DropDownList ID="cmbstate" 
            runat="server" AutoPostBack="True" Enabled="False" 
              onselectedindexchanged="cmbstate_SelectedIndexChanged">        </asp:DropDownList>
      </ContentTemplate>
      </asp:UpdatePanel>
</asp:TableCell></asp:TableRow><asp:TableRow runat="server">
                    <asp:TableCell>City:</asp:TableCell><asp:TableCell>
                    <asp:UpdatePanel ID="upcity" runat="server">
                    <ContentTemplate>
                    <asp:DropDownList ID="cmbcity" runat="server" AutoPostBack="True" Enabled="False" 
              onselectedindexchanged="cmbcity_SelectedIndexChanged">        </asp:DropDownList>
              </ContentTemplate>
              </asp:UpdatePanel>
</asp:TableCell><asp:TableCell>&nbsp;</asp:TableCell><asp:TableCell>&nbsp;</asp:TableCell></asp:TableRow><asp:TableRow runat="server">
                    <asp:TableCell ColumnSpan="4" align="center">
                    
                    <asp:Button ID="cmdsubmit" runat="server" 
                            Text="SUBMIT" OnClick= "cmdsubmit_Click"/>
                           
</asp:TableCell></asp:TableRow></asp:Table>

     
<br /><asp:Label ID="lblerror" runat="server" 
                    ForeColor="Red" Text="All Fileds Are Mandatory" Visible="False"></asp:Label>
                    </br>
                    <asp:RegularExpressionValidator ID="creditcardRegularExpressionValidator" 
                        runat="server" 
                        Display="Dynamic" 
                        ControlToValidate="txtcardno" 
                        ErrorMessage="Enter valid credit card number." 
                        ValidationExpression="[0-9]{13}" >
 </asp:RegularExpressionValidator>
 <asp:RegularExpressionValidator ID="securitycodeRegularExpressionValidator" 
                        runat="server" 
                        Display="Dynamic" 
                        ControlToValidate="txtsec" 
                        ErrorMessage="Enter valid security code." 
                        ValidationExpression="[0-9]{3}" >
 </asp:RegularExpressionValidator>
 <asp:RegularExpressionValidator ID="phonenoRegularExpressionValidator" 
                        runat="server" 
                        Display="Dynamic" 
                        ControlToValidate="txtsec" 
                        ErrorMessage="Enter valid phone number." 
                        ValidationExpression="[0-9]{8}" >
 </asp:RegularExpressionValidator>
  <asp:RegularExpressionValidator ID="pinRegularExpressionValidator" 
                        runat="server" 
                        Display="Dynamic" 
                        ControlToValidate="txtpin" 
                        ErrorMessage="Enter valid pin number." 
                        ValidationExpression="[0-9]{6}" >
</asp:RegularExpressionValidator>
                    </div>
			


                   
                    </div></div><!-- end content --><!-- start sidebars --><div id="sidebar2" class="sidebar">
			<ul>
			  <li> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:LinkButton ID="lnksignout" runat="server" onclick="lnksignout_Click" >SIGN OUT</asp:LinkButton>
                </li>
				<li></li>
			  <li></li>
		  </ul>
		</div>
		<!-- end sidebars -->
		<div style="clear: both;">&nbsp;</div></div><!-- end page --></div></div><div id="footer">
<div id="footer-bg">
	<p class="copyright">&copy;&nbsp;&nbsp;2010 All Rights Reserved &nbsp;&bull;&nbsp; Design bybsp; Design by Design by<a> iBtions Infologies </a>.</p>
	<p class="link"><a href="#">Privacy Policy</a>&nbsp;&#8226;&nbsp;<a href="#">Terms of Use</a></p>
</div>
</div>
 </form>
</body>
</html>

