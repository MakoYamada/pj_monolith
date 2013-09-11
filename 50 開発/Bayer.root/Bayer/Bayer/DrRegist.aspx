<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="DrRegist.aspx.vb" Inherits="Bayer.DrRegist" MaintainScrollPositionOnPostback="true" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table border="0" cellpadding="4" cellspacing="0">
		<tr>
			<td align="left">
				<asp:Button ID="BtnCancel" runat="server" Width="150px" Text="参加取消" CssClass="ButtonCancel" />
				<asp:Image ID="ImgCanceled" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/Images/Canceled.png" />
			</td>
		</tr>
		<tr style="height: 10px;">
			<td class="FontSize1" colspan="2">&nbsp;</td>
		</tr>
		<tr>
			<td align="left">
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr id="Tr1" runat="server">
						<td align="left" class="TdTitleHeader" >
							講演会番号
						</td>
						<td align="left" class="style1">
							<asp:Label ID="KOUENKAI_NO" runat="server" Text="1234567890"></asp:Label>
						</td>
						<td align="left" style="width: 170px;" class="TdTitleHeader">
							実施日
						</td>
						<td align="left" class="TdItem" style="width: 710px;">
							<asp:Label ID="KOUENKAI_FROM_DATE" runat="server" Text="yyyy/mm/dd"></asp:Label>
							&nbsp;～&nbsp;
							<asp:Label ID="KOUENKAI_TO_DATE" runat="server" Text="yyyy/mm/dd"></asp:Label>
						</td>
					</tr>
					<tr id="Tr2" runat="server">
						<td align="left" class="TdTitleHeader" style="width:170px">
							会合名
						</td>
						<td align="left" colspan="3">
							<asp:Label ID="KOUENKAI_NAME" runat="server"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="left" class="TdTitleHeader" style="width:170px">
							チケット印字名
						</td>
						<td align="left" colspan="3">
							<asp:Label ID="TAXI_PRT_NAME" runat="server"></asp:Label>
						</td>
					</tr>
				</table>
			</td>
		</tr>

		<tr>
		    <td align="left">
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" class="TdTitleHeader" colspan="2">
                            講演会企画担当者
                        </td>
                    </tr>
	                <tr>
		                <td align="left" class="TdTitleHeader" style="width:170px">
			                事業部
		                </td>
		                <td align="left">
							<asp:Label ID="KIKAKU_TANTO_JIGYOBU" runat="server" Text="12345678901234567890123456789012345678901234567890"></asp:Label>
		                </td>
		            </tr>
		            <tr>
		                <td align="left" class="TdTitleHeader" style="width:170px">
			                エリア
		                </td>
		                <td align="left">
							<asp:Label ID="KIKAKU_TANTO_AREA" runat="server" Text="12345678901234567890123456789012345678901234567890"></asp:Label>
		                </td>
		            </tr>
		            <tr>
		                <td align="left" class="TdTitleHeader" style="width:170px">
			                営業所
		                </td>
		                <td align="left">
							<asp:Label ID="KIKAKU_TANTO_EIGYOSHO" runat="server" Text="12345678901234567890123456789012345678901234567890"></asp:Label>
		                </td>
	                </tr>
		            <tr>
                        <td align="left" class="TdTitleHeader" style="width:170px">
                            CWID
                        </td>
                        <td align="left">
				            <asp:Label ID="KIKAKU_TANTO_NO" runat="server" Text="1234567890"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="TdTitleHeader" style="width:170px">
                            氏名
                        </td>
                        <td align="left">
				            <asp:Label ID="KIKAKU_TANTO_NAME" runat="server" Text="1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890"></asp:Label>
                        </td>
	                </tr>
                    <tr>
                        <td align="left" class="TdTitleHeader" style="width:170px">
                            携帯電話
                        </td>
                        <td align="left">
				            <asp:Label ID="KIKAKU_TANTO_KEITAI" runat="server" Text="12345678901234567890"></asp:Label>
                        </td>
	                </tr>
                    <tr>
                        <td align="left" class="TdTitleHeader" style="width:170px">
                            アドレス
                        </td>
                        <td align="left">
				            <asp:Label ID="KIKAKU_TANTO_EMAIL" runat="server" Text="1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890"></asp:Label>
                        </td>
	                </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr>
		    <td align="left">
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" class="TdTitleHeader" colspan="2">
                            講演会手配担当者
                        </td>
                    </tr>
	                <tr>
		                <td align="left" class="TdTitleHeader" style="width:170px">
			                事業部
		                </td>
		                <td align="left">
							<asp:Label ID="TEHAI_TANTO_JIGYOBU" runat="server" Text="12345678901234567890123456789012345678901234567890"></asp:Label>
		                </td>
		            </tr>
		            <tr>
		                <td align="left" class="TdTitleHeader" style="width:170px">
			                エリア
		                </td>
		                <td align="left">
							<asp:Label ID="TEHAI_TANTO_AREA" runat="server" Text="12345678901234567890123456789012345678901234567890"></asp:Label>
		                </td>
		            </tr>
		            <tr>
		                <td align="left" class="TdTitleHeader" style="width:170px">
			                営業所
		                </td>
		                <td align="left">
							<asp:Label ID="TEHAI_TANTO_EIGYOSHO" runat="server" Text="12345678901234567890123456789012345678901234567890"></asp:Label>
		                </td>
	                </tr>
		            <tr>
                        <td align="left" class="TdTitleHeader" style="width:170px">
                            CWID
                        </td>
                        <td align="left">
				            <asp:Label ID="TEHAI_TANTO_NO" runat="server" Text="1234567890"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="TdTitleHeader" style="width:170px">
                            氏名
                        </td>
                        <td align="left">
				            <asp:Label ID="TEHAI_TANTO_NAME" runat="server" Text="1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890"></asp:Label>
                        </td>
	                </tr>
                    <tr>
                        <td align="left" class="TdTitleHeader" style="width:170px">
                            携帯電話
                        </td>
                        <td align="left">
				            <asp:Label ID="TEHAI_TANTO_KEITAI" runat="server" Text="12345678901234567890"></asp:Label>
                        </td>
	                </tr>
                    <tr>
                        <td align="left" class="TdTitleHeader" style="width:170px">
                            アドレス
                        </td>
                        <td align="left">
				            <asp:Label ID="TEHAI_TANTO_EMAIL" runat="server" Text="1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890"></asp:Label>
                        </td>
	                </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr>
		    <td align="left">
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" class="TdTitleHeader" colspan="2">
                            DR担当MR
                        </td>
                    </tr>
	                <tr>
		                <td align="left" class="TdTitleHeader" style="width:170px">
			                事業部
		                </td>
		                <td align="left">
							<asp:Label ID="Label1" runat="server" Text="12345678901234567890123456789012345678901234567890"></asp:Label>
		                </td>
		            </tr>
		            <tr>
		                <td align="left" class="TdTitleHeader" style="width:170px">
			                エリア
		                </td>
		                <td align="left">
							<asp:Label ID="Label2" runat="server" Text="12345678901234567890123456789012345678901234567890"></asp:Label>
		                </td>
		            </tr>
		            <tr>
		                <td align="left" class="TdTitleHeader" style="width:170px">
			                営業所
		                </td>
		                <td align="left">
							<asp:Label ID="Label3" runat="server" Text="12345678901234567890123456789012345678901234567890"></asp:Label>
		                </td>
	                </tr>
		            <tr>
                        <td align="left" class="TdTitleHeader" style="width:170px">
                            CWID
                        </td>
                        <td align="left">
				            <asp:Label ID="Label4" runat="server" Text="1234567890"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="TdTitleHeader" style="width:170px">
                            氏名
                        </td>
                        <td align="left">
				            <asp:Label ID="Label5" runat="server" Text="1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890"></asp:Label>
                        </td>
	                </tr>
                    <tr>
                        <td align="left" class="TdTitleHeader" style="width:170px">
                            携帯電話
                        </td>
                        <td align="left">
				            <asp:Label ID="Label6" runat="server" Text="12345678901234567890"></asp:Label>
                        </td>
	                </tr>
                    <tr>
                        <td align="left" class="TdTitleHeader" style="width:170px">
                            アドレス
                        </td>
                        <td align="left">
				            <asp:Label ID="Label7" runat="server" Text="1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890"></asp:Label>
                        </td>
	                </tr>
                    <tr>
                        <td align="left" class="TdTitleHeader" style="width:170px">
                            チケット<br />送付先
                        </td>
                        <td align="left">
                            <table border="0" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td align="left">
                                        FS名：
                                    </td>
                                    <td align="left">
            				            <asp:Label ID="MR_SEND_SAKI_FS" runat="server" Text="12345678901234567890123456789012345678901234567890"></asp:Label>                                    
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left">
                                        その他送付先：
                                    </td>
                                    <td align="left">
            				            <asp:Label ID="MR_SEND_SAKI_OTHER" runat="server" Text="12345678901234567890123456789012345678901234567890"></asp:Label>                                    
                                    </td>
                                </tr>
                            </table>
                        </td>
	                </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr>
		    <td align="left">
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" class="TdTitleHeader" colspan="8">
                            DR情報
                        </td>
                    </tr>
	                <tr>
		                <td align="left" class="TdTitleHeader" style="width:100px">
			                MPID
		                </td>
		                <td align="left">
							<asp:Label ID="DR_MPID" runat="server" Text="1234567890"></asp:Label>
		                </td>
		                <td align="left" class="TdTitleHeader" style="width:100px">
			                DRコード
		                </td>
		                <td align="left">
							<asp:Label ID="DR_CD" runat="server" Text="1234567890"></asp:Label>
		                </td>
		                <td align="left" class="TdTitleHeader" style="width:100px">
			                TimeStamp
		                </td>
		                <td align="left">
							<asp:Label ID="UPDATE_DATE" runat="server" Text="yyyy/MM/dd HH:mm;ss"></asp:Label>
		                </td>
		                <td align="left" class="TdTitleHeader" style="width:100px">
			                手配ステータス
		                </td>
		                <td align="left">
							<asp:Label ID="STATUS_TEHAI" runat="server" Text="1234567890"></asp:Label>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" class="TdTitleHeader" style="width:100px">
			                氏名
		                </td>
		                <td align="left" colspan="7">
							<asp:Label ID="DR_NAME" runat="server" Text="1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890"></asp:Label>
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
		    
