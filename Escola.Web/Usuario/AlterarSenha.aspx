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
        ID="lblSucesso"
        runat="server"
        Text="Senha alterada com sucesso!"
        Visible="false"
        CssClass="badge bg-success" />

    <asp:ValidationSummary
        runat="server"
        CssClass="alert alert-danger" />

    <div>

        <asp:Label
            runat="server"
            Text="Senha atual"
            AssociatedControlID="txtSenhaAtual" />

        <asp:TextBox
            ID="txtSenhaAtual"
            runat="server"
            TextMode="Password" />

        <asp:RequiredFieldValidator
            ID="valSenhaAtualObrigatoria"
            runat="server"
            ControlToValidate="txtSenhaAtual"
            ErrorMessage="O campo &quot;Senha atual&quot; é obrigatório."
            Text="*"
            Display="Dynamic"
            CssClass="text-danger" />

        <asp:CustomValidator
            ID="valSenhaAtualCorreta"
            runat="server"
            ControlToValidate="txtSenhaAtual"
            ErrorMessage="A senha atual informada está incorreta."
            Text="*"
            Display="Dynamic"
            CssClass="text-danger" />

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

        <asp:RequiredFieldValidator
            ID="valNovaSenhaObrigatoria"
            runat="server"
            ControlToValidate="txtNovaSenha"
            ErrorMessage="O campo &quot;Nova senha&quot; é obrigatório."
            Text="*"
            Display="Dynamic"
            CssClass="text-danger" />

        <asp:RegularExpressionValidator
            ID="valNovaSenhaFormato"
            runat="server"
            ControlToValidate="txtNovaSenha"
            ValidationExpression="^.{8,50}$"
            ErrorMessage="A senha precisa ter entre 8 e 50 caracteres."
            Text="*"
            Display="Dynamic"
            CssClass="text-danger" />

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

        <asp:CustomValidator
            ID="valSenhasCoincidem"
            runat="server"
            ControlToValidate="txtNovaSenhaConfirmacao"
            ErrorMessage="As senhas não coincidem."
            Text="*"
            Display="Dynamic"
            CssClass="text-danger" />

    </div>

    <div>

        <asp:Button
            ID="btnEnviarAlteracao"
            runat="server"
            Text="Salvar nova senha" />

        <asp:HyperLink
            runat="server"
            NavigateUrl="~/Usuario/Default.aspx"
            Text="Voltar" />
    
    </div>

</asp:Content>