<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="KaijoRegist.aspx.vb" Inherits="Bayer.KaijoRegist" MaintainScrollPositionOnPostback="true" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table cellspacing="2" border="0">
		<tr>
			<td nowrap="nowrap" align="right">
				<table cellspacing="0" border="0" style="width: 940px;">
					<tr>
						<td>&nbsp;</td>
						<td nowrap="nowrap" align="left" class="TdTitleKaijo" style="width: 90px;">
							&nbsp;
							ステータス
							&nbsp;
						</td>
						<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 200px;">
							<asp:DropDownList ID="ANS_STATUS_TEHAI" runat="server" Width="200px"></asp:DropDownList>
						</td>
					</tr>
				</table>
			</td>
		</tr>
		<tr>
			<td nowrap="nowrap" align="left">
				<table style="width: 940px; border: 1px solid #738891;" cellspacing="0" border="0">
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp">
							■ 講演会情報
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left">
							<table cellspacing="2" border="0">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										講演会番号
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="KOUENKAI_NO" runat="server" Text="12345678901234"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										依頼内容
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="REQ_STATUS_TEHAI" runat="server" Text="◎◎◎◎◎◎◎◎◎◎"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										Timestamp
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="TIME_STAMP_BYL" runat="server" Text="8888/88/88 88:88:88"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										承認者
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="SHONIN_NAME" runat="server" Text="12345678901234567890"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										承認日
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="3">
										<asp:Label ID="SHONIN_DATE" runat="server" Text="yyyy/MM/dd"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										講演会名
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="5">
										<asp:Label ID="KOUENKAI_NAME" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										講演開催日
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="FROM_DATE" runat="server" Text="yyyy/MM/dd"></asp:Label>
										～
										<asp:Label ID="TO_DATE" runat="server" Text="yyyy/MM/dd"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										チケット印字名
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="TAXI_PRT_NAME" runat="server" Text="1234567890"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										製品名
									</td>
									<td nowrap="nowrap" align="left">
										<asp:Label ID="SEIHIN_NAME" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										開催日備考
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="5">
										<asp:TextBox ID="KAISAI_DATE_NOTE" runat="server" TextMode="MultiLine" Width="600px" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" ReadOnly="true" TabIndex="-1" CssClass="DispMultiLine"></asp:TextBox>
									</td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left">
							<table border="0" cellpadding="1" cellspacing="2">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										Internal order<br />(課税)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="INTERNAL_ORDER_T" runat="server" Text="123456789012"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										Internal order<br />(非課税)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="INTERNAL_ORDER_TF" runat="server" Text="123456789012"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										アカウントコード<br />(課税)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="ACCOUNT_CD_T" runat="server" Text="1234567"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										アカウントコード<br />(非課税)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="ACCOUNT_CD_TF" runat="server" Text="1234567"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										zetia Code
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="ZETIA_CD" runat="server" Text="1234567890"></asp:Label>
									</td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp">
							■ 講演会 企画担当者
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left">
							<table cellspacing="2" border="0">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										所属BU
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="BU" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										所属エリア
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="KIKAKU_TANTO_AREA" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										所属営業所
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="KIKAKU_TANTO_EIGYOSHO" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										担当者氏名
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="KIKAKU_TANTO_NAME" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										担当者氏名(ローマ字)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="KIKAKU_TANTO_ROMA" runat="server" Text="WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										携帯電話番号
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 150px;">
										<asp:Label ID="KIKAKU_TANTO_KEITAI" runat="server" Text="1234-5678-9012"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 120px;">
										オフィス電話番号
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 150px;">
										<asp:Label ID="KIKAKU_TANTO_TEL" runat="server" Text="1234-5678-9012"></asp:Label>
									</td>
									<td>&nbsp;</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										EMailアドレス
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="KIKAKU_TANTO_EMAIL_PC" runat="server" Text="12345678901234567890123456789012345678901234567890"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										携帯アドレス
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="KIKAKU_TANTO_EMAIL_KEITAI" runat="server" Text="12345678901234567890123456789012345678901234567890"></asp:Label>
									</td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp">
							■ 講演会 手配担当者
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left">
							<table cellspacing="2" border="0">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										所属BU
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="TEHAI_TANTO_BU" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										所属エリア
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="TEHAI_TANTO_AREA" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										所属営業所
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="TEHAI_TANTO_EIGYOSHO" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										担当者氏名
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="TEHAI_TANTO_NAME" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										担当者氏名(ローマ字)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="TEHAI_TANTO_ROMA" runat="server" Text="WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										携帯電話番号
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 150px;">
										<asp:Label ID="TEHAI_TANTO_KEITAI" runat="server" Text="1234-5678-9012"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 120px;">
										オフィス電話番号
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 150px;">
										<asp:Label ID="TEHAI_TANTO_TEL" runat="server" Text="1234-5678-9012"></asp:Label>
									</td>
									<td>&nbsp;</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										EMailアドレス
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="TEHAI_TANTO_EMAIL_PC" runat="server" Text="12345678901234567890123456789012345678901234567890"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										携帯アドレス
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="TEHAI_TANTO_EMAIL_KEITAI" runat="server" Text="12345678901234567890123456789012345678901234567890"></asp:Label>
									</td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp">
							■ 概要
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left">
							<table cellspacing="2" border="0">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 110px;">
										参加予定数
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="5">
										<asp:Label ID="SANKA_YOTEI_CNT" runat="server" Text="12,345"></asp:Label>
										名
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 110px;">
										予算額(課税)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 120px;">
										<asp:Label ID="YOSAN_T" runat="server" Text="1,234,567,890"></asp:Label>
										円
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 110px;">
										予算額(非課税)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 120px;">
										<asp:Label ID="YOSAN_TF" runat="server" Text="1,234,567,890"></asp:Label>
										円
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 110px;">
										予算額合計
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 120px;">
										<asp:Label ID="YOSAN_TOTAL" runat="server" Text="1,234,567,890"></asp:Label>
										円
									</td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp">
							■ 会場
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left">
							<table cellspacing="2" border="0">
								<tr>
									<td nowrap="nowrap" align="left" style="width: 75px; background-color: #e1e1e1; font-weight: bold; color: #4e4e4e;">
										開催希望地
									</td>
									<td nowrap="nowrap" align="left">
										<table cellspacing="2" border="0">
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													都道府県
												</td>
												<td nowrap="nowrap" align="left" style="width: 95px;">
													<asp:Label ID="KAISAI_KIBOU_ADDRESS1" runat="server" Text="◎◎◎◎"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													市町村
												</td>
												<td nowrap="nowrap" align="left" style="width: 370px;">
													<asp:Label ID="KAISAI_KIBOU_ADDRESS2" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎"></asp:Label>
												</td>
												<td>&nbsp;</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													備考欄
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="KAISAI_KIBOU_NOTE" runat="server" TextMode="MultiLine" Width="600px" ReadOnly="true" TabIndex="-1" CssClass="DispMultiLine"></asp:TextBox>
												</td>
											</tr>
										</table>
									</td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left">
							<table cellspacing="2" border="0">
								<tr>
									<td nowrap="nowrap" align="left" style="width: 75px; background-color: #e1e1e1; font-weight: bold; color: #4e4e4e;" rowspan="2">
										必要会場
									</td>
									<td nowrap="nowrap" align="left">
										<table cellspacing="2" border="0">
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													講演会
												</td>
												<td nowrap="nowrap" align="left" style="width: 68px; background-color: #e1e1e1; font-weight: bold; color: #4e4e4e;">
													開始時間
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 55px;">
													<asp:Label ID="KOUEN_TIME1" runat="server" Text="12:34"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left" style="width: 68px; background-color: #e1e1e1; font-weight: bold; color: #4e4e4e;">
													終了時間
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 55px;">
													<asp:Label ID="KOUEN_TIME2" runat="server" Text="12:34"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left" style="width: 70px; background-color: #e1e1e1; font-weight: bold; color: #4e4e4e;">
													レイアウト
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													<asp:Label ID="KOUEN_KAIJO_LAYOUT" runat="server" Text="◎◎◎◎◎◎◎◎◎◎"></asp:Label>
												</td>
											</tr>
										</table>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left">
										<table cellspacing="2" border="0">
											<tr>
												<td nowrap="nowrap" align="center">
													&nbsp;
												</td>
												<td nowrap="nowrap" align="center" class="TdTitleKaijoDisp" style="width: 45px; background-color: #e1e1e1; font-weight: bold; color: #4e4e4e;">
													要
												</td>
												<td nowrap="nowrap" align="center" class="TdTitleKaijoDisp" style="width: 45px; background-color: #e1e1e1; font-weight: bold; color: #4e4e4e;">
													不要
												</td>
												<td nowrap="nowrap" align="center">
													&nbsp;
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													意見交換会場
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="IKENKOUKAN_KAIJO_TEHAI_Yes" runat="server" Text="●"></asp:Label>
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="IKENKOUKAN_KAIJO_TEHAI_No" runat="server" Text="○"></asp:Label>
												</td>
												<td nowrap="nowrap">
													&nbsp;
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													慰労会会場
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="IROUKAI_KAIJO_TEHAI_Yes" runat="server" Text="●"></asp:Label>
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="IROUKAI_KAIJO_TEHAI_No" runat="server" Text="○"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left">
													参加人数：
													<asp:Label ID="IROUKAI_SANKA_YOTEI_CNT" runat="server" Text="1,234"></asp:Label>
													名
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													講師控室
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="KOUSHI_ROOM_TEHAI_Yes" runat="server" Text="○"></asp:Label>
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="KOUSHI_ROOM_TEHAI_No" runat="server" Text="●"></asp:Label>
												</td>
												<td nowrap="nowrap">
													&nbsp;
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													世話人会
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="MANAGER_KAIJO_TEHAI_Yes" runat="server" Text="●"></asp:Label>
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="MANAGER_KAIJO_TEHAI_No" runat="server" Text="○"></asp:Label>
												</td>
												<td nowrap="nowrap">
													&nbsp;
												</td>
											</tr>
										</table>
									</td>
								</tr>
							</table>
						</td>
					</tr>
				</table>
			</td>
		</tr>
		<tr>
			<td nowrap="nowrap" align="left">
				<table cellspacing="2" border="0" style="margin-top: 10px; width: 940px; border: 1px solid #9babb3;">
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleKaijo">
							■ 回答
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left">
							<table border="0" cellpadding="1" cellspacing="2">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijo" style="width: 110px;">
										会場回答
									</td>
									<td nowrap="nowrap" align="left">
										<table cellspacing="2" border="0">
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 70px;">
													都道府県
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 110px;">
													<asp:DropDownList ID="ADDRESS1" runat="server" Width="100px"></asp:DropDownList>
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 70px;">
													市区町村
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 330px;">
													<asp:TextBox ID="ADDRESS2" runat="server" Text="◎◎◎◎◎◎◎◎◎◎" Width="300px"></asp:TextBox>
												</td>
												<td nowrap="nowrap">&nbsp;</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													施設名
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_SHISETSU_NAME" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" Width="650px"></asp:TextBox>
													&nbsp;
													<asp:Button ID="BtnShisetsuKensaku" runat="server" Text="検索" Width="50px" CssClass="ButtonList" />
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													会場住所
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_SHISETSU_ADDRESS" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎●" Width="650px" ReadOnly="true" TabIndex="-1" CssClass="disp"></asp:TextBox>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													会場TEL
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_SHISETSU_TEL" runat="server" Text="0000-0000-0000" Width="130px" ReadOnly="true" TabIndex="-1" CssClass="disp"></asp:TextBox>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													会場URL
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_SHISETSU_URL" runat="server" Text="http://WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW@" Width="650px" ReadOnly="true" TabIndex="-1" CssClass="disp"></asp:TextBox>
												</td>
											</tr>
										</table>
									</td>
								</tr>
							</table>
							<table border="0" cellpadding="1" cellspacing="2">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijo" style="width: 110px;">
										概算見積
									</td>
									<td nowrap="nowrap" align="left">
										<table cellspacing="2" border="0">
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 70px;">
													非課税額
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_MITSUMORI_TF" runat="server" Text="1234567890" Width="100px"></asp:TextBox>
													円
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 70px;">
													課税額
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_MITSUMORI_T" runat="server" Text="1234567890" Width="100px"></asp:TextBox>
													円
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 70px;">
													利用額合計
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 110px;">
													<asp:Label ID="ANS_MITSUMORI_TOTAL" runat="server" Text="1,234,567,890"></asp:Label>
													円
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													<asp:Button ID="BtnCalc" runat="server" Text="再計算" Width="60px" CssClass="ButtonList" />
												</td>
											</tr>
										</table>
									</td>
								</tr>
							</table>
							<table border="0" cellpadding="1" cellspacing="2">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijo" style="width: 110px;">
										見積書 保存場所<br />URL
									</td>
									<td nowrap="nowrap" align="left">
										<table cellspacing="2" border="0">
											<tr>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													<asp:TextBox ID="ANS_MITSUMORI_URL" runat="server" Text="http://WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW@" Width="650px"></asp:TextBox>
												</td>
											</tr>
										</table>
									</td>
								</tr>
							</table>
						</td>
					</tr>
				</table>
			</td>
		</tr>
		<tr>
			<td nowrap="nowrap" align="left">
				<div class="FontSize1" style="height: 10px;"></div>
				<table cellspacing="0" cellpadding="0" border="0" style="width: 940px;">
					<tr style="height: 36px;">
						<td nowrap="nowrap" align="left">
							<asp:Button ID="BtnRireki" runat="server" Width="150px" Text="履歴表示" CssClass="Button" />
							<asp:Button ID="BtnPrint" runat="server" Width="150px" Text="手配書印刷" CssClass="Button" />
						</td>
						<td nowrap="nowrap" align="right">
							<asp:Button ID="BtnNozomi" runat="server" Width="150px" Text="NOZOMIへ" CssClass="Button" />
							<asp:Button ID="BtnSubmit" runat="server" Width="150px" Text="登録" CssClass="Button" />
							<asp:Button ID="BtnCancel" runat="server" Width="150px" Text="キャンセル" CssClass="ButtonCancel" />
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
</asp:Content>
