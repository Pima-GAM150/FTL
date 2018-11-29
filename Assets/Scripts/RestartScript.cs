using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

            //Application.LoadLevel is depreciated; use the scene manager function that you get from 'using SceneManager'
            
            //You can see there are a few overloads for this function; you can pass a string (name) or number for the scene.
            SceneManager.LoadScene(0);
        }
    }
}
