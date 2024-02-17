﻿<%@ Page
    Title="Home Page"
    Language="C#"
    MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="Default.aspx.cs"
    Inherits="E_CommerceWebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div runat="server" class="row gy-2 card-group">
            <asp:Repeater ID="CatalogoRepeater" runat="server">
                <ItemTemplate>
                    <div class="col-6 col-md-4 col-lg-3">
                        <div class='card border'>
                            <img
                                src='<%# Eval("Image") %>'
                                class='card-img-top pt-2'
                                alt='<%# Eval("Name") %>'
                                style='max-height: 200px; object-fit: contain'>

                            <div class='card-body d-flex flex-column justify-content-between mt-3'>
                                <div>
                                    <h5
                                        class='card-title'>
                                        <%#Eval("Name") %></h5>
                                    <p
                                        class='card-text badge bg-gradient'>
                                        Prezzo: 
                                    <%# Eval("Price") %> €
                                    </p>
                                </div>
                                <div class="mt-4 d-flex justify-content-center gap-2 flex-wrap">
                                    <a
                                        href='Dettagli.aspx?id_item=<%# Eval("id_item") %>'
                                        class='btn btn-primary'>Dettagli</a>
                                    <asp:Button
                                        ID="addToCartButton"
                                        OnClick="addToCartButton_Click"
                                        CssClass="btn btn-success"
                                        runat="server"
                                        Text="Aggiungi al carrello" />
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

</asp:Content>
