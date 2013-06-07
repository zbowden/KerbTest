<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="KerbTest._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
   
    </asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">



    <asp:Label ID="Label4" runat="server" Text="IIS Authentication: "/><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SQLConnectionString %>" SelectCommand="SELECT SYSTEM_USER"></asp:SqlDataSource>

     <br />
    <br />

     <asp:Label ID="Label5" runat="server" Text="SQL Server Authentication: "/><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:PGConnection %>" SelectCommand="SELECT current_user as Column1" ProviderName="System.Data.Odbc"></asp:SqlDataSource>
     <br />
    <br />
     <asp:Label ID="Label6" runat="server" Text="Greenplum Authentication: "/><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>





</asp:Content>
