<%@ Page Title="" Language="C#" MasterPageFile="~/AreaRestrita/Templates/Layout.Master" AutoEventWireup="true" CodeBehind="ConsultaTarefa.aspx.cs" Inherits="Proejto.WEB.AreaRestrita.ConsultaTarefa" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!--Habilitar o uso de componentes Ajax na página..-->
    <asp:ScriptManager ID="scriptManager" runat="server">

    </asp:ScriptManager>

    <h4>Consultar Tarefa</h4>
    <hr />

    <!--Painel para evento AJAX-->
    <asp:UpdatePanel ID="painelConsulta" runat="server">
        <ContentTemplate>
            
    <div class="row">
        <div class="col-md-4">

            <label>Data de Término: </label>
            <asp:TextBox ID="txtDataIni" runat="server"
                CssClass="form-control" type="date" /> 
        
            <label>Data de Término: </label>
            <asp:TextBox ID="txtDataFim" runat="server"
                CssClass="form-control" type="date" />

            <asp:Button ID="BtnConsulta" runat="server"
                CssClass="btn btn-primary" Text="Pesquisar Tarefas"
                OnClick="BtnConsulta_Click"/>
            <br />
            <br />
            <asp:Label ID="lblMensagem" runat="server" />

        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <asp:GridView ID="gridTarefas" runat="server"
                CssClass="table table-hover" AutoGenerateColumns="false" GridLines="None">

                <EmptyDataTemplate>
                    Nenhuma tarefa foi encontrada
                </EmptyDataTemplate>

                <Columns>

                    <asp:TemplateField HeaderText="Código">
                        <ItemTemplate>
                            <%# Eval("IdTarefa") %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Nome da Tarefa">
                        <ItemTemplate>
                            <%# Eval("NomeTarefa") %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Data e Hora">
                        <ItemTemplate>
                            <%# Eval("DataHora", "{0:dd/MM/yyy HH:mm}")%>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <ItemTemplate>
                            <%# Eval("Descricao")%>
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>

            </asp:GridView>
        </div>
    </div>
            
        </ContentTemplate>
    </asp:UpdatePanel>



    <asp:UpdateProgress ID="painelCarregamento" runat="server"
        AssociatedUpdatePanelID="painelConsulta">
        <ProgressTemplate>

            <div class="alert alert-info">

            </div>

        </ProgressTemplate>
    </asp:UpdateProgress>


</asp:Content>