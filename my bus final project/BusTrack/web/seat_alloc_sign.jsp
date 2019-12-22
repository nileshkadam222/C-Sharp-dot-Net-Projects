<%@page import="Conn.GenUtility"%>
<%@page import="java.sql.*"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"
   "http://www.w3.org/TR/html4/loose.dtd">

<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <%

                   String bus_no=(String)session.getAttribute("bus_no_signup");
                   String dest=(String)session.getAttribute("dest_signup");
                   session.setAttribute("pay_bus_no_sign",bus_no);

                   Connection conn = null;
                   PreparedStatement ps = null;
                   ResultSet rs = null;
                   Statement st = null;
                   GenUtility gen = new GenUtility();

     //  String dest=(String)session.getAttribute("ser_dest");
    String bustype=(String)session.getAttribute("ser_bus_type_log");
    String no_passenger=(String)session.getAttribute("ser_passenger_log");
    String travel_dt=(String)session.getAttribute("ser_travel_dt_log");
    String sql="select  b.bus_no,a.from1,b.point,b.point_time,b.price from bus_detail a,bus_path b,bus_sch c "
+" where  a.num=b.bus_no and a.num=c.busno and a.num='"+bus_no+"' and b.point='"+dest+"' AND C.TRAVEL_DT='"+travel_dt+"'";
           conn=gen.dbconnection();
           System.out.println("sql  signup  "+sql);
           ps=conn.prepareStatement(sql);
           rs=ps.executeQuery();

    %>
    <body>

        <div>
            <center>
                <h3>Seat Allocation</h3>
                <table border="1" width="450">
                <%while(rs.next()){
                 session.setAttribute("seatprice_sign",String.valueOf(rs.getFloat(5)));

                %>
                <tr>
                    <td>Source</td><td><%=rs.getString(2)%></td>
                    <td>Destination</td><td><%=rs.getString(3)%></td>
                </tr>
                <tr>
                    <td>Bus Type</td><td><%=bustype%></td>
                    <td>Journey Date </td><td><%=travel_dt%></td>
                </tr>
                 <tr>
                    <td>Destination Time</td><td><%=rs.getString(4)%></td>
                    <td>Ticket Fare</td><td><%=rs.getFloat(5)%></td>
                </tr>
                 <tr>
                     <td colspan="4"><input type="hidden" name="price"  value="<%=rs.getFloat(5)%>"/>

                </tr>
                <%}%>
            </table>
            </center>
        </div>
        <div ><center><strong>NO of Seats to be selected :<%=no_passenger%> </strong> </center></div>
        <div>
            <center>
            <table width="700" border="1">
                <tr>
                    <td width="150"><img src="images/Non_AC.jpg" width="150" height="400"/></td>
                    <td width="450">
                       <center>
                         <%
                         sql="select seatno,tag from bus_reserv where travel_dt='"+travel_dt+"'";
                          conn=gen.dbconnection();
                          ps=conn.prepareStatement(sql);
                          rs=ps.executeQuery();
                         %>
                         <form name="frmName" method="post" action="payment_sign.jsp" onsubmit="return checkEmpty();">
                        <table  width="450">
                            <tr><td>
                             <% while(rs.next()){
                                ///System.out.println("inside "+rs.getInt(1)+" "+rs.getString(2)+"#");
                                int num=Integer.parseInt(rs.getString(2));
                                if(rs.getInt(1)==5 || rs.getInt(1)==10 || rs.getInt(1)==15 || rs.getInt(1)==20 || rs.getInt(1)==25 || rs.getInt(1)==30 || rs.getInt(1)==35){
                                  if(num==0){
                                     // System.out.println("inside side the check");
                                    %>

                                    <input type="checkbox" name="seatno" value="<%=rs.getInt(1)%>" onclick="return false;"/><%=rs.getInt(1)+"(R)"%>&nbsp;&nbsp;&nbsp;<br>
                                    <%

                                     }else if(num==1) {
                                       //  System.out.println("inside side the 1"+rs.getInt(1));
                                     %>

                                     <input type="checkbox" name="seatno" value="<%=rs.getInt(1)%>"/><%=rs.getInt(1)+"(N)"%>&nbsp;&nbsp;&nbsp;&nbsp;<br>
                                     <%

                                   } ///else

                                }///if for 5,10,15,20,25,30,35
                                else {
                                      if(num==0){
                                     // System.out.println("inside side the check");
                                    %>

                                    <input type="checkbox" name="seatno" value="<%=rs.getInt(1)%>" onclick="return false;"/><%=rs.getInt(1)+"(R)"%>&nbsp;&nbsp;&nbsp;
                                    <%

                                     }else if(num==1) {
                                       //  System.out.println("inside side the 1"+rs.getInt(1));
                                     %>

                                     <input type="checkbox" name="seatno" value="<%=rs.getInt(1)%>"/><%=rs.getInt(1)+"(N)"%>&nbsp;&nbsp;&nbsp;&nbsp;
                                     <%

                                   } ///else


                                    }


                                  }///WHILE
                              %>
                            <tr><td><input type="hidden" name="no_passenger" value="<%=no_passenger%>"/></td></tr>
                             <tr>
                                <td colspan="2"> <center><input type="submit" name="&nbsp;Next&&nbsp;"  value="&nbsp;&nbsp;Next&nbsp;&nbsp;"/></center></td>
                            </tr>

                        </table>

                         </form>
                        </center>
                    </td>

                </tr>



            </table>

        </center>
        </div>

                             <div><center>
                                 <table width="500">
                                     <tr><td><Strong>(R) Implies for Reserv Seat</Strong></td>
                                     <td><Strong>(N) Implies for Non Reserv Seat</Strong></td>
                                     </tr>
                                 </table>
                                     </center>
                             </div>

<script>
    function checkEmpty(){
       // alert("HI");
        var flag=0;
        var actual_selection=document.frmName.no_passenger.value;
        // alert("HI"+actual_selection);
        for (var i = 0; i< 35; i++) {
            if(document.frmName["seatno"][i].checked){
            flag ++;
            }
        }
       //  alert("flag "+flag);
     if(flag==0){
         alert("Please Select the Seat ");
       return false;
     }
   else if(actual_selection<flag){
       alert("You have select more seat than you want ");
       return false;
   }else if(actual_selection>flag) {
       alert("You have select less seat than you want ");
       return false;
   }else if(actual_selection=flag){
       return true;
   }
}


</script>
    </body>
</html>
