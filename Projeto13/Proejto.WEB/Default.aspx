<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proejto.WEB.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Projeto Login e Tarefas</title>
    <!--Css-->
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <!--Js-->
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body class="container">
    <form id="form1" runat="server">
        <div class="col-md-5 col-md-offset-3">
            <div class="panel panel-primary">
                <div class=" panel-heading">
                    <h4>Autenticação do Usuario</h4>
                </div>
                <div class="panel-body">
                    Para acessar o sistema, informe os dados abaixo!
                    <hr />

                    <label>Login de Acesso: </label>
                    <asp:TextBox runat="server" ID="txtLoginAcesso" CssClass="form-control" />
                    <asp:Label runat="server" ID="lblErroLogin" CssClass="label label-danger" />
                    <br />

                    <label>Senha de Acesso: </label>
                    <asp:TextBox runat="server" ID="txtSenhaAcesso" CssClass="form-control" TextMode="Password"/>
                    <asp:Label runat="server" ID="lblErroSenha" CssClass=" label label-danger" />
                    <br />
                </div>
                <div class="panel-footer">
                    <asp:Button runat="server" ID="BtnAcesso" CssClass="btn btn-primary" 
                        Text="Acessar Sistema" OnClick="BtnAcesso_Click"/>
                    <hr />
                    Não possui conta?
                    <a href="#" data-target="#janela" data-toggle="modal">
                        Cadastre-se aqui
                    </a>
                    <br />
                    <asp:label runat="server" id="lblMessagem" />
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
                                <asp:RequiredFieldValidator 
                                    ID="RequiredNome" 
                                    runat="server"
                                    ControlToValidate="txtNome"
                                    ErrorMessage="Por favor, informe o nome do usuário"
                                    ForeColor="Red"
                                    Display="Dynamic"
                                    ValidationGroup="formularioCadastro" 
                                />
                                <asp:RegularExpressionValidator 
                                    Id="regexNome"
                                    runat="server"
                                    ControlToValidate="txtNome"
                                    ErrorMessage="Somente letras, de 6 a 50 caracteres."
                                    ForeColor="Red"
                                    Display="Dynamic"
                                    ValidationGroup="formularioCadastro"
                                    ValidationExpression="^[A-Za-zÀ-Üà-ü\s]{6,50}$"
                                />                                
                            </div>                        
                            <br />

                            <div class="col-md-12">                               
                                <label>Login de Acesso: </label>
                                <asp:TextBox runat="server" ID="txtLoginCadastro" 
                                    CssClass="form-control" />
                                <asp:RequiredFieldValidator
                                    ID="requiredLoginCadastro"
                                    runat="server"
                                    ControlToValidate="txtLoginCadastro"
                                    ErrorMessage="Por favor, informe o login so usuário"
                                    ForeColor="Red"
                                    Display="Dynamic"
                                    validationGroup="formularioCadastro"
                                />
                                <asp:RegularExpressionValidator
                                    ID="regexLogin"
                                    runat="server"
                                    ControlToValidate="txtLoginCadastro"
                                    ErrorMessage="Somente letras minúsculas ou numéros,
                                    de 6 a 20 caracteres."
                                    ForeColor="Red"
                                    Display="Dynamic"
                                    ValidationGroup="formularioCadastro"
                                    ValidationExpression="^[a-z0-9]{6,20}$" 
                                />
                            </div>
                            <br />

                            <div class="col-md-6">                              
                                <label>Senha de Acesso: </label>
                                <asp:TextBox runat="server" ID="txtSenhaCadastro"
                                    CssClass=" form-control" TextMode="Password"/>
                                <asp:RequiredFieldValidator 
                                    ID="requiredSenhaCadastro"
                                    runat="server"
                                    ControlToValidate="txtSenhaCadastro"                                    
                                    ErrorMessage="Por favor, informe a senha do usuário"
                                    ForeColor="Red"
                                    Display="Dynamic"
                                    ValidationGroup="formularioCadastro"
                                />
                                <asp:RegularExpressionValidator
                                    ID="regexSenha"
                                    runat="server"                               
                                    ErrorMessage="Senha inválida. Sua senha deve
                                conter no minimo 5 e no máximo 25 digitos, sendo no minimo uma letra minuscula,
                                uma letra maiuscula, um número e um caracter especial (#*.@)."
                                    Display="Dynamic"
                                    ControlToValidate="txtSenhaCadastro"
                                    ValidationExpression="^.*(?=.{5,25})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$"
                                    ForeColor="Red"
                                    ValidationGroup="formularioCadastro"
                                 />
                            </div>
                            <br />

                            <div class="col-md-6">                             
                                <label>Confirme a sua Senha</label>
                                <asp:TextBox runat="server" ID="txtSenhaConfirm"
                                    CssClass="form-control" TextMode="Password"/>
                                <asp:RequiredFieldValidator
                                    ID="requiredSenhaConfirm"
                                    runat="server"
                                    ControlToValidate="txtSenhaConfirm"
                                    ErrorMessage="Por favor, confirme a senha do usuário"
                                    ForeColor="Red"
                                    Display="Dynamic"
                                    ValidationGroup="formularioCadastro"
                                />
                                <asp:CompareValidator
                                    ID="compareSenha"
                                    runat="server"
                                    ControlToValidate="txtSenhaConfirm"
                                    ControlToCompare="txtSenhaCadastro"
                                    ErrorMessage="Senhas não conferem"
                                     ForeColor="Red"
                                    Display="Dynamic"
                                    ValidationGroup="formularioCadastro" 
                                />
                            </div>
                            <br />

                            <div class="col-md-12">
                                <label>Insira uma foto</label>
                                <asp:FileUpload ID="txtFoto" runat="server"
                                    CssClass="form-control" />
                                <asp:RequiredFieldValidator
                                    ID="requiredFoto"
                                    runat="server"
                                    ControlToValidate="txtFoto"
                                    ErrorMessage="Por favor, envie a foto do usuário"
                                    ForeColor="Red"
                                    Display="Dynamic"
                                    ValidationGroup="formularioCadastro"
                                />
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="BtnCadastro" runat="server"
                            Text="Criar Conta de Usuário" 
                            CssClass="btn btn-success"
                            OnClick="BtnCadastro_Click"
                            ValidationGroup="formularioCadastro" />                   
                    </div>
                </div>
            </div>
        </div>
        </div>
    </form>
</body>
</html>
