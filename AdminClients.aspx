<%@ Page Title="" Language="C#" MasterPageFile="~/Administration.master" AutoEventWireup="true" CodeBehind="AdminClients.aspx.cs" Inherits="Admin_MRLoca.AdminClients" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentMain2" runat="server">
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:ListView ID="lsvClient" runat="server" OnPagePropertiesChanging="lsvClient_PagePropertiesChanging" OnItemDataBound="lsvClient_ItemDataBound">
                <ItemTemplate>
                    <div class="d-flex col-12 border shadow p-3 mb-3 bg-white rounded">
                        <div class="col-12">
                            <div class="d-flex  flex-column bd-highlight mb-3">
                                <div class="p-2 bd-highlight">
                                    <p><strong><%# Eval("Nom") %> <%# Eval("Prenom") %></strong> - <%# Eval("login") %></p>
                                    <p>Mél. : <%# Eval("Email") %> - Tél. : <%# Eval("Email") %></p>
                                </div>                                 
                                <div id="btns" class="mt-auto p-2 bd-highlight">
                                    <asp:Button CssClass="btn btn-primary" ID="btnActive" runat="server" Text="Activé" CommandArgument='<%# Eval("IdClient") %>' OnClick="btnActive_Click"/>
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>        
            </asp:ListView>
            <asp:DataPager ID="dtpClients" runat="server" PageSize="10" PagedControlID="lsvClient">
                <Fields>
                    <asp:NumericPagerField NumericButtonCssClass="btn btn-secondary" CurrentPageLabelCssClass="btn btn-warning"/>
                </Fields>
            </asp:DataPager>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
