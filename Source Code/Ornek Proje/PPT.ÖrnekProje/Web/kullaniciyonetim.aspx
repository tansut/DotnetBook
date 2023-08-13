<%@ Page Language="C#" MasterPageFile="~/PptMaster.Master" AutoEventWireup="true" CodeBehind="kullaniciyonetim.aspx.cs" Inherits="Web.kullaniciyonetim" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <table>
                <tr>
                    <td>
            <asp:Label ID="ctlFiltre" runat="server" CssClass="collapseOptions" Text="Filtreleme Se�enekleri"></asp:Label>
                    </td>
                    <td>
            <asp:Label ID="ctlEkle" runat="server" CssClass="collapseOptions" Text="Kullan�c� Ekle"></asp:Label></td>
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
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="ctlAd"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>
                    �ifre:</td>
                <td>
                    <asp:TextBox ID="ctlSifre" runat="server" TextMode="Password"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="ctlSifre"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>
                    Rol:</td>
                <td>
                    <asp:DropDownList ID="ctlRol" runat="server">
                        <asp:ListItem>[Se&#231;iniz]</asp:ListItem>
                        <asp:ListItem>Standart</asp:ListItem>
                        <asp:ListItem>Y&#246;netici</asp:ListItem>
                    </asp:DropDownList></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="ctlRol" InitialValue="[Se�iniz]"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <asp:Button ID="ctlEkleBtn" runat="server" Text="Ekle" OnClick="ctlEkleBtn_Click" />
                </td>
                <td>
                </td>
            </tr>
        </table>
            </asp:Panel>
                    </td>
                </tr>
            </table>
    <asp:GridView ID="ctlKullan�c�Grid" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="odsKullan�c�" CssClass="Grid">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" />
            <asp:BoundField DataField="Ad" HeaderText="Kullan�c� Ad" SortExpression="Ad" />
            <asp:TemplateField HeaderText="Son Giri� Tarihi" SortExpression="SonGiris">
                <EditItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("SonGiris") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("SonGiris") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Rol">
                <EditItemTemplate>
                    <asp:DropDownList ID="ctlRol" runat="server" SelectedValue='<%# Bind("Rol", "{0}") %>'>
                        <asp:ListItem>Standart</asp:ListItem>
                        <asp:ListItem>Y&#246;netici</asp:ListItem>
                    </asp:DropDownList>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Rol") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowDeleteButton="True" DeleteText="Sil" />
        </Columns>
    </asp:GridView>
            <cc1:CollapsiblePanelExtender ID="CollapsiblePanelExtender1" runat="server" CollapseControlID="ctlEkle"
                Collapsed="True" ExpandControlID="ctlEkle" TargetControlID="ctlEklePanel">
            </cc1:CollapsiblePanelExtender>
            <cc1:CollapsiblePanelExtender ID="CollapsiblePanelExtender2" runat="server" CollapseControlID="ctlFiltre"
                Collapsed="True" ExpandControlID="ctlFiltre" TargetControlID="ctlFilterPanel">
            </cc1:CollapsiblePanelExtender>

    <asp:ObjectDataSource ID="odsKullan�c�" runat="server" EnablePaging="True" InsertMethod="Ekle"
        MaximumRowsParameterName="maxSatir"
        SelectMethod="Ara" StartRowIndexParameterName="baslangicSatir" TypeName="��Katman�.��Nesneleri.Kullan�c���S�n�f�" DeleteMethod="Sil" UpdateMethod="G�ncelleRol" SelectCountMethod="GetirKullan�c�Say�s�" OnDeleted="odsKullan�c�_Deleted" OnInserted="odsKullan�c�_Inserted" OnUpdated="odsKullan�c�_Updated">
        <SelectParameters>
            <asp:ControlParameter ControlID="ctlFiltreAd" Name="ad" PropertyName="Text" Type="String" />
            <asp:Parameter Name="sira" Type="String" />
            <asp:Parameter Name="baslangicSatir" Type="Int32" />
            <asp:Parameter Name="maxSatir" Type="Int32" />
        </SelectParameters>
        <InsertParameters>
            <asp:Parameter Direction="InputOutput" Name="id" Type="Int32" />
            <asp:Parameter Name="ad" Type="String" />
            <asp:Parameter Name="�ifre" Type="String" />
            <asp:Parameter Name="rol" Type="String" />
        </InsertParameters>
        <DeleteParameters>
            <asp:Parameter Name="id" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="id" Type="Int32" />
            <asp:Parameter Name="rol" Type="String" />
            <asp:Parameter Name="sonGiris" Type="DateTime" />
        </UpdateParameters>
    </asp:ObjectDataSource>
        </ContentTemplate>
    </asp:UpdatePanel>
    
</asp:Content>
