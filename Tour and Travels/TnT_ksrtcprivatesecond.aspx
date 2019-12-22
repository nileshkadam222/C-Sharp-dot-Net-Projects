<%@ Page Language="C#" MasterPageFile="~/TnT_ksrtc.master" AutoEventWireup="true" CodeFile="TnT_ksrtcprivatesecond.aspx.cs" Inherits="_Default" Title="KSRTC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td style="width: 100px; height: 18px">
                <asp:Label ID="Label1" runat="server" Text="Route:"></asp:Label>
            </td>
            <td style="width: 181px; height: 18px">
                <asp:Label ID="lbl_route" runat="server" Text="Label"></asp:Label></td>
            <td style="width: 100px; height: 18px">
            </td>
            <td style="width: 200px; height: 18px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label3" runat="server" Text="From:"></asp:Label>
                &nbsp;
            </td>
            <td style="width: 181px">
                <asp:Label ID="lbl_from" runat="server" Text="Label"></asp:Label></td>
            <td style="width: 100px">
                <asp:Label ID="Label7" runat="server" Text="To:"></asp:Label>
                &nbsp;
            </td>
            <td style="width: 200px">
                <asp:Label ID="lbl_to" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label6" runat="server" Text="Service Type:"></asp:Label></td>
            <td style="width: 181px">
                <asp:Label ID="lbl_service" runat="server" Text="Label"></asp:Label></td>
            <td style="width: 100px">
                <asp:Label ID="Label8" runat="server" Text="Fare/Seat(Rs.)"></asp:Label></td>
            <td style="width: 200px">
                <asp:Label ID="lbl_fare" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 181px">
            </td>
            <td style="width: 100px">
            &nbsp;
            </td>
            <td style="width: 200px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 181px">
            </td>
            <td style="width: 100px">
                <asp:Label ID="lbl_mis" runat="server" Font-Bold="True" ForeColor="Red" Visible="False"></asp:Label>&nbsp;</td>
            <td style="width: 200px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 181px">
                <asp:Label ID="Label11" runat="server" Text="Date:"></asp:Label></td>
            <td style="width: 100px">
                <asp:TextBox ID="txt_date" runat="server" ReadOnly="True" ></asp:TextBox></td>
            <td style="width: 200px">
                <asp:Button ID="but_date" runat="server" Text="..." OnClick="but_date_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td align="center" colspan="2">
             <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66"
                    BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt"
                    ForeColor="#663399" Height="200px" ShowGridLines="True" Style="left: 605px; position: absolute;
                    top: 416px" Visible="False" Width="220px" OnSelectionChanged="Calendar1_SelectionChanged">
                    <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                    <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                    <SelectorStyle BackColor="#FFCC66" />
                    <OtherMonthDayStyle ForeColor="#CC9966" />
                    <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                    <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                    <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                </asp:Calendar>
            </td>
            <td style="width: 200px">
                
               
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td align="center" colspan="2">
            </td>
            <td style="width: 200px">
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="lblmsg" runat="server" Font-Bold="True" ForeColor="Red" Visible="False"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 100px; height: 20px;">
            </td>
            <td style="width: 181px; height: 20px;">
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
            </td>
            <td style="width: 100px; height: 20px;">
                <asp:Label ID="Label12" runat="server" Text="Select Seats"></asp:Label></td>
            <td style="width: 200px; height: 20px;">
            </td>
        </tr>
        <tr>
            <td style="width: 100px; height: 235px;">
                <asp:CheckBoxList ID="check_1" runat="server" Enabled="False">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                </asp:CheckBoxList></td>
            <td style="width: 181px; height: 235px;">
                <asp:CheckBoxList ID="check_2" runat="server" Enabled="False">
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    <asp:ListItem>16</asp:ListItem>
                    <asp:ListItem>17</asp:ListItem>
                    <asp:ListItem>18</asp:ListItem>
                    <asp:ListItem>19</asp:ListItem>
                    <asp:ListItem>20</asp:ListItem>
                </asp:CheckBoxList></td>
            <td style="width: 100px; height: 235px;">
                <asp:CheckBoxList ID="check_3" runat="server" Enabled="False">
                    <asp:ListItem>21</asp:ListItem>
                    <asp:ListItem>22</asp:ListItem>
                    <asp:ListItem>23</asp:ListItem>
                    <asp:ListItem>24</asp:ListItem>
                    <asp:ListItem>25</asp:ListItem>
                    <asp:ListItem>26</asp:ListItem>
                    <asp:ListItem>27</asp:ListItem>
                    <asp:ListItem>28</asp:ListItem>
                    <asp:ListItem>29</asp:ListItem>
                    <asp:ListItem>30</asp:ListItem>
                </asp:CheckBoxList></td>
            <td style="width: 200px; height: 235px;">
                <asp:CheckBoxList ID="check_4" runat="server" Enabled="False">
                    <asp:ListItem>31</asp:ListItem>
                    <asp:ListItem>32</asp:ListItem>
                    <asp:ListItem>33</asp:ListItem>
                    <asp:ListItem>34</asp:ListItem>
                    <asp:ListItem>35</asp:ListItem>
                    <asp:ListItem>36</asp:ListItem>
                    <asp:ListItem>37</asp:ListItem>
                    <asp:ListItem>38</asp:ListItem>
                    <asp:ListItem>39</asp:ListItem>
                    <asp:ListItem>40</asp:ListItem>
                </asp:CheckBoxList></td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 181px">
            </td>
            <td style="width: 100px">
            </td>
            <td style="width: 200px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td align="center" colspan="2">
                <asp:Button ID="but_continue" runat="server" Text="Continue" OnClick="but_continue_Click" /></td>
            <td style="width: 200px">
            </td>
        </tr>
    </table>
</asp:Content>

