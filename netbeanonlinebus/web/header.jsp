
<jsp:directive.page import="com.onlinebus.beans.MemberBean"/>

<link rel="stylesheet" type="text/css" href="<%=request.getContextPath()%>/css/jquery-datepicker.css">
<link rel="stylesheet" type="text/css" href="<%=request.getContextPath()%>/css/header.css">
<link rel="stylesheet" type="text/css" href="<%=request.getContextPath()%>/css/index.css">
<link rel="stylesheet" type="text/css" href="<%=request.getContextPath()%>/css/loadAvailableBuses.css">
<link rel="stylesheet" type="text/css" href="<%=request.getContextPath()%>/css/admincss.css">

<script type="text/javascript" src="<%=request.getContextPath()%>/js/jquery-1.10.2.min.js"></script>
<script type="text/javascript" src="<%=request.getContextPath()%>/js/jquery-ui.js"></script>
<script type="text/javascript" src="<%=request.getContextPath()%>/js/header.js"></script>
<script type="text/javascript" src="<%=request.getContextPath()%>/js/register.js"></script>
<script type="text/javascript" src="<%=request.getContextPath()%>/js/login.js"></script>
<script type="text/javascript"> var path ="<%=request.getContextPath()%>";</script>
<script type="text/javascript" src="<%=request.getContextPath()%>/js/index.js"></script>
<script type="text/javascript" src="<%=request.getContextPath()%>/js/ticketcancellation.js"></script>

<div class="wrapperheader">
	<div class="topheader">
		<div class="logoheader">
			<a href ="<%=request.getContextPath()%>"><img src="<%=request.getContextPath() %>/images/logo.png" style ="height:80px;width:160px;"></a>
		</div><%--
		
		<div class="searchheader">
			<div class="searchtextdiv">
				<div style="float: right;">
					<input type="image" src="<%=request.getContextPath() %>/images/rsz_search.png">
				</div>	
				<div style="float: right;padding-top: 15px">
					<input type="text" style="border: 1px solid #606860" class="searchtextbox">
				</div>
			</div>
			<div class="clear"></div>
		</div>
		--%><div class="clear"></div>
	</div>
	
	<div class="downheader">
		<div class="leftlinks">
			<a href ="<%=request.getContextPath()%>">HOME</a>
			
			
			<div class="clear"></div>
		</div>
		
		<div class="rightlinks">
			<%
			MemberBean memberBean = (MemberBean)request.getSession().getAttribute("MemberBean");
			if(memberBean == null)
			{%>
				<span> Hi Guest</span>
			<%}else{%>
			 	<span style="color:blue; font: italic;"> Hi <%=memberBean.getMemberFirstname()%></span>
			 	<script type="text/javascript">loginFlag=true;</script>
			<%}%>
			
			<%if(memberBean == null)
			{%>
				<a href="javascript:void(0);" onClick="headerObj.login_popup();">LOGIN</a>
				<a href="javascript:void(0);"  onClick="headerObj.register_popup();">REGISTER</a>
			<%}else{ %>
				<a href="<%=request.getContextPath()%>/jsp/myAccount.jsp">MyAccount</a>
				<a href="<%=request.getContextPath()%>/jsp/ticketcancellation.jsp">Cancellation</a>
				<a href="<%=request.getContextPath()%>/jsp/logout.jsp"  >Signout</a>
			<%} %>
			<div class="clear"></div>
		</div>
	</div>

</div>

<div id="background">
</div>
	<div id="registerbox">
		<div align="center" style="font-size:16px; font-weight:bold;">
			Register Here
		</div><br>
		<div id="validationall" style="border-style: solid;">
			
		</div><br>
		
		<div align="left">
			Email Address:
		</div>
		<div align="left">
			<input type="text" id="email" name="email"  class="inputBox"  onblur="registrObj.emailAvailable(this.value);">
		</div><br>
		
		<div align="left">
			First Name:
		</div>
		<div align="left">
			<input type="text" id="name" name="name" class="inputBox" >
		</div><br>

		<div align="left">
			Last Name:
		</div>
		<div align="left">
			<input type="text" id="lastname" name="lastname" class="inputBox">
		</div><br>
						
		<div align="left">
			Mobile Number:
		</div>
		<div align="left">
			<input type="text" id="mobileno" name="mobileno"  class="inputBox">
		</div><br>

		<div align="left">
			Address
		</div>
		<div align="left">
			<input type="text" id="address" name="address"  class="inputBox" >
		</div><br>
				
		<div align="left">
			Your Password:
		</div>
		<div align="left">
			<input type="password" id="password" name="password"  value="" class="inputBox">
		</div><br>
				
		<div align="left">
			Confirm Password:
		</div>
		<div align="left">
			<input type="password" id="confirmpassword" name="confirmpassword" class="inputBox">
		</div><br>
				
		<div align="left">
			<a href="javascript:void(0);" class="button_style" id="submit" onclick="return registrObj.checkValidation();">REGISTER</a>
			<a href="javascript:void(0);" class="button_style" onClick="headerObj.popup_cancel();">CANCEL</a>
		</div>
	</div><%-- register div close--%>
			
	<div id="loginbox">
		<div>
			LOGIN 
		</div><br/>
		<div id="signin_error_message">
			<span id="login_error_msg" style="color:red"></span>	
		</div><br/>

		<div align="left">
			Email Id:
		</div>
		<div align="left">
			<input type="text" id="login_email" name="login_email" maxlength="50" class="inputBox">
		</div><br/>
				
		<div align="left">
			Password:
		</div>
		<div align="left">
			<input type="password" id="login_password" name="login_password" maxlength="50" class="inputBox">
		</div><br/>

		<div align="left">
			<a href="javascript:void(0);" class="button_style"  onClick="return loginObj.check_login_validation();">LOGIN</a>
			<a href="javascript:void(0);" class="button_style"  onClick="headerObj.popup_cancel();">CANCEL</a>
			<a href="javascript:void(0);" onclick="headerObj.popupOpenRegister();">register now</a>
		</div>
		
		
		
	</div>
			
	