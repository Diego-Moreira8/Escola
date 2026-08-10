<%@ Page 
    Language="vb" 
    AutoEventWireup="false" 
    CodeBehind="Default.aspx.vb" 
    Inherits="Escola.Web._Default1" 
    MasterPageFile="~/Site.Master" %>

<asp:Content 
    ContentPlaceHolderID="mainContent" 
    runat="server" >

    <h1>Alunos</h1>

    <asp:HyperLink
        ID="hlinkCadastro"
        runat="server"
        NavigateUrl="~/Alunos/Cadastro.aspx"
        Text="Cadastrar aluno" />

    <asp:GridView 
        ID="gdvAlunos" 
        runat="server"
        AutoGenerateColumns="false" >

        <Columns>

            <asp:BoundField
                DataField="Matricula"
                HeaderText="Matrícula" />

            <asp:BoundField
                DataField="Nome"
                HeaderText="Nome" />

            <asp:TemplateField HeaderText="Ações">

                <ItemTemplate>

                    <asp:HyperLink
                        ID="lnkDetalhes"
                        runat="server"
                        Text="Detalhes"
                        NavigateUrl='<%# "~/Alunos/Detalhes.aspx?matricula=" & Eval("Matricula") %>' />

                </ItemTemplate>

            </asp:TemplateField>

        </Columns>

    </asp:GridView>

</asp:Content>