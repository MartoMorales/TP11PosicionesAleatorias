using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int Mov = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Mov <1 && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-2, 0, 0);
            Mov++;
        }
        if(Mov> -1 && Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(2, 0, 0);
            Mov--;
        }
        if(Mov == 1 && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(0,0,0);
        }
        if(Mov == -1 && Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(0,0,0);
        }
    }
}
