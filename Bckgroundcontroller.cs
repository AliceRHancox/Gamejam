using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bckgroundcontroller : MonoBehaviour
{
    public float player_y = 0;
    public SpriteRenderer background;
    public Sprite backgroundtop;
    public Sprite backgroundbottom;
    // Start is called before the first frame update
    void Start()
    {
        background.sprite=backgroundtop;
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (player_y < 0)
        {
            background.sprite = backgroundbottom;

        }
        
    }
}
