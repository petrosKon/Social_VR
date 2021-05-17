using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handler : MonoBehaviour
{

    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One))
        {
            ScreenShot.TakeScreenshot_static(500, 500);
        }
    }
}
