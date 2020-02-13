using System.Collections;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(ShowTitleAttribute))]
public class ShowTitleDrawer : DecoratorDrawer
{
    public override void OnGUI(Rect position)
    {
        ShowTitleAttribute s = (ShowTitleAttribute)attribute;
        
        Rect box = new Rect(position.x, position.y + 1, position.width, position.height / 1.45f);
        if (s.showBox)
        {
            GUI.Box(box, "");
        }
        GUIStyle style = new GUIStyle(EditorStyles.label);
        style.fontStyle = s.fontStyle;
        style.alignment = s.textAnchor;
        style.fontSize = s.fontSize;
        style.normal.textColor = new Color(s.r,s.g,s.b);
        box = new Rect(box.x, box.y, box.width, box.height);
        GUI.Label(box, s.writing, style);
    }

    public override float GetHeight()
    {
        ShowTitleAttribute s = (ShowTitleAttribute)attribute;
        return base.GetHeight() + 2 + s.fontSize;
    }
}