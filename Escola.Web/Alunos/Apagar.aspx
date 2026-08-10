<%@ Page 
    Language="vb" 
    AutoEventWireup="false" 
    CodeBehind="Apagar.aspx.vb" 
    Inherits="Escola.Web.Apagar" 
    MasterPageFile="~/Site.Master" %>

<asp:Content 
    runat="server" 
    ContentPlaceHolderID="mainContent" >

    <h1>Apagar Aluno</h1>

    <p>
        Tem certeza que deseja apagar o aluno 
        <asp:Label ID="lblDescricao" runat="server" />?
    </p>

    <asp:Button 
        ID="btnConfirmarRemocao" 
        runat="server" 
        Text="Apagar" />

    <asp:HyperLink
        ID="lnkCancelar"
        runat="server"
        Text="Cancelar" />

</asp:Content>
