<%@page import="ser.Admin_Ser"%>
<%@page import="Conn.GenUtility"%>
<%@page import="java.sql.*"%>
<%@include file="header/header_Client.jsp"%>

<%
    Connection conn=null;
    PreparedStatement ps=null;
    ResultSet rs=null;
    Statement st=null;
    GenUtility gen=new GenUtility();
  

    String scr=request.getParameter("source");
    String dest=request.getParameter("destination");
    String bustype=request.getParameter("BusType");
    String no_passenger=request.getParameter("travler");
    String travel_dt=request.getParameter("datepic");
     int passenger=Integer.parseInt(no_passenger);
    /////save the value
    session.setAttribute("ser_dest",dest);
    session.setAttribute("ser_bus_type",bustype);
    session.setAttribute("ser_passenger",no_passenger);
    session.setAttribute("ser_travel_dt",travel_dt);
    int counter=0;

    try{
            String sql="select a.busno,a.frm,a.scr_time,b.point,b.point_time,b.price,count(c.seatno) from bus_sch a,bus_path b,bus_reserv c,bus_detail d "

+" where a.busno=b.bus_no and   c.busno=b.bus_no and d.num=b.bus_no  "
+" and a.frm='"+scr+"' and b.point='"+dest+"' AND  tag='1' and c.travel_dt='"+travel_dt+"' and d.type1='"+bustype+"' "
+" group by a.busno,a.frm,a.scr_time,b.point,b.point_time,b.price";

           conn=gen.dbconnection();
           ps=conn.prepareStatement(sql);
           rs=ps.executeQuery();

      }
    catch(Exception E){
        System.out.println("Exception at searchAgent "+E);
        }
%>

<div class="main">
  <section id="content">
  <!--LEFT HAND SIDE ENDS-->
		<!--CHANGING PART-->
    <article class="colA pad_left1">
        <center>
        <h2>Search Bus</h2>
        <form name="frmName" action="res_search_agent.jsp" method="post" >

            <table width="750" border="5">
                <tr>
                      <td><Strong>Bus Number</Strong></td>
                    <td><Strong>Source Loc</Strong></td>
                    <td><Strong>Source Time</Strong></td>
                    <td><Strong>Destination Loc</Strong></td>
                    <td><Strong>Destination Time</Strong></td>
                    <td><Strong>Price</Strong></td>
                    <td><Strong>Book</Strong></td>

                </tr>
                <% while(rs.next()){
                    if(passenger<=rs.getFloat(7)){
                        counter++;
                 %>
                  <tr>
                    <td><%=rs.getString(1)%></td>
                    <td><%=rs.getString(2)%></td>
                    <td><%=rs.getString(3)%></td>
                    <td><%=rs.getString(4)%></td>
                    <td><%=rs.getString(5)%></td>
                    <td><%=rs.getFloat(6)%></td>
                    <td><a href=<%= "\"seat_Allocation.jsp?Id="+rs.getString(1)+":"+rs.getString(4)+"\"" %>>Confirm</a></td>

                </tr>
                 <%
                 }


                    }
                    if(counter==0){
                    %>
                    <tr><td align="center"><strong>No Data Found</strong><td></tr>
                    <%
                    }
                %>


            </table>
        </form>

        </center>

    </article>
  </section>
</div>
<%

%>
