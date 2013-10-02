<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master"
    CodeBehind="HotelKensaku.aspx.vb" Inherits="Bayer.HotelKensaku" %>

<%@ MasterType VirtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table border="0" cellpadding="4" cellspacing="0" style="width:972px">
        <tr>
            <td align="left">
	            <table border="0" cellpadding="4" cellspacing="0" style="width:972px">
                    <tr>
                        <td align="left">
				            <table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                                cellpadding="2" border="1" bordercolor="#4f5b61" style="width:972px">
                                <tr>
                                    <td class="TdTitleHeader">
                                        都道府県
                                    </td>
                                    <td class="TdItem">
                                        <asp:DropDownList ID="ADDRESS1" runat="server" Width="150px">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="TdTitleHeader">
                                        施設名
                                    </td>
                                    <td class="TdItem">
                                        <asp:TextBox ID="SHISETSU_NAME" runat="server" Width="810px" MaxLength="200"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="TdTitleHeader">
                                        施設名カナ
                                    </td>
                                    <td class="TdItem">
                                        <asp:TextBox ID="SHISETSU_KANA" runat="server" Width="810px" MaxLength="200"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" valign="bottom" colspan="2">
                            <asp:Button ID="BtnSearch" runat="server" Text="検索" Width="130px" CssClass="Button" />
                        </td>
                    </tr>
                </table>
                <hr style="width:100%" />
            </td>
        </tr>        
        <tr>
            <td align="left">
                <asp:Label ID="LabelNoData" runat="server" CssClass="NoData">対象データが登録されていません。</asp:Label>
                <br />
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GrvList" runat="server" TabIndex="-1" CellPadding="2" AutoGenerateColumns="False"
                    AllowPaging="True" PageSize="13" 
                    DataSourceID="SqlDataSource1" Width="972px">
                    <AlternatingRowStyle Wrap="false" BackColor="#f2f2f2" />
                    <RowStyle Wrap="false" BackColor="#ffffff" />
                    <HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
                    <PagerSettings Mode="NumericFirstLast" Position="Top" PreviousPageText="&lt;" NextPageText="&gt;"
                        FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
                    <PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
                    <Columns>
                        <asp:ButtonField ButtonType="Button" Text="選択" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                            ItemStyle-HorizontalAlign="Center" CommandName="Detail" ControlStyle-CssClass="ButtonList"
                            ControlStyle-Width="46px" ItemStyle-Width="52px" ItemStyle-BackColor="#e4e9d1">
                            <ControlStyle CssClass="ButtonList" Width="46px"></ControlStyle>
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" BackColor="#E4E9D1" Width="52px">
                            </ItemStyle>
                        </asp:ButtonField>
                        <asp:BoundField DataField="ADDRESS1" HeaderText="都道府県" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                            ItemStyle-HorizontalAlign="Center" ReadOnly="True">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" Width="60px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="SHISETSU_NAME" HeaderText="施設名" ItemStyle-Wrap="false"
                            HeaderStyle-Wrap="false" ReadOnly="True">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False" HorizontalAlign="Left"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="ADDRESS2" HeaderText="住所" ItemStyle-Wrap="false" 
                            HeaderStyle-Wrap="false" ReadOnly="True">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False" HorizontalAlign="Left"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="TEL" HeaderText="電話番号" ItemStyle-Wrap="false"
                            HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center" 
                            ReadOnly="True">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" Width="100px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="CHECKIN_TIME" HeaderText="ﾁｪｯｸｲﾝ" 
                            ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                            ItemStyle-HorizontalAlign="Center" ReadOnly="True">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Left" Wrap="False" Width="60px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="CHECKOUT_TIME" HeaderText="ﾁｪｯｸｱｳﾄ" 
                            ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                            ItemStyle-HorizontalAlign="Center" ReadOnly="True">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" Width="60px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="SYSTEM_ID" HeaderText="システムID" ItemStyle-Wrap="false"
                            HeaderStyle-Wrap="false" Visible="False">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False" Width="30px" HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr align="center">
            <td>
				<input type="button" value="戻る" style="width: 130px;" class="Button" onclick="window.close()" />
            </td>
        </tr>
    </table>
</asp:Content>
