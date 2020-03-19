using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClosing : MonoBehaviour
{

    bool DoorClosed;
    GameObject DoorWrapper;
    GameObject DoorWithFrame;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        DoorWithFrame = GameObject.FindGameObjectWithTag("Door");
        DoorWrapper = GameObject.FindGameObjectWithTag("DoorParent");
        audioSource = DoorWithFrame.GetComponent<AudioSource>();
    }

    private void DoorClosingEvent()
    {
            DoorWrapper.transform.Rotate(0.0f, 0.0f, 0.0f, Space.World);
            audioSource.PlayOneShot(audioSource.clip, 0.5f);
            DoorClosed = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger");
        if (!DoorClosed)
        {
            DoorClosingEvent();
        }
    }
}
