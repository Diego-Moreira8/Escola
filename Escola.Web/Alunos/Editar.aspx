<%@ Page 
    Language="vb" 
    AutoEventWireup="false" 
    CodeBehind="Editar.aspx.vb" 
    Inherits="Escola.Web.Editar" 
    MasterPageFile="~/Site.Master" %>

<%@ Register 
    Src="~/UserControls/AlunoForm.ascx" 
    TagPrefix="uc" 
    TagName="AlunoForm" %>

<asp:Content 
    runat="server" 
    ContentPlaceHolderID="mainContent" >

    <h1>Editar Aluno</h1>

    <uc:AlunoForm 
        Id="ucAlunoFormEditar" 
        RunAt="server" />

    <asp:Button 
        ID="btnSalvarAlteracoes" 
        runat="server" 
        Text="Salvar alterações" />

    <asp:HyperLink
        ID="lnkCancelar"
        runat="server"
        Text="Cancelar" />

</asp:Content>
