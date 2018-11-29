<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddCategory.aspx.cs" Inherits="ShopSchoolv4.AddCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
    <div class="row">
        <div class="col-12">
            <asp:Label ID="lLogMess" runat="server" CssClass="alert alert-danger" Visible="false"></asp:Label>
        </div>
            <div class="col-md-3"></div>
            <div class="col-md-6">
                <h2>Dodaj Kategorie</h2>
                <hr>
            </div>
        </div>
        <div class="row">
            <div class="col-md-3 field-label-responsive">
                <label for="email">Nazwa: </label>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <div class="input-group mb-2 mr-sm-2 mb-sm-0">
                        <div class="input-group-addon" style="width: 2.6rem"><i class="fa fa-at"></i></div>
                        <asp:TextBox ID="txtName" placeholder="Twoja nazwa"  CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-3"></div>
            <div class="col-md-6">
                <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-success" Text="Dodaj" OnClick="btnAdd_Click"></asp:Button>
            </div>
        </div>
        </div>
</asp:Content>
