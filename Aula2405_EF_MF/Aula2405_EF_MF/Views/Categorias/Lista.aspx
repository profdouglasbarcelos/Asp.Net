<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lista.aspx.cs" Inherits="Aula2405_EF_MF.Views.Categorias.Lista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Categorias Ativas</h1>
    <asp:GridView ID="gvCategorias" runat="server"></asp:GridView>

    <h1>Categorias Excluidas</h1>
    <asp:GridView ID="gvCategoriasExcluidas" runat="server"></asp:GridView>

</asp:Content>
