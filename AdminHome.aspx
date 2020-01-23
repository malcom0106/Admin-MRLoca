<%@ Page Title="" Language="C#" MasterPageFile="~/Administration.master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="Admin_MRLoca.AdminHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentMain2" runat="server">
    <figure class="figure col-12">
        <asp:Label ID="lblAdmin" runat="server" Text=""></asp:Label>
        <ul class="list-group">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AdminReservations.aspx"><li class="list-group-item">
                Reservations
            </li></asp:HyperLink>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/AdminClients.aspx"><li class="list-group-item">
                Clients
            </li></asp:HyperLink>
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/AdminHebergements.aspx"><li class="list-group-item">
                Hebergements
            </li></asp:HyperLink>
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/AdminAvis.aspx"><li class="list-group-item">
                Avis
            </li></asp:HyperLink>
            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/AdminMessagerie.aspx"><li class="list-group-item">
                Messagerie
            </li></asp:HyperLink>
        </ul>
    </figure>
</asp:Content>
