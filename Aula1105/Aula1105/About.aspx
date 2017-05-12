<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Aula1105.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Sobre</h2>
    <h3>Descrição da sua aplicação.</h3>
    <p>Use this area to provide additional information.</p>

    <br />

    <asp:Calendar ID="calDataInicio" runat="server"></asp:Calendar>
    <br />
    <br />

    <asp:TextBox ID="txtData" runat="server"></asp:TextBox>
    <asp:Button ID="btnSalvar" CssClass="btn btn-primary" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />


</asp:Content>
