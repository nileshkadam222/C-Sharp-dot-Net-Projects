<%@page import="ser.Admin_Ser"%>
<%@page import="Conn.GenUtility"%>
<%@page import="java.sql.*"%>
<%@include file="header/header_Client.jsp"%>
<%
   String para = request.getParameter("Id");
               // out.println(bus_no);
               String[] parts = para.split(":");
               String bus_no = parts[0];
               String traveldt = parts[1];
               String seatno = parts[2];

               Connection conn = null;
               PreparedStatement ps = null;
               ResultSet rs = null;
               Statement st = null;
               GenUtility gen = new GenUtility();
               String sql = "";
    try{
          sql="update cust_reserv set active='N' where busno='"+bus_no+"' and travel_dt='"+traveldt+"' and seatno='"+seatno+"'";
         // System.out.println("sql "+sql);
          conn=gen.dbconnection();
          ps=conn.prepareStatement(sql);
          ps.executeUpdate();
          sql="update bus_reserv set tag='1' where busno='"+bus_no+"' and travel_dt='"+traveldt+"' and seatno='"+seatno+"'";
         
          ps=conn.prepareStatement(sql);
          ps.executeUpdate();
        }catch(Exception E){
            System.out.println("Exception at y_agent "+E);
            }
%>
<div class="main">
  <section id="content">
  <!--LEFT HAND SIDE ENDS-->
		<!--CHANGING PART-->
    <article class="colA pad_left1">
        <br>
        <br>
        <br>
        <center>


            <table>

                <tr><td colspan="2"><font color="blue"><h3>Reservation for seat <%=seatno%> Has been cancel. Thank you</h4></font></td></tr>


            </table>





        </center>

    </article>
  </section>
</div>
<%

%>
<script>
    function  CheckForm(){
        var user=document.frmName.username.value;
        var name=document.frmName.name.value;
        var email=document.frmName.email.value;
        var Type=document.frmName.city.value;
       // alert(Type);
        if(user==""){

            alert("Please write username");
            return false;
        }
        else if(name==""){
            alert("Please write name");
            return false;
        }else if(email==""){
            alert("Please write email id");
            return false;
        }else if(city==""){
             alert("Please write city name");
            return false;
        }
       else{
            return true;
        }


    }
</script>
