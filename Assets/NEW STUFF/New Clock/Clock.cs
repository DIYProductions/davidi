using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clock : MonoBehaviour
{
    float currentTime = 0f, startingTime = 180f;
    public TextMeshProUGUI timer;
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        timer.text = currentTime.ToString("0") /*+ " sec"*/;

        if (currentTime <= 0) currentTime = 0;
    }
}
