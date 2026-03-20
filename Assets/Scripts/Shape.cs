using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public abstract class Shape : MonoBehaviour
{
    private string _name;
    private Color _color;
    
    public string Name //ENCAPSULATION
    { 
        get => _name;
        set 
        {
            _name = value?.Substring(0, 10);
        } 
    } 
    public Color Color  //ENCAPSULATION
    { 
        get => _color; 
        set => _color = value;
    }

    private float _jumpSpeed = 2;

    public float JumpSpeed  //ENCAPSULATION
    {
        get
        {
            return _jumpSpeed;
        }

        set
        {
            if (value >= 2 || value <= 10)
            {
                _jumpSpeed = value;
            }
            else
            {
                Debug.Log("The value of JumpSpeed must be between 2 and 10. Default: 2.");
                _jumpSpeed = 2;
            }
        }
    }

    protected Rigidbody rb;
    protected Renderer rend;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OnStart();
    }

    protected virtual void OnStart()
    {
        InitializeShape(); // ABSTRACTION
    }

    // Update is called once per frame
    void Update()
    {
        OnUpdate();
    }

    protected virtual void OnUpdate(){}

    public abstract void Jump();

    public void DisplayText()
    {
        MainManager.Instance.DisplayMessage(this.ToString());
    }

    public override string ToString() // POLYMORPHISM
    {
        return $"My name is {Name}.";
    }

    private void InitializeShape() // ABSTRACTION
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.Log("Error: Object without a Ribigbody!");
        }

        rend = GetComponent<Renderer>();

        rend.material.color = Color;
    }

    protected virtual void OnMouseDown()
    {
        DisplayText();
        Jump();
    }
}