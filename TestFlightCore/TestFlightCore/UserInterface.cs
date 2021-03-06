// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using KSP;
using UnityEngine;
using KSPPluginFramework;

namespace TestFlightCore
{
    internal static class OldStyles
    {
        internal static GUIStyle panelStyle;

        internal static GUIStyle textStyleCritical;
        internal static GUIStyle textStyleWarning;
        internal static GUIStyle textStyleSafe;
        internal static GUIStyle textStyleStandard;

        internal static GUIStyle stylePanel;
        internal static GUIStyle styleButton;
        internal static GUIStyle styleButtonUnity;
        internal static GUIStyle styleButtonMain;
        internal static GUIStyle styleButtonMainUnity;
        internal static GUIStyle styleButtonSettings;


        internal static void Init()
        {
            Debug.Log("TestFlight Styles: Init");
            panelStyle = new GUIStyle(SkinsLibrary.DefKSPSkin.window);
//            panelStyle.border = new RectOffset(6, 6, 6, 6);
//            panelStyle.padding = new RectOffset(8, 3, 7, 0);

            stylePanel = new GUIStyle();
            stylePanel.normal.background = TestFlight.Resources.texPanel;
            stylePanel.border = new RectOffset(6, 6, 6, 6);
            stylePanel.padding = new RectOffset(8, 3, 7, 0);

            textStyleStandard = new GUIStyle(SkinsLibrary.DefUnitySkin.label);
            textStyleStandard.fontSize = 12;
            textStyleStandard.alignment = TextAnchor.MiddleLeft;
            textStyleStandard.normal.textColor = new Color(253, 246, 227);
            textStyleStandard.wordWrap = false;

            textStyleSafe = new GUIStyle(textStyleStandard);
            textStyleSafe.normal.textColor = new Color32(133, 153, 0, 255);        
            
            textStyleWarning = new GUIStyle(textStyleStandard);
            textStyleWarning.normal.textColor = new Color32(203, 75, 22, 255);        
            
            textStyleCritical = new GUIStyle(textStyleStandard);
            textStyleCritical.normal.textColor = new Color32(220, 50, 47, 255);        

            styleButton = new GUIStyle(SkinsLibrary.DefUnitySkin.button);
            styleButton.name = "ButtonGeneral";
            styleButton.normal.background = SkinsLibrary.DefKSPSkin.button.normal.background;
            styleButton.hover.background = SkinsLibrary.DefKSPSkin.button.hover.background;
            styleButton.normal.textColor = new Color(207, 207, 207);
            styleButton.fontStyle = FontStyle.Normal;
            styleButton.fixedHeight = 20;
            styleButton.padding.top = 2;

            styleButtonUnity = new GUIStyle(styleButton);
            styleButtonUnity.normal.background = SkinsLibrary.DefUnitySkin.button.normal.background;
            styleButtonUnity.hover.background = SkinsLibrary.DefUnitySkin.button.hover.background;

            styleButtonMain = new GUIStyle(styleButton);
            styleButtonMain.name = "ButtonMain";
            styleButtonMain.fixedHeight = 20;

            styleButtonMainUnity = new GUIStyle(styleButtonMain);
            styleButtonMainUnity.normal.background = SkinsLibrary.DefUnitySkin.button.normal.background;
            styleButtonMainUnity.hover.background = SkinsLibrary.DefUnitySkin.button.hover.background;


            styleButtonSettings = new GUIStyle(styleButton);
            styleButtonSettings.name = "ButtonSettings";
            styleButtonSettings.padding = new RectOffset(1, 1, 1, 1);


            //Default Skin
//            GUISkin DefKSP = SkinsLibrary.CopySkin(SkinsLibrary.DefSkinType.KSP);
//            DefKSP.window = stylePanel;
//            DefKSP.font = SkinsLibrary.DefUnitySkin.font;
//            DefKSP.horizontalSlider.margin.top = 8;
//            SkinsLibrary.AddSkin("Default", DefKSP);
//
//            //Adjust Default Skins
//            SkinsLibrary.List["Default"].button = new GUIStyle(styleButton);
//            SkinsLibrary.List["Default"].label = new GUIStyle(styleText);
//
//            //Add Styles once skin is added
//            SkinsLibrary.AddStyle("Default", styleTooltipStyle);
//            SkinsLibrary.AddStyle("Default", styleButton);
//            SkinsLibrary.AddStyle("Default", styleButtonMain);
//            SkinsLibrary.AddStyle("Default", styleButtonSettings);
//            SkinsLibrary.AddStyle("Default", "DropDownButton", styleDropDownButton);
//            SkinsLibrary.AddStyle("Default", "DropDownListBox", styleDropDownListBox);
//            SkinsLibrary.AddStyle("Default", "DropDownListItem", styleDropDownListItem);
        }
    }
}

