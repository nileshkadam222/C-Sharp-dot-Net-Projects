﻿<%@ Page Language="C#" MasterPageFile="~/TnT_hotelhome.master" AutoEventWireup="true" CodeFile="RptHotelBooking.aspx.cs" Inherits="RptHotelBooking" Title="Untitled Page" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
    Font-Size="8pt" Height="357px" Width="766px">
        <LocalReport ReportPath="Hotel_Report.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" 
                    Name="DataSet1_TnT_hotelbooking" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>

<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
    SelectMethod="GetData" 
    TypeName="DataSet1TableAdapters.TnT_hotelbookingTableAdapter">
</asp:ObjectDataSource>
<br/><br/>

</asp:Content>
