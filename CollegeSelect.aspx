<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CollegeSelect.aspx.cs" Inherits="CollegeSelect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Select Your College:</h2>
        <asp:RadioButton runat="server" ID="rbDiet" GroupName="College" />DIET
        <asp:RadioButton runat="server" ID="rbDietds" GroupName="College" />DIETDS
        <br />
        <br />
        <asp:Button runat="server" ID="btnCollege" Text="Click Me" OnClick="btnCollege_Click"/>
        <hr />
        <br />
        <asp:Label runat="server" ID="lblDiet" Text=" On Select of DIET :-" Visible="False"></asp:Label>
        <br />
        <asp:RadioButton runat="server" ID="rbcomp" GroupName="DIET" Text="Degree in Computer Engineering" Visible="False" /><br />
        <asp:RadioButton runat="server" ID="rbMech" GroupName="DIET" Text="Degree in Mechanical Engineering" Visible="False" /><br />
        <asp:RadioButton runat="server" ID="rbElect" GroupName="DIET" Text="Degree in Electrical Engineering" Visible="False" /><br />
        <asp:RadioButton runat="server" ID="rbCivil" GroupName="DIET" Text="Degree in Civil Engineering" Visible="False" /><br />
        <br />
        <br />

        <asp:Label runat="server" ID="lblDiestds" Text=" On Select of DIETDS :-" Visible="False"></asp:Label>
        <br />
        <asp:RadioButton runat="server" ID="rbDSComp" GroupName="DIETDS" Text="Diploma in Computer Engineering" Visible="False" /><br />
        <asp:RadioButton runat="server" ID="rbDSMech" GroupName="DIETDS" Text="Diploma in Mechanical Engineering" Visible="False" /><br />
        <asp:RadioButton runat="server" ID="rbDSElect" GroupName="DIETDS" Text="Diploma in Electrical Engineering" Visible="False" /><br />
        <asp:RadioButton runat="server" ID="RbDSCivil" GroupName="DIETDS" Text="Diploma in Civil Engineering" Visible="False" /><br />
        <br />

        <asp:Button runat="server" ID="btnDept" Text="Submit" OnClick="btnDept_Click" Visible="False"/>
        <br />
        <br />
        <asp:Label runat="server" ID="lblMessage"></asp:Label>
    </div>
    </form>
</body>
</html>
