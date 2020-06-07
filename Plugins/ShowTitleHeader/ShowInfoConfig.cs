using UnityEngine;


public class ShowInfoAttribute : PropertyAttribute
{

    public string writing;
    
    /*public FontStyle fontStyle;
    public TextAnchor textAnchor;
    public int fontSize;
    public float r, g, b;
    public bool showBox;*/

    public ShowInfoAttribute(string write)
    {
#if UNITY_EDITOR
        writing = write;
#endif
    }

}