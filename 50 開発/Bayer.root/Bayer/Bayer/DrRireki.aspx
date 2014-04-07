<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="DrRireki.aspx.vb" Inherits="Bayer.DrRireki" %>
<%@ MasterType VirtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellspacing="0" cellpadding="2" border="0">
		<tr id="TrKOUENKAI_NAME" runat="server">
			<td align="left" style="font-weight: bold;">
				<asp:Label ID="KOUENKAI_NO" runat="server"></asp:Label>
				：
				<asp:Label ID="KOUENKAI_NAME" runat="server"></asp:Label>
			</td>
		</tr>
        <tr>
            <td align="left">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>
                <table cellpadding="2" cellspacing="0" border="0" width="900px">
                    <tr>
                        <td style="width:100%">
                            <asp:Button ID="BtnPrint1" runat="server" Text="印刷" Width="130px" 
                                CssClass="Button"  TabIndex="1"/>
                            <asp:Button ID="BtnBack1" runat="server" Text="戻る" Width="130px" 
                                CssClass="Button" TabIndex="2" />
                        </td>
                    </tr>
                </table> 
            </td>
        </tr>
        <tr>
            <td>
		        <asp:Label ID="LabelNoData" runat="server" CssClass="NoData">対象データが登録されていません。</asp:Label>
                <asp:GridView ID="GrvList" runat="server" TabIndex="-1" CellPadding="2" AutoGenerateColumns="False"
                    AllowPaging="True" PageSize="13" DataKeyNames="KOUENKAI_NO,DR_MPID" 
                    DataSourceID="SqlDataSource1" Width="792px">
                    <AlternatingRowStyle Wrap="false" BackColor="#f2f2f2" />
                    <RowStyle Wrap="false" BackColor="#ffffff" />
                    <HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
                    <PagerSettings Mode="NumericFirstLast" Position="Top" PreviousPageText="&lt;" NextPageText="&gt;"
                        FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
                    <PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
                    <Columns>
                        <asp:BoundField DataField="FROM_DATE" HeaderText="開催日" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                            ItemStyle-HorizontalAlign="Center">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" Width="100px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="SANKASHA_ID" HeaderText="参加者番号">
                        <ItemStyle Width="100px" Wrap="False" />
                        </asp:BoundField>
                        <asp:BoundField DataField="DR_NAME" HeaderText="ＤＲ氏名" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False" Width="100px" HorizontalAlign="Left"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="MR_NAME" HeaderText="DR担当MR">
                        <ItemStyle Width="100px" Wrap="False" />
                        </asp:BoundField>
                        <asp:BoundField DataField="TIME_STAMP_BYL" HeaderText="Timestamp" ItemStyle-Wrap="false"
                            HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" Width="150px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="UPDATE_DATE" HeaderText="更新日時" ItemStyle-Wrap="false"
                            HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" Width="200px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="USER_NAME" HeaderText="TOP担当者" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                            ItemStyle-HorizontalAlign="Center">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Left" Wrap="False" Width="100px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="ANS_STATUS_TEHAI" HeaderText="TOPステータス" />
                        <asp:BoundField DataField="TEHAI_HOTEL" HeaderText="宿泊" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                            ItemStyle-HorizontalAlign="Center">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" Width="30px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="REQ_O_TEHAI_1" HeaderText="交通" ItemStyle-Wrap="false"
                            HeaderStyle-Wrap="false">
<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle Wrap="False" HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="TEHAI_TAXI" HeaderText="ﾀｸﾁｹ" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False" Width="30px" HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="MR&lt;br /&gt;手配" HtmlEncode="False">
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" Width="30px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="KINKYU_FLAG" HeaderText="緊急" />
                        <asp:BoundField DataField="SEND_FLAG" HeaderText="NOZOMI送信">
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:ButtonField ButtonType="Button" Text="詳細" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                            ItemStyle-HorizontalAlign="Center" CommandName="Detail" ControlStyle-CssClass="ButtonList"
                            ControlStyle-Width="46px" ItemStyle-Width="52px" ItemStyle-BackColor="#e4e9d1">
                            <ControlStyle CssClass="ButtonList" Width="46px"></ControlStyle>
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" BackColor="#E4E9D1" Width="52px">
                            </ItemStyle>
                        </asp:ButtonField>
                        <asp:BoundField DataField="KOUENKAI_NO" HeaderText="会合番号" Visible="False" />
                        <asp:BoundField DataField="SALEFORCE_ID" HeaderText="SALEFORCE_ID" />
                        <asp:BoundField DataField="TO_DATE" HeaderText="TO_DATE" />
                        <asp:BoundField DataField="REQ_O_TEHAI_1" HeaderText="REQ_O_TEHAI_1" />
                        <asp:BoundField DataField="REQ_O_TEHAI_2" HeaderText="REQ_O_TEHAI_2" />
                        <asp:BoundField DataField="REQ_O_TEHAI_3" HeaderText="REQ_O_TEHAI_3" />
                        <asp:BoundField DataField="REQ_O_TEHAI_4" HeaderText="REQ_O_TEHAI_4" />
                        <asp:BoundField DataField="REQ_O_TEHAI_5" HeaderText="REQ_O_TEHAI_5" />
                        <asp:BoundField DataField="REQ_F_TEHAI_1" HeaderText="REQ_F_TEHAI_1" />
                        <asp:BoundField DataField="REQ_F_TEHAI_2" HeaderText="REQ_F_TEHAI_2" />
                        <asp:BoundField DataField="REQ_F_TEHAI_3" HeaderText="REQ_F_TEHAI_3" />
                        <asp:BoundField DataField="REQ_F_TEHAI_4" HeaderText="REQ_F_TEHAI_4" />
                        <asp:BoundField DataField="REQ_F_TEHAI_5" HeaderText="REQ_F_TEHAI_5" />
                        <asp:BoundField DataField="REQ_MR_O_TEHAI" HeaderText="REQ_MR_O_TEHAI" />
                        <asp:BoundField DataField="REQ_MR_F_TEHAI" HeaderText="REQ_MR_F_TEHAI" />
                        <asp:BoundField DataField="REQ_MR_HOTEL_NOTE" HeaderText="REQ_MR_HOTEL_NOTE" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                <table cellpadding="2" cellspacing="0" border="0" width="900px">
                    <tr>
                        <td style="width:100%">
                            <asp:Button ID="BtnPrint2" runat="server" Text="印刷" Width="130px" 
                                CssClass="Button"  TabIndex="22"/>
                            <asp:Button ID="BtnBack2" runat="server" Text="戻る" Width="130px" 
                                CssClass="Button" TabIndex="23" />
                        </td>
                    </tr>
                </table> 
            </td>
        </tr>
    </table>
</asp:Content>
