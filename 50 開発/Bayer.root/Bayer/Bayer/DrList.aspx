<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master"  CodeBehind="DrList.aspx.vb" Inherits="Bayer.DrList" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td align="left">
                <table cellpadding="2" cellspacing="0" border="0">
                    <tr>
                        <td align="left">
                            <table cellpadding="2" cellspacing="0" border="0">
                                <tr>
                                    <td>事業部&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="JIGYOBU" runat="server" Width="150px"></asp:DropDownList></td>
                                    <td>エリア&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="AREA" runat="server" Width="150px"></asp:DropDownList></td>
                                    <td>会合名&nbsp;&nbsp;&nbsp;<asp:TextBox ID="MEETING_NAME" runat="server" Width="350px" Maxlength="200"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td colspan="3">
                                        講演会担当者&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="200px" Maxlength="100"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td align="left" valign="bottom">
                            <asp:Button ID="BtnSearch" runat="server" Text="検索" Width="130px" CssClass="Button" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:Label ID="LabelNoData" runat="server" CssClass="NoData">対象データが登録されていません。</asp:Label>
                <br />
                <asp:LinkButton ID="lnkCheck" runat="server">全てにチェック</asp:LinkButton>
                <asp:GridView ID="GrvList" runat="server" TabIndex="-1" CellPadding="2"
				 AutoGenerateColumns="False"
				 AllowPaging="True" PageSize="13"
				 DataKeyNames="KOUENKAI_NO,DR_MPID" DataSourceID="SqlDataSource1">
					<AlternatingRowStyle Wrap="false" BackColor="#f2f2f2" />
					<RowStyle Wrap="false" BackColor="#ffffff" />
					<HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
					<PagerSettings Mode="NumericFirstLast" Position="Top" PreviousPageText="&lt;" NextPageText="&gt;" FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
					<PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
					<Columns>
					     <asp:TemplateField HeaderText="印刷" SortExpression="Print">
                            <ItemTemplate>
                                <asp:CheckBox ID="chkPrint" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
						<asp:BoundField DataField="FROM_DATE" HeaderText="実施日" ItemStyle-Wrap="false" 
                             HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center" >
<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle HorizontalAlign="Center" Wrap="False"></ItemStyle>
                         </asp:BoundField>
						<asp:BoundField DataField="KOUENKAI_NAME" HeaderText="会合名" ItemStyle-Wrap="false" 
                             HeaderStyle-Wrap="false" >
<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle Wrap="False"></ItemStyle>
                         </asp:BoundField>
						<asp:BoundField DataField="DR_NAME" HeaderText="ＤＲ氏名" ItemStyle-Wrap="false" 
                             HeaderStyle-Wrap="false" >
<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle Wrap="False"></ItemStyle>
                         </asp:BoundField>
						<asp:BoundField DataField="TIMESTAMP" HeaderText="Timestamp" 
                             ItemStyle-Wrap="false" HeaderStyle-Wrap="false" 
                             ItemStyle-HorizontalAlign="Center" >
<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle HorizontalAlign="Center" Wrap="False"></ItemStyle>
                         </asp:BoundField>
						<asp:BoundField DataField="MR_NAME" HeaderText="担当者" ItemStyle-Wrap="false" 
                             HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center" >
<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle HorizontalAlign="Center" Wrap="False"></ItemStyle>
                         </asp:BoundField>
						<asp:BoundField DataField="TEHAI_HOTEL" HeaderText="宿泊" ItemStyle-Wrap="false" 
                             HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center" >
<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle HorizontalAlign="Center" Wrap="False"></ItemStyle>
                         </asp:BoundField>
						<asp:BoundField DataField="REQ_O_TEHAI_1" HeaderText="往路" ItemStyle-Wrap="false" 
                             HeaderStyle-Wrap="false" >
<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle Wrap="False"></ItemStyle>
                         </asp:BoundField>
						<asp:BoundField DataField="REQ_F_TEHAI_1" HeaderText="復路" ItemStyle-Wrap="false" 
                             HeaderStyle-Wrap="false" >
<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle Wrap="False"></ItemStyle>
                         </asp:BoundField>
						<asp:BoundField DataField="TEHAI_TAXI" HeaderText="ﾀｸﾁｹ" ItemStyle-Wrap="false" 
                             HeaderStyle-Wrap="false" >
<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle Wrap="False"></ItemStyle>
                         </asp:BoundField>
						<asp:ButtonField ButtonType="Button" Text="詳細" ItemStyle-Wrap="false" 
                             HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center" 
                             CommandName="Detail" ControlStyle-CssClass="ButtonList" 
                             ControlStyle-Width="46px" ItemStyle-Width="52px" ItemStyle-BackColor="#e4e9d1" >
<ControlStyle CssClass="ButtonList" Width="46px"></ControlStyle>

<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle HorizontalAlign="Center" Wrap="False" BackColor="#E4E9D1" Width="52px"></ItemStyle>
                         </asp:ButtonField>
					</Columns>
				</asp:GridView>
				<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="BtnPrint" runat="server" Text="手配書一括印刷" Width="130px" CssClass="Button" />
            </td>
        </tr>
        <tr align="center">
            <td>
                <asp:Button ID="BtnBack" runat="server" Text="戻る" Width="130px" CssClass="Button" />
            </td>
        </tr>
    </table>
</asp:Content>
