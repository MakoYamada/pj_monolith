<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="SeisanRegist.aspx.vb" Inherits="Bayer.SeisanRegist" MaintainScrollPositionOnPostback="true" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellspacing="2" border="0">
        <tr>
            <td nowrap="nowrap" align="left" >
                <table  border="0" cellpadding="2" cellspacing="0" width="100%">
                    <tr>
                        <td>
                            <table border="1" cellpadding="2" cellspacing="0" style="border-collapse: collapse;" bordercolor="#4f5b61" width="100%">
                                <tr>
                                    <td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 130px;">
                                        講演会番号
                                    </td>
                                    <td nowrap="nowrap" align="left" style="width: 130px;">
                                        <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td  nowrap="nowrap" align="left" class="TdTitleHeader" style="width:130px;">
                                        TOP請求書番号
                                    </td>
                                    <td nowrap="nowrap" align="left" colspan="3">
							            <asp:Label ID="label4" runat="server" Text=""></asp:Label>
						            </td>
                                </tr>
                                <tr>
                                    <td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 130px;">
                                        支払番号
                                    </td>
                                    <td nowrap="nowrap" align="left" style="width: 130px;">
                                        <asp:Label ID="Label9" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 130px;">
                                        承認区分
                                    </td>
                                    <td nowrap="nowrap" align="left" style="width: 130px;">
                                        <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 130px;">
                                        精算承認日
                                    </td>
                                    <td nowrap="nowrap" align="left" >
                                        <asp:Label ID="Label11" runat="server" Text=""></asp:Label>
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
										            <asp:TextBox ID="TextBox1" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
				                                <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    機材費
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1" >
										            <asp:TextBox ID="TextBox2" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
								            </tr>
								            <tr>
				                                <td nowrap="nowrap" align="left" class="TdTitleSeisan2" >
								                    飲食費
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="TextBox3" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
				                                <td nowrap="nowrap" align="left" class="TdItem"  colspan="2">								        
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdTitleSeisanKei1">
								                    小計
							                    </td>
							                    <td nowrap="nowrap" class="TdItemSeisanKei1">
										            <asp:Label ID="Label1" runat="server" Text="1,234,567,890"></asp:Label>円
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
										            <asp:TextBox ID="TextBox9" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
									            <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    JR代
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="TextBox10" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
								            </tr>
								            <tr>
									            <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    航空券代
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="TextBox11" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
									            <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    その他<br />私鉄・バス等交通費
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="TextBox12" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
							                </tr>
							                <tr>
							                    <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    タクシー実車料金
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="TextBox4" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
									            <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    交通宿泊手配手数料
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="TextBox5" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
								            </tr>
							                <tr>
							                    <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    タクシー発券手数料
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="TextBox13" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
									            <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    タクシー精算手数料
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="TextBox14" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
								            </tr>
								            <tr>
							                    <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    人件費
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="TextBox8" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
									            <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    その他
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="TextBox17" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
								            </tr>
								            <tr>
									            <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    管理費
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="TextBox15" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
									            <td nowrap="nowrap" align="left" class="TdItem" colspan="2">
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdTitleSeisanKei1">
								                    小計
							                    </td>
							                    <td nowrap="nowrap" class="TdItemSeisanKei1">
										            <asp:Label ID="Label3" runat="server" Text="1,234,567,890"></asp:Label>円
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
										            <asp:Label ID="Label12" runat="server" Text="1,234,567,890"></asp:Label>円
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
										            <asp:TextBox ID="TextBox19" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
				                                <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    機材費
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="TextBox20" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
								            </tr>
								            <tr>
				                                <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
								                    飲食費
							                    </td>
							                    <td nowrap="nowrap" align="left" class="TdItemSeisan1">
										            <asp:TextBox ID="TextBox21" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
								                <td nowrap="nowrap" align="left" class="TdItem" colspan="2">
							                    </td>
				                                <td nowrap="nowrap" align="left" class="TdTitleSeisanKei1">
								                    小計
							                    </td>
							                    <td nowrap="nowrap" class="TdItemSeisanKei1">
										            <asp:Label ID="Label5" runat="server" Text="1,234,567,890"></asp:Label>円
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
										            <asp:TextBox ID="TextBox6" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
									            <td nowrap="nowrap" align="left" class="TdTitleSeisan2" style="width: 130px;">
					                                その他
					                            </td>
					                            <td nowrap="nowrap" align="left" class="TdItemSeisan1" colspan="1">
										            <asp:TextBox ID="TextBox7" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
					                        </tr>
					                        <tr>
					                            <td nowrap="nowrap" align="left" class="TdTitleSeisan2">
					                                管理費
					                            </td>
					                            <td nowrap="nowrap" align="left" class="TdItemSeisan1" colspan="1">
										            <asp:TextBox ID="TextBox16" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									            </td>
									            <td nowrap="nowrap" align="left" class="TdItem" colspan="2">
							                    </td>
				                                <td nowrap="nowrap" align="left" class="TdTitleSeisanKei1">
								                    小計
							                    </td>
							                    <td nowrap="nowrap" class="TdItemSeisanKei1">
										            <asp:Label ID="Label2" runat="server" Text="1,234,567,890"></asp:Label>円
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
										            <asp:Label ID="Label13" runat="server" Text="1,234,567,890"></asp:Label>円
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
                            <table cellpadding="1" cellspacing="2" style="border: 1px solid #9babb3;" width="100%">
                                <tr>
                                    <td nowrap="nowrap" align="left" class="TdTitleSeisan3">
                                        トップツアー精算年月
                                    </td>
                                    <td class="TdItem">
                                        <asp:TextBox ID="TextBox31" runat="server" Text="123456" Width="60px" MaxLength="6"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td nowrap="nowrap" align="left" class="TdTitleSeisan3">
		                                タクチケ実車料金(課税)
	                                </td>
	                                <td nowrap="nowrap" align="left" class="TdItem">
				                        <asp:TextBox ID="TextBox23" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
			                        </td>
                                </tr>
                                <tr>
			                        <td nowrap="nowrap" align="left" class="TdTitleSeisan3">
		                                タクチケ精算手数料(課税)
	                                </td>
	                                <td nowrap="nowrap" align="left" class="TdItem">
				                        <asp:TextBox ID="TextBox24" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
			                        </td>
		                        </tr>
                                <tr>
                                    <td  nowrap="nowrap" align="left" class="TdTitleSeisan3">
                                        精算書保存場所URL
                                    </td>
                                    <td nowrap="nowrap" align="left" class="TdItem">
							            <asp:TextBox ID="TextBox18" runat="server" Text="http://WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW@" Width="650px" MaxLength="255"></asp:TextBox>
						            </td>
                                </tr>
                                <tr>
                                    <td  nowrap="nowrap" align="left" class="TdTitleSeisan3">
                                        タクチケ管理表保存場所URL
                                    </td>
                                    <td nowrap="nowrap" align="left" class="TdItem">
							            <asp:TextBox ID="TextBox26" runat="server" Text="http://WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW@" Width="650px" MaxLength="255"></asp:TextBox>
						            </td>
                                </tr>
                                <tr>
                                    <td  nowrap="nowrap" align="left" class="TdTitleSeisan3">
                                        精算完了
                                    </td>
                                    <td nowrap="nowrap" align="left" class="TdItem">
							            <asp:TextBox ID="TextBox32" runat="server" Height="45px" TextMode="MultiLine" Width="624px"></asp:TextBox>
						            </td>
                                </tr>
                                <tr>
                                    <td  nowrap="nowrap" align="left" class="TdTitleSeisan3">
                                        社員の国内旅費(JR/航空券)
                                    </td>
                                    <td nowrap="nowrap" align="left" class="TdItem">
							            <asp:TextBox ID="TextBox28" runat="server" Text="123456789012" Width="120px" MaxLength="12"></asp:TextBox>
						            </td>
                                </tr>
                                <tr>
                                    <td  nowrap="nowrap" align="left" class="TdTitleSeisan3">
                                        社員の国内旅費(宿泊)
                                    </td>
                                    <td nowrap="nowrap" align="left" class="TdItem">
							            <asp:TextBox ID="TextBox29" runat="server" Text="123456789012" Width="120px" MaxLength="12"></asp:TextBox>
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
						    <asp:Button ID="Button1" runat="server" Width="150px" Text="再計算" CssClass="Button" />
							<asp:Button ID="BtnSubmit" runat="server" Width="150px" Text="登録" CssClass="Button" />
							<asp:Button ID="BtnNozomi" runat="server" Width="150px" Text="NOZOMIへ" CssClass="Button" />
							<asp:Button ID="BtnCancel" runat="server" Width="150px" Text="キャンセル" CssClass="Button" />
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">

		<style type="text/css">
            .style1
            {
                width: 840px;
            }
        </style>

</asp:Content>
