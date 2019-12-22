<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="onlinebooking.aspx.cs" Inherits="onlinebooking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        #TextArea1
    {
        height: 22px;
    }
    .style16
    {
        height: 26px;
    }
    .style18
    {
        width: 134px;
    }
        .style20
        {
            width: 308px;
        }
        .style22
        {
            width: 90px;
        }
        .style23
        {
            width: 276px;
        }
        .style24
        {
            width: 245px;
        }
        .style25
        {
            width: 341px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" runat="server" Height="717px" Width="690px">
    <br />
        <script language="javascript" type="text/javascript">

    function Character()
    {
         if (!((event.keyCode  >= 65 && event.keyCode  <= 90) || (event.keyCode  >= 97 && event.keyCode  <= 122) || event.keyCode  == 8 || event.keyCode  == 32 ))
         event.returnValue=false;
    }
    
  // Phone Validation 
   function Validate() {
      // alert('Hello');
         if (!((event.keyCode  >= 48 && event.keyCode  <= 57) || event.keyCode  == 8 || event.keyCode  == 47 || event.keyCode  == 45 || event.keyCode  == 43))
         event.returnValue=false;
    }
     
     
     function Validate1() {
      // alert('Hello');
         if (((event.keyCode  >= 33 && event.keyCode  <= 39) || (event.keyCode  >= 42 && event.keyCode  <= 64) || (event.keyCode  >= 91 && event.keyCode  <= 96) || (event.keyCode  >= 123 && event.keyCode  <= 126 || event.keyCode == 92 )))
         event.returnValue=false;
    }
        function Nums()
        {
            if (!((event.keyCode  >= 48 && event.keyCode  <= 57) || event.keyCode  == 8 ))
             event.returnValue=false;
        }
         function Rupees()
        {
            if (!((event.keyCode  >= 48 && event.keyCode  <= 57) || event.keyCode  == 8 || event.keyCode  == 46 ))
             event.returnValue=false;
        }
//     
     
     //Email Validation
    
// Date Validation
 function isDate(txtDate)
    {  
         var objDate;  // date object initialized from the txtDate string  
         var mSeconds; // milliseconds from txtDate  
         
         if (txtDate.length != 10) return false;  
        
         var day   = txtDate.substring(0,2)  - 0;  
         var month = txtDate.substring(3,5)  - 1; // because months in JS start with 0  
         var year  = txtDate.substring(6,10) - 0;  
              
         if (txtDate.substring(2,3) != '/') return false;  
         if (txtDate.substring(5,6) != '/') return false;  
              
         if (year < 999 || year > 3000) return false;  
             
         mSeconds = (new Date(year, month, day)).getTime();  
             
         objDate = new Date();  
         objDate.setTime(mSeconds);  
         
         if (objDate.getFullYear() != year)  return false;  
         if (objDate.getMonth()    != month) return false;  
         if (objDate.getDate()     != day)   return false;  
         
         return true; 
     } 
     
     
     function checkDate(s)
     {  
         var txtDate = document.getElementById(s).value;  
         if(txtDate == "")
         {
          alert('select the date');
          document.getElementById(s).focus();
         }
         else if (isDate(txtDate)) 
         {
         }  
         else
         {
         alert('Invalid date format!');  
         document.getElementById(s).focus();
         }          
         
     }
</script>
        <table border="1">
            <tr>
                <td colspan="4" style="background-color: white">
                    <asp:Label ID="lbl_hotelname" runat="server" Font-Names="Times New Roman" 
                        Font-Size="24pt" Style="font-weight: bold; font-family: 'Times New Roman'" 
                        Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="4" style="background-color: white">
                </td>
            </tr>
            <tr>
                <td colspan="4" style="background-color: white">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="TextBox1" ValidationExpression="0-9"></asp:RegularExpressionValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                        ControlToValidate="TextBox2" ValidationExpression="0-9"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="background-color: white" class="style25">
                    <asp:Label ID="Label17" runat="server" AssociatedControlID="TextBox1" 
                        Font-Names="Times New Roman" Font-Size="12pt" Text="Total No. of Persons :" 
                        Width="146px"></asp:Label>
                </td>
                <td style="background-color: white; " class="style24">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td style="background-color: white" class="style23">
                    <asp:Label ID="Label18" runat="server" AssociatedControlID="TextBox2" 
                        Font-Names="Times New Roman" Font-Size="12pt" Text=" 	Total No. of Rooms :" 
                        Width="137px"></asp:Label>
                </td>
                <td style="background-color: white" class="style20">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="background-color: white" class="style25">
                    <asp:Label ID="Label19" runat="server" AssociatedControlID="TextBox3" 
                        Font-Names="Times New Roman" Font-Size="12pt" Text="Arrival Date:"></asp:Label>
                </td>
                <td style="background-color: white; " class="style24">
                    <asp:TextBox ID="TextBox3" runat="server" Height="22px"></asp:TextBox>
                </td>
                <td style="background-color: white" class="style23">
                    <asp:Label ID="Label20" runat="server" AssociatedControlID="TextBox4" 
                        Font-Names="Times New Roman" Font-Size="12pt" Text="Depature Date:"></asp:Label>
                </td>
                <td style="background-color: white" class="style20">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="background-color: white">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                        ControlToValidate="TextBox3" 
                        ValidationExpression="(0( \d|\d ))?\d\d \d\d(\d \d| \d\d )\d\d"></asp:RegularExpressionValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                        ControlToValidate="TextBox4" 
                        ValidationExpression="(0( \d|\d ))?\d\d \d\d(\d \d| \d\d )\d\d"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="background-color: white; height: 42px;">
                    <asp:Label ID="Label22" runat="server" AssociatedControlID="TextBox9" 
                        Font-Names="Times New Roman" Font-Size="12pt" 
                        Text="* Any Preferences Or Other Requirements :"></asp:Label>
                </td>
                <td colspan="2" style="background-color: white; height: 42px;">
                    <asp:TextBox ID="TextBox9" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="Please Enter Something" ControlToValidate="TextBox9"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="4" style="background-color: white; height: 25px;">
                    <asp:Label ID="Label23" runat="server" Font-Names="Times New Roman" 
                        Font-Size="12pt" Text="Your Contact Information:"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="4" style="background-color: white">
                    <asp:Label ID="Label24" runat="server" Font-Names="Times New Roman" 
                        Font-Size="12pt" Text="( *  represents Compulsory Fields )"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="background-color: white" class="style25">
                </td>
                <td style="background-color: white; " class="style24">
                </td>
                <td style="background-color: white" class="style23">
                </td>
                <td style="background-color: white" class="style20">
                </td>
            </tr>
            <tr>
                <td colspan="2" style="background-color: white">
                    <asp:Label ID="Label25" runat="server" AssociatedControlID="TextBox5" 
                        Font-Names="Times New Roman" Font-Size="12pt" ForeColor="Black" 
                        Text="* Your Name :"></asp:Label>
                </td>
                <td colspan="2" style="background-color: white">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        BackColor="Red" ControlToValidate="TextBox5" Display="Dynamic" 
                        EnableTheming="False" ErrorMessage="Please Enter your Name"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="background-color: white">
                    <asp:Label ID="Label26" runat="server" AssociatedControlID="TextBox6" 
                        Font-Names="Times New Roman" Font-Size="12pt" Text="* Your E-Mail : "></asp:Label>
                </td>
                <td colspan="2" style="background-color: white">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="regEmail" runat="server" 
                        ControlToValidate="TextBox6" ErrorMessage="Please Enter valid Email Id" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                        BackColor="#CC0000"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="background-color: white">
                    <asp:Label ID="Label27" runat="server" AssociatedControlID="TextBox7" 
                        Font-Names="Times New Roman" Font-Size="12pt" 
                        Text="* Phone : (Include Country/Area Code)"></asp:Label>
                </td>
                <td colspan="2" style="background-color: white">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        BackColor="Red" ControlToValidate="TextBox7" 
                        ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style16" colspan="2" style="background-color: white">
                    <asp:Label ID="Label29" runat="server" AssociatedControlID="TextBox8" 
                        Font-Names="Times New Roman" Font-Size="12pt" Text="Street Address : "></asp:Label>
                </td>
                <td class="style16" colspan="2" style="background-color: white">
                    <asp:TextBox ID="TextBox8" runat="server" ontextchanged="TextBox8_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="background-color: white">
                    <asp:Label ID="Label14" runat="server" AssociatedControlID="DropDownList1" 
                        Text="State : "></asp:Label>
                </td>
                <td colspan="2">
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                        DataSourceID="SqlDataSource1" DataTextField="State" DataValueField="State">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:C:\USERS\MARUTI\DOCUMENTS\VISUAL STUDIO 2010\PROJECTS\HOTELMGMT\HOTELMGMT\APP_DATA\DATABASE.MDFConnectionString2 %>" 
                        SelectCommand="SELECT DISTINCT [State] FROM [statecity]">
                    </asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="background-color: white">
                    <asp:Label ID="Label30" runat="server" AssociatedControlID="DropDownList2" 
                        Text="City :"></asp:Label>
                </td>
                <td colspan="2" style="background-color: white">
                    <asp:DropDownList ID="DropDownList2" runat="server" AppendDataBoundItems="True" 
                        AutoPostBack="True" CausesValidation="True" DataSourceID="SqlDataSource2" 
                        DataTextField="city" DataValueField="city">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:C:\USERS\MARUTI\DOCUMENTS\VISUAL STUDIO 2010\PROJECTS\HOTELMGMT\HOTELMGMT\APP_DATA\DATABASE.MDFConnectionString2 %>" 
                        
                        SelectCommand="SELECT DISTINCT * FROM [statecity] WHERE ([State] = @State)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="DropDownList1" Name="State" 
                                PropertyName="SelectedValue" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td style="background-color: white" class="style25">
                </td>
                <td style="background-color: white; " class="style24">
                </td>
                <td style="background-color: white" class="style23">
                </td>
                <td style="background-color: white" class="style20">
                </td>
            </tr>
            <tr>
                <td align="center" colspan="4" style="background-color: white">
                    <asp:Button ID="bt_submit" runat="server" Font-Names="Times New Roman" 
                        Font-Size="12pt" OnClick="bt_submit_Click" Text="Submit" Width="60px" 
                        Height="22px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Height="23px" onclick="Button1_Click" 
                        Text="Reset" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Height="25px" onclick="Button2_Click1" 
                        PostBackUrl="~/Home.aspx" Text="Home" />
                </td>
            </tr>
            <tr>
                <td style="background-color: white" class="style25">
                </td>
                <td style="background-color: white; " class="style24">
                </td>
                <td style="background-color: white" class="style23">
                </td>
                <td style="background-color: white" class="style20">
                </td>
            </tr>
        </table>
</asp:Panel>
</asp:Content>

