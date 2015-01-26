<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="CompanyWebForms.Employee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <ul>
            <li> <asp:Label runat="server" ID="firstName"></asp:Label> </li>
            <li> <asp:Label runat="server" ID="lastName"></asp:Label> </li>
            <li> <asp:Label runat="server" ID="birthDate"></asp:Label> </li>
        </ul>
    </div>
</asp:Content>
