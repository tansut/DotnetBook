<%@ Page Language="C#" MasterPageFile="~/PptMaster.Master" AutoEventWireup="true" CodeBehind="giris.aspx.cs" Inherits="Web.giris" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
    <asp:Login ID="ctlLogin" runat="server" FailureText="Giri� ba�ar�s�z. L�tfen tekrar deneyin."
        LoginButtonText="Giri� Yap" OnAuthenticate="ctlLogin_Authenticate" PasswordLabelText="�ifre:"
        PasswordRequiredErrorMessage="�ifre bo� olamaz." RememberMeText="Beni hat�rla."
        TitleText="Kullan�c� Giri�i" UserNameLabelText="Kullan�c� Ad�:" UserNameRequiredErrorMessage="Kullan�c� ad� bo� olamaz." OnLoggedIn="ctlLogin_LoggedIn">
    </asp:Login>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
