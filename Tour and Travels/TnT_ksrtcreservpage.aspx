<%@ Page Language="C#" MasterPageFile="~/TnT_ksrtc.master" AutoEventWireup="true" CodeFile="TnT_ksrtcreservpage.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <ul>
        <li>
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/TnT_ksrtcreservsearch.aspx"
                Style="font-weight: bold; font-size: 14pt; font-family: 'Times New Roman'">KSRTC Reservation Search</asp:LinkButton></li></ul>
   <ul>
        <li>
            <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/TnT_keralaprivatefirst.aspx"
                Style="font-weight: bold; font-size: 14pt; font-family: 'Times New Roman'">Private Bus Reservation</asp:LinkButton>
            &nbsp; &nbsp; &nbsp; </li>
    </ul>
   
       <ul>
        <li>
            <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/TnT_ksrtcCancelBusReserve.aspx"
                Style="font-weight: bold; font-size: 14pt; font-family: 'Times New Roman'">Cancel Bus Reservation</asp:LinkButton>
            &nbsp; &nbsp; &nbsp; </li>
    </ul>
        &nbsp;</p>
    <p>
    </p>
</asp:Content>

