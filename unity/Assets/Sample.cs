using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    void Start()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        this.ShowTextView();
#endif
    }

    void ShowTextView()
    {
        using (var cls = new AndroidJavaClass("com.unity.plugin.ui.TextSelectable")) {
            using (var textSelectable = cls.CallStatic<AndroidJavaObject>("Make", 500, 500, 0, 0)) {
                textSelectable.Call("SetText", "test test test test test test test");
            }
        }
    }
}
