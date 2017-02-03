<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master"
    CodeBehind="TaxiMikanryou.aspx.vb" Inherits="Bayer_Past.TaxiMikanryou" %>

<%@ MasterType VirtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td align="left">
                <table cellpadding="2" cellspacing="0" border="0">
                    <tr>
                        <td align="left">
                            <table cellpadding="2" cellspacing="0" border="0" width="100%">
                                <tr>
                                    <td align="left" style="width:50px">
                                        開催日
                                    </td>
                                    <td>
							            <asp:TextBox ID="Joken_YYYY" runat="server" Width="50px" MaxLength="4" 
                                            TabIndex="1"></asp:TextBox>年
							            <asp:TextBox ID="Joken_MM" runat="server" Width="30px" MaxLength="2" 
                                            TabIndex="2"></asp:TextBox>月 以前&nbsp;
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
                <hr style="width:100%" />
            </td>
        </tr>        
		<tr id="TrNoData" runat="server">
			<td align="left">
				<asp:Label ID="LabelNoData" runat="server" Text="対象となるデータがありません。" CssClass="NoData"></asp:Label>
			</td>
		</tr>
        <tr style="width:100%">
            <td align="left" valign="bottom" colspan="4" style="width:100%">
                <asp:Button ID="BtnCsv" runat="server" Text="精算未完了CSV" Width="130px" 
                    CssClass="Button" TabIndex="7" />
            </td>
        </tr>
    </table>
</asp:Content>
