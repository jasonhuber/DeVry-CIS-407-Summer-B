<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ListAllUsers.aspx.cs" Inherits="ListAllUsers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
    DataKeyNames="username" DataSourceID="logons" AllowPaging="True" 
        AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
            ShowSelectButton="True" />
        <asp:BoundField DataField="username" HeaderText="username" ReadOnly="True" 
            SortExpression="username" />
        <asp:BoundField DataField="password" HeaderText="password" 
            SortExpression="password" />
        <asp:BoundField DataField="firstname" HeaderText="firstname" 
            SortExpression="firstname" />
        <asp:BoundField DataField="lastname" HeaderText="lastname" 

            SortExpression="lastname" />
        <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
    </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
</asp:GridView>
<asp:SqlDataSource ID="logons" runat="server" 
    ConnectionString="<%$ ConnectionStrings:LogonsConnection %>" 
    DeleteCommand="DELETE FROM [usernames] WHERE [username] = @username" 
    InsertCommand="INSERT INTO [usernames] ([username], [password], [firstname], [lastname], [email]) VALUES (@username, @password, @firstname, @lastname, @email)" 
    SelectCommand="SELECT * FROM [usernames]" 
    UpdateCommand="UPDATE [usernames] SET [password] = @password, [firstname] = @firstname, [lastname] = @lastname, [email] = @email WHERE [username] = @username">
    <DeleteParameters>
        <asp:Parameter Name="username" Type="String" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="username" Type="String" />
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
        <asp:Parameter Name="username" Type="String" />
    </UpdateParameters>
</asp:SqlDataSource>
&nbsp;

</asp:Content>

