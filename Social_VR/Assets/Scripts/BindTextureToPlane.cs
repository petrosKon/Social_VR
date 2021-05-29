using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BindTextureToPlane : MonoBehaviour
{
    // Start is called before the first frame update
    private Renderer myplane_renderer;

    private void Awake()
    {
        myplane_renderer = gameObject.GetComponent<Renderer>();

        Handler.onButtonPressed += AttachTexture;

    }

    private void AttachTexture()
    {
        Texture my_img = (Texture)Resources.Load("zall");
        myplane_renderer.material.mainTexture = my_img;
    }
}
