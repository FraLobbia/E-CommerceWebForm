<%@ Page Title="Dettagli" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dettagli.aspx.cs" Inherits="E_CommerceWebForm.Dettagli" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        


       

        <asp:Image
            ID="itemImage"
            runat="server"
            ImageUrl=""
            Width="200px"
            Height="200px"
            AlternateText="Product Image"
        />

        <p id="itemTitle" runat="server"></p>
        <p id="itemPrice" runat="server"></p>

        

        


        <asp:Button ID="addToCartButton" runat="server" Text="Aggiungi al carrello" OnClick="addToCart" />


    </main>
</asp:Content>
