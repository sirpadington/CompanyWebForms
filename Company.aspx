<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Company.aspx.cs" Inherits="CompanyWebForms.Company1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <ul>
            <asp:Repeater runat="server" ID="companyListRepeater">
               <ItemTemplate>
                   <li><a href='Employee.aspx?Id=<%# Eval("Id") %>'><%# Eval("LastName") %>,<%# Eval("FirstName") %> </a></li>
               </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>
</asp:Content>
