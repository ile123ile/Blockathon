using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public GameObject textObject;
    private TextMeshProUGUI text;
    public static float timeElapsed;

    // Start is called before the first frame update
    void Start()
    {
        ResetTimer();
        text = textObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeElapsed += Time.fixedDeltaTime;
        int seconds = Mathf.FloorToInt(timeElapsed) & 60;
        int minutes = Mathf.FloorToInt(timeElapsed - seconds);
        string timeString = minutes + ":";
        if (seconds < 10)
        {
            timeString += "0";
        }
        timeString += seconds;
        text.text = timeString;
        
    }

    public void ResetTimer()
    {
        timeElapsed = 0;
    }

    public void DecreaseTime(float seconds)
    {
        timeElapsed -= seconds;
    }
}
