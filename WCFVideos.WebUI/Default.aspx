<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WCFVideos.WebUI._Default" %>

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
            <td align="center">
                <fieldset style="width: 65%; padding: 10px">
                    <legend class="Titulo">Crédito</legend>
                    <br />
                    <p style="text-align: left">
                        Total de Recurso Disponível: <b>
                            <asp:Label ID="RecursoDisponivel" runat="server" /></b>
                    </p>
                    <br />
                    <table width="100%">
                        <tr>
                            <td align="left">
                                <asp:Button ID="NovaProposta" runat="server" Text="Criar Nova Proposta" 
                                    onclick="NovaProposta_Click" />
                            </td>
                            <td align="right">
                                <asp:Button ID="VisualizarPropostas" runat="server" Text="Visualizar Propostas" 
                                    onclick="VisualizarPropostas_Click" />
                            </td>
                        </tr>
                    </table>
                </fieldset>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
