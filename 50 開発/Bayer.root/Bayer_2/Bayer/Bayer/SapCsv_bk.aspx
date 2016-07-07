<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="SapCsv_bk.aspx.vb" Inherits="Bayer.SapCsv_bk" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div style="padding: 10px; margin-bottom: 10px; border: 1px solid #cccccc; width: 650px">
        <table cellspacing="0" cellpadding="2" border="0">
            <p style=" text-align:left; font-weight:bold;">SAP用CSV</p>
            <tr>
                <td align="left">
                    <table cellpadding="2" cellspacing="0" border="0">
                        <tr>
                            <td style="width:70px;">
                                承認年月
                            </td>
                            <td>
                                <asp:TextBox ID="JokenSHOUNIN_Y" runat="server" Width="50px" MaxLength="4"></asp:TextBox>年
							    <asp:TextBox ID="JokenSHOUNIN_M" runat="server" Width="30px" MaxLength="2"></asp:TextBox>月
                            </td>
                        </tr>
                        <tr>
                            <td style="width:70px;">
                                請求書番号
                            </td>
                            <td>
                                <asp:TextBox ID="SEIKYUSHO_NO" runat="server" Width="180px" MaxLength="20"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;&nbsp;&nbsp;
                                <asp:Button ID="BtnSapCSV" runat="server" Text="SAP用CSV出力" Width="155px" CssClass="Button" />
                                &nbsp;&nbsp;&nbsp;
                                <asp:Button ID="BtnTopCSV" runat="server" Text="TopTour用CSV出力" Width="155px" CssClass="Button" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    <br />
    <div style="padding: 10px; margin-bottom: 10px; border: 1px solid #cccccc; width: 650px">
        <p style=" text-align:left; font-weight:bold;">SAPエビデンス用CSV</p>
        <table cellspacing="0" cellpadding="2" border="0">
            <tr>
                <td align="left">
                    <table cellpadding="2" cellspacing="0" border="0">
                        <tr>
                            <td style="width:70px;">
                                承認年月
                            </td>
                            <td style="width:184px;">
                                <asp:TextBox ID="JokenSHOUNIN_Y_Evi" runat="server" Width="50px" MaxLength="4"></asp:TextBox>年
							    <asp:TextBox ID="JokenSHOUNIN_M_Evi" runat="server" Width="30px" MaxLength="2"></asp:TextBox>月
                            </td>
                            <td >
                                &nbsp;&nbsp;&nbsp;
                                <asp:Button ID="BtnEvidenceCSV" runat="server" Text="エビデンス用CSV出力" Width="155px" 
                                    CssClass="Button" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
