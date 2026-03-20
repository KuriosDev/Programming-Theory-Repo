using TMPro;
using UnityEngine;

public class Sphere : Shape // INHERITANCE
{
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

        message += " I am a Sphere!";

        return message;
    }
}