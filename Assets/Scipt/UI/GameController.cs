using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Slider[] slider;
    public Gun gun;



    private void Start()
    {
        slider[0].value = 1;

        slider[1].value = 12;

        slider[2].value = 30;

        slider[3].value = 1;

        slider[4].value = 4;

        gun = FindObjectOfType<Gun>();
    }

    private void Update()
    {
        gun.reloadTime = slider[0].value;

        gun.ammunition = (int)slider[1].value;

        gun.roundSpeed = slider[2].value;

        gun.maxRoundVariation = slider[3].value;

        gun.fireRate = slider[4].value;
    }
}