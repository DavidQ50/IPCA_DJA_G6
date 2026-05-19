using UnityEngine;

public class GameManager : MonoBehaviour
{
<<<<<<< HEAD
    public enum GameMode { Normal, Infinito };
    public GameMode currentGameMode;
    int pontuacaoModoInfinito;
    GameObject[] spheres;
    public static GameManager Instance;
=======
    int pontuacaoModoInfinito;
    GameObject[] spheres;
    public static GameManager Instance;
    public Animator portalAnimator;
>>>>>>> parent of 3841e64a (portal)

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

<<<<<<< HEAD
    void Start()
    {
        if (currentGameMode == GameMode.Infinito)
        {
            pontuacaoModoInfinito = 0;
        }
    }
    
=======
>>>>>>> parent of 3841e64a (portal)
    void sphereCount()
    {
        spheres = GameObject.FindGameObjectsWithTag("Spheres");
        Debug.Log("Number of spheres: " + spheres.Length);
    }

    void openDoor()
    {
        int sphereCount = spheres.Length;

<<<<<<< HEAD
        if (sphereCount == 0) // Example condition, adjust as needed
        {
            Debug.Log("All spheres collected! Door opened.");
=======
        if (sphereCount == 0)
        {
            Debug.Log("All spheres collected! Portal opened.");
            
            
        
        
            




>>>>>>> parent of 3841e64a (portal)
        }
    }
    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        if (currentGameMode == GameMode.Infinito)
        {
           
        }
        else
        {
            sphereCount();
            openDoor();
        }
        
=======
        sphereCount();
        openDoor();
>>>>>>> parent of 3841e64a (portal)
    }
}
