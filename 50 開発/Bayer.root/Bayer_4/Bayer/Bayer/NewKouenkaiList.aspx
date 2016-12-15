<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master"
    CodeBehind="NewKouenkaiList.aspx.vb" Inherits="Bayer.NewKouenkaiList" %>

<%@ MasterType VirtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td align="left">
                <table cellpadding="2" cellspacing="0" border="0" width="972px">
                    <tr style="width:900px">
                        <td>
                            BYL企画担当者BU 
                        </td>
                        <td>
                            <asp:DropDownList ID="JOKEN_BU" runat="server" TabIndex="1" Width="250px">
                            </asp:DropDownList>
                        </td>
                        <td>
                            BYL企画担当者エリア
                        </td>
                        <td>
                            <asp:DropDownList ID="JOKEN_AREA" runat="server" TabIndex="2" Width="250px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <!-- <tr>
                        <td align="right">
                            区分
                        </td>
                        <td colspan="3">
                            <asp:DropDownList ID="KUBUN" runat="server" TabIndex="3">
                            </asp:DropDownList>
                        </td>
                    </tr> -->
                    <tr style="width:900px">
                        <td align="right" valign="bottom" colspan="4" style="width:100%">
                            <asp:Button ID="BtnSearch" runat="server" Text="検索" Width="130px" 
                                CssClass="Button" TabIndex="3" />
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
                            <asp:Button ID="BtnPrint1" runat="server" Text="印刷" Width="130px" 
                                CssClass="Button"  TabIndex="4"/>
                            <asp:Button ID="BtnBack1" runat="server" Text="戻る" Width="130px" 
                                CssClass="Button" TabIndex="5" />
                        </td>
                    </tr>
                </table> 
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
                <asp:GridView ID="GrvList" runat="server" TabIndex="6" CellPadding="2" AutoGenerateColumns="False"
                    AllowPaging="True" PageSize="13" DataKeyNames="KOUENKAI_NO"
                    DataSourceID="SqlDataSource1" Width="972px">
                    <AlternatingRowStyle Wrap="false" BackColor="#f2f2f2" />
                    <RowStyle Wrap="false" BackColor="#ffffff" />
                    <HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
                    <PagerSettings Mode="NumericFirstLast" Position="Top" PreviousPageText="&lt;" NextPageText="&gt;"
                        FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
                    <PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
                    <Columns>
                        <asp:BoundField HeaderText="BU" 
                            ItemStyle-Wrap="false" HeaderStyle-Wrap="false" HtmlEncode="False">
                            <HeaderStyle Wrap="true"></HeaderStyle>
                            <ItemStyle Wrap="True" Width="80px" HorizontalAlign="Left"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField 
                            HeaderText="エリア" ItemStyle-Wrap="false" 
                            HeaderStyle-Wrap="false" HtmlEncode="False">
                            <HeaderStyle Wrap="true"></HeaderStyle>
                            <ItemStyle Wrap="True" Width="80px" HorizontalAlign="Left"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField 
                            HeaderText="営業所" ItemStyle-Wrap="false" 
                            HeaderStyle-Wrap="false" HtmlEncode="False">
                            <HeaderStyle Wrap="true"></HeaderStyle>
                            <ItemStyle Wrap="True" Width="80px" HorizontalAlign="Left"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="企画担当者" 
                            HtmlEncode="False">
                        <HeaderStyle  Wrap="true" />
                        <ItemStyle Width="140px" Wrap="False" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="開催日" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                            ItemStyle-HorizontalAlign="Center">
                            <HeaderStyle></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" Width="100px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="KOUENKAI_NO" HeaderText="会合番号" >
                        <HeaderStyle Wrap="false" />
                        <ItemStyle Width="100px" Wrap="False" />
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
                        <asp:BoundField HeaderText="区分" ItemStyle-Wrap="false"
                            HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center">
                            <HeaderStyle Wrap="False"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" Width="150px"></ItemStyle>
                        </asp:BoundField>
                        <asp:ButtonField ButtonType="Button" Text="詳細" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                            ItemStyle-HorizontalAlign="Center" CommandName="Detail" ControlStyle-CssClass="ButtonList"
                            ControlStyle-Width="46px" ItemStyle-Width="52px" ItemStyle-BackColor="#e4e9d1">
                            <ControlStyle CssClass="ButtonList" Width="46px"></ControlStyle>
                            <HeaderStyle Wrap="true"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="False" BackColor="#E4E9D1" Width="52px">
                            </ItemStyle>
                        </asp:ButtonField>
                        <asp:BoundField HeaderText="開催日TO" ReadOnly="True" />
                        <asp:BoundField DataField="CNT" HeaderText="件数" />
                        <asp:BoundField DataField="KOUENKAI_TITLE" HeaderText="講演会タイトル" />
                        <asp:BoundField DataField="TIME_STAMP" HeaderText="TimeStamp2" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                <table cellpadding="2" cellspacing="0" border="0" width="100%">
                    <tr>
                        <td style="width:100%">
                            <asp:Button ID="BtnPrint2" runat="server" Text="印刷" Width="130px" 
                                CssClass="Button" TabIndex="7" />
                            <asp:Button ID="BtnBack2" runat="server" Text="戻る" Width="130px" 
                                CssClass="Button" TabIndex="8" />
                        </td>
                    </tr>
                </table> 
            </td>
        </tr>
    </table>
</asp:Content>
