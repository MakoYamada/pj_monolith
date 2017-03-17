<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="TaxiSeisanAuto.aspx.vb" Inherits="Bayer.TaxiSeisanAuto" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellspacing="0" cellpadding="2" border="0">
		<tr>
			<td align="left">
                <table border="1" cellpadding="2" cellspacing="0" style="border-collapse: collapse;" bordercolor="#4f5b61" width="900px">
                    <tr style="width:100%">
						<td align="left" style="width:15%" class="TdTitle ">
						    精算年月
						</td>
						<td align="left" class="TdItem">
				            <asp:TextBox ID="SEISAN_YM" runat="server" Width="62px" MaxLength="6"></asp:TextBox>
						</td>
					</tr>					
                    <tr style="width:100%">
						<td align="left" style="width:15%" class="TdTitle ">
						    精算用団体コード
						</td>
						<td align="left" class="TdItem">
				            <asp:TextBox ID="SEISAN_DANTAI" runat="server" Width="62px" MaxLength="6"></asp:TextBox>
						</td>
					</tr>					
                    <tr style="width:100%">
						<td align="left" style="width:15%" class="TdTitle ">
						    精算コメント
						</td>
						<td align="left" class="TdItem">
				            <asp:TextBox ID="SEISAN_COMMENT" runat="server" Width="533px" MaxLength="255" 
                                TextMode="MultiLine" ></asp:TextBox>
						</td>
					</tr>					
					<tr style="width:100%">
						<td align="left" style="width:15%" class="TdTitle ">
						    自動精算対象データ
						</td>
						<td align="left" class="TdItem">
						    <asp:FileUpload ID="FileUpload1" runat="server" Width="533px" />
						</td>
					</tr>					
					<tr style="height: 50px;" valign="bottom">
						<td align="left" colspan="2">
							<asp:Button ID="BtnTorikomi" runat="server" Text="データ作成予約" Width="180px" CssClass="Button" />
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
</asp:Content>
