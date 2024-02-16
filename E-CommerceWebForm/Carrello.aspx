<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="E_CommerceWebForm.Carrello" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



    <h2>Totale Carrello:  <span id="totaleCarrello" runat="server">0</span></h2>


<div class="container">
    <div id="containerProducts" runat="server" class="row row-cols-3 gap-2 card-group"></div>
</div>


</asp:Content>
