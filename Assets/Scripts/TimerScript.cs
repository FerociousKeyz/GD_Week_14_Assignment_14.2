using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class TimerScript : MonoBehaviour
{
    private bool paused;
    private float currentTime;
    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        currentTime = 0;
        paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!paused)
        {
            currentTime += Time.deltaTime;
        }

        TimeSpan time = TimeSpan.FromSeconds(currentTime);

        text.text = time.Minutes.ToString() + ":" + time.Seconds.ToString("00");
    }

    public void OnRestart()
    {
        currentTime = 0;
    }

    public void OnPause()
    {
        paused = !paused;
    }
}
