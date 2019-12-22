<%@page import="ser.Admin_Ser"%>
<%@page import="Conn.GenUtility"%>
<%@page import="java.sql.*"%>
<%@include file="header/header_log.jsp"%>
<%
    String para = request.getParameter("Id");
                   // out.println(bus_no);
                   String[] parts = para.split(":");
                   String bus_no = parts[0];
                   session.setAttribute("pay_bus_no",bus_no);
                   String dest = parts[1];
                   System.out.println(bus_no+" "+dest);

                   session.setAttribute("bus_no_signup",bus_no);
                   session.setAttribute("dest_signup",dest);
%>
  <div class="main">
  <section id="content">
  <!--LEFT HAND SIDE ENDS-->
		<!--CHANGING PART-->
    <article class="colA pad_left1">
           <center>
       <form name="frmName" action="VisitSer?do=login" method="post" onsubmit="return CheckForm();">
        
           <h2>Please do Sign in </h2>
           <table>
               <tr>
                   <td><input type="hidden" name="busno" value="<%=bus_no%>"></td>
                     <td><input type="hidden" name="destination" value="<%=dest%>"></td>
               </tr>
               <tr>
                   <td><strong>Username &nbsp;&nbsp;&nbsp;</strong> </td>
                   <td><input type="text" name="username" onkeyup="this.value=this.value.toUppercase();" value=""></td>
               </tr>
               <tr>
                   <td>
                   <td colspan="2">&nbsp;</td>
               </tr>
               <tr>
                   <td>
                   <td colspan="2">&nbsp;</td>
               </tr>
               <tr>
                   <td><strong>Password &nbsp;&nbsp;&nbsp;</strong> </td>
                   <td><input type="password" name="password" value=""></td>
               </tr>
               <tr>
                   <td>
                   <td colspan="2">&nbsp;</td>
               </tr>
               <tr>
                   <td>
                   <td colspan="2">&nbsp;</td>
               </tr>
               <tr>
                   <td colspan="2"><input type="submit" name="Login"></td>

               </tr>
               <tr><td colspan="2"><a href="new_sign.jsp">Create New User</a></td></tr>

           </table>
           
       </form>
       </center>



        </div>
      </article>
  </section>
</div>

<script>
    function  CheckForm(){
        var user=document.frmName.username.value;
        var pass=document.frmName.password.value;

        if(user=="" && pass==""){
           alert("Please Enter the Username and Password");
            return false;
        }else if(pass==""){
            alert("Please Enter the Password");
            return false;
        }else if( user==""){

               alert("Please Enter the Username");
              return false;
        }else{
            return true;
        }

    }
</script>
