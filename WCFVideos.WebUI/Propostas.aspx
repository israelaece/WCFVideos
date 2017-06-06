<%@ Page Language="C#" AutoEventWireup="true" Async="true" CodeBehind="Propostas.aspx.cs" Inherits="WCFVideos.WebUI.Propostas" %>

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
                <table width="70%">
                    <tr>
                        <td>
                            <asp:GridView ID="RelacaoDePropostas" runat="server" Width="100%" 
                                BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" 
                                CellPadding="2" ForeColor="Black" GridLines="None">
                                <FooterStyle BackColor="Tan" />
                                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
                                    HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
