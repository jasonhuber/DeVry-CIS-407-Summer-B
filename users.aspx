<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="users.aspx.cs" Inherits="users" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:repeater id=rptUsers runat="server">
          <HeaderTemplate>
            <table>
            <tr>
                <td>picture</td>
                <td>username</td>
                <td>email</td>
            </tr>
          </HeaderTemplate>
          <ItemTemplate>
            <tr>
                <td><img src="uploadedfiles/<%#  DataBinder.Eval(Container.DataItem,"photo" ) %>" width=100 height=100 /></td>
                <td><%#  DataBinder.Eval(Container.DataItem,"userid" ) %></td>
                <td><%#  DataBinder.Eval(Container.DataItem,"email" ) %></td>
            </tr>
          </ItemTemplate>
          <FooterTemplate>
            </table>
          </FooterTemplate>
    </asp:repeater>
</asp:Content>

