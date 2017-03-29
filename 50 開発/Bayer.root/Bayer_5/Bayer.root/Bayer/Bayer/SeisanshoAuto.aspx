﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master"
    CodeBehind="SeisanshoAuto.aspx.vb" Inherits="Bayer.SeisanshoAuto" %>

<%@ MasterType VirtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table cellspacing="0" cellpadding="2" border="0">
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
                <asp:Label ID="LabelNoData" runat="server" CssClass="NoData">対象データが登録されていません。</asp:Label>
                <asp:Label ID="LabelCountTitle" runat="server">件数：</asp:Label>
                <asp:Label ID="LabelCount" runat="server"></asp:Label>
                <br />
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
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
                        <asp:BoundField DataField="FILE_NAME" HeaderText="精算番号表CSVファイル名" />
                        <asp:BoundField DataField="INS_DATE" HeaderText="精算番号表CSV作成日" />
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
