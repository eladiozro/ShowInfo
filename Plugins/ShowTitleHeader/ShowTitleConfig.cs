using System.Collections;
using UnityEngine;
public class ShowTitleAttribute : PropertyAttribute
{
    public string writing;
    public FontStyle fontStyle;
    public TextAnchor textAnchor;
    public int fontSize;
    public float r, g, b;
    public bool showBox;
    public ShowTitleAttribute(string write)
    {
        // ONLY TEXT
        writing = write;
        ConfigStyle(ShowTitleStyle.NormalSmallBox);
        ConfigColor(ShowTitleColor.White);
        
        fontSize = 11;
        textAnchor = TextAnchor.MiddleLeft;
    }
    public ShowTitleAttribute(string write, ShowTitleColor color)
    {
        // COLOR
        writing = write;
        ConfigStyle(ShowTitleStyle.BoldSmall);
        ConfigColor(color);
        fontSize = 11;
        textAnchor = TextAnchor.MiddleCenter;
    }
    public ShowTitleAttribute(string write, ShowTitleColor color, ShowTitleStyle style)
    {
        // COLOR STYLE 
        writing = write;
        ConfigStyle(style);
        ConfigColor(color);
        textAnchor = TextAnchor.MiddleCenter;
    }
    public ShowTitleAttribute(string write, ShowTitleColor color, ShowTitleStyle style, TextAnchor anchor)
    {
        // COLOR STYLE ANCHOR
        writing = write;
        ConfigStyle(style);
        ConfigColor(color);
        textAnchor = anchor;
    }
    public ShowTitleAttribute(string write, float _r, float _g, float _b, ShowTitleStyle style, TextAnchor anchor, int fSize)
    {
        // R G B STYLE ANCHOR FONTSIZE 
        writing = write;
        ConfigStyle(style);
        SetColor(_r, _g, _b);
        fontSize = fSize;
        textAnchor = anchor;
    }
    void SetColor(float _r, float _g, float _b)
    {
        r = _r;
        g = _g;
        b = _b;
    }
    void ConfigStyle(ShowTitleStyle config)
    {
        switch ((int)config)
        {
            // Normal
            case 00: fontSize = 11; fontStyle = FontStyle.Normal; showBox = false; break;
            case 01: fontSize = 14; fontStyle = FontStyle.Normal; showBox = false; break;
            case 02: fontSize = 18; fontStyle = FontStyle.Normal; showBox = false; break;
            case 03: fontSize = 25; fontStyle = FontStyle.Normal; showBox = false; break;
            case 04: fontSize = 11; fontStyle = FontStyle.Normal; showBox = true; break;
            case 05: fontSize = 14; fontStyle = FontStyle.Normal; showBox = true; break;
            case 06: fontSize = 18; fontStyle = FontStyle.Normal; showBox = true; break;
            case 07: fontSize = 25; fontStyle = FontStyle.Normal; showBox = true; break;
            // Bold
            case 08: fontSize = 11; fontStyle = FontStyle.Bold; showBox = false; break;
            case 09: fontSize = 14; fontStyle = FontStyle.Bold; showBox = false; break;
            case 10: fontSize = 18; fontStyle = FontStyle.Bold; showBox = false; break;
            case 11: fontSize = 25; fontStyle = FontStyle.Bold; showBox = false; break;
            case 12: fontSize = 11; fontStyle = FontStyle.Bold; showBox = true; break;
            case 13: fontSize = 14; fontStyle = FontStyle.Bold; showBox = true; break;
            case 14: fontSize = 18; fontStyle = FontStyle.Bold; showBox = true; break;
            case 15: fontSize = 25; fontStyle = FontStyle.Bold; showBox = true; break;
            // Italic
            case 16: fontSize = 11; fontStyle = FontStyle.Italic; showBox = false; break;
            case 17: fontSize = 14; fontStyle = FontStyle.Italic; showBox = false; break;
            case 18: fontSize = 18; fontStyle = FontStyle.Italic; showBox = false; break;
            case 19: fontSize = 25; fontStyle = FontStyle.Italic; showBox = false; break;
            case 20: fontSize = 11; fontStyle = FontStyle.Italic; showBox = true; break;
            case 21: fontSize = 14; fontStyle = FontStyle.Italic; showBox = true; break;
            case 22: fontSize = 18; fontStyle = FontStyle.Italic; showBox = true; break;
            case 23: fontSize = 25; fontStyle = FontStyle.Italic; showBox = true; break;
            // BoldAndItalic
            case 24: fontSize = 11; fontStyle = FontStyle.BoldAndItalic; showBox = false; break;
            case 25: fontSize = 14; fontStyle = FontStyle.BoldAndItalic; showBox = false; break;
            case 26: fontSize = 18; fontStyle = FontStyle.BoldAndItalic; showBox = false; break;
            case 27: fontSize = 25; fontStyle = FontStyle.BoldAndItalic; showBox = false; break;
            case 28: fontSize = 11; fontStyle = FontStyle.BoldAndItalic; showBox = true; break;
            case 29: fontSize = 14; fontStyle = FontStyle.BoldAndItalic; showBox = true; break;
            case 30: fontSize = 18; fontStyle = FontStyle.BoldAndItalic; showBox = true; break;
            case 31: fontSize = 25; fontStyle = FontStyle.BoldAndItalic; showBox = true; break;
        }
    }
    void ConfigColor(ShowTitleColor colors)
    {
        // print((int)colors);
        switch ((int)colors)
        {
            case 00: SetColor(1.00f, 1.00f, 1.00f); break; // White
            case 01: SetColor(0.75f, 0.75f, 0.75f); break; // GrayLight
            case 02: SetColor(0.25f, 0.25f, 0.25f); break; // GrayDark
            case 03: SetColor(0.80f, 0.80f, 0.70f); break; // GrayCream
            case 04: SetColor(0.70f, 0.70f, 0.80f); break; // GrayBlue
            case 05: SetColor(0.70f, 0.80f, 0.70f); break; // GrayGreen
            case 06: SetColor(0.80f, 0.70f, 0.70f); break; // GrayPink
            case 07: SetColor(0.00f, 0.00f, 0.00f); break; // Black
            case 08: SetColor(0.00f, 0.00f, 1.00f); break; // BlueFull
            case 09: SetColor(0.00f, 0.50f, 1.00f); break; // BlueSky
            case 10: SetColor(0.00f, 1.00f, 1.00f); break; // Cyan
            case 11: SetColor(0.00f, 1.00f, 0.50f); break; // GreenWater
            case 12: SetColor(0.00f, 1.00f, 0.00f); break; // GreenFull
            case 13: SetColor(0.50f, 1.00f, 0.00f); break; // GreenLemon
            case 14: SetColor(1.00f, 1.00f, 0.00f); break; // Yellow
            case 15: SetColor(1.00f, 0.50f, 0.00f); break; // Orange
            case 16: SetColor(0.60f, 0.35f, 0.00f); break; // Brown
            case 17: SetColor(1.00f, 0.00f, 0.00f); break; // RedFull
            case 18: SetColor(1.00f, 0.00f, 0.50f); break; // Purple
            case 19: SetColor(1.00f, 0.00f, 1.00f); break; // Magenta
            case 20: SetColor(0.50f, 0.00f, 1.00f); break; // Indigo
        }
    }
}