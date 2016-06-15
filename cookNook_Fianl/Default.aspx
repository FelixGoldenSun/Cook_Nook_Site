<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="cookNook_Fianl._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div class="row">
            <div class="col-md-2 col-md-offset-4">
                <img src="Images/cookNookLogo.png" alt="Cook Nook Logo"/>
            </div>
        </div>
    
        
        <p class="lead" style="text-align:center">Welcome to Cook Nook! We are a company that sells cooking equipment and other kitchen items. We invite you to peruse our selection of fine kitchen stuff. Seriously, they're the best. </p>

    </div>

    <div class="row">
        <div class="col-md-12">
            <div class="col-md-3">
                <img src="Images/FrenchPress.png" alt="French Press"/>
          
            </div>
            <div class="col-md-9">
                <h2>French press</h2>
                <p>
                    This is a French Press, perfect for making coffee! This is no ordinary french press, it is made for aircraft grade aluminum and can survive water up to 500 feet deep. It can also serve as a paperweight. You should buy one!
                </p>
                <p>
                    <b>Only $29.99!</b>
                </p>
            </div>
           
        </div>

    </div>
</asp:Content>
