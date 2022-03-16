<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Verastar_Tech_Assessment._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <p class="lead">Customer Order Table</p>
    </div>

    <div class="row">
        
        <asp:Table ID="customerTable" runat="server">
        </asp:Table>
        
    </div>

</asp:Content>
