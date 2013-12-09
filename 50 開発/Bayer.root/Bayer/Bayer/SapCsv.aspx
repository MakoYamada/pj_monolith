<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="SapCsv.aspx.vb" Inherits="Bayer.SapCsv" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td align="left">
                <table cellpadding="2" cellspacing="0" border="0">
                    <tr>
                        <td>
                            承認年月
                        </td>
                        <td>
                            <asp:TextBox ID="JokenSHOUNIN_Y" runat="server" Width="50px" MaxLength="4"></asp:TextBox>年
							<asp:TextBox ID="JokenSHOUNIN_M" runat="server" Width="30px" MaxLength="2"></asp:TextBox>月
                        </td>
                    </tr>
                    <tr>
                        <td>
                            請求書番号
                        </td>
                        <td>
                            <asp:TextBox ID="SEIKYUSHO_NO" runat="server" Width="180px" MaxLength="20"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;&nbsp;&nbsp;
                            <asp:Button ID="BtnSapCSV" runat="server" Text="SAP用CSV出力" Width="150px" CssClass="Button" />
                            &nbsp;&nbsp;&nbsp;
                            <asp:Button ID="BtnTopCSV" runat="server" Text="TopTour用CSV出力" Width="150px" CssClass="Button" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
