<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="KaijoRegist.aspx.vb" Inherits="Bayer.KaijoRegist" MaintainScrollPositionOnPostback="true" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table cellspacing="2" border="0" id="TblComment" runat="server" style="width: 940px;">
		<tr>
			<td nowrap="nowrap" align="left">
				<table cellspacing="2" border="0" style="border: 3px double #339933; width: 100%; background-color: #eaf8ff; margin-bottom: 5px;">
					<tr>
						<td align="center" style="padding: 3px; color: #0099cc; font-weight: bold;">
							�_�u���N�H�[�e�[�V�����u�h�v�E���s(Enter�L�[)��<br />
							���͂ł��܂���B
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
	<table cellspacing="0" cellpadding="0" border="0" style="width: 940px; margin-bottom: 10px;">
		<tr>
			<td nowrap="nowrap" align="left">
				&nbsp;
			</td>
			<td nowrap="nowrap"align="right">
				<asp:Button ID="BtnPrint1" runat="server" Width="150px" Text="��z�����" CssClass="Button" />
				<asp:Button ID="BtnBack1" runat="server" Width="150px" Text="�L�����Z��" CssClass="Button" />
			</td>
		</tr>
	</table>
	<table cellspacing="2" border="0" style="width: 940px;">
		<tr>
			<td nowrap="nowrap" align="right">
				<table cellspacing="0" border="0">
					<tr>
						<td nowrap="nowrap" align="center" class="TdTitle" style="width: 70px;">
							NOZOMI
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="SEND_FLAG" runat="server"></asp:Label>
							&nbsp;
							&nbsp;
						</td>
						<td nowrap="nowrap" align="center" class="TdTitle" style="width: 90px;" id="TdUPDATE_DATE_1" runat="server">
							TOP�X�V����
						</td>
						<td nowrap="nowrap" align="left" class="TdItem" id="TdUPDATE_DATE_2" runat="server">
							<asp:Label ID="UPDATE_DATE" runat="server" Text="2013/12/31 12:34:56"></asp:Label>
							&nbsp;
							&nbsp;
						</td>
						<td nowrap="nowrap" align="center" class="TdTitle" style="width: 80px;">
							TOP�S����
						</td>
						<td nowrap="nowrap" align="left" class="TdItem">
							<asp:Label ID="USER_NAME" runat="server"></asp:Label>
							&nbsp;
							&nbsp;
						</td>
						<td nowrap="nowrap" align="center" class="TdTitleKaijo" style="width: 80px;">
							�X�e�[�^�X
						</td>
						<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 150px;">
							<asp:DropDownList ID="ANS_STATUS_TEHAI" runat="server" Width="145px"></asp:DropDownList>
						</td>
						<td nowrap="nowrap" align="left" id="TdHelp" runat="server">
							<asp:Image runat="server" ImageAlign="AbsMiddle" ImageUrl="~/Images/help.png" /><a href="#" class="link" onclick="window.open('KaijoStatus.html','help','width=500,height=400,menubar=no,stausbar=no,toolbar=no,location=no,resizable=no,scrollbars=no')">�X�e�[�^�X�ɂ���</a>
						</td>
					</tr>
				</table>
			</td>
		</tr>
		<tr>
			<td nowrap="nowrap" align="left">
				<table style="width: 940px; border: 1px solid #738891;" cellspacing="0" border="0">
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp">
							�� �u������
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left">
							<table cellspacing="2" border="0">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										�u����ԍ�
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="KOUENKAI_NO" runat="server" Text="12345678901234"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										�˗����e
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="REQ_STATUS_TEHAI" runat="server" Text="��������������������" Width="100px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										Timestamp
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="TIME_STAMP_BYL" runat="server" Text="8888/88/88 88:88:88" Width="150px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										���F��
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="SHONIN_NAME" runat="server" Text="����������������������������������������" Width="200px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										���F��
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="3">
										<asp:Label ID="SHONIN_DATE" runat="server" Text="yyyy/MM/dd" Width="100px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										�u���
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="5">
										<asp:Label ID="KOUENKAI_NAME" runat="server" Text="��������������������������������������������������������������������������������" Width="600px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										�u���J�Ó�
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="5">
										<asp:Label ID="FROM_DATE" runat="server" Text="yyyy/MM/dd" Width="280px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										�`�P�b�g�󎚖�
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="TAXI_PRT_NAME" runat="server" Text="1234567890" Width="200px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										���i��
									</td>
									<td nowrap="nowrap" align="left" colspan="3">
										<asp:Label ID="SEIHIN_NAME" runat="server" Text="����������������������������������������" Width="400px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										�J�Ó����l
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="5">
										<asp:TextBox ID="KAISAI_DATE_NOTE" runat="server" TextMode="MultiLine" Width="750px" Text="��������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������" ReadOnly="true" TabIndex="-1" CssClass="DispMultiLine"></asp:TextBox>
									</td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left">
							<table border="0" cellpadding="1" cellspacing="2">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										Internal order<br />(�ې�)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="INTERNAL_ORDER_T" runat="server" Text="123456789012" Width="110px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										Internal order<br />(��ې�)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="INTERNAL_ORDER_TF" runat="server" Text="123456789012" Width="110px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										Account Code<br />(�ې�)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="ACCOUNT_CD_T" runat="server" Text="1234567" Width="70px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										Account Code<br />(��ې�)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="ACCOUNT_CD_TF" runat="server" Text="1234567" Width="70px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 115px;">
										Zetia Code
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="ZETIA_CD" runat="server" Text="1234567890" Width="110px"></asp:Label>
									</td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp">
							�� �u���� ���S����
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left">
							<table cellspacing="2" border="0">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										����BU
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="BU" runat="server" Text="����������������������������������������" Width="300px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										�����G���A
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="KIKAKU_TANTO_AREA" runat="server" Text="����������������������������������������" Width="300px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										�����c�Ə�
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="KIKAKU_TANTO_EIGYOSHO" runat="server" Text="����������������������������������������" Width="300px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										�S���Ҏ���
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="KIKAKU_TANTO_NAME" runat="server" Text="������������������������������������������������������������" Width="300px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										�S���Ҏ���(���[�}��)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="KIKAKU_TANTO_ROMA" runat="server" Text="WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW" Width="300px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										�g�ѓd�b�ԍ�
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 150px;">
										<asp:Label ID="KIKAKU_TANTO_KEITAI" runat="server" Text="1234-5678-9012" Width="300px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										�I�t�B�X�d�b�ԍ�
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 150px;">
										<asp:Label ID="KIKAKU_TANTO_TEL" runat="server" Text="1234-5678-9012" Width="300px"></asp:Label>
									</td>
									<td>&nbsp;</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										�g�уA�h���X
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 300px;">
										<asp:Label ID="KIKAKU_TANTO_EMAIL_KEITAI" runat="server" Text="12345678901234567890123456789012345678901234567890" Width="300px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										EMail�A�h���X
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="KIKAKU_TANTO_EMAIL_PC" runat="server" Text="12345678901234567890123456789012345678901234567890" Width="300px"></asp:Label>
									</td>
									<td>&nbsp;</td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp">
							�� �u���� ��z�S����
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left">
							<table cellspacing="2" border="0">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										����BU
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="TEHAI_TANTO_BU" runat="server" Text="����������������������������������������" Width="300px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										�����G���A
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="TEHAI_TANTO_AREA" runat="server" Text="����������������������������������������" Width="300px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										�����c�Ə�
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="TEHAI_TANTO_EIGYOSHO" runat="server" Text="����������������������������������������" Width="300px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										�S���Ҏ���
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="TEHAI_TANTO_NAME" runat="server" Text="������������������������������������������������������������" Width="300px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										�S���Ҏ���(���[�}��)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
										<asp:Label ID="TEHAI_TANTO_ROMA" runat="server" Text="WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW" Width="300px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										�g�ѓd�b�ԍ�
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 150px;">
										<asp:Label ID="TEHAI_TANTO_KEITAI" runat="server" Text="1234-5678-9012" Width="300px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										�I�t�B�X�d�b�ԍ�
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 150px;">
										<asp:Label ID="TEHAI_TANTO_TEL" runat="server" Text="1234-5678-9012" Width="300px"></asp:Label>
									</td>
									<td>&nbsp;</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										�g�уA�h���X
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 300px;">
										<asp:Label ID="TEHAI_TANTO_EMAIL_KEITAI" runat="server" Text="12345678901234567890123456789012345678901234567890" Width="300px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										EMail�A�h���X
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="TEHAI_TANTO_EMAIL_PC" runat="server" Text="12345678901234567890123456789012345678901234567890" Width="300px"></asp:Label>
									</td>
									<td>&nbsp;</td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp">
							�� �T�v
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left">
							<table cellspacing="2" border="0">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										�Q���\�萔
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="3">
										�]�ƈ��ȊO�F
										<asp:Label ID="SANKA_YOTEI_CNT_NMBR" runat="server" Text="12,345" Width="80px"></asp:Label>
										&nbsp;&nbsp;&nbsp;
										�]�ƈ��F
										<asp:Label ID="SANKA_YOTEI_CNT_MBR" runat="server" Text="12,345" Width="80px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 120px;">
										SRM�����敪
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo">
										<asp:Label ID="SRM_HACYU_KBN" runat="server" Text="������������" Width="100px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										�\�Z�z(�ې�)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 120px;">
										<asp:Label ID="YOSAN_T" runat="server" Text="1,234,567,890" Width="100px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp">
										�\�Z�z(��ې�)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 120px;">
										<asp:Label ID="YOSAN_TF" runat="server" Text="1,234,567,890" Width="100px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 110px;">
										�\�Z�z���v
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 120px;">
										<asp:Label ID="YOSAN_TOTAL" runat="server" Text="1,234,567,890" Width="100px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										�ԘJ��\�Z(�ې�)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 120px;">
										<asp:Label ID="IROUKAI_YOSAN_T" runat="server" Text="1,234,567,890" Width="100px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 135px;">
										�ӌ�������\�Z(�ې�)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 120px;" colspan="3">
										<asp:Label ID="IKENKOUKAN_YOSAN_T" runat="server" Text="1,234,567,890" Width="100px"></asp:Label>
									</td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp">
							�� ���
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left">
							<table cellspacing="2" border="0">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp2" style="width: 75px;">
										�J�Ê�]�n
									</td>
									<td nowrap="nowrap" align="left">
										<table cellspacing="2" border="0">
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													�s���{��
												</td>
												<td nowrap="nowrap" align="left" style="width: 95px;">
													<asp:Label ID="KAISAI_KIBOU_ADDRESS1" runat="server" Text="��������" Width="70px"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													�s����
												</td>
												<td nowrap="nowrap" align="left" style="width: 510px;">
													<asp:Label ID="KAISAI_KIBOU_ADDRESS2" runat="server" Text="��������������������������������������������������������������������������������" Width="500px"></asp:Label>
												</td>
												<td>&nbsp;</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													���l��
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="KAISAI_KIBOU_NOTE" runat="server" TextMode="MultiLine" Width="700px" ReadOnly="true" TabIndex="-1" CssClass="DispMultiLine"></asp:TextBox>
												</td>
											</tr>
										</table>
									</td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left">
							<table cellpadding="2" cellspacing="0" style="margin-bottom: 3px;">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp2" style="width: 75px;" rowspan="2">
										�K�v���
									</td>
									<td nowrap="nowrap" align="left">
										<table cellpadding="2" cellspacing="2">
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													�u����
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp2" style="width: 70px;">
													�J�n����
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 55px;">
													<asp:Label ID="KOUEN_TIME1" runat="server" Text="12:34" Width="50px"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp2" style="width: 70px;">
													�I������
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 55px;">
													<asp:Label ID="KOUEN_TIME2" runat="server" Text="12:34" Width="50px"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp2" style="width: 70px;">
													���C�A�E�g
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													<asp:Label ID="KOUEN_KAIJO_LAYOUT" runat="server" Text="��������������������" Width="180px"></asp:Label>
												</td>
											</tr>
										</table>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left">
										<table cellpadding="2" cellspacing="2">
											<tr>
												<td nowrap="nowrap" align="center">
													&nbsp;
												</td>
												<td nowrap="nowrap" align="center" class="TdTitleKaijoDisp2" style="width: 45px;">
													�v
												</td>
												<td nowrap="nowrap" align="center" class="TdTitleKaijoDisp2" style="width: 45px;">
													�s�v
												</td>
												<td nowrap="nowrap" colspan="2">
													&nbsp;
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													�ӌ��������
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="IKENKOUKAN_KAIJO_TEHAI_Yes" runat="server" Text="��" Width="40px"></asp:Label>
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="IKENKOUKAN_KAIJO_TEHAI_No" runat="server" Text="��" Width="40px"></asp:Label>
												</td>
												<td nowrap="nowrap">
													&nbsp;
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													�ԘJ����
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="IROUKAI_KAIJO_TEHAI_Yes" runat="server" Text="��" Width="40px"></asp:Label>
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="IROUKAI_KAIJO_TEHAI_No" runat="server" Text="��" Width="40px"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left">
													<table border="0" cellpadding="2" cellspacing="0" style="margin-left: 5px;">
														<tr>
															<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp2" style="width: 90px;">
																�Q���\��Ґ�
															</td>
															<td nowrap="nowrap" align="left" style="width: 80px;">
																<asp:Label ID="IROUKAI_SANKA_YOTEI_CNT" runat="server" Text="12,345" Width="80px"></asp:Label>
															</td>
														</tr>
													</table>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													�u�t�T��
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="KOUSHI_ROOM_TEHAI_Yes" runat="server" Text="��" Width="40px"></asp:Label>
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="KOUSHI_ROOM_TEHAI_No" runat="server" Text="��" Width="40px"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left">
													<table border="0" cellpadding="2" cellspacing="0" style="margin-left: 5px;">
														<tr>
															<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp2" style="width: 90px;">
																����(From)
															</td>
															<td nowrap="nowrap" align="left" style="width: 60px;">
																<asp:Label ID="KOUSHI_ROOM_FROM" runat="server" Text="12:34" Width="80px"></asp:Label>
															</td>
															<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp2" style="width: 45px;">
																�l��
															</td>
															<td nowrap="nowrap" align="left">
																<asp:Label ID="KOUSHI_ROOM_CNT" runat="server" Text="12,345" Width="80px"></asp:Label>
															</td>
														</tr>
													</table>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													�Ј��T��
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="SHAIN_ROOM_TEHAI_Yes" runat="server" Text="��" Width="40px"></asp:Label>
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="SHAIN_ROOM_TEHAI_No" runat="server" Text="��" Width="40px"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left">
													<table border="0" cellpadding="2" cellspacing="0" style="margin-left: 5px;">
														<tr>
															<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp2" style="width: 90px;">
																�l��
															</td>
															<td nowrap="nowrap" align="left" style="width: 80px;">
																<asp:Label ID="SHAIN_ROOM_CNT" runat="server" Text="12,345" Width="80px"></asp:Label>
															</td>
														</tr>
													</table>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 90px;">
													���b�l����
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="MANAGER_KAIJO_TEHAI_Yes" runat="server" Text="��" Width="40px"></asp:Label>
												</td>
												<td nowrap="nowrap" align="center">
													<asp:Label ID="MANAGER_KAIJO_TEHAI_No" runat="server" Text="��" Width="40px"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left">
													<table border="0" cellpadding="2" cellspacing="0" style="margin-left: 5px;">
														<tr>
															<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp2" style="width: 150px;">
																���b�l�T�� ����(From)
															</td>
															<td nowrap="nowrap" align="left" style="width: 60px;">
																<asp:Label ID="MANAGER_ROOM_FROM" runat="server" Text="12:34" Width="80px"></asp:Label>
															</td>
															<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp2" style="width: 105px;">
																���b�l�T�� �l��
															</td>
															<td nowrap="nowrap" align="left">
																<asp:Label ID="MANAGER_ROOM_CNT" runat="server" Text="12,345" Width="80px"></asp:Label>
															</td>
														</tr>
													</table>
												</td>
											</tr>
										</table>
									</td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp">
							�� �h���E��ʁE���̑�
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left">
							<table cellspacing="2" border="0">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										�h����]����
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="5">
										<asp:Label ID="REQ_ROOM_CNT" runat="server" Text="12,345" Width="80px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										�h����]��
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 140px;">
										<asp:Label ID="REQ_STAY_DATE" runat="server" Text="yyyy/MM/dd" Width="135px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 180px;">
										��ʎ�z�\��l��(JR/AIR)
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 100px;">
										<asp:Label ID="REQ_KOTSU_CNT" runat="server" Text="12,345" Width="80px"></asp:Label>
									</td>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										�^�N�V�[��z�\��l��
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 100px;">
										<asp:Label ID="REQ_TAXI_CNT" runat="server" Text="12,345" Width="80px"></asp:Label>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijoDisp" style="width: 140px;">
										���̑����l��
									</td>
									<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="5">
										<asp:TextBox ID="OTHER_NOTE" runat="server" TextMode="MultiLine" Width="600px" Text="��������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������������" ReadOnly="true" TabIndex="-1" CssClass="DispMultiLine"></asp:TextBox>
									</td>
								</tr>
							</table>
						</td>
					</tr>
				</table>
			</td>
		</tr>
		<tr>
			<td nowrap="nowrap" align="left">
				<table cellspacing="2" border="0" style="margin-top: 10px; width: 940px; border: 1px solid #9babb3;">
					<tr>
						<td nowrap="nowrap" align="left" class="TdTitleKaijo">
							�� ��
						</td>
					</tr>
					<tr>
						<td nowrap="nowrap" align="left">
							<table border="0" cellpadding="1" cellspacing="2">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijo" style="width: 110px;">
										����
									</td>
									<td nowrap="nowrap" align="left">
										<table cellspacing="2" border="0">
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 100px;">
													�{��<br />
													�I�藝�R
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_SENTEI_RIYU" runat="server" Text="��������������������������������������������������������������������������������" Width="650px" MaxLength="510" TextMode="MultiLine"></asp:TextBox>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 100px;">
													�s���{��
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 110px;">
													<asp:DropDownList ID="ADDRESS1" runat="server" Width="100px"></asp:DropDownList>
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 100px;">
													�s�撬��
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 330px;">
													<asp:TextBox ID="ADDRESS2" runat="server" Text="��������������������" Width="350px" MaxLength="100"></asp:TextBox>
												</td>
												<td nowrap="nowrap">&nbsp;</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 100px;">
													�{�ݖ�
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_SHISETSU_NAME" runat="server" Text="��������������������������������������������������������������������������������" Width="600px" MaxLength="80"></asp:TextBox>
													&nbsp;
													<asp:Button ID="BtnShisetsuKensaku" runat="server" Text="����" Width="50px" CssClass="ButtonList" />
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													�{�ݏZ��
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													��<asp:TextBox ID="ANS_SHISETSU_ZIP" runat="server" Text="888-8888" Width="80px" ReadOnly="true" TabIndex="-1" CssClass="disp"></asp:TextBox>
													<asp:Image ID="Image1" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/Images/spacer.gif" Width="2px" Height="1px" />
													<asp:TextBox ID="ANS_SHISETSU_ADDRESS" runat="server" Text="��������������������������������������������������������������������������������" Width="570px" ReadOnly="true" TabIndex="-1" CssClass="disp"></asp:TextBox>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													�{��TEL
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_SHISETSU_TEL" runat="server" Text="0000-0000-0000" Width="130px" ReadOnly="true" TabIndex="-1" CssClass="disp"></asp:TextBox>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													�{��URL
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_SHISETSU_URL" runat="server" Text="http://WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW@" Width="650px" ReadOnly="true" TabIndex="-1" CssClass="disp"></asp:TextBox>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													�u�����ꖼ
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_KOUEN_KAIJO_NAME" runat="server" Text="��������������������������������������������������������������������������������������������������������������������������������������������" Width="650px" MaxLength="160"></asp:TextBox>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													���t���A
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_KOUEN_KAIJO_FLOOR" runat="server" Text="��������������������������������������������������������������������������������������������������������������������������������������������" Width="650px" MaxLength="160"></asp:TextBox>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													�ӌ�������ꖼ
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_IKENKOUKAN_KAIJO_NAME" runat="server" Text="��������������������������������������������������������������������������������������������������������������������������������������������" Width="650px" MaxLength="160"></asp:TextBox>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													�ԘJ���ꖼ
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_IROUKAI_KAIJO_NAME" runat="server" Text="��������������������������������������������������������������������������������������������������������������������������������������������" Width="650px" MaxLength="160"></asp:TextBox>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													�u�t�T����ꖼ
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_KOUSHI_ROOM_NAME" runat="server" Text="��������������������������������������������������������������������������������������������������������������������������������������������" Width="650px" MaxLength="160"></asp:TextBox>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													�Ј��T����ꖼ
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_SHAIN_ROOM_NAME" runat="server" Text="��������������������������������������������������������������������������������������������������������������������������������������������" Width="650px" MaxLength="160"></asp:TextBox>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													���b�l���ꖼ
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_MANAGER_KAIJO_NAME" runat="server" Text="��������������������������������������������������������������������������������������������������������������������������������������������" Width="650px" MaxLength="160"></asp:TextBox>
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													�J�Òn���l
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" colspan="4">
													<asp:TextBox ID="ANS_KAISAI_NOTE" runat="server" Text="��������������������������������������������������������������������������������" Width="650px" MaxLength="510" TextMode="MultiLine"></asp:TextBox>
												</td>
											</tr>
										</table>
									</td>
								</tr>
							</table>
							<table border="0" cellpadding="1" cellspacing="2">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijo" style="width: 110px;" rowspan="3">
										�T�Z����<br />
										(��ې�)
									</td>
									<td nowrap="nowrap" align="left" style="border: 1px solid #a8a8a8;">
										<span style="font-weight: bold;">
											991330401
										</span>
										<br />
										<table cellspacing="2" border="0">
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													����
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													�@�ޔ�
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													���H��
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" colspan="2">
													���v
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_KAIJOUHI_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>
													�~
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_KIZAIHI_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>
													�~
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_INSHOKUHI_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>
													�~
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 140px;">
													<asp:Label ID="ANS_991330401_TF" runat="server" Text="1,234,567,890"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													&nbsp;
												</td>
											</tr>
										</table>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" style="border: 1px solid #a8a8a8;">
										<span style="font-weight: bold;">
											41120200
										</span>
										<br />
										<table cellspacing="2" border="0">
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													�h����
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													��ʔ�
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													�^�N�V�[���ԗ���
												</td>
												<td colspan="2">&nbsp;</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_HOTELHI_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>�~
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_KOTSUHI_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>�~
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_TAXI_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>�~
												</td>
												<td colspan="2">&nbsp;</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 125px;">
													 ��ʏh����z�萔��
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 120px;">
													�^�N�V�[�����萔��
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 120px;">
													�^�N�V�[���Z�萔��
												</td>
												<td colspan="2">&nbsp;</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_TEHAI_TESURYO_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>�~
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_TAXI_HAKKEN_TESURYO_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>�~
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_TAXI_SEISAN_TESURYO_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>�~
												</td>
												<td colspan="2">&nbsp;</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													�l����
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													���̑�
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													�Ǘ���
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" colspan="2">
													���v
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_JINKENHI_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>�~
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_OTHER_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>�~
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_KANRIHI_TF" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>�~
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 140px;">
													<asp:Label ID="ANS_41120200_TF" runat="server" Text="1,234,567,890"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													&nbsp;
												</td>
											</tr>
										</table>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" style="border: 1px solid #a8a8a8;">
										<table cellspacing="2" border="0" style="width: 220px;">
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" colspan="3" style="font-weight: bold;">
													��ېō��v
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 140px;">
													<asp:Label ID="ANS_TOTAL_TF" runat="server" Text="1,234,567,890"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													<asp:Button ID="BtnCalc_ANS_TOTAL_TF" runat="server" Text="�Čv�Z" Width="60px" CssClass="ButtonList" />
												</td>
												<td>&nbsp;</td>
											</tr>
										</table>
									</td>
								</tr>
							</table>
							<table border="0" cellpadding="1" cellspacing="2">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijo" style="width: 110px;" rowspan="3">
										�T�Z����<br />
										(�ې�)
									</td>
									<td nowrap="nowrap" align="left" style="border: 1px solid #a8a8a8;">
										<span style="font-weight: bold;">
											991330401
										</span>
										<br />
										<table cellspacing="2" border="0">
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													����
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													�@�ޔ�
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													���H��
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" colspan="2">
													���v
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_KAIJOUHI_T" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>
													�~
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_KIZAIHI_T" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>
													�~
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_INSHOKUHI_T" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>
													�~
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 140px;">
													<asp:Label ID="ANS_991330401_T" runat="server" Text="1,234,567,890"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													&nbsp;
												</td>
											</tr>
										</table>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" style="border: 1px solid #a8a8a8;">
										<span style="font-weight: bold;">
											41120200
										</span>
										<br />
										<table cellspacing="2" border="0">
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													�l����
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													���̑�
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer">
													�Ǘ���
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" colspan="2">
													���v
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_JINKENHI_T" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>�~
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_OTHER_T" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>�~
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 130px;">
													<asp:TextBox ID="ANS_KANRIHI_T" runat="server" Text="1234567890" Width="100px" MaxLength="10"></asp:TextBox>�~
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 140px;">
													<asp:Label ID="ANS_41120200_T" runat="server" Text="1,234,567,890"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													&nbsp;
												</td>
											</tr>
										</table>
									</td>
								</tr>
								<tr>
									<td nowrap="nowrap" align="left" style="border: 1px solid #a8a8a8;">
										<table cellspacing="2" border="0" style="width: 220px;">
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" colspan="3" style="font-weight: bold;">
													�ېō��v
												</td>
											</tr>
											<tr>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 140px;">
													<asp:Label ID="ANS_TOTAL_T" runat="server" Text="1,234,567,890"></asp:Label>
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													<asp:Button ID="BtnCalc_ANS_TOTAL_T" runat="server" Text="�Čv�Z" Width="60px" CssClass="ButtonList" />
												</td>
												<td>&nbsp;</td>
											</tr>
										</table>
									</td>
								</tr>
							</table>
							<table border="0" cellpadding="1" cellspacing="2">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijo" style="width: 110px;">
										�T�Z����
									</td>
									<td nowrap="nowrap" align="left">
										<table cellspacing="2" border="0">
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 100px;">
													��ېŊz
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													<asp:Label ID="ANS_MITSUMORI_TF" runat="server" Text="1,234,567,890"></asp:Label>
													&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 75px;">
													�ېŊz
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													<asp:Label ID="ANS_MITSUMORI_T" runat="server" Text="1,234,567,890"></asp:Label>
													&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
												</td>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 90px;">
													���p�z���v
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo" style="width: 110px">
													<asp:Label ID="ANS_MITSUMORI_TOTAL" runat="server" Text="1,234,567,890"></asp:Label>
													&nbsp;&nbsp;&nbsp;
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													<asp:Button ID="BtnCalc_ANS_MITSUMORI" runat="server" Text="�Čv�Z" Width="60px" CssClass="ButtonList" />
												</td>
											</tr>
										</table>
									</td>
								</tr>
							</table>
							<table border="0" cellpadding="1" cellspacing="2">
								<tr>
									<td nowrap="nowrap" align="left" class="TdTitleKaijo" style="width: 110px;">
										���Ϗ�
									</td>
									<td nowrap="nowrap" align="left">
										<table cellspacing="2" border="0">
											<tr>
												<td nowrap="nowrap" align="left" class="TdTitleKaijoAnswer" style="width: 100px;">
													�ۑ��ꏊURL
												</td>
												<td nowrap="nowrap" align="left" class="TdItemKaijo">
													<asp:TextBox ID="ANS_MITSUMORI_URL" runat="server" Text="http://WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW@" Width="650px" MaxLength="255"></asp:TextBox>
												</td>
											</tr>
										</table>
									</td>
								</tr>
							</table>
						</td>
					</tr>
				</table>
			</td>
		</tr>
		<tr>
			<td nowrap="nowrap" align="left">
				<table cellspacing="0" cellpadding="2" border="0" style="width: 940px;">
					<tr style="height: 36px;">
						<td nowrap="nowrap"align="left">
							<asp:Button ID="BtnRireki" runat="server" Width="150px" Text="����\��" CssClass="Button" />
							<asp:Button ID="BtnPrint2" runat="server" Width="150px" Text="��z�����" CssClass="Button" />
						</td>
						<td>&nbsp;</td>
						<td nowrap="nowrap"align="right">
							<asp:Button ID="BtnNozomi" runat="server" Width="150px" Text="NOZOMI��" CssClass="Button" />
							<asp:Button ID="BtnSubmit" runat="server" Width="150px" Text="�o�^" CssClass="Button" />
							<asp:Button ID="BtnBack2" runat="server" Width="150px" Text="�L�����Z��" CssClass="Button" />
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
</asp:Content>
