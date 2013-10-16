<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="SeisanRegist.aspx.vb" Inherits="Bayer.SeisanRegist" MaintainScrollPositionOnPostback="true" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellspacing="2" border="0">
        <tr>
            <td nowrap="nowrap" align="left" class="style1">
                <table border="0" cellpadding="1" cellspacing="2">
                    <tr>
                        <td>&nbsp;&nbsp;&nbsp;
                        </td>
                        <td nowrap="nowrap" align="left" style="width: 80px;" >
                            講演会ID
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox30" runat="server" Text="12345678901234" Width="130px" MaxLength="14"></asp:TextBox>
                        </td>
                        <td nowrap="nowrap" align="left" style="width: 140px;">
                            トップツアー精算年月
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox31" runat="server" Text="123456" Width="80px" MaxLength="6"></asp:TextBox>
                        </td>
                        <td align="right" valign="bottom" colspan="4" style="width:200px;">
                            <asp:Button ID="BtnSearch" runat="server" Text="検索" Width="130px" CssClass="Button" TabIndex="18" />
                        </td>
                    </tr>
                </table>
                <table border="0" cellpadding="1" cellspacing="2">
                    <tr>
                        <td nowrap="nowrap" align="left">
                            <table cellspacing="2" style="border: 1px solid #9babb3;">
                                <tr>
                                    <td nowrap="nowrap" align="left" class="TdTitleKaijo" style="width: 80px;" rowspan="11">
							            非課税金額
						            </td>
						            <td nowrap="nowrap" align="left" class="TdTitleKaijo" colspan="8">
							            991330401
						            </td>
					            </tr>
                                <tr>
							        <td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 130px;">
								        会場費
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:TextBox ID="TextBox1" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									</td>
				                    <td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 130px;">
								        機材費
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:TextBox ID="TextBox2" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									</td>
								</tr>
								<tr>
				                    <td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 130px;">
								        飲食費
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:TextBox ID="TextBox3" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									</td>
				                    <td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 130px;">
								        その他立替等
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:TextBox ID="TextBox4" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									</td>
							        <td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 130px;">
								        小計
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:Label ID="Label1" runat="server" Text="1,234,567,890"></asp:Label>円
									</td>
							    </tr>
							    <tr>
						            <td nowrap="nowrap" align="left" class="TdTitleKaijo" colspan="8">
							            41120200
						            </td>
					            </tr>
							    <tr>
							        <td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 130px;">
								        運営費
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:TextBox ID="TextBox6" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 130px;">
								        人件費
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:TextBox ID="TextBox7" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									</td>
							        <td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 130px;">
								        小計
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:Label ID="Label2" runat="server" Text="1,234,567,890"></asp:Label>円
									</td>
							    </tr>
							    <tr>
						            <td nowrap="nowrap" align="left" class="TdTitleKaijo" colspan="8">
							            41120200
						            </td>
					            </tr>
							    <tr>
							        <td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 130px;">
								        宿泊費
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:TextBox ID="TextBox9" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 130px;">
								        JR代
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:TextBox ID="TextBox10" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 130px;">
								        航空券代
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:TextBox ID="TextBox11" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 130px;">
								        その他交通費
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:TextBox ID="TextBox12" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									</td>
							    </tr>
							    <tr>
							        <td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 130px;">
								        交通・宿泊手数料
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:TextBox ID="TextBox13" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 130px;">
								        タクチケ発券手数料
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:TextBox ID="TextBox14" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 130px;">
								        タクチケ実車料金
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:TextBox ID="TextBox15" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 130px;">
								        タクチケ精算代金
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:TextBox ID="TextBox16" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									</td>
							        <td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 100px;">
								        小計
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:Label ID="Label3" runat="server" Text="1,234,567,890"></asp:Label>円
									</td>
							    </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td nowrap="nowrap" align="left">
                            <table cellspacing="2" style="border: 1px solid #9babb3;">
                                <tr>
                                    <td nowrap="nowrap" align="left" class="TdTitleKaijo" style="width: 80px;" rowspan="6">
							            課税金額
						            </td>
						            <td nowrap="nowrap" align="left" class="TdTitleKaijo" colspan="8">
							            991330401
						            </td>
					            </tr>
					            <tr>
							        <td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 130px;">
								        会場費
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:TextBox ID="TextBox19" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									</td>
				                    <td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 130px;">
								        機材費
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:TextBox ID="TextBox20" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									</td>
								</tr>
								<tr>
				                    <td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 130px;">
								        飲食費
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:TextBox ID="TextBox21" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									</td>
								    <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="2">
							        </td>
				                    <td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 130px;">
								        小計
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:Label ID="Label5" runat="server" Text="1,234,567,890"></asp:Label>円
									</td>
								</tr>
								<tr>
						            <td nowrap="nowrap" align="left" class="TdTitleKaijo" colspan="8">
						                &nbsp;
							        </td>
					            </tr>
								<tr>
								    <td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 130px;">
								        タクチケ実車料金
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:TextBox ID="TextBox23" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 130px;">
								        タクチケ精算代金
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:TextBox ID="TextBox24" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>円
									</td>
								</tr>
                            </table>
                        </td>
                    </tr>
                    <tr align="right">
                        <td>
                            <table style="border: 1px solid #9babb3;">
                                <tr>
							        <td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 130px; height:36px;">
								        非課税金額合計
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:Label ID="Label4" runat="server" Text="1,234,567,890"></asp:Label>円
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 130px; height:36px;">
								        課税金額合計
							        </td>
							        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
										<asp:Label ID="Label6" runat="server" Text="1,234,567,890"></asp:Label>円
									</td>
									<td>
									    <asp:Button ID="Button1" runat="server" Width="150px" Text="再計算" CssClass="Button" />
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
                <table cellpadding="1" cellspacing="2" >
                    <tr>
                        <td  nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 180px;">
                            TOP請求書番号
                        </td>
                        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
							<asp:TextBox ID="TextBox25" runat="server" Text="12345678901234" Width="130px" MaxLength="14"></asp:TextBox>
						</td>
                    </tr>
                    <tr>
                        <td  nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 180px;">
                            タクチケ保存場所URL
                        </td>
                        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
							<asp:TextBox ID="TextBox26" runat="server" Text="http://WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW@" Width="650px" MaxLength="255"></asp:TextBox>
						</td>
                    </tr>
                    <tr>
                        <td></td>
                    </tr>
                    <tr>
                        <td  nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 180px;">
                            社員の国内旅費(JR/航空券)
                        </td>
                        <td nowrap="nowrap" align="left" class="style3" colspan="1">
							<asp:TextBox ID="TextBox28" runat="server" Text="123456789012" Width="120px" MaxLength="12"></asp:TextBox>
						</td>
                    </tr>
                    <tr>
                        <td  nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 180px;">
                            社員の国内旅費(宿泊)
                        </td>
                        <td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="1">
							<asp:TextBox ID="TextBox29" runat="server" Text="123456789012" Width="120px" MaxLength="12"></asp:TextBox>
						</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
			<td nowrap="nowrap" align="left">
				<div class="FontSize1" style="height: 10px;"></div>
				<table cellspacing="0" cellpadding="0" border="0" style="width: 640px;">
					<tr style="height: 36px;">
						<td nowrap="nowrap" align="right">
						    
							<asp:Button ID="BtnNozomi" runat="server" Width="150px" Text="NOZOMIへ" CssClass="Button" />
							<asp:Button ID="BtnSubmit" runat="server" Width="150px" Text="登録" CssClass="Button" />
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
                width: 800px;
            }
            .style3
            {
                background-color: #ffffff;
                color: #0a0a0a;
                font-weight: normal;
                padding-right: 5px;
                height: 30px;
            }
        </style>

</asp:Content>
