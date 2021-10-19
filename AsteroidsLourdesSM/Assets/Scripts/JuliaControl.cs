using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuliaControl : MonoBehaviour
{
    public float xSpeed, ySpeed;
    public float xLimit = 9.0f, yLimit = 4.0f;
    public bool asteroidBounce;
    private float xPos, yPos;

    public GameObject explosion;
    public int energy = 3;

    //19-10
    public bool createChildren;
    public int numberOfChildren;
    public GameObject theChildren;


    void Start()
    {
        //Posición inicial
        xPos = transform.position.x;
        yPos = transform.position.y;
    }

    void Update()
    {
        xPos += xSpeed * Time.deltaTime;
        yPos += ySpeed * Time.deltaTime;

        if (asteroidBounce) BounceControl();
        else LimitsControl();

        // Aplicamos la nueva posición
        transform.position = new Vector3(xPos, yPos, 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Cookie"))
        {
            energy--;

            if (energy <= 0)
            {
                for (int i = 0; i < numberOfChildren; i++)
                {
                    Instantiate(theChildren, transform.position, transform.rotation);
                }

                Instantiate(explosion, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
    }
    void LimitsControl()
    {
        if (xPos > xLimit) xPos = -xLimit;
        else if (xPos < -xLimit) xPos = xLimit;

        if (yPos > yLimit) yPos = -yLimit;
        else if (yPos < -yLimit) xPos = yLimit;
    }

    void BounceControl()
    {
        if (xPos > xLimit) xSpeed = -Mathf.Abs(xSpeed);
        if (xPos < -xLimit) xSpeed = Mathf.Abs(xSpeed);

        if (yPos > yLimit) ySpeed = -Mathf.Abs(ySpeed);
        if (yPos < -yLimit) ySpeed = Mathf.Abs(ySpeed);
    }

}
