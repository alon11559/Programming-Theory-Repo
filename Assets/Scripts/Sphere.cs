using UnityEngine;
using UnityEngine.UI;

public class Sphere : MonoBehaviour
{
    //encapsulation
    protected Color newColor;
    [SerializeField] private Text text;
    [SerializeField] private string textString;

    //abstraction
    private void Start()
    {
        SpehereColor();
    }

    //inheritence
    public virtual void SpehereColor()
    {
        if (transform.childCount == 3){}
        else
        {
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", newColor);
        }
    }

    //polymorphism
    //abstraction
    private void OnMouseDown()
    {
        text.color = newColor;
        text.text = textString;
    }
}
