using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoveCounterScript : MonoBehaviour
{
    private int count;
    private bool paused;
    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        paused = false;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = count.ToString();
    }

    public void OnSlide()
    {
        if(!paused)
        {
            count++;
        }
    }

    public void OnRestart()
    {
        count = 0;
    }

    public void OnPause()
    {
        paused = !paused;
    }
}
