using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Speed of the ball.
    public float Speed = 0;


    void Start()
    {
        //Movement and bouncec for the ball .
        GetComponent<Rigidbody2D>().velocity = new Vector2(5 + Speed, 5 + Speed);
    }
}
