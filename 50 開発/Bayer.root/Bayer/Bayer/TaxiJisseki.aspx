<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="TaxiJisseki.aspx.vb" Inherits="Bayer.TaxiJisseki" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellspacing="0" cellpadding="2" border="0">
		<tr>
			<td align="left">
				<table cellpadding="2" cellspacing="0" border="0" width="900px">
					<tr style="width:100%">
						<td align="right" style="width:20%">
							タクシー会社
						</td>
						<td align="left">
						    <asp:RadioButtonList ID="RdoTaxi" runat="server" RepeatDirection="Horizontal">
                            </asp:RadioButtonList>
						</td>
					</tr>
					<tr style="width:100%">
						<td align="right" style="width:20%">
						    取込ファイル
						</td>
						<td align="left">
						    <asp:FileUpload ID="FileUpload1" runat="server" />
						</td>
					</tr>					
					<tr style="height: 50px;" valign="bottom">
						<td align="center" colspan="2">
							<asp:Button ID="BtnTorikomi" runat="server" Text="取込開始" Width="180px" CssClass="Button" />
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
</asp:Content>
