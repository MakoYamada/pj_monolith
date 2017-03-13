Code Snippet;
 
// Sys.Application イベントの追加 
Sys.Application.add_init(AppInit);
 
// Sys.Application.init イベントハンドラ
function AppInit(sender)
{
 
  // PageRequestManagerインスタンスの取得
  var prm = Sys.WebForms.PageRequestManager.getInstance();
 
  if (!prm.get_isInAsyncPostBack())
  {
    // 非同期ポストバックの各イベントハンドラの設定
    prm.add_initializeRequest(InitializeRequest);
  }
}
 
 
 
// 非同期ポストバックの初期化(initializeRequest)イベントハンドラ
function InitializeRequest(sender, args)
{
  var prm = Sys.WebForms.PageRequestManager.getInstance();
 
  if (!prm.get_isInAsyncPostBack() &&
      args.get_postBackElement().id == "Button1" &&
      $get("TextBox1").value == "")
  {
    args.set_cancel(true);
    alert("テキストを入力してください");
  }
}
