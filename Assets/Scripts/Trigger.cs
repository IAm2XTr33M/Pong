using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{
    //Valuables For the Scores.
    public int Left;
    public int right;

    //Public text where you can link the text to in unity.
    public Text ScoreLeft;
    public Text Scoreright;

    void Start()
    {
        //Resets the Scores to 0 at start.
        ScoreLeft.text = "0";
        Scoreright.text = "0";
    }


    void Update()
    {
        //Makes sure yhe Text in unity is linked to the int valuables each frame.
        ScoreLeft.text = Left.ToString();
        Scoreright.text = right.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Checks if the Tag of the trigger is Left or Right.
        //Adds 1 Point to the int valuable.
        //Makes sure the ball Goes back to 0, 0.

        if (collision.CompareTag("Left"))
        {
            right = right + 1;
            transform.position = new Vector3(0, 0);
        }
        if (collision.CompareTag("Right"))
        {
            Left = Left + 1;
            transform.position = new Vector3(0, 0);
        }
    }
}
