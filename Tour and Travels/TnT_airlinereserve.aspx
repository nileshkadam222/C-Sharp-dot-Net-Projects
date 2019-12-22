<%@ Page Language="C#" MasterPageFile="~/TnT_airlinemaster.master" AutoEventWireup="true" CodeFile="TnT_airlinereserve.aspx.cs" Inherits="Default2" Title="Untitled Page" %>
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
   
    <table id="TABLE1"  style="text-align: left">
        <tr>
            <td colspan="1" style="height: 44px">
                <asp:Label ID="lblmsg" runat="server" Font-Bold="True" ForeColor="Red" Visible="False"></asp:Label></td>
            <td colspan="1" style="height: 44px">
                &nbsp;</td>
            <td colspan="1" style="height: 44px; width: 142px;">
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 44px">
                <asp:Label ID="Label1" runat="server" Text="Airline Ticket Reservation Form" Font-Bold="True" Font-Size="14pt" Font-Names="Times New Roman" ForeColor="#003300"></asp:Label></td>
            <td colspan="1" style="height: 44px; width: 142px;">
            </td>
        </tr>
        <tr>
            <td style="width: 154px; height: 20px">
                <asp:Label ID="Label2" runat="server" Text="Title:" Font-Names="Times New Roman" Font-Size="12pt" ForeColor="#003300"></asp:Label></td>
            <td style="width: 140px; height: 20px">
            <asp:DropDownList ID="drop_tittle" runat="server">
                    <asp:ListItem>Mr</asp:ListItem>
                    <asp:ListItem>Miss</asp:ListItem>
                    <asp:ListItem>Mrs</asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 142px; height: 20px">
            </td>
        </tr>
        <tr>
            <td style="width: 154px; height: 2px;">
                <asp:Label ID="Label7" runat="server" Text="*First Name:" Font-Names="Times New Roman" Font-Size="12pt" ForeColor="#003300"></asp:Label></td>
            <td align="left" colspan="1" style="height: 2px">
                <asp:TextBox ID="txt_name" runat="server" TabIndex="1"></asp:TextBox></td>
            <td align="left" colspan="1" style="height: 2px; width: 142px;">
            </td>
        </tr>
        <tr>
            <td style="width: 154px; height: 28px;">
                <asp:Label ID="Label8" runat="server" Text="*Last Name:" Font-Names="Times New Roman" Font-Size="12pt" ForeColor="#003300"></asp:Label></td>
            <td align="left" colspan="1" style="height: 28px">
                <asp:TextBox ID="txt_last" runat="server" TabIndex="2"></asp:TextBox></td>
            <td align="left" colspan="1" style="height: 28px; width: 142px;">
            </td>
        </tr>
        <tr>
            <td style="width: 154px">
                <asp:Label ID="Label9" runat="server" Text="Leaving From:" Font-Names="Times New Roman" Font-Size="12pt" ForeColor="#003300"></asp:Label>
                &nbsp;&nbsp;
            </td>
            <td align="left" colspan="1">
                <asp:TextBox ID="txt_leaving" runat="server" TabIndex="3"></asp:TextBox></td>
            <td align="left" colspan="1" style="width: 142px">
            </td>
        </tr>
        <tr>
            <td style="width: 154px; height: 26px">
                <asp:Label ID="Label13" runat="server" Text="Going To:" Font-Names="Times New Roman" Font-Size="12pt" ForeColor="#003300"></asp:Label></td>
            <td align="left" colspan="1" style="height: 26px">
                <asp:TextBox ID="txt_going" runat="server" TabIndex="4"></asp:TextBox></td>
            <td align="left" colspan="1" style="height: 26px; width: 142px;">
            </td>
        </tr>
        <tr>
            <td colspan="1" style="height: 26px" align="left">
                <asp:Label ID="Label10" runat="server" Text="Expected Departure Date:" Font-Names="Times New Roman" Font-Size="12pt" ForeColor="#003300"></asp:Label>
                
              </td>
                <td colspan="1" style="height: 26px" align="left">
                <asp:TextBox ID="txt_cal1" runat="server" TabIndex="5"></asp:TextBox></td>
            <td align="left" colspan="1" style="height: 26px; width: 142px;">
                &nbsp;
            </td>
                
        </tr>
        <tr>
            <td colspan="1" style="height: 13px" align="left">
                <asp:Label ID="Label12" runat="server" Text="Expected Return Date:" Font-Names="Times New Roman" Font-Size="12pt" ForeColor="#003300"></asp:Label>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;</td>
            <td align="left" colspan="1" style="height: 13px">
            <asp:TextBox ID="txt_cal2" runat="server" TabIndex="6"></asp:TextBox></td>
            <td align="left" colspan="1" style="height: 13px; width: 142px;">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td colspan="1" style="height: 16px" align="left">
                <asp:Label ID="Label11" runat="server" Text="Class:" Font-Names="Times New Roman" Font-Size="12pt" ForeColor="#003300"></asp:Label>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</td>
            <td align="left" colspan="1" style="height: 16px">
            <asp:DropDownList ID="drop_class" runat="server" TabIndex="7">
                    <asp:ListItem Selected="True">Economy Class</asp:ListItem>
                    <asp:ListItem>Business Class</asp:ListItem>
                    <asp:ListItem>First Class</asp:ListItem>
                </asp:DropDownList></td>
            <td align="left" colspan="1" style="height: 16px; width: 142px;">
            </td>
        </tr>
        <tr>
            <td style="width: 154px; height: 20px">
                <asp:Label ID="Label14" runat="server" Text="E-mail Address:" Font-Names="Times New Roman" Font-Size="12pt" ForeColor="#003300"></asp:Label></td>
            <td colspan="1" style="height: 20px">
                <asp:TextBox ID="txt_email" runat="server" TabIndex="8"></asp:TextBox></td>
            <td colspan="1" style="height: 20px; width: 142px;">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_email"
                    ErrorMessage="Invalid ID" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
        </tr>
        <tr>
            <td style="width: 154px; height: 20px">
                <asp:Label ID="Label16" runat="server" Text="Phone Number:" Font-Names="Times New Roman" Font-Size="12pt" ForeColor="#003300"></asp:Label></td>
            <td colspan="1" style="height: 20px">
                <asp:TextBox ID="txt_phone" runat="server" TabIndex="9"></asp:TextBox></td>
            <td colspan="1" style="height: 20px; width: 142px;">
            </td>
        </tr>
        <tr>
            <td style="width: 154px">
                <asp:Label ID="Label17" runat="server" Text="Passenger Name:" Font-Names="Times New Roman" Font-Size="12pt" ForeColor="#003300"></asp:Label></td>
            <td colspan="1">
                <asp:TextBox ID="txt_passname" runat="server" TabIndex="10"></asp:TextBox></td>
            <td colspan="1" style="width: 142px">
            </td>
        </tr>
        <tr>
            <td colspan="1" style="height: 24px" align="left">
                <asp:Label ID="Label15" runat="server" Text="Date Of Birth:" Font-Names="Times New Roman" Font-Size="12pt" ForeColor="#003300"></asp:Label>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
            </td>
            <td align="left" colspan="1" style="height: 24px">
                <asp:TextBox ID="txt_dob" runat="server" TabIndex="11"></asp:TextBox></td>
            <td align="left" colspan="1" style="height: 24px; width: 142px;">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 154px; height: 31px">
                <asp:Label ID="Label18" runat="server" Text="Nationality:" Font-Names="Times New Roman" Font-Size="12pt" ForeColor="#003300"></asp:Label>
                &nbsp;&nbsp;
            </td>
            <td style="width: 140px; height: 31px">
                <asp:TextBox ID="txt_nationality" runat="server" TabIndex="12"></asp:TextBox></td>
            <td style="width: 142px; height: 31px">
            </td>
        </tr>
        <tr>
            <td style="width: 154px">
                <asp:Label ID="Label21" runat="server" Text="Passport No:" Font-Names="Times New Roman" Font-Size="12pt" ForeColor="#003300"></asp:Label></td>
            <td style="width: 140px">
                <asp:TextBox ID="txt_passport" runat="server" TabIndex="13"></asp:TextBox></td>
            <td style="width: 142px">
            </td>
        </tr>
        <tr>
            <td colspan="1">
                <asp:HyperLink ID="Hyperlink" runat="server" style="font-weight: bold" Font-Names="Times New Roman" Font-Size="14pt" ForeColor="#003300">Add a passenger</asp:HyperLink></td>
            <td colspan="1">
            </td>
            <td colspan="1" style="width: 142px">
            </td>
        </tr>
        <tr>
            <td style="width: 154px">
                <asp:Label ID="Label19" runat="server" Text="Form Of Payment:" Font-Names="Times New Roman" Font-Size="12pt" ForeColor="#003300"></asp:Label></td>
            <td align="left" style="width: 140px">
                <asp:RadioButton ID="rdbcard" runat="server" AutoPostBack="True" Font-Bold="True"
                    ForeColor="Black" GroupName="w" Text="Credit Card" Width="98px" TabIndex="14" /></td>
            <td align="left" style="width: 142px">
                <asp:RadioButton ID="rdbDD" runat="server" AutoPostBack="True" Font-Bold="True" ForeColor="Black"
                    GroupName="w" Text="DD/Draft/Cheque" Width="88px" TabIndex="15" /></td>
        </tr>
        <tr>
            <td style="width: 154px">
                <asp:Label ID="lblDD" runat="server" Font-Bold="True" Text="DD/Draft/Cheque No" ForeColor="#003300"></asp:Label></td>
            <td align="left" style="width: 140px">
                <asp:TextBox ID="txtDDNo" runat="server" TabIndex="16"></asp:TextBox></td>
            <td align="left" style="width: 142px">
                <asp:Label ID="lblmsgdd" runat="server" Visible="False"></asp:Label>&nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 154px; height: 24px;">
                <asp:Label ID="lblmsgCardType" runat="server" Font-Bold="True" Text="Card Type" ForeColor="#003300"></asp:Label></td>
            <td align="left" style="width: 140px; height: 24px;">
                <asp:DropDownList ID="drpCardType" runat="server" Width="155px" TabIndex="17">
                    <asp:ListItem>--Select--</asp:ListItem>
                    <asp:ListItem>ICICI Bank</asp:ListItem>
                    <asp:ListItem>HDFC Bank</asp:ListItem>
                    <asp:ListItem>HSBC Bank</asp:ListItem>
                    <asp:ListItem>CiTi Bank</asp:ListItem>
                    <asp:ListItem>State Bank of India</asp:ListItem>
                    <asp:ListItem>UTI Bank</asp:ListItem>
                    <asp:ListItem>Axis Bank</asp:ListItem>
                    <asp:ListItem>ABN Amro</asp:ListItem>
                    <asp:ListItem>Deutsche Bank </asp:ListItem>
                </asp:DropDownList></td>
            <td align="left" style="width: 142px; height: 24px;">
                <asp:Label ID="Label3" runat="server" Visible="False"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 154px; height: 26px;">
                <asp:Label ID="lblCardNo" runat="server" Font-Bold="True" Text="Card No" ForeColor="#003300"></asp:Label></td>
            <td align="left" style="width: 140px; height: 26px;">
                <asp:TextBox ID="txtCardNo" runat="server" TabIndex="18"></asp:TextBox></td>
            <td align="left" style="width: 142px; height: 26px;">
            </td>
        </tr>
        <tr>
            <td style="width: 154px; height: 70px">
                <asp:Label ID="Label22" runat="server" Text="Comment:" Font-Names="Times New Roman" Font-Size="12pt" ForeColor="#003300"></asp:Label>&nbsp;
            </td>
            <td colspan="1" style="height: 70px">
                <asp:TextBox ID="txt_comment" runat="server" Height="57px" TextMode="MultiLine" Width="149px" TabIndex="19"></asp:TextBox></td>
            <td colspan="1" style="height: 70px; width: 142px;">
            </td>
        </tr>
        <tr>
            <td style="width: 154px; height: 4px">
                <asp:Label ID="Label23" runat="server" Text="Company Name (Required For Travel Agent And Corporate Client)"
                    Width="196px" Font-Names="Times New Roman" Font-Size="12pt" ForeColor="#003300"></asp:Label></td>
            <td colspan="1" style="height: 4px">
                <asp:TextBox ID="txt_company" runat="server" TabIndex="20"></asp:TextBox></td>
            <td colspan="1" style="height: 4px; width: 142px;">
            </td>
        </tr>
        <tr>
            <td style="width: 154px; height: 4px">
            </td>
            <td colspan="1" style="height: 4px">
            </td>
            <td colspan="1" style="height: 4px; width: 142px;">
            </td>
        </tr>
    </table>
    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/TnT_Cancel.aspx">Cancel</asp:LinkButton>
    <asp:Button ID="but_regester" runat="server" OnClick="but_regester_Click" Text="Register" Font-Names="Times New Roman" Font-Size="12pt" TabIndex="21" />
    <asp:Button ID="but_reset" runat="server" OnClick="but_reset_Click" Text="Reset" Font-Names="Times New Roman" Font-Size="12pt" Width="63px" TabIndex="22" />
</asp:Content>

