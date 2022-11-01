using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessPlayer : MonoBehaviour
{
    //float speed.
    public float Speed = 0.03f;

    //Float Position Player.
    float Pos = 0;

    //Float Position ball from the GetYpos script.
    float Posball = GetYpos.ypos;

    void Start()
    {
        //Put Paddle at 7.5 , 0 .
        transform.position = new Vector3(7.74f, 0);
    }


    void Update()
    {
        //Get the ypos every frame.
        Posball = GetYpos.ypos;

        //Make position player equal to the Y position.
        Pos = transform.position.y;

        //Make sure that pos tries to go to posball
        //Make sure Pos is Between -3.8 and 3.8 .
        if (Posball > Pos)
        {
            if (Pos < 3.8) { transform.position = new Vector3(7.74f, transform.position.y + Speed * 2); }
        }
        else if (Posball < Pos)
        {
            if (Pos > -3.8) { transform.position = new Vector3(7.74f, transform.position.y - Speed * 2); }
        }
    }
}
