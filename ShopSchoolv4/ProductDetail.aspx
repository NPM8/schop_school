<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="ShopSchoolv4.ProductDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-10">
                <asp:Label ID="Name" runat="server"></asp:Label>
            </div>
        </div>
        <div class="row justify-content-center">
            <div class="col-3">
                <asp:Image ID="ProdImg" runat="server" CssClass="img-in-product"/>
            </div>
            <div class="col-7">
                <div class="d-flex flex-column ml-2">
                    <asp:Label ID="Desc" runat="server"/>
                    <asp:Label ID="Price" runat="server"></asp:Label>
                    <div class="d-flex justify-content-center">
                        <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-primary" OnClick="LinkButton1_Click" >Add to card</asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
