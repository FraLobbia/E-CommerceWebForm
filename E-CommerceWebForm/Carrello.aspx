<%@ Page
    Title="Carrello"
    Language="C#"
    MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="Carrello.aspx.cs"
    Inherits="E_CommerceWebForm.Carrello" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Totale Carrello:  <span id="totaleCarrello" runat="server">0</span> €</h2>
    <div class="container" id="cartContainer" runat="server">

        <asp:Repeater ID="CarrelloRepeater" runat="server">
            <ItemTemplate>

                <div class='row card flex-row my-2'>

                    <img
                        src='<%# Eval("Image") %>'
                        class='col'
                        alt='<%# Eval("Name") %>'
                        style='max-height: 200px; object-fit: contain'>

                    <div class='col d-flex flex-column justify-content-center'>
                        <h3
                            >
                            <%# Eval("Name") %></h3>
                        <p
                            >
                            Prezzo: 
                                 <%# Eval("Price") %> €
                        </p>
                    </div>

                    <div class='col d-flex flex-column justify-content-center align-items-center gap-4'>
                        <a
                            href='Dettagli.aspx?id_item=<%# Eval("id_item") %>'
                            class='btn btn-primary p-3'>Dettagli</a>
                        <%-- Per far funzionare il button delete dentro il repeater serve inserire in web.config <pages enableEventValidation="false">  --%>
                        <asp:Button
                            CssClass="btn btn-danger p-3"
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
