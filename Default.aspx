<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Admin_MRLoca._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <figure class="figure bg-white py-2 col-12 border shadow my-2 bg-white rounded">            
            <div>
                <div class="form-inline">
                    <label for="exampleInputEmail1" class="d-none d-sm-block col-12 col-md-4">Login : </label>
                    <asp:TextBox ID="txtLogin" runat="server" placeholder="Entrer votre login" CssClass="form-control col-12 col-md-8" TextMode="SingleLine"></asp:TextBox>
                    <asp:RequiredFieldValidator Display="None" ControlToValidate="txtLogin" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Veuillez Saisir un Email"></asp:RequiredFieldValidator>
    <%--                <asp:RegularExpressionValidator Display="None" ControlToValidate="txtEmail" ID="RegularExpressionValidator2" runat="server" ErrorMessage="Veuillez saisir un email correct" ValidationExpression="^[^\W][a-zA-Z0-9_]+(\.[a-zA-Z0-9_]+)*\@[a-zA-Z0-9_]+(\.[a-zA-Z0-9_]+)*\.[a-zA-Z]{2,4}$"></asp:RegularExpressionValidator>--%>
                </div>
                <div class="form-inline">
                    <label for="exampleInputPassword1" class="d-none d-sm-block col-12 col-md-4">Password : </label>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Password" CssClass="form-control col-12 col-md-8"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                </div>
                <div class="text-center col-12">
                    <asp:Button ID="btnValider" runat="server" Text="Valider" OnClick="btnValider_Click" class="btn btn-primary text-center"/>
                </div>            
            </div>
        </figure>
</asp:Content>
