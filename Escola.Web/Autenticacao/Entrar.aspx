<%@ Page 
    Language="vb" 
    AutoEventWireup="false" 
    CodeBehind="Entrar.aspx.vb" 
    Inherits="Escola.Web.Entrar"
    MasterPageFile="~/Site.Master" %>

<asp:Content 
    runat="server" 
    ContentPlaceHolderID="mainContent" >

    <h1>Entrar</h1>

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
            runat="server"
            autofocus="true" />

        <asp:RequiredFieldValidator
            ID="valNomeDeUsuarioObrigatorio"
            runat="server"
            ControlToValidate="txtNomeDeUsuario"
            ErrorMessage="Informe um nome de usuário."
            Text="*"
            Display="Dynamic"
            CssClass="text-danger" />

        <asp:CustomValidator
            ID="valNomeDeUsuarioExiste"
            runat="server"
            ControlToValidate="txtNomeDeUsuario"
            ErrorMessage="O nome de usuário informado não existe."
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
            ErrorMessage="Informe uma senha."
            Text="*"
            Display="Dynamic"
            CssClass="text-danger" />

        <asp:CustomValidator
            ID="valSenhaCorreta"
            runat="server"
            ControlToValidate="txtSenha"
            ErrorMessage="Senha incorreta."
            Text="*"
            Display="Dynamic"
            CssClass="text-danger" />

    </div>

    <div>

        <asp:Button
            ID="btnEntrar"
            runat="server"
            Text="Entrar" />

    </div>

    <p>
        Não tem uma conta? 
        <asp:HyperLink 
            runat="server" 
            NavigateUrl="~/Autenticacao/Registrar.aspx"
            Text="Registrar" />
    </p>

</asp:Content>
