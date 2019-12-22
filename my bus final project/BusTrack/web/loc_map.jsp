<%@page import="ser.Admin_Ser"%>
<%@page import="Conn.GenUtility"%>
<%@page import="java.sql.*"%>
<%@include file="header/header_Admin.jsp"%>
<%
     String error=(String)session.getAttribute("ADD_LOC");
     int value=Admin_Ser.new_loc;

    Connection conn=null;
    PreparedStatement ps=null;
    ResultSet rs=null;
    Statement st=null;
    GenUtility gen=new GenUtility();
    String sql="";

    try{
           sql="select distinct num from bus_detail order by num";
           conn=gen.dbconnection();
           ps=conn.prepareStatement(sql);
           rs=ps.executeQuery();


      }
    catch(Exception E){
        System.out.println("Exception at viw_user "+E);
        }
%>

<div class="main">
  <section id="content">
  <!--LEFT HAND SIDE ENDS-->
		<!--CHANGING PART-->
    <article class="colA pad_left1">

    <center>
          <h2> Please Enter the location mapping</h2><br>
        <%
         if(error!=null){
             if(value==1){
      %>
      <h4><font color="Red"><strong><%=error%></strong></font></h4>
      <%
     }
             }
        %>

             <form name="frmName" action="AdminSer?do=locmapping" method="post" onsubmit="return CheckForm();">
            <table>
                <tr><td><Strong>Bus NO:</Strong></td>
                    <td>
                        <select name="bussch" >
                            <option value="-1">--Select--</option>
                      <% while(rs.next()){

                       %>
                       <option value="<%=rs.getString(1)%>"><%=rs.getString(1)%></option>
                       <%
                      }
                        %>

                        </select>
                    </td>
                </tr>
                <tr><td>&nbsp;</td></tr>
              
               <tr>
                    <td><strong>Pick up point:</strong></td>
                    <td> <input name="pick"></td>
                
                </tr>
 <tr><td>&nbsp;</td></tr>
 <tr><td><strong>Pick up time :</strong>&nbsp;</td>

     <td>
         <select name="Hr">
              <option value="-1">--Select Hour--</option>
             <option value="0">0 AM</option>
               <option value="1">1</option>
               <option value="2">2</option>
               <option value="3">3</option>
               <option value="4">4</option>
               <option value="5">5</option>
               <option value="6">6</option>
               <option value="7">7</option>
               <option value="8">8</option>
               <option value="9">9</option>
               <option value="10">10</option>
               <option value="11">11</option>
               <option value="12">12</option>


         </select>&nbsp;&nbsp;
          <select name="Min">
              <option value="-1">--Select Minius--</option>
              <option value="0">00</option>
              <option value="1">01</option>
              <option value="2">02</option>
              <option value="3">03</option>
              <option value="4">04</option>
              <option value="5">05</option>
              <option value="6">06</option>
              <option value="7">07</option>
              <option value="8">08</option>
              <option value="9">09</option>
              <option value="10">10</option>
              <option value="11">11</option>
              <option value="12">12</option>
              <option value="13">13</option>
              <option value="14">14</option>
              <option value="15">15</option>
              <option value="16">16</option>
              <option value="17">17</option>
              <option value="18">18</option>
              <option value="19">19</option>
              <option value="20">20</option>
              <option value="21">21</option>
              <option value="22">22</option>
              <option value="23">23</option>
              <option value="24">24</option>
              <option value="25">25</option>
              <option value="26">26</option>
              <option value="27">27</option>
              <option value="28">28</option>
              <option value="29">29</option>
              <option value="30">30</option>
              <option value="31">31</option>
              <option value="32">32</option>
              <option value="33">33</option>
              <option value="34">34</option>
              <option value="35">35</option>
              <option value="36">36</option>
              <option value="37">37</option>
              <option value="38">38</option>
              <option value="39">39</option>
              <option value="40">40</option>
              <option value="41">41</option>
              <option value="42">42</option>
              <option value="43">43</option>
              <option value="44">44</option>
              <option value="45">45</option>
              <option value="46">46</option>
              <option value="47">47</option>
              <option value="48">48</option>
              <option value="49">49</option>
              <option value="50">50</option>
               <option value="51">51</option>
              <option value="52">52</option>
              <option value="53">53</option>
              <option value="54">54</option>
              <option value="55">55</option>
              <option value="56">56</option>
              <option value="57">57</option>
              <option value="58">58</option>
              <option value="59">59</option>
              <option value="60">60</option>


         </select>
     </td>
 </tr>
<tr><td>&nbsp;</td></tr>
        <tr><td><strong>Price :</strong></td><td><input type="text" name="price" /></td></tr>

  <tr><td>&nbsp;</td></tr>
                 <tr><td><font color="blue"><input type="Submit" value="Schedule Bus" /></font></td>
                     <td><font color="blue"><input type="button" value="&nbsp;Reset&nbsp;" onclick="ResetValues();" /></font></td>
                 </tr>

  <tr><td>&nbsp;</td></tr>
            </table>



        </form>

    </center>

    </article>
  </section>
</div>
<%
    Admin_Ser.new_loc=0;
%>
<script>
    function  CheckForm(){
      var busno=document.frmName.bussch.value;
      var hour=document.frmName.Hr.value;
      var min=document.frmName.Min.value;
      var datepicker=document.frmName.pick.value;
      var prc=document.frmName.price.value;;


      if(busno=="-1"){
          alert("Please select the BUS NUMBER");
          return false;
      }
      else if(datepicker==""){
            alert("Please enter Pick up point");
          return false;
      }else if(hour=="-1"){
            alert("Please select hour timing");
          return false;
      }else if(min=="-1"){
            alert("Please select the Minus");
          return false;
      }
      else if(prc==""){
          alert("Please enter price ");
          return false;
      }
      else {
          return true;
      }
    }
    function ResetValues(){
        document.frmName.bussch.value="-1";
      document.frmName.Hr.value="-1";
      document.frmName.Min.value="-1";
     
       document.frmName.pick.value="";
        document.frmName.price.value="";



    }

</script>
