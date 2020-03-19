using UnityEngine.Audio;
using UnityEngine;

public class RiddleManager : MonoBehaviour
{
    float randomTime;
    float timeCounter = 0.0f;

    public Sound[] sounds; 
    
    // Start is called before the first frame update
    void Awake()
    {
        //s is the sound we are currently looking at
        //we add a audiosource component from our gameobject (AdioManager)
        //and set the clip attribute of audiosource equal to the specific sound clip defined in sound class
        foreach (Sound s in sounds)
        {
        s.source = gameObject.AddComponent<AudioSource>();
        s.source.clip = s.clip;
        s.source.panStereo = s.panStereo;
        }    
        
    }
    
    void Start() {
       // sounds[0].source.Play();
    randomTime = Random.Range(5.0f, 15.0f);

    }

    // Update is called once per frame
    void Update()
    {

        if(timeCounter  > randomTime)
        {
        randomTime = Random.Range(15.0f, 40.0f);
        timeCounter = 0.0f;
        ChooseSound();
     }
          timeCounter += Time.deltaTime;

    }


//it's public so we can call it outside class
 void ChooseSound() 
{
    var randomSound = Random.Range(0,3);
    sounds[randomSound].source.Stop();
    Debug.Log("random: " + randomSound);
    sounds[randomSound].source.Play();
}
}

[System.Serializable]
public class Sound {
public string name;
public float panStereo;
public AudioClip clip;

[HideInInspector] //an audiosource we can call from AudioManager
public AudioSource source;


}
