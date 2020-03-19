using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playExercisesSounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("TV").GetComponent<Voice>().riddleFail = true;
        GameObject.FindGameObjectWithTag("TV").GetComponent<Voice>().entryScene3 = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
