<%@page import="ser.Admin_Ser"%>
<%@include file="header/header.jsp"%>
<div class="main">
  <section id="content">
   
    <article class="colA pad_left1">
        <center>
      <h2>Feedback Form</h2>
      <%
   String error=(String)session.getAttribute("ADD_CONTACT");
   int value=Admin_Ser.new_feedback;
      if(error!=null){
          if(value==1){
              %>
               <h5><font color="RED"><Strong><%=error%></Strong></font></h5>
              <%
              }
          }

%>
      <form name="frmName" action="AdminSer?do=contactForm" method="post" onsubmit="return check();">
          <table>
              <tr><td>Your Name:</td><td><input type="text" name="user_name" class="input" /></td>
              </tr>
               <tr><td colspan="2">&nbsp;</td></tr>
              <tr><td>Your E-mail:</td>
              <td><input type="text" name="emailid" class="input" /></td>
              </tr>
               <tr><td colspan="2">&nbsp;</td></tr>
              <tr>
                  <td>Your FeedBack Message</td>
              <td><textarea  name="msg" cols="25" rows="5"></textarea></td>
              </tr>
              <tr><td colspan="2">&nbsp;</td></tr>
              <tr>
                  <td colspan="2"><input type="submit" name="Submit" value="Submit"/></td>
                 
              </tr>
          </table>
      </form>
        </center>
    </article>
  </section>
</div>
          <script>
              function check(){
                  var name=document.frmName.user_name.value;
                  var emailid=document.frmName.emailid.value;
                  var msging=document.frmName.msg.value;

                  if(name==""){
                      alert("Please enter your name");
                      return false;
                  }else if(emailid==""){
                       alert("Please enter your email");
                      return false;
                  }else if(msging==""){
                       alert("Please enter your feedback");
                      return false;
                  }else {
                      return true;
                  }
              }
               function ResetFun(){
               document.frmName.user_name.value="";
               document.frmName.emailid.value="";
               docuent.frmName.msg.value="";
    }
          </script>