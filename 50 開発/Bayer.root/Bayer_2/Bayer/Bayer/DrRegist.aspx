<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="DrRegist.aspx.vb" Inherits="Bayer.DrRegist" MaintainScrollPositionOnPostback="true" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table border="0" cellpadding="4" cellspacing="0" style="width:900px">
		<tr style="height: 36px; width:100%">
			<td align="left" style="width:100%">
                <a name="PageTopLink"></a>				    
				<asp:Button ID="BtnPrint1" runat="server" Width="130px" Text="手配書印刷" 
                    CssClass="Button" TabIndex="1" />
				<asp:Button ID="BtnSoufujo1" runat="server" Width="130px" Text="送付状印刷" 
                    CssClass="Button" TabIndex="2" />
				<asp:Button ID="BtnTaxiKakunin1" runat="server" Width="150px" Text="タクチケ手配確認票印刷" 
                    CssClass="Button" TabIndex="3" />
			    <asp:Button ID="BtnSubmit1" runat="server" Width="130px" Text="登録" 
                    CssClass="Button" TabIndex="4" />
			    <asp:Button ID="BtnNozomi1" runat="server" Width="130px" Text="NOZOMIへ" 
                    CssClass="Button" TabIndex="5" />
				<asp:Button ID="BtnBack1" runat="server" Width="130px" Text="戻る" 
                    CssClass="Button" TabIndex="6" />
			</td>
		</tr>
		<tr>
		    <td colspan="2" style="width:100%">
			    <table style="border-collapse: collapse; " cellspacing="0" 
                    cellpadding="2" class="style1">
		            <tr>
		                <td id="TdEmergency" runat="server" align="center" 
                            style="border: thin solid #FF0000; width:10%; font-weight: bold; color: #FF0000;">
			                <a id="msg_emergency" runat="server" 
                                style="font-size: x-large; font-weight: bold; color: #FF0000">緊　急</a>
		                </td>
		                <td align="right" style="width:90%">
			                <a href="#TaxiTehaiLink" tabindex="7">タクチケ手配へ</a>
		                </td>
		            </tr>
		        </table>
		    </td>
		</tr>
		<tr>
			<td align="left" colspan="2">
			    <!-- 会合情報 -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="8">
                            ■会合情報
	                        <asp:Button ID="BtnKihon" runat="server" Width="150px" Text="基本情報へ" 
                                CssClass="Button" TabIndex="8" />
                        </td>
                    </tr>
                    <tr>
						<td align="left" class="TdTitleHeader" style="width:120px">
							会合番号
						</td>
						<td align="left" class="TdItem" style="width:100px">
							<asp:Label ID="KOUENKAI_NO" runat="server" Width="100px"></asp:Label>
						</td>
						<td align="left" class="TdTitleHeader" style="width:100px">
							開催日
						</td>
                        <td align="left" class="TdItem">
							<asp:Label ID="FROM_DATE" runat="server" Width="150px"></asp:Label>
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
							会合名
						</td>
						<td align="left" class="TdItem" colspan="3">
                            <asp:TextBox ID="KOUENKAI_NAME" runat="server" MaxLength="80" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="500px" tabstop="false" 
                                BorderStyle="None"></asp:TextBox>
						</td>
						<td align="left" class="TdTitleHeader">
							チケット印字名
						</td>
						<td align="left" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_PRT_NAME" runat="server" Text=""></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="left" class="TdTitleHeader" style="width:120px">
							会場名
						</td>
						<td align="left" class="TdItem" colspan="3">
                            <asp:TextBox ID="KAIJO_NAME" runat="server" MaxLength="80" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="500px" tabstop="false" 
                                BorderStyle="None"></asp:TextBox>
						</td>
						<td align="left" class="TdTitleHeader">
							団体コード
						</td>
						<td align="left" class="TdItem" colspan="3">
							<asp:Label ID="DANTAI_CODE" runat="server" Text=""></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="left" class="TdTitleHeader">
							WBS Element
						</td>
						<td align="left" class="TdItem" colspan="7">
							<asp:Label ID="WBS_ELEMENT1" runat="server" Text=""></asp:Label>
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
                                TabIndex="9">
                            </asp:DropDownList>						
		                </td>
		                <td align="left" valign="middle" class="TdTitle" style="width:100px">
			                チケット類<br />発送日（最新）
		                </td>
		                <td align="left" valign="middle">							
                            <asp:TextBox ID="ANS_TICKET_SEND_DAY" runat="server" MaxLength="8" 
                                Height="18px" Width="79px" TabIndex="10"></asp:TextBox>
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
			                年齢
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_AGE" runat="server" Width="100px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                性別
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_SEX" runat="server" Width="100px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                会合への参加
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
                                TextMode="MultiLine" Height="30px" Width="533px"  tabstop="false" 
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
		            <tr>		                
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                WBS Element
		                </td>
		                <td align="left" valign="middle" colspan="7">
							<asp:Label ID="WBS_ELEMENT" runat="server" Width="100px"></asp:Label>
		                </td>
		            </tr>
	                <tr id="TrSEIKYU_NO_TOPTOUR" runat="server">
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                精算番号
		                </td>
		                <td align="left" valign="middle" colspan="7">
                            <asp:TextBox ID="SEIKYU_NO_TOPTOUR" runat="server" MaxLength="14" Width="130px"></asp:TextBox>
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
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" tabindex="11">ページトップへ</a>
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
			<td align="left" colspan="2">
				<!-- MR手配情報 -->				
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleMR" colspan="8">
							■MR手配情報
                        </td>
					</tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleMR" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleMR">
                            担当MR隣席希望(往路)
                        </td>
                        <td align="left" valign="top" class="TdItem" colspan="3">
							<asp:Label ID="REQ_MR_O_TEHAI" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            担当MR手配(往路)
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
		                    <asp:DropDownList ID="ANS_MR_O_TEHAI" runat="server" Width="150px" 
                                TabIndex="12">
                            </asp:DropDownList>						
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleMR">
                            担当MR隣席希望(復路)
                        </td>
                        <td align="left" valign="top" class="TdItem" colspan="3">
							<asp:Label ID="REQ_MR_F_TEHAI" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            担当MR手配(復路)
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
		                    <asp:DropDownList ID="ANS_MR_F_TEHAI" runat="server" Width="150px" 
                                TabIndex="13">
                            </asp:DropDownList>						
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleMR">
                            年齢
                        </td>
                        <td align="left" valign="top" class="TdItem">
							<asp:Label ID="MR_AGE" runat="server" Width="50px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleMR">
                            性別
                        </td>
                        <td align="left" valign="top" class="TdItem">
							<asp:Label ID="MR_SEX" runat="server" Width="50px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="4">
							<div style="font-weight: bold; color: #2424f0;" id="DivComment" runat="server">
								ダブルクォーテーション「”」・改行(Enterキー)は入力できません。
							</div>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleMR">
                            備考
                        </td>
                        <td align="left" valign="top" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_MR_HOTEL_NOTE" runat="server" MaxLength="510" 
                                TextMode="MultiLine" Height="47px" Width="344px" Tabstop="False" 
                                BorderStyle="None" ReadOnly="True"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            備考
                        </td>
                        <td align="left" valign="top" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_MR_HOTEL_NOTE" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="14"></asp:TextBox>                            
                        </td>
                    </tr>
				</table>
		    </td>
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" tabindex="15">ページトップへ</a>
		    </td>
		</tr>

		<tr>
		    <td align="left"  colspan="2">
				<!-- 宿泊手配 -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHotel" colspan="8">
                            ■宿泊手配
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHotel" style="width:100px">
                            宿泊依頼
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TEHAI_HOTEL" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHotel" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="HOTEL_IRAINAIYOU" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_STATUS_HOTEL" runat="server" TabIndex="16" 
                                Width="147px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHotel" style="width:100px">
                            宿泊日
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_HOTEL_DATE" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHotel" style="width:100px">
                            泊数
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_HAKUSU" runat="server" Width="30px"></asp:Label>
							&nbsp;&nbsp;泊
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            施設名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_HOTEL_NAME" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="30px" Width="267px" TabIndex="17"></asp:TextBox>
            				<asp:Button ID="BtnHotelKensaku" runat="server" Width="55px" Text="検索" 
                                CssClass="ButtonList" TabIndex="18" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHotel" style="width:100px">
                            喫煙
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_HOTEL_SMOKING" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            施設住所
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_HOTEL_ADDRESS" runat="server" MaxLength="128" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="19"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHotel" style="width:100px" rowspan="6">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3" rowspan="6">
                            <asp:TextBox ID="REQ_HOTEL_NOTE" runat="server" MaxLength="255" 
                                readonly="true" textmode="MultiLine" Height="220px" Width="321px" 
                                 tabstop="false"  BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            施設TEL
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_HOTEL_TEL" runat="server" MaxLength="20" 
                                Height="18px" Width="173px" TabIndex="20"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            宿泊日
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_HOTEL_DATE" runat="server" MaxLength="8" 
                                Height="18px" Width="67px" TabIndex="21"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            泊数
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_HAKUSU" runat="server" MaxLength="2" 
                                Height="18px" Width="26px" TabIndex="22"></asp:TextBox>
							&nbsp;&nbsp;泊                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            チェックイン
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_CHECKIN_TIME" runat="server" MaxLength="5" 
                                Height="18px" Width="47px" TabIndex="23"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            チェックアウト
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_CHECKOUT_TIME" runat="server" MaxLength="5" 
                                Height="18px" Width="47px" TabIndex="24"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            部屋タイプ
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_ROOM_TYPE" runat="server" TabIndex="25" Width="344px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            喫煙
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_HOTEL_SMOKING" runat="server" TabIndex="26" 
                                Width="344px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3" width="344px">							
							<div style="font-weight: bold; color: #2424f0;" id="Div1" runat="server">
								ダブルクォーテーション「”」・改行(Enterキー)は入力できません。
							</div>
                            <asp:TextBox ID="ANS_HOTEL_NOTE" runat="server" MaxLength="255" 
                                textmode="MultiLine" Height="65px" Width="347px" TabIndex="27"></asp:TextBox>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" tabindex="28">ページトップへ</a>
		    </td>
		</tr>
		
		<tr>
			<td align="left" colspan="2">
				<!-- 交通（往路１）タイトル -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleOuro" style="width:170px">
							■交通（往路１）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TEHAI_1" runat="server" Width="200px" ></asp:Label>
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
                        <td align="left" valign="middle" class="TdTitleOuro" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
            				<asp:Button ID="BtnCopy_O_TEHAI_1" runat="server" Width="55px" Text="コピー" 
                                CssClass="ButtonList" TabIndex="29" />
            				<asp:Button ID="BtnClear_O_TEHAI_1" runat="server" Width="55px" Text="クリア" 
                                CssClass="ButtonList" TabIndex="30" />
                            <a style="color: #FF0000; font-weight: bold">※回答欄入力済の場合はコピーできません</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_IRAINAIYOU_1" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_O_STATUS_1" runat="server" TabIndex="31" 
                                Width="147px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_KOTSUKIKAN_1" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_O_KOTSUKIKAN_1" runat="server" TabIndex="32" 
                                Width="147px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_DATE_1" runat="server" Width="130px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_DATE_1" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="33"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_AIRPORT1_1" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                 tabstop="false"  BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
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
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="34"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT2_1" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="35"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TIME1_1" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
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
                                Height="18px" Width="148px" TabIndex="36"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME2_1" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="37"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
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
                            <asp:TextBox ID="ANS_O_BIN_1" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="38"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_SEAT_1" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_SEAT_KIBOU1" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_1" runat="server" TabIndex="39">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_KIBOU1" runat="server" TabIndex="40">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" tabindex="41">ページトップへ</a>
		    </td>
		</tr>
		
		<tr>
			<td align="left" colspan="2">
				<!-- 交通（往路２）タイトル -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleOuro" style="width:170px">
							■交通（往路２）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TEHAI_2" runat="server" Width="200px" ></asp:Label>
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
                        <td align="left" valign="middle" class="TdTitleOuro" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
            				<asp:Button ID="BtnCopy_O_TEHAI_2" runat="server" Width="55px" Text="コピー" 
                                CssClass="ButtonList" TabIndex="42" />
            				<asp:Button ID="BtnClear_O_TEHAI_2" runat="server" Width="55px" Text="クリア" 
                                CssClass="ButtonList" TabIndex="43" />
                            <a style="color: #FF0000; font-weight: bold">※回答欄入力済の場合はコピーできません</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_IRAINAIYOU_2" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_O_STATUS_2" runat="server" TabIndex="44" 
                                Width="147px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_KOTSUKIKAN_2" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_O_KOTSUKIKAN_2" runat="server" TabIndex="45" 
                                Width="147px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_DATE_2" runat="server" Width="130px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_DATE_2" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="46"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_AIRPORT1_2" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                 tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
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
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="47"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT2_2" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="48"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TIME1_2" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
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
                                Height="18px" Width="148px" TabIndex="49"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME2_2" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="50"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
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
                            <asp:TextBox ID="ANS_O_BIN_2" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="51"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_SEAT_2" runat="server" Width="120px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_SEAT_KIBOU2" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_2" runat="server" TabIndex="52">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_KIBOU2" runat="server" TabIndex="53">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" tabindex="54">ページトップへ</a>
		    </td>
		</tr>
		
		<tr>
			<td align="left" colspan="2">
				<!-- 交通（往路３）タイトル -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleOuro" style="width:170px">
							■交通（往路３）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TEHAI_3" runat="server" Width="200px" ></asp:Label>
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
                        <td align="left" valign="middle" class="TdTitleOuro" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
            				<asp:Button ID="BtnCopy_O_TEHAI_3" runat="server" Width="55px" Text="コピー" 
                                CssClass="ButtonList" TabIndex="55" />
            				<asp:Button ID="BtnClear_O_TEHAI_3" runat="server" Width="55px" Text="クリア" 
                                CssClass="ButtonList" TabIndex="56" />
                            <a style="color: #FF0000; font-weight: bold">※回答欄入力済の場合はコピーできません</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px" 
                            width="200">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_IRAINAIYOU_3" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_O_STATUS_3" runat="server" TabIndex="57" 
                                Width="148px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_KOTSUKIKAN_3" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_O_KOTSUKIKAN_3" runat="server" TabIndex="58" 
                                Width="148px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_DATE_3" runat="server" Width="130px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_DATE_3" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="59"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_AIRPORT1_3" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
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
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="60"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT2_3" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="61"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TIME1_3" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
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
                                Height="18px" Width="148px" TabIndex="62"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME2_3" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="63"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
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
                            <asp:TextBox ID="ANS_O_BIN_3" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="64"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_SEAT_3" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_SEAT_KIBOU3" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_3" runat="server" TabIndex="65">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_KIBOU3" runat="server" TabIndex="66">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" TabIndex="67">ページトップへ</a>
		    </td>
		</tr>
		
		<tr>
			<td align="left" colspan="2">
				<!-- 交通（往路４）タイトル -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleOuro" style="width:170px">
							■交通（往路４）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TEHAI_4" runat="server" Width="200px" ></asp:Label>
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
                        <td align="left" valign="middle" class="TdTitleOuro" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
            				<asp:Button ID="BtnCopy_O_TEHAI_4" runat="server" Width="55px" Text="コピー" 
                                CssClass="ButtonList" TabIndex="68" />
            				<asp:Button ID="BtnClear_O_TEHAI_4" runat="server" Width="55px" Text="クリア" 
                                CssClass="ButtonList" TabIndex="69" />
                            <a style="color: #FF0000; font-weight: bold">※回答欄入力済の場合はコピーできません</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_IRAINAIYOU_4" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_O_STATUS_4" runat="server" TabIndex="70" Width="148px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_KOTSUKIKAN_4" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_O_KOTSUKIKAN_4" runat="server" TabIndex="71" Width="148px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_DATE_4" runat="server" Width="130px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_DATE_4" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="72"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_AIRPORT1_4" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
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
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="73"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT2_4" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="74"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TIME1_4" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
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
                                Height="18px" Width="148px" TabIndex="75"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME2_4" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="76"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
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
                            <asp:TextBox ID="ANS_O_BIN_4" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="77"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_SEAT_4" runat="server" Width="120px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_SEAT_KIBOU4" runat="server" Width="120px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_4" runat="server" TabIndex="78">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_KIBOU4" runat="server" TabIndex="79">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" TabIndex="80">ページトップへ</a>
		    </td>
		</tr>
		
		<tr>
			<td align="left" colspan="2">
				<!-- 交通（往路５）タイトル -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleOuro" style="width:170px">
							■交通（往路５）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TEHAI_5" runat="server" Width="200px" ></asp:Label>
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
                        <td align="left" valign="middle" class="TdTitleOuro" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
            				<asp:Button ID="BtnCopy_O_TEHAI_5" runat="server" Width="55px" Text="コピー" 
                                CssClass="ButtonList" TabIndex="81" />
            				<asp:Button ID="BtnClear_O_TEHAI_5" runat="server" Width="55px" Text="クリア" 
                                CssClass="ButtonList" TabIndex="82" />
                            <a style="color: #FF0000; font-weight: bold">※回答欄入力済の場合はコピーできません</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_IRAINAIYOU_5" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_O_STATUS_5" runat="server" TabIndex="83" Width="148px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_KOTSUKIKAN_5" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_O_KOTSUKIKAN_5" runat="server" TabIndex="84" Width="148px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_DATE_5" runat="server" Width="130px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_DATE_5" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="85"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_AIRPORT1_5" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
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
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="86"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT2_5" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="87"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TIME1_5" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
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
                                Height="18px" Width="148px" TabIndex="88"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME2_5" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="89"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
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
                            <asp:TextBox ID="ANS_O_BIN_5" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="90"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_SEAT_5" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_SEAT_KIBOU5" runat="server" Width="120px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_5" runat="server" TabIndex="91">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_KIBOU5" runat="server" TabIndex="92">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>		
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" TabIndex="93">ページトップへ</a>
		    </td>
		</tr>
		
		<tr>
			<td align="left" colspan="2">
				<!-- 交通（復路１）タイトル -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleFukuro" style="width:170px">
							■交通（復路１）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TEHAI_1" runat="server" Width="200px" ></asp:Label>
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
                        <td align="left" valign="middle" class="TdTitleFukuro" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
            				<asp:Button ID="BtnCopy_F_TEHAI_1" runat="server" Width="55px" Text="コピー" 
                                CssClass="ButtonList" TabIndex="94" />
            				<asp:Button ID="BtnClear_F_TEHAI_1" runat="server" Width="55px" Text="クリア" 
                                CssClass="ButtonList" TabIndex="95" />
                            <a style="color: #FF0000; font-weight: bold">※回答欄入力済の場合はコピーできません</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_IRAINAIYOU_1" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_F_STATUS_1" runat="server" TabIndex="96" Width="148px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_KOTSUKIKAN_1" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_F_KOTSUKIKAN_1" runat="server" TabIndex="97" Width="148px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_DATE_1" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_DATE_1" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="98"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_F_AIRPORT1_1" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
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
                            <asp:TextBox ID="ANS_F_AIRPORT1_1" runat="server" MaxLength="160" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="99"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT2_1" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="100"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TIME1_1" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
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
                                Height="18px" Width="148px" TabIndex="101"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME2_1" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="102"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
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
                            <asp:TextBox ID="ANS_F_BIN_1" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="103"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_SEAT_1" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_SEAT_KIBOU1" runat="server" Width="120px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_1" runat="server" TabIndex="104">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_KIBOU1" runat="server" TabIndex="105">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" TabIndex="106">ページトップへ</a>
		    </td>
		</tr>		
		<tr>
			<td align="left" colspan="2">
				<!-- 交通（復路２）タイトル -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleFukuro" style="width:170px">
							■交通（復路２）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TEHAI_2" runat="server" Width="200px" ></asp:Label>
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
                        <td align="left" valign="middle" class="TdTitleFukuro" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
            				<asp:Button ID="BtnCopy_F_TEHAI_2" runat="server" Width="55px" Text="コピー" 
                                CssClass="ButtonList" TabIndex="107" />
            				<asp:Button ID="BtnClear_F_TEHAI_2" runat="server" Width="55px" Text="クリア" 
                                CssClass="ButtonList" TabIndex="108" />
                            <a style="color: #FF0000; font-weight: bold">※回答欄入力済の場合はコピーできません</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_IRAINAIYOU_2" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_F_STATUS_2" runat="server" TabIndex="109" Width="148px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_KOTSUKIKAN_2" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_F_KOTSUKIKAN_2" runat="server" TabIndex="110" Width="148px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_DATE_2" runat="server" Width="130px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_DATE_2" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="111"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_F_AIRPORT1_2" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
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
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="112"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT2_2" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="113"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TIME1_2" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
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
                                Height="18px" Width="148px" TabIndex="114"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME2_2" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="115"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
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
                            <asp:TextBox ID="ANS_F_BIN_2" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="116"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_SEAT_2" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_SEAT_KIBOU2" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_2" runat="server" TabIndex="117">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_KIBOU2" runat="server" TabIndex="118">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" TabIndex="119">ページトップへ</a>
		    </td>
		</tr>		
		<tr>
			<td align="left" colspan="2">
				<!-- 交通（復路３）タイトル -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleFukuro" style="width:170px">
							■交通（復路３）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TEHAI_3" runat="server" Width="200px" ></asp:Label>
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
                        <td align="left" valign="middle" class="TdTitleFukuro" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
            				<asp:Button ID="BtnCopy_F_TEHAI_3" runat="server" Width="55px" Text="コピー" 
                                CssClass="ButtonList" TabIndex="120" />
            				<asp:Button ID="BtnClear_F_TEHAI_3" runat="server" Width="55px" Text="クリア" 
                                CssClass="ButtonList" TabIndex="121" />
                            <a style="color: #FF0000; font-weight: bold">※回答欄入力済の場合はコピーできません</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_IRAINAIYOU_3" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_F_STATUS_3" runat="server" TabIndex="122" Width="148px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_KOTSUKIKAN_3" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_F_KOTSUKIKAN_3" runat="server" TabIndex="123" Width="148px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_DATE_3" runat="server" Width="130px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_DATE_3" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="124"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_F_AIRPORT1_3" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
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
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="125"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT2_3" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="126"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TIME1_3" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
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
                                Height="18px" Width="148px" TabIndex="127"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME2_3" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="128"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
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
                            <asp:TextBox ID="ANS_F_BIN_3" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="129"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_SEAT_3" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_SEAT_KIBOU3" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_3" runat="server" TabIndex="130">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_KIBOU3" runat="server" TabIndex="131">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" TabIndex="132">ページトップへ</a>
		    </td>
		</tr>		
		<tr>
			<td align="left" colspan="2">
				<!-- 交通（復路４）タイトル -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleFukuro" style="width:170px">
							■交通（復路４）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TEHAI_4" runat="server" Width="200px"></asp:Label>
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
                        <td align="left" valign="middle" class="TdTitleFukuro" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
            				<asp:Button ID="BtnCopy_F_TEHAI_4" runat="server" Width="55px" Text="コピー" 
                                CssClass="ButtonList" TabIndex="133" />
            				<asp:Button ID="BtnClear_F_TEHAI_4" runat="server" Width="55px" Text="クリア" 
                                CssClass="ButtonList" TabIndex="134" />
                            <a style="color: #FF0000; font-weight: bold">※回答欄入力済の場合はコピーできません</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_IRAINAIYOU_4" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_F_STATUS_4" runat="server" TabIndex="135" Width="148px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_KOTSUKIKAN_4" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_F_KOTSUKIKAN_4" runat="server" TabIndex="136" Width="148px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_DATE_4" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_DATE_4" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="137"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_F_AIRPORT1_4" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
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
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="138"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT2_4" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="139"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TIME1_4" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
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
                                Height="18px" Width="148px" TabIndex="140"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME2_4" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="141"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
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
                            <asp:TextBox ID="ANS_F_BIN_4" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="142"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_SEAT_4" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_SEAT_KIBOU4" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_4" runat="server" TabIndex="143">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_KIBOU4" runat="server" TabIndex="144">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" TabIndex="145">ページトップへ</a>
		    </td>
		</tr>		
		<tr>
			<td align="left" colspan="2">
				<!-- 交通（復路５）タイトル -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleFukuro" style="width:170px">
							■交通（復路５）手配
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TEHAI_5" runat="server" Width="200px"></asp:Label>
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
                        <td align="left" valign="middle" class="TdTitleFukuro" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
            				<asp:Button ID="BtnCopy_F_TEHAI_5" runat="server" Width="55px" Text="コピー" 
                                CssClass="ButtonList" TabIndex="146" />
            				<asp:Button ID="BtnClear_F_TEHAI_5" runat="server" Width="55px" Text="クリア" 
                                CssClass="ButtonList" TabIndex="147" />
                            <a style="color: #FF0000; font-weight: bold">※回答欄入力済の場合はコピーできません</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_IRAINAIYOU_5" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_F_STATUS_5" runat="server" TabIndex="148" Width="148px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_KOTSUKIKAN_5" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通機関
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_F_KOTSUKIKAN_5" runat="server" TabIndex="149" Width="148px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_DATE_5" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_DATE_5" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="150"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_F_AIRPORT1_5" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
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
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="151"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT2_5" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="152"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TIME1_5" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
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
                                Height="18px" Width="148px" TabIndex="153"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME2_5" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="154"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
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
                            <asp:TextBox ID="ANS_F_BIN_5" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="155"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_SEAT_5" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_SEAT_KIBOU5" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_5" runat="server" TabIndex="156">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席位置
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_KIBOU5" runat="server" TabIndex="157">
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
						<td align="left" valign="middle" class="TdTitleFukuro" colspan="5">
							■交通備考
                        </td>
					</tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro">
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
							<div style="font-weight: bold; color: #2424f0;" id="Div2" runat="server">
								ダブルクォーテーション「”」・改行(Enterキー)は入力できません。
							</div>
                            <asp:TextBox ID="ANS_KOTSU_BIKO" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="68px" Width="445px" TabIndex="158"></asp:TextBox>                            
                        </td>
                    </tr>
				</table>
		    </td>
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
                <a name="TaxiTehaiLink"></a>				    
			    <a href="#PageTopLink" TabIndex="159">ページトップへ</a>
		    </td>
		</tr>		
		<tr runat="server" id="TB_TAXI_1">
		    <td align="left"  colspan="2">
				<!-- タクチケ手配 -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleTaxi" style="width:170px">
							タクチケ手配
                        </td>
                        <td align="left" valign="middle" class="TdItem"  colspan="5">
							<asp:Label ID="TEHAI_TAXI" runat="server" Width="120px"></asp:Label>
            				<asp:Button ID="BtnTicketCopy" runat="server" Width="55px" Text="コピー" 
                                CssClass="ButtonList" TabIndex="160" />
            				<asp:Button ID="BtnTicketClear" runat="server" Width="55px" Text="クリア" 
                                CssClass="ButtonList" TabIndex="161" />
                            <a style="color: #FF0000; font-weight: bold">※回答欄入力済の場合はコピーできません</a>							
                        </td>
						<td align="left" valign="middle" class="TdTitleTaxi" style="width:170px">
							スキャンデータ取込日
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="SCAN_IMPORT_DATE" runat="server" Width="80px"></asp:Label>
                        </td>
					</tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" colspan="8">
                            ■タクチケ備考
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" colspan="4">
                            ◆依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ◆回答内容
            			</td>
                    </tr>
					<tr>
						<td align="left" valign="middle" class="TdTitleTaxi" style="width:170px">
							備考
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_NOTE" runat="server" MaxLength="255" 
                                ReadOnly="true" TextMode="MultiLine" Height="68px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>                            
                        </td>
						<td align="left" valign="middle" class="TdTitle" style="width:170px">
							NOZOMIへ<br />備考
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<div style="font-weight: bold; color: #2424f0;" id="Div3" runat="server">
								ダブルクォーテーション「”」・改行(Enterキー)は入力できません。
							</div>
                            <asp:TextBox ID="ANS_TAXI_NOTE" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="68px" Width="344px" TabIndex="162"></asp:TextBox>                            
                        </td>
					</tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" colspan="4">
                            ◆行程１
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ◆タクシーチケット１
            				</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            				<asp:Button ID="BtnTicketClear1" runat="server" Width="130px" Text="タクチケ1クリア" 
                                CssClass="ButtonList" TabIndex="161" />                            
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_1" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_1" runat="server" TabIndex="163" 
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
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
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
                                Height="18px" Width="85px" TabIndex="164"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_1" runat="server" TabIndex="165">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
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
                                Width="79px" TabIndex="166" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            トップ社内(備考)
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_1" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="167" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" colspan="4">
                            ◆行程２
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ◆タクシーチケット２
            				</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            				<asp:Button ID="BtnTicketClear2" runat="server" Width="130px" Text="タクチケ2クリア" 
                                CssClass="ButtonList" TabIndex="161" />                            
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_2" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_2" runat="server" TabIndex="168" Text="発行対象" />
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
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
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
                                Height="18px" Width="85px" TabIndex="169"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_2" runat="server" TabIndex="170">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
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
                                Width="79px" TabIndex="171" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            トップ社内(備考)
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_2" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="172" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" colspan="4">
                            ◆行程３
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ◆タクシーチケット３
            				</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            				<asp:Button ID="BtnTicketClear3" runat="server" Width="130px" Text="タクチケ3クリア" 
                                CssClass="ButtonList" TabIndex="161" />                            
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_3" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_3" runat="server" TabIndex="173" Text="発行対象" />
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
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
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
                                Height="18px" Width="85px" TabIndex="174"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_3" runat="server" TabIndex="175">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
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
                                Width="79px" TabIndex="176" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            トップ社内(備考)
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_3" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="177" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" colspan="4">
                            ◆行程４
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ◆タクシーチケット４
            				</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            				<asp:Button ID="BtnTicketClear4" runat="server" Width="130px" Text="タクチケ4クリア" 
                                CssClass="ButtonList" TabIndex="161" />                            
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_4" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_4" runat="server" TabIndex="178" Text="発行対象" />
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
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
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
                                Height="18px" Width="85px" TabIndex="179"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_4" runat="server" TabIndex="180">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
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
                                Width="79px" TabIndex="181" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            トップ社内(備考)
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_4" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="182" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" colspan="4">
                            ◆行程５
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ◆タクシーチケット５
            				</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            				<asp:Button ID="BtnTicketClear5" runat="server" Width="130px" Text="タクチケ5クリア" 
                                CssClass="ButtonList" TabIndex="161" />                            
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_5" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_5" runat="server" TabIndex="183" Text="発行対象" />
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
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
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
                                Height="18px" Width="85px" TabIndex="184"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_5" runat="server" TabIndex="185">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
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
                                Width="79px" TabIndex="186" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            トップ社内(備考)
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_5" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="187" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" colspan="4">
                            ◆行程６
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ◆タクシーチケット６
            				</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            				<asp:Button ID="BtnTicketClear6" runat="server" Width="130px" Text="タクチケ6クリア" 
                                CssClass="ButtonList" TabIndex="161" />                            
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_6" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_6" runat="server" TabIndex="188" Text="発行対象" />
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
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
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
                                Height="18px" Width="85px" TabIndex="189"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_6" runat="server" TabIndex="190">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
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
                                Width="79px" TabIndex="191" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            トップ社内(備考)
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_6" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="192" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" colspan="4">
                            ◆行程７
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ◆タクシーチケット７
            				</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            				<asp:Button ID="BtnTicketClear7" runat="server" Width="130px" Text="タクチケ7クリア" 
                                CssClass="ButtonList" TabIndex="161" />                            
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_7" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_7" runat="server" TabIndex="193" Text="発行対象" />
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
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
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
                                Height="18px" Width="85px" TabIndex="194"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_7" runat="server" TabIndex="195">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
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
                                Width="79px" TabIndex="196" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            トップ社内(備考)
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_7" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="197" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" colspan="4">
                            ◆行程８
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ◆タクシーチケット８
            				</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            				<asp:Button ID="BtnTicketClear8" runat="server" Width="130px" Text="タクチケ8クリア" 
                                CssClass="ButtonList" TabIndex="161" />                            
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_8" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_8" runat="server" TabIndex="198" Text="発行対象" />
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
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
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
                                Height="18px" Width="85px" TabIndex="199"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_8" runat="server" TabIndex="200">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
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
                                Width="79px" TabIndex="201" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            トップ社内(備考)
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_8" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="202" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" colspan="4">
                            ◆行程９
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ◆タクシーチケット９
            				</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            				<asp:Button ID="BtnTicketClear9" runat="server" Width="130px" Text="タクチケ9クリア" 
                                CssClass="ButtonList" TabIndex="161" />                            
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_9" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_9" runat="server" TabIndex="203" Text="発行対象" />
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
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
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
                                Height="18px" Width="85px" TabIndex="204"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_9" runat="server" TabIndex="205">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
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
                                Width="79px" TabIndex="206" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            トップ社内(備考)
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_9" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="207" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" colspan="4">
                            ◆行程１０
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ◆タクシーチケット１０
            				</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            				<asp:Button ID="BtnTicketClear10" runat="server" Width="130px" Text="タクチケ10クリア" 
                                CssClass="ButtonList" TabIndex="161" />                            
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_10" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_10" runat="server" TabIndex="208" Text="発行対象" />
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
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
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
                                Height="18px" Width="85px" TabIndex="209"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_10" runat="server" TabIndex="210">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
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
                                Width="79px" TabIndex="211" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            トップ社内(備考)
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_10" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="212" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4" rowspan="40">
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ◆タクシーチケット１１
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            				<asp:Button ID="BtnTicketClear11" runat="server" Width="130px" Text="タクチケ11クリア" 
                                CssClass="ButtonList" TabIndex="161" />                            
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_11" runat="server" TabIndex="213" Text="発行対象" />
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
                                Height="18px" Width="85px" TabIndex="214"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_11" runat="server" TabIndex="215">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_11" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="216" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            トップ社内(備考)
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_11" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="217" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ◆タクシーチケット１２
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            				<asp:Button ID="BtnTicketClear12" runat="server" Width="130px" Text="タクチケ12クリア" 
                                CssClass="ButtonList" TabIndex="161" />                            
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_12" runat="server" TabIndex="218" Text="発行対象" />
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
                                Height="18px" Width="85px" TabIndex="219"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_12" runat="server" TabIndex="220">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_12" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="221" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            トップ社内(備考)
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_12" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="222" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ◆タクシーチケット１３
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            				<asp:Button ID="BtnTicketClear13" runat="server" Width="130px" Text="タクチケ13クリア" 
                                CssClass="ButtonList" TabIndex="161" />                            
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_13" runat="server" TabIndex="223" Text="発行対象" />
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
                                Height="18px" Width="85px" TabIndex="224"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_13" runat="server" TabIndex="225">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_13" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="226" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            トップ社内(備考)
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_13" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="227" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ◆タクシーチケット１４
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            				<asp:Button ID="BtnTicketClear14" runat="server" Width="130px" Text="タクチケ14クリア" 
                                CssClass="ButtonList" TabIndex="161" />                            
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_14" runat="server" TabIndex="228" Text="発行対象" />
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
                                Height="18px" Width="85px" TabIndex="229"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_14" runat="server" TabIndex="230">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_14" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="231" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            トップ社内(備考)
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_14" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="232" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ◆タクシーチケット１５
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            				<asp:Button ID="BtnTicketClear15" runat="server" Width="130px" Text="タクチケ15クリア" 
                                CssClass="ButtonList" TabIndex="161" />                            
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_15" runat="server" TabIndex="233" Text="発行対象" />
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
                                Height="18px" Width="85px" TabIndex="234"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_15" runat="server" TabIndex="235">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_15" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="236" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            トップ社内(備考)
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_15" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="237" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ◆タクシーチケット１６
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            				<asp:Button ID="BtnTicketClear16" runat="server" Width="130px" Text="タクチケ16クリア" 
                                CssClass="ButtonList" TabIndex="161" />                            
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_16" runat="server" TabIndex="238" Text="発行対象" />
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
                                Height="18px" Width="85px" TabIndex="239"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_16" runat="server" TabIndex="240">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_16" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="241" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            トップ社内(備考)
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_16" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="242" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ◆タクシーチケット１７
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            				<asp:Button ID="BtnTicketClear17" runat="server" Width="130px" Text="タクチケ17クリア" 
                                CssClass="ButtonList" TabIndex="161" />                            
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_17" runat="server" TabIndex="243" Text="発行対象" />
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
                                Height="18px" Width="85px" TabIndex="244"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_17" runat="server" TabIndex="245">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_17" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="246" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            トップ社内(備考)
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_17" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="247" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ◆タクシーチケット１８
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            				<asp:Button ID="BtnTicketClear18" runat="server" Width="130px" Text="タクチケ18クリア" 
                                CssClass="ButtonList" TabIndex="161" />                            
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_18" runat="server" TabIndex="248" Text="発行対象" />
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
                                Height="18px" Width="85px" TabIndex="249"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_18" runat="server" TabIndex="250">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_18" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="251" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            トップ社内(備考)
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_18" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="252" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ◆タクシーチケット１９
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            				<asp:Button ID="BtnTicketClear19" runat="server" Width="130px" Text="タクチケ19クリア" 
                                CssClass="ButtonList" TabIndex="161" />                            
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_19" runat="server" TabIndex="253" Text="発行対象" />
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
                                Height="18px" Width="85px" TabIndex="254"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_19" runat="server" TabIndex="255">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_19" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="256" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            トップ社内(備考)
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_19" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="257" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ◆タクシーチケット２０
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            				<asp:Button ID="BtnTicketClear20" runat="server" Width="130px" Text="タクチケ20クリア" 
                                CssClass="ButtonList" TabIndex="161" />                            
            			</td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            発行
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_20" runat="server" TabIndex="258" Text="発行対象" />
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
                                Height="18px" Width="85px" TabIndex="259"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            券種</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_20" runat="server" TabIndex="260">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            番号
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_20" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="261" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            トップ社内(備考)
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_20" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="262" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" TabIndex="263">ページトップへ</a>
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
                        <td align="left" valign="middle" class="TdItem" colspan="2">
                            <asp:TextBox ID="ANS_HOTELHI" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="264" AutoPostBack="True"></asp:TextBox>円                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            航空券代(税込)
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="2">
                            <asp:TextBox ID="ANS_AIR_FARE" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="270"></asp:TextBox>円                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle">
                            DR宿泊東京都税
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="2">
                            <asp:TextBox ID="ANS_HOTELHI_TOZEI" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="265"></asp:TextBox>円                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            航空券取消料(税込)
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="2">
                            <asp:TextBox ID="ANS_AIR_CANCELLATION" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="271"></asp:TextBox>円                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle">
                            DR宿泊取消料(税込)
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="2">
                            <asp:TextBox ID="ANS_HOTELHI_CANCEL" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="267"></asp:TextBox>円                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            JR券代(税込)
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="2">
                            <asp:TextBox ID="ANS_RAIL_FARE" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="272"></asp:TextBox>円                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle">
                            登録手数料（交通・宿泊）
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_KOTSUHOTEL_TESURYO" runat="server" Text="手数料あり" 
                                TabIndex="268" AutoPostBack="True" />
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:Label ID="ANS_KOTSUHOTEL_TESURYO" runat="server"></asp:Label>円
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            JR券取消料(税込)
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="2">
                            <asp:TextBox ID="ANS_RAIL_CANCELLATION" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="273"></asp:TextBox>円                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle">
                            タクチケ発行枚数
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_MAISUU" runat="server" MaxLength="3" 
                                Height="18px" Width="35px" TabIndex="269" AutoPostBack="True"></asp:TextBox>枚
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:Label ID="ANS_TAXI_TESURYO" runat="server"></asp:Label>円
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            その他鉄道代等(税込)
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="2">
                            <asp:TextBox ID="ANS_OTHER_FARE" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="274"></asp:TextBox>円                            
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3"></td>
                        <td align="left" valign="middle" class="TdTitle">
                            その他鉄道代等取消料(税込)
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="2">
                            <asp:TextBox ID="ANS_OTHER_CANCELLATION" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="275"></asp:TextBox>円                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleMR">
                            MR宿泊費(税込)
                        </td>
                        <td align="left" valign="top" class="TdItem" colspan="2">
                            <asp:TextBox ID="ANS_MR_HOTELHI" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="276" AutoPostBack="True" 
                                Enabled="False"></asp:TextBox>円                            
                        </td>
                        <td align="left" valign="middle" class="TdTitleMR">
                            MR交通費(税込)
                        </td>
                        <td align="left" valign="top" class="TdItem" colspan="2">
                            <asp:TextBox ID="ANS_MR_KOTSUHI" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="278"></asp:TextBox>円                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleMR">
                            MR宿泊東京都税
                        </td>
                        <td align="left" valign="top" class="TdItem" colspan="5">
                            <asp:TextBox ID="ANS_MR_HOTELHI_TOZEI" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="277" Enabled="False"></asp:TextBox>円                            
                        </td>
                    </tr>
				</table>
		    </td>
		</tr>
		    
		<div class="FontSize1" style="height: 10px;"></div>
		<table cellspacing="0" cellpadding="0" border="0" style="width:900px;">
			<tr style="height: 36px; width:100%">
				<td align="left" style="width:100%">
				    <asp:Button ID="BtnRireki" runat="server" Width="130px" Text="履歴表示" 
                        CssClass="Button" TabIndex="279" />
                </td>
            </tr>
            <tr align="left" style="width:100%">
                <td>
					<asp:Button ID="BtnPrint2" runat="server" Width="130px" Text="手配書印刷" 
                        CssClass="Button" TabIndex="280" />
					<asp:Button ID="BtnSoufujo2" runat="server" Width="130px" Text="送付状印刷" 
                        CssClass="Button" TabIndex="281" />
					<asp:Button ID="BtnTaxiKakunin2" runat="server" Width="150px" Text="タクチケ手配確認票印刷" 
                        CssClass="Button" TabIndex="282" />
				    <asp:Button ID="BtnSubmit2" runat="server" Width="130px" Text="登録" 
                        CssClass="Button" TabIndex="283" />
				    <asp:Button ID="BtnNozomi2" runat="server" Width="130px" Text="NOZOMIへ" 
                        CssClass="Button" TabIndex="284" />
					<asp:Button ID="BtnBack2" runat="server" Width="130px" Text="戻る" 
                        CssClass="Button" TabIndex="285" />
				</td>
			</tr>
		</table>
	</table>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">

		<style type="text/css">
            .style1
            {
                width: 900px;
            }
        </style>

</asp:Content>

