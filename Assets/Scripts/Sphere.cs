using UnityEngine;
using UnityEngine.UI;

public class Sphere : MonoBehaviour
{
    public Color newColor;
    public Text text;
    public string textString;

    private void Start()
    {
        SpehereColor();
    }
    public virtual void SpehereColor()
    {
        if (transform.childCount == 3)
        {

        }
        else
        {
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", newColor);
        }
    }

    private void OnMouseDown()
    {
        text.color = newColor;
        text.text = textString;
    }
}
