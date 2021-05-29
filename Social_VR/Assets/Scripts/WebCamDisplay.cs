using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCamDisplay : MonoBehaviour, IWebCamDisplay
{
    [HideInInspector]
    public WebCamTexture webCamTexture;

    // Start is called before the first frame update
    void Awake()
    {
        AttachWebcamTexture();
    }

    public void AttachWebcamTexture()
    {
        webCamTexture = new WebCamTexture();
        this.GetComponent<MeshRenderer>().material.mainTexture = webCamTexture;
        webCamTexture.Play();
    }
}
