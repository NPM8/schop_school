<%@ Page Title="Strona Główna" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShopSchoolv4._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Kategorie</h2>
    <div class="container">
        <asp:ListView ID="ListView2"
        ItemType="ShopSchoolv4.Models.Category"
        runat="server"
        DataKeyNames="ID"
        SelectMethod="GetCetegories" 
                GroupItemCount="3"
        >
                <GroupTemplate>
                    <div class="row" id="itemPlaceholderContainer" runat="server">
                        <div id="itemPlaceholder" runat="server"></div>
                    </div>
                </GroupTemplate>
        <ItemTemplate>
            <div class="card col-2">
              <a href="/ProductsByCategory.aspx?id=<%#:Item.ID %>">
                  <%#:Item.Name %>
              </a>
              
            </div>
        </ItemTemplate>
            </asp:ListView>
    </div>
    <h2>Produkty</h2>
    <div class="container">
            <asp:ListView ID="products"
        ItemType="ShopSchoolv4.Models.Product"
        runat="server"
        DataKeyNames="ID"
        SelectMethod="GetProducts" 
                GroupItemCount="3"
        >
                <GroupTemplate>
                    <div class="row" id="itemPlaceholderContainer" runat="server">
                        <div id="itemPlaceholder" runat="server"></div>
                    </div>
                </GroupTemplate>
        <ItemTemplate>
            <div class="card col-4">
              <img class="card-img-top" src="/Catalogue/Images/<%#:Item.ImgUrl%>" alt="Card image cap">
              <div class="card-body">
                <h5 class="card-title"><%#:Item.ProductName %></h5>
                  <p class="card-text">Cena: <%#:String.Format("{0:c}", Item.Cost)%></p>
                <a href="/ProductDetail.aspx?productId=<%#:Item.ID %>" class="btn">See Deatiles</a>
                  <a href="" class="btn btn-primary">Add to card</a>
              </div>
            </div>
        </ItemTemplate>
    </asp:ListView>
    </div>

</asp:Content>
