using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowSphere : Sphere
{
    public override void SpehereColor()
    {
        newColor = Color.yellow;
        base.SpehereColor();
    }
}
