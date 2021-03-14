using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public static Data Instance { get; private set; }

    public int lives;

    public int time;

    public float rotatorSpeed;

    public float pinSpeed;

    public string player_name;

    public float speed = 1f;

    public int score;

    public bool paused;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        Time.timeScale = Data.Instance.speed;
    }
}
