<%@ Page Language="C#" MasterPageFile="~/TnT_MasterPage.master" AutoEventWireup="true" CodeFile="TnT_knewlogin.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td colspan="2">
            </td>
            <td align="right" colspan="2">
                &nbsp;
                <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="DimGray" Font-Bold="True" PostBackUrl="~/TnT_ksignup.aspx">New User?Signup</asp:LinkButton>&nbsp;
            </td>
        </tr>
        <tr>
            <td colspan="4">
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="Label1" runat="server" Text="If you already a member, enter your User ID and Password" Width="363px"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 99px">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="User ID"></asp:Label></td>
            <td colspan="3">
                <asp:TextBox ID="txt_user" runat="server" Width="139px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 99px; height: 20px">
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Password"></asp:Label></td>
            <td colspan="3" style="height: 20px">
                <asp:TextBox ID="txt_pass" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="lblmsg" runat="server" ForeColor="Red" Text="Invalid User ID or Password"
                    Visible="False" Width="188px"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="4">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 99px">
            </td>
            <td align="right" style="width: 100px">
                <asp:Button ID="btnsign" runat="server" Text="Sign In" Font-Bold="True" OnClick="Button1_Click" />
            </td>
            <td style="width: 100px">
                <asp:Button ID="btnreset" runat="server" Text="Reset" Font-Bold="True" OnClick="btnreset_Click" /></td>
            <td style="width: 100px">
            </td>
        </tr>
    </table>
</asp:Content>

