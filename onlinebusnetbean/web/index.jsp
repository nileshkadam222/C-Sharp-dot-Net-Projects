<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<script type="text/javascript" src="<%=request.getContextPath()%>/js/jquery-1.10.2.min.js"></script>
<script type="text/javascript">
$(document).ready(function()
{

 $("#datepicker").datepicker(
 	{
		minDate: 0,
		changeMonth: true,
		changeYear: true,
		dateFormat:"yy-mm-dd",
	    setDate: new Date()   
	});
	$("#datepicker").datepicker("setDate", new Date());
});

</script>

<title>Bus Reservation</title>
</head>
<body>
<div class="headerdiv">
<%@ include file="header.jsp" %>
</div>

<div class="contentdiv">
<%
String status = request.getParameter("status");

if("fail".equals(status)){
status = "Some Error Occured during  process";
}
else
status = "";
%>
<div>
<%=status%>
</div>

	<div class="routeSearchMain">
		<div class="cmnSearch">
		<div class="errordiv" id ="errordiv"></div>
			<div class="searchLft">
				<span class="blackText">From</span><span style= "color:red">*</span>
				<form action="<%=request.getContextPath()%>/jsp/loadAvailableBuses.jsp" method="post">
				<input id="DDLSource"  placeholder="Enter a city" type="text" tabindex="1"  name="DDLSource"  onkeyup="indexObj.search_from_city();" maxlength="20" >
			</div>
			
			<div class="searchRht">
				<span class="blackText">To</span><span style= "color:red">*</span>
				<input id="DDLDestination" placeholder="Enter a city" type="text" tabindex="2" name="DDLDestination" onkeyup="indexObj.search_to_city();" maxlength="20">
			</div>
		</div><!-- cmnsearch close -->
		
		
		<div class="btmRow">
			<div class="searchLft">
				<span class="blackText">Date of Journey</span>
					<input id="datepicker" name="datepicker" placeholder="yyyy-mm-dd" type="text" tabindex="3" readonly="readonly" class="datepicker">
					
					
			</div>               
		</div><br><br><br><br><br><br>
		<div class="seatcount_bustypediv">
			<span class="blackText">Seat Count</span>&nbsp;&nbsp;&nbsp;
			<input id="SeatCount" placeholder="Enter seat count" type="text" tabindex="4"  name="seatCount" maxlength="2">
			<br><br>
			<span class="blackText">Bus Type</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			
			<select style="width:120px;" tabindex="5" name="bus_type" id="bus_type">
			  <option value="SELECT">SELECT</option>
			  <option value="A/C-Sleeper">A/C-Sleeper</option>
			  <option value="A/C-Non-Sleeper">A/C-Non-Sleeper</option>
			  <option value="NON A/C-Sleeper">NON A/C-Sleeper</option>
			  <option value="NON A/C-Non-Sleeper">NON A/C-Non-Sleeper</option>
			</select>
			
		</div>
			
		<input type="hidden" value="loadAllBuses" name="pageType">
		<div class="searchbuttonbox">
		
			<input type="submit" value=" Search Buses " class="searchBtn" onclick="return indexObj.isCityEqual();" id="searchBtn" name="searchBtn" tabindex="6" style="margin-top:0;">
			
		</div>
		</form>
	
	</div>

</div>

<div class="footerdiv">
<%@ include file="footer.jsp" %>
</div>

</body>
</html>