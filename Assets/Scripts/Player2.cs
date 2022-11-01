using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    //float speed.
    public float Speed = 0.01f;

    //Float Position Player.
    float Pos = 0;

    void Start()
    {
        //Put Paddle at 7.5 , 0 .
        transform.position = new Vector3(7.5f, 0);
    }


    void Update()
    {
        //Make position player equal to the Y position.
        Pos = transform.position.y;

        //Make sure that you can move with Arrows.
        //Make sure Pos is Between -3.8 and 3.8 .
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (Pos < 3.8) { transform.position = new Vector3(7.5f, transform.position.y + Speed); }
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if (Pos > -3.8) { transform.position = new Vector3(7.5f, transform.position.y - Speed); }
        }
    }
}
