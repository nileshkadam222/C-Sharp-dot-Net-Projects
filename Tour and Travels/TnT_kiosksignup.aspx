<%@ Page Language="C#" MasterPageFile="~/TnT_masterHome.master" AutoEventWireup="true" CodeFile="TnT_kiosksignup.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <script type="text/javascript" language="javascript">
  
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
        function isNumeric(keyCode)
        {
        return ((keyCode >= 48 && keyCode <= 57) || keyCode == 8)
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
   
    <table id="TABLE1" border="2"  style="width: 451px;
        height: 532px">
        <tr>
            <td align="center" colspan="4" style="height: 18px">
            </td>
        </tr>
        <tr>
            <td colspan="4" style="height: 18px">
                <asp:Label ID="Label2" runat="server" Style="color: gray; font-weight: bold;" Text="Account Information"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 95px">
                <asp:Label ID="Label3" runat="server" Text="User ID:"></asp:Label>
                &nbsp;
            </td>
            <td colspan="3">
                <asp:TextBox ID="txt_user" runat="server" ></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="Label4" runat="server" Text="User ID may consist of a-z, 0-9, underscores,hyphen and a single dot (.) and minimum of 6 characters & maximum of 15 characters" Width="498px"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 95px; height: 28px;">
                <asp:Label ID="Label5" runat="server" Text="Password:"></asp:Label>
            </td>
            <td style="width: 110px; height: 28px;">
                <asp:TextBox ID="txt_pass" runat="server" Height="15px" TextMode="Password"></asp:TextBox></td>
            <td style="width: 100px; height: 28px;">
                <asp:Label ID="Label6" runat="server" Text="Confirm Password:" Width="124px"></asp:Label></td>
            <td style="width: 100px; height: 28px;">
                <asp:TextBox ID="txt_confrm" runat="server" TextMode="Password" Width="97px"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="4" style="height: 18px">
                <asp:Label ID="Label7" runat="server" ForeColor="Red" Text="Password must be minimum of 6 characters & maximum of 9 characters"
                    Visible="False"></asp:Label>
                <br />
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txt_pass"
                    ControlToValidate="txt_confrm" ErrorMessage="Password Mismatch"></asp:CompareValidator></td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="Label8" runat="server" Style="font-weight: bold; color: gray" Text="Personal Information" Font-Bold="False"></asp:Label>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 95px">
                <asp:Label ID="Label9" runat="server" Text="User Fullname:"></asp:Label></td>
            <td colspan="3">
                <asp:TextBox ID="txt_ful" runat="server" Width="134px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 95px">
                <asp:Label ID="Label10" runat="server" Text="Gender:"></asp:Label></td>
            <td style="width: 110px">
                <asp:DropDownList ID="drop_gen" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 100px">
                <asp:Label ID="Label12" runat="server" Text="Marital Status:"></asp:Label></td>
            <td style="width: 100px">
                <asp:DropDownList ID="drop_mari" runat="server" >
                    <asp:ListItem>Single</asp:ListItem>
                    <asp:ListItem>Married</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 95px; height: 46px;">
                <asp:Label ID="Label11" runat="server" Text="Date Of Birth:"></asp:Label></td>
            <td style="width: 110px; height: 46px;">
                <asp:TextBox ID="txtdob" runat="server" Width="111px"></asp:TextBox><asp:Button ID="btncal" runat="server"
                    OnClick="Button1_Click" Text="..." Width="23px" />
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999"
                    CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt"
                    ForeColor="Black" Height="180px" OnSelectionChanged="Calendar1_SelectionChanged1"
                    Style="left: 604px; position: absolute; top: 613px" Visible="False" Width="200px">
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                </asp:Calendar>
            </td>
            <td style="width: 100px; height: 46px;">
                <asp:Label ID="Label13" runat="server" Text="E-mail Address:"></asp:Label></td>
            <td style="width: 100px; height: 46px;">
                <asp:TextBox ID="txt_email" runat="server" Width="96px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid ID"
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txt_email"></asp:RegularExpressionValidator></td>
        </tr>
        <tr>
            <td colspan="4" style="height: 13px">
                <asp:Label ID="Label14" runat="server" Height="12px" Style="font-weight: bold; color: gray"
                    Text="Contact Information(Home)" Font-Bold="False"></asp:Label>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 95px; height: 18px">
                <asp:Label ID="Label15" runat="server" Text="Street Address :" Width="111px"></asp:Label></td>
            <td style="width: 110px; height: 18px">
                <asp:TextBox ID="txt_street" runat="server" Height="16px" TextMode="MultiLine" Width="147px"></asp:TextBox></td>
            <td style="width: 100px; height: 18px">
                <asp:Label ID="Label18" runat="server" Text="City/Town:"></asp:Label>&nbsp;
            </td>
            <td style="width: 100px; height: 18px">
                <asp:DropDownList ID="drop_city" runat="server">
                    <asp:ListItem>Sreekariyam</asp:ListItem>
                    <asp:ListItem>Nedumangad</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 95px; height: 18px">
                <asp:Label ID="Label16" runat="server" Text="State:"></asp:Label></td>
            <td style="width: 110px; height: 18px">
                <asp:DropDownList ID="drop_state" runat="server">
                    <asp:ListItem>Kerala</asp:ListItem>
                    <asp:ListItem>Tamil nadu</asp:ListItem>
                </asp:DropDownList>&nbsp;
            </td>
            <td style="width: 100px; height: 18px">
                <asp:Label ID="Label19" runat="server" Text="Country:"></asp:Label></td>
            <td style="width: 100px; height: 18px">
                <asp:DropDownList ID="drop_country" runat="server">
                    <asp:ListItem>India</asp:ListItem>
                    <asp:ListItem>America</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 95px">
                <asp:Label ID="Label17" runat="server" Text="Zip/Postal Code:" Width="111px"></asp:Label></td>
            <td style="width: 110px">
                <asp:TextBox ID="txt_zip" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:Label ID="Label20" runat="server" Text="Phone Number:"></asp:Label></td>
            <td style="width: 100px">
                <asp:TextBox ID="txt_phone" runat="server" Width="100px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 95px">
                <asp:Label ID="Label22" runat="server" Text="Fax Number:"></asp:Label></td>
            <td style="width: 110px">
                <asp:TextBox ID="txt_fax" runat="server" ></asp:TextBox></td>
            <td style="width: 100px">
                <asp:Label ID="Label21" runat="server" Text="Mobile Number:" Width="103px"></asp:Label></td>
            <td style="width: 100px">
                <asp:TextBox ID="txt_mobile" runat="server" Width="92px"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="4" style="height: 18px">
                &nbsp;<asp:Label ID="lblmsg" runat="server" ForeColor="Red" Text="Enter sufficient information"
                    Visible="False"></asp:Label></td>
        </tr>
        <tr>
            <td align="center" colspan="4" style="height: 28px">
                <asp:Button ID="btnreg" runat="server" OnClick="btnreg_Click1" Text="Register" Width="63px" />
                <asp:Button ID="btnreset" runat="server" OnClick="btnreset_Click1" Text="Reset" Width="61px" />
                </td>
        </tr>
    </table>
</asp:Content>

