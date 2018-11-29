<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="ShopSchoolv4.Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
