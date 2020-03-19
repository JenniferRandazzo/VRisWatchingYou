using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playMathFinished : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("TV").GetComponent<Voice>().riddleFail = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
