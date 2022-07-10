using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YellowSphere : Sphere
{
    //inheritence
    public override void SpehereColor()
    {
        newColor = Color.yellow;
        base.SpehereColor();

    }
}
