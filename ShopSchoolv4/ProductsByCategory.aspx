<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductsByCategory.aspx.cs" Inherits="ShopSchoolv4.ProductsByCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Produkty w kategorii <%#Name %></h2>
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
                <EmptyDataTemplate>
                    <div class="row">
                        <div class="col-2">
                            <span class="text-bold">Nie ma testów w tej kategorii</span>
                        </div>
                    </div>
                </EmptyDataTemplate>
    </asp:ListView>
    </div>
</asp:Content>
