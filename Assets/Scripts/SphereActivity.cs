using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;


public class SphereActivity : MonoBehaviour
{
    float timeLeft = 4f;
    bool alarmActive;
    bool topRightSphereActive;
    bool topLeftSphereActive;
    bool bottomRightSphereActive;
    bool bottomLeftSphereActive;
    bool timerIsOn;
    private GameObject Player;
    private GameObject TopRightSphere;
    private GameObject TopLeftSphere;
    private GameObject BottomRightSphere;
    private GameObject BottomLeftSphere;
    // Start is called before the first frame update
    void Start()
    {
        TopRightSphere = GameObject.FindWithTag("SphereTopRight");
        TopLeftSphere = GameObject.FindWithTag("SphereTopLeft");
        BottomRightSphere = GameObject.FindWithTag("SphereBottomRight");
        BottomLeftSphere = GameObject.FindWithTag("SphereBottomLeft");
        Player = GameObject.FindWithTag("Player");
        StartExcersises();
        //InvokeRepeating("sphereTimer", 2, 2);
        //transform.position = new Vector3 (Player.transform.position.x-0.1f, Player.transform.position.y+1, Player.transform.position.z);
    }

    private void OnHandHoverBegin(Hand hand)
    {
        //hideObject();
    }

    private void hideObject()
    {
        transform.gameObject.SetActive(false);
        topRightSphereActive = false;
    }

    private void showObject(GameObject objectToShow)
    {
        transform.gameObject.SetActive(true);
        topRightSphereActive = true;
    }

    //private void sphereTimer()
    //{
    //    //Debug.Log("Two seconds have passed");
    //    if (sphereActive)
    //    {
    //        hideObject();
    //        //alarm rings!
    //    }
    //    else
    //    {
    //        showObject();
    //    }
    //}

    private void StartExcersises() {
        // start timer
        timerIsOn = true;
    }


    private void SphereTimer()
    {
        timeLeft -= Time.deltaTime;
        //Debug.Log(timeLeft);
        if (timeLeft < 0)
        {
            Debug.Log("TIMEOUT");
            timeLeft = 4f;
            //sphereShowHide();

        }

    }

    private void alarmRinging() {
        if (alarmActive) {

        }

    }

    // Update is called once per frame
    void Update()
    {
        if(timerIsOn) {
           SphereTimer();
        }
        
    }



}

// the topRightphere shown and others hidden
// if touched {LowerLeftSphere = active + topRightphere = disabled}




// if X seconds have passed {ring the alarm}
// if player touches the top sphere {alarm stop + top spheres disappear + bottom ones appear}
// if X seconds have passed {ring the alarm}
// if player touches the lower spheres {alarm stop + top spheres disappear + bottom ones appear}
