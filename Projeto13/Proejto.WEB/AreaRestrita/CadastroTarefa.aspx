<%@ Page Title="" Language="C#" MasterPageFile="~/AreaRestrita/Templates/Layout.Master" AutoEventWireup="true" CodeBehind="CadastroTarefa.aspx.cs" Inherits="Proejto.WEB.AreaRestrita.CadastroTarefa" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



<h4>Cadastro de Tarefas</h4>
<hr />


<div class="row">
    <div class="col-md-6">

        <label>Nome da tarefa: </label>
        <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" />       
        <asp:RequiredFieldValidator 
            ID="requiredNomeTarefa"
            runat="server"
            ControlToValidate="txtNome"
            ErrorMessage="Por favor, infome o nome da terefa"
            ForeColor="Red"
            Display="Dynamic"
            ValidationGroup="formularioCadastro"
        />
        <br />

        <label>Data e Hora: </label>
        <asp:TextBox ID="txtDataHora" runat="server" CssClass="form-control" type="datetime-local" />
        <asp:RequiredFieldValidator
        ID="requiredDataHora"
        runat="server"
        ControlToValidate="txtDataHora"
        ErrorMessage="Por favor, informe a data e hora da tarefa"
        ForeColor="Red"
        Display="Dynamic"
        ValidationGroup="formularioCadastro"
        />   
        <br />

        <label>Descrição da tarefa: </label>
        <asp:TextBox ID="txtDescricao" runat="server" CssClass="form-control" TextMode="MultiLine" />
        <asp:RequiredFieldValidator
        ID="requiredDescricao"
        runat="server"
        ControlToValidate="txtDescricao"
        ErrorMessage="Por favor, informe a descrição da tarefa"
        ForeColor="Red"
        Display="Dynamic"
        ValidationGroup="formularioCadastro"
        />
        
        <br />
        <br />

        <asp:Button ID="BtnCadastro" runat="server" 
            Text="Cadastrar Tarefa" CssClass="btn btn-success" 
            OnClick="BtnCadastro_Click"/>
        <br />
        <br />
        <asp:Label ID="lblMessangem" runat="server" />
    </div>
</div>

























</asp:Content>

