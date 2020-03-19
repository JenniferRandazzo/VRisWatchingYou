using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class changeScene : MonoBehaviour
{
    //bool sphereActive;
    //private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("sphereTimer", 2, 2);
       // player = GameObject.FindWithTag("Player");
        //transform.position = new Vector3(player.transform.position.x - 0.1f, player.transform.position.y + 1, player.transform.position.z);
    }

    private void OnHandHoverBegin(Hand hand)
    {
        // if (handtype == RightHand) {}
        //Debug.Log("Hand type: " + handtype);
        hideObject();
        SceneManager.LoadScene("BookScene");
        //encouraging sound plays
        //plus points added

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
