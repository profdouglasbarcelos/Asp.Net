<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calc1.aspx.cs" Inherits="Aula1805.Calc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <h1>
                <asp:Label ID="lblNome" runat="server" Text="Label"></asp:Label>
            </h1>

            <asp:Label ID="lblValor1" runat="server" Text="Valor 1"></asp:Label>
            <asp:TextBox ID="txtValor1" runat="server"></asp:TextBox>
            <asp:Label ID="lblValor2" runat="server" Text="Valor 2"></asp:Label>
            <asp:TextBox ID="txtValor2" runat="server"></asp:TextBox>
            <asp:Label ID="lblIgual" runat="server" Text="="></asp:Label>
            <asp:TextBox ID="txtResultado" runat="server"></asp:TextBox>
            <asp:Button ID="btnMais" CssClass="btn btn-default" runat="server" Text="+" OnClick="btnMais_Click" />
            <asp:Button ID="btnIgual" CssClass="btn btn-primary" runat="server" Text="=" OnClick="btnIgual_Click" />

        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
