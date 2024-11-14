<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Store.aspx.cs" Inherits="Store" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Store Item Selection</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- ListBox to display store items -->
            <asp:ListBox ID="lstItems" runat="server" AutoPostBack="true" OnSelectedIndexChanged="lstItems_SelectedIndexChanged">
                <asp:ListItem Text="Laptop" Value="Laptop" />
                <asp:ListItem Text="Smartphone" Value="Smartphone" />
                <asp:ListItem Text="Tablet" Value="Tablet" />
                <asp:ListItem Text="Headphones" Value="Headphones" />
                <asp:ListItem Text="Smartwatch" Value="Smartwatch" />
            </asp:ListBox>

            <!-- Image control to display the image of the selected product -->
            <asp:Image ID="storeImage" runat="server" Visible="false" />

            <!-- Button to show the price of the selected product -->
            <asp:Button ID="btnShowPrice" runat="server" Text="Show Price" OnClick="btnShowPrice_Click" />

            <!-- Label to display the price -->
            <asp:Label ID="lblPrice" runat="server" Text="" Font-Bold="true" ForeColor="Green" />
        </div>
    </form>
</body>
</html>
