<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Criar.aspx.cs" Inherits="Aula2405_EF_MF.Views.Categorias.Criar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Criar Categoria</h1>
    <div class="form-group">
        <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
        <asp:TextBox ID="txtNome" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="lblDescricao" runat="server" Text="Descrição"></asp:Label>
        <asp:TextBox ID="txtDescricao" CssClass="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
    </div>
    <asp:Button ID="btnSalvar" CssClass="btn btn-primary" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />

</asp:Content>
