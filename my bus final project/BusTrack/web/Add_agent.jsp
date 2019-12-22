<%@page import="ser.Admin_Ser"%>
<%@include file="header/header_Admin.jsp"%>
<%
     String error=(String)session.getAttribute("ADD_AGENT");
     int value=Admin_Ser.new_agent;
%>
<div class="main">
  <section id="content">
  <!--LEFT HAND SIDE ENDS-->
		<!--CHANGING PART-->
    <article class="colA pad_left1">
    <center>
          <h2> Please Enter the User Detail</h2>
        <%
         if(error!=null){
             if(value==1){

      %>
      <h4><font color="Red"><strong><%=error%></strong></font></h4>
      <%
     }
        }
        %>

             <form name="frmName" action="AdminSer?do=insertagent" method="post" onsubmit="return CheckForm();">
            <table>
                <tr><td>Agent Name :</td><td><input type="text" value="" name="user_name"></td></tr>
                  <tr><td colspan="2">&nbsp;</td></tr>
                 <tr><td>Agent Username :</td><td><input type="text" value="" name="user"></td></tr>
                   <tr><td colspan="2">&nbsp;</td></tr>
                 <tr><td>Agent Password :</td><td><input type="password" value="" name="password"></td></tr>
                   <tr><td colspan="2">&nbsp;</td></tr>
                 <tr><td>Agent City :</td>
                     <td>
                     <input type="text" value="" name="city">
                     </td></tr>

                 <tr><td colspan="2">&nbsp;</td></tr>

                  <tr><td>Agent Email ID :</td>
                     <td>
                     <input type="text" value="" name="email">
                     </td></tr>

                 <tr><td colspan="2">&nbsp;</td></tr>
                 <tr><td colspan="2"><font color="blue"><input type="Submit" value="Add Agent" /></font></td></tr>


            </table>



        </form>

    </center>

    </article>
  </section>
</div>
<%
Admin_Ser.new_agent=0;
%>
<script>
    function  CheckForm(){
       // alert("hi");
        var name=document.frmName.user_name.value;
        var username=document.frmName.user.value;
        var pass=document.frmName.password.value;
        var city=document.frmName.city.value;
        var id=document.frmName.email.value;
        if(name==""){
            alert("Please enter Name");
            return false;
        }else if(username==""){
             alert("Please enter Username");
            return false;
        }else if(pass==""){
             alert("Please enter Password");
            return false;
        }else if(city==""){
            alert("Please enter City");
            return false;
        }else if(id==""){
             alert("Please enter Email ID");
            return false;
        }else {
            return true;
        }
    }
</script>
