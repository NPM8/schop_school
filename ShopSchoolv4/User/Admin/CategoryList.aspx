<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CategoryList.aspx.cs" Inherits="ShopSchoolv4.CategoryList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
                <div class="d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom">
                    <h1 class="h2">Kategorie</h1>
                    <div class="btn-toolbar mb-2 mb-md-0">
                <a class="btn btn-sm btn-outline-secondary mr-2" href="/AddCategory.aspx">Dodaj</a>
            </div>
                </div>
                <div class="table-responsive">
                    <table class="table table-striped table-sm">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Nazwa</th>
                                <th>Edytuj</th>
                                <th>Usuń</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:ListView ID="userList" runat="server" DataKeyNames="ID" ItemType="ShopSchoolv4.Models.Category" SelectMethod="GetCategories">
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
                                        <td><%#:Item.Name %></td>
                                        <td>
                                            <a href="EditCategory.aspx?id=<%#:Item.ID %>">Edytuj</a>
                                        </td>
                                        <td>
                                            <a href="DeleteCategory.aspx?id=<%#:Item.ID %>">Usuń</a>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:ListView>
                        </tbody>
                        </table>
                    </div>
</asp:Content>
