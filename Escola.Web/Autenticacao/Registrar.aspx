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

    <asp:Panel 
        ID="pnlErro"
        runat="server"
        Visible="false">

        <asp:Label
            ID="lblErro"
            runat="server" />

    </asp:Panel>


    <div>

        <asp:Label 
            ID="lblNomeDeUsuario"
            runat="server"
            Text="Nome de usuário" 
            AssociatedControlID="txtNomeDeUsuario" />

        <asp:TextBox
            ID="txtNomeDeUsuario"
            runat="server" />

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

    </div>

    <div>

        <asp:Button
            ID="btnCriarConta"
            runat="server"
            Text="Criar conta" />

    </div>

    <p>
        Já tem uma conta? 
        <asp:HyperLink 
            runat="server" 
            NavigateUrl="~/Autenticacao/Entrar.aspx" 
            Text="Entrar" />
    </p>

</asp:Content>