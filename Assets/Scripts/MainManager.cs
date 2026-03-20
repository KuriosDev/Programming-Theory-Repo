using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    [SerializeField] Cube cubePrefab;
    [SerializeField] Sphere spherePrefab;
    [SerializeField] Cylinder cylinderPrefab;

    [SerializeField] Button createButton;
    [SerializeField] TextMeshProUGUI messageText;
    [SerializeField] AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCreateClick()
    {
        createButton.gameObject.SetActive(false);
        CreateShapes(); // ABSTRACTION
    }

    public void DisplayMessage(string message)
    {
        messageText.text = message;
    }

    private void CreateShapes() // ABSTRACTION
    {
        Cube cube = Instantiate(cubePrefab);
        float height = cube.GetComponent<Renderer>().bounds.size.y;
        cube.transform.SetPositionAndRotation(new Vector3(-3f, height / 2f, 0f), cubePrefab.transform.rotation);
        
        cube.Name = "Tim Burton";
        cube.Color = Color.blueViolet;
        cube.JumpSpeed = 5f;
        cube.JumpSpeedModifier = 1.6f;

        Cylinder cylinder = Instantiate(cylinderPrefab);
        height = cylinder.GetComponent<Renderer>().bounds.size.y;
        cylinder.transform.SetPositionAndRotation(new Vector3(0f, height / 2f, 0f), cylinderPrefab.transform.rotation);

        cylinder.Name = "Will Smith";
        cylinder.Color = Color.green;
        cylinder.JumpSpeed = 8f;

        Sphere sphere = Instantiate(spherePrefab);
        height = sphere.GetComponent<Renderer>().bounds.size.y;
        sphere.transform.SetPositionAndRotation(new Vector3(3f, height / 2f, 0f), spherePrefab.transform.rotation);
        
        sphere.Name = "Angelina Jolie";
        sphere.Color = Color.pink;
        sphere.JumpSpeed = 6f;
    }

    public void PlayMusic() // COMPILE-TIME POLYMORPHISM
    {
        audioSource.Play();
    }

    public void PlayMusic(float volume) // COMPILE-TIME POLYMORPHISM
    {
        audioSource.volume = volume;
        audioSource.Play();
    }
}
