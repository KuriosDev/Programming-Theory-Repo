using TMPro;
using UnityEngine;

public class Cylinder : Shape // INHERITANCE
{

    void Update()
    {
        if (Color != rend.material.color)
        {
            rend.material.color = Color;        
        }
    }

    public void ChangeColorRandomly() // ABSTRACTION
    {
        Color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    public override void Jump() // POLYMORPHISM
    {
        rb.AddForce(Vector3.up * JumpSpeed, ForceMode.Impulse);
    }

    public override void DisplayText() // POLYMORPHISM
    {
        TextMeshProUGUI text = GameObject.Find("DisplayText").GetComponent<TextMeshProUGUI>();
        text.text = this.ToString();
    }

    public override string ToString() // POLYMORPHISM
    {
        string message = base.ToString();

        message += " I am a Cylinder!";

        return message; 
    }

    protected override void OnMouseDown() // POLYMORPHISM
    {
        ChangeColorRandomly();
        base.OnMouseDown();
    }
}