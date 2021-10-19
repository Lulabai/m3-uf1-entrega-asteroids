using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JarControl : MonoBehaviour
{

    public float rotSpeed = 180.0f, ySpeed = 1.0f;
    public float xLimit = 9.0f, yLimit = 4.0f;

    private float playerRot;
    private float xPos, yPos;

    public GameObject explosion;

    void Start()
    {
        playerRot = transform.eulerAngles.z;
    }

    void Update()
    {
        playerRot -= rotSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;

        transform.rotation = Quaternion.Euler(0.0f, 0.0f, playerRot);

        transform.position += Input.GetAxis("Vertical") * Time.deltaTime * ySpeed * transform.up;

        LimitsControl();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Juliaroid"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
    void LimitsControl()
    {
        xPos = transform.position.x;
        yPos = transform.position.y;

        if (xPos > xLimit) xPos = -xLimit;
        else if (xPos < -xLimit) xPos = xLimit;

        if (yPos > yLimit) yPos = -yLimit;
        else if (yPos < -yLimit) yPos = yLimit;

        transform.position = new Vector3(xPos, yPos, 0.0f);
    }
}