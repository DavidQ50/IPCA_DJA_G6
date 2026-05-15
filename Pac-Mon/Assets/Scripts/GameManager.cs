using UnityEngine;

public class GameManager : MonoBehaviour
{
    int pontuacaoModoInfinito;
    GameObject[] spheres;
    public static GameManager Instance;
    public Animator portalAnimator;

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

    void sphereCount()
    {
        spheres = GameObject.FindGameObjectsWithTag("Spheres");
        Debug.Log("Number of spheres: " + spheres.Length);
    }

    void openDoor()
    {
        int sphereCount = spheres.Length;

        if (sphereCount == 0)
        {
            Debug.Log("All spheres collected! Portal opened.");
            
            
        
        
            




        }
    }
    // Update is called once per frame
    void Update()
    {
        sphereCount();
        openDoor();
    }
}
