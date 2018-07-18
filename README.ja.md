# psgg-unity-menu

## 概要

1. PSGGステートマシンによるUI作成  
Assets/app/0100_Base/UIControl/state  

![UI state machine](https://raw.githubusercontent.com/NNNIC/psgg-unity-menu/master/web/ui.png)

2. PSGGステートマシンによるイベント制御  
"Button 05"押下により、エラーダイアログ表示   

Assets/app/0100_Base/MainControl  
![Main state machine](https://raw.githubusercontent.com/NNNIC/psgg-unity-menu/master/web/main.png)

## UI システム

本サンプルでは、テンプレートをクローンして、パネルとボタンを生成します。  
UIビューは、メンテナンス性向上のため、１スケールと１ピクセルが同じになっています。  
ターゲットビューがiPhoneXサイズの時、セーフエリアを確保します。


## エラーダイアログ

ErrorDlg.V.SetError()を呼ぶことで、エラーダイアログが生成されます。
このAPIは複数回コールが可能です。

## イベントシステム

すべてのUIイベントを　MainStateEvent.Push() にて記録します。  
将来において、UIテストを可能にするためです。

## カメラ設定

### Depth

|Camera|Mask|Depth|Comment|
|:--|--:|:--|:--|
|UI/main/Camera|UI|11| Main UI |
|BG/Camera |None|-49|Background Color|
|ErrorDg/Camera|UI|50| Error Dialog|


![app](https://raw.githubusercontent.com/NNNIC/psgg-unity-menu/master/web/app.png)

