<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Proposta.aspx.cs" Inherits="WCFVideos.WebUI.Proposta" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sistema de Gestão de Crédito</title>
    <style>
        body
        {
            font-size: 12px;
            font-family: Arial;
        }
        .Titulo
        {
            font-size: 12px;
            font-family: Arial;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <br />
    <br />
    <br />
    <table width="100%">
        <tr>
            <td align="center" colspan="2">
                <table width="65%" cellpadding="0" cellspacing="0">
                    <tr>
                        <td align="left">
                            Data:
                            <asp:Label ID="Data" runat="server" />
                        </td>
                        <td align="right">
                            Número:
                            <asp:Label ID="Numero" runat="server" Text="00000" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <fieldset style="width: 65%; padding: 10px">
                    <legend class="Titulo">Cliente</legend>
                    <br />
                    <table width="100%">
                        <tr>
                            <td align="left" style="width: 28%">
                                Nome:
                            </td>
                            <td align="left">
                                <asp:TextBox runat="server" ID="Nome" Columns="50" />
                            </td>
                        </tr>
                        <tr>
                            <td align="left" style="width: 28%">
                                Empresa:
                            </td>
                            <td align="left">
                                <asp:TextBox runat="server" ID="Empresa" Columns="50" />
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                Idade:
                            </td>
                            <td align="left">
                                <asp:TextBox runat="server" ID="Idade" />
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                Salário:
                            </td>
                            <td align="left">
                                <asp:TextBox runat="server" ID="Salario" />
                            </td>
                        </tr>
                    </table>
                </fieldset>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <fieldset style="width: 65%; padding: 10px">
                    <legend class="Titulo">Empréstimo</legend>
                    <br />
                    <table width="100%">
                        <tr>
                            <td align="left" style="width: 28%">
                                Valor:
                            </td>
                            <td align="left">
                                <asp:TextBox runat="server" ID="Valor" />
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                Taxa de Juros:
                            </td>
                            <td align="left">
                                <asp:TextBox runat="server" ID="TaxaDeJuros" />
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                Quantidade de Parcelas:
                            </td>
                            <td align="left">
                                <asp:DropDownList runat="server" ID="QuantidadeDeParcelas">
                                    <asp:ListItem Text="12" Value="12" />
                                    <asp:ListItem Text="24" Value="24" />
                                    <asp:ListItem Text="36" Value="36" />
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                </fieldset>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <table width="65%" cellpadding="0" cellspacing="0">
                    <tr>
                        <td align="left">
                            <asp:Button ID="Cancelar" runat="server" Text="Cancelar" 
                                onclick="Cancelar_Click" />
                        </td>
                        <td align="right">
                            <asp:Button ID="Analisar" runat="server" Text="Analisar Proposta" 
                                onclick="Analisar_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
