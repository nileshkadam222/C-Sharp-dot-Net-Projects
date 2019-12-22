<%@ Page Language="C#" MasterPageFile="~/TnT_hotelhome.master" AutoEventWireup="true" CodeFile="TnT_hotelbooking1.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

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
                <asp:Label ID="lbl_hotelname" runat="server" Font-Names="Times New Roman" Font-Size="24pt"
                    Style="font-weight: bold; font-family: 'Times New Roman'" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="4" style="background-color: white">
            </td>
        </tr>
        <tr>
            <td colspan="4" style="background-color: white">
            </td>
        </tr>
        <tr>
            <td style="background-color: white">
                <asp:Label ID="Label3" runat="server" Font-Names="Times New Roman" Font-Size="12pt"
                    Text="Total No. of Persons :" Width="146px"></asp:Label></td>
            <td style="background-color: white">
                <asp:TextBox ID="txt_noof" runat="server"></asp:TextBox></td>
            <td style="background-color: white">
                <asp:Label ID="Label4" runat="server" Font-Names="Times New Roman" Font-Size="12pt"
                    Text=" &#9;Total No. of Rooms :" Width="137px"></asp:Label></td>
            <td style="background-color: white">
                <asp:TextBox ID="txt_noofpers" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="background-color: white">
                <asp:Label ID="Label1" runat="server" Font-Names="Times New Roman" Font-Size="12pt"
                    Text="Arrival Date:"></asp:Label></td>
            <td style="background-color: white">
                <asp:TextBox ID="txt_arrival" runat="server"></asp:TextBox></td>
            <td style="background-color: white">
                <asp:Label ID="Label2" runat="server" Font-Names="Times New Roman" Font-Size="12pt"
                    Text="Depature Date:"></asp:Label></td>
            <td style="background-color: white">
                <asp:TextBox ID="txt_dapature" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" style="background-color: white">
                <asp:Label ID="Label5" runat="server" Font-Names="Times New Roman" Font-Size="12pt"
                    Text="Approximate Budget in US $ :" Width="186px"></asp:Label></td>
            <td colspan="2" style="background-color: white">
                <asp:TextBox ID="txt_cash" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" style="background-color: white">
                <asp:Label ID="Label6" runat="server" Font-Names="Times New Roman" Font-Size="12pt"
                    Text="* Any Preferences Or Other Requirements :"></asp:Label></td>
            <td colspan="2" style="background-color: white">
                <asp:TextBox ID="txt_other" runat="server" TextMode="MultiLine"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" colspan="4" style="background-color: white">
                <asp:Label ID="Label7" runat="server" Font-Names="Times New Roman" Font-Size="12pt"
                    Text="Your Contact Information:"></asp:Label></td>
        </tr>
        <tr>
            <td align="center" colspan="4" style="background-color: white">
                <asp:Label ID="Label8" runat="server" Font-Names="Times New Roman" Font-Size="12pt"
                    Text="( *  represents Compulsory Fields )"></asp:Label></td>
        </tr>
        <tr>
            <td style="background-color: white">
            </td>
            <td style="background-color: white">
            </td>
            <td style="background-color: white">
            </td>
            <td style="background-color: white">
            </td>
        </tr>
        <tr>
            <td colspan="2" style="background-color: white">
                <asp:Label ID="Label9" runat="server" Font-Names="Times New Roman" Font-Size="12pt"
                    ForeColor="Black" Text="* Your Name :"></asp:Label></td>
            <td colspan="2" style="background-color: white">
                <asp:TextBox ID="txt_name" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" style="background-color: white">
                <asp:Label ID="Label10" runat="server" Font-Names="Times New Roman" Font-Size="12pt"
                    Text="* Your E-Mail : "></asp:Label></td>
            <td colspan="2" style="background-color: white">
                <asp:TextBox ID="txt_mail" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="regEmail" runat="server" ControlToValidate="txt_mail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Please Enter valid Email Id"></asp:RegularExpressionValidator>
                </td>
        </tr>
        <tr>
            <td colspan="2" style="background-color: white">
                <asp:Label ID="Label11" runat="server" Font-Names="Times New Roman" Font-Size="12pt"
                    Text="* Phone : (Include Country/Area Code)"></asp:Label></td>
            <td colspan="2" style="background-color: white">
                <asp:TextBox ID="txt_phone" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" style="height: 26px; background-color: white">
                <asp:Label ID="Label12" runat="server" Font-Names="Times New Roman" Font-Size="12pt"
                    Text="Fax : (Include Country/ Area Code)"></asp:Label></td>
            <td colspan="2" style="height: 26px; background-color: white">
                <asp:TextBox ID="txt_fax" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" style="background-color: white">
                <asp:Label ID="Label13" runat="server" Font-Names="Times New Roman" Font-Size="12pt"
                    Text="Street Address : "></asp:Label></td>
            <td colspan="2" style="background-color: white">
                <asp:TextBox ID="txt_street" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" style="background-color: white">
                <asp:Label ID="Label14" runat="server" Text="City/State : "></asp:Label></td>
            <td colspan="2" style="background-color: white">
                <asp:TextBox ID="txt_city" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" style="background-color: white">
                <asp:Label ID="Label15" runat="server" Font-Names="Times New Roman" Font-Size="12pt"
                    Text="Zip/Postal Code :"></asp:Label></td>
            <td colspan="2" style="background-color: white">
                <asp:TextBox ID="txt_pincode" runat="server" MaxLength="6"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" style="background-color: white">
                <asp:Label ID="Label16" runat="server" Font-Names="Times New Roman" Font-Size="12pt"
                    Text="* Country :"></asp:Label></td>
            <td colspan="2" style="background-color: white">
                <asp:TextBox ID="txt_country" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="background-color: white">
            </td>
            <td style="background-color: white">
            </td>
            <td style="background-color: white">
            </td>
            <td style="background-color: white">
            </td>
        </tr>
        <tr>
            <td align="center" colspan="4" style="background-color: white">
                <asp:Button ID="bt_submit" runat="server" Font-Names="Times New Roman" Font-Size="12pt"
                    OnClick="bt_submit_Click" Text="Submit" /></td>
        </tr>
        <tr>
            <td style="background-color: white">
            </td>
            <td style="background-color: white">
            </td>
            <td style="background-color: white">
            </td>
            <td style="background-color: white">
            </td>
        </tr>
    </table>
</asp:Content>

