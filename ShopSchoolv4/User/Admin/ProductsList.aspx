<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMain.Master" AutoEventWireup="true" CodeBehind="ProductsList.aspx.cs" Inherits="ShopSchoolv4.ProductsList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
                <div class="d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom">
                    <h1 class="h2">Produkty</h1>
                </div>
                <div class="table-responsive">
                    <table class="table table-striped table-sm">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Nazwa</th>
                                <th>Opis</th>
                                <th>Koszt</th>
                                <th>Link obrazka</th>
                                <th>Kategoria</th>
                                <th>Edytuj</th>
                                <th>Usuń</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:ListView ID="userList" runat="server" DataKeyNames="ID" ItemType="ShopSchoolv4.Models.Product" SelectMethod="GetProducts">
                                <EmptyItemTemplate>
                                    <tr>
                                        <td>#</td>
                                        <td>No Item</td>
                                    </tr>
                                </EmptyItemTemplate>
                                <EmptyDataTemplate>
                                    <tr>
                                        <td>#</td>
                                        <td>No Items et all</td>
                                    </tr>
                                </EmptyDataTemplate>
                                <ItemTemplate>
                                    <tr>
                                       <td><%#:Item.ID %></td>
                                        <td><%#:Item.ProductName %></td>
                                        <td><%#:Item.Description %></td>
                                        <td><%#:String.Format("{0:c}",Item.Cost) %></td>
                                        <td><%#:Item.ImgUrl  %></td>
                                        <td>
                                            <a href="EditProducts.aspx?userId=<%#:Item.ID %>">Edytuj</a>
                                        </td>
                                        <td>
                                            <a href="DeleteProducts.aspx?userId=<%#:Item.ID %>">Usuń</a>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:ListView>
                        </tbody>
                        </table>
                    </div>
</asp:Content>
