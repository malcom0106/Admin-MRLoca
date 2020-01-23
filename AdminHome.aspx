<%@ Page Title="" Language="C#" MasterPageFile="~/Administration.master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="Admin_MRLoca.AdminHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentMain2" runat="server">
    <asp:Label ID="lblAdmin" runat="server" Text=""></asp:Label>
    <ul class="list-group">
        <li class="list-group-item">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AdminReservations.aspx">Reservations</asp:HyperLink>
        </li>
        <li class="list-group-item">
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/AdminClients.aspx">Reservations</asp:HyperLink>Clients
        </li>
        <li class="list-group-item">
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/AdminHebergements.aspx">Hebergements</asp:HyperLink>
        </li>
        <li class="list-group-item">
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/AdminAvis.aspx">Avis</asp:HyperLink>
        </li>
        <li class="list-group-item">
            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/AdminMessagerie.aspx">Messagerie</asp:HyperLink>
        </li>
    </ul>
</asp:Content>
