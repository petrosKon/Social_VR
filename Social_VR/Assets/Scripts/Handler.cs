using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handler : MonoBehaviour
{
    public static Action onButtonPressed;

    private void Start()
    {
        onButtonPressed += ScreenShotCapture.TakeScreenshot_static;
    }

    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One))
        {
            onButtonPressed();
        }
    }
}
