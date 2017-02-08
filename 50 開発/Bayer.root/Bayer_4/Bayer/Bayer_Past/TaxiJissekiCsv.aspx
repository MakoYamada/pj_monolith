<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TaxiJissekiCsv.aspx.vb" Inherits="Bayer_Past.TaxiJissekiCsv" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
	<title id="Title1" runat="server">タクチケ一覧CSV出力</title>
	<meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
	<meta http-equiv="Content-Type" content="text/html; charset=Shift_JIS" />
	<meta http-equiv="Pragma" content="no-cache" />
	<meta http-equiv="Cache-Control" content="no-cache" />
	<meta http-equiv="Expires" content="0" />
	<meta http-equiv="content-style-type" content="text/css" />
	<meta name="robots" content="noindex,nofollow,noarchive" />
	<link rel="stylesheet" href="Styles.css" type="text/css" />
    <script type="text/javascript">
        var timer;

        function StartTimer() {
            GetTimer();
        }
        function GetTimer() {
            // 進捗確認ボタンをスクリプトで押す。
            document.getElementById("BtnCsvRun").click();
            timer = setTimeout('GetTimer()', 1000);
        }
        function StopTimer() {
            timer = clearInterval(timer);
        }
    </script>
</head> 
<body>
    <form id="form1" runat="server">
		<span lang="ja"></span><table style="width: 100%;" cellpadding="0" cellspacing="0" width="100%">
			<tr valign="top">
				<td>
					<table border="0" cellpadding="0" cellspacing="0" style="width: 100%;" id="TblHeader1" runat="server">
						<tr style="height: 42px;">
							<td align="left" style="background-position: top left; background-repeat: no-repeat; background-color: #ffffff;" id="TdHeader1" runat="server">
								<asp:Image ID="ImgSiteName" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/Images/logo.png" />
							</td>
							<td align="right" style="background-color: #ffffff; color: #0c2f76; padding-right: 2px;" id="TdHeader2" runat="server">
								<table border="0" cellpadding="2" cellspacing="0">
									<tr>
										<td align="left" style="background-color: #ffffff;">
											&nbsp;<asp:Label ID="HeaderComment1" runat="server"></asp:Label>&nbsp;
											<br />
											&nbsp;<asp:Label ID="HeaderComment2" runat="server"></asp:Label>&nbsp;
										</td>
									</tr>
								</table>
							</td>
						</tr>
					</table>
					<table border="0" cellpadding="0" cellspacing="0" style="width: 100%;" id="TblHeader2" runat="server">
						<tr style="height: 22px;" id="TrPageTitle" runat="server" class="TrPageTitle">
							<td align="left" style="font-weight: bold; color: #2a2a2a; padding-left: 5px; vertical-align: middle;">
								<asp:Label ID="LabelPageTitle" runat="server"></asp:Label>
							</td>
							<td align="right" style="font-weight: bold; color: #1c75bc; vertical-align: middle;">
								<!-- <span id="SpnTaxiMenu" runat="server">
									<asp:Image ID="Image3" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/Images/gomenu.gif" />
									<asp:LinkButton ID="LnkBTaxiMenu" runat="server" CssClass="baselink">タクシーチケット管理メニューへ</asp:LinkButton>
								</span> 
								&nbsp;&nbsp; -->
								<span id="SpnMenu" runat="server">
									<asp:Image ID="Image1" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/Images/gomenu.gif" />
									<asp:HyperLink ID="LnkBMenu" runat="server" Text="メニューへ" CssClass="baselinkmenu" NavigateUrl="~/Menu.aspx"></asp:HyperLink>
								</span>
								&nbsp;&nbsp;
								<span id="SpnLogout" runat="server">
									<asp:Image ID="Image2" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/Images/logout.gif" />
									<asp:HyperLink ID="LnkBLogout" runat="server" Text="ログアウト" CssClass="baselink" NavigateUrl="~/Login.aspx"></asp:HyperLink>
								</span>
								&nbsp;
							</td>
						</tr>
					</table>
					<table id="TblLoginUser" runat="server" cellpadding="2" cellspacing="0" border="0" style="width: 100%; border-bottom: 1px solid #c8cbce;">
						<tr style="background-color: #f3f3f3;">
							<td align="left" style="font-weight: bold; color: #4b4b4b;">
								&nbsp;&nbsp;&nbsp;
								<asp:Label ID="LabelLoginUser" runat="server"></asp:Label>
							</td>
						</tr>
					</table>
				</td>
			</tr>
		</table>
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <table cellspacing="0" cellpadding="2" border="0" width="100%">
                <tr>
                    <td align="left">
                        <table cellpadding="2" cellspacing="0" border="0" width="972px">
                            <tr style="width:900px">
                                <td style="width:80px">
                                    <span lang="ja">承認年月</span>
                                </td>
                                <td style="width:800px">
			                        <asp:TextBox ID="JokenSHOUNIN_Y" runat="server" Width="50px" MaxLength="4" 
                                        TabIndex="6"></asp:TextBox>年
			                        <asp:TextBox ID="JokenSHOUNIN_M" runat="server" Width="30px" MaxLength="2" 
                                        TabIndex="7"></asp:TextBox>月&nbsp;&nbsp;&nbsp;
                                </td>
                            </tr>
                        </table>
                        <hr style="width:100%" />
                    </td>
                </tr>        
                <tr align="left">
                    <td style="width:100%" colspan="5">
                        <asp:Button ID="BtnCsv" runat="server" Text="CSV出力" Width="180px" 
                            CssClass="Button"  TabIndex="4"/>
                        <asp:Button ID="BtnBack" runat="server" Text="戻る" Width="180px" 
                            CssClass="Button" TabIndex="5" />
                    </td>
                </tr>
            </table>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <table style="width:100%">
                        <tr align="left">
                            <th style="width:10%">処理ステータス</th>
                            <td style="width:10%">
                                <asp:Label ID="lblStatus" runat="server" Text="-"></asp:Label></td>
                            <th style="width:10%">進行状況</th>
                            <td style="width:10%">
                                <asp:Label ID="lblProgress" runat="server" Text="-"></asp:Label>
                            </td>
                            <td style="width:60%">
                                <asp:Button ID="BtnDL" runat="server" CssClass="Button" TabIndex="4" 
                                    Text="CSVダウンロード" Width="180px" />
                                <asp:Button ID="BtnCsvRun" runat="server" Text="CSV出力" 
                                    CssClass="ButtonHidden"  />
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
                <Triggers>
                    <asp:PostBackTrigger ControlID="BtnDL" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
