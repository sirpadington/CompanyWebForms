<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CompanyWebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <ul>
            <asp:Repeater runat="server" ID="mainListRepeater">
               <ItemTemplate>
                   <li><a href='Company.aspx?Id=<%# Eval("Id") %>'><%# Eval("Name") %></a></li>
               </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>
</asp:Content>
