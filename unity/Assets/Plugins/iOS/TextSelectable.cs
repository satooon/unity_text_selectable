using UnityEngine;
using System.Runtime.InteropServices;

public class TextSelectable
{
    [DllImport("__Internal")]
    private static extern void make_();
    [DllImport("__Internal")]
    private static extern void setText_(string text);

    public static void Make()
    {
        make_();
    }
    public static void SetText(string text)
    {
        setText_(text);
    }
}
