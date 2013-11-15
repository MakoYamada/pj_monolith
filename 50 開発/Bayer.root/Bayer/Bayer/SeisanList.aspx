<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="SeisanList.aspx.vb" Inherits="Bayer.SeisanList" %>
<%@ MasterType VirtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td>
                <table width="1000px">
                    <tr align="right" style="width:100%;">
                        <td>
                            <asp:Button ID="BtnBack1" runat="server" Text="�߂�" Width="130px" CssClass="Button" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table>
                                <tr>
                                    <td align="right">
                                        �u����ԍ�
                                    </td>
                                    <td>
                                        <asp:TextBox ID="JokenKOUENKAI_NO" runat="server" Text="12345678901234" Width="130px" MaxLength="14"></asp:TextBox>
                                    </td>
                                    <td align="right">
                                        ���Z�ԍ�
                                    </td>
                                    <td>
                                        <asp:TextBox ID="JokenSEIKYU_NO_TOPTOUR" runat="server" Text="12345678901234" Width="130px" MaxLength="14"></asp:TextBox>
                                    </td>
                                    <td align="right">
                                        �g�b�v�c�A�[&nbsp;&nbsp;&nbsp;<br />���Z�N��
                                    </td>
                                    <td>
                                        <asp:TextBox ID="JokenSEISAN_Y" runat="server" Width="50px" MaxLength="4"></asp:TextBox>�N
							            <asp:TextBox ID="JokenSEISAN_M" runat="server" Width="30px" MaxLength="2"></asp:TextBox>��
                                    </td>
                                    <td align="right">
                                        ���F�敪
                                    </td>
                                    <td>    
                                        <asp:DropDownList ID="JokenSHOUNIN_KUBUN" runat="server" Width="100px"></asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        ���{��
                                    </td>
                                    <td colspan="3">
							            <asp:TextBox ID="JokenFROM_DATE_YYYY" runat="server" Width="50px" MaxLength="4"></asp:TextBox>�N
							            <asp:TextBox ID="JokenFROM_DATE_MM" runat="server" Width="30px" MaxLength="2"></asp:TextBox>��
							            <asp:TextBox ID="JokenFROM_DATE_DD" runat="server" Width="30px" MaxLength="2"></asp:TextBox>��
							            �`
							            <asp:TextBox ID="JokenTO_DATE_YYYY" runat="server" Width="50px" MaxLength="4"></asp:TextBox>�N
							            <asp:TextBox ID="JokenTO_DATE_MM" runat="server" Width="30px" MaxLength="2"></asp:TextBox>��
							            <asp:TextBox ID="JokenTO_DATE_DD" runat="server" Width="30px" MaxLength="2"></asp:TextBox>��
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        BYL���S����<br />
                                        (���[�}��)
                                    </td>
                                    <td colspan="3">
                                        <asp:TextBox ID="JokenKIKAKU_TANTO_ROMA" runat="server" Width="350px" 
                                            MaxLength="300"></asp:TextBox>                                        
                                    </td>
                                    <td align="right">
                                        BYL���S����<br />BU
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="JokenBU" runat="server">
                                        </asp:DropDownList>
                                    </td>
                                    <td align="right">
                                        BYL���S����<br />�G���A
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="JokenKIKAKU_TANTO_AREA" runat="server">
                                        </asp:DropDownList>
                                    </td>
                                </tr>                                
                            </table>                            
                        </td>
                    </tr>
                    <tr align="right">
                        <td>
                            <asp:Button ID="BtnSearch" runat="server" Width="130px" Text="����" CssClass="Button" />
                            <asp:Button ID="BtnInsert" runat="server" Width="130px" Text="�V�K�o�^" CssClass="Button" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left">
                            <hr style="width:100%" />
                            <asp:Label ID="LabelNoData" runat="server" CssClass="NoData">�Ώۃf�[�^���o�^����Ă��܂���B</asp:Label>
                            <br />
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:GridView ID="GrvList" runat="server" TabIndex="15" CellPadding="2" AutoGenerateColumns="False"
                                AllowPaging="True" PageSize="10" DataKeyNames="KOUENKAI_NO"
                                DataSourceID="SqlDataSource1" Width="1282px">
                                <AlternatingRowStyle Wrap="false" BackColor="#f2f2f2" />
                                <RowStyle Wrap="false" BackColor="#ffffff" />
                                <HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
                                <PagerSettings Mode="NumericFirstLast" Position="Top" PreviousPageText="&lt;" NextPageText="&gt;"
                                    FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
                                <PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
                                <Columns>
                                    <asp:BoundField DataField="BU" HeaderText="BYL<br/>���S��<br/>BU" ItemStyle-Wrap="false" 
                                        HeaderStyle-Wrap="false" HtmlEncode="False">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" Width="70px" HorizontalAlign="Left"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="KIKAKU_TANTO_AREA" HeaderText="BYL<br/>���S��<br/>�G���A" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" HtmlEncode="False">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" Width="70px" HorizontalAlign="Left"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="KIKAKU_TANTO_EIGYOSHO" HeaderText="BYL<br/>���S��<br/>�c�Ə�" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" HtmlEncode="False">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" Width="90px" HorizontalAlign="Left"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="KIKAKU_TANTO_NAME" HeaderText="BYL<br/>���S����" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" HtmlEncode="False">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" Width="100px" HorizontalAlign="Left"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="FROM_DATE" HeaderText="���{��" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                                        ItemStyle-HorizontalAlign="Center">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" Wrap="False" Width="100px"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="KOUENKAI_NO" HeaderText="�u����ԍ�" >
                                    <ItemStyle HorizontalAlign="Left" Width="130px" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="KOUENKAI_NAME" HeaderText="�u���" ItemStyle-Wrap="false"
                                        HeaderStyle-Wrap="false">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" Width="300px" HorizontalAlign="Left"></ItemStyle>
                                    </asp:BoundField>                                    
                                    <asp:BoundField DataField="SEIKYU_NO_TOPTOUR" HeaderText="���Z�ԍ�" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" Width="140px" HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="SEISAN_YM" HeaderText="�g�b�v�c�A�[<br/>���Z�N��" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" HtmlEncode="False">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" Width="90px" HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="SHOUNIN_KUBUN" HeaderText="���F<br/>�敪" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" HtmlEncode="False">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" Width="50px" HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="SEND_FLAG" HeaderText="���M<br/>��" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" HtmlEncode="False">
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle Wrap="False" Width="80px" HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>                
                                    <asp:ButtonField ButtonType="Button" Text="�ڍ�" ItemStyle-Wrap="false" HeaderStyle-Wrap="false"
                                        ItemStyle-HorizontalAlign="Center" CommandName="Detail" ControlStyle-CssClass="ButtonList"
                                        ControlStyle-Width="46px" ItemStyle-Width="52px" ItemStyle-BackColor="#e4e9d1">
                                        <ControlStyle CssClass="ButtonList" Width="46px"></ControlStyle>
                                        <HeaderStyle Wrap="False"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" Wrap="False" BackColor="#E4E9D1" Width="52px">
                                        </ItemStyle>
                                    </asp:ButtonField>
                                    <asp:BoundField DataField="TO_DATE" HeaderText="TO_DATE" />
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr align="right">
                        <td>
                            <asp:Button ID="BtnBack2" runat="server" Text="�߂�" Width="130px" CssClass="Button" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>