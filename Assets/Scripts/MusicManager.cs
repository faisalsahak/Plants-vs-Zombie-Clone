using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
	public AudioClip[] levelMusicChangeArray;
	private AudioSource audioSource;

	void Awake(){
		DontDestroyOnLoad(gameObject);

	}
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnLevelWasLoaded(int level){
    	AudioClip thisLevelMusic = levelMusicChangeArray[level];
    	if(thisLevelMusic){
    		audioSource.clip = thisLevelMusic;
    		audioSource.loop = true;
    		audioSource.Play();
    	}
    }
}
