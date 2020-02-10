using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPaleta : MonoBehaviour
{
    // Start is called before the first frame update
    public float velX = 0.1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //Obtenemos -1 si se pulsa flecha izquierda y 1 si se pulsa flecha derecha
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        //Cálculo de la posición en el ejeX después de la pulsación de la tecla
        //Time.deltaTime independiza el movimiento del fotograma. 
        //Calcula el tiempo que tarda el fotograma en ejecutarse
        float posX = transform.position.x + (movimientoHorizontal * velX * Time.deltaTime);
        //Actualizamos la posición de la barra
        transform.position = new Vector3(posX, transform.position.y,transform.position.z);


    }


}
