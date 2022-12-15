using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Slider = UnityEngine.UI.Slider;

public class BoidValueChanger : MonoBehaviour
{
    public static Slider[] slider;




    private void Start()
    {


    }

    public static class SaveStuff
    {
        public static float optionScore;
    }


    private void Update()
    {
        


        SaveStuff.optionScore = slider[0].value; // saving data
        slider[0].value = SaveStuff.optionScore; // load stuff

    }
}