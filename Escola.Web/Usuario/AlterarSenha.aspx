<%@ Page 
    Language="vb" 
    AutoEventWireup="false" 
    CodeBehind="AlterarSenha.aspx.vb" 
    Inherits="Escola.Web.AlterarSenha" 
    MasterPageFile="~/Site.Master" %>

<asp:Content
    runat="server"
    ContentPlaceHolderID="mainContent" >

    <h1>Alterar Senha</h1>

    <asp:Label
        ID="lblResultado"
        runat="server" />

    <div>

        <asp:Label
            runat="server"
            Text="Senha atual"
            AssociatedControlID="txtSenhaAtual" />

        <asp:TextBox
            ID="txtSenhaAtual"
            runat="server"
            TextMode="Password" />

    </div>

    <div>

        <asp:Label
            runat="server"
            Text="Nova senha"
            AssociatedControlID="txtNovaSenha" />

        <asp:TextBox
            ID="txtNovaSenha"
            runat="server"
            TextMode="Password" />

    </div>

    <div>

        <asp:Label
            runat="server"
            Text="Repita a nova senha"
            AssociatedControlID="txtNovaSenhaConfirmacao" />

        <asp:TextBox
            ID="txtNovaSenhaConfirmacao"
            runat="server"
            TextMode="Password" />

    </div>

    <div>

        <asp:Button
            ID="btnEnviarAlteracao"
            runat="server"
            Text="Salvar nova senha" />

        <asp:HyperLink
            runat="server"
            NavigateUrl="~/Usuario/Default.aspx"
            Text="Cancelar" />
    
    </div>

</asp:Content>