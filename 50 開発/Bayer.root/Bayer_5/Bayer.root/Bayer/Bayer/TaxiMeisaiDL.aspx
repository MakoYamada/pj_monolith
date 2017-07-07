<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master"
    CodeBehind="TaxiMeisaiDL.aspx.vb" Inherits="Bayer.TaxiMeisaiDL" %>

<%@ MasterType VirtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td>
                <table>
                    <tr>
                        <td align="right">
                            会合番号
                        </td>
                        <td colspan="2">
                            <asp:TextBox ID="JokenKOUENKAI_NO" runat="server" Text="12345678901234" Width="130px" MaxLength="14"></asp:TextBox>
                        </td>                        
                    </tr>
                    <tr>
                        <td align="right">
                            開催開始日
                        </td>
                        <td colspan="5">
				            <%--<asp:TextBox ID="JokenFROM_DATE_YYYY" runat="server" Width="50px" MaxLength="4" 
                                ></asp:TextBox>年
				            <asp:TextBox ID="JokenFROM_DATE_MM" runat="server" Width="30px" MaxLength="2" 
                                ></asp:TextBox>月

				            <asp:TextBox ID="JokenFROM_DATE_DD" runat="server" Width="30px" MaxLength="2" 
                                ></asp:TextBox>日--%>
				            <asp:TextBox ID="JokenFROM_DATE" runat="server" Width="80px" MaxLength="8" 
                                ></asp:TextBox>&nbsp;～&nbsp;
				            <asp:TextBox ID="JokenTO_DATE" runat="server" Width="80px" MaxLength="8" 
                                ></asp:TextBox>
				            <%--<asp:TextBox ID="JokenTO_DATE_YYYY" runat="server" Width="50px" MaxLength="4" 
                                ></asp:TextBox>年
				            <asp:TextBox ID="JokenTO_DATE_MM" runat="server" Width="30px" MaxLength="2" 
                                ></asp:TextBox>月

				            <asp:TextBox ID="JokenTO_DATE_DD" runat="server" Width="30px" MaxLength="2" 
                                ></asp:TextBox>日--%>
                        </td>
                        <td>
                            <asp:Button ID="BtnSearch" runat="server" Width="130px" Text="検索" CssClass="Button" />
                        </td>
                    </tr>
                </table>                            
            </td>
        </tr>
        <tr>
            <td align="left">
                <hr style="width:100%" />
                <asp:Label ID="LabelNoData" runat="server" CssClass="NoData">対象データが登録されていません。</asp:Label>
                <asp:Label ID="LabelCountTitle" runat="server">件数：</asp:Label>
                <asp:Label ID="LabelCount" runat="server"></asp:Label>
                <br />
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            </td>
        </tr>
        <tr id="TrButton1" runat="server">
            <td align="right">
                <table cellpadding="2" cellspacing="0" border="0" width="100%">
                    <tr>
                        <td style="width:"50%" align="left">
                            <asp:Button ID="BtnAllSelect1" runat="server" Text="全選択" Width="130px" 
                                CssClass="Button" />
                            <asp:Button ID="BtnAllClear1" runat="server" Text="全解除" Width="130px" 
                                CssClass="Button" />
                        </td>
                        <td style="width:50%" align="right">
                            <asp:Button ID="BtnDownload1" runat="server" Text="ダウンロード" Width="130px" 
                                CssClass="Button" />
                            <asp:Button ID="BtnDelete1" runat="server" Text="削除" Width="130px" 
                                CssClass="Button" />
                            <asp:Button ID="BtnBack1" runat="server" Text="戻る" Width="130px" 
                                CssClass="Button" />
                        </td>
                    </tr>
                </table> 
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GrvList" runat="server" CellPadding="2" 
                    AutoGenerateColumns="False" PageSize="13" DataKeyNames="FILE_NAME" 
                    DataSourceID="SqlDataSource1" Width="972px" AllowSorting="True">
                    <AlternatingRowStyle Wrap="false" BackColor="#f2f2f2" />
                    <RowStyle Wrap="false" BackColor="#ffffff" />
                    <HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
                    <PagerSettings Mode="NumericFirstLast" Position="Top" PreviousPageText="&lt;" NextPageText="&gt;"
                        FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
                    <PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
                    <Columns>
                        <asp:TemplateField HeaderText="選択">
                            <ItemTemplate>
                                <asp:CheckBox ID="chkDelete" runat="server" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" Width="50px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="NO">
                            <ItemTemplate>
                                <%# Container.DataItemIndex + 1  %>
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                        <asp:BoundField DataField="FILE_NAME" HeaderText="タクチケ台帳CSVファイル名" />
                        <asp:BoundField DataField="INS_DATE" HeaderText="タクチケ台帳CSV作成日" />
                        <asp:BoundField DataField="FILE_TYPE" HeaderText="ファイルタイプ" />
                        <%--<asp:ButtonField ButtonType="Button" CommandName="Download" HeaderText="ダウンロード" 
                            Text="ダウンロード">
                        <ControlStyle CssClass="ButtonList90" />
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:ButtonField>--%>
                        <%--<asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="削除" 
                            Text="削除">
                        <ControlStyle CssClass="ButtonList90" />
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:ButtonField>--%>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr id="TrButton2" runat="server">
            <td align="right">
                <table cellpadding="2" cellspacing="0" border="0" width="100%">
                    <tr>
                        <td style="width:"50%" align="left">
                            <asp:Button ID="BtnAllSelect2" runat="server" Text="全選択" Width="130px" 
                                CssClass="Button" />
                            <asp:Button ID="BtnAllClear2" runat="server" Text="全解除" Width="130px" 
                                CssClass="Button" />
                        </td>
                        <td style="width:50%" align="right">
                            <asp:Button ID="BtnDownload2" runat="server" Text="ダウンロード" Width="130px" 
                                CssClass="Button" />
                            <asp:Button ID="BtnDelete2" runat="server" Text="削除" Width="130px" 
                                CssClass="Button" />
                            <asp:Button ID="BtnBack2" runat="server" Text="戻る" Width="130px" 
                                CssClass="Button" />
                        </td>
                    </tr>
                </table> 
            </td>
        </tr>
    </table>
</asp:Content>
