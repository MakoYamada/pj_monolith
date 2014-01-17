<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="SeisanRegist.aspx.vb" Inherits="Bayer.SeisanRegist" MaintainScrollPositionOnPostback="true" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellspacing="2" border="0">
        <tr>
            <td nowrap="nowrap" align="left" >
                <table  border="0" cellpadding="2" cellspacing="0" width="100%">
                    <tr>
                        <td>
                            <table border="0" cellpadding="2" cellspacing="0" style="border-collapse: collapse; margin-bottom: 5px;" width="100%">
                                <tr align="right">
                                    <td colspan="3">
                                        <asp:Button ID="BtnPrint1" runat="server" Width="130px" Text="印刷" 
                                            CssClass="Button" BackColor="#ececec" />
							            <asp:Button ID="BtnCancel1" runat="server" Width="130px" Text="戻る" 
                                            CssClass="Button" BackColor="#ececec" />
                                    </td>
                                </tr>
                                <tr align="right">
                                    <td style="width:520px;"></td>
                                    <td nowrap="nowrap" class="TdTitleSeisan1" style="width:100px;">
                                        NOZOMI送信
                                    </td>
                                    <td nowrap="nowrap" style="width:105px;">
                                        <asp:DropDownList ID="SEND_FLAG" runat="server" Width="100px" Enabled="False"></asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3">
                                        <div ID="DivMessage" runat="server" visible="false">
		                                    <asp:Label ID="LabelMessage" runat="server" Font-Bold="true"> 精算データを登録しました。 </asp:Label>
	                                    </div>
                                    </td>
                                </tr>
                            </table>
                            <table border="1" cellpadding="2" cellspacing="0" style="border-collapse: collapse;" bordercolor="#4f5b61" width="100%">
                                <tr>
                                    <td nowrap="nowrap" align="left" class="TdTitleHeader" style="width:130px;">
                                        講演会番号
                                    </td>
                                    <td nowrap="nowrap" align="left" style="width:130px;">
                                        <asp:TextBox ID="KOUENKAI_NO" runat="server" Text="12345678901234" Width="125px" MaxLength="14"></asp:TextBox>
                                    </td>
                                    <td nowrap="nowrap" align="left" class="TdTitleHeader" style="width:150px;">
                                        トップツアー精算年月
                                    </td>
                                    <td nowrap="nowrap" align="left" style="width:80px;">
                                        <asp:TextBox ID="SEISAN_YM" runat="server" Text="123456" Width="60px" MaxLength="6"></asp:TextBox>
                                    </td>
                                    <td  nowrap="nowrap" align="left" class="TdTitleHeader" style="width:130px;">
                                        精算番号
                                    </td>
                                    <td nowrap="nowrap" align="left" style="width:130px;">
							            <asp:TextBox ID="SEIKYU_NO_TOPTOUR" runat="server" Text="12345678901234" BorderStyle="None" 
                                            Width="125px" MaxLength="14" ReadOnly="True" TabIndex="-1"></asp:TextBox>
						            </td>
                                </tr>
                                <tr>
                                    <td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 130px;">
                                        支払番号
                                    </td>
                                    <td nowrap="nowrap" align="left" style="width: 130px;">
                                        <asp:Label ID="SHIHARAI_NO" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 150px;">
                                        承認区分
                                    </td>
                                    <td nowrap="nowrap" align="left" style="width: 80px;">
                                        <asp:Label ID="SHOUNIN_KUBUN" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 130px;">
                                        精算承認日
                                    </td>
                                    <td nowrap="nowrap" align="left" >
                                        <asp:Label ID="SHOUNIN_DATE" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>                        
                    </tr>                    
                </table>
                <table border="0" cellpadding="2" cellspacing="0">
                    <tr>
                        <td nowrap="nowrap" align="left">
                            <table cellspacing="2" style="border: 1px solid #9babb3;">
                                <tr>
                                    <td nowrap="nowrap" align="left" class="TdTitleSeisan1" rowspan="11">
							            非課税金額
						            </td>
						            <td nowrap="nowrap" align="left">
							            <table cellpadding="1" style="border: 1px solid #9babb3;" width="100%">
							                <tr>
							                    <td>
							                        <span style="font-weight: bold;">
							                            991330401
							                        </span>
							                    </td>
							                </tr>
							                <tr>
							                    <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    会場費
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="KAIJOHI_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
				                                <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    機材費
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1" >
										            <asp:TextBox ID="KIZAIHI_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
								            </tr>
								            <tr>
				                                <td nowrap="nowrap" align="left" class="TdTitleSeisan2" >
								                    飲食費
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="INSHOKUHI_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
				                                <td nowrap="nowrap" align="left" class="TdItem"  colspan="2">								        
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdTitleSeisanKei1">
								                    小計
							                    </td>
							                    <td nowrap="nowrap" class="TdItemSeisanKei1">
										            <asp:Label ID="KEI_991330401_TF" runat="server" Text="1,234,567,890"></asp:Label>円
									            </td>
							                </tr>
							            </table>
						            </td>
					            </tr>                               
							    <tr>
						            <td nowrap="nowrap" align="left" colspan="8">
							            <table cellpadding="1" style="border: 1px solid #9babb3;" width="100%">
							                <tr>
							                    <td>
							                        <span style="font-weight: bold;">
							                            41120200
							                        </span>
							                    </td>
							                </tr>
							                <tr>
							                    <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    宿泊費
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="HOTELHI_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
									            <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    宿泊費都税
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="HOTELHI_TOZEI" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
								            </tr>
								            <tr>
								                <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    JR代
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="JR_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>

									            <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    航空券代
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="AIR_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
							                </tr>
							                <tr>
							                    <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    その他鉄道等費用
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="OTHER_TRAFFIC_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
							                    <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    タクチケ発券手数料
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="TAXI_COMMISSION_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
								            </tr>
								            <tr>
                                                <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    登録手数料
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="HOTEL_COMMISSION_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>							                    <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    人件費
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="JINKENHI_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
								            </tr>
								            <tr>
									            <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    その他費
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="OTHER_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
									            <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    管理費
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="KANRIHI_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
							                </tr>
							                							                <tr>
							                    <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    タクチケ実車料金
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="TAXI_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
									            <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    タクチケ精算手数料
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="TAXI_SEISAN_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
									            <td nowrap="nowrap" align="left" class="TdTitleSeisanKei1">
								                    小計
							                    </td>
							                    <td nowrap="nowrap" class="TdItemSeisanKei1">
										            <asp:Label ID="KEI_41120200_TF" runat="server" Text="1,234,567,890"></asp:Label>円
									            </td>
								            </tr>
							            </table>
						            </td>
					            </tr>
							    <tr>
							        <td nowrap="nowrap" align="left">
							            <table cellpadding="1" style="border: 1px solid #9babb3;" width="100%">
							                <tr>
							                    <td nowrap="nowrap" align="left" class="TdTitleSeisanKei2">
								                    非課税金額合計
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisanKei2" >
										            <asp:Label ID="KEI_TF" runat="server" Text="1,234,567,890"></asp:Label>円
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
                            <table cellspacing="2" style="border: 1px solid #9babb3;">
                                <tr>
                                    <td nowrap="nowrap" align="left" class="TdTitleSeisan1" rowspan="7">
							            課税金額
						            </td>
						            <td nowrap="nowrap" align="left" colspan="8">
							            <table cellpadding="1" style="border: 1px solid #9babb3;" width="100%">
							                <tr>
							                    <td>
							                        <span style="font-weight: bold;">
							                            991330401
							                        </span>
							                    </td>
							                </tr>
							                <tr>
							                    <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    会場費
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="KAIJOUHI_T" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
				                                <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    機材費
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="KIZAIHI_T" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
								            </tr>
								            <tr>
				                                <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    飲食費
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="INSHOKUHI_T" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
								                <td nowrap="nowrap" align="left" class="TdItem" colspan="2">
							                    </td>
				                                <td nowrap="nowrap" align="left" class="TdTitleSeisanKei1">
								                    小計
							                    </td>
							                    <td nowrap="nowrap" class="TdItemSeisanKei1">
										            <asp:Label ID="KEI_991330401_T" runat="server" Text="1,234,567,890"></asp:Label>円
									            </td>
								            </tr>
							            </table>
						            </td>
					            </tr>
								<tr>
						            <td nowrap="nowrap" align="left" colspan="8">
							            <table cellpadding="1" style="border: 1px solid #9babb3;" width="100%">
							                <tr>
							                    <td>
							                        <span style="font-weight: bold;">
							                            41120200
							                        </span>
							                    </td>
							                </tr>
							                <tr>
					                            <td nowrap="nowrap" align="left" class="TdTitleSeisan2" style="width: 130px;">
					                                人件費
					                            </td>
					                            <td nowrap="nowrap" align="left" class="TdItemSeisan1" colspan="1">
										            <asp:TextBox ID="JINKENHI_T" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
									            <td nowrap="nowrap" align="left" class="TdTitleSeisan2" style="width: 130px;">
					                                その他費
					                            </td>
					                            <td nowrap="nowrap" align="left" class="TdItemSeisan1" colspan="1">
										            <asp:TextBox ID="OTHER_T" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
					                        </tr>
					                        <tr>
					                            <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
					                                管理費
					                            </td>
					                            <td nowrap="nowrap" align="left" class="TdItemSeisan1" colspan="1">
										            <asp:TextBox ID="KANRIHI_T" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
									            <td nowrap="nowrap" align="left" class="TdItem" colspan="2">
							                    </td>
				                                <td nowrap="nowrap" align="left" class="TdTitleSeisanKei1">
								                    小計
							                    </td>
							                    <td nowrap="nowrap" class="TdItemSeisanKei1">
										            <asp:Label ID="KEI_41120200_T" runat="server" Text="1,234,567,890"></asp:Label>円
									            </td>
					                        </tr>
							            </table>
						            </td>
					            </tr>
					            <tr>
					                <td>
					                    <table cellpadding="1" style="border: 1px solid #9babb3;" width="100%">
					                        <tr>
					                            <td nowrap="nowrap" align="left" class="TdTitleSeisanKei2">
					                                課税金額合計
					                            </td>
					                            <td nowrap="nowrap" align="right" class="TdItemSeisanKei2">
										            <asp:Label ID="KEI_T" runat="server" Text="1,234,567,890"></asp:Label>円
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
            <td nowrap="nowrap" align="left" >
                <table border="0" cellpadding="2" cellspacing="0" width="100%">
                    <tr>
                        <td>
                            <table cellpadding="1" cellspacing="2" style="border: 1px solid #9babb3; margin-bottom:5px;"  width="100%">
                                <tr>
                                    <td  nowrap="nowrap" align="left" class="TdTitleSeisan3">
                                        社員の国内旅費(宿泊)
                                    </td>
                                    <td nowrap="nowrap" align="left" class="TdItem">
							            <asp:TextBox ID="MR_HOTEL" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
						            </td>
                                </tr>
                                <tr>
                                    <td  nowrap="nowrap" align="left" class="TdTitleSeisan3">
                                        社員の国内旅費(宿泊都税)
                                    </td>
                                    <td nowrap="nowrap" align="left" class="TdItem">
							            <asp:TextBox ID="MR_HOTEL_TOZEI" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
						            </td>
                                </tr>
                                <tr>
                                    <td  nowrap="nowrap" align="left" class="TdTitleSeisan3">
                                        社員の国内旅費(JR/航空券)
                                    </td>
                                    <td nowrap="nowrap" align="left" class="TdItem">
							            <asp:TextBox ID="MR_JR" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
						            </td>
                                </tr>
                                <tr>
                                    <td  nowrap="nowrap" align="left" class="TdTitleSeisan3">
                                        精算書保存場所URL
                                    </td>
                                    <td nowrap="nowrap" align="left" class="TdItem">
							            <asp:TextBox ID="SEISANSHO_URL" runat="server" Text="http://WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW@" Width="650px" MaxLength="255"></asp:TextBox>
						            </td>
                                </tr>
                            </table>
                            <table cellpadding="1" cellspacing="2" style="border: 1px solid #9babb3; margin-bottom:5px;" width="100%">
                                <tr>
                                    <td nowrap="nowrap" align="left" class="TdTitleSeisan3">
		                                タクチケ実車料金(課税)
	                                </td>
	                                <td nowrap="nowrap" align="left" class="TdItem">
				                        <asp:TextBox ID="TAXI_T" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
			                        </td>
                                </tr>
                                <tr>
			                        <td nowrap="nowrap" align="left" class="TdTitleSeisan3">
		                                タクチケ精算手数料(課税)
	                                </td>
	                                <td nowrap="nowrap" align="left" class="TdItem">
				                        <asp:TextBox ID="TAXI_SEISAN_T" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
			                        </td>
		                        </tr>
                                <tr>
                                    <td  nowrap="nowrap" align="left" class="TdTitleSeisan3">
                                        タクチケ管理表保存場所URL
                                    </td>
                                    <td nowrap="nowrap" align="left" class="TdItem">
							            <asp:TextBox ID="TAXI_TICKET_URL" runat="server" Text="http://WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW@" Width="650px" MaxLength="255"></asp:TextBox>
						            </td>
                                </tr>
                            </table>
                            <table cellpadding="1" cellspacing="2" style="border: 1px solid #9babb3; margin-bottom:5px;" width="100%">
                                <tr>
                                    <td  nowrap="nowrap" align="left" class="TdTitleSeisan3">
                                        精算完了
                                    </td>
                                    <td nowrap="nowrap" align="left" class="TdItem">
                                        <asp:CheckBox ID="SEISAN_KANRYO" runat="server" />
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
				<div class="FontSize1" style="height: 10px;"></div>
				<table cellspacing="0" cellpadding="0" border="0" style="width: 100%;">
				    <tr style="height: 36px;">
				        <td nowrap="nowrap" align="center">
					        <asp:Button ID="BtnDrCsv" runat="server" Width="180px" Text="参加者一覧CSV作成" 
                                CssClass="Button" BackColor="#ececec" />
                            <asp:Button ID="BtnDrCsvHid" runat="server" Width="25px" Text="" style="visibility:hidden"
                                CssClass="Button" />
					        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
					        <asp:Button ID="BtnMrCsv" runat="server" Width="180px" Text="MR一覧CSV作成" 
                                CssClass="Button" BackColor="#ececec" />
                            <asp:Button ID="BtnMrCsvHid" runat="server" Width="25px" Text="" style="visibility:hidden"
                                CssClass="Button" />
					        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
					        <asp:Button ID="BtnTaxiCsv" runat="server" Width="180px" Text="タクチケ精算データCSV作成" 
                                CssClass="Button" BackColor="#ececec" />					        
					        
					    </td>
				    </tr>
					<tr style="height: 36px;">
						<td nowrap="nowrap" align="center">
						    <asp:Button ID="BtnCalc" runat="server" Width="130px" Text="再計算" 
                                CssClass="Button" BackColor="#ececec" />
							<asp:Button ID="BtnSubmit" runat="server" Width="130px" Text="登録" 
                                CssClass="Button" BackColor="#ececec" />
							<asp:Button ID="BtnNozomi" runat="server" Width="130px" Text="NOZOMIへ" 
                                CssClass="Button" BackColor="#ececec" />
							<asp:Button ID="BtnPrint2" runat="server" Width="130px" Text="印刷" 
                                CssClass="Button" BackColor="#ececec" />
							<asp:Button ID="BtnCancel2" runat="server" Width="130px" Text="戻る" 
                                CssClass="Button" BackColor="#ececec" />
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
</asp:Content>
