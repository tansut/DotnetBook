<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Sepet.ascx.cs" Inherits="Web.Sepet" %>
<%@ Register Assembly="Web.Controls" Namespace="Web.Controls" TagPrefix="ppt" %>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <asp:HyperLink ID="ctlBaglanti" runat="server" ImageUrl="~/Resimler/icon-cart.gif"
            NavigateUrl="~/sepet.aspx"></asp:HyperLink>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="odsSepet" AutoGenerateColumns="False" CssClass="Grid" EnableViewState="False" OnDataBinding="GridView1_DataBinding" OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound" EmptyDataText="Alýþveriþ sepetiniz boþ." ToolTip="Alýþveriþ Sepeti">
            <Columns>
                <asp:BoundField DataField="&#220;r&#252;nAd" HeaderText="&#220;r&#252;n" />
                <asp:BoundField DataField="Adet" HeaderText="Adet" />
                <asp:BoundField DataField="ToplamUcret" HeaderText="&#220;cret" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="ctlSil" runat="server" CommandName="Sil" ImageUrl="~/Resimler/sil.gif" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <ppt:sepetdatasource id="odsSepet" runat="server" enableviewstate="False"></ppt:sepetdatasource>
    </ContentTemplate>
</asp:UpdatePanel>
