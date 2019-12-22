<%--
    Document   : payment
    Created on : 12 Mar, 2014, 11:25:52 PM
    Author     : ind
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"
   "http://www.w3.org/TR/html4/loose.dtd">

<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">

        <%
          String no_passenger=(String)session.getAttribute("ser_passenger_log");
          int no=Integer.parseInt(no_passenger);
          String[] seat=request.getParameterValues("seatno");
          String concat="";
          for(int i=0;i<seat.length;i++){
              //System.out.println(" i "+seat[i]);
              if(seat.length==1){
                    concat=seat[i];
                  }
              else{
              concat=seat[i]+":"+concat;
              }
              }
         session.setAttribute("seat_list_sign",concat);

             // System.out.println("concat "+concat);
      //    System.out.println("no_passenger "+no_passenger);
        %>
        <script>
            function checkSumbit(){
              //  alert("HI");
                var passenger=documnet.frmName.passenger.value;
                alert("passener"+passenger);
                if(passenger=="01"){
                var mob=documnet.frmName.mobile.value;
                var email=documnet.frmName.emailid.value;
                var cardno=documnet.frmName.cardno.value;
                var cardname=documnet.frmName.cardname.value;
                var cww=documnet.frmName.cardcww.value;
                var name1=documnet.frmName.name1.value;
                var gender1=documnet.frmName.gender1.value;
                var age1=documnet.frmName.age1.value;
                 if(name1=""){
                     alert("Please enter name1");
                     return false;
                 }
                 else if(gender1=="-1"){
                      alert("Please select gender 1");
                     return false;
                 }
                 else if(age1=="-1"){
                     alert("Please select age");
                     return false;
                 }
                 else if(mob==""){
                      alert("Plase enter the mobile nuber");
                     return false;
                 }
                 else if(email==""){
                      alert("Please enter the email id");
                     return false;
                 }else if(cardno==""){
                     alert("Please enter card number");
                     return false;
                 }else if(cardname==""){
                      alert("Please enter card name");
                     return false;
                 }else if(cww==""){
                       alert("Please enter the CWW Number");
                     return false;
                 }else {
                     return true;
                 }
                }///if no ===1
            }
        </script>
    </head>
    <body>
        <div align="center">
            <h2> Paasenger(s) & Payent Details</h2>
            <form name="frmName"  action="CustSer?do=payment_sign" method="post" onsubmit="return checkSumbit();">
            <table width="800" border="1" height="450">
                <tr><td><input type="hidden" name="passenger" value="<%=no_passenger%>"/></td></tr>
                <% if(no==1){%>
            <tr>
                <td>Customer Name1 </td><td><input type="text" name="name1"/></td>
                <td>Gender</td><td><select name="gender1">
                                <option value="-1">--select--</option> <option value="Male">Male</option>
                                <option value="Female">Female</option>
                    </select></td>
                <td>Age</td><td><input type="text" name="age1"/></td>
            </tr>
            <%}  else if(no==2){%>
             <tr>
                <td>Customer Name1 </td><td><input type="text" name="name1"/></td>
                <td>Gender</td><td><select name="gender1">
                                <option value="-1">--select--</option> <option value="Male">Male</option>
                                <option value="Female">Female</option>
                    </select></td>
                <td>Age</td><td><input type="text" name="age1"/></td>
            </tr>

             <tr>
                <td>Customer Name2 </td><td><input type="text" name="name2"/></td>
                <td>Gender</td><td><select name="gender2">
                                <option value="-1">--select--</option> <option value="Male">Male</option>
                                <option value="Female">Female</option>
                    </select></td>
                <td>Age</td><td><input type="text" name="age2"/></td>
            </tr>

            <%} else if(no==3){%>
             <tr>
                <td>Customer Name1 </td><td><input type="text" name="name1"/></td>
                <td>Gender</td><td><select name="gender1">
                                <option value="-1">--select--</option> <option value="Male">Male</option>
                                <option value="Female">Female</option>
                    </select></td>
                <td>Age</td><td><input type="text" name="age1"/></td>
            </tr>

             <tr>
                <td>Customer Name2 </td><td><input type="text" name="name2"/></td>
                <td>Gender</td><td><select name="gender2">
                                <option value="-1">--select--</option> <option value="Male">Male</option>
                                <option value="Female">Female</option>
                    </select></td>
                <td>Age</td><td><input type="text" name="age2"/></td>
            </tr>

             <tr>
                <td>Customer Name3 </td><td><input type="text" name="name3"/></td>
                <td>Gender</td><td><select name="gender3">
                                <option value="-1">--select--</option> <option value="Male">Male</option>
                                <option value="Female">Female</option>
                    </select></td>
                <td>Age</td><td><input type="text" name="age3"/></td>
            </tr>

            <%} else if(no==04){%>
              <tr>
                <td>Customer Name1 </td><td><input type="text" name="name1"/></td>
                <td>Gender</td><td><select name="gender1">
                                <option value="-1">--select--</option> <option value="Male">Male</option>
                                <option value="Female">Female</option>
                    </select></td>
                <td>Age</td><td><input type="text" name="age1"/></td>
            </tr>

             <tr>
                <td>Customer Name2 </td><td><input type="text" name="name2"/></td>
                <td>Gender</td><td><select name="gender2">
                                <option value="-1">--select--</option> <option value="Male">Male</option>
                                <option value="Female">Female</option>
                    </select></td>
                <td>Age</td><td><input type="text" name="age2"/></td>
            </tr>

             <tr>
                <td>Customer Name3 </td><td><input type="text" name="name3"/></td>
                <td>Gender</td><td><select name="gender3">
                                <option value="-1">--select--</option> <option value="Male">Male</option>
                                <option value="Female">Female</option>
                    </select></td>
                <td>Age</td><td><input type="text" name="age3"/></td>
            </tr>

              <tr>
                <td>Customer Name4 </td><td><input type="text" name="name4"/></td>
                <td>Gender</td><td><select name="gender4">
                                <option value="-1">--select--</option> <option value="Male">Male</option>
                                <option value="Female">Female</option>
                    </select></td>
                <td>Age</td><td><input type="text" name="age4"/></td>
            </tr>


            <%} else if(no==05){%>
                   <tr>
                <td>Customer Name1 </td><td><input type="text" name="name1"/></td>
                <td>Gender</td><td><select name="gender1">
                                <option value="-1">--select--</option> <option value="Male">Male</option>
                                <option value="Female">Female</option>
                    </select></td>
                <td>Age</td><td><input type="text" name="age1"/></td>
            </tr>

             <tr>
                <td>Customer Name2 </td><td><input type="text" name="name2"/></td>
                <td>Gender</td><td><select name="gender2">
                                <option value="-1">--select--</option> <option value="Male">Male</option>
                                <option value="Female">Female</option>
                    </select></td>
                <td>Age</td><td><input type="text" name="age2"/></td>
            </tr>

             <tr>
                <td>Customer Name3 </td><td><input type="text" name="name3"/></td>
                <td>Gender</td><td><select name="gender3">
                                <option value="-1">--select--</option> <option value="Male">Male</option>
                                <option value="Female">Female</option>
                    </select></td>
                <td>Age</td><td><input type="text" name="age3"/></td>
            </tr>

              <tr>
                <td>Customer Name4 </td><td><input type="text" name="name4"/></td>
                <td>Gender</td><td><select name="gender4">
                                <option value="-1">--select--</option> <option value="Male">Male</option>
                                <option value="Female">Female</option>
                    </select></td>
                <td>Age</td><td><input type="text" name="age4"/></td>
            </tr>

             <tr>
                <td>Customer Name 5 </td><td><input type="text" name="name5"/></td>
                <td>Gender</td><td><select name="gender5">
                                <option value="-1">--select--</option> <option value="Male">Male</option>
                                <option value="Female">Female</option>
                    </select></td>
                <td>Age</td><td><input type="text" name="age5"/></td>
            </tr>
            <%} else if(no==06){%>
                     <tr>
                <td>Customer Name1 </td><td><input type="text" name="name1"/></td>
                <td>Gender</td><td><select name="gender1">
                                <option value="-1">--select--</option> <option value="Male">Male</option>
                                <option value="Female">Female</option>
                    </select></td>
                <td>Age</td><td><input type="text" name="age1"/></td>
            </tr>

             <tr>
                <td>Customer Name2 </td><td><input type="text" name="name2"/></td>
                <td>Gender</td><td><select name="gender2">
                                <option value="-1">--select--</option> <option value="Male">Male</option>
                                <option value="Female">Female</option>
                    </select></td>
                <td>Age</td><td><input type="text" name="age2"/></td>
            </tr>

             <tr>
                <td>Customer Name3 </td><td><input type="text" name="name3"/></td>
                <td>Gender</td><td><select name="gender3">
                                <option value="-1">--select--</option> <option value="Male">Male</option>
                                <option value="Female">Female</option>
                    </select></td>
                <td>Age</td><td><input type="text" name="age3"/></td>
            </tr>

              <tr>
                <td>Customer Name4 </td><td><input type="text" name="name4"/></td>
                <td>Gender</td><td><select name="gender4">
                                <option value="-1">--select--</option> <option value="Male">Male</option>
                                <option value="Female">Female</option>
                    </select></td>
                <td>Age</td><td><input type="text" name="age4"/></td>
            </tr>

             <tr>
                <td>Customer Name 5 </td><td><input type="text" name="name5"/></td>
                <td>Gender</td><td><select name="gender5">
                                <option value="-1">--select--</option> <option value="Male">Male</option>
                                <option value="Female">Female</option>
                    </select></td>
                <td>Age</td><td><input type="text" name="age5"/></td>
            </tr>
              <tr>
                <td>Customer Name 6</td><td><input type="text" name="name6"/></td>
                <td>Gender</td><td><select name="gender6">
                                <option value="-1">--select--</option> <option value="Male">Male</option>
                                <option value="Female">Female</option>
                    </select></td>
                <td>Age</td><td><input type="text" name="age6"/></td>
            </tr>

            <%}%>
            <tr>
                <td>Mobile No</td><td colspan="2"><input type="text" name="mobile"/></td>
                <td>Email ID</td><td colspan="2"><input type="text" size="40" name="emailid"/></td>
            </tr>
            <tr>
                <td colspan="6"><Strong>Creadit or Debit Card Details</strong></td>

            </tr>
             <tr>
                 <td>Card Number</td><td colspan="5"><input type="text" size="40" name="cardno"/></td>


            </tr>
             <tr>
                 <td>Name on Card</td><td colspan="5"><input type="text" size="40" name="cardname"/></td>


            </tr>
            <tr>
                <td>Enter the CWW</td><td colspan="5"><input type="text" size="15" name="cardcww"/></td>


            </tr>
             <tr>
                 <td colspan="6" align="center"><input type="submit" name="Submit" value="&nbsp&nbsp&nbsp;Done&nbsp&nbsp&nbsp"/></td>


            </tr>

        </table>
            </form>
        </div>

    </body>
</html>
