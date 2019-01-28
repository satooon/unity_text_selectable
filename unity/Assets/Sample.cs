using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    void Start()
    {
#if UNITY_EDITOR
        Debug.Log("None");
#elif UNITY_ANDROID
        this.ShowTextViewByAndroid();
#elif UNITY_IOS
        this.ShowTextViewByiOS();
#endif
    }

    void ShowTextViewByAndroid()
    {
        using (var cls = new AndroidJavaClass("com.unity.plugin.ui.TextSelectable")) {
            using (var textSelectable = cls.CallStatic<AndroidJavaObject>("Make", 500, 500, 0, 0)) {
                textSelectable.Call("SetText", "test test test test test test test");
            }
        }
    }

    void ShowTextViewByiOS()
    {
        TextSelectable.Make();
        TextSelectable.SetText("sample samplesamplesample sample sample sample sample");
    }
}
