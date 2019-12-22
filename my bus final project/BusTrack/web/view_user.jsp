<%@page import="Conn.GenUtility"%>
<%@page import="java.sql.*"%>
<%@include file="header/header_Admin.jsp"%>
<%
 Connection conn=null;
    PreparedStatement ps=null;
    ResultSet rs=null;
    Statement st=null;
    GenUtility gen=new GenUtility();
    String sql="";

    try{
           sql="select name,username,city,emailid,dt from user_table where tag=3";
           conn=gen.dbconnection();
           ps=conn.prepareStatement(sql);
           rs=ps.executeQuery();

      }
    catch(Exception E){
        System.out.println("Exception at viw_user "+E);
        }
%>
<div class="main">
  <section id="content">
  <!--LEFT HAND SIDE ENDS-->
		<!--CHANGING PART-->
    <article class="colA pad_left1">
        <h5><a href="Add_user.jsp"> ADD User</a></h5>
        <center> <h3><strong>User Detail</strong></h3></center>
        <center>
        <form>
            <table border="1" width="650">
                <tr>
                    <td><Strong>Name</Strong></td>
                    <td><Strong>Username</Strong></td>
                    <td><Strong>City</Strong></td>
                    <td><Strong>Email ID</Strong></td>
                     <td><Strong>Date(YYYY/MM/dd)</Strong></td>
                </tr>
                <%
                 while(rs.next()){

                 %>
                 <tr>
                     <td><%=rs.getString(1)%></td>
                     <td><%=rs.getString(2)%></td>
                     <td><%=rs.getString(3)%></td>
                     <td><%=rs.getString(4)%></td>
                     <td><%=rs.getString(5)%></td>
                 </tr>
                 <%
                     }
                %>
            </table>
        </form>
        </center>


    </article>
  </section>
</div>

