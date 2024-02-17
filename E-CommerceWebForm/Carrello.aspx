<%@ Page
    Title="Home Page"
    Language="C#"
    MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="Carrello.aspx.cs"
    Inherits="E_CommerceWebForm.Carrello"
     %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Totale Carrello:  <span id="totaleCarrello" runat="server">0</span> €</h2>

    <div class="container">
        <div id="CartListRow" runat="server" class="row gap-2 card-group">
            <asp:Repeater ID="CarrelloRepeater" runat="server">
                <ItemTemplate>
                    <div class="col-6 col-md-4 col-lg-3">
                        <div class='card border'>
                            <img
                                src='<%# Eval("Image") %>'
                                class='card-img-top'
                                alt='<%# Eval("Name") %>'
                                style='max-height: 200px; object-fit: contain'>

                            <div class='card-body d-flex flex-column justify-content-between mt-3'>
                                <div>
                                    <h5
                                        class='card-title'>
                                        <%# Eval("Name") %></h5>
                                    <p
                                        class='card-text'>
                                        Prezzo: 
                                 <%# Eval("Price") %> €
                                    </p>
                                </div>
                                <div class="mt-4">
                                    <a
                                        href='Dettagli.aspx?id_item=<%# Eval("id_item") %>'
                                        class='btn btn-primary'>Dettagli</a>
<%-- Per far funzionare il button delete dentro il repeater serve inserire in web.config <pages enableEventValidation="false">  --%>
                                    <asp:Button
                                        CssClass="btn btn-danger"
                                        runat="server"
                                        Text="Rimuovi"
                                        OnClick="DeleteButton_Click"
                                        CommandArgument='<%# Eval("id_item") %>' />
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
