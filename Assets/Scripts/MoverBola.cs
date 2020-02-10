using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBola : MonoBehaviour
{
    public float vel = 0f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(vel, vel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
