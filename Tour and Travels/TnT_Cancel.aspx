<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TnT_Cancel.aspx.cs" Inherits="TnT_Cancel" MasterPageFile="~/TnT_airlinemaster.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
    
    </div>
    <asp:GridView ID="GridView1" runat="server" Height="200px" Width="617px" 
        AutoGenerateColumns="False" AllowSorting="True" DataKeyNames="Jourid" 
        DataSourceID="SqlDataSource1" onrowdeleted="GridView1_RowDeleted" 
        CellPadding="4" ForeColor="#333333" GridLines="None">
    
        <RowStyle BackColor="#EFF3FB" />
    
      <Columns>
          <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
          <asp:BoundField DataField="userid" HeaderText="userid" 
              SortExpression="userid" />
          <asp:BoundField DataField="Jourid" HeaderText="Jourid" ReadOnly="True" 
              SortExpression="Jourid" />
          <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
          <asp:BoundField DataField="firstname" HeaderText="firstname" 
              SortExpression="firstname" />
          <asp:BoundField DataField="lastname" HeaderText="lastname" 
              SortExpression="lastname" />
          <asp:BoundField DataField="leavingfrom" HeaderText="leavingfrom" 
              SortExpression="leavingfrom" />
          <asp:BoundField DataField="goingto" HeaderText="goingto" 
              SortExpression="goingto" />
          <asp:BoundField DataField="depaturedate" HeaderText="depaturedate" 
              SortExpression="depaturedate" />
          <asp:BoundField DataField="returndate" HeaderText="returndate" 
              SortExpression="returndate" />
          <asp:BoundField DataField="class" HeaderText="class" SortExpression="class" />
          <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
          <asp:BoundField DataField="phoneno" HeaderText="phoneno" 
              SortExpression="phoneno" />
          <asp:BoundField DataField="passengername" HeaderText="passengername" 
              SortExpression="passengername" />
                        
                       
                        
                        
    
    
    </Columns>
    

        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <AlternatingRowStyle BackColor="White" />
    

    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConflictDetection="CompareAllValues" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        DeleteCommand="DELETE FROM [TnT_airlinereser] WHERE [Jourid] = @original_Jourid AND [userid] = @original_userid AND [title] = @original_title AND [firstname] = @original_firstname AND [lastname] = @original_lastname AND [leavingfrom] = @original_leavingfrom AND [goingto] = @original_goingto AND [depaturedate] = @original_depaturedate AND [returndate] = @original_returndate AND [class] = @original_class AND [email] = @original_email AND [phoneno] = @original_phoneno AND [passengername] = @original_passengername" 
        InsertCommand="INSERT INTO [TnT_airlinereser] ([userid], [Jourid], [title], [firstname], [lastname], [leavingfrom], [goingto], [depaturedate], [returndate], [class], [email], [phoneno], [passengername]) VALUES (@userid, @Jourid, @title, @firstname, @lastname, @leavingfrom, @goingto, @depaturedate, @returndate, @class, @email, @phoneno, @passengername)" 
        OldValuesParameterFormatString="original_{0}" 
        SelectCommand="SELECT [userid], [Jourid], [title], [firstname], [lastname], [leavingfrom], [goingto], [depaturedate], [returndate], [class], [email], [phoneno], [passengername] FROM [TnT_airlinereser] WHERE ([userid] = @userid)" 
        
        UpdateCommand="UPDATE [TnT_airlinereser] SET [userid] = @userid, [title] = @title, [firstname] = @firstname, [lastname] = @lastname, [leavingfrom] = @leavingfrom, [goingto] = @goingto, [depaturedate] = @depaturedate, [returndate] = @returndate, [class] = @class, [email] = @email, [phoneno] = @phoneno, [passengername] = @passengername WHERE [Jourid] = @original_Jourid AND [userid] = @original_userid AND [title] = @original_title AND [firstname] = @original_firstname AND [lastname] = @original_lastname AND [leavingfrom] = @original_leavingfrom AND [goingto] = @original_goingto AND [depaturedate] = @original_depaturedate AND [returndate] = @original_returndate AND [class] = @original_class AND [email] = @original_email AND [phoneno] = @original_phoneno AND [passengername] = @original_passengername">
        <SelectParameters>
            <asp:ControlParameter ControlID="Label1" Name="userid" PropertyName="Text" 
                Type="String" />
        </SelectParameters>
        <DeleteParameters>
            <asp:Parameter Name="original_Jourid" Type="Int32" />
            <asp:Parameter Name="original_userid" Type="String" />
            <asp:Parameter Name="original_title" Type="String" />
            <asp:Parameter Name="original_firstname" Type="String" />
            <asp:Parameter Name="original_lastname" Type="String" />
            <asp:Parameter Name="original_leavingfrom" Type="String" />
            <asp:Parameter Name="original_goingto" Type="String" />
            <asp:Parameter Name="original_depaturedate" Type="String" />
            <asp:Parameter Name="original_returndate" Type="String" />
            <asp:Parameter Name="original_class" Type="String" />
            <asp:Parameter Name="original_email" Type="String" />
            <asp:Parameter Name="original_phoneno" Type="String" />
            <asp:Parameter Name="original_passengername" Type="String" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="userid" Type="String" />
            <asp:Parameter Name="title" Type="String" />
            <asp:Parameter Name="firstname" Type="String" />
            <asp:Parameter Name="lastname" Type="String" />
            <asp:Parameter Name="leavingfrom" Type="String" />
            <asp:Parameter Name="goingto" Type="String" />
            <asp:Parameter Name="depaturedate" Type="String" />
            <asp:Parameter Name="returndate" Type="String" />
            <asp:Parameter Name="class" Type="String" />
            <asp:Parameter Name="email" Type="String" />
            <asp:Parameter Name="phoneno" Type="String" />
            <asp:Parameter Name="passengername" Type="String" />
            <asp:Parameter Name="original_Jourid" Type="Int32" />
            <asp:Parameter Name="original_userid" Type="String" />
            <asp:Parameter Name="original_title" Type="String" />
            <asp:Parameter Name="original_firstname" Type="String" />
            <asp:Parameter Name="original_lastname" Type="String" />
            <asp:Parameter Name="original_leavingfrom" Type="String" />
            <asp:Parameter Name="original_goingto" Type="String" />
            <asp:Parameter Name="original_depaturedate" Type="String" />
            <asp:Parameter Name="original_returndate" Type="String" />
            <asp:Parameter Name="original_class" Type="String" />
            <asp:Parameter Name="original_email" Type="String" />
            <asp:Parameter Name="original_phoneno" Type="String" />
            <asp:Parameter Name="original_passengername" Type="String" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="userid" Type="String" />
            <asp:Parameter Name="Jourid" Type="Int32" />
            <asp:Parameter Name="title" Type="String" />
            <asp:Parameter Name="firstname" Type="String" />
            <asp:Parameter Name="lastname" Type="String" />
            <asp:Parameter Name="leavingfrom" Type="String" />
            <asp:Parameter Name="goingto" Type="String" />
            <asp:Parameter Name="depaturedate" Type="String" />
            <asp:Parameter Name="returndate" Type="String" />
            <asp:Parameter Name="class" Type="String" />
            <asp:Parameter Name="email" Type="String" />
            <asp:Parameter Name="phoneno" Type="String" />
            <asp:Parameter Name="passengername" Type="String" />
        </InsertParameters>
    </asp:SqlDataSource>
  </asp:Content>