<table border="1" bordercolor="#4f5b61" cellpadding="2" cellspacing="0" style="table-layout: fixed; border-collapse: collapse; width: 900px;">
	<tr>
		<td align="left"  class="TdTitle">
			ドクター氏名(漢字)
			<span class="Must">※</span>
		</td>
		<td align="left" colspan="2" class="TdItem" style="width: 730px;">
			<table border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td align="left">
						[姓]&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="DR_NAME_FIRST" runat="server" Width="200px" MaxLength="20"></asp:TextBox>
					</td>
					<td align="left">
						&nbsp;&nbsp;
						[名]&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="DR_NAME_LAST" runat="server" Width="200px" MaxLength="20"></asp:TextBox>
					</td>
				</tr>
			</table>
		</td>
	</tr>
	<tr>
		<td align="left" class="TdTitle">
			ドクター氏名(カナ)
			<span class="Must">※</span>
		</td>
		<td align="left" colspan="2" class="TdItem" style="width: 730px;">
			<table border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td align="left">
						[姓]&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="DR_NAME_KANA_FIRST" runat="server" Width="200px" MaxLength="20"></asp:TextBox>
					</td>
					<td align="left">
						&nbsp;&nbsp;
						[名]&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="DR_NAME_KANA_LAST" runat="server" Width="200px" MaxLength="20"></asp:TextBox>
					</td>
				</tr>
			</table>
		</td>
	</tr>
	<tr>
		<td align="left" class="style2">
			性別
			<span class="Must">※</span>
		</td>
		<td align="left" colspan="2" class="TdItem">
			<asp:RadioButton ID="SEX_Male" runat="server" Text="男性" GroupName="SEX" />
			&nbsp;&nbsp;&nbsp;
			<asp:RadioButton ID="SEX_Female" runat="server" Text="女性" GroupName="SEX" />
		</td>
	</tr>
	<tr>
		<td align="left" class="style2">
			都道府県
			<span class="Must">※</span>
		</td>
		<td align="left" colspan="2" class="TdItem">
			<asp:DropDownList ID="PREFECTURES_NO" runat="server" Width="150px"></asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td align="left" class="style2">
			施設・病院名称
			<span class="Must">※</span>
		</td>
		<td align="left" colspan="2" class="TdItem">
			<table border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td align="left">
						<asp:TextBox ID="SHISETSU_NAME" runat="server" Width="300px" MaxLength="50"></asp:TextBox>
					</td>
					<td align="left">
						<span class="Comment">
							&nbsp;&nbsp;
							当日の名札に反映されます。

						</span>
					</td>
				</tr>
			</table>
		</td>
	</tr>
	<tr>
		<td align="left" class="style2">
			施設・病院名称(カナ)
			<span class="Must">※</span>
		</td>
		<td align="left" colspan="2" class="TdItem">
			<asp:TextBox ID="SHISETSU_NAME_KANA" runat="server" Width="300px" MaxLength="50"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td align="left" class="style2">
			診療科

			<span class="Must">※</span>
		</td>
		<td align="left" colspan="2" class="TdItem">
			<asp:TextBox ID="KAMOKU" runat="server" Width="300px" MaxLength="50"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td align="left" class="style2">
			役職
		</td>
		<td align="left" colspan="2" class="TdItem">
			<asp:TextBox ID="YAKUSHOKU" runat="server" Width="300px" MaxLength="50"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td align="left" class="style2">
			年齢
			<span class="Must">※</span>
		</td>
		<td align="left" colspan="2" class="TdItem">
			<table border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td align="left">
						<asp:TextBox ID="AGE" runat="server" Width="30px" MaxLength="2"></asp:TextBox>
					</td>
					<td align="left">
						歳
					</td>
				</tr>
			</table>
		</td>
	</tr>
	<tr>
		<td align="left" class="style2">
			公務員／非公務員
			<span class="Must">※</span>
		</td>
		<td align="left" colspan="2" class="TdItem">
			<asp:RadioButton ID="PUBLIC_SERVANT_Yes" runat="server" Text="公務員" GroupName="PUBLIC_SERVANT" />
			&nbsp;&nbsp;&nbsp;
			<asp:RadioButton ID="PUBLIC_SERVANT_No" runat="server" Text="非公務員" GroupName="PUBLIC_SERVANT" />
		</td>
	</tr>
	<tr>
		<td align="left" class="style2">
			画像及び発言の二次使用
			<span class="Must">※</span>
		</td>
		<td align="left" colspan="2" class="TdItem">
			本セミナーにおける貴殿の肖像及び発言が記録されたビデオ、写真等の著作物につき、弊社の通常業務の範囲内で、<br />
			その二次使用（複製、翻案、修正を含む）を弊社に許可していただきたくお願い申し上げます。 
			<br />
			<asp:RadioButton ID="SECANDARY_USE_Yes" runat="server" Text="同意します" GroupName="SECANDARY_USE" />
			&nbsp;&nbsp;&nbsp;
			<asp:RadioButton ID="SECANDARY_USE_No" runat="server" Text="同意しません" GroupName="SECANDARY_USE" Visible="false" />
		</td>
	</tr>
	<tr id="TrTEHAI_HOTEL_0" runat="server">
		<td align="left" class="style2">
			宿泊手配

			<span class="Must">※</span>
		</td>
		<td align="left" colspan="2" class="TdItem" id="TdTEHAI_HOTEL_0" runat="server">
			<asp:RadioButton ID="TEHAI_HOTEL_Yes" runat="server" Text="依頼する" GroupName="TEHAI_HOTEL" AutoPostBack="true" />
			&nbsp;&nbsp;&nbsp;
			<asp:RadioButton ID="TEHAI_HOTEL_No" runat="server" Text="依頼しない" GroupName="TEHAI_HOTEL" AutoPostBack="true" />
		</td>
	</tr>
	<tr id="TrTEHAI_HOTEL_1" runat="server">
		<td align="left" class="style2">
			宿泊日
		</td>
		<td align="left" colspan="2" class="TdItem" id="TdTEHAI_HOTEL_1" runat="server">
			チェックイン日：

			<asp:Label ID="CHECK_IN" runat="server">11月9日(土)</asp:Label>
			&nbsp;&nbsp;&nbsp;
			チェックアウト日：

			<asp:Label ID="CHECK_OUT" runat="server">11月10日(日)</asp:Label>
			&nbsp;
			(1泊)
		</td>
	</tr>
	<tr id="TrTEHAI_HOTEL_2" runat="server">
		<td align="left" class="style2">
			おたばこ

		</td>
		<td align="left" colspan="2" class="TdItem" id="TdTEHAI_HOTEL_2" runat="server">
			<asp:RadioButton ID="HOTEL_SMOKING_No" runat="server" Text="禁煙" GroupName="HOTEL_SMOKING" />
			&nbsp;&nbsp;&nbsp;
			<asp:RadioButton ID="HOTEL_SMOKING_Yes" runat="server" Text="喫煙" GroupName="HOTEL_SMOKING" />
			&nbsp;&nbsp;
			<span class="Comment">ご希望に沿えない場合がございます。</span>
		</td>
	</tr>
	<tr id="TrTEHAI_HOTEL_3" runat="server">
		<td align="left" class="style2">
			宿泊備考欄

		</td>
		<td align="left" colspan="2" class="TdItem" id="TdTEHAI_HOTEL_5" runat="server">
			<asp:TextBox ID="NOTE_HOTEL" runat="server" Width="550px" MaxLength="500" TextMode="MultiLine"></asp:TextBox>
			<div class="FontSize1" style="height: 1px;"></div>
			<span class="Comment">宿泊についてのご希望があれば、ご記入ください。(他のドクターとの同室を希望、等)</span>
		</td>
	</tr>
	<tr id="TrTEHAI_HOTEL_4" runat="server">
		<td align="left" class="style2">
			同伴者の有無
		</td>
		<td align="left" colspan="2" class="TdItem" id="TdTEHAI_HOTEL_3" runat="server">
			<asp:RadioButton ID="ACCOMPANY_FLAG_Yes" runat="server" Text="同伴者 あり" GroupName="ACCOMPANY_FLAG" AutoPostBack="true" />
			&nbsp;&nbsp;&nbsp;
			<asp:RadioButton ID="ACCOMPANY_FLAG_No" runat="server" Text="同伴者 なし" GroupName="ACCOMPANY_FLAG" AutoPostBack="true" />
		</td>
	</tr>
	<tr id="TrTEHAI_HOTEL_5" runat="server">
		<td align="left" class="style2">
			同伴者に関する情報
		</td>
		<td align="left" colspan="2" class="TdItem" id="TdTEHAI_HOTEL_4" runat="server">
			<table border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td align="left">
						宿泊：

					</td>
					<td align="left">
						<asp:RadioButton ID="ACCOMPANY_STAY_Yes" runat="server" Text="有" GroupName="ACCOMPANY_STAY" AutoPostBack="true" />
						&nbsp;&nbsp;&nbsp;
						<asp:RadioButton ID="ACCOMPANY_STAY_No" runat="server" Text="無" GroupName="ACCOMPANY_STAY" AutoPostBack="true" />
						&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:Image ID="Image2" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/Images/download.gif" />
						<asp:HyperLink ID="HyperLink1" runat="server" Text="同伴者差額料金" NavigateUrl="~/Doc/Room.pdf" Target="pdf" CssClass="menulink"></asp:HyperLink>
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td align="left">
						<div id="DivACCOMPANY" runat="server" style="margin-left: 10px;">
							<table border="0" cellpadding="0" cellspacing="0">
								<tr>
									<td align="left">
										<span style="display: none;">
										宿泊日：

										<asp:CheckBox ID="ACCOMPANY_STAY_DATE" runat="server" Text="ドクターと同日程" Checked="true" />
										&nbsp;&nbsp;&nbsp;
										&nbsp;&nbsp;&nbsp;
										</span>
										部屋：

										<asp:CheckBox ID="ACCOMPANY_SAME_ROOM" runat="server" Text="ドクターと同室" AutoPostBack="true" />
									</td>
								</tr>
							</table>
							<table border="0" cellpadding="0" cellspacing="0" style="margin-top: 1px;" id="TblACCOMPANY" runat="server">
								<tr>
									<td align="left">
										同室者人数
										&nbsp;&nbsp;
									</td>
									<td align="left">
										大人：

										<asp:DropDownList ID="ACCOMPANY_ADULT_SU" runat="server" Width="50px" AutoPostBack="true">
											<asp:ListItem Text="---" Value="0"></asp:ListItem>
											<asp:ListItem Text="1人" Value="1"></asp:ListItem>
											<asp:ListItem Text="2人" Value="2"></asp:ListItem>
										</asp:DropDownList>
										&nbsp;&nbsp;&nbsp;
										小人：

										<asp:DropDownList ID="ACCOMPANY_CHILD_SU" runat="server" Width="50px" AutoPostBack="true">
											<asp:ListItem Text="---" Value="0"></asp:ListItem>
											<asp:ListItem Text="1人" Value="1"></asp:ListItem>
											<asp:ListItem Text="2人" Value="2"></asp:ListItem>
										</asp:DropDownList>
									</td>
								</tr>
								<tr>
									<td>&nbsp;</td>
									<td align="left">
										<table border="0" cellpadding="0" cellspacing="0" style="margin-top: 2px;">
											<tr valign="top">
												<td align="left">
													<table border="0" cellpadding="0" cellspacing="0" id="TblACCOMPANY_CHILD" runat="server">
														<tr id="TrACCOMPANY_CHILD_1" runat="server">
															<td align="left">
																&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
																小人
															</td>
															<td align="left">
																&nbsp;
																1人目
																&nbsp;
																年齢:
															</td>
															<td align="left">
																<asp:TextBox ID="ACCOMPANY_CHILD_AGE_1" runat="server" Width="30px" MaxLength="2"></asp:TextBox>
															</td>
															<td align="left">
																歳
																&nbsp;&nbsp;&nbsp;
																性別：

															</td>
															<td align="left">
																<asp:RadioButton ID="ACCOMPANY_CHILD_SEX_1_Male" runat="server" Text="男性" GroupName="ACCOMPANY_CHILD_SEX_1" />
																&nbsp;
																<asp:RadioButton ID="ACCOMPANY_CHILD_SEX_1_Female" runat="server" Text="女性" GroupName="ACCOMPANY_CHILD_SEX_1" />
															</td>
															<td align="left">
																&nbsp;&nbsp;&nbsp;
																ベッド：

															</td>
															<td align="left">
																<asp:RadioButton ID="ACCOMPANY_CHILD_BED_1_Yes" runat="server" Text="必要" GroupName="ACCOMPANY_CHILD_BED_1" AutoPostBack="true" />
																&nbsp;
																<asp:RadioButton ID="ACCOMPANY_CHILD_BED_1_No" runat="server" Text="不要(添い寝)" GroupName="ACCOMPANY_CHILD_BED_1" AutoPostBack="true" />
															</td>
														</tr>
														<tr id="TrACCOMPANY_CHILD_2" runat="server">
															<td></td>
															<td align="left">
																&nbsp;
																2人目
																&nbsp;
																年齢:
															</td>
															<td align="left">
																<asp:TextBox ID="ACCOMPANY_CHILD_AGE_2" runat="server" Width="30px" MaxLength="2"></asp:TextBox>
															</td>
															<td align="left">
																歳
																&nbsp;&nbsp;&nbsp;
																性別：

															</td>
															<td align="left">
																<asp:RadioButton ID="ACCOMPANY_CHILD_SEX_2_Male" runat="server" Text="男性" GroupName="ACCOMPANY_CHILD_SEX_2" />
																&nbsp;
																<asp:RadioButton ID="ACCOMPANY_CHILD_SEX_2_Female" runat="server" Text="女性" GroupName="ACCOMPANY_CHILD_SEX_2" />
															</td>
															<td align="left">
																&nbsp;&nbsp;&nbsp;
																ベッド：

															</td>
															<td align="left">
																<asp:RadioButton ID="ACCOMPANY_CHILD_BED_2_Yes" runat="server" Text="必要" GroupName="ACCOMPANY_CHILD_BED_2" AutoPostBack="true" />
																&nbsp;
																<asp:RadioButton ID="ACCOMPANY_CHILD_BED_2_No" runat="server" Text="不要(添い寝)" GroupName="ACCOMPANY_CHILD_BED_2" AutoPostBack="true" />
															</td>
														</tr>
													</table>
												</td>
											</tr>
										</table>
									</td>
								</tr>
							</table>
						</div>
					</td>
				</tr>
			</table>
			<asp:TextBox ID="NOTE_ACCOMPANY" runat="server" Width="550px" MaxLength="500" TextMode="MultiLine"></asp:TextBox>
			<div class="FontSize1" style="height: 1px;"></div>
			<span class="Comment">
				同伴者の詳細情報を記入してください。

			</span>
		</td>
	</tr>
	<tr id="TrSANKA_KUBUN" runat="server">
		<td align="left" class="style2">
			参加区分

		</td>
		<td align="left" colspan="2" class="TdItem">
			<asp:RadioButton ID="SANKA_KUBUN_Listener" runat="server" Text="参加Dr." GroupName="SANKA_KUBUN" />
			&nbsp;&nbsp;&nbsp;
			<asp:RadioButton ID="SANKA_KUBUN_Speaker" runat="server" Text="講師・座長" GroupName="SANKA_KUBUN" />
		</td>
	</tr>
	<tr>
		<td align="left" class="style2">
			情報交換会

			<span class="Must">※</span>
		</td>
		<td align="left" colspan="2" class="TdItem">
			<asp:RadioButton ID="PARTY_Yes" runat="server" Text="参加する" GroupName="PARTY" />
			&nbsp;&nbsp;&nbsp;
			<asp:RadioButton ID="PARTY_No" runat="server" Text="参加しない" GroupName="PARTY" />
		</td>
	</tr>
	<tr>
		<td align="left" class="style2">
			お車での来場
			<span class="Must">※</span>
		</td>
		<td align="left" colspan="2" class="TdItem">
			<asp:RadioButton ID="BYCAR_Yes" runat="server" Text="参加する" GroupName="BYCAR" />
			&nbsp;&nbsp;&nbsp;
			<asp:RadioButton ID="BYCAR_No" runat="server" Text="参加しない" GroupName="BYCAR" />
		</td>
	</tr>
	<tr id="TrTEHAI_KOTSU_00" runat="server">
		<td align="left" class="style2">
			公共交通手配

			<span class="Must">※</span>
		</td>
		<td align="left" colspan="2" class="TdItem" id="TdTEHAI_KOTSU_00" runat="server">
			<asp:RadioButton ID="TEHAI_KOTSU_Yes" runat="server" Text="依頼する" GroupName="TEHAI_KOTSU" AutoPostBack="true" />
			&nbsp;&nbsp;&nbsp;
			<asp:RadioButton ID="TEHAI_KOTSU_No" runat="server" Text="依頼しない" GroupName="TEHAI_KOTSU" AutoPostBack="true" />
		</td>
	</tr>
	<tr id="TrTEHAI_KOTSU_01" runat="server">
		<td align="center" class="Comment" colspan="3" style="font-weight: bold; background-color: #e1e8eb;">
			数字は英数半角で入力してください。<br />
			区間は空港名、または駅名を入力してください。<br />
			時間は英数半角4桁で入力してください。：は不要です。

		</td>
	</tr>
	<tr id="TrTEHAI_KOTSU_02" runat="server">
		<td align="left" class="style2">
			&nbsp;
		</td>
		<td class="TdTitle" style="width: 355px;" align="center">
			往路
		</td>
		<td class="TdTitle" style="width: 355px;" align="center">
			復路
		</td>
	</tr>
	<tr id="TrTEHAI_KOTSU_1" runat="server">
		<td align="left" class="style2" id="TdTEHAI_KOTSU_1" runat="server">
			交通手配１

		</td>
		<td align="left" class="TdItem" id="TdTEHAI_KOTSU_O_1" runat="server" valign="top">
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 2px;">
				<tr>
					<td align="left">
						<asp:RadioButton ID="O_KOTSU_KUBUN_1_AIR" runat="server" Text="航空便利用" GroupName="O_KOTSU_KUBUN_1" AutoPostBack="true" />
						&nbsp;&nbsp;&nbsp;
						<asp:RadioButton ID="O_KOTSU_KUBUN_1_JR" runat="server" Text="JR利用" GroupName="O_KOTSU_KUBUN_1" AutoPostBack="true" />
						&nbsp;&nbsp;&nbsp;
						<asp:RadioButton ID="O_KOTSU_KUBUN_1_None" runat="server" Text="利用なし" GroupName="O_KOTSU_KUBUN_1" AutoPostBack="true" />
					</td>
					<td align="left">
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;">
				<tr>
					<td align="left">
						乗車・搭乗日&nbsp;
					</td>
					<td align="left">
						<asp:DropDownList ID="O_DATE_1" runat="server" Width="110px"></asp:DropDownList>
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;">
				<tr>
					<td align="left">
						便名&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="O_BIN_1" runat="server" Width="250px" MaxLength="30"></asp:TextBox>
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;" id="TblO_AIRPORT_1" runat="server">
				<tr>
					<td align="left">
						区間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="O_AIRPORT1_1" runat="server" Width="105px" MaxLength="30"></asp:TextBox>
					</td>
					<td align="left">
						発
					</td>
					<td align="left">
						～

					</td>
					<td align="left">
						<asp:TextBox ID="O_AIRPORT2_1" runat="server" Width="105px" MaxLength="30"></asp:TextBox>
					</td>
					<td align="left">
						着
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;" id="TblO_EXPRESS_1" runat="server">
				<tr>
					<td align="left">
						新幹線・特急区間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="O_EXPRESS1_1" runat="server" Width="95px" MaxLength="30" AutoPostBack="true"></asp:TextBox>
					</td>
					<td align="left">
						発
					</td>
					<td align="left">
						～

					</td>
					<td align="left">
						<asp:TextBox ID="O_EXPRESS2_1" runat="server" Width="95px" MaxLength="30" AutoPostBack="true"></asp:TextBox>
					</td>
					<td align="left">
						着
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;" id="TblO_LOCAL_1" runat="server">
				<tr>
					<td align="left">
						乗車券区間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="O_LOCAL1_1" runat="server" Width="105px" MaxLength="30" AutoPostBack="true"></asp:TextBox>
					</td>
					<td align="left">
						発
					</td>
					<td align="left">
						～

					</td>
					<td align="left">
						<asp:TextBox ID="O_LOCAL2_1" runat="server" Width="105px" MaxLength="30" AutoPostBack="true"></asp:TextBox>
					</td>
					<td align="left">
						着
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;">
				<tr>
					<td align="left">
						発時間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="O_TIME1_1" runat="server" Width="50px" Maxlength="4"></asp:TextBox>
					</td>
					<td align="left">
						～

					</td>
					<td align="left">
						着時間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="O_TIME2_1" runat="server" Width="50px" Maxlength="4"></asp:TextBox>
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" id="TblO_SEAT_1" runat="server">
				<tr>
					<td align="left">
						座席希望&nbsp;
					</td>
					<td align="left">
						<asp:DropDownList ID="O_SEAT_1" runat="server" Width="100px" />
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" id="TblO_SEATCLASS_1" runat="server">
				<tr>
					<td align="left">
						座席区分&nbsp;
					</td>
					<td align="left">
						<asp:DropDownList ID="O_SEATCLASS_1" runat="server" Width="230px" />
					</td>
				</tr>
			</table>
		</td>
		<td align="left" class="TdItem" id="TdTEHAI_KOTSU_F_1" runat="server" valign="top">
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 2px;">
				<tr>
					<td align="left">
						<asp:RadioButton ID="F_KOTSU_KUBUN_1_AIR" runat="server" Text="航空便利用" GroupName="F_KOTSU_KUBUN_1" AutoPostBack="true" />
						&nbsp;&nbsp;&nbsp;
						<asp:RadioButton ID="F_KOTSU_KUBUN_1_JR" runat="server" Text="JR利用" GroupName="F_KOTSU_KUBUN_1" AutoPostBack="true" />
						&nbsp;&nbsp;&nbsp;
						<asp:RadioButton ID="F_KOTSU_KUBUN_1_None" runat="server" Text="利用なし" GroupName="F_KOTSU_KUBUN_1" AutoPostBack="true" />
					</td>
					<td align="left">
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;">
				<tr>
					<td align="left">
						乗車・搭乗日&nbsp;
					</td>
					<td align="left">
						<asp:DropDownList ID="F_DATE_1" runat="server" Width="110px"></asp:DropDownList>
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;">
				<tr>
					<td align="left">
						便名&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="F_BIN_1" runat="server" Width="250px" MaxLength="30"></asp:TextBox>
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;" id="TblF_AIRPORT_1" runat="server">
				<tr>
					<td align="left">
						区間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="F_AIRPORT1_1" runat="server" Width="105px" MaxLength="30"></asp:TextBox>
					</td>
					<td align="left">
						発
					</td>
					<td align="left">
						～

					</td>
					<td align="left">
						<asp:TextBox ID="F_AIRPORT2_1" runat="server" Width="105px" MaxLength="30"></asp:TextBox>
					</td>
					<td align="left">
						着
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;" id="TblF_EXPRESS_1" runat="server">
				<tr>
					<td align="left">
						新幹線・特急区間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="F_EXPRESS1_1" runat="server" Width="95px" MaxLength="30" AutoPostBack="true"></asp:TextBox>
					</td>
					<td align="left">
						発
					</td>
					<td align="left">
						～

					</td>
					<td align="left">
						<asp:TextBox ID="F_EXPRESS2_1" runat="server" Width="95px" MaxLength="30" AutoPostBack="true"></asp:TextBox>
					</td>
					<td align="left">
						着
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;" id="TblF_LOCAL_1" runat="server">
				<tr>
					<td align="left">
						乗車券区間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="F_LOCAL1_1" runat="server" Width="105px" MaxLength="30" AutoPostBack="true"></asp:TextBox>
					</td>
					<td align="left">
						発
					</td>
					<td align="left">
						～

					</td>
					<td align="left">
						<asp:TextBox ID="F_LOCAL2_1" runat="server" Width="105px" MaxLength="30" AutoPostBack="true"></asp:TextBox>
					</td>
					<td align="left">
						着
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;">
				<tr>
					<td align="left">
						発時間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="F_TIME1_1" runat="server" Width="50px" Maxlength="4"></asp:TextBox>
					</td>
					<td align="left">
						～

					</td>
					<td align="left">
						着時間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="F_TIME2_1" runat="server" Width="50px" Maxlength="4"></asp:TextBox>
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" id="TblF_SEAT_1" runat="server">
				<tr>
					<td align="left">
						座席希望&nbsp;
					</td>
					<td align="left">
						<asp:DropDownList ID="F_SEAT_1" runat="server" Width="100px" />
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" id="TblF_SEATCLASS_1" runat="server">
				<tr>
					<td align="left">
						座席区分&nbsp;
					</td>
					<td align="left">
						<asp:DropDownList ID="F_SEATCLASS_1" runat="server" Width="230px" />
					</td>
				</tr>
			</table>
		</td>
	</tr>
	<tr id="TrTEHAI_KOTSU_2" runat="server">
		<td align="left" class="style2" id="TdTEHAI_KOTSU_2" runat="server">
			交通手配２

		</td>
		<td align="left" class="TdItem" id="TdTEHAI_KOTSU_O_2" runat="server" valign="top">
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 2px;">
				<tr>
					<td align="left">
						<asp:RadioButton ID="O_KOTSU_KUBUN_2_AIR" runat="server" Text="航空便利用" GroupName="O_KOTSU_KUBUN_2" AutoPostBack="true" />
						&nbsp;&nbsp;&nbsp;
						<asp:RadioButton ID="O_KOTSU_KUBUN_2_JR" runat="server" Text="JR利用" GroupName="O_KOTSU_KUBUN_2" AutoPostBack="true" />
						&nbsp;&nbsp;&nbsp;
						<asp:RadioButton ID="O_KOTSU_KUBUN_2_None" runat="server" Text="利用なし" GroupName="O_KOTSU_KUBUN_2" AutoPostBack="true" />
					</td>
					<td align="left">
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;">
				<tr>
					<td align="left">
						乗車・搭乗日&nbsp;
					</td>
					<td align="left">
						<asp:DropDownList ID="O_DATE_2" runat="server" Width="110px"></asp:DropDownList>
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;">
				<tr>
					<td align="left">
						便名&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="O_BIN_2" runat="server" Width="250px" MaxLength="30"></asp:TextBox>
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;" id="TblO_AIRPORT_2" runat="server">
				<tr>
					<td align="left">
						区間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="O_AIRPORT1_2" runat="server" Width="105px" MaxLength="30"></asp:TextBox>
					</td>
					<td align="left">
						発
					</td>
					<td align="left">
						～

					</td>
					<td align="left">
						<asp:TextBox ID="O_AIRPORT2_2" runat="server" Width="105px" MaxLength="30"></asp:TextBox>
					</td>
					<td align="left">
						着
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;" id="TblO_EXPRESS_2" runat="server">
				<tr>
					<td align="left">
						新幹線・特急区間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="O_EXPRESS1_2" runat="server" Width="95px" MaxLength="30" AutoPostBack="true"></asp:TextBox>
					</td>
					<td align="left">
						発
					</td>
					<td align="left">
						～

					</td>
					<td align="left">
						<asp:TextBox ID="O_EXPRESS2_2" runat="server" Width="95px" MaxLength="30" AutoPostBack="true"></asp:TextBox>
					</td>
					<td align="left">
						着
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;" id="TblO_LOCAL_2" runat="server">
				<tr>
					<td align="left">
						乗車券区間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="O_LOCAL1_2" runat="server" Width="105px" MaxLength="30" AutoPostBack="true"></asp:TextBox>
					</td>
					<td align="left">
						発
					</td>
					<td align="left">
						～

					</td>
					<td align="left">
						<asp:TextBox ID="O_LOCAL2_2" runat="server" Width="105px" MaxLength="30" AutoPostBack="true"></asp:TextBox>
					</td>
					<td align="left">
						着
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;">
				<tr>
					<td align="left">
						発時間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="O_TIME1_2" runat="server" Width="50px" Maxlength="4"></asp:TextBox>
					</td>
					<td align="left">
						～

					</td>
					<td align="left">
						着時間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="O_TIME2_2" runat="server" Width="50px" Maxlength="4"></asp:TextBox>
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" id="TblO_SEAT_2" runat="server">
				<tr>
					<td align="left">
						座席希望&nbsp;
					</td>
					<td align="left">
						<asp:DropDownList ID="O_SEAT_2" runat="server" Width="100px" />
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" id="TblO_SEATCLASS_2" runat="server">
				<tr>
					<td align="left">
						座席区分&nbsp;
					</td>
					<td align="left">
						<asp:DropDownList ID="O_SEATCLASS_2" runat="server" Width="230px" />
					</td>
				</tr>
			</table>
		</td>
		<td align="left" class="TdItem" id="TdTEHAI_KOTSU_F_2" runat="server" valign="top">
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 2px;">
				<tr>
					<td align="left">
						<asp:RadioButton ID="F_KOTSU_KUBUN_2_AIR" runat="server" Text="航空便利用" GroupName="F_KOTSU_KUBUN_2" AutoPostBack="true" />
						&nbsp;&nbsp;&nbsp;
						<asp:RadioButton ID="F_KOTSU_KUBUN_2_JR" runat="server" Text="JR利用" GroupName="F_KOTSU_KUBUN_2" AutoPostBack="true" />
						&nbsp;&nbsp;&nbsp;
						<asp:RadioButton ID="F_KOTSU_KUBUN_2_None" runat="server" Text="利用なし" GroupName="F_KOTSU_KUBUN_2" AutoPostBack="true" />
					</td>
					<td align="left">
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;">
				<tr>
					<td align="left">
						乗車・搭乗日&nbsp;
					</td>
					<td align="left">
						<asp:DropDownList ID="F_DATE_2" runat="server" Width="110px"></asp:DropDownList>
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;">
				<tr>
					<td align="left">
						便名&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="F_BIN_2" runat="server" Width="250px" MaxLength="30"></asp:TextBox>
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;" id="TblF_AIRPORT_2" runat="server">
				<tr>
					<td align="left">
						区間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="F_AIRPORT1_2" runat="server" Width="105px" MaxLength="30"></asp:TextBox>
					</td>
					<td align="left">
						発
					</td>
					<td align="left">
						～

					</td>
					<td align="left">
						<asp:TextBox ID="F_AIRPORT2_2" runat="server" Width="105px" MaxLength="30"></asp:TextBox>
					</td>
					<td align="left">
						着
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;" id="TblF_EXPRESS_2" runat="server">
				<tr>
					<td align="left">
						新幹線・特急区間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="F_EXPRESS1_2" runat="server" Width="95px" MaxLength="30" AutoPostBack="true"></asp:TextBox>
					</td>
					<td align="left">
						発
					</td>
					<td align="left">
						～

					</td>
					<td align="left">
						<asp:TextBox ID="F_EXPRESS2_2" runat="server" Width="95px" MaxLength="30" AutoPostBack="true"></asp:TextBox>
					</td>
					<td align="left">
						着
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;" id="TblF_LOCAL_2" runat="server">
				<tr>
					<td align="left">
						乗車券区間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="F_LOCAL1_2" runat="server" Width="105px" MaxLength="30" AutoPostBack="true"></asp:TextBox>
					</td>
					<td align="left">
						発
					</td>
					<td align="left">
						～

					</td>
					<td align="left">
						<asp:TextBox ID="F_LOCAL2_2" runat="server" Width="105px" MaxLength="30" AutoPostBack="true"></asp:TextBox>
					</td>
					<td align="left">
						着
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;">
				<tr>
					<td align="left">
						発時間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="F_TIME1_2" runat="server" Width="50px" Maxlength="4"></asp:TextBox>
					</td>
					<td align="left">
						～

					</td>
					<td align="left">
						着時間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="F_TIME2_2" runat="server" Width="50px" Maxlength="4"></asp:TextBox>
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" id="TblF_SEAT_2" runat="server">
				<tr>
					<td align="left">
						座席希望&nbsp;
					</td>
					<td align="left">
						<asp:DropDownList ID="F_SEAT_2" runat="server" Width="100px" />
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" id="TblF_SEATCLASS_2" runat="server">
				<tr>
					<td align="left">
						座席区分&nbsp;
					</td>
					<td align="left">
						<asp:DropDownList ID="F_SEATCLASS_2" runat="server" Width="230px" />
					</td>
				</tr>
			</table>
		</td>
	</tr>
	<tr id="TrTEHAI_KOTSU_3" runat="server">
		<td align="left" class="style2" id="TdTEHAI_KOTSU_3" runat="server">
			交通手配３

		</td>
		<td align="left" class="TdItem" id="TdTEHAI_KOTSU_O_3" runat="server" valign="top">
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 2px;">
				<tr>
					<td align="left">
						<asp:RadioButton ID="O_KOTSU_KUBUN_3_AIR" runat="server" Text="航空便利用" GroupName="O_KOTSU_KUBUN_3" AutoPostBack="true" />
						&nbsp;&nbsp;&nbsp;
						<asp:RadioButton ID="O_KOTSU_KUBUN_3_JR" runat="server" Text="JR利用" GroupName="O_KOTSU_KUBUN_3" AutoPostBack="true" />
						&nbsp;&nbsp;&nbsp;
						<asp:RadioButton ID="O_KOTSU_KUBUN_3_None" runat="server" Text="利用なし" GroupName="O_KOTSU_KUBUN_3" AutoPostBack="true" />
					</td>
					<td align="left">
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;">
				<tr>
					<td align="left">
						乗車・搭乗日&nbsp;
					</td>
					<td align="left">
						<asp:DropDownList ID="O_DATE_3" runat="server" Width="110px"></asp:DropDownList>
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;">
				<tr>
					<td align="left">
						便名&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="O_BIN_3" runat="server" Width="250px" MaxLength="30"></asp:TextBox>
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;" id="TblO_AIRPORT_3" runat="server">
				<tr>
					<td align="left">
						区間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="O_AIRPORT1_3" runat="server" Width="105px" MaxLength="30"></asp:TextBox>
					</td>
					<td align="left">
						発
					</td>
					<td align="left">
						～

					</td>
					<td align="left">
						<asp:TextBox ID="O_AIRPORT2_3" runat="server" Width="105px" MaxLength="30"></asp:TextBox>
					</td>
					<td align="left">
						着
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;" id="TblO_EXPRESS_3" runat="server">
				<tr>
					<td align="left">
						新幹線・特急区間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="O_EXPRESS1_3" runat="server" Width="95px" MaxLength="30" AutoPostBack="true"></asp:TextBox>
					</td>
					<td align="left">
						発
					</td>
					<td align="left">
						～

					</td>
					<td align="left">
						<asp:TextBox ID="O_EXPRESS2_3" runat="server" Width="95px" MaxLength="30" AutoPostBack="true"></asp:TextBox>
					</td>
					<td align="left">
						着
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;" id="TblO_LOCAL_3" runat="server">
				<tr>
					<td align="left">
						乗車券区間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="O_LOCAL1_3" runat="server" Width="105px" MaxLength="30" AutoPostBack="true"></asp:TextBox>
					</td>
					<td align="left">
						発
					</td>
					<td align="left">
						～

					</td>
					<td align="left">
						<asp:TextBox ID="O_LOCAL2_3" runat="server" Width="105px" MaxLength="30" AutoPostBack="true"></asp:TextBox>
					</td>
					<td align="left">
						着
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;">
				<tr>
					<td align="left">
						発時間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="O_TIME1_3" runat="server" Width="50px" Maxlength="4"></asp:TextBox>
					</td>
					<td align="left">
						～

					</td>
					<td align="left">
						着時間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="O_TIME2_3" runat="server" Width="50px" Maxlength="4"></asp:TextBox>
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" id="TblO_SEAT_3" runat="server">
				<tr>
					<td align="left">
						座席希望&nbsp;
					</td>
					<td align="left">
						<asp:DropDownList ID="O_SEAT_3" runat="server" Width="100px" />
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" id="TblO_SEATCLASS_3" runat="server">
				<tr>
					<td align="left">
						座席区分&nbsp;
					</td>
					<td align="left">
						<asp:DropDownList ID="O_SEATCLASS_3" runat="server" Width="230px" />
					</td>
				</tr>
			</table>
		</td>
		<td align="left" class="TdItem" id="TdTEHAI_KOTSU_F_3" runat="server" valign="top">
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 2px;">
				<tr>
					<td align="left">
						<asp:RadioButton ID="F_KOTSU_KUBUN_3_AIR" runat="server" Text="航空便利用" GroupName="F_KOTSU_KUBUN_3" AutoPostBack="true" />
						&nbsp;&nbsp;&nbsp;
						<asp:RadioButton ID="F_KOTSU_KUBUN_3_JR" runat="server" Text="JR利用" GroupName="F_KOTSU_KUBUN_3" AutoPostBack="true" />
						&nbsp;&nbsp;&nbsp;
						<asp:RadioButton ID="F_KOTSU_KUBUN_3_None" runat="server" Text="利用なし" GroupName="F_KOTSU_KUBUN_3" AutoPostBack="true" />
					</td>
					<td align="left">
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;">
				<tr>
					<td align="left">
						乗車・搭乗日&nbsp;
					</td>
					<td align="left">
						<asp:DropDownList ID="F_DATE_3" runat="server" Width="110px"></asp:DropDownList>
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;">
				<tr>
					<td align="left">
						便名&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="F_BIN_3" runat="server" Width="250px" MaxLength="30"></asp:TextBox>
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;" id="TblF_AIRPORT_3" runat="server">
				<tr>
					<td align="left">
						区間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="F_AIRPORT1_3" runat="server" Width="105px" MaxLength="30"></asp:TextBox>
					</td>
					<td align="left">
						発
					</td>
					<td align="left">
						～

					</td>
					<td align="left">
						<asp:TextBox ID="F_AIRPORT2_3" runat="server" Width="105px" MaxLength="30"></asp:TextBox>
					</td>
					<td align="left">
						着
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;" id="TblF_EXPRESS_3" runat="server">
				<tr>
					<td align="left">
						新幹線・特急区間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="F_EXPRESS1_3" runat="server" Width="95px" MaxLength="30" AutoPostBack="true"></asp:TextBox>
					</td>
					<td align="left">
						発
					</td>
					<td align="left">
						～

					</td>
					<td align="left">
						<asp:TextBox ID="F_EXPRESS2_3" runat="server" Width="95px" MaxLength="30" AutoPostBack="true"></asp:TextBox>
					</td>
					<td align="left">
						着
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;" id="TblF_LOCAL_3" runat="server">
				<tr>
					<td align="left">
						乗車券区間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="F_LOCAL1_3" runat="server" Width="105px" MaxLength="30" AutoPostBack="true"></asp:TextBox>
					</td>
					<td align="left">
						発
					</td>
					<td align="left">
						～

					</td>
					<td align="left">
						<asp:TextBox ID="F_LOCAL2_3" runat="server" Width="105px" MaxLength="30" AutoPostBack="true"></asp:TextBox>
					</td>
					<td align="left">
						着
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" style="margin-bottom: 1px;">
				<tr>
					<td align="left">
						発時間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="F_TIME1_3" runat="server" Width="50px" Maxlength="4"></asp:TextBox>
					</td>
					<td align="left">
						～

					</td>
					<td align="left">
						着時間&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="F_TIME2_3" runat="server" Width="50px" Maxlength="4"></asp:TextBox>
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" id="TblF_SEAT_3" runat="server">
				<tr>
					<td align="left">
						座席希望&nbsp;
					</td>
					<td align="left">
						<asp:DropDownList ID="F_SEAT_3" runat="server" Width="100px" />
					</td>
				</tr>
			</table>
			<table border="0" cellpadding="0" cellspacing="0" id="TblF_SEATCLASS_3" runat="server">
				<tr>
					<td align="left">
						座席区分&nbsp;
					</td>
					<td align="left">
						<asp:DropDownList ID="F_SEATCLASS_3" runat="server" Width="230px" />
					</td>
				</tr>
			</table>
		</td>
	</tr>
	<tr id="TrTEHAI_KOTSU_4" runat="server">
		<td align="left" class="style2">
			マイレージ
		</td>
		<td class="TdItem" align="left" id="TdTEHAI_KOTSU_4" runat="server" colspan="2">
			<table border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td align="left">
						航空会社：

					</td>
					<td align="left">
						<asp:RadioButton ID="AIRLINE_ANA" runat="server" Text="ANA" GroupName="AIRLINE" />
						&nbsp;&nbsp;&nbsp;
						<asp:RadioButton ID="AIRLINE_JAL" runat="server" Text="JAL" GroupName="AIRLINE" />
					</td>
					<td align="left">
						&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						マイレージナンバー：

					</td>
					<td align="left">
						<asp:TextBox ID="MILAGE_NO" runat="server" Width="200px" MaxLength="20"></asp:TextBox>
					</td>
				</tr>
			</table>
		</td>
	</tr>
	<tr id="TrTEHAI_KOTSU_5" runat="server">
		<td align="left" class="style2">
			交通希望欄

		</td>
		<td align="left" colspan="2" class="TdItem" id="TdTEHAI_KOTSU_5" runat="server">
			<asp:TextBox ID="NOTE_KOTSU" runat="server" Width="550px" MaxLength="500" TextMode="MultiLine"></asp:TextBox>
			<div class="FontSize1" style="height: 1px;"></div>
			<span class="Comment">交通についてのご希望があれば、ご記入ください。</span>
		</td>
	</tr>
	<tr>
		<td align="left" class="style2">
			チケット送付先
			<span class="Must">※</span>
		</td>
		<td align="left" colspan="2" class="TdItem" id="TdSEND_SAKI_0" runat="server">
			<asp:DropDownList ID="SEND_SAKI" runat="server" Width="220px" AutoPostBack="true"></asp:DropDownList>
		</td>
	</tr>
	<tr id="TrSEND_SAKI_1" runat="server">
		<td align="left" class="style2">
			&nbsp;&nbsp;&nbsp;送付先：住所
		</td>
		<td align="left" colspan="2" class="TdItem" id="TdSEND_SAKI_1" runat="server">
			<table border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td align="left">
						〒

					</td>
					<td align="left">
						<asp:TextBox ID="SEND_ZIP_1" runat="server" Width="35px" MaxLength="3"></asp:TextBox>
					</td>
					<td align="left">
						－

					</td>
					<td align="left">
						<asp:TextBox ID="SEND_ZIP_2" runat="server" Width="45px" MaxLength="4"></asp:TextBox>
					</td>
					<td align="left">
						&nbsp;&nbsp;&nbsp;
					</td>
					<td align="left">
						<asp:TextBox ID="SEND_ADDRESS" runat="server" Width="450px" MaxLength="50"></asp:TextBox>
					</td>
				</tr>
			</table>
		</td>
	</tr>
	<tr id="TrSEND_SAKI_2" runat="server">
		<td align="left" class="style2">
			&nbsp;&nbsp;&nbsp;送付先：宛先名

		</td>
		<td align="left" colspan="2" class="TdItem" id="TdSEND_SAKI_3" runat="server">
			<table border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td align="left">
						<asp:TextBox ID="SEND_NAME" runat="server" Width="500px" MaxLength="50"></asp:TextBox>
					</td>
					<td align="left">
						様

					</td>
				</tr>
			</table>
		</td>
	</tr>
	<tr id="TrSEND_SAKI_3" runat="server">
		<td align="left" class="style2">
			&nbsp;&nbsp;&nbsp;送付先：電話番号
		</td>
		<td align="left" colspan="2" class="TdItem" id="TdSEND_SAKI_4" runat="server">
			<table border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td align="left">
						<asp:TextBox ID="SEND_TEL_1" runat="server" Width="45px" MaxLength="4"></asp:TextBox>
					</td>
					<td align="left">
						－

					</td>
					<td align="left">
						<asp:TextBox ID="SEND_TEL_2" runat="server" Width="45px" MaxLength="4"></asp:TextBox>
					</td>
					<td align="left">
						－

					</td>
					<td align="left">
						<asp:TextBox ID="SEND_TEL_3" runat="server" Width="45px" MaxLength="4"></asp:TextBox>
					</td>
				</tr>
			</table>
		</td>
	</tr>
	<tr id="TrPAYMENT_METHOD" runat="server">
		<td align="left" class="style2">
			お支払い方法

		</td>
		<td align="left" colspan="2" class="TdItem">
			<asp:RadioButton ID="PAYMENT_METHOD_Card" runat="server" Text="クレジットカード" GroupName="PAYMENT_METHOD" />
			&nbsp;&nbsp;&nbsp;
			<asp:RadioButton ID="PAYMENT_METHOD_Bank" runat="server" Text="銀行振込" GroupName="PAYMENT_METHOD" />
		</td>
	</tr>
	<tr>
		<td align="left" class="style2">
			備考考考
		</td>
		<td align="left" colspan="2" class="TdItem">
			<asp:TextBox ID="NOTES" runat="server" Width="550px" MaxLength="500" TextMode="MultiLine"></asp:TextBox>
			<div class="FontSize1" style="height: 1px;"></div>
			<span class="Comment">その他のご連絡事項がございましたら、ご記入ください。</span>
		</td>
	</tr>
</table>
				<div class="FontSize1" style="height: 10px;"></div>
				<table style="width: 900px;" cellspacing="0" cellpadding="0" border="0">
					<tr style="height: 36px;">
						<td align="center">
							<asp:Button ID="BtnConfirm" runat="server" Width="150px" Text="確認画面へ" CssClass="Button" />
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
</asp:Content>
