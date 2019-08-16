<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="FindTotal.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style/StyleSheet.css" rel="stylesheet" />
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
        <script src="Script/Script.js"></script>
</head>
<body>
     <form id="form1" runat="server">
        <h3>Enter Z Value </h3>
        <br />
        <asp:TextBox ID="ValueOfZ" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="ErrorMessage" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="SuccessMessage" runat="server" Text="" Style="font-size: 13px; color: green;"></asp:Label><br />
         <asp:Button ID="AddValueTo" runat="server" Text="Submit" OnClick="AddValueTo_Click" /> 
         <br />
        <br />
    </form>

    <div class="container">
        <div class="card">
            <span>X : </span>
            <asp:Label ID="LableForX" runat="server" Text=""></asp:Label></br>
        </div>
    </div>
    <br />
    <div class="container">
        <div class="card">
            <span>Y : </span>
            <asp:Label ID="LableForY" runat="server" Text=""></asp:Label>
            <br />
        </div>
    </div>
    <br />
    <div class="container">
        <div class="card">
            <span>Z : </span>
            <asp:Label ID="LableForZ" runat="server" Text=""></asp:Label><br />
            <br />
        </div>
    </div>
    <br />

    <div class="column">
        <div class="card">
            <span>TOTAL : </span>
            <asp:Label ID="LableForTotal" runat="server" Text=""></asp:Label>
        </div>
    </div>
    <br />
</body>
</html>
