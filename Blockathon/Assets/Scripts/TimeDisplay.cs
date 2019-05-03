﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeDisplay : MonoBehaviour
{
    public GameObject textObject;
    private float timeElapsed;
    private TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        text = textObject.GetComponent<TextMeshProUGUI>();
        timeElapsed = Timer.timeElapsed;
        int minutes = Mathf.FloorToInt(timeElapsed) / 60;
        int seconds = Mathf.FloorToInt(timeElapsed - minutes);
        string timeString = minutes + ":";
        if (seconds < 10)
        {
            timeString += "0";
        }
        timeString += seconds;
        text.text = timeString;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
