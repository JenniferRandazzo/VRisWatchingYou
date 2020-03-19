using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class OpenDoor : MonoBehaviour
{
    bool doorActivated = false;
    GameObject DoorWrapper;
    AudioSource audioSource;
    void Start()
    {
        DoorWrapper = transform.GetChild(0).gameObject;
        audioSource = GetComponent<AudioSource>();
        DoorOpenning();
    }

    private void OnHandHoverBegin(Hand hand)
    {
        //DoorOpenning();
    }

    private void DoorOpenning() {
        if (!doorActivated)
        {
           DoorWrapper.transform.Rotate(0.0f, 92.84701f, 0.0f, Space.World);
           audioSource.PlayOneShot(audioSource.clip, 0.5f);
           doorActivated = true;
        }
    }



    private void hideObject()
    {
        transform.gameObject.SetActive(false);

    }

    private void showObject()
    {
        transform.gameObject.SetActive(true);

    }


    void Update()
    {

    }
}
