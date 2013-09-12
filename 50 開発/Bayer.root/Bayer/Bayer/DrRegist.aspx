<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="DrRegist.aspx.vb" Inherits="Bayer.DrRegist" MaintainScrollPositionOnPostback="true" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            background-color: #738891;
            color: #ffffff;
            font-weight: bold;
            width: 170px;
            height: 21px;
        }
        .style2
        {
            height: 21px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table border="0" cellpadding="4" cellspacing="0" style="width:900px">
		<!-- 参加取消ボタン・NOZOMIボタン等 -->
		<tr>
			<td align="left">
				<asp:Button ID="BtnCancel" runat="server" Width="150px" Text="参加取消" CssClass="ButtonCancel" />
				<asp:Image ID="ImgCanceled" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/Images/Canceled.png" />
			</td>
			<td align="right">
				<asp:Button ID="BtnNozomi" runat="server" Width="150px" Text="NOZOMIへ" CssClass="Button" />
			</td>
		</tr>
		<tr style="height: 10px;">
			<td class="FontSize1" colspan="2">&nbsp;</td>
		</tr>
		<tr>
			<td align="left" colspan="2">
			    <!-- 講演会情報 -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            ■講演会情報
	                        <asp:Button ID="BtnKihon" runat="server" Width="150px" Text="基本情報へ" CssClass="Button" />
                        </td>
                    </tr>
					<tr id="Tr1" runat="server">
						<td align="left" class="TdTitleHeader" >
							講演会番号
						</td>
						<td align="left">
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
						<td align="left">
                            <asp:TextBox ID="KOUENKAI_NAME" runat="server" MaxLength="200" ReadOnly="True" 
                                TextMode="MultiLine"></asp:TextBox>
						</td>
						<td align="left" class="TdTitleHeader" style="width:170px">
							チケット印字名
						</td>
						<td align="left">
							<asp:Label ID="TAXI_PRT_NAME" runat="server" Text="1234567890"></asp:Label>
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
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="6">
                            ■DR担当MR
                        </td>
                    </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                事業部
		                </td>
		                <td align="left" valign="top" colspan="3">
				            <asp:Label ID="MR_JIGYOBU" runat="server" Text="12345678901234567890123456789012345678901234567890"></asp:Label>
		                </td>
		            </tr>
		            <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                エリア
		                </td>
		                <td align="left" valign="top">
                            <asp:TextBox ID="MR_AREA" runat="server" MaxLength="50" ReadOnly="True" 
                                TextMode="MultiLine" Height="23px" Width="263px"></asp:TextBox>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                営業所
		                </td>
		                <td align="left" valign="top">
                            <asp:TextBox ID="MR_EIGYOSHO" runat="server" MaxLength="50" ReadOnly="True" 
                                TextMode="MultiLine" Height="23px" Width="263px"></asp:TextBox>
		                </td>
		            </tr>
		            <tr>
                        <td align="left" valign="middle" class="style1">
                            CWID
                        </td>
                        <td align="left" valign="top" class="style2">
				            <asp:Label ID="MR_NO" runat="server" Text="1234567890"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="style1">
                            携帯電話
                        </td>
                        <td align="left" valign="top" class="style2">
				            <asp:Label ID="MR_KEITAI" runat="server" Text="12345678901234567890"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
                            氏名
                        </td>
                        <td align="left" valign="top" colspan="3">
				            <asp:Label ID="MR_NAME" runat="server" Text="1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
                            アドレス
                        </td>
                        <td align="left" valign="top" colspan="5">
				            <asp:Label ID="MR_EMAIL" runat="server" Text="1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890"></asp:Label>
                        </td>
	                </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
                            チケット<br />送付先
                        </td>
                        <td align="left" valign="top" colspan="5">
                            <table border="0" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td align="left" valign="top">
                                        FS名：
                                    </td>
                                    <td align="left" valign="top">
            				            <asp:Label ID="MR_SEND_SAKI_FS" runat="server" Text="12345678901234567890123456789012345678901234567890"></asp:Label>                                    
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" valign="top">
                                        その他送付先：
                                    </td>
                                    <td align="left" valign="top">
                                        <asp:TextBox ID="MR_SEND_SAKI_OTHER" runat="server" MaxLength="100" ReadOnly="True" 
                                            TextMode="MultiLine" Height="44px" Width="662px">1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
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
			                MPID
		                </td>
		                <td align="left" valign="top">
							<asp:Label ID="DR_MPID" runat="server" Text="1234567890"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                DRコード
		                </td>
		                <td align="left" valign="top">
							<asp:Label ID="DR_CD" runat="server" Text="1234567890"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                TimeStamp
		                </td>
		                <td align="left" valign="top">
							<asp:Label ID="UPDATE_DATE" runat="server" Text="yyyy/MM/dd HH:mm;ss"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                手配ステータス
		                </td>
		                <td align="left" valign="top">
							<asp:Label ID="STATUS_TEHAI" runat="server" Text="1234567890"></asp:Label>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                氏名
		                </td>
		                <td align="left" valign="top" colspan="3">
                            <asp:TextBox ID="DR_NAME" runat="server" MaxLength="100" ReadOnly="True" 
                                TextMode="MultiLine" Height="23px" Width="263px">1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                氏名カナ
		                </td>
		                <td align="left" valign="top" colspan="3">
                            <asp:TextBox ID="DR_KANA" runat="server" MaxLength="100" ReadOnly="True" 
                                TextMode="MultiLine" Height="23px" Width="263px">1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                性別
		                </td>
		                <td align="left" valign="top" colspan="3">
							<asp:Label ID="DR_SEX" runat="server" Text="M"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                講演会への参加（事後）
		                </td>
		                <td align="left" valign="top" colspan="3">
                            <asp:TextBox ID="DR_SANKA" runat="server" MaxLength="50" ReadOnly="True" 
                                TextMode="MultiLine" Height="23px" Width="263px">1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
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
			                承認者氏名
		                </td>
		                <td align="left" valign="top">
                            <asp:TextBox ID="SHONIN_NAME" runat="server" MaxLength="100" ReadOnly="True" 
                                TextMode="MultiLine" Height="23px" Width="388px">1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                承認日時
		                </td>
		                <td align="left" valign="top">
							<asp:Label ID="SHONIN_DATE" runat="server" Text="yyyy/MM/dd HH:mm;ss"></asp:Label>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                承認者備考
		                </td>
		                <td align="left" valign="top" colspan="3">
                            <asp:TextBox ID="SHONIN_NOTE" runat="server" MaxLength="1000" ReadOnly="True" 
                                TextMode="MultiLine" Height="23px" Width="784px">1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
		                </td>
		            </tr> 
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                CM承認者氏名
		                </td>
		                <td align="left" valign="top">
                            <asp:TextBox ID="CMSHONIN_NAME" runat="server" MaxLength="100" ReadOnly="True" 
                                TextMode="MultiLine" Height="23px" Width="388px">1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                CM承認日時
		                </td>
		                <td align="left" valign="top">
							<asp:Label ID="CMSHONIN_DATE" runat="server" Text="yyyy/MM/dd HH:mm;ss"></asp:Label>
		                </td>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                CM承認者備考
		                </td>
		                <td align="left" valign="top" colspan="3">
                            <asp:TextBox ID="CMSHONIN_NOTE" runat="server" MaxLength="1000" ReadOnly="True" 
                                TextMode="MultiLine" Height="23px" Width="784px">1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
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
							<asp:Label ID="TEHAI_HOTEL" runat="server" Text="希望する"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_STATUS_HOTEL" runat="server">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="HOTEL_IRAINAIYOU" runat="server" Text="手配依頼"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            施設名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_HOTEL_NAME" runat="server" MaxLength="200" 
                                TextMode="MultiLine" Height="23px" Width="267px">12345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
            				<asp:Button ID="BtnHotelKensaku" runat="server" Width="55px" Text="検索" 
                                CssClass="ButtonList" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            宿泊日
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_HOTEL_DATE" runat="server" Text="YY/MM/DD"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            泊数
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_HAKUSU" runat="server" Text="99"></asp:Label>
							&nbsp;&nbsp;泊
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            施設住所
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_HOTEL_ADDRESS" runat="server" MaxLength="200" 
                                TextMode="MultiLine" Height="23px" Width="344px">12345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            喫煙
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_HOTEL_SMOKING" runat="server" Text="禁煙"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            施設TEL
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_HOTEL_TEL" runat="server" MaxLength="20" 
                                Height="23px" Width="173px">12345678901234567890</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px" rowspan="6">
                            備考
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3" rowspan="6">
                            <asp:TextBox ID="REQ_HOTEL_NOTE" runat="server" MaxLength="1000" 
                                readonly="true" textmode="MultiLine" Height="180px" Width="321px">1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            チェックイン
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_CHECKIN_TIME" runat="server" MaxLength="4" 
                                Height="23px" Width="47px">1400</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            チェックアウト
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_CHECKOUT_TIME" runat="server" MaxLength="4" 
                                Height="23px" Width="47px">1200</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            宿泊日
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_HOTEL_DATE" runat="server" MaxLength="6" 
                                Height="23px" Width="67px">YYMMDD</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            泊数
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_HAKUSU" runat="server" MaxLength="2" 
                                Height="23px" Width="26px">99</asp:TextBox>
							&nbsp;&nbsp;泊                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            部屋タイプ
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_ROOM_TYPE" runat="server">
                            </asp:DropDownList>							
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            宿泊代金
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_ROOM_CHARGE" runat="server" MaxLength="10" 
                                Height="23px" Width="65px">999,999</asp:TextBox>
							&nbsp;&nbsp;円
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            喫煙
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:RadioButton ID="ANS_HOTEL_SMOKING_YES" runat="server" Text="喫煙" />&nbsp;&nbsp;&nbsp;
                            <asp:RadioButton ID="ANS_HOTEL_SMOKING_NO" runat="server" Text="禁煙" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            特記事項
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_HOTEL_NOTE" runat="server" MaxLength="1000" 
                                textmode="MultiLine" Height="62px" Width="347px">1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
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
							<asp:Label ID="REQ_O_TEHAI_1" runat="server" Text="希望する"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_O_STATUS_1" runat="server">
                            </asp:DropDownList>							
                        </td>
					</tr>
				</table>
		    </td>
		</tr>

		<tr runat="server" id="TB_KOTSU_1">
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
                                CssClass="ButtonList" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="7">
							<asp:Label ID="REQ_O_IRAINAIYOU_1" runat="server" Text="手配依頼"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            交通手段
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_KOTSUKIKAN_1" runat="server" Text="123456789012345678901234567890"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通手段
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_O_KOTSUKIKAN_1" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_DATE_1" runat="server" Text="YY/MM/DD"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_DATE_1" runat="server" MaxLength="6" 
                                Height="23px" Width="67px">YYMMDD</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_AIRPORT1_1" runat="server" MaxLength="60" 
                                readonly="true" textmode="MultiLine" Height="23px" Width="148px">123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_O_AIRPORT2_1" runat="server" MaxLength="60" 
                                readonly="true" textmode="MultiLine" Height="23px" Width="148px">123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT1_1" runat="server" MaxLength="60" 
                                textmode="MultiLine" Height="23px" Width="148px">123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT2_1" runat="server" MaxLength="60" 
                                textmode="MultiLine" Height="23px" Width="148px">123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_TIME1_1" runat="server" MaxLength="5" 
                                readonly="true" Height="23px" Width="148px">HH:MM</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_O_TIME2_1" runat="server" MaxLength="5" 
                                readonly="true" Height="23px" Width="148px">HH:MM</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME1_1" runat="server" MaxLength="4" 
                                Height="23px" Width="148px">HHMM</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME2_1" runat="server" MaxLength="4" 
                                Height="23px" Width="148px">HHMM</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_O_BIN_1" runat="server" MaxLength="100" 
                                ReadOnly="true" TextMode="MultiLine" Height="23px" Width="344px">1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_BIN_1" runat="server" MaxLength="100" 
                                TextMode="MultiLine" Height="23px" Width="344px">1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_SEAT_1" runat="server" MaxLength="20" 
                                readonly="true" Height="23px" Width="148px">12345678901234567890</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            年齢
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_O_AGE_1" runat="server" MaxLength="3" 
                                readonly="true" Height="23px" Width="33px">999</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_1" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            年齢
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AGE_1" runat="server" MaxLength="3" 
                                Height="23px" Width="33px">999</asp:TextBox>
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
							<asp:Label ID="REQ_O_TEHAI_2" runat="server" Text="希望する"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_O_STATUS_2" runat="server">
                            </asp:DropDownList>							
                        </td>
					</tr>
				</table>
		    </td>
		</tr>

		<tr runat="server" id="TB_KOTSU_2">
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
                                CssClass="ButtonList" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="7">
							<asp:Label ID="REQ_O_IRAINAIYOU_2" runat="server" Text="手配依頼"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            交通手段
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_KOTSUKIKAN_2" runat="server" Text="123456789012345678901234567890"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通手段
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_O_KOTSUKIKAN_2" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_DATE_2" runat="server" Text="YY/MM/DD"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_DATE_2" runat="server" MaxLength="6" 
                                Height="23px" Width="67px">YYMMDD</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_AIRPORT1_2" runat="server" MaxLength="60" 
                                readonly="true" textmode="MultiLine" Height="23px" Width="148px">123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_O_AIRPORT2_2" runat="server" MaxLength="60" 
                                readonly="true" textmode="MultiLine" Height="23px" Width="148px">123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT1_2" runat="server" MaxLength="60" 
                                textmode="MultiLine" Height="23px" Width="148px">123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT2_2" runat="server" MaxLength="60" 
                                textmode="MultiLine" Height="23px" Width="148px">123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_TIME1_2" runat="server" MaxLength="5" 
                                readonly="true" Height="23px" Width="148px">HH:MM</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_O_TIME2_2" runat="server" MaxLength="5" 
                                readonly="true" Height="23px" Width="148px">HH:MM</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME1_2" runat="server" MaxLength="4" 
                                Height="23px" Width="148px">HHMM</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME2_2" runat="server" MaxLength="4" 
                                Height="23px" Width="148px">HHMM</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_O_BIN_2" runat="server" MaxLength="100" 
                                ReadOnly="true" TextMode="MultiLine" Height="23px" Width="344px">1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_BIN_2" runat="server" MaxLength="100" 
                                TextMode="MultiLine" Height="23px" Width="344px">1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_SEAT_2" runat="server" MaxLength="20" 
                                readonly="true" Height="23px" Width="148px">12345678901234567890</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            年齢
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_O_AGE_2" runat="server" MaxLength="3" 
                                readonly="true" Height="23px" Width="33px">999</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_2" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            年齢
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AGE_2" runat="server" MaxLength="3" 
                                Height="23px" Width="33px">999</asp:TextBox>
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
							<asp:Label ID="REQ_O_TEHAI_3" runat="server" Text="希望する"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            回答ステータス
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_O_STATUS_3" runat="server">
                            </asp:DropDownList>							
                        </td>
					</tr>
				</table>
		    </td>
		</tr>

		<tr runat="server" id="TB_KOTSU_3">
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
                                CssClass="ButtonList" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            依頼内容
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="7">
							<asp:Label ID="REQ_O_IRAINAIYOU_3" runat="server" Text="手配依頼"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            交通手段
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_KOTSUKIKAN_3" runat="server" Text="123456789012345678901234567890"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            交通手段
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_O_KOTSUKIKAN_3" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_DATE_3" runat="server" Text="YY/MM/DD"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            利用日
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_DATE_3" runat="server" MaxLength="6" 
                                Height="23px" Width="67px">YYMMDD</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_AIRPORT1_3" runat="server" MaxLength="60" 
                                readonly="true" textmode="MultiLine" Height="23px" Width="148px">123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_O_AIRPORT2_3" runat="server" MaxLength="60" 
                                readonly="true" textmode="MultiLine" Height="23px" Width="148px">123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT1_3" runat="server" MaxLength="60" 
                                textmode="MultiLine" Height="23px" Width="148px">123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着地
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT2_3" runat="server" MaxLength="60" 
                                textmode="MultiLine" Height="23px" Width="148px">123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_TIME1_3" runat="server" MaxLength="5" 
                                readonly="true" Height="23px" Width="148px">HH:MM</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_O_TIME2_3" runat="server" MaxLength="5" 
                                readonly="true" Height="23px" Width="148px">HH:MM</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            出発時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME1_3" runat="server" MaxLength="4" 
                                Height="23px" Width="148px">HHMM</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            到着時刻
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME2_3" runat="server" MaxLength="4" 
                                Height="23px" Width="148px">HHMM</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_O_BIN_3" runat="server" MaxLength="100" 
                                ReadOnly="true" TextMode="MultiLine" Height="23px" Width="344px">1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            列車・便名
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_BIN_3" runat="server" MaxLength="100" 
                                TextMode="MultiLine" Height="23px" Width="344px">1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_SEAT_3" runat="server" MaxLength="20" 
                                readonly="true" Height="23px" Width="148px">12345678901234567890</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
                            年齢
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_O_AGE_3" runat="server" MaxLength="3" 
                                readonly="true" Height="23px" Width="33px">999</asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            座席区分
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_3" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            年齢
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AGE_3" runat="server" MaxLength="3" 
                                Height="23px" Width="33px">999</asp:TextBox>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		    
		<div class="FontSize1" style="height: 10px;"></div>
		<table style="width: 900px;" cellspacing="0" cellpadding="0" border="0">
			<tr style="height: 36px;">
				<td align="center">
					<asp:Button ID="BtnConfirm" runat="server" Width="150px" Text="確認画面へ" CssClass="Button" />
				</td>
			</tr>
		</table>
	</table>
</asp:Content>
