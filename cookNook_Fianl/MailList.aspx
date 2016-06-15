<%@ Page Title="Mail List" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MailList.aspx.cs" Inherits="cookNook_Fianl.MailList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
                <div class="form-horizontal">
                    <h4>Mail List</h4>
                    <p>This page allows you to sign up for our mail list. </p>
                    <p class="MsoNormal">
                        <span>Signing up will allow you to receive periodic information on new products and sales announcements.</span></p>
                    <hr />
                    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtEmail" CssClass="col-md-2 control-label">Email</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" TextMode="Email" AutoPostBack="True" CausesValidation="True" ValidationGroup="mailList" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtEmail"
                                CssClass="text-danger" ErrorMessage="The email field is required." ValidationGroup="mailList" />
                        &nbsp;<br />
                            <asp:CustomValidator ID="valValidEmail" runat="server" BorderColor="Red" ControlToValidate="txtEmail" ForeColor="#990000" OnServerValidate="valValidEmail_ServerValidate" SetFocusOnError="True" ValidationGroup="mailList"></asp:CustomValidator>
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtFirstName" CssClass="col-md-2 control-label">First Name</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtFirstName" CssClass="form-control" AutoPostBack="True" CausesValidation="True" ValidationGroup="mailList" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtFirstName" CssClass="text-danger" ErrorMessage="First name is required." ValidationGroup="mailList" />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtLastName" CssClass="col-md-2 control-label">Last Name</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtLastName" CssClass="form-control" AutoPostBack="True" ValidationGroup="mailList" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtLastName" CssClass="text-danger" ErrorMessage="Last name is required." ValidationGroup="mailList" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" ValidationGroup="mailList" />
                        &nbsp;<asp:Label ID="lblSuccess" runat="server"></asp:Label>
                        </div>
                    </div>
                </div>
        </section>
    </div>
 </div>
</asp:Content>
