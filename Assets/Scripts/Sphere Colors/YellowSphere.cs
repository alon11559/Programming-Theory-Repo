using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YellowSphere : Sphere
{
    public override void SpehereColor()
    {
        newColor = Color.yellow;
        base.SpehereColor();

    }
}
