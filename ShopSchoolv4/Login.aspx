<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ShopSchoolv4.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
    <div class="row">
        <div class="col-12">
            <asp:Label ID="lLogMess" runat="server" CssClass="alert alert-danger" Visible="false"></asp:Label>
        </div>
            <div class="col-md-3"></div>
            <div class="col-md-6">
                <h2>Zaloguj</h2>
                <hr>
            </div>
        </div>
        <div class="row">
            <div class="col-md-3 field-label-responsive">
                <label for="email">E-Mail: </label>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <div class="input-group mb-2 mr-sm-2 mb-sm-0">
                        <div class="input-group-addon" style="width: 2.6rem"><i class="fa fa-at"></i></div>
                        <asp:TextBox ID="txtEmail" placeholder="you@example.com"  CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="col-md-3">
                <div class="form-control-feedback">
                        <span class="text-danger align-middle">
                            <asp:RequiredFieldValidator ID="rfvMail" CssClass="text-danger" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email wymagany"  Visible="False" ></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revMail" CssClass="text-danger" runat="server" ControlToValidate="txtEmail" ErrorMessage="Błędny format email"   ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Visible="False"></asp:RegularExpressionValidator>
                        </span>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-3 field-label-responsive">
                <label for="password">Hasło</label>
            </div>
            <div class="col-md-6">
                <div class="form-group has-danger">
                    <div class="input-group mb-2 mr-sm-2 mb-sm-0">
                        <div class="input-group-addon" style="width: 2.6rem"><i class="fa fa-key"></i></div>
                        <asp:TextBox ID="iPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="col-md-3">
                <div class="form-control-feedback">
                        <span class="text-danger align-middle">
                            <asp:RequiredFieldValidator ID="rfvPassword" CssClass="text-danger" runat="server" ControlToValidate="iPassword" ErrorMessage="Hasło wymagane"></asp:RequiredFieldValidator>
                        </span>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-3"><asp:CheckBox ID="Persist" runat="server" /></div>
            <div class="col-md-6"> Zapamiętaj</div>
        </div>
        <div class="row">
            <div class="col-md-3"></div>
            <div class="col-md-6">
                <asp:Button ID="btnLogin" runat="server" CssClass="btn btn-success" Text="Login" OnClick="btnLogin_Click"></asp:Button>
            </div>
        </div>
        </div>
</asp:Content>
