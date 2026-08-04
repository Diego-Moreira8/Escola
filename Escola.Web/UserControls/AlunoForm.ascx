<%@ Control 
    Language="vb" 
    AutoEventWireup="false" 
    CodeBehind="AlunoForm.ascx.vb" 
    Inherits="Escola.Web.AlunoForm" 
%>

<div>
    <asp:Label 
        ID="lblNome" 
        AssociatedControlID="txtNome" 
        runat="server" 
        Text="Nome completo"
    ></asp:Label>

    <asp:TextBox 
        ID="txtNome" 
        runat="server"
    ></asp:TextBox>
</div>
        
<div>
    <asp:Label 
        ID="lblDataNascimento" 
        AssociatedControlID="txtDataNascimento" 
        runat="server" 
        Text="Data de nascimento"
    ></asp:Label>

    <asp:TextBox 
        ID="txtDataNascimento" 
        TextMode="Date" 
        runat="server"
    ></asp:TextBox>
</div>