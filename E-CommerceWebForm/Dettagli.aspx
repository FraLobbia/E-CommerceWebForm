<%@ Page
    Title="Dettagli"
    Language="C#"
    MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="Dettagli.aspx.cs"
    Inherits="E_CommerceWebForm.Dettagli" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">

        <%-- div da riempire nel caso non ci sia id --%>
        <div id="idNonTrovato" runat="server"></div>


        <div id="ContainerPage" runat="server" class="container">
            <div class='card border w-100'>
                <asp:Image
                    ID="itemImage"
                    runat="server"
                    class='mt-2'
                    Style='max-height: 600px; object-fit: contain' />
                <div
                    class='card-body d-flex flex-column justify-content-between mt-3'>
                    <div>
                        <div class="d-flex gap-3 align-items-center">

                            <h1
                                id="itemTitle"
                                runat="server"
                                class='card-title d-inline'></h1>
                            <span
                                id="itemPrice"
                                runat="server"
                                class='badge bg-info text-bg-info p-2 fs-5'>
                            </span>

                        </div>

                        <h5
                            id="itemCategory"
                            runat="server"></h5>

                        <p
                            id="itemDescription"
                            runat="server"
                            class='card-text'>
                        </p>
                        <a href='Carrello.aspx'>
                        <p id="qntInCart" runat="server" class="text-end"></p></a>
                    </div>

                    <asp:Button
                        ID="addToCartButton"
                        CssClass="btn btn-success ms-auto p-4"
                        runat="server"
                        Text="Aggiungi al carrello"
                        OnClick="addToCartButton_Click"/>



                </div>
            </div>
        </div>
    </main>
</asp:Content>
