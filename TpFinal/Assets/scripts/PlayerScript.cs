using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Gyroscope = UnityEngine.InputSystem.Gyroscope;
public class PlayerScript : MonoBehaviour
{
    float aceleracion;
    float puntaje;
    float direccion;
   
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        InputSystem.EnableDevice(Gyroscope.current);

    }

    // Update is called once per frame
    void Update()
    {
       
        
        Debug.Log(rb.velocity);
        transform.Rotate(0, Input.acceleration.x *1.4f, 0);

    }
    public void PerderPuntaje(float perdida) 
    {
        puntaje -=perdida ;
    }
}
