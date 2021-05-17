using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ScreenShot : MonoBehaviour
{

    private Camera myCamera;
    private static ScreenShot instance;
    private bool takeScreenShotFrame;
    private void Awake()
    {
        instance = this;
        myCamera = gameObject.GetComponent<Camera>();
    }

    private void OnPostRender()
    {
        if (takeScreenShotFrame)
        {
            takeScreenShotFrame = false;
            RenderTexture renderTexture = myCamera.targetTexture;

            Texture2D screenshot = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.ARGB32, false);
            Rect rect = new Rect(0, 0, renderTexture.width, renderTexture.height);
            screenshot.ReadPixels(rect, 0, 0);

            byte[] byteArray = screenshot.EncodeToPNG();
            System.IO.File.WriteAllBytes(Application.dataPath + "/Resources/zall.png", byteArray);
            AssetDatabase.Refresh();



        }
    }

    private void TakeScreenshot(int width, int height)
    {
        takeScreenShotFrame = true;
    }

    public static void TakeScreenshot_static(int width, int height)
    {
        instance.TakeScreenshot(width, height);
    }


}
