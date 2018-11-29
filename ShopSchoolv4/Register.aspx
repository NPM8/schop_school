<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ShopSchoolv4.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="form-horizontal">
    <div class="row">
        <div class="col-12">
            <asp:Label ID="lRegMess" runat="server" CssClass="alert alert-danger" Visible="false"></asp:Label>
        </div>
            <div class="col-md-3"></div>
            <div class="col-md-6">
                <h2>Zarejestruj się</h2>
                <hr>
            </div>
        </div>
        <div class="row">
            <div class="col-md-3 field-label-responsive">
                <label for="name">Imie</label>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <div class="input-group mb-2 mr-sm-2 mb-sm-0">
                        <div class="input-group-addon" style="width: 2.6rem"><i class="fa fa-user"></i></div>
                        <asp:TextBox ID="txtName" CssClass="form-control" placeholder="John Doe" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="col-md-3">
                <div class="form-control-feedback">
                        <span class="text-danger align-middle">
                            <asp:RequiredFieldValidator ID="rfvName" CssClass="text-danger" ControlToValidate="txtName" runat="server" ErrorMessage="<i class='fa fa-close'> Imię jest konieczne</i>"></asp:RequiredFieldValidator>
                        </span>
                </div>
            </div>
        </div>
    <div class="row">
            <div class="col-md-3 field-label-responsive">
                <label for="name">Nazwisko</label>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <div class="input-group mb-2 mr-sm-2 mb-sm-0">
                        <div class="input-group-addon" style="width: 2.6rem"><i class="fa fa-user"></i></div>
                        <asp:TextBox ID="txtSurN" CssClass="form-control"  runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="col-md-3">
                <div class="form-control-feedback">
                        <span class="text-danger align-middle">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="text-danger" ControlToValidate="txtSurN" runat="server" ErrorMessage="<i class='fa fa-close'> Name is nececery</i>"></asp:RequiredFieldValidator>
                        </span>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-3 field-label-responsive">
                <label for="email">Adres E-Mail</label>
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
                            <asp:CompareValidator runat="server" ControlToCompare="iPassword" ControlToValidate="iPass2"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
                        </span>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-3 field-label-responsive">
                <label for="password">Potwierdź hasło</label>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <div class="input-group mb-2 mr-sm-2 mb-sm-0">
                        <div class="input-group-addon" style="width: 2.6rem">
                            <i class="fa fa-repeat"></i>
                        </div>
                         <asp:TextBox ID="iPass2" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-3"></div>
            <div class="col-md-6">
                <asp:Button ID="btnRegister" runat="server" CssClass="btn btn-success" Text="Register" OnClick="btnRegister_Click"></asp:Button>
            </div>
        </div>
        </div>
</asp:Content>
