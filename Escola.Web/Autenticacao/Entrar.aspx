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
            runat="server"
            autofocus="true" />

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
