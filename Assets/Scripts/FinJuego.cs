using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinJuego : MonoBehaviour
{
    public GameObject palas;
    public MoverPaleta pala;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnTriggerEnter2D(Collider2D elOtro){
        
        if(elOtro.tag == "bola"){
            
            Destroy(GameObject.Find("ball_1"));
            pala.velX = 0f;
        }
  
    }
}
