<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TournamentForm.aspx.cs" Inherits="FrontEnd.TournamentForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .Title {
            font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
            font-size: xx-large;
            font-weight: 500;
            text-transform: capitalize;
            color: #000080;
        }
        #TextArea1 {
            width: 504px;
            height: 252px;
            margin-left: 0px;
        }
        .auto-style1 {
            margin-left: 480px;
        }
        .auto-style2 {
            margin-left: 480px;
        }
        .auto-style3 {
            margin-left: 480px;
        }
        .auto-style4 {
            margin-left: 480px;
        }
        .auto-style5 {
            margin-left: 480px;
        }
        .auto-style6 {
            margin-left: 480px;
        }
        .auto-style7 {
            margin-left: 600px;
        }
        .auto-style8 {
            width: 396px;
            height: 275px;
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="Title">
            TOURNAMENT SCHEDULER&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        <p>
            <br />
        </p>
        <p>
            &nbsp;</p>
        <p class="auto-style1">
            Tournament Name&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tNametxtBox" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style2">
            Start Date&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p class="auto-style7">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Calendar ID="sDate" runat="server"></asp:Calendar>
        </p>
        <p class="auto-style3">
            End Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p class="auto-style7">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Calendar ID="eDate" runat="server"></asp:Calendar>
        </p>
        <p class="auto-style4">
            Venue&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtBoxVenue" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style5">
            Tournament Type&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="tTypeDropList" runat="server">
                <asp:ListItem>Round Robin</asp:ListItem>
                <asp:ListItem>Group Stage</asp:ListItem>
                <asp:ListItem>Group Stage and Knockout</asp:ListItem>
                <asp:ListItem>Knockout</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p class="auto-style6">
            Add Players/Teams
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <textarea id="playerTxtArea" class="auto-style8" name="S1"></textarea>
            <asp:Button ID="addButton" runat="server" Text="Add" />
        </p>
        <p>
            &nbsp;</p>
        <p class="auto-style1">
            <asp:Button ID="generateBtn" runat="server" Text="Generate Tournament" />
        </p>
    </form>
</body>
</html>
