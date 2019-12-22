<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="sign_up.aspx.cs" Inherits="sign_up" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style16
        {
            height: 26px;
            width: 170px;
        }
        .style17
        {
            width: 170px;
        }
        .style18
        {
            height: 20px;
            width: 170px;
        }
        .style19
        {
            height: 44px;
            width: 170px;
        }
        .style20
        {
            height: 15px;
            width: 170px;
        }
        .style21
        {
            height: 24px;
            width: 170px;
        }
        .style22
        {
            width: 125px;
        }
        .style23
        {
            height: 26px;
            width: 125px;
        }
        .style24
        {
            height: 20px;
            width: 125px;
        }
        .style25
        {
            height: 44px;
            width: 125px;
        }
        .style26
        {
            height: 15px;
            width: 125px;
        }
        .style27
        {
            height: 24px;
            width: 125px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script type="text/javascript" language="javascript">

     // Phone Validation 
     function Validate() {
         // alert('Hello');
         if (!((event.keyCode >= 48 && event.keyCode <= 57) || event.keyCode == 8 || event.keyCode == 47 || event.keyCode == 45 || event.keyCode == 43))
             event.returnValue = false;
     }


     function Validate1() {
         // alert('Hello');
         if (((event.keyCode >= 33 && event.keyCode <= 39) || (event.keyCode >= 42 && event.keyCode <= 64) || (event.keyCode >= 91 && event.keyCode <= 96) || (event.keyCode >= 123 && event.keyCode <= 126 || event.keyCode == 92)))
             event.returnValue = false;
     }

     //     

     //Email Validation

     // Date Validation
     function isDate(txtDate) {
         var objDate;  // date object initialized from the txtDate string  
         var mSeconds; // milliseconds from txtDate  

         if (txtDate.length != 10) return false;

         var day = txtDate.substring(0, 2) - 0;
         var month = txtDate.substring(3, 5) - 1; // because months in JS start with 0  
         var year = txtDate.substring(6, 10) - 0;

         if (txtDate.substring(2, 3) != '/') return false;
         if (txtDate.substring(5, 6) != '/') return false;

         if (year < 999 || year > 3000) return false;

         mSeconds = (new Date(year, month, day)).getTime();

         objDate = new Date();
         objDate.setTime(mSeconds);

         if (objDate.getFullYear() != year) return false;
         if (objDate.getMonth() != month) return false;
         if (objDate.getDate() != day) return false;

         return true;
     }


     function checkDate(s) {
         var txtDate = document.getElementById(s).value;
         if (txtDate == "") {
             alert('select the date');
         }
         else if (isDate(txtDate)) {
         }
         else {
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
            <td class="style22">
                <asp:Label ID="ldlid" runat="server" Text="Login Name" 
                    AssociatedControlID="txt_name"></asp:Label></td>
            <td colspan="3">
                <asp:TextBox ID="txt_name" runat="server" Width="144px" OnTextChanged="txt_name_TextChanged"></asp:TextBox>&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txt_name" ErrorMessage="Please Enter User Name"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style23">
                <asp:Label ID="Label4" runat="server" Text="Password" 
                    AssociatedControlID="txt_pas"></asp:Label></td>
            <td style="width: 47px; height: 26px;">
                <asp:TextBox ID="txt_pas" runat="server" Width="143px" TextMode="Password"></asp:TextBox></td>
            <td class="style16">
                <asp:Label ID="Label3" runat="server" Text="Confirm Password" Width="116px" 
                    AssociatedControlID="txt_conf"></asp:Label></td>
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
                    ControlToValidate="txt_conf" ErrorMessage="Password Missmatch" 
                    BackColor="Red" BorderColor="Black"></asp:CompareValidator></td>
        </tr>
        <tr>
            <td style="height: 20px;" colspan="4">
                <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="Gray">Personal Information</asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style22">
                <asp:Label ID="Label2" runat="server" Text="User Fullname" 
                    AssociatedControlID="txt_ful"></asp:Label></td>
            <td style="width: 47px">
                <asp:TextBox ID="txt_ful" runat="server" Width="159px"></asp:TextBox>
            </td>
            <td class="style17">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td class="style24">
                <asp:Label ID="Label7" runat="server" Text="Gender" 
                    AssociatedControlID="drop_gen"></asp:Label></td>
            <td style="width: 47px; height: 20px;">
                <asp:DropDownList ID="drop_gen" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList></td>
            <td class="style18">
                <asp:Label ID="Label8" runat="server" Text="Marital Status" 
                    AssociatedControlID="drop_mari"></asp:Label></td>
            <td style="width: 100px; height: 20px;">
                <asp:DropDownList ID="drop_mari" runat="server">
                    <asp:ListItem>Single</asp:ListItem>
                    <asp:ListItem>Married</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td class="style25">
                <asp:Label ID="Label10" runat="server" Text="Date of Birth" 
                    AssociatedControlID="txtDOB"></asp:Label></td>
            <td style="width: 47px; height: 44px;">
                <asp:TextBox ID="txtDOB" runat="server" ></asp:TextBox>
                </td>
            <td class="style19">
                <asp:Label ID="Label9" runat="server" Text="E-mail Address" 
                    AssociatedControlID="txt_mail"></asp:Label></td>
            <td style="width: 100px; height: 44px;">
                <asp:TextBox ID="txt_mail" runat="server" Width="139px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="4" style="height: 20px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_mail"
                    ErrorMessage="Invalid ID" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    BackColor="Red" BorderColor="Black" ControlToValidate="txt_mail" 
                    ErrorMessage="Please enter  Mail ID"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="height: 20px;" colspan="4">
                <asp:Label ID="Label11" runat="server" Text="Contact Information(Home)" Font-Bold="True" ForeColor="Gray"></asp:Label></td>
        </tr>
        <tr>
            <td class="style26">
                <asp:Label ID="Label12" runat="server" Text="Street Address" 
                    AssociatedControlID="txt_street"></asp:Label>&nbsp;
            </td>
            <td style="width: 47px; height: 15px;">
                <asp:TextBox ID="txt_street" runat="server" Width="138px"></asp:TextBox>&nbsp;
            </td>
            <td class="style20">
                &nbsp;</td>
            <td style="width: 100px; height: 15px;">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style27">
                <asp:Label ID="Label14" runat="server" Text="State" 
                    AssociatedControlID="drop_state"></asp:Label></td>
            <td style="width: 47px; height: 24px;">
                <asp:DropDownList ID="drop_state" runat="server" DataSourceID="SqlDataSource1" 
                    DataTextField="State" DataValueField="State" AutoPostBack="True">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:C:\USERS\MARUTI\DOCUMENTS\VISUAL STUDIO 2010\PROJECTS\HOTELMGMT\HOTELMGMT\APP_DATA\DATABASE.MDFConnectionString2 %>" 
                    SelectCommand="SELECT DISTINCT [State] FROM [statecity]">
                </asp:SqlDataSource>
            </td>
            <td class="style21">
                <asp:Label ID="Label13" runat="server" Text="City/Town" 
                    AssociatedControlID="drop_city"></asp:Label></td>
            <td style="width: 100px; height: 24px;">
                <asp:DropDownList ID="drop_city" runat="server" AutoPostBack="True" 
                    DataSourceID="SqlDataSource2" DataTextField="city" DataValueField="city">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:C:\USERS\MARUTI\DOCUMENTS\VISUAL STUDIO 2010\PROJECTS\HOTELMGMT\HOTELMGMT\APP_DATA\DATABASE.MDFConnectionString2 %>" 
                    
                    
                    SelectCommand="SELECT DISTINCT * FROM [statecity] WHERE ([State] = @State)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="drop_state" Name="State" 
                            PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td class="style24">
                <asp:Label ID="Label15" runat="server" Text="Zip/Postal Code" 
                    AssociatedControlID="txt_zip"></asp:Label></td>
            <td style="width: 47px; height: 20px;">
                <asp:TextBox ID="txt_zip" MaxLength="6" runat="server"></asp:TextBox>&nbsp;
            </td>
            <td class="style18">
                <asp:Label ID="Label17" runat="server" Text="Phone Number" 
                    AssociatedControlID="txt_phone"></asp:Label></td>
            <td style="width: 100px; height: 20px;">
                <asp:TextBox ID="txt_phone" runat="server" Width="140px"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="style23">
                <asp:Label ID="Label19" runat="server" Text="Fax Number" 
                    AssociatedControlID="txt_fax"></asp:Label></td>
            <td style="width: 47px; height: 26px;">
                <asp:TextBox ID="txt_fax" runat="server"></asp:TextBox></td>
            <td class="style16">
                <asp:Label ID="Label18" runat="server" Text="Mobile Number" 
                    AssociatedControlID="txt_mobile"></asp:Label></td>
            <td style="width: 100px; height: 26px;">
                <asp:TextBox ID="txt_mobile" runat="server" Width="139px" MaxLength="10"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="lblmsg" runat="server" ForeColor="Red" Text="Enter sufficient information"
                    Visible="False"></asp:Label>&nbsp;
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="txt_mobile" ValidationExpression="0-9"></asp:RegularExpressionValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                    ControlToValidate="txt_phone" ErrorMessage="RegularExpressionValidator" 
                    ValidationExpression="0-9"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="height: 20px;" align="center" colspan="4">
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnreg" runat="server"  Text="Register" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnreset" runat="server" OnClick="btnreset_Click" Text="Reset" 
                    CausesValidation="False" /></td>
        </tr>
    </table>

</asp:Content>

