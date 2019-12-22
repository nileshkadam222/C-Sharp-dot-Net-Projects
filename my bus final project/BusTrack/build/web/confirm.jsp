<%@page import="ser.Admin_Ser"%>
<%@page import="Conn.GenUtility"%>
<%@page import="java.sql.*"%>
<%@include file="header/header_Client.jsp"%>


<div class="main">
  <section id="content">
  <!--LEFT HAND SIDE ENDS-->
		<!--CHANGING PART-->
    <article class="colA pad_left1">
        <center>
        <h2>Search Bus</h2>


            <table width="750" border="5">
                <tr>
                    <td>Bus Number</td>
                    <td>Source Loc</td>
                    <td>Source Time</td>
                    <td>Destination Loc</td>
                    <td>Destination Time</td>
                    <td>Price</td>
                    <td>Book</td>

                </tr>
                <% while(rs.next()){
                    if(passenger<=rs.getFloat(7)){
                 %>
                  <tr>
                    <td><%=rs.getString(1)%></td>
                    <td><%=rs.getString(2)%></td>
                    <td><%=rs.getString(3)%></td>
                    <td><%=rs.getString(4)%></td>
                    <td><%=rs.getString(5)%></td>
                    <td><%=rs.getFloat(6)%></td>
                    <td><a href="seat_Allocation.jsp">Confirm</a></td>

                </tr>
                 <%
                 }


                    }
                %>

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
        var scr=document.frmName.source.value;
        var dest=document.frmName.destination.value;
        var bustype=document.frmName.BusType.value;
        var no_pass=document.frmName.travler.value;
       // alert(Type);
        if(scr=="-1"){

            alert("Please select source");
            return false;
        }
        else if(dest=="-1"){
            alert("Please select destination");
            return false;
        }else if(bustype=="-1"){
            alert("Please select Bus Type ");
            return false;
        }else if(no_pass=="-1"){
            alert("Please select the number of traveler ");
            return false;
        }else if (datepic=""){
            alert("Please select date of travelling ");
            return false;
        }
       else{
            return true;
        }


    }
</script>
