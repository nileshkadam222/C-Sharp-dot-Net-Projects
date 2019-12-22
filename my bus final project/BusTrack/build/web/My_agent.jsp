<%@page import="ser.Admin_Ser"%>
<%@page import="Conn.GenUtility"%>
<%@page import="java.sql.*"%>
<%@include file="header/header_Client.jsp"%>
<%
 //   int value=Admin_Ser.new_bus;

    Connection conn=null;
    PreparedStatement ps=null;
    ResultSet rs=null;
    Statement st=null;
    GenUtility gen=new GenUtility();
    String sql="";
    try{
         sql="select name,username,city,emailid from user_table where tag in (2,3) and username='"+username_sess+"' and name='"+name_sess+"'";
        // System.out.println("sql "+sql);
         conn=gen.dbconnection();
           ps=conn.prepareStatement(sql);
           rs=ps.executeQuery();

        }catch(Exception E){
            System.out.println("Exception at y_agent "+E);
            }
%>
<div class="main">
  <section id="content">
  <!--LEFT HAND SIDE ENDS-->
		<!--CHANGING PART-->
    <article class="colA pad_left1">
        <center>
        <h2>Personal Information</h2>
          
          <form name="frmName" action="ClientSer?do=insert" method="post" onsubmit="return CheckForm();">
            <table>
                <% while(rs.next()){
                    %>
                    <tr><td>Username :</td><td><input type="text" value="<%=rs.getString(2)%>" name="username" disabled/></td></tr>
                  <tr><td colspan="2">&nbsp;</td></tr>
                 <tr><td>My Name :</td><td><input type="text" value="<%=rs.getString(1)%>" name="name"/></td></tr>
                   <tr><td colspan="2">&nbsp;</td></tr>
                 <tr><td>My Email ID :</td><td><input type="text" value="<%=rs.getString(4)%>" name="email"/></td></tr>
                   <tr><td colspan="2">&nbsp;</td></tr>
                 <tr><td>MY City :</td>
                     <td><input type="text" value="<%=rs.getString(3)%>" name="city"/></td></tr>
                 <tr><td colspan="2">&nbsp;</td></tr>
                 <%}%>
                 <tr><td colspan="2"><font color="blue"><input type="Submit" value="&nbsp;UPDATE&nbsp;" /></font></td></tr>


            </table>



        </form>

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
