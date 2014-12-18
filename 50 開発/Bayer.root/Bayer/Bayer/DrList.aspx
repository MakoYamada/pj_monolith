<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master"
    CodeBehind="DrList.aspx.vb" Inherits="Bayer.DrList" %>

<%@ MasterType VirtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td align="left">
                <table cellpadding="2" cellspacing="0" border="0" width="900px">
                    <tr>
                        <td align="left">
                            <table cellpadding="2" cellspacing="0" border="0">
                                <tr>
                                    <td align="right" style="width:130px">
                                        Dr担当MR名<br />
                                        (ローマ字)
                                    </td>
                                    <td>
                                        <asp:TextBox ID="JokenMR_ROMA" runat="server" Width="350px" 
                                            MaxLength="300" TabIndex="1"></asp:TextBox>                                        
                                    </td>
                                    <td align="right" style="width:100px">
                                        DR名(カナ)
                                    </td>
                                    <td colspan="3">
                                        <asp:TextBox ID="JokenDR_KANA" runat="server" Width="279px" MaxLength="80" 
                                            TabIndex="2"></asp:TextBox>                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        参加・不参加
                                    </td>
                                    <td colspan="3">
                                        <asp:DropDownList ID="JokenDR_SANKA" runat="server" TabIndex="3">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        会合番号
                                    </td>
                                    <td colspan="5">
                                        <asp:TextBox ID="JokenKOUENKAI_NO" runat="server" Width="124px" MaxLength="14" 
                                            TabIndex="4"></asp:TextBox>&nbsp;&nbsp;&nbsp;
                                        会合名&nbsp;&nbsp;&nbsp;
                                        <asp:TextBox ID="JokenKOUENKAI_NAME" runat="server" Width="536px" MaxLength="160" 
                                            TabIndex="5"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        参加者番号
                                    </td>
                                    <td colspan="5">
                                        <asp:TextBox ID="JokenSANKASHA_ID" runat="server" Width="124px" MaxLength="14" 
                                            TabIndex="4"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        開催日
                                    </td>
                                    <td colspan="5">
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
                                    <td align="right">
                                        BYL手配担当者<br />BU
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="JokenBU" runat="server" TabIndex="12">
                                        </asp:DropDownList>
                                    </td>
                                    <td align="right">
                                        BYL手配担当者<br />エリア
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="JokenTEHAI_TANTO_AREA" runat="server" TabIndex="13">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                               <tr>
                                    <td align="right">
                                        TOP担当者                                        
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="JokenTTEHAI_TANTO" runat="server" TabIndex="14">
                                        </asp:DropDownList>
                                    </td>
                                    <td align="right">
                                        更新日
                                    </td>
                                    <td>
							            <asp:TextBox ID="JokenUPDATE_DATE_YYYY" runat="server" Width="50px" MaxLength="4" 
                                            TabIndex="15"></asp:TextBox>年
							            <asp:TextBox ID="JokenUPDATE_DATE_MM" runat="server" Width="30px" MaxLength="2" 
                                            TabIndex="16"></asp:TextBox>月

							            <asp:TextBox ID="JokenUPDATE_DATE_DD" runat="server" Width="30px" MaxLength="2" 
                                            TabIndex="17"></asp:TextBox>日
                                    </td>
                                </tr>
                                <tr style="width:900px">
                                    <td align="right" valign="bottom" colspan="4" style="width:100%">
                                        <asp:Button ID="BtnSearch" runat="server" Text="検索" Width="130px" 
                                            CssClass="Button" TabIndex="18" />
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
                <table cellpadding="2" cellspacing="0" border="0" width="900px">
                    <tr>
                        <td style="width:100%">
                            <asp:Button ID="BtnPrint1" runat="server" Text="印刷" Width="130px" 
                                CssClass="Button"  TabIndex="19"/>
                            <asp:Button ID="BtnCsv1" runat="server" Text="CSV出力" Width="130px" 
                                CssClass="Button"  TabIndex="20" Visible="False" />
                            <asp:Button ID="BtnBack1" runat="server" Text="戻る" Width="130px" 
                                CssClass="Button" TabIndex="21" />
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
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GrvList" runat="server" TabIndex="22" CellPadding="2" AutoGenerateColumns="False"
                    AllowPaging="True" PageSize="8" DataKeyNames="KOUENKAI_NO,DR_MPID" 
                    DataSourceID="SqlDataSource1" Width="972px">
                    <AlternatingRowStyle Wrap="false" BackColor="#f2f2f2" />
                    <RowStyle Wrap="false" BackColor="#ffffff" />
                    <HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
                    <PagerSettings Mode="NumericFirstLast" Position="Top" PreviousPageText="&lt;" NextPageText="&gt;"
                        FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
                    <PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
                    <Columns>
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
                            <ItemStyle HorizontalAlign="Left" Width="150px" Wrap="False" />
                        </asp:TemplateField>
                        <asp:BoundField DataField="SANKASHA_ID" HeaderText="参加者番号">
                        <ItemStyle Width="100px" Wrap="False" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="ＤＲ氏名">
                            <ItemTemplate>
                                <asp:Label ID="DR_NAME" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Wrap="False" />
                            <ItemStyle HorizontalAlign="Left" Width="100px" Wrap="False" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="DR&lt;br /&gt;担当MR">
                            <ItemTemplate>
                                <asp:Label ID="MR_NAME" runat="server"></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="100px" Wrap="False" />
                        </asp:TemplateField>
                        <asp:BoundField DataField="TIME_STAMP_BYL" HeaderText="BYL Timestamp" ItemStyle-Wrap="false"
                            HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" Width="150px"></ItemStyle>
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="TOP受信日時">
                            <ItemTemplate>
                                <asp:Label ID="INPUT_DATE" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="TOP更新日時">
                            <ItemTemplate>
                                <asp:Label ID="UPDATE_DATE" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Wrap="False" />
                            <ItemStyle HorizontalAlign="Center" Width="150px" Wrap="False" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="TOP&lt;br /&gt;担当">
                            <ItemTemplate>
                                <asp:Label ID="USER_NAME" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Wrap="True" />
                            <ItemStyle HorizontalAlign="Left" Width="100px" Wrap="False" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="TOP&lt;br /&gt;ｽﾃｰﾀｽ">
                            <ItemTemplate>
                                <asp:Label ID="ANS_STATUS_TEHAI" runat="server"></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="100px" Wrap="False" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="宿&lt;br /&gt;泊">
                            <ItemTemplate>
                                <asp:Label ID="TEHAI_HOTEL" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Wrap="False" />
                            <ItemStyle HorizontalAlign="Center" Width="30px" Wrap="False" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="交&lt;br /&gt;通">
                            <ItemTemplate>
                                <asp:Label ID="REQ_O_TEHAI_1" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Wrap="False" />
                            <ItemStyle HorizontalAlign="Center" Wrap="False" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="タ&lt;br /&gt;ク">
                            <ItemTemplate>
                                <asp:Label ID="TEHAI_TAXI" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Wrap="False" />
                            <ItemStyle HorizontalAlign="Center" Width="30px" Wrap="False" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="MR&lt;br /&gt;手配">
                            <ItemTemplate>
                                <asp:Label ID="MR_TEHAI" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" Width="30px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="緊急">
                            <ItemTemplate>
                                <asp:Label ID="KINKYU_FLAG" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="NZ送信">
                            <ItemTemplate>
                                <asp:Label ID="SEND_FLAG" runat="server"></asp:Label>
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:ButtonField ButtonType="Button" Text="詳細" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                            ItemStyle-HorizontalAlign="Center" CommandName="Detail" ControlStyle-CssClass="ButtonList"
                            ControlStyle-Width="46px" ItemStyle-Width="52px" ItemStyle-BackColor="#e4e9d1">
                            <ControlStyle CssClass="ButtonList" Width="46px"></ControlStyle>
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" BackColor="#E4E9D1" Width="52px">
                            </ItemStyle>
                        </asp:ButtonField>
                        <asp:BoundField HeaderText="SalesForceID" DataField="SALEFORCE_ID" />
                        <asp:BoundField DataField="DR_MPID" HeaderText="MPID" />
                        <asp:BoundField DataField="TIME_STAMP_BYL" HeaderText="TIME_STAMP_BYL" />
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
                                CssClass="Button"  TabIndex="23"/>
                            <asp:Button ID="BtnCsv2" runat="server" Text="CSV出力" Width="130px" 
                                CssClass="Button"  TabIndex="24" Visible="false"/>
                            <asp:Button ID="BtnBack2" runat="server" Text="戻る" Width="130px" 
                                CssClass="Button" TabIndex="25" />
                        </td>
                    </tr>
                </table> 
            </td>
        </tr>
    </table>
</asp:Content>
