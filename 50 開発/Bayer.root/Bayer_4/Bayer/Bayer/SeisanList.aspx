<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="SeisanList.aspx.vb" Inherits="Bayer.SeisanList" %>
<%@ MasterType VirtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td>
                <table width="100%">
                    <tr>
                        <td>
                            <table>
                                <tr>
                                    <td align="right">
                                        会合番号
                                    </td>
                                    <td>
                                        <asp:TextBox ID="JokenKOUENKAI_NO" runat="server" Text="12345678901234" Width="130px" MaxLength="14"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        開催日
                                    </td>
                                    <td colspan="5">
							            <asp:TextBox ID="JokenFROM_DATE_YYYY" runat="server" Width="50px" MaxLength="4"></asp:TextBox>年
							            <asp:TextBox ID="JokenFROM_DATE_MM" runat="server" Width="30px" MaxLength="2"></asp:TextBox>月
							            <asp:TextBox ID="JokenFROM_DATE_DD" runat="server" Width="30px" MaxLength="2"></asp:TextBox>日
							            ～
							            <asp:TextBox ID="JokenTO_DATE_YYYY" runat="server" Width="50px" MaxLength="4"></asp:TextBox>年
							            <asp:TextBox ID="JokenTO_DATE_MM" runat="server" Width="30px" MaxLength="2"></asp:TextBox>月
							            <asp:TextBox ID="JokenTO_DATE_DD" runat="server" Width="30px" MaxLength="2"></asp:TextBox>日
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        BYL企画担当者<br />(ローマ字)
                                    </td>
                                    <td>
                                        <asp:TextBox ID="JokenKIKAKU_TANTO_ROMA" runat="server" Width="170px" 
                                            MaxLength="300"></asp:TextBox>                                        
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
                                        精算番号
                                    </td>
                                    <td colspan="5">
                                        <asp:TextBox ID="JokenSEIKYU_NO_TOPTOUR" runat="server" Text="12345678901234" Width="130px" MaxLength="14"></asp:TextBox>
                                        &nbsp;&nbsp;&nbsp;
                                        TOP精算年月
                                        <asp:TextBox ID="JokenSEISAN_Y" runat="server" Width="50px" MaxLength="4"></asp:TextBox>年
							            <asp:TextBox ID="JokenSEISAN_M" runat="server" Width="30px" MaxLength="2"></asp:TextBox>月
                                        &nbsp;&nbsp;&nbsp;
                                        承認区分
                                        &nbsp;&nbsp;&nbsp;
                                        <asp:DropDownList ID="JokenSHOUNIN_KUBUN" runat="server" Width="100px"></asp:DropDownList>
                                        &nbsp;&nbsp;&nbsp;
                                        NOZOMI送信区分
                                        &nbsp;&nbsp;&nbsp;
                                        <asp:DropDownList ID="JokenSEND_FLAG" runat="server" Width="100px"></asp:DropDownList>
                                        &nbsp;&nbsp;&nbsp;
                                    </td>
                                    <td>
                                        <asp:Button ID="BtnSearch" runat="server" Width="130px" Text="検索" CssClass="Button" />
                                        <asp:Button ID="BtnInsert" runat="server" Width="130px" Text="新規登録" CssClass="Button" />
                                    </td>
                                </tr>
                            </table>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left">
                            <hr style="width:100%" />
                            <asp:Label ID="LabelNoData" runat="server" CssClass="NoData">対象データが登録されていません。</asp:Label>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                        </td>
                    </tr>
                    <tr align="left">
                        <td>
                            <table cellspacing="0" cellpadding="2" border="0" id="TblButton1" runat="server">
					            <tr align="center">
					                <td>
                                        <asp:Button ID="BtnSeisanListCsv1" runat="server" Text="精算データ一覧CSV出力" Width="160px" CssClass="Button" />
                                        <asp:Button ID="BtnSeisanListPrint1" runat="server" Text="精算データ一覧印刷" Width="130px" CssClass="Button" />
                                        <asp:Button ID="BtnMishuHoukoku1" runat="server" Text="未収入金滞留理由報告書印刷" Width="200px" CssClass="Button" />
                                        <asp:Button ID="BtnBack1" runat="server" Text="戻る" Width="130px" CssClass="Button" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:GridView ID="GrvList" runat="server" TabIndex="15" CellPadding="2" AutoGenerateColumns="False"
                                AllowPaging="True" DataKeyNames="KOUENKAI_NO"
                                DataSourceID="SqlDataSource1" Width="1367px">
                                <AlternatingRowStyle Wrap="false" BackColor="#f2f2f2" />
                                <RowStyle Wrap="false" BackColor="#ffffff" />
                                <HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
                                <PagerSettings Mode="NumericFirstLast" Position="Top" PreviousPageText="&lt;" NextPageText="&gt;"
                                    FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
                                <PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
                                <Columns>
                                    <asp:BoundField DataField="BU" HeaderText="BU" ItemStyle-Wrap="false" 
                                        HeaderStyle-Wrap="false" HtmlEncode="False">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" HorizontalAlign="Left"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="KIKAKU_TANTO_AREA" HeaderText="エリア" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" HtmlEncode="False">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" HorizontalAlign="Left"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="KIKAKU_TANTO_EIGYOSHO" HeaderText="営業所" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" HtmlEncode="False">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" HorizontalAlign="Left"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="KIKAKU_TANTO_NAME" HeaderText="企画担当者" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" HtmlEncode="False">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" horizontalAlign="Left"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="FROM_DATE" HeaderText="開催日" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                                        ItemStyle-HorizontalAlign="Center">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" Wrap="False" ></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="KOUENKAI_NO" HeaderText="会合番号" >
                                        <ItemStyle HorizontalAlign="Left" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="KOUENKAI_NAME" HeaderText="会合名" ItemStyle-Wrap="false"
                                        HeaderStyle-Wrap="false">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="True" HorizontalAlign="Left"></ItemStyle>
                                    </asp:BoundField>                                    
                                    <asp:BoundField DataField="SEIHIN_NAME" HeaderText="製品名" >
                                        <ItemStyle HorizontalAlign="Left" />
                                    </asp:BoundField>
                                    <%--<asp:BoundField DataField="TEHAI_ID" HeaderText="会場手配番号" >
                                        <ItemStyle HorizontalAlign="Left" Width="130px" />
                                    </asp:BoundField>--%>
                                    <asp:BoundField DataField="SEIKYU_NO_TOPTOUR" HeaderText="精算番号" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="True" HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="SHIHARAI_NO" HeaderText="承認番号" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="True" HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="" HeaderText="精算金額" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" HorizontalAlign="Right"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="SEISAN_KANRYO" HeaderText="精算コメント" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="True" HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="SEISAN_YM" HeaderText="TOP<br/>精算年月" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" HtmlEncode="False">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="UPDATE_DATE" HeaderText="TOP<br/>送信日時" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" HtmlEncode="False">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="True" HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="SHOUNIN_KUBUN" HeaderText="承認<br/>区分" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" HtmlEncode="False">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="SHOUNIN_DATE" HeaderText="承認日" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" HtmlEncode="False">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="SEND_FLAG" HeaderText="NZ<br/>送信" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" HtmlEncode="False">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>                
                                    <asp:ButtonField ButtonType="Button" Text="詳細" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                                        ItemStyle-HorizontalAlign="Center" CommandName="Detail" ControlStyle-CssClass="ButtonList"
                                        ControlStyle-Width="46px" ItemStyle-Width="52px" ItemStyle-BackColor="#e4e9d1">
                                        <ControlStyle CssClass="ButtonList" Width="46px"></ControlStyle>
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" Wrap="False" BackColor="#E4E9D1" >
                                        </ItemStyle>
                                    </asp:ButtonField>
                                    <asp:BoundField DataField="TO_DATE" HeaderText="TO_DATE" />
                                    <asp:BoundField DataField="KEI_TF" HeaderText="KEI_TF" />
                                    <asp:BoundField DataField="KEI_T" HeaderText="KEI_T" />
                                    <asp:BoundField DataField="MR_JR" HeaderText="MR_JR" />
                                    <asp:BoundField DataField="MR_HOTEL" HeaderText="MR_HOTEL" />
                                    <asp:BoundField DataField="MR_HOTEL_TOZEI" HeaderText="MR_HOTEL_TOZEI" />
                                    <asp:BoundField DataField="TAXI_T" HeaderText="TAXI_T" />
                                    <asp:BoundField DataField="TAXI_SEISAN_T" HeaderText="TAXI_SEISAN_T" />
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr align="left">
                        <td>
                            <asp:Button ID="BtnSeisanListCsv2" runat="server" Text="精算データ一覧CSV出力" Width="160px" CssClass="Button" />
                            <asp:Button ID="BtnSeisanListPrint2" runat="server" Text="精算データ一覧印刷" Width="130px" CssClass="Button" />
                            <asp:Button ID="BtnMishuHoukoku2" runat="server" Text="未収入金滞留理由報告書印刷" Width="200px" CssClass="Button" />
                            <asp:Button ID="BtnBack2" runat="server" Text="戻る" Width="130px" CssClass="Button" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>