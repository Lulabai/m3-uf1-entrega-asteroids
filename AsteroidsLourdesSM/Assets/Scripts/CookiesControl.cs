using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookiesControl : MonoBehaviour
{

    public float cookieSpeed = 10.0f;
    void Start()
    {

    }
    void Update()
    {
        transform.position += cookieSpeed * Time.deltaTime * transform.up;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Juliaroid")) Destroy(gameObject);
    }
}
