<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPublishers.aspx.cs" Inherits="CSCI3321_ASPNET_FinalProject.AddPublishers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Add an Author</h1>
    <div class="row">
        <div class="col-md-3">
            First Name
            <asp:TextBox id="txtFirstName" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-9">
            Last Name
            <asp:TextBox id="txtLastName" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-3">
            Gender
            <asp:TextBox ID="txtGender" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-9">
            Birthday
            <asp:TextBox id="txtBirthday" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-mid-3">
            <asp:Button id="btnSubmit" runat="server" text="Add Author" OnClick="btnSubmit_Click"/>
        </div>
    </div>
</asp:Content>
