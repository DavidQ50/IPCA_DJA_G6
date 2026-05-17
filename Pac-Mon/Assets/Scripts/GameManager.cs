using UnityEngine;

namespace game
{
    public class GameManager : MonoBehaviour
    {
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

        

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
