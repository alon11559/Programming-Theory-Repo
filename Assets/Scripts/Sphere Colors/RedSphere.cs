using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSphere : Sphere
{
    public override void SpehereColor()
    {
        newColor = Color.red;
        base.SpehereColor();
    }
}
