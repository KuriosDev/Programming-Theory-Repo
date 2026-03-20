using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    [SerializeField] Cube cubePrefab;
    [SerializeField] Sphere spherePrefab;
    [SerializeField] Cylinder cylinderPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
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

    public void CreateShapes()
    {
        Vector3 cubePosition = new Vector3(-4f, 0f, 0f);
        Cube cube = Instantiate(cubePrefab, cubePosition, cubePrefab.transform.rotation);
        cube.Name = "Tim Burton";
        cube.Color = Color.red;
        cube.JumpSpeed = 5f;
        cube.JumpSpeedModifier = 1f;
        
    }
}
