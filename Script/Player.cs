using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int Vida=100;
    private bool PuedeSaltar=true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        VivoMuerto();
        if(Input.GetKey(KeyCode.D)){
            gameObject.GetComponent<SpriteRenderer>().flipX=false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(40f,0,0));
        }
         if(Input.GetKey(KeyCode.A)){
            gameObject.GetComponent<SpriteRenderer>().flipX=true;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(-40f,0,0));
        }
         if(Input.GetKeyDown(KeyCode.Space) && PuedeSaltar){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0,4500f,0));
            PuedeSaltar=false;
        }
    }
   //Getters And Setters
   public void SetPuedeSaltar(bool P){
       this.PuedeSaltar=P;
   }   
   
   //Metodos
    private void VivoMuerto(){
        if(Vida<=0){
            Debug.Log("Estas Muerto");
            Destroy(gameObject);
        }
    }
}
