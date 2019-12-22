<%@ Page Language="C#" MasterPageFile="~/TnT_ksrtc.master" AutoEventWireup="true" CodeFile="TnT_ksrtcreservsearch.aspx.cs" Inherits="Default6" Title="Untitled Page" %>
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
 
  
    <asp:Label ID="Label1" runat="server" Text="From Place" Font-Bold="True" style="text-align: left;" ></asp:Label>:     &nbsp;&nbsp;&nbsp 
    <asp:Label ID="Label2" runat="server" Text="Trivandrum" style="text-align:left;"></asp:Label><br/>
    <asp:Label ID="Label4" runat="server" Text="To Place" Font-Bold="True" style="text-align: left;" ></asp:Label>:     &nbsp;&nbsp;&nbsp 
    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
        DataSourceID="SqlDataSource3" DataTextField="ToPlace" DataValueField="ToPlace">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT [ToPlace] FROM [TnT_kelaraprivate]">
    </asp:SqlDataSource>
  <br/>
    &nbsp;&nbsp;&nbsp 
    
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="SNo" DataSourceID="SqlDataSource1" style="text-align: center" 
        Width="454px">
        <Columns>
            <asp:BoundField DataField="SNo" HeaderText="SNo" ReadOnly="True" 
                SortExpression="SNo" />
            <asp:BoundField DataField="Route" HeaderText="Route" SortExpression="Route" />
            <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
            <asp:BoundField DataField="Fromplace" HeaderText="Fromplace" 
                SortExpression="Fromplace" />
            <asp:BoundField DataField="ToPlace" HeaderText="ToPlace" 
                SortExpression="ToPlace" />
            <asp:BoundField DataField="Departtime" HeaderText="Departtime" 
                SortExpression="Departtime" />
            <asp:BoundField DataField="Arrivaltime" HeaderText="Arrivaltime" 
                SortExpression="Arrivaltime" />
            <asp:BoundField DataField="Fare" HeaderText="Fare" SortExpression="Fare" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        
        SelectCommand="SELECT * FROM [TnT_kelaraprivate] WHERE ([ToPlace] = @ToPlace)">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList2" Name="ToPlace" 
                PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>

