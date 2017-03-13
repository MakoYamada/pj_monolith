<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master"
    CodeBehind="NewDrList.aspx.vb" Inherits="Bayer.NewDrList" %>

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
                            <table cellpadding="2" cellspacing="0" border="0" width="972px">
                                <tr>
                                    <td align="right" style="width:90px">
                                        BYL手配担当者<br />BU
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="JokenBU" runat="server" TabIndex="1" Width="145px">
                                        </asp:DropDownList>
                                    </td>
                                    <td align="right" style="width:90px">
                                        BYL手配担当者<br />エリア
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="JokenTEHAI_TANTO_AREA" runat="server" TabIndex="2" 
                                            Width="145px">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        区分
                                    </td>
                                    <td colspan="3">
                                        <asp:DropDownList ID="JokenKUBUN" runat="server" TabIndex="3" Width="145px">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        会合番号
                                    </td>
                                    <td colspan="5">
                                        <asp:TextBox ID="JokenKOUENKAI_NO" runat="server" Width="126px" MaxLength="14" 
                                            TabIndex="4"></asp:TextBox>&nbsp;&nbsp;&nbsp;
                                        会合名&nbsp;&nbsp;&nbsp;
                                        <asp:TextBox ID="JokenKOUENKAI_NAME" runat="server" Width="564px" MaxLength="160" 
                                            TabIndex="5"></asp:TextBox>
                                    </td>
                                </tr>
                               <tr>
                                    <td align="right">
                                        BYL企画担当者<br />
                                        (ローマ字)
                                    </td>
                                    <td colspan="3">
                                        <asp:TextBox ID="JokenKIKAKU_TANTO_ROMA" runat="server" Width="350px" MaxLength="300" 
                                            TabIndex="6"></asp:TextBox>                                        
                                    </td>
                                </tr>
                               <tr>
                                    <td align="right">
                                        BYL手配担当者<br />
                                        (ローマ字)
                                    </td>
                                    <td colspan="3">
                                        <asp:TextBox ID="JokenTEHAI_TANTO_ROMA" runat="server" Width="350px" MaxLength="300" 
                                            TabIndex="7" Height="26px"></asp:TextBox>                                        
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
                                        <asp:CheckBox ID="ChkTTEHAI_TANTO" runat="server" Text="TOP担当者未登録のみ" 
                                            AutoPostBack="True" TabIndex="9" />
                                    </td>
                                </tr>
                                <tr style="width:900px">
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
                            <asp:Button ID="BtnIchiranPrint1" runat="server" Text="新着一覧印刷" Width="130px" 
                                CssClass="Button" tabindex="11"/>
                            <asp:Button ID="BtnPrint1" runat="server" Text="手配書一括印刷" Width="130px" 
                                CssClass="Button" tabindex="12" />
                            <asp:Button ID="BtnBack1" runat="server" Text="戻る" Width="130px" 
                                CssClass="Button" TabIndex="13" />
                        </td>
                    </tr>
                </table> 
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:Label ID="LabelNoData" runat="server" CssClass="NoData">対象データが登録されていません。</asp:Label>
                <asp:Label ID="LabelCountTitle" runat="server">検索結果件数：</asp:Label>
                <asp:Label ID="LabelCount" runat="server"></asp:Label>
                <br />
                <asp:LinkButton ID="lnkCheck" runat="server" TabIndex="14">全てにチェック</asp:LinkButton>&nbsp;&nbsp;
                <asp:LinkButton ID="lnkNoCheck" runat="server" TabIndex="15">全てのチェックを解除</asp:LinkButton>
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
                        <asp:TemplateField HeaderText="印刷NOZOMIへ" SortExpression="Print" 
                            ShowHeader="False">
                            <ItemTemplate>
                                <asp:CheckBox ID="chkPrint" runat="server" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" Width="50px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="開催日">
                            <ItemTemplate>
                                <asp:Label ID="FROM_DATE" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Wrap="False" />
                            <ItemStyle HorizontalAlign="Center" Width="100px" Wrap="False" />
                        </asp:TemplateField>
                        <asp:BoundField DataField="KOUENKAI_NO" HeaderText="会合番号" />
                        <asp:TemplateField HeaderText="会合名">
                            <ItemTemplate>
                                <asp:Label ID="KOUENKAI_NAME" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Wrap="False" />
                            <ItemStyle HorizontalAlign="Left" Width="300px" Wrap="False" />
                        </asp:TemplateField>
                        <asp:BoundField DataField="SANKASHA_ID" HeaderText="参加者番号" />
                        <asp:TemplateField HeaderText="ＤＲ氏名">
                            <ItemTemplate>
                                <asp:Label ID="DR_NAME" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Wrap="False" />
                            <ItemStyle HorizontalAlign="Left" Width="100px" Wrap="False" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="DR担当MR">
                            <ItemTemplate>
                                <asp:Label ID="MR_NAME" runat="server"></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="100px" Wrap="False" />
                        </asp:TemplateField>
                        <asp:BoundField DataField="TIME_STAMP_BYL" HeaderText="BYL Timestamp" />
                        <asp:TemplateField HeaderText="TOP受信日時">
                            <ItemTemplate>
                                <asp:Label ID="INPUT_DATE" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="TOP担当">
                            <EditItemTemplate>
                                <br />
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="USER_NAME" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Wrap="False" />
                            <ItemStyle HorizontalAlign="Left" Width="100px" Wrap="False" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="依頼内容">
                            <ItemTemplate>
                                <asp:Label ID="REQ_STATUS_TEHAI" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Wrap="False" />
                            <ItemStyle HorizontalAlign="Center" Width="30px" Wrap="False" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="宿&lt;br /&gt;泊">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Wrap="False" />
                            <ItemStyle HorizontalAlign="Center" Width="30px" Wrap="False" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="交&lt;br /&gt;通">
                            <ItemTemplate>
                                <asp:Label ID="REQ_KOTSU_TEHAI" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Wrap="False" />
                            <ItemStyle HorizontalAlign="Center" Wrap="False" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="タ&lt;br /&gt;ク">
                            <ItemTemplate>
                                <asp:Label ID="REQ_TAXI_TEHAI" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Wrap="False" />
                            <ItemStyle HorizontalAlign="Center" Width="30px" Wrap="False" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="MR&lt;br /&gt;手配">
                            <ItemTemplate>
                                <asp:Label ID="REQ_MR_TEHAI" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" Width="30px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="緊&lt;br /&gt;急">
                            <ItemTemplate>
                                <asp:Label ID="KINKYU_FLAG" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:ButtonField ButtonType="Button" Text="詳細" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                            ItemStyle-HorizontalAlign="Center" CommandName="Detail" ControlStyle-CssClass="ButtonList"
                            ControlStyle-Width="46px" ItemStyle-Width="52px" ItemStyle-BackColor="#e4e9d1">
                            <ControlStyle CssClass="ButtonList" Width="46px"></ControlStyle>
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" BackColor="#E4E9D1" Width="52px">
                            </ItemStyle>
                        </asp:ButtonField>
                        <asp:BoundField DataField="SALEFORCE_ID" HeaderText="SALESFORCE_ID" />
                        <asp:BoundField DataField="TIME_STAMP_BYL" HeaderText="TIME_STAMP_BYL" ItemStyle-Wrap="false"
                            HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" Width="150px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="DR_MPID" DataField="DR_MPID" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                <table cellpadding="2" cellspacing="0" border="0" width="100%">
                    <tr>
                        <td style="width:100%">
                            <asp:Button ID="BtnIchiranPrint2" runat="server" Text="新着一覧印刷" Width="130px" 
                                CssClass="Button" tabindex="17"/>
                            <asp:Button ID="BtnPrint2" runat="server" Text="手配書一括印刷" Width="130px" 
                                CssClass="Button" tabindex="18" />
                            <asp:Button ID="BtnBack2" runat="server" Text="戻る" Width="130px" 
                                CssClass="Button" TabIndex="19" />
                        </td>
                    </tr>
                </table> 
            </td>
        </tr>
    </table>
</asp:Content>
