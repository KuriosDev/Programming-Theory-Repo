using TMPro;
using UnityEngine;

public class Cube : Shape // INHERITANCE
{
    private float _jumpSpeedModifier = 1f;
    public float JumpSpeedModifier // ENCAPSULATION
    {
        get
        {
            return _jumpSpeedModifier;
        }
        set
        {
            if (value > 0 || value <= 5)
            {
                _jumpSpeedModifier = value;
            }
            else
            {
                _jumpSpeedModifier = 1;
            }
        }
    }

    public override void Jump() // POLYMORPHISM
    {
        rb.AddForce(Vector3.up * JumpSpeed * _jumpSpeedModifier, ForceMode.Impulse);
    }

    public override string ToString() // POLYMORPHISM
    {
        string message = base.ToString();
        
        message += $" I am a Cube. I have a jump speed modifier ({JumpSpeedModifier * 100}%).";

        return message;
    }

    protected override void OnMouseDown() // POLYMORPHISM
    {
        MainManager.Instance.PlayMusic();
        base.OnMouseDown();
    }
}