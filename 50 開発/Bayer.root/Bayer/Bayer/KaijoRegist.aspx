<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="KaijoRegist.aspx.vb" Inherits="Bayer.KaijoRegist" MaintainScrollPositionOnPostback="true" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table cellspacing="2" border="0" id="TblComment" runat="server" style="width: 940px;">
		<tr>
			<td nowrap="nowrap" align="left">
				<table cellspacing="2" border="0" style="border: 3px double #339933; width: 100%; background-color: #eaf8ff; margin-bottom: 5px;">
					<tr>
						<td align="center" style="padding: 3px; color: #0099cc; font-weight: bold;">
							ダブルクォーテーション「”」・改行(Enterキー)は<br />
							入力できません。
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
	<table cellspacing="0" cellpadding="0" border="0" style="width: 940px; margin-bottom: 10px;">
		<tr>
			<td nowrap="nowrap" align="left">
				&nbsp;
			</td>
			<td nowrap="nowrap"align="right">
				<asp:Button ID="BtnPrint1" runat="server" Width="150px" Text="手配書印刷" CssClass="Button" />
				<asp:Button ID="BtnBack1" runat="server" Width="150px" Text="キャンセル" CssClass="Button" />
			</td>
		</tr>
	</table>
	<table cellspacing="2" border="0" style="width: 940px;">
		<tr>
			<td nowrap="nowrap" align="right">
				<table cellspacing="0" border="0">
					<tr>
						<td nowrap="nowrap" align="center" class="TdTitle" style="width: 70px;">
							NOZOMI
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="SEND_FLAG" runat="server"></asp:Label>
							&nbsp;
							&nbsp;
						</td>
						<td nowrap="nowrap" align="center" class="TdTitle" style="width: 90px;" id="TdUPDATE_DATE_1" runat="server">
							TOP更新日時
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" id="TdUPDATE_DATE_2" runat="server">
							<asp:Label ID="UPDATE_DATE" runat="server" Text="2013/12/31 12:34:56"></asp:Label>
							&nbsp;
							&nbsp;
						</td>
						<td nowrap="nowrap" align="center" class="TdTitle" style="width: 80px;">
							TOP担当者
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="USER_NAME" runat="server"></asp:Label>
							&nbsp;
							&nbsp;
						</td>
						<td nowrap="nowrap" align="center" class="TdTitleKaijo" style="width: 80px;">
							ステータス
						</td>
						<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 150px;">
							<asp:DropDownList ID="ANS_STATUS_TEHAI" runat="server" Width="145px"></asp:DropDownList>
						</td>
						<td nowrap="nowrap" align="left" id="TdHelp" runat="server">
							<asp:Image runat="server" ImageAlign="AbsMiddle" ImageUrl="~/Images/help.png" /><a href="#" class="link" onclick="window.open('KaijoStatus.html','help','width=500,height=400,menubar=no,stausbar=no,toolbar=no,location=no,resizable=no,scrollbars=no')">ステータスについて</a>
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
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										講演会番号
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="KOUENKAI_NO" runat="server" Text="12345678901234"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										依頼内容
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="REQ_STATUS_TEHAI" runat="server" Text="◎◎◎◎◎◎◎◎◎◎" Width="100px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										Timestamp
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="TIME_STAMP_BYL" runat="server" Text="8888/88/88 88:88:88" Width="150px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										承認者
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="SHONIN_NAME" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" Width="200px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										承認日
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="3">
										<asp:Label ID="SHONIN_DATE" runat="server" Text="yyyy/MM/dd" Width="100px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										講演会名
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="5">
										<asp:Label ID="KOUENKAI_NAME" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" Width="600px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										講演開催日
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="5">
										<asp:Label ID="FROM_DATE" runat="server" Text="yyyy/MM/dd" Width="280px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										チケット印字名
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="TAXI_PRT_NAME" runat="server" Text="1234567890" Width="200px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										製品名
									</td>
									<td nowrap="nowrap" align="left" colspan="3">
										<asp:Label ID="SEIHIN_NAME" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" Width="400px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										開催日備考
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="5">
										<asp:TextBox ID="KAISAI_DATE_NOTE" runat="server" TextMode="MultiLine" Width="750px" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" ReadOnly="true" TabIndex="-1" CssClass="DispMultiLine"></asp:TextBox>
									</td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left">
							<table border="0" cellpadding="1" cellspacing="2">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										Internal order<br />(課税)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="INTERNAL_ORDER_T" runat="server" Text="123456789012" Width="110px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										Internal order<br />(非課税)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="INTERNAL_ORDER_TF" runat="server" Text="123456789012" Width="110px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										Account Code<br />(課税)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="ACCOUNT_CD_T" runat="server" Text="1234567" Width="70px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										Account Code<br />(非課税)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="ACCOUNT_CD_TF" runat="server" Text="1234567" Width="70px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										Zetia Code
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="ZETIA_CD" runat="server" Text="1234567890" Width="110px"></asp:Label>
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
										<asp:Label ID="BU" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" Width="300px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										所属エリア
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="KIKAKU_TANTO_AREA" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" Width="300px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										所属営業所
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="KIKAKU_TANTO_EIGYOSHO" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" Width="300px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										担当者氏名
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="KIKAKU_TANTO_NAME" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" Width="300px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										担当者氏名(ローマ字)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="KIKAKU_TANTO_ROMA" runat="server" Text="WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW" Width="300px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										携帯電話番号
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 150px;">
										<asp:Label ID="KIKAKU_TANTO_KEITAI" runat="server" Text="1234-5678-9012" Width="300px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										オフィス電話番号
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 150px;">
										<asp:Label ID="KIKAKU_TANTO_TEL" runat="server" Text="1234-5678-9012" Width="300px"></asp:Label>
									</td>
									<td>&nbsp;</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										携帯アドレス
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 300px;">
										<asp:Label ID="KIKAKU_TANTO_EMAIL_KEITAI" runat="server" Text="12345678901234567890123456789012345678901234567890" Width="300px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										EMailアドレス
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="KIKAKU_TANTO_EMAIL_PC" runat="server" Text="12345678901234567890123456789012345678901234567890" Width="300px"></asp:Label>
									</td>
									<td>&nbsp;</td>
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
										<asp:Label ID="TEHAI_TANTO_BU" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" Width="300px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										所属エリア
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="TEHAI_TANTO_AREA" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" Width="300px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										所属営業所
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="TEHAI_TANTO_EIGYOSHO" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" Width="300px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										担当者氏名
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="TEHAI_TANTO_NAME" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" Width="300px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										担当者氏名(ローマ字)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="TEHAI_TANTO_ROMA" runat="server" Text="WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW" Width="300px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										携帯電話番号
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 150px;">
										<asp:Label ID="TEHAI_TANTO_KEITAI" runat="server" Text="1234-5678-9012" Width="300px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										オフィス電話番号
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 150px;">
										<asp:Label ID="TEHAI_TANTO_TEL" runat="server" Text="1234-5678-9012" Width="300px"></asp:Label>
									</td>
									<td>&nbsp;</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										携帯アドレス
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 300px;">
										<asp:Label ID="TEHAI_TANTO_EMAIL_KEITAI" runat="server" Text="12345678901234567890123456789012345678901234567890" Width="300px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										EMailアドレス
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="TEHAI_TANTO_EMAIL_PC" runat="server" Text="12345678901234567890123456789012345678901234567890" Width="300px"></asp:Label>
									</td>
									<td>&nbsp;</td>
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
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										参加予定数
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="3">
										従業員以外：
										<asp:Label ID="SANKA_YOTEI_CNT_NMBR" runat="server" Text="12,345" Width="80px"></asp:Label>
										&nbsp;&nbsp;&nbsp;
										従業員：
										<asp:Label ID="SANKA_YOTEI_CNT_MBR" runat="server" Text="12,345" Width="80px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 120px;">
										SRM発注区分
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="SRM_HACYU_KBN" runat="server" Text="◎◎◎◎◎◎" Width="100px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										予算額(課税)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 120px;">
										<asp:Label ID="YOSAN_T" runat="server" Text="1,234,567,890" Width="100px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp">
										予算額(非課税)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 120px;">
										<asp:Label ID="YOSAN_TF" runat="server" Text="1,234,567,890" Width="100px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 110px;">
										予算額合計
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 120px;">
										<asp:Label ID="YOSAN_TOTAL" runat="server" Text="1,234,567,890" Width="100px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										慰労会予算(課税)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 120px;">
										<asp:Label ID="IROUKAI_YOSAN_T" runat="server" Text="1,234,567,890" Width="100px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 135px;">
										意見交換会予算(課税)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 120px;" colspan="3">
										<asp:Label ID="IKENKOUKAN_YOSAN_T" runat="server" Text="1,234,567,890" Width="100px"></asp:Label>
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
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp2" style="width: 75px;">
										開催希望地
									</td>
									<td nowrap="nowrap" align="left">
										<table cellspacing="2" border="0">
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													都道府県
												</td>
												<td nowrap="nowrap" align="left" style="width: 95px;">
													<asp:Label ID="KAISAI_KIBOU_ADDRESS1" runat="server" Text="◎◎◎◎" Width="70px"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													市町村
												</td>
												<td nowrap="nowrap" align="left" style="width: 510px;">
													<asp:Label ID="KAISAI_KIBOU_ADDRESS2" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" Width="500px"></asp:Label>
												</td>
												<td>&nbsp;</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													備考欄
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="KAISAI_KIBOU_NOTE" runat="server" TextMode="MultiLine" Width="700px" ReadOnly="true" TabIndex="-1" CssClass="DispMultiLine"></asp:TextBox>
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
							<table cellpadding="2" cellspacing="0" style="margin-bottom: 3px;">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp2" style="width: 75px;" rowspan="2">
										必要会場
									</td>
									<td nowrap="nowrap" align="left">
										<table cellpadding="2" cellspacing="2">
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													講演会
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp2" style="width: 70px;">
													開始時間
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 55px;">
													<asp:Label ID="KOUEN_TIME1" runat="server" Text="12:34" Width="50px"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp2" style="width: 70px;">
													終了時間
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 55px;">
													<asp:Label ID="KOUEN_TIME2" runat="server" Text="12:34" Width="50px"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp2" style="width: 70px;">
													レイアウト
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													<asp:Label ID="KOUEN_KAIJO_LAYOUT" runat="server" Text="◎◎◎◎◎◎◎◎◎◎" Width="180px"></asp:Label>
												</td>
											</tr>
										</table>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left">
										<table cellpadding="2" cellspacing="2">
											<tr>
												<td nowrap="nowrap" align="center">
													&nbsp;
												</td>
												<td nowrap="nowrap" align="center" class="TdTitleKaijoDisp2" style="width: 45px;">
													要
												</td>
												<td nowrap="nowrap" align="center" class="TdTitleKaijoDisp2" style="width: 45px;">
													不要
												</td>
												<td nowrap="nowrap" colspan="2">
													&nbsp;
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													意見交換会場
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="IKENKOUKAN_KAIJO_TEHAI_Yes" runat="server" Text="●" Width="40px"></asp:Label>
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="IKENKOUKAN_KAIJO_TEHAI_No" runat="server" Text="○" Width="40px"></asp:Label>
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
													<asp:Label ID="IROUKAI_KAIJO_TEHAI_Yes" runat="server" Text="●" Width="40px"></asp:Label>
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="IROUKAI_KAIJO_TEHAI_No" runat="server" Text="○" Width="40px"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left">
													<table border="0" cellpadding="2" cellspacing="0" style="margin-left: 5px;">
														<tr>
															<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp2" style="width: 90px;">
																参加予定者数
															</td>
															<td nowrap="nowrap" align="left" style="width: 80px;">
																<asp:Label ID="IROUKAI_SANKA_YOTEI_CNT" runat="server" Text="12,345" Width="80px"></asp:Label>
															</td>
														</tr>
													</table>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													講師控室
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="KOUSHI_ROOM_TEHAI_Yes" runat="server" Text="○" Width="40px"></asp:Label>
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="KOUSHI_ROOM_TEHAI_No" runat="server" Text="●" Width="40px"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left">
													<table border="0" cellpadding="2" cellspacing="0" style="margin-left: 5px;">
														<tr>
															<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp2" style="width: 90px;">
																時間(From)
															</td>
															<td nowrap="nowrap" align="left" style="width: 60px;">
																<asp:Label ID="KOUSHI_ROOM_FROM" runat="server" Text="12:34" Width="80px"></asp:Label>
															</td>
															<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp2" style="width: 45px;">
																人数
															</td>
															<td nowrap="nowrap" align="left">
																<asp:Label ID="KOUSHI_ROOM_CNT" runat="server" Text="12,345" Width="80px"></asp:Label>
															</td>
														</tr>
													</table>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													社員控室
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="SHAIN_ROOM_TEHAI_Yes" runat="server" Text="●" Width="40px"></asp:Label>
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="SHAIN_ROOM_TEHAI_No" runat="server" Text="○" Width="40px"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left">
													<table border="0" cellpadding="2" cellspacing="0" style="margin-left: 5px;">
														<tr>
															<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp2" style="width: 90px;">
																人数
															</td>
															<td nowrap="nowrap" align="left" style="width: 80px;">
																<asp:Label ID="SHAIN_ROOM_CNT" runat="server" Text="12,345" Width="80px"></asp:Label>
															</td>
														</tr>
													</table>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													世話人会会場
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="MANAGER_KAIJO_TEHAI_Yes" runat="server" Text="●" Width="40px"></asp:Label>
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="MANAGER_KAIJO_TEHAI_No" runat="server" Text="○" Width="40px"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left">
													<table border="0" cellpadding="2" cellspacing="0" style="margin-left: 5px;">
														<tr>
															<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp2" style="width: 150px;">
																世話人控室 時間(From)
															</td>
															<td nowrap="nowrap" align="left" style="width: 60px;">
																<asp:Label ID="MANAGER_ROOM_FROM" runat="server" Text="12:34" Width="80px"></asp:Label>
															</td>
															<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp2" style="width: 105px;">
																世話人控室 人数
															</td>
															<td nowrap="nowrap" align="left">
																<asp:Label ID="MANAGER_ROOM_CNT" runat="server" Text="12,345" Width="80px"></asp:Label>
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
						<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp">
							■ 宿泊・交通・その他
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left">
							<table cellspacing="2" border="0">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										宿泊希望室数
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="5">
										<asp:Label ID="REQ_ROOM_CNT" runat="server" Text="12,345" Width="80px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										宿泊希望日
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 140px;">
										<asp:Label ID="REQ_STAY_DATE" runat="server" Text="yyyy/MM/dd" Width="135px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 180px;">
										交通手配予定人数(JR/AIR)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 100px;">
										<asp:Label ID="REQ_KOTSU_CNT" runat="server" Text="12,345" Width="80px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										タクシー手配予定人数
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 100px;">
										<asp:Label ID="REQ_TAXI_CNT" runat="server" Text="12,345" Width="80px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										その他備考欄
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="5">
										<asp:TextBox ID="OTHER_NOTE" runat="server" TextMode="MultiLine" Width="600px" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" ReadOnly="true" TabIndex="-1" CssClass="DispMultiLine"></asp:TextBox>
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
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 100px;">
													施設<br />
													選定理由
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_SENTEI_RIYU" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" Width="650px" MaxLength="510" TextMode="MultiLine"></asp:TextBox>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 100px;">
													都道府県
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 110px;">
													<asp:DropDownList ID="ADDRESS1" runat="server" Width="100px"></asp:DropDownList>
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 100px;">
													市区町村
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 330px;">
													<asp:TextBox ID="ADDRESS2" runat="server" Text="◎◎◎◎◎◎◎◎◎◎" Width="350px" MaxLength="100"></asp:TextBox>
												</td>
												<td nowrap="nowrap">&nbsp;</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 100px;">
													施設名
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_SHISETSU_NAME" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" Width="600px" MaxLength="80"></asp:TextBox>
													&nbsp;
													<asp:Button ID="BtnShisetsuKensaku" runat="server" Text="検索" Width="50px" CssClass="ButtonList" />
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													施設住所
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													〒<asp:TextBox ID="ANS_SHISETSU_ZIP" runat="server" Text="888-8888" Width="80px" ReadOnly="true" TabIndex="-1" CssClass="disp"></asp:TextBox>
													<asp:Image ID="Image1" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/Images/spacer.gif" Width="2px" Height="1px" />
													<asp:TextBox ID="ANS_SHISETSU_ADDRESS" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎●" Width="570px" ReadOnly="true" TabIndex="-1" CssClass="disp"></asp:TextBox>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													施設TEL
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_SHISETSU_TEL" runat="server" Text="0000-0000-0000" Width="130px" ReadOnly="true" TabIndex="-1" CssClass="disp"></asp:TextBox>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													施設URL
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_SHISETSU_URL" runat="server" Text="http://WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW@" Width="650px" ReadOnly="true" TabIndex="-1" CssClass="disp"></asp:TextBox>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													講演会会場名
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_KOUEN_KAIJO_NAME" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" Width="650px" MaxLength="160"></asp:TextBox>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													会場フロア
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_KOUEN_KAIJO_FLOOR" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" Width="650px" MaxLength="160"></asp:TextBox>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													意見交換会場名
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_IKENKOUKAN_KAIJO_NAME" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" Width="650px" MaxLength="160"></asp:TextBox>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													慰労会会場名
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_IROUKAI_KAIJO_NAME" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" Width="650px" MaxLength="160"></asp:TextBox>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													講師控室会場名
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_KOUSHI_ROOM_NAME" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" Width="650px" MaxLength="160"></asp:TextBox>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													社員控室会場名
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_SHAIN_ROOM_NAME" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" Width="650px" MaxLength="160"></asp:TextBox>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													世話人会会場名
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_MANAGER_KAIJO_NAME" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" Width="650px" MaxLength="160"></asp:TextBox>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													開催地備考
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_KAISAI_NOTE" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" Width="650px" MaxLength="510" TextMode="MultiLine"></asp:TextBox>
												</td>
											</tr>
										</table>
									</td>
								</tr>
							</table>
							<table border="0" cellpadding="1" cellspacing="2">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijo" style="width: 110px;" rowspan="3">
										概算見積<br />
										(非課税)
									</td>
									<td nowrap="nowrap" align="left" style="border: 1px solid #a8a8a8;">
										<span style="font-weight: bold;">
											991330401
										</span>
										<br />
										<table cellspacing="2" border="0">
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													会場費
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													機材費
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													飲食費
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" colspan="2">
													小計
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_KAIJOUHI_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>
													円
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_KIZAIHI_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>
													円
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_INSHOKUHI_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>
													円
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 140px;">
													<asp:Label ID="ANS_991330401_TF" runat="server" Text="1,234,567,890"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													&nbsp;
												</td>
											</tr>
										</table>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" style="border: 1px solid #a8a8a8;">
										<span style="font-weight: bold;">
											41120200
										</span>
										<br />
										<table cellspacing="2" border="0">
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													宿泊費
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													交通費
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													タクシー実車料金
												</td>
												<td colspan="2">&nbsp;</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_HOTELHI_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_KOTSUHI_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_TAXI_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
												</td>
												<td colspan="2">&nbsp;</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 125px;">
													 交通宿泊手配手数料
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 120px;">
													タクシー発券手数料
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 120px;">
													タクシー精算手数料
												</td>
												<td colspan="2">&nbsp;</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_TEHAI_TESURYO_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_TAXI_HAKKEN_TESURYO_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_TAXI_SEISAN_TESURYO_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
												</td>
												<td colspan="2">&nbsp;</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													人件費
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													その他
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													管理費
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" colspan="2">
													小計
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_JINKENHI_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_OTHER_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_KANRIHI_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 140px;">
													<asp:Label ID="ANS_41120200_TF" runat="server" Text="1,234,567,890"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													&nbsp;
												</td>
											</tr>
										</table>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" style="border: 1px solid #a8a8a8;">
										<table cellspacing="2" border="0" style="width: 220px;">
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" colspan="3" style="font-weight: bold;">
													非課税合計
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 140px;">
													<asp:Label ID="ANS_TOTAL_TF" runat="server" Text="1,234,567,890"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													<asp:Button ID="BtnCalc_ANS_TOTAL_TF" runat="server" Text="再計算" Width="60px" CssClass="ButtonList" />
												</td>
												<td>&nbsp;</td>
											</tr>
										</table>
									</td>
								</tr>
							</table>
							<table border="0" cellpadding="1" cellspacing="2">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijo" style="width: 110px;" rowspan="3">
										概算見積<br />
										(課税)
									</td>
									<td nowrap="nowrap" align="left" style="border: 1px solid #a8a8a8;">
										<span style="font-weight: bold;">
											991330401
										</span>
										<br />
										<table cellspacing="2" border="0">
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													会場費
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													機材費
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													飲食費
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" colspan="2">
													小計
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_KAIJOUHI_T" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>
													円
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_KIZAIHI_T" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>
													円
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_INSHOKUHI_T" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>
													円
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 140px;">
													<asp:Label ID="ANS_991330401_T" runat="server" Text="1,234,567,890"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													&nbsp;
												</td>
											</tr>
										</table>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" style="border: 1px solid #a8a8a8;">
										<span style="font-weight: bold;">
											41120200
										</span>
										<br />
										<table cellspacing="2" border="0">
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													人件費
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													その他
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													管理費
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" colspan="2">
													小計
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_JINKENHI_T" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_OTHER_T" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_KANRIHI_T" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 140px;">
													<asp:Label ID="ANS_41120200_T" runat="server" Text="1,234,567,890"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													&nbsp;
												</td>
											</tr>
										</table>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" style="border: 1px solid #a8a8a8;">
										<table cellspacing="2" border="0" style="width: 220px;">
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" colspan="3" style="font-weight: bold;">
													課税合計
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 140px;">
													<asp:Label ID="ANS_TOTAL_T" runat="server" Text="1,234,567,890"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													<asp:Button ID="BtnCalc_ANS_TOTAL_T" runat="server" Text="再計算" Width="60px" CssClass="ButtonList" />
												</td>
												<td>&nbsp;</td>
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
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 100px;">
													非課税額
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													<asp:Label ID="ANS_MITSUMORI_TF" runat="server" Text="1,234,567,890"></asp:Label>
													&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 75px;">
													課税額
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													<asp:Label ID="ANS_MITSUMORI_T" runat="server" Text="1,234,567,890"></asp:Label>
													&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 90px;">
													利用額合計
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 110px">
													<asp:Label ID="ANS_MITSUMORI_TOTAL" runat="server" Text="1,234,567,890"></asp:Label>
													&nbsp;&nbsp;&nbsp;
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													<asp:Button ID="BtnCalc_ANS_MITSUMORI" runat="server" Text="再計算" Width="60px" CssClass="ButtonList" />
												</td>
											</tr>
										</table>
									</td>
								</tr>
							</table>
							<table border="0" cellpadding="1" cellspacing="2">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijo" style="width: 110px;">
										見積書
									</td>
									<td nowrap="nowrap" align="left">
										<table cellspacing="2" border="0">
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 100px;">
													保存場所URL
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													<asp:TextBox ID="ANS_MITSUMORI_URL" runat="server" Text="http://WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW@" Width="650px" MaxLength="255"></asp:TextBox>
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
				<table cellspacing="0" cellpadding="2" border="0" style="width: 940px;">
					<tr style="height: 36px;">
						<td nowrap="nowrap"align="left">
							<asp:Button ID="BtnRireki" runat="server" Width="150px" Text="履歴表示" CssClass="Button" />
							<asp:Button ID="BtnPrint2" runat="server" Width="150px" Text="手配書印刷" CssClass="Button" />
						</td>
						<td>&nbsp;</td>
						<td nowrap="nowrap"align="right">
							<asp:Button ID="BtnNozomi" runat="server" Width="150px" Text="NOZOMIへ" CssClass="Button" />
							<asp:Button ID="BtnSubmit" runat="server" Width="150px" Text="登録" CssClass="Button" />
							<asp:Button ID="BtnBack2" runat="server" Width="150px" Text="キャンセル" CssClass="Button" />
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
</asp:Content>
