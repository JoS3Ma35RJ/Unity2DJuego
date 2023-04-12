using UnityEngine;

// Este código se encarga de no destruir el objeto al que está adjunto al cambiar de escenas
public class DontDestroy : MonoBehaviour
{
    private static DontDestroy instance;

    void Awake()
     {
         if (instance != null && instance != this)
             Destroy(this.gameObject);
         else
         {
             instance = this;
             DontDestroyOnLoad(this.gameObject);
         }
     }
}