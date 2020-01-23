<%@ Page Title="" Language="C#" MasterPageFile="~/Administration.master" AutoEventWireup="true" CodeBehind="AdminHebergements.aspx.cs" Inherits="Admin_MRLoca.AdminHebergements" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentMain2" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:ListView ID="lsvHebergement" runat="server" OnPagePropertiesChanging="lsvHebergement_PagePropertiesChanging" OnItemDataBound="lsvHebergement_ItemDataBound">
                <ItemTemplate>
                    <div class="d-flex col-12 border shadow p-3 mb-3 bg-white rounded">
                        <div class="col-3 text-right">
                            <a href="#" data-toggle="modal" data-target="#ModalPhoto"><asp:Image ID="Image1" CssClass="img-fluid" runat="server" ImageUrl='<%# Eval("Photo") %>'/></a>
                        </div>
                        <div class="col-9 text-left">
                            <div class="d-flex align-items-end flex-column bd-highlight mb-3">
                                <div class="p-2 bd-highlight">
                                    <strong><%# Eval("Nom") %></strong>
                                </div>
                                <div class="p-2 bd-highlight"><%# Eval("Description") %></div>
                                <div class="p-2 bd-highlight"><asp:Label ID="lblStatut" runat="server" CssClass=""></asp:Label></div>                     
                                <div id="btns" class="mt-auto p-2 bd-highlight">
                                    <asp:Button CssClass="btn btn-primary" ID="btnActive" runat="server" Text="Activé" CommandArgument='<%# Eval("IdHebergement") %>' OnClick="btnDesactive_Click"/>
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>        
            </asp:ListView>
            <asp:DataPager ID="DataPager1" runat="server" PageSize="10" PagedControlID="lsvHebergement">
                <Fields>
                    <asp:NumericPagerField NumericButtonCssClass="btn btn-secondary" CurrentPageLabelCssClass="btn btn-warning"/>
                </Fields>
            </asp:DataPager>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
