<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebForms1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Descrição da sua aplicação web.</h3>
    <p>Use this area to provide additional information.</p>
    
<asp:HyperLink ID="link1" runat="server" NavigateUrl="~/Default.aspx">Quer saber mais? Link para Google</asp:HyperLink>

    <asp:Calendar ID="calDataInicio" runat="server"></asp:Calendar>

    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
</asp:Content>
