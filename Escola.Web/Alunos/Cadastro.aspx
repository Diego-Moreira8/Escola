<%@ Page 
    Language="vb" 
    AutoEventWireup="false" 
    CodeBehind="Cadastro.aspx.vb" 
    Inherits="Escola.Web.Cadastro" 
    MasterPageFile="~/Site.Master"
%>

<%@ Register 
    Src="~/UserControls/AlunoForm.ascx" 
    TagPrefix="uc" 
    TagName="AlunoForm" 
%>

<asp:Content
    runat="server"
    ContentPlaceHolderID="mainContent"
>
    <h1>Cadastrar Novo Aluno</h1>

    <uc:AlunoForm Id="ucAlunoFormNovo" RunAt="server"/>

    <div>
        <asp:Button 
            ID="btnSalvarNovoAluno" 
            runat="server" 
            Text="Salvar" 
        />
    </div>
</asp:Content>