<%@page import="ser.Admin_Ser"%>
<%@include file="header/header_Admin.jsp"%>
<%
    int value=Admin_Ser.new_bus;
%>
<div class="main">
  <section id="content">
  <!--LEFT HAND SIDE ENDS-->
		<!--CHANGING PART-->
    <article class="colA pad_left1">
        <center>
        <h2> Please Enter the Bus Detail</h2>
              <%
           String inrt_bus=(String)session.getAttribute("inser_bus_flag");
           if(inrt_bus!=null){
               if(value==1){
              %>
              <h5><font color="RED"><Strong><%=inrt_bus%></Strong></font></h5>
               <%
               }
               }

        %>
        <form name="frmName" action="AdminSer?do=insert" method="post" onsubmit="return CheckForm();">
            <table>
                <tr><td>Bus Number :</td><td><input type="text" value="" name="BusNo"></td></tr>
                  <tr><td colspan="2">&nbsp;</td></tr>
                 <tr><td>Leaving From :</td><td><input type="text" value="" name="FromSource"></td></tr>
                   <tr><td colspan="2">&nbsp;</td></tr>
                 <tr><td>Going To :</td><td><input type="text" value="" name="ToSource"></td></tr>
                   <tr><td colspan="2">&nbsp;</td></tr>
                 <tr><td>Type of Bus :</td>
                     <td>
                         <select name="bustype">
                              <option value="-1">--Select--</option>
                             <option value="AC">AC</option>
                             <option value="NONAC">Non AC</option>
                         </select>
                     </td></tr>
                 <tr><td colspan="2">&nbsp;</td></tr>
                 <tr><td colspan="2"><font color="blue"><input type="Submit" value="ADD" /></font></td></tr>
                  
                 
            </table>



        </form>
        
        </center>

    </article>
  </section>
</div>
<%
  Admin_Ser.new_bus=0;
%>
<script>
    function  CheckForm(){
        var no=document.frmName.BusNo.value;
        var From=document.frmName.FromSource.value;
        var ToSrc=document.frmName.ToSource.value;
        var Type=document.frmName.bustype.value;
       // alert(Type);
        if(no==""){

            alert("Please select Bus Number");
            return false;
        }
        else if(From==""){
            alert("Please select From source");
            return false;
        }else if(ToSrc==""){
            alert("Please select ToSource source");
            return false;
        }else if(Type=="-1" || Type==-1){
             alert("Please select Bus Type");
            return false;
        }
       else{
            return true;
        }


    }
</script>
