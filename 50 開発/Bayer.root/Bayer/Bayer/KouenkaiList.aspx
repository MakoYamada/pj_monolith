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
                                    <td align="right" width="140px">
                                        BYL企画担当者<br />
                                        (ローマ字)
                                    </td>
                                    <td>
                                        <asp:TextBox ID="JokenKIKAKU_TANTO_ROMA" runat="server" Width="250px" 
                                            MaxLength="300" TabIndex="1"></asp:TextBox>                                        
                                    </td>
                                    <td align="right" width="120px">
                                        BYL手配担当者<br />
                                        (ローマ字)
                                    </td>
                                    <td colspan="3">
                                        <asp:TextBox ID="JokenTEHAI_TANTO_ROMA" runat="server" Width="250px" MaxLength="300" 
                                            TabIndex="2"></asp:TextBox>                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        製品名
                                    </td>
                                    <td colspan="5">
                                        <asp:DropDownList ID="JokenSEIHIN_NAME" runat="server" TabIndex="3">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        会合番号
                                    </td>
                                    <td>
                                        <asp:TextBox ID="JokenKOUENKAI_NO" runat="server" Width="121px" MaxLength="14" 
                                            TabIndex="4"></asp:TextBox>
                                    </td>
                                    <td>
                                        会合名
                                    </td>
                                    <td colspan="3">
                                        <asp:TextBox ID="JokenKOUENKAI_NAME" runat="server" Width="544px" MaxLength="160" 
                                            TabIndex="5"></asp:TextBox>
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
                                        BYL企画担当者BU
                                    </td>
                                    <td colspan="5">
                                        <asp:DropDownList ID="JokenBU" runat="server" TabIndex="12">
                                        </asp:DropDownList>
                                    </td>
                                </tr> 
                                <tr>
                                    <td align="right">
                                        BYL企画担当者エリア
                                    </td>
                                    <td colspan="5">
                                        <asp:DropDownList ID="JokenKIKAKU_TANTO_AREA" runat="server" TabIndex="13">
                                        </asp:DropDownList>
                                    </td>
                                </tr> 
                                <tr>
                                    <td align="right">
                                        TOP担当者
                                    </td>
                                    <td colspan="5">
                                        <asp:DropDownList ID="JokenTTEHAI_TANTO" runat="server" TabIndex="14">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="bottom" colspan="6">
                                        <asp:Button ID="BtnSearch" runat="server" Text="検索" Width="130px" 
                                            CssClass="Button" TabIndex="15" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table cellpadding="2" cellspacing="0" border="0" width="900px">
                                <tr>
                                    <td style="width:100%">
                                        <asp:Button ID="BtnPrint1" runat="server" Text="印刷" Width="130px" 
                                            CssClass="Button" TabIndex="16" />
                                        <asp:Button ID="BtnBack1" runat="server" Text="戻る" Width="130px" 
                                            CssClass="Button" TabIndex="17" />
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
                <asp:GridView ID="GrvList" runat="server" TabIndex="18" CellPadding="2" AutoGenerateColumns="False"
                    AllowPaging="True" PageSize="13" DataKeyNames="KOUENKAI_NO"
                    DataSourceID="SqlDataSource1" Width="972px">
                    <AlternatingRowStyle Wrap="false" BackColor="#f2f2f2" />
                    <RowStyle Wrap="false" BackColor="#ffffff" />
                    <HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
                    <PagerSettings Mode="NumericFirstLast" Position="Top" PreviousPageText="&lt;" NextPageText="&gt;"
                        FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
                    <PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
                    <Columns>
                        <asp:BoundField DataField="BU" HeaderText="BYL企画担当BU" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False" Width="100px" HorizontalAlign="Left"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="KIKAKU_TANTO_AREA" HeaderText="BYL企画担当エリア" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False" Width="100px" HorizontalAlign="Left"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="KIKAKU_TANTO_EIGYOSHO" HeaderText="BYL企画担当営業所" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False" Width="100px" HorizontalAlign="Left"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="FROM_DATE" HeaderText="開催日" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                            ItemStyle-HorizontalAlign="Center">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" Width="100px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="KOUENKAI_NAME" HeaderText="会合名" ItemStyle-Wrap="false"
                            HeaderStyle-Wrap="false">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False" Width="300px" HorizontalAlign="Left"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="TIME_STAMP" HeaderText="Timestamp" ItemStyle-Wrap="false"
                            HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" Width="150px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="USER_NAME" HeaderText="TOP担当者" ItemStyle-Wrap="false"
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
                        <asp:BoundField DataField="KOUENKAI_NO" HeaderText="会合番号" Visible="False" />
                        <asp:BoundField DataField="TO_DATE" HeaderText="TO_DATE" />
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
                                CssClass="Button" TabIndex="19" />
                            <asp:Button ID="BtnBack2" runat="server" Text="戻る" Width="130px" 
                                CssClass="Button" TabIndex="20" />
                        </td>
                    </tr>
                </table> 
            </td>
        </tr>
    </table>
</asp:Content>
