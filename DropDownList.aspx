<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DropDownList.aspx.cs" Inherits="ListControlDemo_DropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <h3> Enter Country Name: 
                <asp:TextBox runat="server" ID="txtCountryName"></asp:TextBox> <br /></h3>
                <h3> Enter Country Code:   
                <asp:TextBox runat="server" ID="txtCountryCode" ></asp:TextBox><br /></h3>
                <h3><asp:Button runat="server" ID="btnAddItem" Text="Add Item" OnClick="btnAddItem_Click" />
                &nbsp;&nbsp;&nbsp;
                <asp:Button runat="server" ID="btnRemove" Text="Remove Item" OnClick="btnRemove_Click" /></h3>
                <hr />
          
                <asp:DropDownList runat="server" ID="ddlCountry">
                    <asp:ListItem Value="91">India</asp:ListItem>
                    <asp:ListItem Value="92">China</asp:ListItem>
                    <asp:ListItem Value="93">Srilanka</asp:ListItem>
                    <asp:ListItem Value="94">Bangladesh</asp:ListItem>
                    <asp:ListItem Value="95">USA</asp:ListItem>
                </asp:DropDownList>
                <br /><br />
                
                <asp:Button runat="server" ID="btnDisplay" Text="Display" OnClick="btnDisplay_Click" />
                <br />
                <br />
                <asp:Label runat="server" ID="lblMessage" EnableViewState="False"></asp:Label>
        </div>
    
    </form>
</body>
</html>
