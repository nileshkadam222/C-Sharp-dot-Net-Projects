<%@ Page Language="C#" MasterPageFile="~/TnT_ksrtc.master" AutoEventWireup="true" CodeFile="TnT_ksrtcCancelBusReserve.aspx.cs" Inherits="TnT_ksrtcCancelBusReserve" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br/>
    
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        DeleteCommand="DELETE FROM [TnT_KLPrivateBookConfirm] WHERE [SNo] = @original_SNo" 
        InsertCommand="INSERT INTO [TnT_KLPrivateBookConfirm] ([SNo], [RtFrom], [RtTo], [Fare], [TotSeat], [Name], [Address], [City], [Phone]) VALUES (@SNo, @RtFrom, @RtTo, @Fare, @TotSeat, @Name, @Address, @City, @Phone)" 
        OldValuesParameterFormatString="original_{0}" 
        SelectCommand="SELECT [SNo], [RtFrom], [RtTo], [Fare], [TotSeat], [Name], [Address], [City], [Phone] FROM [TnT_KLPrivateBookConfirm] WHERE ([userid] = @userid) ORDER BY [SNo]" 
        
        UpdateCommand="UPDATE [TnT_KLPrivateBookConfirm] SET [RtFrom] = @RtFrom, [RtTo] = @RtTo, [Fare] = @Fare, [TotSeat] = @TotSeat, [Name] = @Name, [Address] = @Address, [City] = @City, [Phone] = @Phone WHERE [SNo] = @original_SNo">
        <SelectParameters>
            <asp:ControlParameter ControlID="lblname" Name="userid" PropertyName="Text" 
                Type="String" />
        </SelectParameters>
        <DeleteParameters>
            <asp:Parameter Name="original_SNo" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="RtFrom" Type="String" />
            <asp:Parameter Name="RtTo" Type="String" />
            <asp:Parameter Name="Fare" Type="String" />
            <asp:Parameter Name="TotSeat" Type="String" />
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Address" Type="String" />
            <asp:Parameter Name="City" Type="String" />
            <asp:Parameter Name="Phone" Type="String" />
            <asp:Parameter Name="original_SNo" Type="Int32" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="SNo" Type="Int32" />
            <asp:Parameter Name="RtFrom" Type="String" />
            <asp:Parameter Name="RtTo" Type="String" />
            <asp:Parameter Name="Fare" Type="String" />
            <asp:Parameter Name="TotSeat" Type="String" />
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Address" Type="String" />
            <asp:Parameter Name="City" Type="String" />
            <asp:Parameter Name="Phone" Type="String" />
        </InsertParameters>
    </asp:SqlDataSource>
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblname" runat="server" Text="Label" Visible="False"></asp:Label>
    <br />
    <br />
 
    
    
    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" 
        AutoGenerateColumns="False" CellPadding="4" DataKeyNames="SNo" 
        DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" 
        onrowdeleted="GridView1_RowDeleted">
        <RowStyle BackColor="#EFF3FB" />
        <Columns>
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
            <asp:BoundField DataField="SNo" HeaderText="SNo" ReadOnly="True" 
                SortExpression="SNo" />
            <asp:BoundField DataField="RtFrom" HeaderText="RtFrom" 
                SortExpression="RtFrom" />
            <asp:BoundField DataField="RtTo" HeaderText="RtTo" SortExpression="RtTo" />
            <asp:BoundField DataField="Fare" HeaderText="Fare" SortExpression="Fare" />
            <asp:BoundField DataField="TotSeat" HeaderText="TotSeat" 
                SortExpression="TotSeat" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Address" HeaderText="Address" 
                SortExpression="Address" />
            <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
            <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
        </Columns>
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
 
    
    
</asp:Content>

