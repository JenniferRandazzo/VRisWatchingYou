using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playCompletedReading : MonoBehaviour
{
    bool readingCompfflete;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("TV").GetComponent<Voice>().bookFail = true;
        GameObject.FindGameObjectWithTag("TV").GetComponent<Voice>().entryScene2 = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
