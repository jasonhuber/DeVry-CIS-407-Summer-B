<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Upload.aspx.cs" Inherits="Upload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <input id="txtFile" type="file" runat="server" name="txtFile" /><br />
<br />
			<asp:button id="cmdUpload" runat="server" Text="Upload" OnClick="cmdUpload_Click1"></asp:button>

</asp:Content>

