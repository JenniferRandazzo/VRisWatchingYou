using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 5f;
    float timeLeft;
    public GameObject timesUpText;
    public bool looking;
    public GameObject teleport;
    AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
       
        timesUpText.SetActive(false);
        timerBar = GetComponent<Image> ();
        timeLeft = maxTime;

        audioData = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //audioData.Play(0);
        Debug.Log(looking);
        if (looking)
        {
            audioData.volume = 0f;
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                timerBar.fillAmount = timeLeft / maxTime;
                
            }
            else
            {
                timesUpText.SetActive(true);
                //Time.timeScale = 0;
                //teleport.SetActive(true);
                SceneManager.LoadScene("transitionScene");

            }
        }
        else if(!looking)
        {
            audioData.volume = 10f;
        }
    }
}
