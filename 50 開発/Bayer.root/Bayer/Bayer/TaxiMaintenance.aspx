<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master"
    CodeBehind="TaxiMaintenance.aspx.vb" Inherits="Bayer.TaxiMaintenance" %>

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
                                    <td align="right" style="width:90px">
                                        実施日
                                    </td>
                                    <td>
							            <asp:TextBox ID="JokenFROM_DATE_YYYY" runat="server" Width="50px" MaxLength="4" 
                                            TabIndex="6"></asp:TextBox>年
							            <asp:TextBox ID="JokenFROM_DATE_MM" runat="server" Width="30px" MaxLength="2" 
                                            TabIndex="7"></asp:TextBox>月

							            <asp:TextBox ID="JokenFROM_DATE_DD" runat="server" Width="30px" MaxLength="2" 
                                            TabIndex="8"></asp:TextBox>日
							            ～

							            <asp:TextBox ID="JokenTO_DATE_YYYY" runat="server" Width="50px" MaxLength="4" 
                                            TabIndex="9"></asp:TextBox>年
							            <asp:TextBox ID="JokenTO_DATE_MM" runat="server" Width="30px" MaxLength="2" 
                                            TabIndex="10"></asp:TextBox>月

							            <asp:TextBox ID="JokenTO_DATE_DD" runat="server" Width="30px" MaxLength="2" 
                                            TabIndex="11"></asp:TextBox>日
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="middle">
                                        講演会番号
                                    </td>
                                    <td colspan="5" valign="middle">
                                        <asp:TextBox ID="JokenKOUENKAI_NO" runat="server" Width="126px" MaxLength="14" 
                                            TabIndex="4"></asp:TextBox>&nbsp;&nbsp;&nbsp;
                                        講演会名&nbsp;&nbsp;&nbsp;
                                        <asp:TextBox ID="JokenKOUENKAI_NAME" runat="server" Width="564px" MaxLength="160" 
                                            TabIndex="5"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        TOP担当者                                        
                                    </td>
                                    <td colspan="3">
                                        <asp:DropDownList ID="JokenTTEHAI_TANTO" runat="server" TabIndex="8" 
                                            AutoPostBack="True">
                                        </asp:DropDownList> &nbsp;&nbsp;
                                    </td>
                                </tr>
                                <tr style="width:100%">
                                    <td align="right" valign="bottom" colspan="4" style="width:100%">
                                        <asp:Button ID="BtnSearch" runat="server" Text="検索" Width="130px" 
                                            CssClass="Button" TabIndex="10" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
                <hr style="width:100%" />
            </td>
        </tr>        
        <tr>
            <td>
                <table cellpadding="2" cellspacing="0" border="0" width="100%">
                    <tr>
                        <td style="width:100%">
                            <asp:Button ID="BtnCsv1" runat="server" Text="未決一覧CSV" Width="130px" 
                                CssClass="Button" tabindex="11"/>
                            <asp:Button ID="BtnBack1" runat="server" Text="戻る" Width="130px" 
                                CssClass="Button" TabIndex="13" />
                        </td>
                    </tr>
                </table> 
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:Label ID="LabelNoData" runat="server" CssClass="NoData">対象データがありません。</asp:Label>
                <br />
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GrvList" runat="server" TabIndex="16" CellPadding="2" AutoGenerateColumns="False"
                    AllowPaging="True" PageSize="13" DataKeyNames="KOUENKAI_NO,DR_MPID" 
                    DataSourceID="SqlDataSource1" Width="972px">
                    <AlternatingRowStyle Wrap="false" BackColor="#f2f2f2" />
                    <RowStyle Wrap="false" BackColor="#ffffff" />
                    <HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
                    <PagerSettings Mode="NumericFirstLast" Position="Top" PreviousPageText="&lt;" NextPageText="&gt;"
                        FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
                    <PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
                    <Columns>
                        <asp:BoundField DataField="FROM_DATE" HeaderText="実施日" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                            ItemStyle-HorizontalAlign="Center">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="KOUENKAI_NAME" HeaderText="講演会名" ItemStyle-Wrap="false"
                            HeaderStyle-Wrap="false">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False" HorizontalAlign="Left"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="DR_NAME" HeaderText="ＤＲ氏名" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False" HorizontalAlign="Left"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="USER_NAME" HeaderText="TOP担当者" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                            ItemStyle-HorizontalAlign="Center">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Left" Wrap="False"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="TKT_NO" HeaderText="タクチケ番号" ItemStyle-Wrap="false"
                            HeaderStyle-Wrap="false">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False"></ItemStyle>
                        <HeaderStyle Wrap="False" />
                        <ItemStyle HorizontalAlign="Center" Width="30px" Wrap="False" />
                        </asp:BoundField>
                        <asp:BoundField DataField="TKT_KENSHU" HeaderText="券種" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                            ItemStyle-HorizontalAlign="Center">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" Width="30px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="利用予定日" ItemStyle-Wrap="false"
                            HeaderStyle-Wrap="false">
