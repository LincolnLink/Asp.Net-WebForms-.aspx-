<%@ Page Title="" Language="C#" MasterPageFile="~/AreaRestrita/Templates/Layout.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Proejto.WEB.AreaRestrita.Home" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
    <h4>Seja bem vindo ao Projeto.</h4>Tarefas desta semana:  
    <hr />

    Período de <strong><asp:Label ID="txtDataIni" runat="server" /></strong>
    Até<strong> <asp:Label ID="txtDataFim" runat="server" /> </strong>

    <asp:Label ID="lblMensagem" runat="server" />
    <br />
    <br />

    <asp:ListView ID="listTarefas" runat="server">
        <ItemTemplate>

            <div class="col-md-4">
                <div class="panel panel-primary">
                    <div class="panel-body">

                        <strong><%# Eval("NomeTarefa") %></strong>
                        <br />
                        <br />

                        Data e Hora: <br />
                        <%# Eval("DataHora", "{0:dd/MM/yyyy HH:mm}") %>
                        <br />
                        <br />

                        Descrição: <br />
                        <%# Eval("Descricao")%>

                    </div>
                </div>
            </div>

        </ItemTemplate>
    </asp:ListView>

</asp:Content>
