<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckBoxExamp.aspx.cs" Inherits="CheckBoxExamp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Choose your college:-&nbsp;
        <asp:CheckBox runat="server" ID="chkDiet" Text="DIET" />
        &nbsp;
        <asp:CheckBox runat="server" ID="chkDietDs" Text="DIETDS" /><br /><br />
        <asp:Button runat="server" ID="btnCollege" Text="Choose College" OnClick="btnCollege_Click" />
        <hr />
        <br />

        <asp:Label runat="server" ID="lblDiet" Text="On select of DIET:- " Visible="False"></asp:Label>
        <br />
        <asp:CheckBox ID="chkInverse" runat="server" AutoPostBack="True" OnCheckedChanged="chkInverse_CheckedChanged" Text="Inverse Selection" Visible="False" />
        <br />
        <asp:CheckBox ID="chkSelectAll" runat="server" Text="Select All" Visible="False" AutoPostBack="True" OnCheckedChanged="chkSelectAll_CheckedChanged"  />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="chkReset" runat="server" AutoPostBack="True" OnCheckedChanged="chkReset_CheckedChanged" Text="Reset All" Visible="False" />
        <br />
        <asp:CheckBox runat="server" ID="chkCE" Text="Degree in computer engineering" Visible="False" /><br />
        <asp:CheckBox runat="server" ID="chkMch" Text="Degree in mechanical engineering" Visible="False" /><br />  
        <asp:CheckBox runat="server" ID="chkEE" Text="Degree in electrical engineering" Visible="False" /><br />
        <asp:CheckBox runat="server" ID="chkCivil" Text="Degree in civil engineering" Visible="False" /><br />
        <br />

        <asp:Label runat="server" ID="lblDietds" Text="On select of DIETDS:- " Visible="False" ></asp:Label>
        <br />
        <asp:CheckBox ID="chkInverse1" runat="server" AutoPostBack="True" Text="Inverse Selection" Visible="False" />
        <br />
        <asp:CheckBox ID="chkSelect" runat="server" Text="Select All" Visible="False" AutoPostBack="True" OnCheckedChanged="chkSelect_CheckedChanged"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="chkReset1" runat="server" AutoPostBack="True" OnCheckedChanged="chkReset1_CheckedChanged" Text="Reset All" Visible="False" />
        <br />
        <asp:CheckBox runat="server" ID="chkDsCE" Text="Diploma in computer engineering" Visible="False" /><br />
        <asp:CheckBox runat="server" ID="chkDsMch" Text="Diploma in mechanical engineering" Visible="False" /><br />
        <asp:CheckBox runat="server" ID="chkDsEE" Text="Diploma in electrical engineering" Visible="False" /><br />
        <asp:CheckBox runat="server" ID="chkDsCivil" Text="Diploma in civil engineering" Visible="False" /><br />
        <br />

        <asp:Button runat="server" ID="btnSubmit" Text="Submit" Visible="False" OnClick="btnSubmit_Click" /><br />
        <asp:Label runat="server" ID="lblMessage"></asp:Label>
    </div>
    </form>
</body>
</html>
