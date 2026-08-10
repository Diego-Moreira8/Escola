<%@ Page 
    Language="vb" 
    AutoEventWireup="false" 
    CodeBehind="Detalhes.aspx.vb" 
    Inherits="Escola.Web.Detalhes" 
    MasterPageFile="~/Site.Master" %>

<asp:Content
    runat="server"
    ContentPlaceHolderID="mainContent" >

    <h1>Detalhes do Aluno</h1>

    <asp:Label ID="lblErro" runat="server" />

    <asp:Panel ID="pnlDetalhes" runat="server">

        <p>
            <strong>Nome: </strong>
            <asp:Label 
                ID="lblNome" 
                runat="server" />
        </p>

        <p>
            <strong>Data de Nascimento: </strong>
            <asp:Label 
                ID="lblDtNascimento" 
                runat="server" />
        </p>

        <asp:HyperLink
            ID="lnkEditar"
            runat="server"
            Text="Editar" />

        <asp:HyperLink
            ID="lnkApagar"
            runat="server"
            Text="Apagar" />

    </asp:Panel>

</asp:Content>
