<%@ Page Language="C#" MasterPageFile="~/PptMaster.Master" AutoEventWireup="true" CodeBehind="urunyonetim.aspx.cs" Inherits="Web.urunyonetim" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <table>
                <tr>
                    <td>
            <asp:Label ID="ctlFiltre" runat="server" CssClass="collapseOptions" Text="Filtreleme Seçenekleri"></asp:Label>
                    </td>
                    <td>
            <asp:Label ID="ctlEkle" runat="server" CssClass="collapseOptions" Text="Ürün Ekle"></asp:Label></td>
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
            <cc1:CollapsiblePanelExtender ID="CollapsiblePanelExtender2" runat="server" CollapseControlID="ctlFiltre"
                Collapsed="True" ExpandControlID="ctlFiltre" TargetControlID="ctlFilterPanel">
            </cc1:CollapsiblePanelExtender>
                    </td>
                    <td valign="top">
            <asp:Panel ID="ctlEklePanel" runat="server" CssClass="CollapsePanel" DefaultButton="ctlEkleBtn">
        <table cellpadding="2" cellspacing="2" style="width: 100%">
            <tr>
                <td>
                    Ad:</td>
                <td>
                    <asp:TextBox ID="ctlAd" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="ctlAd" ValidationGroup="Ekle"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>
                    Stok Adet:</td>
                <td>
                    <asp:TextBox ID="ctlAdet" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="ctlAdet" ValidationGroup="Ekle"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>
                    Ücret:</td>
                <td>
                    <asp:TextBox ID="ctlUcret" runat="server">100</asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ctlUcret"
                        ErrorMessage="*" InitialValue="1000" ValidationGroup="Ekle"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>
                    Resim Baðlantýsý:</td>
                <td>
                    <asp:TextBox ID="ctlResim" runat="server"></asp:TextBox></td>
                <td>
                    </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <asp:Button ID="ctlEkleBtn" runat="server" Text="Ekle" OnClick="ctlEkleBtn_Click" ValidationGroup="Ekle" />
                </td>
                <td>
                </td>
            </tr>
        </table>
            </asp:Panel>
            <cc1:CollapsiblePanelExtender ID="CollapsiblePanelExtender1" runat="server" CollapseControlID="ctlEkle"
                Collapsed="True" ExpandControlID="ctlEkle" TargetControlID="ctlEklePanel">
            </cc1:CollapsiblePanelExtender>
                    </td>
                </tr>
            </table>
    <asp:GridView ID="ctlÜrünGrid" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="odsÜrün" CssClass="Grid">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" />
            <asp:BoundField DataField="Ad" HeaderText="&#220;r&#252;n" SortExpression="Ad" />
            <asp:BoundField DataField="StokAdet" HeaderText="Stok Durumu" />
            <asp:BoundField DataField="Ucret" HeaderText="Ucret" />
            <asp:BoundField DataField="ResimBaglanti" HeaderText="ResimBaglanti" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" CancelText="Ýptal" DeleteText="Sil" EditText="D&#252;zenle" UpdateText="Kaydet" />
        </Columns>
    </asp:GridView>
            &nbsp;&nbsp;
        </ContentTemplate>
    </asp:UpdatePanel>
    &nbsp; &nbsp;&nbsp; &nbsp;<asp:ObjectDataSource ID="odsÜrün" runat="server" EnablePaging="True" InsertMethod="Ekle"
        MaximumRowsParameterName="maxSatir"
        SelectMethod="GetirÜrünler" StartRowIndexParameterName="baslangicSatir" TypeName="ÝþKatmaný.ÝþNesneleri.ÜrünÝþSýnýfý" DeleteMethod="Sil" UpdateMethod="Update" SelectCountMethod="GetirÜrünSayýsý" OnDeleted="odsÜrün_Deleted" OnInserted="odsÜrün_Inserted" OnUpdated="odsÜrün_Updated">
        <SelectParameters>
            <asp:ControlParameter ControlID="ctlFiltreAd" Name="ad" PropertyName="Text" Type="String" />
            <asp:Parameter Name="sira" Type="String" />
            <asp:Parameter Name="baslangicSatir" Type="Int32" />
            <asp:Parameter Name="maxSatir" Type="Int32" />
        </SelectParameters>
        <InsertParameters>
            <asp:Parameter Direction="InputOutput" Name="id" Type="Int32" />
            <asp:Parameter Name="ad" Type="String" />
            <asp:Parameter Name="StokAdet" Type="Int32" />
            <asp:Parameter Name="ResimBaglanti" Type="String" />
        </InsertParameters>
        <DeleteParameters>
            <asp:Parameter Name="id" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="id" Type="Int32" />
            <asp:Parameter Name="Ad" Type="String" />
            <asp:Parameter Name="StokAdet" Type="Int32" />
            <asp:Parameter Name="ResimBaglanti" Type="String" />
        </UpdateParameters>
    </asp:ObjectDataSource>
</asp:Content>
