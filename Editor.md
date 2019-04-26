# Editor-System

1. AssetPreview.GetAssetPreview 可取得资源预览图
2. AssetDatabase.GetCachedIcon 取得图标
3. CustomPropertyDrawer 可定义类 也可以定义Attribute
4. CustomEditor 定义类的Inspector


# GUI 有点乱的地方
1. EditorGUI
    1. EditorGUI.BeginChangeCheck
    2. EditorGUI.indentLevel
    3. ...
2. EditorGUIUtility 
    1. GetObjectPickerControlID;
    2. GetObjectPickerObject;
    3. ShowObjectPicker
    4. keyboardControl

3. EditorGUILayout 自动布局

4. 内部还有EditorGUIExt,EditorGUIInternal,EditorGUILayoutUtilityInternal


6. GUI
    1.GUI.Scope 可定义块 使用using的dispose模式写法
7. GUIUtility
    1. GetControlID 
    2. ExitGUI
    3. ...
8. GUILayout 
    1. 宽高等参数
    2. ...
9. GUILayoutUtility
    1. GetLastRect;
    2. ...

10. HandleUtility
    1. Repaint
    2. ...

11. EditorStyles 样式  可直接Draw

12.  Event;
    1. current.Use()


 # AssetDatabase
    
