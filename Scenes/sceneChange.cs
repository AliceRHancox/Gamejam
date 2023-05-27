using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class sceneChange : MonoBehaviour
{
    public string SceneName;
    public string PortalTag;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(PortalTag))
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}