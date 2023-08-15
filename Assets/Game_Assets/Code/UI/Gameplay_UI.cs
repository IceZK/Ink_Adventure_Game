using Assets.Game_Assets.Code.Singleton;
using IceZK_DEV;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameplay_UI : MonoBehaviour
{
    public GameObject InkTemp_slider_UI;
    public Slider Ink_slider;
    public Slider InkTemp_slider;
    public Slider Curse_slider;
    public Button Bag_button;
    public Button pause_button;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ink_slider.value = Character_Status_Manager.player_baseInk;
       
        InkTemp_slider.value = Character_Status_Manager.player_InkTemp;
        Curse_slider.value = GameManager.curse;
        if (InkTemp_slider.value >= 1)
        {
            InkTemp_slider_UI.SetActive(true);
        }
        else
        {
            InkTemp_slider_UI.SetActive(false);
        }
    }
}
