<%@ Page Language="C#" MasterPageFile="~/PptMaster.Master" AutoEventWireup="true" CodeBehind="sepet.aspx.cs" Inherits="Web.sepet" Title="Untitled Page" %>

<%@ Register Src="Sepet.ascx" TagName="Sepet" TagPrefix="uc1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:Sepet ID="Sepet1" runat="server" BaglantiGoster="false" />
    <br />
    Toplam Ücret:
    <asp:Label ID="ctlToplam" runat="server" Text="Label"></asp:Label>
</asp:Content>
