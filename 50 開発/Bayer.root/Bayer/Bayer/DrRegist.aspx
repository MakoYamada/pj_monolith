<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="DrRegist.aspx.vb" Inherits="Bayer.DrRegist" MaintainScrollPositionOnPostback="true" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table border="0" cellpadding="4" cellspacing="0" style="width:900px">
		<tr>
			<td align="left" colspan="2">
			    <!-- 講演会情報 -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="8">
                            ■講演会情報
	                        <asp:Button ID="BtnKihon" runat="server" Width="150px" Text="基本情報へ" 
                                CssClass="Button" TabIndex="1" />
                        </td>
                    </tr>
                    <tr>
						<td align="left" class="TdTitleHeader" style="width:120px">
							講演会番号
						</td>
						<td align="left" class="TdItem" style="width:100px">
							<asp:Label ID="KOUENKAI_NO" runat="server"></asp:Label>
						</td>
						<td align="left" class="TdTitleHeader" style="width:100px">
							実施日
						</td>
                        <td align="left" class="TdItem">
							<asp:Label ID="FROM_DATE" runat="server"></asp:Label>
							～
							<asp:Label ID="TO_DATE" runat="server"></asp:Label>
                        </td>
						<td align="left" class="TdTitleHeader" style="width:100px">
							TimeStamp
						</td>
                        <td align="left" class="TdItem" colspan="3">
							<asp:Label ID="TIME_STAMP" runat="server"></asp:Label>
                        </td>
                    </tr>
					<tr>
						<td align="left" class="TdTitleHeader" style="width:120px">
							講演会名
						</td>
						<td align="left" class="TdItem" colspan="5">
                            <asp:TextBox ID="KOUENKAI_NAME" runat="server" MaxLength="80" ReadOnly="True" 
                                TextMode="MultiLine" Height="45px" Width="427px" TabIndex="6" 
                                BorderStyle="None"></asp:TextBox>
						</td>
						<td align="left" class="TdTitleHeader">
							チケット印字名
						</td>
						<td align="left" class="TdItem">
							<asp:Label ID="TAXI_PRT_NAME" runat="server" Text=""></asp:Label>
						</td>
					</tr>
				</table>
			</td>
		</tr>

		<tr>
		    <td align="left" colspan="2">
				<!-- DR担当MR -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="9">
                            ■DR担当MR
                        </td>
                    </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                BU
		                </td>
		                <td align="left" valign="top" colspan="7">
				            <asp:Label ID="MR_BU" runat="server" Text=""></asp:Label>
		                </td>
		            </tr>
		            <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                エリア
		                </td>
		                <td align="left" valign="top" colspan="2">
				            <asp:Label ID="MR_AREA" runat="server" Text=""></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                営業所
		                </td>
		                <td align="left" valign="top" colspan="5">
				            <asp:Label ID="MR_EIGYOSHO" runat="server" Text=""></asp:Label>
		                </td>
		            </tr>
		            <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                Account Code
		                </td>
		                <td align="left" valign="middle">
				            <asp:Label ID="ACCOUNT_CODE" runat="server" Text=""></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                Cost Center
		                </td>
		                <td align="left" valign="middle">
				            <asp:Label ID="COST_CENTER" runat="server" Text=""></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                Internal Order
		                </td>
		                <td align="left" valign="middle">
				            <asp:Label ID="INTERNAL_ORDER" runat="server" Text=""></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                zetia Code
		                </td>
		                <td align="left" valign="middle">
				            <asp:Label ID="ZETIA_CD" runat="server" Text=""></asp:Label>
		                </td>
		            </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
                            氏名
                        </td>
                        <td align="left" valign="top" colspan="7">
                            <asp:TextBox ID="MR_NAME" runat="server" MaxLength="150" ReadOnly="True" 
                                TextMode="MultiLine" Height="45px" Width="750px" TabIndex="6" 
                                BorderStyle="None"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
                            氏名<br />（ローマ字）
                        </td>
                        <td align="left" valign="top" colspan="7">
                            <asp:TextBox ID="MR_ROMA" runat="server" MaxLength="150" ReadOnly="True" 
                                TextMode="MultiLine" Height="45px" Width="750px" TabIndex="6" 
                                BorderStyle="None"></asp:TextBox>
                        </td>
                    </tr>
		            <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                携帯電話番号
		                </td>
		                <td align="left" valign="middle" colspan="2">
				            <asp:Label ID="MR_KEITAI" runat="server" Text=""></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                オフィスの電話番号
		                </td>
		                <td align="left" valign="middle" colspan="5">
				            <asp:Label ID="MR_TEL" runat="server" Text=""></asp:Label>
		                </td>
		            </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
                            携帯Email<br />アドレス
                        </td>
                        <td align="left" valign="top" colspan="8">
                            <asp:TextBox ID="MR_EMAIL_KEITAI" runat="server" MaxLength="128" ReadOnly="True" 
                                TextMode="MultiLine" Height="45px" Width="750px" TabIndex="6" 
                                BorderStyle="None"></asp:TextBox>
                        </td>
	                </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:170px" 
                            width="170">
                            Email<br />アドレス
                        </td>
                        <td align="left" valign="top" colspan="8">
                            <asp:TextBox ID="MR_EMAIL_PC" runat="server" MaxLength="128" ReadOnly="True" 
                                TextMode="MultiLine" Height="45px" Width="750px" TabIndex="6" 
                                BorderStyle="None"></asp:TextBox>
                        </td>
	                </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
                            チケット<br />送付先
                        </td>
                        <td align="left" valign="top" colspan="8">
                            <table border="0" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td align="left" valign="top">
                                        FS名：
                                    </td>
                                    <td align="left" valign="top">
            				            <asp:Label ID="MR_SEND_SAKI_FS" runat="server" Text=""></asp:Label>                                    
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" valign="top" style="width:100px">
                                        その他送付先：
                                    </td>
                                    <td align="left" valign="top">
                                        <asp:TextBox ID="MR_SEND_SAKI_OTHER" runat="server" MaxLength="128" ReadOnly="True" 
                                            TextMode="MultiLine" Height="45px" Width="650px" TabIndex="6" 
                                            BorderStyle="None"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
	                </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr>
		    <td align="left"  colspan="2">
				<!-- DR情報 -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="8">
                            ■DR情報
                        </td>
                    </tr>
		            <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                手配<br />ステータス
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="REQ_STATUS_TEHAI" runat="server" Text=""></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitle" style="width:100px">
			                回答<br />ステータス
		                </td>
		                <td align="left" valign="middle">							
		                    <asp:DropDownList ID="ANS_STATUS_TEHAI" runat="server" Width="150px" 
                                TabIndex="2">
                            </asp:DropDownList>						
		                </td>
		                <td align="left" valign="middle" class="TdTitle" style="width:100px">
			                チケット類<br />発送日<br />（最新）
		                </td>
		                <td align="left" valign="middle" colspan="3">							
                            <asp:TextBox ID="ANS_TICKET_SEND_DAY" runat="server" MaxLength="8" 
                                Height="18px" Width="79px" TabIndex="3"></asp:TextBox>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                参加者ID
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="SANKASHA_ID" runat="server" Text=""></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                DRコード
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_CD" runat="server" Text=""></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                TimeStamp(BYL)
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="TIME_STAMP_BYL" runat="server"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                TimeStamp(TOP)
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="TIME_STAMP_TOP" runat="server"></asp:Label>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                氏名
		                </td>
		                <td align="left" valign="middle" colspan="3">
                            <asp:TextBox ID="DR_NAME" runat="server" MaxLength="80" ReadOnly="True" 
                                TextMode="MultiLine" Height="47px" Width="341px" TabIndex="5" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                氏名カナ
		                </td>
		                <td align="left" valign="middle" colspan="3">
                            <asp:TextBox ID="DR_KANA" runat="server" MaxLength="80" ReadOnly="True" 
                                TextMode="MultiLine" Height="47px" Width="341px" TabIndex="23" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                性別
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_SEX" runat="server"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                年齢
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_AGE" runat="server"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                講演会への参加
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_SANKA" runat="server"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                参加者の役割
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_YAKUWARI" runat="server"></asp:Label>
		                </td>
		            </tr> 
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                DCF<br />施設コード
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_SHISETSU_CD" runat="server"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                施設名
		                </td>
		                <td align="left" valign="middle" colspan="5">
                            <asp:TextBox ID="DR_SHISETSU_NAME" runat="server" MaxLength="80" ReadOnly="True" 
                                TextMode="MultiLine" Height="47px" Width="341px" TabIndex="23" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                施設住所
		                </td>
		                <td align="left" valign="middle" colspan="7">
                            <asp:TextBox ID="DR_SHISETSU_ADDRESS" runat="server" MaxLength="128" ReadOnly="True" 
                                TextMode="MultiLine" Height="47px" Width="750px" TabIndex="5" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                指定外<br />申請理由			                
		                </td>
		                <td align="left" valign="middle" colspan="7">
                            <asp:TextBox ID="SHITEIGAI_RIYU" runat="server" MaxLength="128" ReadOnly="True" 
                                TextMode="MultiLine" Height="47px" Width="750px" TabIndex="5" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		            </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr>
		    <td align="left"  colspan="2">
				<!-- 承認者情報 -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ■承認者情報
                        </td>
                    </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                最終承認者
		                </td>
		                <td align="left" valign="top">
                            <asp:TextBox ID="SHONIN_NAME" runat="server" MaxLength="80" ReadOnly="True" 
                                TextMode="MultiLine" Height="18px" Width="388px" TabIndex="10" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                最終承認日時
		                </td>
		                <td align="left" valign="top">
							<asp:Label ID="SHONIN_DATE" runat="server"></asp:Label>
		                </td>
		            </tr>
                </table> 		        
		    </td>		    
		</tr>

		<tr>
			<td align="left" colspan="2">
				<table border="0" cellpadding="1" cellspacing="0" id="TblMust" runat="server">
					<tr>
						<td align="left" style="font-weight: bold;">
							<span class="Must">※</span>
							は入力必須項目です。

						</td>
					</tr>
				</table>
		    </td>
		</tr>

		<tr>
		    <td align="left"  colspan="2">
				<!-- 宿泊手配 -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="8">
                            ■宿泊手配
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            宿泊依頼
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TEHAI_HOTEL" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_STATUS_HOTEL" runat="server" TabIndex="4">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="HOTEL_IRAINAIYOU" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            施設名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_HOTEL_NAME" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="47px" Width="267px" TabIndex="5"></asp:TextBox>
            				<asp:Button ID="BtnHotelKensaku" runat="server" Width="55px" Text="検索" 
                                CssClass="ButtonList" TabIndex="16" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            宿泊日
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_HOTEL_DATE" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            泊数
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_HAKUSU" runat="server"></asp:Label>
							&nbsp;&nbsp;泊
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            施設住所
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_HOTEL_ADDRESS" runat="server" MaxLength="128" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="6"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            喫煙
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_HOTEL_SMOKING" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            施設TEL
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_HOTEL_TEL" runat="server" MaxLength="20" 
                                Height="18px" Width="173px" TabIndex="7"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px" rowspan="5">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3" rowspan="5">
                            <asp:TextBox ID="REQ_HOTEL_NOTE" runat="server" MaxLength="255" 
                                readonly="true" textmode="MultiLine" Height="143px" Width="321px" 
                                TabIndex="29" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            宿泊日
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_HOTEL_DATE" runat="server" MaxLength="6" 
                                Height="18px" Width="67px" TabIndex="8"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            泊数
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_HAKUSU" runat="server" MaxLength="2" 
                                Height="18px" Width="26px" TabIndex="9"></asp:TextBox>
							&nbsp;&nbsp;泊                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            チェックイン
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_CHECKIN_TIME" runat="server" MaxLength="4" 
                                Height="18px" Width="47px" TabIndex="10"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            チェックアウト
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_CHECKOUT_TIME" runat="server" MaxLength="4" 
                                Height="18px" Width="47px" TabIndex="11"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            部屋タイプ
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_ROOM_TYPE" runat="server" TabIndex="12" Width="344px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            喫煙
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_HOTEL_SMOKING" runat="server" TabIndex="13" 
                                Width="344px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3" width="344px">							
                            <asp:TextBox ID="ANS_HOTEL_NOTE" runat="server" MaxLength="255" 
                                textmode="MultiLine" Height="65px" Width="347px" TabIndex="14"></asp:TextBox>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		
		<tr>
			<td align="left" colspan="2">
				<!-- 交通（往路１）タイトル -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
							<asp:ImageButton ID="BtnKOTSU_O_1" runat="server" Height="20px" 
                                ImageUrl="~/Images/button-tick-alt.png" Width="19px" />■交通（往路１）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TEHAI_1" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_O_STATUS_1" runat="server" TabIndex="15">
                            </asp:DropDownList>							
                        </td>
					</tr>
				</table>
		    </td>
		</tr>

		<tr runat="server" id="TB_KOTSU_O_1">
		    <td align="left"  colspan="2">
				<!-- 交通（往路１）手配 -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
            				<asp:Button ID="BtnCopy_O_TEHAI_1" runat="server" Width="55px" Text="コピー" 
                                CssClass="ButtonList" TabIndex="16" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="7">
							<asp:Label ID="REQ_O_IRAINAIYOU_1" runat="server" ></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_KOTSUKIKAN_1" runat="server" Text=""></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_O_KOTSUKIKAN_1" runat="server" TabIndex="17">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_DATE_1" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_DATE_1" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="18"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_AIRPORT1_1" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                TabIndex="30" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_O_AIRPORT2_1" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                TabIndex="31" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT1_1" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="19px" Width="148px" TabIndex="19"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT2_1" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="19px" Width="148px" TabIndex="20"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TIME1_1" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_TIME2_1" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME1_1" runat="server" MaxLength="4" 
                                Height="18px" Width="148px" TabIndex="21"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME2_1" runat="server" MaxLength="4" 
                                Height="18px" Width="148px" TabIndex="22"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_O_BIN_1" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                TabIndex="31" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_BIN_1" runat="server" MaxLength="100" 
                                TextMode="MultiLine" Height="19px" Width="344px" TabIndex="23" 
                                ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_SEAT_1" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_SEAT_KIBOU1" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_1" runat="server" TabIndex="24">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_KIBOU1" runat="server" TabIndex="25">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		
		<tr>
			<td align="left" colspan="2">
				<!-- 交通（往路２）タイトル -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
							<asp:ImageButton ID="BtnKOTSU_O_2" runat="server" Height="20px" 
                                ImageUrl="~/Images/button-tick-alt.png" Width="19px" />■交通（往路２）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TEHAI_2" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_O_STATUS_2" runat="server" TabIndex="26">
                            </asp:DropDownList>							
                        </td>
					</tr>
				</table>
		    </td>
		</tr>

		<tr runat="server" id="TB_KOTSU_O_2">
		    <td align="left"  colspan="2">
				<!-- 交通（往路２）手配 -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
            				<asp:Button ID="BtnCopy_O_TEHAI_2" runat="server" Width="55px" Text="コピー" 
                                CssClass="ButtonList" TabIndex="27" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="7">
							<asp:Label ID="REQ_O_IRAINAIYOU_2" runat="server" ></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_KOTSUKIKAN_2" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_O_KOTSUKIKAN_2" runat="server" TabIndex="28">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_DATE_2" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_DATE_2" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="29"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_AIRPORT1_2" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                TabIndex="30" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_O_AIRPORT2_2" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                TabIndex="31" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT1_2" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="19px" Width="148px" TabIndex="30"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT2_2" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="19px" Width="148px" TabIndex="31"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TIME1_2" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_TIME2_2" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME1_2" runat="server" MaxLength="4" 
                                Height="18px" Width="148px" TabIndex="32"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME2_2" runat="server" MaxLength="4" 
                                Height="18px" Width="148px" TabIndex="33"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_O_BIN_2" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                TabIndex="31" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_BIN_2" runat="server" MaxLength="100" 
                                TextMode="MultiLine" Height="19px" Width="344px" TabIndex="34"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_SEAT_2" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_SEAT_KIBOU2" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_2" runat="server" TabIndex="35">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_KIBOU2" runat="server" TabIndex="36">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		
		<tr>
			<td align="left" colspan="2">
				<!-- 交通（往路３）タイトル -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
							<asp:ImageButton ID="BtnKOTSU_O_3" runat="server" Height="20px" 
                                ImageUrl="~/Images/button-tick-alt.png" Width="19px" />■交通（往路３）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TEHAI_3" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_O_STATUS_3" runat="server" TabIndex="37">
                            </asp:DropDownList>							
                        </td>
					</tr>
				</table>
		    </td>
		</tr>

		<tr runat="server" id="TB_KOTSU_O_3">
		    <td align="left"  colspan="2">
				<!-- 交通（往路３）手配 -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
            				<asp:Button ID="BtnCopy_O_TEHAI_3" runat="server" Width="55px" Text="コピー" 
                                CssClass="ButtonList" TabIndex="38" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="7">
							<asp:Label ID="REQ_O_IRAINAIYOU_3" runat="server" ></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_KOTSUKIKAN_3" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_O_KOTSUKIKAN_3" runat="server" TabIndex="39">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_DATE_3" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_DATE_3" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="40"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_AIRPORT1_3" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                TabIndex="30" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_O_AIRPORT2_3" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                TabIndex="31" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT1_3" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="19px" Width="148px" TabIndex="41"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT2_3" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="19px" Width="148px" TabIndex="42"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TIME1_3" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_TIME2_3" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME1_3" runat="server" MaxLength="4" 
                                Height="18px" Width="148px" TabIndex="36"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME2_3" runat="server" MaxLength="4" 
                                Height="18px" Width="148px" TabIndex="43"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_O_BIN_3" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                TabIndex="31" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_BIN_3" runat="server" MaxLength="100" 
                                TextMode="MultiLine" Height="19px" Width="344px" TabIndex="44"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_SEAT_3" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_SEAT_KIBOU3" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_3" runat="server" TabIndex="45">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_KIBOU3" runat="server" TabIndex="46">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		
		<tr>
			<td align="left" colspan="2">
				<!-- 交通（往路４）タイトル -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
							<asp:ImageButton ID="BtnKOTSU_O_4" runat="server" Height="20px" 
                                ImageUrl="~/Images/button-tick-alt.png" Width="19px" />■交通（往路４）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TEHAI_4" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_O_STATUS_4" runat="server" TabIndex="47">
                            </asp:DropDownList>							
                        </td>
					</tr>
				</table>
		    </td>
		</tr>

		<tr runat="server" id="TB_KOTSU_O_4">
		    <td align="left"  colspan="2">
				<!-- 交通（往路４）手配 -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
            				<asp:Button ID="BtnCopy_O_TEHAI_4" runat="server" Width="55px" Text="コピー" 
                                CssClass="ButtonList" TabIndex="48" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="7">
							<asp:Label ID="REQ_O_IRAINAIYOU_4" runat="server" ></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_KOTSUKIKAN_4" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_O_KOTSUKIKAN_4" runat="server" TabIndex="49">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_DATE_4" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_DATE_4" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="49"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_AIRPORT1_4" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                TabIndex="30" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_O_AIRPORT2_4" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                TabIndex="31" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT1_4" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="19px" Width="148px" TabIndex="50"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT2_4" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="19px" Width="148px" TabIndex="51"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TIME1_4" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_TIME2_4" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME1_4" runat="server" MaxLength="4" 
                                Height="18px" Width="148px" TabIndex="53"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME2_4" runat="server" MaxLength="4" 
                                Height="18px" Width="148px" TabIndex="37"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_O_BIN_4" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                TabIndex="31" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_BIN_4" runat="server" MaxLength="100" 
                                TextMode="MultiLine" Height="19px" Width="344px" TabIndex="54"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_SEAT_4" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_SEAT_KIBOU4" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_4" runat="server" TabIndex="55">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_KIBOU4" runat="server" TabIndex="56">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		
		<tr>
			<td align="left" colspan="2">
				<!-- 交通（往路５）タイトル -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
							<asp:ImageButton ID="BtnKOTSU_O_5" runat="server" Height="20px" 
                                ImageUrl="~/Images/button-tick-alt.png" Width="19px" />■交通（往路５）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TEHAI_5" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_O_STATUS_5" runat="server" TabIndex="57">
                            </asp:DropDownList>							
                        </td>
					</tr>
				</table>
		    </td>
		</tr>

		<tr runat="server" id="TB_KOTSU_O_5">
		    <td align="left"  colspan="2">
				<!-- 交通（往路５）手配 -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
            				<asp:Button ID="BtnCopy_O_TEHAI_5" runat="server" Width="55px" Text="コピー" 
                                CssClass="ButtonList" TabIndex="58" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="7">
							<asp:Label ID="REQ_O_IRAINAIYOU_5" runat="server" ></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_KOTSUKIKAN_5" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_O_KOTSUKIKAN_5" runat="server" TabIndex="59">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_DATE_5" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_DATE_5" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="60"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_AIRPORT1_5" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                TabIndex="30" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_O_AIRPORT2_5" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                TabIndex="31" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT1_5" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="19px" Width="148px" TabIndex="61"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT2_5" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="19px" Width="148px" TabIndex="62"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TIME1_5" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_TIME2_5" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME1_5" runat="server" MaxLength="4" 
                                Height="18px" Width="148px" TabIndex="63"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME2_5" runat="server" MaxLength="4" 
                                Height="18px" Width="148px" TabIndex="64"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_O_BIN_5" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                TabIndex="31" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_BIN_5" runat="server" MaxLength="100" 
                                TextMode="MultiLine" Height="19px" Width="344px" TabIndex="65"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_SEAT_5" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_SEAT_KIBOU5" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_5" runat="server" TabIndex="66">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_KIBOU5" runat="server" TabIndex="67">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>		
		
		<tr>
			<td align="left" colspan="2">
				<!-- 交通（復路１）タイトル -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
							<asp:ImageButton ID="BtnKOTSU_F_1" runat="server" Height="20px" 
                                ImageUrl="~/Images/button-tick-alt.png" Width="19px" />■交通（復路１）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TEHAI_1" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_F_STATUS_1" runat="server" TabIndex="68">
                            </asp:DropDownList>							
                        </td>
					</tr>
				</table>
		    </td>
		</tr>

		<tr runat="server" id="TB_KOTSU_F_1">
		    <td align="left"  colspan="2">
				<!-- 交通（復路１）手配 -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
            				<asp:Button ID="BtnCopy_F_TEHAI_1" runat="server" Width="55px" Text="コピー" 
                                CssClass="ButtonList" TabIndex="69" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="7">
							<asp:Label ID="REQ_F_IRAINAIYOU_1" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_KOTSUKIKAN_1" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_F_KOTSUKIKAN_1" runat="server" TabIndex="33">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_DATE_1" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_DATE_1" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="70"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_F_AIRPORT1_1" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                TabIndex="30" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_F_AIRPORT2_1" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                TabIndex="31" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT1_1" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="19px" Width="148px" TabIndex="71"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT2_1" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="19px" Width="148px" TabIndex="72"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TIME1_1" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_TIME2_1" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME1_1" runat="server" MaxLength="4" 
                                Height="18px" Width="148px" TabIndex="73"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME2_1" runat="server" MaxLength="4" 
                                Height="18px" Width="148px" TabIndex="74"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_F_BIN_1" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                TabIndex="31" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_BIN_1" runat="server" MaxLength="100" 
                                TextMode="MultiLine" Height="19px" Width="344px" TabIndex="75"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_SEAT_1" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_SEAT_KIBOU1" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_1" runat="server" TabIndex="76">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_KIBOU1" runat="server" TabIndex="77">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		
		<tr>
			<td align="left" colspan="2">
				<!-- 交通（復路２）タイトル -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
							<asp:ImageButton ID="BtnKOTSU_F_2" runat="server" Height="20px" 
                                ImageUrl="~/Images/button-tick-alt.png" Width="19px" />■交通（復路２）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TEHAI_2" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_F_STATUS_2" runat="server" TabIndex="78">
                            </asp:DropDownList>							
                        </td>
					</tr>
				</table>
		    </td>
		</tr>

		<tr runat="server" id="TB_KOTSU_F_2">
		    <td align="left"  colspan="2">
				<!-- 交通（復路２）手配 -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
            				<asp:Button ID="BtnCopy_F_TEHAI_2" runat="server" Width="55px" Text="コピー" 
                                CssClass="ButtonList" TabIndex="79" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="7">
							<asp:Label ID="REQ_F_IRAINAIYOU_2" runat="server" ></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_KOTSUKIKAN_2" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_F_KOTSUKIKAN_2" runat="server" TabIndex="80">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_DATE_2" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_DATE_2" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="81"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_F_AIRPORT1_2" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                TabIndex="30" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_F_AIRPORT2_2" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                TabIndex="31" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT1_2" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="19px" Width="148px" TabIndex="82"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT2_2" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="19px" Width="148px" TabIndex="83"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TIME1_2" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_TIME2_2" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME1_2" runat="server" MaxLength="4" 
                                Height="18px" Width="148px" TabIndex="84"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME2_2" runat="server" MaxLength="4" 
                                Height="18px" Width="148px" TabIndex="85"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_F_BIN_2" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                TabIndex="31" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_BIN_2" runat="server" MaxLength="100" 
                                TextMode="MultiLine" Height="19px" Width="344px" TabIndex="86"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_SEAT_2" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_SEAT_KIBOU2" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_2" runat="server" TabIndex="87">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_KIBOU2" runat="server" TabIndex="88">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		
		<tr>
			<td align="left" colspan="2">
				<!-- 交通（復路３）タイトル -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
							<asp:ImageButton ID="BtnKOTSU_F_3" runat="server" Height="20px" 
                                ImageUrl="~/Images/button-tick-alt.png" Width="19px" />■交通（復路３）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TEHAI_3" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_F_STATUS_3" runat="server" TabIndex="89">
                            </asp:DropDownList>							
                        </td>
					</tr>
				</table>
		    </td>
		</tr>

		<tr runat="server" id="TB_KOTSU_F_3">
		    <td align="left"  colspan="2">
				<!-- 交通（復路３）手配 -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
            				<asp:Button ID="BtnCopy_F_TEHAI_3" runat="server" Width="55px" Text="コピー" 
                                CssClass="ButtonList" TabIndex="90" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="7">
							<asp:Label ID="REQ_F_IRAINAIYOU_3" runat="server" ></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_KOTSUKIKAN_3" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_F_KOTSUKIKAN_3" runat="server" TabIndex="91">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_DATE_3" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_DATE_3" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="92"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_F_AIRPORT1_3" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                TabIndex="30" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_F_AIRPORT2_3" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                TabIndex="31" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT1_3" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="19px" Width="148px" TabIndex="93"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT2_3" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="19px" Width="148px" TabIndex="94"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TIME1_3" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_TIME2_3" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME1_3" runat="server" MaxLength="4" 
                                Height="18px" Width="148px" TabIndex="95"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME2_3" runat="server" MaxLength="4" 
                                Height="18px" Width="148px" TabIndex="96"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_F_BIN_3" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                TabIndex="31" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_BIN_3" runat="server" MaxLength="100" 
                                TextMode="MultiLine" Height="19px" Width="344px" TabIndex="97"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_SEAT_3" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_SEAT_KIBOU3" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_3" runat="server" TabIndex="98">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_KIBOU3" runat="server" TabIndex="99">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		
		<tr>
			<td align="left" colspan="2">
				<!-- 交通（復路４）タイトル -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
							<asp:ImageButton ID="BtnKOTSU_F_4" runat="server" Height="20px" 
                                ImageUrl="~/Images/button-tick-alt.png" Width="19px" />■交通（復路４）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TEHAI_4" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_F_STATUS_4" runat="server" TabIndex="100">
                            </asp:DropDownList>							
                        </td>
					</tr>
				</table>
		    </td>
		</tr>

		<tr runat="server" id="TB_KOTSU_F_4">
		    <td align="left"  colspan="2">
				<!-- 交通（復路４）手配 -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
            				<asp:Button ID="BtnCopy_F_TEHAI_4" runat="server" Width="55px" Text="コピー" 
                                CssClass="ButtonList" TabIndex="101" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="7">
							<asp:Label ID="REQ_F_IRAINAIYOU_4" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_KOTSUKIKAN_4" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_F_KOTSUKIKAN_4" runat="server" TabIndex="102">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_DATE_4" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_DATE_4" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="103"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_F_AIRPORT1_4" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                TabIndex="30" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_F_AIRPORT2_4" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                TabIndex="31" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT1_4" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="19px" Width="148px" TabIndex="104"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT2_4" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="19px" Width="148px" TabIndex="105"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TIME1_4" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_TIME2_4" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME1_4" runat="server" MaxLength="4" 
                                Height="18px" Width="148px" TabIndex="106"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME2_4" runat="server" MaxLength="4" 
                                Height="18px" Width="148px" TabIndex="107"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_F_BIN_4" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                TabIndex="31" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_BIN_4" runat="server" MaxLength="100" 
                                TextMode="MultiLine" Height="19px" Width="344px" TabIndex="108"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_SEAT_4" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_SEAT_KIBOU4" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_4" runat="server" TabIndex="109">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_KIBOU4" runat="server" TabIndex="110">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		
		<tr>
			<td align="left" colspan="2">
				<!-- 交通（復路５）タイトル -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
							<asp:ImageButton ID="BtnKOTSU_F_5" runat="server" Height="20px" 
                                ImageUrl="~/Images/button-tick-alt.png" Width="19px" />■交通（復路５）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TEHAI_5" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_F_STATUS_5" runat="server" TabIndex="111">
                            </asp:DropDownList>							
                        </td>
					</tr>
				</table>
		    </td>
		</tr>

		<tr runat="server" id="TB_KOTSU_F_5">
		    <td align="left"  colspan="2">
				<!-- 交通（復路５）手配 -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
            				<asp:Button ID="BtnCopy_F_TEHAI_5" runat="server" Width="55px" Text="コピー" 
                                CssClass="ButtonList" TabIndex="112" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="7">
							<asp:Label ID="REQ_F_IRAINAIYOU_5" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_KOTSUKIKAN_5" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_F_KOTSUKIKAN_5" runat="server" TabIndex="113">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_DATE_5" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_DATE_5" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="114"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_F_AIRPORT1_5" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                TabIndex="30" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_F_AIRPORT2_5" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                TabIndex="31" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT1_5" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="19px" Width="148px" TabIndex="115"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT2_5" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="19px" Width="148px" TabIndex="116"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TIME1_5" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_TIME2_5" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME1_5" runat="server" MaxLength="4" 
                                Height="18px" Width="148px" TabIndex="117"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME2_5" runat="server" MaxLength="4" 
                                Height="18px" Width="148px" TabIndex="118"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_F_BIN_5" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                TabIndex="31" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_BIN_5" runat="server" MaxLength="100" 
                                TextMode="MultiLine" Height="19px" Width="344px" TabIndex="119"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_SEAT_5" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_SEAT_KIBOU5" runat="server" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_5" runat="server" TabIndex="120">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_KIBOU5" runat="server" TabIndex="121">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>		
		<tr>
			<td align="left" colspan="2">
				<!-- 交通備考 -->				
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleHeader" colspan="5">
							■交通備考
                        </td>
					</tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="top" class="TdItem">
                            <asp:TextBox ID="REQ_KOTSU_BIKO" runat="server" MaxLength="255" ReadOnly="True" 
                                TextMode="MultiLine" Height="68px" Width="445px" TabIndex="167" 
                                BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="4">
                            <asp:TextBox ID="ANS_KOTSU_BIKO" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="68px" Width="445px" TabIndex="122"></asp:TextBox>                            
                        </td>
                    </tr>
				</table>
		    </td>
		</tr>
		
		<tr>
			<td align="left" colspan="2">
				<!-- タクチケタイトル -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleHeader">
							<asp:ImageButton ID="BtnTAXI_1" runat="server" Height="20px" 
                                ImageUrl="~/Images/button-tick-alt.png" Width="19px" />■タクシーチケット手配
                        </td>
					</tr>
				</table>
		    </td>
		</tr>
		<tr runat="server" id="TB_TAXI_1">
		    <td align="left"  colspan="2">
				<!-- タクチケ手配 -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
							チケット手配
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="7">
							<asp:Label ID="TEHAI_TAXI" runat="server"></asp:Label>
                        </td>
					</tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="8">
                            ■タクチケ備考
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
            			</td>
                    </tr>
					<tr>
						<td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
							備考
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_NOTE" runat="server" MaxLength="255" 
                                ReadOnly="true" TextMode="MultiLine" Height="68px" Width="344px" 
                                TabIndex="175" BorderStyle="None"></asp:TextBox>                            
                        </td>
						<td align="left" valign="middle" class="TdTitle" style="width:170px">
							備考
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_NOTE" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="68px" Width="344px" TabIndex="123"></asp:TextBox>                            
                        </td>
					</tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ◆行程１
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット１
            				</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_1" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_DATE_1" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="124"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            発地
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_1" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="47px" Width="344px" 
                                TabIndex="178" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_KENSHU_1" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="125"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼金額
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_1" runat="server"></asp:Label>
                            &nbsp;円
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_NO_1" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="126"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ◆行程２
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット２
            				</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_2" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_DATE_2" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="127"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            発地
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_2" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="47px" Width="344px" 
                                TabIndex="178" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_KENSHU_2" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="128"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼金額
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_2" runat="server"></asp:Label>
                            &nbsp;円
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_NO_2" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="129"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ◆行程３
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット３
            				</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_3" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_DATE_3" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="130"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            発地
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_3" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="47px" Width="344px" 
                                TabIndex="178" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_KENSHU_3" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="131"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼金額
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_3" runat="server"></asp:Label>
                            &nbsp;円
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_NO_3" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="132"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ◆行程４
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット４
            				</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_4" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_DATE_4" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="133"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            発地
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_4" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="47px" Width="344px" 
                                TabIndex="178" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_KENSHU_4" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="134"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼金額
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_4" runat="server"></asp:Label>
                            &nbsp;円
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_NO_4" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="135"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ◆行程５
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット５
            				</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_5" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_DATE_5" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="136"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            発地
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_5" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="47px" Width="344px" 
                                TabIndex="178" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_KENSHU_5" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="137"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼金額
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_5" runat="server"></asp:Label>
                            &nbsp;円
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_NO_5" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="138"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ◆行程６
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット６
            				</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_6" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_DATE_6" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="139"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            発地
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_6" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="47px" Width="344px" 
                                TabIndex="178" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_KENSHU_6" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="140"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼金額
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_6" runat="server"></asp:Label>
                            &nbsp;円
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_NO_6" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="141"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ◆行程７
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット７
            				</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_7" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_DATE_7" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="142"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            発地
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_7" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="47px" Width="344px" 
                                TabIndex="178" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_KENSHU_7" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="143"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼金額
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_7" runat="server"></asp:Label>
                            &nbsp;円
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_NO_7" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="144"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ◆行程８
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット８
            				</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_8" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_DATE_8" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="145"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            発地
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_8" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="47px" Width="344px" 
                                TabIndex="178" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_KENSHU_8" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="146"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼金額
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_8" runat="server"></asp:Label>
                            &nbsp;円
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_NO_8" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="147"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ◆行程９
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット９
            				</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_9" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_DATE_9" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="148"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            発地
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_9" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="47px" Width="344px" 
                                TabIndex="178" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_KENSHU_9" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="149"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼金額
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_9" runat="server"></asp:Label>
                            &nbsp;円
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_NO_9" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="150"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ◆行程１０
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット１０
            				</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_10" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_DATE_10" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="151"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            発地
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_10" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="47px" Width="344px" 
                                TabIndex="178" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_KENSHU_10" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="152"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼金額
                        </td>
                        <td align="left" valign="top" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_10" runat="server"></asp:Label>
                            &nbsp;円
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_NO_10" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="153"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4" rowspan="40">
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット１１
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_DATE_11" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="154"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_KENSHU_11" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="155"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_NO_11" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="156"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット１２
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_DATE_12" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="157"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_KENSHU_12" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="158"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_NO_12" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="159"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット１３
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_DATE_13" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="160"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_KENSHU_13" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="161"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_NO_13" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="162"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット１４
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_DATE_14" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="163"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_KENSHU_14" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="164"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_NO_14" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="165"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット１５
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_DATE_15" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="166"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_KENSHU_15" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="167"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_NO_15" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="168"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット１６
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_DATE_16" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="169"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_KENSHU_16" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="170"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_NO_16" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="171"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット１７
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_DATE_17" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="172"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_KENSHU_17" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="173"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_NO_17" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="174"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット１８
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_DATE_18" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="175"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_KENSHU_18" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="176"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_NO_18" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="177"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット１９
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_DATE_19" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="178"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_KENSHU_19" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="179"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_NO_19" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="180"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット２０
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_DATE_20" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="181"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_KENSHU_20" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="182"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_NO_20" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="183"></asp:TextBox>                            
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>

		<tr>
			<td align="left" colspan="2">
				<!-- MR手配情報 -->				
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleHeader" colspan="8">
							■MR手配情報
                        </td>
					</tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader">
                            社員用往路隣席希望
                        </td>
                        <td align="left" valign="top" class="TdItem" colspan="3">
							<asp:Label ID="REQ_MR_O_TEHAI" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            社員用往路手配
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
		                    <asp:DropDownList ID="ANS_MR_O_TEHAI" runat="server" Width="150px" 
                                TabIndex="184">
                            </asp:DropDownList>						
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader">
                            社員用復路隣席希望
                        </td>
                        <td align="left" valign="top" class="TdItem" colspan="3">
							<asp:Label ID="REQ_MR_F_TEHAI" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            社員用復路手配
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
		                    <asp:DropDownList ID="ANS_MR_F_TEHAI" runat="server" Width="150px" 
                                TabIndex="185">
                            </asp:DropDownList>						
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader">
                            性別
                        </td>
                        <td align="left" valign="top" class="TdItem">
							<asp:Label ID="MR_SEX" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader">
                            年齢
                        </td>
                        <td align="left" valign="top" class="TdItem">
							<asp:Label ID="MR_AGE" runat="server"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="4">
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader">
                            備考
                        </td>
                        <td align="left" valign="top" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_MR_HOTEL_NOTE" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="182" 
                                BorderStyle="None" ReadOnly="True"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            備考
                        </td>
                        <td align="left" valign="top" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_MR_HOTEL_NOTE" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="186"></asp:TextBox>                            
                        </td>
                    </tr>
				</table>
		    </td>
		</tr>
		<tr>
			<td align="left" colspan="2">
				<!-- 各種代金 -->				
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleHeader" colspan="5">
							■各種代金
                        </td>
					</tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle">
                            JR券代
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_RAIL_FARE" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="187"></asp:TextBox>円                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            JR券取消料
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_RAIL_CANCELLATION" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="188"></asp:TextBox>円                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle">
                            その他鉄道代等代金
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_OTHER_FARE" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="189"></asp:TextBox>円                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            その他鉄道代等取消料
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_OTHER_CANCELLATION" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="190"></asp:TextBox>円                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle">
                            航空券代
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_AIR_FARE" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="191"></asp:TextBox>円                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            航空券取消料
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_AIR_CANCELLATION" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="192"></asp:TextBox>円                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle">
                            手数料（交通・宿泊）
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_KOTSUHOTEL_TESURYO" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="193"></asp:TextBox>円                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            タクチケ発券手数料
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_TESURYO" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="194"></asp:TextBox>円                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle">
                            MR交通費
                        </td>
                        <td align="left" valign="top" class="TdItem">
                            <asp:TextBox ID="ANS_MR_KOTSUHI" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="195"></asp:TextBox>円                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            MR宿泊費
                        </td>
                        <td align="left" valign="top" class="TdItem">
                            <asp:TextBox ID="ANS_MR_HOTELHI" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="196"></asp:TextBox>円                            
                        </td>
                    </tr>
				</table>
		    </td>
		</tr>
		    
		<div class="FontSize1" style="height: 10px;"></div>
		<table cellspacing="0" cellpadding="0" border="0" style="width:900px;">
			<tr style="height: 36px; width:100%">
				<td align="left" style="width:50%">
				    <asp:Button ID="BtnRireki" runat="server" Width="150px" Text="履歴表示" 
                        CssClass="Button" TabIndex="197" />
					<asp:Button ID="BtnPrint" runat="server" Width="150px" Text="手配書印刷" 
                        CssClass="Button" TabIndex="198" />
					<asp:Button ID="BtnTaxiCsv" runat="server" Width="150px" Text="TAXI CSV" 
                        CssClass="Button" TabIndex="199" />
				</td>
				<td align="right" style="width:50%">
				    <asp:Button ID="BtnSubmit" runat="server" Width="150px" Text="登録" 
                        CssClass="Button" TabIndex="200" />
				    <asp:Button ID="BtnNozomi" runat="server" Width="150px" Text="NOZOMIへ" 
                        CssClass="Button" TabIndex="201" />
					<asp:Button ID="BtnCancel" runat="server" Width="150px" Text="戻る" 
                        CssClass="Button" TabIndex="202" />
				</td>
			</tr>
		</table>
	</table>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">

		</asp:Content>

