using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [Range(-1f, 1f)]
    public float scrollSpeed = 0.5f;
    private float offSet;
    private Material mat;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    void Update()
    {
        offSet += (Time.deltaTime * scrollSpeed) / 10f;

        // Every Material has a "_MainTex" 
        mat.SetTextureOffset("_MainTex", new Vector2(offSet, 0));
    }
}
