<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master"
    CodeBehind="TaxiDaichoDLUL.aspx.vb" Inherits="Bayer.TaxiDaichoDLUL" %>

<%@ MasterType VirtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td align="left">
                <asp:Label ID="Label1" runat="server" CssClass="NoData">下記一覧からダウンロードしたCSVファイルを編集し、タクチケ台帳を出力する会合のみを残して、ここでアップロードしてください。</asp:Label>
            </td>
        </tr>
		<tr>
			<td align="left">
                <table cellpadding="2" cellspacing="0" style="border-collapse: collapse;" width="900px" border="0">
					<tr style="width:100%">
						<td align="center" style="width:30%" class="TdTitle ">
						    タクチケ台帳出力対象データ取込
						</td>
						<td align="left" class="TdItem">
						    <asp:FileUpload ID="FileUpload1" runat="server" Width="533px" />
						</td>
					</tr>					
		            <tr style="height: 50px;" valign="bottom">
			            <td align="left" colspan="2">
				            <asp:Button ID="BtnTorikomi" runat="server" Text="取込開始" Width="180px" CssClass="Button" />
			            </td>
		            </tr>
				</table>
	            <table cellspacing="0" cellpadding="2" border="0">
		            <tr id="TrError" runat="server">
			            <td align="left" colspan="2" style="font-weight: bold; color: #cb1a1a;">
				            エラーがありました。<br />
				            詳細は操作ログ照会でご確認ください。

				            <br />
				            &nbsp;&nbsp;
				            <asp:TextBox ID="LabelErrorMessage" runat="server" Width="900px" Height="108px" 
                                TextMode="MultiLine" ForeColor="#cb1a1a" TabIndex="-1" ReadOnly="true"></asp:TextBox>
			            </td>
		            </tr>
		            <tr id="TrEnd" runat="server">
			            <td align="left" colspan="2" style="font-weight: bold; color:#003399;">
				            正常に終了しました。

				            <br />
				            処理件数：

				            <asp:Label ID="LabelUpdatedCount" runat="server"></asp:Label>件
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
                                CssClass="Button" tabindex="12" />
                            <asp:Button ID="BtnAllClear1" runat="server" Text="全解除" Width="130px" 
                                CssClass="Button" tabindex="12" />
                        </td>
                        <td style="width:50%" align="right">
                            <asp:Button ID="BtnDelete1" runat="server" Text="削除" Width="130px" 
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
                <asp:Label ID="Label2" runat="server" CssClass="NoData">自動精算時に生成されたタクチケ台帳出力対象データは下記の通りです。</asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GrvList" runat="server" TabIndex="16" CellPadding="2" 
                    AutoGenerateColumns="False" PageSize="13" DataKeyNames="FILE_NAME" 
                    DataSourceID="SqlDataSource1" Width="972px" AllowSorting="True">
                    <AlternatingRowStyle Wrap="false" BackColor="#f2f2f2" />
                    <RowStyle Wrap="false" BackColor="#ffffff" />
                    <HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
                    <PagerSettings Mode="NumericFirstLast" Position="Top" PreviousPageText="&lt;" NextPageText="&gt;"
                        FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
                    <PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
                    <Columns>
                        <asp:TemplateField HeaderText="削除">
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
                        <asp:BoundField DataField="FILE_NAME" HeaderText="出力対象CSVファイル名" />
                        <asp:BoundField DataField="INS_DATE" HeaderText="出力対象CSV自動生成日" />
                        <asp:BoundField DataField="FILE_TYPE" HeaderText="ファイルタイプ" />
                        <asp:ButtonField ButtonType="Button" CommandName="Download" HeaderText="ダウンロード" 
                            Text="ダウンロード">
                        <ControlStyle CssClass="ButtonList90" />
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:ButtonField>
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
                                CssClass="Button" tabindex="12" />
                            <asp:Button ID="BtnAllClear2" runat="server" Text="全解除" Width="130px" 
                                CssClass="Button" tabindex="12" />
                        </td>
                        <td style="width:50%" align="right">
                            <asp:Button ID="BtnDelete2" runat="server" Text="削除" Width="130px" 
                                CssClass="Button" tabindex="12" />
                            <asp:Button ID="BtnBack2" runat="server" Text="戻る" Width="130px" 
                                CssClass="Button" TabIndex="13" />
                        </td>
                    </tr>
                </table> 
            </td>
        </tr>
    </table>
</asp:Content>
