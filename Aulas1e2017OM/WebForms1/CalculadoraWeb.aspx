<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CalculadoraWeb.aspx.cs" Inherits="WebForms1.CalculadoraWeb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Calculadora de 1's</h1>
        <div class="row">
            <div class="col-md-12">
                <asp:TextBox ID="txtDisplay" runat="server" Enabled="false"></asp:TextBox>
            </div>
        </div>
        <div class="container">
            <div class="row">
                <div class="col-md-4">
                    <asp:Button ID="btn1" runat="server" Text="1" OnClick="btn1_Click" />
                </div>
                <div class="col-md-4">
                    <asp:Button ID="btnMais" runat="server" Text="+" OnClick="btnMais_Click" />
                </div>
                <div class="col-md-4">
                    <asp:Button ID="btnIgual" runat="server" Text="=" OnClick="btnIgual_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
