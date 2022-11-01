using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetYpos : MonoBehaviour
{
    public static float ypos = 0;

    // Start is called before the first frame update
    void Start()
    {
        print(ypos);
    }

    // Update is called once per frame
    void Update()
    {
        ypos = transform.position.y;
    }
}
