<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="TaxiMaintenanceRegist.aspx.vb" Inherits="Bayer.TaxiMaintenanceRegist" MaintainScrollPositionOnPostback="true" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table border="0" cellpadding="4" cellspacing="0" width="900px">
        <tr>
            <td>
                <table cellpadding="2" cellspacing="0" border="0" width="100%">
                    <tr>
                        <td align="left">
                            <asp:Button ID="BtnBack1" runat="server" Text="�߂�" Width="130px" 
                                CssClass="Button" TabIndex="1" />
                        </td>
                    </tr>
                </table> 
            </td>
        </tr>
		<tr>
			<td nowrap="nowrap" align="left">
				<table style="border-collapse: collapse;" cellspacing="0" cellpadding="2" border="1" bordercolor="#4f5b61" width="100%">
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" colspan="8">
							�� ����
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							��ԍ�
						</td>
						<td nowrap="nowrap" align="left" style="width: 100px;" colspan="7">
							<asp:Label ID="KOUENKAI_NO" runat="server" Text=""></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							���
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" colspan="5">
						    <asp:TextBox ID="KOUENKAI_NAME" runat="server" BorderStyle="None" Height="35px" 
                                ReadOnly="True" TextMode="MultiLine" Width="624px"></asp:TextBox>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							�`�P�b�g�󎚖�
							<br />
							(10����)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" style="width: 95px;">
							<asp:Label ID="TAXI_PRT_NAME" runat="server" Text=""></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 90px;">
							��J�Ó�
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" >
							<asp:Label ID="KOUENKAI_DATE" runat="server" Text=""></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 100px;">
							TOP�S����
						</td>
						<td nowrap="nowrap" align="left" colspan="5">
							<asp:Label ID="TTEHAI_TANTO" runat="server" Text=""></asp:Label>
						</td>
					</tr>
				</table>
			</td>
		</tr>
		<tr>
		    <td align="left"  colspan="2">
				<!-- DR��� -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:100%">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="8">
                            ��DR���
                        </td>
                    </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                �Q����ID
		                </td>
		                <td align="left" valign="middle" colspan="7">							
		                    <asp:TextBox ID="SANKASHA_ID" runat="server" Width="124px" tabindex="2" 
                                MaxLength="14"></asp:TextBox>							
                            <asp:Button ID="BtnSankasha" runat="server" Text="�Q���ҍĕ\��" Width="130px" 
                                CssClass="Button" tabindex="3"/>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                ����
		                </td>
		                <td align="left" valign="middle" colspan="7">
                            <asp:TextBox ID="DR_NAME" runat="server" MaxLength="80" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="750px" TabIndex="1006" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                �����J�i
		                </td>
		                <td align="left" valign="middle" colspan="7">
                            <asp:TextBox ID="DR_KANA" runat="server" MaxLength="80" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="750px" TabIndex="1007" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                ����
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_SEX" runat="server"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                �N��
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_AGE" runat="server"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                ��ւ̎Q��
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_SANKA" runat="server"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                �Q���҂̖���
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_YAKUWARI" runat="server"></asp:Label>
		                </td>
		            </tr> 
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                DCF<br />�{�ݺ���
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_SHISETSU_CD" runat="server"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                �{�ݖ�
		                </td>
		                <td align="left" valign="middle" colspan="5">
                            <asp:TextBox ID="DR_SHISETSU_NAME" runat="server" MaxLength="80" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="341px" TabIndex="1008" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                �{�ݏZ��
		                </td>
		                <td align="left" valign="middle" colspan="7">
                            <asp:TextBox ID="DR_SHISETSU_ADDRESS" runat="server" MaxLength="128" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="750px" TabIndex="1009" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                �w��O<br />�\�����R			                
		                </td>
		                <td align="left" valign="middle" colspan="7">
                            <asp:TextBox ID="SHITEIGAI_RIYU" runat="server" MaxLength="128" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="750px" TabIndex="1010" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		            </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr>
			<td nowrap="nowrap" align="left">
				<table style="border-collapse: collapse; margin-bottom: 8px;" cellspacing="0" cellpadding="2" border="1" bordercolor="#4f5b61" width="100%">
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" colspan="8">
							�� �^�N�`�P���
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							�񓚍s�ԍ�
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="TKT_LINE_NO" runat="server" Text="20"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							�^�N�`�P�ԍ�
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="TKT_NO" runat="server" Text="123456789"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							�^�N�V�[���
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="TKT_KAISHA" runat="server" Text="����M"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							����
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="TKT_KENSHU" runat="server" Text="NG10000"></asp:Label>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							���ԓ�
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="TKT_USED_DATE" runat="server" Text="1234/56/78"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							VOID(��)
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="VOID_DATE" runat="server" Text="1234/56/78"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							�����N��
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="TKT_SEIKYU_YM" runat="server" Text="1234/56"></asp:Label>
						</td>
						<td nowrap="nowrap" align="left" class="TdTitleHeader" style="width: 60px;">
							VOID
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">							
						    <asp:CheckBox ID="TKT_VOID" runat="server" tabindex="4" />							
						</td>
					</tr>
			</table>
			</td>
		</tr>
        <tr>
            <td>
                <table cellpadding="2" cellspacing="0" border="0" width="100%">
                    <tr>
                        <td style="width:100%">
                            <asp:Button ID="BtnSubmit" runat="server" Text="�o�^" Width="130px" 
                                CssClass="Button" tabindex="5"/>
                            <asp:Button ID="BtnBack2" runat="server" Text="�߂�" Width="130px" 
                                CssClass="Button" TabIndex="6" />
                        </td>
                    </tr>
                </table> 
            </td>
        </tr>
	</table>
</asp:Content>
