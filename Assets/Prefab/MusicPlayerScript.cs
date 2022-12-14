using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayerScript : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource audioSource;
    public Slider slider;

    private float musicVolume = 0.5f; 


    void Start()
    {
        slider = FindObjectOfType<Slider>();
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        slider = FindObjectOfType<Slider>();
        audioSource.volume = musicVolume;
    }

    public void updateVolume ()
    {
        musicVolume = slider.value;

    }

}
