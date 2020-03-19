using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;


public class math : MonoBehaviour
{
 public   AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnHandHoverBegin(Hand hand)
    {
        Debug.Log("4");
        audioData.Play();
    }

    private void OnHandHoverEnd(Hand hand)
    {
       // audioData.volume = 0f;
    }
}
