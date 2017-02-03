<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="TaxiMaintenanceRegist.aspx.vb" Inherits="Bayer_Past.TaxiMaintenanceRegist" MaintainScrollPositionOnPostback="true" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table border="0" cellpadding="4" cellspacing="0" width="900px">
        <tr>
            <td>
                <table cellpadding="2" cellspacing="0" border="0" width="100%">
                    <tr>
                        <td align="left">
                            <asp:Button ID="BtnBack1" runat="server" Text="戻る" Width="130px" 
                                CssClass="Button" TabIndex="1" />
                        </td>
                    </tr>
                </table> 
            </td>
        </tr>
		<tr>
			<td nowrap="nowrap" align="left">
				<table style="border-collapse: collapse;" cellspacing="0" cellpadding="2" border="1" bordercolor="#4f5b61" width="100%">
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" colspan="8">
							■ 会合情報
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							会合番号
						</td>
						<td nowrap="nowrap" align="left" style="width: 100px;" colspan="7">
							<asp:Label ID="KOUENKAI_NO" runat="server" Text=""></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							会合名
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
							会合開催日
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" >
							<asp:Label ID="KOUENKAI_DATE" runat="server" Text=""></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							TOP担当者
						</td>
						<td nowrap="nowrap" align="left" colspan="5">
							<asp:Label ID="TTEHAI_TANTO" runat="server" Text=""></asp:Label>
						</td>
					</tr>
				</table>
				<table id="TbFurikae" runat="server" style="border-collapse: collapse;" cellspacing="0" cellpadding="2" border="1" bordercolor="#4f5b61" width="100%">
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" colspan="8">
							■ 振替先会合情報
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							会合番号
						</td>
						<td nowrap="nowrap" align="left" style="width: 100px;" colspan="7">
		                    <asp:TextBox ID="KOUENKAI_NO_FURIKAE" runat="server" Width="124px" 
                                MaxLength="14"></asp:TextBox>							
                            <asp:Button ID="BtnKaigou" runat="server" Text="会合情報再表示" Width="130px" 
                                CssClass="Button" />
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							会合名
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="5">
						    <asp:TextBox ID="KOUENKAI_NAME_FURIKAE" runat="server" BorderStyle="None" Height="35px" 
                                ReadOnly="True" TextMode="MultiLine" Width="624px"></asp:TextBox>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							チケット印字名
							<br />
							(10文字)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" style="width: 95px;">
							<asp:Label ID="TAXI_PRT_NAME_FURIKAE" runat="server" Text=""></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 90px;">
							会合開催日
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" >
							<asp:Label ID="KOUENKAI_DATE_FURIKAE" runat="server" Text=""></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							TOP担当者
						</td>
						<td nowrap="nowrap" align="left" colspan="5">
							<asp:Label ID="TTEHAI_TANTO_FURIKAE" runat="server" Text=""></asp:Label>
						</td>
					</tr>
				</table>
			</td>
		</tr>
		<tr>
		    <td align="left"  colspan="2">
				<!-- DR情報 -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:100%">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="8">
                            ■DR情報
                        </td>
                    </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                参加者ID
		                </td>
		                <td align="left" valign="middle" colspan="7">							
		                    <asp:TextBox ID="SANKASHA_ID" runat="server" Width="124px" 
                                MaxLength="14"></asp:TextBox>							
                            <asp:Button ID="BtnSankasha" runat="server" Text="参加者再表示" Width="130px" 
                                CssClass="Button" />
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                氏名
		                </td>
		                <td align="left" valign="middle" colspan="7">
                            <asp:TextBox ID="DR_NAME" runat="server" MaxLength="80" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="750px" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                氏名カナ
		                </td>
		                <td align="left" valign="middle" colspan="7">
                            <asp:TextBox ID="DR_KANA" runat="server" MaxLength="80" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="750px" 
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
			                会合への参加
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
			                DCF<br />施設ｺｰﾄﾞ
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_SHISETSU_CD" runat="server"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                施設名
		                </td>
		                <td align="left" valign="middle" colspan="5">
                            <asp:TextBox ID="DR_SHISETSU_NAME" runat="server" MaxLength="80" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="341px" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                施設住所
		                </td>
		                <td align="left" valign="middle" colspan="7">
                            <asp:TextBox ID="DR_SHISETSU_ADDRESS" runat="server" MaxLength="128" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="750px" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                指定外<br />申請理由			                
		                </td>
		                <td align="left" valign="middle" colspan="7">
                            <asp:TextBox ID="SHITEIGAI_RIYU" runat="server" MaxLength="128" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="750px" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		            </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr>
			<td nowrap="nowrap" align="left">
				<table id="TbTaxi" runat="server" style="border-collapse: collapse; margin-bottom: 8px;" cellspacing="0" cellpadding="2" border="1" bordercolor="#4f5b61" width="100%">
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" colspan="8">
							■ タクチケ情報
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							回答行番号
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="TKT_LINE_NO" runat="server" Text="20"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							タクチケ番号
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="TKT_NO" runat="server" Text="123456789"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							タクシー会社
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="TKT_KAISHA" runat="server" Text="京交信"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							券種
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="TKT_KENSHU" runat="server" Text="NG10000"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							実車日
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="TKT_USED_DATE" runat="server" Text="1234/56/78"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							VOID(日)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="VOID_DATE" runat="server" Text="1234/56/78"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							請求年月
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="TKT_SEIKYU_YM" runat="server" Text="1234/56"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							VOID
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">							
						    <asp:CheckBox ID="TKT_VOID" runat="server" />							
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							実車発地
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="3">
							<asp:Label ID="TKT_HATUTI" runat="server" Text=""></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							実車着地
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="3">
							<asp:Label ID="TKT_CHAKUTI" runat="server" Text=""></asp:Label>
						</td>
					</tr>
			    </table>
				<table id="TbTaxiMaintenance" runat="server" style="border-collapse: collapse; margin-bottom: 8px;" cellspacing="0" cellpadding="2" border="1" bordercolor="#4f5b61" width="100%">
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" colspan="10">
							■ タクチケ情報
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							回答行番号
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
		                    <asp:TextBox ID="TKT_LINE_NO_2" runat="server" Width="29px" 
                                MaxLength="2"></asp:TextBox>							
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							タクチケ番号
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="TKT_NO_2" runat="server" Text="123456789"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							タクシー会社
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="TKT_KAISHA_2" runat="server" Text="京交信"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							券種
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="3">
							<asp:Label ID="TKT_KENSHU_2" runat="server" Text="NG10000"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							実車日
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
		                    <asp:TextBox ID="TKT_USED_DATE_2" runat="server" Width="77px" 
                                MaxLength="8"></asp:TextBox>							
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							請求年月
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
		                    <asp:TextBox ID="TKT_SEIKYU_YM_2" runat="server" Width="62px" 
                                MaxLength="6"></asp:TextBox>							
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							VOID(日)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="VOID_DATE_2" runat="server" Text=""></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							VOID
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="3">							
						    <asp:CheckBox ID="TKT_VOID_2" runat="server" />							
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							実車発地
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="3">
		                    <asp:TextBox ID="TKT_HATUTI_2" runat="server" Width="350px" 
                                MaxLength="100"></asp:TextBox>							
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							実車着地
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="5">
		                    <asp:TextBox ID="TKT_CHAKUTI_2" runat="server" Width="350px" 
                                MaxLength="100"></asp:TextBox>							
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							実車代金
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
		                    <asp:TextBox ID="TKT_URIAGE" runat="server" Width="94px" 
                                MaxLength="10"></asp:TextBox>							
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							精算手数料
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
		                    <asp:TextBox ID="TKT_SEISAN_FEE" runat="server" Width="94px" 
                                MaxLength="10"></asp:TextBox>							
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							発行手数料
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
		                    <asp:TextBox ID="TKT_HAKKO_FEE" runat="server" Width="94px" 
                                MaxLength="6"></asp:TextBox>							
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							ENTA
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">							
		                    <asp:TextBox ID="TKT_ENTA" runat="server" Width="20px" 
                                MaxLength="1"></asp:TextBox>							
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							精算番号
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">							
		                    <asp:TextBox ID="SEIKYU_NO_TOPTOUR" runat="server" Width="124px" 
                                MaxLength="14"></asp:TextBox>							
						</td>
					</tr>
			</table>
			</td>
		</tr>
        <tr>
            <td>
                <table cellpadding="2" cellspacing="0" border="0" width="100%">
                    <tr>
                        <td style="width:100%">
                            <asp:Button ID="BtnSubmit" runat="server" Text="登録" Width="130px" 
                                CssClass="Button" />
                            <asp:Button ID="BtnBack2" runat="server" Text="戻る" Width="130px" 
                                CssClass="Button" />
                        </td>
                    </tr>
                </table> 
            </td>
        </tr>
	</table>
</asp:Content>
