using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public Color newColor;

    private void Start()
    {
        SpehereColor();
    }
    public virtual void SpehereColor()
    {
        gameObject.GetComponent<Renderer>().material.SetColor("_Color", newColor);
        
    }
}
