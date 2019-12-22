<%@ Page Language="C#" MasterPageFile="~/TnT_ksrtc.master" AutoEventWireup="true" CodeFile="TnT_keralaprivatefirst.aspx.cs" Inherits="_Default" Title="KSRTC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;&nbsp;
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="SNo"
        DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display."
        OnRowCommand="GridView1_RowCommand" Font-Names="Times New Roman" Font-Size="12pt" >
        <Columns>
            <asp:BoundField DataField="SNo" HeaderText="SNo" ReadOnly="True" SortExpression="SNo" />
            <asp:BoundField DataField="Route" HeaderText="Route" SortExpression="Route" />
            <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
            <asp:BoundField DataField="Fromplace" HeaderText="Fromplace" SortExpression="Fromplace" />
            <asp:BoundField DataField="ToPlace" HeaderText="ToPlace" SortExpression="ToPlace" />
            <asp:BoundField DataField="Departtime" HeaderText="Departtime" SortExpression="Departtime" />
            <asp:BoundField DataField="Arrivaltime" HeaderText="Arrivaltime" SortExpression="Arrivaltime" />
            <asp:BoundField DataField="Fare" HeaderText="Fare" SortExpression="Fare" />
            <asp:ButtonField ButtonType="Button" Text="Book" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:kioskDB %>"
        DeleteCommand="DELETE FROM [kelaraprivate] WHERE [SNo] = @SNo" InsertCommand="INSERT INTO [TnT_kelaraprivate] ([SNo], [Route], [Type], [Fromplace], [ToPlace], [Departtime], [Arrivaltime], [Fare]) VALUES (@SNo, @Route, @Type, @Fromplace, @ToPlace, @Departtime, @Arrivaltime, @Fare)"
        ProviderName="<%$ ConnectionStrings:kioskDB.ProviderName %>" SelectCommand="SELECT [SNo], [Route], [Type], [Fromplace], [ToPlace], [Departtime], [Arrivaltime], [Fare] FROM [TnT_kelaraprivate]"
        UpdateCommand="UPDATE [TnT_kelaraprivate] SET [Route] = @Route, [Type] = @Type, [Fromplace] = @Fromplace, [ToPlace] = @ToPlace, [Departtime] = @Departtime, [Arrivaltime] = @Arrivaltime, [Fare] = @Fare WHERE [SNo] = @SNo">
        <InsertParameters>
            <asp:Parameter Name="SNo" Type="Int32" />
            <asp:Parameter Name="Route" Type="String" />
            <asp:Parameter Name="Type" Type="String" />
            <asp:Parameter Name="Fromplace" Type="String" />
            <asp:Parameter Name="ToPlace" Type="String" />
            <asp:Parameter Name="Departtime" Type="String" />
            <asp:Parameter Name="Arrivaltime" Type="String" />
            <asp:Parameter Name="Fare" Type="Decimal" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Route" Type="String" />
            <asp:Parameter Name="Type" Type="String" />
            <asp:Parameter Name="Fromplace" Type="String" />
            <asp:Parameter Name="ToPlace" Type="String" />
            <asp:Parameter Name="Departtime" Type="String" />
            <asp:Parameter Name="Arrivaltime" Type="String" />
            <asp:Parameter Name="Fare" Type="Decimal" />
            <asp:Parameter Name="SNo" Type="Int32" />
        </UpdateParameters>
        <DeleteParameters>
            <asp:Parameter Name="SNo" Type="Int32" />
        </DeleteParameters>
    </asp:SqlDataSource>
</asp:Content>

