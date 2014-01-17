<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="SeisanKensaku.aspx.vb" Inherits="Bayer.SeisanKensaku" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellspacing="0" cellpadding="2" border="0" width="1025px">
        <tr>
            <td align="left">
                <table cellpadding="2" cellspacing="0" border="0">
                    <tr>
                        <td align="left">
                            <table cellpadding="2" cellspacing="0" border="0">
                                <tr>
                                    <td align="right">
                                        BYL企画担当者<br />(ローマ字)
                                    </td>
                                    <td>
                                        <asp:TextBox ID="JokenKIKAKU_TANTO_ROMA" runat="server" Width="170px" MaxLength="300"></asp:TextBox>                                        
                                    </td>
                                    <td align="right">
                                        BYL企画担当者<br />BU
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="JokenBU" runat="server">
                                        </asp:DropDownList>
                                    </td>
                                    <td align="right">
                                        BYL企画担当者<br />エリア
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="JokenKIKAKU_TANTO_AREA" runat="server">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        BYL手配担当者<br />
                                        (ローマ字)
                                    </td>
                                    <td colspan="5">
                                        <asp:TextBox ID="JokenTEHAI_TANTO_ROMA" runat="server" Width="170px" MaxLength="300"></asp:TextBox>                                        
                                    &nbsp;&nbsp;&nbsp;
                                        製品名
                                    &nbsp;&nbsp;&nbsp;
                                        <asp:DropDownList ID="JokenSEIHIN_NAME" runat="server" Width="240px">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        講演会番号
                                    </td>
                                    <td colspan="5">
                                        <asp:TextBox ID="JokenKOUENKAI_NO" runat="server" Width="130px" MaxLength="14"></asp:TextBox>
                                        &nbsp;&nbsp;&nbsp;
                                        講演会名&nbsp;&nbsp;&nbsp;
                                        <asp:TextBox ID="JokenKOUENKAI_NAME" runat="server" Width="350px" MaxLength="160"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        実施日
                                    </td>
                                    <td colspan="3">
							            <asp:TextBox ID="JokenFROM_DATE_YYYY" runat="server" Width="50px" MaxLength="4"></asp:TextBox>年
							            <asp:TextBox ID="JokenFROM_DATE_MM" runat="server" Width="30px" MaxLength="2"></asp:TextBox>月
							            <asp:TextBox ID="JokenFROM_DATE_DD" runat="server" Width="30px" MaxLength="2"></asp:TextBox>日
							            ～
							            <asp:TextBox ID="JokenTO_DATE_YYYY" runat="server" Width="50px" MaxLength="4"></asp:TextBox>年
							            <asp:TextBox ID="JokenTO_DATE_MM" runat="server" Width="30px" MaxLength="2"></asp:TextBox>月
							            <asp:TextBox ID="JokenTO_DATE_DD" runat="server" Width="30px" MaxLength="2"></asp:TextBox>日
                                    </td>
                                    <td align="right">
                                        TOP担当者
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="JokenTTEHAI_TANTO" runat="server">
                                        </asp:DropDownList>
                                    </td>
                                    <td>
                                        <asp:Button ID="BtnSearch" runat="server" Text="検索" Width="130px" CssClass="Button" />
                                    </td>
                                </tr>                                
                            </table>
                        </td>
                    </tr>
                    </table>
            </td>
        </tr>
        <tr>
            <td align="left">
                <hr style="width:100%" />
                <asp:Label ID="LabelNoData" runat="server" CssClass="NoData">対象データが登録されていません。</asp:Label>
                <br />
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            </td>
        </tr>
        <tr align="left">
            <td>
                <asp:Button ID="BtnBack1" runat="server" Text="戻る" Width="130px" CssClass="Button"/>
            </td>
        </tr>

        <tr>
            <td>
                <asp:GridView ID="GrvList" runat="server" CellPadding="2" AutoGenerateColumns="False"
                    AllowPaging="True" PageSize="10" DataKeyNames="KOUENKAI_NO"
                    DataSourceID="SqlDataSource1" Width="848px">
                    <AlternatingRowStyle Wrap="false" BackColor="#f2f2f2" />
                    <RowStyle Wrap="false" BackColor="#ffffff" />
                    <HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
                    <PagerSettings Mode="NumericFirstLast" Position="Top" PreviousPageText="&lt;" NextPageText="&gt;"
                        FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
                    <PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
                    <Columns>
                        <asp:BoundField DataField="BU" HeaderText="BYL企画担当&lt;br/&gt;BU" 
                            ItemStyle-Wrap="false" HeaderStyle-Wrap="false" HtmlEncode="False">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False" Width="90px" HorizontalAlign="Left"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="KIKAKU_TANTO_AREA" 
                            HeaderText="BYL企画担当&lt;br/&gt;エリア" ItemStyle-Wrap="false" 
                            HeaderStyle-Wrap="false" HtmlEncode="False">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False" Width="90px" HorizontalAlign="Left"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="KIKAKU_TANTO_EIGYOSHO" 
                            HeaderText="BYL企画担当&lt;br/&gt;営業所" ItemStyle-Wrap="false" 
                            HeaderStyle-Wrap="false" HtmlEncode="False">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle Wrap="False" Width="90px" HorizontalAlign="Left"></ItemStyle>
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
                        <asp:BoundField DataField="USER_NAME" HeaderText="TOP担当者" ItemStyle-Wrap="false"
                            HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" Width="90px"></ItemStyle>
                        </asp:BoundField>
                        <asp:ButtonField ButtonType="Button" Text="検索" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                            ItemStyle-HorizontalAlign="Center" CommandName="Seisan" ControlStyle-CssClass="ButtonList"
                            ControlStyle-Width="70px" ItemStyle-Width="76px" 
                            ItemStyle-BackColor="#e4e9d1" HeaderText="精算一覧">
                            <ControlStyle CssClass="ButtonList" Width="70px"></ControlStyle>
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" BackColor="#E4E9D1">
                            </ItemStyle>
                        </asp:ButtonField>
                        <asp:BoundField DataField="KOUENKAI_NO" HeaderText="講演会番号" Visible="False" />
                        <asp:BoundField DataField="TO_DATE" HeaderText="TO_DATE" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr align="left">
            <td>                
                <asp:Button ID="BtnBack2" runat="server" Text="戻る" Width="130px" CssClass="Button" />
            </td>
        </tr>
    </table>
</asp:Content>
