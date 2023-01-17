<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="DemowithMysql.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>

    <asp:TextBox runat="server" ID="txtName" />  

    <asp:Button Text="Save" runat="server" ID="btnsave" OnClick="btnsave_Click"/>
    <asp:Label Text="" ID="lbl" runat="server" />

    <asp:GridView runat="server" ID="grdTest" >   </asp:GridView>

</asp:Content>


