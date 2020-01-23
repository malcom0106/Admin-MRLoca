<%@ Page Title="" Language="C#" MasterPageFile="~/Administration.master" AutoEventWireup="true" CodeBehind="AdminReservations.aspx.cs" Inherits="Admin_MRLoca.AdminReservations" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentMain2" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:ListView ID="lsvReservations" runat="server" OnPagePropertiesChanging="" OnItemDataBound="">
                <ItemTemplate>
                    <div class="d-flex col-12 border shadow p-3 mb-3 bg-white rounded">

                        <div class="col-12">
                            <div class="d-flex flex-column bd-highlight mb-3">
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
            <asp:DataPager ID="DataPager" runat="server" PageSize="10" PagedControlID="lsvReservations">
                <Fields>
                    <asp:NumericPagerField NumericButtonCssClass="btn btn-secondary" CurrentPageLabelCssClass="btn btn-warning"/>
                </Fields>
            </asp:DataPager>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
