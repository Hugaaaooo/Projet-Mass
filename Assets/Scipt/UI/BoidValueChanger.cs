using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoidValueChanger : MonoBehaviour
{
    public Slider[] slider;
    public Spawnerr spawn;



    private void Start()
    {
        slider[0].value = 100;
        spawn = FindObjectOfType<Spawnerr>();
    }

    private void Update()
    {
        spawn.spawnBoids = (int)slider[0].value;

      
    }
}