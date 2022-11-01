using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerEndless : MonoBehaviour
{
    //Valuables For the Scores.
    public int ScoreInt;

    public int RDM;

    //Public text where you can link the text to in unity.
    public Text Score;

    void Start()
    {
        //Resets the Scores to 0 at start.
        Score.text = "0";
    }


    void Update()
    {

        RDM = Random.Range(1, 10);

        //Makes sure yhe Text in unity is linked to the int valuables each frame.
        Score.text = ScoreInt.ToString();
        if (RDM == 1)
        { 
            ScoreInt = ScoreInt + 1; 
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreInt = 0;
        transform.position = new Vector3(0, 0);
    }
}
