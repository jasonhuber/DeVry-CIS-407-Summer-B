<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <asp:Label ID="Label1" runat="server" Text="Label">Firstname</asp:Label>
    <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Label">lastname</asp:Label>
    <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Label">Email</asp:Label>
    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
    runat="server" ControlToValidate="txtemail" 
    ErrorMessage="Email is not in a valid format." ForeColor="Red" 
    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Label">userid</asp:Label>
    <asp:TextBox ID="txtuserid" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Label">password</asp:Label>
    <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label6" runat="server" Text="Label">repeat password</asp:Label>
    <asp:TextBox ID="txtpassword2" runat="server"></asp:TextBox>
    <asp:CompareValidator ID="CompareValidator1" runat="server" 
        ControlToCompare="txtpassword" ControlToValidate="txtpassword2" 
        ErrorMessage="passwords do not match!" ForeColor="Red" 
    EnableClientScript="False"></asp:CompareValidator>
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />


</asp:Content>

