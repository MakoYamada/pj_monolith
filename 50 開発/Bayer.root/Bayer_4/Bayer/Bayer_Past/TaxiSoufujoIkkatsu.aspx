<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master"
    CodeBehind="TaxiSoufujoIkkatsu.aspx.vb" Inherits="Bayer_Past.TaxiSoufujoIkkatsu" %>

<%@ MasterType VirtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td align="left">
                <table cellpadding="2" cellspacing="0" border="0" width="100%">
                    <tr>
                        <td align="left">
                            <table cellpadding="2" cellspacing="0" border="0" width="100%">
                                <tr>
                                    <td style="width:140px">
                                        スキャンデータ取込日
                                    </td>
                                    <td align="left" valign="middle" colspan="5">
							            <asp:TextBox ID="JokenFROM_DATE_YYYY" runat="server" Width="50px" MaxLength="4" 
                                            TabIndex="3"></asp:TextBox>年
							            <asp:TextBox ID="JokenFROM_DATE_MM" runat="server" Width="30px" MaxLength="2" 
                                            TabIndex="4"></asp:TextBox>月

							            <asp:TextBox ID="JokenFROM_DATE_DD" runat="server" Width="30px" MaxLength="2" 
                                            TabIndex="5"></asp:TextBox>日
							            ～

							            <asp:TextBox ID="JokenTO_DATE_YYYY" runat="server" Width="50px" MaxLength="4" 
                                            TabIndex="6"></asp:TextBox>年
							            <asp:TextBox ID="JokenTO_DATE_MM" runat="server" Width="30px" MaxLength="2" 
                                            TabIndex="7"></asp:TextBox>月

							            <asp:TextBox ID="JokenTO_DATE_DD" runat="server" Width="30px" MaxLength="2" 
                                            TabIndex="8"></asp:TextBox>日
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width:140px">
                                        会合番号
                                    </td>
                                    <td align="left" valign="middle" colspan="5">
							            <asp:TextBox ID="JokenKOUENKAI_NO" runat="server" Width="125px" MaxLength="14" 
                                            TabIndex="9"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr style="width:100%">
                                    <td align="right" valign="bottom" colspan="6" style="width:100%">
                                        <asp:Button ID="BtnSearch" runat="server" Text="検索" Width="130px" 
                                            CssClass="Button" TabIndex="12" />
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
                            <asp:Button ID="BtnSoufujo1" runat="server" Text="送付状印刷" Width="170px" 
                                CssClass="Button" tabindex="13"/>
                            <asp:Button ID="BtnKakuninhyo1" runat="server" Text="確認票印刷" Width="170px" 
                                CssClass="Button" tabindex="13"/>
                            <asp:Button ID="BtnBack1" runat="server" Text="戻る" Width="130px" 
                                CssClass="Button" TabIndex="14" />
                        </td>
                    </tr>
                </table> 
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:Label ID="LabelNoData" runat="server" CssClass="NoData">対象データがありません。</asp:Label>
                <asp:Label ID="LabelCountTitle" runat="server">検索結果件数：</asp:Label>
                <asp:Label ID="LabelCount" runat="server"></asp:Label>
                <br />
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GrvList" runat="server" TabIndex="15" CellPadding="2" 
                    AutoGenerateColumns="False" PageSize="30" DataKeyNames="KOUENKAI_NO,DR_MPID" 
                    DataSourceID="SqlDataSource1" Width="972px" AllowPaging="True">
                    <AlternatingRowStyle Wrap="false" BackColor="#f2f2f2" />
                    <RowStyle Wrap="false" BackColor="#ffffff" />
                    <HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
                    <PagerSettings Mode="NumericFirstLast" Position="Top" PreviousPageText="&lt;" NextPageText="&gt;"
                        FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
                    <PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
                    <Columns>
                        <asp:BoundField DataField="KOUENKAI_NO" HeaderText="会合番号" ItemStyle-Wrap="false"
                            HeaderStyle-Wrap="false">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False" HorizontalAlign="Left"></ItemStyle>
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="会合名">
                            <ItemTemplate>
                                <asp:Label ID="KOUENKAI_NAME" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Wrap="False" />
                            <ItemStyle HorizontalAlign="Left" Wrap="False" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="開催日">
                            <ItemTemplate>
                                <asp:Label ID="JISSI_DATE" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Wrap="False" />
                            <ItemStyle HorizontalAlign="Left" Wrap="False" />
                        </asp:TemplateField>
                        <asp:BoundField DataField="SANKASHA_ID" HeaderText="参加者ID" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False" HorizontalAlign="Left"></ItemStyle>
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="ＤＲ氏名">
                            <ItemTemplate>
                                <asp:Label ID="DR_NAME" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Wrap="False" />
                            <ItemStyle HorizontalAlign="Left" Wrap="False" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="スキャンデータ取込日">
                            <ItemTemplate>
                                <asp:Label ID="SCAN_DATE" runat="server"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Wrap="False" />
                            <ItemStyle HorizontalAlign="Left" Wrap="False" />
                        </asp:TemplateField>
                        <asp:BoundField DataField="SALEFORCE_ID" HeaderText="SALESFORCE_ID" />
                        <asp:BoundField DataField="TIME_STAMP_BYL" HeaderText="TIME_STAMP_BYL" />
                        <asp:BoundField DataField="DR_MPID" HeaderText="DR_MPID" ItemStyle-Wrap="false"
                            HeaderStyle-Wrap="false">
<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle Wrap="False"></ItemStyle>
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="SCAN_IMPORT_DATE">
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server"></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <HeaderStyle Wrap="False" />
                            <ItemStyle Wrap="False" />
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                <table cellpadding="2" cellspacing="0" border="0" width="100%">
                    <tr>
                        <td style="width:100%">
                            <asp:Button ID="BtnSoufujo2" runat="server" Text="送付状印刷" Width="170px" 
                                CssClass="Button" tabindex="13"/>
                            <asp:Button ID="BtnKakuninhyo2" runat="server" Text="確認票印刷" Width="170px" 
                                CssClass="Button" tabindex="13"/>
                            <asp:Button ID="BtnBack2" runat="server" Text="戻る" Width="130px" 
                                CssClass="Button" TabIndex="17" />
                        </td>
                    </tr>
                </table> 
            </td>
        </tr>
    </table>
</asp:Content>
