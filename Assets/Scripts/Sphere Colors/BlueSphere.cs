using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSphere : Sphere
{
    public override void SpehereColor()
    {
        newColor = Color.blue;
        base.SpehereColor();
    }
}
