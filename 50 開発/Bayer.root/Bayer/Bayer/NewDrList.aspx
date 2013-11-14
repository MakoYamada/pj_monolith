<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master"
    CodeBehind="NewDrList.aspx.vb" Inherits="Bayer.NewDrList" %>

<%@ MasterType VirtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 327px;
        }
        .style2
        {
            width: 230px;
        }
        .style4
        {
            margin-top: 0px;
        }
        .style5
        {
            width: 429px;
        }
        .style6
        {
            width: 210px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td>
                <table cellpadding="2" cellspacing="0" border="0" width="900px">
                    <tr>
                        <td style="width:50%">
                            <asp:Button ID="BtnIchiranPrint1" runat="server" Text="新着一覧印刷" Width="130px" 
                                CssClass="Button" tabindex="1"/>
                            <asp:Button ID="BtnPrint1" runat="server" Text="手配書一括印刷" Width="130px" 
                                CssClass="Button" tabindex="2" />
                        </td>
                        <td style="width:50%" align="right">
                            <asp:Button ID="BtnBack1" runat="server" Text="戻る" Width="130px" 
                                CssClass="Button" TabIndex="3" />
                        </td>
                    </tr>
                </table> 
            </td>
        </tr>
        <tr>
            <td align="left">
                <table cellpadding="2" cellspacing="0" border="0">
                    <tr>
                        <td align="left">
                            <table cellpadding="2" cellspacing="0" border="0">
                                <tr>
                                    <td align="right" style="width:90px">
                                        BYL手配担当者<br />BU
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="JokenBU" runat="server" TabIndex="4">
                                        </asp:DropDownList>
                                    </td>
                                    <td align="right" style="width:90px">
                                        BYL手配担当者<br />エリア
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="JokenTEHAI_TANTO_AREA" runat="server" TabIndex="5">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        区分
                                    </td>
                                    <td colspan="3">
                                        <asp:DropDownList ID="JokenKUBUN" runat="server" TabIndex="6">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        講演会番号
                                    </td>
                                    <td colspan="5">
                                        <asp:TextBox ID="JokenKOUENKAI_NO" runat="server" Width="91px" MaxLength="10" 
                                            TabIndex="7"></asp:TextBox>&nbsp;&nbsp;&nbsp;
                                        講演会名&nbsp;&nbsp;&nbsp;
                                        <asp:TextBox ID="JokenKOUENKAI_NAME" runat="server" Width="564px" MaxLength="160" 
                                            TabIndex="8"></asp:TextBox>
                                    </td>
                                </tr>
                               <tr>
                                    <td align="right">
                                        BYL企画担当者<br />
                                        (ローマ字)
                                    </td>
                                    <td colspan="3">
                                        <asp:TextBox ID="JokenKIKAKU_TANTO_ROMA" runat="server" Width="350px" MaxLength="300" 
                                            TabIndex="9"></asp:TextBox>                                        
                                    </td>
                                </tr>
                               <tr>
                                    <td align="right">
                                        BYL手配担当者<br />
                                        (ローマ字)
                                    </td>
                                    <td colspan="3">
                                        <asp:TextBox ID="JokenTEHAI_TANTO_ROMA" runat="server" Width="350px" MaxLength="300" 
                                            TabIndex="10"></asp:TextBox>                                        
                                    </td>
                                </tr>
                                <tr style="width:900px">
                                    <td align="right" valign="bottom" colspan="4" style="width:100%">
                                        <asp:Button ID="BtnSearch" runat="server" Text="検索" Width="130px" 
                                            CssClass="Button" TabIndex="11" />
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
            <td align="left">
                <asp:Label ID="LabelNoData" runat="server" CssClass="NoData">対象データが登録されていません。</asp:Label>
                <br />
                <asp:LinkButton ID="lnkCheck" runat="server">全てにチェック</asp:LinkButton>&nbsp;&nbsp;
                <asp:LinkButton ID="lnkNoCheck" runat="server">全てのチェックを解除</asp:LinkButton>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GrvList" runat="server" TabIndex="12" CellPadding="2" AutoGenerateColumns="False"
                    AllowPaging="True" PageSize="13" DataKeyNames="KOUENKAI_NO,DR_MPID" 
                    DataSourceID="SqlDataSource1" Width="972px">
                    <AlternatingRowStyle Wrap="false" BackColor="#f2f2f2" />
                    <RowStyle Wrap="false" BackColor="#ffffff" />
                    <HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
                    <PagerSettings Mode="NumericFirstLast" Position="Top" PreviousPageText="&lt;" NextPageText="&gt;"
                        FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
                    <PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
                    <Columns>
                        <asp:TemplateField HeaderText="印刷NOZOMIへ" SortExpression="Print" 
                            ShowHeader="False">
                            <ItemTemplate>
                                <asp:CheckBox ID="chkPrint" runat="server" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" Width="50px" />
                        </asp:TemplateField>
                        <asp:BoundField DataField="FROM_DATE" HeaderText="実施日" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                            ItemStyle-HorizontalAlign="Center">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" Width="100px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="KOUENKAI_NAME" HeaderText="講演会名" ItemStyle-Wrap="false"
                            HeaderStyle-Wrap="false">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False" Width="300px" HorizontalAlign="Left"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="DR_NAME" HeaderText="ＤＲ氏名" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False" Width="100px" HorizontalAlign="Left"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="TIME_STAMP_BYL" HeaderText="Timestamp" ItemStyle-Wrap="false"
                            HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" Width="150px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="USER_NAME" HeaderText="TOP担当者" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                            ItemStyle-HorizontalAlign="Center">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Left" Wrap="False" Width="100px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="REQ_STATUS_TEHAI" HeaderText="区分" ItemStyle-Wrap="false"
                            HeaderStyle-Wrap="false">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False"></ItemStyle>
                        <HeaderStyle Wrap="False" />
                        <ItemStyle HorizontalAlign="Center" Width="30px" Wrap="False" />
                        </asp:BoundField>
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
                        <asp:BoundField DataField="TEHAI_TAXI" HeaderText="ﾀｸﾁｹ" ItemStyle-Wrap="false" 
                            HeaderStyle-Wrap="false">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False" Width="30px" HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
                        <asp:ButtonField ButtonType="Button" Text="詳細" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                            ItemStyle-HorizontalAlign="Center" CommandName="Detail" ControlStyle-CssClass="ButtonList"
                            ControlStyle-Width="46px" ItemStyle-Width="52px" ItemStyle-BackColor="#e4e9d1">
                            <ControlStyle CssClass="ButtonList" Width="46px"></ControlStyle>
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" BackColor="#E4E9D1" Width="52px">
                            </ItemStyle>
                        </asp:ButtonField>
                        <asp:BoundField DataField="KOUENKAI_NO" HeaderText="講演会番号" />
                        <asp:BoundField DataField="SALEFORCE_ID" HeaderText="SALESFORCE_ID" />
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
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="BtnIchiranPrint2" runat="server" Text="新着一覧印刷" Width="130px" 
                    CssClass="Button" TabIndex="13" />
                <asp:Button ID="BtnPrint2" runat="server" Text="手配書一括印刷" Width="130px" 
                    CssClass="Button" TabIndex="14" />
            </td>
            <td style="width:50%" align="right">
                <asp:Button ID="BtnBack2" runat="server" Text="戻る" Width="130px" 
                    CssClass="Button" TabIndex="15" />
            </td>
        </tr>
    </table>
</asp:Content>
