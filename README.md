# psgg-unity-menu

[StateGo](https://statego.programanic.com/index-e.html)

## Overview

1. A PSGG state machine will create UI.  
Assets/app/0100_Base/UIControl/state

![UI state machine](https://raw.githubusercontent.com/NNNIC/psgg-unity-menu/master/web/ui.png)

2. A PSGG state machine will handle events.
It shows dialog when button5 pushes.
Assets/app/0100_Base/MainControl  
![Main state machine](https://raw.githubusercontent.com/NNNIC/psgg-unity-menu/master/web/main.png)

## UI System

Of this example, it will create a panel and buttons that are cloned from template.

UI view is "A unit by A pixel" system for improving maintainability.

When the target view is as iPhone X size, it keeps the safe area.

## Error Dialog

Error dialog can be created by ErrorDlg.V.SetError();  
It allows you to call the api multi times.

## Event System

All UI Events will be recorded by MainStateEvent.Push().
This will be used for UI Test.

## Camera Settings

### Depth

|Camera|Mask|Depth|Comment|
|:--|--:|:--|:--|
|UI/main/Camera|UI|11| Main UI |
|BG/Camera |None|-49|Background Color|
|ErrorDg/Camera|UI|50| Error Dialog|

## Play the scene

Load Assets/app/0100_Base/base.unity

![app](https://raw.githubusercontent.com/NNNIC/psgg-unity-menu/master/web/ap.png)

