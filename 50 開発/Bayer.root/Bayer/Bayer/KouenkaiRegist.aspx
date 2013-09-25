<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="KouenkaiRegist.aspx.vb" Inherits="Bayer.KouenkaiRegist" MaintainScrollPositionOnPostback="true" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table border="0" cellpadding="4" cellspacing="0" width="1100px">
		<tr>
			<td nowrap="nowrap" align="left">
				<table style="border-collapse: collapse;" cellspacing="0" cellpadding="2" border="1" bordercolor="#4f5b61" width="1100px">
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							講演会番号
						</td>
						<td nowrap="nowrap" align="left" style="width: 100px;">
							<asp:Label ID="KOUENKAI_NO" runat="server" Text="12345678901234"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 90px;">
							ステータス
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="5">
							<asp:DropDownList ID="ANS_STATUS_TEHAI" runat="server" Width="200px"></asp:DropDownList>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							講演会名
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="4">
							<asp:Label ID="KOUENKAI_NAME" runat="server" Text="12345678901234567890123456789012345678901234567890123456789012345678901234567890"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							チケット印字名
							<br />
							(10文字)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" style="width: 95px;" colspan="2">
							<asp:Label ID="TAXI_PRT_NAME" runat="server" Text="1234567890"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							タイトル
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="7">
							<asp:Label ID="KOUENKAI_TITLE" runat="server" Text="12345678901234567890123456789012345678901234567890123456789012345678901234567890"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 90px;">
							講演会開催日
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="7">
							<asp:Label ID="FROM_DATE" runat="server" Text="yyyy/MM/dd"></asp:Label>
							&nbsp;&nbsp;～&nbsp;&nbsp;
							<asp:Label ID="TO_DATE" runat="server" Text="yyyy/MM/dd"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							講演会会場名
						</td>
						<td nowrap="nowrap" align="left" colspan="7">
							<asp:Label ID="KAIJO_NAME" runat="server" Text="1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							製品名
						</td>
						<td nowrap="nowrap" align="left" colspan="7">
							<asp:Label ID="SEIHIN_NAME" runat="server" Text="1234567890123456789012345678901234567890"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							Internal Order(課税)
						</td>
						<td nowrap="nowrap" align="left">
							<asp:Label ID="INTERNAL_ORDER_T" runat="server" Text="123456789012"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							Internal Order(非課税)
						</td>
						<td nowrap="nowrap" align="left">
							<asp:Label ID="INTERNAL_ORDER_TF" runat="server" Text="123456789012"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							アカウントコード(課税)
						</td>
						<td nowrap="nowrap" align="left">
							<asp:Label ID="ACCOUNT_CD_T" runat="server" Text="1234567"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							アカウントコード(非課税)
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
							参加人数
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
							■ 講演会 企画担当者

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
							エリア
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="KIKAKU_TANTO_AREA" runat="server" Text="1234567890123456789012345678901234567890"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							営業所
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="3">
							<asp:Label ID="KIKAKU_TANTO_EIGYOSHO" runat="server" Text="1234567890123456789012345678901234567890"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							氏名
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
                            <asp:TextBox ID="KIKAKU_TANTO_NAME" runat="server" MaxLength="150" ReadOnly="true" 
                                TextMode="MultiLine" Height="35px" Width="315px" TabIndex="250" 
                                BorderStyle="None">123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890</asp:TextBox>                            
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							氏名(ローマ字)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="5">
                            <asp:TextBox ID="KIKAKU_TANTO_ROMA" runat="server" MaxLength="150" ReadOnly="true" 
                                TextMode="MultiLine" Height="35px" Width="315px" TabIndex="250" 
                                BorderStyle="None">123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890</asp:TextBox>                            
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							オフィスの電話番号
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="KIKAKU_TANTO_TEL" runat="server" Text="12345678901234567890"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							携帯電話
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="KIKAKU_TANTO_KEITAI" runat="server" Text="1234-5678-9012"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 105px;">
							メールアドレス
						</td>
						<td align="left" class="TdItem" colspan="5">
							<asp:Label ID="KIKAKU_TANTO_EMAIL" runat="server" Text="12345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 105px;">
							携帯のメールアドレス
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
							■ 概要
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							予算額(非課税)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" style="width: 200px;">
							<asp:Label ID="YOSAN_TF" runat="server" Text="1,234,56,789"></asp:Label>
							円

						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							予算額(課税)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="5">
							<asp:Label ID="YOSAN_T" runat="server" Text="1,234,56,789"></asp:Label>
							円
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
				            <asp:Button ID="BtnRireki" runat="server" Width="150px" Text="履歴表示" CssClass="Button" />
				        </td>
				        <td align="right" style="width:70%">
				            <asp:Button ID="BtnToroku" runat="server" Width="150px" Text="登録" 
                                CssClass="Button" />
				            <asp:Button ID="BtnNozomi" runat="server" Width="150px" Text="NOZOMIへ" 
                                CssClass="Button" />
					        <asp:Button ID="BtnCancel" runat="server" Width="150px" Text="キャンセル" CssClass="ButtonCancel" />
				        </td>
			        </tr>
		        </table>
			</td>
		</tr>
	</table>
</asp:Content>
