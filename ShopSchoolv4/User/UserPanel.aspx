<%@ Page Title="List użytkowników" Language="C#" MasterPageFile="UserMain.master" AutoEventWireup="true" CodeBehind="UserPanel.aspx.cs" Inherits="ShopSchoolv4.UserPanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
                <div class="d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom">
                    <h1 class="h2">Użytkownicy</h1>
                </div>
                <div class="table-responsive">
                    <table class="table table-striped table-sm">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Imię</th>
                                <th>Nazwisko</th>
                                <th>E-mail</th>
                                <th>Admin</th>
                                <th>Edytuj</th>
                                <th>Usuń</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:ListView ID="userList" runat="server" DataKeyNames="ID" ItemType="ShopSchoolv4.Models.User" SelectMethod="GetUsers">
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
                                        <td><%#:Item.Surname %></td>
                                        <td><%#:Item.Login %></td>
                                        <td><%#:(Item.isAdmin == "1" ? "Tak" : "Nie")  %></td>
                                        <td>
                                            <a href="EditUser.aspx?userId=<%#:Item.ID %>">Edytuj</a>
                                        </td>
                                        <td>
                                            <a href="DeleteUser.aspx?userId=<%#:Item.ID %>">Usuń</a>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:ListView>
                        </tbody>
                        </table>
                   </div>

</asp:Content>