<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle Wrap="False" HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="備考" ItemStyle-Wrap="false" 
                            HeaderStyle-Wrap="false">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False" Width="30px" HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="発行日" />
                        <asp:BoundField DataField="TKT_USED_DATE" HeaderText="実車日" />
                        <asp:BoundField DataField="TKT_SEIKYU_YM" HeaderText="請求月" />
                        <asp:BoundField DataField="TKT_VOID" HeaderText="VOID(日)" />
                        <asp:BoundField DataField="TKT_LINE_NO" HeaderText="行番号" />
                        <asp:ButtonField ButtonType="Button" Text="詳細" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                            ItemStyle-HorizontalAlign="Center" CommandName="Detail" ControlStyle-CssClass="ButtonList"
                            ControlStyle-Width="46px" ItemStyle-Width="52px" ItemStyle-BackColor="#e4e9d1">
                            <ControlStyle CssClass="ButtonList" Width="46px"></ControlStyle>
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" BackColor="#E4E9D1" Width="52px">
                            </ItemStyle>
                        </asp:ButtonField>
                        <asp:BoundField DataField="KOUENKAI_NO" HeaderText="講演会番号" Visible="False" />
                        <asp:BoundField DataField="SANKASHA_ID" HeaderText="参加者ID" Visible="False" />
                        <asp:BoundField DataField="TO_DATE" HeaderText="開催日TO" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_DATE_1" HeaderText="利用日1" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_KENSHU_1" HeaderText="券種1" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_NO_1" HeaderText="ﾀｸﾁｹ番号1" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_HAKKO_DATE_1" HeaderText="発行日1" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_RMKS_1" HeaderText="備考1" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_DATE_2" HeaderText="利用日2" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_KENSHU_2" HeaderText="券種2" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_NO_2" HeaderText="ﾀｸﾁｹ番号2" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_HAKKO_DATE_2" HeaderText="発行日2" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_RMKS_2" HeaderText="備考2" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_DATE_3" HeaderText="利用日3" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_KENSHU_3" HeaderText="券種3" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_NO_3" HeaderText="ﾀｸﾁｹ番号3" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_HAKKO_DATE_3" HeaderText="発行日3" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_RMKS_3" HeaderText="備考3" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_DATE_4" HeaderText="利用日4" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_KENSHU_4" HeaderText="券種4" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_NO_4" HeaderText="ﾀｸﾁｹ番号4" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_HAKKO_DATE_4" HeaderText="発行日4" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_RMKS_4" HeaderText="備考4" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_DATE_5" HeaderText="利用日5" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_KENSHU_5" HeaderText="券種5" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_NO_5" HeaderText="ﾀｸﾁｹ番号5" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_HAKKO_DATE_5" HeaderText="発行日5" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_RMKS_5" HeaderText="備考5" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_DATE_6" HeaderText="利用日6" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_KENSHU_6" HeaderText="券種6" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_NO_6" HeaderText="ﾀｸﾁｹ番号6" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_HAKKO_DATE_6" HeaderText="発行日6" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_RMKS_6" HeaderText="備考6" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_DATE_7" HeaderText="利用日7" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_KENSHU_7" HeaderText="券種7" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_NO_7" HeaderText="ﾀｸﾁｹ番号7" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_HAKKO_DATE_7" HeaderText="発行日7" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_RMKS_7" HeaderText="備考7" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_DATE_8" HeaderText="利用日8" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_KENSHU_8" HeaderText="券種8" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_NO_8" HeaderText="ﾀｸﾁｹ番号8" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_HAKKO_DATE_8" HeaderText="発行日8" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_RMKS_8" HeaderText="備考8" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_DATE_9" HeaderText="利用日9" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_KENSHU_9" HeaderText="券種9" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_NO_9" HeaderText="ﾀｸﾁｹ番号9" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_HAKKO_DATE_9" HeaderText="発行日9" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_RMKS_9" HeaderText="備考9" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_DATE_10" HeaderText="利用日10" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_KENSHU_10" HeaderText="券種10" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_NO_10" HeaderText="ﾀｸﾁｹ番号10" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_HAKKO_DATE_10" HeaderText="発行日10" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_RMKS_10" HeaderText="備考10" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_DATE_11" HeaderText="利用日11" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_KENSHU_11" HeaderText="券種11" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_NO_11" HeaderText="ﾀｸﾁｹ番号11" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_HAKKO_DATE_11" HeaderText="発行日11" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_RMKS_11" HeaderText="備考11" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_DATE_12" HeaderText="利用日12" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_KENSHU_12" HeaderText="券種12" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_NO_12" HeaderText="ﾀｸﾁｹ番号12" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_HAKKO_DATE_12" HeaderText="発行日12" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_RMKS_12" HeaderText="備考12" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_DATE_13" HeaderText="利用日13" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_KENSHU_13" HeaderText="券種13" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_NO_13" HeaderText="ﾀｸﾁｹ番号13" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_HAKKO_DATE_13" HeaderText="発行日13" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_RMKS_13" HeaderText="備考13" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_DATE_14" HeaderText="利用日14" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_KENSHU_14" HeaderText="券種14" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_NO_14" HeaderText="ﾀｸﾁｹ番号14" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_HAKKO_DATE_14" HeaderText="発行日14" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_RMKS_14" HeaderText="備考14" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_DATE_15" HeaderText="利用日15" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_KENSHU_15" HeaderText="券種15" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_NO_15" HeaderText="ﾀｸﾁｹ番号15" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_HAKKO_DATE_15" HeaderText="発行日15" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_RMKS_15" HeaderText="備考15" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_DATE_16" HeaderText="利用日16" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_KENSHU_16" HeaderText="券種16" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_NO_16" HeaderText="ﾀｸﾁｹ番号16" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_HAKKO_DATE_16" HeaderText="発行日16" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_RMKS_16" HeaderText="備考16" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_DATE_17" HeaderText="利用日17" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_KENSHU_17" HeaderText="券種17" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_NO_17" HeaderText="ﾀｸﾁｹ番号17" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_HAKKO_DATE_17" HeaderText="発行日17" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_RMKS_17" HeaderText="備考17" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_DATE_18" HeaderText="利用日18" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_KENSHU_18" HeaderText="券種18" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_NO_18" HeaderText="ﾀｸﾁｹ番号18" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_HAKKO_DATE_18" HeaderText="発行日18" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_RMKS_18" HeaderText="備考18" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_DATE_19" HeaderText="利用日19" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_KENSHU_19" HeaderText="券種19" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_NO_19" HeaderText="ﾀｸﾁｹ番号19" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_HAKKO_DATE_19" HeaderText="発行日19" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_RMKS_19" HeaderText="備考19" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_DATE_20" HeaderText="利用日20" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_KENSHU_20" HeaderText="券種20" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_NO_20" HeaderText="ﾀｸﾁｹ番号20" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_HAKKO_DATE_20" HeaderText="発行日20" Visible="False" />
                        <asp:BoundField DataField="ANS_TAXI_RMKS_20" HeaderText="備考20" Visible="False" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                <table cellpadding="2" cellspacing="0" border="0" width="100%">
                    <tr>
                        <td style="width:100%">
                            <asp:Button ID="BtnCsv2" runat="server" Text="未決一覧CSV" Width="130px" 
                                CssClass="Button" tabindex="11"/>
                            <asp:Button ID="BtnBack2" runat="server" Text="戻る" Width="130px" 
                                CssClass="Button" TabIndex="19" />
                        </td>
                    </tr>
                </table> 
            </td>
        </tr>
    </table>
</asp:Content>
