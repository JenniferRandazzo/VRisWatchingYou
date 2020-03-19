using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class SphereBottomLeftManager : MonoBehaviour
{
    private GameObject Player;
    public GameObject TopRightSphere;
    public GameObject BottomLeftSphere;
    public GameObject TopLeftSphere;
    public GameObject BottomRightSphere;

    bool currentSphereIsActive;
    bool timerStarted;
    bool alarmActive;
    float time = 5f;
    AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        transform.position = new Vector3(Player.transform.position.x + 0.4f, Player.transform.position.y, Player.transform.position.z);
        audioData = GetComponent<AudioSource>();

    }

    private void OnHandHoverBegin(Hand hand)
    {
        transform.gameObject.SetActive(false);
        TopLeftSphere.transform.gameObject.SetActive(true);
    }
    private void checkSphereStatus()
    {
        if (gameObject.activeSelf)
        {
            currentSphereIsActive = true;
            Debug.Log("Activation time - start the timer");
            timerStarted = true;


        }

        else
        {
            currentSphereIsActive = false;
            timerStarted = false;
            //stop timer
            //stop alarm
        }


    }
    private void startTimer()
    {

        time -= Time.deltaTime;
        Debug.Log(time);
        if (time < 0)
        {


            if (!alarmActive)
            {
                Debug.Log("alarm");
                audioData.Play();
                alarmActive = true;
            }

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (!currentSphereIsActive)
        {
            checkSphereStatus();
        }

        if (timerStarted)
        {
            startTimer();
        }
    }
}
