<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master"
    CodeBehind="KouenkaiList.aspx.vb" Inherits="Bayer.KouenkaiList" %>

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
                            <table cellpadding="2" cellspacing="0" border="0">
                                <tr>
                                    <td align="right">
                                        企画担当者<br />
                                        (ローマ字)
                                    </td>
                                    <td>
                                        <asp:TextBox ID="JokenKIKAKU_TANTO_ROMA" runat="server" Width="350px" 
                                            MaxLength="300"></asp:TextBox>                                        
                                    </td>
                                    <td align="right">
                                        手配担当者<br />
                                        (ローマ字)
                                    </td>
                                    <td colspan="3">
                                        <asp:TextBox ID="JokenTEHAI_TANTO_ROMA" runat="server" Width="350px" MaxLength="300" 
                                            TabIndex="1"></asp:TextBox>                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        製品名
                                    </td>
                                    <td colspan="5">
                                        <asp:TextBox ID="JokenSEIHIN_NAME" runat="server" Width="890px" MaxLength="200" 
                                            TabIndex="2"></asp:TextBox>                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        講演会番号
                                    </td>
                                    <td colspan="5">
                                        <asp:TextBox ID="JokenKOUENKAI_NO" runat="server" Width="91px" MaxLength="10" 
                                            TabIndex="3"></asp:TextBox>&nbsp;&nbsp;&nbsp;
                                        講演会名&nbsp;&nbsp;&nbsp;
                                        <asp:TextBox ID="JokenKOUENKAI_NAME" runat="server" Width="714px" MaxLength="160" 
                                            TabIndex="4"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        実施日
                                    </td>
                                    <td colspan="5">
							            <asp:TextBox ID="JokenFROM_DATE_YYYY" runat="server" Width="50px" MaxLength="4" 
                                            TabIndex="5"></asp:TextBox>年
							            <asp:TextBox ID="JokenFROM_DATE_MM" runat="server" Width="30px" MaxLength="2" 
                                            TabIndex="6"></asp:TextBox>月

							            <asp:TextBox ID="JokenFROM_DATE_DD" runat="server" Width="30px" MaxLength="2" 
                                            TabIndex="7"></asp:TextBox>日
							            ～

							            <asp:TextBox ID="JokenTO_DATE_YYYY" runat="server" Width="50px" MaxLength="4" 
                                            TabIndex="8"></asp:TextBox>年
							            <asp:TextBox ID="JokenTO_DATE_MM" runat="server" Width="30px" MaxLength="2" 
                                            TabIndex="9"></asp:TextBox>月

							            <asp:TextBox ID="JokenTO_DATE_DD" runat="server" Width="30px" MaxLength="2" 
                                            TabIndex="10"></asp:TextBox>日
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        企画担当者BU
                                    </td>
                                    <td colspan="5">
                                        <asp:TextBox ID="JokenBU" runat="server" Width="333px" MaxLength="40" TabIndex="11"></asp:TextBox>
                                    </td>
                                </tr> 
                                <tr>
                                    <td align="right">
                                        企画担当者エリア
                                    </td>
                                    <td colspan="5">
                                        <asp:TextBox ID="JokenKIKAKU_TANTO_AREA" runat="server" Width="651px" MaxLength="80" 
                                            TabIndex="12"></asp:TextBox>
                                    </td>
                                </tr> 
                                <tr>
                                    <td>
                                        トップツアー担当者
                                    </td>
                                    <td colspan="5">
                                        <asp:TextBox ID="JokenTTANTO_ID" runat="server" Width="91px" MaxLength="10" 
                                            TabIndex="13"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="bottom" colspan="6">
                                        <asp:Button ID="BtnSearch" runat="server" Text="検索" Width="130px" 
                                            CssClass="Button" TabIndex="14" />
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
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GrvList" runat="server" TabIndex="15" CellPadding="2" AutoGenerateColumns="False"
                    AllowPaging="True" PageSize="13" DataKeyNames="KOUENKAI_NO"
                    DataSourceID="SqlDataSource1" Width="972px">
                    <AlternatingRowStyle Wrap="false" BackColor="#f2f2f2" />
                    <RowStyle Wrap="false" BackColor="#ffffff" />
                    <HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
                    <PagerSettings Mode="NumericFirstLast" Position="Top" PreviousPageText="&lt;" NextPageText="&gt;"
                        FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
                    <PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
                    <Columns>
                        <asp:BoundField DataField="BU" HeaderText="BU(企画担当)" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False" Width="100px" HorizontalAlign="Left"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="KIKAKU_TANTO_AREA" HeaderText="エリア(企画担当)" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False" Width="100px" HorizontalAlign="Left"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="KIKAKU_TANTO_EIGYOSHO" HeaderText="営業所(企画担当)" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False" Width="100px" HorizontalAlign="Left"></ItemStyle>
                        </asp:BoundField>
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
                        <asp:BoundField DataField="TIME_STAMP" HeaderText="Timestamp" ItemStyle-Wrap="false"
                            HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" Width="150px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="STATUS_TEHAI" HeaderText="担当者" ItemStyle-Wrap="false"
                            HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" Width="150px"></ItemStyle>
                        </asp:BoundField>
                        <asp:ButtonField ButtonType="Button" Text="詳細" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                            ItemStyle-HorizontalAlign="Center" CommandName="Detail" ControlStyle-CssClass="ButtonList"
                            ControlStyle-Width="46px" ItemStyle-Width="52px" ItemStyle-BackColor="#e4e9d1">
                            <ControlStyle CssClass="ButtonList" Width="46px"></ControlStyle>
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" BackColor="#E4E9D1" Width="52px">
                            </ItemStyle>
                        </asp:ButtonField>
                        <asp:BoundField DataField="KOUENKAI_NO" HeaderText="講演会番号" Visible="False" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr align="center">
            <td>
                <asp:Button ID="BtnBack" runat="server" Text="戻る" Width="130px" 
                    CssClass="Button" TabIndex="16" />
            </td>
        </tr>
    </table>
</asp:Content>
