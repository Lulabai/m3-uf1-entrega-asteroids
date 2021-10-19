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
        // Cuando el jugador pulse el bot�n de disparo, creamos una bala en la posici�n y rotaci�n del ca��n
        if (Input.GetButtonDown("Fire1"))
        {
            // Creamos bala con Instantiate public static Object Instantiate(Object original, Vector3 position, Quaternion rotation);
            Instantiate(theCookie, transform.position, transform.rotation);
        }
    }
}
