<%@page import="ser.ValidateSer"%>
<%@include file="header/header.jsp" %>
<%@include file="left.jsp" %>
   <article class="col2 pad_left1">
      <h2>Please enter the Username and password !</h2>
<%
        String error=null;
         error=(String)session.getAttribute("Error_Login");
         int value=ValidateSer.counter_log;

        if(error!=null ){
            if(value==1){
        %>
        <h4><center><font color="red"><strong><%=error%></strong></font></center></h4>
        <%

         }
         }

        

%>
      
      <div class="wrapper" align="left">
            <form name="frmName" action="ValidateSer" method="post" onsubmit="return CheckForm();">
    <table>
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
    </table>

</form>




        </div>
      <article class="cols">
          <h2>Our Client</h2>
          <p><strong>Avero eoset</strong> accusamus et iusto odio dig- nissimos ducimus qui blanditiis praesentium voluptatum deleniti.</p>
         
        </article>
     
<%
ValidateSer.counter_log=0;
%>
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
