<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="securedpage.aspx.cs" Inherits="securedpage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<asp:Label ID="lblUsername" runat="server"></asp:Label>

<asp:Button runat="server" ID="btnLogout" onclick="btnLogout_Click" Text="Logout" />

</asp:Content>

