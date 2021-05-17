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

    }


    // Update is called once per frame
    void Update()
    {
        Texture my_img = (Texture)Resources.Load("zall");
        myplane_renderer.material.mainTexture = my_img;

    }
}
