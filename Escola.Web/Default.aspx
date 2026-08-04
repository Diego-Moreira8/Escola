<%@ 
    Page 
    Language="vb" 
    AutoEventWireup="false" 
    CodeBehind="Default.aspx.vb" 
    Inherits="Escola.Web._Default" 
    MasterPageFile="~/Site.Master"
%>

<asp:Content
    runat="server"
    ContentPlaceHolderID="mainContent"
>
    <h1>Lista de Alunos</h1>

    <asp:GridView ID="gdvAlunos" runat="server"></asp:GridView>
</asp:Content>

