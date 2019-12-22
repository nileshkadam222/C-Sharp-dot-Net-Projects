<%@page import="ser.Admin_Ser"%>
<%@page import="Conn.GenUtility"%>
<%@page import="java.sql.*"%>

<%
    Connection conn=null;
    PreparedStatement ps=null;
    ResultSet rs=null;
    Statement st=null;
    GenUtility gen=new GenUtility();
    String sql="";

    try{
           sql="select distinct from1 from bus_detail";
           conn=gen.dbconnection();
           ps=conn.prepareStatement(sql);
           rs=ps.executeQuery();

      }
    catch(Exception E){
        System.out.println("Exception at searchAgent "+E);
        }
%>

<div class="main">
  <section id="content">
  <!--for ARticle  where colour -->
    <article class="col1">
      <div class="pad_1">
          <h2>Please search Bus</h2><br>
        <form name="frmName" action="res_search_log.jsp" method="post" onsubmit="return CheckForm();">

            <table>
                <tr><td><strong>Source :</strong></td>
                    <td>
                        <select name="source" >
                            <option value="-1">--select--</option>
                            <%
                             while(rs.next()){
                            %>
                            <option value="<%=rs.getString(1)%>"><%=rs.getString(1)%></option>
                            <%}%>
                        </select>
                    </td></tr>
                      <tr><td colspan="2">&nbsp;</td></tr>
                      <%
                      sql="select distinct point from bus_path";
                       conn=gen.dbconnection();
                       ps=conn.prepareStatement(sql);
                      rs=ps.executeQuery();
                      %>
                      <tr>  <td><strong>Destination :</strong></td>
                    <td>
                        <select name="destination" >
                            <option value="-1">--select--</option>
                            <%while(rs.next()){
                              %>
                              <option value="<%=rs.getString(1)%>"><%=rs.getString(1)%></option>
                           <% }%>
                        </select>
                    </td>
                </tr>
                  <tr><td colspan="2">&nbsp;</td></tr>
                <tr><td><Strong>Bus Type :</Strong></td>
                    <td>
                        <select name="BusType" >
                            <option value="-1">--select--</option>
                            <option value="NONAC">NON AC</option>
                            <option value="AC">AC</option>
                        </select>
                    </td>
                </tr>
                  <tr><td colspan="2">&nbsp;</td></tr>
                <tr>
                    <td><Strong>
                        No of Travelers :
                        </Strong>
                    </td>
                    <td>
                        <select name="travler" >
                            <option value="-1">--select--</option>
                            <option value="01">01</option>
                            <option value="02">02</option>
                            <option value="03">03</option>
                            <option value="04">04</option>
                            <option value="05">05</option>
                            <option value="06">06</option>
                        </select>
                    </td>
                </tr>


                <tr><td colspan="2">&nbsp;</td></tr>
                <tr>
                    <td><strong>Journey Date:</strong></td>
                    <td> <input name="datepic"></td>
                    <td><input type=button value="select" onclick="displayDatePicker('datepic', this);"></td>
                </tr>
                 <tr><td colspan="2">&nbsp;</td></tr>
                <tr>
                    <td colspan="2">
                        <input type="submit" name="Search" value="Search"/>
                    </td>
                </tr>
                </table>
        </form>

      </div>
    </article>
                        <script>
    function  CheckForm(){
       // alert("hi");
        var scr=document.frmName.source.value;
        var dest=document.frmName.destination.value;
        var bustype=document.frmName.BusType.value;
        var no_pass=document.frmName.travler.value;
        var dt=document.frmName.datepic.value;
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
        }else if (dt=""){
            alert("Please select date of travelling ");
            return false;
        }
       else{
            return true;
        }


    }
</script>
