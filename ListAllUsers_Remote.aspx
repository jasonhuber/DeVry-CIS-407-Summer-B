<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ListAllUsers_Remote.aspx.cs" Inherits="ListAllUsers_Remote" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

put it here.<asp:GridView ID="GridView1" runat="server" 
    AutoGenerateColumns="False" DataKeyNames="userid" 
    DataSourceID="devryremoteconn">
    <Columns>
        <asp:BoundField DataField="userid" HeaderText="userid" ReadOnly="True" 
            SortExpression="userid" />
        <asp:BoundField DataField="password" HeaderText="password" 
            SortExpression="password" />
        <asp:BoundField DataField="firstname" HeaderText="firstname" 
            SortExpression="firstname" />
        <asp:BoundField DataField="lastname" HeaderText="lastname" 
            SortExpression="lastname" />
        <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="devryremoteconn" runat="server" 
    ConnectionString="<%$ ConnectionStrings:DeVryRemotedb %>" 
    DeleteCommand="DELETE FROM [Huber_Logon] WHERE [userid] = @userid" 
    InsertCommand="INSERT INTO [Huber_Logon] ([userid], [password], [firstname], [lastname], [email]) VALUES (@userid, @password, @firstname, @lastname, @email)" 
    SelectCommand="SELECT * FROM [Huber_Logon]" 
    UpdateCommand="UPDATE [Huber_Logon] SET [password] = @password, [firstname] = @firstname, [lastname] = @lastname, [email] = @email WHERE [userid] = @userid">
    <DeleteParameters>
        <asp:Parameter Name="userid" Type="String" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="userid" Type="String" />
        <asp:Parameter Name="password" Type="String" />
        <asp:Parameter Name="firstname" Type="String" />
        <asp:Parameter Name="lastname" Type="String" />
        <asp:Parameter Name="email" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="password" Type="String" />
        <asp:Parameter Name="firstname" Type="String" />
        <asp:Parameter Name="lastname" Type="String" />
        <asp:Parameter Name="email" Type="String" />
        <asp:Parameter Name="userid" Type="String" />
    </UpdateParameters>
</asp:SqlDataSource>
&nbsp;
</asp:Content>

