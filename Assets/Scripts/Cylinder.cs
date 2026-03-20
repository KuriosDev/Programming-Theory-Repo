using TMPro;
using UnityEngine;

public class Cylinder : Shape // INHERITANCE
{

    protected override void OnUpdate() // POLYMORPHISM
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

    public override string ToString() // POLYMORPHISM
    {
        string message = base.ToString();

        message += " I am a Cylinder! When you click on me, I change color.";

        return message; 
    }

    protected override void OnMouseDown() // POLYMORPHISM
    {
        ChangeColorRandomly();
        MainManager.Instance.PlayMusic(1f);
        base.OnMouseDown();
    }
}