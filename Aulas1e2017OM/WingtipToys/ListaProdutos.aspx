<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaProdutos.aspx.cs" Inherits="WingtipToys.ListaProdutos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView ID="lvwProdutos" runat="server"
        ItemType="WingtipToys.Models.Produto"
        SelectMethod="ObterProdutos">
        <EmptyDataTemplate>
            <div class="row">
                Sem itens para exibir
            </div>
        </EmptyDataTemplate>
        <ItemTemplate>
            <div class="media">
                <div class="media-left">
                    <a href="DetalhesProduto.aspx?idProduto=<%#: Item.ProdutoID %>">
                        <img class="miniaturaImagemProduto media-object"
                            src="/Imagens/Produtos/<%#: Item.CaminhoImagem %>" 
                            alt="...">
                    </a>
                </div>
                <div class="media-body">
                    <h4 class="media-heading"><%#: Item.Nome %></h4>
                    <%#: Item.Descricao %>
                </div>
            </div>
        </ItemTemplate>

    </asp:ListView>
</asp:Content>
