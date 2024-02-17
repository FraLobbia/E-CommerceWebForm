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
                                <h1
                                    id="itemTitle"
                                    runat="server"
                                    class='card-title'></h1>
                                
                                    <h5
                                        ID="itemCategory"
                                        runat="server">
                                    </h5>
                               
                                <p
                                    id="itemDescription"
                                    runat="server"
                                    class='card-text'></p>
                                <p
                                    id="itemPrice"
                                    runat="server"
                                    class='badge bg-secondary'>
                                </p>
                                <p id="qntInCart" runat="server"></p>
                            </div>
                            <div>
                                <asp:Button
                                    ID="addToCartButton"
                                    CssClass="btn btn-success"
                                    runat="server"
                                    Text="Aggiungi al carrello"
                                    OnClick="addToCartButton_Click"/>
                            </div>
                        </div>
                    </div>
                </itemtemplate>

            </div>
        </div>
    </main>
</asp:Content>
