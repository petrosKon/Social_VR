using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenshotCapture : MonoBehaviour
{
    public GameObject screenshotQuad;
    public RenderTexture cameraRenderTexture;
    private Camera thisCamera;

    // Start is called before the first frame update
    void Start()
    {
        thisCamera = GetComponent<Camera>();
        cameraRenderTexture = thisCamera.targetTexture;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            StartCoroutine(TakeSnapshot());
        }
    }

    public IEnumerator TakeSnapshot()
    {
        yield return new WaitForEndOfFrame();

        thisCamera.Render();

        Texture2D image = new Texture2D(cameraRenderTexture.width, cameraRenderTexture.height, TextureFormat.RGB24, true);
        image.ReadPixels(new Rect(0, 0, cameraRenderTexture.width, cameraRenderTexture.height), 0, 0, false);
        image.Apply();


        screenshotQuad.GetComponent<Renderer>().material.mainTexture = image;
    }
}
