<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListBoxDemo.aspx.cs" Inherits="ListControlDemo_ListBoxDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <table>
        <tr>
            <td colspan="3">
               
                 <h3> Enter Country Name: 
                <asp:TextBox runat="server" ID="txtCountryName"></asp:TextBox> <br /></h3>
                <h3> Enter Country Code:   
                <asp:TextBox runat="server" ID="txtCountryCode" ></asp:TextBox><br /></h3>
                <h3><asp:Button runat="server" ID="btnAddItem" Text="Add Item" OnClick="btnAddItem_Click" />
                    &nbsp;&nbsp;&nbsp;
                    <asp:Button runat="server" ID="btnRemove" Text="Remove Item" OnClick="btnRemove_Click"/>
                    &nbsp;&nbsp;&nbsp;
                    <asp:Button runat="server" ID="btnChange" Text="Change Item" OnClick="btnChange_Click"/></h3>
                <hr />
            </td>
        </tr>
        <tr>
            <td>
                <asp:ListBox runat="server" ID="lsbCountry" SelectionMode="Multiple">
                    <asp:ListItem Value="91">India</asp:ListItem>
                    <asp:ListItem Value="92">China</asp:ListItem>
                    <asp:ListItem Value="93">Srilanka</asp:ListItem>
                    <asp:ListItem Value="94">Bangladesh</asp:ListItem>
                    <asp:ListItem Value="95">USA</asp:ListItem>
                </asp:ListBox>
            </td>

            <td>
                <asp:Button runat="server" ID="btnGrater" Text=">" OnClick="btnGrater_Click" /><br />
                <asp:Button runat="server" ID="btnDoubleGrater" Text=">>" OnClick="btnDoubleGrater_Click" /><br />
                <asp:Button runat="server" ID="btnLessthen" Text="<" OnClick="btnLessthen_Click" /><br />
                <asp:Button runat="server" ID="btnDoubleLessthen" Text="<<" OnClick="btnDoubleLessthen_Click" /><br />
            </td>

            <td>
                <asp:ListBox runat="server" ID="lsbSecond" SelectionMode="Multiple"></asp:ListBox>
            </td>
        </tr>
    </table>
        
    <div>
       

        <asp:Button runat="server" ID="btnDisplay" Text="Display" OnClick="btnDisplay_Click" />
                <br />
                <br />
                <asp:Label runat="server" ID="lblMessage" EnableViewState="False"></asp:Label>
                
                <br /><br />
            
                
                
    </div>
    </form>
</body>
</html>
