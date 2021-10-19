using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonControl : MonoBehaviour
{
    public GameObject theCookie;
    void Start()
    {

    }
    void Update()
    {
        // Cuando el jugador pulse el botón de disparo, creamos una bala en la posición y rotación del cañón
        if (Input.GetButtonDown("Fire1"))
        {
            // Creamos bala con Instantiate public static Object Instantiate(Object original, Vector3 position, Quaternion rotation);
            Instantiate(theCookie, transform.position, transform.rotation);
        }
    }
}
