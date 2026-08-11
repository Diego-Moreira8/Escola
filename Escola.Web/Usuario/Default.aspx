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
        ID="lblResultado"
        runat="server" />

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

    <asp:Button 
        ID="btnSalvarAlteracoes"
        runat="server"
        Text="Salvar Alterações" />

    <asp:HyperLink 
        runat="server" 
        NavigateUrl="~/Usuario/AlterarSenha.aspx" 
        Text="Alterar senha" />

</asp:Content>