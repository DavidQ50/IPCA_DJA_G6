using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GameMode { Normal, Infinito };
    public GameMode currentGameMode;
    int pontuacaoModoInfinito;
    GameObject[] spheres;
    public static GameManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        if (currentGameMode == GameMode.Infinito)
        {
            pontuacaoModoInfinito = 0;
        }
    }
    
    void sphereCount()
    {
        spheres = GameObject.FindGameObjectsWithTag("Spheres");
        Debug.Log("Number of spheres: " + spheres.Length);
    }

    void openDoor()
    {
        int sphereCount = spheres.Length;

        if (sphereCount == 0) // Example condition, adjust as needed
        {
            Debug.Log("All spheres collected! Door opened.");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (currentGameMode == GameMode.Infinito)
        {
           
        }
        else
        {
            sphereCount();
            openDoor();
        }
        
    }
}
