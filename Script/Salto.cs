using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OnTriggerEnter2D(gameObject.GetComponent<Collider2D>());
    }
     private void OnTriggerEnter2D(Collider2D c){
        if(c.CompareTag("Suelo")){
           gameObject.transform.parent.GetComponent<Player>().SetPuedeSaltar(true);
        }
    }
}
