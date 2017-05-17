<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebForms1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <table>
           <tr>
               <td>
                   <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
               </td>
               <td>
                   <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
               </td>
               <td>
                   <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
               </td>
           </tr>
           <tr>
               <td colspan="3">
                   <asp:Label ID="lblConvidado" runat="server" Text=""></asp:Label>
               </td>
           </tr>
       </table>
    </div>
    </form>
</body>
</html>
