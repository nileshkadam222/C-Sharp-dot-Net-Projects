<%@ Page Language="C#" MasterPageFile="~/TnT_airlinemaster.master" AutoEventWireup="true" CodeFile="TnT_airlinetime.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label1" runat="server" Text="Date:" Font-Names="Times New Roman" Font-Size="12pt"></asp:Label></td>
            <td style="width: 100px">
                <asp:Label ID="lbl_date" runat="server" Font-Names="Times New Roman" Font-Size="12pt"></asp:Label></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" Checked="True"
                    GroupName="k" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Departure" Font-Names="Times New Roman" Font-Size="12pt" /></td>
            <td style="width: 100px">
                <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="k"
                    OnCheckedChanged="RadioButton2_CheckedChanged" Text="Arrival" Font-Names="Times New Roman" Font-Size="12pt" /></td>
        </tr>
        <tr>
            <td style="width: 100px; height: 34px">
                <asp:Label ID="Label3" runat="server" Text="Airport" Font-Names="Times New Roman" Font-Size="12pt"></asp:Label></td>
            <td style="width: 100px; height: 34px">
                <asp:Label ID="Label4" runat="server" Text=" &#9;(TRV) Trivandrum International Airport "
                    Width="153px"></asp:Label></td>
            <td style="width: 100px; height: 34px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1"
                    EmptyDataText="There are no data records to display." Visible="False" Font-Names="Times New Roman" Font-Size="12pt">
                    <Columns>
                        <asp:BoundField DataField="Flight" HeaderText="Flight" SortExpression="Flight" />
                        <asp:BoundField DataField="Carrier" HeaderText="Carrier" SortExpression="Carrier" />
                        <asp:BoundField DataField="Destination" HeaderText="Destination" SortExpression="Destination" />
                        <asp:BoundField DataField="Departure" HeaderText="Departure" SortExpression="Departure" />
                        <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:kioskDB %>"
                    ProviderName="<%$ ConnectionStrings:kioskDB.ProviderName %>" SelectCommand="SELECT [Flight], [Carrier], [Destination], [Departure], [Status] FROM [TnT_airlinedeparture]">
                </asp:SqlDataSource>
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2"
                    EmptyDataText="There are no data records to display." Visible="False" Font-Names="Times New Roman" Font-Size="12pt">
                    <Columns>
                        <asp:BoundField DataField="Flight" HeaderText="Flight" SortExpression="Flight" />
                        <asp:BoundField DataField="Carrier" HeaderText="Carrier" SortExpression="Carrier" />
                        <asp:BoundField DataField="Destination" HeaderText="Destination" SortExpression="Destination" />
                        <asp:BoundField DataField="Arrival" HeaderText="Arrival" SortExpression="Arrival" />
                        <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:kioskDB %>"
                    ProviderName="<%$ ConnectionStrings:kioskDB.ProviderName %>" SelectCommand="SELECT [Flight], [Carrier], [Destination], [Arrival], [Status] FROM [TnT_airlinearrival]">
                </asp:SqlDataSource>
                &nbsp;&nbsp;
            </td>
            <td style="width: 100px">
            </td>
        </tr>
    </table>
</asp:Content>

