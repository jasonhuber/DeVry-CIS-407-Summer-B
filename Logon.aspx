<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Logon.aspx.cs" Inherits="Logon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    Username: <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox><br />
Password: <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br />

<asp:Button ID="cmdLogon" runat="server" Text="Logon!" 
    onclick="cmdLogon_Click" />

</asp:Content>

