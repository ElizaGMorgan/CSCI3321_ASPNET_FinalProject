<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyBooks.aspx.cs" Inherits="CSCI3321_ASPNET_FinalProject.MyBooks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>My Library</h1>
    <asp:Label ID="lblBookTitle" runat="server"></asp:Label>

    <br />
    <asp:Table ID="tblBookCollection" runat="server" CssClass="table table-stripe">
        <asp:TableHeaderRow>
            <asp:TableCell>Book Title</asp:TableCell>
            <asp:TableCell>Author's First Name</asp:TableCell>
            <asp:TableCell>Author's Last Name</asp:TableCell>
            <asp:TableCell>Price</asp:TableCell>
            <asp:TableCell>Publish Date</asp:TableCell>
            <asp:TableCell>Publishing Company</asp:TableCell>
            <asp:TableCell>Genre</asp:TableCell>
        </asp:TableHeaderRow>
    </asp:Table>
</asp:Content>
