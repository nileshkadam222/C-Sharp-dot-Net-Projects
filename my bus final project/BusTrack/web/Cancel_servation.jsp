<%@page import="Conn.GenUtility"%>
<%@page import="java.sql.*"%>
<%@include file="header/header_Client.jsp"%>

<%
    Connection conn=null;
    PreparedStatement ps=null;
    ResultSet rs=null;
    Statement st=null;
    GenUtility gen=new GenUtility();
    boolean flag=false;
    int counter=0;
try{
            String sql="select busno,travel_dt,seatno,custname from CUST_reserv where username='"+username_sess+"' and active='Y'";
            System.out.println("sql "+sql);
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
        <form name="frmName" action="res_search_agent.jsp" method="post" onsubmit="return CheckForm();">

            <table width="750" border="5">
                
                <tr>
                      <td><Strong>Bus Number</Strong></td>
                    <td><Strong>Travel Date</Strong></td>
                    <td><Strong>Seat Number</Strong></td>
                    <td><Strong>Customer Name</Strong></td>


                </tr>
             
                <% while(rs.next())
                { counter++;
                 %>
                  <tr>
                    <td><%=rs.getString(1)%></td>
                    <td><%=rs.getString(2)%></td>
                    <td><%=rs.getString(3)%></td>
                    <td><%=rs.getString(4)%></td>
                    <td><a href=<%= "\"cancel_success.jsp?Id="+rs.getString(1)+":"+rs.getString(2)+":"+rs.getString(3)+"\"" %>>Confirm</a></td>

                </tr>
                 <%
                 }
                    if(counter!=0){
                 %>
                  <tr><td><Strong>No data Found</Strong></td></tr>
                 <%}%>
            </table>
        </form>

        </center>

    </article>
  </section>
</div>
