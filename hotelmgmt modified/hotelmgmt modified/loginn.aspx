<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="loginn.aspx.cs" Inherits="loginn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width: 403px; margin-left: 0px">
        <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <table style="width: 409px">
            <tr>
                <td colspan="2">
                </td>
                <td align="right" colspan="2">
                    &nbsp;
                    <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" 
                        ForeColor="DimGray" PostBackUrl="~/sign_up.aspx" CausesValidation="False" 
                        EnableViewState="False">New User?Signup</asp:LinkButton>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td colspan="4">
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:Label ID="Label1" runat="server" 
                        Text="If you already a member, enter your User ID and Password" Width="363px"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 99px">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="User ID"></asp:Label>
                </td>
                <td colspan="3">
                    <asp:TextBox ID="txt_user" runat="server" Width="130px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txt_user" ErrorMessage="Please Enter Username"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 99px; height: 20px">
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Password"></asp:Label>
                </td>
                <td colspan="3" style="height: 20px">
                    <asp:TextBox ID="txt_pass" runat="server" TextMode="Password" Width="126px"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txt_pass" ErrorMessage="Please Enter Password"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:Label ID="lblmsg" runat="server" ForeColor="Red" 
                        Text="Invalid User ID or Password" Visible="False" Width="188px"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 99px">
                </td>
                <td align="right" style="width: 100px">
                    <asp:Button ID="btnsign" runat="server" Font-Bold="True" 
                        OnClick="Button1_Click" Text="Sign In" />
                </td>
                <td style="width: 100px">
                    <asp:Button ID="btnreset" runat="server" Font-Bold="True" 
                        OnClick="btnreset_Click" Text="Reset" CausesValidation="False" 
                        EnableViewState="False" />
                </td>
                <td style="width: 100px">
                </td>
            </tr>
        </table>
        <br />
    </div>
</asp:Content>

