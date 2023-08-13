<%@ Page Language="C#" MasterPageFile="~/PptMaster.Master" AutoEventWireup="true" CodeBehind="giris.aspx.cs" Inherits="Web.giris" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
    <asp:Login ID="ctlLogin" runat="server" FailureText="Giriþ baþarýsýz. Lütfen tekrar deneyin."
        LoginButtonText="Giriþ Yap" OnAuthenticate="ctlLogin_Authenticate" PasswordLabelText="Þifre:"
        PasswordRequiredErrorMessage="Þifre boþ olamaz." RememberMeText="Beni hatýrla."
        TitleText="Kullanýcý Giriþi" UserNameLabelText="Kullanýcý Adý:" UserNameRequiredErrorMessage="Kullanýcý adý boþ olamaz." OnLoggedIn="ctlLogin_LoggedIn">
    </asp:Login>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
