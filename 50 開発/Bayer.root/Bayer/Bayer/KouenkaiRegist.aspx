<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="KouenkaiRegist.aspx.vb" Inherits="Bayer.KouenkaiRegist" MaintainScrollPositionOnPostback="true" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table border="0" cellpadding="4" cellspacing="0" width="1100px">
		<tr>
			<td nowrap="nowrap" align="left">
				<table style="border-collapse: collapse;" cellspacing="0" cellpadding="2" border="1" bordercolor="#4f5b61" width="1100px">
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							uïÔ
						</td>
						<td nowrap="nowrap" align="left" style="width: 100px;">
							<asp:Label ID="KOUENKAI_NO" runat="server" Text="12345678901234"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 90px;">
							Xe[^X
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="5">
							<asp:DropDownList ID="ANS_STATUS_TEHAI" runat="server" Width="200px"></asp:DropDownList>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							uï¼
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="4">
							<asp:Label ID="KOUENKAI_NAME" runat="server" Text="12345678901234567890123456789012345678901234567890123456789012345678901234567890"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							`Pbgó¼
							<br />
							(10¶)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" style="width: 95px;" colspan="2">
							<asp:Label ID="TAXI_PRT_NAME" runat="server" Text="1234567890"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							^Cg
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="7">
							<asp:Label ID="KOUENKAI_TITLE" runat="server" Text="12345678901234567890123456789012345678901234567890123456789012345678901234567890"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 90px;">
							uïJÃú
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="7">
							<asp:Label ID="FROM_DATE" runat="server" Text="yyyy/MM/dd"></asp:Label>
							&nbsp;&nbsp;`&nbsp;&nbsp;
							<asp:Label ID="TO_DATE" runat="server" Text="yyyy/MM/dd"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							uïïê¼
						</td>
						<td nowrap="nowrap" align="left" colspan="7">
							<asp:Label ID="KAIJO_NAME" runat="server" Text="1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							»i¼
						</td>
						<td nowrap="nowrap" align="left" colspan="7">
							<asp:Label ID="SEIHIN_NAME" runat="server" Text="1234567890123456789012345678901234567890"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							Internal Order(ÛÅ)
						</td>
						<td nowrap="nowrap" align="left">
							<asp:Label ID="INTERNAL_ORDER_T" runat="server" Text="123456789012"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							Internal Order(ñÛÅ)
						</td>
						<td nowrap="nowrap" align="left">
							<asp:Label ID="INTERNAL_ORDER_TF" runat="server" Text="123456789012"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							AJEgR[h(ÛÅ)
						</td>
						<td nowrap="nowrap" align="left">
							<asp:Label ID="ACCOUNT_CD_T" runat="server" Text="1234567"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							AJEgR[h(ñÛÅ)
						</td>
						<td nowrap="nowrap" align="left">
							<asp:Label ID="ACCOUNT_CD_TF" runat="server" Text="1234567"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							zetia Code
						</td>
						<td nowrap="nowrap" align="left">
							<asp:Label ID="ZETIA_CD" runat="server" Text="1234567890"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							QÁl
						</td>
						<td nowrap="nowrap" align="left" colspan="5">
							<asp:Label ID="SANKA_YOTEI_CNT" runat="server" Text="12345"></asp:Label>
						</td>
					</tr>
				</table>
			</td>
		</tr>
		<tr>
			<td nowrap="nowrap" align="left">
				<table style="border-collapse: collapse; margin-top: 10px;" cellspacing="0" cellpadding="2" border="1" bordercolor="#4f5b61" width="1100px">
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" colspan="8">
							¡ uï éæSÒ

						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							BU
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="5">
							<asp:Label ID="BU" runat="server" Text="1234567890123456789012345678901234567890"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							GA
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="KIKAKU_TANTO_AREA" runat="server" Text="1234567890123456789012345678901234567890"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							cÆ
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="3">
							<asp:Label ID="KIKAKU_TANTO_EIGYOSHO" runat="server" Text="1234567890123456789012345678901234567890"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							¼
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
                            <asp:TextBox ID="KIKAKU_TANTO_NAME" runat="server" MaxLength="150" ReadOnly="true" 
                                TextMode="MultiLine" Height="35px" Width="315px" TabIndex="250" 
                                BorderStyle="None">123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890</asp:TextBox>                            
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							¼([})
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="5">
                            <asp:TextBox ID="KIKAKU_TANTO_ROMA" runat="server" MaxLength="150" ReadOnly="true" 
                                TextMode="MultiLine" Height="35px" Width="315px" TabIndex="250" 
                                BorderStyle="None">123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890</asp:TextBox>                            
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							ItBXÌdbÔ
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="KIKAKU_TANTO_TEL" runat="server" Text="12345678901234567890"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							gÑdb
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="KIKAKU_TANTO_KEITAI" runat="server" Text="1234-5678-9012"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 105px;">
							[AhX
						</td>
						<td align="left" class="TdItem" colspan="5">
							<asp:Label ID="KIKAKU_TANTO_EMAIL" runat="server" Text="12345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 105px;">
							gÑÌ[AhX
						</td>
						<td align="left" class="TdItem" colspan="5">
							<asp:Label ID="KIKAKU_TANTO_EMAIL_KEITAI" runat="server" Text="12345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678"></asp:Label>
						</td>
					</tr>
			</table>
			</td>
		</tr>
		<tr>
			<td nowrap="nowrap" align="left">
				<table style="border-collapse: collapse; margin-top: 4px;" cellspacing="0" cellpadding="2" border="1" bordercolor="#4f5b61" width="1100px">
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" colspan="8">
							¡ Tv
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							\Zz(ñÛÅ)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" style="width: 200px;">
							<asp:Label ID="YOSAN_TF" runat="server" Text="1,234,56,789"></asp:Label>
							~

						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							\Zz(ÛÅ)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="5">
							<asp:Label ID="YOSAN_T" runat="server" Text="1,234,56,789"></asp:Label>
							~
						</td>
					</tr>
				</table>
			</td>
		</tr>
		<tr>
			<td nowrap="nowrap" align="left">
				<div class="FontSize1" style="height: 10px;"></div>
		        <table cellspacing="0" cellpadding="0" border="0" style="width:1100px;">
			        <tr style="height: 36px; width:100%">
				        <td align="left" style="width:30%">
				            <asp:Button ID="BtnRireki" runat="server" Width="150px" Text="ð\¦" CssClass="Button" />
				        </td>
				        <td align="right" style="width:70%">
				            <asp:Button ID="BtnToroku" runat="server" Width="150px" Text="o^" 
                                CssClass="Button" />
				            <asp:Button ID="BtnNozomi" runat="server" Width="150px" Text="NOZOMIÖ" 
                                CssClass="Button" />
					        <asp:Button ID="BtnCancel" runat="server" Width="150px" Text="LZ" CssClass="ButtonCancel" />
				        </td>
			        </tr>
		        </table>
			</td>
		</tr>
	</table>
</asp:Content>
