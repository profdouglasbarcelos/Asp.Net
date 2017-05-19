<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calc2.aspx.cs" Inherits="Aula1805.Calc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Resultados</h1>
    <asp:TextBox ID="txtV1A" runat="server"></asp:TextBox>
    +                
    <asp:TextBox ID="txtV2A" runat="server"></asp:TextBox>
    =                
    <asp:TextBox ID="txtR1A" runat="server"></asp:TextBox>

    <br />

    <asp:TextBox ID="txtV1S" runat="server"></asp:TextBox>
    -
    <asp:TextBox ID="txtV2S" runat="server"></asp:TextBox>
    =                
    <asp:TextBox ID="txtR1S" runat="server"></asp:TextBox>

    <br />

    <asp:TextBox ID="txtV1M" runat="server"></asp:TextBox>
    *                
    <asp:TextBox ID="txtV2M" runat="server"></asp:TextBox>
    =                
    <asp:TextBox ID="txtR1M" runat="server"></asp:TextBox>

    <br />

    <asp:TextBox ID="txtV1D" runat="server"></asp:TextBox>
    :                
    <asp:TextBox ID="txtV2D" runat="server"></asp:TextBox>
    =                
    <asp:TextBox ID="txtR1D" runat="server"></asp:TextBox>

</asp:Content>
