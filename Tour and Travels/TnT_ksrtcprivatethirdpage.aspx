<%@ Page Language="C#" MasterPageFile="~/TnT_ksrtc.master" AutoEventWireup="true" CodeFile="TnT_ksrtcprivatethirdpage.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
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
    <table style="width: 669px; height: 341px; text-align: left">
        <tr>
            <td align="center" colspan="2" style="height: 21px">
                <table style="width: 671px; height: 141px">
                    <tr>
                        <td align="center" colspan="4" style="font-weight: bold">
                            <asp:Label ID="Label16" runat="server" Font-Size="12pt" ForeColor="#C00000" Text="Booking Information"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="4" style="font-weight: bold; text-align: left">
                            <asp:Label ID="lblmsg" runat="server" Font-Bold="True" ForeColor="Red" Visible="False"></asp:Label></td>
                    </tr>
                    <tr>
                        <td align="center" colspan="4" style="font-weight: bold">
                        </td>
                    </tr>
                    <tr>
                        <td align="left" style="width: 100px">
                            <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="Route:"></asp:Label>
                            &nbsp; &nbsp;&nbsp;
                        </td>
                        <td align="left" style="width: 100px">
                            <asp:Label ID="lbl_route" runat="server" Width="156px"></asp:Label></td>
                        <td align="left" style="width: 85px">
                            <asp:Label ID="Label12" runat="server" Font-Bold="True" Text="To:"></asp:Label></td>
                        <td align="left" style="width: 100px">
                            <asp:Label ID="lbl_to" runat="server" Width="156px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td align="left" style="width: 100px; height: 21px">
                            <asp:Label ID="Label11" runat="server" Font-Bold="True" Text="From:"></asp:Label></td>
                        <td align="left" style="width: 100px; height: 21px">
                            <asp:Label ID="lbl_from" runat="server" Width="155px"></asp:Label></td>
                        <td align="left" style="width: 85px; height: 21px">
                            <asp:Label ID="Label13" runat="server" Font-Bold="True" Text="Fare/Seat(Rs.):" Width="119px"></asp:Label></td>
                        <td align="left" style="width: 100px; height: 21px">
                            <asp:Label ID="lbl_fare" runat="server" Width="147px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td align="left" style="width: 100px; height: 8px;">
                            <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="Service Type:"></asp:Label></td>
                        <td align="left" style="width: 100px; height: 8px;">
                            <asp:Label ID="lbl_service" runat="server" Width="151px"></asp:Label></td>
                        <td align="left" style="width: 85px; height: 8px;">
                            <asp:Label ID="Label14" runat="server" Font-Bold="True" Text="Total Seat Required"
                                Width="147px"></asp:Label></td>
                        <td align="left" style="width: 100px; height: 8px;">
                            <asp:Label ID="lbltotseat" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td align="left" style="width: 100px">
                            <asp:Label ID="Label17" runat="server" Font-Bold="True" Text="Seat Opted:"></asp:Label></td>
                        <td align="left" style="width: 100px">
                            <asp:Label ID="lblseatopted" runat="server"></asp:Label></td>
                        <td align="left" style="width: 85px">
                            <asp:Label ID="Label15" runat="server" Font-Bold="True" Text="Payable Amount(Rs.):"
                                Width="158px"></asp:Label></td>
                        <td align="left" style="width: 100px">
                            <asp:Label ID="lblAmt" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td align="left" style="width: 100px; height: 21px">
                            <asp:Label ID="Label26" runat="server" Font-Bold="True" Text="Journey Date:" Width="104px"></asp:Label></td>
                        <td align="left" style="width: 100px; height: 21px">
                            <asp:Label ID="lblJrnydt" runat="server"></asp:Label></td>
                        <td align="left" style="width: 85px; height: 21px">
                        </td>
                        <td align="left" style="width: 100px; height: 21px">
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2" style="height: 21px">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#C00000" Text="Personal Information"></asp:Label></td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="Red" Text="Missing Fields:"
                    Visible="False" Width="109px"></asp:Label></td>
        </tr>
        <tr>
            <td align="right" style="width: 85px; height: 26px">
                &nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Name:"></asp:Label></td>
            <td style="width: 100px; height: 26px">
                <asp:TextBox ID="txtname" runat="server" Width="164px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" style="width: 85px; height: 22px">
                &nbsp;
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Address:"></asp:Label></td>
            <td style="width: 100px; height: 22px">
                <asp:TextBox ID="txtaddr" runat="server" Height="28px" TextMode="MultiLine" Width="166px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" style="width: 85px; height: 31px">
                &nbsp;<asp:Label ID="Label4" runat="server" Font-Bold="True" Text="City:"></asp:Label>&nbsp;
            </td>
            <td style="width: 100px; height: 31px">
                <asp:TextBox ID="txtcity" runat="server" Width="164px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" style="width: 85px; height: 27px">
                &nbsp;&nbsp; &nbsp;<asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Phone:"></asp:Label></td>
            <td style="width: 100px; height: 27px">
                <asp:TextBox ID="txtphone" runat="server" Width="163px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" style="width: 85px">
                &nbsp;&nbsp; &nbsp;<asp:Label ID="Label6" runat="server" Font-Bold="True" Text="E-mail:"></asp:Label></td>
            <td style="width: 100px">
                <asp:TextBox ID="txt_mail" runat="server" Width="162px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_mail"
                    ErrorMessage="Invalid ID" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
        </tr>
        <tr>
            <td align="right" style="width: 85px; height: 33px">
                &nbsp;<asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Mode Of Payment"
                    Width="135px"></asp:Label></td>
            <td style="width: 100px; height: 33px">
                <asp:DropDownList ID="drop_paymnt" runat="server">
                    <asp:ListItem>Cash</asp:ListItem>
                    <asp:ListItem>Cheque</asp:ListItem>
                    <asp:ListItem>Demand Draft</asp:ListItem>
                    <asp:ListItem>Credit Card</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="btn_bookng" runat="server" Height="23px" Text="Confirm Booking" Width="108px" OnClick="btn_bookng_Click" /><asp:Button
                    ID="btn_cancel" runat="server" Text="Cancel" OnClick="btn_cancel_Click" /></td>
        </tr>
        <tr>
            <td style="width: 85px">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
    </table>
    
</asp:Content>

