<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ShopSchoolv4.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Kontakt</h3>
    <address>
        <br />
        ul Przykład 45, Kraków<br />
        <abbr title="Phone">Telefon:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Biuro obsługi klienta:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>reaklama:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>

    <div class="container">
        <div class="row">
            <div class="col-md-3 field-label-responsive">
                <label for="email">Imię: </label>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <div class="input-group mb-2 mr-sm-2 mb-sm-0">
                        <div class="input-group-addon" style="width: 2.6rem"><i class="fa fa-at"></i></div>
                        <asp:TextBox ID="txtName" placeholder="Twoje Imię"  CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-3 field-label-responsive">
                <label for="email">Email: </label>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <div class="input-group mb-2 mr-sm-2 mb-sm-0">
                        <div class="input-group-addon" style="width: 2.6rem"><i class="fa fa-at"></i></div>
                        <asp:TextBox ID="txtEmail" placeholder="Twój E-mail"  CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>
         <div class="row">
            <div class="col-md-3 field-label-responsive">
                <label for="email">Wiadomość: </label>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <div class="input-group mb-2 mr-sm-2 mb-sm-0">
                        <div class="input-group-addon" style="width: 2.6rem"><i class="fa fa-at"></i></div>
                        <asp:TextBox placeholder="Wiadomość"  CssClass="form-control" runat="server" ID="txtDescription" TextMode="MultiLine"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-3"></div>
            <div class="col-md-6">
                <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-success" Text="Wyślij" OnClick="btnAdd_Click" ></asp:Button>
            </div>
        </div>
    </div>

</asp:Content>
