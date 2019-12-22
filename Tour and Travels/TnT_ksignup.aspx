<%@ Page Language="C#" MasterPageFile="~/TnT_MasterPage.master" AutoEventWireup="true" CodeFile="TnT_ksignup.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <script type="text/javascript" language="javascript">
  
  // Phone Validation 
   function Validate() 
   {
      // alert('Hello');
         if (!((event.keyCode  >= 48 && event.keyCode  <= 57) || event.keyCode  == 8 || event.keyCode  == 47 || event.keyCode  == 45 || event.keyCode  == 43))
         event.returnValue=false;
   }
     
     
     function Validate1() 
     {
      // alert('Hello');
         if (((event.keyCode  >= 33 && event.keyCode  <= 39) || (event.keyCode  >= 42 && event.keyCode  <= 64) || (event.keyCode  >= 91 && event.keyCode  <= 96) || (event.keyCode  >= 123 && event.keyCode  <= 126 || event.keyCode == 92 )))
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
    <table>
        <tr>
            <td colspan="4">
                <asp:Label ID="Label1" runat="server" Text="Account Information" Font-Bold="True" ForeColor="DimGray"></asp:Label>
                &nbsp; &nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="ldlid" runat="server" Text="Login Name"></asp:Label></td>
            <td colspan="3">
                <asp:TextBox ID="txt_name" runat="server" Width="144px" OnTextChanged="txt_name_TextChanged"></asp:TextBox>&nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 100px; height: 26px;">
                <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label></td>
            <td style="width: 47px; height: 26px;">
                <asp:TextBox ID="txt_pas" runat="server" Width="143px" TextMode="Password"></asp:TextBox></td>
            <td style="width: 100px; height: 26px;">
                <asp:Label ID="Label3" runat="server" Text="Confirm Password" Width="116px"></asp:Label></td>
            <td style="width: 100px; height: 26px;">
                <asp:TextBox ID="txt_conf" runat="server" Width="144px" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="height: 20px;" colspan="4">
                <asp:Label ID="Label5" runat="server" ForeColor="Red" Text="Password must be minimum of 6 characters & maximum of 9 characters"
                    Width="441px" Visible="False"></asp:Label></td>
        </tr>
        <tr>
            <td style="height: 20px;" colspan="4">
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txt_pas"
                    ControlToValidate="txt_conf" ErrorMessage="Password Missmatch"></asp:CompareValidator></td>
        </tr>
        <tr>
            <td style="height: 20px;" colspan="4">
                <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="Gray">Personal Information</asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label2" runat="server" Text="User Fullname"></asp:Label></td>
            <td style="width: 47px">
                <asp:TextBox ID="txt_ful" runat="server" Width="159px"></asp:TextBox>
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px; height: 20px;">
                <asp:Label ID="Label7" runat="server" Text="Gender"></asp:Label></td>
            <td style="width: 47px; height: 20px;">
                <asp:DropDownList ID="drop_gen" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 100px; height: 20px;">
                <asp:Label ID="Label8" runat="server" Text="Marital Status"></asp:Label></td>
            <td style="width: 100px; height: 20px;">
                <asp:DropDownList ID="drop_mari" runat="server">
                    <asp:ListItem>Single</asp:ListItem>
                    <asp:ListItem>Married</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 100px; height: 44px;">
                <asp:Label ID="Label10" runat="server" Text="Date of Birth"></asp:Label></td>
            <td style="width: 47px; height: 44px;">
                <asp:TextBox ID="txtDOB" runat="server" ></asp:TextBox>
                </td>
            <td style="width: 100px; height: 44px;">
                <asp:Label ID="Label9" runat="server" Text="E-mail Address"></asp:Label></td>
            <td style="width: 100px; height: 44px;">
                <asp:TextBox ID="txt_mail" runat="server" Width="139px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_mail"
                    ErrorMessage="Invalid ID" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
        </tr>
        <tr>
            <td colspan="4" style="height: 20px">
            </td>
        </tr>
        <tr>
            <td style="height: 20px;" colspan="4">
                <asp:Label ID="Label11" runat="server" Text="Contact Information(Home)" Font-Bold="True" ForeColor="Gray"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 100px; height: 15px;">
                <asp:Label ID="Label12" runat="server" Text="Street Address"></asp:Label>&nbsp;
            </td>
            <td style="width: 47px; height: 15px;">
                <asp:TextBox ID="txt_street" runat="server" Width="138px"></asp:TextBox>&nbsp;
            </td>
            <td style="width: 100px; height: 15px;">
                <asp:Label ID="Label13" runat="server" Text="City/Town"></asp:Label></td>
            <td style="width: 100px; height: 15px;">
                <asp:DropDownList ID="drop_city" runat="server">
                    <asp:ListItem>Trivandrum</asp:ListItem>
                    <asp:ListItem>Nedumangad</asp:ListItem>
                    <asp:ListItem>Pattom</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 100px; height: 24px;">
                <asp:Label ID="Label14" runat="server" Text="State"></asp:Label></td>
            <td style="width: 47px; height: 24px;">
                <asp:DropDownList ID="drop_state" runat="server">
                    <asp:ListItem>Kerala</asp:ListItem>
                    <asp:ListItem>Tamilnadu</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 100px; height: 24px;">
                <asp:Label ID="Label16" runat="server" Text="Country"></asp:Label></td>
            <td style="width: 100px; height: 24px;">
                <asp:DropDownList ID="drop_country" runat="server" Width="102px">
                    <asp:ListItem>India</asp:ListItem>
                    <asp:ListItem>America</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 100px; height: 20px;">
                <asp:Label ID="Label15" runat="server" Text="Zip/Postal Code"></asp:Label></td>
            <td style="width: 47px; height: 20px;">
                <asp:TextBox ID="txt_zip" MaxLength="6" runat="server"></asp:TextBox>&nbsp;
            </td>
            <td style="width: 100px; height: 20px;">
                <asp:Label ID="Label17" runat="server" Text="Phone Number"></asp:Label></td>
            <td style="width: 100px; height: 20px;">
                <asp:TextBox ID="txt_phone" runat="server" Width="140px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 100px; height: 26px;">
                <asp:Label ID="Label19" runat="server" Text="Fax Number"></asp:Label></td>
            <td style="width: 47px; height: 26px;">
                <asp:TextBox ID="txt_fax" runat="server"></asp:TextBox></td>
            <td style="width: 100px; height: 26px;">
                <asp:Label ID="Label18" runat="server" Text="Mobile Number"></asp:Label></td>
            <td style="width: 100px; height: 26px;">
                <asp:TextBox ID="txt_mobile" runat="server" Width="139px"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="lblmsg" runat="server" ForeColor="Red" Text="Enter sufficient information"
                    Visible="False"></asp:Label>&nbsp;
            </td>
        </tr>
        <tr>
            <td style="height: 20px;" align="center" colspan="4">
                <asp:Button ID="btnreg" runat="server" OnClick="btnreg_Click" Text="Register" />
                <asp:Button ID="btnreset" runat="server" OnClick="btnreset_Click" Text="Reset" /></td>
        </tr>
    </table>
</asp:Content>

