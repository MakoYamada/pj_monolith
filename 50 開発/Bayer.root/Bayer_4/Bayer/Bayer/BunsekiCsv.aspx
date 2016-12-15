<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master"
    CodeBehind="BunsekiCsv.aspx.vb" Inherits="Bayer.BunsekiCsv" %>

<%@ MasterType VirtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 193px;
        }
        .style2
        {
            width: 910px;
        }
        .style3
        {
            width: 345px;
        }
    </style>
    <script type="text/javascript">
        var timer;
        
        // 会合費用総合一覧表
        function KaigouStartTimer() {
            GetKaigouTimer();
        }
        function GetKaigou() {
            // 会合費用総合一覧　進捗確認ボタンをスクリプトで押す。
            document.getElementById("BtnKaigouCsvRun").click();
        }
        function GetKaigouTimer() {
            // 進捗確認ボタンをスクリプトで押す。
            document.getElementById("BtnKaigouCsvRun").click();
            timer = setTimeout('GetKaigouTimer()', 3000)
        }

        // 参加者旅費費用総合一覧表
        function DrStartTimer() {
            GetDrTimer();
        }
        function GetDr() {
            // 参加者旅費費用総合一覧　進捗確認ボタンをスクリプトで押す。
            document.getElementById("BtnDrCsvRun").click();
        }
        function GetDrTimer() {
            // 進捗確認ボタンをスクリプトで押す。
            document.getElementById("BtnDrCsvRun").click();
            timer = setTimeout('GetDrTimer()', 3000)
        }

        // 社員旅費費用総合一覧表
        function MrStartTimer() {
            GetMrTimer();
        }
        function GetMr() {
            // 社員旅費費用総合一覧　進捗確認ボタンをスクリプトで押す。
            document.getElementById("BtnMrCsvRun").click();
        }
        function GetMrTimer() {
            // 進捗確認ボタンをスクリプトで押す。
            document.getElementById("BtnMrCsvRun").click();
            timer = setTimeout('GetMrTimer()', 3000)
        }
                
        function StopTimer() {
            timer = clearInterval(timer);
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <table cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td align="left">
                <table cellpadding="2" cellspacing="0" border="0" width="972px">
                    <tr style="width:900px">
                        <td style="width:80px">
                            承認年月
                        </td>
                        <td style="width:800px">
                                <asp:TextBox ID="JokenSHOUNIN_Y" runat="server" Width="50px" MaxLength="4"></asp:TextBox>年
							    <asp:TextBox ID="JokenSHOUNIN_M" runat="server" Width="30px" MaxLength="2"></asp:TextBox>月
                        </td>
                    </tr>
                </table>
                <hr style="width:100%" />
            </td>
        </tr>        
        <tr>
            <td>
                <table cellpadding="2" cellspacing="0" border="0" width="100%">
                    <tr>
                        <td style="width:100%">
                            <asp:Button ID="BtnKaigouCsv" runat="server" Text="会合費用総合一覧表" Width="180px" 
                                CssClass="Button"  TabIndex="4"/>
                            <asp:Button ID="BtnDrCsv" runat="server" Text="参加者旅費費用総合一覧表" Width="180px" 
                                CssClass="Button"  TabIndex="4"/>
                            <asp:Button ID="BtnMrCsv" runat="server" Text="社員旅費費用総合一覧表" Width="180px" 
                                CssClass="Button" TabIndex="5" />
                            <asp:Button ID="BtnBack" runat="server" Text="戻る" Width="180px" 
                                CssClass="Button" TabIndex="5" />
                        </td>
                    </tr>
                </table> 
            </td>
        </tr>
    </table>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table>
                <tr align="left">
                    <th>処理ステータス</th>
                    <td>
                        <asp:Label ID="lblStatus" runat="server" Text="-"></asp:Label></td>
                    <td>
                    
                    </td>
                </tr>
                <tr align="left">
                    <th>進行状況</th>
                    <td>
                        <asp:Label ID="lblProgress" runat="server" Text="-"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="BtnKaigouCsvRun" runat="server" Text="会合費用総合一覧表"  />
                        <asp:Button ID="BtnDrCsvRun" runat="server" Text="参加者旅費費用総合一覧表" CssClass="ButtonHidden" />
                        <asp:Button ID="BtnMrCsvRun" runat="server" Text="社員旅費費用総合一覧表" CssClass="ButtonHidden" />
                    </td>
                </tr>
            </table>        
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
