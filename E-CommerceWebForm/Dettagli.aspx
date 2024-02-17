<%@ Page
    Title="Dettagli"
    Language="C#"
    MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="Dettagli.aspx.cs"
    Inherits="E_CommerceWebForm.Dettagli" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">


        <h2 id="title"><%: Title %>.</h2>

        <div class="container">
            <div runat="server" class="row row-cols-3 gap-2 card-group">

                <itemtemplate>
                    <div class='card col border'>
                        <asp:Image
                            ID="itemImage"
                            runat="server"
                            Style='max-height: 200px; object-fit: contain' />
                        <div
                            class='card-body d-flex flex-column justify-content-between mt-3'>
                            <div>
                                <h5
                                    id="itemTitle"
                                    runat="server"
                                    class='card-title'></h5>
                                <p
                                    id="itemPrice"
                                    runat="server"
                                    class='badge bg-secondary'>
                                </p>
                            </div>
                            <div>
                                <asp:Button
                                    ID="addToCartButton"
                                    CssClass="btn btn-success"
                                    runat="server"
                                    Text="Aggiungi al carrello"
                                    OnClick="addToCart" />
                            </div>
                        </div>
                    </div>
                </itemtemplate>

            </div>
        </div>
    </main>
</asp:Content>
