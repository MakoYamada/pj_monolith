﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="SetTicketSend.aspx.vb" Inherits="Bayer.SetTicketSend" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellspacing="0" cellpadding="2" border="0">
		<tr>
			<td align="left">
                <table border="1" cellpadding="2" cellspacing="0" style="border-collapse: collapse;" bordercolor="#4f5b61" width="900px">
					<tr style="width:100%">
						<td align="center" style="width:30%" class="TdTitle ">
						    取込ファイル
						</td>
						<td align="left" class="TdItem">
						    <asp:FileUpload ID="FileUpload1" runat="server" Width="533px" />
						</td>
					</tr>					
                    <tr style="width:100%">
						<td align="left" style="width:15%" class="TdTitle ">
						    発送年月日
						</td>
						<td align="left" class="TdItem">
				            <asp:TextBox ID="ANS_TICKET_SEND_DAY" runat="server" Width="62px" MaxLength="8"></asp:TextBox>
						</td>
					</tr>					
				</table>
			</td>
		</tr>
		<tr style="height: 50px;" valign="bottom">
			<td align="left" colspan="2">
				<asp:Button ID="BtnTorikomi" runat="server" Text="取込開始" Width="180px" CssClass="Button" />
			</td>
		</tr>
	</table>
	<table cellspacing="0" cellpadding="2" border="0">
		<tr id="TrError" runat="server">
			<td align="left" colspan="2" style="font-weight: bold; color: #cb1a1a;">
				エラーがありました。<br />
				詳細は操作ログ照会でご確認ください。

				<br />
				&nbsp;&nbsp;
				<asp:TextBox ID="LabelErrorMessage" runat="server" Width="900px" Height="350px" TextMode="MultiLine" ForeColor="#cb1a1a" TabIndex="-1" ReadOnly="true"></asp:TextBox>
			</td>
		</tr>
		<tr id="TrEnd" runat="server">
			<td align="left" colspan="2" style="font-weight: bold; color:#003399;">
				正常に終了しました。

				<br />
				処理件数：

				<asp:Label ID="LabelUpdatedCount" runat="server"></asp:Label>件
			</td>
		</tr>
	</table>
</asp:Content>
