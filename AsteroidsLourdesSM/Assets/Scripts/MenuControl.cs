using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public int firstLevel = 1;

    void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene(firstLevel);
        }
    }
}
