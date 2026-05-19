using UnityEngine;
using System.Collections;


public class esferaScript : MonoBehaviour
{
    void Start()
    {
        spawnSpheres();
    }
    void spawnSpheres()
    {
    }
    
    void Update()
    {
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
