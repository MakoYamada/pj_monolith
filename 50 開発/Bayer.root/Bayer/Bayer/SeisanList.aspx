<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="SeisanList.aspx.vb" Inherits="Bayer.SeisanList" %>
<%@ MasterType VirtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td>
                <table width="1000px">
                    <tr>
                        <td>
                            <table>
                                <tr>
                                    <td>
                                        çuâââÔî‘çÜ
                                    </td>
                                    <td>
                                        <asp:TextBox ID="JokenKOUENKAI_NO" runat="server" Text="12345678901234" Width="130px" MaxLength="14"></asp:TextBox>
                                    </td>
                                    <td>
                                        ê∏éZî‘çÜ
                                    </td>
                                    <td>
                                        <asp:TextBox ID="JokenSEIKYU_NO_TOPTOUR" runat="server" Text="12345678901234" Width="130px" MaxLength="14"></asp:TextBox>
                                    </td>
                                    <td></td>
                                    <td>
                                        <asp:Button ID="BtnSearch" runat="server" Width="150px" Text="åüçı" CssClass="Button" />
                                    </td>
                                    <td>
                                        <asp:Button ID="BtnInsert" runat="server" Width="150px" Text="êVãKìoò^" CssClass="Button" />
                                    </td>
                                    <td></td>
                                    <td style="width:270px;" align="right">
                                        <asp:Button ID="BtnBack1" runat="server" Text="ñﬂÇÈ" Width="130px" CssClass="Button" />
                                    </td>
                                </tr>
                            </table>
                            <hr style="width:100%" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left">
                            <asp:Label ID="LabelNoData" runat="server" CssClass="NoData">ëŒè€ÉfÅ[É^Ç™ìoò^Ç≥ÇÍÇƒÇ¢Ç‹ÇπÇÒÅB</asp:Label>
                            <br />
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:GridView ID="GrvList" runat="server" TabIndex="15" CellPadding="2" AutoGenerateColumns="False"
                                AllowPaging="True" PageSize="13" DataKeyNames="KOUENKAI_NO"
                                DataSourceID="SqlDataSource1" Width="1012px">
                                <AlternatingRowStyle Wrap="false" BackColor="#f2f2f2" />
                                <RowStyle Wrap="false" BackColor="#ffffff" />
                                <HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
                                <PagerSettings Mode="NumericFirstLast" Position="Top" PreviousPageText="&lt;" NextPageText="&gt;"
                                    FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
                                <PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
                                <Columns>
                                    <asp:BoundField DataField="KOUENKAI_NO" HeaderText="çuâââÔî‘çÜ" >
                                    <ItemStyle HorizontalAlign="Left" Width="130px" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="KOUENKAI_NAME" HeaderText="çuâââÔñº" ItemStyle-Wrap="false"
                                        HeaderStyle-Wrap="false">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" Width="300px" HorizontalAlign="Left"></ItemStyle>
                                    </asp:BoundField>                                    
                                    <asp:BoundField DataField="SEIKYU_NO_TOPTOUR" HeaderText="ê∏éZî‘çÜ" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" Width="140px" HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="SEISAN_YM" HeaderText="ÉgÉbÉvÉcÉAÅ[ê∏éZîNåé" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" Width="130px" HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="SHOUNIN_KUBUN" HeaderText="è≥îFãÊï™" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" Width="90px" HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="KEI_TF" HeaderText="îÒâ€ê≈ã‡äzçáåv" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                                        ItemStyle-HorizontalAlign="Right">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Right" Wrap="False" Width="100px"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="KEI_T" HeaderText="â€ê≈ã‡äzçáåv" ItemStyle-Wrap="false"
                                        HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Right">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Right" Wrap="False" Width="100px"></ItemStyle>
                                    </asp:BoundField>                                    
                                    <asp:ButtonField ButtonType="Button" Text="è⁄ç◊" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                                        ItemStyle-HorizontalAlign="Center" CommandName="Detail" ControlStyle-CssClass="ButtonList"
                                        ControlStyle-Width="46px" ItemStyle-Width="52px" ItemStyle-BackColor="#e4e9d1">
                                        <ControlStyle CssClass="ButtonList" Width="46px"></ControlStyle>
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" Wrap="False" BackColor="#E4E9D1" Width="52px">
                                        </ItemStyle>
                                    </asp:ButtonField>
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr align="right">
                        <td>
                            <asp:Button ID="BtnBack2" runat="server" Text="ñﬂÇÈ" Width="130px" CssClass="Button" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>