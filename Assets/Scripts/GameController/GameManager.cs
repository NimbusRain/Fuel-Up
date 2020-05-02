using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public float objectsDestroyed = 0f;


    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Military target") == null)
        {
            objectsDestroyed = +1;
        }

        if (GameObject.Find("Military target (1)") == null)
        {
            objectsDestroyed = + 1;
        }

        if (GameObject.Find("Military target (2)") == null)
        {
            objectsDestroyed = + 1;
        }

    }
}
