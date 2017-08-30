<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proejto.WEB.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Lincoln</title>
    <!--Css-->
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <!--Js-->
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body class="container">
    <form id="form1" runat="server">
        <div class="col-md-4 col-md-offset-4">
            <div class="panel panel-primary">
                <div class=" panel-heading">
                    <h4>Autenticação do Usuario</h4>
                </div>
                <div class="panel-body">
                    Para acessar o sistema, informe os dados abaixo!
                    <hr />

                    <label>Login de Acesso: </label>
                    <asp:TextBox runat="server" ID="txtLogin" CssClass="form-control" />
                    <asp:Label runat="server" ID="lblErroLogin" CssClass="label label-danger" />
                    <br />

                    <label>Senha de Acesso: </label>
                    <asp:TextBox runat="server" ID="txtSenha" CssClass="form-control"
                        TextMode="Password"/>
                    <asp:Label runat="server" ID="lblErroSenha" CssClass=" label label-danger" />
                    <br />
                </div>
                <div class="panel-footer">
                    <asp:Button runat="server" ID="btnAcesso" CssClass="btn btn-primary" 
                        Text="Acessar Sistema"/>
                    <hr />
                    Não possui conta?
                    <a href="#" data-target="#janela" data-toggle="modal">
                        Cadastre-se aqui
                    </a>
                </div>
            </div>
        
        
        <div id="janela" class="modal fade">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header bg-primary">
                        <h3>Criar Conta de Usuário</h3>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col-md-12">
                                <label>Nome do Usuário:</label>
                                <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" />
                            </div>                        
                            <br />
                            <div class="col-md-12">                               
                                <label>Login de Acesso: </label>
                                <asp:TextBox runat="server" ID="txtLoginAcesso" 
                                    CssClass="form-control" />
                            </div>
                            <br />
                            <div class="col-md-6">                              
                                <label>Senha de Acesso: </label>
                                <asp:TextBox runat="server" ID="txtSenhaAcesso"
                                    CssClass=" form-control" TextModel="password"/>                             
                            </div>
                            <br />
                            <div class="col-md-6">                             
                                <label>Confirme a sua Senha</label>
                                <asp:TextBox runat="server" ID="txtSenhaConfirm"
                                    CssClass="form-control" TextModel="password"/>                                
                            </div>
                            <div class="col-md-12">
                                <label>Insira uma foto</label>
                                <asp:FileUpload ID="txtFoto" runat="server"
                                    CssClass="form-control" />
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="BtnCadastro" runat="server" Text="Criar Conta de Usuário" CssClass="btn btn-success" />
                    </div>
                </div>
            </div>
        </div>
        </div>
    </form>
</body>
</html>
