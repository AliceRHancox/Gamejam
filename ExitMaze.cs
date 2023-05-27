using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exitmaze : MonoBehaviour

{
    public string SceneName;
    public string PortalTag2;



    // runs code when colliding with specific object
    void OnCollisionEnter(Collision collision)
    {
        //Loads specific scene
        if (collision.gameObject.tag == PortalTag2)
        {
            SceneManager.LoadScene(SceneName);

        }


    }
}
