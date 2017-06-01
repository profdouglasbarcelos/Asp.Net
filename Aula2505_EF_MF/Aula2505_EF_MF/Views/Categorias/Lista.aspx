<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lista.aspx.cs" Inherits="Aula2505_EF_MF.Views.Categorias.Lista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Categorias</h1>
    <asp:GridView ID="gvCategorias" runat="server" OnRowCommand="gvCategorias_RowCommand">
        <Columns>
            <asp:ButtonField CommandName="Excluir" Text="Excluir" />
            <asp:ButtonField CommandName="Editar" Text="Editar" />
        </Columns>

    </asp:GridView>
</asp:Content>
