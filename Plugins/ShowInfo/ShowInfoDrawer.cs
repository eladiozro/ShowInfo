﻿using UnityEngine;
using UnityEditor;

#if UNITY_EDITOR
[CustomPropertyDrawer(typeof(ShowInfoAttribute))]
public class ShowInfoDrawer : DecoratorDrawer
{
    public override void OnGUI(Rect position)
    {
#if UNITY_EDITOR

        ShowInfoAttribute attributes = (ShowInfoAttribute)attribute;

        // DRAW BOX
        Rect box = new Rect(position.x + ShowInfoWindow.defaultWidth,
            position.y + ShowInfoWindow.defaultSpaceBefore,
            position.width - (ShowInfoWindow.defaultWidth * 2), 20 + ShowInfoWindow.defaultHeight);

        Color bg = ShowInfoStyles.ConfigColor(ShowInfoWindow.defaultBoxColor);
        if (ShowInfoWindow.boxEnabled) EditorGUI.DrawRect(box, bg);

        // DRAW TEXT
        box = new Rect(box.x + ShowInfoWindow.defaultInnerWidth, box.y,
            box.width - (ShowInfoWindow.defaultInnerWidth * 2), box.height);


        Color c = ShowInfoStyles.ConfigColor(ShowInfoWindow.defaultColor);
        GUIStyle style = new GUIStyle(EditorStyles.label);
        style.fontStyle = ShowInfoWindow.defaultStyle;
        style.alignment = ShowInfoWindow.defaultAnchor;
        style.fontSize = ShowInfoWindow.defaultSize;
        style.normal.textColor = new Color(c.r, c.g, c.b);

        GUI.Label(box, attributes.writing, style);


#endif
    }


#if UNITY_EDITOR
    public override float GetHeight()
    {
        return ShowInfoWindow.defaultSpaceBefore + 20 + ShowInfoWindow.defaultHeight + ShowInfoWindow.defaultSpaceAfter;
    }
#endif


}
#endif
