<%@ Page 
    Language="vb" 
    AutoEventWireup="false" 
    CodeBehind="Registrar.aspx.vb" 
    Inherits="Escola.Web.Registrar" 
    MasterPageFile="~/Site.Master"%>

<asp:Content
    runat="server"
    ContentPlaceholderID="mainContent" >

    <h1>Registrar</h1>

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

        <asp:Label 
            ID="lblSenha"
            runat="server"
            Text="Senha" 
            AssociatedControlID="txtSenha" />

        <asp:TextBox 
            ID="txtSenha"
            runat="server"
            TextMode="Password" />

        <asp:RequiredFieldValidator
            ID="valSenhaObrigatoria"
            runat="server"
            ControlToValidate="txtSenha"
            ErrorMessage="O campo Senha é obrigatório."
            Text="*"
            Display="Static"
            CssClass="text-danger" />

        <asp:RegularExpressionValidator
            ID="valSenhaFormato"
            runat="server"
            ControlToValidate="txtSenha"
            ValidationExpression="^.{8,50}$"
            ErrorMessage="A senha precisa ter entre 8 e 50 caracteres."
            Text="*"
            Display="Dynamic"
            CssClass="text-danger" />

    </div>

    <div>

        <asp:Label 
            ID="lblConfirmarSenha"
            runat="server"
            Text="Confirmar Senha" 
            AssociatedControlID="txtConfirmarSenha" />

        <asp:TextBox 
            ID="txtConfirmarSenha"
            runat="server"
            TextMode="Password" />

        <asp:RequiredFieldValidator
            ID="valConfirmarSenhaObrigatorio"
            runat="server"
            ControlToValidate="txtConfirmarSenha"
            ErrorMessage="O campo Confirmar Senha é obrigatório."
            Text="*"
            Display="Static"
            CssClass="text-danger" />

        <asp:CustomValidator
            ID="valConfirmarSenhaCoincide"
            runat="server"
            ControlToValidate="txtConfirmarSenha"
            ErrorMessage="As senhas são diferentes."
            Text="*"
            Display="Dynamic"
            CssClass="text-danger" />

    </div>

    <div>

        <asp:Button
            ID="btnCriarConta"
            runat="server"
            Text="Criar conta"
            CausesValidation="true" />

    </div>

    <p>
        Já tem uma conta? 
        <asp:HyperLink 
            runat="server" 
            NavigateUrl="~/Autenticacao/Entrar.aspx" 
            Text="Entrar" />
    </p>

</asp:Content>