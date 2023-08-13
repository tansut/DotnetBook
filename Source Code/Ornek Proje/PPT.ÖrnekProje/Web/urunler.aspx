<%@ Page Language="C#" MasterPageFile="~/PptMaster.Master" AutoEventWireup="true" CodeBehind="urunler.aspx.cs" Inherits="Web.urunler" Title="Untitled Page" %>

<%@ Register Src="Sepet.ascx" TagName="Sepet" TagPrefix="uc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <table style="width: 90%">
                <tr>
                    <td>
            <asp:Label ID="ctlFiltre" runat="server" CssClass="collapseOptions" Text="Ürün Ara"></asp:Label>
                    </td>
                    <td>
            </td>
                </tr>
                <tr>
                    <td valign="top">
            <asp:Panel ID="ctlFilterPanel" runat="server" CssClass="CollapsePanel" DefaultButton="ctlFilterBtn">
                <table cellpadding="2" cellspacing="2" style="width: 100%">
                    <tr>
                        <td>
                            Ad:</td>
                        <td>
                            <asp:TextBox ID="ctlFiltreAd" runat="server"></asp:TextBox></td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td>
                            <asp:Button ID="ctlFilterBtn" runat="server" Text="Filtrele" CausesValidation="False" OnClick="ctlFilterBtn_Click" />
                        </td>
                        <td>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
    <asp:GridView ID="ctlÜrünGrid" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="odsÜrün" CssClass="Grid" OnRowCommand="ctlÜrünGrid_RowCommand" OnRowDataBound="ctlÜrünGrid_RowDataBound" Width="100%">
        <Columns>
            <asp:ImageField HeaderText="&#220;r&#252;n Resmi" DataImageUrlField="ResimBaglanti" NullImageUrl="~/Resimler/Urunler/yok.jpg">
            </asp:ImageField>
            <asp:BoundField DataField="Ad" HeaderText="&#220;r&#252;n Adý" SortExpression="Ad" />
            <asp:BoundField DataField="StokAdet" HeaderText="Stok Durumu" DataFormatString="{0} Adet" />
            <asp:BoundField DataField="Ucret" DataFormatString="{0:c}" HeaderText="&#220;cret" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text="Adet:"></asp:Label>
                    <asp:TextBox ID="ctlAdet" runat="server" Width="22px">1</asp:TextBox>&nbsp;<asp:Button
                        ID="ctlSepetEkleBtn" runat="server" CommandName="SepetEkle" Text="Ekle" />
                    <asp:Label ID="ctlUyarý" runat="server" Font-Bold="True" ForeColor="#00C000" Text="*" ToolTip="Bu ürün sepetinizde bulunmaktadýr."></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
                    </td>
                    <td valign="top">
                        <uc1:Sepet ID="ctlSepet" runat="server" />
                    </td>
                </tr>
            </table>
            &nbsp; &nbsp;
            <cc1:CollapsiblePanelExtender ID="CollapsiblePanelExtender1" runat="server" CollapseControlID="ctlFiltre"
                Collapsed="True" ExpandControlID="ctlFiltre" TargetControlID="ctlFilterPanel">
            </cc1:CollapsiblePanelExtender>

    <asp:ObjectDataSource ID="odsÜrün" runat="server" EnablePaging="True"
        MaximumRowsParameterName="maxSatir"
        SelectMethod="GetirÜrünler" StartRowIndexParameterName="baslangicSatir" TypeName="ÝþKatmaný.ÝþNesneleri.ÜrünÝþSýnýfý" SelectCountMethod="GetirÜrünSayýsý">
        <SelectParameters>
            <asp:ControlParameter ControlID="ctlFiltreAd" Name="ad" PropertyName="Text" Type="String" />
            <asp:Parameter Name="sira" Type="String" />
            <asp:Parameter Name="baslangicSatir" Type="Int32" />
            <asp:Parameter Name="maxSatir" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
