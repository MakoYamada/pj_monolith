<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="KouenkaiRegist.aspx.vb" Inherits="Bayer_Past.KouenkaiRegist" MaintainScrollPositionOnPostback="true" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table border="0" cellpadding="4" cellspacing="0" width="1100px">
        <tr>
            <td>
                <table cellpadding="2" cellspacing="0" border="0" width="100%">
                    <tr>
                        <td style="width:50%">
                        </td>
                        <td style="width:50%" align="right">
				            <asp:Button ID="BtnSubmit1" runat="server" Width="150px" Text="o^" 
                                CssClass="Button" TabIndex="1"  Visible="false"/>
                            <asp:Button ID="BtnBack1" runat="server" Text="ßé" Width="130px" 
                                CssClass="Button" TabIndex="2" />
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
							ïÔ
						</td>
						<td nowrap="nowrap" align="left" style="width: 100px;">
							<asp:Label ID="KOUENKAI_NO" runat="server" Width="120px"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 120px;">
							VXe[^X
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:DropDownList ID="KIDOKU_FLG" runat="server" Width="100px" TabIndex="3"></asp:DropDownList>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 90px;">
							Xe[^X
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="TORIKESHI_FLG" runat="server" Width="120px"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 90px;">
							TimeStamp(BYL)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="3">
							<asp:Label ID="TIME_STAMP" runat="server" Width="140px"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							ï¼
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="5">
						    <asp:TextBox ID="KOUENKAI_NAME" runat="server" BorderStyle="None" Height="35px" 
                                ReadOnly="True" TextMode="MultiLine" Width="624px" TabStop="False"></asp:TextBox>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							`Pbgó¼
							<br />
							(10¶)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" style="width: 95px;">
							<asp:Label ID="TAXI_PRT_NAME" runat="server" Width="120px"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 90px;">
							ïJÃú
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="7">
							<asp:Label ID="FROM_DATE" runat="server" Width="622px"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							ïïê¼
						</td>
						<td nowrap="nowrap" align="left" colspan="7">
                            <asp:TextBox ID="KAIJO_NAME" runat="server" BorderStyle="None" Height="35px" 
                                ReadOnly="True" TextMode="MultiLine" Width="624px" TabStop="False"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							»i¼
						</td>
						<td nowrap="nowrap" align="left" colspan="7">
							<asp:Label ID="SEIHIN_NAME" runat="server" Width="980px"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 120px;">
							Internal Order<br />(ÛÅ)
						</td>
						<td nowrap="nowrap" align="left">
							<asp:Label ID="INTERNAL_ORDER_T" runat="server" Width="100px"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 120px;">
							Internal Order<br />(ñÛÅ)
						</td>
						<td nowrap="nowrap" align="left">
							<asp:Label ID="INTERNAL_ORDER_TF" runat="server" Width="100px"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 120px;">
							Account Code(ÛÅ)
						</td>
						<td nowrap="nowrap" align="left">
							<asp:Label ID="ACCOUNT_CD_T" runat="server" Width="100px"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 150px;">
							Account Code(ñÛÅ)
						</td>
						<td nowrap="nowrap" align="left">
							<asp:Label ID="ACCOUNT_CD_TF" runat="server" Width="100px"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							Zetia Code
						</td>
						<td nowrap="nowrap" align="left">
							<asp:Label ID="ZETIA_CD" runat="server" Width="100px"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							QÁl(]Æõ)
						</td>
						<td nowrap="nowrap" align="left">
							<asp:Label ID="SANKA_YOTEI_CNT_MBR" runat="server" Width="100px"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							QÁl(]ÆõÈO)
						</td>
						<td nowrap="nowrap" align="left" colspan="3">
							<asp:Label ID="SANKA_YOTEI_CNT_NMBR" runat="server" Width="100px"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							TOPSÒ
						</td>
						<td nowrap="nowrap" align="left">
                            <asp:DropDownList ID="TTEHAI_TANTO" runat="server" TabIndex="4">
                            </asp:DropDownList>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							cÌR[h
						</td>
						<td nowrap="nowrap" align="left">
                            <asp:TextBox ID="DANTAI_CODE" runat="server" Width="62px" 
                                MaxLength="6" TabIndex="5"></asp:TextBox>                                        

						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							WBS Element
						</td>
						<td nowrap="nowrap" align="left" colspan="3">
							<asp:Label ID="WBS_ELEMENT" runat="server" Width="202px"></asp:Label>
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
							¡ ï éæSÒ

						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							Æ
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="7">
							<asp:Label ID="KIKAKU_TANTO_JIGYOUBU" runat="server" Width="980px"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							BU
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="BU" runat="server" Width="415px"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							GA
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="3">
                            <asp:TextBox ID="KIKAKU_TANTO_AREA" runat="server" MaxLength="80" ReadOnly="true" 
                                TextMode="MultiLine" Height="35px" Width="418px" TabStop="False"
                                BorderStyle="None"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							cÆ
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
                            <asp:TextBox ID="KIKAKU_TANTO_EIGYOSHO" runat="server" MaxLength="80" ReadOnly="true" 
                                TextMode="MultiLine" Height="35px" Width="418px" TabStop="False" 
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
							¼
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
                            <asp:TextBox ID="KIKAKU_TANTO_NAME" runat="server" MaxLength="150" ReadOnly="true" 
                                TextMode="MultiLine" Height="35px" Width="417px" TabStop="False" 
                                BorderStyle="None"></asp:TextBox>                            
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							¼<br />([})
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="5">
                            <asp:TextBox ID="KIKAKU_TANTO_ROMA" runat="server" MaxLength="150" ReadOnly="true" 
                                TextMode="MultiLine" Height="35px" Width="417px" TabStop="False" 
                                BorderStyle="None"></asp:TextBox>                            
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							ItBXÌdbÔ
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="KIKAKU_TANTO_TEL" runat="server" Width="415px"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 75px;">
							gÑdb
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="KIKAKU_TANTO_KEITAI" runat="server" Width="415px"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 105px;">
							[AhX
						</td>
						<td align="left" class="TdItem" colspan="5">
                            <asp:TextBox ID="KIKAKU_TANTO_EMAIL" runat="server" MaxLength="128" ReadOnly="true" 
                                TextMode="MultiLine" Height="35px" Width="903px" TabStop="False" 
                                BorderStyle="None"></asp:TextBox>                            
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 105px;">
							gÑÌ[AhX
						</td>
						<td align="left" class="TdItem" colspan="5">
                            <asp:TextBox ID="KIKAKU_TANTO_EMAIL_KEITAI" runat="server" MaxLength="128" ReadOnly="true" 
                                TextMode="MultiLine" Height="35px" Width="903px" TabStop="False" 
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
							¡ TZ
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							\Zz(ñÛÅ)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" style="width: 200px;">
							<asp:Label ID="YOSAN_TF" runat="server" Width="100px"></asp:Label>
							~

						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							\Zz(ÛÅ)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="5">
							<asp:Label ID="YOSAN_T" runat="server" Width="100px"></asp:Label>
							~
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							ÔJï\Z(ÛÅ)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" style="width: 200px;">
							<asp:Label ID="IROUKAI_YOSAN_T" runat="server" Width="100px"></asp:Label>
							~

						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							Ó©ð·ï\Z(ÛÅ)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="5">
							<asp:Label ID="IKENKOUKAN_YOSAN_T" runat="server" Width="100px"></asp:Label>
							~
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
				            <asp:Button ID="BtnRireki" runat="server" Width="150px" Text="ð\¦" 
                                CssClass="Button" TabIndex="6" />
				        </td>
				        <td align="right" style="width:70%">
				            <asp:Button ID="BtnSubmit2" runat="server" Width="150px" Text="o^" 
                                CssClass="Button" TabIndex="7"  Visible="false"/>
				            <!-- <asp:Button ID="BtnNozomi" runat="server" Width="150px" Text="NOZOMIÖ" 
                                CssClass="Button" /> -->
					        <asp:Button ID="BtnBack2" runat="server" Width="150px" Text="ßé" 
                                CssClass="Button" TabIndex="8" />
				        </td>
			        </tr>
		        </table>
			</td>
		</tr>
	</table>
</asp:Content>
