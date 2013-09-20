<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="KouenkaiRegist.aspx.vb" Inherits="Bayer.KouenkaiRegist" MaintainScrollPositionOnPostback="true" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table border="0" cellpadding="4" cellspacing="0">
		<tr>
			<td nowrap="nowrap" align="left">
				<table style="border-collapse: collapse;" cellspacing="0" cellpadding="2" border="1" bordercolor="#4f5b61">
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 90px;">
							講演会番号
						</td>
						<td nowrap="nowrap" align="left" style="width: 100px;">
							<asp:Label ID="KOUENKAI_NO" runat="server" Text="1234567890"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 90px;">
							ステータス
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="7">
							<asp:DropDownList ID="ANS_STATUS_TEHAI" runat="server" Width="200px"></asp:DropDownList>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 90px;">
							実施予定日
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="YOTEI_DATE" runat="server" Text="yyyy/MM/dd"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 90px;">
							開催日備考

						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="3">
							<asp:TextBox ID="KAISAI_DATE_NOTE" runat="server" TextMode="MultiLine" Width="350px" Height="40px" ReadOnly="true" TabIndex="-1" CssClass="DispMultiLine"></asp:TextBox>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							承認者

						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="SHONIN_NAME" runat="server" Text="12345678901234567890"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							承認日時

						</td>
						<td nowrap="nowrap" align="left" class="TdItem" style="width: 85px;">
							<asp:Label ID="SHONIN_TIME" runat="server" Text="yyyy/MM/dd<br />HH:mm:ss"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 90px;">
							会合名

						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="3">
							<asp:Label ID="KOUENKAI_NAME" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							チケット印字名
							<br />
							(10文字)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" style="width: 95px;">
							<asp:Label ID="TAXI_PRT_NAME" runat="server" Text="1234567890"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							製品者

						</td>
						<td nowrap="nowrap" align="left" colspan="3">
							<asp:Label ID="SEIHIN_NAME" runat="server" Text="1234567890"></asp:Label>
						</td>
					</tr>
				</table>
			</td>
		</tr>
		<tr>
			<td nowrap="nowrap" align="left">
				<table style="border-collapse: collapse; margin-top: 10px;" cellspacing="0" cellpadding="2" border="1" bordercolor="#4f5b61">
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" colspan="8">
							■ 講演会 企画担当者

						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							事業部
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="KIKAKU_TANTO_JIGYOBU" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							エリア
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="KIKAKU_TANTO_AREA" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							営業所
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="3">
							<asp:Label ID="KIKAKU_TANTO_EIGYOSHO" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							CWID
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="KIKAKU_TANTO_NO" runat="server" Text="1234567890"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							氏名
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="KIKAKU_TANTO_NAME" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							携帯電話
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="KIKAKU_TANTO_KEITAI" runat="server" Text="1234-5678-9012"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 105px;">
							メールアドレス
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="KIKAKU_TANTO_EMAIL" runat="server" Text="12345678901234567890123456789012345678901234567890"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" colspan="8">
							■ 講演会 手配担当者

						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							事業部
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="TEHAI_TANTO_JIGYOBU" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							エリア
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="TEHAI_TANTO_AREA" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							営業所
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="3">
							<asp:Label ID="TEHAI_TANTO_EIGYOSHO" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							CWID
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="TEHAI_TANTO_NO" runat="server" Text="1234567890"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							氏名
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="TEHAI_TANTO_NAME" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							携帯電話
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="TEHAI_TANTO_KEITAI" runat="server" Text="1234-5678-9012"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 105px;">
							メールアドレス
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="TEHAI_TANTO_EMAIL" runat="server" Text="12345678901234567890123456789012345678901234567890"></asp:Label>
						</td>
					</tr>
				</table>
			</td>
		</tr>
		<tr>
			<td nowrap="nowrap" align="left">
				<table style="border-collapse: collapse; margin-top: 4px;" cellspacing="0" cellpadding="2" border="1" bordercolor="#4f5b61">
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" colspan="8">
							■ 概要

						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader">
							見積額<br />(非課税)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="MITSUMORI_TF" runat="server" Text="1,234,56,789"></asp:Label>
							円

						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader">
							予算額費用<br />(課税１)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="予算額費用1" runat="server" Text="1,234,56,789"></asp:Label>
							円

						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader">
							予算額費用<br />(課税２)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="予算額費用2" runat="server" Text="1,234,56,789"></asp:Label>
							円

						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader">
							実施費用計

						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="実施費用計" runat="server" Text="1,234,56,789"></asp:Label>
							円

						</td>
					</tr>
				</table>
			</td>
		</tr>
		<tr>
			<td nowrap="nowrap" align="left">
				<div class="FontSize1" style="height: 10px;"></div>
		        <table cellspacing="0" cellpadding="0" border="0" style="width:900px;">
			        <tr style="height: 36px; width:100%">
				        <td align="left" style="width:50%">
				            <asp:Button ID="BtnRireki" runat="server" Width="150px" Text="履歴表示" CssClass="Button" />
				        </td>
				        <td align="right" style="width:50%">
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
