using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public Dropdown Lives;

    public Dropdown Time;

    public Slider RotatorSpeed;

    public Slider PinSpeed;

    public InputField Player_name;

    public void SetData()
    {
        Data.Instance.rotatorSpeed = RotatorSpeed.value;
        Data.Instance.pinSpeed = PinSpeed.value;
        Data.Instance.player_name = Player_name.text;
        if (Lives.value == 0)
        {
            Data.Instance.lives = 3;
        }
        if (Lives.value == 1)
        {
            Data.Instance.lives = 2;
        }
        if (Lives.value == 2)
        {
            Data.Instance.lives = 1;
        }

        if (Time.value == 0)
        {
            Data.Instance.time = 30;
        }
        if (Time.value == 1)
        {
            Data.Instance.time = 60;
        }
        if (Time.value == 2)
        {
            Data.Instance.time = 90;
        }

    }
}

