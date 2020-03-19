using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class SphereTopRightManager : MonoBehaviour
{
    bool currentSphereIsActive;
    bool timerStarted;
    bool alarmActive;
    float time = 5f;
    AudioSource audioData;
    private GameObject Player;
    public GameObject TopRightSphere;
    public GameObject BottomLeftSphere;
    public GameObject TopLeftSphere;
    public GameObject BottomRightSphere;

   
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        transform.position = new Vector3(Player.transform.position.x - 0.4f, Player.transform.position.y + 2f, Player.transform.position.z);

        BottomLeftSphere.transform.gameObject.SetActive(false);
        TopLeftSphere.transform.gameObject.SetActive(false);
        BottomRightSphere.transform.gameObject.SetActive(false);
        //set the timer
        audioData = GetComponent<AudioSource>();

    }

    private void OnHandHoverBegin(Hand hand)
    {
        transform.gameObject.SetActive(false);
        BottomLeftSphere.transform.gameObject.SetActive(true);
        currentSphereIsActive = false;
        Debug.Log("touched");
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
            if(time<0)
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

            if(timerStarted)
            {
            startTimer();
            }

        }

}
