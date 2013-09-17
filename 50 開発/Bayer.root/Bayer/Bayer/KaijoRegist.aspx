<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="KaijoRegist.aspx.vb" Inherits="Bayer.KaijoRegist" MaintainScrollPositionOnPostback="true" %>
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
							依頼内容
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="STATUS_TEHAI" runat="server" Text="◎◎◎◎◎◎◎◎◎◎"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 90px;">
							ステータス
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="5">
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
							参加予定数<br />(医師・薬剤師)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="SANKA_YOTEI_CNT_DR" runat="server" Text="12,345"></asp:Label>
							名
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader">
							参加予定数<br />(その他)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="SANKA_YOTEI_CNT_OTHER" runat="server" Text="12,345"></asp:Label>
							名
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader">
							参加予定数<br />計
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="3">
							<asp:Label ID="SANKA_YOTEI_CNT_TOTAL" runat="server" Text="12,345"></asp:Label>
							名
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
				<table style="border-collapse: collapse; margin-top: 4px;" cellspacing="0" cellpadding="2" border="1" bordercolor="#4f5b61">
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" colspan="4">
							■ 実施会場
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader">
							開催地希望
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							都道府県：
							<asp:Label ID="KAISAI_KIBOU_ADDRESS1" runat="server" Text="◎◎◎◎"></asp:Label>
							&nbsp;&nbsp;&nbsp;
							市町村：
							<asp:Label ID="KAISAI_KIBOU_ADDRESS2" runat="server" Text="◎◎◎◎◎◎◎◎◎◎"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader">
							会場手配に<br />際しての備考
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:TextBox ID="KAISAI_KIBOU_NOTE" runat="server" TextMode="MultiLine" Width="350px" Height="40px" ReadOnly="true" TabIndex="-1" CssClass="DispMultiLine"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader">
							必要会場
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="3">
							<table border="1" cellpadding="3" cellspacing="0" style="border-collapse: collapse;" bordercolor="#b2b2b2">
								<tr style="background-color: #b2b2b2">
									<td align="center" style="width: 80px;">
										&nbsp;
									</td>
									<td align="center" style="width: 45px;">
										要
									</td>
									<td align="center" style="width: 45px;">
										不要
									</td>
									<td align="center" style="width: 70px;">
										開始時刻
									</td>
									<td align="center" style="width: 70px;">
										終了時刻
									</td>
									<td align="center" style="width: 300px;">
										&nbsp;
									</td>
								</tr>
								<tr>
									<td>
										講演会
									</td>
									<td align="center">
										<asp:Label ID="KOUEN_KAIJO_TEHAI_Yes" runat="server" Text="●"></asp:Label>
									</td>
									<td align="center">
										<asp:Label ID="KOUEN_KAIJO_TEHAI_No" runat="server" Text="○"></asp:Label>
									</td>
									<td align="center">
										<asp:Label ID="KOUEN_TIME1" runat="server" Text="12:34"></asp:Label>
									</td>
									<td align="center">
										<asp:Label ID="KOUEN_TIME2" runat="server" Text="12:34"></asp:Label>
									</td>
									<td>
										レイアウト：
										<asp:Label ID="KOUEN_KAIJO_LAYOUT" runat="server" Text="◎◎◎◎◎◎◎◎◎◎"></asp:Label>
									</td>
								</tr>
								<tr>
									<td>
										意見交換会
									</td>
									<td align="center">
										<asp:Label ID="IKENKOUKAN_KAIJO_TEHAI_Yes" runat="server" Text="○"></asp:Label>
									</td>
									<td align="center">
										<asp:Label ID="IKENKOUKAN_KAIJO_TEHAI_No" runat="server" Text="●"></asp:Label>
									</td>
									<td align="center">
										<asp:Label ID="IKENKOUKAN_TIME1" runat="server" Text="12:34"></asp:Label>
									</td>
									<td align="center">
										<asp:Label ID="IKENKOUKAN_TIME2" runat="server" Text="12:34"></asp:Label>
									</td>
									<td>
										&nbsp;
									</td>
								</tr>
								<tr>
									<td>
										講師控室
									</td>
									<td align="center">
										<asp:Label ID="KOUSHI_ROOM_TEHAI_Yes" runat="server" Text="○"></asp:Label>
									</td>
									<td align="center">
										<asp:Label ID="KOUSHI_ROOM_TEHAI_No" runat="server" Text="●"></asp:Label>
									</td>
									<td align="center">
										<asp:Label ID="KOUSHI_ROOM_TIME1" runat="server" Text="12:34"></asp:Label>
									</td>
									<td align="center">
										<asp:Label ID="KOUSHI_ROOM_TIME2" runat="server" Text="12:34"></asp:Label>
									</td>
									<td>
										室数：
										<asp:Label ID="KOUSHI_ROOM_CNT" runat="server" Text="123"></asp:Label>
										室
									</td>
								</tr>
								<tr>
									<td>
										世話人会
									</td>
									<td align="center">
										<asp:Label ID="MANAGER_KAIJO_TEHAI_Yes" runat="server" Text="○"></asp:Label>
									</td>
									<td align="center">
										<asp:Label ID="MANAGER_KAIJO_TEHAI_No" runat="server" Text="●"></asp:Label>
									</td>
									<td align="center">
										<asp:Label ID="MANAGER_KAIJO_TIME1" runat="server" Text="12:34"></asp:Label>
									</td>
									<td align="center">
										<asp:Label ID="MANAGER_KAIJO_TIME2" runat="server" Text="12:34"></asp:Label>
									</td>
									<td>
										&nbsp;
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
				<table style="border-collapse: collapse;" cellspacing="0" cellpadding="2" border="1" bordercolor="#4f5b61">
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitle" colspan="8">
							■ 回答
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitle" rowspan="2">
							会場回答
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="7">
							都道府県：
							<asp:DropDownList ID="ADDRESS1" runat="server" Width="120px"></asp:DropDownList>
							&nbsp;&nbsp;&nbsp;
							市区町村：
							<asp:TextBox ID="ADDRESS2" runat="server" Text="◎◎◎◎◎◎◎◎◎◎"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
							施設名：
							<asp:TextBox ID="FIX_KAISAI_SHISETSU" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎" Width="300px"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
							<asp:Button ID="BtnHotelKensaku" runat="server" Text="検索" Width="50px" CssClass="ButtonList" />
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="7">
							会場住所：
							<asp:TextBox ID="ADDRESS" runat="server" Text="◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎●" Width="550px" ReadOnly="true" TabIndex="-1" CssClass="disp"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
							会場TEL：
							<asp:TextBox ID="KAIJO_TEL" runat="server" Text="0000-0000-0000" Width="130px" ReadOnly="true" TabIndex="-1" CssClass="disp"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
							会場URL：
							<asp:TextBox ID="KAIJO_URL" runat="server" Text="http://WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW@" Width="500px" ReadOnly="true" TabIndex="-1" CssClass="disp"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitle">
							非課税額
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:TextBox ID="FIX_SEISAN_TF" runat="server" Text="1234567890" Width="100px"></asp:TextBox>
							円
							&nbsp;&nbsp;&nbsp;
						</td>
						<td nowrap="nowrap" align="left" class="TdTitle">
							課税1額 (社外)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:TextBox ID="FIX_SEISAN_GTAX" runat="server" Text="1234567890" Width="100px"></asp:TextBox>
							円
							&nbsp;&nbsp;&nbsp;
						</td>
						<td nowrap="nowrap" align="left" class="TdTitle">
							課税2額 (社内)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:TextBox ID="FIX_SEISAN_NTAX" runat="server" Text="1234567890" Width="100px"></asp:TextBox>
							円
							&nbsp;&nbsp;&nbsp;
						</td>
						<td nowrap="nowrap" align="left" class="TdTitle">
							利用額計
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:TextBox ID="FIX_TOTAL" runat="server" Text="1234567890" Width="100px"></asp:TextBox>
							円
						</td>
					</tr>
				</table>
			</td>
		</tr>
		<tr>
			<td nowrap="nowrap" align="left">
				<div class="FontSize1" style="height: 10px;"></div>
				<table cellspacing="0" cellpadding="0" border="0" class="style3">
					<tr style="height: 36px; width: 100%;">
						<td nowrap="nowrap" align="left" style="width: 50%;">
							<asp:Button ID="BtnRireki" runat="server" Width="150px" Text="履歴表示" CssClass="Button" />
							<asp:Button ID="BtnPrint" runat="server" Width="150px" Text="手配書印刷" CssClass="Button" />
						</td>
						<td nowrap="nowrap" align="right" style="width: 50%;">
							<asp:Button ID="BtnNozomi" runat="server" Width="150px" Text="NOZOMIへ" CssClass="Button" />
							<asp:Button ID="BtnCancel" runat="server" Width="150px" Text="キャンセル" CssClass="ButtonCancel" />
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
</asp:Content>
