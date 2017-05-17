<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalhesProduto.aspx.cs" Inherits="WingtipToys.DetalhesProduto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Produto</h1>
    <asp:FormView ID="fvwProduto" runat="server"
        ItemType="WingtipToys.Models.Produto"
        SelectMethod="ObterProduto">
        <EmptyDataTemplate>
            <div class="row">
                Não há produto para exibir.
            </div>
        </EmptyDataTemplate>
        <ItemTemplate>
            <div class="media">
                <div class="media-body">
                    <p>
                        Nome Produto:
                        <h4 class="media-heading"><%#: Item.Nome %></h4>
                    </p>
                    <p>
                        Descrição:
                    <%#: Item.Descricao %>
                    </p>
                    <p>Id: <%#: Item.ProdutoID %></p>
                </div>
                <div class="media-right">
                    <a href="#">
                        <img alt="64x64"
                            class="media-object"
                            data-src="holder.js/64x64"
                            src="Imagens/Produtos/<%#: Item.CaminhoImagem %>"
                            data-holder-rendered="true"
                            style="width: 256px; height: 256px;">
                    </a>
                </div>
            </div>
        </ItemTemplate>
    </asp:FormView>


</asp:Content>
