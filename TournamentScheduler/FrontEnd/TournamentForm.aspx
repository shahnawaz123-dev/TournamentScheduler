<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TournamentForm.aspx.cs" Inherits="FrontEnd.TournamentForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 114px;
        }
        #Text1 {
            height: 153px;
            width: 762px;
        }
        .newStyle1 {
            font-family: "Arial Narrow";
            font-size: larger;
            background-color: #0066FF;
        }
        #TextArea1 {
            height: 215px;
            width: 450px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #6699FF; font-family: Calibri; font-size: x-large; font-weight: bold; font-style: normal; font-variant: normal; text-transform: capitalize; color: #000000; line-height: normal">
        <p style="width: 365px; height: 57px; margin-left: 640px" id="Title" draggable="true">
            Tournament Scheduler&nbsp;&nbsp;&nbsp;
        </p>
    <p>
        &nbsp;</p>
        <asp:Menu ID="Menu2" runat="server" BackColor="#F7F6F3" BorderStyle="Ridge" CssClass="newStyle1" DynamicHorizontalOffset="2" Font-Names="Leelawadee UI" Font-Size="0.8em" ForeColor="#7C6F57" OnMenuItemClick="Menu2_MenuItemClick" StaticSubMenuIndent="10px" style="font-size: large; color: #0066FF">
            <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#F7F6F3" />
            <DynamicSelectedStyle BackColor="#5D7B9D" />
            <Items>
                <asp:MenuItem Text="Login" Value="Login"></asp:MenuItem>
                <asp:MenuItem Text="Schedule Tournament" Value="Schedule Tournament"></asp:MenuItem>
                <asp:MenuItem Text="View Tournament " Value="View Tournament "></asp:MenuItem>
                <asp:MenuItem Text="FAQ's" Value="FAQ's"></asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#5D7B9D" />
        </asp:Menu>
        <div style="width: 1211px; margin-left: 680px">
            <p style="text-align: left; margin-left: 40px">
                Tournament Name
                <asp:TextBox ID="TournamentName" runat="server" OnTextChanged="TextBox1_TextChanged1" Width="338px"></asp:TextBox>
            </p>
        </div>
        <ol>
            <li>
                <p style="margin-left: 680px">
                    Start Date<asp:TextBox ID="startDate" runat="server" OnTextChanged="TextBox1_TextChanged1" style="margin-left: 144px" Width="332px"></asp:TextBox>
                </p>
            </li>
        </ol>
        <div style="margin-left: 680px">
            <ol>
                <li>End Date<asp:TextBox ID="endDate" runat="server" OnTextChanged="TextBox1_TextChanged1" style="margin-left: 157px" Width="334px"></asp:TextBox>
                </li>
            </ol>
        </div>
        <ol>
            <li>
                <p style="margin-left: 680px">
                    Tournament Type&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Round Robin</asp:ListItem>
                        <asp:ListItem>Group Stage</asp:ListItem>
                        <asp:ListItem>Group Stage and Knockout</asp:ListItem>
                        <asp:ListItem>Knockout</asp:ListItem>
                    </asp:DropDownList>
                </p>
            </li>
            <li>
                <p style="margin-left: 719px">
                    Venue<asp:TextBox ID="endDate0" runat="server" OnTextChanged="TextBox1_TextChanged1" style="margin-left: 157px" Width="334px"></asp:TextBox>
                </p>
            </li>
        </ol>
        <p style="margin-left: 680px">
            Add Players           Add Players</p>
        <p style="margin-left: 680px">
            <textarea id="TextArea1" cols="20" name="S1" rows="2"></textarea><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" Width="93px" />
        </p>
        <p style="margin-left: 960px">
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    </body>
</html>
