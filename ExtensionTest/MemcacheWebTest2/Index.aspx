<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="MemcacheWebTest2.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        input:<asp:TextBox ID="inputTxtBox" runat="server"></asp:TextBox> <br />
        result:<asp:Label ID="resultLbl" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Button ID="storeBtn" runat="server" Text="Store" OnClick="storeBtn_Click" />
    </div>
    
    </form>
</body>
</html>

