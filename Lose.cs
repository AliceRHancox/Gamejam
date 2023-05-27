using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    public string SceneName;
    public string Lost;



    // runs code when colliding with specific object
    void OnCollisionEnter(Collision collision)
    {
        //Loads specific scene
        if (collision.gameObject.tag == Lost)
        {
            SceneManager.LoadScene(SceneName);

        }


    }
}


