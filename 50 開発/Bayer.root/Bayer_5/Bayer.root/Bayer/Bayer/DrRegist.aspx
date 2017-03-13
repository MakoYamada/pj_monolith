<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="DrRegist.aspx.vb" Inherits="Bayer.DrRegist" MaintainScrollPositionOnPostback="true" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table border="0" cellpadding="4" cellspacing="0" style="width:900px">
		<tr style="height: 36px; width:100%">
			<td align="left" style="width:100%">
                <a name="PageTopLink"></a>				    
				<asp:Button ID="BtnPrint1" runat="server" Width="130px" Text="��z�����" 
                    CssClass="Button" TabIndex="1" />
				<asp:Button ID="BtnSoufujo1" runat="server" Width="130px" Text="���t����" 
                    CssClass="Button" TabIndex="2" />
				<asp:Button ID="BtnTaxiKakunin1" runat="server" Width="150px" Text="�^�N�`�P��z�m�F�[���" 
                    CssClass="Button" TabIndex="3" />
			    <asp:Button ID="BtnSubmit1" runat="server" Width="130px" Text="�o�^" 
                    CssClass="Button" TabIndex="4" />
			    <asp:Button ID="BtnNozomi1" runat="server" Width="130px" Text="NOZOMI��" 
                    CssClass="Button" TabIndex="5" />
				<asp:Button ID="BtnBack1" runat="server" Width="130px" Text="�߂�" 
                    CssClass="Button" TabIndex="6" />
			</td>
		</tr>
		<tr>
		    <td colspan="2" style="width:100%">
			    <table style="border-collapse: collapse; " cellspacing="0" 
                    cellpadding="2" class="style1">
		            <tr>
		                <td id="TdEmergency" runat="server" align="center" 
                            style="border: thin solid #FF0000; width:10%; font-weight: bold; color: #FF0000;">
			                <a id="msg_emergency" runat="server" 
                                style="font-size: x-large; font-weight: bold; color: #FF0000">�ف@�}</a>
		                </td>
		                <td align="right" style="width:90%">
			                <a href="#TaxiTehaiLink" tabindex="7">�^�N�`�P��z��</a>
		                </td>
		            </tr>
		        </table>
		    </td>
		</tr>
		<tr>
			<td align="left" colspan="2">
			    <!-- ���� -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="8">
                            ������
	                        <asp:Button ID="BtnKihon" runat="server" Width="150px" Text="��{����" 
                                CssClass="Button" TabIndex="8" />
                        </td>
                    </tr>
                    <tr>
						<td align="left" class="TdTitleHeader" style="width:120px">
							��ԍ�
						</td>
						<td align="left" class="TdItem" style="width:100px">
							<asp:Label ID="KOUENKAI_NO" runat="server" Width="100px"></asp:Label>
						</td>
						<td align="left" class="TdTitleHeader" style="width:100px">
							�J�Ó�
						</td>
                        <td align="left" class="TdItem">
							<asp:Label ID="FROM_DATE" runat="server" Width="150px"></asp:Label>
						</td>
						<td align="left" class="TdTitleHeader" style="width:100px">
							TimeStamp
						</td>
                        <td align="left" class="TdItem" colspan="3">
							<asp:Label ID="TIME_STAMP" runat="server"></asp:Label>
                        </td>
                    </tr>
					<tr>
						<td align="left" class="TdTitleHeader" style="width:120px">
							���
						</td>
						<td align="left" class="TdItem" colspan="3">
                            <asp:TextBox ID="KOUENKAI_NAME" runat="server" MaxLength="80" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="500px" tabstop="false" 
                                BorderStyle="None"></asp:TextBox>
						</td>
						<td align="left" class="TdTitleHeader">
							�`�P�b�g�󎚖�
						</td>
						<td align="left" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_PRT_NAME" runat="server" Text=""></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="left" class="TdTitleHeader" style="width:120px">
							��ꖼ
						</td>
						<td align="left" class="TdItem" colspan="3">
                            <asp:TextBox ID="KAIJO_NAME" runat="server" MaxLength="80" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="500px" tabstop="false" 
                                BorderStyle="None"></asp:TextBox>
						</td>
						<td align="left" class="TdTitleHeader">
							�c�̃R�[�h
						</td>
						<td align="left" class="TdItem" colspan="3">
							<asp:Label ID="DANTAI_CODE" runat="server" Text=""></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="left" class="TdTitleHeader">
							WBS Element
						</td>
						<td align="left" class="TdItem" colspan="7">
							<asp:Label ID="WBS_ELEMENT1" runat="server" Text=""></asp:Label>
						</td>
					</tr>
				</table>
			</td>
		</tr>
		<tr>
		    <td align="left"  colspan="2">
				<!-- DR��� -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="8">
                            ��DR���
                        </td>
                    </tr>
		            <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                ��z<br />�X�e�[�^�X
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="REQ_STATUS_TEHAI" runat="server" Width="120px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitle" style="width:100px">
			                ��<br />�X�e�[�^�X
		                </td>
		                <td align="left" valign="middle">							
		                    <asp:DropDownList ID="ANS_STATUS_TEHAI" runat="server" Width="150px" 
                                TabIndex="9" AutoPostBack="True">
                            </asp:DropDownList>						
		                </td>
		                <td align="left" valign="middle" class="TdTitle" style="width:100px">
			                �`�P�b�g��<br />�������i�ŐV�j
		                </td>
		                <td align="left" valign="middle">							
                            <asp:TextBox ID="ANS_TICKET_SEND_DAY" runat="server" MaxLength="8" 
                                Height="18px" Width="79px" TabIndex="10"></asp:TextBox>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                NOZOMI���M<br />�X�e�[�^�X
		                </td>
		                <td align="left" valign="middle">							
							<asp:Label ID="SEND_FLAG" runat="server" Width="120px"></asp:Label>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                �Q����ID
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="SANKASHA_ID" runat="server" Width="120px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                DR�R�[�h</td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_CD" runat="server" Width="140px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                TimeStamp(BYL)
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="TIME_STAMP_BYL" runat="server" Width="120px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                TimeStamp(TOP)
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="TIME_STAMP_TOP" runat="server" Width="120px"></asp:Label>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                ����
		                </td>
		                <td align="left" valign="middle" colspan="7">
                            <asp:TextBox ID="DR_NAME" runat="server" MaxLength="80" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="750px"  tabstop="false" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                �����J�i
		                </td>
		                <td align="left" valign="middle" colspan="7">
                            <asp:TextBox ID="DR_KANA" runat="server" MaxLength="80" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="750px"  tabstop="false" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                �N��
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_AGE" runat="server" Width="100px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                ����
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_SEX" runat="server" Width="100px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                ��ւ̎Q��
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_SANKA" runat="server" Width="100px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                �Q���҂̖���
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_YAKUWARI" runat="server" Width="100px"></asp:Label>
		                </td>
		            </tr> 
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                DCF<br />�{�ݺ���
		                </td>
		                <td align="left" valign="middle">
							<asp:Label ID="DR_SHISETSU_CD" runat="server" Width="100px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                �{�ݖ�
		                </td>
		                <td align="left" valign="middle" colspan="5">
                            <asp:TextBox ID="DR_SHISETSU_NAME" runat="server" MaxLength="80" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="533px"  tabstop="false" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                �{�ݏZ��
		                </td>
		                <td align="left" valign="middle" colspan="7">
                            <asp:TextBox ID="DR_SHISETSU_ADDRESS" runat="server" MaxLength="128" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="750px"  tabstop="false" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		            </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                �w��O<br />�\�����R			                
		                </td>
		                <td align="left" valign="middle" colspan="7">
                            <asp:TextBox ID="SHITEIGAI_RIYU" runat="server" MaxLength="128" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="750px"  tabstop="false" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		            </tr>
		            <tr>		                
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                WBS Element
		                </td>
		                <td align="left" valign="middle" colspan="7">
							<asp:Label ID="WBS_ELEMENT" runat="server"></asp:Label>
		                </td>
		            </tr>
	                <tr id="TrSEIKYU_NO_TOPTOUR" runat="server">
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                ���Z�ԍ�
		                </td>
		                <td align="left" valign="middle" colspan="7">
                            <asp:TextBox ID="SEIKYU_NO_TOPTOUR" runat="server" MaxLength="14" Width="130px"></asp:TextBox>
		                </td>
		            </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr>
		    <td align="left"  colspan="2">
				<!-- ���F�ҏ�� -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="4">
                            �����F�ҏ��
                        </td>
                    </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                �ŏI���F��
		                </td>
		                <td align="left" valign="top">
                            <asp:TextBox ID="SHONIN_NAME" runat="server" MaxLength="80" ReadOnly="True" 
                                TextMode="MultiLine" Height="18px" Width="388px"  tabstop="false" 
                                BorderStyle="None"></asp:TextBox>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:100px">
			                �ŏI���F����
		                </td>
		                <td align="left" valign="top">
							<asp:Label ID="SHONIN_DATE" runat="server" Width="140px"></asp:Label>
		                </td>
		            </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" tabindex="11">�y�[�W�g�b�v��</a>
		    </td>
		</tr>
		<tr>
		    <td align="left" colspan="2">
				<!-- DR�S��MR -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="9">
                            ��DR�S��MR
                        </td>
                    </tr>
	                <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                BU
		                </td>
		                <td align="left" valign="top" colspan="7">
				            <asp:Label ID="MR_BU" runat="server" Width="480px"></asp:Label>
		                </td>
		            </tr>
		            <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                �G���A
		                </td>
		                <td align="left" valign="top" colspan="2">
				            <asp:Label ID="MR_AREA" runat="server" Width="260px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                �c�Ə�
		                </td>
		                <td align="left" valign="top" colspan="5">
				            <asp:Label ID="MR_EIGYOSHO" runat="server" Width="260px"></asp:Label>
		                </td>
		            </tr>
		            <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                Account Code
		                </td>
		                <td align="left" valign="middle">
				            <asp:Label ID="ACCOUNT_CODE" runat="server" Width="100px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                Cost Center
		                </td>
		                <td align="left" valign="middle">
				            <asp:Label ID="COST_CENTER" runat="server" Width="100px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                Internal Order
		                </td>
		                <td align="left" valign="middle">
				            <asp:Label ID="INTERNAL_ORDER" runat="server" Width="100px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                Zetia Code
		                </td>
		                <td align="left" valign="middle">
				            <asp:Label ID="ZETIA_CD" runat="server" Width="80px"></asp:Label>
		                </td>
		            </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
                            ����
                        </td>
                        <td align="left" valign="top" colspan="7">
                            <asp:TextBox ID="MR_NAME" runat="server" MaxLength="150" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="750px"  tabstop="false" 
                                BorderStyle="None"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
                            ����<br />�i���[�}���j
                        </td>
                        <td align="left" valign="top" colspan="7">
                            <asp:TextBox ID="MR_ROMA" runat="server" MaxLength="150" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="750px"  tabstop="false" 
                                BorderStyle="None"></asp:TextBox>
                        </td>
                    </tr>
		            <tr>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                �g�ѓd�b�ԍ�
		                </td>
		                <td align="left" valign="middle" colspan="2">
				            <asp:Label ID="MR_KEITAI" runat="server" Width="200px"></asp:Label>
		                </td>
		                <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
			                �I�t�B�X�̓d�b�ԍ�
		                </td>
		                <td align="left" valign="middle" colspan="5">
				            <asp:Label ID="MR_TEL" runat="server" Width="200px"></asp:Label>
		                </td>
		            </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
                            �g��Email<br />�A�h���X
                        </td>
                        <td align="left" valign="top" colspan="8">
                            <asp:TextBox ID="MR_EMAIL_KEITAI" runat="server" MaxLength="128" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="750px"  tabstop="false" 
                                BorderStyle="None"></asp:TextBox>
                        </td>
	                </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:170px" 
                            width="170">
                            Email<br />�A�h���X
                        </td>
                        <td align="left" valign="top" colspan="8">
                            <asp:TextBox ID="MR_EMAIL_PC" runat="server" MaxLength="128" ReadOnly="True" 
                                TextMode="MultiLine" Height="30px" Width="750px"  tabstop="false" 
                                BorderStyle="None"></asp:TextBox>
                        </td>
	                </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHeader" style="width:170px">
                            �`�P�b�g<br />���t��
                        </td>
                        <td align="left" valign="top" colspan="8">
                            <table border="0" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td align="left" valign="top">
                                        FS���F
                                    </td>
                                    <td align="left" valign="top" width="400">
            				            <asp:Label ID="MR_SEND_SAKI_FS" runat="server" Width="650px"></asp:Label>                                    
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" valign="top" style="width:100px">
                                        ���̑����t��F
                                    </td>
                                    <td align="left" valign="top">
                                        <asp:TextBox ID="MR_SEND_SAKI_OTHER" runat="server" MaxLength="128" ReadOnly="True" 
                                            TextMode="MultiLine" Height="45px" Width="650px"  tabstop="false" 
                                            BorderStyle="None"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
	                </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr>
			<td align="left" colspan="2">
				<!-- MR��z��� -->				
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleMR" colspan="8">
							��MR��z���
                        </td>
					</tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleMR" colspan="4">
                            ���˗����e
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ���񓚓��e
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleMR">
                            �S��MR�אȊ�](���H)
                        </td>
                        <td align="left" valign="top" class="TdItem" colspan="3">
							<asp:Label ID="REQ_MR_O_TEHAI" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            �S��MR��z(���H)
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
		                    <asp:DropDownList ID="ANS_MR_O_TEHAI" runat="server" Width="150px" 
                                TabIndex="12">
                            </asp:DropDownList>						
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleMR">
                            �S��MR�אȊ�](���H)
                        </td>
                        <td align="left" valign="top" class="TdItem" colspan="3">
							<asp:Label ID="REQ_MR_F_TEHAI" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            �S��MR��z(���H)
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
		                    <asp:DropDownList ID="ANS_MR_F_TEHAI" runat="server" Width="150px" 
                                TabIndex="13">
                            </asp:DropDownList>						
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleMR">
                            �N��
                        </td>
                        <td align="left" valign="top" class="TdItem">
							<asp:Label ID="MR_AGE" runat="server" Width="50px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleMR">
                            ����
                        </td>
                        <td align="left" valign="top" class="TdItem">
							<asp:Label ID="MR_SEX" runat="server" Width="50px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="4">
							<div style="font-weight: bold; color: #2424f0;" id="DivComment" runat="server">
								�_�u���N�H�[�e�[�V�����u�h�v�E���s(Enter�L�[)�͓��͂ł��܂���B
							</div>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleMR">
                            ���l
                        </td>
                        <td align="left" valign="top" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_MR_HOTEL_NOTE" runat="server" MaxLength="510" 
                                TextMode="MultiLine" Height="47px" Width="344px" Tabstop="False" 
                                BorderStyle="None" ReadOnly="True"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            ���l
                        </td>
                        <td align="left" valign="top" class="TdItem" colspan="3">
                            <asp:TextBox ID="ANS_MR_HOTEL_NOTE" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="47px" Width="344px" TabIndex="14"></asp:TextBox>                            
                        </td>
                    </tr>
				</table>
		    </td>
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" tabindex="15">�y�[�W�g�b�v��</a>
		    </td>
		</tr>

		<tr>
		    <td align="left"  colspan="2">
				<!-- �h����z -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHotel" colspan="8">
                            ���h����z
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHotel" style="width:100px">
                            �h���˗�
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TEHAI_HOTEL" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ���񓚓��e
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHotel" style="width:100px">
                            �˗����e
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="HOTEL_IRAINAIYOU" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �񓚃X�e�[�^�X
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_STATUS_HOTEL" runat="server" TabIndex="16" 
                                Width="147px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHotel" style="width:100px">
                            �h����
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_HOTEL_DATE" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleHotel" style="width:100px">
                            ����
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_HAKUSU" runat="server" Width="30px"></asp:Label>
							&nbsp;&nbsp;��
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �{�ݖ�
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_HOTEL_NAME" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="30px" Width="267px" TabIndex="17"></asp:TextBox>
            				<asp:Button ID="BtnHotelKensaku" runat="server" Width="55px" Text="����" 
                                CssClass="ButtonList" TabIndex="18" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHotel" style="width:100px">
                            �i��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_HOTEL_SMOKING" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �{�ݏZ��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_HOTEL_ADDRESS" runat="server" MaxLength="128" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="19"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleHotel" style="width:100px" rowspan="6">
                            ���l
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3" rowspan="6">
                            <asp:TextBox ID="REQ_HOTEL_NOTE" runat="server" MaxLength="255" 
                                readonly="true" textmode="MultiLine" Height="220px" Width="321px" 
                                 tabstop="false"  BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �{��TEL
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_HOTEL_TEL" runat="server" MaxLength="20" 
                                Height="18px" Width="173px" TabIndex="20"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �h����
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_HOTEL_DATE" runat="server" MaxLength="8" 
                                Height="18px" Width="67px" TabIndex="21"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ����
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_HAKUSU" runat="server" MaxLength="2" 
                                Height="18px" Width="26px" TabIndex="22"></asp:TextBox>
							&nbsp;&nbsp;��                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �`�F�b�N�C��
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_CHECKIN_TIME" runat="server" MaxLength="5" 
                                Height="18px" Width="47px" TabIndex="23"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �`�F�b�N�A�E�g
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_CHECKOUT_TIME" runat="server" MaxLength="5" 
                                Height="18px" Width="47px" TabIndex="24"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �����^�C�v
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_ROOM_TYPE" runat="server" TabIndex="25" Width="344px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �i��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_HOTEL_SMOKING" runat="server" TabIndex="26" 
                                Width="344px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���l
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3" width="344px">							
							<div style="font-weight: bold; color: #2424f0;" id="Div1" runat="server">
								�_�u���N�H�[�e�[�V�����u�h�v�E���s(Enter�L�[)�͓��͂ł��܂���B
							</div>
                            <asp:TextBox ID="ANS_HOTEL_NOTE" runat="server" MaxLength="255" 
                                textmode="MultiLine" Height="65px" Width="347px" TabIndex="27"></asp:TextBox>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" tabindex="28">�y�[�W�g�b�v��</a>
		    </td>
		</tr>
		
		<tr>
			<td align="left" colspan="2">
				<!-- ��ʁi���H�P�j�^�C�g�� -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleOuro" style="width:170px">
							����ʁi���H�P�j��z
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TEHAI_1" runat="server" Width="200px" ></asp:Label>
                        </td>
					</tr>
				</table>
		    </td>
		</tr>
		<tr runat="server" id="TB_KOTSU_O_1">
		    <td align="left"  colspan="2">
				<!-- ��ʁi���H�P�j��z -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" colspan="4">
                            ���˗����e
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ���񓚓��e
            				<asp:Button ID="BtnCopy_O_TEHAI_1" runat="server" Width="55px" Text="�R�s�[" 
                                CssClass="ButtonList" TabIndex="29" />
            				<asp:Button ID="BtnClear_O_TEHAI_1" runat="server" Width="55px" Text="�N���A" 
                                CssClass="ButtonList" TabIndex="30" />
                            <a style="color: #FF0000; font-weight: bold">���񓚗����͍ς̏ꍇ�̓R�s�[�ł��܂���</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            �˗����e
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_IRAINAIYOU_1" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �񓚃X�e�[�^�X
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_O_STATUS_1" runat="server" TabIndex="31" 
                                Width="147px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ��ʋ@��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_KOTSUKIKAN_1" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��ʋ@��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_O_KOTSUKIKAN_1" runat="server" TabIndex="32" 
                                Width="147px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_DATE_1" runat="server" Width="130px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_DATE_1" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="33"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            �o���n
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_AIRPORT1_1" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                 tabstop="false"  BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            �����n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_O_AIRPORT2_1" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                 tabstop="false"  BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �o���n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT1_1" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="34"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �����n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT2_1" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="35"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            �o������
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TIME1_1" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ��������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_TIME2_1" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �o������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME1_1" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="36"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME2_1" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="37"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ��ԁE�֖�
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_O_BIN_1" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��ԁE�֖�
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_BIN_1" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="38"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ���ȋ敪
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_SEAT_1" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ���Ȉʒu
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_SEAT_KIBOU1" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���ȋ敪
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_1" runat="server" TabIndex="39">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���Ȉʒu
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_KIBOU1" runat="server" TabIndex="40">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" tabindex="41">�y�[�W�g�b�v��</a>
		    </td>
		</tr>
		
		<tr>
			<td align="left" colspan="2">
				<!-- ��ʁi���H�Q�j�^�C�g�� -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleOuro" style="width:170px">
							����ʁi���H�Q�j��z
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TEHAI_2" runat="server" Width="200px" ></asp:Label>
                        </td>
					</tr>
				</table>
		    </td>
		</tr>

		<tr runat="server" id="TB_KOTSU_O_2">
		    <td align="left"  colspan="2">
				<!-- ��ʁi���H�Q�j��z -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" colspan="4">
                            ���˗����e
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ���񓚓��e
            				<asp:Button ID="BtnCopy_O_TEHAI_2" runat="server" Width="55px" Text="�R�s�[" 
                                CssClass="ButtonList" TabIndex="42" />
            				<asp:Button ID="BtnClear_O_TEHAI_2" runat="server" Width="55px" Text="�N���A" 
                                CssClass="ButtonList" TabIndex="43" />
                            <a style="color: #FF0000; font-weight: bold">���񓚗����͍ς̏ꍇ�̓R�s�[�ł��܂���</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            �˗����e
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_IRAINAIYOU_2" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �񓚃X�e�[�^�X
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_O_STATUS_2" runat="server" TabIndex="44" 
                                Width="147px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ��ʋ@��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_KOTSUKIKAN_2" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��ʋ@��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_O_KOTSUKIKAN_2" runat="server" TabIndex="45" 
                                Width="147px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_DATE_2" runat="server" Width="130px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_DATE_2" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="46"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            �o���n
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_AIRPORT1_2" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                 tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            �����n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_O_AIRPORT2_2" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                 tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �o���n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT1_2" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="47"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �����n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT2_2" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="48"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            �o������
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TIME1_2" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ��������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_TIME2_2" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �o������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME1_2" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="49"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME2_2" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="50"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ��ԁE�֖�
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_O_BIN_2" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��ԁE�֖�
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_BIN_2" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="51"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ���ȋ敪
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_SEAT_2" runat="server" Width="120px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ���Ȉʒu
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_SEAT_KIBOU2" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���ȋ敪
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_2" runat="server" TabIndex="52">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���Ȉʒu
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_KIBOU2" runat="server" TabIndex="53">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" tabindex="54">�y�[�W�g�b�v��</a>
		    </td>
		</tr>
		
		<tr>
			<td align="left" colspan="2">
				<!-- ��ʁi���H�R�j�^�C�g�� -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleOuro" style="width:170px">
							����ʁi���H�R�j��z
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TEHAI_3" runat="server" Width="200px" ></asp:Label>
                        </td>
					</tr>
				</table>
		    </td>
		</tr>

		<tr runat="server" id="TB_KOTSU_O_3">
		    <td align="left"  colspan="2">
				<!-- ��ʁi���H�R�j��z -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" colspan="4">
                            ���˗����e
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ���񓚓��e
            				<asp:Button ID="BtnCopy_O_TEHAI_3" runat="server" Width="55px" Text="�R�s�[" 
                                CssClass="ButtonList" TabIndex="55" />
            				<asp:Button ID="BtnClear_O_TEHAI_3" runat="server" Width="55px" Text="�N���A" 
                                CssClass="ButtonList" TabIndex="56" />
                            <a style="color: #FF0000; font-weight: bold">���񓚗����͍ς̏ꍇ�̓R�s�[�ł��܂���</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px" 
                            width="200">
                            �˗����e
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_IRAINAIYOU_3" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �񓚃X�e�[�^�X
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_O_STATUS_3" runat="server" TabIndex="57" 
                                Width="148px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ��ʋ@��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_KOTSUKIKAN_3" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��ʋ@��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_O_KOTSUKIKAN_3" runat="server" TabIndex="58" 
                                Width="148px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_DATE_3" runat="server" Width="130px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_DATE_3" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="59"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            �o���n
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_AIRPORT1_3" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            �����n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_O_AIRPORT2_3" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �o���n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT1_3" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="60"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �����n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT2_3" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="61"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            �o������
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TIME1_3" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ��������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_TIME2_3" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �o������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME1_3" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="62"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME2_3" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="63"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ��ԁE�֖�
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_O_BIN_3" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��ԁE�֖�
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_BIN_3" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="64"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ���ȋ敪
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_SEAT_3" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ���Ȉʒu
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_SEAT_KIBOU3" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���ȋ敪
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_3" runat="server" TabIndex="65">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���Ȉʒu
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_KIBOU3" runat="server" TabIndex="66">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" TabIndex="67">�y�[�W�g�b�v��</a>
		    </td>
		</tr>
		
		<tr>
			<td align="left" colspan="2">
				<!-- ��ʁi���H�S�j�^�C�g�� -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleOuro" style="width:170px">
							����ʁi���H�S�j��z
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TEHAI_4" runat="server" Width="200px" ></asp:Label>
                        </td>
					</tr>
				</table>
		    </td>
		</tr>

		<tr runat="server" id="TB_KOTSU_O_4">
		    <td align="left"  colspan="2">
				<!-- ��ʁi���H�S�j��z -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" colspan="4">
                            ���˗����e
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ���񓚓��e
            				<asp:Button ID="BtnCopy_O_TEHAI_4" runat="server" Width="55px" Text="�R�s�[" 
                                CssClass="ButtonList" TabIndex="68" />
            				<asp:Button ID="BtnClear_O_TEHAI_4" runat="server" Width="55px" Text="�N���A" 
                                CssClass="ButtonList" TabIndex="69" />
                            <a style="color: #FF0000; font-weight: bold">���񓚗����͍ς̏ꍇ�̓R�s�[�ł��܂���</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            �˗����e
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_IRAINAIYOU_4" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �񓚃X�e�[�^�X
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_O_STATUS_4" runat="server" TabIndex="70" Width="148px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ��ʋ@��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_KOTSUKIKAN_4" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��ʋ@��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_O_KOTSUKIKAN_4" runat="server" TabIndex="71" Width="148px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_DATE_4" runat="server" Width="130px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_DATE_4" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="72"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            �o���n
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_AIRPORT1_4" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            �����n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_O_AIRPORT2_4" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �o���n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT1_4" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="73"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �����n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT2_4" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="74"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            �o������
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TIME1_4" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ��������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_TIME2_4" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �o������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME1_4" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="75"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME2_4" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="76"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ��ԁE�֖�
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_O_BIN_4" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��ԁE�֖�
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_BIN_4" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="77"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ���ȋ敪
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_SEAT_4" runat="server" Width="120px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ���Ȉʒu
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_SEAT_KIBOU4" runat="server" Width="120px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���ȋ敪
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_4" runat="server" TabIndex="78">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���Ȉʒu
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_KIBOU4" runat="server" TabIndex="79">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" TabIndex="80">�y�[�W�g�b�v��</a>
		    </td>
		</tr>
		
		<tr>
			<td align="left" colspan="2">
				<!-- ��ʁi���H�T�j�^�C�g�� -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleOuro" style="width:170px">
							����ʁi���H�T�j��z
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TEHAI_5" runat="server" Width="200px" ></asp:Label>
                        </td>
					</tr>
				</table>
		    </td>
		</tr>

		<tr runat="server" id="TB_KOTSU_O_5">
		    <td align="left"  colspan="2">
				<!-- ��ʁi���H�T�j��z -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" colspan="4">
                            ���˗����e
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ���񓚓��e
            				<asp:Button ID="BtnCopy_O_TEHAI_5" runat="server" Width="55px" Text="�R�s�[" 
                                CssClass="ButtonList" TabIndex="81" />
            				<asp:Button ID="BtnClear_O_TEHAI_5" runat="server" Width="55px" Text="�N���A" 
                                CssClass="ButtonList" TabIndex="82" />
                            <a style="color: #FF0000; font-weight: bold">���񓚗����͍ς̏ꍇ�̓R�s�[�ł��܂���</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            �˗����e
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_IRAINAIYOU_5" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �񓚃X�e�[�^�X
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_O_STATUS_5" runat="server" TabIndex="83" Width="148px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ��ʋ@��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_KOTSUKIKAN_5" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��ʋ@��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_O_KOTSUKIKAN_5" runat="server" TabIndex="84" Width="148px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_O_DATE_5" runat="server" Width="130px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_DATE_5" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="85"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            �o���n
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_O_AIRPORT1_5" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            �����n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_O_AIRPORT2_5" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �o���n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT1_5" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="86"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �����n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_AIRPORT2_5" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="87"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            �o������
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_TIME1_5" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ��������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_TIME2_5" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �o������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME1_5" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="88"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_O_TIME2_5" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="89"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ��ԁE�֖�
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_O_BIN_5" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��ԁE�֖�
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_O_BIN_5" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="90"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ���ȋ敪
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_O_SEAT_5" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleOuro" style="width:100px">
                            ���Ȉʒu
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_O_SEAT_KIBOU5" runat="server" Width="120px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���ȋ敪
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_5" runat="server" TabIndex="91">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���Ȉʒu
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_O_SEAT_KIBOU5" runat="server" TabIndex="92">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>		
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" TabIndex="93">�y�[�W�g�b�v��</a>
		    </td>
		</tr>
		
		<tr>
			<td align="left" colspan="2">
				<!-- ��ʁi���H�P�j�^�C�g�� -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleFukuro" style="width:170px">
							����ʁi���H�P�j��z
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TEHAI_1" runat="server" Width="200px" ></asp:Label>
                        </td>
					</tr>
				</table>
		    </td>
		</tr>

		<tr runat="server" id="TB_KOTSU_F_1">
		    <td align="left"  colspan="2">
				<!-- ��ʁi���H�P�j��z -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" colspan="4">
                            ���˗����e
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ���񓚓��e
            				<asp:Button ID="BtnCopy_F_TEHAI_1" runat="server" Width="55px" Text="�R�s�[" 
                                CssClass="ButtonList" TabIndex="94" />
            				<asp:Button ID="BtnClear_F_TEHAI_1" runat="server" Width="55px" Text="�N���A" 
                                CssClass="ButtonList" TabIndex="95" />
                            <a style="color: #FF0000; font-weight: bold">���񓚗����͍ς̏ꍇ�̓R�s�[�ł��܂���</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            �˗����e
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_IRAINAIYOU_1" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �񓚃X�e�[�^�X
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_F_STATUS_1" runat="server" TabIndex="96" Width="148px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ��ʋ@��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_KOTSUKIKAN_1" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��ʋ@��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_F_KOTSUKIKAN_1" runat="server" TabIndex="97" Width="148px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_DATE_1" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_DATE_1" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="98"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            �o���n
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_F_AIRPORT1_1" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            �����n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_F_AIRPORT2_1" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �o���n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT1_1" runat="server" MaxLength="160" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="99"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �����n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT2_1" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="100"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            �o������
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TIME1_1" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ��������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_TIME2_1" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �o������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME1_1" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="101"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME2_1" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="102"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ��ԁE�֖�
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_F_BIN_1" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��ԁE�֖�
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_BIN_1" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="103"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ���ȋ敪
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_SEAT_1" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ���Ȉʒu
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_SEAT_KIBOU1" runat="server" Width="120px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���ȋ敪
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_1" runat="server" TabIndex="104">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���Ȉʒu
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_KIBOU1" runat="server" TabIndex="105">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" TabIndex="106">�y�[�W�g�b�v��</a>
		    </td>
		</tr>		
		<tr>
			<td align="left" colspan="2">
				<!-- ��ʁi���H�Q�j�^�C�g�� -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleFukuro" style="width:170px">
							����ʁi���H�Q�j��z
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TEHAI_2" runat="server" Width="200px" ></asp:Label>
                        </td>
					</tr>
				</table>
		    </td>
		</tr>

		<tr runat="server" id="TB_KOTSU_F_2">
		    <td align="left"  colspan="2">
				<!-- ��ʁi���H�Q�j��z -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" colspan="4">
                            ���˗����e
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ���񓚓��e
            				<asp:Button ID="BtnCopy_F_TEHAI_2" runat="server" Width="55px" Text="�R�s�[" 
                                CssClass="ButtonList" TabIndex="107" />
            				<asp:Button ID="BtnClear_F_TEHAI_2" runat="server" Width="55px" Text="�N���A" 
                                CssClass="ButtonList" TabIndex="108" />
                            <a style="color: #FF0000; font-weight: bold">���񓚗����͍ς̏ꍇ�̓R�s�[�ł��܂���</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            �˗����e
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_IRAINAIYOU_2" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �񓚃X�e�[�^�X
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_F_STATUS_2" runat="server" TabIndex="109" Width="148px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ��ʋ@��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_KOTSUKIKAN_2" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��ʋ@��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_F_KOTSUKIKAN_2" runat="server" TabIndex="110" Width="148px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_DATE_2" runat="server" Width="130px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_DATE_2" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="111"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            �o���n
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_F_AIRPORT1_2" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            �����n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_F_AIRPORT2_2" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �o���n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT1_2" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="112"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �����n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT2_2" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="113"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            �o������
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TIME1_2" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ��������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_TIME2_2" runat="server" Width="80px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �o������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME1_2" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="114"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME2_2" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="115"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ��ԁE�֖�
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_F_BIN_2" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��ԁE�֖�
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_BIN_2" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="116"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ���ȋ敪
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_SEAT_2" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ���Ȉʒu
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_SEAT_KIBOU2" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���ȋ敪
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_2" runat="server" TabIndex="117">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���Ȉʒu
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_KIBOU2" runat="server" TabIndex="118">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" TabIndex="119">�y�[�W�g�b�v��</a>
		    </td>
		</tr>		
		<tr>
			<td align="left" colspan="2">
				<!-- ��ʁi���H�R�j�^�C�g�� -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleFukuro" style="width:170px">
							����ʁi���H�R�j��z
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TEHAI_3" runat="server" Width="200px" ></asp:Label>
                        </td>
					</tr>
				</table>
		    </td>
		</tr>

		<tr runat="server" id="TB_KOTSU_F_3">
		    <td align="left"  colspan="2">
				<!-- ��ʁi���H�R�j��z -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" colspan="4">
                            ���˗����e
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ���񓚓��e
            				<asp:Button ID="BtnCopy_F_TEHAI_3" runat="server" Width="55px" Text="�R�s�[" 
                                CssClass="ButtonList" TabIndex="120" />
            				<asp:Button ID="BtnClear_F_TEHAI_3" runat="server" Width="55px" Text="�N���A" 
                                CssClass="ButtonList" TabIndex="121" />
                            <a style="color: #FF0000; font-weight: bold">���񓚗����͍ς̏ꍇ�̓R�s�[�ł��܂���</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            �˗����e
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_IRAINAIYOU_3" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �񓚃X�e�[�^�X
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_F_STATUS_3" runat="server" TabIndex="122" Width="148px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ��ʋ@��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_KOTSUKIKAN_3" runat="server" Width="200px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��ʋ@��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_F_KOTSUKIKAN_3" runat="server" TabIndex="123" Width="148px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_DATE_3" runat="server" Width="130px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_DATE_3" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="124"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            �o���n
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_F_AIRPORT1_3" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            �����n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_F_AIRPORT2_3" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �o���n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT1_3" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="125"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �����n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT2_3" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="126"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            �o������
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TIME1_3" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ��������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_TIME2_3" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �o������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME1_3" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="127"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME2_3" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="128"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ��ԁE�֖�
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_F_BIN_3" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��ԁE�֖�
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_BIN_3" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="129"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ���ȋ敪
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_SEAT_3" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ���Ȉʒu
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_SEAT_KIBOU3" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���ȋ敪
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_3" runat="server" TabIndex="130">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���Ȉʒu
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_KIBOU3" runat="server" TabIndex="131">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" TabIndex="132">�y�[�W�g�b�v��</a>
		    </td>
		</tr>		
		<tr>
			<td align="left" colspan="2">
				<!-- ��ʁi���H�S�j�^�C�g�� -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleFukuro" style="width:170px">
							����ʁi���H�S�j��z
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TEHAI_4" runat="server" Width="200px"></asp:Label>
                        </td>
					</tr>
				</table>
		    </td>
		</tr>

		<tr runat="server" id="TB_KOTSU_F_4">
		    <td align="left"  colspan="2">
				<!-- ��ʁi���H�S�j��z -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" colspan="4">
                            ���˗����e
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ���񓚓��e
            				<asp:Button ID="BtnCopy_F_TEHAI_4" runat="server" Width="55px" Text="�R�s�[" 
                                CssClass="ButtonList" TabIndex="133" />
            				<asp:Button ID="BtnClear_F_TEHAI_4" runat="server" Width="55px" Text="�N���A" 
                                CssClass="ButtonList" TabIndex="134" />
                            <a style="color: #FF0000; font-weight: bold">���񓚗����͍ς̏ꍇ�̓R�s�[�ł��܂���</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            �˗����e
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_IRAINAIYOU_4" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �񓚃X�e�[�^�X
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_F_STATUS_4" runat="server" TabIndex="135" Width="148px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ��ʋ@��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_KOTSUKIKAN_4" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��ʋ@��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_F_KOTSUKIKAN_4" runat="server" TabIndex="136" Width="148px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_DATE_4" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_DATE_4" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="137"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            �o���n
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_F_AIRPORT1_4" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            �����n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_F_AIRPORT2_4" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �o���n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT1_4" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="138"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �����n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT2_4" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="139"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            �o������
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TIME1_4" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ��������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_TIME2_4" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �o������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME1_4" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="140"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME2_4" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="141"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ��ԁE�֖�
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_F_BIN_4" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��ԁE�֖�
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_BIN_4" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="142"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ���ȋ敪
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_SEAT_4" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ���Ȉʒu
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_SEAT_KIBOU4" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���ȋ敪
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_4" runat="server" TabIndex="143">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���Ȉʒu
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_KIBOU4" runat="server" TabIndex="144">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" TabIndex="145">�y�[�W�g�b�v��</a>
		    </td>
		</tr>		
		<tr>
			<td align="left" colspan="2">
				<!-- ��ʁi���H�T�j�^�C�g�� -->				
				<table style="margin-bottom: 0px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="0" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleFukuro" style="width:170px">
							����ʁi���H�T�j��z
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TEHAI_5" runat="server" Width="200px"></asp:Label>
                        </td>
					</tr>
				</table>
		    </td>
		</tr>

		<tr runat="server" id="TB_KOTSU_F_5">
		    <td align="left"  colspan="2">
				<!-- ��ʁi���H�T�j��z -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" colspan="4">
                            ���˗����e
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ���񓚓��e
            				<asp:Button ID="BtnCopy_F_TEHAI_5" runat="server" Width="55px" Text="�R�s�[" 
                                CssClass="ButtonList" TabIndex="146" />
            				<asp:Button ID="BtnClear_F_TEHAI_5" runat="server" Width="55px" Text="�N���A" 
                                CssClass="ButtonList" TabIndex="147" />
                            <a style="color: #FF0000; font-weight: bold">���񓚗����͍ς̏ꍇ�̓R�s�[�ł��܂���</a>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            �˗����e
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_IRAINAIYOU_5" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �񓚃X�e�[�^�X
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:DropDownList ID="ANS_F_STATUS_5" runat="server" TabIndex="148" Width="148px">
                            </asp:DropDownList>							
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ��ʋ@��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_KOTSUKIKAN_5" runat="server" Width="200px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��ʋ@��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:DropDownList ID="ANS_F_KOTSUKIKAN_5" runat="server" TabIndex="149" Width="148px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_F_DATE_5" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_DATE_5" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="150"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            �o���n
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="REQ_F_AIRPORT1_5" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            �����n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="REQ_F_AIRPORT2_5" runat="server" MaxLength="80" 
                                readonly="true" textmode="MultiLine" Height="18px" Width="148px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �o���n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT1_5" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="151"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �����n
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_AIRPORT2_5" runat="server" MaxLength="80" 
                                textmode="MultiLine" Height="30px" Width="148px" TabIndex="152"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            �o������
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_TIME1_5" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ��������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_TIME2_5" runat="server" Width="80px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �o������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME1_5" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="153"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��������
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:TextBox ID="ANS_F_TIME2_5" runat="server" MaxLength="5" 
                                Height="18px" Width="148px" TabIndex="154"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ��ԁE�֖�
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_F_BIN_5" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="19px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ��ԁE�֖�
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">							
                            <asp:TextBox ID="ANS_F_BIN_5" runat="server" MaxLength="80" 
                                TextMode="MultiLine" Height="30px" Width="344px" TabIndex="155"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ���ȋ敪
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="REQ_F_SEAT_5" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitleFukuro" style="width:100px">
                            ���Ȉʒu
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
							<asp:Label ID="REQ_F_SEAT_KIBOU5" runat="server" Width="120px" ></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���ȋ敪
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_5" runat="server" TabIndex="156">
                            </asp:DropDownList>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���Ȉʒu
                        </td>
                        <td align="left" valign="middle" class="TdItem">							
                            <asp:DropDownList ID="ANS_F_SEAT_KIBOU5" runat="server" TabIndex="157">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>		
		<tr>
			<td align="left" colspan="2">
				<!-- ��ʔ��l -->				
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleFukuro" colspan="5">
							����ʔ��l
                        </td>
					</tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleFukuro">
                            ���˗����e
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ���񓚓��e
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="top" class="TdItem">
                            <asp:TextBox ID="REQ_KOTSU_BIKO" runat="server" MaxLength="255" ReadOnly="True" 
                                TextMode="MultiLine" Height="68px" Width="445px" tabstop="false" 
                                BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="4">
							<div style="font-weight: bold; color: #2424f0;" id="Div2" runat="server">
								�_�u���N�H�[�e�[�V�����u�h�v�E���s(Enter�L�[)�͓��͂ł��܂���B
							</div>
                            <asp:TextBox ID="ANS_KOTSU_BIKO" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="68px" Width="445px" TabIndex="158"></asp:TextBox>                            
                        </td>
                    </tr>
				</table>
		    </td>
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
                <a name="TaxiTehaiLink"></a>				    
			    <a href="#PageTopLink" TabIndex="159">�y�[�W�g�b�v��</a>
		    </td>
		</tr>		
		<tr runat="server" id="TB_TAXI_1">
		    <td align="left"  colspan="2">
				<!-- �^�N�`�P��z -->
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleTaxi" style="width:170px">
							�^�N�`�P��z
                        </td>
                        <td align="left" valign="middle" class="TdItem"  colspan="5">
							<asp:Label ID="TEHAI_TAXI" runat="server" Width="120px"></asp:Label>
            				<asp:Button ID="BtnTicketCopy" runat="server" Width="55px" Text="�R�s�[" 
                                CssClass="ButtonList" TabIndex="160" />
            				<asp:Button ID="BtnTicketClear" runat="server" Width="55px" Text="�N���A" 
                                CssClass="ButtonList" TabIndex="161" />
                            <a style="color: #FF0000; font-weight: bold">���񓚗����͍ς̏ꍇ�̓R�s�[�ł��܂���</a>							
                        </td>
						<td align="left" valign="middle" class="TdTitleTaxi" style="width:170px">
							�X�L�����f�[�^�捞��
                        </td>
                        <td align="left" valign="middle" class="TdItem">
							<asp:Label ID="SCAN_IMPORT_DATE" runat="server" Width="80px"></asp:Label>
                        </td>
					</tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" colspan="8">
                            ���^�N�`�P���l
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" colspan="4">
                            ���˗����e
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="4">
                            ���񓚓��e
            			</td>
                    </tr>
					<tr>
						<td align="left" valign="middle" class="TdTitleTaxi" style="width:170px">
							���l
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_NOTE" runat="server" MaxLength="255" 
                                ReadOnly="true" TextMode="MultiLine" Height="68px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>                            
                        </td>
						<td align="left" valign="middle" class="TdTitle" style="width:170px">
							NOZOMI��<br />���l
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<div style="font-weight: bold; color: #2424f0;" id="Div3" runat="server">
								�_�u���N�H�[�e�[�V�����u�h�v�E���s(Enter�L�[)�͓��͕s�B
							</div>
                            <asp:TextBox ID="ANS_TAXI_NOTE" runat="server" MaxLength="255" 
                                TextMode="MultiLine" Height="68px" Width="344px" TabIndex="162"></asp:TextBox>                            
                        </td>
					</tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" colspan="4">
                            ���s���P
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ���P<br />
            				<asp:Button ID="BtnTaxiAnsCopy" runat="server" Width="100px" Text="���փR�s�[" 
                                CssClass="ButtonList" TabIndex="163" />
            				<asp:Button ID="BtnTicketClear1" runat="server" Width="130px" Text="�^�N�`�P1�N���A" 
                                CssClass="ButtonList" TabIndex="163" />                            
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            			    �䒠�p
                            <asp:TextBox ID="ANS_TAXI_SRMKS_1" runat="server" MaxLength="20" Height="18px"
                                Width="189px" TabIndex="164" Wrap="False"></asp:TextBox>                                        			
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_1" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_1" runat="server" TabIndex="165" 
                                Text="���s�Ώ�" />
							<asp:Label ID="ANS_TAXI_HAKKO_1" runat="server" Width="80px">���s��</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_1" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            ���n
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_1" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="30px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" >
                            <asp:TextBox ID="ANS_TAXI_DATE_1" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="166"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ����</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_1" runat="server" TabIndex="167">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            �˗����z
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_1" runat="server" Width="80px"></asp:Label>
                            &nbsp;�~
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �ԍ�
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_1" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="168" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            T���l
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_1" runat="server" MaxLength="20" Height="18px" 
                                Width="138px" TabIndex="169" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" colspan="4">
                            ���s���Q
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ���Q
            				<asp:Button ID="BtnTicketClear2" runat="server" Width="130px" Text="�^�N�`�P2�N���A" 
                                CssClass="ButtonList" TabIndex="170" />                            
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            			    �䒠�p
                            <asp:TextBox ID="ANS_TAXI_SRMKS_2" runat="server" MaxLength="20" Height="18px"
                                Width="189px" TabIndex="171" Wrap="False"></asp:TextBox>                                        			
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_2" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_2" runat="server" TabIndex="172" Text="���s�Ώ�" />
							<asp:Label ID="ANS_TAXI_HAKKO_2" runat="server" Width="80px">���s��</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_2" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="style2">
                            ���n
                        </td>
                        <td align="left" valign="middle" class="style3" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_2" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="30px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="style4">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="style3" >
                            <asp:TextBox ID="ANS_TAXI_DATE_2" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="173"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="style4">
                            ����</td>
                        <td align="left" valign="middle" class="style3">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_2" runat="server" TabIndex="174">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            �˗����z
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_2" runat="server" Width="80px"></asp:Label>
                            &nbsp;�~
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �ԍ�
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_2" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="175" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            T���l
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_2" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="176" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" colspan="4">
                            ���s���R
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ���R
            				<asp:Button ID="BtnTicketClear3" runat="server" Width="130px" Text="�^�N�`�P3�N���A" 
                                CssClass="ButtonList" TabIndex="177" />                            
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            			    �䒠�p
                            <asp:TextBox ID="ANS_TAXI_SRMKS_3" runat="server" MaxLength="20" Height="18px"
                                Width="189px" TabIndex="178" Wrap="False"></asp:TextBox>                                        			
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_3" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_3" runat="server" TabIndex="179" Text="���s�Ώ�" />
							<asp:Label ID="ANS_TAXI_HAKKO_3" runat="server" Width="80px">���s��</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_3" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            ���n
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_3" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="30px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" >
                            <asp:TextBox ID="ANS_TAXI_DATE_3" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="180"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ����</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_3" runat="server" TabIndex="181">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            �˗����z
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_3" runat="server" Width="80px"></asp:Label>
                            &nbsp;�~
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �ԍ�
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_3" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="182" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            T���l
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_3" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="183" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" colspan="4">
                            ���s���S
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ���S
            				<asp:Button ID="BtnTicketClear4" runat="server" Width="130px" Text="�^�N�`�P4�N���A" 
                                CssClass="ButtonList" TabIndex="184" />                            
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            			    �䒠�p
                            <asp:TextBox ID="ANS_TAXI_SRMKS_4" runat="server" MaxLength="20" Height="18px"
                                Width="189px" TabIndex="185" Wrap="False"></asp:TextBox>                                        			
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_4" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_4" runat="server" TabIndex="186" Text="���s�Ώ�" />
							<asp:Label ID="ANS_TAXI_HAKKO_4" runat="server" Width="80px">���s��</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_4" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            ���n
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_4" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="30px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" >
                            <asp:TextBox ID="ANS_TAXI_DATE_4" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="187"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ����</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_4" runat="server" TabIndex="188">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            �˗����z
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_4" runat="server" Width="80px"></asp:Label>
                            &nbsp;�~
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �ԍ�
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_4" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="189" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            T���l
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_4" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="190" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" colspan="4">
                            ���s���T
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ���T
            				<asp:Button ID="BtnTicketClear5" runat="server" Width="130px" Text="�^�N�`�P5�N���A" 
                                CssClass="ButtonList" TabIndex="191" />                            
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            			    �䒠�p
                            <asp:TextBox ID="ANS_TAXI_SRMKS_5" runat="server" MaxLength="20" Height="18px"
                                Width="189px" TabIndex="192" Wrap="False"></asp:TextBox>                                        			
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_5" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_5" runat="server" TabIndex="193" Text="���s�Ώ�" />
							<asp:Label ID="ANS_TAXI_HAKKO_5" runat="server" Width="80px">���s��</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_5" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            ���n
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_5" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="30px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" >
                            <asp:TextBox ID="ANS_TAXI_DATE_5" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="194"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ����</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_5" runat="server" TabIndex="195">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            �˗����z
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_5" runat="server" Width="80px"></asp:Label>
                            &nbsp;�~
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �ԍ�
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_5" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="196" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            T���l
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_5" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="197" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" colspan="4">
                            ���s���U
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ���U
            				<asp:Button ID="BtnTicketClear6" runat="server" Width="130px" Text="�^�N�`�P6�N���A" 
                                CssClass="ButtonList" TabIndex="198" />                            
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            			    �䒠�p
                            <asp:TextBox ID="ANS_TAXI_SRMKS_6" runat="server" MaxLength="20" Height="18px"
                                Width="189px" TabIndex="199" Wrap="False"></asp:TextBox>                                        			
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_6" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_6" runat="server" TabIndex="200" Text="���s�Ώ�" />
							<asp:Label ID="ANS_TAXI_HAKKO_6" runat="server" Width="80px">���s��</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_6" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            ���n
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_6" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="30px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" >
                            <asp:TextBox ID="ANS_TAXI_DATE_6" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="201"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ����</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_6" runat="server" TabIndex="202">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            �˗����z
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_6" runat="server" Width="80px"></asp:Label>
                            &nbsp;�~
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �ԍ�
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_6" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="203" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            T���l
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_6" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="204" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" colspan="4">
                            ���s���V
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ���V
            				<asp:Button ID="BtnTicketClear7" runat="server" Width="130px" Text="�^�N�`�P7�N���A" 
                                CssClass="ButtonList" TabIndex="205" />                            
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            			    �䒠�p
                            <asp:TextBox ID="ANS_TAXI_SRMKS_7" runat="server" MaxLength="20" Height="18px"
                                Width="189px" TabIndex="206" Wrap="False"></asp:TextBox>                                        			
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_7" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_7" runat="server" TabIndex="207" Text="���s�Ώ�" />
							<asp:Label ID="ANS_TAXI_HAKKO_7" runat="server" Width="80px">���s��</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_7" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            ���n
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_7" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="30px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" >
                            <asp:TextBox ID="ANS_TAXI_DATE_7" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="208"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ����</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_7" runat="server" TabIndex="209">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            �˗����z
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_7" runat="server" Width="80px"></asp:Label>
                            &nbsp;�~
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �ԍ�
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_7" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="210" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            T���l
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_7" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="211" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" colspan="4">
                            ���s���W
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ���W
            				<asp:Button ID="BtnTicketClear8" runat="server" Width="130px" Text="�^�N�`�P8�N���A" 
                                CssClass="ButtonList" TabIndex="212" />                            
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            			    �䒠�p
                            <asp:TextBox ID="ANS_TAXI_SRMKS_8" runat="server" MaxLength="20" Height="18px"
                                Width="189px" TabIndex="213" Wrap="False"></asp:TextBox>                                        			
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_8" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_8" runat="server" TabIndex="214" Text="���s�Ώ�" />
							<asp:Label ID="ANS_TAXI_HAKKO_8" runat="server" Width="80px">���s��</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_8" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            ���n
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_8" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="30px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" >
                            <asp:TextBox ID="ANS_TAXI_DATE_8" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="215"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ����</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_8" runat="server" TabIndex="216">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            �˗����z
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_8" runat="server" Width="80px"></asp:Label>
                            &nbsp;�~
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �ԍ�
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_8" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="217" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            T���l
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_8" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="218" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" colspan="4">
                            ���s���X
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ���X
            				<asp:Button ID="BtnTicketClear9" runat="server" Width="130px" Text="�^�N�`�P9�N���A" 
                                CssClass="ButtonList" TabIndex="219" />                            
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            			    �䒠�p
                            <asp:TextBox ID="ANS_TAXI_SRMKS_9" runat="server" MaxLength="20" Height="18px"
                                Width="189px" TabIndex="220" Wrap="False"></asp:TextBox>                                        			
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_9" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_9" runat="server" TabIndex="221" Text="���s�Ώ�" />
							<asp:Label ID="ANS_TAXI_HAKKO_9" runat="server" Width="80px">���s��</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_9" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            ���n
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_9" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="30px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" >
                            <asp:TextBox ID="ANS_TAXI_DATE_9" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="222"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ����</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_9" runat="server" TabIndex="223">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            �˗����z
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_9" runat="server" Width="80px"></asp:Label>
                            &nbsp;�~
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �ԍ�
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_9" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="224" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            T���l
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_9" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="225" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" colspan="4">
                            ���s���P�O
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ���P�O
            				<asp:Button ID="BtnTicketClear10" runat="server" Width="130px" Text="�^�N�`�P10�N���A" 
                                CssClass="ButtonList" TabIndex="226" />                            
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            			    �䒠�p
                            <asp:TextBox ID="ANS_TAXI_SRMKS_10" runat="server" MaxLength="20" Height="18px"
                                Width="189px" TabIndex="227" Wrap="False"></asp:TextBox>                                        			
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="REQ_TAXI_DATE_10" runat="server" Width="130px"></asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_10" runat="server" TabIndex="228" Text="���s�Ώ�" />
							<asp:Label ID="ANS_TAXI_HAKKO_10" runat="server" Width="80px">���s��</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_10" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            ���n
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
                            <asp:TextBox ID="REQ_TAXI_FROM_10" runat="server" MaxLength="80" 
                                ReadOnly="true" TextMode="MultiLine" Height="30px" Width="344px" 
                                tabstop="false" BorderStyle="None"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem" >
                            <asp:TextBox ID="ANS_TAXI_DATE_10" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="229"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ����</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_10" runat="server" TabIndex="230">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleTaxi" style="width:100px">
                            �˗����z
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="TAXI_YOTEIKINGAKU_10" runat="server" Width="80px"></asp:Label>
                            &nbsp;�~
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �ԍ�
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_10" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="231" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            T���l
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_10" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="232" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4" rowspan="40">
                        </td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ���P�P
            				<asp:Button ID="BtnTicketClear11" runat="server" Width="130px" Text="�^�N�`�P11�N���A" 
                                CssClass="ButtonList" TabIndex="233" />                            
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            			    �䒠�p
                            <asp:TextBox ID="ANS_TAXI_SRMKS_11" runat="server" MaxLength="20" Height="18px"
                                Width="189px" TabIndex="234" Wrap="False"></asp:TextBox>                                        			
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_11" runat="server" TabIndex="235" Text="���s�Ώ�" />
							<asp:Label ID="ANS_TAXI_HAKKO_11" runat="server" Width="80px">���s��</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_11" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_DATE_11" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="236"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ����</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_11" runat="server" TabIndex="237">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �ԍ�
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_11" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="238" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            T���l
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_11" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="239" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ���P�Q
            				<asp:Button ID="BtnTicketClear12" runat="server" Width="130px" Text="�^�N�`�P12�N���A" 
                                CssClass="ButtonList" TabIndex="240" />                            
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            			    �䒠�p
                            <asp:TextBox ID="ANS_TAXI_SRMKS_12" runat="server" MaxLength="20" Height="18px"
                                Width="189px" TabIndex="241" Wrap="False"></asp:TextBox>                                        			
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_12" runat="server" TabIndex="242" Text="���s�Ώ�" />
							<asp:Label ID="ANS_TAXI_HAKKO_12" runat="server" Width="80px">���s��</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_12" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_DATE_12" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="243"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ����</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_12" runat="server" TabIndex="244">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �ԍ�
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_12" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="245" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            T���l
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_12" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="246" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ���P�R
            				<asp:Button ID="BtnTicketClear13" runat="server" Width="130px" Text="�^�N�`�P13�N���A" 
                                CssClass="ButtonList" TabIndex="247" />                            
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            			    �䒠�p
                            <asp:TextBox ID="ANS_TAXI_SRMKS_13" runat="server" MaxLength="20" Height="18px"
                                Width="189px" TabIndex="248" Wrap="False"></asp:TextBox>                                        			
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_13" runat="server" TabIndex="249" Text="���s�Ώ�" />
							<asp:Label ID="ANS_TAXI_HAKKO_13" runat="server" Width="80px">���s��</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_13" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_DATE_13" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="250"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ����</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_13" runat="server" TabIndex="251">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �ԍ�
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_13" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="252" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            T���l
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_13" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="253" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ���P�S
            				<asp:Button ID="BtnTicketClear14" runat="server" Width="130px" Text="�^�N�`�P14�N���A" 
                                CssClass="ButtonList" TabIndex="254" />                            
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            			    �䒠�p
                            <asp:TextBox ID="ANS_TAXI_SRMKS_14" runat="server" MaxLength="20" Height="18px"
                                Width="189px" TabIndex="255" Wrap="False"></asp:TextBox>                                        			
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_14" runat="server" TabIndex="256" Text="���s�Ώ�" />
							<asp:Label ID="ANS_TAXI_HAKKO_14" runat="server" Width="80px">���s��</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_14" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_DATE_14" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="257"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ����</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_14" runat="server" TabIndex="258">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �ԍ�
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_14" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="259" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            T���l
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_14" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="260" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ���P�T
            				<asp:Button ID="BtnTicketClear15" runat="server" Width="130px" Text="�^�N�`�P15�N���A" 
                                CssClass="ButtonList" TabIndex="261" />                            
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            			    �䒠�p
                            <asp:TextBox ID="ANS_TAXI_SRMKS_15" runat="server" MaxLength="20" Height="18px"
                                Width="189px" TabIndex="262" Wrap="False"></asp:TextBox>                                        			
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_15" runat="server" TabIndex="263" Text="���s�Ώ�" />
							<asp:Label ID="ANS_TAXI_HAKKO_15" runat="server" Width="80px">���s��</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_15" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_DATE_15" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="264"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ����</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_15" runat="server" TabIndex="265">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �ԍ�
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_15" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="266" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            T���l
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_15" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="267" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ���P�U
            				<asp:Button ID="BtnTicketClear16" runat="server" Width="130px" Text="�^�N�`�P16�N���A" 
                                CssClass="ButtonList" TabIndex="268" />                            
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            			    �䒠�p
                            <asp:TextBox ID="ANS_TAXI_SRMKS_16" runat="server" MaxLength="20" Height="18px"
                                Width="189px" TabIndex="269" Wrap="False"></asp:TextBox>                                        			
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_16" runat="server" TabIndex="270" Text="���s�Ώ�" />
							<asp:Label ID="ANS_TAXI_HAKKO_16" runat="server" Width="80px">���s��</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_16" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_DATE_16" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="271"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ����</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_16" runat="server" TabIndex="272">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �ԍ�
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_16" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="273" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            T���l
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_16" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="274" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ���P�V
            				<asp:Button ID="BtnTicketClear17" runat="server" Width="130px" Text="�^�N�`�P17�N���A" 
                                CssClass="ButtonList" TabIndex="275" />                            
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            			    �䒠�p
                            <asp:TextBox ID="ANS_TAXI_SRMKS_17" runat="server" MaxLength="20" Height="18px"
                                Width="189px" TabIndex="276" Wrap="False"></asp:TextBox>                                        			
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_17" runat="server" TabIndex="277" Text="���s�Ώ�" />
							<asp:Label ID="ANS_TAXI_HAKKO_17" runat="server" Width="80px">���s��</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_17" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_DATE_17" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="278"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ����</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_17" runat="server" TabIndex="279">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �ԍ�
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_17" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="280" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            T���l
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_17" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="281" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ���P�W
            				<asp:Button ID="BtnTicketClear18" runat="server" Width="130px" Text="�^�N�`�P18�N���A" 
                                CssClass="ButtonList" TabIndex="282" />                            
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            			    �䒠�p
                            <asp:TextBox ID="ANS_TAXI_SRMKS_18" runat="server" MaxLength="20" Height="18px"
                                Width="189px" TabIndex="283" Wrap="False"></asp:TextBox>                                        			
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_18" runat="server" TabIndex="284" Text="���s�Ώ�" />
							<asp:Label ID="ANS_TAXI_HAKKO_18" runat="server" Width="80px">���s��</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_18" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_DATE_18" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="285"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ����</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_18" runat="server" TabIndex="286">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �ԍ�
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_18" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="287" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            T���l
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_18" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="288" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ���P�X
            				<asp:Button ID="BtnTicketClear19" runat="server" Width="130px" Text="�^�N�`�P19�N���A" 
                                CssClass="ButtonList" TabIndex="289" />                            
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            			    �䒠�p
                            <asp:TextBox ID="ANS_TAXI_SRMKS_19" runat="server" MaxLength="20" Height="18px"
                                Width="189px" TabIndex="290" Wrap="False"></asp:TextBox>                                        			
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_19" runat="server" TabIndex="291" Text="���s�Ώ�" />
							<asp:Label ID="ANS_TAXI_HAKKO_19" runat="server" Width="80px">���s��</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_19" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_DATE_19" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="292"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ����</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_19" runat="server" TabIndex="293">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �ԍ�
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_19" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="294" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            T���l
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_19" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="295" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">
                            ���Q�O
            				<asp:Button ID="BtnTicketClear20" runat="server" Width="130px" Text="�^�N�`�P20�N���A" 
                                CssClass="ButtonList" TabIndex="296" />                            
            			</td>
                        <td align="left" valign="middle" class="TdTitle" colspan="2">                            
            			    �䒠�p
                            <asp:TextBox ID="ANS_TAXI_SRMKS_20" runat="server" MaxLength="20" Height="18px"
                                Width="189px" TabIndex="297" Wrap="False"></asp:TextBox>                                        			
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_ANS_TAXI_HAKKO_20" runat="server" TabIndex="298" Text="���s�Ώ�" />
							<asp:Label ID="ANS_TAXI_HAKKO_20" runat="server" Width="80px">���s��</asp:Label>
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���s��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="3">
							<asp:Label ID="ANS_TAXI_HAKKO_DATE_20" runat="server" Width="80px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ���p��
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_DATE_20" runat="server" MaxLength="8" 
                                Height="18px" Width="85px" TabIndex="299"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            ����</td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:DropDownList ID="ANS_TAXI_KENSHU_20" runat="server" TabIndex="300">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            �ԍ�
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_NO_20" runat="server" MaxLength="9" Height="18px" 
                                Width="79px" TabIndex="301" Wrap="False"></asp:TextBox>                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle" style="width:100px">
                            T���l
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_RMKS_20" runat="server" MaxLength="10" Height="18px" 
                                Width="138px" TabIndex="302" Wrap="False"></asp:TextBox>                            
                        </td>
                    </tr>
                </table> 		        
		    </td>		    
		</tr>
		<tr style="height: 36px; width:100%">
		    <td align="right" style="width:100%">
			    <a href="#PageTopLink" TabIndex="303">�y�[�W�g�b�v��</a>
		    </td>
		</tr>
		<tr>
			<td align="left" colspan="2">
				<!-- �e���� -->				
				<table style="margin-bottom: 8px; border-collapse: collapse;" cellspacing="0" 
                    cellpadding="2" border="1" bordercolor="#4f5b61" style="width:900px">
					<tr>
						<td align="left" valign="middle" class="TdTitleHeader" colspan="6">
							���e����
                        </td>
					</tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle">
                            DR�h����(�ō�)
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="2">
                            <asp:TextBox ID="ANS_HOTELHI" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="304" AutoPostBack="True"></asp:TextBox>�~                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            �q�󌔑�(�ō�)
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="2">
                            <asp:TextBox ID="ANS_AIR_FARE" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="305"></asp:TextBox>�~                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle">
                            DR�h�������s��
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="2">
                            <asp:TextBox ID="ANS_HOTELHI_TOZEI" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="306"></asp:TextBox>�~                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            �q�󌔎����(�ō�)
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="2">
                            <asp:TextBox ID="ANS_AIR_CANCELLATION" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="307"></asp:TextBox>�~                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle">
                            DR�h�������(�ō�)
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="2">
                            <asp:TextBox ID="ANS_HOTELHI_CANCEL" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="308"></asp:TextBox>�~                            
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            JR����(�ō�)
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="2">
                            <asp:TextBox ID="ANS_RAIL_FARE" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="309"></asp:TextBox>�~                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle">
                            �o�^�萔���i��ʁE�h���j
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:CheckBox ID="CHK_KOTSUHOTEL_TESURYO" runat="server" Text="�萔������" 
                                TabIndex="310" AutoPostBack="True" />
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:Label ID="ANS_KOTSUHOTEL_TESURYO" runat="server"></asp:Label>�~
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            JR�������(�ō�)
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="2">
                            <asp:TextBox ID="ANS_RAIL_CANCELLATION" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="311"></asp:TextBox>�~                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitle">
                            �^�N�`�P���s����
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:TextBox ID="ANS_TAXI_MAISUU" runat="server" MaxLength="3" 
                                Height="18px" Width="35px" TabIndex="312" AutoPostBack="True"></asp:TextBox>��
                        </td>
                        <td align="left" valign="middle" class="TdItem">
                            <asp:Label ID="ANS_TAXI_TESURYO" runat="server"></asp:Label>�~
                        </td>
                        <td align="left" valign="middle" class="TdTitle">
                            ���̑��S���㓙(�ō�)
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="2">
                            <asp:TextBox ID="ANS_OTHER_FARE" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="313"></asp:TextBox>�~                            
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3"></td>
                        <td align="left" valign="middle" class="TdTitle">
                            ���̑��S���㓙�����(�ō�)
                        </td>
                        <td align="left" valign="middle" class="TdItem" colspan="2">
                            <asp:TextBox ID="ANS_OTHER_CANCELLATION" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="314"></asp:TextBox>�~                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleMR">
                            MR�h����(�ō�)
                        </td>
                        <td align="left" valign="top" class="TdItem" colspan="2">
                            <asp:TextBox ID="ANS_MR_HOTELHI" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="315" AutoPostBack="True" 
                                Enabled="False"></asp:TextBox>�~                            
                        </td>
                        <td align="left" valign="middle" class="TdTitleMR">
                            MR��ʔ�(�ō�)
                        </td>
                        <td align="left" valign="top" class="TdItem" colspan="2">
                            <asp:TextBox ID="ANS_MR_KOTSUHI" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="316"></asp:TextBox>�~                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" valign="middle" class="TdTitleMR">
                            MR�h�������s��
                        </td>
                        <td align="left" valign="top" class="TdItem" colspan="5">
                            <asp:TextBox ID="ANS_MR_HOTELHI_TOZEI" runat="server" MaxLength="10" 
                                Height="18px" Width="85px" TabIndex="317" Enabled="False"></asp:TextBox>�~                            
                        </td>
                    </tr>
				</table>
		    </td>
		</tr>
		    
		<div class="FontSize1" style="height: 10px;"></div>
		<table cellspacing="0" cellpadding="0" border="0" style="width:900px;">
			<tr style="height: 36px; width:100%">
				<td align="left" style="width:100%">
				    <asp:Button ID="BtnRireki" runat="server" Width="130px" Text="����\��" 
                        CssClass="Button" TabIndex="318" />
                </td>
            </tr>
            <tr align="left" style="width:100%">
                <td>
					<asp:Button ID="BtnPrint2" runat="server" Width="130px" Text="��z�����" 
                        CssClass="Button" TabIndex="319" />
					<asp:Button ID="BtnSoufujo2" runat="server" Width="130px" Text="���t����" 
                        CssClass="Button" TabIndex="320" />
					<asp:Button ID="BtnTaxiKakunin2" runat="server" Width="150px" Text="�^�N�`�P��z�m�F�[���" 
                        CssClass="Button" TabIndex="321" />
				    <asp:Button ID="BtnSubmit2" runat="server" Width="130px" Text="�o�^" 
                        CssClass="Button" TabIndex="322" />
				    <asp:Button ID="BtnNozomi2" runat="server" Width="130px" Text="NOZOMI��" 
                        CssClass="Button" TabIndex="323" />
					<asp:Button ID="BtnBack2" runat="server" Width="130px" Text="�߂�" 
                        CssClass="Button" TabIndex="324" />
				</td>
			</tr>
		</table>
	</table>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">

		<style type="text/css">
            .style1
            {
                width: 900px;
            }
            .style2
            {
                background-color: #e5a800;
                color: #332500;
                font-weight: bold;
                width: 100px;
                height: 35px;
            }
            .style3
            {
                background-color: #ffffff;
                color: #0a0a0a;
                font-weight: normal;
                height: 35px;
            }
            .style4
            {
                background-color: #b8c3c8;
                color: #273034;
                font-weight: bold;
                width: 100px;
                height: 35px;
            }
        </style>

</asp:Content>

