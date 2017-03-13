<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="TaxiPrintCsv.aspx.vb" Inherits="Bayer.TaxiPrintCsv" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
	<table cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td align="left">
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" >
                    <tr>
                        <td align="left">
                            <table cellpadding="2" cellspacing="0" border="0" width="100%">
                                <tr>
                                    <td align="left" class="TdTitle">
                                        会合番号（頭5桁）
                                    </td>
                                    <td>
							            <asp:TextBox ID="JokenKOUENKAI_NO" runat="server" Width="50px" MaxLength="5" 
                                            TabIndex="1"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
                <hr style="width:100%" />
            </td>
        </tr>        
		<tr id="TrNoData" runat="server">
			<td align="left">
				<asp:Label ID="LabelNoData" runat="server" Text="対象となるデータがありません。" CssClass="NoData"></asp:Label>
			</td>
		</tr>
		<tr>
			<td align="left">
				<asp:Button ID="BtnCsv" runat="server" Text="印刷用CSVファイル作成" Width="180px" CssClass="Button" />
			</td>
		</tr>
	</table>
</asp:Content>
