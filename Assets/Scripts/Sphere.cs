using UnityEngine;

public class Sphere : Shape // INHERITANCE
{
    private float minScale = 0.5f;
    private float maxScale = 2f;

    float elapsedTime;

    protected override void OnStart() // POLYMORPHISM
    {
        base.OnStart();
        elapsedTime = 0;
    }

    protected override void OnUpdate() // POLYMORPHISM
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= 1f)
        {
            ChangeSizeRandomly();
            elapsedTime = 0;
        }
    }

    public override void Jump() // POLYMORPHISM
    {
        rb.AddForce(Vector3.up * JumpSpeed, ForceMode.Impulse);
    }

    public override string ToString() // POLYMORPHISM
    {
        string message = base.ToString();

        message += " I am a Sphere! I change size every second.";

        return message;
    }

    private void ChangeSizeRandomly() // ABSTRACTION
    {
        float scaleValue = Random.Range(minScale, maxScale);
        transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);
    }

    protected override void OnMouseDown() // POLYMORPHISM
    {
        MainManager.Instance.PlayMusic(0.2f);
        base.OnMouseDown();
    }
}