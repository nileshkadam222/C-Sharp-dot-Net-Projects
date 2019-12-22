<%@ Page Language="C#" MasterPageFile="~/TnT_ksrtc.master" AutoEventWireup="true" CodeFile="TnT_ksrtclinkdetails.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <ul>
        <li>
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/TnT_ksrtcbusrouteno.aspx"
                Style="font-weight: bold; font-size: 14pt; font-family: 'Times New Roman'">Bus Route</asp:LinkButton></li></ul>
    <ul>
        <li>
            <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/TnT_ksrtcdepot.aspx" Style="font-weight: bold;
                font-size: 14pt; font-family: 'Times New Roman'">Depot</asp:LinkButton>&nbsp;</li></ul>
    <ul>
        <li>
            <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/TnT_ksrtcfinancial.aspx"
                Style="font-weight: bold; font-size: 14pt; font-family: 'Times New Roman'">Financial</asp:LinkButton>&nbsp;</li></ul>
    <ul>
        <li>
            <asp:LinkButton ID="LinkButton4" runat="server" PostBackUrl="~/TnT_ksrtcfuture.aspx"
                Style="font-weight: bold; font-size: 14pt; font-family: 'Times New Roman'">Future</asp:LinkButton>&nbsp;</li></ul>
    <ul>
        <li>
            <asp:LinkButton ID="LinkButton5" runat="server" PostBackUrl="~/TnT_ksrtcholidayservice.aspx"
                Style="font-weight: bold; font-size: 14pt; font-family: 'Times New Roman'">Holiday Service</asp:LinkButton>&nbsp;</li></ul>
    <ul>
        <li>
            <asp:LinkButton ID="LinkButton6" runat="server" PostBackUrl="~/TnT_ksrtcrulesandregulation.aspx"
                Style="font-weight: bold; font-size: 14pt; font-family: 'Times New Roman'">Rules And Regulation</asp:LinkButton>&nbsp;</li></ul>
</asp:Content>

