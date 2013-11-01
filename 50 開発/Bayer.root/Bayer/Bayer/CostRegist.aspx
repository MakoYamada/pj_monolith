<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="CostRegist.aspx.vb" Inherits="Bayer.CostRegist" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellspacing="0" cellpadding="2" border="0">
        <tr>
			<td align="left">
			    <table cellpadding="2" cellspacing="0" border="0">
			        <tr>
			            <td align="left" colspan="2">
							請求番号
							<asp:TextBox ID="JokenSEIKYU_NO" runat="server" Width="130px" MaxLength="14"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
							請求年月
							<asp:TextBox ID="JokenSEIKYU_YM" runat="server" Width="80px" MaxLength="6"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
						</td>
						<td>
							<asp:Button ID="BtnSearch" runat="server" Text="検索" Width="150px" CssClass="Button" />
						</td>
						<td>
							<asp:Button ID="BtnRegist" runat="server" Text="新規登録" Width="150px" CssClass="Button" />
						</td>
			        </tr>
			    </table>
			</td>
		</tr>
    </table>
    <hr style="width: 100%;" />
	<div ID="DivMessage" runat="server" style="margin-bottom: 10px;">
		<asp:Label ID="LabelMessage" runat="server" Font-Bold="true">
			コストセンター別費用情報を登録しました。 <br />
			<br />
			トップツアー請求番号＝12345678901234<br />
			請求年月＝201312
		</asp:Label>
	</div>
	<table cellspacing="0" cellpadding="2" border="0" id="TblRegist" runat="server" style="margin: 5px 5px 5px 2px; border: #999999 1px solid;">
	    <tr>
	        <td align="left" style="padding: 3px;">
	            <table border="0" cellpadding="2" cellspacing="2" width="100%">
	                <tr>
						<td align="left" style="background-color: #87CEEB; color: #555555; font-weight: bold; width: 100px;">
							&nbsp;
							請求番号
						</td>
						<td align="left" class="TdItem">
							<asp:TextBox ID="SEIKYU_NO" runat="server" Width="100px" MaxLength="14"></asp:TextBox>
							<asp:Label ID="DispSEIKYU_NO" runat="server"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="left" style="background-color: #87CEEB; color: #555555; font-weight: bold;">
							&nbsp;
							請求年月
						</td>
						<td align="left" class="TdItem">
							<asp:TextBox ID="SEIKYU_YM" runat="server" Width="80px" MaxLength="6"></asp:TextBox>
							<asp:Label ID="DispSEIKYU_YM" runat="server"></asp:Label>
						</td>
					</tr>
					<tr>
					    <td>
					        <asp:Button ID="btnAdd" runat="server" Text="行追加" Width="100px" CssClass="Button" />
					    </td>
					    <td align="right">
					        <asp:Button ID="BtnCalc" runat="server" Text="再計算" Width="150px" CssClass="Button" />
					        &nbsp;&nbsp;&nbsp;
					        <asp:Button ID="BtnSubmit" runat="server" Text="登録" Width="150px" CssClass="Button" />
					    </td>
					</tr>
				</table>
				<table border="0" cellpadding="2" cellspacing="2">
					<tr>
					    <td colspan="6">
					        <table>
					            <tr>
					                <td>
                                        <asp:GridView ID="GrvUpdate" runat="server" CellPadding="2" 
                                            AutoGenerateColumns="False" PageSize="1" Width="995px" ShowFooter="True">
                                            <HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
                                            <AlternatingRowStyle Wrap="false" BackColor="#f2f2f2" />
                                            <RowStyle Wrap="false" BackColor="#ffffff" />
                                            <PagerSettings Mode="NumericFirstLast" Position="Top" PreviousPageText="&lt;" NextPageText="&gt;" FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
					                        <PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
                                            <Columns>
                                                <asp:TemplateField HeaderText="コストセンター">
                                                    <FooterStyle BackColor="#D8D8D8" />
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                    <ItemStyle Width="410px" HorizontalAlign="Left" VerticalAlign="Top" />
                                                    <ItemTemplate>
                                                        <asp:DropDownList ID="ddlCostCenter" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCostCenter_SelectedIndexChanged">
                                                        </asp:DropDownList>
                                                        <asp:Label ID="COSTCENTER_NAME1" runat="server" Text=""></asp:Label>
                                                        <asp:TextBox ID="COSTCENTER_NAME" runat="server" MaxLength="100" ReadOnly="True" 
                                                        TextMode="MultiLine" Height="18px" Width="260px"
                                                        BorderStyle="None"></asp:TextBox>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="交通費">
                                                    <FooterStyle BackColor="#D8D8D8" Font-Bold="False" HorizontalAlign="Right" />
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                    <ItemStyle Width="105px" />
                                                    <ItemTemplate>
                                                        <asp:TextBox ID="KOTSUHI" runat="server" Width="100px"
                                                            Text='<%#DataBinder.Eval(Container.DataItem, "pKOTSUHI") %>' ></asp:TextBox>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="宿泊費">
                                                    <FooterStyle BackColor="#D8D8D8" Font-Bold="False" HorizontalAlign="Right" />
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                    <ItemStyle Width="105px" />
                                                    <ItemTemplate>
                                                        <asp:TextBox ID="HOTELHI" runat="server" Width="100px" Text='<%#DataBinder.Eval(Container.DataItem, "pHOTELHI")%>' ></asp:TextBox>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="タクチケ<br />実車料金(課税)">
                                                    <FooterStyle BackColor="#D8D8D8" Font-Bold="False" HorizontalAlign="Right" />
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                    <ItemStyle Width="105px" />
                                                    <ItemTemplate>
                                                        <asp:TextBox ID="TAXI_T" runat="server"  Width="100px" Text='<%#DataBinder.Eval(Container.DataItem, "pTAXI_T")%>'></asp:TextBox>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="タクチケ<br />精算料金(課税)">
                                                    <FooterStyle BackColor="#D8D8D8" Font-Bold="False" HorizontalAlign="Right" />
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                    <ItemStyle Width="105px" />
                                                    <ItemTemplate>
                                                        <asp:TextBox ID="TAXI_SEISAN_T" runat="server" Width="100px" Text='<%#DataBinder.Eval(Container.DataItem, "pTAXI_SEISAN_T")%>'></asp:TextBox>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="コストセンター計">
                                                    <FooterStyle BackColor="#D8D8D8" Font-Bold="False" HorizontalAlign="Right" />
                                                    <ItemTemplate>
                                                        <asp:Label ID="KEI" runat="server" Text=""></asp:Label>
                                                    </ItemTemplate>
                                                    <HeaderStyle HorizontalAlign="Left" />
                                                    <ItemStyle Width="115px" HorizontalAlign="Right" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="削除">
                                                    <FooterStyle BackColor="#D8D8D8" Font-Bold="False" HorizontalAlign="Right" />
                                                    <ItemStyle Width="40px" HorizontalAlign="Center" />
                                                    <ItemTemplate>
                                                        <asp:CheckBox ID="chkDelete" runat="server" />
                                                    </ItemTemplate>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                                <asp:BoundField HeaderText="コストセンターコード" DataField="pCOSTCENTER_CD" />
                                            </Columns>
                                        </asp:GridView>
					                </td>
					            </tr>
					        </table>
					    </td>
					</tr>
				</table>
	        </td>
	    </tr>
	</table>
	<table cellspacing="0" cellpadding="2" border="0">
	    <tr>
	        <td align="left">
	            <asp:Label ID="LabelNoData" runat="server" CssClass="NoData">対象データが登録されていません。</asp:Label>
	            <asp:GridView ID="GrvList" runat="server" TabIndex="-1" CellPadding="2" CellSpacing="0" 
				 AutoGenerateColumns="false" ShowHeader="true" ShowFooter="false" 
				 AllowPaging="true" PageSize="10"
				 DataKeyNames="SEIKYU_NO" DataSourceID="SqlDataSource1">
					<HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
					<AlternatingRowStyle Wrap="false" BackColor="#f2f2f2" />
					<RowStyle Wrap="false" BackColor="#ffffff" />
					<PagerSettings Mode="NumericFirstLast" Position="Top" PreviousPageText="&lt;" NextPageText="&gt;" FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
					<PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
					<Columns>
						<asp:ButtonField ButtonType="Button" Text="変更" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center" CommandName="Regist" ControlStyle-CssClass="ButtonList" ControlStyle-Width="46px" ItemStyle-Width="68px" />
						<asp:BoundField DataField="SEIKYU_NO" HeaderText="請求番号" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="SEIKYU_YM" HeaderText="請求年月" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
					</Columns>
				</asp:GridView>
				<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
	        </td>
	    </tr>
	</table>
</asp:Content>

