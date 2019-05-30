﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
	public Slider volumeSlider, diffSlider;
	public LevelManager levelManager;

	private MusicManager musicManager;
    // Start is called before the first frame update
    void Start()
    {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
    	diffSlider.value = PlayerPrefsManager.GetDifficulty();
    }

    // Update is called once per frame
    void Update()
    {
        musicManager.ChangeVolume(volumeSlider.value);
    }

    public void SaveAndExit(){
    	PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
    	PlayerPrefsManager.SetDifficulty(diffSlider.value);
    	levelManager.LoadLevel("01a Start");
    }

    public void SetDefualts(){
    	volumeSlider.value = 0.8f;
    	diffSlider.value = 2f;
    }
}
