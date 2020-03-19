using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class Voice : MonoBehaviour
{
        public bool bookFail = false;
        public bool riddleFail = false;
        public bool exerciseFail = false;

        public bool entryScene1 = true;
        public bool entryScene2 = false;
        public bool entryScene3 = false;

    //instantiate an array of voice commands
    public Command[] commands; 

    // Start is called before the first frame update
    void Awake() //so we can see elements in inspector before we press start 
    {
        foreach (Command c in commands)
        {
        c.source = gameObject.AddComponent<AudioSource>();
        c.source.clip = c.clip;
        c.source.spatialBlend = c.spatialBlend;
        }  
    }

    void Start() {
   
    }

    // Update is called once per frame
    void Update()
    {
        //array in inspector does not count from 0.

        if(bookFail == true)
        {
            commands[0].source.Play();
            Debug.Log("BOOKFAIL");

        }
        if(riddleFail == true)
        {   
            commands[1].source.Play();
            Debug.Log("RIDDLEFAIL");  
        }
        if(exerciseFail == true)
        {
            commands[2].source.Play();
            Debug.Log("EXERCISEFAIL");
        }

                if (entryScene1 == true) 
        {
            // commands[3].source.Play();
            StartCoroutine(playBookSoundAfterTenSeconds());
        }

                if (entryScene2 == true) 
        {
            //commands[4].source.Play();
            StartCoroutine(playExerciseSoundAfterTenSeconds());

        }

                if (entryScene3 == true) 
        {
            //commands[5].source.Play();
            StartCoroutine(playMathSoundAfterTenSeconds());

        }

        bookFail = false;
        riddleFail = false;
        exerciseFail = false;
        entryScene1 = false;
        entryScene2 = false;
        entryScene3 = false;
        
    }
    IEnumerator playBookSoundAfterTenSeconds()
    {
        yield return new WaitForSeconds(10);
        commands[3].source.Play();
    }
    IEnumerator playExerciseSoundAfterTenSeconds()
    {
        yield return new WaitForSeconds(10);
        commands[4].source.Play();
    }
    IEnumerator playMathSoundAfterTenSeconds()
    {
        yield return new WaitForSeconds(5);
        commands[5].source.Play();
    }
}

[System.Serializable] //so it shows in the inspector window
public class Command {

public string name;
public float spatialBlend;
public AudioClip clip;


[HideInInspector] //an audiosource we can call from AudioManager
public AudioSource source;
}


