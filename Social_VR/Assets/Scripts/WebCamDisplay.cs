using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCamDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WebCamTexture webCamTexture = new WebCamTexture();
        this.GetComponent<MeshRenderer>().material.mainTexture = webCamTexture;
        webCamTexture.Play();
    }
}
