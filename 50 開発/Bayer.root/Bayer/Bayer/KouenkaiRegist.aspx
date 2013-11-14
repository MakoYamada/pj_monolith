<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="KouenkaiRegist.aspx.vb" Inherits="Bayer.KouenkaiRegist" MaintainScrollPositionOnPostback="true" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table border="0" cellpadding="4" cellspacing="0" width="1100px">
        <tr>
            <td>
                <table cellpadding="2" cellspacing="0" border="0" width="900px">
                    <tr>
                        <td style="width:50%">
                        </td>
                        <td style="width:50%" align="right">
                            <asp:Button ID="BtnBack1" runat="server" Text="戻る" Width="130px" 
                                CssClass="Button" TabIndex="1" />
                        </td>
                    </tr>
                </table> 
            </td>
        </tr>
		<tr>
			<td nowrap="nowrap" align="left">
				<table style="border-collapse: collapse;" cellspacing="0" cellpadding="2" border="1" bordercolor="#4f5b61" width="1100px">
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							講演会番号
						</td>
						<td nowrap="nowrap" align="left" style="width: 100px;">
							<asp:Label ID="KOUENKAI_NO" runat="server" Text=""></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 120px;">
							新着ステータス
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:DropDownList ID="KIDOKU_FLG" runat="server" Width="100px" TabIndex="2"></asp:DropDownList>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 90px;">
							ステータス
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="TORIKESHI_FLG" runat="server" Text=""></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 90px;">
							TimeStamp(BYL)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="3">
							<asp:Label ID="TIME_STAMP" runat="server" Text=""></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							講演会名
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="5">
						    <asp:TextBox ID="KOUENKAI_NAME" runat="server" BorderStyle="None" Height="35px" 
                                ReadOnly="True" TextMode="MultiLine" Width="624px"></asp:TextBox>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							チケット印字名
							<br />
							(10文字)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" style="width: 95px;">
							<asp:Label ID="TAXI_PRT_NAME" runat="server" Text=""></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 90px;">
							講演会開催日
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="7">
							<asp:Label ID="FROM_DATE" runat="server" Text=""></asp:Label>
							&nbsp;&nbsp;～&nbsp;&nbsp;
							<asp:Label ID="TO_DATE" runat="server" Text=""></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							講演会会場名
						</td>
						<td nowrap="nowrap" align="left" colspan="7">
                            <asp:TextBox ID="KAIJO_NAME" runat="server" BorderStyle="None" Height="35px" 
                                ReadOnly="True" TextMode="MultiLine" Width="624px"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							製品名
						</td>
						<td nowrap="nowrap" align="left" colspan="7">
							<asp:Label ID="SEIHIN_NAME" runat="server" Text=""></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 120px;">
							Internal Order<br />(課税)
						</td>
						<td nowrap="nowrap" align="left">
							<asp:Label ID="INTERNAL_ORDER_T" runat="server" Text=""></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 120px;">
							Internal Order<br />(非課税)
						</td>
						<td nowrap="nowrap" align="left">
							<asp:Label ID="INTERNAL_ORDER_TF" runat="server" Text=""></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 120px;">
							アカウントコード<br />(課税)
						</td>
						<td nowrap="nowrap" align="left">
							<asp:Label ID="ACCOUNT_CD_T" runat="server" Text=""></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 120px;">
							アカウントコード<br />(非課税)
						</td>
						<td nowrap="nowrap" align="left">
							<asp:Label ID="ACCOUNT_CD_TF" runat="server" Text=""></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							zetia Code
						</td>
						<td nowrap="nowrap" align="left">
							<asp:Label ID="ZETIA_CD" runat="server" Text=""></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							参加人数(従業員)
						</td>
						<td nowrap="nowrap" align="left">
							<asp:Label ID="SANKA_YOTEI_CNT_MBR" runat="server" Text=""></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							参加人数(従業員以外)
						</td>
						<td nowrap="nowrap" align="left" colspan="3">
							<asp:Label ID="SANKA_YOTEI_CNT_NMBR" runat="server" Text=""></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							TOP担当者
						</td>
						<td nowrap="nowrap" align="left" colspan="7">
                            <asp:DropDownList ID="TTEHAI_TANTO" runat="server" TabIndex="3">
                            </asp:DropDownList>
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
							事業部
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="7">
							<asp:Label ID="KIKAKU_TANTO_JIGYOUBU" runat="server" Text=""></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							BU
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="BU" runat="server" Text=""></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							エリア
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="3">
                            <asp:TextBox ID="KIKAKU_TANTO_AREA" runat="server" MaxLength="80" ReadOnly="true" 
                                TextMode="MultiLine" Height="35px" Width="418px" TabIndex="250" 
                                BorderStyle="None"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							営業所
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
                            <asp:TextBox ID="KIKAKU_TANTO_EIGYOSHO" runat="server" MaxLength="80" ReadOnly="true" 
                                TextMode="MultiLine" Height="35px" Width="418px" TabIndex="250" 
                                BorderStyle="None"></asp:TextBox>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							Cost Center
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="3">
							<asp:Label ID="COST_CENTER" runat="server" Text=""></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							氏名
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
                            <asp:TextBox ID="KIKAKU_TANTO_NAME" runat="server" MaxLength="150" ReadOnly="true" 
                                TextMode="MultiLine" Height="35px" Width="417px" TabIndex="250" 
                                BorderStyle="None"></asp:TextBox>                            
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							氏名<br />(ローマ字)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="5">
                            <asp:TextBox ID="KIKAKU_TANTO_ROMA" runat="server" MaxLength="150" ReadOnly="true" 
                                TextMode="MultiLine" Height="35px" Width="417px" TabIndex="250" 
                                BorderStyle="None"></asp:TextBox>                            
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							オフィスの電話番号
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="KIKAKU_TANTO_TEL" runat="server" Text=""></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							携帯電話
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="KIKAKU_TANTO_KEITAI" runat="server" Text=""></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 105px;">
							メールアドレス
						</td>
						<td align="left" class="TdItem" colspan="5">
                            <asp:TextBox ID="KIKAKU_TANTO_EMAIL" runat="server" MaxLength="128" ReadOnly="true" 
                                TextMode="MultiLine" Height="35px" Width="903px" TabIndex="250" 
                                BorderStyle="None"></asp:TextBox>                            
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 105px;">
							携帯のメールアドレス
						</td>
						<td align="left" class="TdItem" colspan="5">
                            <asp:TextBox ID="KIKAKU_TANTO_EMAIL_KEITAI" runat="server" MaxLength="128" ReadOnly="true" 
                                TextMode="MultiLine" Height="35px" Width="903px" TabIndex="250" 
                                BorderStyle="None"></asp:TextBox>                            
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
							■ 概算
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							予算額(非課税)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" style="width: 200px;">
							<asp:Label ID="YOSAN_TF" runat="server" Text=""></asp:Label>
							円

						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							予算額(課税)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="5">
							<asp:Label ID="YOSAN_T" runat="server" Text=""></asp:Label>
							円
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							慰労会予算(課税)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" style="width: 200px;">
							<asp:Label ID="IROUKAI_YOSAN_T" runat="server" Text=""></asp:Label>
							円

						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							意見交換会予算(課税)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="5">
							<asp:Label ID="IKENKOUKAN_YOSAN_T" runat="server" Text=""></asp:Label>
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
				            <asp:Button ID="BtnRireki" runat="server" Width="150px" Text="履歴表示" CssClass="Button" TabIndex="4" />
				        </td>
				        <td align="right" style="width:70%">
				            <asp:Button ID="BtnSubmit" runat="server" Width="150px" Text="登録" 
                                CssClass="Button" TabIndex="5" />
				            <!-- <asp:Button ID="BtnNozomi" runat="server" Width="150px" Text="NOZOMIへ" 
                                CssClass="Button" /> -->
					        <asp:Button ID="BtnBack2" runat="server" Width="150px" Text="戻る" CssClass="Button" TabIndex="6" />
				        </td>
			        </tr>
		        </table>
			</td>
		</tr>
	</table>
</asp:Content>
