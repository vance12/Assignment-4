using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    DateTime lastTick;
    TimeSpan tickInterval;

    public Text timeRemaining;

    private void Update()
    {
        if (!Data.Instance.paused) 
        {
            tickInterval = DateTime.Now - lastTick;
            if (tickInterval.Seconds > 1 && Data.Instance.time != 0)
            {
                Data.Instance.time--;
                lastTick = DateTime.Now;
            }
            if (Data.Instance.time == 0)
            {
                SceneManager.LoadScene("End");
            }
            timeRemaining.text = Data.Instance.time.ToString();
        }
        
    }
}
