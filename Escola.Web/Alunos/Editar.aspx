<%@ Page 
    Language="vb" 
    AutoEventWireup="false" 
    CodeBehind="Editar.aspx.vb" 
    Inherits="Escola.Web.Editar" 
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
    <h1>Editar Aluno</h1>

    <div>
        <asp:Label 
            ID="lblAluno" 
            AssociatedControlID="ddlAlunos" 
            runat="server" 
            Text="Aluno para editar"
        ></asp:Label>
    
        <asp:DropDownList
            ID="ddlAlunos"
            runat="server" 
            AutoPostBack="True"
        ></asp:DropDownList>
    </div>


    <asp:Panel 
        ID="pnlEdicao" 
        runat="server"
    >
        <uc:AlunoForm Id="ucAlunoFormEditar" RunAt="server"/>

        <div>
            <asp:Button 
                ID="btnSalvarAlteracoes" 
                runat="server" 
                Text="Salvar alterações" 
            />
        </div>

        <div>
            <asp:Button 
                ID="btnApagarAluno" 
                runat="server" 
                Text="Apagar aluno" 
            />
        </div>
    </asp:Panel>
</asp:Content>
