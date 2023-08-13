<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Katsayı Giriniz:"></asp:Label><br />
        <br />
        <asp:TextBox ID="ctlKatsayı" runat="server"></asp:TextBox><br />
        <br />
        <asp:Button ID="ctlHesapla" runat="server" OnClick="ctlHesapla_Click" Text="Hesapla" /><br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Sonuç: "></asp:Label>
        <asp:Label ID="ctlSonuç" runat="server"></asp:Label><br />
    
    </div>
    </form>
</body>
</html>
