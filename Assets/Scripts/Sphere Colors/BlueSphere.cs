using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSphere : Sphere
{
    //inheritence
    public override void SpehereColor()
    {
        newColor = Color.blue;
        base.SpehereColor();
    }
}
