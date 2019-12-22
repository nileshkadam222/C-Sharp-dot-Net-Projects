<%@ Page Language="C#" MasterPageFile="~/TnT_airlinemaster.master" AutoEventWireup="true" CodeFile="Airline_Schedule_Report.aspx.cs" Inherits="Reports_Airline_Schedule_Report" Title="Untitled Page" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="521px" 
        Font-Names="Verdana" Font-Size="8pt" Height="400px">
        <LocalReport ReportPath="Airlinedeparture_Report.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" 
                    Name="DataSet1_TnT_airlinedeparture" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>


    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="GetData" 
        TypeName="DataSet1TableAdapters.TnT_airlinedepartureTableAdapter">
    </asp:ObjectDataSource>

    <rsweb:ReportViewer ID="ReportViewer2" runat="server" Font-Names="Verdana" 
        Font-Size="8pt" Height="400px" Width="491px">
        <LocalReport ReportPath="AirlineArrival_report.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="ObjectDataSource2" 
                    Name="DataSet1_TnT_airlinearrival" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>


    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
        SelectMethod="GetData" 
        TypeName="DataSet1TableAdapters.TnT_airlinearrivalTableAdapter">
    </asp:ObjectDataSource>


</asp:Content>

