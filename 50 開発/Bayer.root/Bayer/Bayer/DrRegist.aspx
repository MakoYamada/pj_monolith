<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="DrRegist.aspx.vb" Inherits="Bayer.DrRegist" MaintainScrollPositionOnPostback="true" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table border="0" cellpadding="4" cellspacing="0" style="width:900px">
			<tr style="height: 36px; width:100%">
				<td align="left" style="width:100%">
					<asp:Button ID="BtnPrint1" runat="server" Width="150px" Text="手配書印刷" 
                        CssClass="Button" TabIndex="1" />
					<asp:Button ID="BtnSoufujo1" runat="server" Width="150px" Text="送付状印刷" 
                        CssClass="Button" TabIndex="2" />
					<asp:Button ID="BtnTaxiKakunin1" runat="server" Width="150px" Text="タクチケ手配確認票印刷" 
                        CssClass="Button" TabIndex="3" />
					<asp:Button ID="BtnBack1" runat="server" Width="150px" Text="戻る" 
                        CssClass="Button" TabIndex="4" />
				    <a href="#TaxiTehaiLink" tabindex="5">タクチケ手配へ</a>
				</td>
			</tr>
		<tr>
			<td align="left" colspan="2">
			    <!-- 講演会情報 -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="8">
                            ■講演会情報
	                        <asp:Button ID="BtnKihon" runat="server" Width="150px" Text="基本情報へ" 
                                CssClass="Button" TabIndex="5" />
                        </td>
                    </tr>
                    <tr>
						<td align="left" class="TdTitleHeader" style="width:120px">
							講演会番号
						</td>
						<td align="left" class="TdItem" style="width:100px">
							<asp:Label ID="KOUENKAI_NO" runat="server" Width="120px"></asp:Label>
						</td>
						<td align="left" class="TdTitleHeader" style="width:100px">
							実施日
						</td>
                        <td align="left" class="TdItem">
							<asp:Label ID="FROM_DATE" runat="server" Width="80px"></asp:Label>
							〜
							<asp:Label ID="TO_DATE" runat="server" Width="80px"></asp:Label>
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
                                TextMode="MultiLine" Height="30px" Width="427px" tabstop="false" 
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
				            <asp:Label ID="MR_BU" runat="server" Width="480px"></asp:Label>
		                </td>
		            </tr>
		            <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                エリア
		                </td>
		                <td align="left" valign="top" colspan="2">
				            <asp:Label ID="MR_AREA" runat="server" Width="260px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                営業所
		                </td>
		                <td align="left" valign="top" colspan="5">
				            <asp:Label ID="MR_EIGYOSHO" runat="server" Width="260px"></asp:Label>
		                </td>
		            </tr>
		            <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                Account Code
		                </td>
		                <td align="left" valign="middle">
				            <asp:Label ID="ACCOUNT_CODE" runat="server" Width="100px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                Cost Center
		                </td>
		                <td align="left" valign="middle">
				            <asp:Label ID="COST_CENTER" runat="server" Width="100px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                Internal Order
		                </td>
		                <td align="left" valign="middle">
				            <asp:Label ID="INTERNAL_ORDER" runat="server" Width="100px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                Zetia Code
		                </td>
		                <td align="left" valign="middle">
				            <asp:Label ID="ZETIA_CD" runat="server" Width="80px"></asp:Label>
		                </td>
		            </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
                            氏名
                        </td>
                        <td align="left" valign="top" colspan="7">
                            <asp:TextBox ID="MR_NAME" runat="server" MaxLength="150" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="750px"  tabstop="false" 
                                BorderStyle="None"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
                            氏名<br />（ローマ字）
                        </td>
                        <td align="left" valign="top" colspan="7">
                            <asp:TextBox ID="MR_ROMA" runat="server" MaxLength="150" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="750px"  tabstop="false" 
                                BorderStyle="None"></asp:TextBox>
                        </td>
                    </tr>
		            <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                携帯電話番号
		                </td>
		                <td align="left" valign="middle" colspan="2">
				            <asp:Label ID="MR_KEITAI" runat="server" Width="200px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                オフィスの電話番号
		                </td>
		                <td align="left" valign="middle" colspan="5">
				            <asp:Label ID="MR_TEL" runat="server" Width="200px"></asp:Label>
		                </td>
		            </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
                            携帯Email<br />アドレス
                        </td>
                        <td align="left" valign="top" colspan="8">
                            <asp:TextBox ID="MR_EMAIL_KEITAI" runat="server" MaxLength="128" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="750px"  tabstop="false" 
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
                                TextMode="MultiLine" Height="30px" Width="750px"  tabstop="false" 
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
                                    <td align="left" valign="top" width="400">
            				            <asp:Label ID="MR_SEND_SAKI_FS" runat="server" Width="650px"></asp:Label>                                    
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" valign="top" style="width:100px">
                                        その他送付先：
                                    </td>
                                    <td align="left" valign="top">
                                        <asp:TextBox ID="MR_SEND_SAKI_OTHER" runat="server" MaxLength="128" ReadOnly="True" 
                                            TextMode="MultiLine" Height="45px" Width="650px"  tabstop="false" 
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
							<asp:Label ID="REQ_STATUS_TEHAI" runat="server" Width="120px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitle" style="width:100px">
			                回答<br />ステータス
		                </td>
		                <td align="left" valign="middle">							
		                    <asp:DropDownList ID="ANS_STATUS_TEHAI" runat="server" Width="150px" 
                                TabIndex="6">
                            </asp:DropDownList>						
		                </td>
		                <td align="left" valign="middle" class="TdTitle" style="width:100px">
			                チケット類<br />発送日（最新）
		                </td>
		                <td align="left" valign="middle">							
                            <asp:TextBox ID="ANS_TICKET_SEND_DAY" runat="server" MaxLength="8" 
                                Height="18px" Width="79px" TabIndex="7"></asp:TextBox>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                NOZOMI送信<br />ステータス
		                </td>
		                <td align="left" valign="middle">							
							<asp:Label ID="SEND_FLAG" runat="server" Width="120px"></asp:Label>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                参加者ID
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="SANKASHA_ID" runat="server" Width="120px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                DRコード</td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_CD" runat="server" Width="140px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                TimeStamp(BYL)
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="TIME_STAMP_BYL" runat="server" Width="120px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                TimeStamp(TOP)
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="TIME_STAMP_TOP" runat="server" Width="120px"></asp:Label>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                氏名
		                </td>
		                <td align="left" valign="middle" colspan="7">
                            <asp:TextBox ID="DR_NAME" runat="server" MaxLength="80" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="750px"  tabstop="false" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                氏名カナ
		                </td>
		                <td align="left" valign="middle" colspan="7">
                            <asp:TextBox ID="DR_KANA" runat="server" MaxLength="80" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="750px"  tabstop="false" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                性別
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_SEX" runat="server" Width="100px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                年齢
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_AGE" runat="server" Width="100px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                講演会への参加
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_SANKA" runat="server" Width="100px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                参加者の役割
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_YAKUWARI" runat="server" Width="100px"></asp:Label>
		                </td>
		            </tr> 
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                DCF<br />施設ｺｰﾄﾞ
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_SHISETSU_CD" runat="server" Width="100px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                施設名
		                </td>
		                <td align="left" valign="middle" colspan="5">
                            <asp:TextBox ID="DR_SHISETSU_NAME" runat="server" MaxLength="80" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="341px"  tabstop="false" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                施設住所
		                </td>
		                <td align="left" valign="middle" colspan="7">
                            <asp:TextBox ID="DR_SHISETSU_ADDRESS" runat="server" MaxLength="128" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="750px"  tabstop="false" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                指定外<br />申請理由			                
		                </td>
		                <td align="left" valign="middle" colspan="7">
                            <asp:TextBox ID="SHITEIGAI_RIYU" runat="server" MaxLength="128" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="750px"  tabstop="false" 
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
                                TextMode="MultiLine" Height="18px" Width="388px"  tabstop="false" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                最終承認日時
		                </td>
		                <td align="left" valign="top">
							<asp:Label ID="SHONIN_DATE" runat="server" Width="140px"></asp:Label>
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
							<asp:Label ID="TEHAI_HOTEL" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_STATUS_HOTEL" runat="server" TabIndex="8">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="HOTEL_IRAINAIYOU" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            施設名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_HOTEL_NAME" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="30px" Width="267px" TabIndex="9"></asp:TextBox>
            				<asp:Button ID="BtnHotelKensaku" runat="server" Width="55px" Text="検索" 
                                CssClass="ButtonList" TabIndex="10" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            宿泊日
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_HOTEL_DATE" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            泊数
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_HAKUSU" runat="server" Width="30px"></asp:Label>
							&nbsp;&nbsp;泊
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            施設住所
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_HOTEL_ADDRESS" runat="server" MaxLength="128" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="11"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            喫煙
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_HOTEL_SMOKING" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            施設TEL
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_HOTEL_TEL" runat="server" MaxLength="20" 
                                Height="18px" Width="173px" TabIndex="12"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px" rowspan="5">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3" rowspan="5">
                            <asp:TextBox ID="REQ_HOTEL_NOTE" runat="server" MaxLength="255" 
                                readonly="true" textmode="MultiLine" Height="143px" Width="321px" 
                                 tabstop="false"  BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            宿泊日
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_HOTEL_DATE" runat="server" MaxLength="8" 
                                Height="18px" Width="67px" TabIndex="13"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            泊数
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_HAKUSU" runat="server" MaxLength="2" 
                                Height="18px" Width="26px" TabIndex="14"></asp:TextBox>
							&nbsp;&nbsp;泊                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            チェックイン
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_CHECKIN_TIME" runat="server" MaxLength="5" 
                                Height="18px" Width="47px" TabIndex="15"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            チェックアウト
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_CHECKOUT_TIME" runat="server" MaxLength="5" 
                                Height="18px" Width="47px" TabIndex="16"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            部屋タイプ
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_ROOM_TYPE" runat="server" TabIndex="17" Width="344px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            喫煙
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_HOTEL_SMOKING" runat="server" TabIndex="18" 
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
                                textmode="MultiLine" Height="65px" Width="347px" TabIndex="19"></asp:TextBox>
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
							■交通（往路１）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TEHAI_1" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_O_STATUS_1" runat="server" TabIndex="20">
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
                                CssClass="ButtonList" TabIndex="21" />
            				<asp:Button ID="BtnClear_O_TEHAI_1" runat="server" Width="55px" Text="クリア" 
                                CssClass="ButtonList" TabIndex="22" />
                            <a style="color: #FF0000; font-weight: bold">※回答欄入力済の場合はコピーできません</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="7">
							<asp:Label ID="REQ_O_IRAINAIYOU_1" runat="server" Width="200px" ></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_KOTSUKIKAN_1" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_O_KOTSUKIKAN_1" runat="server" TabIndex="23">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_DATE_1" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_DATE_1" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="24"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_AIRPORT1_1" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                 tabstop="false"  BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_O_AIRPORT2_1" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                 tabstop="false"  BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT1_1" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="25"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT2_1" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="26"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TIME1_1" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_TIME2_1" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME1_1" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="27"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME2_1" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="28"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_O_BIN_1" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_BIN_1" runat="server" MaxLength="100" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="29"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_SEAT_1" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_SEAT_KIBOU1" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_1" runat="server" TabIndex="30">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_KIBOU1" runat="server" TabIndex="31">
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
							■交通（往路２）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TEHAI_2" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_O_STATUS_2" runat="server" TabIndex="32">
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
                                CssClass="ButtonList" TabIndex="33" />
            				<asp:Button ID="BtnClear_O_TEHAI_2" runat="server" Width="55px" Text="クリア" 
                                CssClass="ButtonList" TabIndex="34" />
                            <a style="color: #FF0000; font-weight: bold">※回答欄入力済の場合はコピーできません</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="7">
							<asp:Label ID="REQ_O_IRAINAIYOU_2" runat="server" Width="200px" ></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_KOTSUKIKAN_2" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_O_KOTSUKIKAN_2" runat="server" TabIndex="35">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_DATE_2" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_DATE_2" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="36"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_AIRPORT1_2" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                 tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_O_AIRPORT2_2" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                 tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT1_2" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="37"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT2_2" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="38"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TIME1_2" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_TIME2_2" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME1_2" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="39"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME2_2" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="40"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_O_BIN_2" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_BIN_2" runat="server" MaxLength="100" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="41"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_SEAT_2" runat="server" Width="120px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_SEAT_KIBOU2" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_2" runat="server" TabIndex="42">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_KIBOU2" runat="server" TabIndex="43">
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
							■交通（往路３）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TEHAI_3" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_O_STATUS_3" runat="server" TabIndex="44">
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
                                CssClass="ButtonList" TabIndex="45" />
            				<asp:Button ID="BtnClear_O_TEHAI_3" runat="server" Width="55px" Text="クリア" 
                                CssClass="ButtonList" TabIndex="46" />
                            <a style="color: #FF0000; font-weight: bold">※回答欄入力済の場合はコピーできません</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px" 
                            width="200">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="7" width="200">
							<asp:Label ID="REQ_O_IRAINAIYOU_3" runat="server" Width="200px" ></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_KOTSUKIKAN_3" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_O_KOTSUKIKAN_3" runat="server" TabIndex="47">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_DATE_3" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_DATE_3" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="48"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_AIRPORT1_3" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_O_AIRPORT2_3" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT1_3" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="49"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT2_3" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="50"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TIME1_3" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_TIME2_3" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME1_3" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="51"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME2_3" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="52"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_O_BIN_3" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_BIN_3" runat="server" MaxLength="100" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="53"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_SEAT_3" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_SEAT_KIBOU3" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_3" runat="server" TabIndex="54">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_KIBOU3" runat="server" TabIndex="55">
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
							■交通（往路４）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TEHAI_4" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_O_STATUS_4" runat="server" TabIndex="56">
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
                                CssClass="ButtonList" TabIndex="57" />
            				<asp:Button ID="BtnClear_O_TEHAI_4" runat="server" Width="55px" Text="クリア" 
                                CssClass="ButtonList" TabIndex="58" />
                            <a style="color: #FF0000; font-weight: bold">※回答欄入力済の場合はコピーできません</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="7">
							<asp:Label ID="REQ_O_IRAINAIYOU_4" runat="server" Width="200px" ></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_KOTSUKIKAN_4" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_O_KOTSUKIKAN_4" runat="server" TabIndex="59">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_DATE_4" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_DATE_4" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="60"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_AIRPORT1_4" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_O_AIRPORT2_4" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT1_4" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="61"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT2_4" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="62"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TIME1_4" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_TIME2_4" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME1_4" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="63"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME2_4" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="64"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_O_BIN_4" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_BIN_4" runat="server" MaxLength="100" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="65"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_SEAT_4" runat="server" Width="120px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_SEAT_KIBOU4" runat="server" Width="120px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_4" runat="server" TabIndex="66">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_KIBOU4" runat="server" TabIndex="67">
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
							■交通（往路５）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TEHAI_5" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_O_STATUS_5" runat="server" TabIndex="68">
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
                                CssClass="ButtonList" TabIndex="69" />
            				<asp:Button ID="BtnClear_O_TEHAI_5" runat="server" Width="55px" Text="クリア" 
                                CssClass="ButtonList" TabIndex="70" />
                            <a style="color: #FF0000; font-weight: bold">※回答欄入力済の場合はコピーできません</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="7">
							<asp:Label ID="REQ_O_IRAINAIYOU_5" runat="server" Width="200px" ></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_KOTSUKIKAN_5" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_O_KOTSUKIKAN_5" runat="server" TabIndex="71">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_DATE_5" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_DATE_5" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="72"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_AIRPORT1_5" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_O_AIRPORT2_5" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT1_5" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="73"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT2_5" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="74"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TIME1_5" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_TIME2_5" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME1_5" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="75"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME2_5" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="76"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_O_BIN_5" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_BIN_5" runat="server" MaxLength="100" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="77"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_SEAT_5" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_SEAT_KIBOU5" runat="server" Width="120px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_5" runat="server" TabIndex="78">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_KIBOU5" runat="server" TabIndex="79">
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
							■交通（復路１）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TEHAI_1" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_F_STATUS_1" runat="server" TabIndex="80">
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
                                CssClass="ButtonList" TabIndex="81" />
            				<asp:Button ID="BtnClear_F_TEHAI_1" runat="server" Width="55px" Text="クリア" 
                                CssClass="ButtonList" TabIndex="82" />
                            <a style="color: #FF0000; font-weight: bold">※回答欄入力済の場合はコピーできません</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="7">
							<asp:Label ID="REQ_F_IRAINAIYOU_1" runat="server" Width="200px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_KOTSUKIKAN_1" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_F_KOTSUKIKAN_1" runat="server" TabIndex="83">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_DATE_1" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_DATE_1" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="84"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_F_AIRPORT1_1" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_F_AIRPORT2_1" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT1_1" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="85"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT2_1" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="86"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TIME1_1" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_TIME2_1" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME1_1" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="87"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME2_1" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="88"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_F_BIN_1" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_BIN_1" runat="server" MaxLength="100" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="89"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_SEAT_1" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_SEAT_KIBOU1" runat="server" Width="120px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_1" runat="server" TabIndex="90">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_KIBOU1" runat="server" TabIndex="91">
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
							■交通（復路２）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TEHAI_2" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_F_STATUS_2" runat="server" TabIndex="92">
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
                                CssClass="ButtonList" TabIndex="93" />
            				<asp:Button ID="BtnClear_F_TEHAI_2" runat="server" Width="55px" Text="クリア" 
                                CssClass="ButtonList" TabIndex="94" />
                            <a style="color: #FF0000; font-weight: bold">※回答欄入力済の場合はコピーできません</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="7">
							<asp:Label ID="REQ_F_IRAINAIYOU_2" runat="server" Width="200px" ></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_KOTSUKIKAN_2" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_F_KOTSUKIKAN_2" runat="server" TabIndex="95">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_DATE_2" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_DATE_2" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="96"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_F_AIRPORT1_2" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_F_AIRPORT2_2" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT1_2" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="97"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT2_2" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="98"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TIME1_2" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_TIME2_2" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME1_2" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="99"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME2_2" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="100"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_F_BIN_2" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_BIN_2" runat="server" MaxLength="100" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="101"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_SEAT_2" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_SEAT_KIBOU2" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_2" runat="server" TabIndex="102">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_KIBOU2" runat="server" TabIndex="103">
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
							■交通（復路３）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TEHAI_3" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_F_STATUS_3" runat="server" TabIndex="104">
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
                                CssClass="ButtonList" TabIndex="105" />
            				<asp:Button ID="BtnClear_F_TEHAI_3" runat="server" Width="55px" Text="クリア" 
                                CssClass="ButtonList" TabIndex="106" />
                            <a style="color: #FF0000; font-weight: bold">※回答欄入力済の場合はコピーできません</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="7">
							<asp:Label ID="REQ_F_IRAINAIYOU_3" runat="server" Width="200px" ></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_KOTSUKIKAN_3" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_F_KOTSUKIKAN_3" runat="server" TabIndex="107">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_DATE_3" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_DATE_3" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="108"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_F_AIRPORT1_3" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_F_AIRPORT2_3" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT1_3" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="109"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT2_3" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="110"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TIME1_3" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_TIME2_3" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME1_3" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="111"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME2_3" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="112"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_F_BIN_3" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_BIN_3" runat="server" MaxLength="100" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="113"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_SEAT_3" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_SEAT_KIBOU3" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_3" runat="server" TabIndex="114">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_KIBOU3" runat="server" TabIndex="115">
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
							■交通（復路４）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TEHAI_4" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_F_STATUS_4" runat="server" TabIndex="116">
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
                        <td align="left" valign="middle" class="style1" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="style2" colspan="4">
                            ◆回答内容
            				<asp:Button ID="BtnCopy_F_TEHAI_4" runat="server" Width="55px" Text="コピー" 
                                CssClass="ButtonList" TabIndex="117" />
            				<asp:Button ID="BtnClear_F_TEHAI_4" runat="server" Width="55px" Text="クリア" 
                                CssClass="ButtonList" TabIndex="118" />
                            <a style="color: #FF0000; font-weight: bold">※回答欄入力済の場合はコピーできません</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="7">
							<asp:Label ID="REQ_F_IRAINAIYOU_4" runat="server" Width="200px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_KOTSUKIKAN_4" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_F_KOTSUKIKAN_4" runat="server" TabIndex="119">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_DATE_4" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_DATE_4" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="120"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_F_AIRPORT1_4" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_F_AIRPORT2_4" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT1_4" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="121"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT2_4" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="122"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TIME1_4" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_TIME2_4" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME1_4" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="123"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME2_4" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="124"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_F_BIN_4" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_BIN_4" runat="server" MaxLength="100" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="125"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_SEAT_4" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_SEAT_KIBOU4" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_4" runat="server" TabIndex="126">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_KIBOU4" runat="server" TabIndex="127">
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
							■交通（復路５）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TEHAI_5" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_F_STATUS_5" runat="server" TabIndex="128">
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
                                CssClass="ButtonList" TabIndex="129" />
            				<asp:Button ID="BtnClear_F_TEHAI_5" runat="server" Width="55px" Text="クリア" 
                                CssClass="ButtonList" TabIndex="130" />
                            <a style="color: #FF0000; font-weight: bold">※回答欄入力済の場合はコピーできません</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="7">
							<asp:Label ID="REQ_F_IRAINAIYOU_5" runat="server" Width="200px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_KOTSUKIKAN_5" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_F_KOTSUKIKAN_5" runat="server" TabIndex="131">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_DATE_5" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_DATE_5" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="132"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_F_AIRPORT1_5" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_F_AIRPORT2_5" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT1_5" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="133"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT2_5" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="134"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TIME1_5" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_TIME2_5" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME1_5" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="135"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME2_5" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="136"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_F_BIN_5" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_BIN_5" runat="server" MaxLength="100" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="137"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_SEAT_5" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_SEAT_KIBOU5" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_5" runat="server" TabIndex="138">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_KIBOU5" runat="server" TabIndex="139">
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
                                TextMode="MultiLine" Height="68px" Width="445px" tabstop="false" 
                                BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="4">
                            <asp:TextBox ID="ANS_KOTSU_BIKO" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="68px" Width="445px" TabIndex="140"></asp:TextBox>                            
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
                        <td align="left" valign="middle" class="TdItem"  colspan="5">
							<asp:Label ID="TEHAI_TAXI" runat="server" Width="120px"></asp:Label>
							<a name="TaxiTehaiLink"></a>
            				<asp:Button ID="BtnTicketCopy" runat="server" Width="55px" Text="コピー" 
                                CssClass="ButtonList" TabIndex="141" />
            				<asp:Button ID="BtnTicketClear" runat="server" Width="55px" Text="クリア" 
                                CssClass="ButtonList" TabIndex="142" />
                            <a style="color: #FF0000; font-weight: bold">※回答欄入力済の場合はコピーできません</a>							
                        </td>
						<td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
							スキャンデータ取込日
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="SCAN_IMPORT_DATE" runat="server" Width="80px"></asp:Label>
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
                                tabstop="false" BorderStyle="None"></asp:TextBox>                            
                        </td>
						<td align="left" valign="middle" class="TdTitle" style="width:170px">
							備考
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_TAXI_NOTE" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="68px" Width="344px" TabIndex="143"></asp:TextBox>                            
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
							<asp:Label ID="REQ_TAXI_DATE_1" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_1" runat="server" TabIndex="144" 
                                Text="発行対象" />
							<asp:Label ID="ANS_TAXI_HAKKO_1" runat="server" Width="80px">発行済</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_1" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            発地
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_1" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="30px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" >
                            <asp:TextBox ID="ANS_TAXI_DATE_1" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="145"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_1" runat="server" TabIndex="146">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼金額
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_1" runat="server" Width="80px"></asp:Label>
                            &nbsp;円
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_1" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="147" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_1" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="148" Wrap="False"></asp:TextBox>                            
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
							<asp:Label ID="REQ_TAXI_DATE_2" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_2" runat="server" TabIndex="149" Text="発行対象" />
							<asp:Label ID="ANS_TAXI_HAKKO_2" runat="server" Width="80px">発行済</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_2" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            発地
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_2" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="30px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" >
                            <asp:TextBox ID="ANS_TAXI_DATE_2" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="150"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_2" runat="server" TabIndex="151">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼金額
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_2" runat="server" Width="80px"></asp:Label>
                            &nbsp;円
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_2" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="152" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_2" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="153" Wrap="False"></asp:TextBox>                            
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
							<asp:Label ID="REQ_TAXI_DATE_3" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_3" runat="server" TabIndex="154" Text="発行対象" />
							<asp:Label ID="ANS_TAXI_HAKKO_3" runat="server" Width="80px">発行済</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_3" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            発地
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_3" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="30px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" >
                            <asp:TextBox ID="ANS_TAXI_DATE_3" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="155"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_3" runat="server" TabIndex="156">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼金額
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_3" runat="server" Width="80px"></asp:Label>
                            &nbsp;円
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_3" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="157" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_3" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="158" Wrap="False"></asp:TextBox>                            
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
							<asp:Label ID="REQ_TAXI_DATE_4" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_4" runat="server" TabIndex="159" Text="発行対象" />
							<asp:Label ID="ANS_TAXI_HAKKO_4" runat="server" Width="80px">発行済</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_4" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            発地
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_4" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="30px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" >
                            <asp:TextBox ID="ANS_TAXI_DATE_4" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="160"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_4" runat="server" TabIndex="161">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼金額
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_4" runat="server" Width="80px"></asp:Label>
                            &nbsp;円
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_4" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="162" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_4" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="163" Wrap="False"></asp:TextBox>                            
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
							<asp:Label ID="REQ_TAXI_DATE_5" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_5" runat="server" TabIndex="164" Text="発行対象" />
							<asp:Label ID="ANS_TAXI_HAKKO_5" runat="server" Width="80px">発行済</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_5" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            発地
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_5" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="30px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" >
                            <asp:TextBox ID="ANS_TAXI_DATE_5" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="165"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_5" runat="server" TabIndex="166">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼金額
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_5" runat="server" Width="80px"></asp:Label>
                            &nbsp;円
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_5" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="167" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_5" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="168" Wrap="False"></asp:TextBox>                            
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
							<asp:Label ID="REQ_TAXI_DATE_6" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_6" runat="server" TabIndex="169" Text="発行対象" />
							<asp:Label ID="ANS_TAXI_HAKKO_6" runat="server" Width="80px">発行済</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_6" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            発地
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_6" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="30px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" >
                            <asp:TextBox ID="ANS_TAXI_DATE_6" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="170"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_6" runat="server" TabIndex="171">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼金額
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_6" runat="server" Width="80px"></asp:Label>
                            &nbsp;円
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_6" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="172" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_6" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="173" Wrap="False"></asp:TextBox>                            
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
							<asp:Label ID="REQ_TAXI_DATE_7" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_7" runat="server" TabIndex="174" Text="発行対象" />
							<asp:Label ID="ANS_TAXI_HAKKO_7" runat="server" Width="80px">発行済</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_7" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            発地
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_7" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="30px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" >
                            <asp:TextBox ID="ANS_TAXI_DATE_7" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="175"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_7" runat="server" TabIndex="176">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼金額
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_7" runat="server" Width="80px"></asp:Label>
                            &nbsp;円
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_7" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="177" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_7" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="178" Wrap="False"></asp:TextBox>                            
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
							<asp:Label ID="REQ_TAXI_DATE_8" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_8" runat="server" TabIndex="179" Text="発行対象" />
							<asp:Label ID="ANS_TAXI_HAKKO_8" runat="server" Width="80px">発行済</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_8" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            発地
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_8" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="30px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" >
                            <asp:TextBox ID="ANS_TAXI_DATE_8" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="180"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_8" runat="server" TabIndex="181">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼金額
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_8" runat="server" Width="80px"></asp:Label>
                            &nbsp;円
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_8" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="182" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_8" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="183" Wrap="False"></asp:TextBox>                            
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
							<asp:Label ID="REQ_TAXI_DATE_9" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_9" runat="server" TabIndex="184" Text="発行対象" />
							<asp:Label ID="ANS_TAXI_HAKKO_9" runat="server" Width="80px">発行済</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_9" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            発地
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_9" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="30px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" >
                            <asp:TextBox ID="ANS_TAXI_DATE_9" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="185"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_9" runat="server" TabIndex="186">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼金額
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_9" runat="server" Width="80px"></asp:Label>
                            &nbsp;円
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_9" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="187" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_9" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="188" Wrap="False"></asp:TextBox>                            
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
							<asp:Label ID="REQ_TAXI_DATE_10" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_10" runat="server" TabIndex="189" Text="発行対象" />
							<asp:Label ID="ANS_TAXI_HAKKO_10" runat="server" Width="80px">発行済</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_10" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            発地
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_10" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="30px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" >
                            <asp:TextBox ID="ANS_TAXI_DATE_10" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="190"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_10" runat="server" TabIndex="191">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼金額
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_10" runat="server" Width="80px"></asp:Label>
                            &nbsp;円
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_10" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="192" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_10" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="193" Wrap="False"></asp:TextBox>                            
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
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_11" runat="server" TabIndex="194" Text="発行対象" />
							<asp:Label ID="ANS_TAXI_HAKKO_11" runat="server" Width="80px">発行済</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_11" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_DATE_11" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="195"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_11" runat="server" TabIndex="196">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_11" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="197" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_11" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="198" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット１２
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_12" runat="server" TabIndex="199" Text="発行対象" />
							<asp:Label ID="ANS_TAXI_HAKKO_12" runat="server" Width="80px">発行済</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_12" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_DATE_12" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="200"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_12" runat="server" TabIndex="201">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_12" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="202" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_12" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="203" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット１３
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_13" runat="server" TabIndex="204" Text="発行対象" />
							<asp:Label ID="ANS_TAXI_HAKKO_13" runat="server" Width="80px">発行済</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_13" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_DATE_13" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="205"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_13" runat="server" TabIndex="206">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_13" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="207" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_13" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="208" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット１４
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_14" runat="server" TabIndex="209" Text="発行対象" />
							<asp:Label ID="ANS_TAXI_HAKKO_14" runat="server" Width="80px">発行済</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_14" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_DATE_14" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="210"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_14" runat="server" TabIndex="211">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_14" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="212" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_14" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="213" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット１５
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_15" runat="server" TabIndex="214" Text="発行対象" />
							<asp:Label ID="ANS_TAXI_HAKKO_15" runat="server" Width="80px">発行済</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_15" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_DATE_15" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="215"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_15" runat="server" TabIndex="216">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_15" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="217" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_15" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="218" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット１６
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_16" runat="server" TabIndex="219" Text="発行対象" />
							<asp:Label ID="ANS_TAXI_HAKKO_16" runat="server" Width="80px">発行済</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_16" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_DATE_16" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="220"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_16" runat="server" TabIndex="221">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_16" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="222" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_16" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="223" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット１７
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_17" runat="server" TabIndex="224" Text="発行対象" />
							<asp:Label ID="ANS_TAXI_HAKKO_17" runat="server" Width="80px">発行済</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_17" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_DATE_17" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="225"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_17" runat="server" TabIndex="226">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_17" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="227" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_17" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="228" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット１８
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_18" runat="server" TabIndex="229" Text="発行対象" />
							<asp:Label ID="ANS_TAXI_HAKKO_18" runat="server" Width="80px">発行済</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_18" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_DATE_18" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="230"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_18" runat="server" TabIndex="231">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_18" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="232" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_18" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="233" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット１９
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_19" runat="server" TabIndex="234" Text="発行対象" />
							<asp:Label ID="ANS_TAXI_HAKKO_19" runat="server" Width="80px">発行済</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_19" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_DATE_19" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="235"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_19" runat="server" TabIndex="236">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_19" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="237" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_19" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="238" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆タクシーチケット２０
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_20" runat="server" TabIndex="239" Text="発行対象" />
							<asp:Label ID="ANS_TAXI_HAKKO_20" runat="server" Width="80px">発行済</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_20" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_DATE_20" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="240"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_20" runat="server" TabIndex="241">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_20" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="242" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_20" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="243" Wrap="False"></asp:TextBox>                            
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
							<asp:Label ID="REQ_MR_O_TEHAI" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            社員用往路手配
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
		                    <asp:DropDownList ID="ANS_MR_O_TEHAI" runat="server" Width="150px" 
                                TabIndex="244">
                            </asp:DropDownList>						
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader">
                            社員用復路隣席希望
                        </td>
                        <td align="left" valign="top" class="TdItem" colspan="3">
							<asp:Label ID="REQ_MR_F_TEHAI" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            社員用復路手配
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
		                    <asp:DropDownList ID="ANS_MR_F_TEHAI" runat="server" Width="150px" 
                                TabIndex="245">
                            </asp:DropDownList>						
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader">
                            性別
                        </td>
                        <td align="left" valign="top" class="TdItem">
							<asp:Label ID="MR_SEX" runat="server" Width="50px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader">
                            年齢
                        </td>
                        <td align="left" valign="top" class="TdItem">
							<asp:Label ID="MR_AGE" runat="server" Width="50px"></asp:Label>
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
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="246" 
                                BorderStyle="None" ReadOnly="True"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            備考
                        </td>
                        <td align="left" valign="top" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_MR_HOTEL_NOTE" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="247"></asp:TextBox>                            
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
						<td align="left" valign="middle" class="TdTitleHeader" colspan="6">
							■各種代金
                        </td>
					</tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle">
                            DR宿泊費(税込)
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_HOTELHI" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="248" AutoPostBack="True"></asp:TextBox>円                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            JR券代
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_RAIL_FARE" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="253"></asp:TextBox>円                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle">
                            DR宿泊都税
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_HOTELHI_TOZEI" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="249" AutoPostBack="True"></asp:TextBox>円                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            JR券取消料
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_RAIL_CANCELLATION" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="254"></asp:TextBox>円                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle">
                            DR宿泊費消費税抜金額
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:Label ID="ANS_HOTELHI_TF" runat="server"></asp:Label>円
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            その他鉄道代等代金
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_OTHER_FARE" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="255"></asp:TextBox>円                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle">
                            DR宿泊取消料
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_HOTELHI_CANCEL" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="250"></asp:TextBox>円                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            その他鉄道代等取消料
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_OTHER_CANCELLATION" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="256"></asp:TextBox>円                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle">
                            航空券代
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="5">
                            <asp:TextBox ID="ANS_AIR_FARE" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="251"></asp:TextBox>円                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle">
                            航空券取消料
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="5">
                            <asp:TextBox ID="ANS_AIR_CANCELLATION" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="252"></asp:TextBox>円                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle">
                            手数料（交通・宿泊）
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            &nbsp;<asp:CheckBox ID="ANS_KOTSUHOTEL_TESURYO" runat="server" Text="手数料あり" 
                                TabIndex="257" />
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            タクチケ発行枚数
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_MAISUU" runat="server" MaxLength="3" 
                                Height="18px" Width="35px" TabIndex="258" AutoPostBack="True"></asp:TextBox>枚
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            タクチケ発券手数料
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:Label ID="ANS_TAXI_TESURYO" runat="server"></asp:Label>円
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle">
                            MR宿泊費(税込)
                        </td>
                        <td align="left" valign="top" class="TdItem">
                            <asp:TextBox ID="ANS_MR_HOTELHI" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="259" AutoPostBack="True"></asp:TextBox>円                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            MR交通費
                        </td>
                        <td align="left" valign="top" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_MR_KOTSUHI" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="261"></asp:TextBox>円                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle">
                            MR宿泊都税
                        </td>
                        <td align="left" valign="top" class="TdItem" colspan="6">
                            <asp:TextBox ID="ANS_MR_HOTELHI_TOZEI" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="260" AutoPostBack="True"></asp:TextBox>円                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle">
                            MR宿泊費消費税抜金額
                        </td>
                        <td align="left" valign="top" class="TdItem" colspan="6">
                            <asp:Label ID="ANS_MR_HOTELHI_TF" runat="server"></asp:Label>円
                        </td>
                    </tr>
				</table>
		    </td>
		</tr>
		    
		<div class="FontSize1" style="height: 10px;"></div>
		<table cellspacing="0" cellpadding="0" border="0" style="width:900px;">
			<tr style="height: 36px; width:100%">
				<td align="left" style="width:100%">
				    <asp:Button ID="BtnRireki" runat="server" Width="150px" Text="履歴表示" 
                        CssClass="Button" TabIndex="262" />
					<asp:Button ID="BtnPrint2" runat="server" Width="150px" Text="手配書印刷" 
                        CssClass="Button" TabIndex="263" />
					<asp:Button ID="BtnSoufujo2" runat="server" Width="150px" Text="送付状印刷" 
                        CssClass="Button" TabIndex="264" />
					<asp:Button ID="BtnTaxiKakunin2" runat="server" Width="150px" Text="タクチケ手配確認票印刷" 
                        CssClass="Button" TabIndex="265" />
                </td>
            </tr>
            <tr align="right" style="width:100%">
                <td>
				    <asp:Button ID="BtnSubmit" runat="server" Width="150px" Text="登録" 
                        CssClass="Button" TabIndex="264" />
				    <asp:Button ID="BtnNozomi" runat="server" Width="150px" Text="NOZOMIへ" 
                        CssClass="Button" TabIndex="265" />
					<asp:Button ID="BtnBack2" runat="server" Width="150px" Text="戻る" 
                        CssClass="Button" TabIndex="266" />
				</td>
			</tr>
		</table>
	</table>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">

		<style type="text/css">
            .style1
            {
                background-color: #738891;
                color: #ffffff;
                font-weight: bold;
                height: 37px;
            }
            .style2
            {
                background-color: #b8c3c8;
                color: #273034;
                font-weight: bold;
                height: 37px;
            }
            .style3
            {
                background-color: #738891;
                color: #ffffff;
                font-weight: bold;
                width: 100px;
            }
            .style4
            {
                background-color: #b8c3c8;
                color: #273034;
                font-weight: bold;
                width: 100px;
            }
        </style>

		</asp:Content>

