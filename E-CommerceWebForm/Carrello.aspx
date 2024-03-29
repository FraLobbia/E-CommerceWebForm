﻿<%@ Page
    Title="Carrello"
    Language="C#"
    MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="Carrello.aspx.cs"
    Inherits="E_CommerceWebForm.Carrello" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="card flex-row justify-content-around align-items-center py-4 row">
            <div class="col">
                <h2>Totale Carrello:  <span id="totaleCarrello" runat="server">0</span> €</h2>
            </div>
            <div id="Riepilogo" runat="server" class="col">
            </div>
            <div class="col d-flex flex-column justify-content-center align-items-center">
                <asp:Button
                    ID="ClearCartButton"
                    runat="server"
                    Text="Svuota Carrello"
                    CssClass="btn btn-danger"
                    OnClick="ClearCartButton_Click" />
            </div>
        </div>
    </div>


    <div class="container" id="cartContainer" runat="server">
        <asp:Repeater ID="CarrelloRepeater" runat="server">
            <ItemTemplate>

                <div class='row card flex-row my-2'>
                   
                        <img
                            src='<%# Eval("Image") %>'
                            onclick='location.href="Dettagli.aspx?id_item=<%# Eval("id_item") %>"'
                            class='col'
                            alt='<%# Eval("Name") %>'>

                    <div class='col d-flex flex-column justify-content-center'>
                        <a href='Dettagli.aspx?id_item=<%# Eval("id_item") %>'>
                            <h3>
                                <%# Eval("Name") %></h3>
                        </a>
                        <p>
                            Prezzo: 
                                 <%# Eval("Price") %> €
                        </p>
                        <p class="fs-3">Quantità nel carrello: <%# Eval("QuantityInCart") %></p>
                    </div>

                    <div class='col d-flex flex-column justify-content-center align-items-center gap-4'>
                        <a
                            href='Dettagli.aspx?id_item=<%# Eval("id_item") %>'
                            class='btn btn-secondary px-3'>Dettagli</a>
                        <%-- Per far funzionare il button delete dentro il repeater serve inserire in web.config <pages enableEventValidation="false">  --%>
                        <asp:Button
                            CssClass="btn btn-danger px-3"
                            runat="server"
                            Text="Rimuovi"
                            OnClick="DeleteButton_Click"
                            CommandArgument='<%# Eval("id_item") %>' />
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>

    </div>
</asp:Content>
