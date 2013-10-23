<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="SeisanList.aspx.vb" Inherits="Bayer.SeisanList" %>
<%@ MasterType VirtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <table>
                                <tr>
                                    <td>
                                        講演会番号
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox30" runat="server" Text="12345678901234" Width="130px" MaxLength="14"></asp:TextBox>
                                    </td>
                                    <td>
                                        TOP請求書番号
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox1" runat="server" Text="12345678901234" Width="130px" MaxLength="14"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Button ID="Button1" runat="server" Width="150px" Text="検索" CssClass="Button" />
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
                                    <asp:BoundField DataField="KOUENKAI_NAME" HeaderText="講演会名" ItemStyle-Wrap="false"
                                        HeaderStyle-Wrap="false">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" Width="300px" HorizontalAlign="Left"></ItemStyle>
                                    </asp:BoundField>                                    
                                    <asp:BoundField DataField="SEIKYU_NO_TOPTOUR" HeaderText="TOP請求書番号" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" Width="100px" HorizontalAlign="Left"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="SHIHARAI_NO" HeaderText="支払番号" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" Width="100px" HorizontalAlign="Left"></ItemStyle>
                                    </asp:BoundField>

                                    <asp:BoundField DataField="SEISAN_YM" HeaderText="精算年月" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" Width="100px" HorizontalAlign="Left"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="KEI_TF" HeaderText="非課税金額合計" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                                        ItemStyle-HorizontalAlign="Center">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" Wrap="False" Width="100px"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="KEI_T" HeaderText="課税金額合計" ItemStyle-Wrap="false"
                                        HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" Wrap="False" Width="100px"></ItemStyle>
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
                </table>
            </td>
        </tr>
    </table>
</asp:Content>