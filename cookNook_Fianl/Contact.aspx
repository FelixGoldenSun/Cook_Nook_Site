<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="cookNook_Fianl.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
                <div class="form-horizontal">
                    <h4>Contact Us!</h4>
                    <p class="MsoNormal">
                        <span>You can use this area to contact us! Simply enter your email, a subject, and a message and you are good to go! </span>
                    </p>
                    <hr />
                    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtFrom" CssClass="col-md-2 control-label">From</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtFrom" CssClass="form-control" TextMode="Email" Width="479px" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtFrom"
                                CssClass="text-danger" ErrorMessage="The email field is required." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtSubject" CssClass="col-md-2 control-label">Subject</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtSubject" CssClass="form-control" Width="479px" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtSubject" CssClass="text-danger" ErrorMessage="The subject field is required." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtBody" CssClass="col-md-2 control-label">Content</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtBody" TextMode="MultiLine" CssClass="form-control" Height="146px" Width="497px" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtBody" CssClass="text-danger" ErrorMessage="The content field is required." />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button ID="btnSemd" runat="server" Text="Send" OnClick="btnSemd_Click" />
                        &nbsp;<asp:Label ID="lblSendStatus" runat="server"></asp:Label>
                        </div>
                    </div>
                </div>
                <p>
                    &nbsp;</p>
                <p>
                    <%-- Enable this once you have account confirmation enabled for password reset functionality
                    <asp:HyperLink runat="server" ID="ForgotPasswordHyperLink" ViewStateMode="Disabled">Forgot your password?</asp:HyperLink>
                    --%>
                </p>
            </section>
        </div>

    </div>
</asp:Content>
