<%@ Page 
    Language="vb" 
    AutoEventWireup="false" 
    CodeBehind="Default.aspx.vb" 
    Inherits="Escola.Web._Default3" 
    MasterPageFile="~/Site.Master" %>

<asp:Content
    runat="server"
    ContentPlaceHolderID="mainContent" >

    <h1>Minha Conta</h1>

    <asp:Label 
        ID="lblSucesso"
        runat="server"
        Text="Dados salvos!"
        Visible="false"
        CssClass="badge bg-success" />

    <asp:ValidationSummary
        runat="server"
        CssClass="alert alert-danger" />

    <div>

        <asp:Label 
            ID="lblNomeDeUsuario"
            runat="server"
            Text="Nome de usuário" 
            AssociatedControlID="txtNomeDeUsuario" />

        <asp:TextBox
            ID="txtNomeDeUsuario"
            runat="server" />

        <asp:RequiredFieldValidator
            ID="valNomeDeUsuarioObrigatorio"
            runat="server"
            ControlToValidate="txtNomeDeUsuario"
            ErrorMessage="Informe um nome de usuário."
            Text="*"
            Display="Static"
            CssClass="text-danger" />

        <asp:RegularExpressionValidator
            ID="valNomeDeUsuarioFormato"
            runat="server"
            ControlToValidate="txtNomeDeUsuario"
            ValidationExpression="^[a-z.]{3,50}$"
            ErrorMessage="O nome de usuário deve conter apenas letras e pontos e ter entre 3 e 50 caracteres."
            Text="*"
            Display="Dynamic"
            CssClass="text-danger" />

        <asp:CustomValidator
            ID="valNomeDeUsuarioExistente"
            runat="server"
            ControlToValidate="txtNomeDeUsuario"
            ErrorMessage="Nome de usuário já existe."
            Text="*"
            Display="Dynamic"
            CssClass="text-danger" />

    </div>

    <div>

        <asp:Button 
            ID="btnSalvarAlteracoes"
            runat="server"
            Text="Salvar Alterações" />

    </div>

    <asp:HyperLink 
        runat="server" 
        NavigateUrl="~/Usuario/AlterarSenha.aspx" 
        Text="Alterar senha" />

</asp:Content>