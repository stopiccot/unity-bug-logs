using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
#if UNITY_IOS && !UNITY_EDITOR
    [System.Runtime.InteropServices.DllImport("__Internal")]
    private static extern void TestScript_NSLog(string text);
#else
    private static void TestScript_NSLog(string text) { }
#endif

    void Awake()
    {
        Debug.Log("[UNITYTEST] Debug.Log()");
        TestScript_NSLog("[UNITYTEST] NSLog()");
    }
}
